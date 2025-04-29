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
[CqlLibrary("QICoreCommon", "2.1.000")]
public partial class QICoreCommon_2_1_000 : ILibrary, ISingleton<QICoreCommon_2_1_000>
{
    private QICoreCommon_2_1_000() {}

    public static QICoreCommon_2_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "QICoreCommon";
    public string Version => "2.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region Codes

    #region Code: Birthdate
    [CqlCodeDefinition(
        definitionName: "Birthdate",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext context) => _Birthdate;

    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Dead
    [CqlCodeDefinition(
        definitionName: "Dead",
        codeId: "419099009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext context) => _Dead;

    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: ER
    [CqlCodeDefinition(
        definitionName: "ER",
        codeId: "ER",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext context) => _ER;

    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);
    #endregion

    #region Code: ICU
    [CqlCodeDefinition(
        definitionName: "ICU",
        codeId: "ICU",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext context) => _ICU;

    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);
    #endregion

    #region Code: Billing
    [CqlCodeDefinition(
        definitionName: "Billing",
        codeId: "billing",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext context) => _Billing;

    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: ambulatory
    [CqlCodeDefinition(
        definitionName: "ambulatory",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode ambulatory(CqlContext context) => _ambulatory;

    private static readonly CqlCode _ambulatory = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: emergency
    [CqlCodeDefinition(
        definitionName: "emergency",
        codeId: "EMER",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode emergency(CqlContext context) => _emergency;

    private static readonly CqlCode _emergency = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: field
    [CqlCodeDefinition(
        definitionName: "field",
        codeId: "FLD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode field(CqlContext context) => _field;

    private static readonly CqlCode _field = new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: home health
    [CqlCodeDefinition(
        definitionName: "home health",
        codeId: "HH",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode home_health(CqlContext context) => _home_health;

    private static readonly CqlCode _home_health = new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: inpatient encounter
    [CqlCodeDefinition(
        definitionName: "inpatient encounter",
        codeId: "IMP",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_encounter(CqlContext context) => _inpatient_encounter;

    private static readonly CqlCode _inpatient_encounter = new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: inpatient acute
    [CqlCodeDefinition(
        definitionName: "inpatient acute",
        codeId: "ACUTE",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_acute(CqlContext context) => _inpatient_acute;

    private static readonly CqlCode _inpatient_acute = new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: inpatient non-acute
    [CqlCodeDefinition(
        definitionName: "inpatient non-acute",
        codeId: "NONAC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_non_acute(CqlContext context) => _inpatient_non_acute;

    private static readonly CqlCode _inpatient_non_acute = new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: observation encounter
    [CqlCodeDefinition(
        definitionName: "observation encounter",
        codeId: "OBSENC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode observation_encounter(CqlContext context) => _observation_encounter;

    private static readonly CqlCode _observation_encounter = new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: pre-admission
    [CqlCodeDefinition(
        definitionName: "pre-admission",
        codeId: "PRENC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode pre_admission(CqlContext context) => _pre_admission;

    private static readonly CqlCode _pre_admission = new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: short stay
    [CqlCodeDefinition(
        definitionName: "short stay",
        codeId: "SS",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode short_stay(CqlContext context) => _short_stay;

    private static readonly CqlCode _short_stay = new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: problem-list-item
    [CqlCodeDefinition(
        definitionName: "problem-list-item",
        codeId: "problem-list-item",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode problem_list_item(CqlContext context) => _problem_list_item;

    private static readonly CqlCode _problem_list_item = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);
    #endregion

    #region Code: encounter-diagnosis
    [CqlCodeDefinition(
        definitionName: "encounter-diagnosis",
        codeId: "encounter-diagnosis",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode encounter_diagnosis(CqlContext context) => _encounter_diagnosis;

    private static readonly CqlCode _encounter_diagnosis = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);
    #endregion

    #region Code: health-concern
    [CqlCodeDefinition(
        definitionName: "health-concern",
        codeId: "health-concern",
        codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/condition-category")]
    public CqlCode health_concern(CqlContext context) => _health_concern;

    private static readonly CqlCode _health_concern = new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default);
    #endregion

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: recurrence
    [CqlCodeDefinition(
        definitionName: "recurrence",
        codeId: "recurrence",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext context) => _recurrence;

    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: relapse
    [CqlCodeDefinition(
        definitionName: "relapse",
        codeId: "relapse",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext context) => _relapse;

    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: inactive
    [CqlCodeDefinition(
        definitionName: "inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext context) => _inactive;

    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: remission
    [CqlCodeDefinition(
        definitionName: "remission",
        codeId: "remission",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext context) => _remission;

    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: resolved
    [CqlCodeDefinition(
        definitionName: "resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext context) => _resolved;

    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: unconfirmed
    [CqlCodeDefinition(
        definitionName: "unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext context) => _unconfirmed;

    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: provisional
    [CqlCodeDefinition(
        definitionName: "provisional",
        codeId: "provisional",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext context) => _provisional;

    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: differential
    [CqlCodeDefinition(
        definitionName: "differential",
        codeId: "differential",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext context) => _differential;

    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: confirmed
    [CqlCodeDefinition(
        definitionName: "confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext context) => _confirmed;

    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: refuted
    [CqlCodeDefinition(
        definitionName: "refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext context) => _refuted;

    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: entered-in-error
    [CqlCodeDefinition(
        definitionName: "entered-in-error",
        codeId: "entered-in-error",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext context) => _entered_in_error;

    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: allergy-active
    [CqlCodeDefinition(
        definitionName: "allergy-active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext context) => _allergy_active;

    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-inactive
    [CqlCodeDefinition(
        definitionName: "allergy-inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext context) => _allergy_inactive;

    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-resolved
    [CqlCodeDefinition(
        definitionName: "allergy-resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext context) => _allergy_resolved;

    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-unconfirmed
    [CqlCodeDefinition(
        definitionName: "allergy-unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext context) => _allergy_unconfirmed;

    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-confirmed
    [CqlCodeDefinition(
        definitionName: "allergy-confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext context) => _allergy_confirmed;

    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-refuted
    [CqlCodeDefinition(
        definitionName: "allergy-refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext context) => _allergy_refuted;

    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: Inpatient
    [CqlCodeDefinition(
        definitionName: "Inpatient",
        codeId: "inpatient",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Inpatient(CqlContext context) => _Inpatient;

    private static readonly CqlCode _Inpatient = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Outpatient
    [CqlCodeDefinition(
        definitionName: "Outpatient",
        codeId: "outpatient",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Outpatient(CqlContext context) => _Outpatient;

    private static readonly CqlCode _Outpatient = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Community
    [CqlCodeDefinition(
        definitionName: "Community",
        codeId: "community",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext context) => _Community;

    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Discharge
    [CqlCodeDefinition(
        definitionName: "Discharge",
        codeId: "discharge",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext context) => _Discharge;

    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: AD
    [CqlCodeDefinition(
        definitionName: "AD",
        codeId: "AD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode AD(CqlContext context) => _AD;

    private static readonly CqlCode _AD = new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: DD
    [CqlCodeDefinition(
        definitionName: "DD",
        codeId: "DD",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode DD(CqlContext context) => _DD;

    private static readonly CqlCode _DD = new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: CC
    [CqlCodeDefinition(
        definitionName: "CC",
        codeId: "CC",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CC(CqlContext context) => _CC;

    private static readonly CqlCode _CC = new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: CM
    [CqlCodeDefinition(
        definitionName: "CM",
        codeId: "CM",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CM(CqlContext context) => _CM;

    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: pre-op
    [CqlCodeDefinition(
        definitionName: "pre-op",
        codeId: "pre-op",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode pre_op(CqlContext context) => _pre_op;

    private static readonly CqlCode _pre_op = new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: post-op
    [CqlCodeDefinition(
        definitionName: "post-op",
        codeId: "post-op",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode post_op(CqlContext context) => _post_op;

    private static readonly CqlCode _post_op = new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: billing
    [CqlCodeDefinition(
        definitionName: "billing",
        codeId: "billing",
        codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode billing(CqlContext context) => _billing;

    private static readonly CqlCode _billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);
    #endregion

    #region Code: social-history
    [CqlCodeDefinition(
        definitionName: "social-history",
        codeId: "social-history",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode social_history(CqlContext context) => _social_history;

    private static readonly CqlCode _social_history = new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: vital-signs
    [CqlCodeDefinition(
        definitionName: "vital-signs",
        codeId: "vital-signs",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext context) => _vital_signs;

    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: imaging
    [CqlCodeDefinition(
        definitionName: "imaging",
        codeId: "imaging",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode imaging(CqlContext context) => _imaging;

    private static readonly CqlCode _imaging = new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: laboratory
    [CqlCodeDefinition(
        definitionName: "laboratory",
        codeId: "laboratory",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext context) => _laboratory;

    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: procedure
    [CqlCodeDefinition(
        definitionName: "procedure",
        codeId: "procedure",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode procedure(CqlContext context) => _procedure;

    private static readonly CqlCode _procedure = new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: survey
    [CqlCodeDefinition(
        definitionName: "survey",
        codeId: "survey",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext context) => _survey;

    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: exam
    [CqlCodeDefinition(
        definitionName: "exam",
        codeId: "exam",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext context) => _exam;

    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: therapy
    [CqlCodeDefinition(
        definitionName: "therapy",
        codeId: "therapy",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode therapy(CqlContext context) => _therapy;

    private static readonly CqlCode _therapy = new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #region Code: activity
    [CqlCodeDefinition(
        definitionName: "activity",
        codeId: "activity",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode activity(CqlContext context) => _activity;

    private static readonly CqlCode _activity = new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] wu_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return wu_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] wv_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return wv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] ww_ = [
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return ww_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] wx_ = [
            new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
            new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
        ];

        return wx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] wy_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return wy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RequestIntent")]
    public CqlCode[] RequestIntent(CqlContext context)
    {
        CqlCode[] wz_ = []
;

        return wz_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] xa_ = [
            new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return xa_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] xb_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return xb_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] xc_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return xc_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] xd_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
        ];

        return xd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] xe_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return xe_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] xf_ = [
            new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return xf_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "USCoreObservationCategoryExtensionCodes")]
    public CqlCode[] USCoreObservationCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] xg_ = []
;

        return xg_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionCategory")]
    public CqlCode[] ConditionCategory(CqlContext context)
    {
        CqlCode[] xh_ = [
            new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
            new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
        ];

        return xh_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "USCoreConditionCategoryExtensionCodes")]
    public CqlCode[] USCoreConditionCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] xi_ = [
            new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default),
        ];

        return xi_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xk_ = context.Operators.SingletonFrom<Patient>(xj_);

        return xk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept xl_ = condition?.ClinicalStatus;
        CqlConcept xm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xl_);
        CqlCode xn_ = this.active(context);
        CqlConcept xo_ = context.Operators.ConvertCodeToConcept(xn_);
        bool? xp_ = context.Operators.Equivalent(xm_, xo_);
        CqlConcept xr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xl_);
        CqlCode xs_ = this.recurrence(context);
        CqlConcept xt_ = context.Operators.ConvertCodeToConcept(xs_);
        bool? xu_ = context.Operators.Equivalent(xr_, xt_);
        bool? xv_ = context.Operators.Or(xp_, xu_);
        CqlConcept xx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xl_);
        CqlCode xy_ = this.relapse(context);
        CqlConcept xz_ = context.Operators.ConvertCodeToConcept(xy_);
        bool? ya_ = context.Operators.Equivalent(xx_, xz_);
        bool? yb_ = context.Operators.Or(xv_, ya_);

        return yb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> yc_ = condition?.Category;
        CqlConcept yd_(CodeableConcept @this)
        {
            CqlConcept yi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return yi_;
        };
        IEnumerable<CqlConcept> ye_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yc_, yd_);
        bool? yf_(CqlConcept C)
        {
            CqlConcept yj_ = context.Operators.ConvertCodeToConcept(category);
            bool? yk_ = context.Operators.Equivalent(C, yj_);

            return yk_;
        };
        IEnumerable<CqlConcept> yg_ = context.Operators.Where<CqlConcept>(ye_, yf_);
        bool? yh_ = context.Operators.Exists<CqlConcept>(yg_);

        return yh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> yl_ = observation?.Category;
        CqlConcept ym_(CodeableConcept @this)
        {
            CqlConcept yr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return yr_;
        };
        IEnumerable<CqlConcept> yn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yl_, ym_);
        bool? yo_(CqlConcept C)
        {
            CqlConcept ys_ = context.Operators.ConvertCodeToConcept(category);
            bool? yt_ = context.Operators.Equivalent(C, ys_);

            return yt_;
        };
        IEnumerable<CqlConcept> yp_ = context.Operators.Where<CqlConcept>(yn_, yo_);
        bool? yq_ = context.Operators.Exists<CqlConcept>(yp_);

        return yq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yu_ = condition?.Category;
        CqlConcept yv_(CodeableConcept @this)
        {
            CqlConcept za_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return za_;
        };
        IEnumerable<CqlConcept> yw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yu_, yv_);
        bool? yx_(CqlConcept C)
        {
            CqlCode zb_ = this.problem_list_item(context);
            CqlConcept zc_ = context.Operators.ConvertCodeToConcept(zb_);
            bool? zd_ = context.Operators.Equivalent(C, zc_);

            return zd_;
        };
        IEnumerable<CqlConcept> yy_ = context.Operators.Where<CqlConcept>(yw_, yx_);
        bool? yz_ = context.Operators.Exists<CqlConcept>(yy_);

        return yz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> ze_ = condition?.Category;
        CqlConcept zf_(CodeableConcept @this)
        {
            CqlConcept zk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return zk_;
        };
        IEnumerable<CqlConcept> zg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ze_, zf_);
        bool? zh_(CqlConcept C)
        {
            CqlCode zl_ = this.encounter_diagnosis(context);
            CqlConcept zm_ = context.Operators.ConvertCodeToConcept(zl_);
            bool? zn_ = context.Operators.Equivalent(C, zm_);

            return zn_;
        };
        IEnumerable<CqlConcept> zi_ = context.Operators.Where<CqlConcept>(zg_, zh_);
        bool? zj_ = context.Operators.Exists<CqlConcept>(zi_);

        return zj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> zo_ = condition?.Category;
        CqlConcept zp_(CodeableConcept @this)
        {
            CqlConcept zu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return zu_;
        };
        IEnumerable<CqlConcept> zq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zo_, zp_);
        bool? zr_(CqlConcept C)
        {
            CqlCode zv_ = this.health_concern(context);
            CqlConcept zw_ = context.Operators.ConvertCodeToConcept(zv_);
            bool? zx_ = context.Operators.Equivalent(C, zw_);

            return zx_;
        };
        IEnumerable<CqlConcept> zs_ = context.Operators.Where<CqlConcept>(zq_, zr_);
        bool? zt_ = context.Operators.Exists<CqlConcept>(zs_);

        return zt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zy_ = observation?.Category;
        CqlConcept zz_(CodeableConcept @this)
        {
            CqlConcept aze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return aze_;
        };
        IEnumerable<CqlConcept> aza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zy_, zz_);
        bool? azb_(CqlConcept C)
        {
            CqlCode azf_ = this.social_history(context);
            CqlConcept azg_ = context.Operators.ConvertCodeToConcept(azf_);
            bool? azh_ = context.Operators.Equivalent(C, azg_);

            return azh_;
        };
        IEnumerable<CqlConcept> azc_ = context.Operators.Where<CqlConcept>(aza_, azb_);
        bool? azd_ = context.Operators.Exists<CqlConcept>(azc_);

        return azd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azi_ = observation?.Category;
        CqlConcept azj_(CodeableConcept @this)
        {
            CqlConcept azo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return azo_;
        };
        IEnumerable<CqlConcept> azk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azi_, azj_);
        bool? azl_(CqlConcept C)
        {
            CqlCode azp_ = this.vital_signs(context);
            CqlConcept azq_ = context.Operators.ConvertCodeToConcept(azp_);
            bool? azr_ = context.Operators.Equivalent(C, azq_);

            return azr_;
        };
        IEnumerable<CqlConcept> azm_ = context.Operators.Where<CqlConcept>(azk_, azl_);
        bool? azn_ = context.Operators.Exists<CqlConcept>(azm_);

        return azn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azs_ = observation?.Category;
        CqlConcept azt_(CodeableConcept @this)
        {
            CqlConcept azy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return azy_;
        };
        IEnumerable<CqlConcept> azu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azs_, azt_);
        bool? azv_(CqlConcept C)
        {
            CqlCode azz_ = this.imaging(context);
            CqlConcept bza_ = context.Operators.ConvertCodeToConcept(azz_);
            bool? bzb_ = context.Operators.Equivalent(C, bza_);

            return bzb_;
        };
        IEnumerable<CqlConcept> azw_ = context.Operators.Where<CqlConcept>(azu_, azv_);
        bool? azx_ = context.Operators.Exists<CqlConcept>(azw_);

        return azx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzc_ = observation?.Category;
        CqlConcept bzd_(CodeableConcept @this)
        {
            CqlConcept bzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return bzi_;
        };
        IEnumerable<CqlConcept> bze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzc_, bzd_);
        bool? bzf_(CqlConcept C)
        {
            CqlCode bzj_ = this.laboratory(context);
            CqlConcept bzk_ = context.Operators.ConvertCodeToConcept(bzj_);
            bool? bzl_ = context.Operators.Equivalent(C, bzk_);

            return bzl_;
        };
        IEnumerable<CqlConcept> bzg_ = context.Operators.Where<CqlConcept>(bze_, bzf_);
        bool? bzh_ = context.Operators.Exists<CqlConcept>(bzg_);

        return bzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzm_ = observation?.Category;
        CqlConcept bzn_(CodeableConcept @this)
        {
            CqlConcept bzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return bzs_;
        };
        IEnumerable<CqlConcept> bzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzm_, bzn_);
        bool? bzp_(CqlConcept C)
        {
            CqlCode bzt_ = this.procedure(context);
            CqlConcept bzu_ = context.Operators.ConvertCodeToConcept(bzt_);
            bool? bzv_ = context.Operators.Equivalent(C, bzu_);

            return bzv_;
        };
        IEnumerable<CqlConcept> bzq_ = context.Operators.Where<CqlConcept>(bzo_, bzp_);
        bool? bzr_ = context.Operators.Exists<CqlConcept>(bzq_);

        return bzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzw_ = observation?.Category;
        CqlConcept bzx_(CodeableConcept @this)
        {
            CqlConcept czc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return czc_;
        };
        IEnumerable<CqlConcept> bzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzw_, bzx_);
        bool? bzz_(CqlConcept C)
        {
            CqlCode czd_ = this.survey(context);
            CqlConcept cze_ = context.Operators.ConvertCodeToConcept(czd_);
            bool? czf_ = context.Operators.Equivalent(C, cze_);

            return czf_;
        };
        IEnumerable<CqlConcept> cza_ = context.Operators.Where<CqlConcept>(bzy_, bzz_);
        bool? czb_ = context.Operators.Exists<CqlConcept>(cza_);

        return czb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czg_ = observation?.Category;
        CqlConcept czh_(CodeableConcept @this)
        {
            CqlConcept czm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return czm_;
        };
        IEnumerable<CqlConcept> czi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czg_, czh_);
        bool? czj_(CqlConcept C)
        {
            CqlCode czn_ = this.exam(context);
            CqlConcept czo_ = context.Operators.ConvertCodeToConcept(czn_);
            bool? czp_ = context.Operators.Equivalent(C, czo_);

            return czp_;
        };
        IEnumerable<CqlConcept> czk_ = context.Operators.Where<CqlConcept>(czi_, czj_);
        bool? czl_ = context.Operators.Exists<CqlConcept>(czk_);

        return czl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czq_ = observation?.Category;
        CqlConcept czr_(CodeableConcept @this)
        {
            CqlConcept czw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return czw_;
        };
        IEnumerable<CqlConcept> czs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czq_, czr_);
        bool? czt_(CqlConcept C)
        {
            CqlCode czx_ = this.therapy(context);
            CqlConcept czy_ = context.Operators.ConvertCodeToConcept(czx_);
            bool? czz_ = context.Operators.Equivalent(C, czy_);

            return czz_;
        };
        IEnumerable<CqlConcept> czu_ = context.Operators.Where<CqlConcept>(czs_, czt_);
        bool? czv_ = context.Operators.Exists<CqlConcept>(czu_);

        return czv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> dza_ = observation?.Category;
        CqlConcept dzb_(CodeableConcept @this)
        {
            CqlConcept dzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzg_;
        };
        IEnumerable<CqlConcept> dzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dza_, dzb_);
        bool? dzd_(CqlConcept C)
        {
            CqlCode dzh_ = this.activity(context);
            CqlConcept dzi_ = context.Operators.ConvertCodeToConcept(dzh_);
            bool? dzj_ = context.Operators.Equivalent(C, dzi_);

            return dzj_;
        };
        IEnumerable<CqlConcept> dze_ = context.Operators.Where<CqlConcept>(dzc_, dzd_);
        bool? dzf_ = context.Operators.Exists<CqlConcept>(dze_);

        return dzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzk_ = medicationRequest?.Category;
        CqlConcept dzl_(CodeableConcept @this)
        {
            CqlConcept dzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzq_;
        };
        IEnumerable<CqlConcept> dzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzk_, dzl_);
        bool? dzn_(CqlConcept C)
        {
            CqlCode dzr_ = this.Community(context);
            CqlConcept dzs_ = context.Operators.ConvertCodeToConcept(dzr_);
            bool? dzt_ = context.Operators.Equivalent(C, dzs_);

            return dzt_;
        };
        IEnumerable<CqlConcept> dzo_ = context.Operators.Where<CqlConcept>(dzm_, dzn_);
        bool? dzp_ = context.Operators.Exists<CqlConcept>(dzo_);

        return dzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzu_ = medicationRequest?.Category;
        CqlConcept dzv_(CodeableConcept @this)
        {
            CqlConcept eza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return eza_;
        };
        IEnumerable<CqlConcept> dzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzu_, dzv_);
        bool? dzx_(CqlConcept C)
        {
            CqlCode ezb_ = this.Discharge(context);
            CqlConcept ezc_ = context.Operators.ConvertCodeToConcept(ezb_);
            bool? ezd_ = context.Operators.Equivalent(C, ezc_);

            return ezd_;
        };
        IEnumerable<CqlConcept> dzy_ = context.Operators.Where<CqlConcept>(dzw_, dzx_);
        bool? dzz_ = context.Operators.Exists<CqlConcept>(dzy_);

        return dzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? eze_(Extension E)
        {
            string ezk_ = E?.Url;
            FhirString ezl_ = context.Operators.Convert<FhirString>(ezk_);
            string ezm_ = ezl_?.Value;
            bool? ezn_ = context.Operators.Equal(ezm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return ezn_;
        };
        IEnumerable<Extension> ezf_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), eze_);
        bool? ezg_(Extension E)
        {
            DataType ezo_ = E?.Value;
            object ezp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezo_);

            return ezp_ as bool?;
        };
        IEnumerable<bool?> ezh_ = context.Operators.Select<Extension, bool?>(ezf_, ezg_);
        IEnumerable<bool?> ezi_ = context.Operators.Distinct<bool?>(ezh_);
        bool? ezj_ = context.Operators.SingletonFrom<bool?>(ezi_);

        return ezj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezq_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ezr_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ezr_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezs_ = this.Patient(context);
                Date ezt_ = ezs_?.BirthDateElement;
                string ezu_ = ezt_?.Value;
                CqlDate ezv_ = context.Operators.ConvertStringToDate(ezu_);
                CqlDate ezw_ = context.Operators.Add(ezv_, choice as CqlQuantity);
                Date ezy_ = ezs_?.BirthDateElement;
                string ezz_ = ezy_?.Value;
                CqlDate fza_ = context.Operators.ConvertStringToDate(ezz_);
                CqlDate fzb_ = context.Operators.Add(fza_, choice as CqlQuantity);
                CqlQuantity fzc_ = context.Operators.Quantity(1m, "year");
                CqlDate fzd_ = context.Operators.Add(fzb_, fzc_);
                CqlInterval<CqlDate> fze_ = context.Operators.Interval(ezw_, fzd_, true, false);
                CqlDate fzf_ = fze_?.low;
                CqlDateTime fzg_ = context.Operators.ConvertDateToDateTime(fzf_);
                Date fzi_ = ezs_?.BirthDateElement;
                string fzj_ = fzi_?.Value;
                CqlDate fzk_ = context.Operators.ConvertStringToDate(fzj_);
                CqlDate fzl_ = context.Operators.Add(fzk_, choice as CqlQuantity);
                Date fzn_ = ezs_?.BirthDateElement;
                string fzo_ = fzn_?.Value;
                CqlDate fzp_ = context.Operators.ConvertStringToDate(fzo_);
                CqlDate fzq_ = context.Operators.Add(fzp_, choice as CqlQuantity);
                CqlDate fzs_ = context.Operators.Add(fzq_, fzc_);
                CqlInterval<CqlDate> fzt_ = context.Operators.Interval(fzl_, fzs_, true, false);
                CqlDate fzu_ = fzt_?.high;
                CqlDateTime fzv_ = context.Operators.ConvertDateToDateTime(fzu_);
                Date fzx_ = ezs_?.BirthDateElement;
                string fzy_ = fzx_?.Value;
                CqlDate fzz_ = context.Operators.ConvertStringToDate(fzy_);
                CqlDate gza_ = context.Operators.Add(fzz_, choice as CqlQuantity);
                Date gzc_ = ezs_?.BirthDateElement;
                string gzd_ = gzc_?.Value;
                CqlDate gze_ = context.Operators.ConvertStringToDate(gzd_);
                CqlDate gzf_ = context.Operators.Add(gze_, choice as CqlQuantity);
                CqlDate gzh_ = context.Operators.Add(gzf_, fzc_);
                CqlInterval<CqlDate> gzi_ = context.Operators.Interval(gza_, gzh_, true, false);
                bool? gzj_ = gzi_?.lowClosed;
                Date gzl_ = ezs_?.BirthDateElement;
                string gzm_ = gzl_?.Value;
                CqlDate gzn_ = context.Operators.ConvertStringToDate(gzm_);
                CqlDate gzo_ = context.Operators.Add(gzn_, choice as CqlQuantity);
                Date gzq_ = ezs_?.BirthDateElement;
                string gzr_ = gzq_?.Value;
                CqlDate gzs_ = context.Operators.ConvertStringToDate(gzr_);
                CqlDate gzt_ = context.Operators.Add(gzs_, choice as CqlQuantity);
                CqlDate gzv_ = context.Operators.Add(gzt_, fzc_);
                CqlInterval<CqlDate> gzw_ = context.Operators.Interval(gzo_, gzv_, true, false);
                bool? gzx_ = gzw_?.highClosed;
                CqlInterval<CqlDateTime> gzy_ = context.Operators.Interval(fzg_, fzv_, gzj_, gzx_);

                return gzy_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzz_ = this.Patient(context);
                Date hza_ = gzz_?.BirthDateElement;
                string hzb_ = hza_?.Value;
                CqlDate hzc_ = context.Operators.ConvertStringToDate(hzb_);
                object hzd_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate hze_ = context.Operators.Add(hzc_, hzd_ as CqlQuantity);
                Date hzg_ = gzz_?.BirthDateElement;
                string hzh_ = hzg_?.Value;
                CqlDate hzi_ = context.Operators.ConvertStringToDate(hzh_);
                object hzj_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate hzk_ = context.Operators.Add(hzi_, hzj_ as CqlQuantity);
                CqlQuantity hzl_ = context.Operators.Quantity(1m, "year");
                CqlDate hzm_ = context.Operators.Add(hzk_, hzl_);
                CqlInterval<CqlDate> hzn_ = context.Operators.Interval(hze_, hzm_, true, false);
                CqlDate hzo_ = hzn_?.low;
                CqlDateTime hzp_ = context.Operators.ConvertDateToDateTime(hzo_);
                Date hzr_ = gzz_?.BirthDateElement;
                string hzs_ = hzr_?.Value;
                CqlDate hzt_ = context.Operators.ConvertStringToDate(hzs_);
                CqlDate hzv_ = context.Operators.Add(hzt_, hzd_ as CqlQuantity);
                Date hzx_ = gzz_?.BirthDateElement;
                string hzy_ = hzx_?.Value;
                CqlDate hzz_ = context.Operators.ConvertStringToDate(hzy_);
                CqlDate izb_ = context.Operators.Add(hzz_, hzj_ as CqlQuantity);
                CqlDate izd_ = context.Operators.Add(izb_, hzl_);
                CqlInterval<CqlDate> ize_ = context.Operators.Interval(hzv_, izd_, true, false);
                CqlDate izf_ = ize_?.high;
                CqlDateTime izg_ = context.Operators.ConvertDateToDateTime(izf_);
                Date izi_ = gzz_?.BirthDateElement;
                string izj_ = izi_?.Value;
                CqlDate izk_ = context.Operators.ConvertStringToDate(izj_);
                CqlDate izm_ = context.Operators.Add(izk_, hzd_ as CqlQuantity);
                Date izo_ = gzz_?.BirthDateElement;
                string izp_ = izo_?.Value;
                CqlDate izq_ = context.Operators.ConvertStringToDate(izp_);
                CqlDate izs_ = context.Operators.Add(izq_, hzj_ as CqlQuantity);
                CqlDate izu_ = context.Operators.Add(izs_, hzl_);
                CqlInterval<CqlDate> izv_ = context.Operators.Interval(izm_, izu_, true, false);
                bool? izw_ = izv_?.lowClosed;
                Date izy_ = gzz_?.BirthDateElement;
                string izz_ = izy_?.Value;
                CqlDate jza_ = context.Operators.ConvertStringToDate(izz_);
                CqlDate jzc_ = context.Operators.Add(jza_, hzd_ as CqlQuantity);
                Date jze_ = gzz_?.BirthDateElement;
                string jzf_ = jze_?.Value;
                CqlDate jzg_ = context.Operators.ConvertStringToDate(jzf_);
                CqlDate jzi_ = context.Operators.Add(jzg_, hzj_ as CqlQuantity);
                CqlDate jzk_ = context.Operators.Add(jzi_, hzl_);
                CqlInterval<CqlDate> jzl_ = context.Operators.Interval(jzc_, jzk_, true, false);
                bool? jzm_ = jzl_?.highClosed;
                CqlInterval<CqlDateTime> jzn_ = context.Operators.Interval(hzp_, izg_, izw_, jzm_);

                return jzn_;
            }
            else if (choice is Timing)
            {
                object jzo_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return jzo_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ezq_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzp_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jzq_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jzq_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzr_ = this.Patient(context);
                Date jzs_ = jzr_?.BirthDateElement;
                string jzt_ = jzs_?.Value;
                CqlDate jzu_ = context.Operators.ConvertStringToDate(jzt_);
                CqlDate jzv_ = context.Operators.Add(jzu_, choice as CqlQuantity);
                Date jzx_ = jzr_?.BirthDateElement;
                string jzy_ = jzx_?.Value;
                CqlDate jzz_ = context.Operators.ConvertStringToDate(jzy_);
                CqlDate kza_ = context.Operators.Add(jzz_, choice as CqlQuantity);
                CqlQuantity kzb_ = context.Operators.Quantity(1m, "year");
                CqlDate kzc_ = context.Operators.Add(kza_, kzb_);
                CqlInterval<CqlDate> kzd_ = context.Operators.Interval(jzv_, kzc_, true, false);
                CqlDate kze_ = kzd_?.low;
                CqlDateTime kzf_ = context.Operators.ConvertDateToDateTime(kze_);
                Date kzh_ = jzr_?.BirthDateElement;
                string kzi_ = kzh_?.Value;
                CqlDate kzj_ = context.Operators.ConvertStringToDate(kzi_);
                CqlDate kzk_ = context.Operators.Add(kzj_, choice as CqlQuantity);
                Date kzm_ = jzr_?.BirthDateElement;
                string kzn_ = kzm_?.Value;
                CqlDate kzo_ = context.Operators.ConvertStringToDate(kzn_);
                CqlDate kzp_ = context.Operators.Add(kzo_, choice as CqlQuantity);
                CqlDate kzr_ = context.Operators.Add(kzp_, kzb_);
                CqlInterval<CqlDate> kzs_ = context.Operators.Interval(kzk_, kzr_, true, false);
                CqlDate kzt_ = kzs_?.high;
                CqlDateTime kzu_ = context.Operators.ConvertDateToDateTime(kzt_);
                Date kzw_ = jzr_?.BirthDateElement;
                string kzx_ = kzw_?.Value;
                CqlDate kzy_ = context.Operators.ConvertStringToDate(kzx_);
                CqlDate kzz_ = context.Operators.Add(kzy_, choice as CqlQuantity);
                Date lzb_ = jzr_?.BirthDateElement;
                string lzc_ = lzb_?.Value;
                CqlDate lzd_ = context.Operators.ConvertStringToDate(lzc_);
                CqlDate lze_ = context.Operators.Add(lzd_, choice as CqlQuantity);
                CqlDate lzg_ = context.Operators.Add(lze_, kzb_);
                CqlInterval<CqlDate> lzh_ = context.Operators.Interval(kzz_, lzg_, true, false);
                bool? lzi_ = lzh_?.lowClosed;
                Date lzk_ = jzr_?.BirthDateElement;
                string lzl_ = lzk_?.Value;
                CqlDate lzm_ = context.Operators.ConvertStringToDate(lzl_);
                CqlDate lzn_ = context.Operators.Add(lzm_, choice as CqlQuantity);
                Date lzp_ = jzr_?.BirthDateElement;
                string lzq_ = lzp_?.Value;
                CqlDate lzr_ = context.Operators.ConvertStringToDate(lzq_);
                CqlDate lzs_ = context.Operators.Add(lzr_, choice as CqlQuantity);
                CqlDate lzu_ = context.Operators.Add(lzs_, kzb_);
                CqlInterval<CqlDate> lzv_ = context.Operators.Interval(lzn_, lzu_, true, false);
                bool? lzw_ = lzv_?.highClosed;
                CqlInterval<CqlDateTime> lzx_ = context.Operators.Interval(kzf_, kzu_, lzi_, lzw_);

                return lzx_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzy_ = this.Patient(context);
                Date lzz_ = lzy_?.BirthDateElement;
                string mza_ = lzz_?.Value;
                CqlDate mzb_ = context.Operators.ConvertStringToDate(mza_);
                object mzc_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate mzd_ = context.Operators.Add(mzb_, mzc_ as CqlQuantity);
                Date mzf_ = lzy_?.BirthDateElement;
                string mzg_ = mzf_?.Value;
                CqlDate mzh_ = context.Operators.ConvertStringToDate(mzg_);
                object mzi_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate mzj_ = context.Operators.Add(mzh_, mzi_ as CqlQuantity);
                CqlQuantity mzk_ = context.Operators.Quantity(1m, "year");
                CqlDate mzl_ = context.Operators.Add(mzj_, mzk_);
                CqlInterval<CqlDate> mzm_ = context.Operators.Interval(mzd_, mzl_, true, false);
                CqlDate mzn_ = mzm_?.low;
                CqlDateTime mzo_ = context.Operators.ConvertDateToDateTime(mzn_);
                Date mzq_ = lzy_?.BirthDateElement;
                string mzr_ = mzq_?.Value;
                CqlDate mzs_ = context.Operators.ConvertStringToDate(mzr_);
                CqlDate mzu_ = context.Operators.Add(mzs_, mzc_ as CqlQuantity);
                Date mzw_ = lzy_?.BirthDateElement;
                string mzx_ = mzw_?.Value;
                CqlDate mzy_ = context.Operators.ConvertStringToDate(mzx_);
                CqlDate nza_ = context.Operators.Add(mzy_, mzi_ as CqlQuantity);
                CqlDate nzc_ = context.Operators.Add(nza_, mzk_);
                CqlInterval<CqlDate> nzd_ = context.Operators.Interval(mzu_, nzc_, true, false);
                CqlDate nze_ = nzd_?.high;
                CqlDateTime nzf_ = context.Operators.ConvertDateToDateTime(nze_);
                Date nzh_ = lzy_?.BirthDateElement;
                string nzi_ = nzh_?.Value;
                CqlDate nzj_ = context.Operators.ConvertStringToDate(nzi_);
                CqlDate nzl_ = context.Operators.Add(nzj_, mzc_ as CqlQuantity);
                Date nzn_ = lzy_?.BirthDateElement;
                string nzo_ = nzn_?.Value;
                CqlDate nzp_ = context.Operators.ConvertStringToDate(nzo_);
                CqlDate nzr_ = context.Operators.Add(nzp_, mzi_ as CqlQuantity);
                CqlDate nzt_ = context.Operators.Add(nzr_, mzk_);
                CqlInterval<CqlDate> nzu_ = context.Operators.Interval(nzl_, nzt_, true, false);
                bool? nzv_ = nzu_?.lowClosed;
                Date nzx_ = lzy_?.BirthDateElement;
                string nzy_ = nzx_?.Value;
                CqlDate nzz_ = context.Operators.ConvertStringToDate(nzy_);
                CqlDate ozb_ = context.Operators.Add(nzz_, mzc_ as CqlQuantity);
                Date ozd_ = lzy_?.BirthDateElement;
                string oze_ = ozd_?.Value;
                CqlDate ozf_ = context.Operators.ConvertStringToDate(oze_);
                CqlDate ozh_ = context.Operators.Add(ozf_, mzi_ as CqlQuantity);
                CqlDate ozj_ = context.Operators.Add(ozh_, mzk_);
                CqlInterval<CqlDate> ozk_ = context.Operators.Interval(ozb_, ozj_, true, false);
                bool? ozl_ = ozk_?.highClosed;
                CqlInterval<CqlDateTime> ozm_ = context.Operators.Interval(mzo_, nzf_, nzv_, ozl_);

                return ozm_;
            }
            else if (choice is Timing)
            {
                object ozn_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return ozn_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzp_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ozo_()
        {
            bool ozp_()
            {
                DataType ozt_ = condition?.Abatement;
                object ozu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozt_);
                bool ozv_ = ozu_ is CqlDateTime;

                return ozv_;
            };
            bool ozq_()
            {
                DataType ozw_ = condition?.Abatement;
                object ozx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozw_);
                bool ozy_ = ozx_ is CqlQuantity;

                return ozy_;
            };
            bool ozr_()
            {
                DataType ozz_ = condition?.Abatement;
                object pza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                bool pzb_ = pza_ is CqlInterval<CqlQuantity>;

                return pzb_;
            };
            bool ozs_()
            {
                DataType pzc_ = condition?.Abatement;
                object pzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzc_);
                bool pze_ = pzd_ is CqlInterval<CqlDateTime>;

                return pze_;
            };
            if (ozp_())
            {
                DataType pzf_ = condition?.Abatement;
                object pzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzf_);
                object pzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzf_);
                CqlInterval<CqlDateTime> pzj_ = context.Operators.Interval(pzg_ as CqlDateTime, pzi_ as CqlDateTime, true, true);

                return pzj_;
            }
            else if (ozq_())
            {
                Patient pzk_ = this.Patient(context);
                Date pzl_ = pzk_?.BirthDateElement;
                string pzm_ = pzl_?.Value;
                CqlDate pzn_ = context.Operators.ConvertStringToDate(pzm_);
                DataType pzo_ = condition?.Abatement;
                object pzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate pzq_ = context.Operators.Add(pzn_, pzp_ as CqlQuantity);
                Date pzs_ = pzk_?.BirthDateElement;
                string pzt_ = pzs_?.Value;
                CqlDate pzu_ = context.Operators.ConvertStringToDate(pzt_);
                object pzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate pzx_ = context.Operators.Add(pzu_, pzw_ as CqlQuantity);
                CqlQuantity pzy_ = context.Operators.Quantity(1m, "year");
                CqlDate pzz_ = context.Operators.Add(pzx_, pzy_);
                CqlInterval<CqlDate> qza_ = context.Operators.Interval(pzq_, pzz_, true, false);
                CqlDate qzb_ = qza_?.low;
                CqlDateTime qzc_ = context.Operators.ConvertDateToDateTime(qzb_);
                Date qze_ = pzk_?.BirthDateElement;
                string qzf_ = qze_?.Value;
                CqlDate qzg_ = context.Operators.ConvertStringToDate(qzf_);
                object qzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate qzj_ = context.Operators.Add(qzg_, qzi_ as CqlQuantity);
                Date qzl_ = pzk_?.BirthDateElement;
                string qzm_ = qzl_?.Value;
                CqlDate qzn_ = context.Operators.ConvertStringToDate(qzm_);
                object qzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate qzq_ = context.Operators.Add(qzn_, qzp_ as CqlQuantity);
                CqlDate qzs_ = context.Operators.Add(qzq_, pzy_);
                CqlInterval<CqlDate> qzt_ = context.Operators.Interval(qzj_, qzs_, true, false);
                CqlDate qzu_ = qzt_?.high;
                CqlDateTime qzv_ = context.Operators.ConvertDateToDateTime(qzu_);
                Date qzx_ = pzk_?.BirthDateElement;
                string qzy_ = qzx_?.Value;
                CqlDate qzz_ = context.Operators.ConvertStringToDate(qzy_);
                object rzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate rzc_ = context.Operators.Add(qzz_, rzb_ as CqlQuantity);
                Date rze_ = pzk_?.BirthDateElement;
                string rzf_ = rze_?.Value;
                CqlDate rzg_ = context.Operators.ConvertStringToDate(rzf_);
                object rzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate rzj_ = context.Operators.Add(rzg_, rzi_ as CqlQuantity);
                CqlDate rzl_ = context.Operators.Add(rzj_, pzy_);
                CqlInterval<CqlDate> rzm_ = context.Operators.Interval(rzc_, rzl_, true, false);
                bool? rzn_ = rzm_?.lowClosed;
                Date rzp_ = pzk_?.BirthDateElement;
                string rzq_ = rzp_?.Value;
                CqlDate rzr_ = context.Operators.ConvertStringToDate(rzq_);
                object rzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate rzu_ = context.Operators.Add(rzr_, rzt_ as CqlQuantity);
                Date rzw_ = pzk_?.BirthDateElement;
                string rzx_ = rzw_?.Value;
                CqlDate rzy_ = context.Operators.ConvertStringToDate(rzx_);
                object sza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzo_);
                CqlDate szb_ = context.Operators.Add(rzy_, sza_ as CqlQuantity);
                CqlDate szd_ = context.Operators.Add(szb_, pzy_);
                CqlInterval<CqlDate> sze_ = context.Operators.Interval(rzu_, szd_, true, false);
                bool? szf_ = sze_?.highClosed;
                CqlInterval<CqlDateTime> szg_ = context.Operators.Interval(qzc_, qzv_, rzn_, szf_);

                return szg_;
            }
            else if (ozr_())
            {
                Patient szh_ = this.Patient(context);
                Date szi_ = szh_?.BirthDateElement;
                string szj_ = szi_?.Value;
                CqlDate szk_ = context.Operators.ConvertStringToDate(szj_);
                DataType szl_ = condition?.Abatement;
                object szm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object szn_ = context.Operators.LateBoundProperty<object>(szm_, "low");
                CqlDate szo_ = context.Operators.Add(szk_, szn_ as CqlQuantity);
                Date szq_ = szh_?.BirthDateElement;
                string szr_ = szq_?.Value;
                CqlDate szs_ = context.Operators.ConvertStringToDate(szr_);
                object szu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object szv_ = context.Operators.LateBoundProperty<object>(szu_, "high");
                CqlDate szw_ = context.Operators.Add(szs_, szv_ as CqlQuantity);
                CqlQuantity szx_ = context.Operators.Quantity(1m, "year");
                CqlDate szy_ = context.Operators.Add(szw_, szx_);
                CqlInterval<CqlDate> szz_ = context.Operators.Interval(szo_, szy_, true, false);
                CqlDate tza_ = szz_?.low;
                CqlDateTime tzb_ = context.Operators.ConvertDateToDateTime(tza_);
                Date tzd_ = szh_?.BirthDateElement;
                string tze_ = tzd_?.Value;
                CqlDate tzf_ = context.Operators.ConvertStringToDate(tze_);
                object tzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object tzi_ = context.Operators.LateBoundProperty<object>(tzh_, "low");
                CqlDate tzj_ = context.Operators.Add(tzf_, tzi_ as CqlQuantity);
                Date tzl_ = szh_?.BirthDateElement;
                string tzm_ = tzl_?.Value;
                CqlDate tzn_ = context.Operators.ConvertStringToDate(tzm_);
                object tzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object tzq_ = context.Operators.LateBoundProperty<object>(tzp_, "high");
                CqlDate tzr_ = context.Operators.Add(tzn_, tzq_ as CqlQuantity);
                CqlDate tzt_ = context.Operators.Add(tzr_, szx_);
                CqlInterval<CqlDate> tzu_ = context.Operators.Interval(tzj_, tzt_, true, false);
                CqlDate tzv_ = tzu_?.high;
                CqlDateTime tzw_ = context.Operators.ConvertDateToDateTime(tzv_);
                Date tzy_ = szh_?.BirthDateElement;
                string tzz_ = tzy_?.Value;
                CqlDate uza_ = context.Operators.ConvertStringToDate(tzz_);
                object uzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object uzd_ = context.Operators.LateBoundProperty<object>(uzc_, "low");
                CqlDate uze_ = context.Operators.Add(uza_, uzd_ as CqlQuantity);
                Date uzg_ = szh_?.BirthDateElement;
                string uzh_ = uzg_?.Value;
                CqlDate uzi_ = context.Operators.ConvertStringToDate(uzh_);
                object uzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object uzl_ = context.Operators.LateBoundProperty<object>(uzk_, "high");
                CqlDate uzm_ = context.Operators.Add(uzi_, uzl_ as CqlQuantity);
                CqlDate uzo_ = context.Operators.Add(uzm_, szx_);
                CqlInterval<CqlDate> uzp_ = context.Operators.Interval(uze_, uzo_, true, false);
                bool? uzq_ = uzp_?.lowClosed;
                Date uzs_ = szh_?.BirthDateElement;
                string uzt_ = uzs_?.Value;
                CqlDate uzu_ = context.Operators.ConvertStringToDate(uzt_);
                object uzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object uzx_ = context.Operators.LateBoundProperty<object>(uzw_, "low");
                CqlDate uzy_ = context.Operators.Add(uzu_, uzx_ as CqlQuantity);
                Date vza_ = szh_?.BirthDateElement;
                string vzb_ = vza_?.Value;
                CqlDate vzc_ = context.Operators.ConvertStringToDate(vzb_);
                object vze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szl_);
                object vzf_ = context.Operators.LateBoundProperty<object>(vze_, "high");
                CqlDate vzg_ = context.Operators.Add(vzc_, vzf_ as CqlQuantity);
                CqlDate vzi_ = context.Operators.Add(vzg_, szx_);
                CqlInterval<CqlDate> vzj_ = context.Operators.Interval(uzy_, vzi_, true, false);
                bool? vzk_ = vzj_?.highClosed;
                CqlInterval<CqlDateTime> vzl_ = context.Operators.Interval(tzb_, tzw_, uzq_, vzk_);

                return vzl_;
            }
            else if (ozs_())
            {
                DataType vzm_ = condition?.Abatement;
                object vzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzm_);
                object vzo_ = context.Operators.LateBoundProperty<object>(vzn_, "low");
                object vzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzm_);
                object vzr_ = context.Operators.LateBoundProperty<object>(vzq_, "high");
                CqlInterval<CqlDateTime> vzs_ = context.Operators.Interval(vzo_ as CqlDateTime, vzr_ as CqlDateTime, true, false);

                return vzs_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ozo_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vzt_()
        {
            bool vzu_()
            {
                DataType vzy_ = condition?.Abatement;
                object vzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzy_);
                bool wza_ = vzz_ is CqlDateTime;

                return wza_;
            };
            bool vzv_()
            {
                DataType wzb_ = condition?.Abatement;
                object wzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzb_);
                bool wzd_ = wzc_ is CqlQuantity;

                return wzd_;
            };
            bool vzw_()
            {
                DataType wze_ = condition?.Abatement;
                object wzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                bool wzg_ = wzf_ is CqlInterval<CqlQuantity>;

                return wzg_;
            };
            bool vzx_()
            {
                DataType wzh_ = condition?.Abatement;
                object wzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzh_);
                bool wzj_ = wzi_ is CqlInterval<CqlDateTime>;

                return wzj_;
            };
            if (vzu_())
            {
                DataType wzk_ = condition?.Abatement;
                object wzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzk_);
                object wzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzk_);
                CqlInterval<CqlDateTime> wzo_ = context.Operators.Interval(wzl_ as CqlDateTime, wzn_ as CqlDateTime, true, true);

                return wzo_;
            }
            else if (vzv_())
            {
                Patient wzp_ = this.Patient(context);
                Date wzq_ = wzp_?.BirthDateElement;
                string wzr_ = wzq_?.Value;
                CqlDate wzs_ = context.Operators.ConvertStringToDate(wzr_);
                DataType wzt_ = condition?.Abatement;
                object wzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate wzv_ = context.Operators.Add(wzs_, wzu_ as CqlQuantity);
                Date wzx_ = wzp_?.BirthDateElement;
                string wzy_ = wzx_?.Value;
                CqlDate wzz_ = context.Operators.ConvertStringToDate(wzy_);
                object xzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate xzc_ = context.Operators.Add(wzz_, xzb_ as CqlQuantity);
                CqlQuantity xzd_ = context.Operators.Quantity(1m, "year");
                CqlDate xze_ = context.Operators.Add(xzc_, xzd_);
                CqlInterval<CqlDate> xzf_ = context.Operators.Interval(wzv_, xze_, true, false);
                CqlDate xzg_ = xzf_?.low;
                CqlDateTime xzh_ = context.Operators.ConvertDateToDateTime(xzg_);
                Date xzj_ = wzp_?.BirthDateElement;
                string xzk_ = xzj_?.Value;
                CqlDate xzl_ = context.Operators.ConvertStringToDate(xzk_);
                object xzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate xzo_ = context.Operators.Add(xzl_, xzn_ as CqlQuantity);
                Date xzq_ = wzp_?.BirthDateElement;
                string xzr_ = xzq_?.Value;
                CqlDate xzs_ = context.Operators.ConvertStringToDate(xzr_);
                object xzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate xzv_ = context.Operators.Add(xzs_, xzu_ as CqlQuantity);
                CqlDate xzx_ = context.Operators.Add(xzv_, xzd_);
                CqlInterval<CqlDate> xzy_ = context.Operators.Interval(xzo_, xzx_, true, false);
                CqlDate xzz_ = xzy_?.high;
                CqlDateTime yza_ = context.Operators.ConvertDateToDateTime(xzz_);
                Date yzc_ = wzp_?.BirthDateElement;
                string yzd_ = yzc_?.Value;
                CqlDate yze_ = context.Operators.ConvertStringToDate(yzd_);
                object yzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate yzh_ = context.Operators.Add(yze_, yzg_ as CqlQuantity);
                Date yzj_ = wzp_?.BirthDateElement;
                string yzk_ = yzj_?.Value;
                CqlDate yzl_ = context.Operators.ConvertStringToDate(yzk_);
                object yzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate yzo_ = context.Operators.Add(yzl_, yzn_ as CqlQuantity);
                CqlDate yzq_ = context.Operators.Add(yzo_, xzd_);
                CqlInterval<CqlDate> yzr_ = context.Operators.Interval(yzh_, yzq_, true, false);
                bool? yzs_ = yzr_?.lowClosed;
                Date yzu_ = wzp_?.BirthDateElement;
                string yzv_ = yzu_?.Value;
                CqlDate yzw_ = context.Operators.ConvertStringToDate(yzv_);
                object yzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate yzz_ = context.Operators.Add(yzw_, yzy_ as CqlQuantity);
                Date zzb_ = wzp_?.BirthDateElement;
                string zzc_ = zzb_?.Value;
                CqlDate zzd_ = context.Operators.ConvertStringToDate(zzc_);
                object zzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzt_);
                CqlDate zzg_ = context.Operators.Add(zzd_, zzf_ as CqlQuantity);
                CqlDate zzi_ = context.Operators.Add(zzg_, xzd_);
                CqlInterval<CqlDate> zzj_ = context.Operators.Interval(yzz_, zzi_, true, false);
                bool? zzk_ = zzj_?.highClosed;
                CqlInterval<CqlDateTime> zzl_ = context.Operators.Interval(xzh_, yza_, yzs_, zzk_);

                return zzl_;
            }
            else if (vzw_())
            {
                Patient zzm_ = this.Patient(context);
                Date zzn_ = zzm_?.BirthDateElement;
                string zzo_ = zzn_?.Value;
                CqlDate zzp_ = context.Operators.ConvertStringToDate(zzo_);
                DataType zzq_ = condition?.Abatement;
                object zzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object zzs_ = context.Operators.LateBoundProperty<object>(zzr_, "low");
                CqlDate zzt_ = context.Operators.Add(zzp_, zzs_ as CqlQuantity);
                Date zzv_ = zzm_?.BirthDateElement;
                string zzw_ = zzv_?.Value;
                CqlDate zzx_ = context.Operators.ConvertStringToDate(zzw_);
                object zzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object azza_ = context.Operators.LateBoundProperty<object>(zzz_, "high");
                CqlDate azzb_ = context.Operators.Add(zzx_, azza_ as CqlQuantity);
                CqlQuantity azzc_ = context.Operators.Quantity(1m, "year");
                CqlDate azzd_ = context.Operators.Add(azzb_, azzc_);
                CqlInterval<CqlDate> azze_ = context.Operators.Interval(zzt_, azzd_, true, false);
                CqlDate azzf_ = azze_?.low;
                CqlDateTime azzg_ = context.Operators.ConvertDateToDateTime(azzf_);
                Date azzi_ = zzm_?.BirthDateElement;
                string azzj_ = azzi_?.Value;
                CqlDate azzk_ = context.Operators.ConvertStringToDate(azzj_);
                object azzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object azzn_ = context.Operators.LateBoundProperty<object>(azzm_, "low");
                CqlDate azzo_ = context.Operators.Add(azzk_, azzn_ as CqlQuantity);
                Date azzq_ = zzm_?.BirthDateElement;
                string azzr_ = azzq_?.Value;
                CqlDate azzs_ = context.Operators.ConvertStringToDate(azzr_);
                object azzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object azzv_ = context.Operators.LateBoundProperty<object>(azzu_, "high");
                CqlDate azzw_ = context.Operators.Add(azzs_, azzv_ as CqlQuantity);
                CqlDate azzy_ = context.Operators.Add(azzw_, azzc_);
                CqlInterval<CqlDate> azzz_ = context.Operators.Interval(azzo_, azzy_, true, false);
                CqlDate bzza_ = azzz_?.high;
                CqlDateTime bzzb_ = context.Operators.ConvertDateToDateTime(bzza_);
                Date bzzd_ = zzm_?.BirthDateElement;
                string bzze_ = bzzd_?.Value;
                CqlDate bzzf_ = context.Operators.ConvertStringToDate(bzze_);
                object bzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object bzzi_ = context.Operators.LateBoundProperty<object>(bzzh_, "low");
                CqlDate bzzj_ = context.Operators.Add(bzzf_, bzzi_ as CqlQuantity);
                Date bzzl_ = zzm_?.BirthDateElement;
                string bzzm_ = bzzl_?.Value;
                CqlDate bzzn_ = context.Operators.ConvertStringToDate(bzzm_);
                object bzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object bzzq_ = context.Operators.LateBoundProperty<object>(bzzp_, "high");
                CqlDate bzzr_ = context.Operators.Add(bzzn_, bzzq_ as CqlQuantity);
                CqlDate bzzt_ = context.Operators.Add(bzzr_, azzc_);
                CqlInterval<CqlDate> bzzu_ = context.Operators.Interval(bzzj_, bzzt_, true, false);
                bool? bzzv_ = bzzu_?.lowClosed;
                Date bzzx_ = zzm_?.BirthDateElement;
                string bzzy_ = bzzx_?.Value;
                CqlDate bzzz_ = context.Operators.ConvertStringToDate(bzzy_);
                object czzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object czzc_ = context.Operators.LateBoundProperty<object>(czzb_, "low");
                CqlDate czzd_ = context.Operators.Add(bzzz_, czzc_ as CqlQuantity);
                Date czzf_ = zzm_?.BirthDateElement;
                string czzg_ = czzf_?.Value;
                CqlDate czzh_ = context.Operators.ConvertStringToDate(czzg_);
                object czzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzq_);
                object czzk_ = context.Operators.LateBoundProperty<object>(czzj_, "high");
                CqlDate czzl_ = context.Operators.Add(czzh_, czzk_ as CqlQuantity);
                CqlDate czzn_ = context.Operators.Add(czzl_, azzc_);
                CqlInterval<CqlDate> czzo_ = context.Operators.Interval(czzd_, czzn_, true, false);
                bool? czzp_ = czzo_?.highClosed;
                CqlInterval<CqlDateTime> czzq_ = context.Operators.Interval(azzg_, bzzb_, bzzv_, czzp_);

                return czzq_;
            }
            else if (vzx_())
            {
                DataType czzr_ = condition?.Abatement;
                object czzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzr_);
                object czzt_ = context.Operators.LateBoundProperty<object>(czzs_, "low");
                object czzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzr_);
                object czzw_ = context.Operators.LateBoundProperty<object>(czzv_, "high");
                CqlInterval<CqlDateTime> czzx_ = context.Operators.Interval(czzt_ as CqlDateTime, czzw_ as CqlDateTime, true, false);

                return czzx_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vzt_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzy_()
        {
            bool czzz_()
            {
                CodeableConcept dzza_ = condition?.ClinicalStatus;
                CqlConcept dzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzza_);
                CqlCode dzzc_ = this.active(context);
                CqlConcept dzzd_ = context.Operators.ConvertCodeToConcept(dzzc_);
                bool? dzze_ = context.Operators.Equivalent(dzzb_, dzzd_);
                CqlConcept dzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzza_);
                CqlCode dzzh_ = this.recurrence(context);
                CqlConcept dzzi_ = context.Operators.ConvertCodeToConcept(dzzh_);
                bool? dzzj_ = context.Operators.Equivalent(dzzg_, dzzi_);
                bool? dzzk_ = context.Operators.Or(dzze_, dzzj_);
                CqlConcept dzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzza_);
                CqlCode dzzn_ = this.relapse(context);
                CqlConcept dzzo_ = context.Operators.ConvertCodeToConcept(dzzn_);
                bool? dzzp_ = context.Operators.Equivalent(dzzm_, dzzo_);
                bool? dzzq_ = context.Operators.Or(dzzk_, dzzp_);

                return dzzq_ ?? false;
            };
            if (czzz_())
            {
                DataType dzzr_ = condition?.Onset;
                object dzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzr_);
                CqlInterval<CqlDateTime> dzzt_ = this.ToInterval(context, dzzs_);
                CqlDateTime dzzu_ = context.Operators.Start(dzzt_);
                CqlInterval<CqlDateTime> dzzv_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzw_ = context.Operators.End(dzzv_);
                CqlInterval<CqlDateTime> dzzx_ = context.Operators.Interval(dzzu_, dzzw_, true, true);

                return dzzx_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzy_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzz_ = context.Operators.End(dzzy_);
                CqlDateTime[] ezza_ = [
                    dzzz_,
                ];
                CqlInterval<CqlDateTime> ezzb_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> ezzf_()
                    {
                        if (abatementDate is null)
                        {
                            DataType ezzg_ = condition?.Onset;
                            object ezzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzg_);
                            CqlInterval<CqlDateTime> ezzi_ = this.ToInterval(context, ezzh_);
                            CqlDateTime ezzj_ = context.Operators.Start(ezzi_);
                            CqlInterval<CqlDateTime> ezzk_ = context.Operators.Interval(ezzj_, abatementDate, true, false);

                            return ezzk_;
                        }
                        else
                        {
                            DataType ezzl_ = condition?.Onset;
                            object ezzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzl_);
                            CqlInterval<CqlDateTime> ezzn_ = this.ToInterval(context, ezzm_);
                            CqlDateTime ezzo_ = context.Operators.Start(ezzn_);
                            CqlInterval<CqlDateTime> ezzp_ = context.Operators.Interval(ezzo_, abatementDate, true, true);

                            return ezzp_;
                        }
                    };

                    return ezzf_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> ezzc_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ezza_, ezzb_);
                IEnumerable<CqlInterval<CqlDateTime>> ezzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzc_);
                CqlInterval<CqlDateTime> ezze_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ezzd_);

                return ezze_;
            }
        };

        return czzy_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ezzq_()
        {
            bool ezzr_()
            {
                CodeableConcept ezzs_ = condition?.ClinicalStatus;
                CqlConcept ezzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzs_);
                CqlCode ezzu_ = this.active(context);
                CqlConcept ezzv_ = context.Operators.ConvertCodeToConcept(ezzu_);
                bool? ezzw_ = context.Operators.Equivalent(ezzt_, ezzv_);
                CqlConcept ezzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzs_);
                CqlCode ezzz_ = this.recurrence(context);
                CqlConcept fzza_ = context.Operators.ConvertCodeToConcept(ezzz_);
                bool? fzzb_ = context.Operators.Equivalent(ezzy_, fzza_);
                bool? fzzc_ = context.Operators.Or(ezzw_, fzzb_);
                CqlConcept fzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzs_);
                CqlCode fzzf_ = this.relapse(context);
                CqlConcept fzzg_ = context.Operators.ConvertCodeToConcept(fzzf_);
                bool? fzzh_ = context.Operators.Equivalent(fzze_, fzzg_);
                bool? fzzi_ = context.Operators.Or(fzzc_, fzzh_);

                return fzzi_ ?? false;
            };
            if (ezzr_())
            {
                DataType fzzj_ = condition?.Onset;
                object fzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzj_);
                CqlInterval<CqlDateTime> fzzl_ = this.toInterval(context, fzzk_);
                CqlDateTime fzzm_ = context.Operators.Start(fzzl_);
                CqlInterval<CqlDateTime> fzzn_ = this.abatementInterval(context, condition);
                CqlDateTime fzzo_ = context.Operators.End(fzzn_);
                CqlInterval<CqlDateTime> fzzp_ = context.Operators.Interval(fzzm_, fzzo_, true, true);

                return fzzp_;
            }
            else
            {
                CqlInterval<CqlDateTime> fzzq_ = this.abatementInterval(context, condition);
                CqlDateTime fzzr_ = context.Operators.End(fzzq_);
                CqlDateTime[] fzzs_ = [
                    fzzr_,
                ];
                CqlInterval<CqlDateTime> fzzt_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzx_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzy_ = condition?.Onset;
                            object fzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzy_);
                            CqlInterval<CqlDateTime> gzza_ = this.toInterval(context, fzzz_);
                            CqlDateTime gzzb_ = context.Operators.Start(gzza_);
                            CqlInterval<CqlDateTime> gzzc_ = context.Operators.Interval(gzzb_, abatementDate, true, false);

                            return gzzc_;
                        }
                        else
                        {
                            DataType gzzd_ = condition?.Onset;
                            object gzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzd_);
                            CqlInterval<CqlDateTime> gzzf_ = this.toInterval(context, gzze_);
                            CqlDateTime gzzg_ = context.Operators.Start(gzzf_);
                            CqlInterval<CqlDateTime> gzzh_ = context.Operators.Interval(gzzg_, abatementDate, true, true);

                            return gzzh_;
                        }
                    };

                    return fzzx_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzu_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzs_, fzzt_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzu_);
                CqlInterval<CqlDateTime> fzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzv_);

                return fzzw_;
            }
        };

        return ezzq_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzi_ = context.Operators.Split(uri, "/");
        string gzzj_ = context.Operators.Last<string>(gzzi_);

        return gzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzk_ = context.Operators.Split(uri, "/");
        string gzzl_ = context.Operators.Last<string>(gzzk_);

        return gzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzm_ = context.Operators.Start(period);
        CqlDateTime gzzo_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzp_ = context.Operators.Equal(gzzm_, gzzo_);
        bool? gzzq_ = context.Operators.Or((bool?)(gzzm_ is null), gzzp_);
        bool? gzzr_ = context.Operators.Not(gzzq_);

        return gzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzs_ = context.Operators.Start(period);
        CqlDateTime gzzu_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzv_ = context.Operators.Equal(gzzs_, gzzu_);
        bool? gzzw_ = context.Operators.Or((bool?)(gzzs_ is null), gzzv_);
        bool? gzzx_ = context.Operators.Not(gzzw_);

        return gzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzy_ = context.Operators.End(period);
        CqlDateTime hzza_ = context.Operators.MaxValue<CqlDateTime>();
        bool? hzzb_ = context.Operators.Equal(gzzy_, hzza_);
        bool? hzzc_ = context.Operators.Or((bool?)(gzzy_ is null), hzzb_);
        bool? hzzd_ = context.Operators.Not(hzzc_);

        return hzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime hzze_ = context.Operators.End(period);
        CqlDateTime hzzg_ = context.Operators.MaxValue<CqlDateTime>();
        bool? hzzh_ = context.Operators.Equal(hzze_, hzzg_);
        bool? hzzi_ = context.Operators.Or((bool?)(hzze_ is null), hzzh_);
        bool? hzzj_ = context.Operators.Not(hzzi_);

        return hzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzk_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzl_ = [
            hzzk_,
        ];
        CqlDateTime hzzm_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzq_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzr_ = context.Operators.End(period);

                    return hzzr_;
                }
                else
                {
                    CqlDateTime hzzs_ = context.Operators.Start(period);

                    return hzzs_;
                }
            };

            return hzzq_();
        };
        IEnumerable<CqlDateTime> hzzn_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzl_, hzzm_);
        IEnumerable<CqlDateTime> hzzo_ = context.Operators.Distinct<CqlDateTime>(hzzn_);
        CqlDateTime hzzp_ = context.Operators.SingletonFrom<CqlDateTime>(hzzo_);

        return hzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzt_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzu_ = [
            hzzt_,
        ];
        CqlDateTime hzzv_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzz_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime izza_ = context.Operators.End(period);

                    return izza_;
                }
                else
                {
                    CqlDateTime izzb_ = context.Operators.Start(period);

                    return izzb_;
                }
            };

            return hzzz_();
        };
        IEnumerable<CqlDateTime> hzzw_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzu_, hzzv_);
        IEnumerable<CqlDateTime> hzzx_ = context.Operators.Distinct<CqlDateTime>(hzzw_);
        CqlDateTime hzzy_ = context.Operators.SingletonFrom<CqlDateTime>(hzzx_);

        return hzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izzc_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] izzd_ = [
            izzc_,
        ];
        CqlDateTime izze_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzi_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime izzj_ = context.Operators.Start(period);

                    return izzj_;
                }
                else
                {
                    CqlDateTime izzk_ = context.Operators.End(period);

                    return izzk_;
                }
            };

            return izzi_();
        };
        IEnumerable<CqlDateTime> izzf_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)izzd_, izze_);
        IEnumerable<CqlDateTime> izzg_ = context.Operators.Distinct<CqlDateTime>(izzf_);
        CqlDateTime izzh_ = context.Operators.SingletonFrom<CqlDateTime>(izzg_);

        return izzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izzl_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] izzm_ = [
            izzl_,
        ];
        CqlDateTime izzn_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzr_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime izzs_ = context.Operators.Start(period);

                    return izzs_;
                }
                else
                {
                    CqlDateTime izzt_ = context.Operators.End(period);

                    return izzt_;
                }
            };

            return izzr_();
        };
        IEnumerable<CqlDateTime> izzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)izzm_, izzn_);
        IEnumerable<CqlDateTime> izzp_ = context.Operators.Distinct<CqlDateTime>(izzo_);
        CqlDateTime izzq_ = context.Operators.SingletonFrom<CqlDateTime>(izzp_);

