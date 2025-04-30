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

    [CqlValueSetDefinition("ACE Inhibitor or ARB or ARNI Ingredient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489", valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(CqlContext _) => _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient;
    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI_Ingredient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1489", null);

    [CqlValueSetDefinition("ACE Inhibitor or ARB or ARNI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139", valueSetVersion: null)]
    public CqlValueSet ACE_Inhibitor_or_ARB_or_ARNI(CqlContext _) => _ACE_Inhibitor_or_ARB_or_ARNI;
    private static readonly CqlValueSet _ACE_Inhibitor_or_ARB_or_ARNI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1139", null);

    [CqlValueSetDefinition("Allergy to ACE Inhibitor or ARB", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211", valueSetVersion: null)]
    public CqlValueSet Allergy_to_ACE_Inhibitor_or_ARB(CqlContext _) => _Allergy_to_ACE_Inhibitor_or_ARB;
    private static readonly CqlValueSet _Allergy_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1211", null);

    [CqlValueSetDefinition("Intolerance to ACE Inhibitor or ARB", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212", valueSetVersion: null)]
    public CqlValueSet Intolerance_to_ACE_Inhibitor_or_ARB(CqlContext _) => _Intolerance_to_ACE_Inhibitor_or_ARB;
    private static readonly CqlValueSet _Intolerance_to_ACE_Inhibitor_or_ARB = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1212", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Patient Reason for ACE Inhibitor or ARB Decline", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140", valueSetVersion: null)]
    public CqlValueSet Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(CqlContext _) => _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline;
    private static readonly CqlValueSet _Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1140", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    [CqlValueSetDefinition("Moderate or Severe LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext _) => _Moderate_or_Severe_LVSD;
    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Acute renal failure caused by angiotensin-converting-enzyme inhibitor (disorder)", codeId: "422593004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(CqlContext _) => _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_;
    private static readonly CqlCode _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_ = new CqlCode("422593004", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin II receptor antagonist mechanism of action (substance)", codeId: "372913009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_ = new CqlCode("372913009", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with angiotensin-converting enzyme inhibitor mechanism of action (substance)", codeId: "372733002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_ = new CqlCode("372733002", "http://snomed.info/sct");

    [CqlCodeDefinition("Substance with neprilysin inhibitor mechanism of action (substance)", codeId: "786886009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(CqlContext _) => _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_;
    private static readonly CqlCode _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_ = new CqlCode("786886009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_,
          _Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_,
          _Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_,
          _Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("HFACEIorARBorARNIforLVSDFHIR-0.2.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzl_);

        return xzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzn_ = AHAOverall_2_8_000.Instance.Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(context);

        return xzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzp_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? xzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzp_);
        bool? xzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzzzzzs_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant(context);
        bool? xzzzzzzzzzzzzzzzzzzzzt_ = AHAOverall_2_8_000.Instance.Has_Heart_Transplant_Complications(context);
        bool? xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzt_);
        bool? xzzzzzzzzzzzzzzzzzzzzv_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device(context);
        bool? xzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzv_);
        bool? xzzzzzzzzzzzzzzzzzzzzx_ = AHAOverall_2_8_000.Instance.Has_Left_Ventricular_Assist_Device_Complications(context);
        bool? xzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzx_);

        return xzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has ACEI or ARB or ARNI Ordered")]
    public bool? Has_ACEI_or_ARB_or_ARNI_Ordered(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzz_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? yzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest ACEIOrARBOrARNIOrdered)
        {
            bool? yzzzzzzzzzzzzzzzzzzzze_ = AHAOverall_2_8_000.Instance.isOrderedDuringHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIOrdered);

            return yzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzb_);
        bool? yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Is Currently Taking ACEI or ARB or ARNI")]
    public bool? Is_Currently_Taking_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzf_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? yzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest ActiveACEIOrARBOrARNI)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzk_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ActiveACEIOrARBOrARNI);

            return yzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzh_);
        bool? yzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzzzzzzzzl_ = this.Has_ACEI_or_ARB_or_ARNI_Ordered(context);
        bool? yzzzzzzzzzzzzzzzzzzzzm_ = this.Is_Currently_Taking_ACEI_or_ARB_or_ARNI(context);
        bool? yzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzm_);

        return yzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Allergy or Intolerance to ACEI or ARB or ARNI Ingredient")]
    public bool? Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzo_ = this.ACE_Inhibitor_or_ARB_or_ARNI_Ingredient(context);
        IEnumerable<AllergyIntolerance> yzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode yzzzzzzzzzzzzzzzzzzzzq_ = this.Substance_with_angiotensin_converting_enzyme_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<AllergyIntolerance> yzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> yzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<AllergyIntolerance>(yzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzs_);
        CqlCode yzzzzzzzzzzzzzzzzzzzzu_ = this.Substance_with_angiotensin_II_receptor_antagonist_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<AllergyIntolerance> yzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        CqlCode yzzzzzzzzzzzzzzzzzzzzx_ = this.Substance_with_neprilysin_inhibitor_mechanism_of_action__substance_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<AllergyIntolerance> yzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
        IEnumerable<AllergyIntolerance> zzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<AllergyIntolerance>(yzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<AllergyIntolerance> zzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<AllergyIntolerance>(yzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzzzzzzzzc_(AllergyIntolerance ACEIOrARBOrARNIAllergyIntolerance)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzf_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBOrARNIAllergyIntolerance);

            return zzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<AllergyIntolerance> zzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<AllergyIntolerance>(zzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<AllergyIntolerance>(zzzzzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Allergy or Intolerance to ACEI or ARB")]
    public bool? Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzg_ = this.Allergy_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzi_ = this.Intolerance_to_ACE_Inhibitor_or_ARB(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzzzzzzzzl_(Condition ACEIOrARBAllergyOrIntoleranceDiagnosis)
        {
            bool? zzzzzzzzzzzzzzzzzzzzzo_ = AHAOverall_2_8_000.Instance.overlapsAfterHeartFailureOutpatientEncounter(context, ACEIOrARBAllergyOrIntoleranceDiagnosis);

            return zzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzl_);
        bool? zzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzm_);

        return zzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pregnancy")]
    public bool? Has_Diagnosis_of_Pregnancy(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzp_ = this.Pregnancy(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzr_(Condition PregnancyDiagnosis)
        {
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzu_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? zzzzzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyDiagnosis);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzz_);
                Period azzzzzzzzzzzzzzzzzzzzzb_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(9m, "months");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzj_, default);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzn_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzo_);

                return azzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzv_);
            Condition zzzzzzzzzzzzzzzzzzzzzx_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                PregnancyDiagnosis;
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, Condition>(zzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzx_);

            return zzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Condition, Condition>(zzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Renal Failure Due to ACEI")]
    public bool? Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzq_ = this.Acute_renal_failure_caused_by_angiotensin_converting_enzyme_inhibitor__disorder_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzzzzt_(Condition RenalFailureDueToACEI)
        {
            bool? azzzzzzzzzzzzzzzzzzzzzw_ = AHAOverall_2_8_000.Instance.overlapsHeartFailureOutpatientEncounter(context, RenalFailureDueToACEI);

            return azzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzt_);
        bool? azzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    [CqlTag("commentedOut", "\"Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI\"")]
    [CqlTag("commentedOutReason", "Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Allergy_or_Intolerance_to_ACEI_or_ARB_or_ARNI_Ingredient(context);
        bool? azzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Diagnosis_of_Allergy_or_Intolerance_to_ACEI_or_ARB(context);
        bool? azzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Diagnosis_of_Pregnancy(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Diagnosis_of_Renal_Failure_Due_to_ACEI(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> bzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return bzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? bzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Medical or Patient Reason for Not Ordering ACEI or ARB or ARNI")]
    public bool? Has_Medical_or_Patient_Reason_for_Not_Ordering_ACEI_or_ARB_or_ARNI(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzi_ = this.ACE_Inhibitor_or_ARB_or_ARNI(context);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzp_ = AHAOverall_2_8_000.Instance.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzq_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzu_ = NoACEIOrARBOrARNIOrdered?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzu_);
                Period bzzzzzzzzzzzzzzzzzzzzzw_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzx_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzq_);
            MedicationRequest bzzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                NoACEIOrARBOrARNIOrdered;
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzk_);
        bool? bzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest NoACEIOrARBOrARNIOrdered)
        {
            Code<MedicationRequest.MedicationrequestStatus> bzzzzzzzzzzzzzzzzzzzzzz_ = NoACEIOrARBOrARNIOrdered?.StatusElement;
            MedicationRequest.MedicationrequestStatus? czzzzzzzzzzzzzzzzzzzzza_ = bzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string czzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzza_);
            bool? czzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzb_, "completed");
            Code<MedicationRequest.MedicationRequestIntent> czzzzzzzzzzzzzzzzzzzzzd_ = NoACEIOrARBOrARNIOrdered?.IntentElement;
            MedicationRequest.MedicationRequestIntent? czzzzzzzzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string czzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzze_);
            string[] czzzzzzzzzzzzzzzzzzzzzg_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzh_);
            List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzj_ = NoACEIOrARBOrARNIOrdered?.ReasonCode;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzk_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzm_ = this.Medical_Reason(context);
            bool? czzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzm_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzr_ = this.Patient_Reason(context);
            bool? czzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzs_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzx_ = this.Patient_Reason_for_ACE_Inhibitor_or_ARB_Decline(context);
            bool? czzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
