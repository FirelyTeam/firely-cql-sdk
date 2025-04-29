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
        object azzj_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzl_ = context.Operators.SingletonFrom<Patient>(azzk_);

        return azzl_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
    {
        IEnumerable<Encounter> azzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);
        bool? azzn_(Encounter EncounterInpatient)
        {
            Patient azzp_ = this.Patient(context);
            Date azzq_ = azzp_?.BirthDateElement;
            string azzr_ = azzq_?.Value;
            CqlDate azzs_ = context.Operators.ConvertStringToDate(azzr_);
            Period azzt_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> azzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, azzt_);
            CqlDateTime azzv_ = context.Operators.Start(azzu_);
            CqlDate azzw_ = context.Operators.DateFrom(azzv_);
            int? azzx_ = context.Operators.CalculateAgeAt(azzs_, azzw_, "year");
            bool? azzy_ = context.Operators.GreaterOrEqual(azzx_, 18);
            Code<Encounter.EncounterStatus> azzz_ = EncounterInpatient?.StatusElement;
            string bzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzz_);
            bool? bzzb_ = context.Operators.Equal(bzza_, "finished");
            bool? bzzc_ = context.Operators.And(azzy_, bzzb_);

            return bzzc_;
        };
        IEnumerable<Encounter> azzo_ = context.Operators.Where<Encounter>(azzm_, azzn_);

        return azzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> bzzd_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        IEnumerable<Encounter> bzze_(Encounter InpatientEncounter)
        {
            CqlValueSet bzzg_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> bzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzg_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> bzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzg_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> bzzk_ = context.Operators.Union<MedicationRequest>(bzzh_, bzzj_);
            CqlValueSet bzzl_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> bzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzl_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> bzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, bzzl_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            IEnumerable<MedicationRequest> bzzp_ = context.Operators.Union<MedicationRequest>(bzzm_, bzzo_);
            bool? bzzq_(MedicationRequest Medications)
            {
                List<CodeableConcept> bzzx_ = Medications?.Category;
                bool? bzzy_(CodeableConcept C)
                {
                    CqlConcept czzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode czzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                    CqlConcept czzd_ = context.Operators.ConvertCodeToConcept(czzc_);
                    bool? czze_ = context.Operators.Equivalent(czzb_, czzd_);

                    return czze_;
                };
                IEnumerable<CodeableConcept> bzzz_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)bzzx_, bzzy_);
                bool? czza_ = context.Operators.Exists<CodeableConcept>(bzzz_);

                return czza_;
            };
            IEnumerable<MedicationRequest> bzzr_ = context.Operators.Where<MedicationRequest>(bzzp_, bzzq_);
            IEnumerable<MedicationRequest> bzzs_ = context.Operators.Union<MedicationRequest>(bzzk_, bzzr_);
            bool? bzzt_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
            {
                FhirDateTime czzf_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
                CqlDateTime czzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, czzf_);
                Period czzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, czzh_);
                bool? czzj_ = context.Operators.In<CqlDateTime>(czzg_, czzi_, default);
                Code<MedicationRequest.MedicationrequestStatus> czzk_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
                string czzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzk_);
                bool? czzm_ = context.Operators.Equal(czzl_, "active");
                bool? czzn_ = context.Operators.And(czzj_, czzm_);
                Code<MedicationRequest.MedicationRequestIntent> czzo_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
                string czzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzo_);
                bool? czzq_ = context.Operators.Equal(czzp_, "plan");
                bool? czzr_ = context.Operators.And(czzn_, czzq_);

                return czzr_;
            };
            IEnumerable<MedicationRequest> bzzu_ = context.Operators.Where<MedicationRequest>(bzzs_, bzzt_);
            Encounter bzzv_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
                InpatientEncounter;
            IEnumerable<Encounter> bzzw_ = context.Operators.Select<MedicationRequest, Encounter>(bzzu_, bzzv_);

            return bzzw_;
        };
        IEnumerable<Encounter> bzzf_ = context.Operators.SelectMany<Encounter, Encounter>(bzzd_, bzze_);

        return bzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> czzs_ = this.Initial_Population(context);

        return czzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> czzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return czzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> czzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return czzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> czzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return czzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return czzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> czzx_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? czzy_(Encounter InpatientEncounter)
        {
            CqlValueSet dzzg_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> dzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzg_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? dzzi_(MedicationRequest Opioids)
            {
                FhirDateTime dzzp_ = Opioids?.AuthoredOnElement;
                CqlDateTime dzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, dzzp_);
                Period dzzr_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> dzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dzzr_);
                bool? dzzt_ = context.Operators.In<CqlDateTime>(dzzq_, dzzs_, default);

                return dzzt_;
            };
            IEnumerable<MedicationRequest> dzzj_ = context.Operators.Where<MedicationRequest>(dzzh_, dzzi_);
            object dzzk_(MedicationRequest Opioids)
            {
                DataType dzzu_ = Opioids?.Medication;

                return dzzu_;
            };
            IEnumerable<object> dzzl_ = context.Operators.Select<MedicationRequest, object>(dzzj_, dzzk_);
            IEnumerable<object> dzzm_ = context.Operators.Distinct<object>(dzzl_);
            int? dzzn_ = context.Operators.Count<object>(dzzm_);
            bool? dzzo_ = context.Operators.GreaterOrEqual(dzzn_, 2);

            return dzzo_;
        };
        IEnumerable<Encounter> czzz_ = context.Operators.Where<Encounter>(czzx_, czzy_);
        IEnumerable<Encounter> dzzb_(Encounter InpatientEncounter)
        {
            CqlValueSet dzzv_ = this.Schedule_II_and_III_Opioid_Medications(context);
            IEnumerable<MedicationRequest> dzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzv_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? dzzx_(MedicationRequest OpioidsDischarge)
            {
                FhirDateTime ezzb_ = OpioidsDischarge?.AuthoredOnElement;
                CqlDateTime ezzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzb_);
                Period ezzd_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ezze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzd_);
                bool? ezzf_ = context.Operators.In<CqlDateTime>(ezzc_, ezze_, default);

                return ezzf_;
            };
            IEnumerable<MedicationRequest> dzzy_ = context.Operators.Where<MedicationRequest>(dzzw_, dzzx_);
            Encounter dzzz_(MedicationRequest OpioidsDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> ezza_ = context.Operators.Select<MedicationRequest, Encounter>(dzzy_, dzzz_);

            return ezza_;
        };
        IEnumerable<Encounter> dzzc_ = context.Operators.SelectMany<Encounter, Encounter>(czzx_, dzzb_);
        IEnumerable<Encounter> dzzd_(Encounter InpatientEncounter)
        {
            CqlValueSet ezzg_ = this.Schedule_IV_Benzodiazepines(context);
            IEnumerable<MedicationRequest> ezzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzg_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
            bool? ezzi_(MedicationRequest BenzodiazepinesDischarge)
            {
                FhirDateTime ezzm_ = BenzodiazepinesDischarge?.AuthoredOnElement;
                CqlDateTime ezzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzm_);
                Period ezzo_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ezzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzo_);
                bool? ezzq_ = context.Operators.In<CqlDateTime>(ezzn_, ezzp_, default);

                return ezzq_;
            };
            IEnumerable<MedicationRequest> ezzj_ = context.Operators.Where<MedicationRequest>(ezzh_, ezzi_);
            Encounter ezzk_(MedicationRequest BenzodiazepinesDischarge) =>
                InpatientEncounter;
            IEnumerable<Encounter> ezzl_ = context.Operators.Select<MedicationRequest, Encounter>(ezzj_, ezzk_);

            return ezzl_;
        };
        IEnumerable<Encounter> dzze_ = context.Operators.SelectMany<Encounter, Encounter>(dzzc_, dzzd_);
        IEnumerable<Encounter> dzzf_ = context.Operators.Union<Encounter>(czzz_, dzze_);

        return dzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> ezzr_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
        bool? ezzs_(Encounter InpatientEncounter)
        {
            CqlValueSet ezzx_ = this.All_Primary_and_Secondary_Cancer(context);
            IEnumerable<Condition> ezzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? ezzz_(Condition Cancer)
            {
                CqlInterval<CqlDateTime> fzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
                Period fzzu_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> fzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzu_);
                bool? fzzw_ = context.Operators.Overlaps(fzzt_, fzzv_, default);

                return fzzw_;
            };
            IEnumerable<Condition> fzza_ = context.Operators.Where<Condition>(ezzy_, ezzz_);
            bool? fzzb_ = context.Operators.Exists<Condition>(fzza_);
            CqlValueSet fzzc_ = this.Palliative_or_Hospice_Care(context);
            IEnumerable<ServiceRequest> fzzd_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzc_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
            bool? fzze_(ServiceRequest PalliativeOrHospiceCareOrder)
            {
                FhirDateTime fzzx_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
                CqlDateTime fzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, fzzx_);
                Period fzzz_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzz_);
                bool? gzzb_ = context.Operators.In<CqlDateTime>(fzzy_, gzza_, default);
                Code<RequestIntent> gzzc_ = PalliativeOrHospiceCareOrder?.IntentElement;
                string gzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzc_);
                bool? gzze_ = context.Operators.Equal(gzzd_, "order");
                bool? gzzf_ = context.Operators.And(gzzb_, gzze_);

                return gzzf_;
            };
            IEnumerable<ServiceRequest> fzzf_ = context.Operators.Where<ServiceRequest>(fzzd_, fzze_);
            bool? fzzg_ = context.Operators.Exists<ServiceRequest>(fzzf_);
            bool? fzzh_ = context.Operators.Or(fzzb_, fzzg_);
            IEnumerable<Procedure> fzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            bool? fzzk_(Procedure PalliativeOrHospiceCarePerformed)
            {
                DataType gzzg_ = PalliativeOrHospiceCarePerformed?.Performed;
                CqlInterval<CqlDateTime> gzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzg_);
                Period gzzi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzi_);
                bool? gzzk_ = context.Operators.Overlaps(gzzh_, gzzj_, default);

                return gzzk_;
            };
            IEnumerable<Procedure> fzzl_ = context.Operators.Where<Procedure>(fzzj_, fzzk_);
            bool? fzzm_ = context.Operators.Exists<Procedure>(fzzl_);
            bool? fzzn_ = context.Operators.Or(fzzh_, fzzm_);
            IEnumerable<Encounter> fzzo_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
            bool? fzzp_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent gzzl_ = InpatientEncounter?.Hospitalization;
                CodeableConcept gzzm_ = gzzl_?.DischargeDisposition;
                CqlConcept gzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzm_);
                CqlValueSet gzzo_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? gzzp_ = context.Operators.ConceptInValueSet(gzzn_, gzzo_);
                CodeableConcept gzzr_ = gzzl_?.DischargeDisposition;
                CqlConcept gzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzr_);
                CqlValueSet gzzt_ = this.Hospice_Care_Referral_or_Admission(context);
                bool? gzzu_ = context.Operators.ConceptInValueSet(gzzs_, gzzt_);
                bool? gzzv_ = context.Operators.Or(gzzp_, gzzu_);
                CodeableConcept gzzx_ = gzzl_?.DischargeDisposition;
                CqlConcept gzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzx_);
                CqlValueSet gzzz_ = this.Patient_Expired(context);
                bool? hzza_ = context.Operators.ConceptInValueSet(gzzy_, gzzz_);
                bool? hzzb_ = context.Operators.Or(gzzv_, hzza_);

                return hzzb_;
            };
            IEnumerable<Encounter> fzzq_ = context.Operators.Where<Encounter>(fzzo_, fzzp_);
            bool? fzzr_ = context.Operators.Exists<Encounter>(fzzq_);
            bool? fzzs_ = context.Operators.Or(fzzn_, fzzr_);

            return fzzs_;
        };
        IEnumerable<Encounter> ezzt_ = context.Operators.Where<Encounter>(ezzr_, ezzs_);
        Encounter ezzu_(Encounter InpatientEncounter) =>
            InpatientEncounter;
        IEnumerable<Encounter> ezzv_ = context.Operators.Select<Encounter, Encounter>(ezzt_, ezzu_);
        IEnumerable<Encounter> ezzw_ = context.Operators.Distinct<Encounter>(ezzv_);

        return ezzw_;
    }


    #endregion Expressions

}
