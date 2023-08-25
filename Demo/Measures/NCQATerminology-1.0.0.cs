using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("NCQATerminology", "1.0.0")]
public class NCQATerminology_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __problem_list_item;
    internal Lazy<CqlCode> __encounter_diagnosis;
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
    internal Lazy<CqlCode> __food;
    internal Lazy<CqlCode> __medication;
    internal Lazy<CqlCode> __environment;
    internal Lazy<CqlCode> __biologic;
    internal Lazy<CqlCode> __Allergy;
    internal Lazy<CqlCode> __Intolerance;
    internal Lazy<CqlCode> __Inpatient;
    internal Lazy<CqlCode> __Outpatient;
    internal Lazy<CqlCode> __Community;
    internal Lazy<CqlCode> __Discharge;
    internal Lazy<CqlCode> __Pharmacy;
    internal Lazy<CqlCode> __Institutional;
    internal Lazy<CqlCode> __Professional;
    internal Lazy<CqlCode> __Oral;
    internal Lazy<CqlCode> __Vision;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode> __ambulatory;
    internal Lazy<CqlCode> __home_health;
    internal Lazy<CqlCode> __inpatient_non_acute;
    internal Lazy<CqlCode> __emergency;
    internal Lazy<CqlCode> __inpatient_acute;
    internal Lazy<CqlCode> __drug_policy;
    internal Lazy<CqlCode> __mental_health_policy;
    internal Lazy<CqlCode> __managed_care_policy;
    internal Lazy<CqlCode> __subsidized_health_program;
    internal Lazy<CqlCode> __retiree_health_program;
    internal Lazy<CqlCode> __substance_use_policy;
    internal Lazy<CqlCode> __Provider_number;
    internal Lazy<CqlCode[]> __ConditionCategoryCodes;
    internal Lazy<CqlCode[]> __ConditionClinicalStatusCodes;
    internal Lazy<CqlCode[]> __ConditionVerificationStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceClinicalStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceVerificationStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceCategory;
    internal Lazy<CqlCode[]> __AllergyIntoleranceType;
    internal Lazy<CqlCode[]> __MedicationRequestCategory;
    internal Lazy<CqlCode[]> __claim_type;
    internal Lazy<CqlCode[]> __ActEncounterCodes;
    internal Lazy<CqlCode[]> __coverage_type;
    internal Lazy<CqlCode[]> __IdentifierType;

    #endregion
    public NCQATerminology_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __problem_list_item = new Lazy<CqlCode>(this.problem_list_item_Value);
        __encounter_diagnosis = new Lazy<CqlCode>(this.encounter_diagnosis_Value);
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
        __food = new Lazy<CqlCode>(this.food_Value);
        __medication = new Lazy<CqlCode>(this.medication_Value);
        __environment = new Lazy<CqlCode>(this.environment_Value);
        __biologic = new Lazy<CqlCode>(this.biologic_Value);
        __Allergy = new Lazy<CqlCode>(this.Allergy_Value);
        __Intolerance = new Lazy<CqlCode>(this.Intolerance_Value);
        __Inpatient = new Lazy<CqlCode>(this.Inpatient_Value);
        __Outpatient = new Lazy<CqlCode>(this.Outpatient_Value);
        __Community = new Lazy<CqlCode>(this.Community_Value);
        __Discharge = new Lazy<CqlCode>(this.Discharge_Value);
        __Pharmacy = new Lazy<CqlCode>(this.Pharmacy_Value);
        __Institutional = new Lazy<CqlCode>(this.Institutional_Value);
        __Professional = new Lazy<CqlCode>(this.Professional_Value);
        __Oral = new Lazy<CqlCode>(this.Oral_Value);
        __Vision = new Lazy<CqlCode>(this.Vision_Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __ambulatory = new Lazy<CqlCode>(this.ambulatory_Value);
        __home_health = new Lazy<CqlCode>(this.home_health_Value);
        __inpatient_non_acute = new Lazy<CqlCode>(this.inpatient_non_acute_Value);
        __emergency = new Lazy<CqlCode>(this.emergency_Value);
        __inpatient_acute = new Lazy<CqlCode>(this.inpatient_acute_Value);
        __drug_policy = new Lazy<CqlCode>(this.drug_policy_Value);
        __mental_health_policy = new Lazy<CqlCode>(this.mental_health_policy_Value);
        __managed_care_policy = new Lazy<CqlCode>(this.managed_care_policy_Value);
        __subsidized_health_program = new Lazy<CqlCode>(this.subsidized_health_program_Value);
        __retiree_health_program = new Lazy<CqlCode>(this.retiree_health_program_Value);
        __substance_use_policy = new Lazy<CqlCode>(this.substance_use_policy_Value);
        __Provider_number = new Lazy<CqlCode>(this.Provider_number_Value);
        __ConditionCategoryCodes = new Lazy<CqlCode[]>(this.ConditionCategoryCodes_Value);
        __ConditionClinicalStatusCodes = new Lazy<CqlCode[]>(this.ConditionClinicalStatusCodes_Value);
        __ConditionVerificationStatusCodes = new Lazy<CqlCode[]>(this.ConditionVerificationStatusCodes_Value);
        __AllergyIntoleranceClinicalStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceClinicalStatusCodes_Value);
        __AllergyIntoleranceVerificationStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceVerificationStatusCodes_Value);
        __AllergyIntoleranceCategory = new Lazy<CqlCode[]>(this.AllergyIntoleranceCategory_Value);
        __AllergyIntoleranceType = new Lazy<CqlCode[]>(this.AllergyIntoleranceType_Value);
        __MedicationRequestCategory = new Lazy<CqlCode[]>(this.MedicationRequestCategory_Value);
        __claim_type = new Lazy<CqlCode[]>(this.claim_type_Value);
        __ActEncounterCodes = new Lazy<CqlCode[]>(this.ActEncounterCodes_Value);
        __coverage_type = new Lazy<CqlCode[]>(this.coverage_type_Value);
        __IdentifierType = new Lazy<CqlCode[]>(this.IdentifierType_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private CqlCode problem_list_item_Value()
	{
		var a_ = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

		return a_;
	}

    [CqlDeclaration("problem-list-item")]
    public CqlCode problem_list_item() => __problem_list_item.Value;

    private CqlCode encounter_diagnosis_Value()
	{
		var a_ = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

		return a_;
	}

    [CqlDeclaration("encounter-diagnosis")]
    public CqlCode encounter_diagnosis() => __encounter_diagnosis.Value;

    private CqlCode active_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("active")]
    public CqlCode active() => __active.Value;

    private CqlCode recurrence_Value()
	{
		var a_ = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("recurrence")]
    public CqlCode recurrence() => __recurrence.Value;

    private CqlCode relapse_Value()
	{
		var a_ = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("relapse")]
    public CqlCode relapse() => __relapse.Value;

    private CqlCode inactive_Value()
	{
		var a_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("inactive")]
    public CqlCode inactive() => __inactive.Value;

    private CqlCode remission_Value()
	{
		var a_ = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("remission")]
    public CqlCode remission() => __remission.Value;

    private CqlCode resolved_Value()
	{
		var a_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("resolved")]
    public CqlCode resolved() => __resolved.Value;

    private CqlCode unconfirmed_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("unconfirmed")]
    public CqlCode unconfirmed() => __unconfirmed.Value;

    private CqlCode provisional_Value()
	{
		var a_ = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("provisional")]
    public CqlCode provisional() => __provisional.Value;

    private CqlCode differential_Value()
	{
		var a_ = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("differential")]
    public CqlCode differential() => __differential.Value;

    private CqlCode confirmed_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("confirmed")]
    public CqlCode confirmed() => __confirmed.Value;

    private CqlCode refuted_Value()
	{
		var a_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("refuted")]
    public CqlCode refuted() => __refuted.Value;

    private CqlCode entered_in_error_Value()
	{
		var a_ = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

		return a_;
	}

    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error() => __entered_in_error.Value;

    private CqlCode allergy_active_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active() => __allergy_active.Value;

    private CqlCode allergy_inactive_Value()
	{
		var a_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive() => __allergy_inactive.Value;

    private CqlCode allergy_resolved_Value()
	{
		var a_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved() => __allergy_resolved.Value;

    private CqlCode allergy_unconfirmed_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed() => __allergy_unconfirmed.Value;

    private CqlCode allergy_confirmed_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed() => __allergy_confirmed.Value;

    private CqlCode allergy_refuted_Value()
	{
		var a_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted() => __allergy_refuted.Value;

    private CqlCode food_Value()
	{
		var a_ = new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

		return a_;
	}

    [CqlDeclaration("food")]
    public CqlCode food() => __food.Value;

    private CqlCode medication_Value()
	{
		var a_ = new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

		return a_;
	}

    [CqlDeclaration("medication")]
    public CqlCode medication() => __medication.Value;

    private CqlCode environment_Value()
	{
		var a_ = new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

		return a_;
	}

    [CqlDeclaration("environment")]
    public CqlCode environment() => __environment.Value;

    private CqlCode biologic_Value()
	{
		var a_ = new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

		return a_;
	}

    [CqlDeclaration("biologic")]
    public CqlCode biologic() => __biologic.Value;

    private CqlCode Allergy_Value()
	{
		var a_ = new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", null, null);

		return a_;
	}

    [CqlDeclaration("Allergy")]
    public CqlCode Allergy() => __Allergy.Value;

    private CqlCode Intolerance_Value()
	{
		var a_ = new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", null, null);

		return a_;
	}

    [CqlDeclaration("Intolerance")]
    public CqlCode Intolerance() => __Intolerance.Value;

    private CqlCode Inpatient_Value()
	{
		var a_ = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Inpatient")]
    public CqlCode Inpatient() => __Inpatient.Value;

    private CqlCode Outpatient_Value()
	{
		var a_ = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Outpatient")]
    public CqlCode Outpatient() => __Outpatient.Value;

    private CqlCode Community_Value()
	{
		var a_ = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Community")]
    public CqlCode Community() => __Community.Value;

    private CqlCode Discharge_Value()
	{
		var a_ = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Discharge")]
    public CqlCode Discharge() => __Discharge.Value;

    private CqlCode Pharmacy_Value()
	{
		var a_ = new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

		return a_;
	}

    [CqlDeclaration("Pharmacy")]
    public CqlCode Pharmacy() => __Pharmacy.Value;

    private CqlCode Institutional_Value()
	{
		var a_ = new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

		return a_;
	}

    [CqlDeclaration("Institutional")]
    public CqlCode Institutional() => __Institutional.Value;

    private CqlCode Professional_Value()
	{
		var a_ = new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

		return a_;
	}

    [CqlDeclaration("Professional")]
    public CqlCode Professional() => __Professional.Value;

    private CqlCode Oral_Value()
	{
		var a_ = new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

		return a_;
	}

    [CqlDeclaration("Oral")]
    public CqlCode Oral() => __Oral.Value;

    private CqlCode Vision_Value()
	{
		var a_ = new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

		return a_;
	}

    [CqlDeclaration("Vision")]
    public CqlCode Vision() => __Vision.Value;

    private CqlCode @virtual_Value()
	{
		var a_ = new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("virtual")]
    public CqlCode @virtual() => __virtual.Value;

    private CqlCode ambulatory_Value()
	{
		var a_ = new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("ambulatory")]
    public CqlCode ambulatory() => __ambulatory.Value;

    private CqlCode home_health_Value()
	{
		var a_ = new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("home health")]
    public CqlCode home_health() => __home_health.Value;

    private CqlCode inpatient_non_acute_Value()
	{
		var a_ = new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("inpatient non-acute")]
    public CqlCode inpatient_non_acute() => __inpatient_non_acute.Value;

    private CqlCode emergency_Value()
	{
		var a_ = new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("emergency")]
    public CqlCode emergency() => __emergency.Value;

    private CqlCode inpatient_acute_Value()
	{
		var a_ = new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

		return a_;
	}

    [CqlDeclaration("inpatient acute")]
    public CqlCode inpatient_acute() => __inpatient_acute.Value;

    private CqlCode drug_policy_Value()
	{
		var a_ = new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("drug policy")]
    public CqlCode drug_policy() => __drug_policy.Value;

    private CqlCode mental_health_policy_Value()
	{
		var a_ = new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("mental health policy")]
    public CqlCode mental_health_policy() => __mental_health_policy.Value;

    private CqlCode managed_care_policy_Value()
	{
		var a_ = new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("managed care policy")]
    public CqlCode managed_care_policy() => __managed_care_policy.Value;

    private CqlCode subsidized_health_program_Value()
	{
		var a_ = new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("subsidized health program")]
    public CqlCode subsidized_health_program() => __subsidized_health_program.Value;

    private CqlCode retiree_health_program_Value()
	{
		var a_ = new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("retiree health program")]
    public CqlCode retiree_health_program() => __retiree_health_program.Value;

    private CqlCode substance_use_policy_Value()
	{
		var a_ = new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

		return a_;
	}

    [CqlDeclaration("substance use policy")]
    public CqlCode substance_use_policy() => __substance_use_policy.Value;

    private CqlCode Provider_number_Value()
	{
		var a_ = new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", null, null);

		return a_;
	}

    [CqlDeclaration("Provider number")]
    public CqlCode Provider_number() => __Provider_number.Value;

    private CqlCode[] ConditionCategoryCodes_Value()
	{
		var a_ = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);
		var b_ = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);
		var c_ = new CqlCode[]
		{
			a_,
			b_,
		};

		return c_;
	}

    [CqlDeclaration("ConditionCategoryCodes")]
    public CqlCode[] ConditionCategoryCodes() => __ConditionCategoryCodes.Value;

    private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var b_ = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var c_ = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var d_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var e_ = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var f_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes() => __ConditionClinicalStatusCodes.Value;

    private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var b_ = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var c_ = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var d_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var e_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var f_ = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes() => __ConditionVerificationStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var b_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var c_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var d_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
		};

		return d_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => __AllergyIntoleranceClinicalStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var b_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var c_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var d_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
		};

		return d_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => __AllergyIntoleranceVerificationStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceCategory_Value()
	{
		var a_ = new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", null, null);
		var b_ = new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", null, null);
		var c_ = new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", null, null);
		var d_ = new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", null, null);
		var e_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
		};

		return e_;
	}

    [CqlDeclaration("AllergyIntoleranceCategory")]
    public CqlCode[] AllergyIntoleranceCategory() => __AllergyIntoleranceCategory.Value;

    private CqlCode[] AllergyIntoleranceType_Value()
	{
		var a_ = new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", null, null);
		var b_ = new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", null, null);
		var c_ = new CqlCode[]
		{
			a_,
			b_,
		};

		return c_;
	}

    [CqlDeclaration("AllergyIntoleranceType")]
    public CqlCode[] AllergyIntoleranceType() => __AllergyIntoleranceType.Value;

    private CqlCode[] MedicationRequestCategory_Value()
	{
		var a_ = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var b_ = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var c_ = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var d_ = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var e_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
		};

		return e_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory() => __MedicationRequestCategory.Value;

    private CqlCode[] claim_type_Value()
	{
		var a_ = new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);
		var b_ = new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);
		var c_ = new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);
		var d_ = new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);
		var e_ = new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);
		var f_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
		};

		return f_;
	}

    [CqlDeclaration("claim-type")]
    public CqlCode[] claim_type() => __claim_type.Value;

    private CqlCode[] ActEncounterCodes_Value()
	{
		var a_ = new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var b_ = new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var c_ = new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var d_ = new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var e_ = new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var f_ = new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("ActEncounterCodes")]
    public CqlCode[] ActEncounterCodes() => __ActEncounterCodes.Value;

    private CqlCode[] coverage_type_Value()
	{
		var a_ = new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var b_ = new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var c_ = new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var d_ = new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var e_ = new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var f_ = new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("coverage-type")]
    public CqlCode[] coverage_type() => __coverage_type.Value;

    private CqlCode[] IdentifierType_Value()
	{
		var a_ = new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("IdentifierType")]
    public CqlCode[] IdentifierType() => __IdentifierType.Value;

}