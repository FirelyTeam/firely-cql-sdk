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
        CqlDateTime yzzzzzk_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime yzzzzzl_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> yzzzzzm_ = context.Operators.Interval(yzzzzzk_, yzzzzzl_, true, false);
        object yzzzzzn_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", yzzzzzm_);

        return (CqlInterval<CqlDateTime>)yzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzzzzzp_ = context.Operators.SingletonFrom<Patient>(yzzzzzo_);

        return yzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> yzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return yzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> yzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return yzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return yzzzzzs_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet yzzzzzt_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> yzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? yzzzzzv_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> yzzzzzx_ = EncounterInpatient?.StatusElement;
            string yzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzx_);
            bool? yzzzzzz_ = context.Operators.Equal(yzzzzzy_, "finished");
            Period zzzzzza_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> zzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzzzza_);
            CqlDateTime zzzzzzc_ = context.Operators.End(zzzzzzb_);
            CqlInterval<CqlDateTime> zzzzzzd_ = this.Measurement_Period(context);
            bool? zzzzzze_ = context.Operators.In<CqlDateTime>(zzzzzzc_, zzzzzzd_, default);
            bool? zzzzzzf_ = context.Operators.And(yzzzzzz_, zzzzzze_);

            return zzzzzzf_;
        };
        IEnumerable<Encounter> yzzzzzw_ = context.Operators.Where<Encounter>(yzzzzzu_, yzzzzzv_);

        return yzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzg_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? zzzzzzh_(Encounter InpatientEncounter)
        {
            Patient zzzzzzj_ = this.Patient(context);
            Date zzzzzzk_ = zzzzzzj_?.BirthDateElement;
            string zzzzzzl_ = zzzzzzk_?.Value;
            CqlDateTime zzzzzzm_ = context.Operators.ConvertStringToDateTime(zzzzzzl_);
            CqlInterval<CqlDateTime> zzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime zzzzzzo_ = context.Operators.Start(zzzzzzn_);
            int? zzzzzzp_ = context.Operators.CalculateAgeAt(zzzzzzm_, zzzzzzo_, "year");
            bool? zzzzzzq_ = context.Operators.GreaterOrEqual(zzzzzzp_, 18);

            return zzzzzzq_;
        };
        IEnumerable<Encounter> zzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzg_, zzzzzzh_);

        return zzzzzzi_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet zzzzzzr_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> zzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, zzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> zzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, zzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> zzzzzzv_ = context.Operators.Union<MedicationAdministration>(zzzzzzs_, zzzzzzu_);
        bool? zzzzzzw_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> zzzzzzy_ = HypoMedication?.StatusElement;
            string zzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzy_);
            bool? azzzzzza_ = context.Operators.Equal(zzzzzzz_, "completed");
            string azzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzy_);
            bool? azzzzzzd_ = context.Operators.Equal(azzzzzzc_, "not-done");
            bool? azzzzzze_ = context.Operators.Not(azzzzzzd_);
            bool? azzzzzzf_ = context.Operators.And(azzzzzza_, azzzzzze_);

            return azzzzzzf_;
        };
        IEnumerable<MedicationAdministration> zzzzzzx_ = context.Operators.Where<MedicationAdministration>(zzzzzzv_, zzzzzzw_);

        return zzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzg_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> azzzzzzh_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> azzzzzzj_ = this.Hypoglycemic_Medication_Administration(context);
            bool? azzzzzzk_(MedicationAdministration HypoglycemicMedication)
            {
                DataType azzzzzzo_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> azzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzo_);
                CqlDateTime azzzzzzq_ = context.Operators.Start(azzzzzzp_);
                CqlInterval<CqlDateTime> azzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? azzzzzzs_ = context.Operators.In<CqlDateTime>(azzzzzzq_, azzzzzzr_, default);

                return azzzzzzs_;
            };
            IEnumerable<MedicationAdministration> azzzzzzl_ = context.Operators.Where<MedicationAdministration>(azzzzzzj_, azzzzzzk_);
            Encounter azzzzzzm_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> azzzzzzn_ = context.Operators.Select<MedicationAdministration, Encounter>(azzzzzzl_, azzzzzzm_);

            return azzzzzzn_;
        };
        IEnumerable<Encounter> azzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzg_, azzzzzzh_);

        return azzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzt_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return azzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzu_ = this.Initial_Population(context);

        return azzzzzzu_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzv_ = this.Denominator(context);
        bool? azzzzzzw_(Encounter QualifyingEncounter)
        {
            CqlValueSet azzzzzzy_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> azzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> bzzzzzza_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> bzzzzzzm_ = this.Hypoglycemic_Medication_Administration(context);
                bool? bzzzzzzn_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType bzzzzzzr_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> bzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzr_);
                    CqlDateTime bzzzzzzt_ = context.Operators.Start(bzzzzzzs_);
                    DataType bzzzzzzu_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> bzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzu_);
                    CqlDateTime bzzzzzzw_ = context.Operators.Start(bzzzzzzv_);
                    CqlQuantity bzzzzzzx_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime bzzzzzzy_ = context.Operators.Subtract(bzzzzzzw_, bzzzzzzx_);
                    CqlInterval<CqlDateTime> czzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzu_);
                    CqlDateTime czzzzzzb_ = context.Operators.Start(czzzzzza_);
                    CqlInterval<CqlDateTime> czzzzzzc_ = context.Operators.Interval(bzzzzzzy_, czzzzzzb_, true, true);
                    bool? czzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzt_, czzzzzzc_, default);
                    CqlInterval<CqlDateTime> czzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzu_);
                    CqlDateTime czzzzzzg_ = context.Operators.Start(czzzzzzf_);
                    bool? czzzzzzh_ = context.Operators.Not((bool?)(czzzzzzg_ is null));
                    bool? czzzzzzi_ = context.Operators.And(czzzzzzd_, czzzzzzh_);
                    Code<ObservationStatus> czzzzzzj_ = BloodGlucoseLab?.StatusElement;
                    string czzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzj_);
                    bool? czzzzzzl_ = context.Operators.Equal(czzzzzzk_, "final");
                    bool? czzzzzzm_ = context.Operators.And(czzzzzzi_, czzzzzzl_);
                    string czzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzj_);
                    bool? czzzzzzp_ = context.Operators.Equal(czzzzzzo_, "cancelled");
                    bool? czzzzzzq_ = context.Operators.Not(czzzzzzp_);
                    bool? czzzzzzr_ = context.Operators.And(czzzzzzm_, czzzzzzq_);
                    CqlInterval<CqlDateTime> czzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzr_);
                    CqlDateTime czzzzzzu_ = context.Operators.Start(czzzzzzt_);
                    CqlInterval<CqlDateTime> czzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? czzzzzzw_ = context.Operators.In<CqlDateTime>(czzzzzzu_, czzzzzzv_, default);
                    bool? czzzzzzx_ = context.Operators.And(czzzzzzr_, czzzzzzw_);

                    return czzzzzzx_;
                };
                IEnumerable<MedicationAdministration> bzzzzzzo_ = context.Operators.Where<MedicationAdministration>(bzzzzzzm_, bzzzzzzn_);
                Observation bzzzzzzp_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> bzzzzzzq_ = context.Operators.Select<MedicationAdministration, Observation>(bzzzzzzo_, bzzzzzzp_);

                return bzzzzzzq_;
            };
            IEnumerable<Observation> bzzzzzzb_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzz_, bzzzzzza_);
            IEnumerable<Observation> bzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> bzzzzzze_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> czzzzzzy_ = this.Hypoglycemic_Medication_Administration(context);
                bool? czzzzzzz_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType dzzzzzzd_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> dzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzd_);
                    CqlDateTime dzzzzzzf_ = context.Operators.Start(dzzzzzze_);
                    DataType dzzzzzzg_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> dzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzg_);
                    CqlDateTime dzzzzzzi_ = context.Operators.Start(dzzzzzzh_);
                    CqlQuantity dzzzzzzj_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime dzzzzzzk_ = context.Operators.Subtract(dzzzzzzi_, dzzzzzzj_);
                    CqlInterval<CqlDateTime> dzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzg_);
                    CqlDateTime dzzzzzzn_ = context.Operators.Start(dzzzzzzm_);
                    CqlInterval<CqlDateTime> dzzzzzzo_ = context.Operators.Interval(dzzzzzzk_, dzzzzzzn_, true, true);
                    bool? dzzzzzzp_ = context.Operators.In<CqlDateTime>(dzzzzzzf_, dzzzzzzo_, default);
                    CqlInterval<CqlDateTime> dzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzg_);
                    CqlDateTime dzzzzzzs_ = context.Operators.Start(dzzzzzzr_);
                    bool? dzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzs_ is null));
                    bool? dzzzzzzu_ = context.Operators.And(dzzzzzzp_, dzzzzzzt_);
                    Code<ObservationStatus> dzzzzzzv_ = BloodGlucoseLab?.StatusElement;
                    string dzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzv_);
                    bool? dzzzzzzx_ = context.Operators.Equal(dzzzzzzw_, "final");
                    bool? dzzzzzzy_ = context.Operators.And(dzzzzzzu_, dzzzzzzx_);
                    string ezzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzv_);
                    bool? ezzzzzzb_ = context.Operators.Equal(ezzzzzza_, "cancelled");
                    bool? ezzzzzzc_ = context.Operators.Not(ezzzzzzb_);
                    bool? ezzzzzzd_ = context.Operators.And(dzzzzzzy_, ezzzzzzc_);
                    CqlInterval<CqlDateTime> ezzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzd_);
                    CqlDateTime ezzzzzzg_ = context.Operators.Start(ezzzzzzf_);
                    CqlInterval<CqlDateTime> ezzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? ezzzzzzi_ = context.Operators.In<CqlDateTime>(ezzzzzzg_, ezzzzzzh_, default);
                    bool? ezzzzzzj_ = context.Operators.And(ezzzzzzd_, ezzzzzzi_);

                    return ezzzzzzj_;
                };
                IEnumerable<MedicationAdministration> dzzzzzza_ = context.Operators.Where<MedicationAdministration>(czzzzzzy_, czzzzzzz_);
                Observation dzzzzzzb_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> dzzzzzzc_ = context.Operators.Select<MedicationAdministration, Observation>(dzzzzzza_, dzzzzzzb_);

                return dzzzzzzc_;
            };
            IEnumerable<Observation> bzzzzzzf_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzd_, bzzzzzze_);
            IEnumerable<Observation> bzzzzzzg_(Observation BloodGlucoseLab)
            {
                CqlValueSet ezzzzzzk_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> ezzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? ezzzzzzm_(Observation FollowupBloodGlucoseLab)
                {
                    DataType ezzzzzzq_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> ezzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzq_);
                    CqlDateTime ezzzzzzs_ = context.Operators.Start(ezzzzzzr_);
                    CqlInterval<CqlDateTime> ezzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? ezzzzzzu_ = context.Operators.In<CqlDateTime>(ezzzzzzs_, ezzzzzzt_, default);
                    CqlInterval<CqlDateTime> ezzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzq_);
                    CqlDateTime ezzzzzzx_ = context.Operators.Start(ezzzzzzw_);
                    DataType ezzzzzzy_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> ezzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzy_);
                    CqlDateTime fzzzzzza_ = context.Operators.Start(ezzzzzzz_);
                    CqlInterval<CqlDateTime> fzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzy_);
                    CqlDateTime fzzzzzzd_ = context.Operators.Start(fzzzzzzc_);
                    CqlQuantity fzzzzzze_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime fzzzzzzf_ = context.Operators.Add(fzzzzzzd_, fzzzzzze_);
                    CqlInterval<CqlDateTime> fzzzzzzg_ = context.Operators.Interval(fzzzzzza_, fzzzzzzf_, false, true);
                    bool? fzzzzzzh_ = context.Operators.In<CqlDateTime>(ezzzzzzx_, fzzzzzzg_, default);
                    CqlInterval<CqlDateTime> fzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzy_);
                    CqlDateTime fzzzzzzk_ = context.Operators.Start(fzzzzzzj_);
                    bool? fzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzk_ is null));
                    bool? fzzzzzzm_ = context.Operators.And(fzzzzzzh_, fzzzzzzl_);
                    bool? fzzzzzzn_ = context.Operators.And(ezzzzzzu_, fzzzzzzm_);
                    Code<ObservationStatus> fzzzzzzo_ = FollowupBloodGlucoseLab?.StatusElement;
                    string fzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzo_);
                    bool? fzzzzzzq_ = context.Operators.Equal(fzzzzzzp_, "final");
                    bool? fzzzzzzr_ = context.Operators.And(fzzzzzzn_, fzzzzzzq_);
                    string fzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzo_);
                    bool? fzzzzzzu_ = context.Operators.Equal(fzzzzzzt_, "cancelled");
                    bool? fzzzzzzv_ = context.Operators.Not(fzzzzzzu_);
                    bool? fzzzzzzw_ = context.Operators.And(fzzzzzzr_, fzzzzzzv_);
                    DataType fzzzzzzx_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity fzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzzx_ as Quantity);
                    CqlQuantity fzzzzzzz_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? gzzzzzza_ = context.Operators.Greater(fzzzzzzy_, fzzzzzzz_);
                    bool? gzzzzzzb_ = context.Operators.And(fzzzzzzw_, gzzzzzza_);

                    return gzzzzzzb_;
                };
                IEnumerable<Observation> ezzzzzzn_ = context.Operators.Where<Observation>(ezzzzzzl_, ezzzzzzm_);
                Observation ezzzzzzo_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> ezzzzzzp_ = context.Operators.Select<Observation, Observation>(ezzzzzzn_, ezzzzzzo_);

                return ezzzzzzp_;
            };
            IEnumerable<Observation> bzzzzzzh_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzf_, bzzzzzzg_);
            IEnumerable<Observation> bzzzzzzi_ = context.Operators.Except<Observation>(bzzzzzzb_, bzzzzzzh_);
            bool? bzzzzzzj_(Observation BloodGlucoseLab)
            {
                DataType gzzzzzzc_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> gzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzc_);
                CqlDateTime gzzzzzze_ = context.Operators.Start(gzzzzzzd_);
                CqlInterval<CqlDateTime> gzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? gzzzzzzg_ = context.Operators.In<CqlDateTime>(gzzzzzze_, gzzzzzzf_, default);
                DataType gzzzzzzh_ = BloodGlucoseLab?.Value;
                CqlQuantity gzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzzh_ as Quantity);
                CqlQuantity gzzzzzzj_ = context.Operators.Quantity(40m, "mg/dL");
                bool? gzzzzzzk_ = context.Operators.Less(gzzzzzzi_, gzzzzzzj_);
                bool? gzzzzzzl_ = context.Operators.And(gzzzzzzg_, gzzzzzzk_);

                return gzzzzzzl_;
            };
            IEnumerable<Observation> bzzzzzzk_ = context.Operators.Where<Observation>(bzzzzzzi_, bzzzzzzj_);
            bool? bzzzzzzl_ = context.Operators.Exists<Observation>(bzzzzzzk_);

            return bzzzzzzl_;
        };
        IEnumerable<Encounter> azzzzzzx_ = context.Operators.Where<Encounter>(azzzzzzv_, azzzzzzw_);

        return azzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzm_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return gzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> gzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzn_;
    }


    #endregion Expressions

}
