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
[CqlLibrary("HFACEIorARBorARNIforLVSDFHIR", "0.2.000")]
public partial class HFACEIorARBorARNIforLVSDFHIR_0_2_000 : ILibrary, ISingleton<HFACEIorARBorARNIforLVSDFHIR_0_2_000>
{
    private HFACEIorARBorARNIforLVSDFHIR_0_2_000() {}

    public static HFACEIorARBorARNIforLVSDFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HFACEIorARBorARNIforLVSDFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, AHAOverall_2_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: ACE Inhibitor or ARB or ARNI Ingredient
    [CqlValueSetDefinition(
        definitionName: "ACE Inhibitor or ARB or ARNI Ingredient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489",
        valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(CqlContext context) => _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient;

    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489", null);
    #endregion

    #region ValueSet: ACE Inhibitor or ARB or ARNI
    [CqlValueSetDefinition(
        definitionName: "ACE Inhibitor or ARB or ARNI",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139",
        valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI(CqlContext context) => _ACE_Inhibitor_or_ARB_or_ARNI;

    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139", null);
    #endregion

    #region ValueSet: Allergy to ACE Inhibitor or ARB
    [CqlValueSetDefinition(
        definitionName: "Allergy to ACE Inhibitor or ARB",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211",
        valueSetVersion: null)]
    public CqlValueSet Allergy_to_ACE_Inhibitor_or_ARB(CqlContext context) => _Allergy_to_ACE_Inhibitor_or_ARB;

    private static readonly CqlValueSet _Allergy_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211", null);
    #endregion

    #region ValueSet: Intolerance to ACE Inhibitor or ARB
    [CqlValueSetDefinition(
        definitionName: "Intolerance to ACE Inhibitor or ARB",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212",
        valueSetVersion: null)]
    public CqlValueSet Intolerance_to_ACE_Inhibitor_or_ARB(CqlContext context) => _Intolerance_to_ACE_Inhibitor_or_ARB;

    private static readonly CqlValueSet _Intolerance_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Patient Reason
    [CqlValueSetDefinition(
        definitionName: "Patient Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008",
        valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext context) => _Patient_Reason;

    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);
    #endregion

    #region ValueSet: Patient Reason for ACE Inhibitor or ARB Decline
    [CqlValueSetDefinition(
        definitionName: "Patient Reason for ACE Inhibitor or ARB Decline",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140",
        valueSetVersion: null)]
    public CqlValueSet Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(CqlContext context) => _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline;

    private static readonly CqlValueSet _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140", null);
    #endregion

    #region ValueSet: Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext context) => _Pregnancy;

    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);
    #endregion

    #region ValueSet: Moderate or Severe LVSD
    [CqlValueSetDefinition(
        definitionName: "Moderate or Severe LVSD",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090",
        valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext context) => _Moderate_or_Severe_LVSD;

    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Acute renal failure caused by angiotensin-converting-enzyme inhibitor (disorder)
    [CqlCodeDefinition(
        definitionName: "Acute renal failure caused by angiotensin-converting-enzyme inhibitor (disorder)",
        codeId: "422593004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(CqlContext context) => _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_;

    private static readonly CqlCode _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_ = new CqlCode("422593004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Substance with angiotensin II receptor antagonist mechanism of action (substance)
    [CqlCodeDefinition(
        definitionName: "Substance with angiotensin II receptor antagonist mechanism of action (substance)",
        codeId: "372913009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(CqlContext context) => _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_;

    private static readonly CqlCode _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("372913009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Substance with angiotensin-converting enzyme inhibitor mechanism of action (substance)
    [CqlCodeDefinition(
        definitionName: "Substance with angiotensin-converting enzyme inhibitor mechanism of action (substance)",
        codeId: "372733002",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(CqlContext context) => _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_;

    private static readonly CqlCode _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_ = new CqlCode("372733002", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Substance with neprilysin inhibitor mechanism of action (substance)
    [CqlCodeDefinition(
        definitionName: "Substance with neprilysin inhibitor mechanism of action (substance)",
        codeId: "786886009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(CqlContext context) => _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_;

    private static readonly CqlCode _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_ = new CqlCode("786886009", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] uzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("422593004", "http://snomed.info/sct", default, default),
            new CqlCode("372913009", "http://snomed.info/sct", default, default),
            new CqlCode("372733002", "http://snomed.info/sct", default, default),
            new CqlCode("786886009", "http://snomed.info/sct", default, default),
        ];

        return uzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzq_, true, true);
        object uzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("HFACEIorARBorARNIforLVSDFHIR-0.2.000", "Measurement Period", uzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return uzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? uzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzza_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? vzzzzzzzzzzzzzzzzb_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? vzzzzzzzzzzzzzzzzc_ = context.Operators.Or(vzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzd_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? vzzzzzzzzzzzzzzzze_ = context.Operators.Or(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzd_);
        bool? vzzzzzzzzzzzzzzzzf_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? vzzzzzzzzzzzzzzzzg_ = context.Operators.Or(vzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has ACEI or ARB or ARNI Ordered")]
    public bool? Has_ACEI_or_ARB_or_ARNI_Ordered(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzh_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? vzzzzzzzzzzzzzzzzj_(MedicationRequest ACEIOrARBOrARNIOrdered)
        {
            bool? vzzzzzzzzzzzzzzzzm_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIOrdered);

            return vzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzj_);
        bool? vzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Currently Taking ACEI or ARB or ARNI")]
    public bool? Is_Currently_Taking_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzn_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? vzzzzzzzzzzzzzzzzp_(MedicationRequest ActiveACEIOrARBOrARNI)
        {
            bool? vzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveACEIOrARBOrARNI);

            return vzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzt_ = this.Has_ACEI_or_ARB_or_ARNI_Ordered(context);
        bool? vzzzzzzzzzzzzzzzzu_ = this.Is_Currently_Taking_ACEI_or_ARB_or_ARNI(context);
        bool? vzzzzzzzzzzzzzzzzv_ = context.Operators.Or(vzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Allergy or Intolerance to ACEI or ARB or ARNI Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzw_ = this.ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(context);
        IEnumerable<AllergyIntolerance> vzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode vzzzzzzzzzzzzzzzzy_ = this.Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzy_);
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzb_ = context.Operators.Union<AllergyIntolerance>(vzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzza_);
        CqlCode wzzzzzzzzzzzzzzzzc_ = this.Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzc_);
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode wzzzzzzzzzzzzzzzzf_ = this.Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzf_);
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzi_ = context.Operators.Union<AllergyIntolerance>(wzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzh_);
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzj_ = context.Operators.Union<AllergyIntolerance>(wzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzzk_(AllergyIntolerance ACEIOrARBOrARNIAllergyIntolerance)
        {
            bool? wzzzzzzzzzzzzzzzzn_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIAllergyIntolerance);

            return wzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzl_ = context.Operators.Where<AllergyIntolerance>(wzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<AllergyIntolerance>(wzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Allergy or Intolerance to ACEI or ARB")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzo_ = this.Allergy_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzq_ = this.Intolerance_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzt_(Condition ACEIOrARBAllergyOrIntoleranceDiagnosis)
        {
            bool? wzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBAllergyOrIntoleranceDiagnosis);

            return wzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzt_);
        bool? wzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Pregnancy")]
    public bool? Has_Diagnosis_of_Pregnancy(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzx_ = this.Pregnancy(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzz_(Condition PregnancyDiagnosis)
        {
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzc_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? xzzzzzzzzzzzzzzzzd_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlDateTime xzzzzzzzzzzzzzzzzi_ = context.Operators.Start(xzzzzzzzzzzzzzzzzh_);
                Period xzzzzzzzzzzzzzzzzj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzj_);
                CqlDateTime xzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzk_);
                CqlQuantity xzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(9m, "months");
                CqlDateTime xzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzj_);
                CqlDateTime xzzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzq_, true, true);
                bool? xzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzr_, default);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzj_);
                CqlDateTime xzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzu_);
                bool? xzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzv_ is null));
                bool? xzzzzzzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzw_);

                return xzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzd_);
            Condition xzzzzzzzzzzzzzzzzf_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Condition>(xzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Condition, Condition>(wzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzz_);
        bool? xzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzza_);

        return xzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diagnosis of Renal Failure Due to ACEI")]
    public bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzy_ = this.Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzb_(Condition RenalFailureDueToACEI)
        {
            bool? yzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, RenalFailureDueToACEI);

            return yzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzb_);
        bool? yzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    [CqlTag("commentedOut", "\"Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI\"")]
    [CqlTag("commentedOutReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzzzzf_ = this.Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(context);
        bool? yzzzzzzzzzzzzzzzzg_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(context);
        bool? yzzzzzzzzzzzzzzzzh_ = context.Operators.Or(yzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzg_);
        bool? yzzzzzzzzzzzzzzzzi_ = this.Has_Diagnosis_of_Pregnancy(context);
        bool? yzzzzzzzzzzzzzzzzj_ = context.Operators.Or(yzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzzk_ = this.Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(context);
        bool? yzzzzzzzzzzzzzzzzl_ = context.Operators.Or(yzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return yzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzq_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzs_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? yzzzzzzzzzzzzzzzzy_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime zzzzzzzzzzzzzzzzzc_ = NoACEIOrARBOrARNIOrdered?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzc_);
                Period zzzzzzzzzzzzzzzzze_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzf_, "day");

                return zzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzy_);
            MedicationRequest zzzzzzzzzzzzzzzzza_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoACEIOrARBOrARNIOrdered;
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, MedicationRequest>(yzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzza_);

            return zzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(yzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzs_);
        bool? yzzzzzzzzzzzzzzzzu_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzzzh_ = NoACEIOrARBOrARNIOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzh_?.Value;
            string zzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzi_);
            bool? zzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzj_, "completed");
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzzzzl_ = NoACEIOrARBOrARNIOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzl_?.Value;
            string zzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzm_);
            string[] zzzzzzzzzzzzzzzzzo_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? zzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzp_);
            List<CodeableConcept> zzzzzzzzzzzzzzzzzr_ = NoACEIOrARBOrARNIOrdered?.ReasonCode;
            CqlConcept zzzzzzzzzzzzzzzzzs_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzs_);
            CqlValueSet zzzzzzzzzzzzzzzzzu_ = this.Medical_Reason(context);
            bool? zzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzu_);
            CqlConcept zzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzx_);
            CqlValueSet zzzzzzzzzzzzzzzzzz_ = this.Patient_Reason(context);
            bool? azzzzzzzzzzzzzzzzza_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzza_);
            CqlConcept azzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzd_);
            CqlValueSet azzzzzzzzzzzzzzzzzf_ = this.Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(context);
            bool? azzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzf_);
            bool? azzzzzzzzzzzzzzzzzh_ = context.Operators.Or(azzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzg_);
            bool? azzzzzzzzzzzzzzzzzi_ = context.Operators.And(zzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
