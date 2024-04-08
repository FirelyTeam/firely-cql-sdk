using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode ER_Value() => 
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ER")]
	public CqlCode ER() => 
		__ER.Value;

	private CqlCode ICU_Value() => 
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ICU")]
	public CqlCode ICU() => 
		__ICU.Value;

	private CqlCode Billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("Billing")]
	public CqlCode Billing() => 
		__Billing.Value;

	private CqlCode ambulatory_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("ambulatory")]
	public CqlCode ambulatory() => 
		__ambulatory.Value;

	private CqlCode emergency_Value() => 
		new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("emergency")]
	public CqlCode emergency() => 
		__emergency.Value;

	private CqlCode field_Value() => 
		new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("field")]
	public CqlCode field() => 
		__field.Value;

	private CqlCode home_health_Value() => 
		new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("home health")]
	public CqlCode home_health() => 
		__home_health.Value;

	private CqlCode inpatient_encounter_Value() => 
		new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("inpatient encounter")]
	public CqlCode inpatient_encounter() => 
		__inpatient_encounter.Value;

	private CqlCode inpatient_acute_Value() => 
		new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("inpatient acute")]
	public CqlCode inpatient_acute() => 
		__inpatient_acute.Value;

	private CqlCode inpatient_non_acute_Value() => 
		new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("inpatient non-acute")]
	public CqlCode inpatient_non_acute() => 
		__inpatient_non_acute.Value;

	private CqlCode observation_encounter_Value() => 
		new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("observation encounter")]
	public CqlCode observation_encounter() => 
		__observation_encounter.Value;

	private CqlCode pre_admission_Value() => 
		new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("pre-admission")]
	public CqlCode pre_admission() => 
		__pre_admission.Value;

	private CqlCode short_stay_Value() => 
		new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("short stay")]
	public CqlCode short_stay() => 
		__short_stay.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode problem_list_item_Value() => 
		new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

    [CqlDeclaration("problem-list-item")]
	public CqlCode problem_list_item() => 
		__problem_list_item.Value;

	private CqlCode encounter_diagnosis_Value() => 
		new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

    [CqlDeclaration("encounter-diagnosis")]
	public CqlCode encounter_diagnosis() => 
		__encounter_diagnosis.Value;

	private CqlCode health_concern_Value() => 
		new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", null, null);

    [CqlDeclaration("health-concern")]
	public CqlCode health_concern() => 
		__health_concern.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode recurrence_Value() => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("recurrence")]
	public CqlCode recurrence() => 
		__recurrence.Value;

	private CqlCode relapse_Value() => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("relapse")]
	public CqlCode relapse() => 
		__relapse.Value;

	private CqlCode inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("inactive")]
	public CqlCode inactive() => 
		__inactive.Value;

	private CqlCode remission_Value() => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("remission")]
	public CqlCode remission() => 
		__remission.Value;

	private CqlCode resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("resolved")]
	public CqlCode resolved() => 
		__resolved.Value;

	private CqlCode unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed() => 
		__unconfirmed.Value;

	private CqlCode provisional_Value() => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("provisional")]
	public CqlCode provisional() => 
		__provisional.Value;

	private CqlCode differential_Value() => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("differential")]
	public CqlCode differential() => 
		__differential.Value;

	private CqlCode confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("confirmed")]
	public CqlCode confirmed() => 
		__confirmed.Value;

	private CqlCode refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("refuted")]
	public CqlCode refuted() => 
		__refuted.Value;

	private CqlCode entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error() => 
		__entered_in_error.Value;

	private CqlCode allergy_active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active() => 
		__allergy_active.Value;

	private CqlCode allergy_inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive() => 
		__allergy_inactive.Value;

	private CqlCode allergy_resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved() => 
		__allergy_resolved.Value;

	private CqlCode allergy_unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed() => 
		__allergy_unconfirmed.Value;

	private CqlCode allergy_confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed() => 
		__allergy_confirmed.Value;

	private CqlCode allergy_refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted() => 
		__allergy_refuted.Value;

	private CqlCode Inpatient_Value() => 
		new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Inpatient")]
	public CqlCode Inpatient() => 
		__Inpatient.Value;

	private CqlCode Outpatient_Value() => 
		new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Outpatient")]
	public CqlCode Outpatient() => 
		__Outpatient.Value;

	private CqlCode Community_Value() => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Community")]
	public CqlCode Community() => 
		__Community.Value;

	private CqlCode Discharge_Value() => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Discharge")]
	public CqlCode Discharge() => 
		__Discharge.Value;

	private CqlCode AD_Value() => 
		new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("AD")]
	public CqlCode AD() => 
		__AD.Value;

	private CqlCode DD_Value() => 
		new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("DD")]
	public CqlCode DD() => 
		__DD.Value;

	private CqlCode CC_Value() => 
		new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("CC")]
	public CqlCode CC() => 
		__CC.Value;

	private CqlCode CM_Value() => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("CM")]
	public CqlCode CM() => 
		__CM.Value;

	private CqlCode pre_op_Value() => 
		new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("pre-op")]
	public CqlCode pre_op() => 
		__pre_op.Value;

	private CqlCode post_op_Value() => 
		new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("post-op")]
	public CqlCode post_op() => 
		__post_op.Value;

	private CqlCode billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("billing")]
	public CqlCode billing() => 
		__billing.Value;

	private CqlCode social_history_Value() => 
		new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("social-history")]
	public CqlCode social_history() => 
		__social_history.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode imaging_Value() => 
		new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("imaging")]
	public CqlCode imaging() => 
		__imaging.Value;

	private CqlCode laboratory_Value() => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("laboratory")]
	public CqlCode laboratory() => 
		__laboratory.Value;

	private CqlCode procedure_Value() => 
		new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("procedure")]
	public CqlCode procedure() => 
		__procedure.Value;

	private CqlCode survey_Value() => 
		new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("survey")]
	public CqlCode survey() => 
		__survey.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode therapy_Value() => 
		new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("therapy")]
	public CqlCode therapy() => 
		__therapy.Value;

	private CqlCode activity_Value() => 
		new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("activity")]
	public CqlCode activity() => 
		__activity.Value;

	private CqlCode clinical_test_Value() => 
		new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null, null);

    [CqlDeclaration("clinical-test")]
	public CqlCode clinical_test() => 
		__clinical_test.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlCode[] RoleCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null),
			new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("RoleCode")]
	public CqlCode[] RoleCode() => 
		__RoleCode.Value;

	private CqlCode[] Diagnosis_Role_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role() => 
		__Diagnosis_Role.Value;

	private CqlCode[] RequestIntent_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("RequestIntent")]
	public CqlCode[] RequestIntent() => 
		__RequestIntent.Value;

	private CqlCode[] MedicationRequestCategory_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
			new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory() => 
		__MedicationRequestCategory.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes() => 
		__ConditionVerificationStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => 
		__AllergyIntoleranceClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => 
		__AllergyIntoleranceVerificationStatusCodes.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlCode[] USCoreObservationCategoryExtensionCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("USCoreObservationCategoryExtensionCodes")]
	public CqlCode[] USCoreObservationCategoryExtensionCodes() => 
		__USCoreObservationCategoryExtensionCodes.Value;

	private CqlCode[] ConditionCategory_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null),
			new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionCategory")]
	public CqlCode[] ConditionCategory() => 
		__ConditionCategory.Value;

	private CqlCode[] USCoreConditionCategoryExtensionCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("USCoreConditionCategoryExtensionCodes")]
	public CqlCode[] USCoreConditionCategoryExtensionCodes() => 
		__USCoreConditionCategoryExtensionCodes.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("isActive")]
    [CqlTag("description", "Returns true if the given condition has a clinical status of active, recurrence, or relapse")]
	public bool? isActive(Condition condition)
	{
		var a_ = FHIRHelpers_4_3_000.ToConcept(condition?.ClinicalStatus);
		var b_ = this.active();
		var c_ = context.Operators.ConvertCodeToConcept(b_);
		var d_ = context.Operators.Equivalent(a_, c_);
		var f_ = this.recurrence();
		var g_ = context.Operators.ConvertCodeToConcept(f_);
		var h_ = context.Operators.Equivalent(a_, g_);
		var i_ = context.Operators.Or(d_, h_);
		var k_ = this.relapse();
		var l_ = context.Operators.ConvertCodeToConcept(k_);
		var m_ = context.Operators.Equivalent(a_, l_);
		var n_ = context.Operators.Or(i_, m_);

		return n_;
	}

    [CqlDeclaration("hasCategory")]
    [CqlTag("description", "Returns true if the given condition has the given category")]
	public bool? hasCategory(Condition condition, CqlCode category)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(condition?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = context.Operators.ConvertCodeToConcept(category);
			var h_ = context.Operators.Equivalent(C, g_);

			return h_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("hasCategory")]
    [CqlTag("description", "Returns true if the given observation has the given category")]
	public bool? hasCategory(Observation observation, CqlCode category)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = context.Operators.ConvertCodeToConcept(category);
			var h_ = context.Operators.Equivalent(C, g_);

			return h_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isProblemListItem")]
    [CqlTag("description", "Returns true if the given condition is a problem list item.")]
	public bool? isProblemListItem(Condition condition)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(condition?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.problem_list_item();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isEncounterDiagnosis")]
    [CqlTag("description", "Returns true if the given condition is an encounter diagnosis")]
	public bool? isEncounterDiagnosis(Condition condition)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(condition?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.encounter_diagnosis();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isHealthConcern")]
    [CqlTag("description", "Returns true if the given condition is a health concern")]
	public bool? isHealthConcern(Condition condition)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(condition?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.health_concern();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isSocialHistory")]
    [CqlTag("description", "Returns true if the given observation is a social history observation")]
	public bool? isSocialHistory(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.social_history();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isVitalSign")]
    [CqlTag("description", "Returns true if the given observation is a vital sign")]
	public bool? isVitalSign(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.vital_signs();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isImaging")]
    [CqlTag("description", "Returns true if the given observation is an imaging observation")]
	public bool? isImaging(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.imaging();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isLaboratory")]
    [CqlTag("description", "Returns true if the given observation is a laboratory observation")]
	public bool? isLaboratory(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.laboratory();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isProcedure")]
    [CqlTag("description", "REturns true if the given observation is a procedure observation")]
	public bool? isProcedure(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.procedure();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isSurvey")]
    [CqlTag("description", "Returns true if the given observation is a survey observation")]
	public bool? isSurvey(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.survey();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isExam")]
    [CqlTag("description", "Returns true if the given observation is an exam observation")]
	public bool? isExam(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.exam();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isTherapy")]
    [CqlTag("description", "Returns true if the given observation is a therapy observation")]
	public bool? isTherapy(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.therapy();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isActivity")]
    [CqlTag("description", "Returns true if the given observation is an activity observation")]
	public bool? isActivity(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.activity();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isClinicalTest")]
    [CqlTag("description", "Returns true if the given observation is a clinical test result")]
	public bool? isClinicalTest(Observation observation)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(observation?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.clinical_test();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isCommunity")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Community")]
	public bool? isCommunity(MedicationRequest medicationRequest)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(medicationRequest?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.Community();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("isDischarge")]
    [CqlTag("description", "Returns true if the given MedicationRequest has a category of Discharge")]
	public bool? isDischarge(MedicationRequest medicationRequest)
	{
		CqlConcept a_(CodeableConcept @this)
		{
			var f_ = FHIRHelpers_4_3_000.ToConcept(@this);

			return f_;
		};
		var b_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(medicationRequest?.Category, a_);
		bool? c_(CqlConcept C)
		{
			var g_ = this.Discharge();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(C, h_);

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<CqlConcept>(b_, c_);
		var e_ = context.Operators.ExistsInList<CqlConcept>(d_);

		return e_;
	}

    [CqlDeclaration("doNotPerform")]
    [CqlTag("description", "Returns true if the given DeviceRequest is a negation (i.e. do not perform this order)")]
	public bool? doNotPerform(DeviceRequest deviceRequest)
	{
		bool? a_(Extension E)
		{
			var f_ = context.Operators.LateBoundProperty<string>(E?.Url, "value");
			var g_ = context.Operators.Equal(f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<Extension>(((deviceRequest is DomainResource)
				? ((deviceRequest as DomainResource).ModifierExtension as IEnumerable<Extension>)
				: (null as IEnumerable<Extension>)), a_);
		bool? c_(Extension E)
		{
			var h_ = FHIRHelpers_4_3_000.ToValue(E?.Value);

			return (bool?)h_;
		};
		var d_ = context.Operators.SelectOrNull<Extension, bool?>(b_, c_);
		var e_ = context.Operators.SingleOrNull<bool?>(d_);

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
				var b_ = context.Operators.Interval((choice as CqlDateTime), (choice as CqlDateTime), true, true);

				return b_;
			}
			else if (choice is CqlInterval<CqlDateTime>)
			{
				return (choice as CqlInterval<CqlDateTime>);
			}
			else if (choice is CqlQuantity)
			{
				var c_ = this.Patient();
				var d_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var e_ = context.Operators.Add(d_, (choice as CqlQuantity));
				var g_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var h_ = context.Operators.Add(g_, (choice as CqlQuantity));
				var i_ = context.Operators.Quantity(1m, "year");
				var j_ = context.Operators.Add(h_, i_);
				var k_ = context.Operators.Interval(e_, j_, true, false);
				var l_ = context.Operators.ConvertDateToDateTime(k_?.low);
				var n_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var o_ = context.Operators.Add(n_, (choice as CqlQuantity));
				var q_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var r_ = context.Operators.Add(q_, (choice as CqlQuantity));
				var t_ = context.Operators.Add(r_, i_);
				var u_ = context.Operators.Interval(o_, t_, true, false);
				var v_ = context.Operators.ConvertDateToDateTime(u_?.high);
				var x_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var y_ = context.Operators.Add(x_, (choice as CqlQuantity));
				var aa_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ab_ = context.Operators.Add(aa_, (choice as CqlQuantity));
				var ad_ = context.Operators.Add(ab_, i_);
				var ae_ = context.Operators.Interval(y_, ad_, true, false);
				var ag_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ah_ = context.Operators.Add(ag_, (choice as CqlQuantity));
				var aj_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ak_ = context.Operators.Add(aj_, (choice as CqlQuantity));
				var am_ = context.Operators.Add(ak_, i_);
				var an_ = context.Operators.Interval(ah_, am_, true, false);
				var ao_ = context.Operators.Interval(l_, v_, ae_?.lowClosed, an_?.highClosed);

				return ao_;
			}
			else if (choice is CqlInterval<CqlQuantity>)
			{
				var ap_ = this.Patient();
				var aq_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var ar_ = context.Operators.LateBoundProperty<object>(choice, "low");
				var as_ = context.Operators.Add(aq_, (ar_ as CqlQuantity));
				var au_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var av_ = context.Operators.LateBoundProperty<object>(choice, "high");
				var aw_ = context.Operators.Add(au_, (av_ as CqlQuantity));
				var ax_ = context.Operators.Quantity(1m, "year");
				var ay_ = context.Operators.Add(aw_, ax_);
				var az_ = context.Operators.Interval(as_, ay_, true, false);
				var ba_ = context.Operators.ConvertDateToDateTime(az_?.low);
				var bc_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var be_ = context.Operators.Add(bc_, (ar_ as CqlQuantity));
				var bg_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bi_ = context.Operators.Add(bg_, (av_ as CqlQuantity));
				var bk_ = context.Operators.Add(bi_, ax_);
				var bl_ = context.Operators.Interval(be_, bk_, true, false);
				var bm_ = context.Operators.ConvertDateToDateTime(bl_?.high);
				var bo_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bq_ = context.Operators.Add(bo_, (ar_ as CqlQuantity));
				var bs_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bu_ = context.Operators.Add(bs_, (av_ as CqlQuantity));
				var bw_ = context.Operators.Add(bu_, ax_);
				var bx_ = context.Operators.Interval(bq_, bw_, true, false);
				var bz_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var cb_ = context.Operators.Add(bz_, (ar_ as CqlQuantity));
				var cd_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var cf_ = context.Operators.Add(cd_, (av_ as CqlQuantity));
				var ch_ = context.Operators.Add(cf_, ax_);
				var ci_ = context.Operators.Interval(cb_, ch_, true, false);
				var cj_ = context.Operators.Interval(ba_, bm_, bx_?.lowClosed, ci_?.highClosed);

				return cj_;
			}
			else if (choice is Timing)
			{
				var ck_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

				return (ck_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				CqlInterval<CqlDateTime> cl_ = null;

				return (cl_ as CqlInterval<CqlDateTime>);
			};
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
				var b_ = context.Operators.Interval((choice as CqlDateTime), (choice as CqlDateTime), true, true);

				return b_;
			}
			else if (choice is CqlInterval<CqlDateTime>)
			{
				return (choice as CqlInterval<CqlDateTime>);
			}
			else if (choice is CqlQuantity)
			{
				var c_ = this.Patient();
				var d_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var e_ = context.Operators.Add(d_, (choice as CqlQuantity));
				var g_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var h_ = context.Operators.Add(g_, (choice as CqlQuantity));
				var i_ = context.Operators.Quantity(1m, "year");
				var j_ = context.Operators.Add(h_, i_);
				var k_ = context.Operators.Interval(e_, j_, true, false);
				var l_ = context.Operators.ConvertDateToDateTime(k_?.low);
				var n_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var o_ = context.Operators.Add(n_, (choice as CqlQuantity));
				var q_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var r_ = context.Operators.Add(q_, (choice as CqlQuantity));
				var t_ = context.Operators.Add(r_, i_);
				var u_ = context.Operators.Interval(o_, t_, true, false);
				var v_ = context.Operators.ConvertDateToDateTime(u_?.high);
				var x_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var y_ = context.Operators.Add(x_, (choice as CqlQuantity));
				var aa_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ab_ = context.Operators.Add(aa_, (choice as CqlQuantity));
				var ad_ = context.Operators.Add(ab_, i_);
				var ae_ = context.Operators.Interval(y_, ad_, true, false);
				var ag_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ah_ = context.Operators.Add(ag_, (choice as CqlQuantity));
				var aj_ = context.Operators.ConvertStringToDate(c_?.BirthDateElement?.Value);
				var ak_ = context.Operators.Add(aj_, (choice as CqlQuantity));
				var am_ = context.Operators.Add(ak_, i_);
				var an_ = context.Operators.Interval(ah_, am_, true, false);
				var ao_ = context.Operators.Interval(l_, v_, ae_?.lowClosed, an_?.highClosed);

				return ao_;
			}
			else if (choice is CqlInterval<CqlQuantity>)
			{
				var ap_ = this.Patient();
				var aq_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var ar_ = context.Operators.LateBoundProperty<object>(choice, "low");
				var as_ = context.Operators.Add(aq_, (ar_ as CqlQuantity));
				var au_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var av_ = context.Operators.LateBoundProperty<object>(choice, "high");
				var aw_ = context.Operators.Add(au_, (av_ as CqlQuantity));
				var ax_ = context.Operators.Quantity(1m, "year");
				var ay_ = context.Operators.Add(aw_, ax_);
				var az_ = context.Operators.Interval(as_, ay_, true, false);
				var ba_ = context.Operators.ConvertDateToDateTime(az_?.low);
				var bc_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var be_ = context.Operators.Add(bc_, (ar_ as CqlQuantity));
				var bg_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bi_ = context.Operators.Add(bg_, (av_ as CqlQuantity));
				var bk_ = context.Operators.Add(bi_, ax_);
				var bl_ = context.Operators.Interval(be_, bk_, true, false);
				var bm_ = context.Operators.ConvertDateToDateTime(bl_?.high);
				var bo_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bq_ = context.Operators.Add(bo_, (ar_ as CqlQuantity));
				var bs_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var bu_ = context.Operators.Add(bs_, (av_ as CqlQuantity));
				var bw_ = context.Operators.Add(bu_, ax_);
				var bx_ = context.Operators.Interval(bq_, bw_, true, false);
				var bz_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var cb_ = context.Operators.Add(bz_, (ar_ as CqlQuantity));
				var cd_ = context.Operators.ConvertStringToDate(ap_?.BirthDateElement?.Value);
				var cf_ = context.Operators.Add(cd_, (av_ as CqlQuantity));
				var ch_ = context.Operators.Add(cf_, ax_);
				var ci_ = context.Operators.Interval(cb_, ch_, true, false);
				var cj_ = context.Operators.Interval(ba_, bm_, bx_?.lowClosed, ci_?.highClosed);

				return cj_;
			}
			else if (choice is Timing)
			{
				var ck_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

				return (ck_ as CqlInterval<CqlDateTime>);
			}
			else
			{
				CqlInterval<CqlDateTime> cl_ = null;

				return (cl_ as CqlInterval<CqlDateTime>);
			};
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
				var f_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var g_ = f_ is CqlDateTime;

				return g_;
			};
			bool c_()
			{
				var h_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var i_ = h_ is CqlQuantity;

				return i_;
			};
			bool d_()
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var k_ = j_ is CqlInterval<CqlQuantity>;

				return k_;
			};
			bool e_()
			{
				var l_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var m_ = l_ is CqlInterval<CqlDateTime>;

				return m_;
			};
			if (b_())
			{
				var n_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var p_ = context.Operators.Interval((n_ as CqlDateTime), (n_ as CqlDateTime), true, true);

				return p_;
			}
			else if (c_())
			{
				var q_ = this.Patient();
				var r_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var s_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var t_ = context.Operators.Add(r_, (s_ as CqlQuantity));
				var v_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var x_ = context.Operators.Add(v_, (s_ as CqlQuantity));
				var y_ = context.Operators.Quantity(1m, "year");
				var z_ = context.Operators.Add(x_, y_);
				var aa_ = context.Operators.Interval(t_, z_, true, false);
				var ab_ = context.Operators.ConvertDateToDateTime(aa_?.low);
				var ad_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var af_ = context.Operators.Add(ad_, (s_ as CqlQuantity));
				var ah_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var aj_ = context.Operators.Add(ah_, (s_ as CqlQuantity));
				var al_ = context.Operators.Add(aj_, y_);
				var am_ = context.Operators.Interval(af_, al_, true, false);
				var an_ = context.Operators.ConvertDateToDateTime(am_?.high);
				var ap_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var ar_ = context.Operators.Add(ap_, (s_ as CqlQuantity));
				var at_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var av_ = context.Operators.Add(at_, (s_ as CqlQuantity));
				var ax_ = context.Operators.Add(av_, y_);
				var ay_ = context.Operators.Interval(ar_, ax_, true, false);
				var ba_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var bc_ = context.Operators.Add(ba_, (s_ as CqlQuantity));
				var be_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var bg_ = context.Operators.Add(be_, (s_ as CqlQuantity));
				var bi_ = context.Operators.Add(bg_, y_);
				var bj_ = context.Operators.Interval(bc_, bi_, true, false);
				var bk_ = context.Operators.Interval(ab_, an_, ay_?.lowClosed, bj_?.highClosed);

				return bk_;
			}
			else if (d_())
			{
				var bl_ = this.Patient();
				var bm_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var bn_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var bo_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var bp_ = context.Operators.Add(bm_, (bo_ as CqlQuantity));
				var br_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var bt_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var bu_ = context.Operators.Add(br_, (bt_ as CqlQuantity));
				var bv_ = context.Operators.Quantity(1m, "year");
				var bw_ = context.Operators.Add(bu_, bv_);
				var bx_ = context.Operators.Interval(bp_, bw_, true, false);
				var by_ = context.Operators.ConvertDateToDateTime(bx_?.low);
				var ca_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cc_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var cd_ = context.Operators.Add(ca_, (cc_ as CqlQuantity));
				var cf_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var ch_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var ci_ = context.Operators.Add(cf_, (ch_ as CqlQuantity));
				var ck_ = context.Operators.Add(ci_, bv_);
				var cl_ = context.Operators.Interval(cd_, ck_, true, false);
				var cm_ = context.Operators.ConvertDateToDateTime(cl_?.high);
				var co_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cq_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var cr_ = context.Operators.Add(co_, (cq_ as CqlQuantity));
				var ct_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cv_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var cw_ = context.Operators.Add(ct_, (cv_ as CqlQuantity));
				var cy_ = context.Operators.Add(cw_, bv_);
				var cz_ = context.Operators.Interval(cr_, cy_, true, false);
				var db_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var dd_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var de_ = context.Operators.Add(db_, (dd_ as CqlQuantity));
				var dg_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var di_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var dj_ = context.Operators.Add(dg_, (di_ as CqlQuantity));
				var dl_ = context.Operators.Add(dj_, bv_);
				var dm_ = context.Operators.Interval(de_, dl_, true, false);
				var dn_ = context.Operators.Interval(by_, cm_, cz_?.lowClosed, dm_?.highClosed);

				return dn_;
			}
			else if (e_())
			{
				var do_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var dp_ = context.Operators.LateBoundProperty<object>(do_, "low");
				var dr_ = context.Operators.LateBoundProperty<object>(do_, "high");
				var ds_ = context.Operators.Interval((dp_ as CqlDateTime), (dr_ as CqlDateTime), true, false);

				return ds_;
			}
			else
			{
				CqlInterval<CqlDateTime> dt_ = null;

				return (dt_ as CqlInterval<CqlDateTime>);
			};
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
				var f_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var g_ = f_ is CqlDateTime;

				return g_;
			};
			bool c_()
			{
				var h_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var i_ = h_ is CqlQuantity;

				return i_;
			};
			bool d_()
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var k_ = j_ is CqlInterval<CqlQuantity>;

				return k_;
			};
			bool e_()
			{
				var l_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var m_ = l_ is CqlInterval<CqlDateTime>;

				return m_;
			};
			if (b_())
			{
				var n_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var p_ = context.Operators.Interval((n_ as CqlDateTime), (n_ as CqlDateTime), true, true);

				return p_;
			}
			else if (c_())
			{
				var q_ = this.Patient();
				var r_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var s_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var t_ = context.Operators.Add(r_, (s_ as CqlQuantity));
				var v_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var x_ = context.Operators.Add(v_, (s_ as CqlQuantity));
				var y_ = context.Operators.Quantity(1m, "year");
				var z_ = context.Operators.Add(x_, y_);
				var aa_ = context.Operators.Interval(t_, z_, true, false);
				var ab_ = context.Operators.ConvertDateToDateTime(aa_?.low);
				var ad_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var af_ = context.Operators.Add(ad_, (s_ as CqlQuantity));
				var ah_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var aj_ = context.Operators.Add(ah_, (s_ as CqlQuantity));
				var al_ = context.Operators.Add(aj_, y_);
				var am_ = context.Operators.Interval(af_, al_, true, false);
				var an_ = context.Operators.ConvertDateToDateTime(am_?.high);
				var ap_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var ar_ = context.Operators.Add(ap_, (s_ as CqlQuantity));
				var at_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var av_ = context.Operators.Add(at_, (s_ as CqlQuantity));
				var ax_ = context.Operators.Add(av_, y_);
				var ay_ = context.Operators.Interval(ar_, ax_, true, false);
				var ba_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var bc_ = context.Operators.Add(ba_, (s_ as CqlQuantity));
				var be_ = context.Operators.ConvertStringToDate(q_?.BirthDateElement?.Value);
				var bg_ = context.Operators.Add(be_, (s_ as CqlQuantity));
				var bi_ = context.Operators.Add(bg_, y_);
				var bj_ = context.Operators.Interval(bc_, bi_, true, false);
				var bk_ = context.Operators.Interval(ab_, an_, ay_?.lowClosed, bj_?.highClosed);

				return bk_;
			}
			else if (d_())
			{
				var bl_ = this.Patient();
				var bm_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var bn_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var bo_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var bp_ = context.Operators.Add(bm_, (bo_ as CqlQuantity));
				var br_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var bt_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var bu_ = context.Operators.Add(br_, (bt_ as CqlQuantity));
				var bv_ = context.Operators.Quantity(1m, "year");
				var bw_ = context.Operators.Add(bu_, bv_);
				var bx_ = context.Operators.Interval(bp_, bw_, true, false);
				var by_ = context.Operators.ConvertDateToDateTime(bx_?.low);
				var ca_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cc_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var cd_ = context.Operators.Add(ca_, (cc_ as CqlQuantity));
				var cf_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var ch_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var ci_ = context.Operators.Add(cf_, (ch_ as CqlQuantity));
				var ck_ = context.Operators.Add(ci_, bv_);
				var cl_ = context.Operators.Interval(cd_, ck_, true, false);
				var cm_ = context.Operators.ConvertDateToDateTime(cl_?.high);
				var co_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cq_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var cr_ = context.Operators.Add(co_, (cq_ as CqlQuantity));
				var ct_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var cv_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var cw_ = context.Operators.Add(ct_, (cv_ as CqlQuantity));
				var cy_ = context.Operators.Add(cw_, bv_);
				var cz_ = context.Operators.Interval(cr_, cy_, true, false);
				var db_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var dd_ = context.Operators.LateBoundProperty<object>(bn_, "low");
				var de_ = context.Operators.Add(db_, (dd_ as CqlQuantity));
				var dg_ = context.Operators.ConvertStringToDate(bl_?.BirthDateElement?.Value);
				var di_ = context.Operators.LateBoundProperty<object>(bn_, "high");
				var dj_ = context.Operators.Add(dg_, (di_ as CqlQuantity));
				var dl_ = context.Operators.Add(dj_, bv_);
				var dm_ = context.Operators.Interval(de_, dl_, true, false);
				var dn_ = context.Operators.Interval(by_, cm_, cz_?.lowClosed, dm_?.highClosed);

				return dn_;
			}
			else if (e_())
			{
				var do_ = FHIRHelpers_4_3_000.ToValue(condition?.Abatement);
				var dp_ = context.Operators.LateBoundProperty<object>(do_, "low");
				var dr_ = context.Operators.LateBoundProperty<object>(do_, "high");
				var ds_ = context.Operators.Interval((dp_ as CqlDateTime), (dr_ as CqlDateTime), true, false);

				return ds_;
			}
			else
			{
				CqlInterval<CqlDateTime> dt_ = null;

				return (dt_ as CqlInterval<CqlDateTime>);
			};
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
				var c_ = FHIRHelpers_4_3_000.ToConcept(condition?.ClinicalStatus);
				var d_ = this.active();
				var e_ = context.Operators.ConvertCodeToConcept(d_);
				var f_ = context.Operators.Equivalent(c_, e_);
				var h_ = this.recurrence();
				var i_ = context.Operators.ConvertCodeToConcept(h_);
				var j_ = context.Operators.Equivalent(c_, i_);
				var k_ = context.Operators.Or(f_, j_);
				var m_ = this.relapse();
				var n_ = context.Operators.ConvertCodeToConcept(m_);
				var o_ = context.Operators.Equivalent(c_, n_);
				var p_ = context.Operators.Or(k_, o_);

				return (p_ ?? false);
			};
			if (b_())
			{
				var q_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
				var r_ = this.ToInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = this.ToAbatementInterval(condition);
				var u_ = context.Operators.End(t_);
				var v_ = context.Operators.Interval(s_, u_, true, true);

				return v_;
			}
			else
			{
				var w_ = this.ToAbatementInterval(condition);
				var x_ = context.Operators.End(w_);
				var y_ = new CqlDateTime[]
				{
					x_,
				};
				CqlInterval<CqlDateTime> z_(CqlDateTime abatementDate)
				{
					CqlInterval<CqlDateTime> ac_()
					{
						if ((abatementDate is null))
						{
							var ad_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
							var ae_ = this.ToInterval(ad_);
							var af_ = context.Operators.Start(ae_);
							var ag_ = context.Operators.Interval(af_, abatementDate, true, false);

							return ag_;
						}
						else
						{
							var ah_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
							var ai_ = this.ToInterval(ah_);
							var aj_ = context.Operators.Start(ai_);
							var ak_ = context.Operators.Interval(aj_, abatementDate, true, true);

							return ak_;
						};
					};

					return ac_();
				};
				var aa_ = context.Operators.SelectOrNull<CqlDateTime, CqlInterval<CqlDateTime>>(y_, z_);
				var ab_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(aa_);

				return ab_;
			};
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
				var c_ = FHIRHelpers_4_3_000.ToConcept(condition?.ClinicalStatus);
				var d_ = this.active();
				var e_ = context.Operators.ConvertCodeToConcept(d_);
				var f_ = context.Operators.Equivalent(c_, e_);
				var h_ = this.recurrence();
				var i_ = context.Operators.ConvertCodeToConcept(h_);
				var j_ = context.Operators.Equivalent(c_, i_);
				var k_ = context.Operators.Or(f_, j_);
				var m_ = this.relapse();
				var n_ = context.Operators.ConvertCodeToConcept(m_);
				var o_ = context.Operators.Equivalent(c_, n_);
				var p_ = context.Operators.Or(k_, o_);

				return (p_ ?? false);
			};
			if (b_())
			{
				var q_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
				var r_ = this.toInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = this.abatementInterval(condition);
				var u_ = context.Operators.End(t_);
				var v_ = context.Operators.Interval(s_, u_, true, true);

				return v_;
			}
			else
			{
				var w_ = this.ToAbatementInterval(condition);
				var x_ = context.Operators.End(w_);
				var y_ = new CqlDateTime[]
				{
					x_,
				};
				CqlInterval<CqlDateTime> z_(CqlDateTime abatementDate)
				{
					CqlInterval<CqlDateTime> ac_()
					{
						if ((abatementDate is null))
						{
							var ad_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
							var ae_ = this.ToInterval(ad_);
							var af_ = context.Operators.Start(ae_);
							var ag_ = context.Operators.Interval(af_, abatementDate, true, false);

							return ag_;
						}
						else
						{
							var ah_ = FHIRHelpers_4_3_000.ToValue(condition?.Onset);
							var ai_ = this.ToInterval(ah_);
							var aj_ = context.Operators.Start(ai_);
							var ak_ = context.Operators.Interval(aj_, abatementDate, true, true);

							return ak_;
						};
					};

					return ac_();
				};
				var aa_ = context.Operators.SelectOrNull<CqlDateTime, CqlInterval<CqlDateTime>>(y_, z_);
				var ab_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(aa_);

				return ab_;
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in a single-server environment to trace references. However, this function does not attempt to resolve or distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getId()` instead")]
	public string GetId(string uri)
	{
		var a_ = context.Operators.Split(uri, "/");
		var b_ = context.Operators.LastOfList<string>(a_);

		return b_;
	}

    [CqlDeclaration("getId")]
    [CqlTag("description", "Returns the tail of the given uri (i.e. everything after the last slash in the URI).")]
    [CqlTag("comment", "This function can be used to determine the logical id of a given resource. It can be used in a single-server environment to trace references. However, this function does not attempt to resolve or distinguish the base of the given url, and so cannot be used safely in multi-server environments.")]
	public string getId(string uri)
	{
		var a_ = context.Operators.Split(uri, "/");
		var b_ = context.Operators.LastOfList<string>(a_);

		return b_;
	}

    [CqlDeclaration("HasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified (i.e. the start of the interval is not null and not the minimum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Uee the fluent function `hasStart()` instead")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.Start(period);
		var c_ = context.Operators.Minimum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("hasStart")]
    [CqlTag("description", "Given an interval, return true if the interval has a starting boundary specified (i.e. the start of the interval is not null and not the minimum DateTime value)")]
	public bool? hasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.Start(period);
		var c_ = context.Operators.Minimum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified (i.e. the end of the interval is not null and not the maximum DateTime value)")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hasEnd()` instead")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.End(period);
		var c_ = context.Operators.Maximum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("hasEnd")]
    [CqlTag("description", "Given an interval, returns true if the interval has an ending boundary specified (i.e. the end of the interval is not null and not the maximum DateTime value)")]
	public bool? hasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.End(period);
		var c_ = context.Operators.Maximum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified, otherwise, returns the starting point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `latest()` instead")]
	public CqlDateTime Latest(object choice)
	{
		var a_ = this.toInterval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(period) ?? false))
				{
					var g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.Start(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("latest")]
    [CqlTag("description", "Given an interval, returns the ending point if the interval has an ending boundary specified, otherwise, returns the starting point")]
	public CqlDateTime latest(object choice)
	{
		var a_ = this.toInterval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.hasEnd(period) ?? false))
				{
					var g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.Start(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified, otherwise, return the ending point")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `earliest()` instead")]
	public CqlDateTime Earliest(object choice)
	{
		var a_ = this.toInterval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(period) ?? false))
				{
					var g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.End(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("earliest")]
    [CqlTag("description", "Given an interval, return the starting point if the interval has a starting boundary specified, otherwise, return the ending point")]
	public CqlDateTime earliest(object choice)
	{
		var a_ = this.toInterval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.hasStart(period) ?? false))
				{
					var g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.End(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Interval To Day Numbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for the final day if it is less than 24 hours. This also includes the first 24 hour period.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `toDayNumbers()` instead")]
	public IEnumerable<int?> Interval_To_Day_Numbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var c_ = context.Operators.DurationBetween(a_, b_, "day");
		var d_ = context.Operators.Interval((int?)1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = context.Operators.ExpandList((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayNumber)
		{
			var i_ = context.Operators.End(DayNumber);

			return i_;
		};
		var h_ = context.Operators.SelectOrNull<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("toDayNumbers")]
    [CqlTag("description", "Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for the final day if it is less than 24 hours. This also includes the first 24 hour period.")]
	public IEnumerable<int?> toDayNumbers(CqlInterval<CqlDateTime> Period)
	{
		var a_ = context.Operators.Start(Period);
		var b_ = context.Operators.End(Period);
		var c_ = context.Operators.DurationBetween(a_, b_, "day");
		var d_ = context.Operators.Interval((int?)1, c_, true, true);
		var e_ = new CqlInterval<int?>[]
		{
			d_,
		};
		var f_ = context.Operators.ExpandList((e_ as IEnumerable<CqlInterval<int?>>), null);
		int? g_(CqlInterval<int?> DayNumber)
		{
			var i_ = context.Operators.End(DayNumber);

			return i_;
		};
		var h_ = context.Operators.SelectOrNull<CqlInterval<int?>, int?>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Days In Period")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is. Note that the result will include intervals that are closed at the beginning and open at the end")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `daysInPeriod()` instead")]
	public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> Days_In_Period(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(Period);
		Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf b_(int? DayIndex)
		{
			var d_ = context.Operators.Start(Period);
			var e_ = context.Operators.Quantity(24m, "hours");
			var f_ = context.Operators.Subtract(DayIndex, (int?)1);
			var g_ = context.Operators.ConvertIntegerToQuantity(f_);
			var h_ = context.Operators.Multiply(e_, g_);
			var i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					var n_ = context.Operators.Start(Period);
					var o_ = context.Operators.Quantity(24m, "hours");
					var p_ = context.Operators.Subtract(DayIndex, (int?)1);
					var q_ = context.Operators.ConvertIntegerToQuantity(p_);
					var r_ = context.Operators.Multiply(o_, q_);
					var s_ = context.Operators.Add(n_, r_);
					var t_ = context.Operators.End(Period);
					var u_ = context.Operators.DurationBetween(s_, t_, "hour");
					var v_ = context.Operators.Less(u_, (int?)24);

					return (v_ ?? false);
				};
				if (m_())
				{
					var w_ = context.Operators.Start(Period);
					var x_ = context.Operators.Quantity(24m, "hours");
					var y_ = context.Operators.Subtract(DayIndex, (int?)1);
					var z_ = context.Operators.ConvertIntegerToQuantity(y_);
					var aa_ = context.Operators.Multiply(x_, z_);
					var ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					var ac_ = context.Operators.Start(Period);
					var ad_ = context.Operators.Quantity(24m, "hours");
					var ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					var af_ = context.Operators.Multiply(ad_, ae_);
					var ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				};
			};
			var k_ = context.Operators.Interval(i_, j_(), true, false);
			var l_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		var c_ = context.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return c_;
	}

    [CqlDeclaration("daysInPeriod")]
    [CqlTag("description", "Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is. Note that the result will include intervals that are closed at the beginning and open at the end")]
	public IEnumerable<Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf> daysInPeriod(CqlInterval<CqlDateTime> Period)
	{
		var a_ = this.Interval_To_Day_Numbers(Period);
		Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf b_(int? DayIndex)
		{
			var d_ = context.Operators.Start(Period);
			var e_ = context.Operators.Quantity(24m, "hours");
			var f_ = context.Operators.Subtract(DayIndex, (int?)1);
			var g_ = context.Operators.ConvertIntegerToQuantity(f_);
			var h_ = context.Operators.Multiply(e_, g_);
			var i_ = context.Operators.Add(d_, h_);
			CqlDateTime j_()
			{
				bool m_()
				{
					var n_ = context.Operators.Start(Period);
					var o_ = context.Operators.Quantity(24m, "hours");
					var p_ = context.Operators.Subtract(DayIndex, (int?)1);
					var q_ = context.Operators.ConvertIntegerToQuantity(p_);
					var r_ = context.Operators.Multiply(o_, q_);
					var s_ = context.Operators.Add(n_, r_);
					var t_ = context.Operators.End(Period);
					var u_ = context.Operators.DurationBetween(s_, t_, "hour");
					var v_ = context.Operators.Less(u_, (int?)24);

					return (v_ ?? false);
				};
				if (m_())
				{
					var w_ = context.Operators.Start(Period);
					var x_ = context.Operators.Quantity(24m, "hours");
					var y_ = context.Operators.Subtract(DayIndex, (int?)1);
					var z_ = context.Operators.ConvertIntegerToQuantity(y_);
					var aa_ = context.Operators.Multiply(x_, z_);
					var ab_ = context.Operators.Add(w_, aa_);

					return ab_;
				}
				else
				{
					var ac_ = context.Operators.Start(Period);
					var ad_ = context.Operators.Quantity(24m, "hours");
					var ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
					var af_ = context.Operators.Multiply(ad_, ae_);
					var ag_ = context.Operators.Add(ac_, af_);

					return ag_;
				};
			};
			var k_ = context.Operators.Interval(i_, j_(), true, false);
			var l_ = new Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf
			{
				dayIndex = DayIndex,
				dayPeriod = k_,
			};

			return l_;
		};
		var c_ = context.Operators.SelectOrNull<int?, Tuples.Tuple_BZfjDHYASdKbVKTOeigaYPBVf>(a_, b_);

		return c_;
	}

}
