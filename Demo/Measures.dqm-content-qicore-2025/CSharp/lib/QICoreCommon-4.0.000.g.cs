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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("QICoreCommon", "4.0.000")]
public partial class QICoreCommon_4_0_000 : ILibrary, ISingleton<QICoreCommon_4_0_000>
{
    #region Codes (58)

    [CqlCodeDefinition("Birthdate", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext _) => _Birthdate;
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Dead", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext _) => _Dead;
    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct");

    [CqlCodeDefinition("ER", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext _) => _ER;
    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("ICU", codeId: "ICU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext _) => _ICU;
    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("Fulfill", codeId: "fulfill", codeSystem: "http://hl7.org/fhir/CodeSystem/task-code")]
    public CqlCode Fulfill(CqlContext _) => _Fulfill;
    private static readonly CqlCode _Fulfill = new CqlCode("fulfill", "http://hl7.org/fhir/CodeSystem/task-code");

    [CqlCodeDefinition("ambulatory", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode ambulatory(CqlContext _) => _ambulatory;
    private static readonly CqlCode _ambulatory = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("emergency", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode emergency(CqlContext _) => _emergency;
    private static readonly CqlCode _emergency = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("field", codeId: "FLD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode field(CqlContext _) => _field;
    private static readonly CqlCode _field = new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("home health", codeId: "HH", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode home_health(CqlContext _) => _home_health;
    private static readonly CqlCode _home_health = new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("inpatient encounter", codeId: "IMP", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_encounter(CqlContext _) => _inpatient_encounter;
    private static readonly CqlCode _inpatient_encounter = new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("inpatient acute", codeId: "ACUTE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_acute(CqlContext _) => _inpatient_acute;
    private static readonly CqlCode _inpatient_acute = new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("inpatient non-acute", codeId: "NONAC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_non_acute(CqlContext _) => _inpatient_non_acute;
    private static readonly CqlCode _inpatient_non_acute = new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("observation encounter", codeId: "OBSENC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode observation_encounter(CqlContext _) => _observation_encounter;
    private static readonly CqlCode _observation_encounter = new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("pre-admission", codeId: "PRENC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode pre_admission(CqlContext _) => _pre_admission;
    private static readonly CqlCode _pre_admission = new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("short stay", codeId: "SS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode short_stay(CqlContext _) => _short_stay;
    private static readonly CqlCode _short_stay = new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("problem-list-item", codeId: "problem-list-item", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode problem_list_item(CqlContext _) => _problem_list_item;
    private static readonly CqlCode _problem_list_item = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category");

    [CqlCodeDefinition("encounter-diagnosis", codeId: "encounter-diagnosis", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode encounter_diagnosis(CqlContext _) => _encounter_diagnosis;
    private static readonly CqlCode _encounter_diagnosis = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category");

    [CqlCodeDefinition("health-concern", codeId: "health-concern", codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/condition-category")]
    public CqlCode health_concern(CqlContext _) => _health_concern;
    private static readonly CqlCode _health_concern = new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category");

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("recurrence", codeId: "recurrence", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext _) => _recurrence;
    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("relapse", codeId: "relapse", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext _) => _relapse;
    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext _) => _inactive;
    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("remission", codeId: "remission", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext _) => _remission;
    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext _) => _resolved;
    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical");

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status");

    [CqlCodeDefinition("allergy-active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext _) => _allergy_active;
    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext _) => _allergy_inactive;
    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext _) => _allergy_resolved;
    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical");

    [CqlCodeDefinition("allergy-unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext _) => _allergy_unconfirmed;
    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("allergy-confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext _) => _allergy_confirmed;
    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("allergy-refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext _) => _allergy_refuted;
    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification");

    [CqlCodeDefinition("Inpatient", codeId: "inpatient", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Inpatient(CqlContext _) => _Inpatient;
    private static readonly CqlCode _Inpatient = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("Outpatient", codeId: "outpatient", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlCode _Outpatient = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("Community", codeId: "community", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext _) => _Community;
    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("Discharge", codeId: "discharge", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext _) => _Discharge;
    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category");

    [CqlCodeDefinition("AD", codeId: "AD", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode AD(CqlContext _) => _AD;
    private static readonly CqlCode _AD = new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("DD", codeId: "DD", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode DD(CqlContext _) => _DD;
    private static readonly CqlCode _DD = new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("CC", codeId: "CC", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CC(CqlContext _) => _CC;
    private static readonly CqlCode _CC = new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("pre-op", codeId: "pre-op", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode pre_op(CqlContext _) => _pre_op;
    private static readonly CqlCode _pre_op = new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("post-op", codeId: "post-op", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode post_op(CqlContext _) => _post_op;
    private static readonly CqlCode _post_op = new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode billing(CqlContext _) => _billing;
    private static readonly CqlCode _billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("social-history", codeId: "social-history", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode social_history(CqlContext _) => _social_history;
    private static readonly CqlCode _social_history = new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("vital-signs", codeId: "vital-signs", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext _) => _vital_signs;
    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("imaging", codeId: "imaging", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode imaging(CqlContext _) => _imaging;
    private static readonly CqlCode _imaging = new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("procedure", codeId: "procedure", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode procedure(CqlContext _) => _procedure;
    private static readonly CqlCode _procedure = new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("exam", codeId: "exam", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext _) => _exam;
    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("therapy", codeId: "therapy", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode therapy(CqlContext _) => _therapy;
    private static readonly CqlCode _therapy = new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category");

    [CqlCodeDefinition("activity", codeId: "activity", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode activity(CqlContext _) => _activity;
    private static readonly CqlCode _activity = new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems (16)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birthdate]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _ambulatory,
          _emergency,
          _field,
          _home_health,
          _inpatient_encounter,
          _inpatient_acute,
          _inpatient_non_acute,
          _observation_encounter,
          _pre_admission,
          _short_stay,
          _virtual]);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _ER,
          _ICU]);

    [CqlCodeSystemDefinition("Diagnosis Role", codeSystemId: "http://terminology.hl7.org/CodeSystem/diagnosis-role", codeSystemVersion: null)]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, [
          _Billing,
          _AD,
          _DD,
          _CC,
          _CM,
          _pre_op,
          _post_op,
          _Billing]);

    [CqlCodeSystemDefinition("RequestIntent", codeSystemId: "http://hl7.org/fhir/request-intent", codeSystemVersion: null)]
    public CqlCodeSystem RequestIntent(CqlContext _) => _RequestIntent;
    private static readonly CqlCodeSystem _RequestIntent =
      new CqlCodeSystem("http://hl7.org/fhir/request-intent", null, []);

    [CqlCodeSystemDefinition("MedicationRequestCategory", codeSystemId: "http://terminology.hl7.org/CodeSystem/medicationrequest-category", codeSystemVersion: null)]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, [
          _Inpatient,
          _Outpatient,
          _Community,
          _Discharge]);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-clinical", codeSystemVersion: null)]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active,
          _recurrence,
          _relapse,
          _inactive,
          _remission,
          _resolved]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-ver-status", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _unconfirmed,
          _provisional,
          _differential,
          _confirmed,
          _refuted,
          _entered_in_error]);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, [
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, [
          _allergy_unconfirmed,
          _allergy_confirmed,
          _allergy_refuted]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _social_history,
          _vital_signs,
          _imaging,
          _laboratory,
          _procedure,
          _survey,
          _exam,
          _therapy,
          _activity]);

    [CqlCodeSystemDefinition("USCoreObservationCategoryExtensionCodes", codeSystemId: "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", codeSystemVersion: null)]
    public CqlCodeSystem USCoreObservationCategoryExtensionCodes(CqlContext _) => _USCoreObservationCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreObservationCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null, []);

    [CqlCodeSystemDefinition("ConditionCategory", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-category", codeSystemVersion: null)]
    public CqlCodeSystem ConditionCategory(CqlContext _) => _ConditionCategory;
    private static readonly CqlCodeSystem _ConditionCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-category", null, [
          _problem_list_item,
          _encounter_diagnosis]);

    [CqlCodeSystemDefinition("USCoreConditionCategoryExtensionCodes", codeSystemId: "http://hl7.org/fhir/us/core/CodeSystem/condition-category", codeSystemVersion: null)]
    public CqlCodeSystem USCoreConditionCategoryExtensionCodes(CqlContext _) => _USCoreConditionCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreConditionCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/condition-category", null, [
          _health_concern]);

    [CqlCodeSystemDefinition("TaskCodeSystem", codeSystemId: "http://hl7.org/fhir/CodeSystem/task-code", codeSystemVersion: null)]
    public CqlCodeSystem TaskCodeSystem(CqlContext _) => _TaskCodeSystem;
    private static readonly CqlCodeSystem _TaskCodeSystem =
      new CqlCodeSystem("http://hl7.org/fhir/CodeSystem/task-code", null, [
          _Fulfill]);

    #endregion CodeSystems

    #region Functions and Expressions (44)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4143263978380686161L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.ClinicalStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (112:3-113:46): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CodeableConcept g_ = condition?.ClinicalStatus;
            CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
            CqlCode i_ = this.recurrence(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_, j_);
            f_ = e_ | k_;
        }
        // CQL 'or' (112:3-114:43): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            CodeableConcept l_ = condition?.ClinicalStatus;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.relapse(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            bool? p_ = context.Operators.Equivalent(m_, o_);
            return f_ | p_;
        }
    }


    [CqlFunctionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> a_ = condition?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(category);
            bool? h_ = context.Operators.Equivalent(C, g_);
            return h_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(category);
            bool? h_ = context.Operators.Equivalent(C, g_);
            return h_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.problem_list_item(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.encounter_diagnosis(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.health_concern(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.social_history(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.vital_signs(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.imaging(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.laboratory(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isProcedure")]
    [CqlTag("description", "Returns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.procedure(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.survey(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.exam(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.therapy(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.activity(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> a_ = medicationRequest?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.Community(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> a_ = medicationRequest?.Category;

        CqlConcept b_(CodeableConcept @this) {
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
            return f_;
        }


        bool? c_(CqlConcept C) {
            CqlCode g_ = this.Discharge(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(C, h_);
            return i_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_, c_);
        bool? e_ = context.Operators.Exists<CqlConcept>(d_);
        return e_;
    }


    [CqlFunctionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    [CqlTag("deprecated", "This function is no longer required in QICore 6.0.0 and above")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {

        bool? a_(Extension @this) {
            FhirUri e_ = @this?.UrlElement;
            string f_ = FHIRHelpers_4_4_000.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "http://hl7.org/fhir/5.0/StructureDefinition/extension-DeviceRequest.doNotPerform");
            return g_;
        }


        object b_(Extension @this) {
            DataType h_ = @this?.Value;
            return h_;
        }

        IEnumerable<object> c_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(deviceRequest is DomainResource
            ? (deviceRequest as DomainResource).ModifierExtension
            : default), a_, b_);
        object d_ = context.Operators.SingletonFrom<object>(c_);
        return (bool?)d_;
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        if (choice is CqlDateTime)
        {
            CqlInterval<CqlDateTime> a_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);
            return a_;
        }
        else if (choice is CqlInterval<CqlDateTime>)
        {
            return choice as CqlInterval<CqlDateTime>;
        }
        else if (choice is CqlQuantity)
        {
            Patient b_ = this.Patient(context);
            Date c_ = b_?.BirthDateElement;
            string d_ = c_?.Value;
            CqlDate e_ = context.Operators.ConvertStringToDate(d_);
            CqlDate f_ = context.Operators.Add(e_, choice as CqlQuantity);
            CqlDateTime g_ = context.Operators.ConvertDateToDateTime(f_);
            CqlQuantity h_ = context.Operators.Quantity(1m, "year");
            CqlDate i_ = context.Operators.Add(f_, h_);
            CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(g_, j_, true, false);
            return k_;
        }
        else if (choice is CqlInterval<CqlQuantity>)
        {
            Patient l_ = this.Patient(context);
            Date m_ = l_?.BirthDateElement;
            string n_ = m_?.Value;
            CqlDate o_ = context.Operators.ConvertStringToDate(n_);
            object p_ = context.Operators.LateBoundProperty<object>(choice, "low");
            CqlDate q_ = context.Operators.Add(o_, p_ as CqlQuantity);
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            object s_ = context.Operators.LateBoundProperty<object>(choice, "high");
            CqlDate t_ = context.Operators.Add(o_, s_ as CqlQuantity);
            CqlQuantity u_ = context.Operators.Quantity(1m, "year");
            CqlDate v_ = context.Operators.Add(t_, u_);
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(r_, w_, true, false);
            return x_;
        }
        else if (choice is Timing)
        {
            object y_ = context.Operators.Message<object>((object)null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");
            return y_ as CqlInterval<CqlDateTime>;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        if (choice is CqlDateTime)
        {
            CqlInterval<CqlDateTime> a_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);
            return a_;
        }
        else if (choice is CqlInterval<CqlDateTime>)
        {
            return choice as CqlInterval<CqlDateTime>;
        }
        else if (choice is CqlQuantity)
        {
            Patient b_ = this.Patient(context);
            Date c_ = b_?.BirthDateElement;
            string d_ = c_?.Value;
            CqlDate e_ = context.Operators.ConvertStringToDate(d_);
            CqlDate f_ = context.Operators.Add(e_, choice as CqlQuantity);
            CqlDateTime g_ = context.Operators.ConvertDateToDateTime(f_);
            CqlQuantity h_ = context.Operators.Quantity(1m, "year");
            CqlDate i_ = context.Operators.Add(f_, h_);
            CqlDateTime j_ = context.Operators.ConvertDateToDateTime(i_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(g_, j_, true, false);
            return k_;
        }
        else if (choice is CqlInterval<CqlQuantity>)
        {
            Patient l_ = this.Patient(context);
            Date m_ = l_?.BirthDateElement;
            string n_ = m_?.Value;
            CqlDate o_ = context.Operators.ConvertStringToDate(n_);
            object p_ = context.Operators.LateBoundProperty<object>(choice, "low");
            CqlDate q_ = context.Operators.Add(o_, p_ as CqlQuantity);
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            object s_ = context.Operators.LateBoundProperty<object>(choice, "high");
            CqlDate t_ = context.Operators.Add(o_, s_ as CqlQuantity);
            CqlQuantity u_ = context.Operators.Quantity(1m, "year");
            CqlDate v_ = context.Operators.Add(t_, u_);
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(r_, w_, true, false);
            return x_;
        }
        else if (choice is Timing)
        {
            object y_ = context.Operators.Message<object>((object)null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");
            return y_ as CqlInterval<CqlDateTime>;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        DataType a_ = condition?.Abatement;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlDateTime;
        if (c_)
        {
            DataType d_ = condition?.Abatement;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlInterval<CqlDateTime> f_ = context.Operators.Interval(e_ as CqlDateTime, e_ as CqlDateTime, true, true);
            return f_;
        }
        else
        {
            DataType g_ = condition?.Abatement;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool i_ = h_ is CqlQuantity;
            if (i_)
            {
                Patient j_ = this.Patient(context);
                Date k_ = j_?.BirthDateElement;
                string l_ = k_?.Value;
                CqlDate m_ = context.Operators.ConvertStringToDate(l_);
                DataType n_ = condition?.Abatement;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDate p_ = context.Operators.Add(m_, o_ as CqlQuantity);
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "year");
                CqlDate s_ = context.Operators.Add(p_, r_);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(q_, t_, true, false);
                return u_;
            }
            else
            {
                DataType v_ = condition?.Abatement;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlInterval<CqlQuantity>;
                if (x_)
                {
                    Patient y_ = this.Patient(context);
                    Date z_ = y_?.BirthDateElement;
                    string aa_ = z_?.Value;
                    CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
                    DataType ac_ = condition?.Abatement;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    object ae_ = context.Operators.LateBoundProperty<object>(ad_, "low");
                    CqlDate af_ = context.Operators.Add(ab_, ae_ as CqlQuantity);
                    CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
                    object ah_ = context.Operators.LateBoundProperty<object>(ad_, "high");
                    CqlDate ai_ = context.Operators.Add(ab_, ah_ as CqlQuantity);
                    CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
                    CqlDate ak_ = context.Operators.Add(ai_, aj_);
                    CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
                    CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ag_, al_, true, false);
                    return am_;
                }
                else
                {
                    DataType an_ = condition?.Abatement;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType aq_ = condition?.Abatement;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        object as_ = context.Operators.LateBoundProperty<object>(ar_, "low");
                        object at_ = context.Operators.LateBoundProperty<object>(ar_, "high");
                        CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_ as CqlDateTime, at_ as CqlDateTime, true, false);
                        return au_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDateTime>;
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        DataType a_ = condition?.Abatement;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlDateTime;
        if (c_)
        {
            DataType d_ = condition?.Abatement;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlInterval<CqlDateTime> f_ = context.Operators.Interval(e_ as CqlDateTime, e_ as CqlDateTime, true, true);
            return f_;
        }
        else
        {
            DataType g_ = condition?.Abatement;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool i_ = h_ is CqlQuantity;
            if (i_)
            {
                Patient j_ = this.Patient(context);
                Date k_ = j_?.BirthDateElement;
                string l_ = k_?.Value;
                CqlDate m_ = context.Operators.ConvertStringToDate(l_);
                DataType n_ = condition?.Abatement;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlDate p_ = context.Operators.Add(m_, o_ as CqlQuantity);
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "year");
                CqlDate s_ = context.Operators.Add(p_, r_);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(q_, t_, true, false);
                return u_;
            }
            else
            {
                DataType v_ = condition?.Abatement;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool x_ = w_ is CqlInterval<CqlQuantity>;
                if (x_)
                {
                    Patient y_ = this.Patient(context);
                    Date z_ = y_?.BirthDateElement;
                    string aa_ = z_?.Value;
                    CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
                    DataType ac_ = condition?.Abatement;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    object ae_ = context.Operators.LateBoundProperty<object>(ad_, "low");
                    CqlDate af_ = context.Operators.Add(ab_, ae_ as CqlQuantity);
                    CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
                    object ah_ = context.Operators.LateBoundProperty<object>(ad_, "high");
                    CqlDate ai_ = context.Operators.Add(ab_, ah_ as CqlQuantity);
                    CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
                    CqlDate ak_ = context.Operators.Add(ai_, aj_);
                    CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
                    CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ag_, al_, true, false);
                    return am_;
                }
                else
                {
                    DataType an_ = condition?.Abatement;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType aq_ = condition?.Abatement;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        object as_ = context.Operators.LateBoundProperty<object>(ar_, "low");
                        object at_ = context.Operators.LateBoundProperty<object>(ar_, "high");
                        CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_ as CqlDateTime, at_ as CqlDateTime, true, false);
                        return au_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDateTime>;
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.ClinicalStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (435:4-436:44): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CodeableConcept h_ = condition?.ClinicalStatus;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            CqlCode j_ = this.recurrence(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            f_ = e_ | l_;
        }
        bool? g_;
        // CQL 'or' (435:4-437:41): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CodeableConcept m_ = condition?.ClinicalStatus;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.relapse(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            g_ = f_ | q_;
        }
        if (g_ ?? false)
        {
            DataType r_ = condition?.Onset;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = this.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = this.ToAbatementInterval(context, condition);
            CqlDateTime w_ = context.Operators.End(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            return x_;
        }
        else
        {
            CqlInterval<CqlDateTime> y_ = this.ToAbatementInterval(context, condition);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlDateTime[] aa_ = [
                z_,
            ];

            CqlInterval<CqlDateTime> ab_(CqlDateTime abatementDate) {
                if (abatementDate is null)
                {
                    DataType ae_ = condition?.Onset;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime> ag_ = this.ToInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ah_, abatementDate, true, false);
                    return ai_;
                }
                else
                {
                    DataType aj_ = condition?.Onset;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    CqlInterval<CqlDateTime> al_ = this.ToInterval(context, ak_);
                    CqlDateTime am_ = context.Operators.Start(al_);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(am_, abatementDate, true, true);
                    return an_;
                }
            }

            IEnumerable<CqlInterval<CqlDateTime>> ac_ = context.Operators.SelectDistinct<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)aa_, ab_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ac_);
            return ad_;
        }
    }


    [CqlFunctionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.ClinicalStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (453:4-454:44): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CodeableConcept h_ = condition?.ClinicalStatus;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            CqlCode j_ = this.recurrence(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_, k_);
            f_ = e_ | l_;
        }
        bool? g_;
        // CQL 'or' (453:4-455:41): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CodeableConcept m_ = condition?.ClinicalStatus;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlCode o_ = this.relapse(context);
            CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
            bool? q_ = context.Operators.Equivalent(n_, p_);
            g_ = f_ | q_;
        }
        if (g_ ?? false)
        {
            DataType r_ = condition?.Onset;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = this.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = this.abatementInterval(context, condition);
            CqlDateTime w_ = context.Operators.End(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            return x_;
        }
        else
        {
            CqlInterval<CqlDateTime> y_ = this.abatementInterval(context, condition);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlDateTime[] aa_ = [
                z_,
            ];

            CqlInterval<CqlDateTime> ab_(CqlDateTime abatementDate) {
                if (abatementDate is null)
                {
                    DataType ae_ = condition?.Onset;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime> ag_ = this.toInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ah_, abatementDate, true, false);
                    return ai_;
                }
                else
                {
                    DataType aj_ = condition?.Onset;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    CqlInterval<CqlDateTime> al_ = this.toInterval(context, ak_);
                    CqlDateTime am_ = context.Operators.Start(al_);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(am_, abatementDate, true, true);
                    return an_;
                }
            }

            IEnumerable<CqlInterval<CqlDateTime>> ac_ = context.Operators.SelectDistinct<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)aa_, ab_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ac_);
            return ad_;
        }
    }


    [CqlFunctionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("references")]
    [CqlTag("description", "Returns true if the given reference is to the given resource")]
    [CqlTag("comment", "Returns true if the `id` element of the given resource exactly equals the tail of the given reference.\nNOTE: This function assumes resources from the same source server.")]
    public bool? references(CqlContext context, ResourceReference reference, Resource resource)
    {
        Id a_ = resource?.IdElement;
        string b_ = a_?.Value;
        FhirString c_ = reference?.ReferenceElement;
        string d_ = c_?.Value;
        IEnumerable<string> e_ = context.Operators.Split(d_, "/");
        string f_ = context.Operators.Last<string>(e_);
        bool? g_ = context.Operators.Equal(b_, f_);
        return g_;
    }


    [CqlFunctionDefinition("references")]
    [CqlTag("description", "Returns true if the given reference is to the given resourceId")]
    [CqlTag("comment", "Returns true if the `resourceId` parameter exactly equals the tail of the given reference.\nNOTE: This function assumes resources from the same source server.")]
    public bool? references(CqlContext context, ResourceReference reference, string resourceId)
    {
        FhirString a_ = reference?.ReferenceElement;
        string b_ = a_?.Value;
        IEnumerable<string> c_ = context.Operators.Split(b_, "/");
        string d_ = context.Operators.Last<string>(c_);
        bool? e_ = context.Operators.Equal(resourceId, d_);
        return e_;
    }


    [CqlFunctionDefinition("references")]
    [CqlTag("description", "Returns true if any of the given references are to the given resource")]
    [CqlTag("comment", "Returns true if the `id` element of the given resource exactly equals the tail of any of the given references.\nNOTE: This function assumes resources from the same source server.")]
    public bool? references(CqlContext context, IEnumerable<ResourceReference> references, Resource resource)
    {

        bool? a_(ResourceReference R) {
            bool? c_ = this.references(context, R, resource);
            return c_;
        }

        bool? b_ = context.Operators.WhereAny<ResourceReference>(references, a_);
        return b_;
    }


    [CqlFunctionDefinition("references")]
    [CqlTag("description", "Returns true if any of the given references are to the given resourceId")]
    [CqlTag("comment", "Returns true if the `resourceId` parameter exactly equals the tail of any of the given references.\nNOTE: This function assumes resources from the same source server.")]
    public bool? references(CqlContext context, IEnumerable<ResourceReference> references, string resourceId)
    {

        bool? a_(ResourceReference R) {
            bool? c_ = this.references(context, R, resourceId);
            return c_;
        }

        bool? b_ = context.Operators.WhereAny<ResourceReference>(references, a_);
        return b_;
    }


    [CqlFunctionDefinition("includesCode")]
    [CqlTag("description", "Returns true if the given code is in the given codeList")]
    [CqlTag("comment", "Returns true if the `code` is equivalent to any of the codes in the given `codeList`, false otherwise.")]
    public bool? includesCode(CqlContext context, IEnumerable<CqlConcept> codeList, CqlCode code)
    {

        bool? a_(CqlConcept C) {
            CqlConcept c_ = context.Operators.ConvertCodeToConcept(code);
            bool? d_ = context.Operators.Equivalent(C, c_);
            return d_;
        }

        bool? b_ = context.Operators.WhereAny<CqlConcept>(codeList, a_);
        return b_;
    }


    [CqlFunctionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        bool? b_ = (bool?)(a_ is null);
        bool? c_;
        // CQL 'or' (528:7-530:3): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            CqlDateTime d_ = context.Operators.Start(period);
            CqlDateTime e_ = context.Operators.MinValue<CqlDateTime>();
            bool? f_ = context.Operators.Equal(d_, e_);
            c_ = b_ | f_;
        }
        return !c_;
    }


    [CqlFunctionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        bool? b_ = (bool?)(a_ is null);
        bool? c_;
        // CQL 'or' (537:7-539:3): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            CqlDateTime d_ = context.Operators.Start(period);
            CqlDateTime e_ = context.Operators.MinValue<CqlDateTime>();
            bool? f_ = context.Operators.Equal(d_, e_);
            c_ = b_ | f_;
        }
        return !c_;
    }


    [CqlFunctionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        bool? b_ = (bool?)(a_ is null);
        bool? c_;
        // CQL 'or' (547:7-550:3): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            CqlDateTime d_ = context.Operators.End(period);
            CqlDateTime e_ = context.Operators.MaxValue<CqlDateTime>();
            bool? f_ = context.Operators.Equal(d_, e_);
            c_ = b_ | f_;
        }
        return !c_;
    }


    [CqlFunctionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        bool? b_ = (bool?)(a_ is null);
        bool? c_;
        // CQL 'or' (557:7-560:3): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            CqlDateTime d_ = context.Operators.End(period);
            CqlDateTime e_ = context.Operators.MaxValue<CqlDateTime>();
            bool? f_ = context.Operators.Equal(d_, e_);
            c_ = b_ | f_;
        }
        return !c_;
    }


    [CqlFunctionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {
            if ((this.HasEnd(context, period)) ?? false)
            {
                CqlDateTime f_ = context.Operators.End(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.Start(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
    }


    [CqlFunctionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {
            if ((this.hasEnd(context, period)) ?? false)
            {
                CqlDateTime f_ = context.Operators.End(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.Start(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {
            if ((this.HasStart(context, period)) ?? false)
            {
                CqlDateTime f_ = context.Operators.Start(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.End(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
    }


    [CqlFunctionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];

        CqlDateTime c_(CqlInterval<CqlDateTime> period) {
            if ((this.hasStart(context, period)) ?? false)
            {
                CqlDateTime f_ = context.Operators.Start(period);
                return f_;
            }
            else
            {
                CqlDateTime g_ = context.Operators.End(period);
                return g_;
            }
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((IEnumerable<CqlInterval<int?>>)e_, (CqlQuantity)default);

        int? g_(CqlInterval<int?> DayNumber) {
            int? i_ = context.Operators.End(DayNumber);
            return i_;
        }

        IEnumerable<int?> h_ = context.Operators.SelectDistinct<CqlInterval<int?>, int?>(f_, g_);
        return h_;
    }


    [CqlFunctionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((IEnumerable<CqlInterval<int?>>)e_, (CqlQuantity)default);

        int? g_(CqlInterval<int?> DayNumber) {
            int? i_ = context.Operators.End(DayNumber);
            return i_;
        }

        IEnumerable<int?> h_ = context.Operators.SelectDistinct<CqlInterval<int?>, int?>(f_, g_);
        return h_;
    }


    [CqlFunctionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);

        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex) {
            CqlDateTime d_ = context.Operators.Start(Period);
            CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
            int? f_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
            CqlQuantity h_ = context.Operators.Multiply(e_, g_);
            CqlDateTime i_ = context.Operators.Add(d_, h_);
            CqlDateTime j_;
            CqlDateTime m_ = context.Operators.Start(Period);
            CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
            int? o_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity p_ = context.Operators.ConvertIntegerToQuantity(o_);
            CqlQuantity q_ = context.Operators.Multiply(n_, p_);
            CqlDateTime r_ = context.Operators.Add(m_, q_);
            CqlDateTime s_ = context.Operators.End(Period);
            int? t_ = context.Operators.DurationBetween(r_, s_, "hour");
            bool? u_ = context.Operators.Less(t_, 24);
            if (u_ ?? false)
            {
                CqlDateTime v_ = context.Operators.Start(Period);
                CqlQuantity w_ = context.Operators.Quantity(24m, "hours");
                int? x_ = context.Operators.Subtract(DayIndex, 1);
                CqlQuantity y_ = context.Operators.ConvertIntegerToQuantity(x_);
                CqlQuantity z_ = context.Operators.Multiply(w_, y_);
                CqlDateTime aa_ = context.Operators.Add(v_, z_);
                j_ = aa_;
            }
            else
            {
                CqlDateTime ab_ = context.Operators.Start(Period);
                CqlQuantity ac_ = context.Operators.Quantity(24m, "hours");
                CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                CqlQuantity ae_ = context.Operators.Multiply(ac_, ad_);
                CqlDateTime af_ = context.Operators.Add(ab_, ae_);
                j_ = af_;
            }
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_, true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, k_);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.SelectDistinct<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);

        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex) {
            CqlDateTime d_ = context.Operators.Start(Period);
            CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
            int? f_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
            CqlQuantity h_ = context.Operators.Multiply(e_, g_);
            CqlDateTime i_ = context.Operators.Add(d_, h_);
            CqlDateTime j_;
            CqlDateTime m_ = context.Operators.Start(Period);
            CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
            int? o_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity p_ = context.Operators.ConvertIntegerToQuantity(o_);
            CqlQuantity q_ = context.Operators.Multiply(n_, p_);
            CqlDateTime r_ = context.Operators.Add(m_, q_);
            CqlDateTime s_ = context.Operators.End(Period);
            int? t_ = context.Operators.DurationBetween(r_, s_, "hour");
            bool? u_ = context.Operators.Less(t_, 24);
            if (u_ ?? false)
            {
                CqlDateTime v_ = context.Operators.Start(Period);
                CqlQuantity w_ = context.Operators.Quantity(24m, "hours");
                int? x_ = context.Operators.Subtract(DayIndex, 1);
                CqlQuantity y_ = context.Operators.ConvertIntegerToQuantity(x_);
                CqlQuantity z_ = context.Operators.Multiply(w_, y_);
                CqlDateTime aa_ = context.Operators.Add(v_, z_);
                j_ = aa_;
            }
            else
            {
                CqlDateTime ab_ = context.Operators.Start(Period);
                CqlQuantity ac_ = context.Operators.Quantity(24m, "hours");
                CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                CqlQuantity ae_ = context.Operators.Multiply(ac_, ad_);
                CqlDateTime af_ = context.Operators.Add(ab_, ae_);
                j_ = af_;
            }
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_, true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, k_);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.SelectDistinct<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private QICoreCommon_4_0_000() {}

    public static QICoreCommon_4_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "QICoreCommon";
    public string Version => "4.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
       ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
