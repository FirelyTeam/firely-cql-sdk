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
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object uzzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", uzzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzh_);

        return uzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientHospitalEncounter)
        {
            Patient uzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
            Date uzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
            string uzzzzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzzo_);
            Period uzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzs_);
            int? uzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzt_, "year");
            bool? uzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzzzu_, 18);

            return uzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzw_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest OpioidMedications)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? vzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? vzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzd_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzzzzzzzzzzzzzzzi_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzzzzzzzzzzzzzzzzzzzzzj_ = vzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzj_);
            string[] vzzzzzzzzzzzzzzzzzzzzzzl_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzzzzzzzzzzzzzzzn_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzp_, "order");
            bool? vzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzq_);

            return vzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzs_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzu_(MedicationRequest BenzoMedications)
        {
            bool? vzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? vzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? wzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> wzzzzzzzzzzzzzzzzzzzzzzb_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? wzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] wzzzzzzzzzzzzzzzzzzzzzze_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> wzzzzzzzzzzzzzzzzzzzzzzg_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzi_, "order");
            bool? wzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzj_);

            return wzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzl_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzo_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzp_ = this.Benzodiazepine_at_Discharge(context);
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzr_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime wzzzzzzzzzzzzzzzzzzzzzzv_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzv_);
                Period wzzzzzzzzzzzzzzzzzzzzzzx_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzy_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzt_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzt_);

            return wzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzza_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return xzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzc_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzj_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzl_(Procedure MAT)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzp_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzr_ = MAT?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzx_, "day");
                bool? xzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzy_);

                return xzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzl_);
            MedicationRequest xzzzzzzzzzzzzzzzzzzzzzzn_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzn_);

            return xzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzh_);

        return xzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzza_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> yzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<object>(yzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>, yzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<object>);

        return yzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzi_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzk_(Condition CancerPain)
            {
                bool? azzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? azzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period azzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzr_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzs_);

                return azzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? yzzzzzzzzzzzzzzzzzzzzzzo_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzu_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzw_ = this.Cancer_Related_Pain(context);
                bool? azzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzw_);

                return azzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzs_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzu_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period azzzzzzzzzzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(yzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzy_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? zzzzzzzzzzzzzzzzzzzzzzza_(Condition OUD)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period bzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Before(bzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzze_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzf_(MedicationRequest OUDTreatment)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzi_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(zzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzj_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzk_(object PalliativeOrHospiceCare)
            {
                object bzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object bzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzp_);
                object bzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzq_ ?? bzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                return bzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<object>(zzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<object>(zzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter.HospitalizationComponent zzzzzzzzzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Hospitalization;
            CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzzzzo_?.DischargeDisposition;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzr_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzr_);
            CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzzzzzo_?.DischargeDisposition;
            CqlConcept zzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzx_);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzzzzzzo_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient_Expired(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzd_);
            CodeableConcept azzzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzzo_?.DischargeDisposition;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzi_ = this.Left_Against_Medical_Advice(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzk_);

            return azzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzg_);

        return yzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Opioid_at_Discharge(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzz_(MedicationRequest OpioidMedications)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzzzl_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzl_);
                Period czzzzzzzzzzzzzzzzzzzzzzzn_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzo_, "day");

                return czzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzz_);
            object czzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest OpioidMedications)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzq_ = OpioidMedications?.Medication;
                object czzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzq_);

                return czzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<MedicationRequest, object>(czzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<object>(czzzzzzzzzzzzzzzzzzzzzzzc_);
            int? czzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Count<object>(czzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzzzzzzzzzzze_, 2);
            bool? czzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzzzzs_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzs_);
                Period czzzzzzzzzzzzzzzzzzzzzzzu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzx_ = this.Benzodiazepine_at_Discharge(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime dzzzzzzzzzzzzzzzzzzzzzzzc_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzc_);
                    Period dzzzzzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                    return dzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzza_);

                return dzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<MedicationRequest>(czzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzj_);

            return czzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
