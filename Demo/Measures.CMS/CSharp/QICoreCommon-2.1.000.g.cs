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
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null, []);

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
        IEnumerable<Patient> bzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient bzx_ = context.Operators.SingletonFrom<Patient>(bzw_);

        return bzx_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept bzy_ = condition?.ClinicalStatus;
        CqlConcept bzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzy_);
        CqlCode cza_ = this.active(context);
        CqlConcept czb_ = context.Operators.ConvertCodeToConcept(cza_);
        bool? czc_ = context.Operators.Equivalent(bzz_, czb_);
        CqlConcept cze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzy_);
        CqlCode czf_ = this.recurrence(context);
        CqlConcept czg_ = context.Operators.ConvertCodeToConcept(czf_);
        bool? czh_ = context.Operators.Equivalent(cze_, czg_);
        bool? czi_ = context.Operators.Or(czc_, czh_);
        CqlConcept czk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzy_);
        CqlCode czl_ = this.relapse(context);
        CqlConcept czm_ = context.Operators.ConvertCodeToConcept(czl_);
        bool? czn_ = context.Operators.Equivalent(czk_, czm_);
        bool? czo_ = context.Operators.Or(czi_, czn_);

        return czo_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> czp_ = condition?.Category;
        CqlConcept czq_(CodeableConcept @this)
        {
            CqlConcept czv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return czv_;
        };
        IEnumerable<CqlConcept> czr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czp_, czq_);
        bool? czs_(CqlConcept C)
        {
            CqlConcept czw_ = context.Operators.ConvertCodeToConcept(category);
            bool? czx_ = context.Operators.Equivalent(C, czw_);

            return czx_;
        };
        IEnumerable<CqlConcept> czt_ = context.Operators.Where<CqlConcept>(czr_, czs_);
        bool? czu_ = context.Operators.Exists<CqlConcept>(czt_);

        return czu_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> czy_ = observation?.Category;
        CqlConcept czz_(CodeableConcept @this)
        {
            CqlConcept dze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dze_;
        };
        IEnumerable<CqlConcept> dza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czy_, czz_);
        bool? dzb_(CqlConcept C)
        {
            CqlConcept dzf_ = context.Operators.ConvertCodeToConcept(category);
            bool? dzg_ = context.Operators.Equivalent(C, dzf_);

            return dzg_;
        };
        IEnumerable<CqlConcept> dzc_ = context.Operators.Where<CqlConcept>(dza_, dzb_);
        bool? dzd_ = context.Operators.Exists<CqlConcept>(dzc_);

        return dzd_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> dzh_ = condition?.Category;
        CqlConcept dzi_(CodeableConcept @this)
        {
            CqlConcept dzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzn_;
        };
        IEnumerable<CqlConcept> dzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzh_, dzi_);
        bool? dzk_(CqlConcept C)
        {
            CqlCode dzo_ = this.problem_list_item(context);
            CqlConcept dzp_ = context.Operators.ConvertCodeToConcept(dzo_);
            bool? dzq_ = context.Operators.Equivalent(C, dzp_);

            return dzq_;
        };
        IEnumerable<CqlConcept> dzl_ = context.Operators.Where<CqlConcept>(dzj_, dzk_);
        bool? dzm_ = context.Operators.Exists<CqlConcept>(dzl_);

        return dzm_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> dzr_ = condition?.Category;
        CqlConcept dzs_(CodeableConcept @this)
        {
            CqlConcept dzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzx_;
        };
        IEnumerable<CqlConcept> dzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzr_, dzs_);
        bool? dzu_(CqlConcept C)
        {
            CqlCode dzy_ = this.encounter_diagnosis(context);
            CqlConcept dzz_ = context.Operators.ConvertCodeToConcept(dzy_);
            bool? eza_ = context.Operators.Equivalent(C, dzz_);

            return eza_;
        };
        IEnumerable<CqlConcept> dzv_ = context.Operators.Where<CqlConcept>(dzt_, dzu_);
        bool? dzw_ = context.Operators.Exists<CqlConcept>(dzv_);

        return dzw_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> ezb_ = condition?.Category;
        CqlConcept ezc_(CodeableConcept @this)
        {
            CqlConcept ezh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return ezh_;
        };
        IEnumerable<CqlConcept> ezd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezb_, ezc_);
        bool? eze_(CqlConcept C)
        {
            CqlCode ezi_ = this.health_concern(context);
            CqlConcept ezj_ = context.Operators.ConvertCodeToConcept(ezi_);
            bool? ezk_ = context.Operators.Equivalent(C, ezj_);

            return ezk_;
        };
        IEnumerable<CqlConcept> ezf_ = context.Operators.Where<CqlConcept>(ezd_, eze_);
        bool? ezg_ = context.Operators.Exists<CqlConcept>(ezf_);

        return ezg_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> ezl_ = observation?.Category;
        CqlConcept ezm_(CodeableConcept @this)
        {
            CqlConcept ezr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return ezr_;
        };
        IEnumerable<CqlConcept> ezn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezl_, ezm_);
        bool? ezo_(CqlConcept C)
        {
            CqlCode ezs_ = this.social_history(context);
            CqlConcept ezt_ = context.Operators.ConvertCodeToConcept(ezs_);
            bool? ezu_ = context.Operators.Equivalent(C, ezt_);

            return ezu_;
        };
        IEnumerable<CqlConcept> ezp_ = context.Operators.Where<CqlConcept>(ezn_, ezo_);
        bool? ezq_ = context.Operators.Exists<CqlConcept>(ezp_);

        return ezq_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> ezv_ = observation?.Category;
        CqlConcept ezw_(CodeableConcept @this)
        {
            CqlConcept fzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return fzb_;
        };
        IEnumerable<CqlConcept> ezx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezv_, ezw_);
        bool? ezy_(CqlConcept C)
        {
            CqlCode fzc_ = this.vital_signs(context);
            CqlConcept fzd_ = context.Operators.ConvertCodeToConcept(fzc_);
            bool? fze_ = context.Operators.Equivalent(C, fzd_);

            return fze_;
        };
        IEnumerable<CqlConcept> ezz_ = context.Operators.Where<CqlConcept>(ezx_, ezy_);
        bool? fza_ = context.Operators.Exists<CqlConcept>(ezz_);

        return fza_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> fzf_ = observation?.Category;
        CqlConcept fzg_(CodeableConcept @this)
        {
            CqlConcept fzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return fzl_;
        };
        IEnumerable<CqlConcept> fzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzf_, fzg_);
        bool? fzi_(CqlConcept C)
        {
            CqlCode fzm_ = this.imaging(context);
            CqlConcept fzn_ = context.Operators.ConvertCodeToConcept(fzm_);
            bool? fzo_ = context.Operators.Equivalent(C, fzn_);

            return fzo_;
        };
        IEnumerable<CqlConcept> fzj_ = context.Operators.Where<CqlConcept>(fzh_, fzi_);
        bool? fzk_ = context.Operators.Exists<CqlConcept>(fzj_);

        return fzk_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> fzp_ = observation?.Category;
        CqlConcept fzq_(CodeableConcept @this)
        {
            CqlConcept fzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return fzv_;
        };
        IEnumerable<CqlConcept> fzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzp_, fzq_);
        bool? fzs_(CqlConcept C)
        {
            CqlCode fzw_ = this.laboratory(context);
            CqlConcept fzx_ = context.Operators.ConvertCodeToConcept(fzw_);
            bool? fzy_ = context.Operators.Equivalent(C, fzx_);

            return fzy_;
        };
        IEnumerable<CqlConcept> fzt_ = context.Operators.Where<CqlConcept>(fzr_, fzs_);
        bool? fzu_ = context.Operators.Exists<CqlConcept>(fzt_);

        return fzu_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> fzz_ = observation?.Category;
        CqlConcept gza_(CodeableConcept @this)
        {
            CqlConcept gzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return gzf_;
        };
        IEnumerable<CqlConcept> gzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzz_, gza_);
        bool? gzc_(CqlConcept C)
        {
            CqlCode gzg_ = this.procedure(context);
            CqlConcept gzh_ = context.Operators.ConvertCodeToConcept(gzg_);
            bool? gzi_ = context.Operators.Equivalent(C, gzh_);

            return gzi_;
        };
        IEnumerable<CqlConcept> gzd_ = context.Operators.Where<CqlConcept>(gzb_, gzc_);
        bool? gze_ = context.Operators.Exists<CqlConcept>(gzd_);

        return gze_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> gzj_ = observation?.Category;
        CqlConcept gzk_(CodeableConcept @this)
        {
            CqlConcept gzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return gzp_;
        };
        IEnumerable<CqlConcept> gzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzj_, gzk_);
        bool? gzm_(CqlConcept C)
        {
            CqlCode gzq_ = this.survey(context);
            CqlConcept gzr_ = context.Operators.ConvertCodeToConcept(gzq_);
            bool? gzs_ = context.Operators.Equivalent(C, gzr_);

            return gzs_;
        };
        IEnumerable<CqlConcept> gzn_ = context.Operators.Where<CqlConcept>(gzl_, gzm_);
        bool? gzo_ = context.Operators.Exists<CqlConcept>(gzn_);

        return gzo_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> gzt_ = observation?.Category;
        CqlConcept gzu_(CodeableConcept @this)
        {
            CqlConcept gzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return gzz_;
        };
        IEnumerable<CqlConcept> gzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzt_, gzu_);
        bool? gzw_(CqlConcept C)
        {
            CqlCode hza_ = this.exam(context);
            CqlConcept hzb_ = context.Operators.ConvertCodeToConcept(hza_);
            bool? hzc_ = context.Operators.Equivalent(C, hzb_);

            return hzc_;
        };
        IEnumerable<CqlConcept> gzx_ = context.Operators.Where<CqlConcept>(gzv_, gzw_);
        bool? gzy_ = context.Operators.Exists<CqlConcept>(gzx_);

        return gzy_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> hzd_ = observation?.Category;
        CqlConcept hze_(CodeableConcept @this)
        {
            CqlConcept hzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return hzj_;
        };
        IEnumerable<CqlConcept> hzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzd_, hze_);
        bool? hzg_(CqlConcept C)
        {
            CqlCode hzk_ = this.therapy(context);
            CqlConcept hzl_ = context.Operators.ConvertCodeToConcept(hzk_);
            bool? hzm_ = context.Operators.Equivalent(C, hzl_);

            return hzm_;
        };
        IEnumerable<CqlConcept> hzh_ = context.Operators.Where<CqlConcept>(hzf_, hzg_);
        bool? hzi_ = context.Operators.Exists<CqlConcept>(hzh_);

        return hzi_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> hzn_ = observation?.Category;
        CqlConcept hzo_(CodeableConcept @this)
        {
            CqlConcept hzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return hzt_;
        };
        IEnumerable<CqlConcept> hzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzn_, hzo_);
        bool? hzq_(CqlConcept C)
        {
            CqlCode hzu_ = this.activity(context);
            CqlConcept hzv_ = context.Operators.ConvertCodeToConcept(hzu_);
            bool? hzw_ = context.Operators.Equivalent(C, hzv_);

            return hzw_;
        };
        IEnumerable<CqlConcept> hzr_ = context.Operators.Where<CqlConcept>(hzp_, hzq_);
        bool? hzs_ = context.Operators.Exists<CqlConcept>(hzr_);

        return hzs_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> hzx_ = medicationRequest?.Category;
        CqlConcept hzy_(CodeableConcept @this)
        {
            CqlConcept izd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return izd_;
        };
        IEnumerable<CqlConcept> hzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzx_, hzy_);
        bool? iza_(CqlConcept C)
        {
            CqlCode ize_ = this.Community(context);
            CqlConcept izf_ = context.Operators.ConvertCodeToConcept(ize_);
            bool? izg_ = context.Operators.Equivalent(C, izf_);

            return izg_;
        };
        IEnumerable<CqlConcept> izb_ = context.Operators.Where<CqlConcept>(hzz_, iza_);
        bool? izc_ = context.Operators.Exists<CqlConcept>(izb_);

        return izc_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> izh_ = medicationRequest?.Category;
        CqlConcept izi_(CodeableConcept @this)
        {
            CqlConcept izn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return izn_;
        };
        IEnumerable<CqlConcept> izj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izh_, izi_);
        bool? izk_(CqlConcept C)
        {
            CqlCode izo_ = this.Discharge(context);
            CqlConcept izp_ = context.Operators.ConvertCodeToConcept(izo_);
            bool? izq_ = context.Operators.Equivalent(C, izp_);

            return izq_;
        };
        IEnumerable<CqlConcept> izl_ = context.Operators.Where<CqlConcept>(izj_, izk_);
        bool? izm_ = context.Operators.Exists<CqlConcept>(izl_);

        return izm_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? izr_(Extension E)
        {
            string izx_ = E?.Url;
            FhirString izy_ = context.Operators.Convert<FhirString>(izx_);
            string izz_ = izy_?.Value;
            bool? jza_ = context.Operators.Equal(izz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return jza_;
        };
        IEnumerable<Extension> izs_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), izr_);
        bool? izt_(Extension E)
        {
            DataType jzb_ = E?.Value;
            object jzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzb_);

            return jzc_ as bool?;
        };
        IEnumerable<bool?> izu_ = context.Operators.Select<Extension, bool?>(izs_, izt_);
        IEnumerable<bool?> izv_ = context.Operators.Distinct<bool?>(izu_);
        bool? izw_ = context.Operators.SingletonFrom<bool?>(izv_);

        return izw_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzd_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jze_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jze_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzf_ = this.Patient(context);
                Date jzg_ = jzf_?.BirthDateElement;
                string jzh_ = jzg_?.Value;
                CqlDate jzi_ = context.Operators.ConvertStringToDate(jzh_);
                CqlDate jzj_ = context.Operators.Add(jzi_, choice as CqlQuantity);
                Date jzl_ = jzf_?.BirthDateElement;
                string jzm_ = jzl_?.Value;
                CqlDate jzn_ = context.Operators.ConvertStringToDate(jzm_);
                CqlDate jzo_ = context.Operators.Add(jzn_, choice as CqlQuantity);
                CqlQuantity jzp_ = context.Operators.Quantity(1m, "year");
                CqlDate jzq_ = context.Operators.Add(jzo_, jzp_);
                CqlInterval<CqlDate> jzr_ = context.Operators.Interval(jzj_, jzq_, true, false);
                CqlDate jzs_ = jzr_?.low;
                CqlDateTime jzt_ = context.Operators.ConvertDateToDateTime(jzs_);
                Date jzv_ = jzf_?.BirthDateElement;
                string jzw_ = jzv_?.Value;
                CqlDate jzx_ = context.Operators.ConvertStringToDate(jzw_);
                CqlDate jzy_ = context.Operators.Add(jzx_, choice as CqlQuantity);
                Date kza_ = jzf_?.BirthDateElement;
                string kzb_ = kza_?.Value;
                CqlDate kzc_ = context.Operators.ConvertStringToDate(kzb_);
                CqlDate kzd_ = context.Operators.Add(kzc_, choice as CqlQuantity);
                CqlDate kzf_ = context.Operators.Add(kzd_, jzp_);
                CqlInterval<CqlDate> kzg_ = context.Operators.Interval(jzy_, kzf_, true, false);
                CqlDate kzh_ = kzg_?.high;
                CqlDateTime kzi_ = context.Operators.ConvertDateToDateTime(kzh_);
                Date kzk_ = jzf_?.BirthDateElement;
                string kzl_ = kzk_?.Value;
                CqlDate kzm_ = context.Operators.ConvertStringToDate(kzl_);
                CqlDate kzn_ = context.Operators.Add(kzm_, choice as CqlQuantity);
                Date kzp_ = jzf_?.BirthDateElement;
                string kzq_ = kzp_?.Value;
                CqlDate kzr_ = context.Operators.ConvertStringToDate(kzq_);
                CqlDate kzs_ = context.Operators.Add(kzr_, choice as CqlQuantity);
                CqlDate kzu_ = context.Operators.Add(kzs_, jzp_);
                CqlInterval<CqlDate> kzv_ = context.Operators.Interval(kzn_, kzu_, true, false);
                bool? kzw_ = kzv_?.lowClosed;
                Date kzy_ = jzf_?.BirthDateElement;
                string kzz_ = kzy_?.Value;
                CqlDate lza_ = context.Operators.ConvertStringToDate(kzz_);
                CqlDate lzb_ = context.Operators.Add(lza_, choice as CqlQuantity);
                Date lzd_ = jzf_?.BirthDateElement;
                string lze_ = lzd_?.Value;
                CqlDate lzf_ = context.Operators.ConvertStringToDate(lze_);
                CqlDate lzg_ = context.Operators.Add(lzf_, choice as CqlQuantity);
                CqlDate lzi_ = context.Operators.Add(lzg_, jzp_);
                CqlInterval<CqlDate> lzj_ = context.Operators.Interval(lzb_, lzi_, true, false);
                bool? lzk_ = lzj_?.highClosed;
                CqlInterval<CqlDateTime> lzl_ = context.Operators.Interval(jzt_, kzi_, kzw_, lzk_);

                return lzl_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzm_ = this.Patient(context);
                Date lzn_ = lzm_?.BirthDateElement;
                string lzo_ = lzn_?.Value;
                CqlDate lzp_ = context.Operators.ConvertStringToDate(lzo_);
                object lzq_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzr_ = context.Operators.Add(lzp_, lzq_ as CqlQuantity);
                Date lzt_ = lzm_?.BirthDateElement;
                string lzu_ = lzt_?.Value;
                CqlDate lzv_ = context.Operators.ConvertStringToDate(lzu_);
                object lzw_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate lzx_ = context.Operators.Add(lzv_, lzw_ as CqlQuantity);
                CqlQuantity lzy_ = context.Operators.Quantity(1m, "year");
                CqlDate lzz_ = context.Operators.Add(lzx_, lzy_);
                CqlInterval<CqlDate> mza_ = context.Operators.Interval(lzr_, lzz_, true, false);
                CqlDate mzb_ = mza_?.low;
                CqlDateTime mzc_ = context.Operators.ConvertDateToDateTime(mzb_);
                Date mze_ = lzm_?.BirthDateElement;
                string mzf_ = mze_?.Value;
                CqlDate mzg_ = context.Operators.ConvertStringToDate(mzf_);
                CqlDate mzi_ = context.Operators.Add(mzg_, lzq_ as CqlQuantity);
                Date mzk_ = lzm_?.BirthDateElement;
                string mzl_ = mzk_?.Value;
                CqlDate mzm_ = context.Operators.ConvertStringToDate(mzl_);
                CqlDate mzo_ = context.Operators.Add(mzm_, lzw_ as CqlQuantity);
                CqlDate mzq_ = context.Operators.Add(mzo_, lzy_);
                CqlInterval<CqlDate> mzr_ = context.Operators.Interval(mzi_, mzq_, true, false);
                CqlDate mzs_ = mzr_?.high;
                CqlDateTime mzt_ = context.Operators.ConvertDateToDateTime(mzs_);
                Date mzv_ = lzm_?.BirthDateElement;
                string mzw_ = mzv_?.Value;
                CqlDate mzx_ = context.Operators.ConvertStringToDate(mzw_);
                CqlDate mzz_ = context.Operators.Add(mzx_, lzq_ as CqlQuantity);
                Date nzb_ = lzm_?.BirthDateElement;
                string nzc_ = nzb_?.Value;
                CqlDate nzd_ = context.Operators.ConvertStringToDate(nzc_);
                CqlDate nzf_ = context.Operators.Add(nzd_, lzw_ as CqlQuantity);
                CqlDate nzh_ = context.Operators.Add(nzf_, lzy_);
                CqlInterval<CqlDate> nzi_ = context.Operators.Interval(mzz_, nzh_, true, false);
                bool? nzj_ = nzi_?.lowClosed;
                Date nzl_ = lzm_?.BirthDateElement;
                string nzm_ = nzl_?.Value;
                CqlDate nzn_ = context.Operators.ConvertStringToDate(nzm_);
                CqlDate nzp_ = context.Operators.Add(nzn_, lzq_ as CqlQuantity);
                Date nzr_ = lzm_?.BirthDateElement;
                string nzs_ = nzr_?.Value;
                CqlDate nzt_ = context.Operators.ConvertStringToDate(nzs_);
                CqlDate nzv_ = context.Operators.Add(nzt_, lzw_ as CqlQuantity);
                CqlDate nzx_ = context.Operators.Add(nzv_, lzy_);
                CqlInterval<CqlDate> nzy_ = context.Operators.Interval(nzp_, nzx_, true, false);
                bool? nzz_ = nzy_?.highClosed;
                CqlInterval<CqlDateTime> oza_ = context.Operators.Interval(mzc_, mzt_, nzj_, nzz_);

                return oza_;
            }
            else if (choice is Timing)
            {
                object ozb_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return ozb_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzd_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ozc_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ozd_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ozd_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient oze_ = this.Patient(context);
                Date ozf_ = oze_?.BirthDateElement;
                string ozg_ = ozf_?.Value;
                CqlDate ozh_ = context.Operators.ConvertStringToDate(ozg_);
                CqlDate ozi_ = context.Operators.Add(ozh_, choice as CqlQuantity);
                Date ozk_ = oze_?.BirthDateElement;
                string ozl_ = ozk_?.Value;
                CqlDate ozm_ = context.Operators.ConvertStringToDate(ozl_);
                CqlDate ozn_ = context.Operators.Add(ozm_, choice as CqlQuantity);
                CqlQuantity ozo_ = context.Operators.Quantity(1m, "year");
                CqlDate ozp_ = context.Operators.Add(ozn_, ozo_);
                CqlInterval<CqlDate> ozq_ = context.Operators.Interval(ozi_, ozp_, true, false);
                CqlDate ozr_ = ozq_?.low;
                CqlDateTime ozs_ = context.Operators.ConvertDateToDateTime(ozr_);
                Date ozu_ = oze_?.BirthDateElement;
                string ozv_ = ozu_?.Value;
                CqlDate ozw_ = context.Operators.ConvertStringToDate(ozv_);
                CqlDate ozx_ = context.Operators.Add(ozw_, choice as CqlQuantity);
                Date ozz_ = oze_?.BirthDateElement;
                string pza_ = ozz_?.Value;
                CqlDate pzb_ = context.Operators.ConvertStringToDate(pza_);
                CqlDate pzc_ = context.Operators.Add(pzb_, choice as CqlQuantity);
                CqlDate pze_ = context.Operators.Add(pzc_, ozo_);
                CqlInterval<CqlDate> pzf_ = context.Operators.Interval(ozx_, pze_, true, false);
                CqlDate pzg_ = pzf_?.high;
                CqlDateTime pzh_ = context.Operators.ConvertDateToDateTime(pzg_);
                Date pzj_ = oze_?.BirthDateElement;
                string pzk_ = pzj_?.Value;
                CqlDate pzl_ = context.Operators.ConvertStringToDate(pzk_);
                CqlDate pzm_ = context.Operators.Add(pzl_, choice as CqlQuantity);
                Date pzo_ = oze_?.BirthDateElement;
                string pzp_ = pzo_?.Value;
                CqlDate pzq_ = context.Operators.ConvertStringToDate(pzp_);
                CqlDate pzr_ = context.Operators.Add(pzq_, choice as CqlQuantity);
                CqlDate pzt_ = context.Operators.Add(pzr_, ozo_);
                CqlInterval<CqlDate> pzu_ = context.Operators.Interval(pzm_, pzt_, true, false);
                bool? pzv_ = pzu_?.lowClosed;
                Date pzx_ = oze_?.BirthDateElement;
                string pzy_ = pzx_?.Value;
                CqlDate pzz_ = context.Operators.ConvertStringToDate(pzy_);
                CqlDate qza_ = context.Operators.Add(pzz_, choice as CqlQuantity);
                Date qzc_ = oze_?.BirthDateElement;
                string qzd_ = qzc_?.Value;
                CqlDate qze_ = context.Operators.ConvertStringToDate(qzd_);
                CqlDate qzf_ = context.Operators.Add(qze_, choice as CqlQuantity);
                CqlDate qzh_ = context.Operators.Add(qzf_, ozo_);
                CqlInterval<CqlDate> qzi_ = context.Operators.Interval(qza_, qzh_, true, false);
                bool? qzj_ = qzi_?.highClosed;
                CqlInterval<CqlDateTime> qzk_ = context.Operators.Interval(ozs_, pzh_, pzv_, qzj_);

                return qzk_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient qzl_ = this.Patient(context);
                Date qzm_ = qzl_?.BirthDateElement;
                string qzn_ = qzm_?.Value;
                CqlDate qzo_ = context.Operators.ConvertStringToDate(qzn_);
                object qzp_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate qzq_ = context.Operators.Add(qzo_, qzp_ as CqlQuantity);
                Date qzs_ = qzl_?.BirthDateElement;
                string qzt_ = qzs_?.Value;
                CqlDate qzu_ = context.Operators.ConvertStringToDate(qzt_);
                object qzv_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate qzw_ = context.Operators.Add(qzu_, qzv_ as CqlQuantity);
                CqlQuantity qzx_ = context.Operators.Quantity(1m, "year");
                CqlDate qzy_ = context.Operators.Add(qzw_, qzx_);
                CqlInterval<CqlDate> qzz_ = context.Operators.Interval(qzq_, qzy_, true, false);
                CqlDate rza_ = qzz_?.low;
                CqlDateTime rzb_ = context.Operators.ConvertDateToDateTime(rza_);
                Date rzd_ = qzl_?.BirthDateElement;
                string rze_ = rzd_?.Value;
                CqlDate rzf_ = context.Operators.ConvertStringToDate(rze_);
                CqlDate rzh_ = context.Operators.Add(rzf_, qzp_ as CqlQuantity);
                Date rzj_ = qzl_?.BirthDateElement;
                string rzk_ = rzj_?.Value;
                CqlDate rzl_ = context.Operators.ConvertStringToDate(rzk_);
                CqlDate rzn_ = context.Operators.Add(rzl_, qzv_ as CqlQuantity);
                CqlDate rzp_ = context.Operators.Add(rzn_, qzx_);
                CqlInterval<CqlDate> rzq_ = context.Operators.Interval(rzh_, rzp_, true, false);
                CqlDate rzr_ = rzq_?.high;
                CqlDateTime rzs_ = context.Operators.ConvertDateToDateTime(rzr_);
                Date rzu_ = qzl_?.BirthDateElement;
                string rzv_ = rzu_?.Value;
                CqlDate rzw_ = context.Operators.ConvertStringToDate(rzv_);
                CqlDate rzy_ = context.Operators.Add(rzw_, qzp_ as CqlQuantity);
                Date sza_ = qzl_?.BirthDateElement;
                string szb_ = sza_?.Value;
                CqlDate szc_ = context.Operators.ConvertStringToDate(szb_);
                CqlDate sze_ = context.Operators.Add(szc_, qzv_ as CqlQuantity);
                CqlDate szg_ = context.Operators.Add(sze_, qzx_);
                CqlInterval<CqlDate> szh_ = context.Operators.Interval(rzy_, szg_, true, false);
                bool? szi_ = szh_?.lowClosed;
                Date szk_ = qzl_?.BirthDateElement;
                string szl_ = szk_?.Value;
                CqlDate szm_ = context.Operators.ConvertStringToDate(szl_);
                CqlDate szo_ = context.Operators.Add(szm_, qzp_ as CqlQuantity);
                Date szq_ = qzl_?.BirthDateElement;
                string szr_ = szq_?.Value;
                CqlDate szs_ = context.Operators.ConvertStringToDate(szr_);
                CqlDate szu_ = context.Operators.Add(szs_, qzv_ as CqlQuantity);
                CqlDate szw_ = context.Operators.Add(szu_, qzx_);
                CqlInterval<CqlDate> szx_ = context.Operators.Interval(szo_, szw_, true, false);
                bool? szy_ = szx_?.highClosed;
                CqlInterval<CqlDateTime> szz_ = context.Operators.Interval(rzb_, rzs_, szi_, szy_);

                return szz_;
            }
            else if (choice is Timing)
            {
                object tza_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return tza_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ozc_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> tzb_()
        {
            bool tzc_()
            {
                DataType tzg_ = condition?.Abatement;
                object tzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzg_);
                bool tzi_ = tzh_ is CqlDateTime;

                return tzi_;
            };
            bool tzd_()
            {
                DataType tzj_ = condition?.Abatement;
                object tzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzj_);
                bool tzl_ = tzk_ is CqlQuantity;

                return tzl_;
            };
            bool tze_()
            {
                DataType tzm_ = condition?.Abatement;
                object tzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzm_);
                bool tzo_ = tzn_ is CqlInterval<CqlQuantity>;

                return tzo_;
            };
            bool tzf_()
            {
                DataType tzp_ = condition?.Abatement;
                object tzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzp_);
                bool tzr_ = tzq_ is CqlInterval<CqlDateTime>;

                return tzr_;
            };
            if (tzc_())
            {
                DataType tzs_ = condition?.Abatement;
                object tzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzs_);
                object tzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzs_);
                CqlInterval<CqlDateTime> tzw_ = context.Operators.Interval(tzt_ as CqlDateTime, tzv_ as CqlDateTime, true, true);

                return tzw_;
            }
            else if (tzd_())
            {
                Patient tzx_ = this.Patient(context);
                Date tzy_ = tzx_?.BirthDateElement;
                string tzz_ = tzy_?.Value;
                CqlDate uza_ = context.Operators.ConvertStringToDate(tzz_);
                DataType uzb_ = condition?.Abatement;
                object uzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate uzd_ = context.Operators.Add(uza_, uzc_ as CqlQuantity);
                Date uzf_ = tzx_?.BirthDateElement;
                string uzg_ = uzf_?.Value;
                CqlDate uzh_ = context.Operators.ConvertStringToDate(uzg_);
                object uzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate uzk_ = context.Operators.Add(uzh_, uzj_ as CqlQuantity);
                CqlQuantity uzl_ = context.Operators.Quantity(1m, "year");
                CqlDate uzm_ = context.Operators.Add(uzk_, uzl_);
                CqlInterval<CqlDate> uzn_ = context.Operators.Interval(uzd_, uzm_, true, false);
                CqlDate uzo_ = uzn_?.low;
                CqlDateTime uzp_ = context.Operators.ConvertDateToDateTime(uzo_);
                Date uzr_ = tzx_?.BirthDateElement;
                string uzs_ = uzr_?.Value;
                CqlDate uzt_ = context.Operators.ConvertStringToDate(uzs_);
                object uzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate uzw_ = context.Operators.Add(uzt_, uzv_ as CqlQuantity);
                Date uzy_ = tzx_?.BirthDateElement;
                string uzz_ = uzy_?.Value;
                CqlDate vza_ = context.Operators.ConvertStringToDate(uzz_);
                object vzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate vzd_ = context.Operators.Add(vza_, vzc_ as CqlQuantity);
                CqlDate vzf_ = context.Operators.Add(vzd_, uzl_);
                CqlInterval<CqlDate> vzg_ = context.Operators.Interval(uzw_, vzf_, true, false);
                CqlDate vzh_ = vzg_?.high;
                CqlDateTime vzi_ = context.Operators.ConvertDateToDateTime(vzh_);
                Date vzk_ = tzx_?.BirthDateElement;
                string vzl_ = vzk_?.Value;
                CqlDate vzm_ = context.Operators.ConvertStringToDate(vzl_);
                object vzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate vzp_ = context.Operators.Add(vzm_, vzo_ as CqlQuantity);
                Date vzr_ = tzx_?.BirthDateElement;
                string vzs_ = vzr_?.Value;
                CqlDate vzt_ = context.Operators.ConvertStringToDate(vzs_);
                object vzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate vzw_ = context.Operators.Add(vzt_, vzv_ as CqlQuantity);
                CqlDate vzy_ = context.Operators.Add(vzw_, uzl_);
                CqlInterval<CqlDate> vzz_ = context.Operators.Interval(vzp_, vzy_, true, false);
                bool? wza_ = vzz_?.lowClosed;
                Date wzc_ = tzx_?.BirthDateElement;
                string wzd_ = wzc_?.Value;
                CqlDate wze_ = context.Operators.ConvertStringToDate(wzd_);
                object wzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate wzh_ = context.Operators.Add(wze_, wzg_ as CqlQuantity);
                Date wzj_ = tzx_?.BirthDateElement;
                string wzk_ = wzj_?.Value;
                CqlDate wzl_ = context.Operators.ConvertStringToDate(wzk_);
                object wzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzb_);
                CqlDate wzo_ = context.Operators.Add(wzl_, wzn_ as CqlQuantity);
                CqlDate wzq_ = context.Operators.Add(wzo_, uzl_);
                CqlInterval<CqlDate> wzr_ = context.Operators.Interval(wzh_, wzq_, true, false);
                bool? wzs_ = wzr_?.highClosed;
                CqlInterval<CqlDateTime> wzt_ = context.Operators.Interval(uzp_, vzi_, wza_, wzs_);

                return wzt_;
            }
            else if (tze_())
            {
                Patient wzu_ = this.Patient(context);
                Date wzv_ = wzu_?.BirthDateElement;
                string wzw_ = wzv_?.Value;
                CqlDate wzx_ = context.Operators.ConvertStringToDate(wzw_);
                DataType wzy_ = condition?.Abatement;
                object wzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object xza_ = context.Operators.LateBoundProperty<object>(wzz_, "low");
                CqlDate xzb_ = context.Operators.Add(wzx_, xza_ as CqlQuantity);
                Date xzd_ = wzu_?.BirthDateElement;
                string xze_ = xzd_?.Value;
                CqlDate xzf_ = context.Operators.ConvertStringToDate(xze_);
                object xzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object xzi_ = context.Operators.LateBoundProperty<object>(xzh_, "high");
                CqlDate xzj_ = context.Operators.Add(xzf_, xzi_ as CqlQuantity);
                CqlQuantity xzk_ = context.Operators.Quantity(1m, "year");
                CqlDate xzl_ = context.Operators.Add(xzj_, xzk_);
                CqlInterval<CqlDate> xzm_ = context.Operators.Interval(xzb_, xzl_, true, false);
                CqlDate xzn_ = xzm_?.low;
                CqlDateTime xzo_ = context.Operators.ConvertDateToDateTime(xzn_);
                Date xzq_ = wzu_?.BirthDateElement;
                string xzr_ = xzq_?.Value;
                CqlDate xzs_ = context.Operators.ConvertStringToDate(xzr_);
                object xzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object xzv_ = context.Operators.LateBoundProperty<object>(xzu_, "low");
                CqlDate xzw_ = context.Operators.Add(xzs_, xzv_ as CqlQuantity);
                Date xzy_ = wzu_?.BirthDateElement;
                string xzz_ = xzy_?.Value;
                CqlDate yza_ = context.Operators.ConvertStringToDate(xzz_);
                object yzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object yzd_ = context.Operators.LateBoundProperty<object>(yzc_, "high");
                CqlDate yze_ = context.Operators.Add(yza_, yzd_ as CqlQuantity);
                CqlDate yzg_ = context.Operators.Add(yze_, xzk_);
                CqlInterval<CqlDate> yzh_ = context.Operators.Interval(xzw_, yzg_, true, false);
                CqlDate yzi_ = yzh_?.high;
                CqlDateTime yzj_ = context.Operators.ConvertDateToDateTime(yzi_);
                Date yzl_ = wzu_?.BirthDateElement;
                string yzm_ = yzl_?.Value;
                CqlDate yzn_ = context.Operators.ConvertStringToDate(yzm_);
                object yzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object yzq_ = context.Operators.LateBoundProperty<object>(yzp_, "low");
                CqlDate yzr_ = context.Operators.Add(yzn_, yzq_ as CqlQuantity);
                Date yzt_ = wzu_?.BirthDateElement;
                string yzu_ = yzt_?.Value;
                CqlDate yzv_ = context.Operators.ConvertStringToDate(yzu_);
                object yzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object yzy_ = context.Operators.LateBoundProperty<object>(yzx_, "high");
                CqlDate yzz_ = context.Operators.Add(yzv_, yzy_ as CqlQuantity);
                CqlDate zzb_ = context.Operators.Add(yzz_, xzk_);
                CqlInterval<CqlDate> zzc_ = context.Operators.Interval(yzr_, zzb_, true, false);
                bool? zzd_ = zzc_?.lowClosed;
                Date zzf_ = wzu_?.BirthDateElement;
                string zzg_ = zzf_?.Value;
                CqlDate zzh_ = context.Operators.ConvertStringToDate(zzg_);
                object zzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object zzk_ = context.Operators.LateBoundProperty<object>(zzj_, "low");
                CqlDate zzl_ = context.Operators.Add(zzh_, zzk_ as CqlQuantity);
                Date zzn_ = wzu_?.BirthDateElement;
                string zzo_ = zzn_?.Value;
                CqlDate zzp_ = context.Operators.ConvertStringToDate(zzo_);
                object zzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzy_);
                object zzs_ = context.Operators.LateBoundProperty<object>(zzr_, "high");
                CqlDate zzt_ = context.Operators.Add(zzp_, zzs_ as CqlQuantity);
                CqlDate zzv_ = context.Operators.Add(zzt_, xzk_);
                CqlInterval<CqlDate> zzw_ = context.Operators.Interval(zzl_, zzv_, true, false);
                bool? zzx_ = zzw_?.highClosed;
                CqlInterval<CqlDateTime> zzy_ = context.Operators.Interval(xzo_, yzj_, zzd_, zzx_);

                return zzy_;
            }
            else if (tzf_())
            {
                DataType zzz_ = condition?.Abatement;
                object azza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzz_);
                object azzb_ = context.Operators.LateBoundProperty<object>(azza_, "low");
                object azzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzz_);
                object azze_ = context.Operators.LateBoundProperty<object>(azzd_, "high");
                CqlInterval<CqlDateTime> azzf_ = context.Operators.Interval(azzb_ as CqlDateTime, azze_ as CqlDateTime, true, false);

                return azzf_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return tzb_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> azzg_()
        {
            bool azzh_()
            {
                DataType azzl_ = condition?.Abatement;
                object azzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzl_);
                bool azzn_ = azzm_ is CqlDateTime;

                return azzn_;
            };
            bool azzi_()
            {
                DataType azzo_ = condition?.Abatement;
                object azzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzo_);
                bool azzq_ = azzp_ is CqlQuantity;

                return azzq_;
            };
            bool azzj_()
            {
                DataType azzr_ = condition?.Abatement;
                object azzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzr_);
                bool azzt_ = azzs_ is CqlInterval<CqlQuantity>;

                return azzt_;
            };
            bool azzk_()
            {
                DataType azzu_ = condition?.Abatement;
                object azzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzu_);
                bool azzw_ = azzv_ is CqlInterval<CqlDateTime>;

                return azzw_;
            };
            if (azzh_())
            {
                DataType azzx_ = condition?.Abatement;
                object azzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzx_);
                object bzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzx_);
                CqlInterval<CqlDateTime> bzzb_ = context.Operators.Interval(azzy_ as CqlDateTime, bzza_ as CqlDateTime, true, true);

                return bzzb_;
            }
            else if (azzi_())
            {
                Patient bzzc_ = this.Patient(context);
                Date bzzd_ = bzzc_?.BirthDateElement;
                string bzze_ = bzzd_?.Value;
                CqlDate bzzf_ = context.Operators.ConvertStringToDate(bzze_);
                DataType bzzg_ = condition?.Abatement;
                object bzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate bzzi_ = context.Operators.Add(bzzf_, bzzh_ as CqlQuantity);
                Date bzzk_ = bzzc_?.BirthDateElement;
                string bzzl_ = bzzk_?.Value;
                CqlDate bzzm_ = context.Operators.ConvertStringToDate(bzzl_);
                object bzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate bzzp_ = context.Operators.Add(bzzm_, bzzo_ as CqlQuantity);
                CqlQuantity bzzq_ = context.Operators.Quantity(1m, "year");
                CqlDate bzzr_ = context.Operators.Add(bzzp_, bzzq_);
                CqlInterval<CqlDate> bzzs_ = context.Operators.Interval(bzzi_, bzzr_, true, false);
                CqlDate bzzt_ = bzzs_?.low;
                CqlDateTime bzzu_ = context.Operators.ConvertDateToDateTime(bzzt_);
                Date bzzw_ = bzzc_?.BirthDateElement;
                string bzzx_ = bzzw_?.Value;
                CqlDate bzzy_ = context.Operators.ConvertStringToDate(bzzx_);
                object czza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate czzb_ = context.Operators.Add(bzzy_, czza_ as CqlQuantity);
                Date czzd_ = bzzc_?.BirthDateElement;
                string czze_ = czzd_?.Value;
                CqlDate czzf_ = context.Operators.ConvertStringToDate(czze_);
                object czzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate czzi_ = context.Operators.Add(czzf_, czzh_ as CqlQuantity);
                CqlDate czzk_ = context.Operators.Add(czzi_, bzzq_);
                CqlInterval<CqlDate> czzl_ = context.Operators.Interval(czzb_, czzk_, true, false);
                CqlDate czzm_ = czzl_?.high;
                CqlDateTime czzn_ = context.Operators.ConvertDateToDateTime(czzm_);
                Date czzp_ = bzzc_?.BirthDateElement;
                string czzq_ = czzp_?.Value;
                CqlDate czzr_ = context.Operators.ConvertStringToDate(czzq_);
                object czzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate czzu_ = context.Operators.Add(czzr_, czzt_ as CqlQuantity);
                Date czzw_ = bzzc_?.BirthDateElement;
                string czzx_ = czzw_?.Value;
                CqlDate czzy_ = context.Operators.ConvertStringToDate(czzx_);
                object dzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate dzzb_ = context.Operators.Add(czzy_, dzza_ as CqlQuantity);
                CqlDate dzzd_ = context.Operators.Add(dzzb_, bzzq_);
                CqlInterval<CqlDate> dzze_ = context.Operators.Interval(czzu_, dzzd_, true, false);
                bool? dzzf_ = dzze_?.lowClosed;
                Date dzzh_ = bzzc_?.BirthDateElement;
                string dzzi_ = dzzh_?.Value;
                CqlDate dzzj_ = context.Operators.ConvertStringToDate(dzzi_);
                object dzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate dzzm_ = context.Operators.Add(dzzj_, dzzl_ as CqlQuantity);
                Date dzzo_ = bzzc_?.BirthDateElement;
                string dzzp_ = dzzo_?.Value;
                CqlDate dzzq_ = context.Operators.ConvertStringToDate(dzzp_);
                object dzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzg_);
                CqlDate dzzt_ = context.Operators.Add(dzzq_, dzzs_ as CqlQuantity);
                CqlDate dzzv_ = context.Operators.Add(dzzt_, bzzq_);
                CqlInterval<CqlDate> dzzw_ = context.Operators.Interval(dzzm_, dzzv_, true, false);
                bool? dzzx_ = dzzw_?.highClosed;
                CqlInterval<CqlDateTime> dzzy_ = context.Operators.Interval(bzzu_, czzn_, dzzf_, dzzx_);

                return dzzy_;
            }
            else if (azzj_())
            {
                Patient dzzz_ = this.Patient(context);
                Date ezza_ = dzzz_?.BirthDateElement;
                string ezzb_ = ezza_?.Value;
                CqlDate ezzc_ = context.Operators.ConvertStringToDate(ezzb_);
                DataType ezzd_ = condition?.Abatement;
                object ezze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object ezzf_ = context.Operators.LateBoundProperty<object>(ezze_, "low");
                CqlDate ezzg_ = context.Operators.Add(ezzc_, ezzf_ as CqlQuantity);
                Date ezzi_ = dzzz_?.BirthDateElement;
                string ezzj_ = ezzi_?.Value;
                CqlDate ezzk_ = context.Operators.ConvertStringToDate(ezzj_);
                object ezzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object ezzn_ = context.Operators.LateBoundProperty<object>(ezzm_, "high");
                CqlDate ezzo_ = context.Operators.Add(ezzk_, ezzn_ as CqlQuantity);
                CqlQuantity ezzp_ = context.Operators.Quantity(1m, "year");
                CqlDate ezzq_ = context.Operators.Add(ezzo_, ezzp_);
                CqlInterval<CqlDate> ezzr_ = context.Operators.Interval(ezzg_, ezzq_, true, false);
                CqlDate ezzs_ = ezzr_?.low;
                CqlDateTime ezzt_ = context.Operators.ConvertDateToDateTime(ezzs_);
                Date ezzv_ = dzzz_?.BirthDateElement;
                string ezzw_ = ezzv_?.Value;
                CqlDate ezzx_ = context.Operators.ConvertStringToDate(ezzw_);
                object ezzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object fzza_ = context.Operators.LateBoundProperty<object>(ezzz_, "low");
                CqlDate fzzb_ = context.Operators.Add(ezzx_, fzza_ as CqlQuantity);
                Date fzzd_ = dzzz_?.BirthDateElement;
                string fzze_ = fzzd_?.Value;
                CqlDate fzzf_ = context.Operators.ConvertStringToDate(fzze_);
                object fzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object fzzi_ = context.Operators.LateBoundProperty<object>(fzzh_, "high");
                CqlDate fzzj_ = context.Operators.Add(fzzf_, fzzi_ as CqlQuantity);
                CqlDate fzzl_ = context.Operators.Add(fzzj_, ezzp_);
                CqlInterval<CqlDate> fzzm_ = context.Operators.Interval(fzzb_, fzzl_, true, false);
                CqlDate fzzn_ = fzzm_?.high;
                CqlDateTime fzzo_ = context.Operators.ConvertDateToDateTime(fzzn_);
                Date fzzq_ = dzzz_?.BirthDateElement;
                string fzzr_ = fzzq_?.Value;
                CqlDate fzzs_ = context.Operators.ConvertStringToDate(fzzr_);
                object fzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object fzzv_ = context.Operators.LateBoundProperty<object>(fzzu_, "low");
                CqlDate fzzw_ = context.Operators.Add(fzzs_, fzzv_ as CqlQuantity);
                Date fzzy_ = dzzz_?.BirthDateElement;
                string fzzz_ = fzzy_?.Value;
                CqlDate gzza_ = context.Operators.ConvertStringToDate(fzzz_);
                object gzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object gzzd_ = context.Operators.LateBoundProperty<object>(gzzc_, "high");
                CqlDate gzze_ = context.Operators.Add(gzza_, gzzd_ as CqlQuantity);
                CqlDate gzzg_ = context.Operators.Add(gzze_, ezzp_);
                CqlInterval<CqlDate> gzzh_ = context.Operators.Interval(fzzw_, gzzg_, true, false);
                bool? gzzi_ = gzzh_?.lowClosed;
                Date gzzk_ = dzzz_?.BirthDateElement;
                string gzzl_ = gzzk_?.Value;
                CqlDate gzzm_ = context.Operators.ConvertStringToDate(gzzl_);
                object gzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object gzzp_ = context.Operators.LateBoundProperty<object>(gzzo_, "low");
                CqlDate gzzq_ = context.Operators.Add(gzzm_, gzzp_ as CqlQuantity);
                Date gzzs_ = dzzz_?.BirthDateElement;
                string gzzt_ = gzzs_?.Value;
                CqlDate gzzu_ = context.Operators.ConvertStringToDate(gzzt_);
                object gzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzd_);
                object gzzx_ = context.Operators.LateBoundProperty<object>(gzzw_, "high");
                CqlDate gzzy_ = context.Operators.Add(gzzu_, gzzx_ as CqlQuantity);
                CqlDate hzza_ = context.Operators.Add(gzzy_, ezzp_);
                CqlInterval<CqlDate> hzzb_ = context.Operators.Interval(gzzq_, hzza_, true, false);
                bool? hzzc_ = hzzb_?.highClosed;
                CqlInterval<CqlDateTime> hzzd_ = context.Operators.Interval(ezzt_, fzzo_, gzzi_, hzzc_);

                return hzzd_;
            }
            else if (azzk_())
            {
                DataType hzze_ = condition?.Abatement;
                object hzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzze_);
                object hzzg_ = context.Operators.LateBoundProperty<object>(hzzf_, "low");
                object hzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzze_);
                object hzzj_ = context.Operators.LateBoundProperty<object>(hzzi_, "high");
                CqlInterval<CqlDateTime> hzzk_ = context.Operators.Interval(hzzg_ as CqlDateTime, hzzj_ as CqlDateTime, true, false);

                return hzzk_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return azzg_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> hzzl_()
        {
            bool hzzm_()
            {
                CodeableConcept hzzn_ = condition?.ClinicalStatus;
                CqlConcept hzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzn_);
                CqlCode hzzp_ = this.active(context);
                CqlConcept hzzq_ = context.Operators.ConvertCodeToConcept(hzzp_);
                bool? hzzr_ = context.Operators.Equivalent(hzzo_, hzzq_);
                CqlConcept hzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzn_);
                CqlCode hzzu_ = this.recurrence(context);
                CqlConcept hzzv_ = context.Operators.ConvertCodeToConcept(hzzu_);
                bool? hzzw_ = context.Operators.Equivalent(hzzt_, hzzv_);
                bool? hzzx_ = context.Operators.Or(hzzr_, hzzw_);
                CqlConcept hzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzn_);
                CqlCode izza_ = this.relapse(context);
                CqlConcept izzb_ = context.Operators.ConvertCodeToConcept(izza_);
                bool? izzc_ = context.Operators.Equivalent(hzzz_, izzb_);
                bool? izzd_ = context.Operators.Or(hzzx_, izzc_);

                return izzd_ ?? false;
            };
            if (hzzm_())
            {
                DataType izze_ = condition?.Onset;
                object izzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izze_);
                CqlInterval<CqlDateTime> izzg_ = this.ToInterval(context, izzf_);
                CqlDateTime izzh_ = context.Operators.Start(izzg_);
                CqlInterval<CqlDateTime> izzi_ = this.ToAbatementInterval(context, condition);
                CqlDateTime izzj_ = context.Operators.End(izzi_);
                CqlInterval<CqlDateTime> izzk_ = context.Operators.Interval(izzh_, izzj_, true, true);

                return izzk_;
            }
            else
            {
                CqlInterval<CqlDateTime> izzl_ = this.ToAbatementInterval(context, condition);
                CqlDateTime izzm_ = context.Operators.End(izzl_);
                CqlDateTime[] izzn_ = [
                    izzm_,
                ];
                CqlInterval<CqlDateTime> izzo_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> izzs_()
                    {
                        if (abatementDate is null)
                        {
                            DataType izzt_ = condition?.Onset;
                            object izzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzt_);
                            CqlInterval<CqlDateTime> izzv_ = this.ToInterval(context, izzu_);
                            CqlDateTime izzw_ = context.Operators.Start(izzv_);
                            CqlInterval<CqlDateTime> izzx_ = context.Operators.Interval(izzw_, abatementDate, true, false);

                            return izzx_;
                        }
                        else
                        {
                            DataType izzy_ = condition?.Onset;
                            object izzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzy_);
                            CqlInterval<CqlDateTime> jzza_ = this.ToInterval(context, izzz_);
                            CqlDateTime jzzb_ = context.Operators.Start(jzza_);
                            CqlInterval<CqlDateTime> jzzc_ = context.Operators.Interval(jzzb_, abatementDate, true, true);

                            return jzzc_;
                        }
                    };

                    return izzs_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> izzp_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)izzn_, izzo_);
                IEnumerable<CqlInterval<CqlDateTime>> izzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(izzp_);
                CqlInterval<CqlDateTime> izzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(izzq_);

                return izzr_;
            }
        };

        return hzzl_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> jzzd_()
        {
            bool jzze_()
            {
                CodeableConcept jzzf_ = condition?.ClinicalStatus;
                CqlConcept jzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzf_);
                CqlCode jzzh_ = this.active(context);
                CqlConcept jzzi_ = context.Operators.ConvertCodeToConcept(jzzh_);
                bool? jzzj_ = context.Operators.Equivalent(jzzg_, jzzi_);
                CqlConcept jzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzf_);
                CqlCode jzzm_ = this.recurrence(context);
                CqlConcept jzzn_ = context.Operators.ConvertCodeToConcept(jzzm_);
                bool? jzzo_ = context.Operators.Equivalent(jzzl_, jzzn_);
                bool? jzzp_ = context.Operators.Or(jzzj_, jzzo_);
                CqlConcept jzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzf_);
                CqlCode jzzs_ = this.relapse(context);
                CqlConcept jzzt_ = context.Operators.ConvertCodeToConcept(jzzs_);
                bool? jzzu_ = context.Operators.Equivalent(jzzr_, jzzt_);
                bool? jzzv_ = context.Operators.Or(jzzp_, jzzu_);

                return jzzv_ ?? false;
            };
            if (jzze_())
            {
                DataType jzzw_ = condition?.Onset;
                object jzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzw_);
                CqlInterval<CqlDateTime> jzzy_ = this.toInterval(context, jzzx_);
                CqlDateTime jzzz_ = context.Operators.Start(jzzy_);
                CqlInterval<CqlDateTime> kzza_ = this.abatementInterval(context, condition);
                CqlDateTime kzzb_ = context.Operators.End(kzza_);
                CqlInterval<CqlDateTime> kzzc_ = context.Operators.Interval(jzzz_, kzzb_, true, true);

                return kzzc_;
            }
            else
            {
                CqlInterval<CqlDateTime> kzzd_ = this.abatementInterval(context, condition);
                CqlDateTime kzze_ = context.Operators.End(kzzd_);
                CqlDateTime[] kzzf_ = [
                    kzze_,
                ];
                CqlInterval<CqlDateTime> kzzg_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> kzzk_()
                    {
                        if (abatementDate is null)
                        {
                            DataType kzzl_ = condition?.Onset;
                            object kzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzl_);
                            CqlInterval<CqlDateTime> kzzn_ = this.toInterval(context, kzzm_);
                            CqlDateTime kzzo_ = context.Operators.Start(kzzn_);
                            CqlInterval<CqlDateTime> kzzp_ = context.Operators.Interval(kzzo_, abatementDate, true, false);

                            return kzzp_;
                        }
                        else
                        {
                            DataType kzzq_ = condition?.Onset;
                            object kzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzq_);
                            CqlInterval<CqlDateTime> kzzs_ = this.toInterval(context, kzzr_);
                            CqlDateTime kzzt_ = context.Operators.Start(kzzs_);
                            CqlInterval<CqlDateTime> kzzu_ = context.Operators.Interval(kzzt_, abatementDate, true, true);

                            return kzzu_;
                        }
                    };

                    return kzzk_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> kzzh_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)kzzf_, kzzg_);
                IEnumerable<CqlInterval<CqlDateTime>> kzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzh_);
                CqlInterval<CqlDateTime> kzzj_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(kzzi_);

                return kzzj_;
            }
        };

        return jzzd_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> kzzv_ = context.Operators.Split(uri, "/");
        string kzzw_ = context.Operators.Last<string>(kzzv_);

        return kzzw_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> kzzx_ = context.Operators.Split(uri, "/");
        string kzzy_ = context.Operators.Last<string>(kzzx_);

        return kzzy_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime kzzz_ = context.Operators.Start(period);
        CqlDateTime lzzb_ = context.Operators.MinValue<CqlDateTime>();
        bool? lzzc_ = context.Operators.Equal(kzzz_, lzzb_);
        bool? lzzd_ = context.Operators.Or((bool?)(kzzz_ is null), lzzc_);
        bool? lzze_ = context.Operators.Not(lzzd_);

        return lzze_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime lzzf_ = context.Operators.Start(period);
        CqlDateTime lzzh_ = context.Operators.MinValue<CqlDateTime>();
        bool? lzzi_ = context.Operators.Equal(lzzf_, lzzh_);
        bool? lzzj_ = context.Operators.Or((bool?)(lzzf_ is null), lzzi_);
        bool? lzzk_ = context.Operators.Not(lzzj_);

        return lzzk_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime lzzl_ = context.Operators.End(period);
        CqlDateTime lzzn_ = context.Operators.MaxValue<CqlDateTime>();
        bool? lzzo_ = context.Operators.Equal(lzzl_, lzzn_);
        bool? lzzp_ = context.Operators.Or((bool?)(lzzl_ is null), lzzo_);
        bool? lzzq_ = context.Operators.Not(lzzp_);

        return lzzq_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime lzzr_ = context.Operators.End(period);
        CqlDateTime lzzt_ = context.Operators.MaxValue<CqlDateTime>();
        bool? lzzu_ = context.Operators.Equal(lzzr_, lzzt_);
        bool? lzzv_ = context.Operators.Or((bool?)(lzzr_ is null), lzzu_);
        bool? lzzw_ = context.Operators.Not(lzzv_);

        return lzzw_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> lzzx_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] lzzy_ = [
            lzzx_,
        ];
        CqlDateTime lzzz_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime mzzd_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime mzze_ = context.Operators.End(period);

                    return mzze_;
                }
                else
                {
                    CqlDateTime mzzf_ = context.Operators.Start(period);

                    return mzzf_;
                }
            };

            return mzzd_();
        };
        IEnumerable<CqlDateTime> mzza_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)lzzy_, lzzz_);
        IEnumerable<CqlDateTime> mzzb_ = context.Operators.Distinct<CqlDateTime>(mzza_);
        CqlDateTime mzzc_ = context.Operators.SingletonFrom<CqlDateTime>(mzzb_);

        return mzzc_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> mzzg_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] mzzh_ = [
            mzzg_,
        ];
        CqlDateTime mzzi_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime mzzm_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime mzzn_ = context.Operators.End(period);

                    return mzzn_;
                }
                else
                {
                    CqlDateTime mzzo_ = context.Operators.Start(period);

                    return mzzo_;
                }
            };

            return mzzm_();
        };
        IEnumerable<CqlDateTime> mzzj_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)mzzh_, mzzi_);
        IEnumerable<CqlDateTime> mzzk_ = context.Operators.Distinct<CqlDateTime>(mzzj_);
        CqlDateTime mzzl_ = context.Operators.SingletonFrom<CqlDateTime>(mzzk_);

        return mzzl_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> mzzp_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] mzzq_ = [
            mzzp_,
        ];
        CqlDateTime mzzr_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime mzzv_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime mzzw_ = context.Operators.Start(period);

                    return mzzw_;
                }
                else
                {
                    CqlDateTime mzzx_ = context.Operators.End(period);

                    return mzzx_;
                }
            };

            return mzzv_();
        };
        IEnumerable<CqlDateTime> mzzs_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)mzzq_, mzzr_);
        IEnumerable<CqlDateTime> mzzt_ = context.Operators.Distinct<CqlDateTime>(mzzs_);
        CqlDateTime mzzu_ = context.Operators.SingletonFrom<CqlDateTime>(mzzt_);

        return mzzu_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> mzzy_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] mzzz_ = [
            mzzy_,
        ];
        CqlDateTime nzza_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime nzze_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime nzzf_ = context.Operators.Start(period);

                    return nzzf_;
                }
                else
                {
                    CqlDateTime nzzg_ = context.Operators.End(period);

                    return nzzg_;
                }
            };

            return nzze_();
        };
        IEnumerable<CqlDateTime> nzzb_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)mzzz_, nzza_);
        IEnumerable<CqlDateTime> nzzc_ = context.Operators.Distinct<CqlDateTime>(nzzb_);
        CqlDateTime nzzd_ = context.Operators.SingletonFrom<CqlDateTime>(nzzc_);

        return nzzd_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime nzzh_ = context.Operators.Start(Period);
        CqlDateTime nzzi_ = context.Operators.End(Period);
        int? nzzj_ = context.Operators.DurationBetween(nzzh_, nzzi_, "day");
        CqlInterval<int?> nzzk_ = context.Operators.Interval(1, nzzj_, true, true);
        CqlInterval<int?>[] nzzl_ = [
            nzzk_,
        ];
        IEnumerable<CqlInterval<int?>> nzzm_ = context.Operators.Expand(nzzl_ as IEnumerable<CqlInterval<int?>>, default);
        int? nzzn_(CqlInterval<int?> DayNumber)
        {
            int? nzzq_ = context.Operators.End(DayNumber);

            return nzzq_;
        };
        IEnumerable<int?> nzzo_ = context.Operators.Select<CqlInterval<int?>, int?>(nzzm_, nzzn_);
        IEnumerable<int?> nzzp_ = context.Operators.Distinct<int?>(nzzo_);

        return nzzp_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime nzzr_ = context.Operators.Start(Period);
        CqlDateTime nzzs_ = context.Operators.End(Period);
        int? nzzt_ = context.Operators.DurationBetween(nzzr_, nzzs_, "day");
        CqlInterval<int?> nzzu_ = context.Operators.Interval(1, nzzt_, true, true);
        CqlInterval<int?>[] nzzv_ = [
            nzzu_,
        ];
        IEnumerable<CqlInterval<int?>> nzzw_ = context.Operators.Expand(nzzv_ as IEnumerable<CqlInterval<int?>>, default);
        int? nzzx_(CqlInterval<int?> DayNumber)
        {
            int? ozza_ = context.Operators.End(DayNumber);

            return ozza_;
        };
        IEnumerable<int?> nzzy_ = context.Operators.Select<CqlInterval<int?>, int?>(nzzw_, nzzx_);
        IEnumerable<int?> nzzz_ = context.Operators.Distinct<int?>(nzzy_);

        return nzzz_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> ozzb_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? ozzc_(int? DayIndex)
        {
            CqlDateTime ozzf_ = context.Operators.Start(Period);
            CqlQuantity ozzg_ = context.Operators.Quantity(24m, "hours");
            int? ozzh_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity ozzi_ = context.Operators.ConvertIntegerToQuantity(ozzh_);
            CqlQuantity ozzj_ = context.Operators.Multiply(ozzg_, ozzi_);
            CqlDateTime ozzk_ = context.Operators.Add(ozzf_, ozzj_);
            CqlDateTime ozzl_()
            {
                bool ozzo_()
                {
                    CqlDateTime ozzp_ = context.Operators.Start(Period);
                    CqlQuantity ozzq_ = context.Operators.Quantity(24m, "hours");
                    int? ozzr_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity ozzs_ = context.Operators.ConvertIntegerToQuantity(ozzr_);
                    CqlQuantity ozzt_ = context.Operators.Multiply(ozzq_, ozzs_);
                    CqlDateTime ozzu_ = context.Operators.Add(ozzp_, ozzt_);
                    CqlDateTime ozzv_ = context.Operators.End(Period);
                    int? ozzw_ = context.Operators.DurationBetween(ozzu_, ozzv_, "hour");
                    bool? ozzx_ = context.Operators.Less(ozzw_, 24);

                    return ozzx_ ?? false;
                };
                if (ozzo_())
                {
                    CqlDateTime ozzy_ = context.Operators.Start(Period);
                    CqlQuantity ozzz_ = context.Operators.Quantity(24m, "hours");
                    int? pzza_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity pzzb_ = context.Operators.ConvertIntegerToQuantity(pzza_);
                    CqlQuantity pzzc_ = context.Operators.Multiply(ozzz_, pzzb_);
                    CqlDateTime pzzd_ = context.Operators.Add(ozzy_, pzzc_);

                    return pzzd_;
                }
                else
                {
                    CqlDateTime pzze_ = context.Operators.Start(Period);
                    CqlQuantity pzzf_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity pzzg_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity pzzh_ = context.Operators.Multiply(pzzf_, pzzg_);
                    CqlDateTime pzzi_ = context.Operators.Add(pzze_, pzzh_);

                    return pzzi_;
                }
            };
            CqlInterval<CqlDateTime> ozzm_ = context.Operators.Interval(ozzk_, ozzl_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? ozzn_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, ozzm_);

            return ozzn_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> ozzd_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(ozzb_, ozzc_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> ozze_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(ozzd_);

        return ozze_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> pzzj_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? pzzk_(int? DayIndex)
        {
            CqlDateTime pzzn_ = context.Operators.Start(Period);
            CqlQuantity pzzo_ = context.Operators.Quantity(24m, "hours");
            int? pzzp_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity pzzq_ = context.Operators.ConvertIntegerToQuantity(pzzp_);
            CqlQuantity pzzr_ = context.Operators.Multiply(pzzo_, pzzq_);
            CqlDateTime pzzs_ = context.Operators.Add(pzzn_, pzzr_);
            CqlDateTime pzzt_()
            {
                bool pzzw_()
                {
                    CqlDateTime pzzx_ = context.Operators.Start(Period);
                    CqlQuantity pzzy_ = context.Operators.Quantity(24m, "hours");
                    int? pzzz_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity qzza_ = context.Operators.ConvertIntegerToQuantity(pzzz_);
                    CqlQuantity qzzb_ = context.Operators.Multiply(pzzy_, qzza_);
                    CqlDateTime qzzc_ = context.Operators.Add(pzzx_, qzzb_);
                    CqlDateTime qzzd_ = context.Operators.End(Period);
                    int? qzze_ = context.Operators.DurationBetween(qzzc_, qzzd_, "hour");
                    bool? qzzf_ = context.Operators.Less(qzze_, 24);

                    return qzzf_ ?? false;
                };
                if (pzzw_())
                {
                    CqlDateTime qzzg_ = context.Operators.Start(Period);
                    CqlQuantity qzzh_ = context.Operators.Quantity(24m, "hours");
                    int? qzzi_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity qzzj_ = context.Operators.ConvertIntegerToQuantity(qzzi_);
                    CqlQuantity qzzk_ = context.Operators.Multiply(qzzh_, qzzj_);
                    CqlDateTime qzzl_ = context.Operators.Add(qzzg_, qzzk_);

                    return qzzl_;
                }
                else
                {
                    CqlDateTime qzzm_ = context.Operators.Start(Period);
                    CqlQuantity qzzn_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity qzzo_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity qzzp_ = context.Operators.Multiply(qzzn_, qzzo_);
                    CqlDateTime qzzq_ = context.Operators.Add(qzzm_, qzzp_);

                    return qzzq_;
                }
            };
            CqlInterval<CqlDateTime> pzzu_ = context.Operators.Interval(pzzs_, pzzt_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? pzzv_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, pzzu_);

            return pzzv_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> pzzl_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(pzzj_, pzzk_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> pzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(pzzl_);

        return pzzm_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
