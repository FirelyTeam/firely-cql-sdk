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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object fzzzzzzzzs_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzt_);

        return fzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);
        bool? fzzzzzzzzw_(Encounter EncounterInpatient)
        {
            Patient fzzzzzzzzy_ = this.Patient(context);
            Date fzzzzzzzzz_ = fzzzzzzzzy_?.BirthDateElement;
            string gzzzzzzzza_ = fzzzzzzzzz_?.Value;
            CqlDate gzzzzzzzzb_ = context.Operators.ConvertStringToDate(gzzzzzzzza_);
            Period gzzzzzzzzc_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzc_);
            CqlDateTime gzzzzzzzze_ = context.Operators.Start(gzzzzzzzzd_);
            CqlDate gzzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzzze_);
            int? gzzzzzzzzg_ = context.Operators.CalculateAgeAt(gzzzzzzzzb_, gzzzzzzzzf_, "year");
            bool? gzzzzzzzzh_ = context.Operators.GreaterOrEqual(gzzzzzzzzg_, 18);
            Code<Encounter.EncounterStatus> gzzzzzzzzi_ = EncounterInpatient?.StatusElement;
            string gzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzi_);
            bool? gzzzzzzzzk_ = context.Operators.Equal(gzzzzzzzzj_, "finished");
            bool? gzzzzzzzzl_ = context.Operators.And(gzzzzzzzzh_, gzzzzzzzzk_);

            return gzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzv_, fzzzzzzzzw_);

        return fzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzm_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> gzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzp_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> gzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzq_, gzzzzzzzzs_);
            CqlValueSet gzzzzzzzzu_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> gzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzv_, gzzzzzzzzx_);
            bool? gzzzzzzzzz_(MedicationRequest Medications)
            {
                List<CodeableConcept> hzzzzzzzzg_ = Medications?.Category;
                bool? hzzzzzzzzh_(CodeableConcept C)
                {
                    CqlConcept hzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode hzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept hzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzl_);
                    bool? hzzzzzzzzn_ = context.Operators.Equivalent(hzzzzzzzzk_, hzzzzzzzzm_);

                    return hzzzzzzzzn_;
                };
                IEnumerable<CodeableConcept> hzzzzzzzzi_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzg_, hzzzzzzzzh_);
                bool? hzzzzzzzzj_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzi_);

                return hzzzzzzzzj_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzza_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzy_, gzzzzzzzzz_);
            IEnumerable<MedicationRequest> hzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzt_, hzzzzzzzza_);
            bool? hzzzzzzzzc_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
            {
                FhirDateTime hzzzzzzzzo_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzo_);
                Period hzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzq_);
                bool? hzzzzzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzzzzzp_, hzzzzzzzzr_, default);
                Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzt_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string hzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzt_);
                bool? hzzzzzzzzv_ = context.Operators.Equal(hzzzzzzzzu_, "active");
                bool? hzzzzzzzzw_ = context.Operators.And(hzzzzzzzzs_, hzzzzzzzzv_);
                Code<MedicationRequest.MedicationRequestIntent> hzzzzzzzzx_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string hzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzx_);
                bool? hzzzzzzzzz_ = context.Operators.Equal(hzzzzzzzzy_, "plan");
                bool? izzzzzzzza_ = context.Operators.And(hzzzzzzzzw_, hzzzzzzzzz_);

                return izzzzzzzza_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(hzzzzzzzzb_, hzzzzzzzzc_);
            Encounter hzzzzzzzze_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
                InpatientEncounter;
            IEnumerable<Encounter> hzzzzzzzzf_ = context.Operators.Select<MedicationRequest, Encounter>(hzzzzzzzzd_, hzzzzzzzze_);

            return hzzzzzzzzf_;
        };
        IEnumerable<Encounter> gzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzm_, gzzzzzzzzn_);

        return gzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzb_ = this.Initial_Population(context);

        return izzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> izzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return izzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return izzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return izzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzg_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? izzzzzzzzh_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzp_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> izzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? izzzzzzzzr_(MedicationRequest Opioids)
            {
                FhirDateTime izzzzzzzzy_ = Opioids?.AuthoredOnElement;
                CqlDateTime izzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzy_);
                Period jzzzzzzzza_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzza_);
                bool? jzzzzzzzzc_ = context.Operators.In<CqlDateTime>(izzzzzzzzz_, jzzzzzzzzb_, default);

                return jzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzs_ = context.Operators.Where<MedicationRequest>(izzzzzzzzq_, izzzzzzzzr_);
            object izzzzzzzzt_(MedicationRequest Opioids)
            {
                DataType jzzzzzzzzd_ = Opioids?.Medication;

                return jzzzzzzzzd_;
            };
            IEnumerable<object> izzzzzzzzu_ = context.Operators.Select<MedicationRequest, object>(izzzzzzzzs_, izzzzzzzzt_);
            IEnumerable<object> izzzzzzzzv_ = context.Operators.Distinct<object>(izzzzzzzzu_);
            int? izzzzzzzzw_ = context.Operators.Count<object>(izzzzzzzzv_);
            bool? izzzzzzzzx_ = context.Operators.GreaterOrEqual(izzzzzzzzw_, 2);

            return izzzzzzzzx_;
        };
        IEnumerable<Encounter> izzzzzzzzi_ = context.Operators.Where<Encounter>(izzzzzzzzg_, izzzzzzzzh_);
        IEnumerable<Encounter> izzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzze_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> jzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzg_(MedicationRequest OpioidsDischarge)
            {
                FhirDateTime jzzzzzzzzk_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzk_);
                Period jzzzzzzzzm_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzm_);
                bool? jzzzzzzzzo_ = context.Operators.In<CqlDateTime>(jzzzzzzzzl_, jzzzzzzzzn_, default);

                return jzzzzzzzzo_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzf_, jzzzzzzzzg_);
            Encounter jzzzzzzzzi_(MedicationRequest OpioidsDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzj_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzh_, jzzzzzzzzi_);

            return jzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzg_, izzzzzzzzk_);
        IEnumerable<Encounter> izzzzzzzzm_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzp_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> jzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzr_(MedicationRequest BenzodiazepinesDischarge)
            {
                FhirDateTime jzzzzzzzzv_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzv_);
                Period jzzzzzzzzx_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzx_);
                bool? jzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzw_, jzzzzzzzzy_, default);

                return jzzzzzzzzz_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzs_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzq_, jzzzzzzzzr_);
            Encounter jzzzzzzzzt_(MedicationRequest BenzodiazepinesDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzu_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzs_, jzzzzzzzzt_);

            return jzzzzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzl_, izzzzzzzzm_);
        IEnumerable<Encounter> izzzzzzzzo_ = context.Operators.Union<Encounter>(izzzzzzzzi_, izzzzzzzzn_);

        return izzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzza_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? kzzzzzzzzb_(Encounter InpatientEncounter)
        {
            CqlValueSet kzzzzzzzzg_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> kzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? kzzzzzzzzi_(Condition Cancer)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period lzzzzzzzzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzd_);
                bool? lzzzzzzzzf_ = context.Operators.Overlaps(lzzzzzzzzc_, lzzzzzzzze_, default);

                return lzzzzzzzzf_;
            };
            IEnumerable<Condition> kzzzzzzzzj_ = context.Operators.Where<Condition>(kzzzzzzzzh_, kzzzzzzzzi_);
            bool? kzzzzzzzzk_ = context.Operators.Exists<Condition>(kzzzzzzzzj_);
            CqlValueSet kzzzzzzzzl_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> kzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
            bool? kzzzzzzzzn_(ServiceRequest PalliativeOrHospiceCareOrder)
            {
                FhirDateTime lzzzzzzzzg_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzg_);
                Period lzzzzzzzzi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzi_);
                bool? lzzzzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzzzzh_, lzzzzzzzzj_, default);
                Code<RequestIntent> lzzzzzzzzl_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string lzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzl_);
                bool? lzzzzzzzzn_ = context.Operators.Equal(lzzzzzzzzm_, "order");
                bool? lzzzzzzzzo_ = context.Operators.And(lzzzzzzzzk_, lzzzzzzzzn_);

                return lzzzzzzzzo_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzm_, kzzzzzzzzn_);
            bool? kzzzzzzzzp_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzo_);
            bool? kzzzzzzzzq_ = context.Operators.Or(kzzzzzzzzk_, kzzzzzzzzp_);
            IEnumerable<Procedure> kzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            bool? kzzzzzzzzt_(Procedure PalliativeOrHospiceCarePerformed)
            {
                DataType lzzzzzzzzp_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> lzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzp_);
                Period lzzzzzzzzr_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzr_);
                bool? lzzzzzzzzt_ = context.Operators.Overlaps(lzzzzzzzzq_, lzzzzzzzzs_, default);

                return lzzzzzzzzt_;
            };
            IEnumerable<Procedure> kzzzzzzzzu_ = context.Operators.Where<Procedure>(kzzzzzzzzs_, kzzzzzzzzt_);
            bool? kzzzzzzzzv_ = context.Operators.Exists<Procedure>(kzzzzzzzzu_);
            bool? kzzzzzzzzw_ = context.Operators.Or(kzzzzzzzzq_, kzzzzzzzzv_);
            IEnumerable<Encounter> kzzzzzzzzx_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
            bool? kzzzzzzzzy_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent lzzzzzzzzu_ = InpatientEncounter?.Hospitalization;
                CodeableConcept lzzzzzzzzv_ = lzzzzzzzzu_?.DischargeDisposition;
                CqlConcept lzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzzv_);
                CqlValueSet lzzzzzzzzx_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? lzzzzzzzzy_ = context.Operators.ConceptInValueSet(lzzzzzzzzw_, lzzzzzzzzx_);
                CodeableConcept mzzzzzzzza_ = lzzzzzzzzu_?.DischargeDisposition;
                CqlConcept mzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzza_);
                CqlValueSet mzzzzzzzzc_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? mzzzzzzzzd_ = context.Operators.ConceptInValueSet(mzzzzzzzzb_, mzzzzzzzzc_);
                bool? mzzzzzzzze_ = context.Operators.Or(lzzzzzzzzy_, mzzzzzzzzd_);
                CodeableConcept mzzzzzzzzg_ = lzzzzzzzzu_?.DischargeDisposition;
                CqlConcept mzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzg_);
                CqlValueSet mzzzzzzzzi_ = this.Patient_Expired(context);
                bool? mzzzzzzzzj_ = context.Operators.ConceptInValueSet(mzzzzzzzzh_, mzzzzzzzzi_);
                bool? mzzzzzzzzk_ = context.Operators.Or(mzzzzzzzze_, mzzzzzzzzj_);

                return mzzzzzzzzk_;
            };
            IEnumerable<Encounter> kzzzzzzzzz_ = context.Operators.Where<Encounter>(kzzzzzzzzx_, kzzzzzzzzy_);
            bool? lzzzzzzzza_ = context.Operators.Exists<Encounter>(kzzzzzzzzz_);
            bool? lzzzzzzzzb_ = context.Operators.Or(kzzzzzzzzw_, lzzzzzzzza_);

            return lzzzzzzzzb_;
        };
        IEnumerable<Encounter> kzzzzzzzzc_ = context.Operators.Where<Encounter>(kzzzzzzzza_, kzzzzzzzzb_);
        Encounter kzzzzzzzzd_(Encounter InpatientEncounter) =>
            InpatientEncounter;
        IEnumerable<Encounter> kzzzzzzzze_ = context.Operators.Select<Encounter, Encounter>(kzzzzzzzzc_, kzzzzzzzzd_);
        IEnumerable<Encounter> kzzzzzzzzf_ = context.Operators.Distinct<Encounter>(kzzzzzzzze_);

        return kzzzzzzzzf_;
    }


    #endregion Expressions

}
