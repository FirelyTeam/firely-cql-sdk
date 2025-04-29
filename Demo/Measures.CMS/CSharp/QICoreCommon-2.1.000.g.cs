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
        IEnumerable<Patient> wu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wv_ = context.Operators.SingletonFrom<Patient>(wu_);

        return wv_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept ww_ = condition?.ClinicalStatus;
        CqlConcept wx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ww_);
        CqlCode wy_ = this.active(context);
        CqlConcept wz_ = context.Operators.ConvertCodeToConcept(wy_);
        bool? xa_ = context.Operators.Equivalent(wx_, wz_);
        CqlConcept xc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ww_);
        CqlCode xd_ = this.recurrence(context);
        CqlConcept xe_ = context.Operators.ConvertCodeToConcept(xd_);
        bool? xf_ = context.Operators.Equivalent(xc_, xe_);
        bool? xg_ = context.Operators.Or(xa_, xf_);
        CqlConcept xi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ww_);
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
            CqlConcept xt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept yc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept yl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept yv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept zz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept azj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept azt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept bzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept czh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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
            CqlConcept czr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

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


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> czv_ = medicationRequest?.Category;
        CqlConcept czw_(CodeableConcept @this)
        {
            CqlConcept dzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzb_;
        };
        IEnumerable<CqlConcept> czx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czv_, czw_);
        bool? czy_(CqlConcept C)
        {
            CqlCode dzc_ = this.Community(context);
            CqlConcept dzd_ = context.Operators.ConvertCodeToConcept(dzc_);
            bool? dze_ = context.Operators.Equivalent(C, dzd_);

            return dze_;
        };
        IEnumerable<CqlConcept> czz_ = context.Operators.Where<CqlConcept>(czx_, czy_);
        bool? dza_ = context.Operators.Exists<CqlConcept>(czz_);

        return dza_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> dzf_ = medicationRequest?.Category;
        CqlConcept dzg_(CodeableConcept @this)
        {
            CqlConcept dzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return dzl_;
        };
        IEnumerable<CqlConcept> dzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzf_, dzg_);
        bool? dzi_(CqlConcept C)
        {
            CqlCode dzm_ = this.Discharge(context);
            CqlConcept dzn_ = context.Operators.ConvertCodeToConcept(dzm_);
            bool? dzo_ = context.Operators.Equivalent(C, dzn_);

            return dzo_;
        };
        IEnumerable<CqlConcept> dzj_ = context.Operators.Where<CqlConcept>(dzh_, dzi_);
        bool? dzk_ = context.Operators.Exists<CqlConcept>(dzj_);

        return dzk_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? dzp_(Extension E)
        {
            string dzv_ = E?.Url;
            FhirString dzw_ = context.Operators.Convert<FhirString>(dzv_);
            string dzx_ = dzw_?.Value;
            bool? dzy_ = context.Operators.Equal(dzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return dzy_;
        };
        IEnumerable<Extension> dzq_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), dzp_);
        bool? dzr_(Extension E)
        {
            DataType dzz_ = E?.Value;
            object eza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzz_);

            return eza_ as bool?;
        };
        IEnumerable<bool?> dzs_ = context.Operators.Select<Extension, bool?>(dzq_, dzr_);
        IEnumerable<bool?> dzt_ = context.Operators.Distinct<bool?>(dzs_);
        bool? dzu_ = context.Operators.SingletonFrom<bool?>(dzt_);

        return dzu_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> ezb_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> ezc_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return ezc_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient ezd_ = this.Patient(context);
                Date eze_ = ezd_?.BirthDateElement;
                string ezf_ = eze_?.Value;
                CqlDate ezg_ = context.Operators.ConvertStringToDate(ezf_);
                CqlDate ezh_ = context.Operators.Add(ezg_, choice as CqlQuantity);
                Date ezj_ = ezd_?.BirthDateElement;
                string ezk_ = ezj_?.Value;
                CqlDate ezl_ = context.Operators.ConvertStringToDate(ezk_);
                CqlDate ezm_ = context.Operators.Add(ezl_, choice as CqlQuantity);
                CqlQuantity ezn_ = context.Operators.Quantity(1m, "year");
                CqlDate ezo_ = context.Operators.Add(ezm_, ezn_);
                CqlInterval<CqlDate> ezp_ = context.Operators.Interval(ezh_, ezo_, true, false);
                CqlDate ezq_ = ezp_?.low;
                CqlDateTime ezr_ = context.Operators.ConvertDateToDateTime(ezq_);
                Date ezt_ = ezd_?.BirthDateElement;
                string ezu_ = ezt_?.Value;
                CqlDate ezv_ = context.Operators.ConvertStringToDate(ezu_);
                CqlDate ezw_ = context.Operators.Add(ezv_, choice as CqlQuantity);
                Date ezy_ = ezd_?.BirthDateElement;
                string ezz_ = ezy_?.Value;
                CqlDate fza_ = context.Operators.ConvertStringToDate(ezz_);
                CqlDate fzb_ = context.Operators.Add(fza_, choice as CqlQuantity);
                CqlDate fzd_ = context.Operators.Add(fzb_, ezn_);
                CqlInterval<CqlDate> fze_ = context.Operators.Interval(ezw_, fzd_, true, false);
                CqlDate fzf_ = fze_?.high;
                CqlDateTime fzg_ = context.Operators.ConvertDateToDateTime(fzf_);
                Date fzi_ = ezd_?.BirthDateElement;
                string fzj_ = fzi_?.Value;
                CqlDate fzk_ = context.Operators.ConvertStringToDate(fzj_);
                CqlDate fzl_ = context.Operators.Add(fzk_, choice as CqlQuantity);
                Date fzn_ = ezd_?.BirthDateElement;
                string fzo_ = fzn_?.Value;
                CqlDate fzp_ = context.Operators.ConvertStringToDate(fzo_);
                CqlDate fzq_ = context.Operators.Add(fzp_, choice as CqlQuantity);
                CqlDate fzs_ = context.Operators.Add(fzq_, ezn_);
                CqlInterval<CqlDate> fzt_ = context.Operators.Interval(fzl_, fzs_, true, false);
                bool? fzu_ = fzt_?.lowClosed;
                Date fzw_ = ezd_?.BirthDateElement;
                string fzx_ = fzw_?.Value;
                CqlDate fzy_ = context.Operators.ConvertStringToDate(fzx_);
                CqlDate fzz_ = context.Operators.Add(fzy_, choice as CqlQuantity);
                Date gzb_ = ezd_?.BirthDateElement;
                string gzc_ = gzb_?.Value;
                CqlDate gzd_ = context.Operators.ConvertStringToDate(gzc_);
                CqlDate gze_ = context.Operators.Add(gzd_, choice as CqlQuantity);
                CqlDate gzg_ = context.Operators.Add(gze_, ezn_);
                CqlInterval<CqlDate> gzh_ = context.Operators.Interval(fzz_, gzg_, true, false);
                bool? gzi_ = gzh_?.highClosed;
                CqlInterval<CqlDateTime> gzj_ = context.Operators.Interval(ezr_, fzg_, fzu_, gzi_);

                return gzj_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient gzk_ = this.Patient(context);
                Date gzl_ = gzk_?.BirthDateElement;
                string gzm_ = gzl_?.Value;
                CqlDate gzn_ = context.Operators.ConvertStringToDate(gzm_);
                object gzo_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate gzp_ = context.Operators.Add(gzn_, gzo_ as CqlQuantity);
                Date gzr_ = gzk_?.BirthDateElement;
                string gzs_ = gzr_?.Value;
                CqlDate gzt_ = context.Operators.ConvertStringToDate(gzs_);
                object gzu_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate gzv_ = context.Operators.Add(gzt_, gzu_ as CqlQuantity);
                CqlQuantity gzw_ = context.Operators.Quantity(1m, "year");
                CqlDate gzx_ = context.Operators.Add(gzv_, gzw_);
                CqlInterval<CqlDate> gzy_ = context.Operators.Interval(gzp_, gzx_, true, false);
                CqlDate gzz_ = gzy_?.low;
                CqlDateTime hza_ = context.Operators.ConvertDateToDateTime(gzz_);
                Date hzc_ = gzk_?.BirthDateElement;
                string hzd_ = hzc_?.Value;
                CqlDate hze_ = context.Operators.ConvertStringToDate(hzd_);
                CqlDate hzg_ = context.Operators.Add(hze_, gzo_ as CqlQuantity);
                Date hzi_ = gzk_?.BirthDateElement;
                string hzj_ = hzi_?.Value;
                CqlDate hzk_ = context.Operators.ConvertStringToDate(hzj_);
                CqlDate hzm_ = context.Operators.Add(hzk_, gzu_ as CqlQuantity);
                CqlDate hzo_ = context.Operators.Add(hzm_, gzw_);
                CqlInterval<CqlDate> hzp_ = context.Operators.Interval(hzg_, hzo_, true, false);
                CqlDate hzq_ = hzp_?.high;
                CqlDateTime hzr_ = context.Operators.ConvertDateToDateTime(hzq_);
                Date hzt_ = gzk_?.BirthDateElement;
                string hzu_ = hzt_?.Value;
                CqlDate hzv_ = context.Operators.ConvertStringToDate(hzu_);
                CqlDate hzx_ = context.Operators.Add(hzv_, gzo_ as CqlQuantity);
                Date hzz_ = gzk_?.BirthDateElement;
                string iza_ = hzz_?.Value;
                CqlDate izb_ = context.Operators.ConvertStringToDate(iza_);
                CqlDate izd_ = context.Operators.Add(izb_, gzu_ as CqlQuantity);
                CqlDate izf_ = context.Operators.Add(izd_, gzw_);
                CqlInterval<CqlDate> izg_ = context.Operators.Interval(hzx_, izf_, true, false);
                bool? izh_ = izg_?.lowClosed;
                Date izj_ = gzk_?.BirthDateElement;
                string izk_ = izj_?.Value;
                CqlDate izl_ = context.Operators.ConvertStringToDate(izk_);
                CqlDate izn_ = context.Operators.Add(izl_, gzo_ as CqlQuantity);
                Date izp_ = gzk_?.BirthDateElement;
                string izq_ = izp_?.Value;
                CqlDate izr_ = context.Operators.ConvertStringToDate(izq_);
                CqlDate izt_ = context.Operators.Add(izr_, gzu_ as CqlQuantity);
                CqlDate izv_ = context.Operators.Add(izt_, gzw_);
                CqlInterval<CqlDate> izw_ = context.Operators.Interval(izn_, izv_, true, false);
                bool? izx_ = izw_?.highClosed;
                CqlInterval<CqlDateTime> izy_ = context.Operators.Interval(hza_, hzr_, izh_, izx_);

                return izy_;
            }
            else if (choice is Timing)
            {
                object izz_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return izz_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return ezb_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jza_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> jzb_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return jzb_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient jzc_ = this.Patient(context);
                Date jzd_ = jzc_?.BirthDateElement;
                string jze_ = jzd_?.Value;
                CqlDate jzf_ = context.Operators.ConvertStringToDate(jze_);
                CqlDate jzg_ = context.Operators.Add(jzf_, choice as CqlQuantity);
                Date jzi_ = jzc_?.BirthDateElement;
                string jzj_ = jzi_?.Value;
                CqlDate jzk_ = context.Operators.ConvertStringToDate(jzj_);
                CqlDate jzl_ = context.Operators.Add(jzk_, choice as CqlQuantity);
                CqlQuantity jzm_ = context.Operators.Quantity(1m, "year");
                CqlDate jzn_ = context.Operators.Add(jzl_, jzm_);
                CqlInterval<CqlDate> jzo_ = context.Operators.Interval(jzg_, jzn_, true, false);
                CqlDate jzp_ = jzo_?.low;
                CqlDateTime jzq_ = context.Operators.ConvertDateToDateTime(jzp_);
                Date jzs_ = jzc_?.BirthDateElement;
                string jzt_ = jzs_?.Value;
                CqlDate jzu_ = context.Operators.ConvertStringToDate(jzt_);
                CqlDate jzv_ = context.Operators.Add(jzu_, choice as CqlQuantity);
                Date jzx_ = jzc_?.BirthDateElement;
                string jzy_ = jzx_?.Value;
                CqlDate jzz_ = context.Operators.ConvertStringToDate(jzy_);
                CqlDate kza_ = context.Operators.Add(jzz_, choice as CqlQuantity);
                CqlDate kzc_ = context.Operators.Add(kza_, jzm_);
                CqlInterval<CqlDate> kzd_ = context.Operators.Interval(jzv_, kzc_, true, false);
                CqlDate kze_ = kzd_?.high;
                CqlDateTime kzf_ = context.Operators.ConvertDateToDateTime(kze_);
                Date kzh_ = jzc_?.BirthDateElement;
                string kzi_ = kzh_?.Value;
                CqlDate kzj_ = context.Operators.ConvertStringToDate(kzi_);
                CqlDate kzk_ = context.Operators.Add(kzj_, choice as CqlQuantity);
                Date kzm_ = jzc_?.BirthDateElement;
                string kzn_ = kzm_?.Value;
                CqlDate kzo_ = context.Operators.ConvertStringToDate(kzn_);
                CqlDate kzp_ = context.Operators.Add(kzo_, choice as CqlQuantity);
                CqlDate kzr_ = context.Operators.Add(kzp_, jzm_);
                CqlInterval<CqlDate> kzs_ = context.Operators.Interval(kzk_, kzr_, true, false);
                bool? kzt_ = kzs_?.lowClosed;
                Date kzv_ = jzc_?.BirthDateElement;
                string kzw_ = kzv_?.Value;
                CqlDate kzx_ = context.Operators.ConvertStringToDate(kzw_);
                CqlDate kzy_ = context.Operators.Add(kzx_, choice as CqlQuantity);
                Date lza_ = jzc_?.BirthDateElement;
                string lzb_ = lza_?.Value;
                CqlDate lzc_ = context.Operators.ConvertStringToDate(lzb_);
                CqlDate lzd_ = context.Operators.Add(lzc_, choice as CqlQuantity);
                CqlDate lzf_ = context.Operators.Add(lzd_, jzm_);
                CqlInterval<CqlDate> lzg_ = context.Operators.Interval(kzy_, lzf_, true, false);
                bool? lzh_ = lzg_?.highClosed;
                CqlInterval<CqlDateTime> lzi_ = context.Operators.Interval(jzq_, kzf_, kzt_, lzh_);

                return lzi_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient lzj_ = this.Patient(context);
                Date lzk_ = lzj_?.BirthDateElement;
                string lzl_ = lzk_?.Value;
                CqlDate lzm_ = context.Operators.ConvertStringToDate(lzl_);
                object lzn_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate lzo_ = context.Operators.Add(lzm_, lzn_ as CqlQuantity);
                Date lzq_ = lzj_?.BirthDateElement;
                string lzr_ = lzq_?.Value;
                CqlDate lzs_ = context.Operators.ConvertStringToDate(lzr_);
                object lzt_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate lzu_ = context.Operators.Add(lzs_, lzt_ as CqlQuantity);
                CqlQuantity lzv_ = context.Operators.Quantity(1m, "year");
                CqlDate lzw_ = context.Operators.Add(lzu_, lzv_);
                CqlInterval<CqlDate> lzx_ = context.Operators.Interval(lzo_, lzw_, true, false);
                CqlDate lzy_ = lzx_?.low;
                CqlDateTime lzz_ = context.Operators.ConvertDateToDateTime(lzy_);
                Date mzb_ = lzj_?.BirthDateElement;
                string mzc_ = mzb_?.Value;
                CqlDate mzd_ = context.Operators.ConvertStringToDate(mzc_);
                CqlDate mzf_ = context.Operators.Add(mzd_, lzn_ as CqlQuantity);
                Date mzh_ = lzj_?.BirthDateElement;
                string mzi_ = mzh_?.Value;
                CqlDate mzj_ = context.Operators.ConvertStringToDate(mzi_);
                CqlDate mzl_ = context.Operators.Add(mzj_, lzt_ as CqlQuantity);
                CqlDate mzn_ = context.Operators.Add(mzl_, lzv_);
                CqlInterval<CqlDate> mzo_ = context.Operators.Interval(mzf_, mzn_, true, false);
                CqlDate mzp_ = mzo_?.high;
                CqlDateTime mzq_ = context.Operators.ConvertDateToDateTime(mzp_);
                Date mzs_ = lzj_?.BirthDateElement;
                string mzt_ = mzs_?.Value;
                CqlDate mzu_ = context.Operators.ConvertStringToDate(mzt_);
                CqlDate mzw_ = context.Operators.Add(mzu_, lzn_ as CqlQuantity);
                Date mzy_ = lzj_?.BirthDateElement;
                string mzz_ = mzy_?.Value;
                CqlDate nza_ = context.Operators.ConvertStringToDate(mzz_);
                CqlDate nzc_ = context.Operators.Add(nza_, lzt_ as CqlQuantity);
                CqlDate nze_ = context.Operators.Add(nzc_, lzv_);
                CqlInterval<CqlDate> nzf_ = context.Operators.Interval(mzw_, nze_, true, false);
                bool? nzg_ = nzf_?.lowClosed;
                Date nzi_ = lzj_?.BirthDateElement;
                string nzj_ = nzi_?.Value;
                CqlDate nzk_ = context.Operators.ConvertStringToDate(nzj_);
                CqlDate nzm_ = context.Operators.Add(nzk_, lzn_ as CqlQuantity);
                Date nzo_ = lzj_?.BirthDateElement;
                string nzp_ = nzo_?.Value;
                CqlDate nzq_ = context.Operators.ConvertStringToDate(nzp_);
                CqlDate nzs_ = context.Operators.Add(nzq_, lzt_ as CqlQuantity);
                CqlDate nzu_ = context.Operators.Add(nzs_, lzv_);
                CqlInterval<CqlDate> nzv_ = context.Operators.Interval(nzm_, nzu_, true, false);
                bool? nzw_ = nzv_?.highClosed;
                CqlInterval<CqlDateTime> nzx_ = context.Operators.Interval(lzz_, mzq_, nzg_, nzw_);

                return nzx_;
            }
            else if (choice is Timing)
            {
                object nzy_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return nzy_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jza_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> nzz_()
        {
            bool oza_()
            {
                DataType oze_ = condition?.Abatement;
                object ozf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, oze_);
                bool ozg_ = ozf_ is CqlDateTime;

                return ozg_;
            };
            bool ozb_()
            {
                DataType ozh_ = condition?.Abatement;
                object ozi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozh_);
                bool ozj_ = ozi_ is CqlQuantity;

                return ozj_;
            };
            bool ozc_()
            {
                DataType ozk_ = condition?.Abatement;
                object ozl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozk_);
                bool ozm_ = ozl_ is CqlInterval<CqlQuantity>;

                return ozm_;
            };
            bool ozd_()
            {
                DataType ozn_ = condition?.Abatement;
                object ozo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozn_);
                bool ozp_ = ozo_ is CqlInterval<CqlDateTime>;

                return ozp_;
            };
            if (oza_())
            {
                DataType ozq_ = condition?.Abatement;
                object ozr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozq_);
                object ozt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozq_);
                CqlInterval<CqlDateTime> ozu_ = context.Operators.Interval(ozr_ as CqlDateTime, ozt_ as CqlDateTime, true, true);

                return ozu_;
            }
            else if (ozb_())
            {
                Patient ozv_ = this.Patient(context);
                Date ozw_ = ozv_?.BirthDateElement;
                string ozx_ = ozw_?.Value;
                CqlDate ozy_ = context.Operators.ConvertStringToDate(ozx_);
                DataType ozz_ = condition?.Abatement;
                object pza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate pzb_ = context.Operators.Add(ozy_, pza_ as CqlQuantity);
                Date pzd_ = ozv_?.BirthDateElement;
                string pze_ = pzd_?.Value;
                CqlDate pzf_ = context.Operators.ConvertStringToDate(pze_);
                object pzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate pzi_ = context.Operators.Add(pzf_, pzh_ as CqlQuantity);
                CqlQuantity pzj_ = context.Operators.Quantity(1m, "year");
                CqlDate pzk_ = context.Operators.Add(pzi_, pzj_);
                CqlInterval<CqlDate> pzl_ = context.Operators.Interval(pzb_, pzk_, true, false);
                CqlDate pzm_ = pzl_?.low;
                CqlDateTime pzn_ = context.Operators.ConvertDateToDateTime(pzm_);
                Date pzp_ = ozv_?.BirthDateElement;
                string pzq_ = pzp_?.Value;
                CqlDate pzr_ = context.Operators.ConvertStringToDate(pzq_);
                object pzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate pzu_ = context.Operators.Add(pzr_, pzt_ as CqlQuantity);
                Date pzw_ = ozv_?.BirthDateElement;
                string pzx_ = pzw_?.Value;
                CqlDate pzy_ = context.Operators.ConvertStringToDate(pzx_);
                object qza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate qzb_ = context.Operators.Add(pzy_, qza_ as CqlQuantity);
                CqlDate qzd_ = context.Operators.Add(qzb_, pzj_);
                CqlInterval<CqlDate> qze_ = context.Operators.Interval(pzu_, qzd_, true, false);
                CqlDate qzf_ = qze_?.high;
                CqlDateTime qzg_ = context.Operators.ConvertDateToDateTime(qzf_);
                Date qzi_ = ozv_?.BirthDateElement;
                string qzj_ = qzi_?.Value;
                CqlDate qzk_ = context.Operators.ConvertStringToDate(qzj_);
                object qzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate qzn_ = context.Operators.Add(qzk_, qzm_ as CqlQuantity);
                Date qzp_ = ozv_?.BirthDateElement;
                string qzq_ = qzp_?.Value;
                CqlDate qzr_ = context.Operators.ConvertStringToDate(qzq_);
                object qzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate qzu_ = context.Operators.Add(qzr_, qzt_ as CqlQuantity);
                CqlDate qzw_ = context.Operators.Add(qzu_, pzj_);
                CqlInterval<CqlDate> qzx_ = context.Operators.Interval(qzn_, qzw_, true, false);
                bool? qzy_ = qzx_?.lowClosed;
                Date rza_ = ozv_?.BirthDateElement;
                string rzb_ = rza_?.Value;
                CqlDate rzc_ = context.Operators.ConvertStringToDate(rzb_);
                object rze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate rzf_ = context.Operators.Add(rzc_, rze_ as CqlQuantity);
                Date rzh_ = ozv_?.BirthDateElement;
                string rzi_ = rzh_?.Value;
                CqlDate rzj_ = context.Operators.ConvertStringToDate(rzi_);
                object rzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozz_);
                CqlDate rzm_ = context.Operators.Add(rzj_, rzl_ as CqlQuantity);
                CqlDate rzo_ = context.Operators.Add(rzm_, pzj_);
                CqlInterval<CqlDate> rzp_ = context.Operators.Interval(rzf_, rzo_, true, false);
                bool? rzq_ = rzp_?.highClosed;
                CqlInterval<CqlDateTime> rzr_ = context.Operators.Interval(pzn_, qzg_, qzy_, rzq_);

                return rzr_;
            }
            else if (ozc_())
            {
                Patient rzs_ = this.Patient(context);
                Date rzt_ = rzs_?.BirthDateElement;
                string rzu_ = rzt_?.Value;
                CqlDate rzv_ = context.Operators.ConvertStringToDate(rzu_);
                DataType rzw_ = condition?.Abatement;
                object rzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object rzy_ = context.Operators.LateBoundProperty<object>(rzx_, "low");
                CqlDate rzz_ = context.Operators.Add(rzv_, rzy_ as CqlQuantity);
                Date szb_ = rzs_?.BirthDateElement;
                string szc_ = szb_?.Value;
                CqlDate szd_ = context.Operators.ConvertStringToDate(szc_);
                object szf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object szg_ = context.Operators.LateBoundProperty<object>(szf_, "high");
                CqlDate szh_ = context.Operators.Add(szd_, szg_ as CqlQuantity);
                CqlQuantity szi_ = context.Operators.Quantity(1m, "year");
                CqlDate szj_ = context.Operators.Add(szh_, szi_);
                CqlInterval<CqlDate> szk_ = context.Operators.Interval(rzz_, szj_, true, false);
                CqlDate szl_ = szk_?.low;
                CqlDateTime szm_ = context.Operators.ConvertDateToDateTime(szl_);
                Date szo_ = rzs_?.BirthDateElement;
                string szp_ = szo_?.Value;
                CqlDate szq_ = context.Operators.ConvertStringToDate(szp_);
                object szs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object szt_ = context.Operators.LateBoundProperty<object>(szs_, "low");
                CqlDate szu_ = context.Operators.Add(szq_, szt_ as CqlQuantity);
                Date szw_ = rzs_?.BirthDateElement;
                string szx_ = szw_?.Value;
                CqlDate szy_ = context.Operators.ConvertStringToDate(szx_);
                object tza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object tzb_ = context.Operators.LateBoundProperty<object>(tza_, "high");
                CqlDate tzc_ = context.Operators.Add(szy_, tzb_ as CqlQuantity);
                CqlDate tze_ = context.Operators.Add(tzc_, szi_);
                CqlInterval<CqlDate> tzf_ = context.Operators.Interval(szu_, tze_, true, false);
                CqlDate tzg_ = tzf_?.high;
                CqlDateTime tzh_ = context.Operators.ConvertDateToDateTime(tzg_);
                Date tzj_ = rzs_?.BirthDateElement;
                string tzk_ = tzj_?.Value;
                CqlDate tzl_ = context.Operators.ConvertStringToDate(tzk_);
                object tzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object tzo_ = context.Operators.LateBoundProperty<object>(tzn_, "low");
                CqlDate tzp_ = context.Operators.Add(tzl_, tzo_ as CqlQuantity);
                Date tzr_ = rzs_?.BirthDateElement;
                string tzs_ = tzr_?.Value;
                CqlDate tzt_ = context.Operators.ConvertStringToDate(tzs_);
                object tzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object tzw_ = context.Operators.LateBoundProperty<object>(tzv_, "high");
                CqlDate tzx_ = context.Operators.Add(tzt_, tzw_ as CqlQuantity);
                CqlDate tzz_ = context.Operators.Add(tzx_, szi_);
                CqlInterval<CqlDate> uza_ = context.Operators.Interval(tzp_, tzz_, true, false);
                bool? uzb_ = uza_?.lowClosed;
                Date uzd_ = rzs_?.BirthDateElement;
                string uze_ = uzd_?.Value;
                CqlDate uzf_ = context.Operators.ConvertStringToDate(uze_);
                object uzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object uzi_ = context.Operators.LateBoundProperty<object>(uzh_, "low");
                CqlDate uzj_ = context.Operators.Add(uzf_, uzi_ as CqlQuantity);
                Date uzl_ = rzs_?.BirthDateElement;
                string uzm_ = uzl_?.Value;
                CqlDate uzn_ = context.Operators.ConvertStringToDate(uzm_);
                object uzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzw_);
                object uzq_ = context.Operators.LateBoundProperty<object>(uzp_, "high");
                CqlDate uzr_ = context.Operators.Add(uzn_, uzq_ as CqlQuantity);
                CqlDate uzt_ = context.Operators.Add(uzr_, szi_);
                CqlInterval<CqlDate> uzu_ = context.Operators.Interval(uzj_, uzt_, true, false);
                bool? uzv_ = uzu_?.highClosed;
                CqlInterval<CqlDateTime> uzw_ = context.Operators.Interval(szm_, tzh_, uzb_, uzv_);

                return uzw_;
            }
            else if (ozd_())
            {
                DataType uzx_ = condition?.Abatement;
                object uzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzx_);
                object uzz_ = context.Operators.LateBoundProperty<object>(uzy_, "low");
                object vzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzx_);
                object vzc_ = context.Operators.LateBoundProperty<object>(vzb_, "high");
                CqlInterval<CqlDateTime> vzd_ = context.Operators.Interval(uzz_ as CqlDateTime, vzc_ as CqlDateTime, true, false);

                return vzd_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return nzz_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> vze_()
        {
            bool vzf_()
            {
                DataType vzj_ = condition?.Abatement;
                object vzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzj_);
                bool vzl_ = vzk_ is CqlDateTime;

                return vzl_;
            };
            bool vzg_()
            {
                DataType vzm_ = condition?.Abatement;
                object vzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzm_);
                bool vzo_ = vzn_ is CqlQuantity;

                return vzo_;
            };
            bool vzh_()
            {
                DataType vzp_ = condition?.Abatement;
                object vzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzp_);
                bool vzr_ = vzq_ is CqlInterval<CqlQuantity>;

                return vzr_;
            };
            bool vzi_()
            {
                DataType vzs_ = condition?.Abatement;
                object vzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzs_);
                bool vzu_ = vzt_ is CqlInterval<CqlDateTime>;

                return vzu_;
            };
            if (vzf_())
            {
                DataType vzv_ = condition?.Abatement;
                object vzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzv_);
                object vzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzv_);
                CqlInterval<CqlDateTime> vzz_ = context.Operators.Interval(vzw_ as CqlDateTime, vzy_ as CqlDateTime, true, true);

                return vzz_;
            }
            else if (vzg_())
            {
                Patient wza_ = this.Patient(context);
                Date wzb_ = wza_?.BirthDateElement;
                string wzc_ = wzb_?.Value;
                CqlDate wzd_ = context.Operators.ConvertStringToDate(wzc_);
                DataType wze_ = condition?.Abatement;
                object wzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate wzg_ = context.Operators.Add(wzd_, wzf_ as CqlQuantity);
                Date wzi_ = wza_?.BirthDateElement;
                string wzj_ = wzi_?.Value;
                CqlDate wzk_ = context.Operators.ConvertStringToDate(wzj_);
                object wzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate wzn_ = context.Operators.Add(wzk_, wzm_ as CqlQuantity);
                CqlQuantity wzo_ = context.Operators.Quantity(1m, "year");
                CqlDate wzp_ = context.Operators.Add(wzn_, wzo_);
                CqlInterval<CqlDate> wzq_ = context.Operators.Interval(wzg_, wzp_, true, false);
                CqlDate wzr_ = wzq_?.low;
                CqlDateTime wzs_ = context.Operators.ConvertDateToDateTime(wzr_);
                Date wzu_ = wza_?.BirthDateElement;
                string wzv_ = wzu_?.Value;
                CqlDate wzw_ = context.Operators.ConvertStringToDate(wzv_);
                object wzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate wzz_ = context.Operators.Add(wzw_, wzy_ as CqlQuantity);
                Date xzb_ = wza_?.BirthDateElement;
                string xzc_ = xzb_?.Value;
                CqlDate xzd_ = context.Operators.ConvertStringToDate(xzc_);
                object xzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate xzg_ = context.Operators.Add(xzd_, xzf_ as CqlQuantity);
                CqlDate xzi_ = context.Operators.Add(xzg_, wzo_);
                CqlInterval<CqlDate> xzj_ = context.Operators.Interval(wzz_, xzi_, true, false);
                CqlDate xzk_ = xzj_?.high;
                CqlDateTime xzl_ = context.Operators.ConvertDateToDateTime(xzk_);
                Date xzn_ = wza_?.BirthDateElement;
                string xzo_ = xzn_?.Value;
                CqlDate xzp_ = context.Operators.ConvertStringToDate(xzo_);
                object xzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate xzs_ = context.Operators.Add(xzp_, xzr_ as CqlQuantity);
                Date xzu_ = wza_?.BirthDateElement;
                string xzv_ = xzu_?.Value;
                CqlDate xzw_ = context.Operators.ConvertStringToDate(xzv_);
                object xzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate xzz_ = context.Operators.Add(xzw_, xzy_ as CqlQuantity);
                CqlDate yzb_ = context.Operators.Add(xzz_, wzo_);
                CqlInterval<CqlDate> yzc_ = context.Operators.Interval(xzs_, yzb_, true, false);
                bool? yzd_ = yzc_?.lowClosed;
                Date yzf_ = wza_?.BirthDateElement;
                string yzg_ = yzf_?.Value;
                CqlDate yzh_ = context.Operators.ConvertStringToDate(yzg_);
                object yzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate yzk_ = context.Operators.Add(yzh_, yzj_ as CqlQuantity);
                Date yzm_ = wza_?.BirthDateElement;
                string yzn_ = yzm_?.Value;
                CqlDate yzo_ = context.Operators.ConvertStringToDate(yzn_);
                object yzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wze_);
                CqlDate yzr_ = context.Operators.Add(yzo_, yzq_ as CqlQuantity);
                CqlDate yzt_ = context.Operators.Add(yzr_, wzo_);
                CqlInterval<CqlDate> yzu_ = context.Operators.Interval(yzk_, yzt_, true, false);
                bool? yzv_ = yzu_?.highClosed;
                CqlInterval<CqlDateTime> yzw_ = context.Operators.Interval(wzs_, xzl_, yzd_, yzv_);

                return yzw_;
            }
            else if (vzh_())
            {
                Patient yzx_ = this.Patient(context);
                Date yzy_ = yzx_?.BirthDateElement;
                string yzz_ = yzy_?.Value;
                CqlDate zza_ = context.Operators.ConvertStringToDate(yzz_);
                DataType zzb_ = condition?.Abatement;
                object zzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object zzd_ = context.Operators.LateBoundProperty<object>(zzc_, "low");
                CqlDate zze_ = context.Operators.Add(zza_, zzd_ as CqlQuantity);
                Date zzg_ = yzx_?.BirthDateElement;
                string zzh_ = zzg_?.Value;
                CqlDate zzi_ = context.Operators.ConvertStringToDate(zzh_);
                object zzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object zzl_ = context.Operators.LateBoundProperty<object>(zzk_, "high");
                CqlDate zzm_ = context.Operators.Add(zzi_, zzl_ as CqlQuantity);
                CqlQuantity zzn_ = context.Operators.Quantity(1m, "year");
                CqlDate zzo_ = context.Operators.Add(zzm_, zzn_);
                CqlInterval<CqlDate> zzp_ = context.Operators.Interval(zze_, zzo_, true, false);
                CqlDate zzq_ = zzp_?.low;
                CqlDateTime zzr_ = context.Operators.ConvertDateToDateTime(zzq_);
                Date zzt_ = yzx_?.BirthDateElement;
                string zzu_ = zzt_?.Value;
                CqlDate zzv_ = context.Operators.ConvertStringToDate(zzu_);
                object zzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object zzy_ = context.Operators.LateBoundProperty<object>(zzx_, "low");
                CqlDate zzz_ = context.Operators.Add(zzv_, zzy_ as CqlQuantity);
                Date azzb_ = yzx_?.BirthDateElement;
                string azzc_ = azzb_?.Value;
                CqlDate azzd_ = context.Operators.ConvertStringToDate(azzc_);
                object azzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object azzg_ = context.Operators.LateBoundProperty<object>(azzf_, "high");
                CqlDate azzh_ = context.Operators.Add(azzd_, azzg_ as CqlQuantity);
                CqlDate azzj_ = context.Operators.Add(azzh_, zzn_);
                CqlInterval<CqlDate> azzk_ = context.Operators.Interval(zzz_, azzj_, true, false);
                CqlDate azzl_ = azzk_?.high;
                CqlDateTime azzm_ = context.Operators.ConvertDateToDateTime(azzl_);
                Date azzo_ = yzx_?.BirthDateElement;
                string azzp_ = azzo_?.Value;
                CqlDate azzq_ = context.Operators.ConvertStringToDate(azzp_);
                object azzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object azzt_ = context.Operators.LateBoundProperty<object>(azzs_, "low");
                CqlDate azzu_ = context.Operators.Add(azzq_, azzt_ as CqlQuantity);
                Date azzw_ = yzx_?.BirthDateElement;
                string azzx_ = azzw_?.Value;
                CqlDate azzy_ = context.Operators.ConvertStringToDate(azzx_);
                object bzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object bzzb_ = context.Operators.LateBoundProperty<object>(bzza_, "high");
                CqlDate bzzc_ = context.Operators.Add(azzy_, bzzb_ as CqlQuantity);
                CqlDate bzze_ = context.Operators.Add(bzzc_, zzn_);
                CqlInterval<CqlDate> bzzf_ = context.Operators.Interval(azzu_, bzze_, true, false);
                bool? bzzg_ = bzzf_?.lowClosed;
                Date bzzi_ = yzx_?.BirthDateElement;
                string bzzj_ = bzzi_?.Value;
                CqlDate bzzk_ = context.Operators.ConvertStringToDate(bzzj_);
                object bzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object bzzn_ = context.Operators.LateBoundProperty<object>(bzzm_, "low");
                CqlDate bzzo_ = context.Operators.Add(bzzk_, bzzn_ as CqlQuantity);
                Date bzzq_ = yzx_?.BirthDateElement;
                string bzzr_ = bzzq_?.Value;
                CqlDate bzzs_ = context.Operators.ConvertStringToDate(bzzr_);
                object bzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzb_);
                object bzzv_ = context.Operators.LateBoundProperty<object>(bzzu_, "high");
                CqlDate bzzw_ = context.Operators.Add(bzzs_, bzzv_ as CqlQuantity);
                CqlDate bzzy_ = context.Operators.Add(bzzw_, zzn_);
                CqlInterval<CqlDate> bzzz_ = context.Operators.Interval(bzzo_, bzzy_, true, false);
                bool? czza_ = bzzz_?.highClosed;
                CqlInterval<CqlDateTime> czzb_ = context.Operators.Interval(zzr_, azzm_, bzzg_, czza_);

                return czzb_;
            }
            else if (vzi_())
            {
                DataType czzc_ = condition?.Abatement;
                object czzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzc_);
                object czze_ = context.Operators.LateBoundProperty<object>(czzd_, "low");
                object czzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzc_);
                object czzh_ = context.Operators.LateBoundProperty<object>(czzg_, "high");
                CqlInterval<CqlDateTime> czzi_ = context.Operators.Interval(czze_ as CqlDateTime, czzh_ as CqlDateTime, true, false);

                return czzi_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return vze_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> czzj_()
        {
            bool czzk_()
            {
                CodeableConcept czzl_ = condition?.ClinicalStatus;
                CqlConcept czzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzl_);
                CqlCode czzn_ = this.active(context);
                CqlConcept czzo_ = context.Operators.ConvertCodeToConcept(czzn_);
                bool? czzp_ = context.Operators.Equivalent(czzm_, czzo_);
                CqlConcept czzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzl_);
                CqlCode czzs_ = this.recurrence(context);
                CqlConcept czzt_ = context.Operators.ConvertCodeToConcept(czzs_);
                bool? czzu_ = context.Operators.Equivalent(czzr_, czzt_);
                bool? czzv_ = context.Operators.Or(czzp_, czzu_);
                CqlConcept czzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzl_);
                CqlCode czzy_ = this.relapse(context);
                CqlConcept czzz_ = context.Operators.ConvertCodeToConcept(czzy_);
                bool? dzza_ = context.Operators.Equivalent(czzx_, czzz_);
                bool? dzzb_ = context.Operators.Or(czzv_, dzza_);

                return dzzb_ ?? false;
            };
            if (czzk_())
            {
                DataType dzzc_ = condition?.Onset;
                object dzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzc_);
                CqlInterval<CqlDateTime> dzze_ = this.ToInterval(context, dzzd_);
                CqlDateTime dzzf_ = context.Operators.Start(dzze_);
                CqlInterval<CqlDateTime> dzzg_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzh_ = context.Operators.End(dzzg_);
                CqlInterval<CqlDateTime> dzzi_ = context.Operators.Interval(dzzf_, dzzh_, true, true);

                return dzzi_;
            }
            else
            {
                CqlInterval<CqlDateTime> dzzj_ = this.ToAbatementInterval(context, condition);
                CqlDateTime dzzk_ = context.Operators.End(dzzj_);
                CqlDateTime[] dzzl_ = [
                    dzzk_,
                ];
                CqlInterval<CqlDateTime> dzzm_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> dzzq_()
                    {
                        if (abatementDate is null)
                        {
                            DataType dzzr_ = condition?.Onset;
                            object dzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzr_);
                            CqlInterval<CqlDateTime> dzzt_ = this.ToInterval(context, dzzs_);
                            CqlDateTime dzzu_ = context.Operators.Start(dzzt_);
                            CqlInterval<CqlDateTime> dzzv_ = context.Operators.Interval(dzzu_, abatementDate, true, false);

                            return dzzv_;
                        }
                        else
                        {
                            DataType dzzw_ = condition?.Onset;
                            object dzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzw_);
                            CqlInterval<CqlDateTime> dzzy_ = this.ToInterval(context, dzzx_);
                            CqlDateTime dzzz_ = context.Operators.Start(dzzy_);
                            CqlInterval<CqlDateTime> ezza_ = context.Operators.Interval(dzzz_, abatementDate, true, true);

                            return ezza_;
                        }
                    };

                    return dzzq_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> dzzn_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)dzzl_, dzzm_);
                IEnumerable<CqlInterval<CqlDateTime>> dzzo_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzn_);
                CqlInterval<CqlDateTime> dzzp_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(dzzo_);

                return dzzp_;
            }
        };

        return czzj_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting\ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> ezzb_()
        {
            bool ezzc_()
            {
                CodeableConcept ezzd_ = condition?.ClinicalStatus;
                CqlConcept ezze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzd_);
                CqlCode ezzf_ = this.active(context);
                CqlConcept ezzg_ = context.Operators.ConvertCodeToConcept(ezzf_);
                bool? ezzh_ = context.Operators.Equivalent(ezze_, ezzg_);
                CqlConcept ezzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzd_);
                CqlCode ezzk_ = this.recurrence(context);
                CqlConcept ezzl_ = context.Operators.ConvertCodeToConcept(ezzk_);
                bool? ezzm_ = context.Operators.Equivalent(ezzj_, ezzl_);
                bool? ezzn_ = context.Operators.Or(ezzh_, ezzm_);
                CqlConcept ezzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzd_);
                CqlCode ezzq_ = this.relapse(context);
                CqlConcept ezzr_ = context.Operators.ConvertCodeToConcept(ezzq_);
                bool? ezzs_ = context.Operators.Equivalent(ezzp_, ezzr_);
                bool? ezzt_ = context.Operators.Or(ezzn_, ezzs_);

                return ezzt_ ?? false;
            };
            if (ezzc_())
            {
                DataType ezzu_ = condition?.Onset;
                object ezzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzu_);
                CqlInterval<CqlDateTime> ezzw_ = this.toInterval(context, ezzv_);
                CqlDateTime ezzx_ = context.Operators.Start(ezzw_);
                CqlInterval<CqlDateTime> ezzy_ = this.abatementInterval(context, condition);
                CqlDateTime ezzz_ = context.Operators.End(ezzy_);
                CqlInterval<CqlDateTime> fzza_ = context.Operators.Interval(ezzx_, ezzz_, true, true);

                return fzza_;
            }
            else
            {
                CqlInterval<CqlDateTime> fzzb_ = this.abatementInterval(context, condition);
                CqlDateTime fzzc_ = context.Operators.End(fzzb_);
                CqlDateTime[] fzzd_ = [
                    fzzc_,
                ];
                CqlInterval<CqlDateTime> fzze_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> fzzi_()
                    {
                        if (abatementDate is null)
                        {
                            DataType fzzj_ = condition?.Onset;
                            object fzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzj_);
                            CqlInterval<CqlDateTime> fzzl_ = this.toInterval(context, fzzk_);
                            CqlDateTime fzzm_ = context.Operators.Start(fzzl_);
                            CqlInterval<CqlDateTime> fzzn_ = context.Operators.Interval(fzzm_, abatementDate, true, false);

                            return fzzn_;
                        }
                        else
                        {
                            DataType fzzo_ = condition?.Onset;
                            object fzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzo_);
                            CqlInterval<CqlDateTime> fzzq_ = this.toInterval(context, fzzp_);
                            CqlDateTime fzzr_ = context.Operators.Start(fzzq_);
                            CqlInterval<CqlDateTime> fzzs_ = context.Operators.Interval(fzzr_, abatementDate, true, true);

                            return fzzs_;
                        }
                    };

                    return fzzi_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzf_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)fzzd_, fzze_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzf_);
                CqlInterval<CqlDateTime> fzzh_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(fzzg_);

                return fzzh_;
            }
        };

        return ezzb_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> fzzt_ = context.Operators.Split(uri, "/");
        string fzzu_ = context.Operators.Last<string>(fzzt_);

        return fzzu_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> fzzv_ = context.Operators.Split(uri, "/");
        string fzzw_ = context.Operators.Last<string>(fzzv_);

        return fzzw_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime fzzx_ = context.Operators.Start(period);
        CqlDateTime fzzz_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzza_ = context.Operators.Equal(fzzx_, fzzz_);
        bool? gzzb_ = context.Operators.Or((bool?)(fzzx_ is null), gzza_);
        bool? gzzc_ = context.Operators.Not(gzzb_);

        return gzzc_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzd_ = context.Operators.Start(period);
        CqlDateTime gzzf_ = context.Operators.MinValue<CqlDateTime>();
        bool? gzzg_ = context.Operators.Equal(gzzd_, gzzf_);
        bool? gzzh_ = context.Operators.Or((bool?)(gzzd_ is null), gzzg_);
        bool? gzzi_ = context.Operators.Not(gzzh_);

        return gzzi_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzj_ = context.Operators.End(period);
        CqlDateTime gzzl_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzm_ = context.Operators.Equal(gzzj_, gzzl_);
        bool? gzzn_ = context.Operators.Or((bool?)(gzzj_ is null), gzzm_);
        bool? gzzo_ = context.Operators.Not(gzzn_);

        return gzzo_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime gzzp_ = context.Operators.End(period);
        CqlDateTime gzzr_ = context.Operators.MaxValue<CqlDateTime>();
        bool? gzzs_ = context.Operators.Equal(gzzp_, gzzr_);
        bool? gzzt_ = context.Operators.Or((bool?)(gzzp_ is null), gzzs_);
        bool? gzzu_ = context.Operators.Not(gzzt_);

        return gzzu_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> gzzv_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] gzzw_ = [
            gzzv_,
        ];
        CqlDateTime gzzx_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzb_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzc_ = context.Operators.End(period);

                    return hzzc_;
                }
                else
                {
                    CqlDateTime hzzd_ = context.Operators.Start(period);

                    return hzzd_;
                }
            };

            return hzzb_();
        };
        IEnumerable<CqlDateTime> gzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)gzzw_, gzzx_);
        IEnumerable<CqlDateTime> gzzz_ = context.Operators.Distinct<CqlDateTime>(gzzy_);
        CqlDateTime hzza_ = context.Operators.SingletonFrom<CqlDateTime>(gzzz_);

        return hzza_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzze_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzf_ = [
            hzze_,
        ];
        CqlDateTime hzzg_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzk_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime hzzl_ = context.Operators.End(period);

                    return hzzl_;
                }
                else
                {
                    CqlDateTime hzzm_ = context.Operators.Start(period);

                    return hzzm_;
                }
            };

            return hzzk_();
        };
        IEnumerable<CqlDateTime> hzzh_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzf_, hzzg_);
        IEnumerable<CqlDateTime> hzzi_ = context.Operators.Distinct<CqlDateTime>(hzzh_);
        CqlDateTime hzzj_ = context.Operators.SingletonFrom<CqlDateTime>(hzzi_);

        return hzzj_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzn_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzo_ = [
            hzzn_,
        ];
        CqlDateTime hzzp_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime hzzt_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime hzzu_ = context.Operators.Start(period);

                    return hzzu_;
                }
                else
                {
                    CqlDateTime hzzv_ = context.Operators.End(period);

                    return hzzv_;
                }
            };

            return hzzt_();
        };
        IEnumerable<CqlDateTime> hzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzo_, hzzp_);
        IEnumerable<CqlDateTime> hzzr_ = context.Operators.Distinct<CqlDateTime>(hzzq_);
        CqlDateTime hzzs_ = context.Operators.SingletonFrom<CqlDateTime>(hzzr_);

        return hzzs_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzw_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] hzzx_ = [
            hzzw_,
        ];
        CqlDateTime hzzy_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime izzc_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime izzd_ = context.Operators.Start(period);

                    return izzd_;
                }
                else
                {
                    CqlDateTime izze_ = context.Operators.End(period);

                    return izze_;
                }
            };

            return izzc_();
        };
        IEnumerable<CqlDateTime> hzzz_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)hzzx_, hzzy_);
        IEnumerable<CqlDateTime> izza_ = context.Operators.Distinct<CqlDateTime>(hzzz_);
        CqlDateTime izzb_ = context.Operators.SingletonFrom<CqlDateTime>(izza_);

        return izzb_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzf_ = context.Operators.Start(Period);
        CqlDateTime izzg_ = context.Operators.End(Period);
        int? izzh_ = context.Operators.DurationBetween(izzf_, izzg_, "day");
        CqlInterval<int?> izzi_ = context.Operators.Interval(1, izzh_, true, true);
        CqlInterval<int?>[] izzj_ = [
            izzi_,
        ];
        IEnumerable<CqlInterval<int?>> izzk_ = context.Operators.Expand(izzj_ as IEnumerable<CqlInterval<int?>>, default);
        int? izzl_(CqlInterval<int?> DayNumber)
        {
            int? izzo_ = context.Operators.End(DayNumber);

            return izzo_;
        };
        IEnumerable<int?> izzm_ = context.Operators.Select<CqlInterval<int?>, int?>(izzk_, izzl_);
        IEnumerable<int?> izzn_ = context.Operators.Distinct<int?>(izzm_);

        return izzn_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
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


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> izzz_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzza_(int? DayIndex)
        {
            CqlDateTime jzzd_ = context.Operators.Start(Period);
            CqlQuantity jzze_ = context.Operators.Quantity(24m, "hours");
            int? jzzf_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity jzzg_ = context.Operators.ConvertIntegerToQuantity(jzzf_);
            CqlQuantity jzzh_ = context.Operators.Multiply(jzze_, jzzg_);
            CqlDateTime jzzi_ = context.Operators.Add(jzzd_, jzzh_);
            CqlDateTime jzzj_()
            {
                bool jzzm_()
                {
                    CqlDateTime jzzn_ = context.Operators.Start(Period);
                    CqlQuantity jzzo_ = context.Operators.Quantity(24m, "hours");
                    int? jzzp_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzq_ = context.Operators.ConvertIntegerToQuantity(jzzp_);
                    CqlQuantity jzzr_ = context.Operators.Multiply(jzzo_, jzzq_);
                    CqlDateTime jzzs_ = context.Operators.Add(jzzn_, jzzr_);
                    CqlDateTime jzzt_ = context.Operators.End(Period);
                    int? jzzu_ = context.Operators.DurationBetween(jzzs_, jzzt_, "hour");
                    bool? jzzv_ = context.Operators.Less(jzzu_, 24);

                    return jzzv_ ?? false;
                };
                if (jzzm_())
                {
                    CqlDateTime jzzw_ = context.Operators.Start(Period);
                    CqlQuantity jzzx_ = context.Operators.Quantity(24m, "hours");
                    int? jzzy_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity jzzz_ = context.Operators.ConvertIntegerToQuantity(jzzy_);
                    CqlQuantity kzza_ = context.Operators.Multiply(jzzx_, jzzz_);
                    CqlDateTime kzzb_ = context.Operators.Add(jzzw_, kzza_);

                    return kzzb_;
                }
                else
                {
                    CqlDateTime kzzc_ = context.Operators.Start(Period);
                    CqlQuantity kzzd_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzze_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity kzzf_ = context.Operators.Multiply(kzzd_, kzze_);
                    CqlDateTime kzzg_ = context.Operators.Add(kzzc_, kzzf_);

                    return kzzg_;
                }
            };
            CqlInterval<CqlDateTime> jzzk_ = context.Operators.Interval(jzzi_, jzzj_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? jzzl_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, jzzk_);

            return jzzl_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzb_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(izzz_, jzza_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> jzzc_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(jzzb_);

        return jzzc_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> kzzh_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzi_(int? DayIndex)
        {
            CqlDateTime kzzl_ = context.Operators.Start(Period);
            CqlQuantity kzzm_ = context.Operators.Quantity(24m, "hours");
            int? kzzn_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity kzzo_ = context.Operators.ConvertIntegerToQuantity(kzzn_);
            CqlQuantity kzzp_ = context.Operators.Multiply(kzzm_, kzzo_);
            CqlDateTime kzzq_ = context.Operators.Add(kzzl_, kzzp_);
            CqlDateTime kzzr_()
            {
                bool kzzu_()
                {
                    CqlDateTime kzzv_ = context.Operators.Start(Period);
                    CqlQuantity kzzw_ = context.Operators.Quantity(24m, "hours");
                    int? kzzx_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity kzzy_ = context.Operators.ConvertIntegerToQuantity(kzzx_);
                    CqlQuantity kzzz_ = context.Operators.Multiply(kzzw_, kzzy_);
                    CqlDateTime lzza_ = context.Operators.Add(kzzv_, kzzz_);
                    CqlDateTime lzzb_ = context.Operators.End(Period);
                    int? lzzc_ = context.Operators.DurationBetween(lzza_, lzzb_, "hour");
                    bool? lzzd_ = context.Operators.Less(lzzc_, 24);

                    return lzzd_ ?? false;
                };
                if (kzzu_())
                {
                    CqlDateTime lzze_ = context.Operators.Start(Period);
                    CqlQuantity lzzf_ = context.Operators.Quantity(24m, "hours");
                    int? lzzg_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity lzzh_ = context.Operators.ConvertIntegerToQuantity(lzzg_);
                    CqlQuantity lzzi_ = context.Operators.Multiply(lzzf_, lzzh_);
                    CqlDateTime lzzj_ = context.Operators.Add(lzze_, lzzi_);

                    return lzzj_;
                }
                else
                {
                    CqlDateTime lzzk_ = context.Operators.Start(Period);
                    CqlQuantity lzzl_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity lzzm_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity lzzn_ = context.Operators.Multiply(lzzl_, lzzm_);
                    CqlDateTime lzzo_ = context.Operators.Add(lzzk_, lzzn_);

                    return lzzo_;
                }
            };
            CqlInterval<CqlDateTime> kzzs_ = context.Operators.Interval(kzzq_, kzzr_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? kzzt_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, kzzs_);

            return kzzt_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzj_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzh_, kzzi_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> kzzk_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(kzzj_);

        return kzzk_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
