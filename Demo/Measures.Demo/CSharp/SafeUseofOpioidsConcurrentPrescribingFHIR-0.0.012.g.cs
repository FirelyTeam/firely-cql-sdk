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
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public partial class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012 : ILibrary, ISingleton<SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012>
{
    private SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012() {}

    public static SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SafeUseofOpioidsConcurrentPrescribingFHIR";
    public string Version => "0.0.012";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("All Primary and Secondary Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", valueSetVersion: null)]
    public CqlValueSet All_Primary_and_Secondary_Cancer(CqlContext _) => _All_Primary_and_Secondary_Cancer;
    private static readonly CqlValueSet _All_Primary_and_Secondary_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Referral or Admission", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext _) => _Hospice_Care_Referral_or_Admission;
    private static readonly CqlValueSet _Hospice_Care_Referral_or_Admission = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Schedule II & III Opioid Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", valueSetVersion: null)]
    public CqlValueSet Schedule_II_and_III_Opioid_Medications(CqlContext _) => _Schedule_II_and_III_Opioid_Medications;
    private static readonly CqlValueSet _Schedule_II_and_III_Opioid_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

    [CqlValueSetDefinition("Schedule IV Benzodiazepines", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", valueSetVersion: null)]
    public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext _) => _Schedule_IV_Benzodiazepines;
    private static readonly CqlValueSet _Schedule_IV_Benzodiazepines = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object fzzzzzzzzzzzzs_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);
        bool? fzzzzzzzzzzzzw_(Encounter EncounterInpatient)
        {
            Patient fzzzzzzzzzzzzy_ = this.Patient(context);
            Date fzzzzzzzzzzzzz_ = fzzzzzzzzzzzzy_?.BirthDateElement;
            string gzzzzzzzzzzzza_ = fzzzzzzzzzzzzz_?.Value;
            CqlDate gzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzza_);
            Period gzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzc_);
            CqlDateTime gzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzd_);
            CqlDate gzzzzzzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzzzzzzze_);
            int? gzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzb_, gzzzzzzzzzzzzf_, "year");
            bool? gzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzg_, 18);
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzi_ = EncounterInpatient?.StatusElement;
            string gzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzi_);
            bool? gzzzzzzzzzzzzk_ = context.Operators.Equal(gzzzzzzzzzzzzj_, "finished");
            bool? gzzzzzzzzzzzzl_ = context.Operators.And(gzzzzzzzzzzzzh_, gzzzzzzzzzzzzk_);

            return gzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzv_, fzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzm_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzp_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzq_, gzzzzzzzzzzzzs_);
            CqlValueSet gzzzzzzzzzzzzu_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzv_, gzzzzzzzzzzzzx_);
            bool? gzzzzzzzzzzzzz_(MedicationRequest Medications)
            {
                List<CodeableConcept> hzzzzzzzzzzzzg_ = Medications?.Category;
                bool? hzzzzzzzzzzzzh_(CodeableConcept C)
                {
                    CqlConcept hzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode hzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept hzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzl_);
                    bool? hzzzzzzzzzzzzn_ = context.Operators.Equivalent(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzm_);

                    return hzzzzzzzzzzzzn_;
                };
                IEnumerable<CodeableConcept> hzzzzzzzzzzzzi_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzg_, hzzzzzzzzzzzzh_);
                bool? hzzzzzzzzzzzzj_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzzzzzi_);

                return hzzzzzzzzzzzzj_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzzza_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzy_, gzzzzzzzzzzzzz_);
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzt_, hzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzc_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
            {
                FhirDateTime hzzzzzzzzzzzzo_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzo_);
                Period hzzzzzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzq_);
                bool? hzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzp_, hzzzzzzzzzzzzr_, default);
                Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzzzzzt_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string hzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzt_);
                bool? hzzzzzzzzzzzzv_ = context.Operators.Equal(hzzzzzzzzzzzzu_, "active");
                bool? hzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzs_, hzzzzzzzzzzzzv_);
                Code<MedicationRequest.MedicationRequestIntent> hzzzzzzzzzzzzx_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string hzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzz_ = context.Operators.Equal(hzzzzzzzzzzzzy_, "plan");
                bool? izzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzw_, hzzzzzzzzzzzzz_);

                return izzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzzzzzb_, hzzzzzzzzzzzzc_);
            Encounter hzzzzzzzzzzzze_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
                InpatientEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(hzzzzzzzzzzzzd_, hzzzzzzzzzzzze_);

            return hzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzm_, gzzzzzzzzzzzzn_);

        return gzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzb_ = this.Initial_Population(context);

        return izzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> izzzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzg_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? izzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzzzzzp_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> izzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? izzzzzzzzzzzzr_(MedicationRequest Opioids)
            {
                FhirDateTime izzzzzzzzzzzzy_ = Opioids?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzzzzzy_);
                Period jzzzzzzzzzzzza_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzz_, jzzzzzzzzzzzzb_, default);

                return jzzzzzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzq_, izzzzzzzzzzzzr_);
            object izzzzzzzzzzzzt_(MedicationRequest Opioids)
            {
                DataType jzzzzzzzzzzzzd_ = Opioids?.Medication;

                return jzzzzzzzzzzzzd_;
            };
            IEnumerable<object> izzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, object>(izzzzzzzzzzzzs_, izzzzzzzzzzzzt_);
            IEnumerable<object> izzzzzzzzzzzzv_ = context.Operators.Distinct<object>(izzzzzzzzzzzzu_);
            int? izzzzzzzzzzzzw_ = context.Operators.Count<object>(izzzzzzzzzzzzv_);
            bool? izzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzw_, 2);

            return izzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzg_, izzzzzzzzzzzzh_);
        IEnumerable<Encounter> izzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzze_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzzzzzg_(MedicationRequest OpioidsDischarge)
            {
                FhirDateTime jzzzzzzzzzzzzk_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzk_);
                Period jzzzzzzzzzzzzm_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzm_);
                bool? jzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzl_, jzzzzzzzzzzzzn_, default);

                return jzzzzzzzzzzzzo_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzf_, jzzzzzzzzzzzzg_);
            Encounter jzzzzzzzzzzzzi_(MedicationRequest OpioidsDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzh_, jzzzzzzzzzzzzi_);

            return jzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzg_, izzzzzzzzzzzzk_);
        IEnumerable<Encounter> izzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzp_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzzzzzr_(MedicationRequest BenzodiazepinesDischarge)
            {
                FhirDateTime jzzzzzzzzzzzzv_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzv_);
                Period jzzzzzzzzzzzzx_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzx_);
                bool? jzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzw_, jzzzzzzzzzzzzy_, default);

                return jzzzzzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzq_, jzzzzzzzzzzzzr_);
            Encounter jzzzzzzzzzzzzt_(MedicationRequest BenzodiazepinesDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzs_, jzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzl_, izzzzzzzzzzzzm_);
        IEnumerable<Encounter> izzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzi_, izzzzzzzzzzzzn_);

        return izzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzza_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? kzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            CqlValueSet kzzzzzzzzzzzzg_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> kzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? kzzzzzzzzzzzzi_(Condition Cancer)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period lzzzzzzzzzzzzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzd_);
                bool? lzzzzzzzzzzzzf_ = context.Operators.Overlaps(lzzzzzzzzzzzzc_, lzzzzzzzzzzzze_, default);

                return lzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> kzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzh_, kzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzj_);
            CqlValueSet kzzzzzzzzzzzzl_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
            bool? kzzzzzzzzzzzzn_(ServiceRequest PalliativeOrHospiceCareOrder)
            {
                FhirDateTime lzzzzzzzzzzzzg_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzzzzzg_);
                Period lzzzzzzzzzzzzi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzi_);
                bool? lzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzh_, lzzzzzzzzzzzzj_, default);
                Code<RequestIntent> lzzzzzzzzzzzzl_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string lzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzl_);
                bool? lzzzzzzzzzzzzn_ = context.Operators.Equal(lzzzzzzzzzzzzm_, "order");
                bool? lzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzk_, lzzzzzzzzzzzzn_);

                return lzzzzzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzn_);
            bool? kzzzzzzzzzzzzp_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzzzzzk_, kzzzzzzzzzzzzp_);
            IEnumerable<Procedure> kzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            bool? kzzzzzzzzzzzzt_(Procedure PalliativeOrHospiceCarePerformed)
            {
                DataType lzzzzzzzzzzzzp_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzp_);
                Period lzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzr_);
                bool? lzzzzzzzzzzzzt_ = context.Operators.Overlaps(lzzzzzzzzzzzzq_, lzzzzzzzzzzzzs_, default);

                return lzzzzzzzzzzzzt_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzs_, kzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzw_ = context.Operators.Or(kzzzzzzzzzzzzq_, kzzzzzzzzzzzzv_);
            IEnumerable<Encounter> kzzzzzzzzzzzzx_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
            bool? kzzzzzzzzzzzzy_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent lzzzzzzzzzzzzu_ = InpatientEncounter?.Hospitalization;
                CodeableConcept lzzzzzzzzzzzzv_ = lzzzzzzzzzzzzu_?.DischargeDisposition;
                CqlConcept lzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzzzzzzv_);
                CqlValueSet lzzzzzzzzzzzzx_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? lzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzw_, lzzzzzzzzzzzzx_);
                CodeableConcept mzzzzzzzzzzzza_ = lzzzzzzzzzzzzu_?.DischargeDisposition;
                CqlConcept mzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzza_);
                CqlValueSet mzzzzzzzzzzzzc_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? mzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzb_, mzzzzzzzzzzzzc_);
                bool? mzzzzzzzzzzzze_ = context.Operators.Or(lzzzzzzzzzzzzy_, mzzzzzzzzzzzzd_);
                CodeableConcept mzzzzzzzzzzzzg_ = lzzzzzzzzzzzzu_?.DischargeDisposition;
                CqlConcept mzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzzg_);
                CqlValueSet mzzzzzzzzzzzzi_ = this.Patient_Expired(context);
                bool? mzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzh_, mzzzzzzzzzzzzi_);
                bool? mzzzzzzzzzzzzk_ = context.Operators.Or(mzzzzzzzzzzzze_, mzzzzzzzzzzzzj_);

                return mzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzx_, kzzzzzzzzzzzzy_);
            bool? lzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzz_);
            bool? lzzzzzzzzzzzzb_ = context.Operators.Or(kzzzzzzzzzzzzw_, lzzzzzzzzzzzza_);

            return lzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzza_, kzzzzzzzzzzzzb_);
        Encounter kzzzzzzzzzzzzd_(Encounter InpatientEncounter) =>
            InpatientEncounter;
        IEnumerable<Encounter> kzzzzzzzzzzzze_ = context.Operators.Select<Encounter, Encounter>(kzzzzzzzzzzzzc_, kzzzzzzzzzzzzd_);
        IEnumerable<Encounter> kzzzzzzzzzzzzf_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
