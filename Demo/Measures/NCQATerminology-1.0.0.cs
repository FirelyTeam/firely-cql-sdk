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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("NCQATerminology", "1.0.0")]
public class NCQATerminology_1_0_0
{

    public static NCQATerminology_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("problem-list-item")]
	public CqlCode problem_list_item(CqlContext context) => 
		new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

    [CqlDeclaration("encounter-diagnosis")]
	public CqlCode encounter_diagnosis(CqlContext context) => 
		new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null);

    [CqlDeclaration("active")]
	public CqlCode active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("recurrence")]
	public CqlCode recurrence(CqlContext context) => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("relapse")]
	public CqlCode relapse(CqlContext context) => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("inactive")]
	public CqlCode inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("remission")]
	public CqlCode remission(CqlContext context) => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("resolved")]
	public CqlCode resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("provisional")]
	public CqlCode provisional(CqlContext context) => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("differential")]
	public CqlCode differential(CqlContext context) => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("confirmed")]
	public CqlCode confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("refuted")]
	public CqlCode refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error(CqlContext context) => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null);

    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active(CqlContext context) => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive(CqlContext context) => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved(CqlContext context) => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed(CqlContext context) => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed(CqlContext context) => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted(CqlContext context) => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("food")]
	public CqlCode food(CqlContext context) => 
		new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

    [CqlDeclaration("medication")]
	public CqlCode medication(CqlContext context) => 
		new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

    [CqlDeclaration("environment")]
	public CqlCode environment(CqlContext context) => 
		new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

    [CqlDeclaration("biologic")]
	public CqlCode biologic(CqlContext context) => 
		new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", null, null);

    [CqlDeclaration("Allergy")]
	public CqlCode Allergy(CqlContext context) => 
		new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", null, null);

    [CqlDeclaration("Intolerance")]
	public CqlCode Intolerance(CqlContext context) => 
		new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", null, null);

    [CqlDeclaration("Inpatient")]
	public CqlCode Inpatient(CqlContext context) => 
		new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Outpatient")]
	public CqlCode Outpatient(CqlContext context) => 
		new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Community")]
	public CqlCode Community(CqlContext context) => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Discharge")]
	public CqlCode Discharge(CqlContext context) => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Pharmacy")]
	public CqlCode Pharmacy(CqlContext context) => 
		new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

    [CqlDeclaration("Institutional")]
	public CqlCode Institutional(CqlContext context) => 
		new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

    [CqlDeclaration("Professional")]
	public CqlCode Professional(CqlContext context) => 
		new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

    [CqlDeclaration("Oral")]
	public CqlCode Oral(CqlContext context) => 
		new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

    [CqlDeclaration("Vision")]
	public CqlCode Vision(CqlContext context) => 
		new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual(CqlContext context) => 
		new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("ambulatory")]
	public CqlCode ambulatory(CqlContext context) => 
		new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("home health")]
	public CqlCode home_health(CqlContext context) => 
		new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("inpatient non-acute")]
	public CqlCode inpatient_non_acute(CqlContext context) => 
		new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("emergency")]
	public CqlCode emergency(CqlContext context) => 
		new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("inpatient acute")]
	public CqlCode inpatient_acute(CqlContext context) => 
		new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null);

    [CqlDeclaration("drug policy")]
	public CqlCode drug_policy(CqlContext context) => 
		new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("mental health policy")]
	public CqlCode mental_health_policy(CqlContext context) => 
		new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("managed care policy")]
	public CqlCode managed_care_policy(CqlContext context) => 
		new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("subsidized health program")]
	public CqlCode subsidized_health_program(CqlContext context) => 
		new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("retiree health program")]
	public CqlCode retiree_health_program(CqlContext context) => 
		new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("substance use policy")]
	public CqlCode substance_use_policy(CqlContext context) => 
		new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null);

    [CqlDeclaration("Provider number")]
	public CqlCode Provider_number(CqlContext context) => 
		new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("RoleCode")]
	public CqlCode[] RoleCode(CqlContext context)
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role(CqlContext context)
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("RequestIntent")]
	public CqlCode[] RequestIntent(CqlContext context)
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory(CqlContext context)
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

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
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

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceType")]
	public CqlCode[] AllergyIntoleranceType(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", null, null),
			new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceCategory")]
	public CqlCode[] AllergyIntoleranceCategory(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", null, null),
			new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", null, null),
			new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", null, null),
			new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionCategoryCodes")]
	public CqlCode[] ConditionCategoryCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", null, null),
			new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("claim-type")]
	public CqlCode[] claim_type(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", null, null),
			new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null),
			new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", null, null),
			new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", null, null),
			new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActEncounterCodes")]
	public CqlCode[] ActEncounterCodes(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
			new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
			new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
			new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
			new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
			new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("coverage-type")]
	public CqlCode[] coverage_type(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
			new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
			new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
			new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
			new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
			new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("IdentifierType")]
	public CqlCode[] IdentifierType(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", null, null),
		};

		return a_;
	}

}