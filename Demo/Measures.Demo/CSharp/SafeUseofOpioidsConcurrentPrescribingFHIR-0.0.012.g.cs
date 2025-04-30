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
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object fzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzr_);

        return fzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);
        bool? fzzzzzzzzzzzzzzzzzu_(Encounter EncounterInpatient)
        {
            Patient fzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date fzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string fzzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate fzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzy_);
            Period gzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzza_);
            CqlDateTime gzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzb_);
            CqlDate gzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzc_);
            int? gzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzd_, "year");
            bool? gzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzze_, 18);
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.StatusElement;
            string gzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzzzzzzg_);
            bool? gzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzh_, "finished");
            bool? gzzzzzzzzzzzzzzzzzj_ = context.Operators.And(gzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzi_);

            return gzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzzn_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzq_);
            CqlValueSet gzzzzzzzzzzzzzzzzzs_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzv_);
            bool? gzzzzzzzzzzzzzzzzzx_(MedicationRequest Medications)
            {
                List<CodeableConcept> hzzzzzzzzzzzzzzzzze_ = Medications?.Category;
                bool? hzzzzzzzzzzzzzzzzzf_(CodeableConcept C)
                {
                    CqlConcept hzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode hzzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept hzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzj_);
                    bool? hzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzk_);

                    return hzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<CodeableConcept> hzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzf_);
                bool? hzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CodeableConcept>(hzzzzzzzzzzzzzzzzzg_);

                return hzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzx_);
            IEnumerable<MedicationRequest> gzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzy_);
            bool? hzzzzzzzzzzzzzzzzza_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
            {
                FhirDateTime hzzzzzzzzzzzzzzzzzm_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, hzzzzzzzzzzzzzzzzzm_);
                Period hzzzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzo_);
                bool? hzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzp_, default);
                Code<MedicationRequest.MedicationrequestStatus> hzzzzzzzzzzzzzzzzzr_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string hzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzzzr_);
                bool? hzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzs_, "active");
                bool? hzzzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzt_);
                Code<MedicationRequest.MedicationRequestIntent> hzzzzzzzzzzzzzzzzzv_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string hzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzzzzzzzzzv_);
                bool? hzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzw_, "plan");
                bool? hzzzzzzzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzx_);

                return hzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<MedicationRequest> hzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzza_);
            Encounter hzzzzzzzzzzzzzzzzzc_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
                InpatientEncounter;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationRequest, Encounter>(hzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzl_);

        return gzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> izzzzzzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? izzzzzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzzzzzzzzzzn_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? izzzzzzzzzzzzzzzzzp_(MedicationRequest Opioids)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzw_ = Opioids?.AuthoredOnElement;
                CqlDateTime izzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzzzzzzzzzzw_);
                Period izzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzy_);
                bool? jzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzz_, default);

                return jzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzp_);
            object izzzzzzzzzzzzzzzzzr_(MedicationRequest Opioids)
            {
                DataType jzzzzzzzzzzzzzzzzzb_ = Opioids?.Medication;

                return jzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, object>(izzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzr_);
            IEnumerable<object> izzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<object>(izzzzzzzzzzzzzzzzzs_);
            int? izzzzzzzzzzzzzzzzzu_ = context.Operators.Count<object>(izzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzu_, 2);

            return izzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzc_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzzzzzzzzzze_(MedicationRequest OpioidsDischarge)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzzi_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzzzzi_);
                Period jzzzzzzzzzzzzzzzzzk_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzl_, default);

                return jzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzze_);
            Encounter jzzzzzzzzzzzzzzzzzg_(MedicationRequest OpioidsDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzg_);

            return jzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzn_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? jzzzzzzzzzzzzzzzzzp_(MedicationRequest BenzodiazepinesDischarge)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzzt_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzzzzt_);
                Period jzzzzzzzzzzzzzzzzzv_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzw_, default);

                return jzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzp_);
            Encounter jzzzzzzzzzzzzzzzzzr_(MedicationRequest BenzodiazepinesDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationRequest, Encounter>(jzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? jzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzze_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> kzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? kzzzzzzzzzzzzzzzzzg_(Condition Cancer)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period lzzzzzzzzzzzzzzzzzb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzzzzd_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzc_, default);

                return lzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> kzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzg_);
            bool? kzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzzzzh_);
            CqlValueSet kzzzzzzzzzzzzzzzzzj_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
            bool? kzzzzzzzzzzzzzzzzzl_(ServiceRequest PalliativeOrHospiceCareOrder)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzze_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzzzzzzzzzze_);
                Period lzzzzzzzzzzzzzzzzzg_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzg_);
                bool? lzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzh_, default);
                Code<RequestIntent> lzzzzzzzzzzzzzzzzzj_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string lzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzk_, "order");
                bool? lzzzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzl_);

                return lzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzl_);
            bool? kzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            bool? kzzzzzzzzzzzzzzzzzr_(Procedure PalliativeOrHospiceCarePerformed)
            {
                DataType lzzzzzzzzzzzzzzzzzn_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzzzn_);
                Period lzzzzzzzzzzzzzzzzzp_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzzzzzr_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzq_, default);

                return lzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
            bool? kzzzzzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent lzzzzzzzzzzzzzzzzzs_ = InpatientEncounter?.Hospitalization;
                CodeableConcept lzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzs_?.DischargeDisposition;
                CqlConcept lzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzt_);
                CqlValueSet lzzzzzzzzzzzzzzzzzv_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? lzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzv_);
                CodeableConcept lzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzs_?.DischargeDisposition;
                CqlConcept lzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzy_);
                CqlValueSet mzzzzzzzzzzzzzzzzza_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? mzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzza_);
                bool? mzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzb_);
                CodeableConcept mzzzzzzzzzzzzzzzzze_ = lzzzzzzzzzzzzzzzzzs_?.DischargeDisposition;
                CqlConcept mzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzze_);
                CqlValueSet mzzzzzzzzzzzzzzzzzg_ = this.Patient_Expired(context);
                bool? mzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzg_);
                bool? mzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzh_);

                return mzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzy_);

            return kzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzz_);
        Encounter kzzzzzzzzzzzzzzzzzb_(Encounter InpatientEncounter) =>
            InpatientEncounter;
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Encounter>(kzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

}
