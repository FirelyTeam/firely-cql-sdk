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
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzw_ = context.Operators.Interval(tzzzzzzzzu_, tzzzzzzzzv_, true, true);
        object tzzzzzzzzx_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", tzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzy_);

        return tzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzza_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? uzzzzzzzzb_(Encounter InpatientHospitalEncounter)
        {
            Patient uzzzzzzzzd_ = this.Patient(context);
            Date uzzzzzzzze_ = uzzzzzzzzd_?.BirthDateElement;
            string uzzzzzzzzf_ = uzzzzzzzze_?.Value;
            CqlDate uzzzzzzzzg_ = context.Operators.ConvertStringToDate(uzzzzzzzzf_);
            Period uzzzzzzzzh_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzh_);
            CqlDateTime uzzzzzzzzj_ = context.Operators.Start(uzzzzzzzzi_);
            CqlDate uzzzzzzzzk_ = context.Operators.DateFrom(uzzzzzzzzj_);
            int? uzzzzzzzzl_ = context.Operators.CalculateAgeAt(uzzzzzzzzg_, uzzzzzzzzk_, "year");
            bool? uzzzzzzzzm_ = context.Operators.GreaterOrEqual(uzzzzzzzzl_, 18);

            return uzzzzzzzzm_;
        };
        IEnumerable<Encounter> uzzzzzzzzc_ = context.Operators.Where<Encounter>(uzzzzzzzza_, uzzzzzzzzb_);

        return uzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet uzzzzzzzzn_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> uzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, uzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> uzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(uzzzzzzzzo_, uzzzzzzzzq_);
        bool? uzzzzzzzzs_(MedicationRequest OpioidMedications)
        {
            bool? uzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? uzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? uzzzzzzzzy_ = context.Operators.Or(uzzzzzzzzw_, uzzzzzzzzx_);

            return uzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzt_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzr_, uzzzzzzzzs_);
        bool? uzzzzzzzzu_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzz_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzzzzzzza_ = uzzzzzzzzz_?.Value;
            string vzzzzzzzzb_ = context.Operators.Convert<string>(vzzzzzzzza_);
            string[] vzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzd_ = context.Operators.In<string>(vzzzzzzzzb_, vzzzzzzzzc_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzze_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzf_ = vzzzzzzzze_?.Value;
            string vzzzzzzzzg_ = context.Operators.Convert<string>(vzzzzzzzzf_);
            bool? vzzzzzzzzh_ = context.Operators.Equal(vzzzzzzzzg_, "order");
            bool? vzzzzzzzzi_ = context.Operators.And(vzzzzzzzzd_, vzzzzzzzzh_);

            return vzzzzzzzzi_;
        };
        IEnumerable<MedicationRequest> uzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(uzzzzzzzzt_, uzzzzzzzzu_);

        return uzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet vzzzzzzzzj_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> vzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? vzzzzzzzzl_(MedicationRequest BenzoMedications)
        {
            bool? vzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? vzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? vzzzzzzzzr_ = context.Operators.Or(vzzzzzzzzp_, vzzzzzzzzq_);

            return vzzzzzzzzr_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzk_, vzzzzzzzzl_);
        bool? vzzzzzzzzn_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzs_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzzzzzzzt_ = vzzzzzzzzs_?.Value;
            string vzzzzzzzzu_ = context.Operators.Convert<string>(vzzzzzzzzt_);
            string[] vzzzzzzzzv_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzw_ = context.Operators.In<string>(vzzzzzzzzu_, vzzzzzzzzv_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzx_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzy_ = vzzzzzzzzx_?.Value;
            string vzzzzzzzzz_ = context.Operators.Convert<string>(vzzzzzzzzy_);
            bool? wzzzzzzzza_ = context.Operators.Equal(vzzzzzzzzz_, "order");
            bool? wzzzzzzzzb_ = context.Operators.And(vzzzzzzzzw_, wzzzzzzzza_);

            return wzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> vzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzm_, vzzzzzzzzn_);

        return vzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzc_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> wzzzzzzzzd_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> wzzzzzzzzf_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> wzzzzzzzzg_ = this.Benzodiazepine_at_Discharge(context);
            IEnumerable<MedicationRequest> wzzzzzzzzh_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzf_, wzzzzzzzzg_);
            bool? wzzzzzzzzi_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime wzzzzzzzzm_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzm_);
                Period wzzzzzzzzo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzo_);
                bool? wzzzzzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzzzzzn_, wzzzzzzzzp_, "day");

                return wzzzzzzzzq_;
            };
            IEnumerable<MedicationRequest> wzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzh_, wzzzzzzzzi_);
            Encounter wzzzzzzzzk_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> wzzzzzzzzl_ = context.Operators.Select<MedicationRequest, Encounter>(wzzzzzzzzj_, wzzzzzzzzk_);

            return wzzzzzzzzl_;
        };
        IEnumerable<Encounter> wzzzzzzzze_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzc_, wzzzzzzzzd_);

        return wzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzr_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return wzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzs_ = this.Initial_Population(context);

        return wzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet wzzzzzzzzt_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> wzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzu_, wzzzzzzzzw_);
        IEnumerable<MedicationRequest> wzzzzzzzzy_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet xzzzzzzzza_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> xzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? xzzzzzzzzc_(Procedure MAT)
            {
                FhirDateTime xzzzzzzzzg_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzg_);
                DataType xzzzzzzzzi_ = MAT?.Performed;
                object xzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzi_);
                CqlInterval<CqlDateTime> xzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzj_);
                bool? xzzzzzzzzl_ = context.Operators.In<CqlDateTime>(xzzzzzzzzh_, xzzzzzzzzk_, "day");
                CqlDateTime xzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzg_);
                CqlInterval<CqlDateTime> xzzzzzzzzo_ = this.Measurement_Period(context);
                bool? xzzzzzzzzp_ = context.Operators.In<CqlDateTime>(xzzzzzzzzn_, xzzzzzzzzo_, "day");
                bool? xzzzzzzzzq_ = context.Operators.And(xzzzzzzzzl_, xzzzzzzzzp_);

                return xzzzzzzzzq_;
            };
            IEnumerable<Procedure> xzzzzzzzzd_ = context.Operators.Where<Procedure>(xzzzzzzzzb_, xzzzzzzzzc_);
            MedicationRequest xzzzzzzzze_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> xzzzzzzzzf_ = context.Operators.Select<Procedure, MedicationRequest>(xzzzzzzzzd_, xzzzzzzzze_);

            return xzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzz_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(wzzzzzzzzx_, wzzzzzzzzy_);

        return wzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet xzzzzzzzzr_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> xzzzzzzzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, xzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> xzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> xzzzzzzzzv_ = context.Operators.Union<object>(xzzzzzzzzs_ as IEnumerable<object>, xzzzzzzzzu_ as IEnumerable<object>);

        return xzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzw_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? xzzzzzzzzx_(Encounter InpatientEncounter)
        {
            CqlValueSet xzzzzzzzzz_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> yzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzb_(Condition CancerPain)
            {
                bool? azzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? azzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? azzzzzzzzzf_ = context.Operators.Or(azzzzzzzzzd_, azzzzzzzzze_);
                CqlInterval<CqlDateTime> azzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period azzzzzzzzzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzh_);
                bool? azzzzzzzzzj_ = context.Operators.Overlaps(azzzzzzzzzg_, azzzzzzzzzi_, "day");
                bool? azzzzzzzzzk_ = context.Operators.And(azzzzzzzzzf_, azzzzzzzzzj_);

                return azzzzzzzzzk_;
            };
            IEnumerable<Condition> yzzzzzzzzc_ = context.Operators.Where<Condition>(yzzzzzzzza_, yzzzzzzzzb_);
            bool? yzzzzzzzzd_ = context.Operators.Exists<Condition>(yzzzzzzzzc_);
            IEnumerable<Condition> yzzzzzzzze_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? yzzzzzzzzf_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept azzzzzzzzzl_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept azzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzl_);
                CqlValueSet azzzzzzzzzn_ = this.Cancer_Related_Pain(context);
                bool? azzzzzzzzzo_ = context.Operators.ConceptInValueSet(azzzzzzzzzm_, azzzzzzzzzn_);

                return azzzzzzzzzo_;
            };
            IEnumerable<Condition> yzzzzzzzzg_ = context.Operators.Where<Condition>(yzzzzzzzze_, yzzzzzzzzf_);
            bool? yzzzzzzzzh_ = context.Operators.Exists<Condition>(yzzzzzzzzg_);
            bool? yzzzzzzzzi_ = context.Operators.Or(yzzzzzzzzd_, yzzzzzzzzh_);
            CqlValueSet yzzzzzzzzj_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> yzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzl_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period azzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzq_);
                bool? azzzzzzzzzs_ = context.Operators.Overlaps(azzzzzzzzzp_, azzzzzzzzzr_, "day");

                return azzzzzzzzzs_;
            };
            IEnumerable<Condition> yzzzzzzzzm_ = context.Operators.Where<Condition>(yzzzzzzzzk_, yzzzzzzzzl_);
            bool? yzzzzzzzzn_ = context.Operators.Exists<Condition>(yzzzzzzzzm_);
            bool? yzzzzzzzzo_ = context.Operators.Or(yzzzzzzzzi_, yzzzzzzzzn_);
            CqlValueSet yzzzzzzzzp_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> yzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzr_(Condition OUD)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime azzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzt_);
                Period azzzzzzzzzv_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzv_);
                CqlDateTime azzzzzzzzzx_ = context.Operators.End(azzzzzzzzzw_);
                bool? azzzzzzzzzy_ = context.Operators.Before(azzzzzzzzzu_, azzzzzzzzzx_, "day");

                return azzzzzzzzzy_;
            };
            IEnumerable<Condition> yzzzzzzzzs_ = context.Operators.Where<Condition>(yzzzzzzzzq_, yzzzzzzzzr_);
            bool? yzzzzzzzzt_ = context.Operators.Exists<Condition>(yzzzzzzzzs_);
            bool? yzzzzzzzzu_ = context.Operators.Or(yzzzzzzzzo_, yzzzzzzzzt_);
            IEnumerable<MedicationRequest> yzzzzzzzzv_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? yzzzzzzzzw_(MedicationRequest OUDTreatment)
            {
                FhirDateTime azzzzzzzzzz_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime bzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzz_);
                Period bzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzb_);
                bool? bzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzzzza_, bzzzzzzzzzc_, "day");

                return bzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzv_, yzzzzzzzzw_);
            bool? yzzzzzzzzy_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzx_);
            bool? yzzzzzzzzz_ = context.Operators.Or(yzzzzzzzzu_, yzzzzzzzzy_);
            IEnumerable<object> zzzzzzzzza_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? zzzzzzzzzb_(object PalliativeOrHospiceCare)
            {
                object bzzzzzzzzze_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object bzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzze_);
                CqlInterval<CqlDateTime> bzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzf_);
                CqlDateTime bzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzg_);
                object bzzzzzzzzzi_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime bzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(bzzzzzzzzzi_, "value");
                CqlInterval<CqlDateTime> bzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? bzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzh_ ?? bzzzzzzzzzj_, bzzzzzzzzzk_, "day");

                return bzzzzzzzzzl_;
            };
            IEnumerable<object> zzzzzzzzzc_ = context.Operators.Where<object>(zzzzzzzzza_, zzzzzzzzzb_);
            bool? zzzzzzzzzd_ = context.Operators.Exists<object>(zzzzzzzzzc_);
            bool? zzzzzzzzze_ = context.Operators.Or(yzzzzzzzzz_, zzzzzzzzzd_);
            Encounter.HospitalizationComponent zzzzzzzzzf_ = InpatientEncounter?.Hospitalization;
            CodeableConcept zzzzzzzzzg_ = zzzzzzzzzf_?.DischargeDisposition;
            CqlConcept zzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzg_);
            CqlValueSet zzzzzzzzzi_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? zzzzzzzzzj_ = context.Operators.ConceptInValueSet(zzzzzzzzzh_, zzzzzzzzzi_);
            CodeableConcept zzzzzzzzzl_ = zzzzzzzzzf_?.DischargeDisposition;
            CqlConcept zzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzl_);
            CqlValueSet zzzzzzzzzn_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? zzzzzzzzzo_ = context.Operators.ConceptInValueSet(zzzzzzzzzm_, zzzzzzzzzn_);
            bool? zzzzzzzzzp_ = context.Operators.Or(zzzzzzzzzj_, zzzzzzzzzo_);
            CodeableConcept zzzzzzzzzr_ = zzzzzzzzzf_?.DischargeDisposition;
            CqlConcept zzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzr_);
            CqlValueSet zzzzzzzzzt_ = this.Patient_Expired(context);
            bool? zzzzzzzzzu_ = context.Operators.ConceptInValueSet(zzzzzzzzzs_, zzzzzzzzzt_);
            bool? zzzzzzzzzv_ = context.Operators.Or(zzzzzzzzzp_, zzzzzzzzzu_);
            CodeableConcept zzzzzzzzzx_ = zzzzzzzzzf_?.DischargeDisposition;
            CqlConcept zzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzx_);
            CqlValueSet zzzzzzzzzz_ = this.Left_Against_Medical_Advice(context);
            bool? azzzzzzzzza_ = context.Operators.ConceptInValueSet(zzzzzzzzzy_, zzzzzzzzzz_);
            bool? azzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzv_, azzzzzzzzza_);
            bool? azzzzzzzzzc_ = context.Operators.Or(zzzzzzzzze_, azzzzzzzzzb_);

            return azzzzzzzzzc_;
        };
        IEnumerable<Encounter> xzzzzzzzzy_ = context.Operators.Where<Encounter>(xzzzzzzzzw_, xzzzzzzzzx_);

        return xzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzm_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? bzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> bzzzzzzzzzp_ = this.Opioid_at_Discharge(context);
            bool? bzzzzzzzzzq_(MedicationRequest OpioidMedications)
            {
                FhirDateTime czzzzzzzzzc_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzc_);
                Period czzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzze_);
                bool? czzzzzzzzzg_ = context.Operators.In<CqlDateTime>(czzzzzzzzzd_, czzzzzzzzzf_, "day");

                return czzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> bzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzp_, bzzzzzzzzzq_);
            object bzzzzzzzzzs_(MedicationRequest OpioidMedications)
            {
                DataType czzzzzzzzzh_ = OpioidMedications?.Medication;
                object czzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzh_);

                return czzzzzzzzzi_;
            };
            IEnumerable<object> bzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, object>(bzzzzzzzzzr_, bzzzzzzzzzs_);
            IEnumerable<object> bzzzzzzzzzu_ = context.Operators.Distinct<object>(bzzzzzzzzzt_);
            int? bzzzzzzzzzv_ = context.Operators.Count<object>(bzzzzzzzzzu_);
            bool? bzzzzzzzzzw_ = context.Operators.GreaterOrEqual(bzzzzzzzzzv_, 2);
            bool? bzzzzzzzzzy_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime czzzzzzzzzj_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime czzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzj_);
                Period czzzzzzzzzl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzl_);
                bool? czzzzzzzzzn_ = context.Operators.In<CqlDateTime>(czzzzzzzzzk_, czzzzzzzzzm_, "day");
                IEnumerable<MedicationRequest> czzzzzzzzzo_ = this.Benzodiazepine_at_Discharge(context);
                bool? czzzzzzzzzp_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime czzzzzzzzzt_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime czzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzt_);
                    Period czzzzzzzzzv_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> czzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzv_);
                    bool? czzzzzzzzzx_ = context.Operators.In<CqlDateTime>(czzzzzzzzzu_, czzzzzzzzzw_, "day");

                    return czzzzzzzzzx_;
                };
                IEnumerable<MedicationRequest> czzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzo_, czzzzzzzzzp_);
                bool? czzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(czzzzzzzzzq_);
                bool? czzzzzzzzzs_ = context.Operators.And(czzzzzzzzzn_, czzzzzzzzzr_);

                return czzzzzzzzzs_;
            };
            IEnumerable<MedicationRequest> bzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(bzzzzzzzzzp_, bzzzzzzzzzy_);
            bool? czzzzzzzzza_ = context.Operators.Exists<MedicationRequest>(bzzzzzzzzzz_);
            bool? czzzzzzzzzb_ = context.Operators.Or(bzzzzzzzzzw_, czzzzzzzzza_);

            return czzzzzzzzzb_;
        };
        IEnumerable<Encounter> bzzzzzzzzzo_ = context.Operators.Where<Encounter>(bzzzzzzzzzm_, bzzzzzzzzzn_);

        return bzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzb_;
    }


    #endregion Expressions

}
