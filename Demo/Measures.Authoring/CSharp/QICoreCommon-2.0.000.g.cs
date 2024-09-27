using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("QICoreCommon", "2.0.000")]
public class QICoreCommon_2_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __Birthdate;
    internal Lazy<CqlCode> __Dead;
    internal Lazy<CqlCode> __ER;
    internal Lazy<CqlCode> __ICU;
    internal Lazy<CqlCode> __Billing;
    internal Lazy<CqlCode> __ambulatory;
    internal Lazy<CqlCode> __emergency;
    internal Lazy<CqlCode> __field;
    internal Lazy<CqlCode> __home_health;
    internal Lazy<CqlCode> __inpatient_encounter;
    internal Lazy<CqlCode> __inpatient_acute;
    internal Lazy<CqlCode> __inpatient_non_acute;
    internal Lazy<CqlCode> __observation_encounter;
    internal Lazy<CqlCode> __pre_admission;
    internal Lazy<CqlCode> __short_stay;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode> __problem_list_item;
    internal Lazy<CqlCode> __encounter_diagnosis;
    internal Lazy<CqlCode> __health_concern;
    internal Lazy<CqlCode> __active;
    internal Lazy<CqlCode> __recurrence;
    internal Lazy<CqlCode> __relapse;
    internal Lazy<CqlCode> __inactive;
    internal Lazy<CqlCode> __remission;
    internal Lazy<CqlCode> __resolved;
    internal Lazy<CqlCode> __unconfirmed;
    internal Lazy<CqlCode> __provisional;
    internal Lazy<CqlCode> __differential;
    internal Lazy<CqlCode> __confirmed;
    internal Lazy<CqlCode> __refuted;
    internal Lazy<CqlCode> __entered_in_error;
    internal Lazy<CqlCode> __allergy_active;
    internal Lazy<CqlCode> __allergy_inactive;
    internal Lazy<CqlCode> __allergy_resolved;
    internal Lazy<CqlCode> __allergy_unconfirmed;
    internal Lazy<CqlCode> __allergy_confirmed;
    internal Lazy<CqlCode> __allergy_refuted;
    internal Lazy<CqlCode> __Inpatient;
    internal Lazy<CqlCode> __Outpatient;
    internal Lazy<CqlCode> __Community;
    internal Lazy<CqlCode> __Discharge;
    internal Lazy<CqlCode> __AD;
    internal Lazy<CqlCode> __DD;
    internal Lazy<CqlCode> __CC;
    internal Lazy<CqlCode> __CM;
    internal Lazy<CqlCode> __pre_op;
    internal Lazy<CqlCode> __post_op;
    internal Lazy<CqlCode> __billing;
    internal Lazy<CqlCode> __social_history;
    internal Lazy<CqlCode> __vital_signs;
    internal Lazy<CqlCode> __imaging;
    internal Lazy<CqlCode> __laboratory;
    internal Lazy<CqlCode> __procedure;
    internal Lazy<CqlCode> __survey;
    internal Lazy<CqlCode> __exam;
    internal Lazy<CqlCode> __therapy;
    internal Lazy<CqlCode> __activity;
    internal Lazy<CqlCode> __clinical_test;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlCode[]> __RoleCode;
    internal Lazy<CqlCode[]> __Diagnosis_Role;
    internal Lazy<CqlCode[]> __RequestIntent;
    internal Lazy<CqlCode[]> __MedicationRequestCategory;
    internal Lazy<CqlCode[]> __ConditionClinicalStatusCodes;
    internal Lazy<CqlCode[]> __ConditionVerificationStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceClinicalStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceVerificationStatusCodes;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlCode[]> __USCoreObservationCategoryExtensionCodes;
    internal Lazy<CqlCode[]> __ConditionCategory;
    internal Lazy<CqlCode[]> __USCoreConditionCategoryExtensionCodes;
    internal Lazy<Patient> __Patient;

    #endregion
    public QICoreCommon_2_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Birthdate = new Lazy<CqlCode>(this.Birthdate_Value);
        __Dead = new Lazy<CqlCode>(this.Dead_Value);
        __ER = new Lazy<CqlCode>(this.ER_Value);
        __ICU = new Lazy<CqlCode>(this.ICU_Value);
        __Billing = new Lazy<CqlCode>(this.Billing_Value);
        __ambulatory = new Lazy<CqlCode>(this.ambulatory_Value);
        __emergency = new Lazy<CqlCode>(this.emergency_Value);
        __field = new Lazy<CqlCode>(this.field_Value);
        __home_health = new Lazy<CqlCode>(this.home_health_Value);
        __inpatient_encounter = new Lazy<CqlCode>(this.inpatient_encounter_Value);
        __inpatient_acute = new Lazy<CqlCode>(this.inpatient_acute_Value);
        __inpatient_non_acute = new Lazy<CqlCode>(this.inpatient_non_acute_Value);
        __observation_encounter = new Lazy<CqlCode>(this.observation_encounter_Value);
        __pre_admission = new Lazy<CqlCode>(this.pre_admission_Value);
        __short_stay = new Lazy<CqlCode>(this.short_stay_Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __problem_list_item = new Lazy<CqlCode>(this.problem_list_item_Value);
        __encounter_diagnosis = new Lazy<CqlCode>(this.encounter_diagnosis_Value);
        __health_concern = new Lazy<CqlCode>(this.health_concern_Value);
        __active = new Lazy<CqlCode>(this.active_Value);
        __recurrence = new Lazy<CqlCode>(this.recurrence_Value);
        __relapse = new Lazy<CqlCode>(this.relapse_Value);
        __inactive = new Lazy<CqlCode>(this.inactive_Value);
        __remission = new Lazy<CqlCode>(this.remission_Value);
        __resolved = new Lazy<CqlCode>(this.resolved_Value);
        __unconfirmed = new Lazy<CqlCode>(this.unconfirmed_Value);
        __provisional = new Lazy<CqlCode>(this.provisional_Value);
        __differential = new Lazy<CqlCode>(this.differential_Value);
        __confirmed = new Lazy<CqlCode>(this.confirmed_Value);
        __refuted = new Lazy<CqlCode>(this.refuted_Value);
        __entered_in_error = new Lazy<CqlCode>(this.entered_in_error_Value);
        __allergy_active = new Lazy<CqlCode>(this.allergy_active_Value);
        __allergy_inactive = new Lazy<CqlCode>(this.allergy_inactive_Value);
        __allergy_resolved = new Lazy<CqlCode>(this.allergy_resolved_Value);
        __allergy_unconfirmed = new Lazy<CqlCode>(this.allergy_unconfirmed_Value);
        __allergy_confirmed = new Lazy<CqlCode>(this.allergy_confirmed_Value);
        __allergy_refuted = new Lazy<CqlCode>(this.allergy_refuted_Value);
        __Inpatient = new Lazy<CqlCode>(this.Inpatient_Value);
        __Outpatient = new Lazy<CqlCode>(this.Outpatient_Value);
        __Community = new Lazy<CqlCode>(this.Community_Value);
        __Discharge = new Lazy<CqlCode>(this.Discharge_Value);
        __AD = new Lazy<CqlCode>(this.AD_Value);
        __DD = new Lazy<CqlCode>(this.DD_Value);
        __CC = new Lazy<CqlCode>(this.CC_Value);
        __CM = new Lazy<CqlCode>(this.CM_Value);
        __pre_op = new Lazy<CqlCode>(this.pre_op_Value);
        __post_op = new Lazy<CqlCode>(this.post_op_Value);
        __billing = new Lazy<CqlCode>(this.billing_Value);
        __social_history = new Lazy<CqlCode>(this.social_history_Value);
        __vital_signs = new Lazy<CqlCode>(this.vital_signs_Value);
        __imaging = new Lazy<CqlCode>(this.imaging_Value);
        __laboratory = new Lazy<CqlCode>(this.laboratory_Value);
        __procedure = new Lazy<CqlCode>(this.procedure_Value);
        __survey = new Lazy<CqlCode>(this.survey_Value);
        __exam = new Lazy<CqlCode>(this.exam_Value);
        __therapy = new Lazy<CqlCode>(this.therapy_Value);
        __activity = new Lazy<CqlCode>(this.activity_Value);
        __clinical_test = new Lazy<CqlCode>(this.clinical_test_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __RoleCode = new Lazy<CqlCode[]>(this.RoleCode_Value);
        __Diagnosis_Role = new Lazy<CqlCode[]>(this.Diagnosis_Role_Value);
        __RequestIntent = new Lazy<CqlCode[]>(this.RequestIntent_Value);
        __MedicationRequestCategory = new Lazy<CqlCode[]>(this.MedicationRequestCategory_Value);
        __ConditionClinicalStatusCodes = new Lazy<CqlCode[]>(this.ConditionClinicalStatusCodes_Value);
        __ConditionVerificationStatusCodes = new Lazy<CqlCode[]>(this.ConditionVerificationStatusCodes_Value);
        __AllergyIntoleranceClinicalStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceClinicalStatusCodes_Value);
        __AllergyIntoleranceVerificationStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceVerificationStatusCodes_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __USCoreObservationCategoryExtensionCodes = new Lazy<CqlCode[]>(this.USCoreObservationCategoryExtensionCodes_Value);
        __ConditionCategory = new Lazy<CqlCode[]>(this.ConditionCategory_Value);
        __USCoreConditionCategoryExtensionCodes = new Lazy<CqlCode[]>(this.USCoreConditionCategoryExtensionCodes_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlCode Birthdate_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode ER_Value() => 
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("ER")]
	public CqlCode ER() => 
		__ER.Value;

	private CqlCode ICU_Value() => 
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("ICU")]
	public CqlCode ICU() => 
		__ICU.Value;

	private CqlCode Billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("Billing")]
	public CqlCode Billing() => 
		__Billing.Value;

	private CqlCode ambulatory_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("ambulatory")]
	public CqlCode ambulatory() => 
		__ambulatory.Value;

	private CqlCode emergency_Value() => 
		new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("emergency")]
	public CqlCode emergency() => 
		__emergency.Value;

	private CqlCode field_Value() => 
		new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("field")]
	public CqlCode field() => 
		__field.Value;

	private CqlCode home_health_Value() => 
		new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("home health")]
	public CqlCode home_health() => 
		__home_health.Value;

	private CqlCode inpatient_encounter_Value() => 
		new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("inpatient encounter")]
	public CqlCode inpatient_encounter() => 
		__inpatient_encounter.Value;

	private CqlCode inpatient_acute_Value() => 
		new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("inpatient acute")]
	public CqlCode inpatient_acute() => 
		__inpatient_acute.Value;

	private CqlCode inpatient_non_acute_Value() => 
		new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("inpatient non-acute")]
	public CqlCode inpatient_non_acute() => 
		__inpatient_non_acute.Value;

	private CqlCode observation_encounter_Value() => 
		new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("observation encounter")]
	public CqlCode observation_encounter() => 
		__observation_encounter.Value;

	private CqlCode pre_admission_Value() => 
		new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("pre-admission")]
	public CqlCode pre_admission() => 
		__pre_admission.Value;

	private CqlCode short_stay_Value() => 
		new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("short stay")]
	public CqlCode short_stay() => 
		__short_stay.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode problem_list_item_Value() => 
		new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);

    [CqlDeclaration("problem-list-item")]
	public CqlCode problem_list_item() => 
		__problem_list_item.Value;

	private CqlCode encounter_diagnosis_Value() => 
		new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);

    [CqlDeclaration("encounter-diagnosis")]
	public CqlCode encounter_diagnosis() => 
		__encounter_diagnosis.Value;

	private CqlCode health_concern_Value() => 
		new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default);

    [CqlDeclaration("health-concern")]
	public CqlCode health_concern() => 
		__health_concern.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode recurrence_Value() => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("recurrence")]
	public CqlCode recurrence() => 
		__recurrence.Value;

	private CqlCode relapse_Value() => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("relapse")]
	public CqlCode relapse() => 
		__relapse.Value;

	private CqlCode inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("inactive")]
	public CqlCode inactive() => 
		__inactive.Value;

	private CqlCode remission_Value() => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("remission")]
	public CqlCode remission() => 
		__remission.Value;

	private CqlCode resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("resolved")]
	public CqlCode resolved() => 
		__resolved.Value;

	private CqlCode unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed() => 
		__unconfirmed.Value;

	private CqlCode provisional_Value() => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("provisional")]
	public CqlCode provisional() => 
		__provisional.Value;

	private CqlCode differential_Value() => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("differential")]
	public CqlCode differential() => 
		__differential.Value;

	private CqlCode confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("confirmed")]
	public CqlCode confirmed() => 
		__confirmed.Value;

	private CqlCode refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("refuted")]
	public CqlCode refuted() => 
		__refuted.Value;

	private CqlCode entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error() => 
		__entered_in_error.Value;

	private CqlCode allergy_active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active() => 
		__allergy_active.Value;

	private CqlCode allergy_inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive() => 
		__allergy_inactive.Value;

	private CqlCode allergy_resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved() => 
		__allergy_resolved.Value;

	private CqlCode allergy_unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed() => 
		__allergy_unconfirmed.Value;

	private CqlCode allergy_confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed() => 
		__allergy_confirmed.Value;

	private CqlCode allergy_refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted() => 
		__allergy_refuted.Value;

	private CqlCode Inpatient_Value() => 
		new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Inpatient")]
	public CqlCode Inpatient() => 
		__Inpatient.Value;

	private CqlCode Outpatient_Value() => 
		new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Outpatient")]
	public CqlCode Outpatient() => 
		__Outpatient.Value;

	private CqlCode Community_Value() => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Community")]
	public CqlCode Community() => 
		__Community.Value;

	private CqlCode Discharge_Value() => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Discharge")]
	public CqlCode Discharge() => 
		__Discharge.Value;

	private CqlCode AD_Value() => 
		new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("AD")]
	public CqlCode AD() => 
		__AD.Value;

	private CqlCode DD_Value() => 
		new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("DD")]
	public CqlCode DD() => 
		__DD.Value;

	private CqlCode CC_Value() => 
		new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("CC")]
	public CqlCode CC() => 
		__CC.Value;

	private CqlCode CM_Value() => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("CM")]
	public CqlCode CM() => 
		__CM.Value;

	private CqlCode pre_op_Value() => 
		new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("pre-op")]
	public CqlCode pre_op() => 
		__pre_op.Value;

	private CqlCode post_op_Value() => 
		new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("post-op")]
	public CqlCode post_op() => 
		__post_op.Value;

	private CqlCode billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("billing")]
	public CqlCode billing() => 
		__billing.Value;

	private CqlCode social_history_Value() => 
		new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("social-history")]
	public CqlCode social_history() => 
		__social_history.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode imaging_Value() => 
		new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("imaging")]
	public CqlCode imaging() => 
		__imaging.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode procedure_Value() => 
		new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("procedure")]
	public CqlCode procedure() => 
		__procedure.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode therapy_Value() => 
		new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("therapy")]
	public CqlCode therapy() => 
		__therapy.Value;

	private CqlCode activity_Value() => 
		new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("activity")]
	public CqlCode activity() => 
		__activity.Value;

	private CqlCode clinical_test_Value() => 
		new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default);

    [CqlDeclaration("clinical-test")]
	public CqlCode clinical_test() => 
		__clinical_test.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] RoleCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
			new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("RoleCode")]
	public CqlCode[] RoleCode() => 
		__RoleCode.Value;

	private CqlCode[] Diagnosis_Role_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role() => 
		__Diagnosis_Role.Value;

	private CqlCode[] RequestIntent_Value()
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("RequestIntent")]
	public CqlCode[] RequestIntent() => 
		__RequestIntent.Value;

	private CqlCode[] MedicationRequestCategory_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory() => 
		__MedicationRequestCategory.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes() => 
		__ConditionVerificationStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => 
		__AllergyIntoleranceClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => 
		__AllergyIntoleranceVerificationStatusCodes.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlCode[] USCoreObservationCategoryExtensionCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("USCoreObservationCategoryExtensionCodes")]
	public CqlCode[] USCoreObservationCategoryExtensionCodes() => 
		__USCoreObservationCategoryExtensionCodes.Value;

	private CqlCode[] ConditionCategory_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
			new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionCategory")]
	public CqlCode[] ConditionCategory() => 
		__ConditionCategory.Value;

	private CqlCode[] USCoreConditionCategoryExtensionCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("USCoreConditionCategoryExtensionCodes")]
	public CqlCode[] USCoreConditionCategoryExtensionCodes() => 
		__USCoreConditionCategoryExtensionCodes.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
	public bool? isActive(Condition condition)
	{
		CodeableConcept a_ = condition?.ClinicalStatus;
		CqlConcept b_ = FHIRHelpers_4_3_000.ToConcept(a_);
		CqlCode c_ = this.active();
		CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
		bool? e_ = context.Operators.Equivalent(b_, d_);
		CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(a_);
		CqlCode h_ = this.recurrence();
		CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
		bool? j_ = context.Operators.Equivalent(g_, i_);
		bool? k_ = context.Operators.Or(e_, j_);
		CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(a_);
		CqlCode n_ = this.relapse();
		CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
		bool? p_ = context.Operators.Equivalent(m_, o_);
		bool? q_ = context.Operators.Or(k_, p_);

		return q_;
	}

    [CqlDeclaration("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
	public bool? hasCategory(Condition condition, CqlCode category)
	{
		List<CodeableConcept> a_ = condition?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(category);
			bool? i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
	public bool? hasCategory(Observation observation, CqlCode category)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(category);
			bool? i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
	public bool? isProblemListItem(Condition condition)
	{
		List<CodeableConcept> a_ = condition?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.problem_list_item();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
	public bool? isEncounterDiagnosis(Condition condition)
	{
		List<CodeableConcept> a_ = condition?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.encounter_diagnosis();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
	public bool? isHealthConcern(Condition condition)
	{
		List<CodeableConcept> a_ = condition?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.health_concern();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
	public bool? isSocialHistory(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.social_history();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
	public bool? isVitalSign(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.vital_signs();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
	public bool? isImaging(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.imaging();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
	public bool? isLaboratory(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.laboratory();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
	public bool? isProcedure(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.procedure();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
	public bool? isSurvey(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.survey();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
	public bool? isExam(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.exam();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
	public bool? isTherapy(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.therapy();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
	public bool? isActivity(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.activity();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
	public bool? isClinicalTest(Observation observation)
	{
		List<CodeableConcept> a_ = observation?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.clinical_test();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
	public bool? isCommunity(MedicationRequest medicationRequest)
	{
		List<CodeableConcept> a_ = medicationRequest?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.Community();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
	public bool? isDischarge(MedicationRequest medicationRequest)
	{
		List<CodeableConcept> a_ = medicationRequest?.Category;
		CqlConcept b_(CodeableConcept @this)
		{
			CqlConcept g_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return g_;
		};
		IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
		bool? d_(CqlConcept C)
		{
			CqlCode h_ = this.Discharge();
			CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
			bool? j_ = context.Operators.Equivalent(C, i_);

			return j_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
		bool? f_ = context.Operators.Exists<CqlConcept>(e_);

		return f_;
	}

    [CqlDeclaration("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
	public bool? doNotPerform(DeviceRequest deviceRequest)
	{
		bool? a_(Extension E)
		{
			string f_ = E?.Url;
			FhirString g_ = context.Operators.Convert<FhirString>(f_);
			string h_ = g_?.Value;
			bool? i_ = context.Operators.Equal(h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

			return i_;
		};
		IEnumerable<Extension> b_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
				? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
				: default), a_);
		bool? c_(Extension E)
		{
			DataType j_ = E?.Value;
			object k_ = FHIRHelpers_4_3_000.ToValue(j_);
			bool? l_ = k_ switch { null => null , bool a => context.Operators.ConvertStringToBoolean(a)/* , CqlDate => ???, CqlDateTime => ???, CqlDateTime => ???, CqlTime => ???, Address => ???, CqlQuantity => ???, Annotation => ???, Attachment => ???, CqlConcept => ???, CqlCode => ???, ContactPoint => ???, CqlQuantity => ???, CqlQuantity => ???, CqlQuantity => ???, HumanName => ???, Identifier => ???, CqlInterval<CqlDateTime> => ???, CqlQuantity => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

			return l_;
		};
		IEnumerable<bool?> d_ = context.Operators.Select<Extension, bool?>(b_, c_);
		bool? e_ = context.Operators.SingletonFrom<bool?>(d_);

		return e_;
	}

    [CqlDeclaration("ToInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types to an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible representations for timing-valued elements in QICore, allowing this function to be used across any resource. The input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>. The intent of this function is to provide a clear and concise mechanism to treat single elements that have multiple possible representations as intervals so that logic doesn't have to account for the variability. More complex calculations (such as medication request period or dispense period calculation) need specific guidance and consideration. That guidance may make use of this function, but the focus of this function is on single element calculations where the semantics are unambiguous. If the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime. If the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age, and the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later. If the input is a DateTime Interval, the result is the input. If the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result is a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending immediately before one year later than the date the patient turned the age given as the end of the quantity interval. If the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toInterval()` instead")]
	public CqlInterval<CqlDateTime> ToInterval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is CqlDateTime)
			{
				CqlDateTime b_ = choice switch { null => null , CqlDateTime a => a/* , CqlQuantity => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is CqlInterval<CqlDateTime>)
			{
				CqlInterval<CqlDateTime> e_ = choice switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, CqlQuantity => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

				return e_;
			}
			else if (choice is CqlQuantity)
			{
				Patient f_ = this.Patient();
				Date g_ = f_?.BirthDateElement;
				string h_ = g_?.Value;
				CqlDate i_ = context.Operators.ConvertStringToDate(h_);
				CqlQuantity j_ = choice switch { null => null , CqlQuantity c => c/* , CqlDateTime => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate k_ = context.Operators.Add(i_, j_);
				Date m_ = f_?.BirthDateElement;
				string n_ = m_?.Value;
				CqlDate o_ = context.Operators.ConvertStringToDate(n_);
				CqlDate q_ = context.Operators.Add(o_, j_);
				CqlQuantity r_ = context.Operators.Quantity(1m, "year");
				CqlDate s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(k_, s_, true, false);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				Date x_ = f_?.BirthDateElement;
				string y_ = x_?.Value;
				CqlDate z_ = context.Operators.ConvertStringToDate(y_);
				CqlDate ab_ = context.Operators.Add(z_, j_);
				Date ad_ = f_?.BirthDateElement;
				string ae_ = ad_?.Value;
				CqlDate af_ = context.Operators.ConvertStringToDate(ae_);
				CqlDate ah_ = context.Operators.Add(af_, j_);
				CqlDate aj_ = context.Operators.Add(ah_, r_);
				CqlInterval<CqlDate> ak_ = context.Operators.Interval(ab_, aj_, true, false);
				CqlDate al_ = ak_?.high;
				CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
				Date ao_ = f_?.BirthDateElement;
				string ap_ = ao_?.Value;
				CqlDate aq_ = context.Operators.ConvertStringToDate(ap_);
				CqlDate as_ = context.Operators.Add(aq_, j_);
				Date au_ = f_?.BirthDateElement;
				string av_ = au_?.Value;
				CqlDate aw_ = context.Operators.ConvertStringToDate(av_);
				CqlDate ay_ = context.Operators.Add(aw_, j_);
				CqlDate ba_ = context.Operators.Add(ay_, r_);
				CqlInterval<CqlDate> bb_ = context.Operators.Interval(as_, ba_, true, false);
				bool? bc_ = bb_?.lowClosed;
				Date be_ = f_?.BirthDateElement;
				string bf_ = be_?.Value;
				CqlDate bg_ = context.Operators.ConvertStringToDate(bf_);
				CqlDate bi_ = context.Operators.Add(bg_, j_);
				Date bk_ = f_?.BirthDateElement;
				string bl_ = bk_?.Value;
				CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
				CqlDate bo_ = context.Operators.Add(bm_, j_);
				CqlDate bq_ = context.Operators.Add(bo_, r_);
				CqlInterval<CqlDate> br_ = context.Operators.Interval(bi_, bq_, true, false);
				bool? bs_ = br_?.highClosed;
				CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(v_, am_, bc_, bs_);

				return bt_;
			}
			else if (choice is CqlInterval<CqlQuantity>)
			{
				Patient bu_ = this.Patient();
				Date bv_ = bu_?.BirthDateElement;
				string bw_ = bv_?.Value;
				CqlDate bx_ = context.Operators.ConvertStringToDate(bw_);
				object by_ = context.Operators.LateBoundProperty<object>(choice, "low");
				CqlQuantity bz_ = by_ switch { null => null , CqlQuantity d => d/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate ca_ = context.Operators.Add(bx_, bz_);
				Date cc_ = bu_?.BirthDateElement;
				string cd_ = cc_?.Value;
				CqlDate ce_ = context.Operators.ConvertStringToDate(cd_);
				object cf_ = context.Operators.LateBoundProperty<object>(choice, "high");
				CqlDate ch_ = context.Operators.Add(ce_, bz_);
				CqlQuantity ci_ = context.Operators.Quantity(1m, "year");
				CqlDate cj_ = context.Operators.Add(ch_, ci_);
				CqlInterval<CqlDate> ck_ = context.Operators.Interval(ca_, cj_, true, false);
				CqlDate cl_ = ck_?.low;
				CqlDateTime cm_ = context.Operators.ConvertDateToDateTime(cl_);
				Date co_ = bu_?.BirthDateElement;
				string cp_ = co_?.Value;
				CqlDate cq_ = context.Operators.ConvertStringToDate(cp_);
				CqlDate ct_ = context.Operators.Add(cq_, bz_);
				Date cv_ = bu_?.BirthDateElement;
				string cw_ = cv_?.Value;
				CqlDate cx_ = context.Operators.ConvertStringToDate(cw_);
				CqlDate da_ = context.Operators.Add(cx_, bz_);
				CqlDate dc_ = context.Operators.Add(da_, ci_);
				CqlInterval<CqlDate> dd_ = context.Operators.Interval(ct_, dc_, true, false);
				CqlDate de_ = dd_?.high;
				CqlDateTime df_ = context.Operators.ConvertDateToDateTime(de_);
				Date dh_ = bu_?.BirthDateElement;
				string di_ = dh_?.Value;
				CqlDate dj_ = context.Operators.ConvertStringToDate(di_);
				CqlDate dm_ = context.Operators.Add(dj_, bz_);
				Date do_ = bu_?.BirthDateElement;
				string dp_ = do_?.Value;
				CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
				CqlDate dt_ = context.Operators.Add(dq_, bz_);
				CqlDate dv_ = context.Operators.Add(dt_, ci_);
				CqlInterval<CqlDate> dw_ = context.Operators.Interval(dm_, dv_, true, false);
				bool? dx_ = dw_?.lowClosed;
				Date dz_ = bu_?.BirthDateElement;
				string ea_ = dz_?.Value;
				CqlDate eb_ = context.Operators.ConvertStringToDate(ea_);
				CqlDate ee_ = context.Operators.Add(eb_, bz_);
				Date eg_ = bu_?.BirthDateElement;
				string eh_ = eg_?.Value;
				CqlDate ei_ = context.Operators.ConvertStringToDate(eh_);
				CqlDate el_ = context.Operators.Add(ei_, bz_);
				CqlDate en_ = context.Operators.Add(el_, ci_);
				CqlInterval<CqlDate> eo_ = context.Operators.Interval(ee_, en_, true, false);
				bool? ep_ = eo_?.highClosed;
				CqlInterval<CqlDateTime> eq_ = context.Operators.Interval(cm_, df_, dx_, ep_);

				return eq_;
			}
			else if (choice is Timing)
			{
				object er_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

				return er_ as CqlInterval<CqlDateTime>;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("toInterval")]
    [CqlTag("description", "Normalizes a value that is a choice of timing-valued types to an equivalent interval")]
    [CqlTag("comment", "Normalizes a choice type of DateTime, Quanitty, Interval<DateTime>, or Interval<Quantity> types to an equivalent interval. This selection of choice types is a superset of the majority of choice types that are used as possible representations for timing-valued elements in QICore, allowing this function to be used across any resource. The input can be provided as a DateTime, Quantity, Interval<DateTime> or Interval<Quantity>. The intent of this function is to provide a clear and concise mechanism to treat single elements that have multiple possible representations as intervals so that logic doesn't have to account for the variability. More complex calculations (such as medication request period or dispense period calculation) need specific guidance and consideration. That guidance may make use of this function, but the focus of this function is on single element calculations where the semantics are unambiguous. If the input is a DateTime, the result a DateTime Interval beginning and ending on that DateTime. If the input is a Quantity, the quantity is expected to be a calendar-duration interpreted as an Age, and the result is a DateTime Interval beginning on the Date the patient turned that age and ending immediately before one year later. If the input is a DateTime Interval, the result is the input. If the input is a Quantity Interval, the quantities are expected to be calendar-durations interpreted as an Age, and the result is a DateTime Interval beginning on the date the patient turned the age given as the start of the quantity interval, and ending immediately before one year later than the date the patient turned the age given as the end of the quantity interval. If the input is a Timing, an error will be thrown indicating that Timing calculations are not implemented. Any other input will reslt in a null DateTime Interval")]
	public CqlInterval<CqlDateTime> toInterval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is CqlDateTime)
			{
				CqlDateTime b_ = choice switch { null => null , CqlDateTime a => a/* , CqlQuantity => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is CqlInterval<CqlDateTime>)
			{
				CqlInterval<CqlDateTime> e_ = choice switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, CqlQuantity => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

				return e_;
			}
			else if (choice is CqlQuantity)
			{
				Patient f_ = this.Patient();
				Date g_ = f_?.BirthDateElement;
				string h_ = g_?.Value;
				CqlDate i_ = context.Operators.ConvertStringToDate(h_);
				CqlQuantity j_ = choice switch { null => null , CqlQuantity c => c/* , CqlDateTime => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate k_ = context.Operators.Add(i_, j_);
				Date m_ = f_?.BirthDateElement;
				string n_ = m_?.Value;
				CqlDate o_ = context.Operators.ConvertStringToDate(n_);
				CqlDate q_ = context.Operators.Add(o_, j_);
				CqlQuantity r_ = context.Operators.Quantity(1m, "year");
				CqlDate s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDate> t_ = context.Operators.Interval(k_, s_, true, false);
				CqlDate u_ = t_?.low;
				CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
				Date x_ = f_?.BirthDateElement;
				string y_ = x_?.Value;
				CqlDate z_ = context.Operators.ConvertStringToDate(y_);
				CqlDate ab_ = context.Operators.Add(z_, j_);
				Date ad_ = f_?.BirthDateElement;
				string ae_ = ad_?.Value;
				CqlDate af_ = context.Operators.ConvertStringToDate(ae_);
				CqlDate ah_ = context.Operators.Add(af_, j_);
				CqlDate aj_ = context.Operators.Add(ah_, r_);
				CqlInterval<CqlDate> ak_ = context.Operators.Interval(ab_, aj_, true, false);
				CqlDate al_ = ak_?.high;
				CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
				Date ao_ = f_?.BirthDateElement;
				string ap_ = ao_?.Value;
				CqlDate aq_ = context.Operators.ConvertStringToDate(ap_);
				CqlDate as_ = context.Operators.Add(aq_, j_);
				Date au_ = f_?.BirthDateElement;
				string av_ = au_?.Value;
				CqlDate aw_ = context.Operators.ConvertStringToDate(av_);
				CqlDate ay_ = context.Operators.Add(aw_, j_);
				CqlDate ba_ = context.Operators.Add(ay_, r_);
				CqlInterval<CqlDate> bb_ = context.Operators.Interval(as_, ba_, true, false);
				bool? bc_ = bb_?.lowClosed;
				Date be_ = f_?.BirthDateElement;
				string bf_ = be_?.Value;
				CqlDate bg_ = context.Operators.ConvertStringToDate(bf_);
				CqlDate bi_ = context.Operators.Add(bg_, j_);
				Date bk_ = f_?.BirthDateElement;
				string bl_ = bk_?.Value;
				CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
				CqlDate bo_ = context.Operators.Add(bm_, j_);
				CqlDate bq_ = context.Operators.Add(bo_, r_);
				CqlInterval<CqlDate> br_ = context.Operators.Interval(bi_, bq_, true, false);
				bool? bs_ = br_?.highClosed;
				CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(v_, am_, bc_, bs_);

				return bt_;
			}
			else if (choice is CqlInterval<CqlQuantity>)
			{
				Patient bu_ = this.Patient();
				Date bv_ = bu_?.BirthDateElement;
				string bw_ = bv_?.Value;
				CqlDate bx_ = context.Operators.ConvertStringToDate(bw_);
				object by_ = context.Operators.LateBoundProperty<object>(choice, "low");
				CqlQuantity bz_ = by_ switch { null => null , CqlQuantity d => d/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate ca_ = context.Operators.Add(bx_, bz_);
				Date cc_ = bu_?.BirthDateElement;
				string cd_ = cc_?.Value;
				CqlDate ce_ = context.Operators.ConvertStringToDate(cd_);
				object cf_ = context.Operators.LateBoundProperty<object>(choice, "high");
				CqlDate ch_ = context.Operators.Add(ce_, bz_);
				CqlQuantity ci_ = context.Operators.Quantity(1m, "year");
				CqlDate cj_ = context.Operators.Add(ch_, ci_);
				CqlInterval<CqlDate> ck_ = context.Operators.Interval(ca_, cj_, true, false);
				CqlDate cl_ = ck_?.low;
				CqlDateTime cm_ = context.Operators.ConvertDateToDateTime(cl_);
				Date co_ = bu_?.BirthDateElement;
				string cp_ = co_?.Value;
				CqlDate cq_ = context.Operators.ConvertStringToDate(cp_);
				CqlDate ct_ = context.Operators.Add(cq_, bz_);
				Date cv_ = bu_?.BirthDateElement;
				string cw_ = cv_?.Value;
				CqlDate cx_ = context.Operators.ConvertStringToDate(cw_);
				CqlDate da_ = context.Operators.Add(cx_, bz_);
				CqlDate dc_ = context.Operators.Add(da_, ci_);
				CqlInterval<CqlDate> dd_ = context.Operators.Interval(ct_, dc_, true, false);
				CqlDate de_ = dd_?.high;
				CqlDateTime df_ = context.Operators.ConvertDateToDateTime(de_);
				Date dh_ = bu_?.BirthDateElement;
				string di_ = dh_?.Value;
				CqlDate dj_ = context.Operators.ConvertStringToDate(di_);
				CqlDate dm_ = context.Operators.Add(dj_, bz_);
				Date do_ = bu_?.BirthDateElement;
				string dp_ = do_?.Value;
				CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
				CqlDate dt_ = context.Operators.Add(dq_, bz_);
				CqlDate dv_ = context.Operators.Add(dt_, ci_);
				CqlInterval<CqlDate> dw_ = context.Operators.Interval(dm_, dv_, true, false);
				bool? dx_ = dw_?.lowClosed;
				Date dz_ = bu_?.BirthDateElement;
				string ea_ = dz_?.Value;
				CqlDate eb_ = context.Operators.ConvertStringToDate(ea_);
				CqlDate ee_ = context.Operators.Add(eb_, bz_);
				Date eg_ = bu_?.BirthDateElement;
				string eh_ = eg_?.Value;
				CqlDate ei_ = context.Operators.ConvertStringToDate(eh_);
				CqlDate el_ = context.Operators.Add(ei_, bz_);
				CqlDate en_ = context.Operators.Add(el_, ci_);
				CqlInterval<CqlDate> eo_ = context.Operators.Interval(ee_, en_, true, false);
				bool? ep_ = eo_?.highClosed;
				CqlInterval<CqlDateTime> eq_ = context.Operators.Interval(cm_, df_, dx_, ep_);

				return eq_;
			}
			else if (choice is Timing)
			{
				object er_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

				return er_ as CqlInterval<CqlDateTime>;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("ToAbatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result is an interval beginning and ending on that DateTime. If the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The result is an interval from the date the patient turned that age to immediately before one year later. If the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during which the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately before one year later than the date the patient turned the ending age of the quantity interval.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `abatementInterval()` instead.")]
	public CqlInterval<CqlDateTime> ToAbatementInterval(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				DataType f_ = condition?.Abatement;
				object g_ = FHIRHelpers_4_3_000.ToValue(f_);
				bool h_ = g_ is CqlDateTime;

				return h_;
			};
			bool c_()
			{
				DataType i_ = condition?.Abatement;
				object j_ = FHIRHelpers_4_3_000.ToValue(i_);
				bool k_ = j_ is CqlQuantity;

				return k_;
			};
			bool d_()
			{
				DataType l_ = condition?.Abatement;
				object m_ = FHIRHelpers_4_3_000.ToValue(l_);
				bool n_ = m_ is CqlInterval<CqlQuantity>;

				return n_;
			};
			bool e_()
			{
				DataType o_ = condition?.Abatement;
				object p_ = FHIRHelpers_4_3_000.ToValue(o_);
				bool q_ = p_ is CqlInterval<CqlDateTime>;

				return q_;
			};
			if (b_())
			{
				DataType r_ = condition?.Abatement;
				object s_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlDateTime t_ = s_ switch { null => null , CqlDateTime a => a/* , CqlQuantity => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				object v_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, t_, true, true);

				return x_;
			}
			else if (c_())
			{
				Patient y_ = this.Patient();
				Date z_ = y_?.BirthDateElement;
				string aa_ = z_?.Value;
				CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
				DataType ac_ = condition?.Abatement;
				object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlQuantity ae_ = ad_ switch { null => null , CqlQuantity b => b/* , CqlDateTime => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate af_ = context.Operators.Add(ab_, ae_);
				Date ah_ = y_?.BirthDateElement;
				string ai_ = ah_?.Value;
				CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
				object al_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate an_ = context.Operators.Add(aj_, ae_);
				CqlQuantity ao_ = context.Operators.Quantity(1m, "year");
				CqlDate ap_ = context.Operators.Add(an_, ao_);
				CqlInterval<CqlDate> aq_ = context.Operators.Interval(af_, ap_, true, false);
				CqlDate ar_ = aq_?.low;
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
				Date au_ = y_?.BirthDateElement;
				string av_ = au_?.Value;
				CqlDate aw_ = context.Operators.ConvertStringToDate(av_);
				object ay_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate ba_ = context.Operators.Add(aw_, ae_);
				Date bc_ = y_?.BirthDateElement;
				string bd_ = bc_?.Value;
				CqlDate be_ = context.Operators.ConvertStringToDate(bd_);
				object bg_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate bi_ = context.Operators.Add(be_, ae_);
				CqlDate bk_ = context.Operators.Add(bi_, ao_);
				CqlInterval<CqlDate> bl_ = context.Operators.Interval(ba_, bk_, true, false);
				CqlDate bm_ = bl_?.high;
				CqlDateTime bn_ = context.Operators.ConvertDateToDateTime(bm_);
				Date bp_ = y_?.BirthDateElement;
				string bq_ = bp_?.Value;
				CqlDate br_ = context.Operators.ConvertStringToDate(bq_);
				object bt_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate bv_ = context.Operators.Add(br_, ae_);
				Date bx_ = y_?.BirthDateElement;
				string by_ = bx_?.Value;
				CqlDate bz_ = context.Operators.ConvertStringToDate(by_);
				object cb_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cd_ = context.Operators.Add(bz_, ae_);
				CqlDate cf_ = context.Operators.Add(cd_, ao_);
				CqlInterval<CqlDate> cg_ = context.Operators.Interval(bv_, cf_, true, false);
				bool? ch_ = cg_?.lowClosed;
				Date cj_ = y_?.BirthDateElement;
				string ck_ = cj_?.Value;
				CqlDate cl_ = context.Operators.ConvertStringToDate(ck_);
				object cn_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cp_ = context.Operators.Add(cl_, ae_);
				Date cr_ = y_?.BirthDateElement;
				string cs_ = cr_?.Value;
				CqlDate ct_ = context.Operators.ConvertStringToDate(cs_);
				object cv_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cx_ = context.Operators.Add(ct_, ae_);
				CqlDate cz_ = context.Operators.Add(cx_, ao_);
				CqlInterval<CqlDate> da_ = context.Operators.Interval(cp_, cz_, true, false);
				bool? db_ = da_?.highClosed;
				CqlInterval<CqlDateTime> dc_ = context.Operators.Interval(as_, bn_, ch_, db_);

				return dc_;
			}
			else if (d_())
			{
				Patient dd_ = this.Patient();
				Date de_ = dd_?.BirthDateElement;
				string df_ = de_?.Value;
				CqlDate dg_ = context.Operators.ConvertStringToDate(df_);
				DataType dh_ = condition?.Abatement;
				object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object dj_ = context.Operators.LateBoundProperty<object>(di_, "low");
				CqlQuantity dk_ = dj_ switch { null => null , CqlQuantity c => c/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate dl_ = context.Operators.Add(dg_, dk_);
				Date dn_ = dd_?.BirthDateElement;
				string do_ = dn_?.Value;
				CqlDate dp_ = context.Operators.ConvertStringToDate(do_);
				object dr_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object ds_ = context.Operators.LateBoundProperty<object>(dr_, "high");
				CqlDate du_ = context.Operators.Add(dp_, dk_);
				CqlQuantity dv_ = context.Operators.Quantity(1m, "year");
				CqlDate dw_ = context.Operators.Add(du_, dv_);
				CqlInterval<CqlDate> dx_ = context.Operators.Interval(dl_, dw_, true, false);
				CqlDate dy_ = dx_?.low;
				CqlDateTime dz_ = context.Operators.ConvertDateToDateTime(dy_);
				Date eb_ = dd_?.BirthDateElement;
				string ec_ = eb_?.Value;
				CqlDate ed_ = context.Operators.ConvertStringToDate(ec_);
				object ef_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object eg_ = context.Operators.LateBoundProperty<object>(ef_, "low");
				CqlDate ei_ = context.Operators.Add(ed_, dk_);
				Date ek_ = dd_?.BirthDateElement;
				string el_ = ek_?.Value;
				CqlDate em_ = context.Operators.ConvertStringToDate(el_);
				object eo_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object ep_ = context.Operators.LateBoundProperty<object>(eo_, "high");
				CqlDate er_ = context.Operators.Add(em_, dk_);
				CqlDate et_ = context.Operators.Add(er_, dv_);
				CqlInterval<CqlDate> eu_ = context.Operators.Interval(ei_, et_, true, false);
				CqlDate ev_ = eu_?.high;
				CqlDateTime ew_ = context.Operators.ConvertDateToDateTime(ev_);
				Date ey_ = dd_?.BirthDateElement;
				string ez_ = ey_?.Value;
				CqlDate fa_ = context.Operators.ConvertStringToDate(ez_);
				object fc_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fd_ = context.Operators.LateBoundProperty<object>(fc_, "low");
				CqlDate ff_ = context.Operators.Add(fa_, dk_);
				Date fh_ = dd_?.BirthDateElement;
				string fi_ = fh_?.Value;
				CqlDate fj_ = context.Operators.ConvertStringToDate(fi_);
				object fl_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fm_ = context.Operators.LateBoundProperty<object>(fl_, "high");
				CqlDate fo_ = context.Operators.Add(fj_, dk_);
				CqlDate fq_ = context.Operators.Add(fo_, dv_);
				CqlInterval<CqlDate> fr_ = context.Operators.Interval(ff_, fq_, true, false);
				bool? fs_ = fr_?.lowClosed;
				Date fu_ = dd_?.BirthDateElement;
				string fv_ = fu_?.Value;
				CqlDate fw_ = context.Operators.ConvertStringToDate(fv_);
				object fy_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fz_ = context.Operators.LateBoundProperty<object>(fy_, "low");
				CqlDate gb_ = context.Operators.Add(fw_, dk_);
				Date gd_ = dd_?.BirthDateElement;
				string ge_ = gd_?.Value;
				CqlDate gf_ = context.Operators.ConvertStringToDate(ge_);
				object gh_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object gi_ = context.Operators.LateBoundProperty<object>(gh_, "high");
				CqlDate gk_ = context.Operators.Add(gf_, dk_);
				CqlDate gm_ = context.Operators.Add(gk_, dv_);
				CqlInterval<CqlDate> gn_ = context.Operators.Interval(gb_, gm_, true, false);
				bool? go_ = gn_?.highClosed;
				CqlInterval<CqlDateTime> gp_ = context.Operators.Interval(dz_, ew_, fs_, go_);

				return gp_;
			}
			else if (e_())
			{
				DataType gq_ = condition?.Abatement;
				object gr_ = FHIRHelpers_4_3_000.ToValue(gq_);
				object gs_ = context.Operators.LateBoundProperty<object>(gr_, "low");
				CqlDateTime gt_ = gs_ switch { null => null , CqlDateTime d => d/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				object gv_ = FHIRHelpers_4_3_000.ToValue(gq_);
				object gw_ = context.Operators.LateBoundProperty<object>(gv_, "high");
				CqlInterval<CqlDateTime> gy_ = context.Operators.Interval(gt_, gt_, true, false);

				return gy_;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("abatementInterval")]
    [CqlTag("description", "Returns an interval representing the normalized abatement of a given Condition.")]
    [CqlTag("comment", "If the abatement element of the Condition is represented as a DateTime, the result is an interval beginning and ending on that DateTime. If the abatement is represented as a Quantity, the quantity is expected to be a calendar-duration and is interpreted as the age of the patient. The result is an interval from the date the patient turned that age to immediately before one year later. If the abatement is represented as a Quantity Interval, the quantities are expected to be calendar-durations and are interpreted as an age range during which the abatement occurred. The result is an interval from the date the patient turned the starting age of the quantity interval, and ending immediately before one year later than the date the patient turned the ending age of the quantity interval.")]
	public CqlInterval<CqlDateTime> abatementInterval(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				DataType f_ = condition?.Abatement;
				object g_ = FHIRHelpers_4_3_000.ToValue(f_);
				bool h_ = g_ is CqlDateTime;

				return h_;
			};
			bool c_()
			{
				DataType i_ = condition?.Abatement;
				object j_ = FHIRHelpers_4_3_000.ToValue(i_);
				bool k_ = j_ is CqlQuantity;

				return k_;
			};
			bool d_()
			{
				DataType l_ = condition?.Abatement;
				object m_ = FHIRHelpers_4_3_000.ToValue(l_);
				bool n_ = m_ is CqlInterval<CqlQuantity>;

				return n_;
			};
			bool e_()
			{
				DataType o_ = condition?.Abatement;
				object p_ = FHIRHelpers_4_3_000.ToValue(o_);
				bool q_ = p_ is CqlInterval<CqlDateTime>;

				return q_;
			};
			if (b_())
			{
				DataType r_ = condition?.Abatement;
				object s_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlDateTime t_ = s_ switch { null => null , CqlDateTime a => a/* , CqlQuantity => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				object v_ = FHIRHelpers_4_3_000.ToValue(r_);
				CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, t_, true, true);

				return x_;
			}
			else if (c_())
			{
				Patient y_ = this.Patient();
				Date z_ = y_?.BirthDateElement;
				string aa_ = z_?.Value;
				CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
				DataType ac_ = condition?.Abatement;
				object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlQuantity ae_ = ad_ switch { null => null , CqlQuantity b => b/* , CqlDateTime => ???, CqlInterval<CqlDateTime> => ???, CqlInterval<CqlQuantity> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate af_ = context.Operators.Add(ab_, ae_);
				Date ah_ = y_?.BirthDateElement;
				string ai_ = ah_?.Value;
				CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
				object al_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate an_ = context.Operators.Add(aj_, ae_);
				CqlQuantity ao_ = context.Operators.Quantity(1m, "year");
				CqlDate ap_ = context.Operators.Add(an_, ao_);
				CqlInterval<CqlDate> aq_ = context.Operators.Interval(af_, ap_, true, false);
				CqlDate ar_ = aq_?.low;
				CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
				Date au_ = y_?.BirthDateElement;
				string av_ = au_?.Value;
				CqlDate aw_ = context.Operators.ConvertStringToDate(av_);
				object ay_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate ba_ = context.Operators.Add(aw_, ae_);
				Date bc_ = y_?.BirthDateElement;
				string bd_ = bc_?.Value;
				CqlDate be_ = context.Operators.ConvertStringToDate(bd_);
				object bg_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate bi_ = context.Operators.Add(be_, ae_);
				CqlDate bk_ = context.Operators.Add(bi_, ao_);
				CqlInterval<CqlDate> bl_ = context.Operators.Interval(ba_, bk_, true, false);
				CqlDate bm_ = bl_?.high;
				CqlDateTime bn_ = context.Operators.ConvertDateToDateTime(bm_);
				Date bp_ = y_?.BirthDateElement;
				string bq_ = bp_?.Value;
				CqlDate br_ = context.Operators.ConvertStringToDate(bq_);
				object bt_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate bv_ = context.Operators.Add(br_, ae_);
				Date bx_ = y_?.BirthDateElement;
				string by_ = bx_?.Value;
				CqlDate bz_ = context.Operators.ConvertStringToDate(by_);
				object cb_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cd_ = context.Operators.Add(bz_, ae_);
				CqlDate cf_ = context.Operators.Add(cd_, ao_);
				CqlInterval<CqlDate> cg_ = context.Operators.Interval(bv_, cf_, true, false);
				bool? ch_ = cg_?.lowClosed;
				Date cj_ = y_?.BirthDateElement;
				string ck_ = cj_?.Value;
				CqlDate cl_ = context.Operators.ConvertStringToDate(ck_);
				object cn_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cp_ = context.Operators.Add(cl_, ae_);
				Date cr_ = y_?.BirthDateElement;
				string cs_ = cr_?.Value;
				CqlDate ct_ = context.Operators.ConvertStringToDate(cs_);
				object cv_ = FHIRHelpers_4_3_000.ToValue(ac_);
				CqlDate cx_ = context.Operators.Add(ct_, ae_);
				CqlDate cz_ = context.Operators.Add(cx_, ao_);
				CqlInterval<CqlDate> da_ = context.Operators.Interval(cp_, cz_, true, false);
				bool? db_ = da_?.highClosed;
				CqlInterval<CqlDateTime> dc_ = context.Operators.Interval(as_, bn_, ch_, db_);

				return dc_;
			}
			else if (d_())
			{
				Patient dd_ = this.Patient();
				Date de_ = dd_?.BirthDateElement;
				string df_ = de_?.Value;
				CqlDate dg_ = context.Operators.ConvertStringToDate(df_);
				DataType dh_ = condition?.Abatement;
				object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object dj_ = context.Operators.LateBoundProperty<object>(di_, "low");
				CqlQuantity dk_ = dj_ switch { null => null , CqlQuantity c => c/* , CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlDate dl_ = context.Operators.Add(dg_, dk_);
				Date dn_ = dd_?.BirthDateElement;
				string do_ = dn_?.Value;
				CqlDate dp_ = context.Operators.ConvertStringToDate(do_);
				object dr_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object ds_ = context.Operators.LateBoundProperty<object>(dr_, "high");
				CqlDate du_ = context.Operators.Add(dp_, dk_);
				CqlQuantity dv_ = context.Operators.Quantity(1m, "year");
				CqlDate dw_ = context.Operators.Add(du_, dv_);
				CqlInterval<CqlDate> dx_ = context.Operators.Interval(dl_, dw_, true, false);
				CqlDate dy_ = dx_?.low;
				CqlDateTime dz_ = context.Operators.ConvertDateToDateTime(dy_);
				Date eb_ = dd_?.BirthDateElement;
				string ec_ = eb_?.Value;
				CqlDate ed_ = context.Operators.ConvertStringToDate(ec_);
				object ef_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object eg_ = context.Operators.LateBoundProperty<object>(ef_, "low");
				CqlDate ei_ = context.Operators.Add(ed_, dk_);
				Date ek_ = dd_?.BirthDateElement;
				string el_ = ek_?.Value;
				CqlDate em_ = context.Operators.ConvertStringToDate(el_);
				object eo_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object ep_ = context.Operators.LateBoundProperty<object>(eo_, "high");
				CqlDate er_ = context.Operators.Add(em_, dk_);
				CqlDate et_ = context.Operators.Add(er_, dv_);
				CqlInterval<CqlDate> eu_ = context.Operators.Interval(ei_, et_, true, false);
				CqlDate ev_ = eu_?.high;
				CqlDateTime ew_ = context.Operators.ConvertDateToDateTime(ev_);
				Date ey_ = dd_?.BirthDateElement;
				string ez_ = ey_?.Value;
				CqlDate fa_ = context.Operators.ConvertStringToDate(ez_);
				object fc_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fd_ = context.Operators.LateBoundProperty<object>(fc_, "low");
				CqlDate ff_ = context.Operators.Add(fa_, dk_);
				Date fh_ = dd_?.BirthDateElement;
				string fi_ = fh_?.Value;
				CqlDate fj_ = context.Operators.ConvertStringToDate(fi_);
				object fl_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fm_ = context.Operators.LateBoundProperty<object>(fl_, "high");
				CqlDate fo_ = context.Operators.Add(fj_, dk_);
				CqlDate fq_ = context.Operators.Add(fo_, dv_);
				CqlInterval<CqlDate> fr_ = context.Operators.Interval(ff_, fq_, true, false);
				bool? fs_ = fr_?.lowClosed;
				Date fu_ = dd_?.BirthDateElement;
				string fv_ = fu_?.Value;
				CqlDate fw_ = context.Operators.ConvertStringToDate(fv_);
				object fy_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object fz_ = context.Operators.LateBoundProperty<object>(fy_, "low");
				CqlDate gb_ = context.Operators.Add(fw_, dk_);
				Date gd_ = dd_?.BirthDateElement;
				string ge_ = gd_?.Value;
				CqlDate gf_ = context.Operators.ConvertStringToDate(ge_);
				object gh_ = FHIRHelpers_4_3_000.ToValue(dh_);
				object gi_ = context.Operators.LateBoundProperty<object>(gh_, "high");
				CqlDate gk_ = context.Operators.Add(gf_, dk_);
				CqlDate gm_ = context.Operators.Add(gk_, dv_);
				CqlInterval<CqlDate> gn_ = context.Operators.Interval(gb_, gm_, true, false);
				bool? go_ = gn_?.highClosed;
				CqlInterval<CqlDateTime> gp_ = context.Operators.Interval(dz_, ew_, fs_, go_);

				return gp_;
			}
			else if (e_())
			{
				DataType gq_ = condition?.Abatement;
				object gr_ = FHIRHelpers_4_3_000.ToValue(gq_);
				object gs_ = context.Operators.LateBoundProperty<object>(gr_, "low");
				CqlDateTime gt_ = gs_ switch { null => null , CqlDateTime d => d/* , CqlQuantity => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				object gv_ = FHIRHelpers_4_3_000.ToValue(gq_);
				object gw_ = context.Operators.LateBoundProperty<object>(gv_, "high");
				CqlInterval<CqlDateTime> gy_ = context.Operators.Interval(gt_, gt_, true, false);

				return gy_;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("ToPrevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from onset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting interval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
    [CqlTag("deprecated", "This function is deprecated. Use the `prevalenceInterval()` fluent function instead")]
	public CqlInterval<CqlDateTime> ToPrevalenceInterval(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				CodeableConcept c_ = condition?.ClinicalStatus;
				CqlConcept d_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode e_ = this.active();
				CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
				bool? g_ = context.Operators.Equivalent(d_, f_);
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode j_ = this.recurrence();
				CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
				bool? l_ = context.Operators.Equivalent(i_, k_);
				bool? m_ = context.Operators.Or(g_, l_);
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode p_ = this.relapse();
				CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
				bool? r_ = context.Operators.Equivalent(o_, q_);
				bool? s_ = context.Operators.Or(m_, r_);

				return s_ ?? false;
			};
			if (b_())
			{
				DataType t_ = condition?.Onset;
				object u_ = FHIRHelpers_4_3_000.ToValue(t_);
				CqlInterval<CqlDateTime> v_ = this.ToInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> x_ = this.ToAbatementInterval(condition);
				CqlDateTime y_ = context.Operators.End(x_);
				CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

				return z_;
			}
			else
			{
				CqlInterval<CqlDateTime> aa_ = this.ToAbatementInterval(condition);
				CqlDateTime ab_ = context.Operators.End(aa_);
				CqlDateTime[] ac_ = [
					ab_,
				];
				CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate)
				{
					CqlInterval<CqlDateTime> ag_()
					{
						if (abatementDate is null)
						{
							DataType ah_ = condition?.Onset;
							object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
							CqlInterval<CqlDateTime> aj_ = this.ToInterval(ai_);
							CqlDateTime ak_ = context.Operators.Start(aj_);
							CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ak_, abatementDate, true, false);

							return al_;
						}
						else
						{
							DataType am_ = condition?.Onset;
							object an_ = FHIRHelpers_4_3_000.ToValue(am_);
							CqlInterval<CqlDateTime> ao_ = this.ToInterval(an_);
							CqlDateTime ap_ = context.Operators.Start(ao_);
							CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, abatementDate, true, true);

							return aq_;
						}
					};

					return ag_();
				};
				IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
				CqlInterval<CqlDateTime> af_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ae_);

				return af_;
			}
		};

		return a_();
	}

    [CqlDeclaration("prevalenceInterval")]
    [CqlTag("description", "Returns an interval representing the normalized prevalence period of a given Condition.")]
    [CqlTag("comment", "Uses the ToInterval and ToAbatementInterval functions to determine the widest potential interval from onset to abatement as specified in the given Condition. If the condition is active, or has an abatement date the resulting interval will have a closed ending boundary. Otherwise, the resulting interval will have an open ending boundary.")]
	public CqlInterval<CqlDateTime> prevalenceInterval(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				CodeableConcept c_ = condition?.ClinicalStatus;
				CqlConcept d_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode e_ = this.active();
				CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
				bool? g_ = context.Operators.Equivalent(d_, f_);
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode j_ = this.recurrence();
				CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
				bool? l_ = context.Operators.Equivalent(i_, k_);
				bool? m_ = context.Operators.Or(g_, l_);
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(c_);
				CqlCode p_ = this.relapse();
				CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
				bool? r_ = context.Operators.Equivalent(o_, q_);
				bool? s_ = context.Operators.Or(m_, r_);

				return s_ ?? false;
			};
			if (b_())
			{
				DataType t_ = condition?.Onset;
				object u_ = FHIRHelpers_4_3_000.ToValue(t_);
				CqlInterval<CqlDateTime> v_ = this.toInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> x_ = this.abatementInterval(condition);
				CqlDateTime y_ = context.Operators.End(x_);
				CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

				return z_;
			}
			else
			{
				CqlInterval<CqlDateTime> aa_ = this.ToAbatementInterval(condition);
				CqlDateTime ab_ = context.Operators.End(aa_);
				CqlDateTime[] ac_ = [
					ab_,
				];
				CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate)
				{
					CqlInterval<CqlDateTime> ag_()
					{
						if (abatementDate is null)
						{
							DataType ah_ = condition?.Onset;
							object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
							CqlInterval<CqlDateTime> aj_ = this.ToInterval(ai_);
							CqlDateTime ak_ = context.Operators.Start(aj_);
							CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ak_, abatementDate, true, false);

							return al_;
						}
						else
						{
							DataType am_ = condition?.Onset;
							object an_ = FHIRHelpers_4_3_000.ToValue(am_);
							CqlInterval<CqlDateTime> ao_ = this.ToInterval(an_);
							CqlDateTime ap_ = context.Operators.Start(ao_);
							CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, abatementDate, true, true);

							return aq_;
						}
					};

					return ag_();
				};
				IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
				CqlInterval<CqlDateTime> af_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ae_);

				return af_;
			}
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in a single-server environment to trace references. However, this function does not attempt to resolve or distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
	public string GetId(string uri)
	{
		IEnumerable<string> a_ = context.Operators.Split(uri, "/");
		string b_ = context.Operators.Last<string>(a_);

		return b_;
	}

    [CqlDeclaration("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in a single-server environment to trace references. However, this function does not attempt to resolve or distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
	public string getId(string uri)
	{
		IEnumerable<string> a_ = context.Operators.Split(uri, "/");
		string b_ = context.Operators.Last<string>(a_);

		return b_;
	}

    [CqlDeclaration("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified (i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified (i.e. the start of the interval is not null and not the minimum DateTime value)")]
	public bool? hasStart(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified (i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.End(period);
		CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified (i.e. the end of the interval is not null and not the maximum DateTime value)")]
	public bool? hasEnd(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.End(period);
		CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified, otherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
	public CqlDateTime Latest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.toInterval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.Start(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified, otherwise, returns the starting point")]
	public CqlDateTime latest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.toInterval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.hasEnd(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.Start(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified, otherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
	public CqlDateTime Earliest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.toInterval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.End(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified, otherwise, return the ending point")]
	public CqlDateTime earliest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.toInterval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.hasStart(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.End(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for the final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		CqlDateTime a_ = context.Operators.Start(Period);
		CqlDateTime b_ = context.Operators.End(Period);
		int? c_ = context.Operators.DurationBetween(a_, b_, "day");
		CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
		CqlInterval<int?>[] e_ = [
			d_,
		];
		IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
		int? g_(CqlInterval<int?> DayNumber)
		{
			int? i_ = context.Operators.End(DayNumber);

			return i_;
		};
		IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for the final day if it is less than 24 hours. This also includes the first 24 hour period.")]
	public IEnumerable<int?> toDayNumbers(CqlInterval<CqlDateTime> Period)
	{
		CqlDateTime a_ = context.Operators.Start(Period);
		CqlDateTime b_ = context.Operators.End(Period);
		int? c_ = context.Operators.DurationBetween(a_, b_, "day");
		CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
		CqlInterval<int?>[] e_ = [
			d_,
		];
		IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
		int? g_(CqlInterval<int?> DayNumber)
		{
			int? i_ = context.Operators.End(DayNumber);

			return i_;
		};
		IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is. Note that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
	public IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(Period);
		(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex)
		{
			CqlDateTime d_ = context.Operators.Start(Period);
			CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
			int? f_ = context.Operators.Subtract(DayIndex, 1);
			CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
			CqlQuantity h_ = context.Operators.Multiply(e_, g_);
			CqlDateTime i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					CqlDateTime n_ = context.Operators.Start(Period);
					CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
					int? p_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
					CqlQuantity r_ = context.Operators.Multiply(o_, q_);
					CqlDateTime s_ = context.Operators.Add(n_, r_);
					CqlDateTime t_ = context.Operators.End(Period);
					int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
					bool? v_ = context.Operators.Less(u_, 24);

					return v_ ?? false;
				};
				if (m_())
				{
					CqlDateTime w_ = context.Operators.Start(Period);
					CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
					int? y_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
					CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
					CqlDateTime ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					CqlDateTime ac_ = context.Operators.Start(Period);
					CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
					CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
					CqlDateTime ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				}
			};
			CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
			(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (DayIndex, k_);

			return l_;
		};
		IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is. Note that the result will include intervals that are closed at the beginning and open at the end")]
	public IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlInterval<CqlDateTime> Period)
	{
		IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(Period);
		(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex)
		{
			CqlDateTime d_ = context.Operators.Start(Period);
			CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
			int? f_ = context.Operators.Subtract(DayIndex, 1);
			CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
			CqlQuantity h_ = context.Operators.Multiply(e_, g_);
			CqlDateTime i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					CqlDateTime n_ = context.Operators.Start(Period);
					CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
					int? p_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
					CqlQuantity r_ = context.Operators.Multiply(o_, q_);
					CqlDateTime s_ = context.Operators.Add(n_, r_);
					CqlDateTime t_ = context.Operators.End(Period);
					int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
					bool? v_ = context.Operators.Less(u_, 24);

					return v_ ?? false;
				};
				if (m_())
				{
					CqlDateTime w_ = context.Operators.Start(Period);
					CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
					int? y_ = context.Operators.Subtract(DayIndex, 1);
					CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
					CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
					CqlDateTime ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					CqlDateTime ac_ = context.Operators.Start(Period);
					CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
					CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
					CqlDateTime ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				}
			};
			CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
			(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (DayIndex, k_);

			return l_;
		};
		IEnumerable<(int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

		return c_;
	}

}
