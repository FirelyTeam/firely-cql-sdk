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
      new CqlCodeSystem("http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null);

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
        CqlConcept wv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wu_);
        CqlCode ww_ = this.active(context);
        CqlConcept wx_ = context.Operators.ConvertCodeToConcept(ww_);
        bool? wy_ = context.Operators.Equivalent(wv_, wx_);
        CqlConcept xa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wu_);
        CqlCode xb_ = this.recurrence(context);
        CqlConcept xc_ = context.Operators.ConvertCodeToConcept(xb_);
        bool? xd_ = context.Operators.Equivalent(xa_, xc_);
        bool? xe_ = context.Operators.Or(wy_, xd_);
        CqlConcept xg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wu_);
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
            CqlConcept xr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept ya_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept yj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept yt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept azh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept azr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept czf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept czp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> czt_ = medicationRequest?.Category;
        CqlConcept czu_(CodeableConcept @this)
        {
            CqlConcept czz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return czz_;
        };
        IEnumerable<CqlConcept> czv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czt_, czu_);
        bool? czw_(CqlConcept C)
        {
            CqlCode dza_ = this.Community(context);
            CqlConcept dzb_ = context.Operators.ConvertCodeToConcept(dza_);
            bool? dzc_ = context.Operators.Equivalent(C, dzb_);

            return dzc_;
        };
        IEnumerable<CqlConcept> czx_ = context.Operators.Where<CqlConcept>(czv_, czw_);
        bool? czy_ = context.Operators.Exists<CqlConcept>(czx_);

        return czy_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzd_ = medicationRequest?.Category;
        CqlConcept dze_(CodeableConcept @this)
        {
            CqlConcept dzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzj_;
        };
        IEnumerable<CqlConcept> dzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzd_, dze_);
        bool? dzg_(CqlConcept C)
        {
            CqlCode dzk_ = this.Discharge(context);
            CqlConcept dzl_ = context.Operators.ConvertCodeToConcept(dzk_);
            bool? dzm_ = context.Operators.Equivalent(C, dzl_);

            return dzm_;
        };
        IEnumerable<CqlConcept> dzh_ = context.Operators.Where<CqlConcept>(dzf_, dzg_);
        bool? dzi_ = context.Operators.Exists<CqlConcept>(dzh_);

        return dzi_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? dzn_(Extension E)
        {
            string dzt_ = E?.Url;
            FhirString dzu_ = context.Operators.Convert<FhirString>(dzt_);
            string dzv_ = dzu_?.Value;
            bool? dzw_ = context.Operators.Equal(dzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return dzw_;
        };
        IEnumerable<Extension> dzo_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), dzn_);
        bool? dzp_(Extension E)
        {
            DataType dzx_ = E?.Value;
            object dzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzx_);

            return dzy_ as bool?;
        };
        IEnumerable<bool?> dzq_ = context.Operators.Select<Extension, bool?>(dzo_, dzp_);
        IEnumerable<bool?> dzr_ = context.Operators.Distinct<bool?>(dzq_);
        bool? dzs_ = context.Operators.SingletonFrom<bool?>(dzr_);

        return dzs_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> dzz_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> eza_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return eza_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezb_ = this.Patient(context);
                Date ezc_ = ezb_?.BirthDateElement;
                string ezd_ = ezc_?.Value;
                CqlDate eze_ = context.Operators.ConvertStringToDate(ezd_);
                CqlDate ezf_ = context.Operators.Add(eze_, choice as CqlQuantity);
                Date ezh_ = ezb_?.BirthDateElement;
                string ezi_ = ezh_?.Value;
                CqlDate ezj_ = context.Operators.ConvertStringToDate(ezi_);
                CqlDate ezk_ = context.Operators.Add(ezj_, choice as CqlQuantity);
                CqlQuantity ezl_ = context.Operators.Quantity(1m, "year");
                CqlDate ezm_ = context.Operators.Add(ezk_, ezl_);
                CqlInterval<CqlDate> ezn_ = context.Operators.Interval(ezf_, ezm_, true, false);
                CqlDate ezo_ = ezn_?.low;
                CqlDateTime ezp_ = context.Operators.ConvertDateToDateTime(ezo_);
                Date ezr_ = ezb_?.BirthDateElement;
                string ezs_ = ezr_?.Value;
                CqlDate ezt_ = context.Operators.ConvertStringToDate(ezs_);
                CqlDate ezu_ = context.Operators.Add(ezt_, choice as CqlQuantity);
                Date ezw_ = ezb_?.BirthDateElement;
                string ezx_ = ezw_?.Value;
                CqlDate ezy_ = context.Operators.ConvertStringToDate(ezx_);
                CqlDate ezz_ = context.Operators.Add(ezy_, choice as CqlQuantity);
                CqlDate fzb_ = context.Operators.Add(ezz_, ezl_);
                CqlInterval<CqlDate> fzc_ = context.Operators.Interval(ezu_, fzb_, true, false);
                CqlDate fzd_ = fzc_?.high;
                CqlDateTime fze_ = context.Operators.ConvertDateToDateTime(fzd_);
                Date fzg_ = ezb_?.BirthDateElement;
                string fzh_ = fzg_?.Value;
                CqlDate fzi_ = context.Operators.ConvertStringToDate(fzh_);
                CqlDate fzj_ = context.Operators.Add(fzi_, choice as CqlQuantity);
                Date fzl_ = ezb_?.BirthDateElement;
                string fzm_ = fzl_?.Value;
                CqlDate fzn_ = context.Operators.ConvertStringToDate(fzm_);
                CqlDate fzo_ = context.Operators.Add(fzn_, choice as CqlQuantity);
                CqlDate fzq_ = context.Operators.Add(fzo_, ezl_);
                CqlInterval<CqlDate> fzr_ = context.Operators.Interval(fzj_, fzq_, true, false);
                bool? fzs_ = fzr_?.lowClosed;
                Date fzu_ = ezb_?.BirthDateElement;
                string fzv_ = fzu_?.Value;
                CqlDate fzw_ = context.Operators.ConvertStringToDate(fzv_);
                CqlDate fzx_ = context.Operators.Add(fzw_, choice as CqlQuantity);
                Date fzz_ = ezb_?.BirthDateElement;
                string gza_ = fzz_?.Value;
                CqlDate gzb_ = context.Operators.ConvertStringToDate(gza_);
                CqlDate gzc_ = context.Operators.Add(gzb_, choice as CqlQuantity);
                CqlDate gze_ = context.Operators.Add(gzc_, ezl_);
                CqlInterval<CqlDate> gzf_ = context.Operators.Interval(fzx_, gze_, true, false);
                bool? gzg_ = gzf_?.highClosed;
                CqlInterval<CqlDateTime> gzh_ = context.Operators.Interval(ezp_, fze_, fzs_, gzg_);

                return gzh_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzi_ = this.Patient(context);
                Date gzj_ = gzi_?.BirthDateElement;
                string gzk_ = gzj_?.Value;
                CqlDate gzl_ = context.Operators.ConvertStringToDate(gzk_);
                object gzm_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate gzn_ = context.Operators.Add(gzl_, gzm_ as CqlQuantity);
                Date gzp_ = gzi_?.BirthDateElement;
                string gzq_ = gzp_?.Value;
                CqlDate gzr_ = context.Operators.ConvertStringToDate(gzq_);
                object gzs_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate gzt_ = context.Operators.Add(gzr_, gzs_ as CqlQuantity);
                CqlQuantity gzu_ = context.Operators.Quantity(1m, "year");
                CqlDate gzv_ = context.Operators.Add(gzt_, gzu_);
                CqlInterval<CqlDate> gzw_ = context.Operators.Interval(gzn_, gzv_, true, false);
                CqlDate gzx_ = gzw_?.low;
                CqlDateTime gzy_ = context.Operators.ConvertDateToDateTime(gzx_);
                Date hza_ = gzi_?.BirthDateElement;
                string hzb_ = hza_?.Value;
                CqlDate hzc_ = context.Operators.ConvertStringToDate(hzb_);
                CqlDate hze_ = context.Operators.Add(hzc_, gzm_ as CqlQuantity);
                Date hzg_ = gzi_?.BirthDateElement;
                string hzh_ = hzg_?.Value;
                CqlDate hzi_ = context.Operators.ConvertStringToDate(hzh_);
                CqlDate hzk_ = context.Operators.Add(hzi_, gzs_ as CqlQuantity);
                CqlDate hzm_ = context.Operators.Add(hzk_, gzu_);
                CqlInterval<CqlDate> hzn_ = context.Operators.Interval(hze_, hzm_, true, false);
                CqlDate hzo_ = hzn_?.high;
                CqlDateTime hzp_ = context.Operators.ConvertDateToDateTime(hzo_);
                Date hzr_ = gzi_?.BirthDateElement;
                string hzs_ = hzr_?.Value;
                CqlDate hzt_ = context.Operators.ConvertStringToDate(hzs_);
                CqlDate hzv_ = context.Operators.Add(hzt_, gzm_ as CqlQuantity);
                Date hzx_ = gzi_?.BirthDateElement;
                string hzy_ = hzx_?.Value;
                CqlDate hzz_ = context.Operators.ConvertStringToDate(hzy_);
                CqlDate izb_ = context.Operators.Add(hzz_, gzs_ as CqlQuantity);
                CqlDate izd_ = context.Operators.Add(izb_, gzu_);
                CqlInterval<CqlDate> ize_ = context.Operators.Interval(hzv_, izd_, true, false);
                bool? izf_ = ize_?.lowClosed;
                Date izh_ = gzi_?.BirthDateElement;
                string izi_ = izh_?.Value;
                CqlDate izj_ = context.Operators.ConvertStringToDate(izi_);
                CqlDate izl_ = context.Operators.Add(izj_, gzm_ as CqlQuantity);
                Date izn_ = gzi_?.BirthDateElement;
                string izo_ = izn_?.Value;
                CqlDate izp_ = context.Operators.ConvertStringToDate(izo_);
                CqlDate izr_ = context.Operators.Add(izp_, gzs_ as CqlQuantity);
                CqlDate izt_ = context.Operators.Add(izr_, gzu_);
                CqlInterval<CqlDate> izu_ = context.Operators.Interval(izl_, izt_, true, false);
                bool? izv_ = izu_?.highClosed;
                CqlInterval<CqlDateTime> izw_ = context.Operators.Interval(gzy_, hzp_, izf_, izv_);

                return izw_;
            }
            else if (choice is Timing)
            {
                object izx_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return izx_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return dzz_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izy_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> izz_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return izz_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jza_ = this.Patient(context);
                Date jzb_ = jza_?.BirthDateElement;
                string jzc_ = jzb_?.Value;
                CqlDate jzd_ = context.Operators.ConvertStringToDate(jzc_);
                CqlDate jze_ = context.Operators.Add(jzd_, choice as CqlQuantity);
                Date jzg_ = jza_?.BirthDateElement;
                string jzh_ = jzg_?.Value;
                CqlDate jzi_ = context.Operators.ConvertStringToDate(jzh_);
                CqlDate jzj_ = context.Operators.Add(jzi_, choice as CqlQuantity);
                CqlQuantity jzk_ = context.Operators.Quantity(1m, "year");
                CqlDate jzl_ = context.Operators.Add(jzj_, jzk_);
                CqlInterval<CqlDate> jzm_ = context.Operators.Interval(jze_, jzl_, true, false);
                CqlDate jzn_ = jzm_?.low;
                CqlDateTime jzo_ = context.Operators.ConvertDateToDateTime(jzn_);
                Date jzq_ = jza_?.BirthDateElement;
                string jzr_ = jzq_?.Value;
                CqlDate jzs_ = context.Operators.ConvertStringToDate(jzr_);
                CqlDate jzt_ = context.Operators.Add(jzs_, choice as CqlQuantity);
                Date jzv_ = jza_?.BirthDateElement;
                string jzw_ = jzv_?.Value;
                CqlDate jzx_ = context.Operators.ConvertStringToDate(jzw_);
                CqlDate jzy_ = context.Operators.Add(jzx_, choice as CqlQuantity);
                CqlDate kza_ = context.Operators.Add(jzy_, jzk_);
                CqlInterval<CqlDate> kzb_ = context.Operators.Interval(jzt_, kza_, true, false);
                CqlDate kzc_ = kzb_?.high;
                CqlDateTime kzd_ = context.Operators.ConvertDateToDateTime(kzc_);
                Date kzf_ = jza_?.BirthDateElement;
                string kzg_ = kzf_?.Value;
                CqlDate kzh_ = context.Operators.ConvertStringToDate(kzg_);
                CqlDate kzi_ = context.Operators.Add(kzh_, choice as CqlQuantity);
                Date kzk_ = jza_?.BirthDateElement;
                string kzl_ = kzk_?.Value;
                CqlDate kzm_ = context.Operators.ConvertStringToDate(kzl_);
                CqlDate kzn_ = context.Operators.Add(kzm_, choice as CqlQuantity);
                CqlDate kzp_ = context.Operators.Add(kzn_, jzk_);
                CqlInterval<CqlDate> kzq_ = context.Operators.Interval(kzi_, kzp_, true, false);
                bool? kzr_ = kzq_?.lowClosed;
                Date kzt_ = jza_?.BirthDateElement;
                string kzu_ = kzt_?.Value;
                CqlDate kzv_ = context.Operators.ConvertStringToDate(kzu_);
                CqlDate kzw_ = context.Operators.Add(kzv_, choice as CqlQuantity);
                Date kzy_ = jza_?.BirthDateElement;
                string kzz_ = kzy_?.Value;
                CqlDate lza_ = context.Operators.ConvertStringToDate(kzz_);
                CqlDate lzb_ = context.Operators.Add(lza_, choice as CqlQuantity);
                CqlDate lzd_ = context.Operators.Add(lzb_, jzk_);
                CqlInterval<CqlDate> lze_ = context.Operators.Interval(kzw_, lzd_, true, false);
                bool? lzf_ = lze_?.highClosed;
                CqlInterval<CqlDateTime> lzg_ = context.Operators.Interval(jzo_, kzd_, kzr_, lzf_);

                return lzg_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzh_ = this.Patient(context);
                Date lzi_ = lzh_?.BirthDateElement;
                string lzj_ = lzi_?.Value;
                CqlDate lzk_ = context.Operators.ConvertStringToDate(lzj_);
                object lzl_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzm_ = context.Operators.Add(lzk_, lzl_ as CqlQuantity);
                Date lzo_ = lzh_?.BirthDateElement;
                string lzp_ = lzo_?.Value;
                CqlDate lzq_ = context.Operators.ConvertStringToDate(lzp_);
                object lzr_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate lzs_ = context.Operators.Add(lzq_, lzr_ as CqlQuantity);
                CqlQuantity lzt_ = context.Operators.Quantity(1m, "year");
                CqlDate lzu_ = context.Operators.Add(lzs_, lzt_);
                CqlInterval<CqlDate> lzv_ = context.Operators.Interval(lzm_, lzu_, true, false);
                CqlDate lzw_ = lzv_?.low;
                CqlDateTime lzx_ = context.Operators.ConvertDateToDateTime(lzw_);
                Date lzz_ = lzh_?.BirthDateElement;
                string mza_ = lzz_?.Value;
                CqlDate mzb_ = context.Operators.ConvertStringToDate(mza_);
                CqlDate mzd_ = context.Operators.Add(mzb_, lzl_ as CqlQuantity);
                Date mzf_ = lzh_?.BirthDateElement;
                string mzg_ = mzf_?.Value;
                CqlDate mzh_ = context.Operators.ConvertStringToDate(mzg_);
                CqlDate mzj_ = context.Operators.Add(mzh_, lzr_ as CqlQuantity);
                CqlDate mzl_ = context.Operators.Add(mzj_, lzt_);
                CqlInterval<CqlDate> mzm_ = context.Operators.Interval(mzd_, mzl_, true, false);
                CqlDate mzn_ = mzm_?.high;
                CqlDateTime mzo_ = context.Operators.ConvertDateToDateTime(mzn_);
                Date mzq_ = lzh_?.BirthDateElement;
                string mzr_ = mzq_?.Value;
                CqlDate mzs_ = context.Operators.ConvertStringToDate(mzr_);
                CqlDate mzu_ = context.Operators.Add(mzs_, lzl_ as CqlQuantity);
                Date mzw_ = lzh_?.BirthDateElement;
                string mzx_ = mzw_?.Value;
                CqlDate mzy_ = context.Operators.ConvertStringToDate(mzx_);
                CqlDate nza_ = context.Operators.Add(mzy_, lzr_ as CqlQuantity);
                CqlDate nzc_ = context.Operators.Add(nza_, lzt_);
                CqlInterval<CqlDate> nzd_ = context.Operators.Interval(mzu_, nzc_, true, false);
                bool? nze_ = nzd_?.lowClosed;
                Date nzg_ = lzh_?.BirthDateElement;
                string nzh_ = nzg_?.Value;
                CqlDate nzi_ = context.Operators.ConvertStringToDate(nzh_);
                CqlDate nzk_ = context.Operators.Add(nzi_, lzl_ as CqlQuantity);
                Date nzm_ = lzh_?.BirthDateElement;
                string nzn_ = nzm_?.Value;
                CqlDate nzo_ = context.Operators.ConvertStringToDate(nzn_);
                CqlDate nzq_ = context.Operators.Add(nzo_, lzr_ as CqlQuantity);
                CqlDate nzs_ = context.Operators.Add(nzq_, lzt_);
                CqlInterval<CqlDate> nzt_ = context.Operators.Interval(nzk_, nzs_, true, false);
                bool? nzu_ = nzt_?.highClosed;
                CqlInterval<CqlDateTime> nzv_ = context.Operators.Interval(lzx_, mzo_, nze_, nzu_);

                return nzv_;
            }
            else if (choice is Timing)
            {
                object nzw_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return nzw_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return izy_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> nzx_()
        {
            bool nzy_()
            {
                DataType ozc_ = condition?.Abatement;
                object ozd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozc_);
                bool oze_ = ozd_ is CqlDateTime;

                return oze_;
            };
            bool nzz_()
            {
                DataType ozf_ = condition?.Abatement;
                object ozg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozf_);
                bool ozh_ = ozg_ is CqlQuantity;

                return ozh_;
            };
            bool oza_()
            {
                DataType ozi_ = condition?.Abatement;
                object ozj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozi_);
                bool ozk_ = ozj_ is CqlInterval<CqlQuantity>;

                return ozk_;
            };
            bool ozb_()
            {
                DataType ozl_ = condition?.Abatement;
                object ozm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozl_);
                bool ozn_ = ozm_ is CqlInterval<CqlDateTime>;

                return ozn_;
            };
            if (nzy_())
            {
                DataType ozo_ = condition?.Abatement;
                object ozp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozo_);
                object ozr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozo_);
                CqlInterval<CqlDateTime> ozs_ = context.Operators.Interval(ozp_ as CqlDateTime, ozr_ as CqlDateTime, true, true);

                return ozs_;
            }
            else if (nzz_())
            {
                Patient ozt_ = this.Patient(context);
                Date ozu_ = ozt_?.BirthDateElement;
                string ozv_ = ozu_?.Value;
                CqlDate ozw_ = context.Operators.ConvertStringToDate(ozv_);
                DataType ozx_ = condition?.Abatement;
                object ozy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate ozz_ = context.Operators.Add(ozw_, ozy_ as CqlQuantity);
                Date pzb_ = ozt_?.BirthDateElement;
                string pzc_ = pzb_?.Value;
                CqlDate pzd_ = context.Operators.ConvertStringToDate(pzc_);
                object pzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate pzg_ = context.Operators.Add(pzd_, pzf_ as CqlQuantity);
                CqlQuantity pzh_ = context.Operators.Quantity(1m, "year");
                CqlDate pzi_ = context.Operators.Add(pzg_, pzh_);
                CqlInterval<CqlDate> pzj_ = context.Operators.Interval(ozz_, pzi_, true, false);
                CqlDate pzk_ = pzj_?.low;
                CqlDateTime pzl_ = context.Operators.ConvertDateToDateTime(pzk_);
                Date pzn_ = ozt_?.BirthDateElement;
                string pzo_ = pzn_?.Value;
                CqlDate pzp_ = context.Operators.ConvertStringToDate(pzo_);
                object pzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate pzs_ = context.Operators.Add(pzp_, pzr_ as CqlQuantity);
                Date pzu_ = ozt_?.BirthDateElement;
                string pzv_ = pzu_?.Value;
                CqlDate pzw_ = context.Operators.ConvertStringToDate(pzv_);
                object pzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate pzz_ = context.Operators.Add(pzw_, pzy_ as CqlQuantity);
                CqlDate qzb_ = context.Operators.Add(pzz_, pzh_);
                CqlInterval<CqlDate> qzc_ = context.Operators.Interval(pzs_, qzb_, true, false);
                CqlDate qzd_ = qzc_?.high;
                CqlDateTime qze_ = context.Operators.ConvertDateToDateTime(qzd_);
                Date qzg_ = ozt_?.BirthDateElement;
                string qzh_ = qzg_?.Value;
                CqlDate qzi_ = context.Operators.ConvertStringToDate(qzh_);
                object qzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate qzl_ = context.Operators.Add(qzi_, qzk_ as CqlQuantity);
                Date qzn_ = ozt_?.BirthDateElement;
                string qzo_ = qzn_?.Value;
                CqlDate qzp_ = context.Operators.ConvertStringToDate(qzo_);
                object qzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate qzs_ = context.Operators.Add(qzp_, qzr_ as CqlQuantity);
                CqlDate qzu_ = context.Operators.Add(qzs_, pzh_);
                CqlInterval<CqlDate> qzv_ = context.Operators.Interval(qzl_, qzu_, true, false);
                bool? qzw_ = qzv_?.lowClosed;
                Date qzy_ = ozt_?.BirthDateElement;
                string qzz_ = qzy_?.Value;
                CqlDate rza_ = context.Operators.ConvertStringToDate(qzz_);
                object rzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate rzd_ = context.Operators.Add(rza_, rzc_ as CqlQuantity);
                Date rzf_ = ozt_?.BirthDateElement;
                string rzg_ = rzf_?.Value;
                CqlDate rzh_ = context.Operators.ConvertStringToDate(rzg_);
                object rzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozx_);
                CqlDate rzk_ = context.Operators.Add(rzh_, rzj_ as CqlQuantity);
                CqlDate rzm_ = context.Operators.Add(rzk_, pzh_);
                CqlInterval<CqlDate> rzn_ = context.Operators.Interval(rzd_, rzm_, true, false);
                bool? rzo_ = rzn_?.highClosed;
                CqlInterval<CqlDateTime> rzp_ = context.Operators.Interval(pzl_, qze_, qzw_, rzo_);

                return rzp_;
            }
            else if (oza_())
            {
                Patient rzq_ = this.Patient(context);
                Date rzr_ = rzq_?.BirthDateElement;
                string rzs_ = rzr_?.Value;
                CqlDate rzt_ = context.Operators.ConvertStringToDate(rzs_);
                DataType rzu_ = condition?.Abatement;
                object rzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object rzw_ = context.Operators.LateBoundProperty<object>(rzv_, "low");
                CqlDate rzx_ = context.Operators.Add(rzt_, rzw_ as CqlQuantity);
                Date rzz_ = rzq_?.BirthDateElement;
                string sza_ = rzz_?.Value;
                CqlDate szb_ = context.Operators.ConvertStringToDate(sza_);
                object szd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object sze_ = context.Operators.LateBoundProperty<object>(szd_, "high");
                CqlDate szf_ = context.Operators.Add(szb_, sze_ as CqlQuantity);
                CqlQuantity szg_ = context.Operators.Quantity(1m, "year");
                CqlDate szh_ = context.Operators.Add(szf_, szg_);
                CqlInterval<CqlDate> szi_ = context.Operators.Interval(rzx_, szh_, true, false);
                CqlDate szj_ = szi_?.low;
                CqlDateTime szk_ = context.Operators.ConvertDateToDateTime(szj_);
                Date szm_ = rzq_?.BirthDateElement;
                string szn_ = szm_?.Value;
                CqlDate szo_ = context.Operators.ConvertStringToDate(szn_);
                object szq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object szr_ = context.Operators.LateBoundProperty<object>(szq_, "low");
                CqlDate szs_ = context.Operators.Add(szo_, szr_ as CqlQuantity);
                Date szu_ = rzq_?.BirthDateElement;
                string szv_ = szu_?.Value;
                CqlDate szw_ = context.Operators.ConvertStringToDate(szv_);
                object szy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object szz_ = context.Operators.LateBoundProperty<object>(szy_, "high");
                CqlDate tza_ = context.Operators.Add(szw_, szz_ as CqlQuantity);
                CqlDate tzc_ = context.Operators.Add(tza_, szg_);
                CqlInterval<CqlDate> tzd_ = context.Operators.Interval(szs_, tzc_, true, false);
                CqlDate tze_ = tzd_?.high;
                CqlDateTime tzf_ = context.Operators.ConvertDateToDateTime(tze_);
                Date tzh_ = rzq_?.BirthDateElement;
                string tzi_ = tzh_?.Value;
                CqlDate tzj_ = context.Operators.ConvertStringToDate(tzi_);
                object tzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object tzm_ = context.Operators.LateBoundProperty<object>(tzl_, "low");
                CqlDate tzn_ = context.Operators.Add(tzj_, tzm_ as CqlQuantity);
                Date tzp_ = rzq_?.BirthDateElement;
                string tzq_ = tzp_?.Value;
                CqlDate tzr_ = context.Operators.ConvertStringToDate(tzq_);
                object tzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object tzu_ = context.Operators.LateBoundProperty<object>(tzt_, "high");
                CqlDate tzv_ = context.Operators.Add(tzr_, tzu_ as CqlQuantity);
                CqlDate tzx_ = context.Operators.Add(tzv_, szg_);
                CqlInterval<CqlDate> tzy_ = context.Operators.Interval(tzn_, tzx_, true, false);
                bool? tzz_ = tzy_?.lowClosed;
                Date uzb_ = rzq_?.BirthDateElement;
                string uzc_ = uzb_?.Value;
                CqlDate uzd_ = context.Operators.ConvertStringToDate(uzc_);
                object uzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object uzg_ = context.Operators.LateBoundProperty<object>(uzf_, "low");
                CqlDate uzh_ = context.Operators.Add(uzd_, uzg_ as CqlQuantity);
                Date uzj_ = rzq_?.BirthDateElement;
                string uzk_ = uzj_?.Value;
                CqlDate uzl_ = context.Operators.ConvertStringToDate(uzk_);
                object uzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzu_);
                object uzo_ = context.Operators.LateBoundProperty<object>(uzn_, "high");
                CqlDate uzp_ = context.Operators.Add(uzl_, uzo_ as CqlQuantity);
                CqlDate uzr_ = context.Operators.Add(uzp_, szg_);
                CqlInterval<CqlDate> uzs_ = context.Operators.Interval(uzh_, uzr_, true, false);
                bool? uzt_ = uzs_?.highClosed;
                CqlInterval<CqlDateTime> uzu_ = context.Operators.Interval(szk_, tzf_, tzz_, uzt_);

                return uzu_;
            }
            else if (ozb_())
            {
                DataType uzv_ = condition?.Abatement;
                object uzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzv_);
                object uzx_ = context.Operators.LateBoundProperty<object>(uzw_, "low");
                object uzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzv_);
                object vza_ = context.Operators.LateBoundProperty<object>(uzz_, "high");
                CqlInterval<CqlDateTime> vzb_ = context.Operators.Interval(uzx_ as CqlDateTime, vza_ as CqlDateTime, true, false);

                return vzb_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return nzx_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vzc_()
        {
            bool vzd_()
            {
                DataType vzh_ = condition?.Abatement;
                object vzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzh_);
                bool vzj_ = vzi_ is CqlDateTime;

                return vzj_;
            };
            bool vze_()
            {
                DataType vzk_ = condition?.Abatement;
                object vzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzk_);
                bool vzm_ = vzl_ is CqlQuantity;

                return vzm_;
            };
            bool vzf_()
            {
                DataType vzn_ = condition?.Abatement;
                object vzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzn_);
                bool vzp_ = vzo_ is CqlInterval<CqlQuantity>;

                return vzp_;
            };
            bool vzg_()
            {
                DataType vzq_ = condition?.Abatement;
                object vzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzq_);
                bool vzs_ = vzr_ is CqlInterval<CqlDateTime>;

                return vzs_;
            };
            if (vzd_())
            {
                DataType vzt_ = condition?.Abatement;
                object vzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzt_);
                object vzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzt_);
                CqlInterval<CqlDateTime> vzx_ = context.Operators.Interval(vzu_ as CqlDateTime, vzw_ as CqlDateTime, true, true);

                return vzx_;
            }
            else if (vze_())
            {
                Patient vzy_ = this.Patient(context);
                Date vzz_ = vzy_?.BirthDateElement;
                string wza_ = vzz_?.Value;
                CqlDate wzb_ = context.Operators.ConvertStringToDate(wza_);
                DataType wzc_ = condition?.Abatement;
                object wzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate wze_ = context.Operators.Add(wzb_, wzd_ as CqlQuantity);
                Date wzg_ = vzy_?.BirthDateElement;
                string wzh_ = wzg_?.Value;
                CqlDate wzi_ = context.Operators.ConvertStringToDate(wzh_);
                object wzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate wzl_ = context.Operators.Add(wzi_, wzk_ as CqlQuantity);
                CqlQuantity wzm_ = context.Operators.Quantity(1m, "year");
                CqlDate wzn_ = context.Operators.Add(wzl_, wzm_);
                CqlInterval<CqlDate> wzo_ = context.Operators.Interval(wze_, wzn_, true, false);
                CqlDate wzp_ = wzo_?.low;
                CqlDateTime wzq_ = context.Operators.ConvertDateToDateTime(wzp_);
                Date wzs_ = vzy_?.BirthDateElement;
                string wzt_ = wzs_?.Value;
                CqlDate wzu_ = context.Operators.ConvertStringToDate(wzt_);
                object wzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate wzx_ = context.Operators.Add(wzu_, wzw_ as CqlQuantity);
                Date wzz_ = vzy_?.BirthDateElement;
                string xza_ = wzz_?.Value;
                CqlDate xzb_ = context.Operators.ConvertStringToDate(xza_);
                object xzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate xze_ = context.Operators.Add(xzb_, xzd_ as CqlQuantity);
                CqlDate xzg_ = context.Operators.Add(xze_, wzm_);
                CqlInterval<CqlDate> xzh_ = context.Operators.Interval(wzx_, xzg_, true, false);
                CqlDate xzi_ = xzh_?.high;
                CqlDateTime xzj_ = context.Operators.ConvertDateToDateTime(xzi_);
                Date xzl_ = vzy_?.BirthDateElement;
                string xzm_ = xzl_?.Value;
                CqlDate xzn_ = context.Operators.ConvertStringToDate(xzm_);
                object xzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate xzq_ = context.Operators.Add(xzn_, xzp_ as CqlQuantity);
                Date xzs_ = vzy_?.BirthDateElement;
                string xzt_ = xzs_?.Value;
                CqlDate xzu_ = context.Operators.ConvertStringToDate(xzt_);
                object xzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate xzx_ = context.Operators.Add(xzu_, xzw_ as CqlQuantity);
                CqlDate xzz_ = context.Operators.Add(xzx_, wzm_);
                CqlInterval<CqlDate> yza_ = context.Operators.Interval(xzq_, xzz_, true, false);
                bool? yzb_ = yza_?.lowClosed;
                Date yzd_ = vzy_?.BirthDateElement;
                string yze_ = yzd_?.Value;
                CqlDate yzf_ = context.Operators.ConvertStringToDate(yze_);
                object yzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate yzi_ = context.Operators.Add(yzf_, yzh_ as CqlQuantity);
                Date yzk_ = vzy_?.BirthDateElement;
                string yzl_ = yzk_?.Value;
                CqlDate yzm_ = context.Operators.ConvertStringToDate(yzl_);
                object yzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzc_);
                CqlDate yzp_ = context.Operators.Add(yzm_, yzo_ as CqlQuantity);
                CqlDate yzr_ = context.Operators.Add(yzp_, wzm_);
                CqlInterval<CqlDate> yzs_ = context.Operators.Interval(yzi_, yzr_, true, false);
                bool? yzt_ = yzs_?.highClosed;
                CqlInterval<CqlDateTime> yzu_ = context.Operators.Interval(wzq_, xzj_, yzb_, yzt_);

                return yzu_;
            }
            else if (vzf_())
            {
                Patient yzv_ = this.Patient(context);
                Date yzw_ = yzv_?.BirthDateElement;
                string yzx_ = yzw_?.Value;
                CqlDate yzy_ = context.Operators.ConvertStringToDate(yzx_);
                DataType yzz_ = condition?.Abatement;
                object zza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object zzb_ = context.Operators.LateBoundProperty<object>(zza_, "low");
                CqlDate zzc_ = context.Operators.Add(yzy_, zzb_ as CqlQuantity);
                Date zze_ = yzv_?.BirthDateElement;
                string zzf_ = zze_?.Value;
                CqlDate zzg_ = context.Operators.ConvertStringToDate(zzf_);
                object zzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object zzj_ = context.Operators.LateBoundProperty<object>(zzi_, "high");
                CqlDate zzk_ = context.Operators.Add(zzg_, zzj_ as CqlQuantity);
                CqlQuantity zzl_ = context.Operators.Quantity(1m, "year");
                CqlDate zzm_ = context.Operators.Add(zzk_, zzl_);
                CqlInterval<CqlDate> zzn_ = context.Operators.Interval(zzc_, zzm_, true, false);
                CqlDate zzo_ = zzn_?.low;
                CqlDateTime zzp_ = context.Operators.ConvertDateToDateTime(zzo_);
                Date zzr_ = yzv_?.BirthDateElement;
                string zzs_ = zzr_?.Value;
                CqlDate zzt_ = context.Operators.ConvertStringToDate(zzs_);
                object zzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object zzw_ = context.Operators.LateBoundProperty<object>(zzv_, "low");
                CqlDate zzx_ = context.Operators.Add(zzt_, zzw_ as CqlQuantity);
                Date zzz_ = yzv_?.BirthDateElement;
                string azza_ = zzz_?.Value;
                CqlDate azzb_ = context.Operators.ConvertStringToDate(azza_);
                object azzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object azze_ = context.Operators.LateBoundProperty<object>(azzd_, "high");
                CqlDate azzf_ = context.Operators.Add(azzb_, azze_ as CqlQuantity);
                CqlDate azzh_ = context.Operators.Add(azzf_, zzl_);
                CqlInterval<CqlDate> azzi_ = context.Operators.Interval(zzx_, azzh_, true, false);
                CqlDate azzj_ = azzi_?.high;
                CqlDateTime azzk_ = context.Operators.ConvertDateToDateTime(azzj_);
                Date azzm_ = yzv_?.BirthDateElement;
                string azzn_ = azzm_?.Value;
                CqlDate azzo_ = context.Operators.ConvertStringToDate(azzn_);
                object azzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object azzr_ = context.Operators.LateBoundProperty<object>(azzq_, "low");
                CqlDate azzs_ = context.Operators.Add(azzo_, azzr_ as CqlQuantity);
                Date azzu_ = yzv_?.BirthDateElement;
                string azzv_ = azzu_?.Value;
                CqlDate azzw_ = context.Operators.ConvertStringToDate(azzv_);
                object azzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object azzz_ = context.Operators.LateBoundProperty<object>(azzy_, "high");
                CqlDate bzza_ = context.Operators.Add(azzw_, azzz_ as CqlQuantity);
                CqlDate bzzc_ = context.Operators.Add(bzza_, zzl_);
                CqlInterval<CqlDate> bzzd_ = context.Operators.Interval(azzs_, bzzc_, true, false);
                bool? bzze_ = bzzd_?.lowClosed;
                Date bzzg_ = yzv_?.BirthDateElement;
                string bzzh_ = bzzg_?.Value;
                CqlDate bzzi_ = context.Operators.ConvertStringToDate(bzzh_);
                object bzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object bzzl_ = context.Operators.LateBoundProperty<object>(bzzk_, "low");
                CqlDate bzzm_ = context.Operators.Add(bzzi_, bzzl_ as CqlQuantity);
                Date bzzo_ = yzv_?.BirthDateElement;
                string bzzp_ = bzzo_?.Value;
                CqlDate bzzq_ = context.Operators.ConvertStringToDate(bzzp_);
                object bzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzz_);
                object bzzt_ = context.Operators.LateBoundProperty<object>(bzzs_, "high");
                CqlDate bzzu_ = context.Operators.Add(bzzq_, bzzt_ as CqlQuantity);
                CqlDate bzzw_ = context.Operators.Add(bzzu_, zzl_);
                CqlInterval<CqlDate> bzzx_ = context.Operators.Interval(bzzm_, bzzw_, true, false);
                bool? bzzy_ = bzzx_?.highClosed;
                CqlInterval<CqlDateTime> bzzz_ = context.Operators.Interval(zzp_, azzk_, bzze_, bzzy_);

                return bzzz_;
            }
            else if (vzg_())
            {
                DataType czza_ = condition?.Abatement;
                object czzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czza_);
                object czzc_ = context.Operators.LateBoundProperty<object>(czzb_, "low");
                object czze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czza_);
                object czzf_ = context.Operators.LateBoundProperty<object>(czze_, "high");
                CqlInterval<CqlDateTime> czzg_ = context.Operators.Interval(czzc_ as CqlDateTime, czzf_ as CqlDateTime, true, false);

                return czzg_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vzc_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzh_()
        {
            bool czzi_()
            {
                CodeableConcept czzj_ = condition?.ClinicalStatus;
                CqlConcept czzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzj_);
                CqlCode czzl_ = this.active(context);
                CqlConcept czzm_ = context.Operators.ConvertCodeToConcept(czzl_);
                bool? czzn_ = context.Operators.Equivalent(czzk_, czzm_);
                CqlConcept czzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzj_);
                CqlCode czzq_ = this.recurrence(context);
                CqlConcept czzr_ = context.Operators.ConvertCodeToConcept(czzq_);
                bool? czzs_ = context.Operators.Equivalent(czzp_, czzr_);
                bool? czzt_ = context.Operators.Or(czzn_, czzs_);
                CqlConcept czzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzj_);
                CqlCode czzw_ = this.relapse(context);
                CqlConcept czzx_ = context.Operators.ConvertCodeToConcept(czzw_);
                bool? czzy_ = context.Operators.Equivalent(czzv_, czzx_);
                bool? czzz_ = context.Operators.Or(czzt_, czzy_);

                return czzz_ ?? false;
            };
            if (czzi_())
            {
                DataType dzza_ = condition?.Onset;
                object dzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzza_);
                CqlInterval<CqlDateTime> dzzc_ = this.ToInterval(context, dzzb_);
                CqlDateTime dzzd_ = context.Operators.Start(dzzc_);
                CqlInterval<CqlDateTime> dzze_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzf_ = context.Operators.End(dzze_);
                CqlInterval<CqlDateTime> dzzg_ = context.Operators.Interval(dzzd_, dzzf_, true, true);

                return dzzg_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzh_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzi_ = context.Operators.End(dzzh_);
                CqlDateTime[] dzzj_ = [
                    dzzi_,
                ];
                CqlInterval<CqlDateTime> dzzk_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> dzzo_()
                    {
                        if (abatementDate is null)
                        {
                            DataType dzzp_ = condition?.Onset;
                            object dzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzp_);
                            CqlInterval<CqlDateTime> dzzr_ = this.ToInterval(context, dzzq_);
                            CqlDateTime dzzs_ = context.Operators.Start(dzzr_);
                            CqlInterval<CqlDateTime> dzzt_ = context.Operators.Interval(dzzs_, abatementDate, true, false);

                            return dzzt_;
                        }
                        else
                        {
                            DataType dzzu_ = condition?.Onset;
                            object dzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzu_);
                            CqlInterval<CqlDateTime> dzzw_ = this.ToInterval(context, dzzv_);
                            CqlDateTime dzzx_ = context.Operators.Start(dzzw_);
                            CqlInterval<CqlDateTime> dzzy_ = context.Operators.Interval(dzzx_, abatementDate, true, true);

                            return dzzy_;
                        }
                    };

                    return dzzo_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzl_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)dzzj_, dzzk_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzl_);
                CqlInterval<CqlDateTime> dzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzm_);

                return dzzn_;
            }
        };

        return czzh_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> dzzz_()
        {
            bool ezza_()
            {
                CodeableConcept ezzb_ = condition?.ClinicalStatus;
                CqlConcept ezzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzb_);
                CqlCode ezzd_ = this.active(context);
                CqlConcept ezze_ = context.Operators.ConvertCodeToConcept(ezzd_);
                bool? ezzf_ = context.Operators.Equivalent(ezzc_, ezze_);
                CqlConcept ezzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzb_);
                CqlCode ezzi_ = this.recurrence(context);
                CqlConcept ezzj_ = context.Operators.ConvertCodeToConcept(ezzi_);
                bool? ezzk_ = context.Operators.Equivalent(ezzh_, ezzj_);
                bool? ezzl_ = context.Operators.Or(ezzf_, ezzk_);
                CqlConcept ezzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzb_);
                CqlCode ezzo_ = this.relapse(context);
                CqlConcept ezzp_ = context.Operators.ConvertCodeToConcept(ezzo_);
                bool? ezzq_ = context.Operators.Equivalent(ezzn_, ezzp_);
                bool? ezzr_ = context.Operators.Or(ezzl_, ezzq_);

                return ezzr_ ?? false;
            };
            if (ezza_())
            {
                DataType ezzs_ = condition?.Onset;
                object ezzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzs_);
                CqlInterval<CqlDateTime> ezzu_ = this.toInterval(context, ezzt_);
                CqlDateTime ezzv_ = context.Operators.Start(ezzu_);
                CqlInterval<CqlDateTime> ezzw_ = this.abatementInterval(context, condition);
                CqlDateTime ezzx_ = context.Operators.End(ezzw_);
                CqlInterval<CqlDateTime> ezzy_ = context.Operators.Interval(ezzv_, ezzx_, true, true);

                return ezzy_;
            }
            else
            {
                CqlInterval<CqlDateTime> ezzz_ = this.abatementInterval(context, condition);
                CqlDateTime fzza_ = context.Operators.End(ezzz_);
                CqlDateTime[] fzzb_ = [
                    fzza_,
                ];
                CqlInterval<CqlDateTime> fzzc_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzg_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzh_ = condition?.Onset;
                            object fzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzh_);
                            CqlInterval<CqlDateTime> fzzj_ = this.toInterval(context, fzzi_);
                            CqlDateTime fzzk_ = context.Operators.Start(fzzj_);
                            CqlInterval<CqlDateTime> fzzl_ = context.Operators.Interval(fzzk_, abatementDate, true, false);

                            return fzzl_;
                        }
                        else
                        {
                            DataType fzzm_ = condition?.Onset;
                            object fzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzm_);
                            CqlInterval<CqlDateTime> fzzo_ = this.toInterval(context, fzzn_);
                            CqlDateTime fzzp_ = context.Operators.Start(fzzo_);
                            CqlInterval<CqlDateTime> fzzq_ = context.Operators.Interval(fzzp_, abatementDate, true, true);

                            return fzzq_;
                        }
                    };

                    return fzzg_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzd_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzb_, fzzc_);
                IEnumerable<CqlInterval<CqlDateTime>> fzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzd_);
                CqlInterval<CqlDateTime> fzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzze_);

                return fzzf_;
            }
        };

        return dzzz_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> fzzr_ = context.Operators.Split(uri, "/");
        string fzzs_ = context.Operators.Last<string>(fzzr_);

        return fzzs_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> fzzt_ = context.Operators.Split(uri, "/");
        string fzzu_ = context.Operators.Last<string>(fzzt_);

        return fzzu_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime fzzv_ = context.Operators.Start(period);
        CqlDateTime fzzx_ = context.Operators.MinValue<CqlDateTime>();
        bool? fzzy_ = context.Operators.Equal(fzzv_, fzzx_);
        bool? fzzz_ = context.Operators.Or((bool?)(fzzv_ is null), fzzy_);
        bool? gzza_ = context.Operators.Not(fzzz_);

        return gzza_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzb_ = context.Operators.Start(period);
        CqlDateTime gzzd_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzze_ = context.Operators.Equal(gzzb_, gzzd_);
        bool? gzzf_ = context.Operators.Or((bool?)(gzzb_ is null), gzze_);
        bool? gzzg_ = context.Operators.Not(gzzf_);

        return gzzg_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzh_ = context.Operators.End(period);
        CqlDateTime gzzj_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzk_ = context.Operators.Equal(gzzh_, gzzj_);
        bool? gzzl_ = context.Operators.Or((bool?)(gzzh_ is null), gzzk_);
        bool? gzzm_ = context.Operators.Not(gzzl_);

        return gzzm_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzn_ = context.Operators.End(period);
        CqlDateTime gzzp_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzq_ = context.Operators.Equal(gzzn_, gzzp_);
        bool? gzzr_ = context.Operators.Or((bool?)(gzzn_ is null), gzzq_);
        bool? gzzs_ = context.Operators.Not(gzzr_);

        return gzzs_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> gzzt_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] gzzu_ = [
            gzzt_,
        ];
        CqlDateTime gzzv_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime gzzz_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzza_ = context.Operators.End(period);

                    return hzza_;
                }
                else
                {
                    CqlDateTime hzzb_ = context.Operators.Start(period);

                    return hzzb_;
                }
            };

            return gzzz_();
        };
        IEnumerable<CqlDateTime> gzzw_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)gzzu_, gzzv_);
        IEnumerable<CqlDateTime> gzzx_ = context.Operators.Distinct<CqlDateTime>(gzzw_);
        CqlDateTime gzzy_ = context.Operators.SingletonFrom<CqlDateTime>(gzzx_);

        return gzzy_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzc_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzd_ = [
            hzzc_,
        ];
        CqlDateTime hzze_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzi_()
            {
                if ((this.hasEnd(context, period)) ?? false)
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


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzl_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzm_ = [
            hzzl_,
        ];
        CqlDateTime hzzn_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzr_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime hzzs_ = context.Operators.Start(period);

                    return hzzs_;
                }
                else
                {
                    CqlDateTime hzzt_ = context.Operators.End(period);

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


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzu_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzv_ = [
            hzzu_,
        ];
        CqlDateTime hzzw_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izza_()
            {
                if ((this.hasStart(context, period)) ?? false)
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


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzd_ = context.Operators.Start(Period);
        CqlDateTime izze_ = context.Operators.End(Period);
        int? izzf_ = context.Operators.DurationBetween(izzd_, izze_, "day");
        CqlInterval<int?> izzg_ = context.Operators.Interval(1, izzf_, true, true);
        CqlInterval<int?>[] izzh_ = [
            izzg_,
        ];
        IEnumerable<CqlInterval<int?>> izzi_ = context.Operators.Expand(izzh_ as IEnumerable<CqlInterval<int?>>, default);
        int? izzj_(CqlInterval<int?> DayNumber)
        {
            int? izzm_ = context.Operators.End(DayNumber);

            return izzm_;
        };
        IEnumerable<int?> izzk_ = context.Operators.Select<CqlInterval<int?>, int?>(izzi_, izzj_);
        IEnumerable<int?> izzl_ = context.Operators.Distinct<int?>(izzk_);

        return izzl_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
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


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> izzx_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? izzy_(int? DayIndex)
        {
            CqlDateTime jzzb_ = context.Operators.Start(Period);
            CqlQuantity jzzc_ = context.Operators.Quantity(24m, "hours");
            int? jzzd_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzze_ = context.Operators.ConvertIntegerToQuantity(jzzd_);
            CqlQuantity jzzf_ = context.Operators.Multiply(jzzc_, jzze_);
            CqlDateTime jzzg_ = context.Operators.Add(jzzb_, jzzf_);
            CqlDateTime jzzh_()
            {
                bool jzzk_()
                {
                    CqlDateTime jzzl_ = context.Operators.Start(Period);
                    CqlQuantity jzzm_ = context.Operators.Quantity(24m, "hours");
                    int? jzzn_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzo_ = context.Operators.ConvertIntegerToQuantity(jzzn_);
                    CqlQuantity jzzp_ = context.Operators.Multiply(jzzm_, jzzo_);
                    CqlDateTime jzzq_ = context.Operators.Add(jzzl_, jzzp_);
                    CqlDateTime jzzr_ = context.Operators.End(Period);
                    int? jzzs_ = context.Operators.DurationBetween(jzzq_, jzzr_, "hour");
                    bool? jzzt_ = context.Operators.Less(jzzs_, 24);

                    return jzzt_ ?? false;
                };
                if (jzzk_())
                {
                    CqlDateTime jzzu_ = context.Operators.Start(Period);
                    CqlQuantity jzzv_ = context.Operators.Quantity(24m, "hours");
                    int? jzzw_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzx_ = context.Operators.ConvertIntegerToQuantity(jzzw_);
                    CqlQuantity jzzy_ = context.Operators.Multiply(jzzv_, jzzx_);
                    CqlDateTime jzzz_ = context.Operators.Add(jzzu_, jzzy_);

                    return jzzz_;
                }
                else
                {
                    CqlDateTime kzza_ = context.Operators.Start(Period);
                    CqlQuantity kzzb_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzc_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzd_ = context.Operators.Multiply(kzzb_, kzzc_);
                    CqlDateTime kzze_ = context.Operators.Add(kzza_, kzzd_);

                    return kzze_;
                }
            };
            CqlInterval<CqlDateTime> jzzi_ = context.Operators.Interval(jzzg_, jzzh_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzj_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzi_);

            return jzzj_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> izzz_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(izzx_, izzy_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzza_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(izzz_);

        return jzza_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzf_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzg_(int? DayIndex)
        {
            CqlDateTime kzzj_ = context.Operators.Start(Period);
            CqlQuantity kzzk_ = context.Operators.Quantity(24m, "hours");
            int? kzzl_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity kzzm_ = context.Operators.ConvertIntegerToQuantity(kzzl_);
            CqlQuantity kzzn_ = context.Operators.Multiply(kzzk_, kzzm_);
            CqlDateTime kzzo_ = context.Operators.Add(kzzj_, kzzn_);
            CqlDateTime kzzp_()
            {
                bool kzzs_()
                {
                    CqlDateTime kzzt_ = context.Operators.Start(Period);
                    CqlQuantity kzzu_ = context.Operators.Quantity(24m, "hours");
                    int? kzzv_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzw_ = context.Operators.ConvertIntegerToQuantity(kzzv_);
                    CqlQuantity kzzx_ = context.Operators.Multiply(kzzu_, kzzw_);
                    CqlDateTime kzzy_ = context.Operators.Add(kzzt_, kzzx_);
                    CqlDateTime kzzz_ = context.Operators.End(Period);
                    int? lzza_ = context.Operators.DurationBetween(kzzy_, kzzz_, "hour");
                    bool? lzzb_ = context.Operators.Less(lzza_, 24);

                    return lzzb_ ?? false;
                };
                if (kzzs_())
                {
                    CqlDateTime lzzc_ = context.Operators.Start(Period);
                    CqlQuantity lzzd_ = context.Operators.Quantity(24m, "hours");
                    int? lzze_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzf_ = context.Operators.ConvertIntegerToQuantity(lzze_);
                    CqlQuantity lzzg_ = context.Operators.Multiply(lzzd_, lzzf_);
                    CqlDateTime lzzh_ = context.Operators.Add(lzzc_, lzzg_);

                    return lzzh_;
                }
                else
                {
                    CqlDateTime lzzi_ = context.Operators.Start(Period);
                    CqlQuantity lzzj_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity lzzk_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity lzzl_ = context.Operators.Multiply(lzzj_, lzzk_);
                    CqlDateTime lzzm_ = context.Operators.Add(lzzi_, lzzl_);

                    return lzzm_;
                }
            };
            CqlInterval<CqlDateTime> kzzq_ = context.Operators.Interval(kzzo_, kzzp_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzr_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, kzzq_);

            return kzzr_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzh_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzf_, kzzg_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzi_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzh_);

        return kzzi_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
