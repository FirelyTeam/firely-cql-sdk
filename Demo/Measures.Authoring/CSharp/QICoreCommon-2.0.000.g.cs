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
        IEnumerable<Patient> mzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzj_ = context.Operators.SingletonFrom<Patient>(mzi_);

        return mzj_;
    }


    [CqlExpressionDefinition("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept mzk_ = condition?.ClinicalStatus;
        CqlConcept mzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, mzk_);
        CqlCode mzm_ = this.active(context);
        CqlConcept mzn_ = context.Operators.ConvertCodeToConcept(mzm_);
        bool? mzo_ = context.Operators.Equivalent(mzl_, mzn_);
        CqlConcept mzq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, mzk_);
        CqlCode mzr_ = this.recurrence(context);
        CqlConcept mzs_ = context.Operators.ConvertCodeToConcept(mzr_);
        bool? mzt_ = context.Operators.Equivalent(mzq_, mzs_);
        bool? mzu_ = context.Operators.Or(mzo_, mzt_);
        CqlConcept mzw_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, mzk_);
        CqlCode mzx_ = this.relapse(context);
        CqlConcept mzy_ = context.Operators.ConvertCodeToConcept(mzx_);
        bool? mzz_ = context.Operators.Equivalent(mzw_, mzy_);
        bool? nza_ = context.Operators.Or(mzu_, mzz_);

        return nza_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> nzb_ = condition?.Category;
        CqlConcept nzc_(CodeableConcept @this)
        {
            CqlConcept nzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return nzh_;
        };
        IEnumerable<CqlConcept> nzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzb_, nzc_);
        bool? nze_(CqlConcept C)
        {
            CqlConcept nzi_ = context.Operators.ConvertCodeToConcept(category);
            bool? nzj_ = context.Operators.Equivalent(C, nzi_);

            return nzj_;
        };
        IEnumerable<CqlConcept> nzf_ = context.Operators.Where<CqlConcept>(nzd_, nze_);
        bool? nzg_ = context.Operators.Exists<CqlConcept>(nzf_);

        return nzg_;
    }


    [CqlExpressionDefinition("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> nzk_ = observation?.Category;
        CqlConcept nzl_(CodeableConcept @this)
        {
            CqlConcept nzq_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return nzq_;
        };
        IEnumerable<CqlConcept> nzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzk_, nzl_);
        bool? nzn_(CqlConcept C)
        {
            CqlConcept nzr_ = context.Operators.ConvertCodeToConcept(category);
            bool? nzs_ = context.Operators.Equivalent(C, nzr_);

            return nzs_;
        };
        IEnumerable<CqlConcept> nzo_ = context.Operators.Where<CqlConcept>(nzm_, nzn_);
        bool? nzp_ = context.Operators.Exists<CqlConcept>(nzo_);

        return nzp_;
    }


    [CqlExpressionDefinition("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> nzt_ = condition?.Category;
        CqlConcept nzu_(CodeableConcept @this)
        {
            CqlConcept nzz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return nzz_;
        };
        IEnumerable<CqlConcept> nzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzt_, nzu_);
        bool? nzw_(CqlConcept C)
        {
            CqlCode oza_ = this.problem_list_item(context);
            CqlConcept ozb_ = context.Operators.ConvertCodeToConcept(oza_);
            bool? ozc_ = context.Operators.Equivalent(C, ozb_);

            return ozc_;
        };
        IEnumerable<CqlConcept> nzx_ = context.Operators.Where<CqlConcept>(nzv_, nzw_);
        bool? nzy_ = context.Operators.Exists<CqlConcept>(nzx_);

        return nzy_;
    }


    [CqlExpressionDefinition("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> ozd_ = condition?.Category;
        CqlConcept oze_(CodeableConcept @this)
        {
            CqlConcept ozj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return ozj_;
        };
        IEnumerable<CqlConcept> ozf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozd_, oze_);
        bool? ozg_(CqlConcept C)
        {
            CqlCode ozk_ = this.encounter_diagnosis(context);
            CqlConcept ozl_ = context.Operators.ConvertCodeToConcept(ozk_);
            bool? ozm_ = context.Operators.Equivalent(C, ozl_);

            return ozm_;
        };
        IEnumerable<CqlConcept> ozh_ = context.Operators.Where<CqlConcept>(ozf_, ozg_);
        bool? ozi_ = context.Operators.Exists<CqlConcept>(ozh_);

        return ozi_;
    }


    [CqlExpressionDefinition("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> ozn_ = condition?.Category;
        CqlConcept ozo_(CodeableConcept @this)
        {
            CqlConcept ozt_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return ozt_;
        };
        IEnumerable<CqlConcept> ozp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozn_, ozo_);
        bool? ozq_(CqlConcept C)
        {
            CqlCode ozu_ = this.health_concern(context);
            CqlConcept ozv_ = context.Operators.ConvertCodeToConcept(ozu_);
            bool? ozw_ = context.Operators.Equivalent(C, ozv_);

            return ozw_;
        };
        IEnumerable<CqlConcept> ozr_ = context.Operators.Where<CqlConcept>(ozp_, ozq_);
        bool? ozs_ = context.Operators.Exists<CqlConcept>(ozr_);

        return ozs_;
    }


    [CqlExpressionDefinition("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> ozx_ = observation?.Category;
        CqlConcept ozy_(CodeableConcept @this)
        {
            CqlConcept pzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return pzd_;
        };
        IEnumerable<CqlConcept> ozz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozx_, ozy_);
        bool? pza_(CqlConcept C)
        {
            CqlCode pze_ = this.social_history(context);
            CqlConcept pzf_ = context.Operators.ConvertCodeToConcept(pze_);
            bool? pzg_ = context.Operators.Equivalent(C, pzf_);

            return pzg_;
        };
        IEnumerable<CqlConcept> pzb_ = context.Operators.Where<CqlConcept>(ozz_, pza_);
        bool? pzc_ = context.Operators.Exists<CqlConcept>(pzb_);

        return pzc_;
    }


    [CqlExpressionDefinition("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> pzh_ = observation?.Category;
        CqlConcept pzi_(CodeableConcept @this)
        {
            CqlConcept pzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return pzn_;
        };
        IEnumerable<CqlConcept> pzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzh_, pzi_);
        bool? pzk_(CqlConcept C)
        {
            CqlCode pzo_ = this.vital_signs(context);
            CqlConcept pzp_ = context.Operators.ConvertCodeToConcept(pzo_);
            bool? pzq_ = context.Operators.Equivalent(C, pzp_);

            return pzq_;
        };
        IEnumerable<CqlConcept> pzl_ = context.Operators.Where<CqlConcept>(pzj_, pzk_);
        bool? pzm_ = context.Operators.Exists<CqlConcept>(pzl_);

        return pzm_;
    }


    [CqlExpressionDefinition("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> pzr_ = observation?.Category;
        CqlConcept pzs_(CodeableConcept @this)
        {
            CqlConcept pzx_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return pzx_;
        };
        IEnumerable<CqlConcept> pzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)pzr_, pzs_);
        bool? pzu_(CqlConcept C)
        {
            CqlCode pzy_ = this.imaging(context);
            CqlConcept pzz_ = context.Operators.ConvertCodeToConcept(pzy_);
            bool? qza_ = context.Operators.Equivalent(C, pzz_);

            return qza_;
        };
        IEnumerable<CqlConcept> pzv_ = context.Operators.Where<CqlConcept>(pzt_, pzu_);
        bool? pzw_ = context.Operators.Exists<CqlConcept>(pzv_);

        return pzw_;
    }


    [CqlExpressionDefinition("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> qzb_ = observation?.Category;
        CqlConcept qzc_(CodeableConcept @this)
        {
            CqlConcept qzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return qzh_;
        };
        IEnumerable<CqlConcept> qzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzb_, qzc_);
        bool? qze_(CqlConcept C)
        {
            CqlCode qzi_ = this.laboratory(context);
            CqlConcept qzj_ = context.Operators.ConvertCodeToConcept(qzi_);
            bool? qzk_ = context.Operators.Equivalent(C, qzj_);

            return qzk_;
        };
        IEnumerable<CqlConcept> qzf_ = context.Operators.Where<CqlConcept>(qzd_, qze_);
        bool? qzg_ = context.Operators.Exists<CqlConcept>(qzf_);

        return qzg_;
    }


    [CqlExpressionDefinition("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> qzl_ = observation?.Category;
        CqlConcept qzm_(CodeableConcept @this)
        {
            CqlConcept qzr_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return qzr_;
        };
        IEnumerable<CqlConcept> qzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzl_, qzm_);
        bool? qzo_(CqlConcept C)
        {
            CqlCode qzs_ = this.procedure(context);
            CqlConcept qzt_ = context.Operators.ConvertCodeToConcept(qzs_);
            bool? qzu_ = context.Operators.Equivalent(C, qzt_);

            return qzu_;
        };
        IEnumerable<CqlConcept> qzp_ = context.Operators.Where<CqlConcept>(qzn_, qzo_);
        bool? qzq_ = context.Operators.Exists<CqlConcept>(qzp_);

        return qzq_;
    }


    [CqlExpressionDefinition("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> qzv_ = observation?.Category;
        CqlConcept qzw_(CodeableConcept @this)
        {
            CqlConcept rzb_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return rzb_;
        };
        IEnumerable<CqlConcept> qzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzv_, qzw_);
        bool? qzy_(CqlConcept C)
        {
            CqlCode rzc_ = this.survey(context);
            CqlConcept rzd_ = context.Operators.ConvertCodeToConcept(rzc_);
            bool? rze_ = context.Operators.Equivalent(C, rzd_);

            return rze_;
        };
        IEnumerable<CqlConcept> qzz_ = context.Operators.Where<CqlConcept>(qzx_, qzy_);
        bool? rza_ = context.Operators.Exists<CqlConcept>(qzz_);

        return rza_;
    }


    [CqlExpressionDefinition("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> rzf_ = observation?.Category;
        CqlConcept rzg_(CodeableConcept @this)
        {
            CqlConcept rzl_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return rzl_;
        };
        IEnumerable<CqlConcept> rzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzf_, rzg_);
        bool? rzi_(CqlConcept C)
        {
            CqlCode rzm_ = this.exam(context);
            CqlConcept rzn_ = context.Operators.ConvertCodeToConcept(rzm_);
            bool? rzo_ = context.Operators.Equivalent(C, rzn_);

            return rzo_;
        };
        IEnumerable<CqlConcept> rzj_ = context.Operators.Where<CqlConcept>(rzh_, rzi_);
        bool? rzk_ = context.Operators.Exists<CqlConcept>(rzj_);

        return rzk_;
    }


    [CqlExpressionDefinition("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> rzp_ = observation?.Category;
        CqlConcept rzq_(CodeableConcept @this)
        {
            CqlConcept rzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return rzv_;
        };
        IEnumerable<CqlConcept> rzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzp_, rzq_);
        bool? rzs_(CqlConcept C)
        {
            CqlCode rzw_ = this.therapy(context);
            CqlConcept rzx_ = context.Operators.ConvertCodeToConcept(rzw_);
            bool? rzy_ = context.Operators.Equivalent(C, rzx_);

            return rzy_;
        };
        IEnumerable<CqlConcept> rzt_ = context.Operators.Where<CqlConcept>(rzr_, rzs_);
        bool? rzu_ = context.Operators.Exists<CqlConcept>(rzt_);

        return rzu_;
    }


    [CqlExpressionDefinition("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> rzz_ = observation?.Category;
        CqlConcept sza_(CodeableConcept @this)
        {
            CqlConcept szf_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return szf_;
        };
        IEnumerable<CqlConcept> szb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzz_, sza_);
        bool? szc_(CqlConcept C)
        {
            CqlCode szg_ = this.activity(context);
            CqlConcept szh_ = context.Operators.ConvertCodeToConcept(szg_);
            bool? szi_ = context.Operators.Equivalent(C, szh_);

            return szi_;
        };
        IEnumerable<CqlConcept> szd_ = context.Operators.Where<CqlConcept>(szb_, szc_);
        bool? sze_ = context.Operators.Exists<CqlConcept>(szd_);

        return sze_;
    }


    [CqlExpressionDefinition("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> szj_ = observation?.Category;
        CqlConcept szk_(CodeableConcept @this)
        {
            CqlConcept szp_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return szp_;
        };
        IEnumerable<CqlConcept> szl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szj_, szk_);
        bool? szm_(CqlConcept C)
        {
            CqlCode szq_ = this.clinical_test(context);
            CqlConcept szr_ = context.Operators.ConvertCodeToConcept(szq_);
            bool? szs_ = context.Operators.Equivalent(C, szr_);

            return szs_;
        };
        IEnumerable<CqlConcept> szn_ = context.Operators.Where<CqlConcept>(szl_, szm_);
        bool? szo_ = context.Operators.Exists<CqlConcept>(szn_);

        return szo_;
    }


    [CqlExpressionDefinition("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> szt_ = medicationRequest?.Category;
        CqlConcept szu_(CodeableConcept @this)
        {
            CqlConcept szz_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return szz_;
        };
        IEnumerable<CqlConcept> szv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szt_, szu_);
        bool? szw_(CqlConcept C)
        {
            CqlCode tza_ = this.Community(context);
            CqlConcept tzb_ = context.Operators.ConvertCodeToConcept(tza_);
            bool? tzc_ = context.Operators.Equivalent(C, tzb_);

            return tzc_;
        };
        IEnumerable<CqlConcept> szx_ = context.Operators.Where<CqlConcept>(szv_, szw_);
        bool? szy_ = context.Operators.Exists<CqlConcept>(szx_);

        return szy_;
    }


    [CqlExpressionDefinition("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> tzd_ = medicationRequest?.Category;
        CqlConcept tze_(CodeableConcept @this)
        {
            CqlConcept tzj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return tzj_;
        };
        IEnumerable<CqlConcept> tzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzd_, tze_);
        bool? tzg_(CqlConcept C)
        {
            CqlCode tzk_ = this.Discharge(context);
            CqlConcept tzl_ = context.Operators.ConvertCodeToConcept(tzk_);
            bool? tzm_ = context.Operators.Equivalent(C, tzl_);

            return tzm_;
        };
        IEnumerable<CqlConcept> tzh_ = context.Operators.Where<CqlConcept>(tzf_, tzg_);
        bool? tzi_ = context.Operators.Exists<CqlConcept>(tzh_);

        return tzi_;
    }


    [CqlExpressionDefinition("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? tzn_(Extension E)
        {
            string tzt_ = E?.Url;
            FhirString tzu_ = context.Operators.Convert<FhirString>(tzt_);
            string tzv_ = tzu_?.Value;
            bool? tzw_ = context.Operators.Equal(tzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return tzw_;
        };
        IEnumerable<Extension> tzo_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), tzn_);
        bool? tzp_(Extension E)
        {
            DataType tzx_ = E?.Value;
            object tzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzx_);

            return tzy_ as bool?;
        };
        IEnumerable<bool?> tzq_ = context.Operators.Select<Extension, bool?>(tzo_, tzp_);
        IEnumerable<bool?> tzr_ = context.Operators.Distinct<bool?>(tzq_);
        bool? tzs_ = context.Operators.SingletonFrom<bool?>(tzr_);

        return tzs_;
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> tzz_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> uza_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return uza_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient uzb_ = this.Patient(context);
                Date uzc_ = uzb_?.BirthDateElement;
                string uzd_ = uzc_?.Value;
                CqlDate uze_ = context.Operators.ConvertStringToDate(uzd_);
                CqlDate uzf_ = context.Operators.Add(uze_, choice as CqlQuantity);
                Date uzh_ = uzb_?.BirthDateElement;
                string uzi_ = uzh_?.Value;
                CqlDate uzj_ = context.Operators.ConvertStringToDate(uzi_);
                CqlDate uzk_ = context.Operators.Add(uzj_, choice as CqlQuantity);
                CqlQuantity uzl_ = context.Operators.Quantity(1m, "year");
                CqlDate uzm_ = context.Operators.Add(uzk_, uzl_);
                CqlInterval<CqlDate> uzn_ = context.Operators.Interval(uzf_, uzm_, true, false);
                CqlDate uzo_ = uzn_?.low;
                CqlDateTime uzp_ = context.Operators.ConvertDateToDateTime(uzo_);
                Date uzr_ = uzb_?.BirthDateElement;
                string uzs_ = uzr_?.Value;
                CqlDate uzt_ = context.Operators.ConvertStringToDate(uzs_);
                CqlDate uzu_ = context.Operators.Add(uzt_, choice as CqlQuantity);
                Date uzw_ = uzb_?.BirthDateElement;
                string uzx_ = uzw_?.Value;
                CqlDate uzy_ = context.Operators.ConvertStringToDate(uzx_);
                CqlDate uzz_ = context.Operators.Add(uzy_, choice as CqlQuantity);
                CqlDate vzb_ = context.Operators.Add(uzz_, uzl_);
                CqlInterval<CqlDate> vzc_ = context.Operators.Interval(uzu_, vzb_, true, false);
                CqlDate vzd_ = vzc_?.high;
                CqlDateTime vze_ = context.Operators.ConvertDateToDateTime(vzd_);
                Date vzg_ = uzb_?.BirthDateElement;
                string vzh_ = vzg_?.Value;
                CqlDate vzi_ = context.Operators.ConvertStringToDate(vzh_);
                CqlDate vzj_ = context.Operators.Add(vzi_, choice as CqlQuantity);
                Date vzl_ = uzb_?.BirthDateElement;
                string vzm_ = vzl_?.Value;
                CqlDate vzn_ = context.Operators.ConvertStringToDate(vzm_);
                CqlDate vzo_ = context.Operators.Add(vzn_, choice as CqlQuantity);
                CqlDate vzq_ = context.Operators.Add(vzo_, uzl_);
                CqlInterval<CqlDate> vzr_ = context.Operators.Interval(vzj_, vzq_, true, false);
                bool? vzs_ = vzr_?.lowClosed;
                Date vzu_ = uzb_?.BirthDateElement;
                string vzv_ = vzu_?.Value;
                CqlDate vzw_ = context.Operators.ConvertStringToDate(vzv_);
                CqlDate vzx_ = context.Operators.Add(vzw_, choice as CqlQuantity);
                Date vzz_ = uzb_?.BirthDateElement;
                string wza_ = vzz_?.Value;
                CqlDate wzb_ = context.Operators.ConvertStringToDate(wza_);
                CqlDate wzc_ = context.Operators.Add(wzb_, choice as CqlQuantity);
                CqlDate wze_ = context.Operators.Add(wzc_, uzl_);
                CqlInterval<CqlDate> wzf_ = context.Operators.Interval(vzx_, wze_, true, false);
                bool? wzg_ = wzf_?.highClosed;
                CqlInterval<CqlDateTime> wzh_ = context.Operators.Interval(uzp_, vze_, vzs_, wzg_);

                return wzh_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient wzi_ = this.Patient(context);
                Date wzj_ = wzi_?.BirthDateElement;
                string wzk_ = wzj_?.Value;
                CqlDate wzl_ = context.Operators.ConvertStringToDate(wzk_);
                object wzm_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate wzn_ = context.Operators.Add(wzl_, wzm_ as CqlQuantity);
                Date wzp_ = wzi_?.BirthDateElement;
                string wzq_ = wzp_?.Value;
                CqlDate wzr_ = context.Operators.ConvertStringToDate(wzq_);
                object wzs_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate wzt_ = context.Operators.Add(wzr_, wzs_ as CqlQuantity);
                CqlQuantity wzu_ = context.Operators.Quantity(1m, "year");
                CqlDate wzv_ = context.Operators.Add(wzt_, wzu_);
                CqlInterval<CqlDate> wzw_ = context.Operators.Interval(wzn_, wzv_, true, false);
                CqlDate wzx_ = wzw_?.low;
                CqlDateTime wzy_ = context.Operators.ConvertDateToDateTime(wzx_);
                Date xza_ = wzi_?.BirthDateElement;
                string xzb_ = xza_?.Value;
                CqlDate xzc_ = context.Operators.ConvertStringToDate(xzb_);
                CqlDate xze_ = context.Operators.Add(xzc_, wzm_ as CqlQuantity);
                Date xzg_ = wzi_?.BirthDateElement;
                string xzh_ = xzg_?.Value;
                CqlDate xzi_ = context.Operators.ConvertStringToDate(xzh_);
                CqlDate xzk_ = context.Operators.Add(xzi_, wzs_ as CqlQuantity);
                CqlDate xzm_ = context.Operators.Add(xzk_, wzu_);
                CqlInterval<CqlDate> xzn_ = context.Operators.Interval(xze_, xzm_, true, false);
                CqlDate xzo_ = xzn_?.high;
                CqlDateTime xzp_ = context.Operators.ConvertDateToDateTime(xzo_);
                Date xzr_ = wzi_?.BirthDateElement;
                string xzs_ = xzr_?.Value;
                CqlDate xzt_ = context.Operators.ConvertStringToDate(xzs_);
                CqlDate xzv_ = context.Operators.Add(xzt_, wzm_ as CqlQuantity);
                Date xzx_ = wzi_?.BirthDateElement;
                string xzy_ = xzx_?.Value;
                CqlDate xzz_ = context.Operators.ConvertStringToDate(xzy_);
                CqlDate yzb_ = context.Operators.Add(xzz_, wzs_ as CqlQuantity);
                CqlDate yzd_ = context.Operators.Add(yzb_, wzu_);
                CqlInterval<CqlDate> yze_ = context.Operators.Interval(xzv_, yzd_, true, false);
                bool? yzf_ = yze_?.lowClosed;
                Date yzh_ = wzi_?.BirthDateElement;
                string yzi_ = yzh_?.Value;
                CqlDate yzj_ = context.Operators.ConvertStringToDate(yzi_);
                CqlDate yzl_ = context.Operators.Add(yzj_, wzm_ as CqlQuantity);
                Date yzn_ = wzi_?.BirthDateElement;
                string yzo_ = yzn_?.Value;
                CqlDate yzp_ = context.Operators.ConvertStringToDate(yzo_);
                CqlDate yzr_ = context.Operators.Add(yzp_, wzs_ as CqlQuantity);
                CqlDate yzt_ = context.Operators.Add(yzr_, wzu_);
                CqlInterval<CqlDate> yzu_ = context.Operators.Interval(yzl_, yzt_, true, false);
                bool? yzv_ = yzu_?.highClosed;
                CqlInterval<CqlDateTime> yzw_ = context.Operators.Interval(wzy_, xzp_, yzf_, yzv_);

                return yzw_;
            }
            else if (choice is Timing)
            {
                object yzx_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return yzx_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return tzz_();
    }


    [CqlExpressionDefinition("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types\nto an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible\nrepresentations for timing-valued elements in QICore, allowing this function to be used across any resource.\nThe input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>.\nThe intent of this function is to provide a clear and concise mechanism to treat single\nelements that have multiple possible representations as intervals so that logic doesn't have to account\nfor the variability. More complex calculations (such as medication request period or dispense period\ncalculation) need specific guidance and consideration. That guidance may make use of this function, but\nthe focus of this function is on single element calculations where the semantics are unambiguous.\nIf the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime.\nIf the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age,\nand the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later.\nIf the input is a DateTime Interval, the result is the input.\nIf the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result\nis a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending\nimmediately before one year later than the date the patient turned the age given as the end of the quantity interval.\nIf the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzy_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> yzz_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return yzz_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient zza_ = this.Patient(context);
                Date zzb_ = zza_?.BirthDateElement;
                string zzc_ = zzb_?.Value;
                CqlDate zzd_ = context.Operators.ConvertStringToDate(zzc_);
                CqlDate zze_ = context.Operators.Add(zzd_, choice as CqlQuantity);
                Date zzg_ = zza_?.BirthDateElement;
                string zzh_ = zzg_?.Value;
                CqlDate zzi_ = context.Operators.ConvertStringToDate(zzh_);
                CqlDate zzj_ = context.Operators.Add(zzi_, choice as CqlQuantity);
                CqlQuantity zzk_ = context.Operators.Quantity(1m, "year");
                CqlDate zzl_ = context.Operators.Add(zzj_, zzk_);
                CqlInterval<CqlDate> zzm_ = context.Operators.Interval(zze_, zzl_, true, false);
                CqlDate zzn_ = zzm_?.low;
                CqlDateTime zzo_ = context.Operators.ConvertDateToDateTime(zzn_);
                Date zzq_ = zza_?.BirthDateElement;
                string zzr_ = zzq_?.Value;
                CqlDate zzs_ = context.Operators.ConvertStringToDate(zzr_);
                CqlDate zzt_ = context.Operators.Add(zzs_, choice as CqlQuantity);
                Date zzv_ = zza_?.BirthDateElement;
                string zzw_ = zzv_?.Value;
                CqlDate zzx_ = context.Operators.ConvertStringToDate(zzw_);
                CqlDate zzy_ = context.Operators.Add(zzx_, choice as CqlQuantity);
                CqlDate azza_ = context.Operators.Add(zzy_, zzk_);
                CqlInterval<CqlDate> azzb_ = context.Operators.Interval(zzt_, azza_, true, false);
                CqlDate azzc_ = azzb_?.high;
                CqlDateTime azzd_ = context.Operators.ConvertDateToDateTime(azzc_);
                Date azzf_ = zza_?.BirthDateElement;
                string azzg_ = azzf_?.Value;
                CqlDate azzh_ = context.Operators.ConvertStringToDate(azzg_);
                CqlDate azzi_ = context.Operators.Add(azzh_, choice as CqlQuantity);
                Date azzk_ = zza_?.BirthDateElement;
                string azzl_ = azzk_?.Value;
                CqlDate azzm_ = context.Operators.ConvertStringToDate(azzl_);
                CqlDate azzn_ = context.Operators.Add(azzm_, choice as CqlQuantity);
                CqlDate azzp_ = context.Operators.Add(azzn_, zzk_);
                CqlInterval<CqlDate> azzq_ = context.Operators.Interval(azzi_, azzp_, true, false);
                bool? azzr_ = azzq_?.lowClosed;
                Date azzt_ = zza_?.BirthDateElement;
                string azzu_ = azzt_?.Value;
                CqlDate azzv_ = context.Operators.ConvertStringToDate(azzu_);
                CqlDate azzw_ = context.Operators.Add(azzv_, choice as CqlQuantity);
                Date azzy_ = zza_?.BirthDateElement;
                string azzz_ = azzy_?.Value;
                CqlDate bzza_ = context.Operators.ConvertStringToDate(azzz_);
                CqlDate bzzb_ = context.Operators.Add(bzza_, choice as CqlQuantity);
                CqlDate bzzd_ = context.Operators.Add(bzzb_, zzk_);
                CqlInterval<CqlDate> bzze_ = context.Operators.Interval(azzw_, bzzd_, true, false);
                bool? bzzf_ = bzze_?.highClosed;
                CqlInterval<CqlDateTime> bzzg_ = context.Operators.Interval(zzo_, azzd_, azzr_, bzzf_);

                return bzzg_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient bzzh_ = this.Patient(context);
                Date bzzi_ = bzzh_?.BirthDateElement;
                string bzzj_ = bzzi_?.Value;
                CqlDate bzzk_ = context.Operators.ConvertStringToDate(bzzj_);
                object bzzl_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate bzzm_ = context.Operators.Add(bzzk_, bzzl_ as CqlQuantity);
                Date bzzo_ = bzzh_?.BirthDateElement;
                string bzzp_ = bzzo_?.Value;
                CqlDate bzzq_ = context.Operators.ConvertStringToDate(bzzp_);
                object bzzr_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate bzzs_ = context.Operators.Add(bzzq_, bzzr_ as CqlQuantity);
                CqlQuantity bzzt_ = context.Operators.Quantity(1m, "year");
                CqlDate bzzu_ = context.Operators.Add(bzzs_, bzzt_);
                CqlInterval<CqlDate> bzzv_ = context.Operators.Interval(bzzm_, bzzu_, true, false);
                CqlDate bzzw_ = bzzv_?.low;
                CqlDateTime bzzx_ = context.Operators.ConvertDateToDateTime(bzzw_);
                Date bzzz_ = bzzh_?.BirthDateElement;
                string czza_ = bzzz_?.Value;
                CqlDate czzb_ = context.Operators.ConvertStringToDate(czza_);
                CqlDate czzd_ = context.Operators.Add(czzb_, bzzl_ as CqlQuantity);
                Date czzf_ = bzzh_?.BirthDateElement;
                string czzg_ = czzf_?.Value;
                CqlDate czzh_ = context.Operators.ConvertStringToDate(czzg_);
                CqlDate czzj_ = context.Operators.Add(czzh_, bzzr_ as CqlQuantity);
                CqlDate czzl_ = context.Operators.Add(czzj_, bzzt_);
                CqlInterval<CqlDate> czzm_ = context.Operators.Interval(czzd_, czzl_, true, false);
                CqlDate czzn_ = czzm_?.high;
                CqlDateTime czzo_ = context.Operators.ConvertDateToDateTime(czzn_);
                Date czzq_ = bzzh_?.BirthDateElement;
                string czzr_ = czzq_?.Value;
                CqlDate czzs_ = context.Operators.ConvertStringToDate(czzr_);
                CqlDate czzu_ = context.Operators.Add(czzs_, bzzl_ as CqlQuantity);
                Date czzw_ = bzzh_?.BirthDateElement;
                string czzx_ = czzw_?.Value;
                CqlDate czzy_ = context.Operators.ConvertStringToDate(czzx_);
                CqlDate dzza_ = context.Operators.Add(czzy_, bzzr_ as CqlQuantity);
                CqlDate dzzc_ = context.Operators.Add(dzza_, bzzt_);
                CqlInterval<CqlDate> dzzd_ = context.Operators.Interval(czzu_, dzzc_, true, false);
                bool? dzze_ = dzzd_?.lowClosed;
                Date dzzg_ = bzzh_?.BirthDateElement;
                string dzzh_ = dzzg_?.Value;
                CqlDate dzzi_ = context.Operators.ConvertStringToDate(dzzh_);
                CqlDate dzzk_ = context.Operators.Add(dzzi_, bzzl_ as CqlQuantity);
                Date dzzm_ = bzzh_?.BirthDateElement;
                string dzzn_ = dzzm_?.Value;
                CqlDate dzzo_ = context.Operators.ConvertStringToDate(dzzn_);
                CqlDate dzzq_ = context.Operators.Add(dzzo_, bzzr_ as CqlQuantity);
                CqlDate dzzs_ = context.Operators.Add(dzzq_, bzzt_);
                CqlInterval<CqlDate> dzzt_ = context.Operators.Interval(dzzk_, dzzs_, true, false);
                bool? dzzu_ = dzzt_?.highClosed;
                CqlInterval<CqlDateTime> dzzv_ = context.Operators.Interval(bzzx_, czzo_, dzze_, dzzu_);

                return dzzv_;
            }
            else if (choice is Timing)
            {
                object dzzw_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return dzzw_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return yzy_();
    }


    [CqlExpressionDefinition("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> dzzx_()
        {
            bool dzzy_()
            {
                DataType ezzc_ = condition?.Abatement;
                object ezzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzc_);
                bool ezze_ = ezzd_ is CqlDateTime;

                return ezze_;
            };
            bool dzzz_()
            {
                DataType ezzf_ = condition?.Abatement;
                object ezzg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzf_);
                bool ezzh_ = ezzg_ is CqlQuantity;

                return ezzh_;
            };
            bool ezza_()
            {
                DataType ezzi_ = condition?.Abatement;
                object ezzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzi_);
                bool ezzk_ = ezzj_ is CqlInterval<CqlQuantity>;

                return ezzk_;
            };
            bool ezzb_()
            {
                DataType ezzl_ = condition?.Abatement;
                object ezzm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzl_);
                bool ezzn_ = ezzm_ is CqlInterval<CqlDateTime>;

                return ezzn_;
            };
            if (dzzy_())
            {
                DataType ezzo_ = condition?.Abatement;
                object ezzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzo_);
                object ezzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzo_);
                CqlInterval<CqlDateTime> ezzs_ = context.Operators.Interval(ezzp_ as CqlDateTime, ezzr_ as CqlDateTime, true, true);

                return ezzs_;
            }
            else if (dzzz_())
            {
                Patient ezzt_ = this.Patient(context);
                Date ezzu_ = ezzt_?.BirthDateElement;
                string ezzv_ = ezzu_?.Value;
                CqlDate ezzw_ = context.Operators.ConvertStringToDate(ezzv_);
                DataType ezzx_ = condition?.Abatement;
                object ezzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate ezzz_ = context.Operators.Add(ezzw_, ezzy_ as CqlQuantity);
                Date fzzb_ = ezzt_?.BirthDateElement;
                string fzzc_ = fzzb_?.Value;
                CqlDate fzzd_ = context.Operators.ConvertStringToDate(fzzc_);
                object fzzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate fzzg_ = context.Operators.Add(fzzd_, fzzf_ as CqlQuantity);
                CqlQuantity fzzh_ = context.Operators.Quantity(1m, "year");
                CqlDate fzzi_ = context.Operators.Add(fzzg_, fzzh_);
                CqlInterval<CqlDate> fzzj_ = context.Operators.Interval(ezzz_, fzzi_, true, false);
                CqlDate fzzk_ = fzzj_?.low;
                CqlDateTime fzzl_ = context.Operators.ConvertDateToDateTime(fzzk_);
                Date fzzn_ = ezzt_?.BirthDateElement;
                string fzzo_ = fzzn_?.Value;
                CqlDate fzzp_ = context.Operators.ConvertStringToDate(fzzo_);
                object fzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate fzzs_ = context.Operators.Add(fzzp_, fzzr_ as CqlQuantity);
                Date fzzu_ = ezzt_?.BirthDateElement;
                string fzzv_ = fzzu_?.Value;
                CqlDate fzzw_ = context.Operators.ConvertStringToDate(fzzv_);
                object fzzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate fzzz_ = context.Operators.Add(fzzw_, fzzy_ as CqlQuantity);
                CqlDate gzzb_ = context.Operators.Add(fzzz_, fzzh_);
                CqlInterval<CqlDate> gzzc_ = context.Operators.Interval(fzzs_, gzzb_, true, false);
                CqlDate gzzd_ = gzzc_?.high;
                CqlDateTime gzze_ = context.Operators.ConvertDateToDateTime(gzzd_);
                Date gzzg_ = ezzt_?.BirthDateElement;
                string gzzh_ = gzzg_?.Value;
                CqlDate gzzi_ = context.Operators.ConvertStringToDate(gzzh_);
                object gzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate gzzl_ = context.Operators.Add(gzzi_, gzzk_ as CqlQuantity);
                Date gzzn_ = ezzt_?.BirthDateElement;
                string gzzo_ = gzzn_?.Value;
                CqlDate gzzp_ = context.Operators.ConvertStringToDate(gzzo_);
                object gzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate gzzs_ = context.Operators.Add(gzzp_, gzzr_ as CqlQuantity);
                CqlDate gzzu_ = context.Operators.Add(gzzs_, fzzh_);
                CqlInterval<CqlDate> gzzv_ = context.Operators.Interval(gzzl_, gzzu_, true, false);
                bool? gzzw_ = gzzv_?.lowClosed;
                Date gzzy_ = ezzt_?.BirthDateElement;
                string gzzz_ = gzzy_?.Value;
                CqlDate hzza_ = context.Operators.ConvertStringToDate(gzzz_);
                object hzzc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate hzzd_ = context.Operators.Add(hzza_, hzzc_ as CqlQuantity);
                Date hzzf_ = ezzt_?.BirthDateElement;
                string hzzg_ = hzzf_?.Value;
                CqlDate hzzh_ = context.Operators.ConvertStringToDate(hzzg_);
                object hzzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ezzx_);
                CqlDate hzzk_ = context.Operators.Add(hzzh_, hzzj_ as CqlQuantity);
                CqlDate hzzm_ = context.Operators.Add(hzzk_, fzzh_);
                CqlInterval<CqlDate> hzzn_ = context.Operators.Interval(hzzd_, hzzm_, true, false);
                bool? hzzo_ = hzzn_?.highClosed;
                CqlInterval<CqlDateTime> hzzp_ = context.Operators.Interval(fzzl_, gzze_, gzzw_, hzzo_);

                return hzzp_;
            }
            else if (ezza_())
            {
                Patient hzzq_ = this.Patient(context);
                Date hzzr_ = hzzq_?.BirthDateElement;
                string hzzs_ = hzzr_?.Value;
                CqlDate hzzt_ = context.Operators.ConvertStringToDate(hzzs_);
                DataType hzzu_ = condition?.Abatement;
                object hzzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object hzzw_ = context.Operators.LateBoundProperty<object>(hzzv_, "low");
                CqlDate hzzx_ = context.Operators.Add(hzzt_, hzzw_ as CqlQuantity);
                Date hzzz_ = hzzq_?.BirthDateElement;
                string izza_ = hzzz_?.Value;
                CqlDate izzb_ = context.Operators.ConvertStringToDate(izza_);
                object izzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object izze_ = context.Operators.LateBoundProperty<object>(izzd_, "high");
                CqlDate izzf_ = context.Operators.Add(izzb_, izze_ as CqlQuantity);
                CqlQuantity izzg_ = context.Operators.Quantity(1m, "year");
                CqlDate izzh_ = context.Operators.Add(izzf_, izzg_);
                CqlInterval<CqlDate> izzi_ = context.Operators.Interval(hzzx_, izzh_, true, false);
                CqlDate izzj_ = izzi_?.low;
                CqlDateTime izzk_ = context.Operators.ConvertDateToDateTime(izzj_);
                Date izzm_ = hzzq_?.BirthDateElement;
                string izzn_ = izzm_?.Value;
                CqlDate izzo_ = context.Operators.ConvertStringToDate(izzn_);
                object izzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object izzr_ = context.Operators.LateBoundProperty<object>(izzq_, "low");
                CqlDate izzs_ = context.Operators.Add(izzo_, izzr_ as CqlQuantity);
                Date izzu_ = hzzq_?.BirthDateElement;
                string izzv_ = izzu_?.Value;
                CqlDate izzw_ = context.Operators.ConvertStringToDate(izzv_);
                object izzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object izzz_ = context.Operators.LateBoundProperty<object>(izzy_, "high");
                CqlDate jzza_ = context.Operators.Add(izzw_, izzz_ as CqlQuantity);
                CqlDate jzzc_ = context.Operators.Add(jzza_, izzg_);
                CqlInterval<CqlDate> jzzd_ = context.Operators.Interval(izzs_, jzzc_, true, false);
                CqlDate jzze_ = jzzd_?.high;
                CqlDateTime jzzf_ = context.Operators.ConvertDateToDateTime(jzze_);
                Date jzzh_ = hzzq_?.BirthDateElement;
                string jzzi_ = jzzh_?.Value;
                CqlDate jzzj_ = context.Operators.ConvertStringToDate(jzzi_);
                object jzzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object jzzm_ = context.Operators.LateBoundProperty<object>(jzzl_, "low");
                CqlDate jzzn_ = context.Operators.Add(jzzj_, jzzm_ as CqlQuantity);
                Date jzzp_ = hzzq_?.BirthDateElement;
                string jzzq_ = jzzp_?.Value;
                CqlDate jzzr_ = context.Operators.ConvertStringToDate(jzzq_);
                object jzzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object jzzu_ = context.Operators.LateBoundProperty<object>(jzzt_, "high");
                CqlDate jzzv_ = context.Operators.Add(jzzr_, jzzu_ as CqlQuantity);
                CqlDate jzzx_ = context.Operators.Add(jzzv_, izzg_);
                CqlInterval<CqlDate> jzzy_ = context.Operators.Interval(jzzn_, jzzx_, true, false);
                bool? jzzz_ = jzzy_?.lowClosed;
                Date kzzb_ = hzzq_?.BirthDateElement;
                string kzzc_ = kzzb_?.Value;
                CqlDate kzzd_ = context.Operators.ConvertStringToDate(kzzc_);
                object kzzf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object kzzg_ = context.Operators.LateBoundProperty<object>(kzzf_, "low");
                CqlDate kzzh_ = context.Operators.Add(kzzd_, kzzg_ as CqlQuantity);
                Date kzzj_ = hzzq_?.BirthDateElement;
                string kzzk_ = kzzj_?.Value;
                CqlDate kzzl_ = context.Operators.ConvertStringToDate(kzzk_);
                object kzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, hzzu_);
                object kzzo_ = context.Operators.LateBoundProperty<object>(kzzn_, "high");
                CqlDate kzzp_ = context.Operators.Add(kzzl_, kzzo_ as CqlQuantity);
                CqlDate kzzr_ = context.Operators.Add(kzzp_, izzg_);
                CqlInterval<CqlDate> kzzs_ = context.Operators.Interval(kzzh_, kzzr_, true, false);
                bool? kzzt_ = kzzs_?.highClosed;
                CqlInterval<CqlDateTime> kzzu_ = context.Operators.Interval(izzk_, jzzf_, jzzz_, kzzt_);

                return kzzu_;
            }
            else if (ezzb_())
            {
                DataType kzzv_ = condition?.Abatement;
                object kzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, kzzv_);
                object kzzx_ = context.Operators.LateBoundProperty<object>(kzzw_, "low");
                object kzzz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, kzzv_);
                object lzza_ = context.Operators.LateBoundProperty<object>(kzzz_, "high");
                CqlInterval<CqlDateTime> lzzb_ = context.Operators.Interval(kzzx_ as CqlDateTime, lzza_ as CqlDateTime, true, false);

                return lzzb_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return dzzx_();
    }


    [CqlExpressionDefinition("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result\nis an interval beginning and ending on that DateTime.\nIf the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The\nresult is an interval from the date the patient turned that age to immediately before one year later.\nIf the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during\nwhich the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately\nbefore one year later than the date the patient turned the ending age of the quantity interval.")]
    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> lzzc_()
        {
            bool lzzd_()
            {
                DataType lzzh_ = condition?.Abatement;
                object lzzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzh_);
                bool lzzj_ = lzzi_ is CqlDateTime;

                return lzzj_;
            };
            bool lzze_()
            {
                DataType lzzk_ = condition?.Abatement;
                object lzzl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzk_);
                bool lzzm_ = lzzl_ is CqlQuantity;

                return lzzm_;
            };
            bool lzzf_()
            {
                DataType lzzn_ = condition?.Abatement;
                object lzzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzn_);
                bool lzzp_ = lzzo_ is CqlInterval<CqlQuantity>;

                return lzzp_;
            };
            bool lzzg_()
            {
                DataType lzzq_ = condition?.Abatement;
                object lzzr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzq_);
                bool lzzs_ = lzzr_ is CqlInterval<CqlDateTime>;

                return lzzs_;
            };
            if (lzzd_())
            {
                DataType lzzt_ = condition?.Abatement;
                object lzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzt_);
                object lzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, lzzt_);
                CqlInterval<CqlDateTime> lzzx_ = context.Operators.Interval(lzzu_ as CqlDateTime, lzzw_ as CqlDateTime, true, true);

                return lzzx_;
            }
            else if (lzze_())
            {
                Patient lzzy_ = this.Patient(context);
                Date lzzz_ = lzzy_?.BirthDateElement;
                string mzza_ = lzzz_?.Value;
                CqlDate mzzb_ = context.Operators.ConvertStringToDate(mzza_);
                DataType mzzc_ = condition?.Abatement;
                object mzzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate mzze_ = context.Operators.Add(mzzb_, mzzd_ as CqlQuantity);
                Date mzzg_ = lzzy_?.BirthDateElement;
                string mzzh_ = mzzg_?.Value;
                CqlDate mzzi_ = context.Operators.ConvertStringToDate(mzzh_);
                object mzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate mzzl_ = context.Operators.Add(mzzi_, mzzk_ as CqlQuantity);
                CqlQuantity mzzm_ = context.Operators.Quantity(1m, "year");
                CqlDate mzzn_ = context.Operators.Add(mzzl_, mzzm_);
                CqlInterval<CqlDate> mzzo_ = context.Operators.Interval(mzze_, mzzn_, true, false);
                CqlDate mzzp_ = mzzo_?.low;
                CqlDateTime mzzq_ = context.Operators.ConvertDateToDateTime(mzzp_);
                Date mzzs_ = lzzy_?.BirthDateElement;
                string mzzt_ = mzzs_?.Value;
                CqlDate mzzu_ = context.Operators.ConvertStringToDate(mzzt_);
                object mzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate mzzx_ = context.Operators.Add(mzzu_, mzzw_ as CqlQuantity);
                Date mzzz_ = lzzy_?.BirthDateElement;
                string nzza_ = mzzz_?.Value;
                CqlDate nzzb_ = context.Operators.ConvertStringToDate(nzza_);
                object nzzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate nzze_ = context.Operators.Add(nzzb_, nzzd_ as CqlQuantity);
                CqlDate nzzg_ = context.Operators.Add(nzze_, mzzm_);
                CqlInterval<CqlDate> nzzh_ = context.Operators.Interval(mzzx_, nzzg_, true, false);
                CqlDate nzzi_ = nzzh_?.high;
                CqlDateTime nzzj_ = context.Operators.ConvertDateToDateTime(nzzi_);
                Date nzzl_ = lzzy_?.BirthDateElement;
                string nzzm_ = nzzl_?.Value;
                CqlDate nzzn_ = context.Operators.ConvertStringToDate(nzzm_);
                object nzzp_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate nzzq_ = context.Operators.Add(nzzn_, nzzp_ as CqlQuantity);
                Date nzzs_ = lzzy_?.BirthDateElement;
                string nzzt_ = nzzs_?.Value;
                CqlDate nzzu_ = context.Operators.ConvertStringToDate(nzzt_);
                object nzzw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate nzzx_ = context.Operators.Add(nzzu_, nzzw_ as CqlQuantity);
                CqlDate nzzz_ = context.Operators.Add(nzzx_, mzzm_);
                CqlInterval<CqlDate> ozza_ = context.Operators.Interval(nzzq_, nzzz_, true, false);
                bool? ozzb_ = ozza_?.lowClosed;
                Date ozzd_ = lzzy_?.BirthDateElement;
                string ozze_ = ozzd_?.Value;
                CqlDate ozzf_ = context.Operators.ConvertStringToDate(ozze_);
                object ozzh_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate ozzi_ = context.Operators.Add(ozzf_, ozzh_ as CqlQuantity);
                Date ozzk_ = lzzy_?.BirthDateElement;
                string ozzl_ = ozzk_?.Value;
                CqlDate ozzm_ = context.Operators.ConvertStringToDate(ozzl_);
                object ozzo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, mzzc_);
                CqlDate ozzp_ = context.Operators.Add(ozzm_, ozzo_ as CqlQuantity);
                CqlDate ozzr_ = context.Operators.Add(ozzp_, mzzm_);
                CqlInterval<CqlDate> ozzs_ = context.Operators.Interval(ozzi_, ozzr_, true, false);
                bool? ozzt_ = ozzs_?.highClosed;
                CqlInterval<CqlDateTime> ozzu_ = context.Operators.Interval(mzzq_, nzzj_, ozzb_, ozzt_);

                return ozzu_;
            }
            else if (lzzf_())
            {
                Patient ozzv_ = this.Patient(context);
                Date ozzw_ = ozzv_?.BirthDateElement;
                string ozzx_ = ozzw_?.Value;
                CqlDate ozzy_ = context.Operators.ConvertStringToDate(ozzx_);
                DataType ozzz_ = condition?.Abatement;
                object pzza_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object pzzb_ = context.Operators.LateBoundProperty<object>(pzza_, "low");
                CqlDate pzzc_ = context.Operators.Add(ozzy_, pzzb_ as CqlQuantity);
                Date pzze_ = ozzv_?.BirthDateElement;
                string pzzf_ = pzze_?.Value;
                CqlDate pzzg_ = context.Operators.ConvertStringToDate(pzzf_);
                object pzzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object pzzj_ = context.Operators.LateBoundProperty<object>(pzzi_, "high");
                CqlDate pzzk_ = context.Operators.Add(pzzg_, pzzj_ as CqlQuantity);
                CqlQuantity pzzl_ = context.Operators.Quantity(1m, "year");
                CqlDate pzzm_ = context.Operators.Add(pzzk_, pzzl_);
                CqlInterval<CqlDate> pzzn_ = context.Operators.Interval(pzzc_, pzzm_, true, false);
                CqlDate pzzo_ = pzzn_?.low;
                CqlDateTime pzzp_ = context.Operators.ConvertDateToDateTime(pzzo_);
                Date pzzr_ = ozzv_?.BirthDateElement;
                string pzzs_ = pzzr_?.Value;
                CqlDate pzzt_ = context.Operators.ConvertStringToDate(pzzs_);
                object pzzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object pzzw_ = context.Operators.LateBoundProperty<object>(pzzv_, "low");
                CqlDate pzzx_ = context.Operators.Add(pzzt_, pzzw_ as CqlQuantity);
                Date pzzz_ = ozzv_?.BirthDateElement;
                string qzza_ = pzzz_?.Value;
                CqlDate qzzb_ = context.Operators.ConvertStringToDate(qzza_);
                object qzzd_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object qzze_ = context.Operators.LateBoundProperty<object>(qzzd_, "high");
                CqlDate qzzf_ = context.Operators.Add(qzzb_, qzze_ as CqlQuantity);
                CqlDate qzzh_ = context.Operators.Add(qzzf_, pzzl_);
                CqlInterval<CqlDate> qzzi_ = context.Operators.Interval(pzzx_, qzzh_, true, false);
                CqlDate qzzj_ = qzzi_?.high;
                CqlDateTime qzzk_ = context.Operators.ConvertDateToDateTime(qzzj_);
                Date qzzm_ = ozzv_?.BirthDateElement;
                string qzzn_ = qzzm_?.Value;
                CqlDate qzzo_ = context.Operators.ConvertStringToDate(qzzn_);
                object qzzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object qzzr_ = context.Operators.LateBoundProperty<object>(qzzq_, "low");
                CqlDate qzzs_ = context.Operators.Add(qzzo_, qzzr_ as CqlQuantity);
                Date qzzu_ = ozzv_?.BirthDateElement;
                string qzzv_ = qzzu_?.Value;
                CqlDate qzzw_ = context.Operators.ConvertStringToDate(qzzv_);
                object qzzy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object qzzz_ = context.Operators.LateBoundProperty<object>(qzzy_, "high");
                CqlDate rzza_ = context.Operators.Add(qzzw_, qzzz_ as CqlQuantity);
                CqlDate rzzc_ = context.Operators.Add(rzza_, pzzl_);
                CqlInterval<CqlDate> rzzd_ = context.Operators.Interval(qzzs_, rzzc_, true, false);
                bool? rzze_ = rzzd_?.lowClosed;
                Date rzzg_ = ozzv_?.BirthDateElement;
                string rzzh_ = rzzg_?.Value;
                CqlDate rzzi_ = context.Operators.ConvertStringToDate(rzzh_);
                object rzzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object rzzl_ = context.Operators.LateBoundProperty<object>(rzzk_, "low");
                CqlDate rzzm_ = context.Operators.Add(rzzi_, rzzl_ as CqlQuantity);
                Date rzzo_ = ozzv_?.BirthDateElement;
                string rzzp_ = rzzo_?.Value;
                CqlDate rzzq_ = context.Operators.ConvertStringToDate(rzzp_);
                object rzzs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ozzz_);
                object rzzt_ = context.Operators.LateBoundProperty<object>(rzzs_, "high");
                CqlDate rzzu_ = context.Operators.Add(rzzq_, rzzt_ as CqlQuantity);
                CqlDate rzzw_ = context.Operators.Add(rzzu_, pzzl_);
                CqlInterval<CqlDate> rzzx_ = context.Operators.Interval(rzzm_, rzzw_, true, false);
                bool? rzzy_ = rzzx_?.highClosed;
                CqlInterval<CqlDateTime> rzzz_ = context.Operators.Interval(pzzp_, qzzk_, rzze_, rzzy_);

                return rzzz_;
            }
            else if (lzzg_())
            {
                DataType szza_ = condition?.Abatement;
                object szzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szza_);
                object szzc_ = context.Operators.LateBoundProperty<object>(szzb_, "low");
                object szze_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szza_);
                object szzf_ = context.Operators.LateBoundProperty<object>(szze_, "high");
                CqlInterval<CqlDateTime> szzg_ = context.Operators.Interval(szzc_ as CqlDateTime, szzf_ as CqlDateTime, true, false);

                return szzg_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return lzzc_();
    }


    [CqlExpressionDefinition("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> szzh_()
        {
            bool szzi_()
            {
                CodeableConcept szzj_ = condition?.ClinicalStatus;
                CqlConcept szzk_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, szzj_);
                CqlCode szzl_ = this.active(context);
                CqlConcept szzm_ = context.Operators.ConvertCodeToConcept(szzl_);
                bool? szzn_ = context.Operators.Equivalent(szzk_, szzm_);
                CqlConcept szzp_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, szzj_);
                CqlCode szzq_ = this.recurrence(context);
                CqlConcept szzr_ = context.Operators.ConvertCodeToConcept(szzq_);
                bool? szzs_ = context.Operators.Equivalent(szzp_, szzr_);
                bool? szzt_ = context.Operators.Or(szzn_, szzs_);
                CqlConcept szzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, szzj_);
                CqlCode szzw_ = this.relapse(context);
                CqlConcept szzx_ = context.Operators.ConvertCodeToConcept(szzw_);
                bool? szzy_ = context.Operators.Equivalent(szzv_, szzx_);
                bool? szzz_ = context.Operators.Or(szzt_, szzy_);

                return szzz_ ?? false;
            };
            if (szzi_())
            {
                DataType tzza_ = condition?.Onset;
                object tzzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzza_);
                CqlInterval<CqlDateTime> tzzc_ = this.ToInterval(context, tzzb_);
                CqlDateTime tzzd_ = context.Operators.Start(tzzc_);
                CqlInterval<CqlDateTime> tzze_ = this.ToAbatementInterval(context, condition);
                CqlDateTime tzzf_ = context.Operators.End(tzze_);
                CqlInterval<CqlDateTime> tzzg_ = context.Operators.Interval(tzzd_, tzzf_, true, true);

                return tzzg_;
            }
            else
            {
                CqlInterval<CqlDateTime> tzzh_ = this.ToAbatementInterval(context, condition);
                CqlDateTime tzzi_ = context.Operators.End(tzzh_);
                CqlDateTime[] tzzj_ = [
                    tzzi_,
                ];
                CqlInterval<CqlDateTime> tzzk_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> tzzo_()
                    {
                        if (abatementDate is null)
                        {
                            DataType tzzp_ = condition?.Onset;
                            object tzzq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzp_);
                            CqlInterval<CqlDateTime> tzzr_ = this.ToInterval(context, tzzq_);
                            CqlDateTime tzzs_ = context.Operators.Start(tzzr_);
                            CqlInterval<CqlDateTime> tzzt_ = context.Operators.Interval(tzzs_, abatementDate, true, false);

                            return tzzt_;
                        }
                        else
                        {
                            DataType tzzu_ = condition?.Onset;
                            object tzzv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, tzzu_);
                            CqlInterval<CqlDateTime> tzzw_ = this.ToInterval(context, tzzv_);
                            CqlDateTime tzzx_ = context.Operators.Start(tzzw_);
                            CqlInterval<CqlDateTime> tzzy_ = context.Operators.Interval(tzzx_, abatementDate, true, true);

                            return tzzy_;
                        }
                    };

                    return tzzo_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> tzzl_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)tzzj_, tzzk_);
                IEnumerable<CqlInterval<CqlDateTime>> tzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzl_);
                CqlInterval<CqlDateTime> tzzn_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(tzzm_);

                return tzzn_;
            }
        };

        return szzh_();
    }


    [CqlExpressionDefinition("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from\nonset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting \ninterval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> tzzz_()
        {
            bool uzza_()
            {
                CodeableConcept uzzb_ = condition?.ClinicalStatus;
                CqlConcept uzzc_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzzb_);
                CqlCode uzzd_ = this.active(context);
                CqlConcept uzze_ = context.Operators.ConvertCodeToConcept(uzzd_);
                bool? uzzf_ = context.Operators.Equivalent(uzzc_, uzze_);
                CqlConcept uzzh_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzzb_);
                CqlCode uzzi_ = this.recurrence(context);
                CqlConcept uzzj_ = context.Operators.ConvertCodeToConcept(uzzi_);
                bool? uzzk_ = context.Operators.Equivalent(uzzh_, uzzj_);
                bool? uzzl_ = context.Operators.Or(uzzf_, uzzk_);
                CqlConcept uzzn_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, uzzb_);
                CqlCode uzzo_ = this.relapse(context);
                CqlConcept uzzp_ = context.Operators.ConvertCodeToConcept(uzzo_);
                bool? uzzq_ = context.Operators.Equivalent(uzzn_, uzzp_);
                bool? uzzr_ = context.Operators.Or(uzzl_, uzzq_);

                return uzzr_ ?? false;
            };
            if (uzza_())
            {
                DataType uzzs_ = condition?.Onset;
                object uzzt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, uzzs_);
                CqlInterval<CqlDateTime> uzzu_ = this.toInterval(context, uzzt_);
                CqlDateTime uzzv_ = context.Operators.Start(uzzu_);
                CqlInterval<CqlDateTime> uzzw_ = this.abatementInterval(context, condition);
                CqlDateTime uzzx_ = context.Operators.End(uzzw_);
                CqlInterval<CqlDateTime> uzzy_ = context.Operators.Interval(uzzv_, uzzx_, true, true);

                return uzzy_;
            }
            else
            {
                CqlInterval<CqlDateTime> uzzz_ = this.ToAbatementInterval(context, condition);
                CqlDateTime vzza_ = context.Operators.End(uzzz_);
                CqlDateTime[] vzzb_ = [
                    vzza_,
                ];
                CqlInterval<CqlDateTime> vzzc_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> vzzg_()
                    {
                        if (abatementDate is null)
                        {
                            DataType vzzh_ = condition?.Onset;
                            object vzzi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzzh_);
                            CqlInterval<CqlDateTime> vzzj_ = this.ToInterval(context, vzzi_);
                            CqlDateTime vzzk_ = context.Operators.Start(vzzj_);
                            CqlInterval<CqlDateTime> vzzl_ = context.Operators.Interval(vzzk_, abatementDate, true, false);

                            return vzzl_;
                        }
                        else
                        {
                            DataType vzzm_ = condition?.Onset;
                            object vzzn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, vzzm_);
                            CqlInterval<CqlDateTime> vzzo_ = this.ToInterval(context, vzzn_);
                            CqlDateTime vzzp_ = context.Operators.Start(vzzo_);
                            CqlInterval<CqlDateTime> vzzq_ = context.Operators.Interval(vzzp_, abatementDate, true, true);

                            return vzzq_;
                        }
                    };

                    return vzzg_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> vzzd_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)vzzb_, vzzc_);
                IEnumerable<CqlInterval<CqlDateTime>> vzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzd_);
                CqlInterval<CqlDateTime> vzzf_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(vzze_);

                return vzzf_;
            }
        };

        return tzzz_();
    }


    [CqlExpressionDefinition("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> vzzr_ = context.Operators.Split(uri, "/");
        string vzzs_ = context.Operators.Last<string>(vzzr_);

        return vzzs_;
    }


    [CqlExpressionDefinition("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in\na single-server environment to trace references. However, this function does not attempt to resolve\nor distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> vzzt_ = context.Operators.Split(uri, "/");
        string vzzu_ = context.Operators.Last<string>(vzzt_);

        return vzzu_;
    }


    [CqlExpressionDefinition("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime vzzv_ = context.Operators.Start(period);
        CqlDateTime vzzx_ = context.Operators.MinValue<CqlDateTime>();
        bool? vzzy_ = context.Operators.Equal(vzzv_, vzzx_);
        bool? vzzz_ = context.Operators.Or((bool?)(vzzv_ is null), vzzy_);
        bool? wzza_ = context.Operators.Not(vzzz_);

        return wzza_;
    }


    [CqlExpressionDefinition("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified\n(i.e. the start of the interval is not null and not the minimum DateTime value)")]
    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime wzzb_ = context.Operators.Start(period);
        CqlDateTime wzzd_ = context.Operators.MinValue<CqlDateTime>();
        bool? wzze_ = context.Operators.Equal(wzzb_, wzzd_);
        bool? wzzf_ = context.Operators.Or((bool?)(wzzb_ is null), wzze_);
        bool? wzzg_ = context.Operators.Not(wzzf_);

        return wzzg_;
    }


    [CqlExpressionDefinition("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime wzzh_ = context.Operators.End(period);
        CqlDateTime wzzj_ = context.Operators.MaxValue<CqlDateTime>();
        bool? wzzk_ = context.Operators.Equal(wzzh_, wzzj_);
        bool? wzzl_ = context.Operators.Or((bool?)(wzzh_ is null), wzzk_);
        bool? wzzm_ = context.Operators.Not(wzzl_);

        return wzzm_;
    }


    [CqlExpressionDefinition("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified\n(i.e. the end of the interval is not null and not the maximum DateTime value)")]
    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime wzzn_ = context.Operators.End(period);
        CqlDateTime wzzp_ = context.Operators.MaxValue<CqlDateTime>();
        bool? wzzq_ = context.Operators.Equal(wzzn_, wzzp_);
        bool? wzzr_ = context.Operators.Or((bool?)(wzzn_ is null), wzzq_);
        bool? wzzs_ = context.Operators.Not(wzzr_);

        return wzzs_;
    }


    [CqlExpressionDefinition("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> wzzt_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] wzzu_ = [
            wzzt_,
        ];
        CqlDateTime wzzv_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime wzzz_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime xzza_ = context.Operators.End(period);

                    return xzza_;
                }
                else
                {
                    CqlDateTime xzzb_ = context.Operators.Start(period);

                    return xzzb_;
                }
            };

            return wzzz_();
        };
        IEnumerable<CqlDateTime> wzzw_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)wzzu_, wzzv_);
        IEnumerable<CqlDateTime> wzzx_ = context.Operators.Distinct<CqlDateTime>(wzzw_);
        CqlDateTime wzzy_ = context.Operators.SingletonFrom<CqlDateTime>(wzzx_);

        return wzzy_;
    }


    [CqlExpressionDefinition("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified,\notherwise, returns the starting point")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> xzzc_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] xzzd_ = [
            xzzc_,
        ];
        CqlDateTime xzze_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime xzzi_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime xzzj_ = context.Operators.End(period);

                    return xzzj_;
                }
                else
                {
                    CqlDateTime xzzk_ = context.Operators.Start(period);

                    return xzzk_;
                }
            };

            return xzzi_();
        };
        IEnumerable<CqlDateTime> xzzf_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)xzzd_, xzze_);
        IEnumerable<CqlDateTime> xzzg_ = context.Operators.Distinct<CqlDateTime>(xzzf_);
        CqlDateTime xzzh_ = context.Operators.SingletonFrom<CqlDateTime>(xzzg_);

        return xzzh_;
    }


    [CqlExpressionDefinition("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> xzzl_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] xzzm_ = [
            xzzl_,
        ];
        CqlDateTime xzzn_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime xzzr_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime xzzs_ = context.Operators.Start(period);

                    return xzzs_;
                }
                else
                {
                    CqlDateTime xzzt_ = context.Operators.End(period);

                    return xzzt_;
                }
            };

            return xzzr_();
        };
        IEnumerable<CqlDateTime> xzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)xzzm_, xzzn_);
        IEnumerable<CqlDateTime> xzzp_ = context.Operators.Distinct<CqlDateTime>(xzzo_);
        CqlDateTime xzzq_ = context.Operators.SingletonFrom<CqlDateTime>(xzzp_);

        return xzzq_;
    }


    [CqlExpressionDefinition("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified,\notherwise, return the ending point")]
    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> xzzu_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] xzzv_ = [
            xzzu_,
        ];
        CqlDateTime xzzw_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime yzza_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime yzzb_ = context.Operators.Start(period);

                    return yzzb_;
                }
                else
                {
                    CqlDateTime yzzc_ = context.Operators.End(period);

                    return yzzc_;
                }
            };

            return yzza_();
        };
        IEnumerable<CqlDateTime> xzzx_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)xzzv_, xzzw_);
        IEnumerable<CqlDateTime> xzzy_ = context.Operators.Distinct<CqlDateTime>(xzzx_);
        CqlDateTime xzzz_ = context.Operators.SingletonFrom<CqlDateTime>(xzzy_);

        return xzzz_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime yzzd_ = context.Operators.Start(Period);
        CqlDateTime yzze_ = context.Operators.End(Period);
        int? yzzf_ = context.Operators.DurationBetween(yzzd_, yzze_, "day");
        CqlInterval<int?> yzzg_ = context.Operators.Interval(1, yzzf_, true, true);
        CqlInterval<int?>[] yzzh_ = [
            yzzg_,
        ];
        IEnumerable<CqlInterval<int?>> yzzi_ = context.Operators.Expand(yzzh_ as IEnumerable<CqlInterval<int?>>, default);
        int? yzzj_(CqlInterval<int?> DayNumber)
        {
            int? yzzm_ = context.Operators.End(DayNumber);

            return yzzm_;
        };
        IEnumerable<int?> yzzk_ = context.Operators.Select<CqlInterval<int?>, int?>(yzzi_, yzzj_);
        IEnumerable<int?> yzzl_ = context.Operators.Distinct<int?>(yzzk_);

        return yzzl_;
    }


    [CqlExpressionDefinition("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for\nthe final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime yzzn_ = context.Operators.Start(Period);
        CqlDateTime yzzo_ = context.Operators.End(Period);
        int? yzzp_ = context.Operators.DurationBetween(yzzn_, yzzo_, "day");
        CqlInterval<int?> yzzq_ = context.Operators.Interval(1, yzzp_, true, true);
        CqlInterval<int?>[] yzzr_ = [
            yzzq_,
        ];
        IEnumerable<CqlInterval<int?>> yzzs_ = context.Operators.Expand(yzzr_ as IEnumerable<CqlInterval<int?>>, default);
        int? yzzt_(CqlInterval<int?> DayNumber)
        {
            int? yzzw_ = context.Operators.End(DayNumber);

            return yzzw_;
        };
        IEnumerable<int?> yzzu_ = context.Operators.Select<CqlInterval<int?>, int?>(yzzs_, yzzt_);
        IEnumerable<int?> yzzv_ = context.Operators.Distinct<int?>(yzzu_);

        return yzzv_;
    }


    [CqlExpressionDefinition("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> yzzx_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? yzzy_(int? DayIndex)
        {
            CqlDateTime zzzb_ = context.Operators.Start(Period);
            CqlQuantity zzzc_ = context.Operators.Quantity(24m, "hours");
            int? zzzd_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity zzze_ = context.Operators.ConvertIntegerToQuantity(zzzd_);
            CqlQuantity zzzf_ = context.Operators.Multiply(zzzc_, zzze_);
            CqlDateTime zzzg_ = context.Operators.Add(zzzb_, zzzf_);
            CqlDateTime zzzh_()
            {
                bool zzzk_()
                {
                    CqlDateTime zzzl_ = context.Operators.Start(Period);
                    CqlQuantity zzzm_ = context.Operators.Quantity(24m, "hours");
                    int? zzzn_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity zzzo_ = context.Operators.ConvertIntegerToQuantity(zzzn_);
                    CqlQuantity zzzp_ = context.Operators.Multiply(zzzm_, zzzo_);
                    CqlDateTime zzzq_ = context.Operators.Add(zzzl_, zzzp_);
                    CqlDateTime zzzr_ = context.Operators.End(Period);
                    int? zzzs_ = context.Operators.DurationBetween(zzzq_, zzzr_, "hour");
                    bool? zzzt_ = context.Operators.Less(zzzs_, 24);

                    return zzzt_ ?? false;
                };
                if (zzzk_())
                {
                    CqlDateTime zzzu_ = context.Operators.Start(Period);
                    CqlQuantity zzzv_ = context.Operators.Quantity(24m, "hours");
                    int? zzzw_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity zzzx_ = context.Operators.ConvertIntegerToQuantity(zzzw_);
                    CqlQuantity zzzy_ = context.Operators.Multiply(zzzv_, zzzx_);
                    CqlDateTime zzzz_ = context.Operators.Add(zzzu_, zzzy_);

                    return zzzz_;
                }
                else
                {
                    CqlDateTime azzza_ = context.Operators.Start(Period);
                    CqlQuantity azzzb_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity azzzc_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity azzzd_ = context.Operators.Multiply(azzzb_, azzzc_);
                    CqlDateTime azzze_ = context.Operators.Add(azzza_, azzzd_);

                    return azzze_;
                }
            };
            CqlInterval<CqlDateTime> zzzi_ = context.Operators.Interval(zzzg_, zzzh_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? zzzj_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, zzzi_);

            return zzzj_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> yzzz_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(yzzx_, yzzy_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> zzza_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(yzzz_);

        return zzza_;
    }


    [CqlExpressionDefinition("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.\nNote that the result will include intervals that are closed at the beginning and open at the end")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> azzzf_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? azzzg_(int? DayIndex)
        {
            CqlDateTime azzzj_ = context.Operators.Start(Period);
            CqlQuantity azzzk_ = context.Operators.Quantity(24m, "hours");
            int? azzzl_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity azzzm_ = context.Operators.ConvertIntegerToQuantity(azzzl_);
            CqlQuantity azzzn_ = context.Operators.Multiply(azzzk_, azzzm_);
            CqlDateTime azzzo_ = context.Operators.Add(azzzj_, azzzn_);
            CqlDateTime azzzp_()
            {
                bool azzzs_()
                {
                    CqlDateTime azzzt_ = context.Operators.Start(Period);
                    CqlQuantity azzzu_ = context.Operators.Quantity(24m, "hours");
                    int? azzzv_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity azzzw_ = context.Operators.ConvertIntegerToQuantity(azzzv_);
                    CqlQuantity azzzx_ = context.Operators.Multiply(azzzu_, azzzw_);
                    CqlDateTime azzzy_ = context.Operators.Add(azzzt_, azzzx_);
                    CqlDateTime azzzz_ = context.Operators.End(Period);
                    int? bzzza_ = context.Operators.DurationBetween(azzzy_, azzzz_, "hour");
                    bool? bzzzb_ = context.Operators.Less(bzzza_, 24);

                    return bzzzb_ ?? false;
                };
                if (azzzs_())
                {
                    CqlDateTime bzzzc_ = context.Operators.Start(Period);
                    CqlQuantity bzzzd_ = context.Operators.Quantity(24m, "hours");
                    int? bzzze_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity bzzzf_ = context.Operators.ConvertIntegerToQuantity(bzzze_);
                    CqlQuantity bzzzg_ = context.Operators.Multiply(bzzzd_, bzzzf_);
                    CqlDateTime bzzzh_ = context.Operators.Add(bzzzc_, bzzzg_);

                    return bzzzh_;
                }
                else
                {
                    CqlDateTime bzzzi_ = context.Operators.Start(Period);
                    CqlQuantity bzzzj_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity bzzzk_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity bzzzl_ = context.Operators.Multiply(bzzzj_, bzzzk_);
                    CqlDateTime bzzzm_ = context.Operators.Add(bzzzi_, bzzzl_);

                    return bzzzm_;
                }
            };
            CqlInterval<CqlDateTime> azzzq_ = context.Operators.Interval(azzzo_, azzzp_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? azzzr_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, azzzq_);

            return azzzr_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> azzzh_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(azzzf_, azzzg_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> azzzi_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(azzzh_);

        return azzzi_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