        return izzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzu_ = context.Operators.Start(Period);
        CqlDateTime izzv_ = context.Operators.End(Period);
        int? izzw_ = context.Operators.DurationBetween(izzu_, izzv_, "day");
        CqlInterval<int?> izzx_ = context.Operators.Interval(1, izzw_, true, true);
        CqlInterval<int?>[] izzy_ = [
            izzx_,
        ];
        IEnumerable<CqlInterval<int?>> izzz_ = context.Operators.Expand(izzy_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzza_(CqlInterval<int?> DayNumber)
        {
            int? jzzd_ = context.Operators.End(DayNumber);

            return jzzd_;
        };
        IEnumerable<int?> jzzb_ = context.Operators.Select<CqlInterval<int?>, int?>(izzz_, jzza_);
        IEnumerable<int?> jzzc_ = context.Operators.Distinct<int?>(jzzb_);

        return jzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime jzze_ = context.Operators.Start(Period);
        CqlDateTime jzzf_ = context.Operators.End(Period);
        int? jzzg_ = context.Operators.DurationBetween(jzze_, jzzf_, "day");
        CqlInterval<int?> jzzh_ = context.Operators.Interval(1, jzzg_, true, true);
        CqlInterval<int?>[] jzzi_ = [
            jzzh_,
        ];
        IEnumerable<CqlInterval<int?>> jzzj_ = context.Operators.Expand(jzzi_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzzk_(CqlInterval<int?> DayNumber)
        {
            int? jzzn_ = context.Operators.End(DayNumber);

            return jzzn_;
        };
        IEnumerable<int?> jzzl_ = context.Operators.Select<CqlInterval<int?>, int?>(jzzj_, jzzk_);
        IEnumerable<int?> jzzm_ = context.Operators.Distinct<int?>(jzzl_);

        return jzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> jzzo_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzp_(int? DayIndex)
        {
            CqlDateTime jzzs_ = context.Operators.Start(Period);
            CqlQuantity jzzt_ = context.Operators.Quantity(24m, "hours");
            int? jzzu_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzzv_ = context.Operators.ConvertIntegerToQuantity(jzzu_);
            CqlQuantity jzzw_ = context.Operators.Multiply(jzzt_, jzzv_);
            CqlDateTime jzzx_ = context.Operators.Add(jzzs_, jzzw_);
            CqlDateTime jzzy_()
            {
                bool kzzb_()
                {
                    CqlDateTime kzzc_ = context.Operators.Start(Period);
                    CqlQuantity kzzd_ = context.Operators.Quantity(24m, "hours");
                    int? kzze_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzf_ = context.Operators.ConvertIntegerToQuantity(kzze_);
                    CqlQuantity kzzg_ = context.Operators.Multiply(kzzd_, kzzf_);
                    CqlDateTime kzzh_ = context.Operators.Add(kzzc_, kzzg_);
                    CqlDateTime kzzi_ = context.Operators.End(Period);
                    int? kzzj_ = context.Operators.DurationBetween(kzzh_, kzzi_, "hour");
                    bool? kzzk_ = context.Operators.Less(kzzj_, 24);

                    return kzzk_ ?? false;
                };
                if (kzzb_())
                {
                    CqlDateTime kzzl_ = context.Operators.Start(Period);
                    CqlQuantity kzzm_ = context.Operators.Quantity(24m, "hours");
                    int? kzzn_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzo_ = context.Operators.ConvertIntegerToQuantity(kzzn_);
                    CqlQuantity kzzp_ = context.Operators.Multiply(kzzm_, kzzo_);
                    CqlDateTime kzzq_ = context.Operators.Add(kzzl_, kzzp_);

                    return kzzq_;
                }
                else
                {
                    CqlDateTime kzzr_ = context.Operators.Start(Period);
                    CqlQuantity kzzs_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzt_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzu_ = context.Operators.Multiply(kzzs_, kzzt_);
                    CqlDateTime kzzv_ = context.Operators.Add(kzzr_, kzzu_);

                    return kzzv_;
                }
            };
            CqlInterval<CqlDateTime> jzzz_ = context.Operators.Interval(jzzx_, jzzy_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzza_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzz_);

            return kzza_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzq_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzo_, jzzp_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzr_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzq_);

        return jzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzw_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzx_(int? DayIndex)
        {
            CqlDateTime lzza_ = context.Operators.Start(Period);
            CqlQuantity lzzb_ = context.Operators.Quantity(24m, "hours");
            int? lzzc_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity lzzd_ = context.Operators.ConvertIntegerToQuantity(lzzc_);
            CqlQuantity lzze_ = context.Operators.Multiply(lzzb_, lzzd_);
            CqlDateTime lzzf_ = context.Operators.Add(lzza_, lzze_);
            CqlDateTime lzzg_()
            {
                bool lzzj_()
                {
                    CqlDateTime lzzk_ = context.Operators.Start(Period);
                    CqlQuantity lzzl_ = context.Operators.Quantity(24m, "hours");
                    int? lzzm_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzn_ = context.Operators.ConvertIntegerToQuantity(lzzm_);
                    CqlQuantity lzzo_ = context.Operators.Multiply(lzzl_, lzzn_);
                    CqlDateTime lzzp_ = context.Operators.Add(lzzk_, lzzo_);
                    CqlDateTime lzzq_ = context.Operators.End(Period);
                    int? lzzr_ = context.Operators.DurationBetween(lzzp_, lzzq_, "hour");
                    bool? lzzs_ = context.Operators.Less(lzzr_, 24);

                    return lzzs_ ?? false;
                };
                if (lzzj_())
                {
                    CqlDateTime lzzt_ = context.Operators.Start(Period);
                    CqlQuantity lzzu_ = context.Operators.Quantity(24m, "hours");
                    int? lzzv_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzw_ = context.Operators.ConvertIntegerToQuantity(lzzv_);
                    CqlQuantity lzzx_ = context.Operators.Multiply(lzzu_, lzzw_);
                    CqlDateTime lzzy_ = context.Operators.Add(lzzt_, lzzx_);

                    return lzzy_;
                }
                else
                {
                    CqlDateTime lzzz_ = context.Operators.Start(Period);
                    CqlQuantity mzza_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity mzzb_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity mzzc_ = context.Operators.Multiply(mzza_, mzzb_);
                    CqlDateTime mzzd_ = context.Operators.Add(lzzz_, mzzc_);

                    return mzzd_;
                }
            };
            CqlInterval<CqlDateTime> lzzh_ = context.Operators.Interval(lzzf_, lzzg_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? lzzi_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, lzzh_);

            return lzzi_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzy_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzw_, kzzx_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzz_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzy_);

        return kzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
