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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.0.012")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_0_012 : ILibrary, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_0_012>
{
    private HospitalHarmSevereHypoglycemiaFHIR_0_0_012() {}

    public static HospitalHarmSevereHypoglycemiaFHIR_0_0_012 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmSevereHypoglycemiaFHIR";
    public string Version => "0.0.012";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlValueSetDefinition("Hypoglycemics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics(CqlContext _) => _Hypoglycemics;
    private static readonly CqlValueSet _Hypoglycemics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);

    [CqlValueSetDefinition("Hypoglycemics Severe Hypoglycemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext _) => _Hypoglycemics_Severe_Hypoglycemia;
    private static readonly CqlValueSet _Hypoglycemics_Severe_Hypoglycemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

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
        CqlDateTime ezzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ezzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzh_ = context.Operators.Interval(ezzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzg_, true, false);
        object ezzzzzzzzzzzzzzzi_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", ezzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ezzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzj_);

        return ezzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ezzzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ezzzzzzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzo_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? ezzzzzzzzzzzzzzzq_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzs_ = EncounterInpatient?.StatusElement;
            string ezzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzs_);
            bool? ezzzzzzzzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzzzzzzzt_, "finished");
            Period ezzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzzzzv_);
            CqlDateTime ezzzzzzzzzzzzzzzx_ = context.Operators.End(ezzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzy_, default);
            bool? fzzzzzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzz_);

            return fzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            Patient fzzzzzzzzzzzzzzze_ = this.Patient(context);
            Date fzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzze_?.BirthDateElement;
            string fzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzf_?.Value;
            CqlDateTime fzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDateTime(fzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime fzzzzzzzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzzzzzzzi_);
            int? fzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzj_, "year");
            bool? fzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzk_, 18);

            return fzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzm_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzq_ = context.Operators.Union<MedicationAdministration>(fzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzp_);
        bool? fzzzzzzzzzzzzzzzr_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> fzzzzzzzzzzzzzzzt_ = HypoMedication?.StatusElement;
            string fzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzzzzzv_ = context.Operators.Equal(fzzzzzzzzzzzzzzzu_, "completed");
            string fzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzzzzzy_ = context.Operators.Equal(fzzzzzzzzzzzzzzzx_, "not-done");
            bool? fzzzzzzzzzzzzzzzz_ = context.Operators.Not(fzzzzzzzzzzzzzzzy_);
            bool? gzzzzzzzzzzzzzzza_ = context.Operators.And(fzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationAdministration>(fzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzr_);

        return fzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzc_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> gzzzzzzzzzzzzzzze_ = this.Hypoglycemic_Medication_Administration(context);
            bool? gzzzzzzzzzzzzzzzf_(MedicationAdministration HypoglycemicMedication)
            {
                DataType gzzzzzzzzzzzzzzzj_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? gzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzm_, default);

                return gzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<MedicationAdministration> gzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationAdministration>(gzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzf_);
            Encounter gzzzzzzzzzzzzzzzh_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationAdministration, Encounter>(gzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return gzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzq_ = this.Denominator(context);
        bool? gzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzt_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> gzzzzzzzzzzzzzzzv_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> hzzzzzzzzzzzzzzzh_ = this.Hypoglycemic_Medication_Administration(context);
                bool? hzzzzzzzzzzzzzzzi_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType hzzzzzzzzzzzzzzzm_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzm_);
                    CqlDateTime hzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzn_);
                    DataType hzzzzzzzzzzzzzzzp_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzp_);
                    CqlDateTime hzzzzzzzzzzzzzzzr_ = context.Operators.Start(hzzzzzzzzzzzzzzzq_);
                    CqlQuantity hzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime hzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzp_);
                    CqlDateTime hzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzw_, true, true);
                    bool? hzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzx_, default);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzp_);
                    CqlDateTime izzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzza_);
                    bool? izzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzb_ is null));
                    bool? izzzzzzzzzzzzzzzd_ = context.Operators.And(hzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzc_);
                    Code<ObservationStatus> izzzzzzzzzzzzzzze_ = BloodGlucoseLab?.StatusElement;
                    string izzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzze_);
                    bool? izzzzzzzzzzzzzzzg_ = context.Operators.Equal(izzzzzzzzzzzzzzzf_, "final");
                    bool? izzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzg_);
                    string izzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzze_);
                    bool? izzzzzzzzzzzzzzzk_ = context.Operators.Equal(izzzzzzzzzzzzzzzj_, "cancelled");
                    bool? izzzzzzzzzzzzzzzl_ = context.Operators.Not(izzzzzzzzzzzzzzzk_);
                    bool? izzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzzzzzzzm_);
                    CqlDateTime izzzzzzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? izzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzq_, default);
                    bool? izzzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzr_);

                    return izzzzzzzzzzzzzzzs_;
                };
                IEnumerable<MedicationAdministration> hzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationAdministration>(hzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzi_);
                Observation hzzzzzzzzzzzzzzzk_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> hzzzzzzzzzzzzzzzl_ = context.Operators.Select<MedicationAdministration, Observation>(hzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzk_);

                return hzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzv_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> gzzzzzzzzzzzzzzzz_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzt_ = this.Hypoglycemic_Medication_Administration(context);
                bool? izzzzzzzzzzzzzzzu_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType izzzzzzzzzzzzzzzy_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzy_);
                    CqlDateTime jzzzzzzzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzzzzzzzz_);
                    DataType jzzzzzzzzzzzzzzzb_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzb_);
                    CqlDateTime jzzzzzzzzzzzzzzzd_ = context.Operators.Start(jzzzzzzzzzzzzzzzc_);
                    CqlQuantity jzzzzzzzzzzzzzzze_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime jzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzb_);
                    CqlDateTime jzzzzzzzzzzzzzzzi_ = context.Operators.Start(jzzzzzzzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzj_ = context.Operators.Interval(jzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzi_, true, true);
                    bool? jzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzj_, default);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzzb_);
                    CqlDateTime jzzzzzzzzzzzzzzzn_ = context.Operators.Start(jzzzzzzzzzzzzzzzm_);
                    bool? jzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzn_ is null));
                    bool? jzzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzo_);
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzq_ = BloodGlucoseLab?.StatusElement;
                    string jzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzq_);
                    bool? jzzzzzzzzzzzzzzzs_ = context.Operators.Equal(jzzzzzzzzzzzzzzzr_, "final");
                    bool? jzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzs_);
                    string jzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzq_);
                    bool? jzzzzzzzzzzzzzzzw_ = context.Operators.Equal(jzzzzzzzzzzzzzzzv_, "cancelled");
                    bool? jzzzzzzzzzzzzzzzx_ = context.Operators.Not(jzzzzzzzzzzzzzzzw_);
                    bool? jzzzzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzx_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzzy_);
                    CqlDateTime kzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? kzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzc_, default);
                    bool? kzzzzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzd_);

                    return kzzzzzzzzzzzzzzze_;
                };
                IEnumerable<MedicationAdministration> izzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationAdministration>(izzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzu_);
                Observation izzzzzzzzzzzzzzzw_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> izzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationAdministration, Observation>(izzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzw_);

                return izzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Observation, Observation>(gzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzb_(Observation BloodGlucoseLab)
            {
                CqlValueSet kzzzzzzzzzzzzzzzf_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> kzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? kzzzzzzzzzzzzzzzh_(Observation FollowupBloodGlucoseLab)
                {
                    DataType kzzzzzzzzzzzzzzzl_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzl_);
                    CqlDateTime kzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzm_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? kzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzo_, default);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzl_);
                    CqlDateTime kzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzr_);
                    DataType kzzzzzzzzzzzzzzzt_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzt_);
                    CqlDateTime kzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzt_);
                    CqlDateTime kzzzzzzzzzzzzzzzy_ = context.Operators.Start(kzzzzzzzzzzzzzzzx_);
                    CqlQuantity kzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime lzzzzzzzzzzzzzzza_ = context.Operators.Add(kzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzz_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzb_ = context.Operators.Interval(kzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzza_, false, true);
                    bool? lzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzb_, default);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzzt_);
                    CqlDateTime lzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzze_);
                    bool? lzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzf_ is null));
                    bool? lzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzg_);
                    bool? lzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzh_);
                    Code<ObservationStatus> lzzzzzzzzzzzzzzzj_ = FollowupBloodGlucoseLab?.StatusElement;
                    string lzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzj_);
                    bool? lzzzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzzzk_, "final");
                    bool? lzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzl_);
                    string lzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzzj_);
                    bool? lzzzzzzzzzzzzzzzp_ = context.Operators.Equal(lzzzzzzzzzzzzzzzo_, "cancelled");
                    bool? lzzzzzzzzzzzzzzzq_ = context.Operators.Not(lzzzzzzzzzzzzzzzp_);
                    bool? lzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzq_);
                    DataType lzzzzzzzzzzzzzzzs_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity lzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzzzzzzzzzzzs_ as Quantity);
                    CqlQuantity lzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? lzzzzzzzzzzzzzzzv_ = context.Operators.Greater(lzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzu_);
                    bool? lzzzzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzv_);

                    return lzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Observation> kzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzh_);
                Observation kzzzzzzzzzzzzzzzj_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> kzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, Observation>(kzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzj_);

                return kzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzd_ = context.Operators.Except<Observation>(gzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzc_);
            bool? hzzzzzzzzzzzzzzze_(Observation BloodGlucoseLab)
            {
                DataType lzzzzzzzzzzzzzzzx_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? mzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzza_, default);
                DataType mzzzzzzzzzzzzzzzc_ = BloodGlucoseLab?.Value;
                CqlQuantity mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzc_ as Quantity);
                CqlQuantity mzzzzzzzzzzzzzzze_ = context.Operators.Quantity(40m, "mg/dL");
                bool? mzzzzzzzzzzzzzzzf_ = context.Operators.Less(mzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzze_);
                bool? mzzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzf_);

                return mzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzf_);

            return hzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzr_);

        return gzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzh_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return mzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
