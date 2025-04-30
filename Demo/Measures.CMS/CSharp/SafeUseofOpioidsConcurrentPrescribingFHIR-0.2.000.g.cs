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
      new CqlCodeSystem("http://loinc.org", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzk_ = context.Operators.Interval(qzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzj_, true, true);
        object qzzzzzzzzzzzzzzl_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.2.000", "Measurement Period", qzzzzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? qzzzzzzzzzzzzzzp_(Encounter InpatientHospitalEncounter)
        {
            Patient qzzzzzzzzzzzzzzr_ = this.Patient(context);
            Date qzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzr_?.BirthDateElement;
            string qzzzzzzzzzzzzzzt_ = qzzzzzzzzzzzzzzs_?.Value;
            CqlDate qzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzt_);
            Period qzzzzzzzzzzzzzzv_ = InpatientHospitalEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzv_);
            CqlDateTime qzzzzzzzzzzzzzzx_ = context.Operators.Start(qzzzzzzzzzzzzzzw_);
            CqlDate qzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzx_);
            int? qzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzy_, "year");
            bool? rzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzz_, 18);

            return rzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzp_);

        return qzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Opioid at Discharge")]
    public IEnumerable<MedicationRequest> Opioid_at_Discharge(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzb_ = this.Schedule_II__III_and_IV_Opioid_Medications(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzg_(MedicationRequest OpioidMedications)
        {
            bool? rzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMedications);
            bool? rzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isDischarge(context, OpioidMedications);
            bool? rzzzzzzzzzzzzzzm_ = context.Operators.Or(rzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzl_);

            return rzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzg_);
        bool? rzzzzzzzzzzzzzzi_(MedicationRequest OpioidDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> rzzzzzzzzzzzzzzn_ = OpioidDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? rzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzn_?.Value;
            string rzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzo_);
            string[] rzzzzzzzzzzzzzzq_ = [
                "active",
                "completed",
            ];
            bool? rzzzzzzzzzzzzzzr_ = context.Operators.In<string>(rzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> rzzzzzzzzzzzzzzs_ = OpioidDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? rzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzs_?.Value;
            string rzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzt_);
            bool? rzzzzzzzzzzzzzzv_ = context.Operators.Equal(rzzzzzzzzzzzzzzu_, "order");
            bool? rzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Benzodiazepine at Discharge")]
    public IEnumerable<MedicationRequest> Benzodiazepine_at_Discharge(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzx_ = this.Schedule_IV_Benzodiazepines(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        bool? rzzzzzzzzzzzzzzz_(MedicationRequest BenzoMedications)
        {
            bool? szzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BenzoMedications);
            bool? szzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.isDischarge(context, BenzoMedications);
            bool? szzzzzzzzzzzzzzf_ = context.Operators.Or(szzzzzzzzzzzzzzd_, szzzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzb_(MedicationRequest BenzodiazepineDischargeMedication)
        {
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzzg_ = BenzodiazepineDischargeMedication?.StatusElement;
            MedicationRequest.MedicationrequestStatus? szzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzg_?.Value;
            string szzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzh_);
            string[] szzzzzzzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzzzk_ = context.Operators.In<string>(szzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzj_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzzl_ = BenzodiazepineDischargeMedication?.IntentElement;
            MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzl_?.Value;
            string szzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzm_);
            bool? szzzzzzzzzzzzzzo_ = context.Operators.Equal(szzzzzzzzzzzzzzn_, "order");
            bool? szzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzza_, szzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Inpatient Encounters with an Opioid or Benzodiazepine at Discharge")]
    public IEnumerable<Encounter> Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzq_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzt_ = this.Opioid_at_Discharge(context);
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzu_ = this.Benzodiazepine_at_Discharge(context);
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(szzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzu_);
            bool? szzzzzzzzzzzzzzw_(MedicationRequest OpioidOrBenzodiazepineAtDischarge)
            {
                FhirDateTime tzzzzzzzzzzzzzza_ = OpioidOrBenzodiazepineAtDischarge?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzza_);
                Period tzzzzzzzzzzzzzzc_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzc_);
                bool? tzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzd_, "day");

                return tzzzzzzzzzzzzzze_;
            };
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzw_);
            Encounter szzzzzzzzzzzzzzy_(MedicationRequest OpioidOrBenzodiazepineAtDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, Encounter>(szzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzy_);

            return szzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzr_);

        return szzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);

        return tzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return tzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Treatment for Opioid Use Disorders")]
    public IEnumerable<MedicationRequest> Treatment_for_Opioid_Use_Disorders(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzh_ = this.Medications_for_Opioid_Use_Disorder__MOUD_(context);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzm_(MedicationRequest MedicationTreatment)
        {
            CqlValueSet tzzzzzzzzzzzzzzo_ = this.Opioid_Medication_Assisted_Treatment__MAT_(context);
            IEnumerable<Procedure> tzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? tzzzzzzzzzzzzzzq_(Procedure MAT)
            {
                FhirDateTime tzzzzzzzzzzzzzzu_ = MedicationTreatment?.AuthoredOnElement;
                CqlDateTime tzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzu_);
                DataType tzzzzzzzzzzzzzzw_ = MAT?.Performed;
                object tzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzx_);
                bool? tzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzy_, "day");
                CqlDateTime uzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzc_, "day");
                bool? uzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzze_;
            };
            IEnumerable<Procedure> tzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzq_);
            MedicationRequest tzzzzzzzzzzzzzzs_(Procedure MAT) =>
                MedicationTreatment;
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzt_ = context.Operators.Select<Procedure, MedicationRequest>(tzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> tzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(tzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzm_);

        return tzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Intervention Palliative or Hospice Care")]
    public IEnumerable<object> Intervention_Palliative_or_Hospice_Care(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzf_ = this.Palliative_or_Hospice_Care(context);
        IEnumerable<ServiceRequest> uzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<object> uzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(uzzzzzzzzzzzzzzg_ as IEnumerable<object>, uzzzzzzzzzzzzzzi_ as IEnumerable<object>);

        return uzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? uzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzn_ = this.Cancer_Related_Pain(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? uzzzzzzzzzzzzzzp_(Condition CancerPain)
            {
                bool? wzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, CancerPain);
                bool? wzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, CancerPain);
                bool? wzzzzzzzzzzzzzzt_ = context.Operators.Or(wzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CancerPain);
                Period wzzzzzzzzzzzzzzv_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzx_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzw_, "day");
                bool? wzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzp_);
            bool? uzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzq_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, InpatientEncounter);
            bool? uzzzzzzzzzzzzzzt_(Condition InpatientEncounterDiagnosis)
            {
                CodeableConcept wzzzzzzzzzzzzzzz_ = InpatientEncounterDiagnosis?.Code;
                CqlConcept xzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzz_);
                CqlValueSet xzzzzzzzzzzzzzzb_ = this.Cancer_Related_Pain(context);
                bool? xzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzb_);

                return xzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzt_);
            bool? uzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzu_);
            bool? uzzzzzzzzzzzzzzw_ = context.Operators.Or(uzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzv_);
            CqlValueSet uzzzzzzzzzzzzzzx_ = this.Sickle_Cell_Disease_with_and_without_Crisis(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? uzzzzzzzzzzzzzzz_(Condition SickleCellDisease)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SickleCellDisease);
                Period xzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzf_, "day");

                return xzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> vzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzz_);
            bool? vzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzza_);
            bool? vzzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzb_);
            CqlValueSet vzzzzzzzzzzzzzzd_ = this.Opioid_Use_Disorder(context);
            IEnumerable<Condition> vzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? vzzzzzzzzzzzzzzf_(Condition OUD)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, OUD);
                CqlDateTime xzzzzzzzzzzzzzzi_ = context.Operators.Start(xzzzzzzzzzzzzzzh_);
                Period xzzzzzzzzzzzzzzj_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzj_);
                CqlDateTime xzzzzzzzzzzzzzzl_ = context.Operators.End(xzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzm_ = context.Operators.Before(xzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzl_, "day");

                return xzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> vzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzf_);
            bool? vzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzi_ = context.Operators.Or(vzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzh_);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzj_ = this.Treatment_for_Opioid_Use_Disorders(context);
            bool? vzzzzzzzzzzzzzzk_(MedicationRequest OUDTreatment)
            {
                FhirDateTime xzzzzzzzzzzzzzzn_ = OUDTreatment?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzn_);
                Period xzzzzzzzzzzzzzzp_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzp_);
                bool? xzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzq_, "day");

                return xzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzm_ = context.Operators.Exists<MedicationRequest>(vzzzzzzzzzzzzzzl_);
            bool? vzzzzzzzzzzzzzzn_ = context.Operators.Or(vzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzm_);
            IEnumerable<object> vzzzzzzzzzzzzzzo_ = this.Intervention_Palliative_or_Hospice_Care(context);
            bool? vzzzzzzzzzzzzzzp_(object PalliativeOrHospiceCare)
            {
                object xzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "performed");
                object xzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzt_);
                CqlDateTime xzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzu_);
                object xzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<object>(PalliativeOrHospiceCare, "authoredOn");
                CqlDateTime xzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(xzzzzzzzzzzzzzzw_, "value");
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? xzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzv_ ?? xzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzy_, "day");

                return xzzzzzzzzzzzzzzz_;
            };
            IEnumerable<object> vzzzzzzzzzzzzzzq_ = context.Operators.Where<object>(vzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzr_ = context.Operators.Exists<object>(vzzzzzzzzzzzzzzq_);
            bool? vzzzzzzzzzzzzzzs_ = context.Operators.Or(vzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzr_);
            Encounter.HospitalizationComponent vzzzzzzzzzzzzzzt_ = InpatientEncounter?.Hospitalization;
            CodeableConcept vzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzt_?.DischargeDisposition;
            CqlConcept vzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzu_);
            CqlValueSet vzzzzzzzzzzzzzzw_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? vzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzw_);
            CodeableConcept vzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzt_?.DischargeDisposition;
            CqlConcept wzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzz_);
            CqlValueSet wzzzzzzzzzzzzzzb_ = this.Hospice_Care_Referral_or_Admission(context);
            bool? wzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzzzd_ = context.Operators.Or(vzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzc_);
            CodeableConcept wzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzt_?.DischargeDisposition;
            CqlConcept wzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzf_);
            CqlValueSet wzzzzzzzzzzzzzzh_ = this.Patient_Expired(context);
            bool? wzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzh_);
            bool? wzzzzzzzzzzzzzzj_ = context.Operators.Or(wzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzi_);
            CodeableConcept wzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzt_?.DischargeDisposition;
            CqlConcept wzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzl_);
            CqlValueSet wzzzzzzzzzzzzzzn_ = this.Left_Against_Medical_Advice(context);
            bool? wzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzn_);
            bool? wzzzzzzzzzzzzzzp_ = context.Operators.Or(wzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzo_);
            bool? wzzzzzzzzzzzzzzq_ = context.Operators.Or(vzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzza_ = this.Inpatient_Encounters_with_an_Opioid_or_Benzodiazepine_at_Discharge(context);
        bool? yzzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzd_ = this.Opioid_at_Discharge(context);
            bool? yzzzzzzzzzzzzzze_(MedicationRequest OpioidMedications)
            {
                FhirDateTime yzzzzzzzzzzzzzzq_ = OpioidMedications?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzq_);
                Period yzzzzzzzzzzzzzzs_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzs_);
                bool? yzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzt_, "day");

                return yzzzzzzzzzzzzzzu_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzze_);
            object yzzzzzzzzzzzzzzg_(MedicationRequest OpioidMedications)
            {
                DataType yzzzzzzzzzzzzzzv_ = OpioidMedications?.Medication;
                object yzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzv_);

                return yzzzzzzzzzzzzzzw_;
            };
            IEnumerable<object> yzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, object>(yzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzg_);
            IEnumerable<object> yzzzzzzzzzzzzzzi_ = context.Operators.Distinct<object>(yzzzzzzzzzzzzzzh_);
            int? yzzzzzzzzzzzzzzj_ = context.Operators.Count<object>(yzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzj_, 2);
            bool? yzzzzzzzzzzzzzzm_(MedicationRequest OpioidDischargeMedications)
            {
                FhirDateTime yzzzzzzzzzzzzzzx_ = OpioidDischargeMedications?.AuthoredOnElement;
                CqlDateTime yzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzx_);
                Period yzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzza_, "day");
                IEnumerable<MedicationRequest> zzzzzzzzzzzzzzzc_ = this.Benzodiazepine_at_Discharge(context);
                bool? zzzzzzzzzzzzzzzd_(MedicationRequest BenzodiazepineDischargeMedication)
                {
                    FhirDateTime zzzzzzzzzzzzzzzh_ = BenzodiazepineDischargeMedication?.AuthoredOnElement;
                    CqlDateTime zzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzh_);
                    Period zzzzzzzzzzzzzzzj_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzj_);
                    bool? zzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzk_, "day");

                    return zzzzzzzzzzzzzzzl_;
                };
                IEnumerable<MedicationRequest> zzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzd_);
                bool? zzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(zzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzf_);

                return zzzzzzzzzzzzzzzg_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzn_);
            bool? yzzzzzzzzzzzzzzp_ = context.Operators.Or(yzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
