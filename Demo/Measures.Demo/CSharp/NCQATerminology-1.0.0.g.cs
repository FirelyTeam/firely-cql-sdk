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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("NCQATerminology", "1.0.0")]
public partial class NCQATerminology_1_0_0 : ILibrary, ISingleton<NCQATerminology_1_0_0>
{
private NCQATerminology_1_0_0() {}

public static NCQATerminology_1_0_0 Instance { get; } = new();

    #region Library Members
    public string Name => "NCQATerminology";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];
    #endregion Library Members

    [CqlDeclaration("problem-list-item")]
	public CqlCode problem_list_item(CqlContext context) => 
		new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);


    [CqlDeclaration("encounter-diagnosis")]
	public CqlCode encounter_diagnosis(CqlContext context) => 
		new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);


    [CqlDeclaration("active")]
	public CqlCode active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("recurrence")]
	public CqlCode recurrence(CqlContext context) => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("relapse")]
	public CqlCode relapse(CqlContext context) => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("inactive")]
	public CqlCode inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("remission")]
	public CqlCode remission(CqlContext context) => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("resolved")]
	public CqlCode resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("provisional")]
	public CqlCode provisional(CqlContext context) => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("differential")]
	public CqlCode differential(CqlContext context) => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("confirmed")]
	public CqlCode confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("refuted")]
	public CqlCode refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error(CqlContext context) => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);


    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("food")]
	public CqlCode food(CqlContext context) => 
		new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", default, default);


    [CqlDeclaration("medication")]
	public CqlCode medication(CqlContext context) => 
		new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", default, default);


    [CqlDeclaration("environment")]
	public CqlCode environment(CqlContext context) => 
		new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", default, default);


    [CqlDeclaration("biologic")]
	public CqlCode biologic(CqlContext context) => 
		new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", default, default);


    [CqlDeclaration("Allergy")]
	public CqlCode Allergy(CqlContext context) => 
		new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", default, default);


    [CqlDeclaration("Intolerance")]
	public CqlCode Intolerance(CqlContext context) => 
		new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", default, default);


    [CqlDeclaration("Inpatient")]
	public CqlCode Inpatient(CqlContext context) => 
		new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Outpatient")]
	public CqlCode Outpatient(CqlContext context) => 
		new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Community")]
	public CqlCode Community(CqlContext context) => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Discharge")]
	public CqlCode Discharge(CqlContext context) => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Pharmacy")]
	public CqlCode Pharmacy(CqlContext context) => 
		new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);


    [CqlDeclaration("Institutional")]
	public CqlCode Institutional(CqlContext context) => 
		new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);


    [CqlDeclaration("Professional")]
	public CqlCode Professional(CqlContext context) => 
		new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);


    [CqlDeclaration("Oral")]
	public CqlCode Oral(CqlContext context) => 
		new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);


    [CqlDeclaration("Vision")]
	public CqlCode Vision(CqlContext context) => 
		new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);


    [CqlDeclaration("virtual")]
	public CqlCode @virtual(CqlContext context) => 
		new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("ambulatory")]
	public CqlCode ambulatory(CqlContext context) => 
		new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("home health")]
	public CqlCode home_health(CqlContext context) => 
		new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("inpatient non-acute")]
	public CqlCode inpatient_non_acute(CqlContext context) => 
		new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("emergency")]
	public CqlCode emergency(CqlContext context) => 
		new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("inpatient acute")]
	public CqlCode inpatient_acute(CqlContext context) => 
		new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);


    [CqlDeclaration("drug policy")]
	public CqlCode drug_policy(CqlContext context) => 
		new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("mental health policy")]
	public CqlCode mental_health_policy(CqlContext context) => 
		new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("managed care policy")]
	public CqlCode managed_care_policy(CqlContext context) => 
		new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("subsidized health program")]
	public CqlCode subsidized_health_program(CqlContext context) => 
		new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("retiree health program")]
	public CqlCode retiree_health_program(CqlContext context) => 
		new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("substance use policy")]
	public CqlCode substance_use_policy(CqlContext context) => 
		new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);


    [CqlDeclaration("Provider number")]
	public CqlCode Provider_number(CqlContext context) => 
		new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("RoleCode")]
	public CqlCode[] RoleCode(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("RequestIntent")]
	public CqlCode[] RequestIntent(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
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


    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AllergyIntoleranceType")]
	public CqlCode[] AllergyIntoleranceType(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", default, default),
			new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", default, default),
		];

		return a_;
	}


    [CqlDeclaration("AllergyIntoleranceCategory")]
	public CqlCode[] AllergyIntoleranceCategory(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
			new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
			new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
			new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ConditionCategoryCodes")]
	public CqlCode[] ConditionCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
			new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
		];

		return a_;
	}


    [CqlDeclaration("claim-type")]
	public CqlCode[] claim_type(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
			new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
			new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
			new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
			new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ActEncounterCodes")]
	public CqlCode[] ActEncounterCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
			new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
			new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
			new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
			new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
			new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
		];

		return a_;
	}


    [CqlDeclaration("coverage-type")]
	public CqlCode[] coverage_type(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
			new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
			new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
			new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
			new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
			new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
		];

		return a_;
	}


    [CqlDeclaration("IdentifierType")]
	public CqlCode[] IdentifierType(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", default, default),
		];

		return a_;
	}

}
