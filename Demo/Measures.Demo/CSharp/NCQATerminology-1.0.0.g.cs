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
[CqlLibrary("NCQATerminology", "1.0.0")]
public partial class NCQATerminology_1_0_0 : ILibrary, ISingleton<NCQATerminology_1_0_0>
{
    private NCQATerminology_1_0_0() {}

    public static NCQATerminology_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQATerminology";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("problem-list-item", codeId: "problem-list-item", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode problem_list_item(CqlContext _) => _problem_list_item;
    private static readonly CqlCode _problem_list_item = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category");

    [CqlCodeDefinition("encounter-diagnosis", codeId: "encounter-diagnosis", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode encounter_diagnosis(CqlContext _) => _encounter_diagnosis;
    private static readonly CqlCode _encounter_diagnosis = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category");

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

    [CqlCodeDefinition("unconfirmed", codeId: "unconfirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode unconfirmed(CqlContext _) => _unconfirmed;
    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification");

    [CqlCodeDefinition("provisional", codeId: "provisional", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode provisional(CqlContext _) => _provisional;
    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification");

    [CqlCodeDefinition("differential", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode differential(CqlContext _) => _differential;
    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification");

    [CqlCodeDefinition("confirmed", codeId: "confirmed", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode confirmed(CqlContext _) => _confirmed;
    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification");

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification");

    [CqlCodeDefinition("entered-in-error", codeId: "entered-in-error", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode entered_in_error(CqlContext _) => _entered_in_error;
    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification");

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

    [CqlCodeDefinition("food", codeId: "food", codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode food(CqlContext _) => _food;
    private static readonly CqlCode _food = new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category");

    [CqlCodeDefinition("medication", codeId: "medication", codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode medication(CqlContext _) => _medication;
    private static readonly CqlCode _medication = new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category");

    [CqlCodeDefinition("environment", codeId: "environment", codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode environment(CqlContext _) => _environment;
    private static readonly CqlCode _environment = new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category");

    [CqlCodeDefinition("biologic", codeId: "biologic", codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode biologic(CqlContext _) => _biologic;
    private static readonly CqlCode _biologic = new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category");

    [CqlCodeDefinition("Allergy", codeId: "allergy", codeSystem: "http://hl7.org/fhir/allergy-intolerance-type")]
    public CqlCode Allergy(CqlContext _) => _Allergy;
    private static readonly CqlCode _Allergy = new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type");

    [CqlCodeDefinition("Intolerance", codeId: "intolerance", codeSystem: "http://hl7.org/fhir/allergy-intolerance-type")]
    public CqlCode Intolerance(CqlContext _) => _Intolerance;
    private static readonly CqlCode _Intolerance = new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type");

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

    [CqlCodeDefinition("Pharmacy", codeId: "pharmacy", codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Pharmacy(CqlContext _) => _Pharmacy;
    private static readonly CqlCode _Pharmacy = new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type");

    [CqlCodeDefinition("Institutional", codeId: "institutional", codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Institutional(CqlContext _) => _Institutional;
    private static readonly CqlCode _Institutional = new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type");

    [CqlCodeDefinition("Professional", codeId: "professional", codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Professional(CqlContext _) => _Professional;
    private static readonly CqlCode _Professional = new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type");

    [CqlCodeDefinition("Oral", codeId: "oral", codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Oral(CqlContext _) => _Oral;
    private static readonly CqlCode _Oral = new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type");

    [CqlCodeDefinition("Vision", codeId: "vision", codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Vision(CqlContext _) => _Vision;
    private static readonly CqlCode _Vision = new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("ambulatory", codeId: "AMB", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode ambulatory(CqlContext _) => _ambulatory;
    private static readonly CqlCode _ambulatory = new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("home health", codeId: "HH", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode home_health(CqlContext _) => _home_health;
    private static readonly CqlCode _home_health = new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("inpatient non-acute", codeId: "NONAC", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode inpatient_non_acute(CqlContext _) => _inpatient_non_acute;
    private static readonly CqlCode _inpatient_non_acute = new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("emergency", codeId: "EMER", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode emergency(CqlContext _) => _emergency;
    private static readonly CqlCode _emergency = new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("inpatient acute", codeId: "ACUTE", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode inpatient_acute(CqlContext _) => _inpatient_acute;
    private static readonly CqlCode _inpatient_acute = new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode");

    [CqlCodeDefinition("drug policy", codeId: "DRUGPOL", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode drug_policy(CqlContext _) => _drug_policy;
    private static readonly CqlCode _drug_policy = new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("mental health policy", codeId: "MENTPOL", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode mental_health_policy(CqlContext _) => _mental_health_policy;
    private static readonly CqlCode _mental_health_policy = new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("managed care policy", codeId: "MCPOL", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode managed_care_policy(CqlContext _) => _managed_care_policy;
    private static readonly CqlCode _managed_care_policy = new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("subsidized health program", codeId: "SUBSIDIZ", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode subsidized_health_program(CqlContext _) => _subsidized_health_program;
    private static readonly CqlCode _subsidized_health_program = new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("retiree health program", codeId: "RETIRE", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode retiree_health_program(CqlContext _) => _retiree_health_program;
    private static readonly CqlCode _retiree_health_program = new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("substance use policy", codeId: "SUBPOL", codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode substance_use_policy(CqlContext _) => _substance_use_policy;
    private static readonly CqlCode _substance_use_policy = new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode");

    [CqlCodeDefinition("Provider number", codeId: "PRN", codeSystem: "http://terminology.hl7.org/CodeSystem/v2-0203")]
    public CqlCode Provider_number(CqlContext _) => _Provider_number;
    private static readonly CqlCode _Provider_number = new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://hl7.org/fhir/v3/RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://hl7.org/fhir/v3/RoleCode", null, []);

    [CqlCodeSystemDefinition("Diagnosis Role", codeSystemId: "http://terminology.hl7.org/CodeSystem/diagnosis-role", codeSystemVersion: null)]
    public CqlCodeSystem Diagnosis_Role(CqlContext _) => _Diagnosis_Role;
    private static readonly CqlCodeSystem _Diagnosis_Role =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, []);

    [CqlCodeSystemDefinition("RequestIntent", codeSystemId: "http://terminology.hl7.org/CodeSystem/request-intent", codeSystemVersion: null)]
    public CqlCodeSystem RequestIntent(CqlContext _) => _RequestIntent;
    private static readonly CqlCodeSystem _RequestIntent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/request-intent", null, []);

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

    [CqlCodeSystemDefinition("ConditionVerificationStatusCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-verification", codeSystemVersion: null)]
    public CqlCodeSystem ConditionVerificationStatusCodes(CqlContext _) => _ConditionVerificationStatusCodes;
    private static readonly CqlCodeSystem _ConditionVerificationStatusCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-verification", null, [
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

    [CqlCodeSystemDefinition("AllergyIntoleranceType", codeSystemId: "http://hl7.org/fhir/allergy-intolerance-type", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceType(CqlContext _) => _AllergyIntoleranceType;
    private static readonly CqlCodeSystem _AllergyIntoleranceType =
      new CqlCodeSystem("http://hl7.org/fhir/allergy-intolerance-type", null, [
          _Allergy,
          _Intolerance]);

    [CqlCodeSystemDefinition("AllergyIntoleranceCategory", codeSystemId: "http://hl7.org/fhir/allergy-intolerance-category", codeSystemVersion: null)]
    public CqlCodeSystem AllergyIntoleranceCategory(CqlContext _) => _AllergyIntoleranceCategory;
    private static readonly CqlCodeSystem _AllergyIntoleranceCategory =
      new CqlCodeSystem("http://hl7.org/fhir/allergy-intolerance-category", null, [
          _food,
          _medication,
          _environment,
          _biologic]);

    [CqlCodeSystemDefinition("ConditionCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/condition-category", codeSystemVersion: null)]
    public CqlCodeSystem ConditionCategoryCodes(CqlContext _) => _ConditionCategoryCodes;
    private static readonly CqlCodeSystem _ConditionCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/condition-category", null, [
          _problem_list_item,
          _encounter_diagnosis]);

    [CqlCodeSystemDefinition("claim-type", codeSystemId: "http://terminology.hl7.org/CodeSystem/claim-type", codeSystemVersion: null)]
    public CqlCodeSystem claim_type(CqlContext _) => _claim_type;
    private static readonly CqlCodeSystem _claim_type =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/claim-type", null, [
          _Pharmacy,
          _Institutional,
          _Professional,
          _Oral,
          _Vision]);

    [CqlCodeSystemDefinition("ActEncounterCodes", codeSystemId: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", codeSystemVersion: null)]
    public CqlCodeSystem ActEncounterCodes(CqlContext _) => _ActEncounterCodes;
    private static readonly CqlCodeSystem _ActEncounterCodes =
      new CqlCodeSystem("http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", null, [
          _virtual,
          _ambulatory,
          _home_health,
          _inpatient_non_acute,
          _emergency,
          _inpatient_acute]);

    [CqlCodeSystemDefinition("coverage-type", codeSystemId: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", codeSystemVersion: null)]
    public CqlCodeSystem coverage_type(CqlContext _) => _coverage_type;
    private static readonly CqlCodeSystem _coverage_type =
      new CqlCodeSystem("http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", null, [
          _drug_policy,
          _mental_health_policy,
          _managed_care_policy,
          _subsidized_health_program,
          _retiree_health_program,
          _substance_use_policy]);

    [CqlCodeSystemDefinition("IdentifierType", codeSystemId: "http://terminology.hl7.org/CodeSystem/v2-0203", codeSystemVersion: null)]
    public CqlCodeSystem IdentifierType(CqlContext _) => _IdentifierType;
    private static readonly CqlCodeSystem _IdentifierType =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v2-0203", null, [
          _Provider_number]);

    #endregion CodeSystems

}
