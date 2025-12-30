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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("QICoreCommon", "4.0.000")]
public partial class QICoreCommon_4_0_000 : ILibrary, ISingleton<QICoreCommon_4_0_000>
{
    private QICoreCommon_4_0_000() {}

    public static QICoreCommon_4_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "QICoreCommon";
    public string Version => "4.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

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

    #region CodeSystems

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

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    [CqlFunctionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "clinicalStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode h_ = this.recurrence(context);
        CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
        bool? j_ = context.Operators.Equivalent(g_, i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode n_ = this.relapse(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        bool? p_ = context.Operators.Equivalent(m_, o_);
        bool? q_ = context.Operators.Or(k_, p_);
        return q_;
    }


    [CqlFunctionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, object condition, CqlCode category)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(category);
            bool? l_ = context.Operators.Equivalent(C, k_);
            return l_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.problem_list_item(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.encounter_diagnosis(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.health_concern(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.social_history(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.vital_signs(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.imaging(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.laboratory(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isProcedure")]
    [CqlTag("description", "Returns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.procedure(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.survey(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.exam(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.therapy(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, object observation)
    {
        object a_ = context.Operators.LateBoundProperty<object>(observation, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.activity(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, object medicationRequest)
    {
        object a_ = context.Operators.LateBoundProperty<object>(medicationRequest, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.Community(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, object medicationRequest)
    {
        object a_ = context.Operators.LateBoundProperty<object>(medicationRequest, "category");
        object[] b_ = [
            a_,
        ];

        CqlConcept c_(object @this) {
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this as CodeableConcept);
            return j_;
        }

        IEnumerable<CqlConcept> d_ = context.Operators.Select<object, CqlConcept>((IEnumerable<object>)b_, c_);
        CqlConcept e_ = context.Operators.SingletonFrom<CqlConcept>(d_);
        CqlConcept[] f_ = [
            e_,
        ];

        bool? g_(CqlConcept C) {
            CqlCode k_ = this.Discharge(context);
            CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
            bool? m_ = context.Operators.Equivalent(C, l_);
            return m_;
        }

        IEnumerable<CqlConcept> h_ = context.Operators.Where<CqlConcept>((IEnumerable<CqlConcept>)f_, g_);
        bool? i_ = context.Operators.Exists<CqlConcept>(h_);
        return i_;
    }


    [CqlFunctionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    [CqlTag("deprecated", "This function is no longer required in QICore 6.0.0 and above")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {

        bool? a_(Extension @this) {
            FhirUri f_ = @this?.UrlElement;
            FhirString g_ = context.Operators.Convert<FhirString>(f_);
            string h_ = FHIRHelpers_4_4_000.Instance.ToString(context, g_);
            bool? i_ = context.Operators.Equal(h_, "http://hl7.org/fhir/5.0/StructureDefinition/extension-DeviceRequest.doNotPerform");
            return i_;
        }

        IEnumerable<Extension> b_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(deviceRequest is DomainResource
            ? (deviceRequest as DomainResource).ModifierExtension
            : default), a_);

        object c_(Extension @this) {
            DataType j_ = @this?.Value;
            return j_;
        }

        IEnumerable<object> d_ = context.Operators.Select<Extension, object>(b_, c_);
        object e_ = context.Operators.SingletonFrom<object>(d_);
        return (bool?)e_;
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {

        CqlInterval<CqlDateTime> a_() {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);
                return b_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient c_ = this.Patient(context);
                Date d_ = c_?.BirthDateElement;
                string e_ = d_?.Value;
                CqlDate f_ = context.Operators.ConvertStringToDate(e_);
                CqlDate g_ = context.Operators.Add(f_, choice as CqlQuantity);
                Date i_ = c_?.BirthDateElement;
                string j_ = i_?.Value;
                CqlDate k_ = context.Operators.ConvertStringToDate(j_);
                CqlDate l_ = context.Operators.Add(k_, choice as CqlQuantity);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDate> o_ = context.Operators.Interval(g_, n_, true, false);
                CqlDate p_ = o_?.low;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                Date s_ = c_?.BirthDateElement;
                string t_ = s_?.Value;
                CqlDate u_ = context.Operators.ConvertStringToDate(t_);
                CqlDate v_ = context.Operators.Add(u_, choice as CqlQuantity);
                Date x_ = c_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                CqlDate aa_ = context.Operators.Add(z_, choice as CqlQuantity);
                CqlDate ac_ = context.Operators.Add(aa_, m_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                Date ah_ = c_?.BirthDateElement;
                string ai_ = ah_?.Value;
                CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
                CqlDate ak_ = context.Operators.Add(aj_, choice as CqlQuantity);
                Date am_ = c_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDate ao_ = context.Operators.ConvertStringToDate(an_);
                CqlDate ap_ = context.Operators.Add(ao_, choice as CqlQuantity);
                CqlDate ar_ = context.Operators.Add(ap_, m_);
                CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
                bool? at_ = as_?.lowClosed;
                Date av_ = c_?.BirthDateElement;
                string aw_ = av_?.Value;
                CqlDate ax_ = context.Operators.ConvertStringToDate(aw_);
                CqlDate ay_ = context.Operators.Add(ax_, choice as CqlQuantity);
                Date ba_ = c_?.BirthDateElement;
                string bb_ = ba_?.Value;
                CqlDate bc_ = context.Operators.ConvertStringToDate(bb_);
                CqlDate bd_ = context.Operators.Add(bc_, choice as CqlQuantity);
                CqlDate bf_ = context.Operators.Add(bd_, m_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ay_, bf_, true, false);
                bool? bh_ = bg_?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(q_, af_, at_, bh_);
                return bi_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                string bl_ = bk_?.Value;
                CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
                object bn_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate bo_ = context.Operators.Add(bm_, bn_ as CqlQuantity);
                Date bq_ = bj_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bt_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate bu_ = context.Operators.Add(bs_, bt_ as CqlQuantity);
                CqlQuantity bv_ = context.Operators.Quantity(1m, "year");
                CqlDate bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
                CqlDate by_ = bx_?.low;
                CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_);
                Date cb_ = bj_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                CqlDate cf_ = context.Operators.Add(cd_, bn_ as CqlQuantity);
                Date ch_ = bj_?.BirthDateElement;
                string ci_ = ch_?.Value;
                CqlDate cj_ = context.Operators.ConvertStringToDate(ci_);
                CqlDate cl_ = context.Operators.Add(cj_, bt_ as CqlQuantity);
                CqlDate cn_ = context.Operators.Add(cl_, bv_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(cf_, cn_, true, false);
                CqlDate cp_ = co_?.high;
                CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
                Date cs_ = bj_?.BirthDateElement;
                string ct_ = cs_?.Value;
                CqlDate cu_ = context.Operators.ConvertStringToDate(ct_);
                CqlDate cw_ = context.Operators.Add(cu_, bn_ as CqlQuantity);
                Date cy_ = bj_?.BirthDateElement;
                string cz_ = cy_?.Value;
                CqlDate da_ = context.Operators.ConvertStringToDate(cz_);
                CqlDate dc_ = context.Operators.Add(da_, bt_ as CqlQuantity);
                CqlDate de_ = context.Operators.Add(dc_, bv_);
                CqlInterval<CqlDate> df_ = context.Operators.Interval(cw_, de_, true, false);
                bool? dg_ = df_?.lowClosed;
                Date di_ = bj_?.BirthDateElement;
                string dj_ = di_?.Value;
                CqlDate dk_ = context.Operators.ConvertStringToDate(dj_);
                CqlDate dm_ = context.Operators.Add(dk_, bn_ as CqlQuantity);
                Date do_ = bj_?.BirthDateElement;
                string dp_ = do_?.Value;
                CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
                CqlDate ds_ = context.Operators.Add(dq_, bt_ as CqlQuantity);
                CqlDate du_ = context.Operators.Add(ds_, bv_);
                CqlInterval<CqlDate> dv_ = context.Operators.Interval(dm_, du_, true, false);
                bool? dw_ = dv_?.highClosed;
                CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(bz_, cq_, dg_, dw_);
                return dx_;
            }
            else if (choice is Timing)
            {
                object dy_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");
                return dy_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {

        CqlInterval<CqlDateTime> a_() {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);
                return b_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient c_ = this.Patient(context);
                Date d_ = c_?.BirthDateElement;
                string e_ = d_?.Value;
                CqlDate f_ = context.Operators.ConvertStringToDate(e_);
                CqlDate g_ = context.Operators.Add(f_, choice as CqlQuantity);
                Date i_ = c_?.BirthDateElement;
                string j_ = i_?.Value;
                CqlDate k_ = context.Operators.ConvertStringToDate(j_);
                CqlDate l_ = context.Operators.Add(k_, choice as CqlQuantity);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDate> o_ = context.Operators.Interval(g_, n_, true, false);
                CqlDate p_ = o_?.low;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                Date s_ = c_?.BirthDateElement;
                string t_ = s_?.Value;
                CqlDate u_ = context.Operators.ConvertStringToDate(t_);
                CqlDate v_ = context.Operators.Add(u_, choice as CqlQuantity);
                Date x_ = c_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                CqlDate aa_ = context.Operators.Add(z_, choice as CqlQuantity);
                CqlDate ac_ = context.Operators.Add(aa_, m_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                Date ah_ = c_?.BirthDateElement;
                string ai_ = ah_?.Value;
                CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
                CqlDate ak_ = context.Operators.Add(aj_, choice as CqlQuantity);
                Date am_ = c_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDate ao_ = context.Operators.ConvertStringToDate(an_);
                CqlDate ap_ = context.Operators.Add(ao_, choice as CqlQuantity);
                CqlDate ar_ = context.Operators.Add(ap_, m_);
                CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
                bool? at_ = as_?.lowClosed;
                Date av_ = c_?.BirthDateElement;
                string aw_ = av_?.Value;
                CqlDate ax_ = context.Operators.ConvertStringToDate(aw_);
                CqlDate ay_ = context.Operators.Add(ax_, choice as CqlQuantity);
                Date ba_ = c_?.BirthDateElement;
                string bb_ = ba_?.Value;
                CqlDate bc_ = context.Operators.ConvertStringToDate(bb_);
                CqlDate bd_ = context.Operators.Add(bc_, choice as CqlQuantity);
                CqlDate bf_ = context.Operators.Add(bd_, m_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ay_, bf_, true, false);
                bool? bh_ = bg_?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(q_, af_, at_, bh_);
                return bi_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                string bl_ = bk_?.Value;
                CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
                object bn_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate bo_ = context.Operators.Add(bm_, bn_ as CqlQuantity);
                Date bq_ = bj_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bt_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate bu_ = context.Operators.Add(bs_, bt_ as CqlQuantity);
                CqlQuantity bv_ = context.Operators.Quantity(1m, "year");
                CqlDate bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
                CqlDate by_ = bx_?.low;
                CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_);
                Date cb_ = bj_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                CqlDate cf_ = context.Operators.Add(cd_, bn_ as CqlQuantity);
                Date ch_ = bj_?.BirthDateElement;
                string ci_ = ch_?.Value;
                CqlDate cj_ = context.Operators.ConvertStringToDate(ci_);
                CqlDate cl_ = context.Operators.Add(cj_, bt_ as CqlQuantity);
                CqlDate cn_ = context.Operators.Add(cl_, bv_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(cf_, cn_, true, false);
                CqlDate cp_ = co_?.high;
                CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
                Date cs_ = bj_?.BirthDateElement;
                string ct_ = cs_?.Value;
                CqlDate cu_ = context.Operators.ConvertStringToDate(ct_);
                CqlDate cw_ = context.Operators.Add(cu_, bn_ as CqlQuantity);
                Date cy_ = bj_?.BirthDateElement;
                string cz_ = cy_?.Value;
                CqlDate da_ = context.Operators.ConvertStringToDate(cz_);
                CqlDate dc_ = context.Operators.Add(da_, bt_ as CqlQuantity);
                CqlDate de_ = context.Operators.Add(dc_, bv_);
                CqlInterval<CqlDate> df_ = context.Operators.Interval(cw_, de_, true, false);
                bool? dg_ = df_?.lowClosed;
                Date di_ = bj_?.BirthDateElement;
                string dj_ = di_?.Value;
                CqlDate dk_ = context.Operators.ConvertStringToDate(dj_);
                CqlDate dm_ = context.Operators.Add(dk_, bn_ as CqlQuantity);
                Date do_ = bj_?.BirthDateElement;
                string dp_ = do_?.Value;
                CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
                CqlDate ds_ = context.Operators.Add(dq_, bt_ as CqlQuantity);
                CqlDate du_ = context.Operators.Add(ds_, bv_);
                CqlInterval<CqlDate> dv_ = context.Operators.Interval(dm_, du_, true, false);
                bool? dw_ = dv_?.highClosed;
                CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(bz_, cq_, dg_, dw_);
                return dx_;
            }
            else if (choice is Timing)
            {
                object dy_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");
                return dy_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, object condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                object f_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                bool h_ = g_ is CqlDateTime;
                return h_;
            }


            bool c_() {
                object i_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                bool k_ = j_ is CqlQuantity;
                return k_;
            }


            bool d_() {
                object l_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlInterval<CqlQuantity>;
                return n_;
            }


            bool e_() {
                object o_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;
                return q_;
            }

            if (b_())
            {
                object r_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_ as CqlDateTime, u_ as CqlDateTime, true, true);
                return v_;
            }
            else if (c_())
            {
                Patient w_ = this.Patient(context);
                Date x_ = w_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                object aa_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate ac_ = context.Operators.Add(z_, ab_ as CqlQuantity);
                Date ae_ = w_?.BirthDateElement;
                string af_ = ae_?.Value;
                CqlDate ag_ = context.Operators.ConvertStringToDate(af_);
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate aj_ = context.Operators.Add(ag_, ai_ as CqlQuantity);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ac_, al_, true, false);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                Date aq_ = w_?.BirthDateElement;
                string ar_ = aq_?.Value;
                CqlDate as_ = context.Operators.ConvertStringToDate(ar_);
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate av_ = context.Operators.Add(as_, au_ as CqlQuantity);
                Date ax_ = w_?.BirthDateElement;
                string ay_ = ax_?.Value;
                CqlDate az_ = context.Operators.ConvertStringToDate(ay_);
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bc_ = context.Operators.Add(az_, bb_ as CqlQuantity);
                CqlDate be_ = context.Operators.Add(bc_, ak_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(av_, be_, true, false);
                CqlDate bg_ = bf_?.high;
                CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
                Date bj_ = w_?.BirthDateElement;
                string bk_ = bj_?.Value;
                CqlDate bl_ = context.Operators.ConvertStringToDate(bk_);
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bo_ = context.Operators.Add(bl_, bn_ as CqlQuantity);
                Date bq_ = w_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bv_ = context.Operators.Add(bs_, bu_ as CqlQuantity);
                CqlDate bx_ = context.Operators.Add(bv_, ak_);
                CqlInterval<CqlDate> by_ = context.Operators.Interval(bo_, bx_, true, false);
                bool? bz_ = by_?.lowClosed;
                Date cb_ = w_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate cg_ = context.Operators.Add(cd_, cf_ as CqlQuantity);
                Date ci_ = w_?.BirthDateElement;
                string cj_ = ci_?.Value;
                CqlDate ck_ = context.Operators.ConvertStringToDate(cj_);
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate cn_ = context.Operators.Add(ck_, cm_ as CqlQuantity);
                CqlDate cp_ = context.Operators.Add(cn_, ak_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(cg_, cp_, true, false);
                bool? cr_ = cq_?.highClosed;
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(ao_, bh_, bz_, cr_);
                return cs_;
            }
            else if (d_())
            {
                Patient ct_ = this.Patient(context);
                Date cu_ = ct_?.BirthDateElement;
                string cv_ = cu_?.Value;
                CqlDate cw_ = context.Operators.ConvertStringToDate(cv_);
                object cx_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object cz_ = context.Operators.LateBoundProperty<object>(cy_, "low");
                CqlDate da_ = context.Operators.Add(cw_, cz_ as CqlQuantity);
                Date dc_ = ct_?.BirthDateElement;
                string dd_ = dc_?.Value;
                CqlDate de_ = context.Operators.ConvertStringToDate(dd_);
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object dh_ = context.Operators.LateBoundProperty<object>(dg_, "high");
                CqlDate di_ = context.Operators.Add(de_, dh_ as CqlQuantity);
                CqlQuantity dj_ = context.Operators.Quantity(1m, "year");
                CqlDate dk_ = context.Operators.Add(di_, dj_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(da_, dk_, true, false);
                CqlDate dm_ = dl_?.low;
                CqlDateTime dn_ = context.Operators.ConvertDateToDateTime(dm_);
                Date dp_ = ct_?.BirthDateElement;
                string dq_ = dp_?.Value;
                CqlDate dr_ = context.Operators.ConvertStringToDate(dq_);
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object du_ = context.Operators.LateBoundProperty<object>(dt_, "low");
                CqlDate dv_ = context.Operators.Add(dr_, du_ as CqlQuantity);
                Date dx_ = ct_?.BirthDateElement;
                string dy_ = dx_?.Value;
                CqlDate dz_ = context.Operators.ConvertStringToDate(dy_);
                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ec_ = context.Operators.LateBoundProperty<object>(eb_, "high");
                CqlDate ed_ = context.Operators.Add(dz_, ec_ as CqlQuantity);
                CqlDate ef_ = context.Operators.Add(ed_, dj_);
                CqlInterval<CqlDate> eg_ = context.Operators.Interval(dv_, ef_, true, false);
                CqlDate eh_ = eg_?.high;
                CqlDateTime ei_ = context.Operators.ConvertDateToDateTime(eh_);
                Date ek_ = ct_?.BirthDateElement;
                string el_ = ek_?.Value;
                CqlDate em_ = context.Operators.ConvertStringToDate(el_);
                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ep_ = context.Operators.LateBoundProperty<object>(eo_, "low");
                CqlDate eq_ = context.Operators.Add(em_, ep_ as CqlQuantity);
                Date es_ = ct_?.BirthDateElement;
                string et_ = es_?.Value;
                CqlDate eu_ = context.Operators.ConvertStringToDate(et_);
                object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ex_ = context.Operators.LateBoundProperty<object>(ew_, "high");
                CqlDate ey_ = context.Operators.Add(eu_, ex_ as CqlQuantity);
                CqlDate fa_ = context.Operators.Add(ey_, dj_);
                CqlInterval<CqlDate> fb_ = context.Operators.Interval(eq_, fa_, true, false);
                bool? fc_ = fb_?.lowClosed;
                Date fe_ = ct_?.BirthDateElement;
                string ff_ = fe_?.Value;
                CqlDate fg_ = context.Operators.ConvertStringToDate(ff_);
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object fj_ = context.Operators.LateBoundProperty<object>(fi_, "low");
                CqlDate fk_ = context.Operators.Add(fg_, fj_ as CqlQuantity);
                Date fm_ = ct_?.BirthDateElement;
                string fn_ = fm_?.Value;
                CqlDate fo_ = context.Operators.ConvertStringToDate(fn_);
                object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object fr_ = context.Operators.LateBoundProperty<object>(fq_, "high");
                CqlDate fs_ = context.Operators.Add(fo_, fr_ as CqlQuantity);
                CqlDate fu_ = context.Operators.Add(fs_, dj_);
                CqlInterval<CqlDate> fv_ = context.Operators.Interval(fk_, fu_, true, false);
                bool? fw_ = fv_?.highClosed;
                CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(dn_, ei_, fc_, fw_);
                return fx_;
            }
            else if (e_())
            {
                object fy_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                object ga_ = context.Operators.LateBoundProperty<object>(fz_, "low");
                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                object gd_ = context.Operators.LateBoundProperty<object>(gc_, "high");
                CqlInterval<CqlDateTime> ge_ = context.Operators.Interval(ga_ as CqlDateTime, gd_ as CqlDateTime, true, false);
                return ge_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, object condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                object f_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                bool h_ = g_ is CqlDateTime;
                return h_;
            }


            bool c_() {
                object i_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                bool k_ = j_ is CqlQuantity;
                return k_;
            }


            bool d_() {
                object l_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlInterval<CqlQuantity>;
                return n_;
            }


            bool e_() {
                object o_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;
                return q_;
            }

            if (b_())
            {
                object r_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_ as CqlDateTime, u_ as CqlDateTime, true, true);
                return v_;
            }
            else if (c_())
            {
                Patient w_ = this.Patient(context);
                Date x_ = w_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                object aa_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate ac_ = context.Operators.Add(z_, ab_ as CqlQuantity);
                Date ae_ = w_?.BirthDateElement;
                string af_ = ae_?.Value;
                CqlDate ag_ = context.Operators.ConvertStringToDate(af_);
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate aj_ = context.Operators.Add(ag_, ai_ as CqlQuantity);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ac_, al_, true, false);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                Date aq_ = w_?.BirthDateElement;
                string ar_ = aq_?.Value;
                CqlDate as_ = context.Operators.ConvertStringToDate(ar_);
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate av_ = context.Operators.Add(as_, au_ as CqlQuantity);
                Date ax_ = w_?.BirthDateElement;
                string ay_ = ax_?.Value;
                CqlDate az_ = context.Operators.ConvertStringToDate(ay_);
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bc_ = context.Operators.Add(az_, bb_ as CqlQuantity);
                CqlDate be_ = context.Operators.Add(bc_, ak_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(av_, be_, true, false);
                CqlDate bg_ = bf_?.high;
                CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
                Date bj_ = w_?.BirthDateElement;
                string bk_ = bj_?.Value;
                CqlDate bl_ = context.Operators.ConvertStringToDate(bk_);
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bo_ = context.Operators.Add(bl_, bn_ as CqlQuantity);
                Date bq_ = w_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate bv_ = context.Operators.Add(bs_, bu_ as CqlQuantity);
                CqlDate bx_ = context.Operators.Add(bv_, ak_);
                CqlInterval<CqlDate> by_ = context.Operators.Interval(bo_, bx_, true, false);
                bool? bz_ = by_?.lowClosed;
                Date cb_ = w_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate cg_ = context.Operators.Add(cd_, cf_ as CqlQuantity);
                Date ci_ = w_?.BirthDateElement;
                string cj_ = ci_?.Value;
                CqlDate ck_ = context.Operators.ConvertStringToDate(cj_);
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlDate cn_ = context.Operators.Add(ck_, cm_ as CqlQuantity);
                CqlDate cp_ = context.Operators.Add(cn_, ak_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(cg_, cp_, true, false);
                bool? cr_ = cq_?.highClosed;
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(ao_, bh_, bz_, cr_);
                return cs_;
            }
            else if (d_())
            {
                Patient ct_ = this.Patient(context);
                Date cu_ = ct_?.BirthDateElement;
                string cv_ = cu_?.Value;
                CqlDate cw_ = context.Operators.ConvertStringToDate(cv_);
                object cx_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object cz_ = context.Operators.LateBoundProperty<object>(cy_, "low");
                CqlDate da_ = context.Operators.Add(cw_, cz_ as CqlQuantity);
                Date dc_ = ct_?.BirthDateElement;
                string dd_ = dc_?.Value;
                CqlDate de_ = context.Operators.ConvertStringToDate(dd_);
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object dh_ = context.Operators.LateBoundProperty<object>(dg_, "high");
                CqlDate di_ = context.Operators.Add(de_, dh_ as CqlQuantity);
                CqlQuantity dj_ = context.Operators.Quantity(1m, "year");
                CqlDate dk_ = context.Operators.Add(di_, dj_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(da_, dk_, true, false);
                CqlDate dm_ = dl_?.low;
                CqlDateTime dn_ = context.Operators.ConvertDateToDateTime(dm_);
                Date dp_ = ct_?.BirthDateElement;
                string dq_ = dp_?.Value;
                CqlDate dr_ = context.Operators.ConvertStringToDate(dq_);
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object du_ = context.Operators.LateBoundProperty<object>(dt_, "low");
                CqlDate dv_ = context.Operators.Add(dr_, du_ as CqlQuantity);
                Date dx_ = ct_?.BirthDateElement;
                string dy_ = dx_?.Value;
                CqlDate dz_ = context.Operators.ConvertStringToDate(dy_);
                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ec_ = context.Operators.LateBoundProperty<object>(eb_, "high");
                CqlDate ed_ = context.Operators.Add(dz_, ec_ as CqlQuantity);
                CqlDate ef_ = context.Operators.Add(ed_, dj_);
                CqlInterval<CqlDate> eg_ = context.Operators.Interval(dv_, ef_, true, false);
                CqlDate eh_ = eg_?.high;
                CqlDateTime ei_ = context.Operators.ConvertDateToDateTime(eh_);
                Date ek_ = ct_?.BirthDateElement;
                string el_ = ek_?.Value;
                CqlDate em_ = context.Operators.ConvertStringToDate(el_);
                object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ep_ = context.Operators.LateBoundProperty<object>(eo_, "low");
                CqlDate eq_ = context.Operators.Add(em_, ep_ as CqlQuantity);
                Date es_ = ct_?.BirthDateElement;
                string et_ = es_?.Value;
                CqlDate eu_ = context.Operators.ConvertStringToDate(et_);
                object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object ex_ = context.Operators.LateBoundProperty<object>(ew_, "high");
                CqlDate ey_ = context.Operators.Add(eu_, ex_ as CqlQuantity);
                CqlDate fa_ = context.Operators.Add(ey_, dj_);
                CqlInterval<CqlDate> fb_ = context.Operators.Interval(eq_, fa_, true, false);
                bool? fc_ = fb_?.lowClosed;
                Date fe_ = ct_?.BirthDateElement;
                string ff_ = fe_?.Value;
                CqlDate fg_ = context.Operators.ConvertStringToDate(ff_);
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object fj_ = context.Operators.LateBoundProperty<object>(fi_, "low");
                CqlDate fk_ = context.Operators.Add(fg_, fj_ as CqlQuantity);
                Date fm_ = ct_?.BirthDateElement;
                string fn_ = fm_?.Value;
                CqlDate fo_ = context.Operators.ConvertStringToDate(fn_);
                object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                object fr_ = context.Operators.LateBoundProperty<object>(fq_, "high");
                CqlDate fs_ = context.Operators.Add(fo_, fr_ as CqlQuantity);
                CqlDate fu_ = context.Operators.Add(fs_, dj_);
                CqlInterval<CqlDate> fv_ = context.Operators.Interval(fk_, fu_, true, false);
                bool? fw_ = fv_?.highClosed;
                CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(dn_, ei_, fc_, fw_);
                return fx_;
            }
            else if (e_())
            {
                object fy_ = context.Operators.LateBoundProperty<object>(condition, "abatement");
                object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                object ga_ = context.Operators.LateBoundProperty<object>(fz_, "low");
                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                object gd_ = context.Operators.LateBoundProperty<object>(gc_, "high");
                CqlInterval<CqlDateTime> ge_ = context.Operators.Interval(ga_ as CqlDateTime, gd_ as CqlDateTime, true, false);
                return ge_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, object condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                object c_ = context.Operators.LateBoundProperty<object>(condition, "clinicalStatus");
                CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode j_ = this.recurrence(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_ = context.Operators.Or(g_, l_);
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode p_ = this.relapse(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or(m_, r_);
                return s_ ?? false;
            }

            if (b_())
            {
                object t_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = this.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> x_ = this.ToAbatementInterval(context, condition);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);
                return z_;
            }
            else
            {
                CqlInterval<CqlDateTime> aa_ = this.ToAbatementInterval(context, condition);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlDateTime[] ac_ = [
                    ab_,
                ];

                CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate) {

                    CqlInterval<CqlDateTime> ah_() {
                        if (abatementDate is null)
                        {
                            object ai_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            CqlInterval<CqlDateTime> ak_ = this.ToInterval(context, aj_);
                            CqlDateTime al_ = context.Operators.Start(ak_);
                            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(al_, abatementDate, true, false);
                            return am_;
                        }
                        else
                        {
                            object an_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            CqlInterval<CqlDateTime> ap_ = this.ToInterval(context, ao_);
                            CqlDateTime aq_ = context.Operators.Start(ap_);
                            CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(aq_, abatementDate, true, true);
                            return ar_;
                        };
                    }

                    return ah_();
                }

                IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
                IEnumerable<CqlInterval<CqlDateTime>> af_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(af_);
                return ag_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, object condition)
    {

        CqlInterval<CqlDateTime> a_() {

            bool b_() {
                object c_ = context.Operators.LateBoundProperty<object>(condition, "clinicalStatus");
                CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode j_ = this.recurrence(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_ = context.Operators.Or(g_, l_);
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, c_ as CodeableConcept);
                CqlCode p_ = this.relapse(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or(m_, r_);
                return s_ ?? false;
            }

            if (b_())
            {
                object t_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = this.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> x_ = this.abatementInterval(context, condition);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);
                return z_;
            }
            else
            {
                CqlInterval<CqlDateTime> aa_ = this.abatementInterval(context, condition);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlDateTime[] ac_ = [
                    ab_,
                ];

                CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate) {

                    CqlInterval<CqlDateTime> ah_() {
                        if (abatementDate is null)
                        {
                            object ai_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            CqlInterval<CqlDateTime> ak_ = this.toInterval(context, aj_);
                            CqlDateTime al_ = context.Operators.Start(ak_);
                            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(al_, abatementDate, true, false);
                            return am_;
                        }
                        else
                        {
                            object an_ = context.Operators.LateBoundProperty<object>(condition, "onset");
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            CqlInterval<CqlDateTime> ap_ = this.toInterval(context, ao_);
                            CqlDateTime aq_ = context.Operators.Start(ap_);
                            CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(aq_, abatementDate, true, true);
                            return ar_;
                        };
                    }

                    return ah_();
                }

                IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
                IEnumerable<CqlInterval<CqlDateTime>> af_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(af_);
                return ag_;
            };
        }

        return a_();
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
            bool? d_ = this.references(context, R, resource);
            return d_;
        }

        IEnumerable<ResourceReference> b_ = context.Operators.Where<ResourceReference>(references, a_);
        bool? c_ = context.Operators.Exists<ResourceReference>(b_);
        return c_;
    }


    [CqlFunctionDefinition("references")]
    [CqlTag("description", "Returns true if any of the given references are to the given resourceId")]
    [CqlTag("comment", "Returns true if the `resourceId` parameter exactly equals the tail of any of the given references.\nNOTE: This function assumes resources from the same source server.")]
    public bool? references(CqlContext context, IEnumerable<ResourceReference> references, string resourceId)
    {

        bool? a_(ResourceReference R) {
            bool? d_ = this.references(context, R, resourceId);
            return d_;
        }

        IEnumerable<ResourceReference> b_ = context.Operators.Where<ResourceReference>(references, a_);
        bool? c_ = context.Operators.Exists<ResourceReference>(b_);
        return c_;
    }


    [CqlFunctionDefinition("includesCode")]
    [CqlTag("description", "Returns true if the given code is in the given codeList")]
    [CqlTag("comment", "Returns true if the `code` is equivalent to any of the codes in the given `codeList`, false otherwise.")]
    public bool? includesCode(CqlContext context, IEnumerable<CqlConcept> codeList, CqlCode code)
    {

        bool? a_(CqlConcept C) {
            CqlConcept d_ = context.Operators.ConvertCodeToConcept(code);
            bool? e_ = context.Operators.Equivalent(C, d_);
            return e_;
        }

        IEnumerable<CqlConcept> b_ = context.Operators.Where<CqlConcept>(codeList, a_);
        bool? c_ = context.Operators.Exists<CqlConcept>(b_);
        return c_;
    }


    [CqlFunctionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);
        return f_;
    }


    [CqlFunctionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);
        return f_;
    }


    [CqlFunctionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);
        return f_;
    }


    [CqlFunctionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);
        return f_;
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

            CqlDateTime g_() {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.End(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.Start(period);
                    return i_;
                };
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
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

            CqlDateTime g_() {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.End(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.Start(period);
                    return i_;
                };
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
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

            CqlDateTime g_() {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.Start(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.End(period);
                    return i_;
                };
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
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

            CqlDateTime g_() {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.Start(period);
                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.End(period);
                    return i_;
                };
            }

            return g_();
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);
        return f_;
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
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((IEnumerable<CqlInterval<int?>>)e_, default);

        int? g_(CqlInterval<int?> DayNumber) {
            int? j_ = context.Operators.End(DayNumber);
            return j_;
        }

        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);
        IEnumerable<int?> i_ = context.Operators.Distinct<int?>(h_);
        return i_;
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
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand((IEnumerable<CqlInterval<int?>>)e_, default);

        int? g_(CqlInterval<int?> DayNumber) {
            int? j_ = context.Operators.End(DayNumber);
            return j_;
        }

        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);
        IEnumerable<int?> i_ = context.Operators.Distinct<int?>(h_);
        return i_;
    }


    [CqlFunctionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);

        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex) {
            CqlDateTime e_ = context.Operators.Start(Period);
            CqlQuantity f_ = context.Operators.Quantity(24m, "hours");
            int? g_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity h_ = context.Operators.ConvertIntegerToQuantity(g_);
            CqlQuantity i_ = context.Operators.Multiply(f_, h_);
            CqlDateTime j_ = context.Operators.Add(e_, i_);

            CqlDateTime k_() {

                bool n_() {
                    CqlDateTime o_ = context.Operators.Start(Period);
                    CqlQuantity p_ = context.Operators.Quantity(24m, "hours");
                    int? q_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity r_ = context.Operators.ConvertIntegerToQuantity(q_);
                    CqlQuantity s_ = context.Operators.Multiply(p_, r_);
                    CqlDateTime t_ = context.Operators.Add(o_, s_);
                    CqlDateTime u_ = context.Operators.End(Period);
                    int? v_ = context.Operators.DurationBetween(t_, u_, "hour");
                    bool? w_ = context.Operators.Less(v_, 24);
                    return w_ ?? false;
                }

                if (n_())
                {
                    CqlDateTime x_ = context.Operators.Start(Period);
                    CqlQuantity y_ = context.Operators.Quantity(24m, "hours");
                    int? z_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity aa_ = context.Operators.ConvertIntegerToQuantity(z_);
                    CqlQuantity ab_ = context.Operators.Multiply(y_, aa_);
                    CqlDateTime ac_ = context.Operators.Add(x_, ab_);
                    return ac_;
                }
                else
                {
                    CqlDateTime ad_ = context.Operators.Start(Period);
                    CqlQuantity ae_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity af_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity ag_ = context.Operators.Multiply(ae_, af_);
                    CqlDateTime ah_ = context.Operators.Add(ad_, ag_);
                    return ah_;
                };
            }

            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(j_, k_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? m_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);

        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex) {
            CqlDateTime e_ = context.Operators.Start(Period);
            CqlQuantity f_ = context.Operators.Quantity(24m, "hours");
            int? g_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity h_ = context.Operators.ConvertIntegerToQuantity(g_);
            CqlQuantity i_ = context.Operators.Multiply(f_, h_);
            CqlDateTime j_ = context.Operators.Add(e_, i_);

            CqlDateTime k_() {

                bool n_() {
                    CqlDateTime o_ = context.Operators.Start(Period);
                    CqlQuantity p_ = context.Operators.Quantity(24m, "hours");
                    int? q_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity r_ = context.Operators.ConvertIntegerToQuantity(q_);
                    CqlQuantity s_ = context.Operators.Multiply(p_, r_);
                    CqlDateTime t_ = context.Operators.Add(o_, s_);
                    CqlDateTime u_ = context.Operators.End(Period);
                    int? v_ = context.Operators.DurationBetween(t_, u_, "hour");
                    bool? w_ = context.Operators.Less(v_, 24);
                    return w_ ?? false;
                }

                if (n_())
                {
                    CqlDateTime x_ = context.Operators.Start(Period);
                    CqlQuantity y_ = context.Operators.Quantity(24m, "hours");
                    int? z_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity aa_ = context.Operators.ConvertIntegerToQuantity(z_);
                    CqlQuantity ab_ = context.Operators.Multiply(y_, aa_);
                    CqlDateTime ac_ = context.Operators.Add(x_, ab_);
                    return ac_;
                }
                else
                {
                    CqlDateTime ad_ = context.Operators.Start(Period);
                    CqlQuantity ae_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity af_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity ag_ = context.Operators.Multiply(ae_, af_);
                    CqlDateTime ah_ = context.Operators.Add(ad_, ag_);
                    return ah_;
                };
            }

            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(j_, k_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? m_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
       ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
