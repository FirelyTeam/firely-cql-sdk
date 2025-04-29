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
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Dead", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead(CqlContext _) => _Dead;
    private static readonly CqlCode _Dead = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("ER", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ER(CqlContext _) => _ER;
    private static readonly CqlCode _ER = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlCodeDefinition("ICU", codeId: "ICU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode ICU(CqlContext _) => _ICU;
    private static readonly CqlCode _ICU = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("ambulatory", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode ambulatory(CqlContext _) => _ambulatory;
    private static readonly CqlCode _ambulatory = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("emergency", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode emergency(CqlContext _) => _emergency;
    private static readonly CqlCode _emergency = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("field", codeId: "FLD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode field(CqlContext _) => _field;
    private static readonly CqlCode _field = new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("home health", codeId: "HH", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode home_health(CqlContext _) => _home_health;
    private static readonly CqlCode _home_health = new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("inpatient encounter", codeId: "IMP", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_encounter(CqlContext _) => _inpatient_encounter;
    private static readonly CqlCode _inpatient_encounter = new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("inpatient acute", codeId: "ACUTE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_acute(CqlContext _) => _inpatient_acute;
    private static readonly CqlCode _inpatient_acute = new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("inpatient non-acute", codeId: "NONAC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode inpatient_non_acute(CqlContext _) => _inpatient_non_acute;
    private static readonly CqlCode _inpatient_non_acute = new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("observation encounter", codeId: "OBSENC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode observation_encounter(CqlContext _) => _observation_encounter;
    private static readonly CqlCode _observation_encounter = new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("pre-admission", codeId: "PRENC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode pre_admission(CqlContext _) => _pre_admission;
    private static readonly CqlCode _pre_admission = new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("short stay", codeId: "SS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode short_stay(CqlContext _) => _short_stay;
    private static readonly CqlCode _short_stay = new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("problem-list-item", codeId: "problem-list-item", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode problem_list_item(CqlContext _) => _problem_list_item;
    private static readonly CqlCode _problem_list_item = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);

    [CqlCodeDefinition("encounter-diagnosis", codeId: "encounter-diagnosis", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode encounter_diagnosis(CqlContext _) => _encounter_diagnosis;
    private static readonly CqlCode _encounter_diagnosis = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);

    [CqlCodeDefinition("health-concern", codeId: "health-concern", codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/condition-category")]
    public CqlCode health_concern(CqlContext _) => _health_concern;
    private static readonly CqlCode _health_concern = new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default);

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("recurrence", codeId: "recurrence", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext _) => _recurrence;
    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("relapse", codeId: "relapse", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext _) => _relapse;
    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext _) => _inactive;
    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("remission", codeId: "remission", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext _) => _remission;
    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext _) => _resolved;
    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("allergy-active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext _) => _allergy_active;
    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-inactive", codeId: "inactive", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext _) => _allergy_inactive;
    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-resolved", codeId: "resolved", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext _) => _allergy_resolved;
    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlCodeDefinition("allergy-unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext _) => _allergy_unconfirmed;
    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("allergy-confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext _) => _allergy_confirmed;
    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("allergy-refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext _) => _allergy_refuted;
    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlCodeDefinition("Inpatient", codeId: "inpatient", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Inpatient(CqlContext _) => _Inpatient;
    private static readonly CqlCode _Inpatient = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("Outpatient", codeId: "outpatient", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlCode _Outpatient = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("Community", codeId: "community", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext _) => _Community;
    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("Discharge", codeId: "discharge", codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext _) => _Discharge;
    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlCodeDefinition("AD", codeId: "AD", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode AD(CqlContext _) => _AD;
    private static readonly CqlCode _AD = new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("DD", codeId: "DD", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode DD(CqlContext _) => _DD;
    private static readonly CqlCode _DD = new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("CC", codeId: "CC", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CC(CqlContext _) => _CC;
    private static readonly CqlCode _CC = new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("pre-op", codeId: "pre-op", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode pre_op(CqlContext _) => _pre_op;
    private static readonly CqlCode _pre_op = new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("post-op", codeId: "post-op", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode post_op(CqlContext _) => _post_op;
    private static readonly CqlCode _post_op = new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode billing(CqlContext _) => _billing;
    private static readonly CqlCode _billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlCodeDefinition("social-history", codeId: "social-history", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode social_history(CqlContext _) => _social_history;
    private static readonly CqlCode _social_history = new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("vital-signs", codeId: "vital-signs", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode vital_signs(CqlContext _) => _vital_signs;
    private static readonly CqlCode _vital_signs = new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("imaging", codeId: "imaging", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode imaging(CqlContext _) => _imaging;
    private static readonly CqlCode _imaging = new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("procedure", codeId: "procedure", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode procedure(CqlContext _) => _procedure;
    private static readonly CqlCode _procedure = new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("exam", codeId: "exam", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode exam(CqlContext _) => _exam;
    private static readonly CqlCode _exam = new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("therapy", codeId: "therapy", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode therapy(CqlContext _) => _therapy;
    private static readonly CqlCode _therapy = new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlCodeDefinition("activity", codeId: "activity", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode activity(CqlContext _) => _activity;
    private static readonly CqlCode _activity = new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("RoleCode")]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("Diagnosis Role")]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role = new CqlCodeSystem();

    [CqlCodeSystemDefinition("RequestIntent")]
    public CqlCodeSystem RequestIntent(CqlContext _) => _RequestIntent;
    private static readonly CqlCodeSystem _RequestIntent = new CqlCodeSystem();

    [CqlCodeSystemDefinition("MedicationRequestCategory")]
    public CqlCodeSystem MedicationRequestCategory(CqlContext _) => _MedicationRequestCategory;
    private static readonly CqlCodeSystem _MedicationRequestCategory = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes")]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceClinicalStatusCodes(CqlContext _) => _AllergyIntoleranceClinicalStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCodeSystem AllergyIntoleranceVerificationStatusCodes(CqlContext _) => _AllergyIntoleranceVerificationStatusCodes;
    private static readonly CqlCodeSystem _AllergyIntoleranceVerificationStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("USCoreObservationCategoryExtensionCodes")]
    public CqlCodeSystem USCoreObservationCategoryExtensionCodes(CqlContext _) => _USCoreObservationCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreObservationCategoryExtensionCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionCategory")]
    public CqlCodeSystem ConditionCategory(CqlContext _) => _ConditionCategory;
    private static readonly CqlCodeSystem _ConditionCategory = new CqlCodeSystem();

    [CqlCodeSystemDefinition("USCoreConditionCategoryExtensionCodes")]
    public CqlCodeSystem USCoreConditionCategoryExtensionCodes(CqlContext _) => _USCoreConditionCategoryExtensionCodes;
    private static readonly CqlCodeSystem _USCoreConditionCategoryExtensionCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kze_ = context.Operators.SingletonFrom<Patient>(kzd_);

        return kze_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept kzf_ = condition?.ClinicalStatus;
        CqlConcept kzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzf_);
        CqlCode kzh_ = this.active(context);
        CqlConcept kzi_ = context.Operators.ConvertCodeToConcept(kzh_);
        bool? kzj_ = context.Operators.Equivalent(kzg_, kzi_);
        CqlConcept kzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzf_);
        CqlCode kzm_ = this.recurrence(context);
        CqlConcept kzn_ = context.Operators.ConvertCodeToConcept(kzm_);
        bool? kzo_ = context.Operators.Equivalent(kzl_, kzn_);
        bool? kzp_ = context.Operators.Or(kzj_, kzo_);
        CqlConcept kzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzf_);
        CqlCode kzs_ = this.relapse(context);
        CqlConcept kzt_ = context.Operators.ConvertCodeToConcept(kzs_);
        bool? kzu_ = context.Operators.Equivalent(kzr_, kzt_);
        bool? kzv_ = context.Operators.Or(kzp_, kzu_);

        return kzv_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> kzw_ = condition?.Category;
        CqlConcept kzx_(CodeableConcept @this)
        {
            CqlConcept lzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return lzc_;
        };
        IEnumerable<CqlConcept> kzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzw_, kzx_);
        bool? kzz_(CqlConcept C)
        {
            CqlConcept lzd_ = context.Operators.ConvertCodeToConcept(category);
            bool? lze_ = context.Operators.Equivalent(C, lzd_);

            return lze_;
        };
        IEnumerable<CqlConcept> lza_ = context.Operators.Where<CqlConcept>(kzy_, kzz_);
        bool? lzb_ = context.Operators.Exists<CqlConcept>(lza_);

        return lzb_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> lzf_ = observation?.Category;
        CqlConcept lzg_(CodeableConcept @this)
        {
            CqlConcept lzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return lzl_;
        };
        IEnumerable<CqlConcept> lzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzf_, lzg_);
        bool? lzi_(CqlConcept C)
        {
            CqlConcept lzm_ = context.Operators.ConvertCodeToConcept(category);
            bool? lzn_ = context.Operators.Equivalent(C, lzm_);

            return lzn_;
        };
        IEnumerable<CqlConcept> lzj_ = context.Operators.Where<CqlConcept>(lzh_, lzi_);
        bool? lzk_ = context.Operators.Exists<CqlConcept>(lzj_);

        return lzk_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> lzo_ = condition?.Category;
        CqlConcept lzp_(CodeableConcept @this)
        {
            CqlConcept lzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return lzu_;
        };
        IEnumerable<CqlConcept> lzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzo_, lzp_);
        bool? lzr_(CqlConcept C)
        {
            CqlCode lzv_ = this.problem_list_item(context);
            CqlConcept lzw_ = context.Operators.ConvertCodeToConcept(lzv_);
            bool? lzx_ = context.Operators.Equivalent(C, lzw_);

            return lzx_;
        };
        IEnumerable<CqlConcept> lzs_ = context.Operators.Where<CqlConcept>(lzq_, lzr_);
        bool? lzt_ = context.Operators.Exists<CqlConcept>(lzs_);

        return lzt_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> lzy_ = condition?.Category;
        CqlConcept lzz_(CodeableConcept @this)
        {
            CqlConcept mze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return mze_;
        };
        IEnumerable<CqlConcept> mza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzy_, lzz_);
        bool? mzb_(CqlConcept C)
        {
            CqlCode mzf_ = this.encounter_diagnosis(context);
            CqlConcept mzg_ = context.Operators.ConvertCodeToConcept(mzf_);
            bool? mzh_ = context.Operators.Equivalent(C, mzg_);

            return mzh_;
        };
        IEnumerable<CqlConcept> mzc_ = context.Operators.Where<CqlConcept>(mza_, mzb_);
        bool? mzd_ = context.Operators.Exists<CqlConcept>(mzc_);

        return mzd_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> mzi_ = condition?.Category;
        CqlConcept mzj_(CodeableConcept @this)
        {
            CqlConcept mzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return mzo_;
        };
        IEnumerable<CqlConcept> mzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzi_, mzj_);
        bool? mzl_(CqlConcept C)
        {
            CqlCode mzp_ = this.health_concern(context);
            CqlConcept mzq_ = context.Operators.ConvertCodeToConcept(mzp_);
            bool? mzr_ = context.Operators.Equivalent(C, mzq_);

            return mzr_;
        };
        IEnumerable<CqlConcept> mzm_ = context.Operators.Where<CqlConcept>(mzk_, mzl_);
        bool? mzn_ = context.Operators.Exists<CqlConcept>(mzm_);

        return mzn_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> mzs_ = observation?.Category;
        CqlConcept mzt_(CodeableConcept @this)
        {
            CqlConcept mzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return mzy_;
        };
        IEnumerable<CqlConcept> mzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzs_, mzt_);
        bool? mzv_(CqlConcept C)
        {
            CqlCode mzz_ = this.social_history(context);
            CqlConcept nza_ = context.Operators.ConvertCodeToConcept(mzz_);
            bool? nzb_ = context.Operators.Equivalent(C, nza_);

            return nzb_;
        };
        IEnumerable<CqlConcept> mzw_ = context.Operators.Where<CqlConcept>(mzu_, mzv_);
        bool? mzx_ = context.Operators.Exists<CqlConcept>(mzw_);

        return mzx_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> nzc_ = observation?.Category;
        CqlConcept nzd_(CodeableConcept @this)
        {
            CqlConcept nzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return nzi_;
        };
        IEnumerable<CqlConcept> nze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzc_, nzd_);
        bool? nzf_(CqlConcept C)
        {
            CqlCode nzj_ = this.vital_signs(context);
            CqlConcept nzk_ = context.Operators.ConvertCodeToConcept(nzj_);
            bool? nzl_ = context.Operators.Equivalent(C, nzk_);

            return nzl_;
        };
        IEnumerable<CqlConcept> nzg_ = context.Operators.Where<CqlConcept>(nze_, nzf_);
        bool? nzh_ = context.Operators.Exists<CqlConcept>(nzg_);

        return nzh_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> nzm_ = observation?.Category;
        CqlConcept nzn_(CodeableConcept @this)
        {
            CqlConcept nzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return nzs_;
        };
        IEnumerable<CqlConcept> nzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzm_, nzn_);
        bool? nzp_(CqlConcept C)
        {
            CqlCode nzt_ = this.imaging(context);
            CqlConcept nzu_ = context.Operators.ConvertCodeToConcept(nzt_);
            bool? nzv_ = context.Operators.Equivalent(C, nzu_);

            return nzv_;
        };
        IEnumerable<CqlConcept> nzq_ = context.Operators.Where<CqlConcept>(nzo_, nzp_);
        bool? nzr_ = context.Operators.Exists<CqlConcept>(nzq_);

        return nzr_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> nzw_ = observation?.Category;
        CqlConcept nzx_(CodeableConcept @this)
        {
            CqlConcept ozc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return ozc_;
        };
        IEnumerable<CqlConcept> nzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzw_, nzx_);
        bool? nzz_(CqlConcept C)
        {
            CqlCode ozd_ = this.laboratory(context);
            CqlConcept oze_ = context.Operators.ConvertCodeToConcept(ozd_);
            bool? ozf_ = context.Operators.Equivalent(C, oze_);

            return ozf_;
        };
        IEnumerable<CqlConcept> oza_ = context.Operators.Where<CqlConcept>(nzy_, nzz_);
        bool? ozb_ = context.Operators.Exists<CqlConcept>(oza_);

        return ozb_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> ozg_ = observation?.Category;
        CqlConcept ozh_(CodeableConcept @this)
        {
            CqlConcept ozm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return ozm_;
        };
        IEnumerable<CqlConcept> ozi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozg_, ozh_);
        bool? ozj_(CqlConcept C)
        {
            CqlCode ozn_ = this.procedure(context);
            CqlConcept ozo_ = context.Operators.ConvertCodeToConcept(ozn_);
            bool? ozp_ = context.Operators.Equivalent(C, ozo_);

            return ozp_;
        };
        IEnumerable<CqlConcept> ozk_ = context.Operators.Where<CqlConcept>(ozi_, ozj_);
        bool? ozl_ = context.Operators.Exists<CqlConcept>(ozk_);

        return ozl_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> ozq_ = observation?.Category;
        CqlConcept ozr_(CodeableConcept @this)
        {
            CqlConcept ozw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return ozw_;
        };
        IEnumerable<CqlConcept> ozs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozq_, ozr_);
        bool? ozt_(CqlConcept C)
        {
            CqlCode ozx_ = this.survey(context);
            CqlConcept ozy_ = context.Operators.ConvertCodeToConcept(ozx_);
            bool? ozz_ = context.Operators.Equivalent(C, ozy_);

            return ozz_;
        };
        IEnumerable<CqlConcept> ozu_ = context.Operators.Where<CqlConcept>(ozs_, ozt_);
        bool? ozv_ = context.Operators.Exists<CqlConcept>(ozu_);

        return ozv_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> pza_ = observation?.Category;
        CqlConcept pzb_(CodeableConcept @this)
        {
            CqlConcept pzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return pzg_;
        };
        IEnumerable<CqlConcept> pzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pza_, pzb_);
        bool? pzd_(CqlConcept C)
        {
            CqlCode pzh_ = this.exam(context);
            CqlConcept pzi_ = context.Operators.ConvertCodeToConcept(pzh_);
            bool? pzj_ = context.Operators.Equivalent(C, pzi_);

            return pzj_;
        };
        IEnumerable<CqlConcept> pze_ = context.Operators.Where<CqlConcept>(pzc_, pzd_);
        bool? pzf_ = context.Operators.Exists<CqlConcept>(pze_);

        return pzf_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> pzk_ = observation?.Category;
        CqlConcept pzl_(CodeableConcept @this)
        {
            CqlConcept pzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return pzq_;
        };
        IEnumerable<CqlConcept> pzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzk_, pzl_);
        bool? pzn_(CqlConcept C)
        {
            CqlCode pzr_ = this.therapy(context);
            CqlConcept pzs_ = context.Operators.ConvertCodeToConcept(pzr_);
            bool? pzt_ = context.Operators.Equivalent(C, pzs_);

            return pzt_;
        };
        IEnumerable<CqlConcept> pzo_ = context.Operators.Where<CqlConcept>(pzm_, pzn_);
        bool? pzp_ = context.Operators.Exists<CqlConcept>(pzo_);

        return pzp_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> pzu_ = observation?.Category;
        CqlConcept pzv_(CodeableConcept @this)
        {
            CqlConcept qza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return qza_;
        };
        IEnumerable<CqlConcept> pzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzu_, pzv_);
        bool? pzx_(CqlConcept C)
        {
            CqlCode qzb_ = this.activity(context);
            CqlConcept qzc_ = context.Operators.ConvertCodeToConcept(qzb_);
            bool? qzd_ = context.Operators.Equivalent(C, qzc_);

            return qzd_;
        };
        IEnumerable<CqlConcept> pzy_ = context.Operators.Where<CqlConcept>(pzw_, pzx_);
        bool? pzz_ = context.Operators.Exists<CqlConcept>(pzy_);

        return pzz_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> qze_ = medicationRequest?.Category;
        CqlConcept qzf_(CodeableConcept @this)
        {
            CqlConcept qzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return qzk_;
        };
        IEnumerable<CqlConcept> qzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qze_, qzf_);
        bool? qzh_(CqlConcept C)
        {
            CqlCode qzl_ = this.Community(context);
            CqlConcept qzm_ = context.Operators.ConvertCodeToConcept(qzl_);
            bool? qzn_ = context.Operators.Equivalent(C, qzm_);

            return qzn_;
        };
        IEnumerable<CqlConcept> qzi_ = context.Operators.Where<CqlConcept>(qzg_, qzh_);
        bool? qzj_ = context.Operators.Exists<CqlConcept>(qzi_);

        return qzj_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> qzo_ = medicationRequest?.Category;
        CqlConcept qzp_(CodeableConcept @this)
        {
            CqlConcept qzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return qzu_;
        };
        IEnumerable<CqlConcept> qzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzo_, qzp_);
        bool? qzr_(CqlConcept C)
        {
            CqlCode qzv_ = this.Discharge(context);
            CqlConcept qzw_ = context.Operators.ConvertCodeToConcept(qzv_);
            bool? qzx_ = context.Operators.Equivalent(C, qzw_);

            return qzx_;
        };
        IEnumerable<CqlConcept> qzs_ = context.Operators.Where<CqlConcept>(qzq_, qzr_);
        bool? qzt_ = context.Operators.Exists<CqlConcept>(qzs_);

        return qzt_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? qzy_(Extension E)
        {
            string rze_ = E?.Url;
            FhirString rzf_ = context.Operators.Convert<FhirString>(rze_);
            string rzg_ = rzf_?.Value;
            bool? rzh_ = context.Operators.Equal(rzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return rzh_;
        };
        IEnumerable<Extension> qzz_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), qzy_);
        bool? rza_(Extension E)
        {
            DataType rzi_ = E?.Value;
            object rzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzi_);

            return rzj_ as bool?;
        };
        IEnumerable<bool?> rzb_ = context.Operators.Select<Extension, bool?>(qzz_, rza_);
        IEnumerable<bool?> rzc_ = context.Operators.Distinct<bool?>(rzb_);
        bool? rzd_ = context.Operators.SingletonFrom<bool?>(rzc_);

        return rzd_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> rzk_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> rzl_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return rzl_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient rzm_ = this.Patient(context);
                Date rzn_ = rzm_?.BirthDateElement;
                string rzo_ = rzn_?.Value;
                CqlDate rzp_ = context.Operators.ConvertStringToDate(rzo_);
                CqlDate rzq_ = context.Operators.Add(rzp_, choice as CqlQuantity);
                Date rzs_ = rzm_?.BirthDateElement;
                string rzt_ = rzs_?.Value;
                CqlDate rzu_ = context.Operators.ConvertStringToDate(rzt_);
                CqlDate rzv_ = context.Operators.Add(rzu_, choice as CqlQuantity);
                CqlQuantity rzw_ = context.Operators.Quantity(1m, "year");
                CqlDate rzx_ = context.Operators.Add(rzv_, rzw_);
                CqlInterval<CqlDate> rzy_ = context.Operators.Interval(rzq_, rzx_, true, false);
                CqlDate rzz_ = rzy_?.low;
                CqlDateTime sza_ = context.Operators.ConvertDateToDateTime(rzz_);
                Date szc_ = rzm_?.BirthDateElement;
                string szd_ = szc_?.Value;
                CqlDate sze_ = context.Operators.ConvertStringToDate(szd_);
                CqlDate szf_ = context.Operators.Add(sze_, choice as CqlQuantity);
                Date szh_ = rzm_?.BirthDateElement;
                string szi_ = szh_?.Value;
                CqlDate szj_ = context.Operators.ConvertStringToDate(szi_);
                CqlDate szk_ = context.Operators.Add(szj_, choice as CqlQuantity);
                CqlDate szm_ = context.Operators.Add(szk_, rzw_);
                CqlInterval<CqlDate> szn_ = context.Operators.Interval(szf_, szm_, true, false);
                CqlDate szo_ = szn_?.high;
                CqlDateTime szp_ = context.Operators.ConvertDateToDateTime(szo_);
                Date szr_ = rzm_?.BirthDateElement;
                string szs_ = szr_?.Value;
                CqlDate szt_ = context.Operators.ConvertStringToDate(szs_);
                CqlDate szu_ = context.Operators.Add(szt_, choice as CqlQuantity);
                Date szw_ = rzm_?.BirthDateElement;
                string szx_ = szw_?.Value;
                CqlDate szy_ = context.Operators.ConvertStringToDate(szx_);
                CqlDate szz_ = context.Operators.Add(szy_, choice as CqlQuantity);
                CqlDate tzb_ = context.Operators.Add(szz_, rzw_);
                CqlInterval<CqlDate> tzc_ = context.Operators.Interval(szu_, tzb_, true, false);
                bool? tzd_ = tzc_?.lowClosed;
                Date tzf_ = rzm_?.BirthDateElement;
                string tzg_ = tzf_?.Value;
                CqlDate tzh_ = context.Operators.ConvertStringToDate(tzg_);
                CqlDate tzi_ = context.Operators.Add(tzh_, choice as CqlQuantity);
                Date tzk_ = rzm_?.BirthDateElement;
                string tzl_ = tzk_?.Value;
                CqlDate tzm_ = context.Operators.ConvertStringToDate(tzl_);
                CqlDate tzn_ = context.Operators.Add(tzm_, choice as CqlQuantity);
                CqlDate tzp_ = context.Operators.Add(tzn_, rzw_);
                CqlInterval<CqlDate> tzq_ = context.Operators.Interval(tzi_, tzp_, true, false);
                bool? tzr_ = tzq_?.highClosed;
                CqlInterval<CqlDateTime> tzs_ = context.Operators.Interval(sza_, szp_, tzd_, tzr_);

                return tzs_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient tzt_ = this.Patient(context);
                Date tzu_ = tzt_?.BirthDateElement;
                string tzv_ = tzu_?.Value;
                CqlDate tzw_ = context.Operators.ConvertStringToDate(tzv_);
                object tzx_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate tzy_ = context.Operators.Add(tzw_, tzx_ as CqlQuantity);
                Date uza_ = tzt_?.BirthDateElement;
                string uzb_ = uza_?.Value;
                CqlDate uzc_ = context.Operators.ConvertStringToDate(uzb_);
                object uzd_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate uze_ = context.Operators.Add(uzc_, uzd_ as CqlQuantity);
                CqlQuantity uzf_ = context.Operators.Quantity(1m, "year");
                CqlDate uzg_ = context.Operators.Add(uze_, uzf_);
                CqlInterval<CqlDate> uzh_ = context.Operators.Interval(tzy_, uzg_, true, false);
                CqlDate uzi_ = uzh_?.low;
                CqlDateTime uzj_ = context.Operators.ConvertDateToDateTime(uzi_);
                Date uzl_ = tzt_?.BirthDateElement;
                string uzm_ = uzl_?.Value;
                CqlDate uzn_ = context.Operators.ConvertStringToDate(uzm_);
                CqlDate uzp_ = context.Operators.Add(uzn_, tzx_ as CqlQuantity);
                Date uzr_ = tzt_?.BirthDateElement;
                string uzs_ = uzr_?.Value;
                CqlDate uzt_ = context.Operators.ConvertStringToDate(uzs_);
                CqlDate uzv_ = context.Operators.Add(uzt_, uzd_ as CqlQuantity);
                CqlDate uzx_ = context.Operators.Add(uzv_, uzf_);
                CqlInterval<CqlDate> uzy_ = context.Operators.Interval(uzp_, uzx_, true, false);
                CqlDate uzz_ = uzy_?.high;
                CqlDateTime vza_ = context.Operators.ConvertDateToDateTime(uzz_);
                Date vzc_ = tzt_?.BirthDateElement;
                string vzd_ = vzc_?.Value;
                CqlDate vze_ = context.Operators.ConvertStringToDate(vzd_);
                CqlDate vzg_ = context.Operators.Add(vze_, tzx_ as CqlQuantity);
                Date vzi_ = tzt_?.BirthDateElement;
                string vzj_ = vzi_?.Value;
                CqlDate vzk_ = context.Operators.ConvertStringToDate(vzj_);
                CqlDate vzm_ = context.Operators.Add(vzk_, uzd_ as CqlQuantity);
                CqlDate vzo_ = context.Operators.Add(vzm_, uzf_);
                CqlInterval<CqlDate> vzp_ = context.Operators.Interval(vzg_, vzo_, true, false);
                bool? vzq_ = vzp_?.lowClosed;
                Date vzs_ = tzt_?.BirthDateElement;
                string vzt_ = vzs_?.Value;
                CqlDate vzu_ = context.Operators.ConvertStringToDate(vzt_);
                CqlDate vzw_ = context.Operators.Add(vzu_, tzx_ as CqlQuantity);
                Date vzy_ = tzt_?.BirthDateElement;
                string vzz_ = vzy_?.Value;
                CqlDate wza_ = context.Operators.ConvertStringToDate(vzz_);
                CqlDate wzc_ = context.Operators.Add(wza_, uzd_ as CqlQuantity);
                CqlDate wze_ = context.Operators.Add(wzc_, uzf_);
                CqlInterval<CqlDate> wzf_ = context.Operators.Interval(vzw_, wze_, true, false);
                bool? wzg_ = wzf_?.highClosed;
                CqlInterval<CqlDateTime> wzh_ = context.Operators.Interval(uzj_, vza_, vzq_, wzg_);

                return wzh_;
            }
            else if (choice is Timing)
            {
                object wzi_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return wzi_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return rzk_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> wzj_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> wzk_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return wzk_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient wzl_ = this.Patient(context);
                Date wzm_ = wzl_?.BirthDateElement;
                string wzn_ = wzm_?.Value;
                CqlDate wzo_ = context.Operators.ConvertStringToDate(wzn_);
                CqlDate wzp_ = context.Operators.Add(wzo_, choice as CqlQuantity);
                Date wzr_ = wzl_?.BirthDateElement;
                string wzs_ = wzr_?.Value;
                CqlDate wzt_ = context.Operators.ConvertStringToDate(wzs_);
                CqlDate wzu_ = context.Operators.Add(wzt_, choice as CqlQuantity);
                CqlQuantity wzv_ = context.Operators.Quantity(1m, "year");
                CqlDate wzw_ = context.Operators.Add(wzu_, wzv_);
                CqlInterval<CqlDate> wzx_ = context.Operators.Interval(wzp_, wzw_, true, false);
                CqlDate wzy_ = wzx_?.low;
                CqlDateTime wzz_ = context.Operators.ConvertDateToDateTime(wzy_);
                Date xzb_ = wzl_?.BirthDateElement;
                string xzc_ = xzb_?.Value;
                CqlDate xzd_ = context.Operators.ConvertStringToDate(xzc_);
                CqlDate xze_ = context.Operators.Add(xzd_, choice as CqlQuantity);
                Date xzg_ = wzl_?.BirthDateElement;
                string xzh_ = xzg_?.Value;
                CqlDate xzi_ = context.Operators.ConvertStringToDate(xzh_);
                CqlDate xzj_ = context.Operators.Add(xzi_, choice as CqlQuantity);
                CqlDate xzl_ = context.Operators.Add(xzj_, wzv_);
                CqlInterval<CqlDate> xzm_ = context.Operators.Interval(xze_, xzl_, true, false);
                CqlDate xzn_ = xzm_?.high;
                CqlDateTime xzo_ = context.Operators.ConvertDateToDateTime(xzn_);
                Date xzq_ = wzl_?.BirthDateElement;
                string xzr_ = xzq_?.Value;
                CqlDate xzs_ = context.Operators.ConvertStringToDate(xzr_);
                CqlDate xzt_ = context.Operators.Add(xzs_, choice as CqlQuantity);
                Date xzv_ = wzl_?.BirthDateElement;
                string xzw_ = xzv_?.Value;
                CqlDate xzx_ = context.Operators.ConvertStringToDate(xzw_);
                CqlDate xzy_ = context.Operators.Add(xzx_, choice as CqlQuantity);
                CqlDate yza_ = context.Operators.Add(xzy_, wzv_);
                CqlInterval<CqlDate> yzb_ = context.Operators.Interval(xzt_, yza_, true, false);
                bool? yzc_ = yzb_?.lowClosed;
                Date yze_ = wzl_?.BirthDateElement;
                string yzf_ = yze_?.Value;
                CqlDate yzg_ = context.Operators.ConvertStringToDate(yzf_);
                CqlDate yzh_ = context.Operators.Add(yzg_, choice as CqlQuantity);
                Date yzj_ = wzl_?.BirthDateElement;
                string yzk_ = yzj_?.Value;
                CqlDate yzl_ = context.Operators.ConvertStringToDate(yzk_);
                CqlDate yzm_ = context.Operators.Add(yzl_, choice as CqlQuantity);
                CqlDate yzo_ = context.Operators.Add(yzm_, wzv_);
                CqlInterval<CqlDate> yzp_ = context.Operators.Interval(yzh_, yzo_, true, false);
                bool? yzq_ = yzp_?.highClosed;
                CqlInterval<CqlDateTime> yzr_ = context.Operators.Interval(wzz_, xzo_, yzc_, yzq_);

                return yzr_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient yzs_ = this.Patient(context);
                Date yzt_ = yzs_?.BirthDateElement;
                string yzu_ = yzt_?.Value;
                CqlDate yzv_ = context.Operators.ConvertStringToDate(yzu_);
                object yzw_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate yzx_ = context.Operators.Add(yzv_, yzw_ as CqlQuantity);
                Date yzz_ = yzs_?.BirthDateElement;
                string zza_ = yzz_?.Value;
                CqlDate zzb_ = context.Operators.ConvertStringToDate(zza_);
                object zzc_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate zzd_ = context.Operators.Add(zzb_, zzc_ as CqlQuantity);
                CqlQuantity zze_ = context.Operators.Quantity(1m, "year");
                CqlDate zzf_ = context.Operators.Add(zzd_, zze_);
                CqlInterval<CqlDate> zzg_ = context.Operators.Interval(yzx_, zzf_, true, false);
                CqlDate zzh_ = zzg_?.low;
                CqlDateTime zzi_ = context.Operators.ConvertDateToDateTime(zzh_);
                Date zzk_ = yzs_?.BirthDateElement;
                string zzl_ = zzk_?.Value;
                CqlDate zzm_ = context.Operators.ConvertStringToDate(zzl_);
                CqlDate zzo_ = context.Operators.Add(zzm_, yzw_ as CqlQuantity);
                Date zzq_ = yzs_?.BirthDateElement;
                string zzr_ = zzq_?.Value;
                CqlDate zzs_ = context.Operators.ConvertStringToDate(zzr_);
                CqlDate zzu_ = context.Operators.Add(zzs_, zzc_ as CqlQuantity);
                CqlDate zzw_ = context.Operators.Add(zzu_, zze_);
                CqlInterval<CqlDate> zzx_ = context.Operators.Interval(zzo_, zzw_, true, false);
                CqlDate zzy_ = zzx_?.high;
                CqlDateTime zzz_ = context.Operators.ConvertDateToDateTime(zzy_);
                Date azzb_ = yzs_?.BirthDateElement;
                string azzc_ = azzb_?.Value;
                CqlDate azzd_ = context.Operators.ConvertStringToDate(azzc_);
                CqlDate azzf_ = context.Operators.Add(azzd_, yzw_ as CqlQuantity);
                Date azzh_ = yzs_?.BirthDateElement;
                string azzi_ = azzh_?.Value;
                CqlDate azzj_ = context.Operators.ConvertStringToDate(azzi_);
                CqlDate azzl_ = context.Operators.Add(azzj_, zzc_ as CqlQuantity);
                CqlDate azzn_ = context.Operators.Add(azzl_, zze_);
                CqlInterval<CqlDate> azzo_ = context.Operators.Interval(azzf_, azzn_, true, false);
                bool? azzp_ = azzo_?.lowClosed;
                Date azzr_ = yzs_?.BirthDateElement;
                string azzs_ = azzr_?.Value;
                CqlDate azzt_ = context.Operators.ConvertStringToDate(azzs_);
                CqlDate azzv_ = context.Operators.Add(azzt_, yzw_ as CqlQuantity);
                Date azzx_ = yzs_?.BirthDateElement;
                string azzy_ = azzx_?.Value;
                CqlDate azzz_ = context.Operators.ConvertStringToDate(azzy_);
                CqlDate bzzb_ = context.Operators.Add(azzz_, zzc_ as CqlQuantity);
                CqlDate bzzd_ = context.Operators.Add(bzzb_, zze_);
                CqlInterval<CqlDate> bzze_ = context.Operators.Interval(azzv_, bzzd_, true, false);
                bool? bzzf_ = bzze_?.highClosed;
                CqlInterval<CqlDateTime> bzzg_ = context.Operators.Interval(zzi_, zzz_, azzp_, bzzf_);

                return bzzg_;
            }
            else if (choice is Timing)
            {
                object bzzh_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return bzzh_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return wzj_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> bzzi_()
        {
            bool bzzj_()
            {
                DataType bzzn_ = condition?.Abatement;
                object bzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzn_);
                bool bzzp_ = bzzo_ is CqlDateTime;

                return bzzp_;
            };
            bool bzzk_()
            {
                DataType bzzq_ = condition?.Abatement;
                object bzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzq_);
                bool bzzs_ = bzzr_ is CqlQuantity;

                return bzzs_;
            };
            bool bzzl_()
            {
                DataType bzzt_ = condition?.Abatement;
                object bzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzt_);
                bool bzzv_ = bzzu_ is CqlInterval<CqlQuantity>;

                return bzzv_;
            };
            bool bzzm_()
            {
                DataType bzzw_ = condition?.Abatement;
                object bzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzw_);
                bool bzzy_ = bzzx_ is CqlInterval<CqlDateTime>;

                return bzzy_;
            };
            if (bzzj_())
            {
                DataType bzzz_ = condition?.Abatement;
                object czza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzz_);
                object czzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzz_);
                CqlInterval<CqlDateTime> czzd_ = context.Operators.Interval(czza_ as CqlDateTime, czzc_ as CqlDateTime, true, true);

                return czzd_;
            }
            else if (bzzk_())
            {
                Patient czze_ = this.Patient(context);
                Date czzf_ = czze_?.BirthDateElement;
                string czzg_ = czzf_?.Value;
                CqlDate czzh_ = context.Operators.ConvertStringToDate(czzg_);
                DataType czzi_ = condition?.Abatement;
                object czzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate czzk_ = context.Operators.Add(czzh_, czzj_ as CqlQuantity);
                Date czzm_ = czze_?.BirthDateElement;
                string czzn_ = czzm_?.Value;
                CqlDate czzo_ = context.Operators.ConvertStringToDate(czzn_);
                object czzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate czzr_ = context.Operators.Add(czzo_, czzq_ as CqlQuantity);
                CqlQuantity czzs_ = context.Operators.Quantity(1m, "year");
                CqlDate czzt_ = context.Operators.Add(czzr_, czzs_);
                CqlInterval<CqlDate> czzu_ = context.Operators.Interval(czzk_, czzt_, true, false);
                CqlDate czzv_ = czzu_?.low;
                CqlDateTime czzw_ = context.Operators.ConvertDateToDateTime(czzv_);
                Date czzy_ = czze_?.BirthDateElement;
                string czzz_ = czzy_?.Value;
                CqlDate dzza_ = context.Operators.ConvertStringToDate(czzz_);
                object dzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate dzzd_ = context.Operators.Add(dzza_, dzzc_ as CqlQuantity);
                Date dzzf_ = czze_?.BirthDateElement;
                string dzzg_ = dzzf_?.Value;
                CqlDate dzzh_ = context.Operators.ConvertStringToDate(dzzg_);
                object dzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate dzzk_ = context.Operators.Add(dzzh_, dzzj_ as CqlQuantity);
                CqlDate dzzm_ = context.Operators.Add(dzzk_, czzs_);
                CqlInterval<CqlDate> dzzn_ = context.Operators.Interval(dzzd_, dzzm_, true, false);
                CqlDate dzzo_ = dzzn_?.high;
                CqlDateTime dzzp_ = context.Operators.ConvertDateToDateTime(dzzo_);
                Date dzzr_ = czze_?.BirthDateElement;
                string dzzs_ = dzzr_?.Value;
                CqlDate dzzt_ = context.Operators.ConvertStringToDate(dzzs_);
                object dzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate dzzw_ = context.Operators.Add(dzzt_, dzzv_ as CqlQuantity);
                Date dzzy_ = czze_?.BirthDateElement;
                string dzzz_ = dzzy_?.Value;
                CqlDate ezza_ = context.Operators.ConvertStringToDate(dzzz_);
                object ezzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate ezzd_ = context.Operators.Add(ezza_, ezzc_ as CqlQuantity);
                CqlDate ezzf_ = context.Operators.Add(ezzd_, czzs_);
                CqlInterval<CqlDate> ezzg_ = context.Operators.Interval(dzzw_, ezzf_, true, false);
                bool? ezzh_ = ezzg_?.lowClosed;
                Date ezzj_ = czze_?.BirthDateElement;
                string ezzk_ = ezzj_?.Value;
                CqlDate ezzl_ = context.Operators.ConvertStringToDate(ezzk_);
                object ezzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate ezzo_ = context.Operators.Add(ezzl_, ezzn_ as CqlQuantity);
                Date ezzq_ = czze_?.BirthDateElement;
                string ezzr_ = ezzq_?.Value;
                CqlDate ezzs_ = context.Operators.ConvertStringToDate(ezzr_);
                object ezzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzi_);
                CqlDate ezzv_ = context.Operators.Add(ezzs_, ezzu_ as CqlQuantity);
                CqlDate ezzx_ = context.Operators.Add(ezzv_, czzs_);
                CqlInterval<CqlDate> ezzy_ = context.Operators.Interval(ezzo_, ezzx_, true, false);
                bool? ezzz_ = ezzy_?.highClosed;
                CqlInterval<CqlDateTime> fzza_ = context.Operators.Interval(czzw_, dzzp_, ezzh_, ezzz_);

                return fzza_;
            }
            else if (bzzl_())
            {
                Patient fzzb_ = this.Patient(context);
                Date fzzc_ = fzzb_?.BirthDateElement;
                string fzzd_ = fzzc_?.Value;
                CqlDate fzze_ = context.Operators.ConvertStringToDate(fzzd_);
                DataType fzzf_ = condition?.Abatement;
                object fzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object fzzh_ = context.Operators.LateBoundProperty<object>(fzzg_, "low");
                CqlDate fzzi_ = context.Operators.Add(fzze_, fzzh_ as CqlQuantity);
                Date fzzk_ = fzzb_?.BirthDateElement;
                string fzzl_ = fzzk_?.Value;
                CqlDate fzzm_ = context.Operators.ConvertStringToDate(fzzl_);
                object fzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object fzzp_ = context.Operators.LateBoundProperty<object>(fzzo_, "high");
                CqlDate fzzq_ = context.Operators.Add(fzzm_, fzzp_ as CqlQuantity);
                CqlQuantity fzzr_ = context.Operators.Quantity(1m, "year");
                CqlDate fzzs_ = context.Operators.Add(fzzq_, fzzr_);
                CqlInterval<CqlDate> fzzt_ = context.Operators.Interval(fzzi_, fzzs_, true, false);
                CqlDate fzzu_ = fzzt_?.low;
                CqlDateTime fzzv_ = context.Operators.ConvertDateToDateTime(fzzu_);
                Date fzzx_ = fzzb_?.BirthDateElement;
                string fzzy_ = fzzx_?.Value;
                CqlDate fzzz_ = context.Operators.ConvertStringToDate(fzzy_);
                object gzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object gzzc_ = context.Operators.LateBoundProperty<object>(gzzb_, "low");
                CqlDate gzzd_ = context.Operators.Add(fzzz_, gzzc_ as CqlQuantity);
                Date gzzf_ = fzzb_?.BirthDateElement;
                string gzzg_ = gzzf_?.Value;
                CqlDate gzzh_ = context.Operators.ConvertStringToDate(gzzg_);
                object gzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object gzzk_ = context.Operators.LateBoundProperty<object>(gzzj_, "high");
                CqlDate gzzl_ = context.Operators.Add(gzzh_, gzzk_ as CqlQuantity);
                CqlDate gzzn_ = context.Operators.Add(gzzl_, fzzr_);
                CqlInterval<CqlDate> gzzo_ = context.Operators.Interval(gzzd_, gzzn_, true, false);
                CqlDate gzzp_ = gzzo_?.high;
                CqlDateTime gzzq_ = context.Operators.ConvertDateToDateTime(gzzp_);
                Date gzzs_ = fzzb_?.BirthDateElement;
                string gzzt_ = gzzs_?.Value;
                CqlDate gzzu_ = context.Operators.ConvertStringToDate(gzzt_);
                object gzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object gzzx_ = context.Operators.LateBoundProperty<object>(gzzw_, "low");
                CqlDate gzzy_ = context.Operators.Add(gzzu_, gzzx_ as CqlQuantity);
                Date hzza_ = fzzb_?.BirthDateElement;
                string hzzb_ = hzza_?.Value;
                CqlDate hzzc_ = context.Operators.ConvertStringToDate(hzzb_);
                object hzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object hzzf_ = context.Operators.LateBoundProperty<object>(hzze_, "high");
                CqlDate hzzg_ = context.Operators.Add(hzzc_, hzzf_ as CqlQuantity);
                CqlDate hzzi_ = context.Operators.Add(hzzg_, fzzr_);
                CqlInterval<CqlDate> hzzj_ = context.Operators.Interval(gzzy_, hzzi_, true, false);
                bool? hzzk_ = hzzj_?.lowClosed;
                Date hzzm_ = fzzb_?.BirthDateElement;
                string hzzn_ = hzzm_?.Value;
                CqlDate hzzo_ = context.Operators.ConvertStringToDate(hzzn_);
                object hzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object hzzr_ = context.Operators.LateBoundProperty<object>(hzzq_, "low");
                CqlDate hzzs_ = context.Operators.Add(hzzo_, hzzr_ as CqlQuantity);
                Date hzzu_ = fzzb_?.BirthDateElement;
                string hzzv_ = hzzu_?.Value;
                CqlDate hzzw_ = context.Operators.ConvertStringToDate(hzzv_);
                object hzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzf_);
                object hzzz_ = context.Operators.LateBoundProperty<object>(hzzy_, "high");
                CqlDate izza_ = context.Operators.Add(hzzw_, hzzz_ as CqlQuantity);
                CqlDate izzc_ = context.Operators.Add(izza_, fzzr_);
                CqlInterval<CqlDate> izzd_ = context.Operators.Interval(hzzs_, izzc_, true, false);
                bool? izze_ = izzd_?.highClosed;
                CqlInterval<CqlDateTime> izzf_ = context.Operators.Interval(fzzv_, gzzq_, hzzk_, izze_);

                return izzf_;
            }
            else if (bzzm_())
            {
                DataType izzg_ = condition?.Abatement;
                object izzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzg_);
                object izzi_ = context.Operators.LateBoundProperty<object>(izzh_, "low");
                object izzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzg_);
                object izzl_ = context.Operators.LateBoundProperty<object>(izzk_, "high");
                CqlInterval<CqlDateTime> izzm_ = context.Operators.Interval(izzi_ as CqlDateTime, izzl_ as CqlDateTime, true, false);

                return izzm_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return bzzi_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> izzn_()
        {
            bool izzo_()
            {
                DataType izzs_ = condition?.Abatement;
                object izzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzs_);
                bool izzu_ = izzt_ is CqlDateTime;

                return izzu_;
            };
            bool izzp_()
            {
                DataType izzv_ = condition?.Abatement;
                object izzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzv_);
                bool izzx_ = izzw_ is CqlQuantity;

                return izzx_;
            };
            bool izzq_()
            {
                DataType izzy_ = condition?.Abatement;
                object izzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzy_);
                bool jzza_ = izzz_ is CqlInterval<CqlQuantity>;

                return jzza_;
            };
            bool izzr_()
            {
                DataType jzzb_ = condition?.Abatement;
                object jzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzb_);
                bool jzzd_ = jzzc_ is CqlInterval<CqlDateTime>;

                return jzzd_;
            };
            if (izzo_())
            {
                DataType jzze_ = condition?.Abatement;
                object jzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzze_);
                object jzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzze_);
                CqlInterval<CqlDateTime> jzzi_ = context.Operators.Interval(jzzf_ as CqlDateTime, jzzh_ as CqlDateTime, true, true);

                return jzzi_;
            }
            else if (izzp_())
            {
                Patient jzzj_ = this.Patient(context);
                Date jzzk_ = jzzj_?.BirthDateElement;
                string jzzl_ = jzzk_?.Value;
                CqlDate jzzm_ = context.Operators.ConvertStringToDate(jzzl_);
                DataType jzzn_ = condition?.Abatement;
                object jzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate jzzp_ = context.Operators.Add(jzzm_, jzzo_ as CqlQuantity);
                Date jzzr_ = jzzj_?.BirthDateElement;
                string jzzs_ = jzzr_?.Value;
                CqlDate jzzt_ = context.Operators.ConvertStringToDate(jzzs_);
                object jzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate jzzw_ = context.Operators.Add(jzzt_, jzzv_ as CqlQuantity);
                CqlQuantity jzzx_ = context.Operators.Quantity(1m, "year");
                CqlDate jzzy_ = context.Operators.Add(jzzw_, jzzx_);
                CqlInterval<CqlDate> jzzz_ = context.Operators.Interval(jzzp_, jzzy_, true, false);
                CqlDate kzza_ = jzzz_?.low;
                CqlDateTime kzzb_ = context.Operators.ConvertDateToDateTime(kzza_);
                Date kzzd_ = jzzj_?.BirthDateElement;
                string kzze_ = kzzd_?.Value;
                CqlDate kzzf_ = context.Operators.ConvertStringToDate(kzze_);
                object kzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate kzzi_ = context.Operators.Add(kzzf_, kzzh_ as CqlQuantity);
                Date kzzk_ = jzzj_?.BirthDateElement;
                string kzzl_ = kzzk_?.Value;
                CqlDate kzzm_ = context.Operators.ConvertStringToDate(kzzl_);
                object kzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate kzzp_ = context.Operators.Add(kzzm_, kzzo_ as CqlQuantity);
                CqlDate kzzr_ = context.Operators.Add(kzzp_, jzzx_);
                CqlInterval<CqlDate> kzzs_ = context.Operators.Interval(kzzi_, kzzr_, true, false);
                CqlDate kzzt_ = kzzs_?.high;
                CqlDateTime kzzu_ = context.Operators.ConvertDateToDateTime(kzzt_);
                Date kzzw_ = jzzj_?.BirthDateElement;
                string kzzx_ = kzzw_?.Value;
                CqlDate kzzy_ = context.Operators.ConvertStringToDate(kzzx_);
                object lzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate lzzb_ = context.Operators.Add(kzzy_, lzza_ as CqlQuantity);
                Date lzzd_ = jzzj_?.BirthDateElement;
                string lzze_ = lzzd_?.Value;
                CqlDate lzzf_ = context.Operators.ConvertStringToDate(lzze_);
                object lzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate lzzi_ = context.Operators.Add(lzzf_, lzzh_ as CqlQuantity);
                CqlDate lzzk_ = context.Operators.Add(lzzi_, jzzx_);
                CqlInterval<CqlDate> lzzl_ = context.Operators.Interval(lzzb_, lzzk_, true, false);
                bool? lzzm_ = lzzl_?.lowClosed;
                Date lzzo_ = jzzj_?.BirthDateElement;
                string lzzp_ = lzzo_?.Value;
                CqlDate lzzq_ = context.Operators.ConvertStringToDate(lzzp_);
                object lzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate lzzt_ = context.Operators.Add(lzzq_, lzzs_ as CqlQuantity);
                Date lzzv_ = jzzj_?.BirthDateElement;
                string lzzw_ = lzzv_?.Value;
                CqlDate lzzx_ = context.Operators.ConvertStringToDate(lzzw_);
                object lzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzn_);
                CqlDate mzza_ = context.Operators.Add(lzzx_, lzzz_ as CqlQuantity);
                CqlDate mzzc_ = context.Operators.Add(mzza_, jzzx_);
                CqlInterval<CqlDate> mzzd_ = context.Operators.Interval(lzzt_, mzzc_, true, false);
                bool? mzze_ = mzzd_?.highClosed;
                CqlInterval<CqlDateTime> mzzf_ = context.Operators.Interval(kzzb_, kzzu_, lzzm_, mzze_);

                return mzzf_;
            }
            else if (izzq_())
            {
                Patient mzzg_ = this.Patient(context);
                Date mzzh_ = mzzg_?.BirthDateElement;
                string mzzi_ = mzzh_?.Value;
                CqlDate mzzj_ = context.Operators.ConvertStringToDate(mzzi_);
                DataType mzzk_ = condition?.Abatement;
                object mzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object mzzm_ = context.Operators.LateBoundProperty<object>(mzzl_, "low");
                CqlDate mzzn_ = context.Operators.Add(mzzj_, mzzm_ as CqlQuantity);
                Date mzzp_ = mzzg_?.BirthDateElement;
                string mzzq_ = mzzp_?.Value;
                CqlDate mzzr_ = context.Operators.ConvertStringToDate(mzzq_);
                object mzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object mzzu_ = context.Operators.LateBoundProperty<object>(mzzt_, "high");
                CqlDate mzzv_ = context.Operators.Add(mzzr_, mzzu_ as CqlQuantity);
                CqlQuantity mzzw_ = context.Operators.Quantity(1m, "year");
                CqlDate mzzx_ = context.Operators.Add(mzzv_, mzzw_);
                CqlInterval<CqlDate> mzzy_ = context.Operators.Interval(mzzn_, mzzx_, true, false);
                CqlDate mzzz_ = mzzy_?.low;
                CqlDateTime nzza_ = context.Operators.ConvertDateToDateTime(mzzz_);
                Date nzzc_ = mzzg_?.BirthDateElement;
                string nzzd_ = nzzc_?.Value;
                CqlDate nzze_ = context.Operators.ConvertStringToDate(nzzd_);
                object nzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object nzzh_ = context.Operators.LateBoundProperty<object>(nzzg_, "low");
                CqlDate nzzi_ = context.Operators.Add(nzze_, nzzh_ as CqlQuantity);
                Date nzzk_ = mzzg_?.BirthDateElement;
                string nzzl_ = nzzk_?.Value;
                CqlDate nzzm_ = context.Operators.ConvertStringToDate(nzzl_);
                object nzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object nzzp_ = context.Operators.LateBoundProperty<object>(nzzo_, "high");
                CqlDate nzzq_ = context.Operators.Add(nzzm_, nzzp_ as CqlQuantity);
                CqlDate nzzs_ = context.Operators.Add(nzzq_, mzzw_);
                CqlInterval<CqlDate> nzzt_ = context.Operators.Interval(nzzi_, nzzs_, true, false);
                CqlDate nzzu_ = nzzt_?.high;
                CqlDateTime nzzv_ = context.Operators.ConvertDateToDateTime(nzzu_);
                Date nzzx_ = mzzg_?.BirthDateElement;
                string nzzy_ = nzzx_?.Value;
                CqlDate nzzz_ = context.Operators.ConvertStringToDate(nzzy_);
                object ozzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object ozzc_ = context.Operators.LateBoundProperty<object>(ozzb_, "low");
                CqlDate ozzd_ = context.Operators.Add(nzzz_, ozzc_ as CqlQuantity);
                Date ozzf_ = mzzg_?.BirthDateElement;
                string ozzg_ = ozzf_?.Value;
                CqlDate ozzh_ = context.Operators.ConvertStringToDate(ozzg_);
                object ozzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object ozzk_ = context.Operators.LateBoundProperty<object>(ozzj_, "high");
                CqlDate ozzl_ = context.Operators.Add(ozzh_, ozzk_ as CqlQuantity);
                CqlDate ozzn_ = context.Operators.Add(ozzl_, mzzw_);
                CqlInterval<CqlDate> ozzo_ = context.Operators.Interval(ozzd_, ozzn_, true, false);
                bool? ozzp_ = ozzo_?.lowClosed;
                Date ozzr_ = mzzg_?.BirthDateElement;
                string ozzs_ = ozzr_?.Value;
                CqlDate ozzt_ = context.Operators.ConvertStringToDate(ozzs_);
                object ozzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object ozzw_ = context.Operators.LateBoundProperty<object>(ozzv_, "low");
                CqlDate ozzx_ = context.Operators.Add(ozzt_, ozzw_ as CqlQuantity);
                Date ozzz_ = mzzg_?.BirthDateElement;
                string pzza_ = ozzz_?.Value;
                CqlDate pzzb_ = context.Operators.ConvertStringToDate(pzza_);
                object pzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzk_);
                object pzze_ = context.Operators.LateBoundProperty<object>(pzzd_, "high");
                CqlDate pzzf_ = context.Operators.Add(pzzb_, pzze_ as CqlQuantity);
                CqlDate pzzh_ = context.Operators.Add(pzzf_, mzzw_);
                CqlInterval<CqlDate> pzzi_ = context.Operators.Interval(ozzx_, pzzh_, true, false);
                bool? pzzj_ = pzzi_?.highClosed;
                CqlInterval<CqlDateTime> pzzk_ = context.Operators.Interval(nzza_, nzzv_, ozzp_, pzzj_);

                return pzzk_;
            }
            else if (izzr_())
            {
                DataType pzzl_ = condition?.Abatement;
                object pzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzl_);
                object pzzn_ = context.Operators.LateBoundProperty<object>(pzzm_, "low");
                object pzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzl_);
                object pzzq_ = context.Operators.LateBoundProperty<object>(pzzp_, "high");
                CqlInterval<CqlDateTime> pzzr_ = context.Operators.Interval(pzzn_ as CqlDateTime, pzzq_ as CqlDateTime, true, false);

                return pzzr_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return izzn_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> pzzs_()
        {
            bool pzzt_()
            {
                CodeableConcept pzzu_ = condition?.ClinicalStatus;
                CqlConcept pzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzu_);
                CqlCode pzzw_ = this.active(context);
                CqlConcept pzzx_ = context.Operators.ConvertCodeToConcept(pzzw_);
                bool? pzzy_ = context.Operators.Equivalent(pzzv_, pzzx_);
                CqlConcept qzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzu_);
                CqlCode qzzb_ = this.recurrence(context);
                CqlConcept qzzc_ = context.Operators.ConvertCodeToConcept(qzzb_);
                bool? qzzd_ = context.Operators.Equivalent(qzza_, qzzc_);
                bool? qzze_ = context.Operators.Or(pzzy_, qzzd_);
                CqlConcept qzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzu_);
                CqlCode qzzh_ = this.relapse(context);
                CqlConcept qzzi_ = context.Operators.ConvertCodeToConcept(qzzh_);
                bool? qzzj_ = context.Operators.Equivalent(qzzg_, qzzi_);
                bool? qzzk_ = context.Operators.Or(qzze_, qzzj_);

                return qzzk_ ?? false;
            };
            if (pzzt_())
            {
                DataType qzzl_ = condition?.Onset;
                object qzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzl_);
                CqlInterval<CqlDateTime> qzzn_ = this.ToInterval(context, qzzm_);
                CqlDateTime qzzo_ = context.Operators.Start(qzzn_);
                CqlInterval<CqlDateTime> qzzp_ = this.ToAbatementInterval(context, condition);
                CqlDateTime qzzq_ = context.Operators.End(qzzp_);
                CqlInterval<CqlDateTime> qzzr_ = context.Operators.Interval(qzzo_, qzzq_, true, true);

                return qzzr_;
            }
            else
            {
                CqlInterval<CqlDateTime> qzzs_ = this.ToAbatementInterval(context, condition);
                CqlDateTime qzzt_ = context.Operators.End(qzzs_);
                CqlDateTime[] qzzu_ = [
                    qzzt_,
                ];
                CqlInterval<CqlDateTime> qzzv_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> qzzz_()
                    {
                        if (abatementDate is null)
                        {
                            DataType rzza_ = condition?.Onset;
                            object rzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzza_);
                            CqlInterval<CqlDateTime> rzzc_ = this.ToInterval(context, rzzb_);
                            CqlDateTime rzzd_ = context.Operators.Start(rzzc_);
                            CqlInterval<CqlDateTime> rzze_ = context.Operators.Interval(rzzd_, abatementDate, true, false);

                            return rzze_;
                        }
                        else
                        {
                            DataType rzzf_ = condition?.Onset;
                            object rzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzf_);
                            CqlInterval<CqlDateTime> rzzh_ = this.ToInterval(context, rzzg_);
                            CqlDateTime rzzi_ = context.Operators.Start(rzzh_);
                            CqlInterval<CqlDateTime> rzzj_ = context.Operators.Interval(rzzi_, abatementDate, true, true);

                            return rzzj_;
                        }
                    };

                    return qzzz_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> qzzw_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)qzzu_, qzzv_);
                IEnumerable<CqlInterval<CqlDateTime>> qzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzw_);
                CqlInterval<CqlDateTime> qzzy_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(qzzx_);

                return qzzy_;
            }
        };

        return pzzs_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> rzzk_()
        {
            bool rzzl_()
            {
                CodeableConcept rzzm_ = condition?.ClinicalStatus;
                CqlConcept rzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzm_);
                CqlCode rzzo_ = this.active(context);
                CqlConcept rzzp_ = context.Operators.ConvertCodeToConcept(rzzo_);
                bool? rzzq_ = context.Operators.Equivalent(rzzn_, rzzp_);
                CqlConcept rzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzm_);
                CqlCode rzzt_ = this.recurrence(context);
                CqlConcept rzzu_ = context.Operators.ConvertCodeToConcept(rzzt_);
                bool? rzzv_ = context.Operators.Equivalent(rzzs_, rzzu_);
                bool? rzzw_ = context.Operators.Or(rzzq_, rzzv_);
                CqlConcept rzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzm_);
                CqlCode rzzz_ = this.relapse(context);
                CqlConcept szza_ = context.Operators.ConvertCodeToConcept(rzzz_);
                bool? szzb_ = context.Operators.Equivalent(rzzy_, szza_);
                bool? szzc_ = context.Operators.Or(rzzw_, szzb_);

                return szzc_ ?? false;
            };
            if (rzzl_())
            {
                DataType szzd_ = condition?.Onset;
                object szze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzd_);
                CqlInterval<CqlDateTime> szzf_ = this.toInterval(context, szze_);
                CqlDateTime szzg_ = context.Operators.Start(szzf_);
                CqlInterval<CqlDateTime> szzh_ = this.abatementInterval(context, condition);
                CqlDateTime szzi_ = context.Operators.End(szzh_);
                CqlInterval<CqlDateTime> szzj_ = context.Operators.Interval(szzg_, szzi_, true, true);

                return szzj_;
            }
            else
            {
                CqlInterval<CqlDateTime> szzk_ = this.abatementInterval(context, condition);
                CqlDateTime szzl_ = context.Operators.End(szzk_);
                CqlDateTime[] szzm_ = [
                    szzl_,
                ];
                CqlInterval<CqlDateTime> szzn_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> szzr_()
                    {
                        if (abatementDate is null)
                        {
                            DataType szzs_ = condition?.Onset;
                            object szzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzs_);
                            CqlInterval<CqlDateTime> szzu_ = this.toInterval(context, szzt_);
                            CqlDateTime szzv_ = context.Operators.Start(szzu_);
                            CqlInterval<CqlDateTime> szzw_ = context.Operators.Interval(szzv_, abatementDate, true, false);

                            return szzw_;
                        }
                        else
                        {
                            DataType szzx_ = condition?.Onset;
                            object szzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzx_);
                            CqlInterval<CqlDateTime> szzz_ = this.toInterval(context, szzy_);
                            CqlDateTime tzza_ = context.Operators.Start(szzz_);
                            CqlInterval<CqlDateTime> tzzb_ = context.Operators.Interval(tzza_, abatementDate, true, true);

                            return tzzb_;
                        }
                    };

                    return szzr_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> szzo_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)szzm_, szzn_);
                IEnumerable<CqlInterval<CqlDateTime>> szzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzo_);
                CqlInterval<CqlDateTime> szzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(szzp_);

                return szzq_;
            }
        };

        return rzzk_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> tzzc_ = context.Operators.Split(uri, "/");
        string tzzd_ = context.Operators.Last<string>(tzzc_);

        return tzzd_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> tzze_ = context.Operators.Split(uri, "/");
        string tzzf_ = context.Operators.Last<string>(tzze_);

        return tzzf_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime tzzg_ = context.Operators.Start(period);
        CqlDateTime tzzi_ = context.Operators.MinValue<CqlDateTime>();
        bool? tzzj_ = context.Operators.Equal(tzzg_, tzzi_);
        bool? tzzk_ = context.Operators.Or((bool?)(tzzg_ is null), tzzj_);
        bool? tzzl_ = context.Operators.Not(tzzk_);

        return tzzl_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime tzzm_ = context.Operators.Start(period);
        CqlDateTime tzzo_ = context.Operators.MinValue<CqlDateTime>();
        bool? tzzp_ = context.Operators.Equal(tzzm_, tzzo_);
        bool? tzzq_ = context.Operators.Or((bool?)(tzzm_ is null), tzzp_);
        bool? tzzr_ = context.Operators.Not(tzzq_);

        return tzzr_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime tzzs_ = context.Operators.End(period);
        CqlDateTime tzzu_ = context.Operators.MaxValue<CqlDateTime>();
        bool? tzzv_ = context.Operators.Equal(tzzs_, tzzu_);
        bool? tzzw_ = context.Operators.Or((bool?)(tzzs_ is null), tzzv_);
        bool? tzzx_ = context.Operators.Not(tzzw_);

        return tzzx_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime tzzy_ = context.Operators.End(period);
        CqlDateTime uzza_ = context.Operators.MaxValue<CqlDateTime>();
        bool? uzzb_ = context.Operators.Equal(tzzy_, uzza_);
        bool? uzzc_ = context.Operators.Or((bool?)(tzzy_ is null), uzzb_);
        bool? uzzd_ = context.Operators.Not(uzzc_);

        return uzzd_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzze_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] uzzf_ = [
            uzze_,
        ];
        CqlDateTime uzzg_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime uzzk_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime uzzl_ = context.Operators.End(period);

                    return uzzl_;
                }
                else
                {
                    CqlDateTime uzzm_ = context.Operators.Start(period);

                    return uzzm_;
                }
            };

            return uzzk_();
        };
        IEnumerable<CqlDateTime> uzzh_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)uzzf_, uzzg_);
        IEnumerable<CqlDateTime> uzzi_ = context.Operators.Distinct<CqlDateTime>(uzzh_);
        CqlDateTime uzzj_ = context.Operators.SingletonFrom<CqlDateTime>(uzzi_);

        return uzzj_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzzn_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] uzzo_ = [
            uzzn_,
        ];
        CqlDateTime uzzp_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime uzzt_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime uzzu_ = context.Operators.End(period);

                    return uzzu_;
                }
                else
                {
                    CqlDateTime uzzv_ = context.Operators.Start(period);

                    return uzzv_;
                }
            };

            return uzzt_();
        };
        IEnumerable<CqlDateTime> uzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)uzzo_, uzzp_);
        IEnumerable<CqlDateTime> uzzr_ = context.Operators.Distinct<CqlDateTime>(uzzq_);
        CqlDateTime uzzs_ = context.Operators.SingletonFrom<CqlDateTime>(uzzr_);

        return uzzs_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzzw_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] uzzx_ = [
            uzzw_,
        ];
        CqlDateTime uzzy_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime vzzc_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime vzzd_ = context.Operators.Start(period);

                    return vzzd_;
                }
                else
                {
                    CqlDateTime vzze_ = context.Operators.End(period);

                    return vzze_;
                }
            };

            return vzzc_();
        };
        IEnumerable<CqlDateTime> uzzz_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)uzzx_, uzzy_);
        IEnumerable<CqlDateTime> vzza_ = context.Operators.Distinct<CqlDateTime>(uzzz_);
        CqlDateTime vzzb_ = context.Operators.SingletonFrom<CqlDateTime>(vzza_);

        return vzzb_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> vzzf_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] vzzg_ = [
            vzzf_,
        ];
        CqlDateTime vzzh_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime vzzl_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime vzzm_ = context.Operators.Start(period);

                    return vzzm_;
                }
                else
                {
                    CqlDateTime vzzn_ = context.Operators.End(period);

                    return vzzn_;
                }
            };

            return vzzl_();
        };
        IEnumerable<CqlDateTime> vzzi_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)vzzg_, vzzh_);
        IEnumerable<CqlDateTime> vzzj_ = context.Operators.Distinct<CqlDateTime>(vzzi_);
        CqlDateTime vzzk_ = context.Operators.SingletonFrom<CqlDateTime>(vzzj_);

        return vzzk_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime vzzo_ = context.Operators.Start(Period);
        CqlDateTime vzzp_ = context.Operators.End(Period);
        int? vzzq_ = context.Operators.DurationBetween(vzzo_, vzzp_, "day");
        CqlInterval<int?> vzzr_ = context.Operators.Interval(1, vzzq_, true, true);
        CqlInterval<int?>[] vzzs_ = [
            vzzr_,
        ];
        IEnumerable<CqlInterval<int?>> vzzt_ = context.Operators.Expand(vzzs_ as IEnumerable<CqlInterval<int?>>, default);
        int? vzzu_(CqlInterval<int?> DayNumber)
        {
            int? vzzx_ = context.Operators.End(DayNumber);

            return vzzx_;
        };
        IEnumerable<int?> vzzv_ = context.Operators.Select<CqlInterval<int?>, int?>(vzzt_, vzzu_);
        IEnumerable<int?> vzzw_ = context.Operators.Distinct<int?>(vzzv_);

        return vzzw_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime vzzy_ = context.Operators.Start(Period);
        CqlDateTime vzzz_ = context.Operators.End(Period);
        int? wzza_ = context.Operators.DurationBetween(vzzy_, vzzz_, "day");
        CqlInterval<int?> wzzb_ = context.Operators.Interval(1, wzza_, true, true);
        CqlInterval<int?>[] wzzc_ = [
            wzzb_,
        ];
        IEnumerable<CqlInterval<int?>> wzzd_ = context.Operators.Expand(wzzc_ as IEnumerable<CqlInterval<int?>>, default);
        int? wzze_(CqlInterval<int?> DayNumber)
        {
            int? wzzh_ = context.Operators.End(DayNumber);

            return wzzh_;
        };
        IEnumerable<int?> wzzf_ = context.Operators.Select<CqlInterval<int?>, int?>(wzzd_, wzze_);
        IEnumerable<int?> wzzg_ = context.Operators.Distinct<int?>(wzzf_);

        return wzzg_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> wzzi_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? wzzj_(int? DayIndex)
        {
            CqlDateTime wzzm_ = context.Operators.Start(Period);
            CqlQuantity wzzn_ = context.Operators.Quantity(24m, "hours");
            int? wzzo_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity wzzp_ = context.Operators.ConvertIntegerToQuantity(wzzo_);
            CqlQuantity wzzq_ = context.Operators.Multiply(wzzn_, wzzp_);
            CqlDateTime wzzr_ = context.Operators.Add(wzzm_, wzzq_);
            CqlDateTime wzzs_()
            {
                bool wzzv_()
                {
                    CqlDateTime wzzw_ = context.Operators.Start(Period);
                    CqlQuantity wzzx_ = context.Operators.Quantity(24m, "hours");
                    int? wzzy_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity wzzz_ = context.Operators.ConvertIntegerToQuantity(wzzy_);
                    CqlQuantity xzza_ = context.Operators.Multiply(wzzx_, wzzz_);
                    CqlDateTime xzzb_ = context.Operators.Add(wzzw_, xzza_);
                    CqlDateTime xzzc_ = context.Operators.End(Period);
                    int? xzzd_ = context.Operators.DurationBetween(xzzb_, xzzc_, "hour");
                    bool? xzze_ = context.Operators.Less(xzzd_, 24);

                    return xzze_ ?? false;
                };
                if (wzzv_())
                {
                    CqlDateTime xzzf_ = context.Operators.Start(Period);
                    CqlQuantity xzzg_ = context.Operators.Quantity(24m, "hours");
                    int? xzzh_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity xzzi_ = context.Operators.ConvertIntegerToQuantity(xzzh_);
                    CqlQuantity xzzj_ = context.Operators.Multiply(xzzg_, xzzi_);
                    CqlDateTime xzzk_ = context.Operators.Add(xzzf_, xzzj_);

                    return xzzk_;
                }
                else
                {
                    CqlDateTime xzzl_ = context.Operators.Start(Period);
                    CqlQuantity xzzm_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity xzzn_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity xzzo_ = context.Operators.Multiply(xzzm_, xzzn_);
                    CqlDateTime xzzp_ = context.Operators.Add(xzzl_, xzzo_);

                    return xzzp_;
                }
            };
            CqlInterval<CqlDateTime> wzzt_ = context.Operators.Interval(wzzr_, wzzs_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? wzzu_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, wzzt_);

            return wzzu_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> wzzk_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(wzzi_, wzzj_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> wzzl_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(wzzk_);

        return wzzl_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> xzzq_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? xzzr_(int? DayIndex)
        {
            CqlDateTime xzzu_ = context.Operators.Start(Period);
            CqlQuantity xzzv_ = context.Operators.Quantity(24m, "hours");
            int? xzzw_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity xzzx_ = context.Operators.ConvertIntegerToQuantity(xzzw_);
            CqlQuantity xzzy_ = context.Operators.Multiply(xzzv_, xzzx_);
            CqlDateTime xzzz_ = context.Operators.Add(xzzu_, xzzy_);
            CqlDateTime yzza_()
            {
                bool yzzd_()
                {
                    CqlDateTime yzze_ = context.Operators.Start(Period);
                    CqlQuantity yzzf_ = context.Operators.Quantity(24m, "hours");
                    int? yzzg_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity yzzh_ = context.Operators.ConvertIntegerToQuantity(yzzg_);
                    CqlQuantity yzzi_ = context.Operators.Multiply(yzzf_, yzzh_);
                    CqlDateTime yzzj_ = context.Operators.Add(yzze_, yzzi_);
                    CqlDateTime yzzk_ = context.Operators.End(Period);
                    int? yzzl_ = context.Operators.DurationBetween(yzzj_, yzzk_, "hour");
                    bool? yzzm_ = context.Operators.Less(yzzl_, 24);

                    return yzzm_ ?? false;
                };
                if (yzzd_())
                {
                    CqlDateTime yzzn_ = context.Operators.Start(Period);
                    CqlQuantity yzzo_ = context.Operators.Quantity(24m, "hours");
                    int? yzzp_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity yzzq_ = context.Operators.ConvertIntegerToQuantity(yzzp_);
                    CqlQuantity yzzr_ = context.Operators.Multiply(yzzo_, yzzq_);
                    CqlDateTime yzzs_ = context.Operators.Add(yzzn_, yzzr_);

                    return yzzs_;
                }
                else
                {
                    CqlDateTime yzzt_ = context.Operators.Start(Period);
                    CqlQuantity yzzu_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity yzzv_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity yzzw_ = context.Operators.Multiply(yzzu_, yzzv_);
                    CqlDateTime yzzx_ = context.Operators.Add(yzzt_, yzzw_);

                    return yzzx_;
                }
            };
            CqlInterval<CqlDateTime> yzzb_ = context.Operators.Interval(xzzz_, yzza_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? yzzc_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, yzzb_);

            return yzzc_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> xzzs_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(xzzq_, xzzr_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> xzzt_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(xzzs_);

        return xzzt_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
