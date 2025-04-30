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
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime xzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzn_, true, false);
        object xzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", xzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient xzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> xzzzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> xzzzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzv_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? xzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.StatusElement;
            string yzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(yzzzzzzzzzzzzzzzza_, "finished");
            Period yzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzc_);
            CqlDateTime yzzzzzzzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzf_, default);
            bool? yzzzzzzzzzzzzzzzzh_ = context.Operators.And(yzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzg_);

            return yzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzx_);

        return xzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            Patient yzzzzzzzzzzzzzzzzl_ = this.Patient(context);
            Date yzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzl_?.BirthDateElement;
            string yzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzm_?.Value;
            CqlDateTime yzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDateTime(yzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime yzzzzzzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzzzzzzp_);
            int? yzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzq_, "year");
            bool? yzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzr_, 18);

            return yzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzt_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> yzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> yzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> yzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationAdministration>(yzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzw_);
        bool? yzzzzzzzzzzzzzzzzy_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> zzzzzzzzzzzzzzzzza_ = HypoMedication?.StatusElement;
            string zzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzb_, "completed");
            string zzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(zzzzzzzzzzzzzzzzze_, "not-done");
            bool? zzzzzzzzzzzzzzzzzg_ = context.Operators.Not(zzzzzzzzzzzzzzzzzf_);
            bool? zzzzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzg_);

            return zzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationAdministration> yzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationAdministration>(yzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzj_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> zzzzzzzzzzzzzzzzzl_ = this.Hypoglycemic_Medication_Administration(context);
            bool? zzzzzzzzzzzzzzzzzm_(MedicationAdministration HypoglycemicMedication)
            {
                DataType zzzzzzzzzzzzzzzzzq_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzq_);
                CqlDateTime zzzzzzzzzzzzzzzzzs_ = context.Operators.Start(zzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzt_, default);

                return zzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<MedicationAdministration> zzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationAdministration>(zzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzm_);
            Encounter zzzzzzzzzzzzzzzzzo_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationAdministration, Encounter>(zzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzo_);

            return zzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzj_);

        return zzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return zzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzx_ = this.Denominator(context);
        bool? zzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            CqlValueSet azzzzzzzzzzzzzzzzza_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzc_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> azzzzzzzzzzzzzzzzzo_ = this.Hypoglycemic_Medication_Administration(context);
                bool? azzzzzzzzzzzzzzzzzp_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType azzzzzzzzzzzzzzzzzt_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzt_);
                    CqlDateTime azzzzzzzzzzzzzzzzzv_ = context.Operators.Start(azzzzzzzzzzzzzzzzzu_);
                    DataType azzzzzzzzzzzzzzzzzw_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzw_);
                    CqlDateTime azzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzx_);
                    CqlQuantity azzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime bzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzz_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzw_);
                    CqlDateTime bzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzd_, true, true);
                    bool? bzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzze_, default);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzw_);
                    CqlDateTime bzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzh_);
                    bool? bzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzi_ is null));
                    bool? bzzzzzzzzzzzzzzzzzk_ = context.Operators.And(bzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzj_);
                    Code<ObservationStatus> bzzzzzzzzzzzzzzzzzl_ = BloodGlucoseLab?.StatusElement;
                    string bzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzzzl_);
                    bool? bzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzm_, "final");
                    bool? bzzzzzzzzzzzzzzzzzo_ = context.Operators.And(bzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzn_);
                    string bzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzzzzzzzzzl_);
                    bool? bzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzq_, "cancelled");
                    bool? bzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzr_);
                    bool? bzzzzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzt_);
                    CqlDateTime bzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzv_);
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? bzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzx_, default);
                    bool? bzzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzy_);

                    return bzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<MedicationAdministration> azzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationAdministration>(azzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzp_);
                Observation azzzzzzzzzzzzzzzzzr_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> azzzzzzzzzzzzzzzzzs_ = context.Operators.Select<MedicationAdministration, Observation>(azzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzr_);

                return azzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzc_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzg_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzza_ = this.Hypoglycemic_Medication_Administration(context);
                bool? czzzzzzzzzzzzzzzzzb_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType czzzzzzzzzzzzzzzzzf_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzf_);
                    CqlDateTime czzzzzzzzzzzzzzzzzh_ = context.Operators.Start(czzzzzzzzzzzzzzzzzg_);
                    DataType czzzzzzzzzzzzzzzzzi_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzi_);
                    CqlDateTime czzzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzzj_);
                    CqlQuantity czzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime czzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzl_);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzi_);
                    CqlDateTime czzzzzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzzzzo_);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzp_, true, true);
                    bool? czzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzq_, default);
                    CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzi_);
                    CqlDateTime czzzzzzzzzzzzzzzzzu_ = context.Operators.Start(czzzzzzzzzzzzzzzzzt_);
                    bool? czzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzu_ is null));
                    bool? czzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzv_);
                    Code<ObservationStatus> czzzzzzzzzzzzzzzzzx_ = BloodGlucoseLab?.StatusElement;
                    string czzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzzx_);
                    bool? czzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzy_, "final");
                    bool? dzzzzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzz_);
                    string dzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzzzzx_);
                    bool? dzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzc_, "cancelled");
                    bool? dzzzzzzzzzzzzzzzzze_ = context.Operators.Not(dzzzzzzzzzzzzzzzzzd_);
                    bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzzzzf_);
                    CqlDateTime dzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzh_);
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? dzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzj_, default);
                    bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.And(dzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzk_);

                    return dzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationAdministration>(czzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzb_);
                Observation czzzzzzzzzzzzzzzzzd_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> czzzzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationAdministration, Observation>(czzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzg_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzi_(Observation BloodGlucoseLab)
            {
                CqlValueSet dzzzzzzzzzzzzzzzzzm_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> dzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? dzzzzzzzzzzzzzzzzzo_(Observation FollowupBloodGlucoseLab)
                {
                    DataType dzzzzzzzzzzzzzzzzzs_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzzzzs_);
                    CqlDateTime dzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzt_);
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? dzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzv_, default);
                    CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzzzzs_);
                    CqlDateTime dzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzy_);
                    DataType ezzzzzzzzzzzzzzzzza_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzzzza_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzb_);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzzzza_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzzze_);
                    CqlQuantity ezzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime ezzzzzzzzzzzzzzzzzh_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzh_, false, true);
                    bool? ezzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzi_, default);
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzzzza_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzl_);
                    bool? ezzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzm_ is null));
                    bool? ezzzzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzn_);
                    bool? ezzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzo_);
                    Code<ObservationStatus> ezzzzzzzzzzzzzzzzzq_ = FollowupBloodGlucoseLab?.StatusElement;
                    string ezzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzzq_);
                    bool? ezzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzr_, "final");
                    bool? ezzzzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzs_);
                    string ezzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzzq_);
                    bool? ezzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzv_, "cancelled");
                    bool? ezzzzzzzzzzzzzzzzzx_ = context.Operators.Not(ezzzzzzzzzzzzzzzzzw_);
                    bool? ezzzzzzzzzzzzzzzzzy_ = context.Operators.And(ezzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzx_);
                    DataType ezzzzzzzzzzzzzzzzzz_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity fzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzz_ as Quantity);
                    CqlQuantity fzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? fzzzzzzzzzzzzzzzzzc_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzb_);
                    bool? fzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzc_);

                    return fzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Observation> dzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzo_);
                Observation dzzzzzzzzzzzzzzzzzq_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> dzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Observation>(dzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzq_);

                return dzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(azzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzi_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzk_ = context.Operators.Except<Observation>(azzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzl_(Observation BloodGlucoseLab)
            {
                DataType fzzzzzzzzzzzzzzzzze_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzzzze_);
                CqlDateTime fzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? fzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzh_, default);
                DataType fzzzzzzzzzzzzzzzzzj_ = BloodGlucoseLab?.Value;
                CqlQuantity fzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzzzzzzzzzzzzzj_ as Quantity);
                CqlQuantity fzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(40m, "mg/dL");
                bool? fzzzzzzzzzzzzzzzzzm_ = context.Operators.Less(fzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzl_);
                bool? fzzzzzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzm_);

                return fzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzm_);

            return azzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzy_);

        return zzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzo_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return fzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> fzzzzzzzzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
