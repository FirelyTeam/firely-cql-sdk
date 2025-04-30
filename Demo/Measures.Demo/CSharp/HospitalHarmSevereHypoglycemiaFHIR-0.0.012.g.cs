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
        CqlDateTime uzzzzzzw_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime uzzzzzzx_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> uzzzzzzy_ = context.Operators.Interval(uzzzzzzw_, uzzzzzzx_, true, false);
        object uzzzzzzz_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", uzzzzzzy_);

        return (CqlInterval<CqlDateTime>)uzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzzzzzb_ = context.Operators.SingletonFrom<Patient>(vzzzzzza_);

        return vzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> vzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return vzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return vzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return vzzzzzze_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet vzzzzzzf_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? vzzzzzzh_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> vzzzzzzj_ = EncounterInpatient?.StatusElement;
            string vzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzj_);
            bool? vzzzzzzl_ = context.Operators.Equal(vzzzzzzk_, "finished");
            Period vzzzzzzm_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> vzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzzzzm_);
            CqlDateTime vzzzzzzo_ = context.Operators.End(vzzzzzzn_);
            CqlInterval<CqlDateTime> vzzzzzzp_ = this.Measurement_Period(context);
            bool? vzzzzzzq_ = context.Operators.In<CqlDateTime>(vzzzzzzo_, vzzzzzzp_, default);
            bool? vzzzzzzr_ = context.Operators.And(vzzzzzzl_, vzzzzzzq_);

            return vzzzzzzr_;
        };
        IEnumerable<Encounter> vzzzzzzi_ = context.Operators.Where<Encounter>(vzzzzzzg_, vzzzzzzh_);

        return vzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzs_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? vzzzzzzt_(Encounter InpatientEncounter)
        {
            Patient vzzzzzzv_ = this.Patient(context);
            Date vzzzzzzw_ = vzzzzzzv_?.BirthDateElement;
            string vzzzzzzx_ = vzzzzzzw_?.Value;
            CqlDateTime vzzzzzzy_ = context.Operators.ConvertStringToDateTime(vzzzzzzx_);
            CqlInterval<CqlDateTime> vzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime wzzzzzza_ = context.Operators.Start(vzzzzzzz_);
            int? wzzzzzzb_ = context.Operators.CalculateAgeAt(vzzzzzzy_, wzzzzzza_, "year");
            bool? wzzzzzzc_ = context.Operators.GreaterOrEqual(wzzzzzzb_, 18);

            return wzzzzzzc_;
        };
        IEnumerable<Encounter> vzzzzzzu_ = context.Operators.Where<Encounter>(vzzzzzzs_, vzzzzzzt_);

        return vzzzzzzu_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet wzzzzzzd_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> wzzzzzze_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, wzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> wzzzzzzg_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, wzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> wzzzzzzh_ = context.Operators.Union<MedicationAdministration>(wzzzzzze_, wzzzzzzg_);
        bool? wzzzzzzi_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> wzzzzzzk_ = HypoMedication?.StatusElement;
            string wzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzk_);
            bool? wzzzzzzm_ = context.Operators.Equal(wzzzzzzl_, "completed");
            string wzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzk_);
            bool? wzzzzzzp_ = context.Operators.Equal(wzzzzzzo_, "not-done");
            bool? wzzzzzzq_ = context.Operators.Not(wzzzzzzp_);
            bool? wzzzzzzr_ = context.Operators.And(wzzzzzzm_, wzzzzzzq_);

            return wzzzzzzr_;
        };
        IEnumerable<MedicationAdministration> wzzzzzzj_ = context.Operators.Where<MedicationAdministration>(wzzzzzzh_, wzzzzzzi_);

        return wzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzs_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> wzzzzzzt_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> wzzzzzzv_ = this.Hypoglycemic_Medication_Administration(context);
            bool? wzzzzzzw_(MedicationAdministration HypoglycemicMedication)
            {
                DataType xzzzzzza_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> xzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzza_);
                CqlDateTime xzzzzzzc_ = context.Operators.Start(xzzzzzzb_);
                CqlInterval<CqlDateTime> xzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? xzzzzzze_ = context.Operators.In<CqlDateTime>(xzzzzzzc_, xzzzzzzd_, default);

                return xzzzzzze_;
            };
            IEnumerable<MedicationAdministration> wzzzzzzx_ = context.Operators.Where<MedicationAdministration>(wzzzzzzv_, wzzzzzzw_);
            Encounter wzzzzzzy_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> wzzzzzzz_ = context.Operators.Select<MedicationAdministration, Encounter>(wzzzzzzx_, wzzzzzzy_);

            return wzzzzzzz_;
        };
        IEnumerable<Encounter> wzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzs_, wzzzzzzt_);

        return wzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzf_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return xzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzg_ = this.Initial_Population(context);

        return xzzzzzzg_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzh_ = this.Denominator(context);
        bool? xzzzzzzi_(Encounter QualifyingEncounter)
        {
            CqlValueSet xzzzzzzk_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> xzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> xzzzzzzm_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> xzzzzzzy_ = this.Hypoglycemic_Medication_Administration(context);
                bool? xzzzzzzz_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType yzzzzzzd_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> yzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzd_);
                    CqlDateTime yzzzzzzf_ = context.Operators.Start(yzzzzzze_);
                    DataType yzzzzzzg_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> yzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzg_);
                    CqlDateTime yzzzzzzi_ = context.Operators.Start(yzzzzzzh_);
                    CqlQuantity yzzzzzzj_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime yzzzzzzk_ = context.Operators.Subtract(yzzzzzzi_, yzzzzzzj_);
                    CqlInterval<CqlDateTime> yzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzg_);
                    CqlDateTime yzzzzzzn_ = context.Operators.Start(yzzzzzzm_);
                    CqlInterval<CqlDateTime> yzzzzzzo_ = context.Operators.Interval(yzzzzzzk_, yzzzzzzn_, true, true);
                    bool? yzzzzzzp_ = context.Operators.In<CqlDateTime>(yzzzzzzf_, yzzzzzzo_, default);
                    CqlInterval<CqlDateTime> yzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzg_);
                    CqlDateTime yzzzzzzs_ = context.Operators.Start(yzzzzzzr_);
                    bool? yzzzzzzt_ = context.Operators.Not((bool?)(yzzzzzzs_ is null));
                    bool? yzzzzzzu_ = context.Operators.And(yzzzzzzp_, yzzzzzzt_);
                    Code<ObservationStatus> yzzzzzzv_ = BloodGlucoseLab?.StatusElement;
                    string yzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzv_);
                    bool? yzzzzzzx_ = context.Operators.Equal(yzzzzzzw_, "final");
                    bool? yzzzzzzy_ = context.Operators.And(yzzzzzzu_, yzzzzzzx_);
                    string zzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzv_);
                    bool? zzzzzzzb_ = context.Operators.Equal(zzzzzzza_, "cancelled");
                    bool? zzzzzzzc_ = context.Operators.Not(zzzzzzzb_);
                    bool? zzzzzzzd_ = context.Operators.And(yzzzzzzy_, zzzzzzzc_);
                    CqlInterval<CqlDateTime> zzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzd_);
                    CqlDateTime zzzzzzzg_ = context.Operators.Start(zzzzzzzf_);
                    CqlInterval<CqlDateTime> zzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? zzzzzzzi_ = context.Operators.In<CqlDateTime>(zzzzzzzg_, zzzzzzzh_, default);
                    bool? zzzzzzzj_ = context.Operators.And(zzzzzzzd_, zzzzzzzi_);

                    return zzzzzzzj_;
                };
                IEnumerable<MedicationAdministration> yzzzzzza_ = context.Operators.Where<MedicationAdministration>(xzzzzzzy_, xzzzzzzz_);
                Observation yzzzzzzb_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> yzzzzzzc_ = context.Operators.Select<MedicationAdministration, Observation>(yzzzzzza_, yzzzzzzb_);

                return yzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzn_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzl_, xzzzzzzm_);
            IEnumerable<Observation> xzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> xzzzzzzq_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> zzzzzzzk_ = this.Hypoglycemic_Medication_Administration(context);
                bool? zzzzzzzl_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType zzzzzzzp_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> zzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzp_);
                    CqlDateTime zzzzzzzr_ = context.Operators.Start(zzzzzzzq_);
                    DataType zzzzzzzs_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> zzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzs_);
                    CqlDateTime zzzzzzzu_ = context.Operators.Start(zzzzzzzt_);
                    CqlQuantity zzzzzzzv_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime zzzzzzzw_ = context.Operators.Subtract(zzzzzzzu_, zzzzzzzv_);
                    CqlInterval<CqlDateTime> zzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzs_);
                    CqlDateTime zzzzzzzz_ = context.Operators.Start(zzzzzzzy_);
                    CqlInterval<CqlDateTime> azzzzzzza_ = context.Operators.Interval(zzzzzzzw_, zzzzzzzz_, true, true);
                    bool? azzzzzzzb_ = context.Operators.In<CqlDateTime>(zzzzzzzr_, azzzzzzza_, default);
                    CqlInterval<CqlDateTime> azzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzs_);
                    CqlDateTime azzzzzzze_ = context.Operators.Start(azzzzzzzd_);
                    bool? azzzzzzzf_ = context.Operators.Not((bool?)(azzzzzzze_ is null));
                    bool? azzzzzzzg_ = context.Operators.And(azzzzzzzb_, azzzzzzzf_);
                    Code<ObservationStatus> azzzzzzzh_ = BloodGlucoseLab?.StatusElement;
                    string azzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzh_);
                    bool? azzzzzzzj_ = context.Operators.Equal(azzzzzzzi_, "final");
                    bool? azzzzzzzk_ = context.Operators.And(azzzzzzzg_, azzzzzzzj_);
                    string azzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzh_);
                    bool? azzzzzzzn_ = context.Operators.Equal(azzzzzzzm_, "cancelled");
                    bool? azzzzzzzo_ = context.Operators.Not(azzzzzzzn_);
                    bool? azzzzzzzp_ = context.Operators.And(azzzzzzzk_, azzzzzzzo_);
                    CqlInterval<CqlDateTime> azzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzp_);
                    CqlDateTime azzzzzzzs_ = context.Operators.Start(azzzzzzzr_);
                    CqlInterval<CqlDateTime> azzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? azzzzzzzu_ = context.Operators.In<CqlDateTime>(azzzzzzzs_, azzzzzzzt_, default);
                    bool? azzzzzzzv_ = context.Operators.And(azzzzzzzp_, azzzzzzzu_);

                    return azzzzzzzv_;
                };
                IEnumerable<MedicationAdministration> zzzzzzzm_ = context.Operators.Where<MedicationAdministration>(zzzzzzzk_, zzzzzzzl_);
                Observation zzzzzzzn_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> zzzzzzzo_ = context.Operators.Select<MedicationAdministration, Observation>(zzzzzzzm_, zzzzzzzn_);

                return zzzzzzzo_;
            };
            IEnumerable<Observation> xzzzzzzr_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzp_, xzzzzzzq_);
            IEnumerable<Observation> xzzzzzzs_(Observation BloodGlucoseLab)
            {
                CqlValueSet azzzzzzzw_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> azzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? azzzzzzzy_(Observation FollowupBloodGlucoseLab)
                {
                    DataType bzzzzzzzc_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> bzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzc_);
                    CqlDateTime bzzzzzzze_ = context.Operators.Start(bzzzzzzzd_);
                    CqlInterval<CqlDateTime> bzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? bzzzzzzzg_ = context.Operators.In<CqlDateTime>(bzzzzzzze_, bzzzzzzzf_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzc_);
                    CqlDateTime bzzzzzzzj_ = context.Operators.Start(bzzzzzzzi_);
                    DataType bzzzzzzzk_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> bzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzk_);
                    CqlDateTime bzzzzzzzm_ = context.Operators.Start(bzzzzzzzl_);
                    CqlInterval<CqlDateTime> bzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzk_);
                    CqlDateTime bzzzzzzzp_ = context.Operators.Start(bzzzzzzzo_);
                    CqlQuantity bzzzzzzzq_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime bzzzzzzzr_ = context.Operators.Add(bzzzzzzzp_, bzzzzzzzq_);
                    CqlInterval<CqlDateTime> bzzzzzzzs_ = context.Operators.Interval(bzzzzzzzm_, bzzzzzzzr_, false, true);
                    bool? bzzzzzzzt_ = context.Operators.In<CqlDateTime>(bzzzzzzzj_, bzzzzzzzs_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzzzk_);
                    CqlDateTime bzzzzzzzw_ = context.Operators.Start(bzzzzzzzv_);
                    bool? bzzzzzzzx_ = context.Operators.Not((bool?)(bzzzzzzzw_ is null));
                    bool? bzzzzzzzy_ = context.Operators.And(bzzzzzzzt_, bzzzzzzzx_);
                    bool? bzzzzzzzz_ = context.Operators.And(bzzzzzzzg_, bzzzzzzzy_);
                    Code<ObservationStatus> czzzzzzza_ = FollowupBloodGlucoseLab?.StatusElement;
                    string czzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzza_);
                    bool? czzzzzzzc_ = context.Operators.Equal(czzzzzzzb_, "final");
                    bool? czzzzzzzd_ = context.Operators.And(bzzzzzzzz_, czzzzzzzc_);
                    string czzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzza_);
                    bool? czzzzzzzg_ = context.Operators.Equal(czzzzzzzf_, "cancelled");
                    bool? czzzzzzzh_ = context.Operators.Not(czzzzzzzg_);
                    bool? czzzzzzzi_ = context.Operators.And(czzzzzzzd_, czzzzzzzh_);
                    DataType czzzzzzzj_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity czzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzzzj_ as Quantity);
                    CqlQuantity czzzzzzzl_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? czzzzzzzm_ = context.Operators.Greater(czzzzzzzk_, czzzzzzzl_);
                    bool? czzzzzzzn_ = context.Operators.And(czzzzzzzi_, czzzzzzzm_);

                    return czzzzzzzn_;
                };
                IEnumerable<Observation> azzzzzzzz_ = context.Operators.Where<Observation>(azzzzzzzx_, azzzzzzzy_);
                Observation bzzzzzzza_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> bzzzzzzzb_ = context.Operators.Select<Observation, Observation>(azzzzzzzz_, bzzzzzzza_);

                return bzzzzzzzb_;
            };
            IEnumerable<Observation> xzzzzzzt_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzr_, xzzzzzzs_);
            IEnumerable<Observation> xzzzzzzu_ = context.Operators.Except<Observation>(xzzzzzzn_, xzzzzzzt_);
            bool? xzzzzzzv_(Observation BloodGlucoseLab)
            {
                DataType czzzzzzzo_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> czzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzo_);
                CqlDateTime czzzzzzzq_ = context.Operators.Start(czzzzzzzp_);
                CqlInterval<CqlDateTime> czzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? czzzzzzzs_ = context.Operators.In<CqlDateTime>(czzzzzzzq_, czzzzzzzr_, default);
                DataType czzzzzzzt_ = BloodGlucoseLab?.Value;
                CqlQuantity czzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzzzt_ as Quantity);
                CqlQuantity czzzzzzzv_ = context.Operators.Quantity(40m, "mg/dL");
                bool? czzzzzzzw_ = context.Operators.Less(czzzzzzzu_, czzzzzzzv_);
                bool? czzzzzzzx_ = context.Operators.And(czzzzzzzs_, czzzzzzzw_);

                return czzzzzzzx_;
            };
            IEnumerable<Observation> xzzzzzzw_ = context.Operators.Where<Observation>(xzzzzzzu_, xzzzzzzv_);
            bool? xzzzzzzx_ = context.Operators.Exists<Observation>(xzzzzzzw_);

            return xzzzzzzx_;
        };
        IEnumerable<Encounter> xzzzzzzj_ = context.Operators.Where<Encounter>(xzzzzzzh_, xzzzzzzi_);

        return xzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzy_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return czzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> czzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzz_;
    }


    #endregion Expressions

}
