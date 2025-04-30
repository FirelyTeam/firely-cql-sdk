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

    [CqlCodeDefinition("clinical-test", codeId: "clinical-test", codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category")]
    public CqlCode clinical_test(CqlContext _) => _clinical_test;
    private static readonly CqlCode _clinical_test = new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birthdate]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead]);

    [CqlCodeSystemDefinition("ActCode")]
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

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _ER,
          _ICU]);

    [CqlCodeSystemDefinition("Diagnosis Role")]
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
          _billing]);

    [CqlCodeSystemDefinition("RequestIntent")]
    public CqlCodeSystem RequestIntent(CqlContext _) => _RequestIntent;
    private static readonly CqlCodeSystem _RequestIntent =
      new CqlCodeSystem("http://hl7.org/fhir/request-intent", null, []);

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, [
          _Inpatient,
          _Outpatient,
          _Community,
          _Discharge]);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null, [
          _active,
          _recurrence,
          _relapse,
          _inactive,
          _remission,
          _resolved]);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null, [
          _unconfirmed,
          _provisional,
          _differential,
          _confirmed,
          _refuted,
          _entered_in_error]);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, [
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved]);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, [
          _allergy_unconfirmed,
          _allergy_confirmed,
          _allergy_refuted]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
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

    [CqlCodeSystemDefinition("USCoreObservationCategoryExtensionCodes")]
    public CqlCodeSystem USCoreObservationCategoryExtensionCodes(CqlContext _) => _USCoreObservationCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreObservationCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null, [
          _clinical_test]);

    [CqlCodeSystemDefinition("ConditionCategory")]
    public CqlCodeSystem ConditionCategory(CqlContext _) => _ConditionCategory;
    private static readonly CqlCodeSystem _ConditionCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-category", null, [
          _problem_list_item,
          _encounter_diagnosis]);

    [CqlCodeSystemDefinition("USCoreConditionCategoryExtensionCodes")]
    public CqlCodeSystem USCoreConditionCategoryExtensionCodes(CqlContext _) => _USCoreConditionCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreConditionCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/condition-category", null, [
          _health_concern]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ws_ = context.Operators.SingletonFrom<Patient>(wr_);

        return ws_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept wt_ = condition?.ClinicalStatus;
        CqlConcept wu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wt_);
        CqlCode wv_ = this.active(context);
        CqlConcept ww_ = context.Operators.ConvertCodeToConcept(wv_);
        bool? wx_ = context.Operators.Equivalent(wu_, ww_);
        CqlConcept wz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wt_);
        CqlCode xa_ = this.recurrence(context);
        CqlConcept xb_ = context.Operators.ConvertCodeToConcept(xa_);
        bool? xc_ = context.Operators.Equivalent(wz_, xb_);
        bool? xd_ = context.Operators.Or(wx_, xc_);
        CqlConcept xf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wt_);
        CqlCode xg_ = this.relapse(context);
        CqlConcept xh_ = context.Operators.ConvertCodeToConcept(xg_);
        bool? xi_ = context.Operators.Equivalent(xf_, xh_);
        bool? xj_ = context.Operators.Or(xd_, xi_);

        return xj_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> xk_ = condition?.Category;
        CqlConcept xl_(CodeableConcept @this)
        {
            CqlConcept xq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xq_;
        };
        IEnumerable<CqlConcept> xm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xk_, xl_);
        bool? xn_(CqlConcept C)
        {
            CqlConcept xr_ = context.Operators.ConvertCodeToConcept(category);
            bool? xs_ = context.Operators.Equivalent(C, xr_);

            return xs_;
        };
        IEnumerable<CqlConcept> xo_ = context.Operators.Where<CqlConcept>(xm_, xn_);
        bool? xp_ = context.Operators.Exists<CqlConcept>(xo_);

        return xp_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> xt_ = observation?.Category;
        CqlConcept xu_(CodeableConcept @this)
        {
            CqlConcept xz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xz_;
        };
        IEnumerable<CqlConcept> xv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xt_, xu_);
        bool? xw_(CqlConcept C)
        {
            CqlConcept ya_ = context.Operators.ConvertCodeToConcept(category);
            bool? yb_ = context.Operators.Equivalent(C, ya_);

            return yb_;
        };
        IEnumerable<CqlConcept> xx_ = context.Operators.Where<CqlConcept>(xv_, xw_);
        bool? xy_ = context.Operators.Exists<CqlConcept>(xx_);

        return xy_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yc_ = condition?.Category;
        CqlConcept yd_(CodeableConcept @this)
        {
            CqlConcept yi_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yi_;
        };
        IEnumerable<CqlConcept> ye_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yc_, yd_);
        bool? yf_(CqlConcept C)
        {
            CqlCode yj_ = this.problem_list_item(context);
            CqlConcept yk_ = context.Operators.ConvertCodeToConcept(yj_);
            bool? yl_ = context.Operators.Equivalent(C, yk_);

            return yl_;
        };
        IEnumerable<CqlConcept> yg_ = context.Operators.Where<CqlConcept>(ye_, yf_);
        bool? yh_ = context.Operators.Exists<CqlConcept>(yg_);

        return yh_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> ym_ = condition?.Category;
        CqlConcept yn_(CodeableConcept @this)
        {
            CqlConcept ys_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return ys_;
        };
        IEnumerable<CqlConcept> yo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ym_, yn_);
        bool? yp_(CqlConcept C)
        {
            CqlCode yt_ = this.encounter_diagnosis(context);
            CqlConcept yu_ = context.Operators.ConvertCodeToConcept(yt_);
            bool? yv_ = context.Operators.Equivalent(C, yu_);

            return yv_;
        };
        IEnumerable<CqlConcept> yq_ = context.Operators.Where<CqlConcept>(yo_, yp_);
        bool? yr_ = context.Operators.Exists<CqlConcept>(yq_);

        return yr_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yw_ = condition?.Category;
        CqlConcept yx_(CodeableConcept @this)
        {
            CqlConcept zc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zc_;
        };
        IEnumerable<CqlConcept> yy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yw_, yx_);
        bool? yz_(CqlConcept C)
        {
            CqlCode zd_ = this.health_concern(context);
            CqlConcept ze_ = context.Operators.ConvertCodeToConcept(zd_);
            bool? zf_ = context.Operators.Equivalent(C, ze_);

            return zf_;
        };
        IEnumerable<CqlConcept> za_ = context.Operators.Where<CqlConcept>(yy_, yz_);
        bool? zb_ = context.Operators.Exists<CqlConcept>(za_);

        return zb_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zg_ = observation?.Category;
        CqlConcept zh_(CodeableConcept @this)
        {
            CqlConcept zm_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zm_;
        };
        IEnumerable<CqlConcept> zi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zg_, zh_);
        bool? zj_(CqlConcept C)
        {
            CqlCode zn_ = this.social_history(context);
            CqlConcept zo_ = context.Operators.ConvertCodeToConcept(zn_);
            bool? zp_ = context.Operators.Equivalent(C, zo_);

            return zp_;
        };
        IEnumerable<CqlConcept> zk_ = context.Operators.Where<CqlConcept>(zi_, zj_);
        bool? zl_ = context.Operators.Exists<CqlConcept>(zk_);

        return zl_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zq_ = observation?.Category;
        CqlConcept zr_(CodeableConcept @this)
        {
            CqlConcept zw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zw_;
        };
        IEnumerable<CqlConcept> zs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zq_, zr_);
        bool? zt_(CqlConcept C)
        {
            CqlCode zx_ = this.vital_signs(context);
            CqlConcept zy_ = context.Operators.ConvertCodeToConcept(zx_);
            bool? zz_ = context.Operators.Equivalent(C, zy_);

            return zz_;
        };
        IEnumerable<CqlConcept> zu_ = context.Operators.Where<CqlConcept>(zs_, zt_);
        bool? zv_ = context.Operators.Exists<CqlConcept>(zu_);

        return zv_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> aza_ = observation?.Category;
        CqlConcept azb_(CodeableConcept @this)
        {
            CqlConcept azg_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azg_;
        };
        IEnumerable<CqlConcept> azc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aza_, azb_);
        bool? azd_(CqlConcept C)
        {
            CqlCode azh_ = this.imaging(context);
            CqlConcept azi_ = context.Operators.ConvertCodeToConcept(azh_);
            bool? azj_ = context.Operators.Equivalent(C, azi_);

            return azj_;
        };
        IEnumerable<CqlConcept> aze_ = context.Operators.Where<CqlConcept>(azc_, azd_);
        bool? azf_ = context.Operators.Exists<CqlConcept>(aze_);

        return azf_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azk_ = observation?.Category;
        CqlConcept azl_(CodeableConcept @this)
        {
            CqlConcept azq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azq_;
        };
        IEnumerable<CqlConcept> azm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azk_, azl_);
        bool? azn_(CqlConcept C)
        {
            CqlCode azr_ = this.laboratory(context);
            CqlConcept azs_ = context.Operators.ConvertCodeToConcept(azr_);
            bool? azt_ = context.Operators.Equivalent(C, azs_);

            return azt_;
        };
        IEnumerable<CqlConcept> azo_ = context.Operators.Where<CqlConcept>(azm_, azn_);
        bool? azp_ = context.Operators.Exists<CqlConcept>(azo_);

        return azp_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azu_ = observation?.Category;
        CqlConcept azv_(CodeableConcept @this)
        {
            CqlConcept bza_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bza_;
        };
        IEnumerable<CqlConcept> azw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azu_, azv_);
        bool? azx_(CqlConcept C)
        {
            CqlCode bzb_ = this.procedure(context);
            CqlConcept bzc_ = context.Operators.ConvertCodeToConcept(bzb_);
            bool? bzd_ = context.Operators.Equivalent(C, bzc_);

            return bzd_;
        };
        IEnumerable<CqlConcept> azy_ = context.Operators.Where<CqlConcept>(azw_, azx_);
        bool? azz_ = context.Operators.Exists<CqlConcept>(azy_);

        return azz_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bze_ = observation?.Category;
        CqlConcept bzf_(CodeableConcept @this)
        {
            CqlConcept bzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzk_;
        };
        IEnumerable<CqlConcept> bzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bze_, bzf_);
        bool? bzh_(CqlConcept C)
        {
            CqlCode bzl_ = this.survey(context);
            CqlConcept bzm_ = context.Operators.ConvertCodeToConcept(bzl_);
            bool? bzn_ = context.Operators.Equivalent(C, bzm_);

            return bzn_;
        };
        IEnumerable<CqlConcept> bzi_ = context.Operators.Where<CqlConcept>(bzg_, bzh_);
        bool? bzj_ = context.Operators.Exists<CqlConcept>(bzi_);

        return bzj_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzo_ = observation?.Category;
        CqlConcept bzp_(CodeableConcept @this)
        {
            CqlConcept bzu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzu_;
        };
        IEnumerable<CqlConcept> bzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzo_, bzp_);
        bool? bzr_(CqlConcept C)
        {
            CqlCode bzv_ = this.exam(context);
            CqlConcept bzw_ = context.Operators.ConvertCodeToConcept(bzv_);
            bool? bzx_ = context.Operators.Equivalent(C, bzw_);

            return bzx_;
        };
        IEnumerable<CqlConcept> bzs_ = context.Operators.Where<CqlConcept>(bzq_, bzr_);
        bool? bzt_ = context.Operators.Exists<CqlConcept>(bzs_);

        return bzt_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzy_ = observation?.Category;
        CqlConcept bzz_(CodeableConcept @this)
        {
            CqlConcept cze_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return cze_;
        };
        IEnumerable<CqlConcept> cza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzy_, bzz_);
        bool? czb_(CqlConcept C)
        {
            CqlCode czf_ = this.therapy(context);
            CqlConcept czg_ = context.Operators.ConvertCodeToConcept(czf_);
            bool? czh_ = context.Operators.Equivalent(C, czg_);

            return czh_;
        };
        IEnumerable<CqlConcept> czc_ = context.Operators.Where<CqlConcept>(cza_, czb_);
        bool? czd_ = context.Operators.Exists<CqlConcept>(czc_);

        return czd_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czi_ = observation?.Category;
        CqlConcept czj_(CodeableConcept @this)
        {
            CqlConcept czo_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czo_;
        };
        IEnumerable<CqlConcept> czk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czi_, czj_);
        bool? czl_(CqlConcept C)
        {
            CqlCode czp_ = this.activity(context);
            CqlConcept czq_ = context.Operators.ConvertCodeToConcept(czp_);
            bool? czr_ = context.Operators.Equivalent(C, czq_);

            return czr_;
        };
        IEnumerable<CqlConcept> czm_ = context.Operators.Where<CqlConcept>(czk_, czl_);
        bool? czn_ = context.Operators.Exists<CqlConcept>(czm_);

        return czn_;
    }


    [CqlExpressionDefinition("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czs_ = observation?.Category;
        CqlConcept czt_(CodeableConcept @this)
        {
            CqlConcept czy_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czy_;
        };
        IEnumerable<CqlConcept> czu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czs_, czt_);
        bool? czv_(CqlConcept C)
        {
            CqlCode czz_ = this.clinical_test(context);
            CqlConcept dza_ = context.Operators.ConvertCodeToConcept(czz_);
            bool? dzb_ = context.Operators.Equivalent(C, dza_);

            return dzb_;
        };
        IEnumerable<CqlConcept> czw_ = context.Operators.Where<CqlConcept>(czu_, czv_);
        bool? czx_ = context.Operators.Exists<CqlConcept>(czw_);

        return czx_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzc_ = medicationRequest?.Category;
        CqlConcept dzd_(CodeableConcept @this)
        {
            CqlConcept dzi_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzi_;
        };
        IEnumerable<CqlConcept> dze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzc_, dzd_);
        bool? dzf_(CqlConcept C)
        {
            CqlCode dzj_ = this.Community(context);
            CqlConcept dzk_ = context.Operators.ConvertCodeToConcept(dzj_);
            bool? dzl_ = context.Operators.Equivalent(C, dzk_);

            return dzl_;
        };
        IEnumerable<CqlConcept> dzg_ = context.Operators.Where<CqlConcept>(dze_, dzf_);
        bool? dzh_ = context.Operators.Exists<CqlConcept>(dzg_);

        return dzh_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzm_ = medicationRequest?.Category;
        CqlConcept dzn_(CodeableConcept @this)
        {
            CqlConcept dzs_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzs_;
        };
        IEnumerable<CqlConcept> dzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzm_, dzn_);
        bool? dzp_(CqlConcept C)
        {
            CqlCode dzt_ = this.Discharge(context);
            CqlConcept dzu_ = context.Operators.ConvertCodeToConcept(dzt_);
            bool? dzv_ = context.Operators.Equivalent(C, dzu_);

            return dzv_;
        };
        IEnumerable<CqlConcept> dzq_ = context.Operators.Where<CqlConcept>(dzo_, dzp_);
        bool? dzr_ = context.Operators.Exists<CqlConcept>(dzq_);

        return dzr_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? dzw_(Extension E)
        {
            string ezc_ = E?.Url;
            FhirString ezd_ = context.Operators.Convert<FhirString>(ezc_);
            string eze_ = ezd_?.Value;
            bool? ezf_ = context.Operators.Equal(eze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return ezf_;
        };
        IEnumerable<Extension> dzx_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), dzw_);
        bool? dzy_(Extension E)
        {
            DataType ezg_ = E?.Value;
            object ezh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezg_);

            return ezh_ as bool?;
        };
        IEnumerable<bool?> dzz_ = context.Operators.Select<Extension, bool?>(dzx_, dzy_);
        IEnumerable<bool?> eza_ = context.Operators.Distinct<bool?>(dzz_);
        bool? ezb_ = context.Operators.SingletonFrom<bool?>(eza_);

        return ezb_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezi_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ezj_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ezj_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezk_ = this.Patient(context);
                Date ezl_ = ezk_?.BirthDateElement;
                string ezm_ = ezl_?.Value;
                CqlDate ezn_ = context.Operators.ConvertStringToDate(ezm_);
                CqlDate ezo_ = context.Operators.Add(ezn_, choice as CqlQuantity);
                Date ezq_ = ezk_?.BirthDateElement;
                string ezr_ = ezq_?.Value;
                CqlDate ezs_ = context.Operators.ConvertStringToDate(ezr_);
                CqlDate ezt_ = context.Operators.Add(ezs_, choice as CqlQuantity);
                CqlQuantity ezu_ = context.Operators.Quantity(1m, "year");
                CqlDate ezv_ = context.Operators.Add(ezt_, ezu_);
                CqlInterval<CqlDate> ezw_ = context.Operators.Interval(ezo_, ezv_, true, false);
                CqlDate ezx_ = ezw_?.low;
                CqlDateTime ezy_ = context.Operators.ConvertDateToDateTime(ezx_);
                Date fza_ = ezk_?.BirthDateElement;
                string fzb_ = fza_?.Value;
                CqlDate fzc_ = context.Operators.ConvertStringToDate(fzb_);
                CqlDate fzd_ = context.Operators.Add(fzc_, choice as CqlQuantity);
                Date fzf_ = ezk_?.BirthDateElement;
                string fzg_ = fzf_?.Value;
                CqlDate fzh_ = context.Operators.ConvertStringToDate(fzg_);
                CqlDate fzi_ = context.Operators.Add(fzh_, choice as CqlQuantity);
                CqlDate fzk_ = context.Operators.Add(fzi_, ezu_);
                CqlInterval<CqlDate> fzl_ = context.Operators.Interval(fzd_, fzk_, true, false);
                CqlDate fzm_ = fzl_?.high;
                CqlDateTime fzn_ = context.Operators.ConvertDateToDateTime(fzm_);
                Date fzp_ = ezk_?.BirthDateElement;
                string fzq_ = fzp_?.Value;
                CqlDate fzr_ = context.Operators.ConvertStringToDate(fzq_);
                CqlDate fzs_ = context.Operators.Add(fzr_, choice as CqlQuantity);
                Date fzu_ = ezk_?.BirthDateElement;
                string fzv_ = fzu_?.Value;
                CqlDate fzw_ = context.Operators.ConvertStringToDate(fzv_);
                CqlDate fzx_ = context.Operators.Add(fzw_, choice as CqlQuantity);
                CqlDate fzz_ = context.Operators.Add(fzx_, ezu_);
                CqlInterval<CqlDate> gza_ = context.Operators.Interval(fzs_, fzz_, true, false);
                bool? gzb_ = gza_?.lowClosed;
                Date gzd_ = ezk_?.BirthDateElement;
                string gze_ = gzd_?.Value;
                CqlDate gzf_ = context.Operators.ConvertStringToDate(gze_);
                CqlDate gzg_ = context.Operators.Add(gzf_, choice as CqlQuantity);
                Date gzi_ = ezk_?.BirthDateElement;
                string gzj_ = gzi_?.Value;
                CqlDate gzk_ = context.Operators.ConvertStringToDate(gzj_);
                CqlDate gzl_ = context.Operators.Add(gzk_, choice as CqlQuantity);
                CqlDate gzn_ = context.Operators.Add(gzl_, ezu_);
                CqlInterval<CqlDate> gzo_ = context.Operators.Interval(gzg_, gzn_, true, false);
                bool? gzp_ = gzo_?.highClosed;
                CqlInterval<CqlDateTime> gzq_ = context.Operators.Interval(ezy_, fzn_, gzb_, gzp_);

                return gzq_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzr_ = this.Patient(context);
                Date gzs_ = gzr_?.BirthDateElement;
                string gzt_ = gzs_?.Value;
                CqlDate gzu_ = context.Operators.ConvertStringToDate(gzt_);
                object gzv_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate gzw_ = context.Operators.Add(gzu_, gzv_ as CqlQuantity);
                Date gzy_ = gzr_?.BirthDateElement;
                string gzz_ = gzy_?.Value;
                CqlDate hza_ = context.Operators.ConvertStringToDate(gzz_);
                object hzb_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate hzc_ = context.Operators.Add(hza_, hzb_ as CqlQuantity);
                CqlQuantity hzd_ = context.Operators.Quantity(1m, "year");
                CqlDate hze_ = context.Operators.Add(hzc_, hzd_);
                CqlInterval<CqlDate> hzf_ = context.Operators.Interval(gzw_, hze_, true, false);
                CqlDate hzg_ = hzf_?.low;
                CqlDateTime hzh_ = context.Operators.ConvertDateToDateTime(hzg_);
                Date hzj_ = gzr_?.BirthDateElement;
                string hzk_ = hzj_?.Value;
                CqlDate hzl_ = context.Operators.ConvertStringToDate(hzk_);
                CqlDate hzn_ = context.Operators.Add(hzl_, gzv_ as CqlQuantity);
                Date hzp_ = gzr_?.BirthDateElement;
                string hzq_ = hzp_?.Value;
                CqlDate hzr_ = context.Operators.ConvertStringToDate(hzq_);
                CqlDate hzt_ = context.Operators.Add(hzr_, hzb_ as CqlQuantity);
                CqlDate hzv_ = context.Operators.Add(hzt_, hzd_);
                CqlInterval<CqlDate> hzw_ = context.Operators.Interval(hzn_, hzv_, true, false);
                CqlDate hzx_ = hzw_?.high;
                CqlDateTime hzy_ = context.Operators.ConvertDateToDateTime(hzx_);
                Date iza_ = gzr_?.BirthDateElement;
                string izb_ = iza_?.Value;
                CqlDate izc_ = context.Operators.ConvertStringToDate(izb_);
                CqlDate ize_ = context.Operators.Add(izc_, gzv_ as CqlQuantity);
                Date izg_ = gzr_?.BirthDateElement;
                string izh_ = izg_?.Value;
                CqlDate izi_ = context.Operators.ConvertStringToDate(izh_);
                CqlDate izk_ = context.Operators.Add(izi_, hzb_ as CqlQuantity);
                CqlDate izm_ = context.Operators.Add(izk_, hzd_);
                CqlInterval<CqlDate> izn_ = context.Operators.Interval(ize_, izm_, true, false);
                bool? izo_ = izn_?.lowClosed;
                Date izq_ = gzr_?.BirthDateElement;
                string izr_ = izq_?.Value;
                CqlDate izs_ = context.Operators.ConvertStringToDate(izr_);
                CqlDate izu_ = context.Operators.Add(izs_, gzv_ as CqlQuantity);
                Date izw_ = gzr_?.BirthDateElement;
                string izx_ = izw_?.Value;
                CqlDate izy_ = context.Operators.ConvertStringToDate(izx_);
                CqlDate jza_ = context.Operators.Add(izy_, hzb_ as CqlQuantity);
                CqlDate jzc_ = context.Operators.Add(jza_, hzd_);
                CqlInterval<CqlDate> jzd_ = context.Operators.Interval(izu_, jzc_, true, false);
                bool? jze_ = jzd_?.highClosed;
                CqlInterval<CqlDateTime> jzf_ = context.Operators.Interval(hzh_, hzy_, izo_, jze_);

                return jzf_;
            }
            else if (choice is Timing)
            {
                object jzg_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return jzg_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ezi_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzh_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jzi_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jzi_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzj_ = this.Patient(context);
                Date jzk_ = jzj_?.BirthDateElement;
                string jzl_ = jzk_?.Value;
                CqlDate jzm_ = context.Operators.ConvertStringToDate(jzl_);
                CqlDate jzn_ = context.Operators.Add(jzm_, choice as CqlQuantity);
                Date jzp_ = jzj_?.BirthDateElement;
                string jzq_ = jzp_?.Value;
                CqlDate jzr_ = context.Operators.ConvertStringToDate(jzq_);
                CqlDate jzs_ = context.Operators.Add(jzr_, choice as CqlQuantity);
                CqlQuantity jzt_ = context.Operators.Quantity(1m, "year");
                CqlDate jzu_ = context.Operators.Add(jzs_, jzt_);
                CqlInterval<CqlDate> jzv_ = context.Operators.Interval(jzn_, jzu_, true, false);
                CqlDate jzw_ = jzv_?.low;
                CqlDateTime jzx_ = context.Operators.ConvertDateToDateTime(jzw_);
                Date jzz_ = jzj_?.BirthDateElement;
                string kza_ = jzz_?.Value;
                CqlDate kzb_ = context.Operators.ConvertStringToDate(kza_);
                CqlDate kzc_ = context.Operators.Add(kzb_, choice as CqlQuantity);
                Date kze_ = jzj_?.BirthDateElement;
                string kzf_ = kze_?.Value;
                CqlDate kzg_ = context.Operators.ConvertStringToDate(kzf_);
                CqlDate kzh_ = context.Operators.Add(kzg_, choice as CqlQuantity);
                CqlDate kzj_ = context.Operators.Add(kzh_, jzt_);
                CqlInterval<CqlDate> kzk_ = context.Operators.Interval(kzc_, kzj_, true, false);
                CqlDate kzl_ = kzk_?.high;
                CqlDateTime kzm_ = context.Operators.ConvertDateToDateTime(kzl_);
                Date kzo_ = jzj_?.BirthDateElement;
                string kzp_ = kzo_?.Value;
                CqlDate kzq_ = context.Operators.ConvertStringToDate(kzp_);
                CqlDate kzr_ = context.Operators.Add(kzq_, choice as CqlQuantity);
                Date kzt_ = jzj_?.BirthDateElement;
                string kzu_ = kzt_?.Value;
                CqlDate kzv_ = context.Operators.ConvertStringToDate(kzu_);
                CqlDate kzw_ = context.Operators.Add(kzv_, choice as CqlQuantity);
                CqlDate kzy_ = context.Operators.Add(kzw_, jzt_);
                CqlInterval<CqlDate> kzz_ = context.Operators.Interval(kzr_, kzy_, true, false);
                bool? lza_ = kzz_?.lowClosed;
                Date lzc_ = jzj_?.BirthDateElement;
                string lzd_ = lzc_?.Value;
                CqlDate lze_ = context.Operators.ConvertStringToDate(lzd_);
                CqlDate lzf_ = context.Operators.Add(lze_, choice as CqlQuantity);
                Date lzh_ = jzj_?.BirthDateElement;
                string lzi_ = lzh_?.Value;
                CqlDate lzj_ = context.Operators.ConvertStringToDate(lzi_);
                CqlDate lzk_ = context.Operators.Add(lzj_, choice as CqlQuantity);
                CqlDate lzm_ = context.Operators.Add(lzk_, jzt_);
                CqlInterval<CqlDate> lzn_ = context.Operators.Interval(lzf_, lzm_, true, false);
                bool? lzo_ = lzn_?.highClosed;
                CqlInterval<CqlDateTime> lzp_ = context.Operators.Interval(jzx_, kzm_, lza_, lzo_);

                return lzp_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzq_ = this.Patient(context);
                Date lzr_ = lzq_?.BirthDateElement;
                string lzs_ = lzr_?.Value;
                CqlDate lzt_ = context.Operators.ConvertStringToDate(lzs_);
                object lzu_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzv_ = context.Operators.Add(lzt_, lzu_ as CqlQuantity);
                Date lzx_ = lzq_?.BirthDateElement;
                string lzy_ = lzx_?.Value;
                CqlDate lzz_ = context.Operators.ConvertStringToDate(lzy_);
                object mza_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate mzb_ = context.Operators.Add(lzz_, mza_ as CqlQuantity);
                CqlQuantity mzc_ = context.Operators.Quantity(1m, "year");
                CqlDate mzd_ = context.Operators.Add(mzb_, mzc_);
                CqlInterval<CqlDate> mze_ = context.Operators.Interval(lzv_, mzd_, true, false);
                CqlDate mzf_ = mze_?.low;
                CqlDateTime mzg_ = context.Operators.ConvertDateToDateTime(mzf_);
                Date mzi_ = lzq_?.BirthDateElement;
                string mzj_ = mzi_?.Value;
                CqlDate mzk_ = context.Operators.ConvertStringToDate(mzj_);
                CqlDate mzm_ = context.Operators.Add(mzk_, lzu_ as CqlQuantity);
                Date mzo_ = lzq_?.BirthDateElement;
                string mzp_ = mzo_?.Value;
                CqlDate mzq_ = context.Operators.ConvertStringToDate(mzp_);
                CqlDate mzs_ = context.Operators.Add(mzq_, mza_ as CqlQuantity);
                CqlDate mzu_ = context.Operators.Add(mzs_, mzc_);
                CqlInterval<CqlDate> mzv_ = context.Operators.Interval(mzm_, mzu_, true, false);
                CqlDate mzw_ = mzv_?.high;
                CqlDateTime mzx_ = context.Operators.ConvertDateToDateTime(mzw_);
                Date mzz_ = lzq_?.BirthDateElement;
                string nza_ = mzz_?.Value;
                CqlDate nzb_ = context.Operators.ConvertStringToDate(nza_);
                CqlDate nzd_ = context.Operators.Add(nzb_, lzu_ as CqlQuantity);
                Date nzf_ = lzq_?.BirthDateElement;
                string nzg_ = nzf_?.Value;
                CqlDate nzh_ = context.Operators.ConvertStringToDate(nzg_);
                CqlDate nzj_ = context.Operators.Add(nzh_, mza_ as CqlQuantity);
                CqlDate nzl_ = context.Operators.Add(nzj_, mzc_);
                CqlInterval<CqlDate> nzm_ = context.Operators.Interval(nzd_, nzl_, true, false);
                bool? nzn_ = nzm_?.lowClosed;
                Date nzp_ = lzq_?.BirthDateElement;
                string nzq_ = nzp_?.Value;
                CqlDate nzr_ = context.Operators.ConvertStringToDate(nzq_);
                CqlDate nzt_ = context.Operators.Add(nzr_, lzu_ as CqlQuantity);
                Date nzv_ = lzq_?.BirthDateElement;
                string nzw_ = nzv_?.Value;
                CqlDate nzx_ = context.Operators.ConvertStringToDate(nzw_);
                CqlDate nzz_ = context.Operators.Add(nzx_, mza_ as CqlQuantity);
                CqlDate ozb_ = context.Operators.Add(nzz_, mzc_);
                CqlInterval<CqlDate> ozc_ = context.Operators.Interval(nzt_, ozb_, true, false);
                bool? ozd_ = ozc_?.highClosed;
                CqlInterval<CqlDateTime> oze_ = context.Operators.Interval(mzg_, mzx_, nzn_, ozd_);

                return oze_;
            }
            else if (choice is Timing)
            {
                object ozf_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return ozf_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzh_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ozg_()
        {
            bool ozh_()
            {
                DataType ozl_ = condition?.Abatement;
                object ozm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozl_);
                bool ozn_ = ozm_ is CqlDateTime;

                return ozn_;
            };
            bool ozi_()
            {
                DataType ozo_ = condition?.Abatement;
                object ozp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozo_);
                bool ozq_ = ozp_ is CqlQuantity;

                return ozq_;
            };
            bool ozj_()
            {
                DataType ozr_ = condition?.Abatement;
                object ozs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozr_);
                bool ozt_ = ozs_ is CqlInterval<CqlQuantity>;

                return ozt_;
            };
            bool ozk_()
            {
                DataType ozu_ = condition?.Abatement;
                object ozv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozu_);
                bool ozw_ = ozv_ is CqlInterval<CqlDateTime>;

                return ozw_;
            };
            if (ozh_())
            {
                DataType ozx_ = condition?.Abatement;
                object ozy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozx_);
                object pza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozx_);
                CqlInterval<CqlDateTime> pzb_ = context.Operators.Interval(ozy_ as CqlDateTime, pza_ as CqlDateTime, true, true);

                return pzb_;
            }
            else if (ozi_())
            {
                Patient pzc_ = this.Patient(context);
                Date pzd_ = pzc_?.BirthDateElement;
                string pze_ = pzd_?.Value;
                CqlDate pzf_ = context.Operators.ConvertStringToDate(pze_);
                DataType pzg_ = condition?.Abatement;
                object pzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate pzi_ = context.Operators.Add(pzf_, pzh_ as CqlQuantity);
                Date pzk_ = pzc_?.BirthDateElement;
                string pzl_ = pzk_?.Value;
                CqlDate pzm_ = context.Operators.ConvertStringToDate(pzl_);
                object pzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate pzp_ = context.Operators.Add(pzm_, pzo_ as CqlQuantity);
                CqlQuantity pzq_ = context.Operators.Quantity(1m, "year");
                CqlDate pzr_ = context.Operators.Add(pzp_, pzq_);
                CqlInterval<CqlDate> pzs_ = context.Operators.Interval(pzi_, pzr_, true, false);
                CqlDate pzt_ = pzs_?.low;
                CqlDateTime pzu_ = context.Operators.ConvertDateToDateTime(pzt_);
                Date pzw_ = pzc_?.BirthDateElement;
                string pzx_ = pzw_?.Value;
                CqlDate pzy_ = context.Operators.ConvertStringToDate(pzx_);
                object qza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate qzb_ = context.Operators.Add(pzy_, qza_ as CqlQuantity);
                Date qzd_ = pzc_?.BirthDateElement;
                string qze_ = qzd_?.Value;
                CqlDate qzf_ = context.Operators.ConvertStringToDate(qze_);
                object qzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate qzi_ = context.Operators.Add(qzf_, qzh_ as CqlQuantity);
                CqlDate qzk_ = context.Operators.Add(qzi_, pzq_);
                CqlInterval<CqlDate> qzl_ = context.Operators.Interval(qzb_, qzk_, true, false);
                CqlDate qzm_ = qzl_?.high;
                CqlDateTime qzn_ = context.Operators.ConvertDateToDateTime(qzm_);
                Date qzp_ = pzc_?.BirthDateElement;
                string qzq_ = qzp_?.Value;
                CqlDate qzr_ = context.Operators.ConvertStringToDate(qzq_);
                object qzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate qzu_ = context.Operators.Add(qzr_, qzt_ as CqlQuantity);
                Date qzw_ = pzc_?.BirthDateElement;
                string qzx_ = qzw_?.Value;
                CqlDate qzy_ = context.Operators.ConvertStringToDate(qzx_);
                object rza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate rzb_ = context.Operators.Add(qzy_, rza_ as CqlQuantity);
                CqlDate rzd_ = context.Operators.Add(rzb_, pzq_);
                CqlInterval<CqlDate> rze_ = context.Operators.Interval(qzu_, rzd_, true, false);
                bool? rzf_ = rze_?.lowClosed;
                Date rzh_ = pzc_?.BirthDateElement;
                string rzi_ = rzh_?.Value;
                CqlDate rzj_ = context.Operators.ConvertStringToDate(rzi_);
                object rzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate rzm_ = context.Operators.Add(rzj_, rzl_ as CqlQuantity);
                Date rzo_ = pzc_?.BirthDateElement;
                string rzp_ = rzo_?.Value;
                CqlDate rzq_ = context.Operators.ConvertStringToDate(rzp_);
                object rzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzg_);
                CqlDate rzt_ = context.Operators.Add(rzq_, rzs_ as CqlQuantity);
                CqlDate rzv_ = context.Operators.Add(rzt_, pzq_);
                CqlInterval<CqlDate> rzw_ = context.Operators.Interval(rzm_, rzv_, true, false);
                bool? rzx_ = rzw_?.highClosed;
                CqlInterval<CqlDateTime> rzy_ = context.Operators.Interval(pzu_, qzn_, rzf_, rzx_);

                return rzy_;
            }
            else if (ozj_())
            {
                Patient rzz_ = this.Patient(context);
                Date sza_ = rzz_?.BirthDateElement;
                string szb_ = sza_?.Value;
                CqlDate szc_ = context.Operators.ConvertStringToDate(szb_);
                DataType szd_ = condition?.Abatement;
                object sze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object szf_ = context.Operators.LateBoundProperty<object>(sze_, "low");
                CqlDate szg_ = context.Operators.Add(szc_, szf_ as CqlQuantity);
                Date szi_ = rzz_?.BirthDateElement;
                string szj_ = szi_?.Value;
                CqlDate szk_ = context.Operators.ConvertStringToDate(szj_);
                object szm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object szn_ = context.Operators.LateBoundProperty<object>(szm_, "high");
                CqlDate szo_ = context.Operators.Add(szk_, szn_ as CqlQuantity);
                CqlQuantity szp_ = context.Operators.Quantity(1m, "year");
                CqlDate szq_ = context.Operators.Add(szo_, szp_);
                CqlInterval<CqlDate> szr_ = context.Operators.Interval(szg_, szq_, true, false);
                CqlDate szs_ = szr_?.low;
                CqlDateTime szt_ = context.Operators.ConvertDateToDateTime(szs_);
                Date szv_ = rzz_?.BirthDateElement;
                string szw_ = szv_?.Value;
                CqlDate szx_ = context.Operators.ConvertStringToDate(szw_);
                object szz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object tza_ = context.Operators.LateBoundProperty<object>(szz_, "low");
                CqlDate tzb_ = context.Operators.Add(szx_, tza_ as CqlQuantity);
                Date tzd_ = rzz_?.BirthDateElement;
                string tze_ = tzd_?.Value;
                CqlDate tzf_ = context.Operators.ConvertStringToDate(tze_);
                object tzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object tzi_ = context.Operators.LateBoundProperty<object>(tzh_, "high");
                CqlDate tzj_ = context.Operators.Add(tzf_, tzi_ as CqlQuantity);
                CqlDate tzl_ = context.Operators.Add(tzj_, szp_);
                CqlInterval<CqlDate> tzm_ = context.Operators.Interval(tzb_, tzl_, true, false);
                CqlDate tzn_ = tzm_?.high;
                CqlDateTime tzo_ = context.Operators.ConvertDateToDateTime(tzn_);
                Date tzq_ = rzz_?.BirthDateElement;
                string tzr_ = tzq_?.Value;
                CqlDate tzs_ = context.Operators.ConvertStringToDate(tzr_);
                object tzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object tzv_ = context.Operators.LateBoundProperty<object>(tzu_, "low");
                CqlDate tzw_ = context.Operators.Add(tzs_, tzv_ as CqlQuantity);
                Date tzy_ = rzz_?.BirthDateElement;
                string tzz_ = tzy_?.Value;
                CqlDate uza_ = context.Operators.ConvertStringToDate(tzz_);
                object uzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object uzd_ = context.Operators.LateBoundProperty<object>(uzc_, "high");
                CqlDate uze_ = context.Operators.Add(uza_, uzd_ as CqlQuantity);
                CqlDate uzg_ = context.Operators.Add(uze_, szp_);
                CqlInterval<CqlDate> uzh_ = context.Operators.Interval(tzw_, uzg_, true, false);
                bool? uzi_ = uzh_?.lowClosed;
                Date uzk_ = rzz_?.BirthDateElement;
                string uzl_ = uzk_?.Value;
                CqlDate uzm_ = context.Operators.ConvertStringToDate(uzl_);
                object uzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object uzp_ = context.Operators.LateBoundProperty<object>(uzo_, "low");
                CqlDate uzq_ = context.Operators.Add(uzm_, uzp_ as CqlQuantity);
                Date uzs_ = rzz_?.BirthDateElement;
                string uzt_ = uzs_?.Value;
                CqlDate uzu_ = context.Operators.ConvertStringToDate(uzt_);
                object uzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szd_);
                object uzx_ = context.Operators.LateBoundProperty<object>(uzw_, "high");
                CqlDate uzy_ = context.Operators.Add(uzu_, uzx_ as CqlQuantity);
                CqlDate vza_ = context.Operators.Add(uzy_, szp_);
                CqlInterval<CqlDate> vzb_ = context.Operators.Interval(uzq_, vza_, true, false);
                bool? vzc_ = vzb_?.highClosed;
                CqlInterval<CqlDateTime> vzd_ = context.Operators.Interval(szt_, tzo_, uzi_, vzc_);

                return vzd_;
            }
            else if (ozk_())
            {
                DataType vze_ = condition?.Abatement;
                object vzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vze_);
                object vzg_ = context.Operators.LateBoundProperty<object>(vzf_, "low");
                object vzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vze_);
                object vzj_ = context.Operators.LateBoundProperty<object>(vzi_, "high");
                CqlInterval<CqlDateTime> vzk_ = context.Operators.Interval(vzg_ as CqlDateTime, vzj_ as CqlDateTime, true, false);

                return vzk_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ozg_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vzl_()
        {
            bool vzm_()
            {
                DataType vzq_ = condition?.Abatement;
                object vzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzq_);
                bool vzs_ = vzr_ is CqlDateTime;

                return vzs_;
            };
            bool vzn_()
            {
                DataType vzt_ = condition?.Abatement;
                object vzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzt_);
                bool vzv_ = vzu_ is CqlQuantity;

                return vzv_;
            };
            bool vzo_()
            {
                DataType vzw_ = condition?.Abatement;
                object vzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzw_);
                bool vzy_ = vzx_ is CqlInterval<CqlQuantity>;

                return vzy_;
            };
            bool vzp_()
            {
                DataType vzz_ = condition?.Abatement;
                object wza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzz_);
                bool wzb_ = wza_ is CqlInterval<CqlDateTime>;

                return wzb_;
            };
            if (vzm_())
            {
                DataType wzc_ = condition?.Abatement;
                object wzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzc_);
                object wzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzc_);
                CqlInterval<CqlDateTime> wzg_ = context.Operators.Interval(wzd_ as CqlDateTime, wzf_ as CqlDateTime, true, true);

                return wzg_;
            }
            else if (vzn_())
            {
                Patient wzh_ = this.Patient(context);
                Date wzi_ = wzh_?.BirthDateElement;
                string wzj_ = wzi_?.Value;
                CqlDate wzk_ = context.Operators.ConvertStringToDate(wzj_);
                DataType wzl_ = condition?.Abatement;
                object wzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate wzn_ = context.Operators.Add(wzk_, wzm_ as CqlQuantity);
                Date wzp_ = wzh_?.BirthDateElement;
                string wzq_ = wzp_?.Value;
                CqlDate wzr_ = context.Operators.ConvertStringToDate(wzq_);
                object wzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate wzu_ = context.Operators.Add(wzr_, wzt_ as CqlQuantity);
                CqlQuantity wzv_ = context.Operators.Quantity(1m, "year");
                CqlDate wzw_ = context.Operators.Add(wzu_, wzv_);
                CqlInterval<CqlDate> wzx_ = context.Operators.Interval(wzn_, wzw_, true, false);
                CqlDate wzy_ = wzx_?.low;
                CqlDateTime wzz_ = context.Operators.ConvertDateToDateTime(wzy_);
                Date xzb_ = wzh_?.BirthDateElement;
                string xzc_ = xzb_?.Value;
                CqlDate xzd_ = context.Operators.ConvertStringToDate(xzc_);
                object xzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate xzg_ = context.Operators.Add(xzd_, xzf_ as CqlQuantity);
                Date xzi_ = wzh_?.BirthDateElement;
                string xzj_ = xzi_?.Value;
                CqlDate xzk_ = context.Operators.ConvertStringToDate(xzj_);
                object xzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate xzn_ = context.Operators.Add(xzk_, xzm_ as CqlQuantity);
                CqlDate xzp_ = context.Operators.Add(xzn_, wzv_);
                CqlInterval<CqlDate> xzq_ = context.Operators.Interval(xzg_, xzp_, true, false);
                CqlDate xzr_ = xzq_?.high;
                CqlDateTime xzs_ = context.Operators.ConvertDateToDateTime(xzr_);
                Date xzu_ = wzh_?.BirthDateElement;
                string xzv_ = xzu_?.Value;
                CqlDate xzw_ = context.Operators.ConvertStringToDate(xzv_);
                object xzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate xzz_ = context.Operators.Add(xzw_, xzy_ as CqlQuantity);
                Date yzb_ = wzh_?.BirthDateElement;
                string yzc_ = yzb_?.Value;
                CqlDate yzd_ = context.Operators.ConvertStringToDate(yzc_);
                object yzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate yzg_ = context.Operators.Add(yzd_, yzf_ as CqlQuantity);
                CqlDate yzi_ = context.Operators.Add(yzg_, wzv_);
                CqlInterval<CqlDate> yzj_ = context.Operators.Interval(xzz_, yzi_, true, false);
                bool? yzk_ = yzj_?.lowClosed;
                Date yzm_ = wzh_?.BirthDateElement;
                string yzn_ = yzm_?.Value;
                CqlDate yzo_ = context.Operators.ConvertStringToDate(yzn_);
                object yzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate yzr_ = context.Operators.Add(yzo_, yzq_ as CqlQuantity);
                Date yzt_ = wzh_?.BirthDateElement;
                string yzu_ = yzt_?.Value;
                CqlDate yzv_ = context.Operators.ConvertStringToDate(yzu_);
                object yzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzl_);
                CqlDate yzy_ = context.Operators.Add(yzv_, yzx_ as CqlQuantity);
                CqlDate zza_ = context.Operators.Add(yzy_, wzv_);
                CqlInterval<CqlDate> zzb_ = context.Operators.Interval(yzr_, zza_, true, false);
                bool? zzc_ = zzb_?.highClosed;
                CqlInterval<CqlDateTime> zzd_ = context.Operators.Interval(wzz_, xzs_, yzk_, zzc_);

                return zzd_;
            }
            else if (vzo_())
            {
                Patient zze_ = this.Patient(context);
                Date zzf_ = zze_?.BirthDateElement;
                string zzg_ = zzf_?.Value;
                CqlDate zzh_ = context.Operators.ConvertStringToDate(zzg_);
                DataType zzi_ = condition?.Abatement;
                object zzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object zzk_ = context.Operators.LateBoundProperty<object>(zzj_, "low");
                CqlDate zzl_ = context.Operators.Add(zzh_, zzk_ as CqlQuantity);
                Date zzn_ = zze_?.BirthDateElement;
                string zzo_ = zzn_?.Value;
                CqlDate zzp_ = context.Operators.ConvertStringToDate(zzo_);
                object zzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object zzs_ = context.Operators.LateBoundProperty<object>(zzr_, "high");
                CqlDate zzt_ = context.Operators.Add(zzp_, zzs_ as CqlQuantity);
                CqlQuantity zzu_ = context.Operators.Quantity(1m, "year");
                CqlDate zzv_ = context.Operators.Add(zzt_, zzu_);
                CqlInterval<CqlDate> zzw_ = context.Operators.Interval(zzl_, zzv_, true, false);
                CqlDate zzx_ = zzw_?.low;
                CqlDateTime zzy_ = context.Operators.ConvertDateToDateTime(zzx_);
                Date azza_ = zze_?.BirthDateElement;
                string azzb_ = azza_?.Value;
                CqlDate azzc_ = context.Operators.ConvertStringToDate(azzb_);
                object azze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object azzf_ = context.Operators.LateBoundProperty<object>(azze_, "low");
                CqlDate azzg_ = context.Operators.Add(azzc_, azzf_ as CqlQuantity);
                Date azzi_ = zze_?.BirthDateElement;
                string azzj_ = azzi_?.Value;
                CqlDate azzk_ = context.Operators.ConvertStringToDate(azzj_);
                object azzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object azzn_ = context.Operators.LateBoundProperty<object>(azzm_, "high");
                CqlDate azzo_ = context.Operators.Add(azzk_, azzn_ as CqlQuantity);
                CqlDate azzq_ = context.Operators.Add(azzo_, zzu_);
                CqlInterval<CqlDate> azzr_ = context.Operators.Interval(azzg_, azzq_, true, false);
                CqlDate azzs_ = azzr_?.high;
                CqlDateTime azzt_ = context.Operators.ConvertDateToDateTime(azzs_);
                Date azzv_ = zze_?.BirthDateElement;
                string azzw_ = azzv_?.Value;
                CqlDate azzx_ = context.Operators.ConvertStringToDate(azzw_);
                object azzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object bzza_ = context.Operators.LateBoundProperty<object>(azzz_, "low");
                CqlDate bzzb_ = context.Operators.Add(azzx_, bzza_ as CqlQuantity);
                Date bzzd_ = zze_?.BirthDateElement;
                string bzze_ = bzzd_?.Value;
                CqlDate bzzf_ = context.Operators.ConvertStringToDate(bzze_);
                object bzzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object bzzi_ = context.Operators.LateBoundProperty<object>(bzzh_, "high");
                CqlDate bzzj_ = context.Operators.Add(bzzf_, bzzi_ as CqlQuantity);
                CqlDate bzzl_ = context.Operators.Add(bzzj_, zzu_);
                CqlInterval<CqlDate> bzzm_ = context.Operators.Interval(bzzb_, bzzl_, true, false);
                bool? bzzn_ = bzzm_?.lowClosed;
                Date bzzp_ = zze_?.BirthDateElement;
                string bzzq_ = bzzp_?.Value;
                CqlDate bzzr_ = context.Operators.ConvertStringToDate(bzzq_);
                object bzzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object bzzu_ = context.Operators.LateBoundProperty<object>(bzzt_, "low");
                CqlDate bzzv_ = context.Operators.Add(bzzr_, bzzu_ as CqlQuantity);
                Date bzzx_ = zze_?.BirthDateElement;
                string bzzy_ = bzzx_?.Value;
                CqlDate bzzz_ = context.Operators.ConvertStringToDate(bzzy_);
                object czzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzi_);
                object czzc_ = context.Operators.LateBoundProperty<object>(czzb_, "high");
                CqlDate czzd_ = context.Operators.Add(bzzz_, czzc_ as CqlQuantity);
                CqlDate czzf_ = context.Operators.Add(czzd_, zzu_);
                CqlInterval<CqlDate> czzg_ = context.Operators.Interval(bzzv_, czzf_, true, false);
                bool? czzh_ = czzg_?.highClosed;
                CqlInterval<CqlDateTime> czzi_ = context.Operators.Interval(zzy_, azzt_, bzzn_, czzh_);

                return czzi_;
            }
            else if (vzp_())
            {
                DataType czzj_ = condition?.Abatement;
                object czzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzj_);
                object czzl_ = context.Operators.LateBoundProperty<object>(czzk_, "low");
                object czzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzj_);
                object czzo_ = context.Operators.LateBoundProperty<object>(czzn_, "high");
                CqlInterval<CqlDateTime> czzp_ = context.Operators.Interval(czzl_ as CqlDateTime, czzo_ as CqlDateTime, true, false);

                return czzp_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vzl_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzq_()
        {
            bool czzr_()
            {
                CodeableConcept czzs_ = condition?.ClinicalStatus;
                CqlConcept czzt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzs_);
                CqlCode czzu_ = this.active(context);
                CqlConcept czzv_ = context.Operators.ConvertCodeToConcept(czzu_);
                bool? czzw_ = context.Operators.Equivalent(czzt_, czzv_);
                CqlConcept czzy_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzs_);
                CqlCode czzz_ = this.recurrence(context);
                CqlConcept dzza_ = context.Operators.ConvertCodeToConcept(czzz_);
                bool? dzzb_ = context.Operators.Equivalent(czzy_, dzza_);
                bool? dzzc_ = context.Operators.Or(czzw_, dzzb_);
                CqlConcept dzze_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzs_);
                CqlCode dzzf_ = this.relapse(context);
                CqlConcept dzzg_ = context.Operators.ConvertCodeToConcept(dzzf_);
                bool? dzzh_ = context.Operators.Equivalent(dzze_, dzzg_);
                bool? dzzi_ = context.Operators.Or(dzzc_, dzzh_);

                return dzzi_ ?? false;
            };
            if (czzr_())
            {
                DataType dzzj_ = condition?.Onset;
                object dzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzj_);
                CqlInterval<CqlDateTime> dzzl_ = this.ToInterval(context, dzzk_);
                CqlDateTime dzzm_ = context.Operators.Start(dzzl_);
                CqlInterval<CqlDateTime> dzzn_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzo_ = context.Operators.End(dzzn_);
                CqlInterval<CqlDateTime> dzzp_ = context.Operators.Interval(dzzm_, dzzo_, true, true);

                return dzzp_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzq_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzr_ = context.Operators.End(dzzq_);
                CqlDateTime[] dzzs_ = [
                    dzzr_,
                ];
                CqlInterval<CqlDateTime> dzzt_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> dzzx_()
                    {
                        if (abatementDate is null)
                        {
                            DataType dzzy_ = condition?.Onset;
                            object dzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzy_);
                            CqlInterval<CqlDateTime> ezza_ = this.ToInterval(context, dzzz_);
                            CqlDateTime ezzb_ = context.Operators.Start(ezza_);
                            CqlInterval<CqlDateTime> ezzc_ = context.Operators.Interval(ezzb_, abatementDate, true, false);

                            return ezzc_;
                        }
                        else
                        {
                            DataType ezzd_ = condition?.Onset;
                            object ezze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzd_);
                            CqlInterval<CqlDateTime> ezzf_ = this.ToInterval(context, ezze_);
                            CqlDateTime ezzg_ = context.Operators.Start(ezzf_);
                            CqlInterval<CqlDateTime> ezzh_ = context.Operators.Interval(ezzg_, abatementDate, true, true);

                            return ezzh_;
                        }
                    };

                    return dzzx_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzu_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)dzzs_, dzzt_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzu_);
                CqlInterval<CqlDateTime> dzzw_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzv_);

                return dzzw_;
            }
        };

        return czzq_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ezzi_()
        {
            bool ezzj_()
            {
                CodeableConcept ezzk_ = condition?.ClinicalStatus;
                CqlConcept ezzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzk_);
                CqlCode ezzm_ = this.active(context);
                CqlConcept ezzn_ = context.Operators.ConvertCodeToConcept(ezzm_);
                bool? ezzo_ = context.Operators.Equivalent(ezzl_, ezzn_);
                CqlConcept ezzq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzk_);
                CqlCode ezzr_ = this.recurrence(context);
                CqlConcept ezzs_ = context.Operators.ConvertCodeToConcept(ezzr_);
                bool? ezzt_ = context.Operators.Equivalent(ezzq_, ezzs_);
                bool? ezzu_ = context.Operators.Or(ezzo_, ezzt_);
                CqlConcept ezzw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzk_);
                CqlCode ezzx_ = this.relapse(context);
                CqlConcept ezzy_ = context.Operators.ConvertCodeToConcept(ezzx_);
                bool? ezzz_ = context.Operators.Equivalent(ezzw_, ezzy_);
                bool? fzza_ = context.Operators.Or(ezzu_, ezzz_);

                return fzza_ ?? false;
            };
            if (ezzj_())
            {
                DataType fzzb_ = condition?.Onset;
                object fzzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzb_);
                CqlInterval<CqlDateTime> fzzd_ = this.toInterval(context, fzzc_);
                CqlDateTime fzze_ = context.Operators.Start(fzzd_);
                CqlInterval<CqlDateTime> fzzf_ = this.abatementInterval(context, condition);
                CqlDateTime fzzg_ = context.Operators.End(fzzf_);
                CqlInterval<CqlDateTime> fzzh_ = context.Operators.Interval(fzze_, fzzg_, true, true);

                return fzzh_;
            }
            else
            {
                CqlInterval<CqlDateTime> fzzi_ = this.ToAbatementInterval(context, condition);
                CqlDateTime fzzj_ = context.Operators.End(fzzi_);
                CqlDateTime[] fzzk_ = [
                    fzzj_,
                ];
                CqlInterval<CqlDateTime> fzzl_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzp_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzq_ = condition?.Onset;
                            object fzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzq_);
                            CqlInterval<CqlDateTime> fzzs_ = this.ToInterval(context, fzzr_);
                            CqlDateTime fzzt_ = context.Operators.Start(fzzs_);
                            CqlInterval<CqlDateTime> fzzu_ = context.Operators.Interval(fzzt_, abatementDate, true, false);

                            return fzzu_;
                        }
                        else
                        {
                            DataType fzzv_ = condition?.Onset;
                            object fzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzv_);
                            CqlInterval<CqlDateTime> fzzx_ = this.ToInterval(context, fzzw_);
                            CqlDateTime fzzy_ = context.Operators.Start(fzzx_);
                            CqlInterval<CqlDateTime> fzzz_ = context.Operators.Interval(fzzy_, abatementDate, true, true);

                            return fzzz_;
                        }
                    };

                    return fzzp_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzm_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzk_, fzzl_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzm_);
                CqlInterval<CqlDateTime> fzzo_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzn_);

                return fzzo_;
            }
        };

        return ezzi_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> gzza_ = context.Operators.Split(uri, "/");
        string gzzb_ = context.Operators.Last<string>(gzza_);

        return gzzb_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzc_ = context.Operators.Split(uri, "/");
        string gzzd_ = context.Operators.Last<string>(gzzc_);

        return gzzd_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzze_ = context.Operators.Start(period);
        CqlDateTime gzzg_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzh_ = context.Operators.Equal(gzze_, gzzg_);
        bool? gzzi_ = context.Operators.Or((bool?)(gzze_ is null), gzzh_);
        bool? gzzj_ = context.Operators.Not(gzzi_);

        return gzzj_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzk_ = context.Operators.Start(period);
        CqlDateTime gzzm_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzn_ = context.Operators.Equal(gzzk_, gzzm_);
        bool? gzzo_ = context.Operators.Or((bool?)(gzzk_ is null), gzzn_);
        bool? gzzp_ = context.Operators.Not(gzzo_);

        return gzzp_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzq_ = context.Operators.End(period);
        CqlDateTime gzzs_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzt_ = context.Operators.Equal(gzzq_, gzzs_);
        bool? gzzu_ = context.Operators.Or((bool?)(gzzq_ is null), gzzt_);
        bool? gzzv_ = context.Operators.Not(gzzu_);

        return gzzv_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzw_ = context.Operators.End(period);
        CqlDateTime gzzy_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzz_ = context.Operators.Equal(gzzw_, gzzy_);
        bool? hzza_ = context.Operators.Or((bool?)(gzzw_ is null), gzzz_);
        bool? hzzb_ = context.Operators.Not(hzza_);

        return hzzb_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzc_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzd_ = [
            hzzc_,
        ];
        CqlDateTime hzze_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzi_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzj_ = context.Operators.End(period);

                    return hzzj_;
                }
                else
                {
                    CqlDateTime hzzk_ = context.Operators.Start(period);

                    return hzzk_;
                }
            };

            return hzzi_();
        };
        IEnumerable<CqlDateTime> hzzf_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzd_, hzze_);
        IEnumerable<CqlDateTime> hzzg_ = context.Operators.Distinct<CqlDateTime>(hzzf_);
        CqlDateTime hzzh_ = context.Operators.SingletonFrom<CqlDateTime>(hzzg_);

        return hzzh_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzl_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzm_ = [
            hzzl_,
        ];
        CqlDateTime hzzn_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzr_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzs_ = context.Operators.End(period);

                    return hzzs_;
                }
                else
                {
                    CqlDateTime hzzt_ = context.Operators.Start(period);

                    return hzzt_;
                }
            };

            return hzzr_();
        };
        IEnumerable<CqlDateTime> hzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzm_, hzzn_);
        IEnumerable<CqlDateTime> hzzp_ = context.Operators.Distinct<CqlDateTime>(hzzo_);
        CqlDateTime hzzq_ = context.Operators.SingletonFrom<CqlDateTime>(hzzp_);

        return hzzq_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzu_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzv_ = [
            hzzu_,
        ];
        CqlDateTime hzzw_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izza_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime izzb_ = context.Operators.Start(period);

                    return izzb_;
                }
                else
                {
                    CqlDateTime izzc_ = context.Operators.End(period);

                    return izzc_;
                }
            };

            return izza_();
        };
        IEnumerable<CqlDateTime> hzzx_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzv_, hzzw_);
        IEnumerable<CqlDateTime> hzzy_ = context.Operators.Distinct<CqlDateTime>(hzzx_);
        CqlDateTime hzzz_ = context.Operators.SingletonFrom<CqlDateTime>(hzzy_);

        return hzzz_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izzd_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] izze_ = [
            izzd_,
        ];
        CqlDateTime izzf_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzj_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime izzk_ = context.Operators.Start(period);

                    return izzk_;
                }
                else
                {
                    CqlDateTime izzl_ = context.Operators.End(period);

                    return izzl_;
                }
            };

            return izzj_();
        };
        IEnumerable<CqlDateTime> izzg_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)izze_, izzf_);
        IEnumerable<CqlDateTime> izzh_ = context.Operators.Distinct<CqlDateTime>(izzg_);
        CqlDateTime izzi_ = context.Operators.SingletonFrom<CqlDateTime>(izzh_);

        return izzi_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzm_ = context.Operators.Start(Period);
        CqlDateTime izzn_ = context.Operators.End(Period);
        int? izzo_ = context.Operators.DurationBetween(izzm_, izzn_, "day");
        CqlInterval<int?> izzp_ = context.Operators.Interval(1, izzo_, true, true);
        CqlInterval<int?>[] izzq_ = [
            izzp_,
        ];
        IEnumerable<CqlInterval<int?>> izzr_ = context.Operators.Expand(izzq_ as IEnumerable<CqlInterval<int?>>, default);
        int? izzs_(CqlInterval<int?> DayNumber)
        {
            int? izzv_ = context.Operators.End(DayNumber);

            return izzv_;
        };
        IEnumerable<int?> izzt_ = context.Operators.Select<CqlInterval<int?>, int?>(izzr_, izzs_);
        IEnumerable<int?> izzu_ = context.Operators.Distinct<int?>(izzt_);

        return izzu_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzw_ = context.Operators.Start(Period);
        CqlDateTime izzx_ = context.Operators.End(Period);
        int? izzy_ = context.Operators.DurationBetween(izzw_, izzx_, "day");
        CqlInterval<int?> izzz_ = context.Operators.Interval(1, izzy_, true, true);
        CqlInterval<int?>[] jzza_ = [
            izzz_,
        ];
        IEnumerable<CqlInterval<int?>> jzzb_ = context.Operators.Expand(jzza_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzzc_(CqlInterval<int?> DayNumber)
        {
            int? jzzf_ = context.Operators.End(DayNumber);

            return jzzf_;
        };
        IEnumerable<int?> jzzd_ = context.Operators.Select<CqlInterval<int?>, int?>(jzzb_, jzzc_);
        IEnumerable<int?> jzze_ = context.Operators.Distinct<int?>(jzzd_);

        return jzze_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> jzzg_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzh_(int? DayIndex)
        {
            CqlDateTime jzzk_ = context.Operators.Start(Period);
            CqlQuantity jzzl_ = context.Operators.Quantity(24m, "hours");
            int? jzzm_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzzn_ = context.Operators.ConvertIntegerToQuantity(jzzm_);
            CqlQuantity jzzo_ = context.Operators.Multiply(jzzl_, jzzn_);
            CqlDateTime jzzp_ = context.Operators.Add(jzzk_, jzzo_);
            CqlDateTime jzzq_()
            {
                bool jzzt_()
                {
                    CqlDateTime jzzu_ = context.Operators.Start(Period);
                    CqlQuantity jzzv_ = context.Operators.Quantity(24m, "hours");
                    int? jzzw_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzx_ = context.Operators.ConvertIntegerToQuantity(jzzw_);
                    CqlQuantity jzzy_ = context.Operators.Multiply(jzzv_, jzzx_);
                    CqlDateTime jzzz_ = context.Operators.Add(jzzu_, jzzy_);
                    CqlDateTime kzza_ = context.Operators.End(Period);
                    int? kzzb_ = context.Operators.DurationBetween(jzzz_, kzza_, "hour");
                    bool? kzzc_ = context.Operators.Less(kzzb_, 24);

                    return kzzc_ ?? false;
                };
                if (jzzt_())
                {
                    CqlDateTime kzzd_ = context.Operators.Start(Period);
                    CqlQuantity kzze_ = context.Operators.Quantity(24m, "hours");
                    int? kzzf_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzg_ = context.Operators.ConvertIntegerToQuantity(kzzf_);
                    CqlQuantity kzzh_ = context.Operators.Multiply(kzze_, kzzg_);
                    CqlDateTime kzzi_ = context.Operators.Add(kzzd_, kzzh_);

                    return kzzi_;
                }
                else
                {
                    CqlDateTime kzzj_ = context.Operators.Start(Period);
                    CqlQuantity kzzk_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzl_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzm_ = context.Operators.Multiply(kzzk_, kzzl_);
                    CqlDateTime kzzn_ = context.Operators.Add(kzzj_, kzzm_);

                    return kzzn_;
                }
            };
            CqlInterval<CqlDateTime> jzzr_ = context.Operators.Interval(jzzp_, jzzq_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzs_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzr_);

            return jzzs_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzi_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzg_, jzzh_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzj_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzi_);

        return jzzj_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzo_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzp_(int? DayIndex)
        {
            CqlDateTime kzzs_ = context.Operators.Start(Period);
            CqlQuantity kzzt_ = context.Operators.Quantity(24m, "hours");
            int? kzzu_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity kzzv_ = context.Operators.ConvertIntegerToQuantity(kzzu_);
            CqlQuantity kzzw_ = context.Operators.Multiply(kzzt_, kzzv_);
            CqlDateTime kzzx_ = context.Operators.Add(kzzs_, kzzw_);
            CqlDateTime kzzy_()
            {
                bool lzzb_()
                {
                    CqlDateTime lzzc_ = context.Operators.Start(Period);
                    CqlQuantity lzzd_ = context.Operators.Quantity(24m, "hours");
                    int? lzze_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzf_ = context.Operators.ConvertIntegerToQuantity(lzze_);
                    CqlQuantity lzzg_ = context.Operators.Multiply(lzzd_, lzzf_);
                    CqlDateTime lzzh_ = context.Operators.Add(lzzc_, lzzg_);
                    CqlDateTime lzzi_ = context.Operators.End(Period);
                    int? lzzj_ = context.Operators.DurationBetween(lzzh_, lzzi_, "hour");
                    bool? lzzk_ = context.Operators.Less(lzzj_, 24);

                    return lzzk_ ?? false;
                };
                if (lzzb_())
                {
                    CqlDateTime lzzl_ = context.Operators.Start(Period);
                    CqlQuantity lzzm_ = context.Operators.Quantity(24m, "hours");
                    int? lzzn_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzo_ = context.Operators.ConvertIntegerToQuantity(lzzn_);
                    CqlQuantity lzzp_ = context.Operators.Multiply(lzzm_, lzzo_);
                    CqlDateTime lzzq_ = context.Operators.Add(lzzl_, lzzp_);

                    return lzzq_;
                }
                else
                {
                    CqlDateTime lzzr_ = context.Operators.Start(Period);
                    CqlQuantity lzzs_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity lzzt_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity lzzu_ = context.Operators.Multiply(lzzs_, lzzt_);
                    CqlDateTime lzzv_ = context.Operators.Add(lzzr_, lzzu_);

                    return lzzv_;
                }
            };
            CqlInterval<CqlDateTime> kzzz_ = context.Operators.Interval(kzzx_, kzzy_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? lzza_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, kzzz_);

            return lzza_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzq_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzo_, kzzp_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzr_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzq_);

        return kzzr_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
