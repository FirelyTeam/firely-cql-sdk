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

    #region Code: problem-list-item
    [CqlCodeDefinition(
        definitionName: "problem-list-item",
        codeId: "problem-list-item",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode problem_list_item(CqlContext context) => _problem_list_item;

    private static readonly CqlCode _problem_list_item = new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);
    #endregion

    #region Code: encounter-diagnosis
    [CqlCodeDefinition(
        definitionName: "encounter-diagnosis",
        codeId: "encounter-diagnosis",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-category")]
    public CqlCode encounter_diagnosis(CqlContext context) => _encounter_diagnosis;

    private static readonly CqlCode _encounter_diagnosis = new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);
    #endregion

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: recurrence
    [CqlCodeDefinition(
        definitionName: "recurrence",
        codeId: "recurrence",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode recurrence(CqlContext context) => _recurrence;

    private static readonly CqlCode _recurrence = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: relapse
    [CqlCodeDefinition(
        definitionName: "relapse",
        codeId: "relapse",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode relapse(CqlContext context) => _relapse;

    private static readonly CqlCode _relapse = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: inactive
    [CqlCodeDefinition(
        definitionName: "inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode inactive(CqlContext context) => _inactive;

    private static readonly CqlCode _inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: remission
    [CqlCodeDefinition(
        definitionName: "remission",
        codeId: "remission",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode remission(CqlContext context) => _remission;

    private static readonly CqlCode _remission = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: resolved
    [CqlCodeDefinition(
        definitionName: "resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode resolved(CqlContext context) => _resolved;

    private static readonly CqlCode _resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: unconfirmed
    [CqlCodeDefinition(
        definitionName: "unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode unconfirmed(CqlContext context) => _unconfirmed;

    private static readonly CqlCode _unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: provisional
    [CqlCodeDefinition(
        definitionName: "provisional",
        codeId: "provisional",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode provisional(CqlContext context) => _provisional;

    private static readonly CqlCode _provisional = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: differential
    [CqlCodeDefinition(
        definitionName: "differential",
        codeId: "differential",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode differential(CqlContext context) => _differential;

    private static readonly CqlCode _differential = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: confirmed
    [CqlCodeDefinition(
        definitionName: "confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode confirmed(CqlContext context) => _confirmed;

    private static readonly CqlCode _confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: refuted
    [CqlCodeDefinition(
        definitionName: "refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode refuted(CqlContext context) => _refuted;

    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: entered-in-error
    [CqlCodeDefinition(
        definitionName: "entered-in-error",
        codeId: "entered-in-error",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-verification")]
    public CqlCode entered_in_error(CqlContext context) => _entered_in_error;

    private static readonly CqlCode _entered_in_error = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default);
    #endregion

    #region Code: allergy-active
    [CqlCodeDefinition(
        definitionName: "allergy-active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_active(CqlContext context) => _allergy_active;

    private static readonly CqlCode _allergy_active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-inactive
    [CqlCodeDefinition(
        definitionName: "allergy-inactive",
        codeId: "inactive",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_inactive(CqlContext context) => _allergy_inactive;

    private static readonly CqlCode _allergy_inactive = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-resolved
    [CqlCodeDefinition(
        definitionName: "allergy-resolved",
        codeId: "resolved",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical")]
    public CqlCode allergy_resolved(CqlContext context) => _allergy_resolved;

    private static readonly CqlCode _allergy_resolved = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);
    #endregion

    #region Code: allergy-unconfirmed
    [CqlCodeDefinition(
        definitionName: "allergy-unconfirmed",
        codeId: "unconfirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_unconfirmed(CqlContext context) => _allergy_unconfirmed;

    private static readonly CqlCode _allergy_unconfirmed = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-confirmed
    [CqlCodeDefinition(
        definitionName: "allergy-confirmed",
        codeId: "confirmed",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_confirmed(CqlContext context) => _allergy_confirmed;

    private static readonly CqlCode _allergy_confirmed = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: allergy-refuted
    [CqlCodeDefinition(
        definitionName: "allergy-refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification")]
    public CqlCode allergy_refuted(CqlContext context) => _allergy_refuted;

    private static readonly CqlCode _allergy_refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);
    #endregion

    #region Code: food
    [CqlCodeDefinition(
        definitionName: "food",
        codeId: "food",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode food(CqlContext context) => _food;

    private static readonly CqlCode _food = new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", default, default);
    #endregion

    #region Code: medication
    [CqlCodeDefinition(
        definitionName: "medication",
        codeId: "medication",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode medication(CqlContext context) => _medication;

    private static readonly CqlCode _medication = new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", default, default);
    #endregion

    #region Code: environment
    [CqlCodeDefinition(
        definitionName: "environment",
        codeId: "environment",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode environment(CqlContext context) => _environment;

    private static readonly CqlCode _environment = new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", default, default);
    #endregion

    #region Code: biologic
    [CqlCodeDefinition(
        definitionName: "biologic",
        codeId: "biologic",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-category")]
    public CqlCode biologic(CqlContext context) => _biologic;

    private static readonly CqlCode _biologic = new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", default, default);
    #endregion

    #region Code: Allergy
    [CqlCodeDefinition(
        definitionName: "Allergy",
        codeId: "allergy",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-type")]
    public CqlCode Allergy(CqlContext context) => _Allergy;

    private static readonly CqlCode _Allergy = new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", default, default);
    #endregion

    #region Code: Intolerance
    [CqlCodeDefinition(
        definitionName: "Intolerance",
        codeId: "intolerance",
        codeSystem: "http://hl7.org/fhir/allergy-intolerance-type")]
    public CqlCode Intolerance(CqlContext context) => _Intolerance;

    private static readonly CqlCode _Intolerance = new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", default, default);
    #endregion

    #region Code: Inpatient
    [CqlCodeDefinition(
        definitionName: "Inpatient",
        codeId: "inpatient",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Inpatient(CqlContext context) => _Inpatient;

    private static readonly CqlCode _Inpatient = new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Outpatient
    [CqlCodeDefinition(
        definitionName: "Outpatient",
        codeId: "outpatient",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Outpatient(CqlContext context) => _Outpatient;

    private static readonly CqlCode _Outpatient = new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Community
    [CqlCodeDefinition(
        definitionName: "Community",
        codeId: "community",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Community(CqlContext context) => _Community;

    private static readonly CqlCode _Community = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Discharge
    [CqlCodeDefinition(
        definitionName: "Discharge",
        codeId: "discharge",
        codeSystem: "http://terminology.hl7.org/CodeSystem/medicationrequest-category")]
    public CqlCode Discharge(CqlContext context) => _Discharge;

    private static readonly CqlCode _Discharge = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);
    #endregion

    #region Code: Pharmacy
    [CqlCodeDefinition(
        definitionName: "Pharmacy",
        codeId: "pharmacy",
        codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Pharmacy(CqlContext context) => _Pharmacy;

    private static readonly CqlCode _Pharmacy = new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);
    #endregion

    #region Code: Institutional
    [CqlCodeDefinition(
        definitionName: "Institutional",
        codeId: "institutional",
        codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Institutional(CqlContext context) => _Institutional;

    private static readonly CqlCode _Institutional = new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);
    #endregion

    #region Code: Professional
    [CqlCodeDefinition(
        definitionName: "Professional",
        codeId: "professional",
        codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Professional(CqlContext context) => _Professional;

    private static readonly CqlCode _Professional = new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);
    #endregion

    #region Code: Oral
    [CqlCodeDefinition(
        definitionName: "Oral",
        codeId: "oral",
        codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Oral(CqlContext context) => _Oral;

    private static readonly CqlCode _Oral = new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);
    #endregion

    #region Code: Vision
    [CqlCodeDefinition(
        definitionName: "Vision",
        codeId: "vision",
        codeSystem: "http://terminology.hl7.org/CodeSystem/claim-type")]
    public CqlCode Vision(CqlContext context) => _Vision;

    private static readonly CqlCode _Vision = new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", default, default);
    #endregion

    #region Code: virtual
    [CqlCodeDefinition(
        definitionName: "virtual",
        codeId: "VR",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode @virtual(CqlContext context) => _virtual;

    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: ambulatory
    [CqlCodeDefinition(
        definitionName: "ambulatory",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode ambulatory(CqlContext context) => _ambulatory;

    private static readonly CqlCode _ambulatory = new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: home health
    [CqlCodeDefinition(
        definitionName: "home health",
        codeId: "HH",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode home_health(CqlContext context) => _home_health;

    private static readonly CqlCode _home_health = new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: inpatient non-acute
    [CqlCodeDefinition(
        definitionName: "inpatient non-acute",
        codeId: "NONAC",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode inpatient_non_acute(CqlContext context) => _inpatient_non_acute;

    private static readonly CqlCode _inpatient_non_acute = new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: emergency
    [CqlCodeDefinition(
        definitionName: "emergency",
        codeId: "EMER",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode emergency(CqlContext context) => _emergency;

    private static readonly CqlCode _emergency = new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: inpatient acute
    [CqlCodeDefinition(
        definitionName: "inpatient acute",
        codeId: "ACUTE",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode")]
    public CqlCode inpatient_acute(CqlContext context) => _inpatient_acute;

    private static readonly CqlCode _inpatient_acute = new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default);
    #endregion

    #region Code: drug policy
    [CqlCodeDefinition(
        definitionName: "drug policy",
        codeId: "DRUGPOL",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode drug_policy(CqlContext context) => _drug_policy;

    private static readonly CqlCode _drug_policy = new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: mental health policy
    [CqlCodeDefinition(
        definitionName: "mental health policy",
        codeId: "MENTPOL",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode mental_health_policy(CqlContext context) => _mental_health_policy;

    private static readonly CqlCode _mental_health_policy = new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: managed care policy
    [CqlCodeDefinition(
        definitionName: "managed care policy",
        codeId: "MCPOL",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode managed_care_policy(CqlContext context) => _managed_care_policy;

    private static readonly CqlCode _managed_care_policy = new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: subsidized health program
    [CqlCodeDefinition(
        definitionName: "subsidized health program",
        codeId: "SUBSIDIZ",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode subsidized_health_program(CqlContext context) => _subsidized_health_program;

    private static readonly CqlCode _subsidized_health_program = new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: retiree health program
    [CqlCodeDefinition(
        definitionName: "retiree health program",
        codeId: "RETIRE",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode retiree_health_program(CqlContext context) => _retiree_health_program;

    private static readonly CqlCode _retiree_health_program = new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: substance use policy
    [CqlCodeDefinition(
        definitionName: "substance use policy",
        codeId: "SUBPOL",
        codeSystem: "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode")]
    public CqlCode substance_use_policy(CqlContext context) => _substance_use_policy;

    private static readonly CqlCode _substance_use_policy = new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default);
    #endregion

    #region Code: Provider number
    [CqlCodeDefinition(
        definitionName: "Provider number",
        codeId: "PRN",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v2-0203")]
    public CqlCode Provider_number(CqlContext context) => _Provider_number;

    private static readonly CqlCode _Provider_number = new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] uzzzzs_ = []
;

        return uzzzzs_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] uzzzzt_ = []
;

        return uzzzzt_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] uzzzzu_ = []
;

        return uzzzzu_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] uzzzzv_ = []
;

        return uzzzzv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "RequestIntent")]
    public CqlCode[] RequestIntent(CqlContext context)
    {
        CqlCode[] uzzzzw_ = []
;

        return uzzzzw_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] uzzzzx_ = [
            new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return uzzzzx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] uzzzzy_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return uzzzzy_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] uzzzzz_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-verification", default, default),
        ];

        return uzzzzz_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] vzzzza_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
        ];

        return vzzzza_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] vzzzzb_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return vzzzzb_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceType")]
    public CqlCode[] AllergyIntoleranceType(CqlContext context)
    {
        CqlCode[] vzzzzc_ = [
            new CqlCode("allergy", "http://hl7.org/fhir/allergy-intolerance-type", default, default),
            new CqlCode("intolerance", "http://hl7.org/fhir/allergy-intolerance-type", default, default),
        ];

        return vzzzzc_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "AllergyIntoleranceCategory")]
    public CqlCode[] AllergyIntoleranceCategory(CqlContext context)
    {
        CqlCode[] vzzzzd_ = [
            new CqlCode("food", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
            new CqlCode("medication", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
            new CqlCode("environment", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
            new CqlCode("biologic", "http://hl7.org/fhir/allergy-intolerance-category", default, default),
        ];

        return vzzzzd_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionCategoryCodes")]
    public CqlCode[] ConditionCategoryCodes(CqlContext context)
    {
        CqlCode[] vzzzze_ = [
            new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
            new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
        ];

        return vzzzze_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "claim-type")]
    public CqlCode[] claim_type(CqlContext context)
    {
        CqlCode[] vzzzzf_ = [
            new CqlCode("pharmacy", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
            new CqlCode("institutional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
            new CqlCode("professional", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
            new CqlCode("oral", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
            new CqlCode("vision", "http://terminology.hl7.org/CodeSystem/claim-type", default, default),
        ];

        return vzzzzf_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActEncounterCodes")]
    public CqlCode[] ActEncounterCodes(CqlContext context)
    {
        CqlCode[] vzzzzg_ = [
            new CqlCode("VR", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
            new CqlCode("AMB", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
            new CqlCode("HH", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
            new CqlCode("NONAC", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
            new CqlCode("EMER", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
            new CqlCode("ACUTE", "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode", default, default),
        ];

        return vzzzzg_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "coverage-type")]
    public CqlCode[] coverage_type(CqlContext context)
    {
        CqlCode[] vzzzzh_ = [
            new CqlCode("DRUGPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
            new CqlCode("MENTPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
            new CqlCode("MCPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
            new CqlCode("SUBSIDIZ", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
            new CqlCode("RETIRE", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
            new CqlCode("SUBPOL", "http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode", default, default),
        ];

        return vzzzzh_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "IdentifierType")]
    public CqlCode[] IdentifierType(CqlContext context)
    {
        CqlCode[] vzzzzi_ = [
            new CqlCode("PRN", "http://terminology.hl7.org/CodeSystem/v2-0203", default, default),
        ];

        return vzzzzi_;
    }


    #endregion CodeSystems

}
