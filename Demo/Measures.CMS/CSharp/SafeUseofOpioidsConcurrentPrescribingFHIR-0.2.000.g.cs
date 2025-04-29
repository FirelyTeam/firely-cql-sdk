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
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.2.000")]
public partial class SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000 : ILibrary, ISingleton<SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000>
{
    private SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000() {}

    public static SafeUseofOpioidsConcurrentPrescribingFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SafeUseofOpioidsConcurrentPrescribingFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, Hospice_6_12_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Cancer Related Pain
    [CqlValueSetDefinition(
        definitionName: "Cancer Related Pain",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180",
        valueSetVersion: null)]
    public CqlValueSet Cancer_Related_Pain(CqlContext context) => _Cancer_Related_Pain;

    private static readonly CqlValueSet _Cancer_Related_Pain = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", null);
    #endregion

    #region ValueSet: Discharge To Acute Care Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge To Acute Care Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87",
        valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => _Discharge_To_Acute_Care_Facility;

    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);
    #endregion

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: Hospice Care Referral or Admission
    [CqlValueSetDefinition(
        definitionName: "Hospice Care Referral or Admission",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext context) => _Hospice_Care_Referral_or_Admission;

    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);
    #endregion

    #region ValueSet: Left Against Medical Advice
    [CqlValueSetDefinition(
        definitionName: "Left Against Medical Advice",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308",
        valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext context) => _Left_Against_Medical_Advice;

    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);
    #endregion

    #region ValueSet: Medications for Opioid Use Disorder (MOUD)
    [CqlValueSetDefinition(
        definitionName: "Medications for Opioid Use Disorder (MOUD)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269",
        valueSetVersion: null)]
    public CqlValueSet Medications_for_Opioid_Use_Disorder__MOUD_(CqlContext context) => _Medications_for_Opioid_Use_Disorder__MOUD_;

    private static readonly CqlValueSet _Medications_for_Opioid_Use_Disorder__MOUD_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Opioid Medication Assisted Treatment (MAT)
    [CqlValueSetDefinition(
        definitionName: "Opioid Medication Assisted Treatment (MAT)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177",
        valueSetVersion: null)]
    public CqlValueSet Opioid_Medication_Assisted_Treatment__MAT_(CqlContext context) => _Opioid_Medication_Assisted_Treatment__MAT_;

    private static readonly CqlValueSet _Opioid_Medication_Assisted_Treatment__MAT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", null);
    #endregion

    #region ValueSet: Opioid Use Disorder
    [CqlValueSetDefinition(
        definitionName: "Opioid Use Disorder",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171",
        valueSetVersion: null)]
    public CqlValueSet Opioid_Use_Disorder(CqlContext context) => _Opioid_Use_Disorder;

    private static readonly CqlValueSet _Opioid_Use_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", null);
    #endregion

    #region ValueSet: Palliative or Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Palliative or Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579",
        valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => _Palliative_or_Hospice_Care;

    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Payer Type
    [CqlValueSetDefinition(
        definitionName: "Payer Type",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext context) => _Payer_Type;

    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
    #endregion

    #region ValueSet: Schedule II, III and IV Opioid Medications
    [CqlValueSetDefinition(
        definitionName: "Schedule II, III and IV Opioid Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241",
        valueSetVersion: null)]
    public CqlValueSet Schedule_II__III_and_IV_Opioid_Medications(CqlContext context) => _Schedule_II__III_and_IV_Opioid_Medications;

    private static readonly CqlValueSet _Schedule_II__III_and_IV_Opioid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", null);
    #endregion

    #region ValueSet: Schedule IV Benzodiazepines
    [CqlValueSetDefinition(
        definitionName: "Schedule IV Benzodiazepines",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1",
        valueSetVersion: null)]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext context) => _Schedule_IV_Benzodiazepines;

    private static readonly CqlValueSet _Schedule_IV_Benzodiazepines = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);
    #endregion

    #region ValueSet: Sickle Cell Disease with and without Crisis
    [CqlValueSetDefinition(
        definitionName: "Sickle Cell Disease with and without Crisis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175",
        valueSetVersion: null)]
    public CqlValueSet Sickle_Cell_Disease_with_and_without_Crisis(CqlContext context) => _Sickle_Cell_Disease_with_and_without_Crisis;

    private static readonly CqlValueSet _Sickle_Cell_Disease_with_and_without_Crisis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", null);
    #endregion

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = []
;

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientHospitalEncounter)
        {
            Patient pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 18);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationRequest OpioidMedications)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "order");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(MedicationRequest BenzoMedications)
        {
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "active",
                "completed",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "order");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Benzodiazepine_at_Discharge(context);
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationRequest, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure MAT)
            {
                FhirDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = MAT?.Performed;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            MedicationRequest szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<object>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<object>, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<object>);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition CancerPain)
            {
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Cancer_Related_Pain(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition OUD)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Before(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest OUDTreatment)
            {
                FhirDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<MedicationRequest>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(object PalliativeOrHospiceCare)
            {
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "value");
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ ?? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Encounter.HospitalizationComponent uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = InpatientEncounter?.Hospitalization;
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient_Expired(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Left_Against_Medical_Advice(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Opioid_at_Discharge(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest OpioidMedications)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationRequest OpioidMedications)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = OpioidMedications?.Medication;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<MedicationRequest, object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<object> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Count<object>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, 2);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
                IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Benzodiazepine_at_Discharge(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Expressions

}
