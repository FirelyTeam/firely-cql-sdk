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
[CqlLibrary("QICoreCommon", "2.0.000")]
public partial class QICoreCommon_2_0_000 : ILibrary, ISingleton<QICoreCommon_2_0_000>
{
    private QICoreCommon_2_0_000() {}

    public static QICoreCommon_2_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "QICoreCommon";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

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

    #region Code: clinical-test
    [CqlCodeDefinition(
        definitionName: "clinical-test",
        codeId: "clinical-test",
        codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category")]
    public CqlCode clinical_test(CqlContext context) => _clinical_test;

    private static readonly CqlCode _clinical_test = new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] tzp_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return tzp_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] tzq_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return tzq_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] tzr_ = [
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

        return tzr_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] tzs_ = [
            new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
            new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
        ];

        return tzs_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] tzt_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return tzt_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RequestIntent")]
    public CqlCode[] RequestIntent(CqlContext context)
    {
        CqlCode[] tzu_ = []
;

        return tzu_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] tzv_ = [
            new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return tzv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] tzw_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return tzw_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] tzx_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return tzx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] tzy_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
        ];

        return tzy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] tzz_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return tzz_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] uza_ = [
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

        return uza_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "USCoreObservationCategoryExtensionCodes")]
    public CqlCode[] USCoreObservationCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] uzb_ = [
            new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default),
        ];

        return uzb_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionCategory")]
    public CqlCode[] ConditionCategory(CqlContext context)
    {
        CqlCode[] uzc_ = [
            new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
            new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
        ];

        return uzc_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "USCoreConditionCategoryExtensionCodes")]
    public CqlCode[] USCoreConditionCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] uzd_ = [
            new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default),
        ];

        return uzd_;
    }


    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzf_ = context.Operators.SingletonFrom<Patient>(uze_);

        return uzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept uzg_ = condition?.ClinicalStatus;
        CqlConcept uzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzg_);
        CqlCode uzi_ = this.active(context);
        CqlConcept uzj_ = context.Operators.ConvertCodeToConcept(uzi_);
        bool? uzk_ = context.Operators.Equivalent(uzh_, uzj_);
        CqlConcept uzm_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzg_);
        CqlCode uzn_ = this.recurrence(context);
        CqlConcept uzo_ = context.Operators.ConvertCodeToConcept(uzn_);
        bool? uzp_ = context.Operators.Equivalent(uzm_, uzo_);
        bool? uzq_ = context.Operators.Or(uzk_, uzp_);
        CqlConcept uzs_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzg_);
        CqlCode uzt_ = this.relapse(context);
        CqlConcept uzu_ = context.Operators.ConvertCodeToConcept(uzt_);
        bool? uzv_ = context.Operators.Equivalent(uzs_, uzu_);
        bool? uzw_ = context.Operators.Or(uzq_, uzv_);

        return uzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> uzx_ = condition?.Category;
        CqlConcept uzy_(CodeableConcept @this)
        {
            CqlConcept vzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return vzd_;
        };
        IEnumerable<CqlConcept> uzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzx_, uzy_);
        bool? vza_(CqlConcept C)
        {
            CqlConcept vze_ = context.Operators.ConvertCodeToConcept(category);
            bool? vzf_ = context.Operators.Equivalent(C, vze_);

            return vzf_;
        };
        IEnumerable<CqlConcept> vzb_ = context.Operators.Where<CqlConcept>(uzz_, vza_);
        bool? vzc_ = context.Operators.Exists<CqlConcept>(vzb_);

        return vzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> vzg_ = observation?.Category;
        CqlConcept vzh_(CodeableConcept @this)
        {
            CqlConcept vzm_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return vzm_;
        };
        IEnumerable<CqlConcept> vzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzg_, vzh_);
        bool? vzj_(CqlConcept C)
        {
            CqlConcept vzn_ = context.Operators.ConvertCodeToConcept(category);
            bool? vzo_ = context.Operators.Equivalent(C, vzn_);

            return vzo_;
        };
        IEnumerable<CqlConcept> vzk_ = context.Operators.Where<CqlConcept>(vzi_, vzj_);
        bool? vzl_ = context.Operators.Exists<CqlConcept>(vzk_);

        return vzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> vzp_ = condition?.Category;
        CqlConcept vzq_(CodeableConcept @this)
        {
            CqlConcept vzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return vzv_;
        };
        IEnumerable<CqlConcept> vzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzp_, vzq_);
        bool? vzs_(CqlConcept C)
        {
            CqlCode vzw_ = this.problem_list_item(context);
            CqlConcept vzx_ = context.Operators.ConvertCodeToConcept(vzw_);
            bool? vzy_ = context.Operators.Equivalent(C, vzx_);

            return vzy_;
        };
        IEnumerable<CqlConcept> vzt_ = context.Operators.Where<CqlConcept>(vzr_, vzs_);
        bool? vzu_ = context.Operators.Exists<CqlConcept>(vzt_);

        return vzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> vzz_ = condition?.Category;
        CqlConcept wza_(CodeableConcept @this)
        {
            CqlConcept wzf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return wzf_;
        };
        IEnumerable<CqlConcept> wzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzz_, wza_);
        bool? wzc_(CqlConcept C)
        {
            CqlCode wzg_ = this.encounter_diagnosis(context);
            CqlConcept wzh_ = context.Operators.ConvertCodeToConcept(wzg_);
            bool? wzi_ = context.Operators.Equivalent(C, wzh_);

            return wzi_;
        };
        IEnumerable<CqlConcept> wzd_ = context.Operators.Where<CqlConcept>(wzb_, wzc_);
        bool? wze_ = context.Operators.Exists<CqlConcept>(wzd_);

        return wze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> wzj_ = condition?.Category;
        CqlConcept wzk_(CodeableConcept @this)
        {
            CqlConcept wzp_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return wzp_;
        };
        IEnumerable<CqlConcept> wzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzj_, wzk_);
        bool? wzm_(CqlConcept C)
        {
            CqlCode wzq_ = this.health_concern(context);
            CqlConcept wzr_ = context.Operators.ConvertCodeToConcept(wzq_);
            bool? wzs_ = context.Operators.Equivalent(C, wzr_);

            return wzs_;
        };
        IEnumerable<CqlConcept> wzn_ = context.Operators.Where<CqlConcept>(wzl_, wzm_);
        bool? wzo_ = context.Operators.Exists<CqlConcept>(wzn_);

        return wzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> wzt_ = observation?.Category;
        CqlConcept wzu_(CodeableConcept @this)
        {
            CqlConcept wzz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return wzz_;
        };
        IEnumerable<CqlConcept> wzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzt_, wzu_);
        bool? wzw_(CqlConcept C)
        {
            CqlCode xza_ = this.social_history(context);
            CqlConcept xzb_ = context.Operators.ConvertCodeToConcept(xza_);
            bool? xzc_ = context.Operators.Equivalent(C, xzb_);

            return xzc_;
        };
        IEnumerable<CqlConcept> wzx_ = context.Operators.Where<CqlConcept>(wzv_, wzw_);
        bool? wzy_ = context.Operators.Exists<CqlConcept>(wzx_);

        return wzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> xzd_ = observation?.Category;
        CqlConcept xze_(CodeableConcept @this)
        {
            CqlConcept xzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xzj_;
        };
        IEnumerable<CqlConcept> xzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzd_, xze_);
        bool? xzg_(CqlConcept C)
        {
            CqlCode xzk_ = this.vital_signs(context);
            CqlConcept xzl_ = context.Operators.ConvertCodeToConcept(xzk_);
            bool? xzm_ = context.Operators.Equivalent(C, xzl_);

            return xzm_;
        };
        IEnumerable<CqlConcept> xzh_ = context.Operators.Where<CqlConcept>(xzf_, xzg_);
        bool? xzi_ = context.Operators.Exists<CqlConcept>(xzh_);

        return xzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> xzn_ = observation?.Category;
        CqlConcept xzo_(CodeableConcept @this)
        {
            CqlConcept xzt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xzt_;
        };
        IEnumerable<CqlConcept> xzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzn_, xzo_);
        bool? xzq_(CqlConcept C)
        {
            CqlCode xzu_ = this.imaging(context);
            CqlConcept xzv_ = context.Operators.ConvertCodeToConcept(xzu_);
            bool? xzw_ = context.Operators.Equivalent(C, xzv_);

            return xzw_;
        };
        IEnumerable<CqlConcept> xzr_ = context.Operators.Where<CqlConcept>(xzp_, xzq_);
        bool? xzs_ = context.Operators.Exists<CqlConcept>(xzr_);

        return xzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> xzx_ = observation?.Category;
        CqlConcept xzy_(CodeableConcept @this)
        {
            CqlConcept yzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yzd_;
        };
        IEnumerable<CqlConcept> xzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzx_, xzy_);
        bool? yza_(CqlConcept C)
        {
            CqlCode yze_ = this.laboratory(context);
            CqlConcept yzf_ = context.Operators.ConvertCodeToConcept(yze_);
            bool? yzg_ = context.Operators.Equivalent(C, yzf_);

            return yzg_;
        };
        IEnumerable<CqlConcept> yzb_ = context.Operators.Where<CqlConcept>(xzz_, yza_);
        bool? yzc_ = context.Operators.Exists<CqlConcept>(yzb_);

        return yzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> yzh_ = observation?.Category;
        CqlConcept yzi_(CodeableConcept @this)
        {
            CqlConcept yzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yzn_;
        };
        IEnumerable<CqlConcept> yzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzh_, yzi_);
        bool? yzk_(CqlConcept C)
        {
            CqlCode yzo_ = this.procedure(context);
            CqlConcept yzp_ = context.Operators.ConvertCodeToConcept(yzo_);
            bool? yzq_ = context.Operators.Equivalent(C, yzp_);

            return yzq_;
        };
        IEnumerable<CqlConcept> yzl_ = context.Operators.Where<CqlConcept>(yzj_, yzk_);
        bool? yzm_ = context.Operators.Exists<CqlConcept>(yzl_);

        return yzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> yzr_ = observation?.Category;
        CqlConcept yzs_(CodeableConcept @this)
        {
            CqlConcept yzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yzx_;
        };
        IEnumerable<CqlConcept> yzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzr_, yzs_);
        bool? yzu_(CqlConcept C)
        {
            CqlCode yzy_ = this.survey(context);
            CqlConcept yzz_ = context.Operators.ConvertCodeToConcept(yzy_);
            bool? zza_ = context.Operators.Equivalent(C, yzz_);

            return zza_;
        };
        IEnumerable<CqlConcept> yzv_ = context.Operators.Where<CqlConcept>(yzt_, yzu_);
        bool? yzw_ = context.Operators.Exists<CqlConcept>(yzv_);

        return yzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zzb_ = observation?.Category;
        CqlConcept zzc_(CodeableConcept @this)
        {
            CqlConcept zzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zzh_;
        };
        IEnumerable<CqlConcept> zzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzb_, zzc_);
        bool? zze_(CqlConcept C)
        {
            CqlCode zzi_ = this.exam(context);
            CqlConcept zzj_ = context.Operators.ConvertCodeToConcept(zzi_);
            bool? zzk_ = context.Operators.Equivalent(C, zzj_);

            return zzk_;
        };
        IEnumerable<CqlConcept> zzf_ = context.Operators.Where<CqlConcept>(zzd_, zze_);
        bool? zzg_ = context.Operators.Exists<CqlConcept>(zzf_);

        return zzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zzl_ = observation?.Category;
        CqlConcept zzm_(CodeableConcept @this)
        {
            CqlConcept zzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zzr_;
        };
        IEnumerable<CqlConcept> zzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzl_, zzm_);
        bool? zzo_(CqlConcept C)
        {
            CqlCode zzs_ = this.therapy(context);
            CqlConcept zzt_ = context.Operators.ConvertCodeToConcept(zzs_);
            bool? zzu_ = context.Operators.Equivalent(C, zzt_);

            return zzu_;
        };
        IEnumerable<CqlConcept> zzp_ = context.Operators.Where<CqlConcept>(zzn_, zzo_);
        bool? zzq_ = context.Operators.Exists<CqlConcept>(zzp_);

        return zzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zzv_ = observation?.Category;
        CqlConcept zzw_(CodeableConcept @this)
        {
            CqlConcept azzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azzb_;
        };
        IEnumerable<CqlConcept> zzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzv_, zzw_);
        bool? zzy_(CqlConcept C)
        {
            CqlCode azzc_ = this.activity(context);
            CqlConcept azzd_ = context.Operators.ConvertCodeToConcept(azzc_);
            bool? azze_ = context.Operators.Equivalent(C, azzd_);

            return azze_;
        };
        IEnumerable<CqlConcept> zzz_ = context.Operators.Where<CqlConcept>(zzx_, zzy_);
        bool? azza_ = context.Operators.Exists<CqlConcept>(zzz_);

        return azza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azzf_ = observation?.Category;
        CqlConcept azzg_(CodeableConcept @this)
        {
            CqlConcept azzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azzl_;
        };
        IEnumerable<CqlConcept> azzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzf_, azzg_);
        bool? azzi_(CqlConcept C)
        {
            CqlCode azzm_ = this.clinical_test(context);
            CqlConcept azzn_ = context.Operators.ConvertCodeToConcept(azzm_);
            bool? azzo_ = context.Operators.Equivalent(C, azzn_);

            return azzo_;
        };
        IEnumerable<CqlConcept> azzj_ = context.Operators.Where<CqlConcept>(azzh_, azzi_);
        bool? azzk_ = context.Operators.Exists<CqlConcept>(azzj_);

        return azzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> azzp_ = medicationRequest?.Category;
        CqlConcept azzq_(CodeableConcept @this)
        {
            CqlConcept azzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azzv_;
        };
        IEnumerable<CqlConcept> azzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzp_, azzq_);
        bool? azzs_(CqlConcept C)
        {
            CqlCode azzw_ = this.Community(context);
            CqlConcept azzx_ = context.Operators.ConvertCodeToConcept(azzw_);
            bool? azzy_ = context.Operators.Equivalent(C, azzx_);

            return azzy_;
        };
        IEnumerable<CqlConcept> azzt_ = context.Operators.Where<CqlConcept>(azzr_, azzs_);
        bool? azzu_ = context.Operators.Exists<CqlConcept>(azzt_);

        return azzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> azzz_ = medicationRequest?.Category;
        CqlConcept bzza_(CodeableConcept @this)
        {
            CqlConcept bzzf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzzf_;
        };
        IEnumerable<CqlConcept> bzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzz_, bzza_);
        bool? bzzc_(CqlConcept C)
        {
            CqlCode bzzg_ = this.Discharge(context);
            CqlConcept bzzh_ = context.Operators.ConvertCodeToConcept(bzzg_);
            bool? bzzi_ = context.Operators.Equivalent(C, bzzh_);

            return bzzi_;
        };
        IEnumerable<CqlConcept> bzzd_ = context.Operators.Where<CqlConcept>(bzzb_, bzzc_);
        bool? bzze_ = context.Operators.Exists<CqlConcept>(bzzd_);

        return bzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? bzzj_(Extension E)
        {
            string bzzp_ = E?.Url;
            FhirString bzzq_ = context.Operators.Convert<FhirString>(bzzp_);
            string bzzr_ = bzzq_?.Value;
            bool? bzzs_ = context.Operators.Equal(bzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return bzzs_;
        };
        IEnumerable<Extension> bzzk_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), bzzj_);
        bool? bzzl_(Extension E)
        {
            DataType bzzt_ = E?.Value;
            object bzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bzzt_);

            return bzzu_ as bool?;
        };
        IEnumerable<bool?> bzzm_ = context.Operators.Select<Extension, bool?>(bzzk_, bzzl_);
        IEnumerable<bool?> bzzn_ = context.Operators.Distinct<bool?>(bzzm_);
        bool? bzzo_ = context.Operators.SingletonFrom<bool?>(bzzn_);

        return bzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> bzzv_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> bzzw_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return bzzw_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient bzzx_ = this.Patient(context);
                Date bzzy_ = bzzx_?.BirthDateElement;
                string bzzz_ = bzzy_?.Value;
                CqlDate czza_ = context.Operators.ConvertStringToDate(bzzz_);
                CqlDate czzb_ = context.Operators.Add(czza_, choice as CqlQuantity);
                Date czzd_ = bzzx_?.BirthDateElement;
                string czze_ = czzd_?.Value;
                CqlDate czzf_ = context.Operators.ConvertStringToDate(czze_);
                CqlDate czzg_ = context.Operators.Add(czzf_, choice as CqlQuantity);
                CqlQuantity czzh_ = context.Operators.Quantity(1m, "year");
                CqlDate czzi_ = context.Operators.Add(czzg_, czzh_);
                CqlInterval<CqlDate> czzj_ = context.Operators.Interval(czzb_, czzi_, true, false);
                CqlDate czzk_ = czzj_?.low;
                CqlDateTime czzl_ = context.Operators.ConvertDateToDateTime(czzk_);
                Date czzn_ = bzzx_?.BirthDateElement;
                string czzo_ = czzn_?.Value;
                CqlDate czzp_ = context.Operators.ConvertStringToDate(czzo_);
                CqlDate czzq_ = context.Operators.Add(czzp_, choice as CqlQuantity);
                Date czzs_ = bzzx_?.BirthDateElement;
                string czzt_ = czzs_?.Value;
                CqlDate czzu_ = context.Operators.ConvertStringToDate(czzt_);
                CqlDate czzv_ = context.Operators.Add(czzu_, choice as CqlQuantity);
                CqlDate czzx_ = context.Operators.Add(czzv_, czzh_);
                CqlInterval<CqlDate> czzy_ = context.Operators.Interval(czzq_, czzx_, true, false);
                CqlDate czzz_ = czzy_?.high;
                CqlDateTime dzza_ = context.Operators.ConvertDateToDateTime(czzz_);
                Date dzzc_ = bzzx_?.BirthDateElement;
                string dzzd_ = dzzc_?.Value;
                CqlDate dzze_ = context.Operators.ConvertStringToDate(dzzd_);
                CqlDate dzzf_ = context.Operators.Add(dzze_, choice as CqlQuantity);
                Date dzzh_ = bzzx_?.BirthDateElement;
                string dzzi_ = dzzh_?.Value;
                CqlDate dzzj_ = context.Operators.ConvertStringToDate(dzzi_);
                CqlDate dzzk_ = context.Operators.Add(dzzj_, choice as CqlQuantity);
                CqlDate dzzm_ = context.Operators.Add(dzzk_, czzh_);
                CqlInterval<CqlDate> dzzn_ = context.Operators.Interval(dzzf_, dzzm_, true, false);
                bool? dzzo_ = dzzn_?.lowClosed;
                Date dzzq_ = bzzx_?.BirthDateElement;
                string dzzr_ = dzzq_?.Value;
                CqlDate dzzs_ = context.Operators.ConvertStringToDate(dzzr_);
                CqlDate dzzt_ = context.Operators.Add(dzzs_, choice as CqlQuantity);
                Date dzzv_ = bzzx_?.BirthDateElement;
                string dzzw_ = dzzv_?.Value;
                CqlDate dzzx_ = context.Operators.ConvertStringToDate(dzzw_);
                CqlDate dzzy_ = context.Operators.Add(dzzx_, choice as CqlQuantity);
                CqlDate ezza_ = context.Operators.Add(dzzy_, czzh_);
                CqlInterval<CqlDate> ezzb_ = context.Operators.Interval(dzzt_, ezza_, true, false);
                bool? ezzc_ = ezzb_?.highClosed;
                CqlInterval<CqlDateTime> ezzd_ = context.Operators.Interval(czzl_, dzza_, dzzo_, ezzc_);

                return ezzd_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient ezze_ = this.Patient(context);
                Date ezzf_ = ezze_?.BirthDateElement;
                string ezzg_ = ezzf_?.Value;
                CqlDate ezzh_ = context.Operators.ConvertStringToDate(ezzg_);
                object ezzi_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate ezzj_ = context.Operators.Add(ezzh_, ezzi_ as CqlQuantity);
                Date ezzl_ = ezze_?.BirthDateElement;
                string ezzm_ = ezzl_?.Value;
                CqlDate ezzn_ = context.Operators.ConvertStringToDate(ezzm_);
                object ezzo_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate ezzp_ = context.Operators.Add(ezzn_, ezzo_ as CqlQuantity);
                CqlQuantity ezzq_ = context.Operators.Quantity(1m, "year");
                CqlDate ezzr_ = context.Operators.Add(ezzp_, ezzq_);
                CqlInterval<CqlDate> ezzs_ = context.Operators.Interval(ezzj_, ezzr_, true, false);
                CqlDate ezzt_ = ezzs_?.low;
                CqlDateTime ezzu_ = context.Operators.ConvertDateToDateTime(ezzt_);
                Date ezzw_ = ezze_?.BirthDateElement;
                string ezzx_ = ezzw_?.Value;
                CqlDate ezzy_ = context.Operators.ConvertStringToDate(ezzx_);
                CqlDate fzza_ = context.Operators.Add(ezzy_, ezzi_ as CqlQuantity);
                Date fzzc_ = ezze_?.BirthDateElement;
                string fzzd_ = fzzc_?.Value;
                CqlDate fzze_ = context.Operators.ConvertStringToDate(fzzd_);
                CqlDate fzzg_ = context.Operators.Add(fzze_, ezzo_ as CqlQuantity);
                CqlDate fzzi_ = context.Operators.Add(fzzg_, ezzq_);
                CqlInterval<CqlDate> fzzj_ = context.Operators.Interval(fzza_, fzzi_, true, false);
                CqlDate fzzk_ = fzzj_?.high;
                CqlDateTime fzzl_ = context.Operators.ConvertDateToDateTime(fzzk_);
                Date fzzn_ = ezze_?.BirthDateElement;
                string fzzo_ = fzzn_?.Value;
                CqlDate fzzp_ = context.Operators.ConvertStringToDate(fzzo_);
                CqlDate fzzr_ = context.Operators.Add(fzzp_, ezzi_ as CqlQuantity);
                Date fzzt_ = ezze_?.BirthDateElement;
                string fzzu_ = fzzt_?.Value;
                CqlDate fzzv_ = context.Operators.ConvertStringToDate(fzzu_);
                CqlDate fzzx_ = context.Operators.Add(fzzv_, ezzo_ as CqlQuantity);
                CqlDate fzzz_ = context.Operators.Add(fzzx_, ezzq_);
                CqlInterval<CqlDate> gzza_ = context.Operators.Interval(fzzr_, fzzz_, true, false);
                bool? gzzb_ = gzza_?.lowClosed;
                Date gzzd_ = ezze_?.BirthDateElement;
                string gzze_ = gzzd_?.Value;
                CqlDate gzzf_ = context.Operators.ConvertStringToDate(gzze_);
                CqlDate gzzh_ = context.Operators.Add(gzzf_, ezzi_ as CqlQuantity);
                Date gzzj_ = ezze_?.BirthDateElement;
                string gzzk_ = gzzj_?.Value;
                CqlDate gzzl_ = context.Operators.ConvertStringToDate(gzzk_);
                CqlDate gzzn_ = context.Operators.Add(gzzl_, ezzo_ as CqlQuantity);
                CqlDate gzzp_ = context.Operators.Add(gzzn_, ezzq_);
                CqlInterval<CqlDate> gzzq_ = context.Operators.Interval(gzzh_, gzzp_, true, false);
                bool? gzzr_ = gzzq_?.highClosed;
                CqlInterval<CqlDateTime> gzzs_ = context.Operators.Interval(ezzu_, fzzl_, gzzb_, gzzr_);

                return gzzs_;
            }
            else if (choice is Timing)
            {
                object gzzt_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return gzzt_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return bzzv_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> gzzu_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> gzzv_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return gzzv_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient gzzw_ = this.Patient(context);
                Date gzzx_ = gzzw_?.BirthDateElement;
                string gzzy_ = gzzx_?.Value;
                CqlDate gzzz_ = context.Operators.ConvertStringToDate(gzzy_);
                CqlDate hzza_ = context.Operators.Add(gzzz_, choice as CqlQuantity);
                Date hzzc_ = gzzw_?.BirthDateElement;
                string hzzd_ = hzzc_?.Value;
                CqlDate hzze_ = context.Operators.ConvertStringToDate(hzzd_);
                CqlDate hzzf_ = context.Operators.Add(hzze_, choice as CqlQuantity);
                CqlQuantity hzzg_ = context.Operators.Quantity(1m, "year");
                CqlDate hzzh_ = context.Operators.Add(hzzf_, hzzg_);
                CqlInterval<CqlDate> hzzi_ = context.Operators.Interval(hzza_, hzzh_, true, false);
                CqlDate hzzj_ = hzzi_?.low;
                CqlDateTime hzzk_ = context.Operators.ConvertDateToDateTime(hzzj_);
                Date hzzm_ = gzzw_?.BirthDateElement;
                string hzzn_ = hzzm_?.Value;
                CqlDate hzzo_ = context.Operators.ConvertStringToDate(hzzn_);
                CqlDate hzzp_ = context.Operators.Add(hzzo_, choice as CqlQuantity);
                Date hzzr_ = gzzw_?.BirthDateElement;
                string hzzs_ = hzzr_?.Value;
                CqlDate hzzt_ = context.Operators.ConvertStringToDate(hzzs_);
                CqlDate hzzu_ = context.Operators.Add(hzzt_, choice as CqlQuantity);
                CqlDate hzzw_ = context.Operators.Add(hzzu_, hzzg_);
                CqlInterval<CqlDate> hzzx_ = context.Operators.Interval(hzzp_, hzzw_, true, false);
                CqlDate hzzy_ = hzzx_?.high;
                CqlDateTime hzzz_ = context.Operators.ConvertDateToDateTime(hzzy_);
                Date izzb_ = gzzw_?.BirthDateElement;
                string izzc_ = izzb_?.Value;
                CqlDate izzd_ = context.Operators.ConvertStringToDate(izzc_);
                CqlDate izze_ = context.Operators.Add(izzd_, choice as CqlQuantity);
                Date izzg_ = gzzw_?.BirthDateElement;
                string izzh_ = izzg_?.Value;
                CqlDate izzi_ = context.Operators.ConvertStringToDate(izzh_);
                CqlDate izzj_ = context.Operators.Add(izzi_, choice as CqlQuantity);
                CqlDate izzl_ = context.Operators.Add(izzj_, hzzg_);
                CqlInterval<CqlDate> izzm_ = context.Operators.Interval(izze_, izzl_, true, false);
                bool? izzn_ = izzm_?.lowClosed;
                Date izzp_ = gzzw_?.BirthDateElement;
                string izzq_ = izzp_?.Value;
                CqlDate izzr_ = context.Operators.ConvertStringToDate(izzq_);
                CqlDate izzs_ = context.Operators.Add(izzr_, choice as CqlQuantity);
                Date izzu_ = gzzw_?.BirthDateElement;
                string izzv_ = izzu_?.Value;
                CqlDate izzw_ = context.Operators.ConvertStringToDate(izzv_);
                CqlDate izzx_ = context.Operators.Add(izzw_, choice as CqlQuantity);
                CqlDate izzz_ = context.Operators.Add(izzx_, hzzg_);
                CqlInterval<CqlDate> jzza_ = context.Operators.Interval(izzs_, izzz_, true, false);
                bool? jzzb_ = jzza_?.highClosed;
                CqlInterval<CqlDateTime> jzzc_ = context.Operators.Interval(hzzk_, hzzz_, izzn_, jzzb_);

                return jzzc_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient jzzd_ = this.Patient(context);
                Date jzze_ = jzzd_?.BirthDateElement;
                string jzzf_ = jzze_?.Value;
                CqlDate jzzg_ = context.Operators.ConvertStringToDate(jzzf_);
                object jzzh_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate jzzi_ = context.Operators.Add(jzzg_, jzzh_ as CqlQuantity);
                Date jzzk_ = jzzd_?.BirthDateElement;
                string jzzl_ = jzzk_?.Value;
                CqlDate jzzm_ = context.Operators.ConvertStringToDate(jzzl_);
                object jzzn_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate jzzo_ = context.Operators.Add(jzzm_, jzzn_ as CqlQuantity);
                CqlQuantity jzzp_ = context.Operators.Quantity(1m, "year");
                CqlDate jzzq_ = context.Operators.Add(jzzo_, jzzp_);
                CqlInterval<CqlDate> jzzr_ = context.Operators.Interval(jzzi_, jzzq_, true, false);
                CqlDate jzzs_ = jzzr_?.low;
                CqlDateTime jzzt_ = context.Operators.ConvertDateToDateTime(jzzs_);
                Date jzzv_ = jzzd_?.BirthDateElement;
                string jzzw_ = jzzv_?.Value;
                CqlDate jzzx_ = context.Operators.ConvertStringToDate(jzzw_);
                CqlDate jzzz_ = context.Operators.Add(jzzx_, jzzh_ as CqlQuantity);
                Date kzzb_ = jzzd_?.BirthDateElement;
                string kzzc_ = kzzb_?.Value;
                CqlDate kzzd_ = context.Operators.ConvertStringToDate(kzzc_);
                CqlDate kzzf_ = context.Operators.Add(kzzd_, jzzn_ as CqlQuantity);
                CqlDate kzzh_ = context.Operators.Add(kzzf_, jzzp_);
                CqlInterval<CqlDate> kzzi_ = context.Operators.Interval(jzzz_, kzzh_, true, false);
                CqlDate kzzj_ = kzzi_?.high;
                CqlDateTime kzzk_ = context.Operators.ConvertDateToDateTime(kzzj_);
                Date kzzm_ = jzzd_?.BirthDateElement;
                string kzzn_ = kzzm_?.Value;
                CqlDate kzzo_ = context.Operators.ConvertStringToDate(kzzn_);
                CqlDate kzzq_ = context.Operators.Add(kzzo_, jzzh_ as CqlQuantity);
                Date kzzs_ = jzzd_?.BirthDateElement;
                string kzzt_ = kzzs_?.Value;
                CqlDate kzzu_ = context.Operators.ConvertStringToDate(kzzt_);
                CqlDate kzzw_ = context.Operators.Add(kzzu_, jzzn_ as CqlQuantity);
                CqlDate kzzy_ = context.Operators.Add(kzzw_, jzzp_);
                CqlInterval<CqlDate> kzzz_ = context.Operators.Interval(kzzq_, kzzy_, true, false);
                bool? lzza_ = kzzz_?.lowClosed;
                Date lzzc_ = jzzd_?.BirthDateElement;
                string lzzd_ = lzzc_?.Value;
                CqlDate lzze_ = context.Operators.ConvertStringToDate(lzzd_);
                CqlDate lzzg_ = context.Operators.Add(lzze_, jzzh_ as CqlQuantity);
                Date lzzi_ = jzzd_?.BirthDateElement;
                string lzzj_ = lzzi_?.Value;
                CqlDate lzzk_ = context.Operators.ConvertStringToDate(lzzj_);
                CqlDate lzzm_ = context.Operators.Add(lzzk_, jzzn_ as CqlQuantity);
                CqlDate lzzo_ = context.Operators.Add(lzzm_, jzzp_);
                CqlInterval<CqlDate> lzzp_ = context.Operators.Interval(lzzg_, lzzo_, true, false);
                bool? lzzq_ = lzzp_?.highClosed;
                CqlInterval<CqlDateTime> lzzr_ = context.Operators.Interval(jzzt_, kzzk_, lzza_, lzzq_);

                return lzzr_;
            }
            else if (choice is Timing)
            {
                object lzzs_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return lzzs_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return gzzu_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> lzzt_()
        {
            bool lzzu_()
            {
                DataType lzzy_ = condition?.Abatement;
                object lzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzy_);
                bool mzza_ = lzzz_ is CqlDateTime;

                return mzza_;
            };
            bool lzzv_()
            {
                DataType mzzb_ = condition?.Abatement;
                object mzzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzb_);
                bool mzzd_ = mzzc_ is CqlQuantity;

                return mzzd_;
            };
            bool lzzw_()
            {
                DataType mzze_ = condition?.Abatement;
                object mzzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzze_);
                bool mzzg_ = mzzf_ is CqlInterval<CqlQuantity>;

                return mzzg_;
            };
            bool lzzx_()
            {
                DataType mzzh_ = condition?.Abatement;
                object mzzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzh_);
                bool mzzj_ = mzzi_ is CqlInterval<CqlDateTime>;

                return mzzj_;
            };
            if (lzzu_())
            {
                DataType mzzk_ = condition?.Abatement;
                object mzzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzk_);
                object mzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzk_);
                CqlInterval<CqlDateTime> mzzo_ = context.Operators.Interval(mzzl_ as CqlDateTime, mzzn_ as CqlDateTime, true, true);

                return mzzo_;
            }
            else if (lzzv_())
            {
                Patient mzzp_ = this.Patient(context);
                Date mzzq_ = mzzp_?.BirthDateElement;
                string mzzr_ = mzzq_?.Value;
                CqlDate mzzs_ = context.Operators.ConvertStringToDate(mzzr_);
                DataType mzzt_ = condition?.Abatement;
                object mzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate mzzv_ = context.Operators.Add(mzzs_, mzzu_ as CqlQuantity);
                Date mzzx_ = mzzp_?.BirthDateElement;
                string mzzy_ = mzzx_?.Value;
                CqlDate mzzz_ = context.Operators.ConvertStringToDate(mzzy_);
                object nzzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate nzzc_ = context.Operators.Add(mzzz_, nzzb_ as CqlQuantity);
                CqlQuantity nzzd_ = context.Operators.Quantity(1m, "year");
                CqlDate nzze_ = context.Operators.Add(nzzc_, nzzd_);
                CqlInterval<CqlDate> nzzf_ = context.Operators.Interval(mzzv_, nzze_, true, false);
                CqlDate nzzg_ = nzzf_?.low;
                CqlDateTime nzzh_ = context.Operators.ConvertDateToDateTime(nzzg_);
                Date nzzj_ = mzzp_?.BirthDateElement;
                string nzzk_ = nzzj_?.Value;
                CqlDate nzzl_ = context.Operators.ConvertStringToDate(nzzk_);
                object nzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate nzzo_ = context.Operators.Add(nzzl_, nzzn_ as CqlQuantity);
                Date nzzq_ = mzzp_?.BirthDateElement;
                string nzzr_ = nzzq_?.Value;
                CqlDate nzzs_ = context.Operators.ConvertStringToDate(nzzr_);
                object nzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate nzzv_ = context.Operators.Add(nzzs_, nzzu_ as CqlQuantity);
                CqlDate nzzx_ = context.Operators.Add(nzzv_, nzzd_);
                CqlInterval<CqlDate> nzzy_ = context.Operators.Interval(nzzo_, nzzx_, true, false);
                CqlDate nzzz_ = nzzy_?.high;
                CqlDateTime ozza_ = context.Operators.ConvertDateToDateTime(nzzz_);
                Date ozzc_ = mzzp_?.BirthDateElement;
                string ozzd_ = ozzc_?.Value;
                CqlDate ozze_ = context.Operators.ConvertStringToDate(ozzd_);
                object ozzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate ozzh_ = context.Operators.Add(ozze_, ozzg_ as CqlQuantity);
                Date ozzj_ = mzzp_?.BirthDateElement;
                string ozzk_ = ozzj_?.Value;
                CqlDate ozzl_ = context.Operators.ConvertStringToDate(ozzk_);
                object ozzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate ozzo_ = context.Operators.Add(ozzl_, ozzn_ as CqlQuantity);
                CqlDate ozzq_ = context.Operators.Add(ozzo_, nzzd_);
                CqlInterval<CqlDate> ozzr_ = context.Operators.Interval(ozzh_, ozzq_, true, false);
                bool? ozzs_ = ozzr_?.lowClosed;
                Date ozzu_ = mzzp_?.BirthDateElement;
                string ozzv_ = ozzu_?.Value;
                CqlDate ozzw_ = context.Operators.ConvertStringToDate(ozzv_);
                object ozzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate ozzz_ = context.Operators.Add(ozzw_, ozzy_ as CqlQuantity);
                Date pzzb_ = mzzp_?.BirthDateElement;
                string pzzc_ = pzzb_?.Value;
                CqlDate pzzd_ = context.Operators.ConvertStringToDate(pzzc_);
                object pzzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzt_);
                CqlDate pzzg_ = context.Operators.Add(pzzd_, pzzf_ as CqlQuantity);
                CqlDate pzzi_ = context.Operators.Add(pzzg_, nzzd_);
                CqlInterval<CqlDate> pzzj_ = context.Operators.Interval(ozzz_, pzzi_, true, false);
                bool? pzzk_ = pzzj_?.highClosed;
                CqlInterval<CqlDateTime> pzzl_ = context.Operators.Interval(nzzh_, ozza_, ozzs_, pzzk_);

                return pzzl_;
            }
            else if (lzzw_())
            {
                Patient pzzm_ = this.Patient(context);
                Date pzzn_ = pzzm_?.BirthDateElement;
                string pzzo_ = pzzn_?.Value;
                CqlDate pzzp_ = context.Operators.ConvertStringToDate(pzzo_);
                DataType pzzq_ = condition?.Abatement;
                object pzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object pzzs_ = context.Operators.LateBoundProperty<object>(pzzr_, "low");
                CqlDate pzzt_ = context.Operators.Add(pzzp_, pzzs_ as CqlQuantity);
                Date pzzv_ = pzzm_?.BirthDateElement;
                string pzzw_ = pzzv_?.Value;
                CqlDate pzzx_ = context.Operators.ConvertStringToDate(pzzw_);
                object pzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object qzza_ = context.Operators.LateBoundProperty<object>(pzzz_, "high");
                CqlDate qzzb_ = context.Operators.Add(pzzx_, qzza_ as CqlQuantity);
                CqlQuantity qzzc_ = context.Operators.Quantity(1m, "year");
                CqlDate qzzd_ = context.Operators.Add(qzzb_, qzzc_);
                CqlInterval<CqlDate> qzze_ = context.Operators.Interval(pzzt_, qzzd_, true, false);
                CqlDate qzzf_ = qzze_?.low;
                CqlDateTime qzzg_ = context.Operators.ConvertDateToDateTime(qzzf_);
                Date qzzi_ = pzzm_?.BirthDateElement;
                string qzzj_ = qzzi_?.Value;
                CqlDate qzzk_ = context.Operators.ConvertStringToDate(qzzj_);
                object qzzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object qzzn_ = context.Operators.LateBoundProperty<object>(qzzm_, "low");
                CqlDate qzzo_ = context.Operators.Add(qzzk_, qzzn_ as CqlQuantity);
                Date qzzq_ = pzzm_?.BirthDateElement;
                string qzzr_ = qzzq_?.Value;
                CqlDate qzzs_ = context.Operators.ConvertStringToDate(qzzr_);
                object qzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object qzzv_ = context.Operators.LateBoundProperty<object>(qzzu_, "high");
                CqlDate qzzw_ = context.Operators.Add(qzzs_, qzzv_ as CqlQuantity);
                CqlDate qzzy_ = context.Operators.Add(qzzw_, qzzc_);
                CqlInterval<CqlDate> qzzz_ = context.Operators.Interval(qzzo_, qzzy_, true, false);
                CqlDate rzza_ = qzzz_?.high;
                CqlDateTime rzzb_ = context.Operators.ConvertDateToDateTime(rzza_);
                Date rzzd_ = pzzm_?.BirthDateElement;
                string rzze_ = rzzd_?.Value;
                CqlDate rzzf_ = context.Operators.ConvertStringToDate(rzze_);
                object rzzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object rzzi_ = context.Operators.LateBoundProperty<object>(rzzh_, "low");
                CqlDate rzzj_ = context.Operators.Add(rzzf_, rzzi_ as CqlQuantity);
                Date rzzl_ = pzzm_?.BirthDateElement;
                string rzzm_ = rzzl_?.Value;
                CqlDate rzzn_ = context.Operators.ConvertStringToDate(rzzm_);
                object rzzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object rzzq_ = context.Operators.LateBoundProperty<object>(rzzp_, "high");
                CqlDate rzzr_ = context.Operators.Add(rzzn_, rzzq_ as CqlQuantity);
                CqlDate rzzt_ = context.Operators.Add(rzzr_, qzzc_);
                CqlInterval<CqlDate> rzzu_ = context.Operators.Interval(rzzj_, rzzt_, true, false);
                bool? rzzv_ = rzzu_?.lowClosed;
                Date rzzx_ = pzzm_?.BirthDateElement;
                string rzzy_ = rzzx_?.Value;
                CqlDate rzzz_ = context.Operators.ConvertStringToDate(rzzy_);
                object szzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object szzc_ = context.Operators.LateBoundProperty<object>(szzb_, "low");
                CqlDate szzd_ = context.Operators.Add(rzzz_, szzc_ as CqlQuantity);
                Date szzf_ = pzzm_?.BirthDateElement;
                string szzg_ = szzf_?.Value;
                CqlDate szzh_ = context.Operators.ConvertStringToDate(szzg_);
                object szzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzzq_);
                object szzk_ = context.Operators.LateBoundProperty<object>(szzj_, "high");
                CqlDate szzl_ = context.Operators.Add(szzh_, szzk_ as CqlQuantity);
                CqlDate szzn_ = context.Operators.Add(szzl_, qzzc_);
                CqlInterval<CqlDate> szzo_ = context.Operators.Interval(szzd_, szzn_, true, false);
                bool? szzp_ = szzo_?.highClosed;
                CqlInterval<CqlDateTime> szzq_ = context.Operators.Interval(qzzg_, rzzb_, rzzv_, szzp_);

                return szzq_;
            }
            else if (lzzx_())
            {
                DataType szzr_ = condition?.Abatement;
                object szzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szzr_);
                object szzt_ = context.Operators.LateBoundProperty<object>(szzs_, "low");
                object szzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szzr_);
                object szzw_ = context.Operators.LateBoundProperty<object>(szzv_, "high");
                CqlInterval<CqlDateTime> szzx_ = context.Operators.Interval(szzt_ as CqlDateTime, szzw_ as CqlDateTime, true, false);

                return szzx_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return lzzt_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> szzy_()
        {
            bool szzz_()
            {
                DataType tzzd_ = condition?.Abatement;
                object tzze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzd_);
                bool tzzf_ = tzze_ is CqlDateTime;

                return tzzf_;
            };
            bool tzza_()
            {
                DataType tzzg_ = condition?.Abatement;
                object tzzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzg_);
                bool tzzi_ = tzzh_ is CqlQuantity;

                return tzzi_;
            };
            bool tzzb_()
            {
                DataType tzzj_ = condition?.Abatement;
                object tzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzj_);
                bool tzzl_ = tzzk_ is CqlInterval<CqlQuantity>;

                return tzzl_;
            };
            bool tzzc_()
            {
                DataType tzzm_ = condition?.Abatement;
                object tzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzm_);
                bool tzzo_ = tzzn_ is CqlInterval<CqlDateTime>;

                return tzzo_;
            };
            if (szzz_())
            {
                DataType tzzp_ = condition?.Abatement;
                object tzzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzp_);
                object tzzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzp_);
                CqlInterval<CqlDateTime> tzzt_ = context.Operators.Interval(tzzq_ as CqlDateTime, tzzs_ as CqlDateTime, true, true);

                return tzzt_;
            }
            else if (tzza_())
            {
                Patient tzzu_ = this.Patient(context);
                Date tzzv_ = tzzu_?.BirthDateElement;
                string tzzw_ = tzzv_?.Value;
                CqlDate tzzx_ = context.Operators.ConvertStringToDate(tzzw_);
                DataType tzzy_ = condition?.Abatement;
                object tzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate uzza_ = context.Operators.Add(tzzx_, tzzz_ as CqlQuantity);
                Date uzzc_ = tzzu_?.BirthDateElement;
                string uzzd_ = uzzc_?.Value;
                CqlDate uzze_ = context.Operators.ConvertStringToDate(uzzd_);
                object uzzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate uzzh_ = context.Operators.Add(uzze_, uzzg_ as CqlQuantity);
                CqlQuantity uzzi_ = context.Operators.Quantity(1m, "year");
                CqlDate uzzj_ = context.Operators.Add(uzzh_, uzzi_);
                CqlInterval<CqlDate> uzzk_ = context.Operators.Interval(uzza_, uzzj_, true, false);
                CqlDate uzzl_ = uzzk_?.low;
                CqlDateTime uzzm_ = context.Operators.ConvertDateToDateTime(uzzl_);
                Date uzzo_ = tzzu_?.BirthDateElement;
                string uzzp_ = uzzo_?.Value;
                CqlDate uzzq_ = context.Operators.ConvertStringToDate(uzzp_);
                object uzzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate uzzt_ = context.Operators.Add(uzzq_, uzzs_ as CqlQuantity);
                Date uzzv_ = tzzu_?.BirthDateElement;
                string uzzw_ = uzzv_?.Value;
                CqlDate uzzx_ = context.Operators.ConvertStringToDate(uzzw_);
                object uzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate vzza_ = context.Operators.Add(uzzx_, uzzz_ as CqlQuantity);
                CqlDate vzzc_ = context.Operators.Add(vzza_, uzzi_);
                CqlInterval<CqlDate> vzzd_ = context.Operators.Interval(uzzt_, vzzc_, true, false);
                CqlDate vzze_ = vzzd_?.high;
                CqlDateTime vzzf_ = context.Operators.ConvertDateToDateTime(vzze_);
                Date vzzh_ = tzzu_?.BirthDateElement;
                string vzzi_ = vzzh_?.Value;
                CqlDate vzzj_ = context.Operators.ConvertStringToDate(vzzi_);
                object vzzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate vzzm_ = context.Operators.Add(vzzj_, vzzl_ as CqlQuantity);
                Date vzzo_ = tzzu_?.BirthDateElement;
                string vzzp_ = vzzo_?.Value;
                CqlDate vzzq_ = context.Operators.ConvertStringToDate(vzzp_);
                object vzzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate vzzt_ = context.Operators.Add(vzzq_, vzzs_ as CqlQuantity);
                CqlDate vzzv_ = context.Operators.Add(vzzt_, uzzi_);
                CqlInterval<CqlDate> vzzw_ = context.Operators.Interval(vzzm_, vzzv_, true, false);
                bool? vzzx_ = vzzw_?.lowClosed;
                Date vzzz_ = tzzu_?.BirthDateElement;
                string wzza_ = vzzz_?.Value;
                CqlDate wzzb_ = context.Operators.ConvertStringToDate(wzza_);
                object wzzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate wzze_ = context.Operators.Add(wzzb_, wzzd_ as CqlQuantity);
                Date wzzg_ = tzzu_?.BirthDateElement;
                string wzzh_ = wzzg_?.Value;
                CqlDate wzzi_ = context.Operators.ConvertStringToDate(wzzh_);
                object wzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzy_);
                CqlDate wzzl_ = context.Operators.Add(wzzi_, wzzk_ as CqlQuantity);
                CqlDate wzzn_ = context.Operators.Add(wzzl_, uzzi_);
                CqlInterval<CqlDate> wzzo_ = context.Operators.Interval(wzze_, wzzn_, true, false);
                bool? wzzp_ = wzzo_?.highClosed;
                CqlInterval<CqlDateTime> wzzq_ = context.Operators.Interval(uzzm_, vzzf_, vzzx_, wzzp_);

                return wzzq_;
            }
            else if (tzzb_())
            {
                Patient wzzr_ = this.Patient(context);
                Date wzzs_ = wzzr_?.BirthDateElement;
                string wzzt_ = wzzs_?.Value;
                CqlDate wzzu_ = context.Operators.ConvertStringToDate(wzzt_);
                DataType wzzv_ = condition?.Abatement;
                object wzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object wzzx_ = context.Operators.LateBoundProperty<object>(wzzw_, "low");
                CqlDate wzzy_ = context.Operators.Add(wzzu_, wzzx_ as CqlQuantity);
                Date xzza_ = wzzr_?.BirthDateElement;
                string xzzb_ = xzza_?.Value;
                CqlDate xzzc_ = context.Operators.ConvertStringToDate(xzzb_);
                object xzze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object xzzf_ = context.Operators.LateBoundProperty<object>(xzze_, "high");
                CqlDate xzzg_ = context.Operators.Add(xzzc_, xzzf_ as CqlQuantity);
                CqlQuantity xzzh_ = context.Operators.Quantity(1m, "year");
                CqlDate xzzi_ = context.Operators.Add(xzzg_, xzzh_);
                CqlInterval<CqlDate> xzzj_ = context.Operators.Interval(wzzy_, xzzi_, true, false);
                CqlDate xzzk_ = xzzj_?.low;
                CqlDateTime xzzl_ = context.Operators.ConvertDateToDateTime(xzzk_);
                Date xzzn_ = wzzr_?.BirthDateElement;
                string xzzo_ = xzzn_?.Value;
                CqlDate xzzp_ = context.Operators.ConvertStringToDate(xzzo_);
                object xzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object xzzs_ = context.Operators.LateBoundProperty<object>(xzzr_, "low");
                CqlDate xzzt_ = context.Operators.Add(xzzp_, xzzs_ as CqlQuantity);
                Date xzzv_ = wzzr_?.BirthDateElement;
                string xzzw_ = xzzv_?.Value;
                CqlDate xzzx_ = context.Operators.ConvertStringToDate(xzzw_);
                object xzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object yzza_ = context.Operators.LateBoundProperty<object>(xzzz_, "high");
                CqlDate yzzb_ = context.Operators.Add(xzzx_, yzza_ as CqlQuantity);
                CqlDate yzzd_ = context.Operators.Add(yzzb_, xzzh_);
                CqlInterval<CqlDate> yzze_ = context.Operators.Interval(xzzt_, yzzd_, true, false);
                CqlDate yzzf_ = yzze_?.high;
                CqlDateTime yzzg_ = context.Operators.ConvertDateToDateTime(yzzf_);
                Date yzzi_ = wzzr_?.BirthDateElement;
                string yzzj_ = yzzi_?.Value;
                CqlDate yzzk_ = context.Operators.ConvertStringToDate(yzzj_);
                object yzzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object yzzn_ = context.Operators.LateBoundProperty<object>(yzzm_, "low");
                CqlDate yzzo_ = context.Operators.Add(yzzk_, yzzn_ as CqlQuantity);
                Date yzzq_ = wzzr_?.BirthDateElement;
                string yzzr_ = yzzq_?.Value;
                CqlDate yzzs_ = context.Operators.ConvertStringToDate(yzzr_);
                object yzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object yzzv_ = context.Operators.LateBoundProperty<object>(yzzu_, "high");
                CqlDate yzzw_ = context.Operators.Add(yzzs_, yzzv_ as CqlQuantity);
                CqlDate yzzy_ = context.Operators.Add(yzzw_, xzzh_);
                CqlInterval<CqlDate> yzzz_ = context.Operators.Interval(yzzo_, yzzy_, true, false);
                bool? zzza_ = yzzz_?.lowClosed;
                Date zzzc_ = wzzr_?.BirthDateElement;
                string zzzd_ = zzzc_?.Value;
                CqlDate zzze_ = context.Operators.ConvertStringToDate(zzzd_);
                object zzzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object zzzh_ = context.Operators.LateBoundProperty<object>(zzzg_, "low");
                CqlDate zzzi_ = context.Operators.Add(zzze_, zzzh_ as CqlQuantity);
                Date zzzk_ = wzzr_?.BirthDateElement;
                string zzzl_ = zzzk_?.Value;
                CqlDate zzzm_ = context.Operators.ConvertStringToDate(zzzl_);
                object zzzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzzv_);
                object zzzp_ = context.Operators.LateBoundProperty<object>(zzzo_, "high");
                CqlDate zzzq_ = context.Operators.Add(zzzm_, zzzp_ as CqlQuantity);
                CqlDate zzzs_ = context.Operators.Add(zzzq_, xzzh_);
                CqlInterval<CqlDate> zzzt_ = context.Operators.Interval(zzzi_, zzzs_, true, false);
                bool? zzzu_ = zzzt_?.highClosed;
                CqlInterval<CqlDateTime> zzzv_ = context.Operators.Interval(xzzl_, yzzg_, zzza_, zzzu_);

                return zzzv_;
            }
            else if (tzzc_())
            {
                DataType zzzw_ = condition?.Abatement;
                object zzzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzzw_);
                object zzzy_ = context.Operators.LateBoundProperty<object>(zzzx_, "low");
                object azzza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzzw_);
                object azzzb_ = context.Operators.LateBoundProperty<object>(azzza_, "high");
                CqlInterval<CqlDateTime> azzzc_ = context.Operators.Interval(zzzy_ as CqlDateTime, azzzb_ as CqlDateTime, true, false);

                return azzzc_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return szzy_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> azzzd_()
        {
            bool azzze_()
            {
                CodeableConcept azzzf_ = condition?.ClinicalStatus;
                CqlConcept azzzg_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, azzzf_);
                CqlCode azzzh_ = this.active(context);
                CqlConcept azzzi_ = context.Operators.ConvertCodeToConcept(azzzh_);
                bool? azzzj_ = context.Operators.Equivalent(azzzg_, azzzi_);
                CqlConcept azzzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, azzzf_);
                CqlCode azzzm_ = this.recurrence(context);
                CqlConcept azzzn_ = context.Operators.ConvertCodeToConcept(azzzm_);
                bool? azzzo_ = context.Operators.Equivalent(azzzl_, azzzn_);
                bool? azzzp_ = context.Operators.Or(azzzj_, azzzo_);
                CqlConcept azzzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, azzzf_);
                CqlCode azzzs_ = this.relapse(context);
                CqlConcept azzzt_ = context.Operators.ConvertCodeToConcept(azzzs_);
                bool? azzzu_ = context.Operators.Equivalent(azzzr_, azzzt_);
                bool? azzzv_ = context.Operators.Or(azzzp_, azzzu_);

                return azzzv_ ?? false;
            };
            if (azzze_())
            {
                DataType azzzw_ = condition?.Onset;
                object azzzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, azzzw_);
                CqlInterval<CqlDateTime> azzzy_ = this.ToInterval(context, azzzx_);
                CqlDateTime azzzz_ = context.Operators.Start(azzzy_);
                CqlInterval<CqlDateTime> bzzza_ = this.ToAbatementInterval(context, condition);
                CqlDateTime bzzzb_ = context.Operators.End(bzzza_);
                CqlInterval<CqlDateTime> bzzzc_ = context.Operators.Interval(azzzz_, bzzzb_, true, true);

                return bzzzc_;
            }
            else
            {
                CqlInterval<CqlDateTime> bzzzd_ = this.ToAbatementInterval(context, condition);
                CqlDateTime bzzze_ = context.Operators.End(bzzzd_);
                CqlDateTime[] bzzzf_ = [
                    bzzze_,
                ];
                CqlInterval<CqlDateTime> bzzzg_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> bzzzk_()
                    {
                        if (abatementDate is null)
                        {
                            DataType bzzzl_ = condition?.Onset;
                            object bzzzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bzzzl_);
                            CqlInterval<CqlDateTime> bzzzn_ = this.ToInterval(context, bzzzm_);
                            CqlDateTime bzzzo_ = context.Operators.Start(bzzzn_);
                            CqlInterval<CqlDateTime> bzzzp_ = context.Operators.Interval(bzzzo_, abatementDate, true, false);

                            return bzzzp_;
                        }
                        else
                        {
                            DataType bzzzq_ = condition?.Onset;
                            object bzzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bzzzq_);
                            CqlInterval<CqlDateTime> bzzzs_ = this.ToInterval(context, bzzzr_);
                            CqlDateTime bzzzt_ = context.Operators.Start(bzzzs_);
                            CqlInterval<CqlDateTime> bzzzu_ = context.Operators.Interval(bzzzt_, abatementDate, true, true);

                            return bzzzu_;
                        }
                    };

                    return bzzzk_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> bzzzh_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)bzzzf_, bzzzg_);
                IEnumerable<CqlInterval<CqlDateTime>> bzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzh_);
                CqlInterval<CqlDateTime> bzzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(bzzzi_);

                return bzzzj_;
            }
        };

        return azzzd_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> bzzzv_()
        {
            bool bzzzw_()
            {
                CodeableConcept bzzzx_ = condition?.ClinicalStatus;
                CqlConcept bzzzy_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, bzzzx_);
                CqlCode bzzzz_ = this.active(context);
                CqlConcept czzza_ = context.Operators.ConvertCodeToConcept(bzzzz_);
                bool? czzzb_ = context.Operators.Equivalent(bzzzy_, czzza_);
                CqlConcept czzzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, bzzzx_);
                CqlCode czzze_ = this.recurrence(context);
                CqlConcept czzzf_ = context.Operators.ConvertCodeToConcept(czzze_);
                bool? czzzg_ = context.Operators.Equivalent(czzzd_, czzzf_);
                bool? czzzh_ = context.Operators.Or(czzzb_, czzzg_);
                CqlConcept czzzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, bzzzx_);
                CqlCode czzzk_ = this.relapse(context);
                CqlConcept czzzl_ = context.Operators.ConvertCodeToConcept(czzzk_);
                bool? czzzm_ = context.Operators.Equivalent(czzzj_, czzzl_);
                bool? czzzn_ = context.Operators.Or(czzzh_, czzzm_);

                return czzzn_ ?? false;
            };
            if (bzzzw_())
            {
                DataType czzzo_ = condition?.Onset;
                object czzzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzzo_);
                CqlInterval<CqlDateTime> czzzq_ = this.toInterval(context, czzzp_);
                CqlDateTime czzzr_ = context.Operators.Start(czzzq_);
                CqlInterval<CqlDateTime> czzzs_ = this.abatementInterval(context, condition);
                CqlDateTime czzzt_ = context.Operators.End(czzzs_);
                CqlInterval<CqlDateTime> czzzu_ = context.Operators.Interval(czzzr_, czzzt_, true, true);

                return czzzu_;
            }
            else
            {
                CqlInterval<CqlDateTime> czzzv_ = this.ToAbatementInterval(context, condition);
                CqlDateTime czzzw_ = context.Operators.End(czzzv_);
                CqlDateTime[] czzzx_ = [
                    czzzw_,
                ];
                CqlInterval<CqlDateTime> czzzy_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> dzzzc_()
                    {
                        if (abatementDate is null)
                        {
                            DataType dzzzd_ = condition?.Onset;
                            object dzzze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzzd_);
                            CqlInterval<CqlDateTime> dzzzf_ = this.ToInterval(context, dzzze_);
                            CqlDateTime dzzzg_ = context.Operators.Start(dzzzf_);
                            CqlInterval<CqlDateTime> dzzzh_ = context.Operators.Interval(dzzzg_, abatementDate, true, false);

                            return dzzzh_;
                        }
                        else
                        {
                            DataType dzzzi_ = condition?.Onset;
                            object dzzzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzzi_);
                            CqlInterval<CqlDateTime> dzzzk_ = this.ToInterval(context, dzzzj_);
                            CqlDateTime dzzzl_ = context.Operators.Start(dzzzk_);
                            CqlInterval<CqlDateTime> dzzzm_ = context.Operators.Interval(dzzzl_, abatementDate, true, true);

                            return dzzzm_;
                        }
                    };

                    return dzzzc_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> czzzz_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)czzzx_, czzzy_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzz_);
                CqlInterval<CqlDateTime> dzzzb_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzza_);

                return dzzzb_;
            }
        };

        return bzzzv_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> dzzzn_ = context.Operators.Split(uri, "/");
        string dzzzo_ = context.Operators.Last<string>(dzzzn_);

        return dzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> dzzzp_ = context.Operators.Split(uri, "/");
        string dzzzq_ = context.Operators.Last<string>(dzzzp_);

        return dzzzq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime dzzzr_ = context.Operators.Start(period);
        CqlDateTime dzzzt_ = context.Operators.MinValue<CqlDateTime>();
        bool? dzzzu_ = context.Operators.Equal(dzzzr_, dzzzt_);
        bool? dzzzv_ = context.Operators.Or((bool?)(dzzzr_ is null), dzzzu_);
        bool? dzzzw_ = context.Operators.Not(dzzzv_);

        return dzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime dzzzx_ = context.Operators.Start(period);
        CqlDateTime dzzzz_ = context.Operators.MinValue<CqlDateTime>();
        bool? ezzza_ = context.Operators.Equal(dzzzx_, dzzzz_);
        bool? ezzzb_ = context.Operators.Or((bool?)(dzzzx_ is null), ezzza_);
        bool? ezzzc_ = context.Operators.Not(ezzzb_);

        return ezzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime ezzzd_ = context.Operators.End(period);
        CqlDateTime ezzzf_ = context.Operators.MaxValue<CqlDateTime>();
        bool? ezzzg_ = context.Operators.Equal(ezzzd_, ezzzf_);
        bool? ezzzh_ = context.Operators.Or((bool?)(ezzzd_ is null), ezzzg_);
        bool? ezzzi_ = context.Operators.Not(ezzzh_);

        return ezzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime ezzzj_ = context.Operators.End(period);
        CqlDateTime ezzzl_ = context.Operators.MaxValue<CqlDateTime>();
        bool? ezzzm_ = context.Operators.Equal(ezzzj_, ezzzl_);
        bool? ezzzn_ = context.Operators.Or((bool?)(ezzzj_ is null), ezzzm_);
        bool? ezzzo_ = context.Operators.Not(ezzzn_);

        return ezzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezzzp_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] ezzzq_ = [
            ezzzp_,
        ];
        CqlDateTime ezzzr_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime ezzzv_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime ezzzw_ = context.Operators.End(period);

                    return ezzzw_;
                }
                else
                {
                    CqlDateTime ezzzx_ = context.Operators.Start(period);

                    return ezzzx_;
                }
            };

            return ezzzv_();
        };
        IEnumerable<CqlDateTime> ezzzs_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)ezzzq_, ezzzr_);
        IEnumerable<CqlDateTime> ezzzt_ = context.Operators.Distinct<CqlDateTime>(ezzzs_);
        CqlDateTime ezzzu_ = context.Operators.SingletonFrom<CqlDateTime>(ezzzt_);

        return ezzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezzzy_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] ezzzz_ = [
            ezzzy_,
        ];
        CqlDateTime fzzza_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime fzzze_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime fzzzf_ = context.Operators.End(period);

                    return fzzzf_;
                }
                else
                {
                    CqlDateTime fzzzg_ = context.Operators.Start(period);

                    return fzzzg_;
                }
            };

            return fzzze_();
        };
        IEnumerable<CqlDateTime> fzzzb_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)ezzzz_, fzzza_);
        IEnumerable<CqlDateTime> fzzzc_ = context.Operators.Distinct<CqlDateTime>(fzzzb_);
        CqlDateTime fzzzd_ = context.Operators.SingletonFrom<CqlDateTime>(fzzzc_);

        return fzzzd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> fzzzh_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] fzzzi_ = [
            fzzzh_,
        ];
        CqlDateTime fzzzj_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime fzzzn_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime fzzzo_ = context.Operators.Start(period);

                    return fzzzo_;
                }
                else
                {
                    CqlDateTime fzzzp_ = context.Operators.End(period);

                    return fzzzp_;
                }
            };

            return fzzzn_();
        };
        IEnumerable<CqlDateTime> fzzzk_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)fzzzi_, fzzzj_);
        IEnumerable<CqlDateTime> fzzzl_ = context.Operators.Distinct<CqlDateTime>(fzzzk_);
        CqlDateTime fzzzm_ = context.Operators.SingletonFrom<CqlDateTime>(fzzzl_);

        return fzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> fzzzq_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] fzzzr_ = [
            fzzzq_,
        ];
        CqlDateTime fzzzs_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime fzzzw_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime fzzzx_ = context.Operators.Start(period);

                    return fzzzx_;
                }
                else
                {
                    CqlDateTime fzzzy_ = context.Operators.End(period);

                    return fzzzy_;
                }
            };

            return fzzzw_();
        };
        IEnumerable<CqlDateTime> fzzzt_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)fzzzr_, fzzzs_);
        IEnumerable<CqlDateTime> fzzzu_ = context.Operators.Distinct<CqlDateTime>(fzzzt_);
        CqlDateTime fzzzv_ = context.Operators.SingletonFrom<CqlDateTime>(fzzzu_);

        return fzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime fzzzz_ = context.Operators.Start(Period);
        CqlDateTime gzzza_ = context.Operators.End(Period);
        int? gzzzb_ = context.Operators.DurationBetween(fzzzz_, gzzza_, "day");
        CqlInterval<int?> gzzzc_ = context.Operators.Interval(1, gzzzb_, true, true);
        CqlInterval<int?>[] gzzzd_ = [
            gzzzc_,
        ];
        IEnumerable<CqlInterval<int?>> gzzze_ = context.Operators.Expand(gzzzd_ as IEnumerable<CqlInterval<int?>>, default);
        int? gzzzf_(CqlInterval<int?> DayNumber)
        {
            int? gzzzi_ = context.Operators.End(DayNumber);

            return gzzzi_;
        };
        IEnumerable<int?> gzzzg_ = context.Operators.Select<CqlInterval<int?>, int?>(gzzze_, gzzzf_);
        IEnumerable<int?> gzzzh_ = context.Operators.Distinct<int?>(gzzzg_);

        return gzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime gzzzj_ = context.Operators.Start(Period);
        CqlDateTime gzzzk_ = context.Operators.End(Period);
        int? gzzzl_ = context.Operators.DurationBetween(gzzzj_, gzzzk_, "day");
        CqlInterval<int?> gzzzm_ = context.Operators.Interval(1, gzzzl_, true, true);
        CqlInterval<int?>[] gzzzn_ = [
            gzzzm_,
        ];
        IEnumerable<CqlInterval<int?>> gzzzo_ = context.Operators.Expand(gzzzn_ as IEnumerable<CqlInterval<int?>>, default);
        int? gzzzp_(CqlInterval<int?> DayNumber)
        {
            int? gzzzs_ = context.Operators.End(DayNumber);

            return gzzzs_;
        };
        IEnumerable<int?> gzzzq_ = context.Operators.Select<CqlInterval<int?>, int?>(gzzzo_, gzzzp_);
        IEnumerable<int?> gzzzr_ = context.Operators.Distinct<int?>(gzzzq_);

        return gzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> gzzzt_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? gzzzu_(int? DayIndex)
        {
            CqlDateTime gzzzx_ = context.Operators.Start(Period);
            CqlQuantity gzzzy_ = context.Operators.Quantity(24m, "hours");
            int? gzzzz_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity hzzza_ = context.Operators.ConvertIntegerToQuantity(gzzzz_);
            CqlQuantity hzzzb_ = context.Operators.Multiply(gzzzy_, hzzza_);
            CqlDateTime hzzzc_ = context.Operators.Add(gzzzx_, hzzzb_);
            CqlDateTime hzzzd_()
            {
                bool hzzzg_()
                {
                    CqlDateTime hzzzh_ = context.Operators.Start(Period);
                    CqlQuantity hzzzi_ = context.Operators.Quantity(24m, "hours");
                    int? hzzzj_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity hzzzk_ = context.Operators.ConvertIntegerToQuantity(hzzzj_);
                    CqlQuantity hzzzl_ = context.Operators.Multiply(hzzzi_, hzzzk_);
                    CqlDateTime hzzzm_ = context.Operators.Add(hzzzh_, hzzzl_);
                    CqlDateTime hzzzn_ = context.Operators.End(Period);
                    int? hzzzo_ = context.Operators.DurationBetween(hzzzm_, hzzzn_, "hour");
                    bool? hzzzp_ = context.Operators.Less(hzzzo_, 24);

                    return hzzzp_ ?? false;
                };
                if (hzzzg_())
                {
                    CqlDateTime hzzzq_ = context.Operators.Start(Period);
                    CqlQuantity hzzzr_ = context.Operators.Quantity(24m, "hours");
                    int? hzzzs_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity hzzzt_ = context.Operators.ConvertIntegerToQuantity(hzzzs_);
                    CqlQuantity hzzzu_ = context.Operators.Multiply(hzzzr_, hzzzt_);
                    CqlDateTime hzzzv_ = context.Operators.Add(hzzzq_, hzzzu_);

                    return hzzzv_;
                }
                else
                {
                    CqlDateTime hzzzw_ = context.Operators.Start(Period);
                    CqlQuantity hzzzx_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity hzzzy_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity hzzzz_ = context.Operators.Multiply(hzzzx_, hzzzy_);
                    CqlDateTime izzza_ = context.Operators.Add(hzzzw_, hzzzz_);

                    return izzza_;
                }
            };
            CqlInterval<CqlDateTime> hzzze_ = context.Operators.Interval(hzzzc_, hzzzd_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? hzzzf_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, hzzze_);

            return hzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> gzzzv_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(gzzzt_, gzzzu_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> gzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(gzzzv_);

        return gzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> izzzb_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? izzzc_(int? DayIndex)
        {
            CqlDateTime izzzf_ = context.Operators.Start(Period);
            CqlQuantity izzzg_ = context.Operators.Quantity(24m, "hours");
            int? izzzh_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity izzzi_ = context.Operators.ConvertIntegerToQuantity(izzzh_);
            CqlQuantity izzzj_ = context.Operators.Multiply(izzzg_, izzzi_);
            CqlDateTime izzzk_ = context.Operators.Add(izzzf_, izzzj_);
            CqlDateTime izzzl_()
            {
                bool izzzo_()
                {
                    CqlDateTime izzzp_ = context.Operators.Start(Period);
                    CqlQuantity izzzq_ = context.Operators.Quantity(24m, "hours");
                    int? izzzr_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity izzzs_ = context.Operators.ConvertIntegerToQuantity(izzzr_);
                    CqlQuantity izzzt_ = context.Operators.Multiply(izzzq_, izzzs_);
                    CqlDateTime izzzu_ = context.Operators.Add(izzzp_, izzzt_);
                    CqlDateTime izzzv_ = context.Operators.End(Period);
                    int? izzzw_ = context.Operators.DurationBetween(izzzu_, izzzv_, "hour");
                    bool? izzzx_ = context.Operators.Less(izzzw_, 24);

                    return izzzx_ ?? false;
                };
                if (izzzo_())
                {
                    CqlDateTime izzzy_ = context.Operators.Start(Period);
                    CqlQuantity izzzz_ = context.Operators.Quantity(24m, "hours");
                    int? jzzza_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzzb_ = context.Operators.ConvertIntegerToQuantity(jzzza_);
                    CqlQuantity jzzzc_ = context.Operators.Multiply(izzzz_, jzzzb_);
                    CqlDateTime jzzzd_ = context.Operators.Add(izzzy_, jzzzc_);

                    return jzzzd_;
                }
                else
                {
                    CqlDateTime jzzze_ = context.Operators.Start(Period);
                    CqlQuantity jzzzf_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity jzzzg_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity jzzzh_ = context.Operators.Multiply(jzzzf_, jzzzg_);
                    CqlDateTime jzzzi_ = context.Operators.Add(jzzze_, jzzzh_);

                    return jzzzi_;
                }
            };
            CqlInterval<CqlDateTime> izzzm_ = context.Operators.Interval(izzzk_, izzzl_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? izzzn_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, izzzm_);

            return izzzn_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> izzzd_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(izzzb_, izzzc_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> izzze_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(izzzd_);

        return izzze_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
