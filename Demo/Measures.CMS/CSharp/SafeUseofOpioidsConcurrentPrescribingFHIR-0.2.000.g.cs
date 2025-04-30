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

    [CqlValueSetDefinition("Cancer Related Pain", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", valueSetVersion: null)]
    public CqlValueSet Cancer_Related_Pain(CqlContext _) => _Cancer_Related_Pain;
    private static readonly CqlValueSet _Cancer_Related_Pain = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medications for Opioid Use Disorder (MOUD)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", valueSetVersion: null)]
    public CqlValueSet Medications_for_Opioid_Use_Disorder__MOUD_(CqlContext _) => _Medications_for_Opioid_Use_Disorder__MOUD_;
    private static readonly CqlValueSet _Medications_for_Opioid_Use_Disorder__MOUD_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Opioid Medication Assisted Treatment (MAT)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", valueSetVersion: null)]
    public CqlValueSet Opioid_Medication_Assisted_Treatment__MAT_(CqlContext _) => _Opioid_Medication_Assisted_Treatment__MAT_;
    private static readonly CqlValueSet _Opioid_Medication_Assisted_Treatment__MAT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177", null);

    [CqlValueSetDefinition("Opioid Use Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", valueSetVersion: null)]
    public CqlValueSet Opioid_Use_Disorder(CqlContext _) => _Opioid_Use_Disorder;
    private static readonly CqlValueSet _Opioid_Use_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Schedule II, III and IV Opioid Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", valueSetVersion: null)]
    public CqlValueSet Schedule_II__III_and_IV_Opioid_Medications(CqlContext _) => _Schedule_II__III_and_IV_Opioid_Medications;
    private static readonly CqlValueSet _Schedule_II__III_and_IV_Opioid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241", null);

    [CqlValueSetDefinition("Schedule IV Benzodiazepines", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", valueSetVersion: null)]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext _) => _Schedule_IV_Benzodiazepines;
    private static readonly CqlValueSet _Schedule_IV_Benzodiazepines = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    [CqlValueSetDefinition("Sickle Cell Disease with and without Crisis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", valueSetVersion: null)]
    public CqlValueSet Sickle_Cell_Disease_with_and_without_Crisis(CqlContext _) => _Sickle_Cell_Disease_with_and_without_Crisis;
    private static readonly CqlValueSet _Sickle_Cell_Disease_with_and_without_Crisis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InpatientHospitalEncounter)
        {
            Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "year");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, 18);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(MedicationRequest OpioidMedications)
        {
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "order");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest BenzoMedications)
        {
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "order");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Benzodiazepine_at_Discharge(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure MAT)
            {
                FhirDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = MAT?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            MedicationRequest kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<object>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition CancerPain)
            {
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Cancer_Related_Pain(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition OUD)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest OUDTreatment)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(object PalliativeOrHospiceCare)
            {
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "value");
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ ?? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Encounter.HospitalizationComponent mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = InpatientEncounter?.Hospitalization;
            CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient_Expired(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.DischargeDisposition;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Left_Against_Medical_Advice(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Opioid_at_Discharge(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest OpioidMedications)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(MedicationRequest OpioidMedications)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = OpioidMedications?.Medication;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<object> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, object>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<object> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<object>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Count<object>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, 2);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
                IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Benzodiazepine_at_Discharge(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<MedicationRequest> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}
