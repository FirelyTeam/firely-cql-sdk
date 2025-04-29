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

    [CqlCodeDefinition("clinical-test", codeId: "clinical-test", codeSystem: "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category")]
    public CqlCode clinical_test(CqlContext _) => _clinical_test;
    private static readonly CqlCode _clinical_test = new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default);

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
        IEnumerable<Patient> wu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wv_ = context.Operators.SingletonFrom<Patient>(wu_);

        return wv_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept ww_ = condition?.ClinicalStatus;
        CqlConcept wx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ww_);
        CqlCode wy_ = this.active(context);
        CqlConcept wz_ = context.Operators.ConvertCodeToConcept(wy_);
        bool? xa_ = context.Operators.Equivalent(wx_, wz_);
        CqlConcept xc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ww_);
        CqlCode xd_ = this.recurrence(context);
        CqlConcept xe_ = context.Operators.ConvertCodeToConcept(xd_);
        bool? xf_ = context.Operators.Equivalent(xc_, xe_);
        bool? xg_ = context.Operators.Or(xa_, xf_);
        CqlConcept xi_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ww_);
        CqlCode xj_ = this.relapse(context);
        CqlConcept xk_ = context.Operators.ConvertCodeToConcept(xj_);
        bool? xl_ = context.Operators.Equivalent(xi_, xk_);
        bool? xm_ = context.Operators.Or(xg_, xl_);

        return xm_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> xn_ = condition?.Category;
        CqlConcept xo_(CodeableConcept @this)
        {
            CqlConcept xt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return xt_;
        };
        IEnumerable<CqlConcept> xp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xn_, xo_);
        bool? xq_(CqlConcept C)
        {
            CqlConcept xu_ = context.Operators.ConvertCodeToConcept(category);
            bool? xv_ = context.Operators.Equivalent(C, xu_);

            return xv_;
        };
        IEnumerable<CqlConcept> xr_ = context.Operators.Where<CqlConcept>(xp_, xq_);
        bool? xs_ = context.Operators.Exists<CqlConcept>(xr_);

        return xs_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> xw_ = observation?.Category;
        CqlConcept xx_(CodeableConcept @this)
        {
            CqlConcept yc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yc_;
        };
        IEnumerable<CqlConcept> xy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xw_, xx_);
        bool? xz_(CqlConcept C)
        {
            CqlConcept yd_ = context.Operators.ConvertCodeToConcept(category);
            bool? ye_ = context.Operators.Equivalent(C, yd_);

            return ye_;
        };
        IEnumerable<CqlConcept> ya_ = context.Operators.Where<CqlConcept>(xy_, xz_);
        bool? yb_ = context.Operators.Exists<CqlConcept>(ya_);

        return yb_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yf_ = condition?.Category;
        CqlConcept yg_(CodeableConcept @this)
        {
            CqlConcept yl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yl_;
        };
        IEnumerable<CqlConcept> yh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yf_, yg_);
        bool? yi_(CqlConcept C)
        {
            CqlCode ym_ = this.problem_list_item(context);
            CqlConcept yn_ = context.Operators.ConvertCodeToConcept(ym_);
            bool? yo_ = context.Operators.Equivalent(C, yn_);

            return yo_;
        };
        IEnumerable<CqlConcept> yj_ = context.Operators.Where<CqlConcept>(yh_, yi_);
        bool? yk_ = context.Operators.Exists<CqlConcept>(yj_);

        return yk_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yp_ = condition?.Category;
        CqlConcept yq_(CodeableConcept @this)
        {
            CqlConcept yv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return yv_;
        };
        IEnumerable<CqlConcept> yr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yp_, yq_);
        bool? ys_(CqlConcept C)
        {
            CqlCode yw_ = this.encounter_diagnosis(context);
            CqlConcept yx_ = context.Operators.ConvertCodeToConcept(yw_);
            bool? yy_ = context.Operators.Equivalent(C, yx_);

            return yy_;
        };
        IEnumerable<CqlConcept> yt_ = context.Operators.Where<CqlConcept>(yr_, ys_);
        bool? yu_ = context.Operators.Exists<CqlConcept>(yt_);

        return yu_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> yz_ = condition?.Category;
        CqlConcept za_(CodeableConcept @this)
        {
            CqlConcept zf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zf_;
        };
        IEnumerable<CqlConcept> zb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yz_, za_);
        bool? zc_(CqlConcept C)
        {
            CqlCode zg_ = this.health_concern(context);
            CqlConcept zh_ = context.Operators.ConvertCodeToConcept(zg_);
            bool? zi_ = context.Operators.Equivalent(C, zh_);

            return zi_;
        };
        IEnumerable<CqlConcept> zd_ = context.Operators.Where<CqlConcept>(zb_, zc_);
        bool? ze_ = context.Operators.Exists<CqlConcept>(zd_);

        return ze_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zj_ = observation?.Category;
        CqlConcept zk_(CodeableConcept @this)
        {
            CqlConcept zp_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zp_;
        };
        IEnumerable<CqlConcept> zl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zj_, zk_);
        bool? zm_(CqlConcept C)
        {
            CqlCode zq_ = this.social_history(context);
            CqlConcept zr_ = context.Operators.ConvertCodeToConcept(zq_);
            bool? zs_ = context.Operators.Equivalent(C, zr_);

            return zs_;
        };
        IEnumerable<CqlConcept> zn_ = context.Operators.Where<CqlConcept>(zl_, zm_);
        bool? zo_ = context.Operators.Exists<CqlConcept>(zn_);

        return zo_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> zt_ = observation?.Category;
        CqlConcept zu_(CodeableConcept @this)
        {
            CqlConcept zz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return zz_;
        };
        IEnumerable<CqlConcept> zv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zt_, zu_);
        bool? zw_(CqlConcept C)
        {
            CqlCode aza_ = this.vital_signs(context);
            CqlConcept azb_ = context.Operators.ConvertCodeToConcept(aza_);
            bool? azc_ = context.Operators.Equivalent(C, azb_);

            return azc_;
        };
        IEnumerable<CqlConcept> zx_ = context.Operators.Where<CqlConcept>(zv_, zw_);
        bool? zy_ = context.Operators.Exists<CqlConcept>(zx_);

        return zy_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azd_ = observation?.Category;
        CqlConcept aze_(CodeableConcept @this)
        {
            CqlConcept azj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azj_;
        };
        IEnumerable<CqlConcept> azf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azd_, aze_);
        bool? azg_(CqlConcept C)
        {
            CqlCode azk_ = this.imaging(context);
            CqlConcept azl_ = context.Operators.ConvertCodeToConcept(azk_);
            bool? azm_ = context.Operators.Equivalent(C, azl_);

            return azm_;
        };
        IEnumerable<CqlConcept> azh_ = context.Operators.Where<CqlConcept>(azf_, azg_);
        bool? azi_ = context.Operators.Exists<CqlConcept>(azh_);

        return azi_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azn_ = observation?.Category;
        CqlConcept azo_(CodeableConcept @this)
        {
            CqlConcept azt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return azt_;
        };
        IEnumerable<CqlConcept> azp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azn_, azo_);
        bool? azq_(CqlConcept C)
        {
            CqlCode azu_ = this.laboratory(context);
            CqlConcept azv_ = context.Operators.ConvertCodeToConcept(azu_);
            bool? azw_ = context.Operators.Equivalent(C, azv_);

            return azw_;
        };
        IEnumerable<CqlConcept> azr_ = context.Operators.Where<CqlConcept>(azp_, azq_);
        bool? azs_ = context.Operators.Exists<CqlConcept>(azr_);

        return azs_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> azx_ = observation?.Category;
        CqlConcept azy_(CodeableConcept @this)
        {
            CqlConcept bzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzd_;
        };
        IEnumerable<CqlConcept> azz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azx_, azy_);
        bool? bza_(CqlConcept C)
        {
            CqlCode bze_ = this.procedure(context);
            CqlConcept bzf_ = context.Operators.ConvertCodeToConcept(bze_);
            bool? bzg_ = context.Operators.Equivalent(C, bzf_);

            return bzg_;
        };
        IEnumerable<CqlConcept> bzb_ = context.Operators.Where<CqlConcept>(azz_, bza_);
        bool? bzc_ = context.Operators.Exists<CqlConcept>(bzb_);

        return bzc_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzh_ = observation?.Category;
        CqlConcept bzi_(CodeableConcept @this)
        {
            CqlConcept bzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzn_;
        };
        IEnumerable<CqlConcept> bzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzh_, bzi_);
        bool? bzk_(CqlConcept C)
        {
            CqlCode bzo_ = this.survey(context);
            CqlConcept bzp_ = context.Operators.ConvertCodeToConcept(bzo_);
            bool? bzq_ = context.Operators.Equivalent(C, bzp_);

            return bzq_;
        };
        IEnumerable<CqlConcept> bzl_ = context.Operators.Where<CqlConcept>(bzj_, bzk_);
        bool? bzm_ = context.Operators.Exists<CqlConcept>(bzl_);

        return bzm_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> bzr_ = observation?.Category;
        CqlConcept bzs_(CodeableConcept @this)
        {
            CqlConcept bzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return bzx_;
        };
        IEnumerable<CqlConcept> bzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzr_, bzs_);
        bool? bzu_(CqlConcept C)
        {
            CqlCode bzy_ = this.exam(context);
            CqlConcept bzz_ = context.Operators.ConvertCodeToConcept(bzy_);
            bool? cza_ = context.Operators.Equivalent(C, bzz_);

            return cza_;
        };
        IEnumerable<CqlConcept> bzv_ = context.Operators.Where<CqlConcept>(bzt_, bzu_);
        bool? bzw_ = context.Operators.Exists<CqlConcept>(bzv_);

        return bzw_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czb_ = observation?.Category;
        CqlConcept czc_(CodeableConcept @this)
        {
            CqlConcept czh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czh_;
        };
        IEnumerable<CqlConcept> czd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czb_, czc_);
        bool? cze_(CqlConcept C)
        {
            CqlCode czi_ = this.therapy(context);
            CqlConcept czj_ = context.Operators.ConvertCodeToConcept(czi_);
            bool? czk_ = context.Operators.Equivalent(C, czj_);

            return czk_;
        };
        IEnumerable<CqlConcept> czf_ = context.Operators.Where<CqlConcept>(czd_, cze_);
        bool? czg_ = context.Operators.Exists<CqlConcept>(czf_);

        return czg_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czl_ = observation?.Category;
        CqlConcept czm_(CodeableConcept @this)
        {
            CqlConcept czr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return czr_;
        };
        IEnumerable<CqlConcept> czn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czl_, czm_);
        bool? czo_(CqlConcept C)
        {
            CqlCode czs_ = this.activity(context);
            CqlConcept czt_ = context.Operators.ConvertCodeToConcept(czs_);
            bool? czu_ = context.Operators.Equivalent(C, czt_);

            return czu_;
        };
        IEnumerable<CqlConcept> czp_ = context.Operators.Where<CqlConcept>(czn_, czo_);
        bool? czq_ = context.Operators.Exists<CqlConcept>(czp_);

        return czq_;
    }


    [CqlExpressionDefinition("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> czv_ = observation?.Category;
        CqlConcept czw_(CodeableConcept @this)
        {
            CqlConcept dzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzb_;
        };
        IEnumerable<CqlConcept> czx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czv_, czw_);
        bool? czy_(CqlConcept C)
        {
            CqlCode dzc_ = this.clinical_test(context);
            CqlConcept dzd_ = context.Operators.ConvertCodeToConcept(dzc_);
            bool? dze_ = context.Operators.Equivalent(C, dzd_);

            return dze_;
        };
        IEnumerable<CqlConcept> czz_ = context.Operators.Where<CqlConcept>(czx_, czy_);
        bool? dza_ = context.Operators.Exists<CqlConcept>(czz_);

        return dza_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzf_ = medicationRequest?.Category;
        CqlConcept dzg_(CodeableConcept @this)
        {
            CqlConcept dzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzl_;
        };
        IEnumerable<CqlConcept> dzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzf_, dzg_);
        bool? dzi_(CqlConcept C)
        {
            CqlCode dzm_ = this.Community(context);
            CqlConcept dzn_ = context.Operators.ConvertCodeToConcept(dzm_);
            bool? dzo_ = context.Operators.Equivalent(C, dzn_);

            return dzo_;
        };
        IEnumerable<CqlConcept> dzj_ = context.Operators.Where<CqlConcept>(dzh_, dzi_);
        bool? dzk_ = context.Operators.Exists<CqlConcept>(dzj_);

        return dzk_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzp_ = medicationRequest?.Category;
        CqlConcept dzq_(CodeableConcept @this)
        {
            CqlConcept dzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return dzv_;
        };
        IEnumerable<CqlConcept> dzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzp_, dzq_);
        bool? dzs_(CqlConcept C)
        {
            CqlCode dzw_ = this.Discharge(context);
            CqlConcept dzx_ = context.Operators.ConvertCodeToConcept(dzw_);
            bool? dzy_ = context.Operators.Equivalent(C, dzx_);

            return dzy_;
        };
        IEnumerable<CqlConcept> dzt_ = context.Operators.Where<CqlConcept>(dzr_, dzs_);
        bool? dzu_ = context.Operators.Exists<CqlConcept>(dzt_);

        return dzu_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? dzz_(Extension E)
        {
            string ezf_ = E?.Url;
            FhirString ezg_ = context.Operators.Convert<FhirString>(ezf_);
            string ezh_ = ezg_?.Value;
            bool? ezi_ = context.Operators.Equal(ezh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return ezi_;
        };
        IEnumerable<Extension> eza_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), dzz_);
        bool? ezb_(Extension E)
        {
            DataType ezj_ = E?.Value;
            object ezk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezj_);

            return ezk_ as bool?;
        };
        IEnumerable<bool?> ezc_ = context.Operators.Select<Extension, bool?>(eza_, ezb_);
        IEnumerable<bool?> ezd_ = context.Operators.Distinct<bool?>(ezc_);
        bool? eze_ = context.Operators.SingletonFrom<bool?>(ezd_);

        return eze_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezl_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ezm_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ezm_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezn_ = this.Patient(context);
                Date ezo_ = ezn_?.BirthDateElement;
                string ezp_ = ezo_?.Value;
                CqlDate ezq_ = context.Operators.ConvertStringToDate(ezp_);
                CqlDate ezr_ = context.Operators.Add(ezq_, choice as CqlQuantity);
                Date ezt_ = ezn_?.BirthDateElement;
                string ezu_ = ezt_?.Value;
                CqlDate ezv_ = context.Operators.ConvertStringToDate(ezu_);
                CqlDate ezw_ = context.Operators.Add(ezv_, choice as CqlQuantity);
                CqlQuantity ezx_ = context.Operators.Quantity(1m, "year");
                CqlDate ezy_ = context.Operators.Add(ezw_, ezx_);
                CqlInterval<CqlDate> ezz_ = context.Operators.Interval(ezr_, ezy_, true, false);
                CqlDate fza_ = ezz_?.low;
                CqlDateTime fzb_ = context.Operators.ConvertDateToDateTime(fza_);
                Date fzd_ = ezn_?.BirthDateElement;
                string fze_ = fzd_?.Value;
                CqlDate fzf_ = context.Operators.ConvertStringToDate(fze_);
                CqlDate fzg_ = context.Operators.Add(fzf_, choice as CqlQuantity);
                Date fzi_ = ezn_?.BirthDateElement;
                string fzj_ = fzi_?.Value;
                CqlDate fzk_ = context.Operators.ConvertStringToDate(fzj_);
                CqlDate fzl_ = context.Operators.Add(fzk_, choice as CqlQuantity);
                CqlDate fzn_ = context.Operators.Add(fzl_, ezx_);
                CqlInterval<CqlDate> fzo_ = context.Operators.Interval(fzg_, fzn_, true, false);
                CqlDate fzp_ = fzo_?.high;
                CqlDateTime fzq_ = context.Operators.ConvertDateToDateTime(fzp_);
                Date fzs_ = ezn_?.BirthDateElement;
                string fzt_ = fzs_?.Value;
                CqlDate fzu_ = context.Operators.ConvertStringToDate(fzt_);
                CqlDate fzv_ = context.Operators.Add(fzu_, choice as CqlQuantity);
                Date fzx_ = ezn_?.BirthDateElement;
                string fzy_ = fzx_?.Value;
                CqlDate fzz_ = context.Operators.ConvertStringToDate(fzy_);
                CqlDate gza_ = context.Operators.Add(fzz_, choice as CqlQuantity);
                CqlDate gzc_ = context.Operators.Add(gza_, ezx_);
                CqlInterval<CqlDate> gzd_ = context.Operators.Interval(fzv_, gzc_, true, false);
                bool? gze_ = gzd_?.lowClosed;
                Date gzg_ = ezn_?.BirthDateElement;
                string gzh_ = gzg_?.Value;
                CqlDate gzi_ = context.Operators.ConvertStringToDate(gzh_);
                CqlDate gzj_ = context.Operators.Add(gzi_, choice as CqlQuantity);
                Date gzl_ = ezn_?.BirthDateElement;
                string gzm_ = gzl_?.Value;
                CqlDate gzn_ = context.Operators.ConvertStringToDate(gzm_);
                CqlDate gzo_ = context.Operators.Add(gzn_, choice as CqlQuantity);
                CqlDate gzq_ = context.Operators.Add(gzo_, ezx_);
                CqlInterval<CqlDate> gzr_ = context.Operators.Interval(gzj_, gzq_, true, false);
                bool? gzs_ = gzr_?.highClosed;
                CqlInterval<CqlDateTime> gzt_ = context.Operators.Interval(fzb_, fzq_, gze_, gzs_);

                return gzt_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzu_ = this.Patient(context);
                Date gzv_ = gzu_?.BirthDateElement;
                string gzw_ = gzv_?.Value;
                CqlDate gzx_ = context.Operators.ConvertStringToDate(gzw_);
                object gzy_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate gzz_ = context.Operators.Add(gzx_, gzy_ as CqlQuantity);
                Date hzb_ = gzu_?.BirthDateElement;
                string hzc_ = hzb_?.Value;
                CqlDate hzd_ = context.Operators.ConvertStringToDate(hzc_);
                object hze_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate hzf_ = context.Operators.Add(hzd_, hze_ as CqlQuantity);
                CqlQuantity hzg_ = context.Operators.Quantity(1m, "year");
                CqlDate hzh_ = context.Operators.Add(hzf_, hzg_);
                CqlInterval<CqlDate> hzi_ = context.Operators.Interval(gzz_, hzh_, true, false);
                CqlDate hzj_ = hzi_?.low;
                CqlDateTime hzk_ = context.Operators.ConvertDateToDateTime(hzj_);
                Date hzm_ = gzu_?.BirthDateElement;
                string hzn_ = hzm_?.Value;
                CqlDate hzo_ = context.Operators.ConvertStringToDate(hzn_);
                CqlDate hzq_ = context.Operators.Add(hzo_, gzy_ as CqlQuantity);
                Date hzs_ = gzu_?.BirthDateElement;
                string hzt_ = hzs_?.Value;
                CqlDate hzu_ = context.Operators.ConvertStringToDate(hzt_);
                CqlDate hzw_ = context.Operators.Add(hzu_, hze_ as CqlQuantity);
                CqlDate hzy_ = context.Operators.Add(hzw_, hzg_);
                CqlInterval<CqlDate> hzz_ = context.Operators.Interval(hzq_, hzy_, true, false);
                CqlDate iza_ = hzz_?.high;
                CqlDateTime izb_ = context.Operators.ConvertDateToDateTime(iza_);
                Date izd_ = gzu_?.BirthDateElement;
                string ize_ = izd_?.Value;
                CqlDate izf_ = context.Operators.ConvertStringToDate(ize_);
                CqlDate izh_ = context.Operators.Add(izf_, gzy_ as CqlQuantity);
                Date izj_ = gzu_?.BirthDateElement;
                string izk_ = izj_?.Value;
                CqlDate izl_ = context.Operators.ConvertStringToDate(izk_);
                CqlDate izn_ = context.Operators.Add(izl_, hze_ as CqlQuantity);
                CqlDate izp_ = context.Operators.Add(izn_, hzg_);
                CqlInterval<CqlDate> izq_ = context.Operators.Interval(izh_, izp_, true, false);
                bool? izr_ = izq_?.lowClosed;
                Date izt_ = gzu_?.BirthDateElement;
                string izu_ = izt_?.Value;
                CqlDate izv_ = context.Operators.ConvertStringToDate(izu_);
                CqlDate izx_ = context.Operators.Add(izv_, gzy_ as CqlQuantity);
                Date izz_ = gzu_?.BirthDateElement;
                string jza_ = izz_?.Value;
                CqlDate jzb_ = context.Operators.ConvertStringToDate(jza_);
                CqlDate jzd_ = context.Operators.Add(jzb_, hze_ as CqlQuantity);
                CqlDate jzf_ = context.Operators.Add(jzd_, hzg_);
                CqlInterval<CqlDate> jzg_ = context.Operators.Interval(izx_, jzf_, true, false);
                bool? jzh_ = jzg_?.highClosed;
                CqlInterval<CqlDateTime> jzi_ = context.Operators.Interval(hzk_, izb_, izr_, jzh_);

                return jzi_;
            }
            else if (choice is Timing)
            {
                object jzj_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return jzj_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ezl_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzk_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jzl_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jzl_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzm_ = this.Patient(context);
                Date jzn_ = jzm_?.BirthDateElement;
                string jzo_ = jzn_?.Value;
                CqlDate jzp_ = context.Operators.ConvertStringToDate(jzo_);
                CqlDate jzq_ = context.Operators.Add(jzp_, choice as CqlQuantity);
                Date jzs_ = jzm_?.BirthDateElement;
                string jzt_ = jzs_?.Value;
                CqlDate jzu_ = context.Operators.ConvertStringToDate(jzt_);
                CqlDate jzv_ = context.Operators.Add(jzu_, choice as CqlQuantity);
                CqlQuantity jzw_ = context.Operators.Quantity(1m, "year");
                CqlDate jzx_ = context.Operators.Add(jzv_, jzw_);
                CqlInterval<CqlDate> jzy_ = context.Operators.Interval(jzq_, jzx_, true, false);
                CqlDate jzz_ = jzy_?.low;
                CqlDateTime kza_ = context.Operators.ConvertDateToDateTime(jzz_);
                Date kzc_ = jzm_?.BirthDateElement;
                string kzd_ = kzc_?.Value;
                CqlDate kze_ = context.Operators.ConvertStringToDate(kzd_);
                CqlDate kzf_ = context.Operators.Add(kze_, choice as CqlQuantity);
                Date kzh_ = jzm_?.BirthDateElement;
                string kzi_ = kzh_?.Value;
                CqlDate kzj_ = context.Operators.ConvertStringToDate(kzi_);
                CqlDate kzk_ = context.Operators.Add(kzj_, choice as CqlQuantity);
                CqlDate kzm_ = context.Operators.Add(kzk_, jzw_);
                CqlInterval<CqlDate> kzn_ = context.Operators.Interval(kzf_, kzm_, true, false);
                CqlDate kzo_ = kzn_?.high;
                CqlDateTime kzp_ = context.Operators.ConvertDateToDateTime(kzo_);
                Date kzr_ = jzm_?.BirthDateElement;
                string kzs_ = kzr_?.Value;
                CqlDate kzt_ = context.Operators.ConvertStringToDate(kzs_);
                CqlDate kzu_ = context.Operators.Add(kzt_, choice as CqlQuantity);
                Date kzw_ = jzm_?.BirthDateElement;
                string kzx_ = kzw_?.Value;
                CqlDate kzy_ = context.Operators.ConvertStringToDate(kzx_);
                CqlDate kzz_ = context.Operators.Add(kzy_, choice as CqlQuantity);
                CqlDate lzb_ = context.Operators.Add(kzz_, jzw_);
                CqlInterval<CqlDate> lzc_ = context.Operators.Interval(kzu_, lzb_, true, false);
                bool? lzd_ = lzc_?.lowClosed;
                Date lzf_ = jzm_?.BirthDateElement;
                string lzg_ = lzf_?.Value;
                CqlDate lzh_ = context.Operators.ConvertStringToDate(lzg_);
                CqlDate lzi_ = context.Operators.Add(lzh_, choice as CqlQuantity);
                Date lzk_ = jzm_?.BirthDateElement;
                string lzl_ = lzk_?.Value;
                CqlDate lzm_ = context.Operators.ConvertStringToDate(lzl_);
                CqlDate lzn_ = context.Operators.Add(lzm_, choice as CqlQuantity);
                CqlDate lzp_ = context.Operators.Add(lzn_, jzw_);
                CqlInterval<CqlDate> lzq_ = context.Operators.Interval(lzi_, lzp_, true, false);
                bool? lzr_ = lzq_?.highClosed;
                CqlInterval<CqlDateTime> lzs_ = context.Operators.Interval(kza_, kzp_, lzd_, lzr_);

                return lzs_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzt_ = this.Patient(context);
                Date lzu_ = lzt_?.BirthDateElement;
                string lzv_ = lzu_?.Value;
                CqlDate lzw_ = context.Operators.ConvertStringToDate(lzv_);
                object lzx_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzy_ = context.Operators.Add(lzw_, lzx_ as CqlQuantity);
                Date mza_ = lzt_?.BirthDateElement;
                string mzb_ = mza_?.Value;
                CqlDate mzc_ = context.Operators.ConvertStringToDate(mzb_);
                object mzd_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate mze_ = context.Operators.Add(mzc_, mzd_ as CqlQuantity);
                CqlQuantity mzf_ = context.Operators.Quantity(1m, "year");
                CqlDate mzg_ = context.Operators.Add(mze_, mzf_);
                CqlInterval<CqlDate> mzh_ = context.Operators.Interval(lzy_, mzg_, true, false);
                CqlDate mzi_ = mzh_?.low;
                CqlDateTime mzj_ = context.Operators.ConvertDateToDateTime(mzi_);
                Date mzl_ = lzt_?.BirthDateElement;
                string mzm_ = mzl_?.Value;
                CqlDate mzn_ = context.Operators.ConvertStringToDate(mzm_);
                CqlDate mzp_ = context.Operators.Add(mzn_, lzx_ as CqlQuantity);
                Date mzr_ = lzt_?.BirthDateElement;
                string mzs_ = mzr_?.Value;
                CqlDate mzt_ = context.Operators.ConvertStringToDate(mzs_);
                CqlDate mzv_ = context.Operators.Add(mzt_, mzd_ as CqlQuantity);
                CqlDate mzx_ = context.Operators.Add(mzv_, mzf_);
                CqlInterval<CqlDate> mzy_ = context.Operators.Interval(mzp_, mzx_, true, false);
                CqlDate mzz_ = mzy_?.high;
                CqlDateTime nza_ = context.Operators.ConvertDateToDateTime(mzz_);
                Date nzc_ = lzt_?.BirthDateElement;
                string nzd_ = nzc_?.Value;
                CqlDate nze_ = context.Operators.ConvertStringToDate(nzd_);
                CqlDate nzg_ = context.Operators.Add(nze_, lzx_ as CqlQuantity);
                Date nzi_ = lzt_?.BirthDateElement;
                string nzj_ = nzi_?.Value;
                CqlDate nzk_ = context.Operators.ConvertStringToDate(nzj_);
                CqlDate nzm_ = context.Operators.Add(nzk_, mzd_ as CqlQuantity);
                CqlDate nzo_ = context.Operators.Add(nzm_, mzf_);
                CqlInterval<CqlDate> nzp_ = context.Operators.Interval(nzg_, nzo_, true, false);
                bool? nzq_ = nzp_?.lowClosed;
                Date nzs_ = lzt_?.BirthDateElement;
                string nzt_ = nzs_?.Value;
                CqlDate nzu_ = context.Operators.ConvertStringToDate(nzt_);
                CqlDate nzw_ = context.Operators.Add(nzu_, lzx_ as CqlQuantity);
                Date nzy_ = lzt_?.BirthDateElement;
                string nzz_ = nzy_?.Value;
                CqlDate oza_ = context.Operators.ConvertStringToDate(nzz_);
                CqlDate ozc_ = context.Operators.Add(oza_, mzd_ as CqlQuantity);
                CqlDate oze_ = context.Operators.Add(ozc_, mzf_);
                CqlInterval<CqlDate> ozf_ = context.Operators.Interval(nzw_, oze_, true, false);
                bool? ozg_ = ozf_?.highClosed;
                CqlInterval<CqlDateTime> ozh_ = context.Operators.Interval(mzj_, nza_, nzq_, ozg_);

                return ozh_;
            }
            else if (choice is Timing)
            {
                object ozi_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return ozi_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzk_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ozj_()
        {
            bool ozk_()
            {
                DataType ozo_ = condition?.Abatement;
                object ozp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozo_);
                bool ozq_ = ozp_ is CqlDateTime;

                return ozq_;
            };
            bool ozl_()
            {
                DataType ozr_ = condition?.Abatement;
                object ozs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozr_);
                bool ozt_ = ozs_ is CqlQuantity;

                return ozt_;
            };
            bool ozm_()
            {
                DataType ozu_ = condition?.Abatement;
                object ozv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozu_);
                bool ozw_ = ozv_ is CqlInterval<CqlQuantity>;

                return ozw_;
            };
            bool ozn_()
            {
                DataType ozx_ = condition?.Abatement;
                object ozy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozx_);
                bool ozz_ = ozy_ is CqlInterval<CqlDateTime>;

                return ozz_;
            };
            if (ozk_())
            {
                DataType pza_ = condition?.Abatement;
                object pzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pza_);
                object pzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pza_);
                CqlInterval<CqlDateTime> pze_ = context.Operators.Interval(pzb_ as CqlDateTime, pzd_ as CqlDateTime, true, true);

                return pze_;
            }
            else if (ozl_())
            {
                Patient pzf_ = this.Patient(context);
                Date pzg_ = pzf_?.BirthDateElement;
                string pzh_ = pzg_?.Value;
                CqlDate pzi_ = context.Operators.ConvertStringToDate(pzh_);
                DataType pzj_ = condition?.Abatement;
                object pzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate pzl_ = context.Operators.Add(pzi_, pzk_ as CqlQuantity);
                Date pzn_ = pzf_?.BirthDateElement;
                string pzo_ = pzn_?.Value;
                CqlDate pzp_ = context.Operators.ConvertStringToDate(pzo_);
                object pzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate pzs_ = context.Operators.Add(pzp_, pzr_ as CqlQuantity);
                CqlQuantity pzt_ = context.Operators.Quantity(1m, "year");
                CqlDate pzu_ = context.Operators.Add(pzs_, pzt_);
                CqlInterval<CqlDate> pzv_ = context.Operators.Interval(pzl_, pzu_, true, false);
                CqlDate pzw_ = pzv_?.low;
                CqlDateTime pzx_ = context.Operators.ConvertDateToDateTime(pzw_);
                Date pzz_ = pzf_?.BirthDateElement;
                string qza_ = pzz_?.Value;
                CqlDate qzb_ = context.Operators.ConvertStringToDate(qza_);
                object qzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate qze_ = context.Operators.Add(qzb_, qzd_ as CqlQuantity);
                Date qzg_ = pzf_?.BirthDateElement;
                string qzh_ = qzg_?.Value;
                CqlDate qzi_ = context.Operators.ConvertStringToDate(qzh_);
                object qzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate qzl_ = context.Operators.Add(qzi_, qzk_ as CqlQuantity);
                CqlDate qzn_ = context.Operators.Add(qzl_, pzt_);
                CqlInterval<CqlDate> qzo_ = context.Operators.Interval(qze_, qzn_, true, false);
                CqlDate qzp_ = qzo_?.high;
                CqlDateTime qzq_ = context.Operators.ConvertDateToDateTime(qzp_);
                Date qzs_ = pzf_?.BirthDateElement;
                string qzt_ = qzs_?.Value;
                CqlDate qzu_ = context.Operators.ConvertStringToDate(qzt_);
                object qzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate qzx_ = context.Operators.Add(qzu_, qzw_ as CqlQuantity);
                Date qzz_ = pzf_?.BirthDateElement;
                string rza_ = qzz_?.Value;
                CqlDate rzb_ = context.Operators.ConvertStringToDate(rza_);
                object rzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate rze_ = context.Operators.Add(rzb_, rzd_ as CqlQuantity);
                CqlDate rzg_ = context.Operators.Add(rze_, pzt_);
                CqlInterval<CqlDate> rzh_ = context.Operators.Interval(qzx_, rzg_, true, false);
                bool? rzi_ = rzh_?.lowClosed;
                Date rzk_ = pzf_?.BirthDateElement;
                string rzl_ = rzk_?.Value;
                CqlDate rzm_ = context.Operators.ConvertStringToDate(rzl_);
                object rzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate rzp_ = context.Operators.Add(rzm_, rzo_ as CqlQuantity);
                Date rzr_ = pzf_?.BirthDateElement;
                string rzs_ = rzr_?.Value;
                CqlDate rzt_ = context.Operators.ConvertStringToDate(rzs_);
                object rzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, pzj_);
                CqlDate rzw_ = context.Operators.Add(rzt_, rzv_ as CqlQuantity);
                CqlDate rzy_ = context.Operators.Add(rzw_, pzt_);
                CqlInterval<CqlDate> rzz_ = context.Operators.Interval(rzp_, rzy_, true, false);
                bool? sza_ = rzz_?.highClosed;
                CqlInterval<CqlDateTime> szb_ = context.Operators.Interval(pzx_, qzq_, rzi_, sza_);

                return szb_;
            }
            else if (ozm_())
            {
                Patient szc_ = this.Patient(context);
                Date szd_ = szc_?.BirthDateElement;
                string sze_ = szd_?.Value;
                CqlDate szf_ = context.Operators.ConvertStringToDate(sze_);
                DataType szg_ = condition?.Abatement;
                object szh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object szi_ = context.Operators.LateBoundProperty<object>(szh_, "low");
                CqlDate szj_ = context.Operators.Add(szf_, szi_ as CqlQuantity);
                Date szl_ = szc_?.BirthDateElement;
                string szm_ = szl_?.Value;
                CqlDate szn_ = context.Operators.ConvertStringToDate(szm_);
                object szp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object szq_ = context.Operators.LateBoundProperty<object>(szp_, "high");
                CqlDate szr_ = context.Operators.Add(szn_, szq_ as CqlQuantity);
                CqlQuantity szs_ = context.Operators.Quantity(1m, "year");
                CqlDate szt_ = context.Operators.Add(szr_, szs_);
                CqlInterval<CqlDate> szu_ = context.Operators.Interval(szj_, szt_, true, false);
                CqlDate szv_ = szu_?.low;
                CqlDateTime szw_ = context.Operators.ConvertDateToDateTime(szv_);
                Date szy_ = szc_?.BirthDateElement;
                string szz_ = szy_?.Value;
                CqlDate tza_ = context.Operators.ConvertStringToDate(szz_);
                object tzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object tzd_ = context.Operators.LateBoundProperty<object>(tzc_, "low");
                CqlDate tze_ = context.Operators.Add(tza_, tzd_ as CqlQuantity);
                Date tzg_ = szc_?.BirthDateElement;
                string tzh_ = tzg_?.Value;
                CqlDate tzi_ = context.Operators.ConvertStringToDate(tzh_);
                object tzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object tzl_ = context.Operators.LateBoundProperty<object>(tzk_, "high");
                CqlDate tzm_ = context.Operators.Add(tzi_, tzl_ as CqlQuantity);
                CqlDate tzo_ = context.Operators.Add(tzm_, szs_);
                CqlInterval<CqlDate> tzp_ = context.Operators.Interval(tze_, tzo_, true, false);
                CqlDate tzq_ = tzp_?.high;
                CqlDateTime tzr_ = context.Operators.ConvertDateToDateTime(tzq_);
                Date tzt_ = szc_?.BirthDateElement;
                string tzu_ = tzt_?.Value;
                CqlDate tzv_ = context.Operators.ConvertStringToDate(tzu_);
                object tzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object tzy_ = context.Operators.LateBoundProperty<object>(tzx_, "low");
                CqlDate tzz_ = context.Operators.Add(tzv_, tzy_ as CqlQuantity);
                Date uzb_ = szc_?.BirthDateElement;
                string uzc_ = uzb_?.Value;
                CqlDate uzd_ = context.Operators.ConvertStringToDate(uzc_);
                object uzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object uzg_ = context.Operators.LateBoundProperty<object>(uzf_, "high");
                CqlDate uzh_ = context.Operators.Add(uzd_, uzg_ as CqlQuantity);
                CqlDate uzj_ = context.Operators.Add(uzh_, szs_);
                CqlInterval<CqlDate> uzk_ = context.Operators.Interval(tzz_, uzj_, true, false);
                bool? uzl_ = uzk_?.lowClosed;
                Date uzn_ = szc_?.BirthDateElement;
                string uzo_ = uzn_?.Value;
                CqlDate uzp_ = context.Operators.ConvertStringToDate(uzo_);
                object uzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object uzs_ = context.Operators.LateBoundProperty<object>(uzr_, "low");
                CqlDate uzt_ = context.Operators.Add(uzp_, uzs_ as CqlQuantity);
                Date uzv_ = szc_?.BirthDateElement;
                string uzw_ = uzv_?.Value;
                CqlDate uzx_ = context.Operators.ConvertStringToDate(uzw_);
                object uzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szg_);
                object vza_ = context.Operators.LateBoundProperty<object>(uzz_, "high");
                CqlDate vzb_ = context.Operators.Add(uzx_, vza_ as CqlQuantity);
                CqlDate vzd_ = context.Operators.Add(vzb_, szs_);
                CqlInterval<CqlDate> vze_ = context.Operators.Interval(uzt_, vzd_, true, false);
                bool? vzf_ = vze_?.highClosed;
                CqlInterval<CqlDateTime> vzg_ = context.Operators.Interval(szw_, tzr_, uzl_, vzf_);

                return vzg_;
            }
            else if (ozn_())
            {
                DataType vzh_ = condition?.Abatement;
                object vzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzh_);
                object vzj_ = context.Operators.LateBoundProperty<object>(vzi_, "low");
                object vzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzh_);
                object vzm_ = context.Operators.LateBoundProperty<object>(vzl_, "high");
                CqlInterval<CqlDateTime> vzn_ = context.Operators.Interval(vzj_ as CqlDateTime, vzm_ as CqlDateTime, true, false);

                return vzn_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ozj_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vzo_()
        {
            bool vzp_()
            {
                DataType vzt_ = condition?.Abatement;
                object vzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzt_);
                bool vzv_ = vzu_ is CqlDateTime;

                return vzv_;
            };
            bool vzq_()
            {
                DataType vzw_ = condition?.Abatement;
                object vzx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzw_);
                bool vzy_ = vzx_ is CqlQuantity;

                return vzy_;
            };
            bool vzr_()
            {
                DataType vzz_ = condition?.Abatement;
                object wza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzz_);
                bool wzb_ = wza_ is CqlInterval<CqlQuantity>;

                return wzb_;
            };
            bool vzs_()
            {
                DataType wzc_ = condition?.Abatement;
                object wzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzc_);
                bool wze_ = wzd_ is CqlInterval<CqlDateTime>;

                return wze_;
            };
            if (vzp_())
            {
                DataType wzf_ = condition?.Abatement;
                object wzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzf_);
                object wzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzf_);
                CqlInterval<CqlDateTime> wzj_ = context.Operators.Interval(wzg_ as CqlDateTime, wzi_ as CqlDateTime, true, true);

                return wzj_;
            }
            else if (vzq_())
            {
                Patient wzk_ = this.Patient(context);
                Date wzl_ = wzk_?.BirthDateElement;
                string wzm_ = wzl_?.Value;
                CqlDate wzn_ = context.Operators.ConvertStringToDate(wzm_);
                DataType wzo_ = condition?.Abatement;
                object wzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate wzq_ = context.Operators.Add(wzn_, wzp_ as CqlQuantity);
                Date wzs_ = wzk_?.BirthDateElement;
                string wzt_ = wzs_?.Value;
                CqlDate wzu_ = context.Operators.ConvertStringToDate(wzt_);
                object wzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate wzx_ = context.Operators.Add(wzu_, wzw_ as CqlQuantity);
                CqlQuantity wzy_ = context.Operators.Quantity(1m, "year");
                CqlDate wzz_ = context.Operators.Add(wzx_, wzy_);
                CqlInterval<CqlDate> xza_ = context.Operators.Interval(wzq_, wzz_, true, false);
                CqlDate xzb_ = xza_?.low;
                CqlDateTime xzc_ = context.Operators.ConvertDateToDateTime(xzb_);
                Date xze_ = wzk_?.BirthDateElement;
                string xzf_ = xze_?.Value;
                CqlDate xzg_ = context.Operators.ConvertStringToDate(xzf_);
                object xzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate xzj_ = context.Operators.Add(xzg_, xzi_ as CqlQuantity);
                Date xzl_ = wzk_?.BirthDateElement;
                string xzm_ = xzl_?.Value;
                CqlDate xzn_ = context.Operators.ConvertStringToDate(xzm_);
                object xzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate xzq_ = context.Operators.Add(xzn_, xzp_ as CqlQuantity);
                CqlDate xzs_ = context.Operators.Add(xzq_, wzy_);
                CqlInterval<CqlDate> xzt_ = context.Operators.Interval(xzj_, xzs_, true, false);
                CqlDate xzu_ = xzt_?.high;
                CqlDateTime xzv_ = context.Operators.ConvertDateToDateTime(xzu_);
                Date xzx_ = wzk_?.BirthDateElement;
                string xzy_ = xzx_?.Value;
                CqlDate xzz_ = context.Operators.ConvertStringToDate(xzy_);
                object yzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate yzc_ = context.Operators.Add(xzz_, yzb_ as CqlQuantity);
                Date yze_ = wzk_?.BirthDateElement;
                string yzf_ = yze_?.Value;
                CqlDate yzg_ = context.Operators.ConvertStringToDate(yzf_);
                object yzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate yzj_ = context.Operators.Add(yzg_, yzi_ as CqlQuantity);
                CqlDate yzl_ = context.Operators.Add(yzj_, wzy_);
                CqlInterval<CqlDate> yzm_ = context.Operators.Interval(yzc_, yzl_, true, false);
                bool? yzn_ = yzm_?.lowClosed;
                Date yzp_ = wzk_?.BirthDateElement;
                string yzq_ = yzp_?.Value;
                CqlDate yzr_ = context.Operators.ConvertStringToDate(yzq_);
                object yzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate yzu_ = context.Operators.Add(yzr_, yzt_ as CqlQuantity);
                Date yzw_ = wzk_?.BirthDateElement;
                string yzx_ = yzw_?.Value;
                CqlDate yzy_ = context.Operators.ConvertStringToDate(yzx_);
                object zza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, wzo_);
                CqlDate zzb_ = context.Operators.Add(yzy_, zza_ as CqlQuantity);
                CqlDate zzd_ = context.Operators.Add(zzb_, wzy_);
                CqlInterval<CqlDate> zze_ = context.Operators.Interval(yzu_, zzd_, true, false);
                bool? zzf_ = zze_?.highClosed;
                CqlInterval<CqlDateTime> zzg_ = context.Operators.Interval(xzc_, xzv_, yzn_, zzf_);

                return zzg_;
            }
            else if (vzr_())
            {
                Patient zzh_ = this.Patient(context);
                Date zzi_ = zzh_?.BirthDateElement;
                string zzj_ = zzi_?.Value;
                CqlDate zzk_ = context.Operators.ConvertStringToDate(zzj_);
                DataType zzl_ = condition?.Abatement;
                object zzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object zzn_ = context.Operators.LateBoundProperty<object>(zzm_, "low");
                CqlDate zzo_ = context.Operators.Add(zzk_, zzn_ as CqlQuantity);
                Date zzq_ = zzh_?.BirthDateElement;
                string zzr_ = zzq_?.Value;
                CqlDate zzs_ = context.Operators.ConvertStringToDate(zzr_);
                object zzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object zzv_ = context.Operators.LateBoundProperty<object>(zzu_, "high");
                CqlDate zzw_ = context.Operators.Add(zzs_, zzv_ as CqlQuantity);
                CqlQuantity zzx_ = context.Operators.Quantity(1m, "year");
                CqlDate zzy_ = context.Operators.Add(zzw_, zzx_);
                CqlInterval<CqlDate> zzz_ = context.Operators.Interval(zzo_, zzy_, true, false);
                CqlDate azza_ = zzz_?.low;
                CqlDateTime azzb_ = context.Operators.ConvertDateToDateTime(azza_);
                Date azzd_ = zzh_?.BirthDateElement;
                string azze_ = azzd_?.Value;
                CqlDate azzf_ = context.Operators.ConvertStringToDate(azze_);
                object azzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object azzi_ = context.Operators.LateBoundProperty<object>(azzh_, "low");
                CqlDate azzj_ = context.Operators.Add(azzf_, azzi_ as CqlQuantity);
                Date azzl_ = zzh_?.BirthDateElement;
                string azzm_ = azzl_?.Value;
                CqlDate azzn_ = context.Operators.ConvertStringToDate(azzm_);
                object azzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object azzq_ = context.Operators.LateBoundProperty<object>(azzp_, "high");
                CqlDate azzr_ = context.Operators.Add(azzn_, azzq_ as CqlQuantity);
                CqlDate azzt_ = context.Operators.Add(azzr_, zzx_);
                CqlInterval<CqlDate> azzu_ = context.Operators.Interval(azzj_, azzt_, true, false);
                CqlDate azzv_ = azzu_?.high;
                CqlDateTime azzw_ = context.Operators.ConvertDateToDateTime(azzv_);
                Date azzy_ = zzh_?.BirthDateElement;
                string azzz_ = azzy_?.Value;
                CqlDate bzza_ = context.Operators.ConvertStringToDate(azzz_);
                object bzzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object bzzd_ = context.Operators.LateBoundProperty<object>(bzzc_, "low");
                CqlDate bzze_ = context.Operators.Add(bzza_, bzzd_ as CqlQuantity);
                Date bzzg_ = zzh_?.BirthDateElement;
                string bzzh_ = bzzg_?.Value;
                CqlDate bzzi_ = context.Operators.ConvertStringToDate(bzzh_);
                object bzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object bzzl_ = context.Operators.LateBoundProperty<object>(bzzk_, "high");
                CqlDate bzzm_ = context.Operators.Add(bzzi_, bzzl_ as CqlQuantity);
                CqlDate bzzo_ = context.Operators.Add(bzzm_, zzx_);
                CqlInterval<CqlDate> bzzp_ = context.Operators.Interval(bzze_, bzzo_, true, false);
                bool? bzzq_ = bzzp_?.lowClosed;
                Date bzzs_ = zzh_?.BirthDateElement;
                string bzzt_ = bzzs_?.Value;
                CqlDate bzzu_ = context.Operators.ConvertStringToDate(bzzt_);
                object bzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object bzzx_ = context.Operators.LateBoundProperty<object>(bzzw_, "low");
                CqlDate bzzy_ = context.Operators.Add(bzzu_, bzzx_ as CqlQuantity);
                Date czza_ = zzh_?.BirthDateElement;
                string czzb_ = czza_?.Value;
                CqlDate czzc_ = context.Operators.ConvertStringToDate(czzb_);
                object czze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, zzl_);
                object czzf_ = context.Operators.LateBoundProperty<object>(czze_, "high");
                CqlDate czzg_ = context.Operators.Add(czzc_, czzf_ as CqlQuantity);
                CqlDate czzi_ = context.Operators.Add(czzg_, zzx_);
                CqlInterval<CqlDate> czzj_ = context.Operators.Interval(bzzy_, czzi_, true, false);
                bool? czzk_ = czzj_?.highClosed;
                CqlInterval<CqlDateTime> czzl_ = context.Operators.Interval(azzb_, azzw_, bzzq_, czzk_);

                return czzl_;
            }
            else if (vzs_())
            {
                DataType czzm_ = condition?.Abatement;
                object czzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzm_);
                object czzo_ = context.Operators.LateBoundProperty<object>(czzn_, "low");
                object czzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, czzm_);
                object czzr_ = context.Operators.LateBoundProperty<object>(czzq_, "high");
                CqlInterval<CqlDateTime> czzs_ = context.Operators.Interval(czzo_ as CqlDateTime, czzr_ as CqlDateTime, true, false);

                return czzs_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vzo_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzt_()
        {
            bool czzu_()
            {
                CodeableConcept czzv_ = condition?.ClinicalStatus;
                CqlConcept czzw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzv_);
                CqlCode czzx_ = this.active(context);
                CqlConcept czzy_ = context.Operators.ConvertCodeToConcept(czzx_);
                bool? czzz_ = context.Operators.Equivalent(czzw_, czzy_);
                CqlConcept dzzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzv_);
                CqlCode dzzc_ = this.recurrence(context);
                CqlConcept dzzd_ = context.Operators.ConvertCodeToConcept(dzzc_);
                bool? dzze_ = context.Operators.Equivalent(dzzb_, dzzd_);
                bool? dzzf_ = context.Operators.Or(czzz_, dzze_);
                CqlConcept dzzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, czzv_);
                CqlCode dzzi_ = this.relapse(context);
                CqlConcept dzzj_ = context.Operators.ConvertCodeToConcept(dzzi_);
                bool? dzzk_ = context.Operators.Equivalent(dzzh_, dzzj_);
                bool? dzzl_ = context.Operators.Or(dzzf_, dzzk_);

                return dzzl_ ?? false;
            };
            if (czzu_())
            {
                DataType dzzm_ = condition?.Onset;
                object dzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dzzm_);
                CqlInterval<CqlDateTime> dzzo_ = this.ToInterval(context, dzzn_);
                CqlDateTime dzzp_ = context.Operators.Start(dzzo_);
                CqlInterval<CqlDateTime> dzzq_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzr_ = context.Operators.End(dzzq_);
                CqlInterval<CqlDateTime> dzzs_ = context.Operators.Interval(dzzp_, dzzr_, true, true);

                return dzzs_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzt_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzu_ = context.Operators.End(dzzt_);
                CqlDateTime[] dzzv_ = [
                    dzzu_,
                ];
                CqlInterval<CqlDateTime> dzzw_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> ezza_()
                    {
                        if (abatementDate is null)
                        {
                            DataType ezzb_ = condition?.Onset;
                            object ezzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzb_);
                            CqlInterval<CqlDateTime> ezzd_ = this.ToInterval(context, ezzc_);
                            CqlDateTime ezze_ = context.Operators.Start(ezzd_);
                            CqlInterval<CqlDateTime> ezzf_ = context.Operators.Interval(ezze_, abatementDate, true, false);

                            return ezzf_;
                        }
                        else
                        {
                            DataType ezzg_ = condition?.Onset;
                            object ezzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzg_);
                            CqlInterval<CqlDateTime> ezzi_ = this.ToInterval(context, ezzh_);
                            CqlDateTime ezzj_ = context.Operators.Start(ezzi_);
                            CqlInterval<CqlDateTime> ezzk_ = context.Operators.Interval(ezzj_, abatementDate, true, true);

                            return ezzk_;
                        }
                    };

                    return ezza_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzx_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)dzzv_, dzzw_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzx_);
                CqlInterval<CqlDateTime> dzzz_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzy_);

                return dzzz_;
            }
        };

        return czzt_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ezzl_()
        {
            bool ezzm_()
            {
                CodeableConcept ezzn_ = condition?.ClinicalStatus;
                CqlConcept ezzo_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzn_);
                CqlCode ezzp_ = this.active(context);
                CqlConcept ezzq_ = context.Operators.ConvertCodeToConcept(ezzp_);
                bool? ezzr_ = context.Operators.Equivalent(ezzo_, ezzq_);
                CqlConcept ezzt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzn_);
                CqlCode ezzu_ = this.recurrence(context);
                CqlConcept ezzv_ = context.Operators.ConvertCodeToConcept(ezzu_);
                bool? ezzw_ = context.Operators.Equivalent(ezzt_, ezzv_);
                bool? ezzx_ = context.Operators.Or(ezzr_, ezzw_);
                CqlConcept ezzz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ezzn_);
                CqlCode fzza_ = this.relapse(context);
                CqlConcept fzzb_ = context.Operators.ConvertCodeToConcept(fzza_);
                bool? fzzc_ = context.Operators.Equivalent(ezzz_, fzzb_);
                bool? fzzd_ = context.Operators.Or(ezzx_, fzzc_);

                return fzzd_ ?? false;
            };
            if (ezzm_())
            {
                DataType fzze_ = condition?.Onset;
                object fzzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzze_);
                CqlInterval<CqlDateTime> fzzg_ = this.toInterval(context, fzzf_);
                CqlDateTime fzzh_ = context.Operators.Start(fzzg_);
                CqlInterval<CqlDateTime> fzzi_ = this.abatementInterval(context, condition);
                CqlDateTime fzzj_ = context.Operators.End(fzzi_);
                CqlInterval<CqlDateTime> fzzk_ = context.Operators.Interval(fzzh_, fzzj_, true, true);

                return fzzk_;
            }
            else
            {
                CqlInterval<CqlDateTime> fzzl_ = this.ToAbatementInterval(context, condition);
                CqlDateTime fzzm_ = context.Operators.End(fzzl_);
                CqlDateTime[] fzzn_ = [
                    fzzm_,
                ];
                CqlInterval<CqlDateTime> fzzo_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzs_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzt_ = condition?.Onset;
                            object fzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzt_);
                            CqlInterval<CqlDateTime> fzzv_ = this.ToInterval(context, fzzu_);
                            CqlDateTime fzzw_ = context.Operators.Start(fzzv_);
                            CqlInterval<CqlDateTime> fzzx_ = context.Operators.Interval(fzzw_, abatementDate, true, false);

                            return fzzx_;
                        }
                        else
                        {
                            DataType fzzy_ = condition?.Onset;
                            object fzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fzzy_);
                            CqlInterval<CqlDateTime> gzza_ = this.ToInterval(context, fzzz_);
                            CqlDateTime gzzb_ = context.Operators.Start(gzza_);
                            CqlInterval<CqlDateTime> gzzc_ = context.Operators.Interval(gzzb_, abatementDate, true, true);

                            return gzzc_;
                        }
                    };

                    return fzzs_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzp_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzn_, fzzo_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzp_);
                CqlInterval<CqlDateTime> fzzr_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzq_);

                return fzzr_;
            }
        };

        return ezzl_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzd_ = context.Operators.Split(uri, "/");
        string gzze_ = context.Operators.Last<string>(gzzd_);

        return gzze_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> gzzf_ = context.Operators.Split(uri, "/");
        string gzzg_ = context.Operators.Last<string>(gzzf_);

        return gzzg_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzh_ = context.Operators.Start(period);
        CqlDateTime gzzj_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzk_ = context.Operators.Equal(gzzh_, gzzj_);
        bool? gzzl_ = context.Operators.Or((bool?)(gzzh_ is null), gzzk_);
        bool? gzzm_ = context.Operators.Not(gzzl_);

        return gzzm_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzn_ = context.Operators.Start(period);
        CqlDateTime gzzp_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzq_ = context.Operators.Equal(gzzn_, gzzp_);
        bool? gzzr_ = context.Operators.Or((bool?)(gzzn_ is null), gzzq_);
        bool? gzzs_ = context.Operators.Not(gzzr_);

        return gzzs_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzt_ = context.Operators.End(period);
        CqlDateTime gzzv_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzw_ = context.Operators.Equal(gzzt_, gzzv_);
        bool? gzzx_ = context.Operators.Or((bool?)(gzzt_ is null), gzzw_);
        bool? gzzy_ = context.Operators.Not(gzzx_);

        return gzzy_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzz_ = context.Operators.End(period);
        CqlDateTime hzzb_ = context.Operators.MaxValue<CqlDateTime>();
        bool? hzzc_ = context.Operators.Equal(gzzz_, hzzb_);
        bool? hzzd_ = context.Operators.Or((bool?)(gzzz_ is null), hzzc_);
        bool? hzze_ = context.Operators.Not(hzzd_);

        return hzze_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzf_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzg_ = [
            hzzf_,
        ];
        CqlDateTime hzzh_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzl_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzm_ = context.Operators.End(period);

                    return hzzm_;
                }
                else
                {
                    CqlDateTime hzzn_ = context.Operators.Start(period);

                    return hzzn_;
                }
            };

            return hzzl_();
        };
        IEnumerable<CqlDateTime> hzzi_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzg_, hzzh_);
        IEnumerable<CqlDateTime> hzzj_ = context.Operators.Distinct<CqlDateTime>(hzzi_);
        CqlDateTime hzzk_ = context.Operators.SingletonFrom<CqlDateTime>(hzzj_);

        return hzzk_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzo_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzp_ = [
            hzzo_,
        ];
        CqlDateTime hzzq_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzu_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzv_ = context.Operators.End(period);

                    return hzzv_;
                }
                else
                {
                    CqlDateTime hzzw_ = context.Operators.Start(period);

                    return hzzw_;
                }
            };

            return hzzu_();
        };
        IEnumerable<CqlDateTime> hzzr_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzp_, hzzq_);
        IEnumerable<CqlDateTime> hzzs_ = context.Operators.Distinct<CqlDateTime>(hzzr_);
        CqlDateTime hzzt_ = context.Operators.SingletonFrom<CqlDateTime>(hzzs_);

        return hzzt_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzx_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzy_ = [
            hzzx_,
        ];
        CqlDateTime hzzz_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzd_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime izze_ = context.Operators.Start(period);

                    return izze_;
                }
                else
                {
                    CqlDateTime izzf_ = context.Operators.End(period);

                    return izzf_;
                }
            };

            return izzd_();
        };
        IEnumerable<CqlDateTime> izza_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzy_, hzzz_);
        IEnumerable<CqlDateTime> izzb_ = context.Operators.Distinct<CqlDateTime>(izza_);
        CqlDateTime izzc_ = context.Operators.SingletonFrom<CqlDateTime>(izzb_);

        return izzc_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> izzg_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] izzh_ = [
            izzg_,
        ];
        CqlDateTime izzi_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzm_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime izzn_ = context.Operators.Start(period);

                    return izzn_;
                }
                else
                {
                    CqlDateTime izzo_ = context.Operators.End(period);

                    return izzo_;
                }
            };

            return izzm_();
        };
        IEnumerable<CqlDateTime> izzj_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)izzh_, izzi_);
        IEnumerable<CqlDateTime> izzk_ = context.Operators.Distinct<CqlDateTime>(izzj_);
        CqlDateTime izzl_ = context.Operators.SingletonFrom<CqlDateTime>(izzk_);

        return izzl_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzp_ = context.Operators.Start(Period);
        CqlDateTime izzq_ = context.Operators.End(Period);
        int? izzr_ = context.Operators.DurationBetween(izzp_, izzq_, "day");
        CqlInterval<int?> izzs_ = context.Operators.Interval(1, izzr_, true, true);
        CqlInterval<int?>[] izzt_ = [
            izzs_,
        ];
        IEnumerable<CqlInterval<int?>> izzu_ = context.Operators.Expand(izzt_ as IEnumerable<CqlInterval<int?>>, default);
        int? izzv_(CqlInterval<int?> DayNumber)
        {
            int? izzy_ = context.Operators.End(DayNumber);

            return izzy_;
        };
        IEnumerable<int?> izzw_ = context.Operators.Select<CqlInterval<int?>, int?>(izzu_, izzv_);
        IEnumerable<int?> izzx_ = context.Operators.Distinct<int?>(izzw_);

        return izzx_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzz_ = context.Operators.Start(Period);
        CqlDateTime jzza_ = context.Operators.End(Period);
        int? jzzb_ = context.Operators.DurationBetween(izzz_, jzza_, "day");
        CqlInterval<int?> jzzc_ = context.Operators.Interval(1, jzzb_, true, true);
        CqlInterval<int?>[] jzzd_ = [
            jzzc_,
        ];
        IEnumerable<CqlInterval<int?>> jzze_ = context.Operators.Expand(jzzd_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzzf_(CqlInterval<int?> DayNumber)
        {
            int? jzzi_ = context.Operators.End(DayNumber);

            return jzzi_;
        };
        IEnumerable<int?> jzzg_ = context.Operators.Select<CqlInterval<int?>, int?>(jzze_, jzzf_);
        IEnumerable<int?> jzzh_ = context.Operators.Distinct<int?>(jzzg_);

        return jzzh_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> jzzj_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzk_(int? DayIndex)
        {
            CqlDateTime jzzn_ = context.Operators.Start(Period);
            CqlQuantity jzzo_ = context.Operators.Quantity(24m, "hours");
            int? jzzp_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzzq_ = context.Operators.ConvertIntegerToQuantity(jzzp_);
            CqlQuantity jzzr_ = context.Operators.Multiply(jzzo_, jzzq_);
            CqlDateTime jzzs_ = context.Operators.Add(jzzn_, jzzr_);
            CqlDateTime jzzt_()
            {
                bool jzzw_()
                {
                    CqlDateTime jzzx_ = context.Operators.Start(Period);
                    CqlQuantity jzzy_ = context.Operators.Quantity(24m, "hours");
                    int? jzzz_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzza_ = context.Operators.ConvertIntegerToQuantity(jzzz_);
                    CqlQuantity kzzb_ = context.Operators.Multiply(jzzy_, kzza_);
                    CqlDateTime kzzc_ = context.Operators.Add(jzzx_, kzzb_);
                    CqlDateTime kzzd_ = context.Operators.End(Period);
                    int? kzze_ = context.Operators.DurationBetween(kzzc_, kzzd_, "hour");
                    bool? kzzf_ = context.Operators.Less(kzze_, 24);

                    return kzzf_ ?? false;
                };
                if (jzzw_())
                {
                    CqlDateTime kzzg_ = context.Operators.Start(Period);
                    CqlQuantity kzzh_ = context.Operators.Quantity(24m, "hours");
                    int? kzzi_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzj_ = context.Operators.ConvertIntegerToQuantity(kzzi_);
                    CqlQuantity kzzk_ = context.Operators.Multiply(kzzh_, kzzj_);
                    CqlDateTime kzzl_ = context.Operators.Add(kzzg_, kzzk_);

                    return kzzl_;
                }
                else
                {
                    CqlDateTime kzzm_ = context.Operators.Start(Period);
                    CqlQuantity kzzn_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzo_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzp_ = context.Operators.Multiply(kzzn_, kzzo_);
                    CqlDateTime kzzq_ = context.Operators.Add(kzzm_, kzzp_);

                    return kzzq_;
                }
            };
            CqlInterval<CqlDateTime> jzzu_ = context.Operators.Interval(jzzs_, jzzt_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzv_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzu_);

            return jzzv_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzl_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzj_, jzzk_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzl_);

        return jzzm_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzr_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzs_(int? DayIndex)
        {
            CqlDateTime kzzv_ = context.Operators.Start(Period);
            CqlQuantity kzzw_ = context.Operators.Quantity(24m, "hours");
            int? kzzx_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity kzzy_ = context.Operators.ConvertIntegerToQuantity(kzzx_);
            CqlQuantity kzzz_ = context.Operators.Multiply(kzzw_, kzzy_);
            CqlDateTime lzza_ = context.Operators.Add(kzzv_, kzzz_);
            CqlDateTime lzzb_()
            {
                bool lzze_()
                {
                    CqlDateTime lzzf_ = context.Operators.Start(Period);
                    CqlQuantity lzzg_ = context.Operators.Quantity(24m, "hours");
                    int? lzzh_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzi_ = context.Operators.ConvertIntegerToQuantity(lzzh_);
                    CqlQuantity lzzj_ = context.Operators.Multiply(lzzg_, lzzi_);
                    CqlDateTime lzzk_ = context.Operators.Add(lzzf_, lzzj_);
                    CqlDateTime lzzl_ = context.Operators.End(Period);
                    int? lzzm_ = context.Operators.DurationBetween(lzzk_, lzzl_, "hour");
                    bool? lzzn_ = context.Operators.Less(lzzm_, 24);

                    return lzzn_ ?? false;
                };
                if (lzze_())
                {
                    CqlDateTime lzzo_ = context.Operators.Start(Period);
                    CqlQuantity lzzp_ = context.Operators.Quantity(24m, "hours");
                    int? lzzq_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzr_ = context.Operators.ConvertIntegerToQuantity(lzzq_);
                    CqlQuantity lzzs_ = context.Operators.Multiply(lzzp_, lzzr_);
                    CqlDateTime lzzt_ = context.Operators.Add(lzzo_, lzzs_);

                    return lzzt_;
                }
                else
                {
                    CqlDateTime lzzu_ = context.Operators.Start(Period);
                    CqlQuantity lzzv_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity lzzw_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity lzzx_ = context.Operators.Multiply(lzzv_, lzzw_);
                    CqlDateTime lzzy_ = context.Operators.Add(lzzu_, lzzx_);

                    return lzzy_;
                }
            };
            CqlInterval<CqlDateTime> lzzc_ = context.Operators.Interval(lzza_, lzzb_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? lzzd_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, lzzc_);

            return lzzd_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzt_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzr_, kzzs_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzu_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzt_);

        return kzzu_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
