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

    #region Code: HS
    [CqlCodeDefinition(
        definitionName: "HS",
        codeId: "HS",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext context) => _HS;

    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: WAKE
    [CqlCodeDefinition(
        definitionName: "WAKE",
        codeId: "WAKE",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext context) => _WAKE;

    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: C
    [CqlCodeDefinition(
        definitionName: "C",
        codeId: "C",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext context) => _C;

    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CM
    [CqlCodeDefinition(
        definitionName: "CM",
        codeId: "CM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext context) => _CM;

    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CD
    [CqlCodeDefinition(
        definitionName: "CD",
        codeId: "CD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext context) => _CD;

    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: CV
    [CqlCodeDefinition(
        definitionName: "CV",
        codeId: "CV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext context) => _CV;

    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: AC
    [CqlCodeDefinition(
        definitionName: "AC",
        codeId: "AC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext context) => _AC;

    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACM
    [CqlCodeDefinition(
        definitionName: "ACM",
        codeId: "ACM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext context) => _ACM;

    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACD
    [CqlCodeDefinition(
        definitionName: "ACD",
        codeId: "ACD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext context) => _ACD;

    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: ACV
    [CqlCodeDefinition(
        definitionName: "ACV",
        codeId: "ACV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext context) => _ACV;

    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PC
    [CqlCodeDefinition(
        definitionName: "PC",
        codeId: "PC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext context) => _PC;

    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCM
    [CqlCodeDefinition(
        definitionName: "PCM",
        codeId: "PCM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext context) => _PCM;

    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCD
    [CqlCodeDefinition(
        definitionName: "PCD",
        codeId: "PCD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext context) => _PCD;

    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: PCV
    [CqlCodeDefinition(
        definitionName: "PCV",
        codeId: "PCV",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext context) => _PCV;

    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);
    #endregion

    #region Code: MORN
    [CqlCodeDefinition(
        definitionName: "MORN",
        codeId: "MORN",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext context) => _MORN;

    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: MORN.early
    [CqlCodeDefinition(
        definitionName: "MORN.early",
        codeId: "MORN.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext context) => _MORN_early;

    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: MORN.late
    [CqlCodeDefinition(
        definitionName: "MORN.late",
        codeId: "MORN.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext context) => _MORN_late;

    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: NOON
    [CqlCodeDefinition(
        definitionName: "NOON",
        codeId: "NOON",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext context) => _NOON;

    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: AFT
    [CqlCodeDefinition(
        definitionName: "AFT",
        codeId: "AFT",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext context) => _AFT;

    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: AFT.early
    [CqlCodeDefinition(
        definitionName: "AFT.early",
        codeId: "AFT.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext context) => _AFT_early;

    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: AFT.late
    [CqlCodeDefinition(
        definitionName: "AFT.late",
        codeId: "AFT.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext context) => _AFT_late;

    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: EVE
    [CqlCodeDefinition(
        definitionName: "EVE",
        codeId: "EVE",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext context) => _EVE;

    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: EVE.early
    [CqlCodeDefinition(
        definitionName: "EVE.early",
        codeId: "EVE.early",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext context) => _EVE_early;

    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: EVE.late
    [CqlCodeDefinition(
        definitionName: "EVE.late",
        codeId: "EVE.late",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext context) => _EVE_late;

    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: NIGHT
    [CqlCodeDefinition(
        definitionName: "NIGHT",
        codeId: "NIGHT",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext context) => _NIGHT;

    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: PHS
    [CqlCodeDefinition(
        definitionName: "PHS",
        codeId: "PHS",
        codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext context) => _PHS;

    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);
    #endregion

    #region Code: Every eight hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every eight hours (qualifier value)",
        codeId: "307469008",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_hours__qualifier_value_(CqlContext context) => _Every_eight_hours__qualifier_value_;

    private static readonly CqlCode _Every_eight_hours__qualifier_value_ = new CqlCode("307469008", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every eight to twelve hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every eight to twelve hours (qualifier value)",
        codeId: "396140003",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_eight_to_twelve_hours__qualifier_value_(CqlContext context) => _Every_eight_to_twelve_hours__qualifier_value_;

    private static readonly CqlCode _Every_eight_to_twelve_hours__qualifier_value_ = new CqlCode("396140003", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every forty eight hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every forty eight hours (qualifier value)",
        codeId: "396131002",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_eight_hours__qualifier_value_(CqlContext context) => _Every_forty_eight_hours__qualifier_value_;

    private static readonly CqlCode _Every_forty_eight_hours__qualifier_value_ = new CqlCode("396131002", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every forty hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every forty hours (qualifier value)",
        codeId: "396130001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_forty_hours__qualifier_value_(CqlContext context) => _Every_forty_hours__qualifier_value_;

    private static readonly CqlCode _Every_forty_hours__qualifier_value_ = new CqlCode("396130001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every four hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every four hours (qualifier value)",
        codeId: "225756002",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_four_hours__qualifier_value_(CqlContext context) => _Every_four_hours__qualifier_value_;

    private static readonly CqlCode _Every_four_hours__qualifier_value_ = new CqlCode("225756002", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every seventy two hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every seventy two hours (qualifier value)",
        codeId: "396143001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_seventy_two_hours__qualifier_value_(CqlContext context) => _Every_seventy_two_hours__qualifier_value_;

    private static readonly CqlCode _Every_seventy_two_hours__qualifier_value_ = new CqlCode("396143001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every six hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every six hours (qualifier value)",
        codeId: "307468000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_hours__qualifier_value_(CqlContext context) => _Every_six_hours__qualifier_value_;

    private static readonly CqlCode _Every_six_hours__qualifier_value_ = new CqlCode("307468000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every six to eight hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every six to eight hours (qualifier value)",
        codeId: "396139000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_six_to_eight_hours__qualifier_value_(CqlContext context) => _Every_six_to_eight_hours__qualifier_value_;

    private static readonly CqlCode _Every_six_to_eight_hours__qualifier_value_ = new CqlCode("396139000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every thirty six hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every thirty six hours (qualifier value)",
        codeId: "396126004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_thirty_six_hours__qualifier_value_(CqlContext context) => _Every_thirty_six_hours__qualifier_value_;

    private static readonly CqlCode _Every_thirty_six_hours__qualifier_value_ = new CqlCode("396126004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every three to four hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every three to four hours (qualifier value)",
        codeId: "225754004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_four_hours__qualifier_value_(CqlContext context) => _Every_three_to_four_hours__qualifier_value_;

    private static readonly CqlCode _Every_three_to_four_hours__qualifier_value_ = new CqlCode("225754004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every three to six hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every three to six hours (qualifier value)",
        codeId: "396127008",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_three_to_six_hours__qualifier_value_(CqlContext context) => _Every_three_to_six_hours__qualifier_value_;

    private static readonly CqlCode _Every_three_to_six_hours__qualifier_value_ = new CqlCode("396127008", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every twelve hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every twelve hours (qualifier value)",
        codeId: "307470009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twelve_hours__qualifier_value_(CqlContext context) => _Every_twelve_hours__qualifier_value_;

    private static readonly CqlCode _Every_twelve_hours__qualifier_value_ = new CqlCode("307470009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every twenty four hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every twenty four hours (qualifier value)",
        codeId: "396125000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_twenty_four_hours__qualifier_value_(CqlContext context) => _Every_twenty_four_hours__qualifier_value_;

    private static readonly CqlCode _Every_twenty_four_hours__qualifier_value_ = new CqlCode("396125000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Every two to four hours (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Every two to four hours (qualifier value)",
        codeId: "225752000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Every_two_to_four_hours__qualifier_value_(CqlContext context) => _Every_two_to_four_hours__qualifier_value_;

    private static readonly CqlCode _Every_two_to_four_hours__qualifier_value_ = new CqlCode("225752000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Four times daily (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Four times daily (qualifier value)",
        codeId: "307439001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Four_times_daily__qualifier_value_(CqlContext context) => _Four_times_daily__qualifier_value_;

    private static readonly CqlCode _Four_times_daily__qualifier_value_ = new CqlCode("307439001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Once daily (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Once daily (qualifier value)",
        codeId: "229797004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Once_daily__qualifier_value_(CqlContext context) => _Once_daily__qualifier_value_;

    private static readonly CqlCode _Once_daily__qualifier_value_ = new CqlCode("229797004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: One to four times a day (qualifier value)
    [CqlCodeDefinition(
        definitionName: "One to four times a day (qualifier value)",
        codeId: "396109005",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_four_times_a_day__qualifier_value_(CqlContext context) => _One_to_four_times_a_day__qualifier_value_;

    private static readonly CqlCode _One_to_four_times_a_day__qualifier_value_ = new CqlCode("396109005", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: One to three times a day (qualifier value)
    [CqlCodeDefinition(
        definitionName: "One to three times a day (qualifier value)",
        codeId: "396108002",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_three_times_a_day__qualifier_value_(CqlContext context) => _One_to_three_times_a_day__qualifier_value_;

    private static readonly CqlCode _One_to_three_times_a_day__qualifier_value_ = new CqlCode("396108002", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: One to two times a day (qualifier value)
    [CqlCodeDefinition(
        definitionName: "One to two times a day (qualifier value)",
        codeId: "396107007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode One_to_two_times_a_day__qualifier_value_(CqlContext context) => _One_to_two_times_a_day__qualifier_value_;

    private static readonly CqlCode _One_to_two_times_a_day__qualifier_value_ = new CqlCode("396107007", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Three times daily (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Three times daily (qualifier value)",
        codeId: "229798009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Three_times_daily__qualifier_value_(CqlContext context) => _Three_times_daily__qualifier_value_;

    private static readonly CqlCode _Three_times_daily__qualifier_value_ = new CqlCode("229798009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Twice a day (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Twice a day (qualifier value)",
        codeId: "229799001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Twice_a_day__qualifier_value_(CqlContext context) => _Twice_a_day__qualifier_value_;

    private static readonly CqlCode _Twice_a_day__qualifier_value_ = new CqlCode("229799001", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Two to four times a day (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Two to four times a day (qualifier value)",
        codeId: "396111001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Two_to_four_times_a_day__qualifier_value_(CqlContext context) => _Two_to_four_times_a_day__qualifier_value_;

    private static readonly CqlCode _Two_to_four_times_a_day__qualifier_value_ = new CqlCode("396111001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "V3TimingEvent")]
    public CqlCode[] V3TimingEvent(CqlContext context)
    {
        CqlCode[] jzzzzzzd_ = [
            new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
        ];

        return jzzzzzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "EventTiming")]
    public CqlCode[] EventTiming(CqlContext context)
    {
        CqlCode[] jzzzzzze_ = [
            new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default),
        ];

        return jzzzzzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object jzzzzzzf_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)jzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzh_ = context.Operators.SingletonFrom<Patient>(jzzzzzzg_);

        return jzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? jzzzzzzi_()
        {
            bool jzzzzzzj_()
            {
                string kzzzzzze_ = period?.unit;
                bool? kzzzzzzf_ = context.Operators.Equal(kzzzzzze_, "h");

                return kzzzzzzf_ ?? false;
            };
            bool jzzzzzzk_()
            {
                string kzzzzzzg_ = period?.unit;
                bool? kzzzzzzh_ = context.Operators.Equal(kzzzzzzg_, "min");

                return kzzzzzzh_ ?? false;
            };
            bool jzzzzzzl_()
            {
                string kzzzzzzi_ = period?.unit;
                bool? kzzzzzzj_ = context.Operators.Equal(kzzzzzzi_, "s");

                return kzzzzzzj_ ?? false;
            };
            bool jzzzzzzm_()
            {
                string kzzzzzzk_ = period?.unit;
                bool? kzzzzzzl_ = context.Operators.Equal(kzzzzzzk_, "d");

                return kzzzzzzl_ ?? false;
            };
            bool jzzzzzzn_()
            {
                string kzzzzzzm_ = period?.unit;
                bool? kzzzzzzn_ = context.Operators.Equal(kzzzzzzm_, "wk");

                return kzzzzzzn_ ?? false;
            };
            bool jzzzzzzo_()
            {
                string kzzzzzzo_ = period?.unit;
                bool? kzzzzzzp_ = context.Operators.Equal(kzzzzzzo_, "mo");

                return kzzzzzzp_ ?? false;
            };
            bool jzzzzzzp_()
            {
                string kzzzzzzq_ = period?.unit;
                bool? kzzzzzzr_ = context.Operators.Equal(kzzzzzzq_, "a");

                return kzzzzzzr_ ?? false;
            };
            bool jzzzzzzq_()
            {
                string kzzzzzzs_ = period?.unit;
                bool? kzzzzzzt_ = context.Operators.Equal(kzzzzzzs_, "hour");

                return kzzzzzzt_ ?? false;
            };
            bool jzzzzzzr_()
            {
                string kzzzzzzu_ = period?.unit;
                bool? kzzzzzzv_ = context.Operators.Equal(kzzzzzzu_, "minute");

                return kzzzzzzv_ ?? false;
            };
            bool jzzzzzzs_()
            {
                string kzzzzzzw_ = period?.unit;
                bool? kzzzzzzx_ = context.Operators.Equal(kzzzzzzw_, "second");

                return kzzzzzzx_ ?? false;
            };
            bool jzzzzzzt_()
            {
                string kzzzzzzy_ = period?.unit;
                bool? kzzzzzzz_ = context.Operators.Equal(kzzzzzzy_, "day");

                return kzzzzzzz_ ?? false;
            };
            bool jzzzzzzu_()
            {
                string lzzzzzza_ = period?.unit;
                bool? lzzzzzzb_ = context.Operators.Equal(lzzzzzza_, "week");

                return lzzzzzzb_ ?? false;
            };
            bool jzzzzzzv_()
            {
                string lzzzzzzc_ = period?.unit;
                bool? lzzzzzzd_ = context.Operators.Equal(lzzzzzzc_, "month");

                return lzzzzzzd_ ?? false;
            };
            bool jzzzzzzw_()
            {
                string lzzzzzze_ = period?.unit;
                bool? lzzzzzzf_ = context.Operators.Equal(lzzzzzze_, "year");

                return lzzzzzzf_ ?? false;
            };
            bool jzzzzzzx_()
            {
                string lzzzzzzg_ = period?.unit;
                bool? lzzzzzzh_ = context.Operators.Equal(lzzzzzzg_, "hours");

                return lzzzzzzh_ ?? false;
            };
            bool jzzzzzzy_()
            {
                string lzzzzzzi_ = period?.unit;
                bool? lzzzzzzj_ = context.Operators.Equal(lzzzzzzi_, "minutes");

                return lzzzzzzj_ ?? false;
            };
            bool jzzzzzzz_()
            {
                string lzzzzzzk_ = period?.unit;
                bool? lzzzzzzl_ = context.Operators.Equal(lzzzzzzk_, "seconds");

                return lzzzzzzl_ ?? false;
            };
            bool kzzzzzza_()
            {
                string lzzzzzzm_ = period?.unit;
                bool? lzzzzzzn_ = context.Operators.Equal(lzzzzzzm_, "days");

                return lzzzzzzn_ ?? false;
            };
            bool kzzzzzzb_()
            {
                string lzzzzzzo_ = period?.unit;
                bool? lzzzzzzp_ = context.Operators.Equal(lzzzzzzo_, "weeks");

                return lzzzzzzp_ ?? false;
            };
            bool kzzzzzzc_()
            {
                string lzzzzzzq_ = period?.unit;
                bool? lzzzzzzr_ = context.Operators.Equal(lzzzzzzq_, "months");

                return lzzzzzzr_ ?? false;
            };
            bool kzzzzzzd_()
            {
                string lzzzzzzs_ = period?.unit;
                bool? lzzzzzzt_ = context.Operators.Equal(lzzzzzzs_, "years");

                return lzzzzzzt_ ?? false;
            };
            if (jzzzzzzj_())
            {
                decimal? lzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzzzzv_ = period?.value;
                decimal? lzzzzzzw_ = context.Operators.Divide(24.0m, lzzzzzzv_);
                decimal? lzzzzzzx_ = context.Operators.Multiply(lzzzzzzu_, lzzzzzzw_);

                return lzzzzzzx_;
            }
            else if (jzzzzzzk_())
            {
                decimal? lzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? lzzzzzzz_ = period?.value;
                decimal? mzzzzzza_ = context.Operators.Divide(24.0m, lzzzzzzz_);
                decimal? mzzzzzzb_ = context.Operators.Multiply(lzzzzzzy_, mzzzzzza_);
                decimal? mzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? mzzzzzzd_ = context.Operators.Multiply(mzzzzzzb_, mzzzzzzc_);

                return mzzzzzzd_;
            }
            else if (jzzzzzzl_())
            {
                decimal? mzzzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzzzzf_ = period?.value;
                decimal? mzzzzzzg_ = context.Operators.Divide(24.0m, mzzzzzzf_);
                decimal? mzzzzzzh_ = context.Operators.Multiply(mzzzzzze_, mzzzzzzg_);
                decimal? mzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? mzzzzzzj_ = context.Operators.Multiply(mzzzzzzh_, mzzzzzzi_);
                decimal? mzzzzzzl_ = context.Operators.Multiply(mzzzzzzj_, mzzzzzzi_);

                return mzzzzzzl_;
            }
            else if (jzzzzzzm_())
            {
                decimal? mzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzzzzn_ = period?.value;
                decimal? mzzzzzzo_ = context.Operators.Divide(24.0m, mzzzzzzn_);
                decimal? mzzzzzzp_ = context.Operators.Multiply(mzzzzzzm_, mzzzzzzo_);
                decimal? mzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? mzzzzzzr_ = context.Operators.Divide(mzzzzzzp_, mzzzzzzq_);

                return mzzzzzzr_;
            }
            else if (jzzzzzzn_())
            {
                decimal? mzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? mzzzzzzt_ = period?.value;
                decimal? mzzzzzzu_ = context.Operators.Divide(24.0m, mzzzzzzt_);
                decimal? mzzzzzzv_ = context.Operators.Multiply(mzzzzzzs_, mzzzzzzu_);
                int? mzzzzzzw_ = context.Operators.Multiply(24, 7);
                decimal? mzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(mzzzzzzw_);
                decimal? mzzzzzzy_ = context.Operators.Divide(mzzzzzzv_, mzzzzzzx_);

                return mzzzzzzy_;
            }
            else if (jzzzzzzo_())
            {
                decimal? mzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzzzza_ = period?.value;
                decimal? nzzzzzzb_ = context.Operators.Divide(24.0m, nzzzzzza_);
                decimal? nzzzzzzc_ = context.Operators.Multiply(mzzzzzzz_, nzzzzzzb_);
                int? nzzzzzzd_ = context.Operators.Multiply(24, 30);
                decimal? nzzzzzze_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzd_);
                decimal? nzzzzzzf_ = context.Operators.Divide(nzzzzzzc_, nzzzzzze_);

                return nzzzzzzf_;
            }
            else if (jzzzzzzp_())
            {
                decimal? nzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzzzzh_ = period?.value;
                decimal? nzzzzzzi_ = context.Operators.Divide(24.0m, nzzzzzzh_);
                decimal? nzzzzzzj_ = context.Operators.Multiply(nzzzzzzg_, nzzzzzzi_);
                int? nzzzzzzk_ = context.Operators.Multiply(24, 365);
                decimal? nzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(nzzzzzzk_);
                decimal? nzzzzzzm_ = context.Operators.Divide(nzzzzzzj_, nzzzzzzl_);

                return nzzzzzzm_;
            }
            else if (jzzzzzzq_())
            {
                decimal? nzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzzzzo_ = period?.value;
                decimal? nzzzzzzp_ = context.Operators.Divide(24.0m, nzzzzzzo_);
                decimal? nzzzzzzq_ = context.Operators.Multiply(nzzzzzzn_, nzzzzzzp_);

                return nzzzzzzq_;
            }
            else if (jzzzzzzr_())
            {
                decimal? nzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzzzzs_ = period?.value;
                decimal? nzzzzzzt_ = context.Operators.Divide(24.0m, nzzzzzzs_);
                decimal? nzzzzzzu_ = context.Operators.Multiply(nzzzzzzr_, nzzzzzzt_);
                decimal? nzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? nzzzzzzw_ = context.Operators.Multiply(nzzzzzzu_, nzzzzzzv_);

                return nzzzzzzw_;
            }
            else if (jzzzzzzs_())
            {
                decimal? nzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? nzzzzzzy_ = period?.value;
                decimal? nzzzzzzz_ = context.Operators.Divide(24.0m, nzzzzzzy_);
                decimal? ozzzzzza_ = context.Operators.Multiply(nzzzzzzx_, nzzzzzzz_);
                decimal? ozzzzzzb_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ozzzzzzc_ = context.Operators.Multiply(ozzzzzza_, ozzzzzzb_);
                decimal? ozzzzzze_ = context.Operators.Multiply(ozzzzzzc_, ozzzzzzb_);

                return ozzzzzze_;
            }
            else if (jzzzzzzt_())
            {
                decimal? ozzzzzzf_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzg_ = period?.value;
                decimal? ozzzzzzh_ = context.Operators.Divide(24.0m, ozzzzzzg_);
                decimal? ozzzzzzi_ = context.Operators.Multiply(ozzzzzzf_, ozzzzzzh_);
                decimal? ozzzzzzj_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ozzzzzzk_ = context.Operators.Divide(ozzzzzzi_, ozzzzzzj_);

                return ozzzzzzk_;
            }
            else if (jzzzzzzu_())
            {
                decimal? ozzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzm_ = period?.value;
                decimal? ozzzzzzn_ = context.Operators.Divide(24.0m, ozzzzzzm_);
                decimal? ozzzzzzo_ = context.Operators.Multiply(ozzzzzzl_, ozzzzzzn_);
                int? ozzzzzzp_ = context.Operators.Multiply(24, 7);
                decimal? ozzzzzzq_ = context.Operators.ConvertIntegerToDecimal(ozzzzzzp_);
                decimal? ozzzzzzr_ = context.Operators.Divide(ozzzzzzo_, ozzzzzzq_);

                return ozzzzzzr_;
            }
            else if (jzzzzzzv_())
            {
                decimal? ozzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ozzzzzzt_ = period?.value;
                decimal? ozzzzzzu_ = context.Operators.Divide(24.0m, ozzzzzzt_);
                decimal? ozzzzzzv_ = context.Operators.Multiply(ozzzzzzs_, ozzzzzzu_);
                int? ozzzzzzw_ = context.Operators.Multiply(24, 30);
                decimal? ozzzzzzx_ = context.Operators.ConvertIntegerToDecimal(ozzzzzzw_);
                decimal? ozzzzzzy_ = context.Operators.Divide(ozzzzzzv_, ozzzzzzx_);

                return ozzzzzzy_;
            }
            else if (jzzzzzzw_())
            {
                decimal? ozzzzzzz_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzza_ = period?.value;
                decimal? pzzzzzzb_ = context.Operators.Divide(24.0m, pzzzzzza_);
                decimal? pzzzzzzc_ = context.Operators.Multiply(ozzzzzzz_, pzzzzzzb_);
                int? pzzzzzzd_ = context.Operators.Multiply(24, 365);
                decimal? pzzzzzze_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzd_);
                decimal? pzzzzzzf_ = context.Operators.Divide(pzzzzzzc_, pzzzzzze_);

                return pzzzzzzf_;
            }
            else if (jzzzzzzx_())
            {
                decimal? pzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzh_ = period?.value;
                decimal? pzzzzzzi_ = context.Operators.Divide(24.0m, pzzzzzzh_);
                decimal? pzzzzzzj_ = context.Operators.Multiply(pzzzzzzg_, pzzzzzzi_);

                return pzzzzzzj_;
            }
            else if (jzzzzzzy_())
            {
                decimal? pzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzl_ = period?.value;
                decimal? pzzzzzzm_ = context.Operators.Divide(24.0m, pzzzzzzl_);
                decimal? pzzzzzzn_ = context.Operators.Multiply(pzzzzzzk_, pzzzzzzm_);
                decimal? pzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzp_ = context.Operators.Multiply(pzzzzzzn_, pzzzzzzo_);

                return pzzzzzzp_;
            }
            else if (jzzzzzzz_())
            {
                decimal? pzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzr_ = period?.value;
                decimal? pzzzzzzs_ = context.Operators.Divide(24.0m, pzzzzzzr_);
                decimal? pzzzzzzt_ = context.Operators.Multiply(pzzzzzzq_, pzzzzzzs_);
                decimal? pzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? pzzzzzzv_ = context.Operators.Multiply(pzzzzzzt_, pzzzzzzu_);
                decimal? pzzzzzzx_ = context.Operators.Multiply(pzzzzzzv_, pzzzzzzu_);

                return pzzzzzzx_;
            }
            else if (kzzzzzza_())
            {
                decimal? pzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? pzzzzzzz_ = period?.value;
                decimal? qzzzzzza_ = context.Operators.Divide(24.0m, pzzzzzzz_);
                decimal? qzzzzzzb_ = context.Operators.Multiply(pzzzzzzy_, qzzzzzza_);
                decimal? qzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? qzzzzzzd_ = context.Operators.Divide(qzzzzzzb_, qzzzzzzc_);

                return qzzzzzzd_;
            }
            else if (kzzzzzzb_())
            {
                decimal? qzzzzzze_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzf_ = period?.value;
                decimal? qzzzzzzg_ = context.Operators.Divide(24.0m, qzzzzzzf_);
                decimal? qzzzzzzh_ = context.Operators.Multiply(qzzzzzze_, qzzzzzzg_);
                int? qzzzzzzi_ = context.Operators.Multiply(24, 7);
                decimal? qzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzi_);
                decimal? qzzzzzzk_ = context.Operators.Divide(qzzzzzzh_, qzzzzzzj_);

                return qzzzzzzk_;
            }
            else if (kzzzzzzc_())
            {
                decimal? qzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzm_ = period?.value;
                decimal? qzzzzzzn_ = context.Operators.Divide(24.0m, qzzzzzzm_);
                decimal? qzzzzzzo_ = context.Operators.Multiply(qzzzzzzl_, qzzzzzzn_);
                int? qzzzzzzp_ = context.Operators.Multiply(24, 30);
                decimal? qzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzp_);
                decimal? qzzzzzzr_ = context.Operators.Divide(qzzzzzzo_, qzzzzzzq_);

                return qzzzzzzr_;
            }
            else if (kzzzzzzd_())
            {
                decimal? qzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? qzzzzzzt_ = period?.value;
                decimal? qzzzzzzu_ = context.Operators.Divide(24.0m, qzzzzzzt_);
                decimal? qzzzzzzv_ = context.Operators.Multiply(qzzzzzzs_, qzzzzzzu_);
                int? qzzzzzzw_ = context.Operators.Multiply(24, 365);
                decimal? qzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(qzzzzzzw_);
                decimal? qzzzzzzy_ = context.Operators.Divide(qzzzzzzv_, qzzzzzzx_);

                return qzzzzzzy_;
            }
            else
            {
                string qzzzzzzz_ = this.ErrorLevel(context);
                string rzzzzzza_ = period?.unit;
                string rzzzzzzb_ = context.Operators.Concatenate("Unknown unit ", rzzzzzza_ ?? "");
                object rzzzzzzc_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", qzzzzzzz_, rzzzzzzb_);

                return rzzzzzzc_ as decimal?;
            }
        };

        return jzzzzzzi_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? rzzzzzzd_()
        {
            bool rzzzzzze_()
            {
                CqlCode szzzzzzz_ = this.HS(context);
                bool? tzzzzzza_ = context.Operators.Equivalent(frequency, szzzzzzz_);

                return tzzzzzza_ ?? false;
            };
            bool rzzzzzzf_()
            {
                CqlCode tzzzzzzb_ = this.WAKE(context);
                bool? tzzzzzzc_ = context.Operators.Equivalent(frequency, tzzzzzzb_);

                return tzzzzzzc_ ?? false;
            };
            bool rzzzzzzg_()
            {
                CqlCode tzzzzzzd_ = this.C(context);
                bool? tzzzzzze_ = context.Operators.Equivalent(frequency, tzzzzzzd_);

                return tzzzzzze_ ?? false;
            };
            bool rzzzzzzh_()
            {
                CqlCode tzzzzzzf_ = this.CM(context);
                bool? tzzzzzzg_ = context.Operators.Equivalent(frequency, tzzzzzzf_);

                return tzzzzzzg_ ?? false;
            };
            bool rzzzzzzi_()
            {
                CqlCode tzzzzzzh_ = this.CD(context);
                bool? tzzzzzzi_ = context.Operators.Equivalent(frequency, tzzzzzzh_);

                return tzzzzzzi_ ?? false;
            };
            bool rzzzzzzj_()
            {
                CqlCode tzzzzzzj_ = this.CV(context);
                bool? tzzzzzzk_ = context.Operators.Equivalent(frequency, tzzzzzzj_);

                return tzzzzzzk_ ?? false;
            };
            bool rzzzzzzk_()
            {
                CqlCode tzzzzzzl_ = this.AC(context);
                bool? tzzzzzzm_ = context.Operators.Equivalent(frequency, tzzzzzzl_);

                return tzzzzzzm_ ?? false;
            };
            bool rzzzzzzl_()
            {
                CqlCode tzzzzzzn_ = this.ACM(context);
                bool? tzzzzzzo_ = context.Operators.Equivalent(frequency, tzzzzzzn_);

                return tzzzzzzo_ ?? false;
            };
            bool rzzzzzzm_()
            {
                CqlCode tzzzzzzp_ = this.ACD(context);
                bool? tzzzzzzq_ = context.Operators.Equivalent(frequency, tzzzzzzp_);

                return tzzzzzzq_ ?? false;
            };
            bool rzzzzzzn_()
            {
                CqlCode tzzzzzzr_ = this.ACV(context);
                bool? tzzzzzzs_ = context.Operators.Equivalent(frequency, tzzzzzzr_);

                return tzzzzzzs_ ?? false;
            };
            bool rzzzzzzo_()
            {
                CqlCode tzzzzzzt_ = this.PC(context);
                bool? tzzzzzzu_ = context.Operators.Equivalent(frequency, tzzzzzzt_);

                return tzzzzzzu_ ?? false;
            };
            bool rzzzzzzp_()
            {
                CqlCode tzzzzzzv_ = this.PCM(context);
                bool? tzzzzzzw_ = context.Operators.Equivalent(frequency, tzzzzzzv_);

                return tzzzzzzw_ ?? false;
            };
            bool rzzzzzzq_()
            {
                CqlCode tzzzzzzx_ = this.PCD(context);
                bool? tzzzzzzy_ = context.Operators.Equivalent(frequency, tzzzzzzx_);

                return tzzzzzzy_ ?? false;
            };
            bool rzzzzzzr_()
            {
                CqlCode tzzzzzzz_ = this.PCV(context);
                bool? uzzzzzza_ = context.Operators.Equivalent(frequency, tzzzzzzz_);

                return uzzzzzza_ ?? false;
            };
            bool rzzzzzzs_()
            {
                CqlCode uzzzzzzb_ = this.MORN(context);
                bool? uzzzzzzc_ = context.Operators.Equivalent(frequency, uzzzzzzb_);

                return uzzzzzzc_ ?? false;
            };
            bool rzzzzzzt_()
            {
                CqlCode uzzzzzzd_ = this.MORN_early(context);
                bool? uzzzzzze_ = context.Operators.Equivalent(frequency, uzzzzzzd_);

                return uzzzzzze_ ?? false;
            };
            bool rzzzzzzu_()
            {
                CqlCode uzzzzzzf_ = this.MORN_late(context);
                bool? uzzzzzzg_ = context.Operators.Equivalent(frequency, uzzzzzzf_);

                return uzzzzzzg_ ?? false;
            };
            bool rzzzzzzv_()
            {
                CqlCode uzzzzzzh_ = this.NOON(context);
                bool? uzzzzzzi_ = context.Operators.Equivalent(frequency, uzzzzzzh_);

                return uzzzzzzi_ ?? false;
            };
            bool rzzzzzzw_()
            {
                CqlCode uzzzzzzj_ = this.AFT(context);
                bool? uzzzzzzk_ = context.Operators.Equivalent(frequency, uzzzzzzj_);

                return uzzzzzzk_ ?? false;
            };
            bool rzzzzzzx_()
            {
                CqlCode uzzzzzzl_ = this.AFT_early(context);
                bool? uzzzzzzm_ = context.Operators.Equivalent(frequency, uzzzzzzl_);

                return uzzzzzzm_ ?? false;
            };
            bool rzzzzzzy_()
            {
                CqlCode uzzzzzzn_ = this.AFT_late(context);
                bool? uzzzzzzo_ = context.Operators.Equivalent(frequency, uzzzzzzn_);

                return uzzzzzzo_ ?? false;
            };
            bool rzzzzzzz_()
            {
                CqlCode uzzzzzzp_ = this.EVE(context);
                bool? uzzzzzzq_ = context.Operators.Equivalent(frequency, uzzzzzzp_);

                return uzzzzzzq_ ?? false;
            };
            bool szzzzzza_()
            {
                CqlCode uzzzzzzr_ = this.EVE_early(context);
                bool? uzzzzzzs_ = context.Operators.Equivalent(frequency, uzzzzzzr_);

                return uzzzzzzs_ ?? false;
            };
            bool szzzzzzb_()
            {
                CqlCode uzzzzzzt_ = this.EVE_late(context);
                bool? uzzzzzzu_ = context.Operators.Equivalent(frequency, uzzzzzzt_);

                return uzzzzzzu_ ?? false;
            };
            bool szzzzzzc_()
            {
                CqlCode uzzzzzzv_ = this.NIGHT(context);
                bool? uzzzzzzw_ = context.Operators.Equivalent(frequency, uzzzzzzv_);

                return uzzzzzzw_ ?? false;
            };
            bool szzzzzzd_()
            {
                CqlCode uzzzzzzx_ = this.PHS(context);
                bool? uzzzzzzy_ = context.Operators.Equivalent(frequency, uzzzzzzx_);

                return uzzzzzzy_ ?? false;
            };
            bool szzzzzze_()
            {
                CqlCode uzzzzzzz_ = this.Once_daily__qualifier_value_(context);
                bool? vzzzzzza_ = context.Operators.Equivalent(frequency, uzzzzzzz_);

                return vzzzzzza_ ?? false;
            };
            bool szzzzzzf_()
            {
                CqlCode vzzzzzzb_ = this.Twice_a_day__qualifier_value_(context);
                bool? vzzzzzzc_ = context.Operators.Equivalent(frequency, vzzzzzzb_);

                return vzzzzzzc_ ?? false;
            };
            bool szzzzzzg_()
            {
                CqlCode vzzzzzzd_ = this.Three_times_daily__qualifier_value_(context);
                bool? vzzzzzze_ = context.Operators.Equivalent(frequency, vzzzzzzd_);

                return vzzzzzze_ ?? false;
            };
            bool szzzzzzh_()
            {
                CqlCode vzzzzzzf_ = this.Four_times_daily__qualifier_value_(context);
                bool? vzzzzzzg_ = context.Operators.Equivalent(frequency, vzzzzzzf_);

                return vzzzzzzg_ ?? false;
            };
            bool szzzzzzi_()
            {
                CqlCode vzzzzzzh_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? vzzzzzzi_ = context.Operators.Equivalent(frequency, vzzzzzzh_);

                return vzzzzzzi_ ?? false;
            };
            bool szzzzzzj_()
            {
                CqlCode vzzzzzzj_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? vzzzzzzk_ = context.Operators.Equivalent(frequency, vzzzzzzj_);

                return vzzzzzzk_ ?? false;
            };
            bool szzzzzzk_()
            {
                CqlCode vzzzzzzl_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? vzzzzzzm_ = context.Operators.Equivalent(frequency, vzzzzzzl_);

                return vzzzzzzm_ ?? false;
            };
            bool szzzzzzl_()
            {
                CqlCode vzzzzzzn_ = this.Every_eight_hours__qualifier_value_(context);
                bool? vzzzzzzo_ = context.Operators.Equivalent(frequency, vzzzzzzn_);

                return vzzzzzzo_ ?? false;
            };
            bool szzzzzzm_()
            {
                CqlCode vzzzzzzp_ = this.Every_four_hours__qualifier_value_(context);
                bool? vzzzzzzq_ = context.Operators.Equivalent(frequency, vzzzzzzp_);

                return vzzzzzzq_ ?? false;
            };
            bool szzzzzzn_()
            {
                CqlCode vzzzzzzr_ = this.Every_six_hours__qualifier_value_(context);
                bool? vzzzzzzs_ = context.Operators.Equivalent(frequency, vzzzzzzr_);

                return vzzzzzzs_ ?? false;
            };
            bool szzzzzzo_()
            {
                CqlCode vzzzzzzt_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? vzzzzzzu_ = context.Operators.Equivalent(frequency, vzzzzzzt_);

                return vzzzzzzu_ ?? false;
            };
            bool szzzzzzp_()
            {
                CqlCode vzzzzzzv_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? vzzzzzzw_ = context.Operators.Equivalent(frequency, vzzzzzzv_);

                return vzzzzzzw_ ?? false;
            };
            bool szzzzzzq_()
            {
                CqlCode vzzzzzzx_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? vzzzzzzy_ = context.Operators.Equivalent(frequency, vzzzzzzx_);

                return vzzzzzzy_ ?? false;
            };
            bool szzzzzzr_()
            {
                CqlCode vzzzzzzz_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? wzzzzzza_ = context.Operators.Equivalent(frequency, vzzzzzzz_);

                return wzzzzzza_ ?? false;
            };
            bool szzzzzzs_()
            {
                CqlCode wzzzzzzb_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? wzzzzzzc_ = context.Operators.Equivalent(frequency, wzzzzzzb_);

                return wzzzzzzc_ ?? false;
            };
            bool szzzzzzt_()
            {
                CqlCode wzzzzzzd_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? wzzzzzze_ = context.Operators.Equivalent(frequency, wzzzzzzd_);

                return wzzzzzze_ ?? false;
            };
            bool szzzzzzu_()
            {
                CqlCode wzzzzzzf_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? wzzzzzzg_ = context.Operators.Equivalent(frequency, wzzzzzzf_);

                return wzzzzzzg_ ?? false;
            };
            bool szzzzzzv_()
            {
                CqlCode wzzzzzzh_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? wzzzzzzi_ = context.Operators.Equivalent(frequency, wzzzzzzh_);

                return wzzzzzzi_ ?? false;
            };
            bool szzzzzzw_()
            {
                CqlCode wzzzzzzj_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? wzzzzzzk_ = context.Operators.Equivalent(frequency, wzzzzzzj_);

                return wzzzzzzk_ ?? false;
            };
            bool szzzzzzx_()
            {
                CqlCode wzzzzzzl_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? wzzzzzzm_ = context.Operators.Equivalent(frequency, wzzzzzzl_);

                return wzzzzzzm_ ?? false;
            };
            bool szzzzzzy_()
            {
                CqlCode wzzzzzzn_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? wzzzzzzo_ = context.Operators.Equivalent(frequency, wzzzzzzn_);

                return wzzzzzzo_ ?? false;
            };
            if (rzzzzzze_())
            {
                decimal? wzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzp_;
            }
            else if (rzzzzzzf_())
            {
                decimal? wzzzzzzq_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzq_;
            }
            else if (rzzzzzzg_())
            {
                decimal? wzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(3);

                return wzzzzzzr_;
            }
            else if (rzzzzzzh_())
            {
                decimal? wzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzs_;
            }
            else if (rzzzzzzi_())
            {
                decimal? wzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzt_;
            }
            else if (rzzzzzzj_())
            {
                decimal? wzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzu_;
            }
            else if (rzzzzzzk_())
            {
                decimal? wzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(3);

                return wzzzzzzv_;
            }
            else if (rzzzzzzl_())
            {
                decimal? wzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzw_;
            }
            else if (rzzzzzzm_())
            {
                decimal? wzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzx_;
            }
            else if (rzzzzzzn_())
            {
                decimal? wzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(1);

                return wzzzzzzy_;
            }
            else if (rzzzzzzo_())
            {
                decimal? wzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(3);

                return wzzzzzzz_;
            }
            else if (rzzzzzzp_())
            {
                decimal? xzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzza_;
            }
            else if (rzzzzzzq_())
            {
                decimal? xzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzb_;
            }
            else if (rzzzzzzr_())
            {
                decimal? xzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzc_;
            }
            else if (rzzzzzzs_())
            {
                decimal? xzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzd_;
            }
            else if (rzzzzzzt_())
            {
                decimal? xzzzzzze_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzze_;
            }
            else if (rzzzzzzu_())
            {
                decimal? xzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzf_;
            }
            else if (rzzzzzzv_())
            {
                decimal? xzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzg_;
            }
            else if (rzzzzzzw_())
            {
                decimal? xzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzh_;
            }
            else if (rzzzzzzx_())
            {
                decimal? xzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzi_;
            }
            else if (rzzzzzzy_())
            {
                decimal? xzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzj_;
            }
            else if (rzzzzzzz_())
            {
                decimal? xzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzk_;
            }
            else if (szzzzzza_())
            {
                decimal? xzzzzzzl_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzl_;
            }
            else if (szzzzzzb_())
            {
                decimal? xzzzzzzm_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzm_;
            }
            else if (szzzzzzc_())
            {
                decimal? xzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzn_;
            }
            else if (szzzzzzd_())
            {
                decimal? xzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(1);

                return xzzzzzzo_;
            }
            else if (szzzzzze_())
            {
                return 1.0m;
            }
            else if (szzzzzzf_())
            {
                return 2.0m;
            }
            else if (szzzzzzg_())
            {
                return 3.0m;
            }
            else if (szzzzzzh_())
            {
                return 4.0m;
            }
            else if (szzzzzzi_())
            {
                return 1.0m;
            }
            else if (szzzzzzj_())
            {
                return 2.0m;
            }
            else if (szzzzzzk_())
            {
                return 0.67m;
            }
            else if (szzzzzzl_())
            {
                return 3.0m;
            }
            else if (szzzzzzm_())
            {
                return 6.0m;
            }
            else if (szzzzzzn_())
            {
                return 4.0m;
            }
            else if (szzzzzzo_())
            {
                return 0.33m;
            }
            else if (szzzzzzp_())
            {
                return 0.5m;
            }
            else if (szzzzzzq_())
            {
                return 3.0m;
            }
            else if (szzzzzzr_())
            {
                return 4.0m;
            }
            else if (szzzzzzs_())
            {
                return 8.0m;
            }
            else if (szzzzzzt_())
            {
                return 8.0m;
            }
            else if (szzzzzzu_())
            {
                return 12.0m;
            }
            else if (szzzzzzv_())
            {
                return 4.0m;
            }
            else if (szzzzzzw_())
            {
                return 3.0m;
            }
            else if (szzzzzzx_())
            {
                return 2.0m;
            }
            else if (szzzzzzy_())
            {
                return 4.0m;
            }
            else
            {
                string xzzzzzzp_ = this.ErrorLevel(context);
                string xzzzzzzq_ = frequency?.code;
                string xzzzzzzr_ = context.Operators.Concatenate("Unknown frequency code ", xzzzzzzq_ ?? "");
                object xzzzzzzs_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", xzzzzzzp_, xzzzzzzr_);

                return xzzzzzzs_ as decimal?;
            }
        };

        return rzzzzzzd_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] xzzzzzzt_ = [
            Request,
        ];
        CqlInterval<CqlDate> xzzzzzzu_(MedicationRequest R)
        {
            CqlInterval<CqlDate> xzzzzzzy_()
            {
                bool xzzzzzzz_()
                {
                    List<Dosage> yzzzzzzb_ = R?.DosageInstruction;
                    Dosage yzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing yzzzzzzd_ = yzzzzzzc_?.Timing;
                    Timing.RepeatComponent yzzzzzze_ = yzzzzzzd_?.Repeat;
                    DataType yzzzzzzf_ = yzzzzzze_?.Bounds;
                    object yzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzf_);
                    CqlDateTime yzzzzzzh_ = context.Operators.Start(yzzzzzzg_ as CqlInterval<CqlDateTime>);
                    CqlDate yzzzzzzi_ = context.Operators.DateFrom(yzzzzzzh_);
                    FhirDateTime yzzzzzzj_ = R?.AuthoredOnElement;
                    CqlDateTime yzzzzzzk_ = context.Operators.Convert<CqlDateTime>(yzzzzzzj_);
                    CqlDate yzzzzzzl_ = context.Operators.DateFrom(yzzzzzzk_);
                    MedicationRequest.DispenseRequestComponent yzzzzzzm_ = R?.DispenseRequest;
                    Period yzzzzzzn_ = yzzzzzzm_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> yzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzn_);
                    CqlDateTime yzzzzzzp_ = context.Operators.Start(yzzzzzzo_);
                    CqlDate yzzzzzzq_ = context.Operators.DateFrom(yzzzzzzp_);
                    bool? yzzzzzzr_ = context.Operators.Not((bool?)(((yzzzzzzi_ ?? yzzzzzzl_) ?? yzzzzzzq_) is null));
                    Duration yzzzzzzt_ = yzzzzzzm_?.ExpectedSupplyDuration;
                    CqlQuantity yzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzt_);
                    CqlQuantity yzzzzzzv_ = context.Operators.ConvertQuantity(yzzzzzzu_, "d");
                    decimal? yzzzzzzw_ = yzzzzzzv_?.value;
                    Quantity yzzzzzzy_ = yzzzzzzm_?.Quantity;
                    CqlQuantity yzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzy_);
                    decimal? zzzzzzza_ = yzzzzzzz_?.value;
                    Dosage zzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> zzzzzzzd_ = zzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent zzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)zzzzzzzd_);
                    DataType zzzzzzzf_ = zzzzzzze_?.Dose;
                    object zzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzf_);
                    CqlQuantity zzzzzzzh_ = context.Operators.End(zzzzzzzg_ as CqlInterval<CqlQuantity>);
                    Dosage zzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> zzzzzzzk_ = zzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent zzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)zzzzzzzk_);
                    DataType zzzzzzzm_ = zzzzzzzl_?.Dose;
                    object zzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzm_);
                    decimal? zzzzzzzo_ = (zzzzzzzh_ ?? zzzzzzzn_ as CqlQuantity)?.value;
                    Dosage zzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing zzzzzzzr_ = zzzzzzzq_?.Timing;
                    Timing.RepeatComponent zzzzzzzs_ = zzzzzzzr_?.Repeat;
                    PositiveInt zzzzzzzt_ = zzzzzzzs_?.FrequencyMaxElement;
                    int? zzzzzzzu_ = zzzzzzzt_?.Value;
                    Dosage zzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing zzzzzzzx_ = zzzzzzzw_?.Timing;
                    Timing.RepeatComponent zzzzzzzy_ = zzzzzzzx_?.Repeat;
                    PositiveInt zzzzzzzz_ = zzzzzzzy_?.FrequencyElement;
                    int? azzzzzzza_ = zzzzzzzz_?.Value;
                    Dosage azzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing azzzzzzzd_ = azzzzzzzc_?.Timing;
                    Timing.RepeatComponent azzzzzzze_ = azzzzzzzd_?.Repeat;
                    FhirDecimal azzzzzzzf_ = azzzzzzze_?.PeriodElement;
                    decimal? azzzzzzzg_ = azzzzzzzf_?.Value;
                    Dosage azzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing azzzzzzzj_ = azzzzzzzi_?.Timing;
                    Timing.RepeatComponent azzzzzzzk_ = azzzzzzzj_?.Repeat;
                    Code<Timing.UnitsOfTime> azzzzzzzl_ = azzzzzzzk_?.PeriodUnitElement;
                    Timing.UnitsOfTime? azzzzzzzm_ = azzzzzzzl_?.Value;
                    string azzzzzzzn_ = context.Operators.Convert<string>(azzzzzzzm_);
                    CqlQuantity azzzzzzzo_ = this.Quantity(context, azzzzzzzg_, azzzzzzzn_);
                    decimal? azzzzzzzp_ = this.ToDaily(context, zzzzzzzu_ ?? azzzzzzza_, azzzzzzzo_);
                    Dosage azzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)yzzzzzzb_);
                    Timing azzzzzzzs_ = azzzzzzzr_?.Timing;
                    Timing.RepeatComponent azzzzzzzt_ = azzzzzzzs_?.Repeat;
                    List<Time> azzzzzzzu_ = azzzzzzzt_?.TimeOfDayElement;
                    IEnumerable<CqlTime> azzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(azzzzzzzu_, "value");
                    int? azzzzzzzw_ = context.Operators.Count<CqlTime>(azzzzzzzv_);
                    decimal? azzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(azzzzzzzw_);
                    decimal? azzzzzzzy_ = context.Operators.Multiply(zzzzzzzo_, (azzzzzzzp_ ?? azzzzzzzx_) ?? 1.0m);
                    decimal? azzzzzzzz_ = context.Operators.Divide(zzzzzzza_, azzzzzzzy_);
                    UnsignedInt bzzzzzzzb_ = yzzzzzzm_?.NumberOfRepeatsAllowedElement;
                    int? bzzzzzzzc_ = bzzzzzzzb_?.Value;
                    int? bzzzzzzzd_ = context.Operators.Add(1, bzzzzzzzc_ ?? 0);
                    decimal? bzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(bzzzzzzzd_);
                    decimal? bzzzzzzzf_ = context.Operators.Multiply(yzzzzzzw_ ?? azzzzzzzz_, bzzzzzzze_);
                    bool? bzzzzzzzg_ = context.Operators.Not((bool?)(bzzzzzzzf_ is null));
                    bool? bzzzzzzzh_ = context.Operators.And(yzzzzzzr_, bzzzzzzzg_);

                    return bzzzzzzzh_ ?? false;
                };
                bool yzzzzzza_()
                {
                    List<Dosage> bzzzzzzzi_ = R?.DosageInstruction;
                    Dosage bzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzi_);
                    Timing bzzzzzzzk_ = bzzzzzzzj_?.Timing;
                    Timing.RepeatComponent bzzzzzzzl_ = bzzzzzzzk_?.Repeat;
                    DataType bzzzzzzzm_ = bzzzzzzzl_?.Bounds;
                    object bzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzm_);
                    CqlDateTime bzzzzzzzo_ = context.Operators.Start(bzzzzzzzn_ as CqlInterval<CqlDateTime>);
                    CqlDate bzzzzzzzp_ = context.Operators.DateFrom(bzzzzzzzo_);
                    FhirDateTime bzzzzzzzq_ = R?.AuthoredOnElement;
                    CqlDateTime bzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzq_);
                    CqlDate bzzzzzzzs_ = context.Operators.DateFrom(bzzzzzzzr_);
                    MedicationRequest.DispenseRequestComponent bzzzzzzzt_ = R?.DispenseRequest;
                    Period bzzzzzzzu_ = bzzzzzzzt_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzu_);
                    CqlDateTime bzzzzzzzw_ = context.Operators.Start(bzzzzzzzv_);
                    CqlDate bzzzzzzzx_ = context.Operators.DateFrom(bzzzzzzzw_);
                    bool? bzzzzzzzy_ = context.Operators.Not((bool?)(((bzzzzzzzp_ ?? bzzzzzzzs_) ?? bzzzzzzzx_) is null));
                    Dosage czzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)bzzzzzzzi_);
                    Timing czzzzzzzb_ = czzzzzzza_?.Timing;
                    Timing.RepeatComponent czzzzzzzc_ = czzzzzzzb_?.Repeat;
                    DataType czzzzzzzd_ = czzzzzzzc_?.Bounds;
                    object czzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzd_);
                    CqlDateTime czzzzzzzf_ = (czzzzzzze_ as CqlInterval<CqlDateTime>)?.high;
                    bool? czzzzzzzg_ = context.Operators.Not((bool?)(czzzzzzzf_ is null));
                    bool? czzzzzzzh_ = context.Operators.And(bzzzzzzzy_, czzzzzzzg_);

                    return czzzzzzzh_ ?? false;
                };
                if (xzzzzzzz_())
                {
                    List<Dosage> czzzzzzzi_ = R?.DosageInstruction;
                    Dosage czzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing czzzzzzzk_ = czzzzzzzj_?.Timing;
                    Timing.RepeatComponent czzzzzzzl_ = czzzzzzzk_?.Repeat;
                    DataType czzzzzzzm_ = czzzzzzzl_?.Bounds;
                    object czzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzm_);
                    CqlDateTime czzzzzzzo_ = context.Operators.Start(czzzzzzzn_ as CqlInterval<CqlDateTime>);
                    CqlDate czzzzzzzp_ = context.Operators.DateFrom(czzzzzzzo_);
                    FhirDateTime czzzzzzzq_ = R?.AuthoredOnElement;
                    CqlDateTime czzzzzzzr_ = context.Operators.Convert<CqlDateTime>(czzzzzzzq_);
                    CqlDate czzzzzzzs_ = context.Operators.DateFrom(czzzzzzzr_);
                    MedicationRequest.DispenseRequestComponent czzzzzzzt_ = R?.DispenseRequest;
                    Period czzzzzzzu_ = czzzzzzzt_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> czzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzu_);
                    CqlDateTime czzzzzzzw_ = context.Operators.Start(czzzzzzzv_);
                    CqlDate czzzzzzzx_ = context.Operators.DateFrom(czzzzzzzw_);
                    Dosage czzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing dzzzzzzza_ = czzzzzzzz_?.Timing;
                    Timing.RepeatComponent dzzzzzzzb_ = dzzzzzzza_?.Repeat;
                    DataType dzzzzzzzc_ = dzzzzzzzb_?.Bounds;
                    object dzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzc_);
                    CqlDateTime dzzzzzzze_ = context.Operators.Start(dzzzzzzzd_ as CqlInterval<CqlDateTime>);
                    CqlDate dzzzzzzzf_ = context.Operators.DateFrom(dzzzzzzze_);
                    CqlDateTime dzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(czzzzzzzq_);
                    CqlDate dzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzh_);
                    Period dzzzzzzzk_ = czzzzzzzt_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzk_);
                    CqlDateTime dzzzzzzzm_ = context.Operators.Start(dzzzzzzzl_);
                    CqlDate dzzzzzzzn_ = context.Operators.DateFrom(dzzzzzzzm_);
                    Duration dzzzzzzzp_ = czzzzzzzt_?.ExpectedSupplyDuration;
                    CqlQuantity dzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzp_);
                    CqlQuantity dzzzzzzzr_ = context.Operators.ConvertQuantity(dzzzzzzzq_, "d");
                    decimal? dzzzzzzzs_ = dzzzzzzzr_?.value;
                    Quantity dzzzzzzzu_ = czzzzzzzt_?.Quantity;
                    CqlQuantity dzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzu_);
                    decimal? dzzzzzzzw_ = dzzzzzzzv_?.value;
                    Dosage dzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> dzzzzzzzz_ = dzzzzzzzy_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzzzza_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)dzzzzzzzz_);
                    DataType ezzzzzzzb_ = ezzzzzzza_?.Dose;
                    object ezzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzb_);
                    CqlQuantity ezzzzzzzd_ = context.Operators.End(ezzzzzzzc_ as CqlInterval<CqlQuantity>);
                    Dosage ezzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> ezzzzzzzg_ = ezzzzzzzf_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ezzzzzzzh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ezzzzzzzg_);
                    DataType ezzzzzzzi_ = ezzzzzzzh_?.Dose;
                    object ezzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzi_);
                    decimal? ezzzzzzzk_ = (ezzzzzzzd_ ?? ezzzzzzzj_ as CqlQuantity)?.value;
                    Dosage ezzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing ezzzzzzzn_ = ezzzzzzzm_?.Timing;
                    Timing.RepeatComponent ezzzzzzzo_ = ezzzzzzzn_?.Repeat;
                    PositiveInt ezzzzzzzp_ = ezzzzzzzo_?.FrequencyMaxElement;
                    int? ezzzzzzzq_ = ezzzzzzzp_?.Value;
                    Dosage ezzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing ezzzzzzzt_ = ezzzzzzzs_?.Timing;
                    Timing.RepeatComponent ezzzzzzzu_ = ezzzzzzzt_?.Repeat;
                    PositiveInt ezzzzzzzv_ = ezzzzzzzu_?.FrequencyElement;
                    int? ezzzzzzzw_ = ezzzzzzzv_?.Value;
                    Dosage ezzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing ezzzzzzzz_ = ezzzzzzzy_?.Timing;
                    Timing.RepeatComponent fzzzzzzza_ = ezzzzzzzz_?.Repeat;
                    FhirDecimal fzzzzzzzb_ = fzzzzzzza_?.PeriodElement;
                    decimal? fzzzzzzzc_ = fzzzzzzzb_?.Value;
                    Dosage fzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing fzzzzzzzf_ = fzzzzzzze_?.Timing;
                    Timing.RepeatComponent fzzzzzzzg_ = fzzzzzzzf_?.Repeat;
                    Code<Timing.UnitsOfTime> fzzzzzzzh_ = fzzzzzzzg_?.PeriodUnitElement;
                    Timing.UnitsOfTime? fzzzzzzzi_ = fzzzzzzzh_?.Value;
                    string fzzzzzzzj_ = context.Operators.Convert<string>(fzzzzzzzi_);
                    CqlQuantity fzzzzzzzk_ = this.Quantity(context, fzzzzzzzc_, fzzzzzzzj_);
                    decimal? fzzzzzzzl_ = this.ToDaily(context, ezzzzzzzq_ ?? ezzzzzzzw_, fzzzzzzzk_);
                    Dosage fzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)czzzzzzzi_);
                    Timing fzzzzzzzo_ = fzzzzzzzn_?.Timing;
                    Timing.RepeatComponent fzzzzzzzp_ = fzzzzzzzo_?.Repeat;
                    List<Time> fzzzzzzzq_ = fzzzzzzzp_?.TimeOfDayElement;
                    IEnumerable<CqlTime> fzzzzzzzr_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(fzzzzzzzq_, "value");
                    int? fzzzzzzzs_ = context.Operators.Count<CqlTime>(fzzzzzzzr_);
                    decimal? fzzzzzzzt_ = context.Operators.ConvertIntegerToDecimal(fzzzzzzzs_);
                    decimal? fzzzzzzzu_ = context.Operators.Multiply(ezzzzzzzk_, (fzzzzzzzl_ ?? fzzzzzzzt_) ?? 1.0m);
                    decimal? fzzzzzzzv_ = context.Operators.Divide(dzzzzzzzw_, fzzzzzzzu_);
                    UnsignedInt fzzzzzzzx_ = czzzzzzzt_?.NumberOfRepeatsAllowedElement;
                    int? fzzzzzzzy_ = fzzzzzzzx_?.Value;
                    int? fzzzzzzzz_ = context.Operators.Add(1, fzzzzzzzy_ ?? 0);
                    decimal? gzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(fzzzzzzzz_);
                    decimal? gzzzzzzzb_ = context.Operators.Multiply(dzzzzzzzs_ ?? fzzzzzzzv_, gzzzzzzza_);
                    decimal? gzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? gzzzzzzzd_ = context.Operators.Subtract(gzzzzzzzb_, gzzzzzzzc_);
                    CqlQuantity gzzzzzzze_ = this.Quantity(context, gzzzzzzzd_, "day");
                    CqlDate gzzzzzzzf_ = context.Operators.Add((dzzzzzzzf_ ?? dzzzzzzzi_) ?? dzzzzzzzn_, gzzzzzzze_);
                    CqlInterval<CqlDate> gzzzzzzzg_ = context.Operators.Interval((czzzzzzzp_ ?? czzzzzzzs_) ?? czzzzzzzx_, gzzzzzzzf_, true, true);

                    return gzzzzzzzg_;
                }
                else if (yzzzzzza_())
                {
                    List<Dosage> gzzzzzzzh_ = R?.DosageInstruction;
                    Dosage gzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzh_);
                    Timing gzzzzzzzj_ = gzzzzzzzi_?.Timing;
                    Timing.RepeatComponent gzzzzzzzk_ = gzzzzzzzj_?.Repeat;
                    DataType gzzzzzzzl_ = gzzzzzzzk_?.Bounds;
                    object gzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzl_);
                    CqlDateTime gzzzzzzzn_ = context.Operators.Start(gzzzzzzzm_ as CqlInterval<CqlDateTime>);
                    CqlDate gzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzn_);
                    FhirDateTime gzzzzzzzp_ = R?.AuthoredOnElement;
                    CqlDateTime gzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzp_);
                    CqlDate gzzzzzzzr_ = context.Operators.DateFrom(gzzzzzzzq_);
                    MedicationRequest.DispenseRequestComponent gzzzzzzzs_ = R?.DispenseRequest;
                    Period gzzzzzzzt_ = gzzzzzzzs_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> gzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzt_);
                    CqlDateTime gzzzzzzzv_ = context.Operators.Start(gzzzzzzzu_);
                    CqlDate gzzzzzzzw_ = context.Operators.DateFrom(gzzzzzzzv_);
                    Dosage gzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)gzzzzzzzh_);
                    Timing gzzzzzzzz_ = gzzzzzzzy_?.Timing;
                    Timing.RepeatComponent hzzzzzzza_ = gzzzzzzzz_?.Repeat;
                    DataType hzzzzzzzb_ = hzzzzzzza_?.Bounds;
                    object hzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzb_);
                    CqlDateTime hzzzzzzzd_ = context.Operators.End(hzzzzzzzc_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzze_ = context.Operators.DateFrom(hzzzzzzzd_);
                    CqlInterval<CqlDate> hzzzzzzzf_ = context.Operators.Interval((gzzzzzzzo_ ?? gzzzzzzzr_) ?? gzzzzzzzw_, hzzzzzzze_, true, true);

                    return hzzzzzzzf_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return xzzzzzzy_();
        };
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzv_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)xzzzzzzt_, xzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzzzv_);
        CqlInterval<CqlDate> xzzzzzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(xzzzzzzw_);

        return xzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] hzzzzzzzg_ = [
            Request,
        ];
        CqlInterval<CqlDate> hzzzzzzzh_(MedicationRequest R)
        {
            CqlInterval<CqlDate> hzzzzzzzl_()
            {
                bool hzzzzzzzm_()
                {
                    List<Dosage> hzzzzzzzo_ = R?.DosageInstruction;
                    Dosage hzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing hzzzzzzzq_ = hzzzzzzzp_?.Timing;
                    Timing.RepeatComponent hzzzzzzzr_ = hzzzzzzzq_?.Repeat;
                    DataType hzzzzzzzs_ = hzzzzzzzr_?.Bounds;
                    object hzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzs_);
                    CqlDateTime hzzzzzzzu_ = context.Operators.Start(hzzzzzzzt_ as CqlInterval<CqlDateTime>);
                    CqlDate hzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzu_);
                    FhirDateTime hzzzzzzzw_ = R?.AuthoredOnElement;
                    CqlDateTime hzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzw_);
                    CqlDate hzzzzzzzy_ = context.Operators.DateFrom(hzzzzzzzx_);
                    MedicationRequest.DispenseRequestComponent hzzzzzzzz_ = R?.DispenseRequest;
                    Period izzzzzzza_ = hzzzzzzzz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> izzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzza_);
                    CqlDateTime izzzzzzzc_ = context.Operators.Start(izzzzzzzb_);
                    CqlDate izzzzzzzd_ = context.Operators.DateFrom(izzzzzzzc_);
                    bool? izzzzzzze_ = context.Operators.Not((bool?)(((hzzzzzzzv_ ?? hzzzzzzzy_) ?? izzzzzzzd_) is null));
                    Duration izzzzzzzg_ = hzzzzzzzz_?.ExpectedSupplyDuration;
                    CqlQuantity izzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzg_);
                    CqlQuantity izzzzzzzi_ = context.Operators.ConvertQuantity(izzzzzzzh_, "d");
                    decimal? izzzzzzzj_ = izzzzzzzi_?.value;
                    Quantity izzzzzzzl_ = hzzzzzzzz_?.Quantity;
                    CqlQuantity izzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, izzzzzzzl_);
                    decimal? izzzzzzzn_ = izzzzzzzm_?.value;
                    Dosage izzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> izzzzzzzq_ = izzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzzzzq_);
                    DataType izzzzzzzs_ = izzzzzzzr_?.Dose;
                    object izzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzs_);
                    CqlQuantity izzzzzzzu_ = context.Operators.End(izzzzzzzt_ as CqlInterval<CqlQuantity>);
                    Dosage izzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> izzzzzzzx_ = izzzzzzzw_?.DoseAndRate;
                    Dosage.DoseAndRateComponent izzzzzzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)izzzzzzzx_);
                    DataType izzzzzzzz_ = izzzzzzzy_?.Dose;
                    object jzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzz_);
                    decimal? jzzzzzzzb_ = (izzzzzzzu_ ?? jzzzzzzza_ as CqlQuantity)?.value;
                    Dosage jzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing jzzzzzzze_ = jzzzzzzzd_?.Timing;
                    Timing.RepeatComponent jzzzzzzzf_ = jzzzzzzze_?.Repeat;
                    PositiveInt jzzzzzzzg_ = jzzzzzzzf_?.FrequencyMaxElement;
                    int? jzzzzzzzh_ = jzzzzzzzg_?.Value;
                    Dosage jzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing jzzzzzzzk_ = jzzzzzzzj_?.Timing;
                    Timing.RepeatComponent jzzzzzzzl_ = jzzzzzzzk_?.Repeat;
                    PositiveInt jzzzzzzzm_ = jzzzzzzzl_?.FrequencyElement;
                    int? jzzzzzzzn_ = jzzzzzzzm_?.Value;
                    Dosage jzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing jzzzzzzzq_ = jzzzzzzzp_?.Timing;
                    Timing.RepeatComponent jzzzzzzzr_ = jzzzzzzzq_?.Repeat;
                    FhirDecimal jzzzzzzzs_ = jzzzzzzzr_?.PeriodElement;
                    decimal? jzzzzzzzt_ = jzzzzzzzs_?.Value;
                    Dosage jzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing jzzzzzzzw_ = jzzzzzzzv_?.Timing;
                    Timing.RepeatComponent jzzzzzzzx_ = jzzzzzzzw_?.Repeat;
                    Code<Timing.UnitsOfTime> jzzzzzzzy_ = jzzzzzzzx_?.PeriodUnitElement;
                    Timing.UnitsOfTime? jzzzzzzzz_ = jzzzzzzzy_?.Value;
                    string kzzzzzzza_ = context.Operators.Convert<string>(jzzzzzzzz_);
                    CqlQuantity kzzzzzzzb_ = this.Quantity(context, jzzzzzzzt_, kzzzzzzza_);
                    decimal? kzzzzzzzc_ = this.ToDaily(context, jzzzzzzzh_ ?? jzzzzzzzn_, kzzzzzzzb_);
                    Dosage kzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)hzzzzzzzo_);
                    Timing kzzzzzzzf_ = kzzzzzzze_?.Timing;
                    Timing.RepeatComponent kzzzzzzzg_ = kzzzzzzzf_?.Repeat;
                    List<Time> kzzzzzzzh_ = kzzzzzzzg_?.TimeOfDayElement;
                    IEnumerable<CqlTime> kzzzzzzzi_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(kzzzzzzzh_, "value");
                    int? kzzzzzzzj_ = context.Operators.Count<CqlTime>(kzzzzzzzi_);
                    decimal? kzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzj_);
                    decimal? kzzzzzzzl_ = context.Operators.Multiply(jzzzzzzzb_, (kzzzzzzzc_ ?? kzzzzzzzk_) ?? 1.0m);
                    decimal? kzzzzzzzm_ = context.Operators.Divide(izzzzzzzn_, kzzzzzzzl_);
                    UnsignedInt kzzzzzzzo_ = hzzzzzzzz_?.NumberOfRepeatsAllowedElement;
                    int? kzzzzzzzp_ = kzzzzzzzo_?.Value;
                    int? kzzzzzzzq_ = context.Operators.Add(1, kzzzzzzzp_ ?? 0);
                    decimal? kzzzzzzzr_ = context.Operators.ConvertIntegerToDecimal(kzzzzzzzq_);
                    decimal? kzzzzzzzs_ = context.Operators.Multiply(izzzzzzzj_ ?? kzzzzzzzm_, kzzzzzzzr_);
                    bool? kzzzzzzzt_ = context.Operators.Not((bool?)(kzzzzzzzs_ is null));
                    bool? kzzzzzzzu_ = context.Operators.And(izzzzzzze_, kzzzzzzzt_);

                    return kzzzzzzzu_ ?? false;
                };
                bool hzzzzzzzn_()
                {
                    List<Dosage> kzzzzzzzv_ = R?.DosageInstruction;
                    Dosage kzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzv_);
                    Timing kzzzzzzzx_ = kzzzzzzzw_?.Timing;
                    Timing.RepeatComponent kzzzzzzzy_ = kzzzzzzzx_?.Repeat;
                    DataType kzzzzzzzz_ = kzzzzzzzy_?.Bounds;
                    object lzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzz_);
                    CqlDateTime lzzzzzzzb_ = context.Operators.Start(lzzzzzzza_ as CqlInterval<CqlDateTime>);
                    CqlDate lzzzzzzzc_ = context.Operators.DateFrom(lzzzzzzzb_);
                    FhirDateTime lzzzzzzzd_ = R?.AuthoredOnElement;
                    CqlDateTime lzzzzzzze_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzd_);
                    CqlDate lzzzzzzzf_ = context.Operators.DateFrom(lzzzzzzze_);
                    MedicationRequest.DispenseRequestComponent lzzzzzzzg_ = R?.DispenseRequest;
                    Period lzzzzzzzh_ = lzzzzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> lzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzh_);
                    CqlDateTime lzzzzzzzj_ = context.Operators.Start(lzzzzzzzi_);
                    CqlDate lzzzzzzzk_ = context.Operators.DateFrom(lzzzzzzzj_);
                    bool? lzzzzzzzl_ = context.Operators.Not((bool?)(((lzzzzzzzc_ ?? lzzzzzzzf_) ?? lzzzzzzzk_) is null));
                    Dosage lzzzzzzzn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)kzzzzzzzv_);
                    Timing lzzzzzzzo_ = lzzzzzzzn_?.Timing;
                    Timing.RepeatComponent lzzzzzzzp_ = lzzzzzzzo_?.Repeat;
                    DataType lzzzzzzzq_ = lzzzzzzzp_?.Bounds;
                    object lzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzq_);
                    CqlDateTime lzzzzzzzs_ = (lzzzzzzzr_ as CqlInterval<CqlDateTime>)?.high;
                    bool? lzzzzzzzt_ = context.Operators.Not((bool?)(lzzzzzzzs_ is null));
                    bool? lzzzzzzzu_ = context.Operators.And(lzzzzzzzl_, lzzzzzzzt_);

                    return lzzzzzzzu_ ?? false;
                };
                if (hzzzzzzzm_())
                {
                    List<Dosage> lzzzzzzzv_ = R?.DosageInstruction;
                    Dosage lzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing lzzzzzzzx_ = lzzzzzzzw_?.Timing;
                    Timing.RepeatComponent lzzzzzzzy_ = lzzzzzzzx_?.Repeat;
                    DataType lzzzzzzzz_ = lzzzzzzzy_?.Bounds;
                    object mzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzz_);
                    CqlDateTime mzzzzzzzb_ = context.Operators.Start(mzzzzzzza_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzc_ = context.Operators.DateFrom(mzzzzzzzb_);
                    FhirDateTime mzzzzzzzd_ = R?.AuthoredOnElement;
                    CqlDateTime mzzzzzzze_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzd_);
                    CqlDate mzzzzzzzf_ = context.Operators.DateFrom(mzzzzzzze_);
                    MedicationRequest.DispenseRequestComponent mzzzzzzzg_ = R?.DispenseRequest;
                    Period mzzzzzzzh_ = mzzzzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> mzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzh_);
                    CqlDateTime mzzzzzzzj_ = context.Operators.Start(mzzzzzzzi_);
                    CqlDate mzzzzzzzk_ = context.Operators.DateFrom(mzzzzzzzj_);
                    Dosage mzzzzzzzm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing mzzzzzzzn_ = mzzzzzzzm_?.Timing;
                    Timing.RepeatComponent mzzzzzzzo_ = mzzzzzzzn_?.Repeat;
                    DataType mzzzzzzzp_ = mzzzzzzzo_?.Bounds;
                    object mzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzp_);
                    CqlDateTime mzzzzzzzr_ = context.Operators.Start(mzzzzzzzq_ as CqlInterval<CqlDateTime>);
                    CqlDate mzzzzzzzs_ = context.Operators.DateFrom(mzzzzzzzr_);
                    CqlDateTime mzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzd_);
                    CqlDate mzzzzzzzv_ = context.Operators.DateFrom(mzzzzzzzu_);
                    Period mzzzzzzzx_ = mzzzzzzzg_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> mzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzx_);
                    CqlDateTime mzzzzzzzz_ = context.Operators.Start(mzzzzzzzy_);
                    CqlDate nzzzzzzza_ = context.Operators.DateFrom(mzzzzzzzz_);
                    Duration nzzzzzzzc_ = mzzzzzzzg_?.ExpectedSupplyDuration;
                    CqlQuantity nzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzc_);
                    CqlQuantity nzzzzzzze_ = context.Operators.ConvertQuantity(nzzzzzzzd_, "d");
                    decimal? nzzzzzzzf_ = nzzzzzzze_?.value;
                    Quantity nzzzzzzzh_ = mzzzzzzzg_?.Quantity;
                    CqlQuantity nzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzh_);
                    decimal? nzzzzzzzj_ = nzzzzzzzi_?.value;
                    Dosage nzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    List<Dosage.DoseAndRateComponent> nzzzzzzzm_ = nzzzzzzzl_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzzzzn_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzzzzm_);
                    DataType nzzzzzzzo_ = nzzzzzzzn_?.Dose;
                    object nzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzo_);
                    CqlQuantity nzzzzzzzq_ = context.Operators.End(nzzzzzzzp_ as CqlInterval<CqlQuantity>);
                    Dosage nzzzzzzzs_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    List<Dosage.DoseAndRateComponent> nzzzzzzzt_ = nzzzzzzzs_?.DoseAndRate;
                    Dosage.DoseAndRateComponent nzzzzzzzu_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)nzzzzzzzt_);
                    DataType nzzzzzzzv_ = nzzzzzzzu_?.Dose;
                    object nzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzv_);
                    decimal? nzzzzzzzx_ = (nzzzzzzzq_ ?? nzzzzzzzw_ as CqlQuantity)?.value;
                    Dosage nzzzzzzzz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing ozzzzzzza_ = nzzzzzzzz_?.Timing;
                    Timing.RepeatComponent ozzzzzzzb_ = ozzzzzzza_?.Repeat;
                    PositiveInt ozzzzzzzc_ = ozzzzzzzb_?.FrequencyMaxElement;
                    int? ozzzzzzzd_ = ozzzzzzzc_?.Value;
                    Dosage ozzzzzzzf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing ozzzzzzzg_ = ozzzzzzzf_?.Timing;
                    Timing.RepeatComponent ozzzzzzzh_ = ozzzzzzzg_?.Repeat;
                    PositiveInt ozzzzzzzi_ = ozzzzzzzh_?.FrequencyElement;
                    int? ozzzzzzzj_ = ozzzzzzzi_?.Value;
                    Dosage ozzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing ozzzzzzzm_ = ozzzzzzzl_?.Timing;
                    Timing.RepeatComponent ozzzzzzzn_ = ozzzzzzzm_?.Repeat;
                    FhirDecimal ozzzzzzzo_ = ozzzzzzzn_?.PeriodElement;
                    decimal? ozzzzzzzp_ = ozzzzzzzo_?.Value;
                    Dosage ozzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing ozzzzzzzs_ = ozzzzzzzr_?.Timing;
                    Timing.RepeatComponent ozzzzzzzt_ = ozzzzzzzs_?.Repeat;
                    Code<Timing.UnitsOfTime> ozzzzzzzu_ = ozzzzzzzt_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ozzzzzzzv_ = ozzzzzzzu_?.Value;
                    string ozzzzzzzw_ = context.Operators.Convert<string>(ozzzzzzzv_);
                    CqlQuantity ozzzzzzzx_ = this.Quantity(context, ozzzzzzzp_, ozzzzzzzw_);
                    decimal? ozzzzzzzy_ = this.ToDaily(context, ozzzzzzzd_ ?? ozzzzzzzj_, ozzzzzzzx_);
                    Dosage pzzzzzzza_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)lzzzzzzzv_);
                    Timing pzzzzzzzb_ = pzzzzzzza_?.Timing;
                    Timing.RepeatComponent pzzzzzzzc_ = pzzzzzzzb_?.Repeat;
                    List<Time> pzzzzzzzd_ = pzzzzzzzc_?.TimeOfDayElement;
                    IEnumerable<CqlTime> pzzzzzzze_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(pzzzzzzzd_, "value");
                    int? pzzzzzzzf_ = context.Operators.Count<CqlTime>(pzzzzzzze_);
                    decimal? pzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzf_);
                    decimal? pzzzzzzzh_ = context.Operators.Multiply(nzzzzzzzx_, (ozzzzzzzy_ ?? pzzzzzzzg_) ?? 1.0m);
                    decimal? pzzzzzzzi_ = context.Operators.Divide(nzzzzzzzj_, pzzzzzzzh_);
                    UnsignedInt pzzzzzzzk_ = mzzzzzzzg_?.NumberOfRepeatsAllowedElement;
                    int? pzzzzzzzl_ = pzzzzzzzk_?.Value;
                    int? pzzzzzzzm_ = context.Operators.Add(1, pzzzzzzzl_ ?? 0);
                    decimal? pzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(pzzzzzzzm_);
                    decimal? pzzzzzzzo_ = context.Operators.Multiply(nzzzzzzzf_ ?? pzzzzzzzi_, pzzzzzzzn_);
                    decimal? pzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? pzzzzzzzq_ = context.Operators.Subtract(pzzzzzzzo_, pzzzzzzzp_);
                    CqlQuantity pzzzzzzzr_ = this.Quantity(context, pzzzzzzzq_, "day");
                    CqlDate pzzzzzzzs_ = context.Operators.Add((mzzzzzzzs_ ?? mzzzzzzzv_) ?? nzzzzzzza_, pzzzzzzzr_);
                    CqlInterval<CqlDate> pzzzzzzzt_ = context.Operators.Interval((mzzzzzzzc_ ?? mzzzzzzzf_) ?? mzzzzzzzk_, pzzzzzzzs_, true, true);

                    return pzzzzzzzt_;
                }
                else if (hzzzzzzzn_())
                {
                    List<Dosage> pzzzzzzzu_ = R?.DosageInstruction;
                    Dosage pzzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzu_);
                    Timing pzzzzzzzw_ = pzzzzzzzv_?.Timing;
                    Timing.RepeatComponent pzzzzzzzx_ = pzzzzzzzw_?.Repeat;
                    DataType pzzzzzzzy_ = pzzzzzzzx_?.Bounds;
                    object pzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzy_);
                    CqlDateTime qzzzzzzza_ = context.Operators.Start(pzzzzzzzz_ as CqlInterval<CqlDateTime>);
                    CqlDate qzzzzzzzb_ = context.Operators.DateFrom(qzzzzzzza_);
                    FhirDateTime qzzzzzzzc_ = R?.AuthoredOnElement;
                    CqlDateTime qzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzc_);
                    CqlDate qzzzzzzze_ = context.Operators.DateFrom(qzzzzzzzd_);
                    MedicationRequest.DispenseRequestComponent qzzzzzzzf_ = R?.DispenseRequest;
                    Period qzzzzzzzg_ = qzzzzzzzf_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> qzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzg_);
                    CqlDateTime qzzzzzzzi_ = context.Operators.Start(qzzzzzzzh_);
                    CqlDate qzzzzzzzj_ = context.Operators.DateFrom(qzzzzzzzi_);
                    Dosage qzzzzzzzl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)pzzzzzzzu_);
                    Timing qzzzzzzzm_ = qzzzzzzzl_?.Timing;
                    Timing.RepeatComponent qzzzzzzzn_ = qzzzzzzzm_?.Repeat;
                    DataType qzzzzzzzo_ = qzzzzzzzn_?.Bounds;
                    object qzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzo_);
                    CqlDateTime qzzzzzzzq_ = context.Operators.End(qzzzzzzzp_ as CqlInterval<CqlDateTime>);
                    CqlDate qzzzzzzzr_ = context.Operators.DateFrom(qzzzzzzzq_);
                    CqlInterval<CqlDate> qzzzzzzzs_ = context.Operators.Interval((qzzzzzzzb_ ?? qzzzzzzze_) ?? qzzzzzzzj_, qzzzzzzzr_, true, true);

                    return qzzzzzzzs_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return hzzzzzzzl_();
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzi_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)hzzzzzzzg_, hzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzi_);
        CqlInterval<CqlDate> hzzzzzzzk_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(hzzzzzzzj_);

        return hzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] qzzzzzzzt_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> qzzzzzzzu_(MedicationDispense D)
        {
            CqlInterval<CqlDate> qzzzzzzzy_()
            {
                bool qzzzzzzzz_()
                {
                    FhirDateTime rzzzzzzza_ = D?.WhenHandedOverElement;
                    CqlDateTime rzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(rzzzzzzza_);
                    CqlDate rzzzzzzzc_ = context.Operators.DateFrom(rzzzzzzzb_);
                    FhirDateTime rzzzzzzzd_ = D?.WhenPreparedElement;
                    CqlDateTime rzzzzzzze_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzd_);
                    CqlDate rzzzzzzzf_ = context.Operators.DateFrom(rzzzzzzze_);
                    bool? rzzzzzzzg_ = context.Operators.Not((bool?)((rzzzzzzzc_ ?? rzzzzzzzf_) is null));
                    Quantity rzzzzzzzh_ = D?.DaysSupply;
                    CqlQuantity rzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzh_);
                    CqlQuantity rzzzzzzzj_ = context.Operators.ConvertQuantity(rzzzzzzzi_, "d");
                    decimal? rzzzzzzzk_ = rzzzzzzzj_?.value;
                    Quantity rzzzzzzzl_ = D?.Quantity;
                    CqlQuantity rzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzl_);
                    decimal? rzzzzzzzn_ = rzzzzzzzm_?.value;
                    List<Dosage> rzzzzzzzo_ = D?.DosageInstruction;
                    Dosage rzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> rzzzzzzzq_ = rzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent rzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)rzzzzzzzq_);
                    DataType rzzzzzzzs_ = rzzzzzzzr_?.Dose;
                    object rzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzs_);
                    CqlQuantity rzzzzzzzu_ = context.Operators.End(rzzzzzzzt_ as CqlInterval<CqlQuantity>);
                    Dosage rzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    List<Dosage.DoseAndRateComponent> rzzzzzzzx_ = rzzzzzzzw_?.DoseAndRate;
                    Dosage.DoseAndRateComponent rzzzzzzzy_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)rzzzzzzzx_);
                    DataType rzzzzzzzz_ = rzzzzzzzy_?.Dose;
                    object szzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzz_);
                    decimal? szzzzzzzb_ = (rzzzzzzzu_ ?? szzzzzzza_ as CqlQuantity)?.value;
                    Dosage szzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    Timing szzzzzzze_ = szzzzzzzd_?.Timing;
                    Timing.RepeatComponent szzzzzzzf_ = szzzzzzze_?.Repeat;
                    PositiveInt szzzzzzzg_ = szzzzzzzf_?.FrequencyMaxElement;
                    int? szzzzzzzh_ = szzzzzzzg_?.Value;
                    Dosage szzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    Timing szzzzzzzk_ = szzzzzzzj_?.Timing;
                    Timing.RepeatComponent szzzzzzzl_ = szzzzzzzk_?.Repeat;
                    PositiveInt szzzzzzzm_ = szzzzzzzl_?.FrequencyElement;
                    int? szzzzzzzn_ = szzzzzzzm_?.Value;
                    Dosage szzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    Timing szzzzzzzq_ = szzzzzzzp_?.Timing;
                    Timing.RepeatComponent szzzzzzzr_ = szzzzzzzq_?.Repeat;
                    FhirDecimal szzzzzzzs_ = szzzzzzzr_?.PeriodElement;
                    decimal? szzzzzzzt_ = szzzzzzzs_?.Value;
                    Dosage szzzzzzzv_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    Timing szzzzzzzw_ = szzzzzzzv_?.Timing;
                    Timing.RepeatComponent szzzzzzzx_ = szzzzzzzw_?.Repeat;
                    Code<Timing.UnitsOfTime> szzzzzzzy_ = szzzzzzzx_?.PeriodUnitElement;
                    Timing.UnitsOfTime? szzzzzzzz_ = szzzzzzzy_?.Value;
                    string tzzzzzzza_ = context.Operators.Convert<string>(szzzzzzzz_);
                    CqlQuantity tzzzzzzzb_ = this.Quantity(context, szzzzzzzt_, tzzzzzzza_);
                    decimal? tzzzzzzzc_ = this.ToDaily(context, szzzzzzzh_ ?? szzzzzzzn_, tzzzzzzzb_);
                    Dosage tzzzzzzze_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)rzzzzzzzo_);
                    Timing tzzzzzzzf_ = tzzzzzzze_?.Timing;
                    Timing.RepeatComponent tzzzzzzzg_ = tzzzzzzzf_?.Repeat;
                    List<Time> tzzzzzzzh_ = tzzzzzzzg_?.TimeOfDayElement;
                    IEnumerable<CqlTime> tzzzzzzzi_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(tzzzzzzzh_, "value");
                    int? tzzzzzzzj_ = context.Operators.Count<CqlTime>(tzzzzzzzi_);
                    decimal? tzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(tzzzzzzzj_);
                    decimal? tzzzzzzzl_ = context.Operators.Multiply(szzzzzzzb_, (tzzzzzzzc_ ?? tzzzzzzzk_) ?? 1.0m);
                    decimal? tzzzzzzzm_ = context.Operators.Divide(rzzzzzzzn_, tzzzzzzzl_);
                    bool? tzzzzzzzn_ = context.Operators.Not((bool?)((rzzzzzzzk_ ?? tzzzzzzzm_) is null));
                    bool? tzzzzzzzo_ = context.Operators.And(rzzzzzzzg_, tzzzzzzzn_);

                    return tzzzzzzzo_ ?? false;
                };
                if (qzzzzzzzz_())
                {
                    FhirDateTime tzzzzzzzp_ = D?.WhenHandedOverElement;
                    CqlDateTime tzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzp_);
                    CqlDate tzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzq_);
                    FhirDateTime tzzzzzzzs_ = D?.WhenPreparedElement;
                    CqlDateTime tzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzs_);
                    CqlDate tzzzzzzzu_ = context.Operators.DateFrom(tzzzzzzzt_);
                    CqlDateTime tzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzp_);
                    CqlDate tzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzw_);
                    CqlDateTime tzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzs_);
                    CqlDate uzzzzzzza_ = context.Operators.DateFrom(tzzzzzzzz_);
                    Quantity uzzzzzzzb_ = D?.DaysSupply;
                    CqlQuantity uzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzb_);
                    CqlQuantity uzzzzzzzd_ = context.Operators.ConvertQuantity(uzzzzzzzc_, "d");
                    decimal? uzzzzzzze_ = uzzzzzzzd_?.value;
                    Quantity uzzzzzzzf_ = D?.Quantity;
                    CqlQuantity uzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzf_);
                    decimal? uzzzzzzzh_ = uzzzzzzzg_?.value;
                    List<Dosage> uzzzzzzzi_ = D?.DosageInstruction;
                    Dosage uzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzk_ = uzzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzk_);
                    DataType uzzzzzzzm_ = uzzzzzzzl_?.Dose;
                    object uzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzm_);
                    CqlQuantity uzzzzzzzo_ = context.Operators.End(uzzzzzzzn_ as CqlInterval<CqlQuantity>);
                    Dosage uzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    List<Dosage.DoseAndRateComponent> uzzzzzzzr_ = uzzzzzzzq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent uzzzzzzzs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)uzzzzzzzr_);
                    DataType uzzzzzzzt_ = uzzzzzzzs_?.Dose;
                    object uzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzt_);
                    decimal? uzzzzzzzv_ = (uzzzzzzzo_ ?? uzzzzzzzu_ as CqlQuantity)?.value;
                    Dosage uzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    Timing uzzzzzzzy_ = uzzzzzzzx_?.Timing;
                    Timing.RepeatComponent uzzzzzzzz_ = uzzzzzzzy_?.Repeat;
                    PositiveInt vzzzzzzza_ = uzzzzzzzz_?.FrequencyMaxElement;
                    int? vzzzzzzzb_ = vzzzzzzza_?.Value;
                    Dosage vzzzzzzzd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    Timing vzzzzzzze_ = vzzzzzzzd_?.Timing;
                    Timing.RepeatComponent vzzzzzzzf_ = vzzzzzzze_?.Repeat;
                    PositiveInt vzzzzzzzg_ = vzzzzzzzf_?.FrequencyElement;
                    int? vzzzzzzzh_ = vzzzzzzzg_?.Value;
                    Dosage vzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    Timing vzzzzzzzk_ = vzzzzzzzj_?.Timing;
                    Timing.RepeatComponent vzzzzzzzl_ = vzzzzzzzk_?.Repeat;
                    FhirDecimal vzzzzzzzm_ = vzzzzzzzl_?.PeriodElement;
                    decimal? vzzzzzzzn_ = vzzzzzzzm_?.Value;
                    Dosage vzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    Timing vzzzzzzzq_ = vzzzzzzzp_?.Timing;
                    Timing.RepeatComponent vzzzzzzzr_ = vzzzzzzzq_?.Repeat;
                    Code<Timing.UnitsOfTime> vzzzzzzzs_ = vzzzzzzzr_?.PeriodUnitElement;
                    Timing.UnitsOfTime? vzzzzzzzt_ = vzzzzzzzs_?.Value;
                    string vzzzzzzzu_ = context.Operators.Convert<string>(vzzzzzzzt_);
                    CqlQuantity vzzzzzzzv_ = this.Quantity(context, vzzzzzzzn_, vzzzzzzzu_);
                    decimal? vzzzzzzzw_ = this.ToDaily(context, vzzzzzzzb_ ?? vzzzzzzzh_, vzzzzzzzv_);
                    Dosage vzzzzzzzy_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)uzzzzzzzi_);
                    Timing vzzzzzzzz_ = vzzzzzzzy_?.Timing;
                    Timing.RepeatComponent wzzzzzzza_ = vzzzzzzzz_?.Repeat;
                    List<Time> wzzzzzzzb_ = wzzzzzzza_?.TimeOfDayElement;
                    IEnumerable<CqlTime> wzzzzzzzc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(wzzzzzzzb_, "value");
                    int? wzzzzzzzd_ = context.Operators.Count<CqlTime>(wzzzzzzzc_);
                    decimal? wzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzd_);
                    decimal? wzzzzzzzf_ = context.Operators.Multiply(uzzzzzzzv_, (vzzzzzzzw_ ?? wzzzzzzze_) ?? 1.0m);
                    decimal? wzzzzzzzg_ = context.Operators.Divide(uzzzzzzzh_, wzzzzzzzf_);
                    decimal? wzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? wzzzzzzzi_ = context.Operators.Subtract(uzzzzzzze_ ?? wzzzzzzzg_, wzzzzzzzh_);
                    CqlQuantity wzzzzzzzj_ = this.Quantity(context, wzzzzzzzi_, "day");
                    CqlDate wzzzzzzzk_ = context.Operators.Add(tzzzzzzzx_ ?? uzzzzzzza_, wzzzzzzzj_);
                    CqlInterval<CqlDate> wzzzzzzzl_ = context.Operators.Interval(tzzzzzzzr_ ?? tzzzzzzzu_, wzzzzzzzk_, true, true);

                    return wzzzzzzzl_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return qzzzzzzzy_();
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzv_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)qzzzzzzzt_, qzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDate>>(qzzzzzzzv_);
        CqlInterval<CqlDate> qzzzzzzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(qzzzzzzzw_);

        return qzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] wzzzzzzzm_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> wzzzzzzzn_(MedicationDispense D)
        {
            CqlInterval<CqlDate> wzzzzzzzr_()
            {
                bool wzzzzzzzs_()
                {
                    FhirDateTime wzzzzzzzt_ = D?.WhenHandedOverElement;
                    CqlDateTime wzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzt_);
                    CqlDate wzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzu_);
                    FhirDateTime wzzzzzzzw_ = D?.WhenPreparedElement;
                    CqlDateTime wzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzw_);
                    CqlDate wzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzx_);
                    bool? wzzzzzzzz_ = context.Operators.Not((bool?)((wzzzzzzzv_ ?? wzzzzzzzy_) is null));
                    Quantity xzzzzzzza_ = D?.DaysSupply;
                    CqlQuantity xzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzza_);
                    CqlQuantity xzzzzzzzc_ = context.Operators.ConvertQuantity(xzzzzzzzb_, "d");
                    decimal? xzzzzzzzd_ = xzzzzzzzc_?.value;
                    Quantity xzzzzzzze_ = D?.Quantity;
                    CqlQuantity xzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzze_);
                    decimal? xzzzzzzzg_ = xzzzzzzzf_?.value;
                    List<Dosage> xzzzzzzzh_ = D?.DosageInstruction;
                    Dosage xzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzj_ = xzzzzzzzi_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzk_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzj_);
                    DataType xzzzzzzzl_ = xzzzzzzzk_?.Dose;
                    object xzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzl_);
                    CqlQuantity xzzzzzzzn_ = context.Operators.End(xzzzzzzzm_ as CqlInterval<CqlQuantity>);
                    Dosage xzzzzzzzp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    List<Dosage.DoseAndRateComponent> xzzzzzzzq_ = xzzzzzzzp_?.DoseAndRate;
                    Dosage.DoseAndRateComponent xzzzzzzzr_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)xzzzzzzzq_);
                    DataType xzzzzzzzs_ = xzzzzzzzr_?.Dose;
                    object xzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzs_);
                    decimal? xzzzzzzzu_ = (xzzzzzzzn_ ?? xzzzzzzzt_ as CqlQuantity)?.value;
                    Dosage xzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    Timing xzzzzzzzx_ = xzzzzzzzw_?.Timing;
                    Timing.RepeatComponent xzzzzzzzy_ = xzzzzzzzx_?.Repeat;
                    PositiveInt xzzzzzzzz_ = xzzzzzzzy_?.FrequencyMaxElement;
                    int? yzzzzzzza_ = xzzzzzzzz_?.Value;
                    Dosage yzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    Timing yzzzzzzzd_ = yzzzzzzzc_?.Timing;
                    Timing.RepeatComponent yzzzzzzze_ = yzzzzzzzd_?.Repeat;
                    PositiveInt yzzzzzzzf_ = yzzzzzzze_?.FrequencyElement;
                    int? yzzzzzzzg_ = yzzzzzzzf_?.Value;
                    Dosage yzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    Timing yzzzzzzzj_ = yzzzzzzzi_?.Timing;
                    Timing.RepeatComponent yzzzzzzzk_ = yzzzzzzzj_?.Repeat;
                    FhirDecimal yzzzzzzzl_ = yzzzzzzzk_?.PeriodElement;
                    decimal? yzzzzzzzm_ = yzzzzzzzl_?.Value;
                    Dosage yzzzzzzzo_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    Timing yzzzzzzzp_ = yzzzzzzzo_?.Timing;
                    Timing.RepeatComponent yzzzzzzzq_ = yzzzzzzzp_?.Repeat;
                    Code<Timing.UnitsOfTime> yzzzzzzzr_ = yzzzzzzzq_?.PeriodUnitElement;
                    Timing.UnitsOfTime? yzzzzzzzs_ = yzzzzzzzr_?.Value;
                    string yzzzzzzzt_ = context.Operators.Convert<string>(yzzzzzzzs_);
                    CqlQuantity yzzzzzzzu_ = this.Quantity(context, yzzzzzzzm_, yzzzzzzzt_);
                    decimal? yzzzzzzzv_ = this.ToDaily(context, yzzzzzzza_ ?? yzzzzzzzg_, yzzzzzzzu_);
                    Dosage yzzzzzzzx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)xzzzzzzzh_);
                    Timing yzzzzzzzy_ = yzzzzzzzx_?.Timing;
                    Timing.RepeatComponent yzzzzzzzz_ = yzzzzzzzy_?.Repeat;
                    List<Time> zzzzzzzza_ = yzzzzzzzz_?.TimeOfDayElement;
                    IEnumerable<CqlTime> zzzzzzzzb_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(zzzzzzzza_, "value");
                    int? zzzzzzzzc_ = context.Operators.Count<CqlTime>(zzzzzzzzb_);
                    decimal? zzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(zzzzzzzzc_);
                    decimal? zzzzzzzze_ = context.Operators.Multiply(xzzzzzzzu_, (yzzzzzzzv_ ?? zzzzzzzzd_) ?? 1.0m);
                    decimal? zzzzzzzzf_ = context.Operators.Divide(xzzzzzzzg_, zzzzzzzze_);
                    bool? zzzzzzzzg_ = context.Operators.Not((bool?)((xzzzzzzzd_ ?? zzzzzzzzf_) is null));
                    bool? zzzzzzzzh_ = context.Operators.And(wzzzzzzzz_, zzzzzzzzg_);

                    return zzzzzzzzh_ ?? false;
                };
                if (wzzzzzzzs_())
                {
                    FhirDateTime zzzzzzzzi_ = D?.WhenHandedOverElement;
                    CqlDateTime zzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzi_);
                    CqlDate zzzzzzzzk_ = context.Operators.DateFrom(zzzzzzzzj_);
                    FhirDateTime zzzzzzzzl_ = D?.WhenPreparedElement;
                    CqlDateTime zzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzl_);
                    CqlDate zzzzzzzzn_ = context.Operators.DateFrom(zzzzzzzzm_);
                    CqlDateTime zzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzi_);
                    CqlDate zzzzzzzzq_ = context.Operators.DateFrom(zzzzzzzzp_);
                    CqlDateTime zzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzl_);
                    CqlDate zzzzzzzzt_ = context.Operators.DateFrom(zzzzzzzzs_);
                    Quantity zzzzzzzzu_ = D?.DaysSupply;
                    CqlQuantity zzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzu_);
                    CqlQuantity zzzzzzzzw_ = context.Operators.ConvertQuantity(zzzzzzzzv_, "d");
                    decimal? zzzzzzzzx_ = zzzzzzzzw_?.value;
                    Quantity zzzzzzzzy_ = D?.Quantity;
                    CqlQuantity zzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzy_);
                    decimal? azzzzzzzza_ = zzzzzzzzz_?.value;
                    List<Dosage> azzzzzzzzb_ = D?.DosageInstruction;
                    Dosage azzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzd_ = azzzzzzzzc_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzze_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzd_);
                    DataType azzzzzzzzf_ = azzzzzzzze_?.Dose;
                    object azzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzf_);
                    CqlQuantity azzzzzzzzh_ = context.Operators.End(azzzzzzzzg_ as CqlInterval<CqlQuantity>);
                    Dosage azzzzzzzzj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    List<Dosage.DoseAndRateComponent> azzzzzzzzk_ = azzzzzzzzj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent azzzzzzzzl_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)azzzzzzzzk_);
                    DataType azzzzzzzzm_ = azzzzzzzzl_?.Dose;
                    object azzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzm_);
                    decimal? azzzzzzzzo_ = (azzzzzzzzh_ ?? azzzzzzzzn_ as CqlQuantity)?.value;
                    Dosage azzzzzzzzq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    Timing azzzzzzzzr_ = azzzzzzzzq_?.Timing;
                    Timing.RepeatComponent azzzzzzzzs_ = azzzzzzzzr_?.Repeat;
                    PositiveInt azzzzzzzzt_ = azzzzzzzzs_?.FrequencyMaxElement;
                    int? azzzzzzzzu_ = azzzzzzzzt_?.Value;
                    Dosage azzzzzzzzw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    Timing azzzzzzzzx_ = azzzzzzzzw_?.Timing;
                    Timing.RepeatComponent azzzzzzzzy_ = azzzzzzzzx_?.Repeat;
                    PositiveInt azzzzzzzzz_ = azzzzzzzzy_?.FrequencyElement;
                    int? bzzzzzzzza_ = azzzzzzzzz_?.Value;
                    Dosage bzzzzzzzzc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    Timing bzzzzzzzzd_ = bzzzzzzzzc_?.Timing;
                    Timing.RepeatComponent bzzzzzzzze_ = bzzzzzzzzd_?.Repeat;
                    FhirDecimal bzzzzzzzzf_ = bzzzzzzzze_?.PeriodElement;
                    decimal? bzzzzzzzzg_ = bzzzzzzzzf_?.Value;
                    Dosage bzzzzzzzzi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    Timing bzzzzzzzzj_ = bzzzzzzzzi_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzk_ = bzzzzzzzzj_?.Repeat;
                    Code<Timing.UnitsOfTime> bzzzzzzzzl_ = bzzzzzzzzk_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bzzzzzzzzm_ = bzzzzzzzzl_?.Value;
                    string bzzzzzzzzn_ = context.Operators.Convert<string>(bzzzzzzzzm_);
                    CqlQuantity bzzzzzzzzo_ = this.Quantity(context, bzzzzzzzzg_, bzzzzzzzzn_);
                    decimal? bzzzzzzzzp_ = this.ToDaily(context, azzzzzzzzu_ ?? bzzzzzzzza_, bzzzzzzzzo_);
                    Dosage bzzzzzzzzr_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)azzzzzzzzb_);
                    Timing bzzzzzzzzs_ = bzzzzzzzzr_?.Timing;
                    Timing.RepeatComponent bzzzzzzzzt_ = bzzzzzzzzs_?.Repeat;
                    List<Time> bzzzzzzzzu_ = bzzzzzzzzt_?.TimeOfDayElement;
                    IEnumerable<CqlTime> bzzzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bzzzzzzzzu_, "value");
                    int? bzzzzzzzzw_ = context.Operators.Count<CqlTime>(bzzzzzzzzv_);
                    decimal? bzzzzzzzzx_ = context.Operators.ConvertIntegerToDecimal(bzzzzzzzzw_);
                    decimal? bzzzzzzzzy_ = context.Operators.Multiply(azzzzzzzzo_, (bzzzzzzzzp_ ?? bzzzzzzzzx_) ?? 1.0m);
                    decimal? bzzzzzzzzz_ = context.Operators.Divide(azzzzzzzza_, bzzzzzzzzy_);
                    decimal? czzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? czzzzzzzzb_ = context.Operators.Subtract(zzzzzzzzx_ ?? bzzzzzzzzz_, czzzzzzzza_);
                    CqlQuantity czzzzzzzzc_ = this.Quantity(context, czzzzzzzzb_, "day");
                    CqlDate czzzzzzzzd_ = context.Operators.Add(zzzzzzzzq_ ?? zzzzzzzzt_, czzzzzzzzc_);
                    CqlInterval<CqlDate> czzzzzzzze_ = context.Operators.Interval(zzzzzzzzk_ ?? zzzzzzzzn_, czzzzzzzzd_, true, true);

                    return czzzzzzzze_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return wzzzzzzzr_();
        };
        IEnumerable<CqlInterval<CqlDate>> wzzzzzzzo_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)wzzzzzzzm_, wzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> wzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(wzzzzzzzo_);
        CqlInterval<CqlDate> wzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(wzzzzzzzp_);

        return wzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity czzzzzzzzf_ = context.Operators.Quantity(14m, "days");

        return czzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] czzzzzzzzg_ = [
            Administration,
        ];
        CqlInterval<CqlDate> czzzzzzzzh_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> czzzzzzzzl_()
            {
                bool czzzzzzzzm_()
                {
                    DataType czzzzzzzzn_ = Administration?.Effective;
                    object czzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzn_);
                    CqlDateTime czzzzzzzzp_ = context.Operators.Start(czzzzzzzzo_ as CqlInterval<CqlDateTime>);
                    CqlDate czzzzzzzzq_ = context.Operators.DateFrom(czzzzzzzzp_);
                    bool? czzzzzzzzr_ = context.Operators.Not((bool?)(czzzzzzzzq_ is null));
                    DataType czzzzzzzzs_ = Administration?.Medication;
                    object czzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzs_);
                    CqlQuantity czzzzzzzzu_ = this.TherapeuticDuration(context, czzzzzzzzt_ as CqlConcept);
                    bool? czzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzu_ is null));
                    bool? czzzzzzzzw_ = context.Operators.And(czzzzzzzzr_, czzzzzzzzv_);

                    return czzzzzzzzw_ ?? false;
                };
                if (czzzzzzzzm_())
                {
                    DataType czzzzzzzzx_ = Administration?.Effective;
                    object czzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzx_);
                    CqlDateTime czzzzzzzzz_ = context.Operators.Start(czzzzzzzzy_ as CqlInterval<CqlDateTime>);
                    CqlDate dzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzz_);
                    object dzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzx_);
                    CqlDateTime dzzzzzzzzd_ = context.Operators.Start(dzzzzzzzzc_ as CqlInterval<CqlDateTime>);
                    CqlDate dzzzzzzzze_ = context.Operators.DateFrom(dzzzzzzzzd_);
                    DataType dzzzzzzzzf_ = Administration?.Medication;
                    object dzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzf_);
                    CqlQuantity dzzzzzzzzh_ = this.TherapeuticDuration(context, dzzzzzzzzg_ as CqlConcept);
                    CqlDate dzzzzzzzzi_ = context.Operators.Add(dzzzzzzzze_, dzzzzzzzzh_);
                    CqlQuantity dzzzzzzzzj_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate dzzzzzzzzk_ = context.Operators.Subtract(dzzzzzzzzi_, dzzzzzzzzj_);
                    CqlInterval<CqlDate> dzzzzzzzzl_ = context.Operators.Interval(dzzzzzzzza_, dzzzzzzzzk_, true, true);

                    return dzzzzzzzzl_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return czzzzzzzzl_();
        };
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzi_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)czzzzzzzzg_, czzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDate>>(czzzzzzzzi_);
        CqlInterval<CqlDate> czzzzzzzzk_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(czzzzzzzzj_);

        return czzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] dzzzzzzzzm_ = [
            Administration,
        ];
        CqlInterval<CqlDate> dzzzzzzzzn_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> dzzzzzzzzr_()
            {
                bool dzzzzzzzzs_()
                {
                    DataType dzzzzzzzzt_ = Administration?.Effective;
                    object dzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzt_);
                    CqlDateTime dzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzu_ as CqlInterval<CqlDateTime>);
                    CqlDate dzzzzzzzzw_ = context.Operators.DateFrom(dzzzzzzzzv_);
                    bool? dzzzzzzzzx_ = context.Operators.Not((bool?)(dzzzzzzzzw_ is null));
                    DataType dzzzzzzzzy_ = Administration?.Medication;
                    object dzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzy_);
                    CqlQuantity ezzzzzzzza_ = this.TherapeuticDuration(context, dzzzzzzzzz_ as CqlConcept);
                    bool? ezzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzza_ is null));
                    bool? ezzzzzzzzc_ = context.Operators.And(dzzzzzzzzx_, ezzzzzzzzb_);

                    return ezzzzzzzzc_ ?? false;
                };
                if (dzzzzzzzzs_())
                {
                    DataType ezzzzzzzzd_ = Administration?.Effective;
                    object ezzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzd_);
                    CqlDateTime ezzzzzzzzf_ = context.Operators.Start(ezzzzzzzze_ as CqlInterval<CqlDateTime>);
                    CqlDate ezzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzf_);
                    object ezzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzd_);
                    CqlDateTime ezzzzzzzzj_ = context.Operators.Start(ezzzzzzzzi_ as CqlInterval<CqlDateTime>);
                    CqlDate ezzzzzzzzk_ = context.Operators.DateFrom(ezzzzzzzzj_);
                    DataType ezzzzzzzzl_ = Administration?.Medication;
                    object ezzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzl_);
                    CqlQuantity ezzzzzzzzn_ = this.TherapeuticDuration(context, ezzzzzzzzm_ as CqlConcept);
                    CqlDate ezzzzzzzzo_ = context.Operators.Add(ezzzzzzzzk_, ezzzzzzzzn_);
                    CqlQuantity ezzzzzzzzp_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ezzzzzzzzq_ = context.Operators.Subtract(ezzzzzzzzo_, ezzzzzzzzp_);
                    CqlInterval<CqlDate> ezzzzzzzzr_ = context.Operators.Interval(ezzzzzzzzg_, ezzzzzzzzq_, true, true);

                    return ezzzzzzzzr_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return dzzzzzzzzr_();
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzo_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)dzzzzzzzzm_, dzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzzzzo_);
        CqlInterval<CqlDate> dzzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(dzzzzzzzzp_);

        return dzzzzzzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? ezzzzzzzzs_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzt_ = context.Operators.Collapse(Intervals, "day");
                int? ezzzzzzzzu_(CqlInterval<CqlDate> X)
                {
                    CqlDate ezzzzzzzzx_ = context.Operators.Start(X);
                    CqlDate ezzzzzzzzy_ = context.Operators.End(X);
                    int? ezzzzzzzzz_ = context.Operators.DifferenceBetween(ezzzzzzzzx_, ezzzzzzzzy_, "day");
                    int? fzzzzzzzza_ = context.Operators.Add(ezzzzzzzzz_, 1);

                    return fzzzzzzzza_;
                };
                IEnumerable<int?> ezzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(ezzzzzzzzt_, ezzzzzzzzu_);
                int? ezzzzzzzzw_ = context.Operators.Sum(ezzzzzzzzv_);

                return ezzzzzzzzw_;
            }
            else
            {
                return default;
            }
        };

        return ezzzzzzzzs_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? fzzzzzzzzb_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzc_ = context.Operators.Collapse(Intervals, "day");
                int? fzzzzzzzzd_(CqlInterval<CqlDate> X)
                {
                    CqlDate fzzzzzzzzg_ = context.Operators.Start(X);
                    CqlDate fzzzzzzzzh_ = context.Operators.End(X);
                    int? fzzzzzzzzi_ = context.Operators.DifferenceBetween(fzzzzzzzzg_, fzzzzzzzzh_, "day");
                    int? fzzzzzzzzj_ = context.Operators.Add(fzzzzzzzzi_, 1);

                    return fzzzzzzzzj_;
                };
                IEnumerable<int?> fzzzzzzzze_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(fzzzzzzzzc_, fzzzzzzzzd_);
                int? fzzzzzzzzf_ = context.Operators.Sum(fzzzzzzzze_);

                return fzzzzzzzzf_;
            }
            else
            {
                return default;
            }
        };

        return fzzzzzzzzb_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzk_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] fzzzzzzzzm_ = [
                I,
            ];
            CqlInterval<CqlDate> fzzzzzzzzn_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> fzzzzzzzzt_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate fzzzzzzzzu_ = context.Operators.End(fzzzzzzzzt_);
                CqlQuantity fzzzzzzzzv_ = context.Operators.Quantity(1m, "day");
                CqlDate fzzzzzzzzw_ = context.Operators.Add(fzzzzzzzzu_, fzzzzzzzzv_);
                CqlDate fzzzzzzzzx_ = context.Operators.Start(X);
                CqlDate[] fzzzzzzzzy_ = [
                    fzzzzzzzzw_,
                    fzzzzzzzzx_,
                ];
                CqlDate fzzzzzzzzz_ = context.Operators.Max<CqlDate>(fzzzzzzzzy_ as IEnumerable<CqlDate>);
                CqlDate gzzzzzzzzb_ = context.Operators.End(fzzzzzzzzt_);
                CqlDate gzzzzzzzzd_ = context.Operators.Add(gzzzzzzzzb_, fzzzzzzzzv_);
                CqlDate[] gzzzzzzzzf_ = [
                    gzzzzzzzzd_,
                    fzzzzzzzzx_,
                ];
                CqlDate gzzzzzzzzg_ = context.Operators.Max<CqlDate>(gzzzzzzzzf_ as IEnumerable<CqlDate>);
                CqlDate gzzzzzzzzi_ = context.Operators.End(X);
                int? gzzzzzzzzj_ = context.Operators.DurationBetween(fzzzzzzzzx_, gzzzzzzzzi_, "day");
                decimal? gzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(gzzzzzzzzj_ ?? 0);
                CqlQuantity gzzzzzzzzl_ = this.Quantity(context, gzzzzzzzzk_, "day");
                CqlDate gzzzzzzzzm_ = context.Operators.Add(gzzzzzzzzg_, gzzzzzzzzl_);
                CqlInterval<CqlDate> gzzzzzzzzn_ = context.Operators.Interval(fzzzzzzzzz_, gzzzzzzzzm_, true, true);

                return gzzzzzzzzn_;
            };
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)fzzzzzzzzm_, fzzzzzzzzn_);
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(fzzzzzzzzo_);
            CqlInterval<CqlDate> fzzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(fzzzzzzzzp_);
            CqlInterval<CqlDate>[] fzzzzzzzzr_ = [
                fzzzzzzzzq_,
            ];
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzs_ = context.Operators.Union<CqlInterval<CqlDate>>(R, fzzzzzzzzr_ as IEnumerable<CqlInterval<CqlDate>>);

            return fzzzzzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzl_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, fzzzzzzzzk_, null as IEnumerable<CqlInterval<CqlDate>>);

        return fzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzo_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] gzzzzzzzzq_ = [
                I,
            ];
            CqlInterval<CqlDate> gzzzzzzzzr_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> gzzzzzzzzx_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate gzzzzzzzzy_ = context.Operators.End(gzzzzzzzzx_);
                CqlQuantity gzzzzzzzzz_ = context.Operators.Quantity(1m, "day");
                CqlDate hzzzzzzzza_ = context.Operators.Add(gzzzzzzzzy_, gzzzzzzzzz_);
                CqlDate hzzzzzzzzb_ = context.Operators.Start(X);
                CqlDate[] hzzzzzzzzc_ = [
                    hzzzzzzzza_,
                    hzzzzzzzzb_,
                ];
                CqlDate hzzzzzzzzd_ = context.Operators.Max<CqlDate>(hzzzzzzzzc_ as IEnumerable<CqlDate>);
                CqlDate hzzzzzzzzf_ = context.Operators.End(gzzzzzzzzx_);
                CqlDate hzzzzzzzzh_ = context.Operators.Add(hzzzzzzzzf_, gzzzzzzzzz_);
                CqlDate[] hzzzzzzzzj_ = [
                    hzzzzzzzzh_,
                    hzzzzzzzzb_,
                ];
                CqlDate hzzzzzzzzk_ = context.Operators.Max<CqlDate>(hzzzzzzzzj_ as IEnumerable<CqlDate>);
                CqlDate hzzzzzzzzm_ = context.Operators.End(X);
                int? hzzzzzzzzn_ = context.Operators.DurationBetween(hzzzzzzzzb_, hzzzzzzzzm_, "day");
                decimal? hzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(hzzzzzzzzn_ ?? 0);
                CqlQuantity hzzzzzzzzp_ = this.Quantity(context, hzzzzzzzzo_, "day");
                CqlDate hzzzzzzzzq_ = context.Operators.Add(hzzzzzzzzk_, hzzzzzzzzp_);
                CqlInterval<CqlDate> hzzzzzzzzr_ = context.Operators.Interval(hzzzzzzzzd_, hzzzzzzzzq_, true, true);

                return hzzzzzzzzr_;
            };
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzs_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)gzzzzzzzzq_, gzzzzzzzzr_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzs_);
            CqlInterval<CqlDate> gzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(gzzzzzzzzt_);
            CqlInterval<CqlDate>[] gzzzzzzzzv_ = [
                gzzzzzzzzu_,
            ];
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzw_ = context.Operators.Union<CqlInterval<CqlDate>>(R, gzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDate>>);

            return gzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzp_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, gzzzzzzzzo_, null as IEnumerable<CqlInterval<CqlDate>>);

        return gzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> hzzzzzzzzs_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> hzzzzzzzzt_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return hzzzzzzzzt_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> hzzzzzzzzu_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return hzzzzzzzzu_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return hzzzzzzzzs_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> hzzzzzzzzv_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> hzzzzzzzzw_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return hzzzzzzzzw_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> hzzzzzzzzx_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return hzzzzzzzzx_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return hzzzzzzzzv_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? hzzzzzzzzy_(object M)
        {
            bool izzzzzzzzl_ = M is MedicationRequest;

            return izzzzzzzzl_ as bool?;
        };
        IEnumerable<object> hzzzzzzzzz_ = context.Operators.Where<object>(Medications, hzzzzzzzzy_);
        CqlInterval<CqlDate> izzzzzzzza_(object M)
        {
            CqlInterval<CqlDate> izzzzzzzzm_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return izzzzzzzzm_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzb_ = context.Operators.Select<object, CqlInterval<CqlDate>>(hzzzzzzzzz_, izzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzb_);
        bool? izzzzzzzzd_(object M)
        {
            bool izzzzzzzzn_ = M is MedicationDispense;

            return izzzzzzzzn_ as bool?;
        };
        IEnumerable<object> izzzzzzzze_ = context.Operators.Where<object>(Medications, izzzzzzzzd_);
        CqlInterval<CqlDate> izzzzzzzzf_(object M)
        {
            CqlInterval<CqlDate> izzzzzzzzo_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return izzzzzzzzo_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzg_ = context.Operators.Select<object, CqlInterval<CqlDate>>(izzzzzzzze_, izzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzi_ = this.RolloutIntervals(context, izzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzj_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzzc_, izzzzzzzzi_);
        int? izzzzzzzzk_ = this.CumulativeDuration(context, izzzzzzzzj_);

        return izzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? izzzzzzzzp_(object M)
        {
            bool jzzzzzzzzc_ = M is MedicationRequest;

            return jzzzzzzzzc_ as bool?;
        };
        IEnumerable<object> izzzzzzzzq_ = context.Operators.Where<object>(Medications, izzzzzzzzp_);
        CqlInterval<CqlDate> izzzzzzzzr_(object M)
        {
            CqlInterval<CqlDate> jzzzzzzzzd_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return jzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzs_ = context.Operators.Select<object, CqlInterval<CqlDate>>(izzzzzzzzq_, izzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzs_);
        bool? izzzzzzzzu_(object M)
        {
            bool jzzzzzzzze_ = M is MedicationDispense;

            return jzzzzzzzze_ as bool?;
        };
        IEnumerable<object> izzzzzzzzv_ = context.Operators.Where<object>(Medications, izzzzzzzzu_);
        CqlInterval<CqlDate> izzzzzzzzw_(object M)
        {
            CqlInterval<CqlDate> jzzzzzzzzf_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return jzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzx_ = context.Operators.Select<object, CqlInterval<CqlDate>>(izzzzzzzzv_, izzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzz_ = this.rolloutIntervals(context, izzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzzt_, izzzzzzzzz_);
        int? jzzzzzzzzb_ = this.cumulativeDuration(context, jzzzzzzzza_);

        return jzzzzzzzzb_;
    }


    #endregion Expressions

}
