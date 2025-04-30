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
      new CqlCodeSystem("http://loinc.org", null,
          _Birthdate);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Dead);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
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
          _virtual);

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null,
          _ER,
          _ICU);

    [CqlCodeSystemDefinition("Diagnosis Role")]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null,
          _Billing,
          _AD,
          _DD,
          _CC,
          _CM,
          _pre_op,
          _post_op,
          _billing);

    [CqlCodeSystemDefinition("RequestIntent")]
    public CqlCodeSystem RequestIntent(CqlContext _) => _RequestIntent;
    private static readonly CqlCodeSystem _RequestIntent =
      new CqlCodeSystem("http://hl7.org/fhir/request-intent", null);

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/medicationrequest-category", null,
          _Inpatient,
          _Outpatient,
          _Community,
          _Discharge);

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-clinical", null,
          _active,
          _recurrence,
          _relapse,
          _inactive,
          _remission,
          _resolved);

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-ver-status", null,
          _unconfirmed,
          _provisional,
          _differential,
          _confirmed,
          _refuted,
          _entered_in_error);

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null,
          _allergy_active,
          _allergy_inactive,
          _allergy_resolved);

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null,
          _allergy_unconfirmed,
          _allergy_confirmed,
          _allergy_refuted);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _social_history,
          _vital_signs,
          _imaging,
          _laboratory,
          _procedure,
          _survey,
          _exam,
          _therapy,
          _activity);

    [CqlCodeSystemDefinition("USCoreObservationCategoryExtensionCodes")]
    public CqlCodeSystem USCoreObservationCategoryExtensionCodes(CqlContext _) => _USCoreObservationCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreObservationCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null,
          _clinical_test);

    [CqlCodeSystemDefinition("ConditionCategory")]
    public CqlCodeSystem ConditionCategory(CqlContext _) => _ConditionCategory;
    private static readonly CqlCodeSystem _ConditionCategory =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-category", null,
          _problem_list_item,
          _encounter_diagnosis);

    [CqlCodeSystemDefinition("USCoreConditionCategoryExtensionCodes")]
    public CqlCodeSystem USCoreConditionCategoryExtensionCodes(CqlContext _) => _USCoreConditionCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreConditionCategoryExtensionCodes =
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/condition-category", null,
          _health_concern);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ws_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wt_ = context.Operators.SingletonFrom<Patient>(ws_);

        return wt_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept wu_ = condition?.ClinicalStatus;
        CqlConcept wv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wu_);
        CqlCode ww_ = this.active(context);
        CqlConcept wx_ = context.Operators.ConvertCodeToConcept(ww_);
        bool? wy_ = context.Operators.Equivalent(wv_, wx_);
        CqlConcept xa_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wu_);
        CqlCode xb_ = this.recurrence(context);
        CqlConcept xc_ = context.Operators.ConvertCodeToConcept(xb_);
        bool? xd_ = context.Operators.Equivalent(xa_, xc_);
        bool? xe_ = context.Operators.Or(wy_, xd_);
        CqlConcept xg_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, wu_);
        CqlCode xh_ = this.relapse(context);
        CqlConcept xi_ = context.Operators.ConvertCodeToConcept(xh_);
        bool? xj_ = context.Operators.Equivalent(xg_, xi_);
        bool? xk_ = context.Operators.Or(xe_, xj_);

        return xk_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> xl_ = condition?.Category;
        CqlConcept xm_(CodeableConcept @this)
        {
            CqlConcept xr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xr_;
        };
        IEnumerable<CqlConcept> xn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xl_, xm_);
        bool? xo_(CqlConcept C)
        {
            CqlConcept xs_ = context.Operators.ConvertCodeToConcept(category);
            bool? xt_ = context.Operators.Equivalent(C, xs_);

            return xt_;
        };
        IEnumerable<CqlConcept> xp_ = context.Operators.Where<CqlConcept>(xn_, xo_);
        bool? xq_ = context.Operators.Exists<CqlConcept>(xp_);

        return xq_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> xu_ = observation?.Category;
        CqlConcept xv_(CodeableConcept @this)
        {
            CqlConcept ya_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return ya_;
        };
        IEnumerable<CqlConcept> xw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xu_, xv_);
        bool? xx_(CqlConcept C)
        {
            CqlConcept yb_ = context.Operators.ConvertCodeToConcept(category);
            bool? yc_ = context.Operators.Equivalent(C, yb_);

            return yc_;
        };
        IEnumerable<CqlConcept> xy_ = context.Operators.Where<CqlConcept>(xw_, xx_);
        bool? xz_ = context.Operators.Exists<CqlConcept>(xy_);

        return xz_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yd_ = condition?.Category;
        CqlConcept ye_(CodeableConcept @this)
        {
            CqlConcept yj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yj_;
        };
        IEnumerable<CqlConcept> yf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yd_, ye_);
        bool? yg_(CqlConcept C)
        {
            CqlCode yk_ = this.problem_list_item(context);
            CqlConcept yl_ = context.Operators.ConvertCodeToConcept(yk_);
            bool? ym_ = context.Operators.Equivalent(C, yl_);

            return ym_;
        };
        IEnumerable<CqlConcept> yh_ = context.Operators.Where<CqlConcept>(yf_, yg_);
        bool? yi_ = context.Operators.Exists<CqlConcept>(yh_);

        return yi_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yn_ = condition?.Category;
        CqlConcept yo_(CodeableConcept @this)
        {
            CqlConcept yt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yt_;
        };
        IEnumerable<CqlConcept> yp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yn_, yo_);
        bool? yq_(CqlConcept C)
        {
            CqlCode yu_ = this.encounter_diagnosis(context);
            CqlConcept yv_ = context.Operators.ConvertCodeToConcept(yu_);
            bool? yw_ = context.Operators.Equivalent(C, yv_);

            return yw_;
        };
        IEnumerable<CqlConcept> yr_ = context.Operators.Where<CqlConcept>(yp_, yq_);
        bool? ys_ = context.Operators.Exists<CqlConcept>(yr_);

        return ys_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yx_ = condition?.Category;
        CqlConcept yy_(CodeableConcept @this)
        {
            CqlConcept zd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zd_;
        };
        IEnumerable<CqlConcept> yz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yx_, yy_);
        bool? za_(CqlConcept C)
        {
            CqlCode ze_ = this.health_concern(context);
            CqlConcept zf_ = context.Operators.ConvertCodeToConcept(ze_);
            bool? zg_ = context.Operators.Equivalent(C, zf_);

            return zg_;
        };
        IEnumerable<CqlConcept> zb_ = context.Operators.Where<CqlConcept>(yz_, za_);
        bool? zc_ = context.Operators.Exists<CqlConcept>(zb_);

        return zc_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zh_ = observation?.Category;
        CqlConcept zi_(CodeableConcept @this)
        {
            CqlConcept zn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zn_;
        };
        IEnumerable<CqlConcept> zj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zh_, zi_);
        bool? zk_(CqlConcept C)
        {
            CqlCode zo_ = this.social_history(context);
            CqlConcept zp_ = context.Operators.ConvertCodeToConcept(zo_);
            bool? zq_ = context.Operators.Equivalent(C, zp_);

            return zq_;
        };
        IEnumerable<CqlConcept> zl_ = context.Operators.Where<CqlConcept>(zj_, zk_);
        bool? zm_ = context.Operators.Exists<CqlConcept>(zl_);

        return zm_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zr_ = observation?.Category;
        CqlConcept zs_(CodeableConcept @this)
        {
            CqlConcept zx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zx_;
        };
        IEnumerable<CqlConcept> zt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zr_, zs_);
        bool? zu_(CqlConcept C)
        {
            CqlCode zy_ = this.vital_signs(context);
            CqlConcept zz_ = context.Operators.ConvertCodeToConcept(zy_);
            bool? aza_ = context.Operators.Equivalent(C, zz_);

            return aza_;
        };
        IEnumerable<CqlConcept> zv_ = context.Operators.Where<CqlConcept>(zt_, zu_);
        bool? zw_ = context.Operators.Exists<CqlConcept>(zv_);

        return zw_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azb_ = observation?.Category;
        CqlConcept azc_(CodeableConcept @this)
        {
            CqlConcept azh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azh_;
        };
        IEnumerable<CqlConcept> azd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azb_, azc_);
        bool? aze_(CqlConcept C)
        {
            CqlCode azi_ = this.imaging(context);
            CqlConcept azj_ = context.Operators.ConvertCodeToConcept(azi_);
            bool? azk_ = context.Operators.Equivalent(C, azj_);

            return azk_;
        };
        IEnumerable<CqlConcept> azf_ = context.Operators.Where<CqlConcept>(azd_, aze_);
        bool? azg_ = context.Operators.Exists<CqlConcept>(azf_);

        return azg_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azl_ = observation?.Category;
        CqlConcept azm_(CodeableConcept @this)
        {
            CqlConcept azr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azr_;
        };
        IEnumerable<CqlConcept> azn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azl_, azm_);
        bool? azo_(CqlConcept C)
        {
            CqlCode azs_ = this.laboratory(context);
            CqlConcept azt_ = context.Operators.ConvertCodeToConcept(azs_);
            bool? azu_ = context.Operators.Equivalent(C, azt_);

            return azu_;
        };
        IEnumerable<CqlConcept> azp_ = context.Operators.Where<CqlConcept>(azn_, azo_);
        bool? azq_ = context.Operators.Exists<CqlConcept>(azp_);

        return azq_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azv_ = observation?.Category;
        CqlConcept azw_(CodeableConcept @this)
        {
            CqlConcept bzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzb_;
        };
        IEnumerable<CqlConcept> azx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azv_, azw_);
        bool? azy_(CqlConcept C)
        {
            CqlCode bzc_ = this.procedure(context);
            CqlConcept bzd_ = context.Operators.ConvertCodeToConcept(bzc_);
            bool? bze_ = context.Operators.Equivalent(C, bzd_);

            return bze_;
        };
        IEnumerable<CqlConcept> azz_ = context.Operators.Where<CqlConcept>(azx_, azy_);
        bool? bza_ = context.Operators.Exists<CqlConcept>(azz_);

        return bza_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzf_ = observation?.Category;
        CqlConcept bzg_(CodeableConcept @this)
        {
            CqlConcept bzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzl_;
        };
        IEnumerable<CqlConcept> bzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzf_, bzg_);
        bool? bzi_(CqlConcept C)
        {
            CqlCode bzm_ = this.survey(context);
            CqlConcept bzn_ = context.Operators.ConvertCodeToConcept(bzm_);
            bool? bzo_ = context.Operators.Equivalent(C, bzn_);

            return bzo_;
        };
        IEnumerable<CqlConcept> bzj_ = context.Operators.Where<CqlConcept>(bzh_, bzi_);
        bool? bzk_ = context.Operators.Exists<CqlConcept>(bzj_);

        return bzk_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzp_ = observation?.Category;
        CqlConcept bzq_(CodeableConcept @this)
        {
            CqlConcept bzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzv_;
        };
        IEnumerable<CqlConcept> bzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzp_, bzq_);
        bool? bzs_(CqlConcept C)
        {
            CqlCode bzw_ = this.exam(context);
            CqlConcept bzx_ = context.Operators.ConvertCodeToConcept(bzw_);
            bool? bzy_ = context.Operators.Equivalent(C, bzx_);

            return bzy_;
        };
        IEnumerable<CqlConcept> bzt_ = context.Operators.Where<CqlConcept>(bzr_, bzs_);
        bool? bzu_ = context.Operators.Exists<CqlConcept>(bzt_);

        return bzu_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzz_ = observation?.Category;
        CqlConcept cza_(CodeableConcept @this)
        {
            CqlConcept czf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czf_;
        };
        IEnumerable<CqlConcept> czb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzz_, cza_);
        bool? czc_(CqlConcept C)
        {
            CqlCode czg_ = this.therapy(context);
            CqlConcept czh_ = context.Operators.ConvertCodeToConcept(czg_);
            bool? czi_ = context.Operators.Equivalent(C, czh_);

            return czi_;
        };
        IEnumerable<CqlConcept> czd_ = context.Operators.Where<CqlConcept>(czb_, czc_);
        bool? cze_ = context.Operators.Exists<CqlConcept>(czd_);

        return cze_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czj_ = observation?.Category;
        CqlConcept czk_(CodeableConcept @this)
        {
            CqlConcept czp_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czp_;
        };
        IEnumerable<CqlConcept> czl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czj_, czk_);
        bool? czm_(CqlConcept C)
        {
            CqlCode czq_ = this.activity(context);
            CqlConcept czr_ = context.Operators.ConvertCodeToConcept(czq_);
            bool? czs_ = context.Operators.Equivalent(C, czr_);

            return czs_;
        };
        IEnumerable<CqlConcept> czn_ = context.Operators.Where<CqlConcept>(czl_, czm_);
        bool? czo_ = context.Operators.Exists<CqlConcept>(czn_);

        return czo_;
    }


    [CqlExpressionDefinition("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czt_ = observation?.Category;
        CqlConcept czu_(CodeableConcept @this)
        {
            CqlConcept czz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czz_;
        };
        IEnumerable<CqlConcept> czv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czt_, czu_);
        bool? czw_(CqlConcept C)
        {
            CqlCode dza_ = this.clinical_test(context);
            CqlConcept dzb_ = context.Operators.ConvertCodeToConcept(dza_);
            bool? dzc_ = context.Operators.Equivalent(C, dzb_);

            return dzc_;
        };
        IEnumerable<CqlConcept> czx_ = context.Operators.Where<CqlConcept>(czv_, czw_);
        bool? czy_ = context.Operators.Exists<CqlConcept>(czx_);

        return czy_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzd_ = medicationRequest?.Category;
        CqlConcept dze_(CodeableConcept @this)
        {
            CqlConcept dzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzj_;
        };
        IEnumerable<CqlConcept> dzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzd_, dze_);
        bool? dzg_(CqlConcept C)
        {
            CqlCode dzk_ = this.Community(context);
            CqlConcept dzl_ = context.Operators.ConvertCodeToConcept(dzk_);
            bool? dzm_ = context.Operators.Equivalent(C, dzl_);

            return dzm_;
        };
        IEnumerable<CqlConcept> dzh_ = context.Operators.Where<CqlConcept>(dzf_, dzg_);
        bool? dzi_ = context.Operators.Exists<CqlConcept>(dzh_);

        return dzi_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzn_ = medicationRequest?.Category;
        CqlConcept dzo_(CodeableConcept @this)
        {
            CqlConcept dzt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzt_;
        };
        IEnumerable<CqlConcept> dzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzn_, dzo_);
        bool? dzq_(CqlConcept C)
        {
            CqlCode dzu_ = this.Discharge(context);
            CqlConcept dzv_ = context.Operators.ConvertCodeToConcept(dzu_);
            bool? dzw_ = context.Operators.Equivalent(C, dzv_);

            return dzw_;
        };
        IEnumerable<CqlConcept> dzr_ = context.Operators.Where<CqlConcept>(dzp_, dzq_);
        bool? dzs_ = context.Operators.Exists<CqlConcept>(dzr_);

        return dzs_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? dzx_(Extension E)
        {
            string ezd_ = E?.Url;
            FhirString eze_ = context.Operators.Convert<FhirString>(ezd_);
            string ezf_ = eze_?.Value;
            bool? ezg_ = context.Operators.Equal(ezf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return ezg_;
        };
        IEnumerable<Extension> dzy_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), dzx_);
        bool? dzz_(Extension E)
        {
            DataType ezh_ = E?.Value;
            object ezi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezh_);

            return ezi_ as bool?;
        };
        IEnumerable<bool?> eza_ = context.Operators.Select<Extension, bool?>(dzy_, dzz_);
        IEnumerable<bool?> ezb_ = context.Operators.Distinct<bool?>(eza_);
        bool? ezc_ = context.Operators.SingletonFrom<bool?>(ezb_);

        return ezc_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezj_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ezk_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ezk_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezl_ = this.Patient(context);
                Date ezm_ = ezl_?.BirthDateElement;
                string ezn_ = ezm_?.Value;
                CqlDate ezo_ = context.Operators.ConvertStringToDate(ezn_);
                CqlDate ezp_ = context.Operators.Add(ezo_, choice as CqlQuantity);
                Date ezr_ = ezl_?.BirthDateElement;
                string ezs_ = ezr_?.Value;
                CqlDate ezt_ = context.Operators.ConvertStringToDate(ezs_);
                CqlDate ezu_ = context.Operators.Add(ezt_, choice as CqlQuantity);
                CqlQuantity ezv_ = context.Operators.Quantity(1m, "year");
                CqlDate ezw_ = context.Operators.Add(ezu_, ezv_);
                CqlInterval<CqlDate> ezx_ = context.Operators.Interval(ezp_, ezw_, true, false);
                CqlDate ezy_ = ezx_?.low;
                CqlDateTime ezz_ = context.Operators.ConvertDateToDateTime(ezy_);
                Date fzb_ = ezl_?.BirthDateElement;
                string fzc_ = fzb_?.Value;
                CqlDate fzd_ = context.Operators.ConvertStringToDate(fzc_);
                CqlDate fze_ = context.Operators.Add(fzd_, choice as CqlQuantity);
                Date fzg_ = ezl_?.BirthDateElement;
                string fzh_ = fzg_?.Value;
                CqlDate fzi_ = context.Operators.ConvertStringToDate(fzh_);
                CqlDate fzj_ = context.Operators.Add(fzi_, choice as CqlQuantity);
                CqlDate fzl_ = context.Operators.Add(fzj_, ezv_);
                CqlInterval<CqlDate> fzm_ = context.Operators.Interval(fze_, fzl_, true, false);
                CqlDate fzn_ = fzm_?.high;
                CqlDateTime fzo_ = context.Operators.ConvertDateToDateTime(fzn_);
                Date fzq_ = ezl_?.BirthDateElement;
                string fzr_ = fzq_?.Value;
                CqlDate fzs_ = context.Operators.ConvertStringToDate(fzr_);
                CqlDate fzt_ = context.Operators.Add(fzs_, choice as CqlQuantity);
                Date fzv_ = ezl_?.BirthDateElement;
                string fzw_ = fzv_?.Value;
                CqlDate fzx_ = context.Operators.ConvertStringToDate(fzw_);
                CqlDate fzy_ = context.Operators.Add(fzx_, choice as CqlQuantity);
                CqlDate gza_ = context.Operators.Add(fzy_, ezv_);
                CqlInterval<CqlDate> gzb_ = context.Operators.Interval(fzt_, gza_, true, false);
                bool? gzc_ = gzb_?.lowClosed;
                Date gze_ = ezl_?.BirthDateElement;
                string gzf_ = gze_?.Value;
                CqlDate gzg_ = context.Operators.ConvertStringToDate(gzf_);
                CqlDate gzh_ = context.Operators.Add(gzg_, choice as CqlQuantity);
                Date gzj_ = ezl_?.BirthDateElement;
                string gzk_ = gzj_?.Value;
                CqlDate gzl_ = context.Operators.ConvertStringToDate(gzk_);
                CqlDate gzm_ = context.Operators.Add(gzl_, choice as CqlQuantity);
                CqlDate gzo_ = context.Operators.Add(gzm_, ezv_);
                CqlInterval<CqlDate> gzp_ = context.Operators.Interval(gzh_, gzo_, true, false);
                bool? gzq_ = gzp_?.highClosed;
                CqlInterval<CqlDateTime> gzr_ = context.Operators.Interval(ezz_, fzo_, gzc_, gzq_);

                return gzr_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzs_ = this.Patient(context);
                Date gzt_ = gzs_?.BirthDateElement;
                string gzu_ = gzt_?.Value;
                CqlDate gzv_ = context.Operators.ConvertStringToDate(gzu_);
                object gzw_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate gzx_ = context.Operators.Add(gzv_, gzw_ as CqlQuantity);
                Date gzz_ = gzs_?.BirthDateElement;
                string hza_ = gzz_?.Value;
                CqlDate hzb_ = context.Operators.ConvertStringToDate(hza_);
                object hzc_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate hzd_ = context.Operators.Add(hzb_, hzc_ as CqlQuantity);
                CqlQuantity hze_ = context.Operators.Quantity(1m, "year");
                CqlDate hzf_ = context.Operators.Add(hzd_, hze_);
                CqlInterval<CqlDate> hzg_ = context.Operators.Interval(gzx_, hzf_, true, false);
                CqlDate hzh_ = hzg_?.low;
                CqlDateTime hzi_ = context.Operators.ConvertDateToDateTime(hzh_);
                Date hzk_ = gzs_?.BirthDateElement;
                string hzl_ = hzk_?.Value;
                CqlDate hzm_ = context.Operators.ConvertStringToDate(hzl_);
                CqlDate hzo_ = context.Operators.Add(hzm_, gzw_ as CqlQuantity);
                Date hzq_ = gzs_?.BirthDateElement;
                string hzr_ = hzq_?.Value;
                CqlDate hzs_ = context.Operators.ConvertStringToDate(hzr_);
                CqlDate hzu_ = context.Operators.Add(hzs_, hzc_ as CqlQuantity);
                CqlDate hzw_ = context.Operators.Add(hzu_, hze_);
                CqlInterval<CqlDate> hzx_ = context.Operators.Interval(hzo_, hzw_, true, false);
                CqlDate hzy_ = hzx_?.high;
                CqlDateTime hzz_ = context.Operators.ConvertDateToDateTime(hzy_);
                Date izb_ = gzs_?.BirthDateElement;
                string izc_ = izb_?.Value;
                CqlDate izd_ = context.Operators.ConvertStringToDate(izc_);
                CqlDate izf_ = context.Operators.Add(izd_, gzw_ as CqlQuantity);
                Date izh_ = gzs_?.BirthDateElement;
                string izi_ = izh_?.Value;
                CqlDate izj_ = context.Operators.ConvertStringToDate(izi_);
                CqlDate izl_ = context.Operators.Add(izj_, hzc_ as CqlQuantity);
                CqlDate izn_ = context.Operators.Add(izl_, hze_);
                CqlInterval<CqlDate> izo_ = context.Operators.Interval(izf_, izn_, true, false);
                bool? izp_ = izo_?.lowClosed;
                Date izr_ = gzs_?.BirthDateElement;
                string izs_ = izr_?.Value;
                CqlDate izt_ = context.Operators.ConvertStringToDate(izs_);
                CqlDate izv_ = context.Operators.Add(izt_, gzw_ as CqlQuantity);
                Date izx_ = gzs_?.BirthDateElement;
                string izy_ = izx_?.Value;
                CqlDate izz_ = context.Operators.ConvertStringToDate(izy_);
                CqlDate jzb_ = context.Operators.Add(izz_, hzc_ as CqlQuantity);
                CqlDate jzd_ = context.Operators.Add(jzb_, hze_);
                CqlInterval<CqlDate> jze_ = context.Operators.Interval(izv_, jzd_, true, false);
                bool? jzf_ = jze_?.highClosed;
                CqlInterval<CqlDateTime> jzg_ = context.Operators.Interval(hzi_, hzz_, izp_, jzf_);

                return jzg_;
            }
            else if (choice is Timing)
            {
                object jzh_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return jzh_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ezj_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzi_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jzj_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jzj_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzk_ = this.Patient(context);
                Date jzl_ = jzk_?.BirthDateElement;
                string jzm_ = jzl_?.Value;
                CqlDate jzn_ = context.Operators.ConvertStringToDate(jzm_);
                CqlDate jzo_ = context.Operators.Add(jzn_, choice as CqlQuantity);
                Date jzq_ = jzk_?.BirthDateElement;
                string jzr_ = jzq_?.Value;
                CqlDate jzs_ = context.Operators.ConvertStringToDate(jzr_);
                CqlDate jzt_ = context.Operators.Add(jzs_, choice as CqlQuantity);
                CqlQuantity jzu_ = context.Operators.Quantity(1m, "year");
                CqlDate jzv_ = context.Operators.Add(jzt_, jzu_);
                CqlInterval<CqlDate> jzw_ = context.Operators.Interval(jzo_, jzv_, true, false);
                CqlDate jzx_ = jzw_?.low;
                CqlDateTime jzy_ = context.Operators.ConvertDateToDateTime(jzx_);
                Date kza_ = jzk_?.BirthDateElement;
                string kzb_ = kza_?.Value;
                CqlDate kzc_ = context.Operators.ConvertStringToDate(kzb_);
                CqlDate kzd_ = context.Operators.Add(kzc_, choice as CqlQuantity);
                Date kzf_ = jzk_?.BirthDateElement;
                string kzg_ = kzf_?.Value;
                CqlDate kzh_ = context.Operators.ConvertStringToDate(kzg_);
                CqlDate kzi_ = context.Operators.Add(kzh_, choice as CqlQuantity);
                CqlDate kzk_ = context.Operators.Add(kzi_, jzu_);
                CqlInterval<CqlDate> kzl_ = context.Operators.Interval(kzd_, kzk_, true, false);
                CqlDate kzm_ = kzl_?.high;
                CqlDateTime kzn_ = context.Operators.ConvertDateToDateTime(kzm_);
                Date kzp_ = jzk_?.BirthDateElement;
                string kzq_ = kzp_?.Value;
                CqlDate kzr_ = context.Operators.ConvertStringToDate(kzq_);
                CqlDate kzs_ = context.Operators.Add(kzr_, choice as CqlQuantity);
                Date kzu_ = jzk_?.BirthDateElement;
                string kzv_ = kzu_?.Value;
                CqlDate kzw_ = context.Operators.ConvertStringToDate(kzv_);
                CqlDate kzx_ = context.Operators.Add(kzw_, choice as CqlQuantity);
                CqlDate kzz_ = context.Operators.Add(kzx_, jzu_);
                CqlInterval<CqlDate> lza_ = context.Operators.Interval(kzs_, kzz_, true, false);
                bool? lzb_ = lza_?.lowClosed;
                Date lzd_ = jzk_?.BirthDateElement;
                string lze_ = lzd_?.Value;
                CqlDate lzf_ = context.Operators.ConvertStringToDate(lze_);
                CqlDate lzg_ = context.Operators.Add(lzf_, choice as CqlQuantity);
                Date lzi_ = jzk_?.BirthDateElement;
                string lzj_ = lzi_?.Value;
                CqlDate lzk_ = context.Operators.ConvertStringToDate(lzj_);
                CqlDate lzl_ = context.Operators.Add(lzk_, choice as CqlQuantity);
                CqlDate lzn_ = context.Operators.Add(lzl_, jzu_);
                CqlInterval<CqlDate> lzo_ = context.Operators.Interval(lzg_, lzn_, true, false);
                bool? lzp_ = lzo_?.highClosed;
                CqlInterval<CqlDateTime> lzq_ = context.Operators.Interval(jzy_, kzn_, lzb_, lzp_);

                return lzq_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzr_ = this.Patient(context);
                Date lzs_ = lzr_?.BirthDateElement;
                string lzt_ = lzs_?.Value;
                CqlDate lzu_ = context.Operators.ConvertStringToDate(lzt_);
                object lzv_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzw_ = context.Operators.Add(lzu_, lzv_ as CqlQuantity);
                Date lzy_ = lzr_?.BirthDateElement;
                string lzz_ = lzy_?.Value;
                CqlDate mza_ = context.Operators.ConvertStringToDate(lzz_);
                object mzb_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate mzc_ = context.Operators.Add(mza_, mzb_ as CqlQuantity);
                CqlQuantity mzd_ = context.Operators.Quantity(1m, "year");
                CqlDate mze_ = context.Operators.Add(mzc_, mzd_);
                CqlInterval<CqlDate> mzf_ = context.Operators.Interval(lzw_, mze_, true, false);
                CqlDate mzg_ = mzf_?.low;
                CqlDateTime mzh_ = context.Operators.ConvertDateToDateTime(mzg_);
                Date mzj_ = lzr_?.BirthDateElement;
                string mzk_ = mzj_?.Value;
                CqlDate mzl_ = context.Operators.ConvertStringToDate(mzk_);
                CqlDate mzn_ = context.Operators.Add(mzl_, lzv_ as CqlQuantity);
                Date mzp_ = lzr_?.BirthDateElement;
                string mzq_ = mzp_?.Value;
                CqlDate mzr_ = context.Operators.ConvertStringToDate(mzq_);
                CqlDate mzt_ = context.Operators.Add(mzr_, mzb_ as CqlQuantity);
                CqlDate mzv_ = context.Operators.Add(mzt_, mzd_);
                CqlInterval<CqlDate> mzw_ = context.Operators.Interval(mzn_, mzv_, true, false);
                CqlDate mzx_ = mzw_?.high;
                CqlDateTime mzy_ = context.Operators.ConvertDateToDateTime(mzx_);
                Date nza_ = lzr_?.BirthDateElement;
                string nzb_ = nza_?.Value;
                CqlDate nzc_ = context.Operators.ConvertStringToDate(nzb_);
                CqlDate nze_ = context.Operators.Add(nzc_, lzv_ as CqlQuantity);
                Date nzg_ = lzr_?.BirthDateElement;
                string nzh_ = nzg_?.Value;
                CqlDate nzi_ = context.Operators.ConvertStringToDate(nzh_);
                CqlDate nzk_ = context.Operators.Add(nzi_, mzb_ as CqlQuantity);
                CqlDate nzm_ = context.Operators.Add(nzk_, mzd_);
                CqlInterval<CqlDate> nzn_ = context.Operators.Interval(nze_, nzm_, true, false);
                bool? nzo_ = nzn_?.lowClosed;
                Date nzq_ = lzr_?.BirthDateElement;
                string nzr_ = nzq_?.Value;
                CqlDate nzs_ = context.Operators.ConvertStringToDate(nzr_);
                CqlDate nzu_ = context.Operators.Add(nzs_, lzv_ as CqlQuantity);
                Date nzw_ = lzr_?.BirthDateElement;
                string nzx_ = nzw_?.Value;
                CqlDate nzy_ = context.Operators.ConvertStringToDate(nzx_);
                CqlDate oza_ = context.Operators.Add(nzy_, mzb_ as CqlQuantity);
                CqlDate ozc_ = context.Operators.Add(oza_, mzd_);
                CqlInterval<CqlDate> ozd_ = context.Operators.Interval(nzu_, ozc_, true, false);
                bool? oze_ = ozd_?.highClosed;
                CqlInterval<CqlDateTime> ozf_ = context.Operators.Interval(mzh_, mzy_, nzo_, oze_);

                return ozf_;
            }
            else if (choice is Timing)
            {
                object ozg_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return ozg_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzi_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ozh_()
        {
            bool ozi_()
            {
                DataType ozm_ = condition?.Abatement;
                object ozn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozm_);
                bool ozo_ = ozn_ is CqlDateTime;

                return ozo_;
            };
            bool ozj_()
            {
                DataType ozp_ = condition?.Abatement;
                object ozq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozp_);
                bool ozr_ = ozq_ is CqlQuantity;

                return ozr_;
            };
            bool ozk_()
            {
                DataType ozs_ = condition?.Abatement;
                object ozt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozs_);
                bool ozu_ = ozt_ is CqlInterval<CqlQuantity>;

                return ozu_;
            };
            bool ozl_()
            {
                DataType ozv_ = condition?.Abatement;
                object ozw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozv_);
                bool ozx_ = ozw_ is CqlInterval<CqlDateTime>;

                return ozx_;
            };
            if (ozi_())
            {
                DataType ozy_ = condition?.Abatement;
                object ozz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozy_);
                object pzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozy_);
                CqlInterval<CqlDateTime> pzc_ = context.Operators.Interval(ozz_ as CqlDateTime, pzb_ as CqlDateTime, true, true);

                return pzc_;
            }
            else if (ozj_())
            {
                Patient pzd_ = this.Patient(context);
                Date pze_ = pzd_?.BirthDateElement;
                string pzf_ = pze_?.Value;
                CqlDate pzg_ = context.Operators.ConvertStringToDate(pzf_);
                DataType pzh_ = condition?.Abatement;
                object pzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate pzj_ = context.Operators.Add(pzg_, pzi_ as CqlQuantity);
                Date pzl_ = pzd_?.BirthDateElement;
                string pzm_ = pzl_?.Value;
                CqlDate pzn_ = context.Operators.ConvertStringToDate(pzm_);
                object pzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate pzq_ = context.Operators.Add(pzn_, pzp_ as CqlQuantity);
                CqlQuantity pzr_ = context.Operators.Quantity(1m, "year");
                CqlDate pzs_ = context.Operators.Add(pzq_, pzr_);
                CqlInterval<CqlDate> pzt_ = context.Operators.Interval(pzj_, pzs_, true, false);
                CqlDate pzu_ = pzt_?.low;
                CqlDateTime pzv_ = context.Operators.ConvertDateToDateTime(pzu_);
                Date pzx_ = pzd_?.BirthDateElement;
                string pzy_ = pzx_?.Value;
                CqlDate pzz_ = context.Operators.ConvertStringToDate(pzy_);
                object qzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate qzc_ = context.Operators.Add(pzz_, qzb_ as CqlQuantity);
                Date qze_ = pzd_?.BirthDateElement;
                string qzf_ = qze_?.Value;
                CqlDate qzg_ = context.Operators.ConvertStringToDate(qzf_);
                object qzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate qzj_ = context.Operators.Add(qzg_, qzi_ as CqlQuantity);
                CqlDate qzl_ = context.Operators.Add(qzj_, pzr_);
                CqlInterval<CqlDate> qzm_ = context.Operators.Interval(qzc_, qzl_, true, false);
                CqlDate qzn_ = qzm_?.high;
                CqlDateTime qzo_ = context.Operators.ConvertDateToDateTime(qzn_);
                Date qzq_ = pzd_?.BirthDateElement;
                string qzr_ = qzq_?.Value;
                CqlDate qzs_ = context.Operators.ConvertStringToDate(qzr_);
                object qzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate qzv_ = context.Operators.Add(qzs_, qzu_ as CqlQuantity);
                Date qzx_ = pzd_?.BirthDateElement;
                string qzy_ = qzx_?.Value;
                CqlDate qzz_ = context.Operators.ConvertStringToDate(qzy_);
                object rzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate rzc_ = context.Operators.Add(qzz_, rzb_ as CqlQuantity);
                CqlDate rze_ = context.Operators.Add(rzc_, pzr_);
                CqlInterval<CqlDate> rzf_ = context.Operators.Interval(qzv_, rze_, true, false);
                bool? rzg_ = rzf_?.lowClosed;
                Date rzi_ = pzd_?.BirthDateElement;
                string rzj_ = rzi_?.Value;
                CqlDate rzk_ = context.Operators.ConvertStringToDate(rzj_);
                object rzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate rzn_ = context.Operators.Add(rzk_, rzm_ as CqlQuantity);
                Date rzp_ = pzd_?.BirthDateElement;
                string rzq_ = rzp_?.Value;
                CqlDate rzr_ = context.Operators.ConvertStringToDate(rzq_);
                object rzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzh_);
                CqlDate rzu_ = context.Operators.Add(rzr_, rzt_ as CqlQuantity);
                CqlDate rzw_ = context.Operators.Add(rzu_, pzr_);
                CqlInterval<CqlDate> rzx_ = context.Operators.Interval(rzn_, rzw_, true, false);
                bool? rzy_ = rzx_?.highClosed;
                CqlInterval<CqlDateTime> rzz_ = context.Operators.Interval(pzv_, qzo_, rzg_, rzy_);

                return rzz_;
            }
            else if (ozk_())
            {
                Patient sza_ = this.Patient(context);
                Date szb_ = sza_?.BirthDateElement;
                string szc_ = szb_?.Value;
                CqlDate szd_ = context.Operators.ConvertStringToDate(szc_);
                DataType sze_ = condition?.Abatement;
                object szf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object szg_ = context.Operators.LateBoundProperty<object>(szf_, "low");
                CqlDate szh_ = context.Operators.Add(szd_, szg_ as CqlQuantity);
                Date szj_ = sza_?.BirthDateElement;
                string szk_ = szj_?.Value;
                CqlDate szl_ = context.Operators.ConvertStringToDate(szk_);
                object szn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object szo_ = context.Operators.LateBoundProperty<object>(szn_, "high");
                CqlDate szp_ = context.Operators.Add(szl_, szo_ as CqlQuantity);
                CqlQuantity szq_ = context.Operators.Quantity(1m, "year");
                CqlDate szr_ = context.Operators.Add(szp_, szq_);
                CqlInterval<CqlDate> szs_ = context.Operators.Interval(szh_, szr_, true, false);
                CqlDate szt_ = szs_?.low;
                CqlDateTime szu_ = context.Operators.ConvertDateToDateTime(szt_);
                Date szw_ = sza_?.BirthDateElement;
                string szx_ = szw_?.Value;
                CqlDate szy_ = context.Operators.ConvertStringToDate(szx_);
                object tza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object tzb_ = context.Operators.LateBoundProperty<object>(tza_, "low");
                CqlDate tzc_ = context.Operators.Add(szy_, tzb_ as CqlQuantity);
                Date tze_ = sza_?.BirthDateElement;
                string tzf_ = tze_?.Value;
                CqlDate tzg_ = context.Operators.ConvertStringToDate(tzf_);
                object tzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object tzj_ = context.Operators.LateBoundProperty<object>(tzi_, "high");
                CqlDate tzk_ = context.Operators.Add(tzg_, tzj_ as CqlQuantity);
                CqlDate tzm_ = context.Operators.Add(tzk_, szq_);
                CqlInterval<CqlDate> tzn_ = context.Operators.Interval(tzc_, tzm_, true, false);
                CqlDate tzo_ = tzn_?.high;
                CqlDateTime tzp_ = context.Operators.ConvertDateToDateTime(tzo_);
                Date tzr_ = sza_?.BirthDateElement;
                string tzs_ = tzr_?.Value;
                CqlDate tzt_ = context.Operators.ConvertStringToDate(tzs_);
                object tzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object tzw_ = context.Operators.LateBoundProperty<object>(tzv_, "low");
                CqlDate tzx_ = context.Operators.Add(tzt_, tzw_ as CqlQuantity);
                Date tzz_ = sza_?.BirthDateElement;
                string uza_ = tzz_?.Value;
                CqlDate uzb_ = context.Operators.ConvertStringToDate(uza_);
                object uzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object uze_ = context.Operators.LateBoundProperty<object>(uzd_, "high");
                CqlDate uzf_ = context.Operators.Add(uzb_, uze_ as CqlQuantity);
                CqlDate uzh_ = context.Operators.Add(uzf_, szq_);
                CqlInterval<CqlDate> uzi_ = context.Operators.Interval(tzx_, uzh_, true, false);
                bool? uzj_ = uzi_?.lowClosed;
                Date uzl_ = sza_?.BirthDateElement;
                string uzm_ = uzl_?.Value;
                CqlDate uzn_ = context.Operators.ConvertStringToDate(uzm_);
                object uzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object uzq_ = context.Operators.LateBoundProperty<object>(uzp_, "low");
                CqlDate uzr_ = context.Operators.Add(uzn_, uzq_ as CqlQuantity);
                Date uzt_ = sza_?.BirthDateElement;
                string uzu_ = uzt_?.Value;
                CqlDate uzv_ = context.Operators.ConvertStringToDate(uzu_);
                object uzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, sze_);
                object uzy_ = context.Operators.LateBoundProperty<object>(uzx_, "high");
                CqlDate uzz_ = context.Operators.Add(uzv_, uzy_ as CqlQuantity);
                CqlDate vzb_ = context.Operators.Add(uzz_, szq_);
                CqlInterval<CqlDate> vzc_ = context.Operators.Interval(uzr_, vzb_, true, false);
                bool? vzd_ = vzc_?.highClosed;
                CqlInterval<CqlDateTime> vze_ = context.Operators.Interval(szu_, tzp_, uzj_, vzd_);

                return vze_;
            }
            else if (ozl_())
            {
                DataType vzf_ = condition?.Abatement;
                object vzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzf_);
                object vzh_ = context.Operators.LateBoundProperty<object>(vzg_, "low");
                object vzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzf_);
                object vzk_ = context.Operators.LateBoundProperty<object>(vzj_, "high");
                CqlInterval<CqlDateTime> vzl_ = context.Operators.Interval(vzh_ as CqlDateTime, vzk_ as CqlDateTime, true, false);

                return vzl_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ozh_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vzm_()
        {
            bool vzn_()
            {
                DataType vzr_ = condition?.Abatement;
                object vzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzr_);
                bool vzt_ = vzs_ is CqlDateTime;

                return vzt_;
            };
            bool vzo_()
            {
                DataType vzu_ = condition?.Abatement;
                object vzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzu_);
                bool vzw_ = vzv_ is CqlQuantity;

                return vzw_;
            };
            bool vzp_()
            {
                DataType vzx_ = condition?.Abatement;
                object vzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzx_);
                bool vzz_ = vzy_ is CqlInterval<CqlQuantity>;

                return vzz_;
            };
            bool vzq_()
            {
                DataType wza_ = condition?.Abatement;
                object wzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wza_);
                bool wzc_ = wzb_ is CqlInterval<CqlDateTime>;

                return wzc_;
            };
            if (vzn_())
            {
                DataType wzd_ = condition?.Abatement;
                object wze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzd_);
                object wzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzd_);
                CqlInterval<CqlDateTime> wzh_ = context.Operators.Interval(wze_ as CqlDateTime, wzg_ as CqlDateTime, true, true);

                return wzh_;
            }
            else if (vzo_())
            {
                Patient wzi_ = this.Patient(context);
                Date wzj_ = wzi_?.BirthDateElement;
                string wzk_ = wzj_?.Value;
                CqlDate wzl_ = context.Operators.ConvertStringToDate(wzk_);
                DataType wzm_ = condition?.Abatement;
                object wzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate wzo_ = context.Operators.Add(wzl_, wzn_ as CqlQuantity);
                Date wzq_ = wzi_?.BirthDateElement;
                string wzr_ = wzq_?.Value;
                CqlDate wzs_ = context.Operators.ConvertStringToDate(wzr_);
                object wzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate wzv_ = context.Operators.Add(wzs_, wzu_ as CqlQuantity);
                CqlQuantity wzw_ = context.Operators.Quantity(1m, "year");
                CqlDate wzx_ = context.Operators.Add(wzv_, wzw_);
                CqlInterval<CqlDate> wzy_ = context.Operators.Interval(wzo_, wzx_, true, false);
                CqlDate wzz_ = wzy_?.low;
                CqlDateTime xza_ = context.Operators.ConvertDateToDateTime(wzz_);
                Date xzc_ = wzi_?.BirthDateElement;
                string xzd_ = xzc_?.Value;
                CqlDate xze_ = context.Operators.ConvertStringToDate(xzd_);
                object xzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate xzh_ = context.Operators.Add(xze_, xzg_ as CqlQuantity);
                Date xzj_ = wzi_?.BirthDateElement;
                string xzk_ = xzj_?.Value;
                CqlDate xzl_ = context.Operators.ConvertStringToDate(xzk_);
                object xzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate xzo_ = context.Operators.Add(xzl_, xzn_ as CqlQuantity);
                CqlDate xzq_ = context.Operators.Add(xzo_, wzw_);
                CqlInterval<CqlDate> xzr_ = context.Operators.Interval(xzh_, xzq_, true, false);
                CqlDate xzs_ = xzr_?.high;
                CqlDateTime xzt_ = context.Operators.ConvertDateToDateTime(xzs_);
                Date xzv_ = wzi_?.BirthDateElement;
                string xzw_ = xzv_?.Value;
                CqlDate xzx_ = context.Operators.ConvertStringToDate(xzw_);
                object xzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate yza_ = context.Operators.Add(xzx_, xzz_ as CqlQuantity);
                Date yzc_ = wzi_?.BirthDateElement;
                string yzd_ = yzc_?.Value;
                CqlDate yze_ = context.Operators.ConvertStringToDate(yzd_);
                object yzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate yzh_ = context.Operators.Add(yze_, yzg_ as CqlQuantity);
                CqlDate yzj_ = context.Operators.Add(yzh_, wzw_);
                CqlInterval<CqlDate> yzk_ = context.Operators.Interval(yza_, yzj_, true, false);
                bool? yzl_ = yzk_?.lowClosed;
                Date yzn_ = wzi_?.BirthDateElement;
                string yzo_ = yzn_?.Value;
                CqlDate yzp_ = context.Operators.ConvertStringToDate(yzo_);
                object yzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate yzs_ = context.Operators.Add(yzp_, yzr_ as CqlQuantity);
                Date yzu_ = wzi_?.BirthDateElement;
                string yzv_ = yzu_?.Value;
                CqlDate yzw_ = context.Operators.ConvertStringToDate(yzv_);
                object yzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzm_);
                CqlDate yzz_ = context.Operators.Add(yzw_, yzy_ as CqlQuantity);
                CqlDate zzb_ = context.Operators.Add(yzz_, wzw_);
                CqlInterval<CqlDate> zzc_ = context.Operators.Interval(yzs_, zzb_, true, false);
                bool? zzd_ = zzc_?.highClosed;
                CqlInterval<CqlDateTime> zze_ = context.Operators.Interval(xza_, xzt_, yzl_, zzd_);

                return zze_;
            }
            else if (vzp_())
            {
                Patient zzf_ = this.Patient(context);
                Date zzg_ = zzf_?.BirthDateElement;
                string zzh_ = zzg_?.Value;
                CqlDate zzi_ = context.Operators.ConvertStringToDate(zzh_);
                DataType zzj_ = condition?.Abatement;
                object zzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object zzl_ = context.Operators.LateBoundProperty<object>(zzk_, "low");
                CqlDate zzm_ = context.Operators.Add(zzi_, zzl_ as CqlQuantity);
                Date zzo_ = zzf_?.BirthDateElement;
                string zzp_ = zzo_?.Value;
                CqlDate zzq_ = context.Operators.ConvertStringToDate(zzp_);
                object zzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object zzt_ = context.Operators.LateBoundProperty<object>(zzs_, "high");
                CqlDate zzu_ = context.Operators.Add(zzq_, zzt_ as CqlQuantity);
                CqlQuantity zzv_ = context.Operators.Quantity(1m, "year");
                CqlDate zzw_ = context.Operators.Add(zzu_, zzv_);
                CqlInterval<CqlDate> zzx_ = context.Operators.Interval(zzm_, zzw_, true, false);
                CqlDate zzy_ = zzx_?.low;
                CqlDateTime zzz_ = context.Operators.ConvertDateToDateTime(zzy_);
                Date azzb_ = zzf_?.BirthDateElement;
                string azzc_ = azzb_?.Value;
                CqlDate azzd_ = context.Operators.ConvertStringToDate(azzc_);
                object azzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object azzg_ = context.Operators.LateBoundProperty<object>(azzf_, "low");
                CqlDate azzh_ = context.Operators.Add(azzd_, azzg_ as CqlQuantity);
                Date azzj_ = zzf_?.BirthDateElement;
                string azzk_ = azzj_?.Value;
                CqlDate azzl_ = context.Operators.ConvertStringToDate(azzk_);
                object azzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object azzo_ = context.Operators.LateBoundProperty<object>(azzn_, "high");
                CqlDate azzp_ = context.Operators.Add(azzl_, azzo_ as CqlQuantity);
                CqlDate azzr_ = context.Operators.Add(azzp_, zzv_);
                CqlInterval<CqlDate> azzs_ = context.Operators.Interval(azzh_, azzr_, true, false);
                CqlDate azzt_ = azzs_?.high;
                CqlDateTime azzu_ = context.Operators.ConvertDateToDateTime(azzt_);
                Date azzw_ = zzf_?.BirthDateElement;
                string azzx_ = azzw_?.Value;
                CqlDate azzy_ = context.Operators.ConvertStringToDate(azzx_);
                object bzza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object bzzb_ = context.Operators.LateBoundProperty<object>(bzza_, "low");
                CqlDate bzzc_ = context.Operators.Add(azzy_, bzzb_ as CqlQuantity);
                Date bzze_ = zzf_?.BirthDateElement;
                string bzzf_ = bzze_?.Value;
                CqlDate bzzg_ = context.Operators.ConvertStringToDate(bzzf_);
                object bzzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object bzzj_ = context.Operators.LateBoundProperty<object>(bzzi_, "high");
                CqlDate bzzk_ = context.Operators.Add(bzzg_, bzzj_ as CqlQuantity);
                CqlDate bzzm_ = context.Operators.Add(bzzk_, zzv_);
                CqlInterval<CqlDate> bzzn_ = context.Operators.Interval(bzzc_, bzzm_, true, false);
                bool? bzzo_ = bzzn_?.lowClosed;
                Date bzzq_ = zzf_?.BirthDateElement;
                string bzzr_ = bzzq_?.Value;
                CqlDate bzzs_ = context.Operators.ConvertStringToDate(bzzr_);
                object bzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object bzzv_ = context.Operators.LateBoundProperty<object>(bzzu_, "low");
                CqlDate bzzw_ = context.Operators.Add(bzzs_, bzzv_ as CqlQuantity);
                Date bzzy_ = zzf_?.BirthDateElement;
                string bzzz_ = bzzy_?.Value;
                CqlDate czza_ = context.Operators.ConvertStringToDate(bzzz_);
                object czzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzj_);
                object czzd_ = context.Operators.LateBoundProperty<object>(czzc_, "high");
                CqlDate czze_ = context.Operators.Add(czza_, czzd_ as CqlQuantity);
                CqlDate czzg_ = context.Operators.Add(czze_, zzv_);
                CqlInterval<CqlDate> czzh_ = context.Operators.Interval(bzzw_, czzg_, true, false);
                bool? czzi_ = czzh_?.highClosed;
                CqlInterval<CqlDateTime> czzj_ = context.Operators.Interval(zzz_, azzu_, bzzo_, czzi_);

                return czzj_;
            }
            else if (vzq_())
            {
                DataType czzk_ = condition?.Abatement;
                object czzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzk_);
                object czzm_ = context.Operators.LateBoundProperty<object>(czzl_, "low");
                object czzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzk_);
                object czzp_ = context.Operators.LateBoundProperty<object>(czzo_, "high");
                CqlInterval<CqlDateTime> czzq_ = context.Operators.Interval(czzm_ as CqlDateTime, czzp_ as CqlDateTime, true, false);

                return czzq_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vzm_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzr_()
        {
            bool czzs_()
            {
                CodeableConcept czzt_ = condition?.ClinicalStatus;
                CqlConcept czzu_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzt_);
                CqlCode czzv_ = this.active(context);
                CqlConcept czzw_ = context.Operators.ConvertCodeToConcept(czzv_);
                bool? czzx_ = context.Operators.Equivalent(czzu_, czzw_);
                CqlConcept czzz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzt_);
                CqlCode dzza_ = this.recurrence(context);
                CqlConcept dzzb_ = context.Operators.ConvertCodeToConcept(dzza_);
                bool? dzzc_ = context.Operators.Equivalent(czzz_, dzzb_);
                bool? dzzd_ = context.Operators.Or(czzx_, dzzc_);
                CqlConcept dzzf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzt_);
                CqlCode dzzg_ = this.relapse(context);
                CqlConcept dzzh_ = context.Operators.ConvertCodeToConcept(dzzg_);
                bool? dzzi_ = context.Operators.Equivalent(dzzf_, dzzh_);
                bool? dzzj_ = context.Operators.Or(dzzd_, dzzi_);

                return dzzj_ ?? false;
            };
            if (czzs_())
            {
                DataType dzzk_ = condition?.Onset;
                object dzzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzk_);
                CqlInterval<CqlDateTime> dzzm_ = this.ToInterval(context, dzzl_);
                CqlDateTime dzzn_ = context.Operators.Start(dzzm_);
                CqlInterval<CqlDateTime> dzzo_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzp_ = context.Operators.End(dzzo_);
                CqlInterval<CqlDateTime> dzzq_ = context.Operators.Interval(dzzn_, dzzp_, true, true);

                return dzzq_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzr_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzs_ = context.Operators.End(dzzr_);
                CqlDateTime[] dzzt_ = [
                    dzzs_,
                ];
                CqlInterval<CqlDateTime> dzzu_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> dzzy_()
                    {
                        if (abatementDate is null)
                        {
                            DataType dzzz_ = condition?.Onset;
                            object ezza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzz_);
                            CqlInterval<CqlDateTime> ezzb_ = this.ToInterval(context, ezza_);
                            CqlDateTime ezzc_ = context.Operators.Start(ezzb_);
                            CqlInterval<CqlDateTime> ezzd_ = context.Operators.Interval(ezzc_, abatementDate, true, false);

                            return ezzd_;
                        }
                        else
                        {
                            DataType ezze_ = condition?.Onset;
                            object ezzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezze_);
                            CqlInterval<CqlDateTime> ezzg_ = this.ToInterval(context, ezzf_);
                            CqlDateTime ezzh_ = context.Operators.Start(ezzg_);
                            CqlInterval<CqlDateTime> ezzi_ = context.Operators.Interval(ezzh_, abatementDate, true, true);

                            return ezzi_;
                        }
                    };

                    return dzzy_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzv_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)dzzt_, dzzu_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzv_);
                CqlInterval<CqlDateTime> dzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzw_);

                return dzzx_;
            }
        };

        return czzr_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ezzj_()
        {
            bool ezzk_()
            {
                CodeableConcept ezzl_ = condition?.ClinicalStatus;
                CqlConcept ezzm_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzl_);
                CqlCode ezzn_ = this.active(context);
                CqlConcept ezzo_ = context.Operators.ConvertCodeToConcept(ezzn_);
                bool? ezzp_ = context.Operators.Equivalent(ezzm_, ezzo_);
                CqlConcept ezzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzl_);
                CqlCode ezzs_ = this.recurrence(context);
                CqlConcept ezzt_ = context.Operators.ConvertCodeToConcept(ezzs_);
                bool? ezzu_ = context.Operators.Equivalent(ezzr_, ezzt_);
                bool? ezzv_ = context.Operators.Or(ezzp_, ezzu_);
                CqlConcept ezzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzl_);
                CqlCode ezzy_ = this.relapse(context);
                CqlConcept ezzz_ = context.Operators.ConvertCodeToConcept(ezzy_);
                bool? fzza_ = context.Operators.Equivalent(ezzx_, ezzz_);
                bool? fzzb_ = context.Operators.Or(ezzv_, fzza_);

                return fzzb_ ?? false;
            };
            if (ezzk_())
            {
                DataType fzzc_ = condition?.Onset;
                object fzzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzc_);
                CqlInterval<CqlDateTime> fzze_ = this.toInterval(context, fzzd_);
                CqlDateTime fzzf_ = context.Operators.Start(fzze_);
                CqlInterval<CqlDateTime> fzzg_ = this.abatementInterval(context, condition);
                CqlDateTime fzzh_ = context.Operators.End(fzzg_);
                CqlInterval<CqlDateTime> fzzi_ = context.Operators.Interval(fzzf_, fzzh_, true, true);

                return fzzi_;
            }
            else
            {
                CqlInterval<CqlDateTime> fzzj_ = this.ToAbatementInterval(context, condition);
                CqlDateTime fzzk_ = context.Operators.End(fzzj_);
                CqlDateTime[] fzzl_ = [
                    fzzk_,
                ];
                CqlInterval<CqlDateTime> fzzm_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzq_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzr_ = condition?.Onset;
                            object fzzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzr_);
                            CqlInterval<CqlDateTime> fzzt_ = this.ToInterval(context, fzzs_);
                            CqlDateTime fzzu_ = context.Operators.Start(fzzt_);
                            CqlInterval<CqlDateTime> fzzv_ = context.Operators.Interval(fzzu_, abatementDate, true, false);

                            return fzzv_;
                        }
                        else
                        {
                            DataType fzzw_ = condition?.Onset;
                            object fzzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzw_);
                            CqlInterval<CqlDateTime> fzzy_ = this.ToInterval(context, fzzx_);
                            CqlDateTime fzzz_ = context.Operators.Start(fzzy_);
                            CqlInterval<CqlDateTime> gzza_ = context.Operators.Interval(fzzz_, abatementDate, true, true);

                            return gzza_;
                        }
                    };

                    return fzzq_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzn_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzl_, fzzm_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzn_);
                CqlInterval<CqlDateTime> fzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzo_);

                return fzzp_;
            }
        };

        return ezzj_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzb_ = context.Operators.Split(uri, "/");
        string gzzc_ = context.Operators.Last<string>(gzzb_);

        return gzzc_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzd_ = context.Operators.Split(uri, "/");
        string gzze_ = context.Operators.Last<string>(gzzd_);

        return gzze_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzf_ = context.Operators.Start(period);
        CqlDateTime gzzh_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzi_ = context.Operators.Equal(gzzf_, gzzh_);
        bool? gzzj_ = context.Operators.Or((bool?)(gzzf_ is null), gzzi_);
        bool? gzzk_ = context.Operators.Not(gzzj_);

        return gzzk_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzl_ = context.Operators.Start(period);
        CqlDateTime gzzn_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzo_ = context.Operators.Equal(gzzl_, gzzn_);
        bool? gzzp_ = context.Operators.Or((bool?)(gzzl_ is null), gzzo_);
        bool? gzzq_ = context.Operators.Not(gzzp_);

        return gzzq_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzr_ = context.Operators.End(period);
        CqlDateTime gzzt_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzu_ = context.Operators.Equal(gzzr_, gzzt_);
        bool? gzzv_ = context.Operators.Or((bool?)(gzzr_ is null), gzzu_);
        bool? gzzw_ = context.Operators.Not(gzzv_);

        return gzzw_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzx_ = context.Operators.End(period);
        CqlDateTime gzzz_ = context.Operators.MaxValue<CqlDateTime>();
        bool? hzza_ = context.Operators.Equal(gzzx_, gzzz_);
        bool? hzzb_ = context.Operators.Or((bool?)(gzzx_ is null), hzza_);
        bool? hzzc_ = context.Operators.Not(hzzb_);

        return hzzc_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzd_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzze_ = [
            hzzd_,
        ];
        CqlDateTime hzzf_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzj_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzk_ = context.Operators.End(period);

                    return hzzk_;
                }
                else
                {
                    CqlDateTime hzzl_ = context.Operators.Start(period);

                    return hzzl_;
                }
            };

            return hzzj_();
        };
        IEnumerable<CqlDateTime> hzzg_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzze_, hzzf_);
        IEnumerable<CqlDateTime> hzzh_ = context.Operators.Distinct<CqlDateTime>(hzzg_);
        CqlDateTime hzzi_ = context.Operators.SingletonFrom<CqlDateTime>(hzzh_);

        return hzzi_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzm_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzn_ = [
            hzzm_,
        ];
        CqlDateTime hzzo_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzs_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzt_ = context.Operators.End(period);

                    return hzzt_;
                }
                else
                {
                    CqlDateTime hzzu_ = context.Operators.Start(period);

                    return hzzu_;
                }
            };

            return hzzs_();
        };
        IEnumerable<CqlDateTime> hzzp_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzn_, hzzo_);
        IEnumerable<CqlDateTime> hzzq_ = context.Operators.Distinct<CqlDateTime>(hzzp_);
        CqlDateTime hzzr_ = context.Operators.SingletonFrom<CqlDateTime>(hzzq_);

        return hzzr_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzv_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzw_ = [
            hzzv_,
        ];
        CqlDateTime hzzx_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzb_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime izzc_ = context.Operators.Start(period);

                    return izzc_;
                }
                else
                {
                    CqlDateTime izzd_ = context.Operators.End(period);

                    return izzd_;
                }
            };

            return izzb_();
        };
        IEnumerable<CqlDateTime> hzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzw_, hzzx_);
        IEnumerable<CqlDateTime> hzzz_ = context.Operators.Distinct<CqlDateTime>(hzzy_);
        CqlDateTime izza_ = context.Operators.SingletonFrom<CqlDateTime>(hzzz_);

        return izza_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izze_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] izzf_ = [
            izze_,
        ];
        CqlDateTime izzg_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzk_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime izzl_ = context.Operators.Start(period);

                    return izzl_;
                }
                else
                {
                    CqlDateTime izzm_ = context.Operators.End(period);

                    return izzm_;
                }
            };

            return izzk_();
        };
        IEnumerable<CqlDateTime> izzh_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)izzf_, izzg_);
        IEnumerable<CqlDateTime> izzi_ = context.Operators.Distinct<CqlDateTime>(izzh_);
        CqlDateTime izzj_ = context.Operators.SingletonFrom<CqlDateTime>(izzi_);

        return izzj_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzn_ = context.Operators.Start(Period);
        CqlDateTime izzo_ = context.Operators.End(Period);
        int? izzp_ = context.Operators.DurationBetween(izzn_, izzo_, "day");
        CqlInterval<int?> izzq_ = context.Operators.Interval(1, izzp_, true, true);
        CqlInterval<int?>[] izzr_ = [
            izzq_,
        ];
        IEnumerable<CqlInterval<int?>> izzs_ = context.Operators.Expand(izzr_ as IEnumerable<CqlInterval<int?>>, default);
        int? izzt_(CqlInterval<int?> DayNumber)
        {
            int? izzw_ = context.Operators.End(DayNumber);

            return izzw_;
        };
        IEnumerable<int?> izzu_ = context.Operators.Select<CqlInterval<int?>, int?>(izzs_, izzt_);
        IEnumerable<int?> izzv_ = context.Operators.Distinct<int?>(izzu_);

        return izzv_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzx_ = context.Operators.Start(Period);
        CqlDateTime izzy_ = context.Operators.End(Period);
        int? izzz_ = context.Operators.DurationBetween(izzx_, izzy_, "day");
        CqlInterval<int?> jzza_ = context.Operators.Interval(1, izzz_, true, true);
        CqlInterval<int?>[] jzzb_ = [
            jzza_,
        ];
        IEnumerable<CqlInterval<int?>> jzzc_ = context.Operators.Expand(jzzb_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzzd_(CqlInterval<int?> DayNumber)
        {
            int? jzzg_ = context.Operators.End(DayNumber);

            return jzzg_;
        };
        IEnumerable<int?> jzze_ = context.Operators.Select<CqlInterval<int?>, int?>(jzzc_, jzzd_);
        IEnumerable<int?> jzzf_ = context.Operators.Distinct<int?>(jzze_);

        return jzzf_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> jzzh_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzi_(int? DayIndex)
        {
            CqlDateTime jzzl_ = context.Operators.Start(Period);
            CqlQuantity jzzm_ = context.Operators.Quantity(24m, "hours");
            int? jzzn_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzzo_ = context.Operators.ConvertIntegerToQuantity(jzzn_);
            CqlQuantity jzzp_ = context.Operators.Multiply(jzzm_, jzzo_);
            CqlDateTime jzzq_ = context.Operators.Add(jzzl_, jzzp_);
            CqlDateTime jzzr_()
            {
                bool jzzu_()
                {
                    CqlDateTime jzzv_ = context.Operators.Start(Period);
                    CqlQuantity jzzw_ = context.Operators.Quantity(24m, "hours");
                    int? jzzx_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzy_ = context.Operators.ConvertIntegerToQuantity(jzzx_);
                    CqlQuantity jzzz_ = context.Operators.Multiply(jzzw_, jzzy_);
                    CqlDateTime kzza_ = context.Operators.Add(jzzv_, jzzz_);
                    CqlDateTime kzzb_ = context.Operators.End(Period);
                    int? kzzc_ = context.Operators.DurationBetween(kzza_, kzzb_, "hour");
                    bool? kzzd_ = context.Operators.Less(kzzc_, 24);

                    return kzzd_ ?? false;
                };
                if (jzzu_())
                {
                    CqlDateTime kzze_ = context.Operators.Start(Period);
                    CqlQuantity kzzf_ = context.Operators.Quantity(24m, "hours");
                    int? kzzg_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzh_ = context.Operators.ConvertIntegerToQuantity(kzzg_);
                    CqlQuantity kzzi_ = context.Operators.Multiply(kzzf_, kzzh_);
                    CqlDateTime kzzj_ = context.Operators.Add(kzze_, kzzi_);

                    return kzzj_;
                }
                else
                {
                    CqlDateTime kzzk_ = context.Operators.Start(Period);
                    CqlQuantity kzzl_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzm_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzn_ = context.Operators.Multiply(kzzl_, kzzm_);
                    CqlDateTime kzzo_ = context.Operators.Add(kzzk_, kzzn_);

                    return kzzo_;
                }
            };
            CqlInterval<CqlDateTime> jzzs_ = context.Operators.Interval(jzzq_, jzzr_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzt_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzs_);

            return jzzt_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzj_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzh_, jzzi_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzk_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzj_);

        return jzzk_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzp_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzq_(int? DayIndex)
        {
            CqlDateTime kzzt_ = context.Operators.Start(Period);
            CqlQuantity kzzu_ = context.Operators.Quantity(24m, "hours");
            int? kzzv_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity kzzw_ = context.Operators.ConvertIntegerToQuantity(kzzv_);
            CqlQuantity kzzx_ = context.Operators.Multiply(kzzu_, kzzw_);
            CqlDateTime kzzy_ = context.Operators.Add(kzzt_, kzzx_);
            CqlDateTime kzzz_()
            {
                bool lzzc_()
                {
                    CqlDateTime lzzd_ = context.Operators.Start(Period);
                    CqlQuantity lzze_ = context.Operators.Quantity(24m, "hours");
                    int? lzzf_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzg_ = context.Operators.ConvertIntegerToQuantity(lzzf_);
                    CqlQuantity lzzh_ = context.Operators.Multiply(lzze_, lzzg_);
                    CqlDateTime lzzi_ = context.Operators.Add(lzzd_, lzzh_);
                    CqlDateTime lzzj_ = context.Operators.End(Period);
                    int? lzzk_ = context.Operators.DurationBetween(lzzi_, lzzj_, "hour");
                    bool? lzzl_ = context.Operators.Less(lzzk_, 24);

                    return lzzl_ ?? false;
                };
                if (lzzc_())
                {
                    CqlDateTime lzzm_ = context.Operators.Start(Period);
                    CqlQuantity lzzn_ = context.Operators.Quantity(24m, "hours");
                    int? lzzo_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzp_ = context.Operators.ConvertIntegerToQuantity(lzzo_);
                    CqlQuantity lzzq_ = context.Operators.Multiply(lzzn_, lzzp_);
                    CqlDateTime lzzr_ = context.Operators.Add(lzzm_, lzzq_);

                    return lzzr_;
                }
                else
                {
                    CqlDateTime lzzs_ = context.Operators.Start(Period);
                    CqlQuantity lzzt_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity lzzu_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity lzzv_ = context.Operators.Multiply(lzzt_, lzzu_);
                    CqlDateTime lzzw_ = context.Operators.Add(lzzs_, lzzv_);

                    return lzzw_;
                }
            };
            CqlInterval<CqlDateTime> lzza_ = context.Operators.Interval(kzzy_, kzzz_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? lzzb_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, lzza_);

            return lzzb_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzr_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzp_, kzzq_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzs_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzr_);

        return kzzs_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
