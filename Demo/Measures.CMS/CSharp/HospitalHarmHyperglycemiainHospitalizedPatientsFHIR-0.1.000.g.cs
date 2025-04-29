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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.1.000")]
public partial class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000>
{
    private HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000() {}

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose Lab Test Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext _) => _Glucose_Lab_Test_Mass_Per_Volume;
    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlValueSetDefinition("Hypoglycemics Treatment Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext _) => _Hypoglycemics_Treatment_Medications;
    private static readonly CqlValueSet _Hypoglycemics_Treatment_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

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
        CqlDateTime uzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime uzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzza_ = context.Operators.Interval(uzzzzzzzzzy_, uzzzzzzzzzz_, true, true);
        object vzzzzzzzzzb_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", vzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzc_);

        return vzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet vzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            Patient vzzzzzzzzzi_ = this.Patient(context);
            Date vzzzzzzzzzj_ = vzzzzzzzzzi_?.BirthDateElement;
            string vzzzzzzzzzk_ = vzzzzzzzzzj_?.Value;
            CqlDate vzzzzzzzzzl_ = context.Operators.ConvertStringToDate(vzzzzzzzzzk_);
            Period vzzzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzm_);
            CqlDateTime vzzzzzzzzzo_ = context.Operators.Start(vzzzzzzzzzn_);
            CqlDate vzzzzzzzzzp_ = context.Operators.DateFrom(vzzzzzzzzzo_);
            int? vzzzzzzzzzq_ = context.Operators.CalculateAgeAt(vzzzzzzzzzl_, vzzzzzzzzzp_, "year");
            bool? vzzzzzzzzzr_ = context.Operators.GreaterOrEqual(vzzzzzzzzzq_, 18);
            CqlInterval<CqlDateTime> vzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzm_);
            CqlDateTime vzzzzzzzzzu_ = context.Operators.End(vzzzzzzzzzt_);
            CqlInterval<CqlDateTime> vzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzu_, vzzzzzzzzzv_, "day");
            bool? vzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzr_, vzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> vzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? vzzzzzzzzzz_ = vzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> wzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzzzz_);
            bool? wzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzza_, "finished");
            bool? wzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzx_, wzzzzzzzzzb_);

            return wzzzzzzzzzc_;
        };
        IEnumerable<Encounter> vzzzzzzzzzh_ = context.Operators.Where<Encounter>(vzzzzzzzzzf_, vzzzzzzzzzg_);

        return vzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzd_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? wzzzzzzzzze_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? wzzzzzzzzzi_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, wzzzzzzzzzh_);

            return wzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzf_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(wzzzzzzzzzd_, wzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(wzzzzzzzzzf_);

        return wzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzj_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet wzzzzzzzzzp_ = this.Diabetes(context);
            IEnumerable<Condition> wzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? wzzzzzzzzzr_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime wzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzv_);
                CqlInterval<CqlDateTime> wzzzzzzzzzx_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime wzzzzzzzzzy_ = context.Operators.End(wzzzzzzzzzx_);
                bool? wzzzzzzzzzz_ = context.Operators.Before(wzzzzzzzzzw_, wzzzzzzzzzy_, default);

                return wzzzzzzzzzz_;
            };
            IEnumerable<Condition> wzzzzzzzzzs_ = context.Operators.Where<Condition>(wzzzzzzzzzq_, wzzzzzzzzzr_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? wzzzzzzzzzt_(Condition Diabetes) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzu_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(wzzzzzzzzzs_, wzzzzzzzzzt_);

            return wzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> wzzzzzzzzzl_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(wzzzzzzzzzj_, wzzzzzzzzzk_);
        Encounter wzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter xzzzzzzzzza_ = Hospitalization?.encounter;

            return xzzzzzzzzza_;
        };
        IEnumerable<Encounter> wzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(wzzzzzzzzzl_, wzzzzzzzzzm_);
        IEnumerable<Encounter> wzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzn_);

        return wzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> xzzzzzzzzzb_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet xzzzzzzzzzc_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> xzzzzzzzzzd_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, xzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> xzzzzzzzzzf_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, xzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> xzzzzzzzzzg_ = context.Operators.Union<MedicationAdministration>(xzzzzzzzzzd_, xzzzzzzzzzf_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> xzzzzzzzzzh_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(xzzzzzzzzzb_, xzzzzzzzzzg_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? xzzzzzzzzzi_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? xzzzzzzzzzp_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> xzzzzzzzzzj_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(xzzzzzzzzzh_, xzzzzzzzzzi_);
        bool? xzzzzzzzzzk_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> xzzzzzzzzzq_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? xzzzzzzzzzr_ = xzzzzzzzzzq_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> xzzzzzzzzzs_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(xzzzzzzzzzr_);
            bool? xzzzzzzzzzt_ = context.Operators.Equal(xzzzzzzzzzs_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? xzzzzzzzzzv_ = xzzzzzzzzzq_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> xzzzzzzzzzw_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(xzzzzzzzzzv_);
            bool? xzzzzzzzzzx_ = context.Operators.Equal(xzzzzzzzzzw_, "not-done");
            bool? xzzzzzzzzzy_ = context.Operators.Not(xzzzzzzzzzx_);
            bool? xzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzt_, xzzzzzzzzzy_);
            CqlInterval<CqlDateTime> yzzzzzzzzza_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType yzzzzzzzzzb_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object yzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzb_);
            CqlInterval<CqlDateTime> yzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzc_);
            bool? yzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzzzzzzza_, yzzzzzzzzzd_, default);
            bool? yzzzzzzzzzf_ = context.Operators.And(xzzzzzzzzzz_, yzzzzzzzzze_);

            return yzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> xzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(xzzzzzzzzzj_, xzzzzzzzzzk_);
        Encounter xzzzzzzzzzm_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter yzzzzzzzzzg_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return yzzzzzzzzzg_;
        };
        IEnumerable<Encounter> xzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(xzzzzzzzzzl_, xzzzzzzzzzm_);
        IEnumerable<Encounter> xzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzn_);

        return xzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzh_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzi_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet yzzzzzzzzzn_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> yzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? yzzzzzzzzzp_(Observation GlucoseTest)
            {
                object yzzzzzzzzzt_()
                {
                    bool zzzzzzzzzzp_()
                    {
                        DataType zzzzzzzzzzs_ = GlucoseTest?.Effective;
                        object zzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzs_);
                        bool zzzzzzzzzzu_ = zzzzzzzzzzt_ is CqlDateTime;

                        return zzzzzzzzzzu_;
                    };
                    bool zzzzzzzzzzq_()
                    {
                        DataType zzzzzzzzzzv_ = GlucoseTest?.Effective;
                        object zzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzv_);
                        bool zzzzzzzzzzx_ = zzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                        return zzzzzzzzzzx_;
                    };
                    bool zzzzzzzzzzr_()
                    {
                        DataType zzzzzzzzzzy_ = GlucoseTest?.Effective;
                        object zzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzy_);
                        bool azzzzzzzzzza_ = zzzzzzzzzzz_ is CqlDateTime;

                        return azzzzzzzzzza_;
                    };
                    if (zzzzzzzzzzp_())
                    {
                        DataType azzzzzzzzzzb_ = GlucoseTest?.Effective;
                        object azzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzb_);

                        return (azzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else if (zzzzzzzzzzq_())
                    {
                        DataType azzzzzzzzzzd_ = GlucoseTest?.Effective;
                        object azzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzd_);

                        return (azzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (zzzzzzzzzzr_())
                    {
                        DataType azzzzzzzzzzf_ = GlucoseTest?.Effective;
                        object azzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzf_);

                        return (azzzzzzzzzzg_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime yzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.Earliest(context, yzzzzzzzzzt_());
                CqlInterval<CqlDateTime> yzzzzzzzzzv_ = Hospitalization?.hospitalizationPeriod;
                bool? yzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzu_, yzzzzzzzzzv_, default);
                Code<ObservationStatus> yzzzzzzzzzx_ = GlucoseTest?.StatusElement;
                ObservationStatus? yzzzzzzzzzy_ = yzzzzzzzzzx_?.Value;
                Code<ObservationStatus> yzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzy_);
                string zzzzzzzzzza_ = context.Operators.Convert<string>(yzzzzzzzzzz_);
                string[] zzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzc_ = context.Operators.In<string>(zzzzzzzzzza_, zzzzzzzzzzb_ as IEnumerable<string>);
                bool? zzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzw_, zzzzzzzzzzc_);
                ObservationStatus? zzzzzzzzzzf_ = yzzzzzzzzzx_?.Value;
                Code<ObservationStatus> zzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzf_);
                bool? zzzzzzzzzzh_ = context.Operators.Equal(zzzzzzzzzzg_, "cancelled");
                bool? zzzzzzzzzzi_ = context.Operators.Not(zzzzzzzzzzh_);
                bool? zzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzd_, zzzzzzzzzzi_);
                DataType zzzzzzzzzzk_ = GlucoseTest?.Value;
                object zzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzk_);
                CqlQuantity zzzzzzzzzzm_ = context.Operators.Quantity(200m, "mg/dL");
                bool? zzzzzzzzzzn_ = context.Operators.GreaterOrEqual(zzzzzzzzzzl_ as CqlQuantity, zzzzzzzzzzm_);
                bool? zzzzzzzzzzo_ = context.Operators.And(zzzzzzzzzzj_, zzzzzzzzzzn_);

                return zzzzzzzzzzo_;
            };
            IEnumerable<Observation> yzzzzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzzzzo_, yzzzzzzzzzp_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? yzzzzzzzzzr_(Observation GlucoseTest) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzs_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzq_, yzzzzzzzzzr_);

            return yzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzj_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzh_, yzzzzzzzzzi_);
        Encounter yzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter azzzzzzzzzzh_ = Hospitalization?.encounter;

            return azzzzzzzzzzh_;
        };
        IEnumerable<Encounter> yzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(yzzzzzzzzzj_, yzzzzzzzzzk_);
        IEnumerable<Encounter> yzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzl_);

        return yzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzi_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> azzzzzzzzzzj_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> azzzzzzzzzzk_ = context.Operators.Union<Encounter>(azzzzzzzzzzi_, azzzzzzzzzzj_);
        IEnumerable<Encounter> azzzzzzzzzzl_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> azzzzzzzzzzm_ = context.Operators.Union<Encounter>(azzzzzzzzzzk_, azzzzzzzzzzl_);

        return azzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzn_ = this.Initial_Population(context);

        return azzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzo_ = this.Denominator(context);

        return azzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Hospital Days Max 10")]
    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime azzzzzzzzzzp_ = context.Operators.Start(Period);
        CqlDateTime azzzzzzzzzzq_ = context.Operators.End(Period);
        CqlQuantity azzzzzzzzzzs_ = context.Operators.Quantity(10m, "days");
        CqlDateTime azzzzzzzzzzt_ = context.Operators.Add(azzzzzzzzzzp_, azzzzzzzzzzs_);
        CqlDateTime[] azzzzzzzzzzu_ = [
            azzzzzzzzzzq_,
            azzzzzzzzzzt_,
        ];
        CqlDateTime azzzzzzzzzzv_ = context.Operators.Min<CqlDateTime>(azzzzzzzzzzu_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> azzzzzzzzzzw_ = context.Operators.Interval(azzzzzzzzzzp_, azzzzzzzzzzv_, true, true);

        return azzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime azzzzzzzzzzx_ = context.Operators.Start(Period);
        CqlDateTime azzzzzzzzzzy_ = context.Operators.End(Period);
        int? azzzzzzzzzzz_ = context.Operators.DurationBetween(azzzzzzzzzzx_, azzzzzzzzzzy_, "day");
        CqlInterval<int?> bzzzzzzzzzza_ = context.Operators.Interval(1, azzzzzzzzzzz_, true, true);
        CqlInterval<int?>[] bzzzzzzzzzzb_ = [
            bzzzzzzzzzza_,
        ];
        IEnumerable<CqlInterval<int?>> bzzzzzzzzzzc_ = context.Operators.Expand(bzzzzzzzzzzb_ as IEnumerable<CqlInterval<int?>>, default);
        int? bzzzzzzzzzzd_(CqlInterval<int?> DayExpand)
        {
            int? bzzzzzzzzzzg_ = context.Operators.End(DayExpand);

            return bzzzzzzzzzzg_;
        };
        IEnumerable<int?> bzzzzzzzzzze_ = context.Operators.Select<CqlInterval<int?>, int?>(bzzzzzzzzzzc_, bzzzzzzzzzzd_);
        IEnumerable<int?> bzzzzzzzzzzf_ = context.Operators.Distinct<int?>(bzzzzzzzzzze_);

        return bzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> bzzzzzzzzzzh_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? bzzzzzzzzzzi_(int? DayNumber)
        {
            CqlDateTime bzzzzzzzzzzl_ = context.Operators.Start(Period);
            CqlQuantity bzzzzzzzzzzm_ = context.Operators.Quantity(24m, "hours");
            int? bzzzzzzzzzzn_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity bzzzzzzzzzzo_ = context.Operators.ConvertIntegerToQuantity(bzzzzzzzzzzn_);
            CqlQuantity bzzzzzzzzzzp_ = context.Operators.Multiply(bzzzzzzzzzzm_, bzzzzzzzzzzo_);
            CqlDateTime bzzzzzzzzzzq_ = context.Operators.Add(bzzzzzzzzzzl_, bzzzzzzzzzzp_);
            CqlDateTime bzzzzzzzzzzr_()
            {
                bool bzzzzzzzzzzu_()
                {
                    CqlDateTime bzzzzzzzzzzv_ = context.Operators.Start(Period);
                    CqlQuantity bzzzzzzzzzzw_ = context.Operators.Quantity(24m, "hours");
                    int? bzzzzzzzzzzx_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity bzzzzzzzzzzy_ = context.Operators.ConvertIntegerToQuantity(bzzzzzzzzzzx_);
                    CqlQuantity bzzzzzzzzzzz_ = context.Operators.Multiply(bzzzzzzzzzzw_, bzzzzzzzzzzy_);
                    CqlDateTime czzzzzzzzzza_ = context.Operators.Add(bzzzzzzzzzzv_, bzzzzzzzzzzz_);
                    CqlDateTime czzzzzzzzzzb_ = context.Operators.End(Period);
                    int? czzzzzzzzzzc_ = context.Operators.DurationBetween(czzzzzzzzzza_, czzzzzzzzzzb_, "hour");
                    bool? czzzzzzzzzzd_ = context.Operators.Less(czzzzzzzzzzc_, 24);

                    return czzzzzzzzzzd_ ?? false;
                };
                if (bzzzzzzzzzzu_())
                {
                    CqlDateTime czzzzzzzzzze_ = context.Operators.Start(Period);
                    CqlQuantity czzzzzzzzzzf_ = context.Operators.Quantity(24m, "hours");
                    int? czzzzzzzzzzg_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity czzzzzzzzzzh_ = context.Operators.ConvertIntegerToQuantity(czzzzzzzzzzg_);
                    CqlQuantity czzzzzzzzzzi_ = context.Operators.Multiply(czzzzzzzzzzf_, czzzzzzzzzzh_);
                    CqlDateTime czzzzzzzzzzj_ = context.Operators.Add(czzzzzzzzzze_, czzzzzzzzzzi_);

                    return czzzzzzzzzzj_;
                }
                else
                {
                    CqlDateTime czzzzzzzzzzk_ = context.Operators.Start(Period);
                    CqlQuantity czzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity czzzzzzzzzzm_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity czzzzzzzzzzn_ = context.Operators.Multiply(czzzzzzzzzzl_, czzzzzzzzzzm_);
                    CqlDateTime czzzzzzzzzzo_ = context.Operators.Add(czzzzzzzzzzk_, czzzzzzzzzzn_);

                    return czzzzzzzzzzo_;
                }
            };
            CqlInterval<CqlDateTime> bzzzzzzzzzzs_ = context.Operators.Interval(bzzzzzzzzzzq_, bzzzzzzzzzzr_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? bzzzzzzzzzzt_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, bzzzzzzzzzzs_);

            return bzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> bzzzzzzzzzzj_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(bzzzzzzzzzzh_, bzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> bzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(bzzzzzzzzzzj_);

        return bzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzp_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? czzzzzzzzzzq_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> czzzzzzzzzzv_ = this.Hospital_Days_Max_10(context, czzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzx_ = this.Hospital_Days_Max_10(context, czzzzzzzzzzt_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> czzzzzzzzzzy_ = this.Days_In_Period(context, czzzzzzzzzzx_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? czzzzzzzzzzz_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, czzzzzzzzzzt_, czzzzzzzzzzv_, czzzzzzzzzzy_);

            return czzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> czzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(czzzzzzzzzzp_, czzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> czzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(czzzzzzzzzzr_);

        return czzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> dzzzzzzzzzza_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? dzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter dzzzzzzzzzze_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> dzzzzzzzzzzf_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> dzzzzzzzzzzg_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? dzzzzzzzzzzh_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? dzzzzzzzzzzl_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> dzzzzzzzzzzm_ = EncounterDay?.dayPeriod;
                CqlValueSet dzzzzzzzzzzn_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> dzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? dzzzzzzzzzzp_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> ezzzzzzzzzze_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ezzzzzzzzzzf_ = ezzzzzzzzzze_?.Value;
                    Code<ObservationStatus> ezzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzf_);
                    string ezzzzzzzzzzh_ = context.Operators.Convert<string>(ezzzzzzzzzzg_);
                    string[] ezzzzzzzzzzi_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ezzzzzzzzzzj_ = context.Operators.In<string>(ezzzzzzzzzzh_, ezzzzzzzzzzi_ as IEnumerable<string>);
                    ObservationStatus? ezzzzzzzzzzl_ = ezzzzzzzzzze_?.Value;
                    Code<ObservationStatus> ezzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzl_);
                    bool? ezzzzzzzzzzn_ = context.Operators.Equal(ezzzzzzzzzzm_, "cancelled");
                    bool? ezzzzzzzzzzo_ = context.Operators.Not(ezzzzzzzzzzn_);
                    bool? ezzzzzzzzzzp_ = context.Operators.And(ezzzzzzzzzzj_, ezzzzzzzzzzo_);
                    DataType ezzzzzzzzzzq_ = GlucoseTest?.Value;
                    object ezzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzq_);
                    CqlQuantity ezzzzzzzzzzs_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? ezzzzzzzzzzt_ = context.Operators.Greater(ezzzzzzzzzzr_ as CqlQuantity, ezzzzzzzzzzs_);
                    bool? ezzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzp_, ezzzzzzzzzzt_);
                    object ezzzzzzzzzzv_()
                    {
                        bool fzzzzzzzzzza_()
                        {
                            DataType fzzzzzzzzzzd_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzd_);
                            bool fzzzzzzzzzzf_ = fzzzzzzzzzze_ is CqlDateTime;

                            return fzzzzzzzzzzf_;
                        };
                        bool fzzzzzzzzzzb_()
                        {
                            DataType fzzzzzzzzzzg_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzg_);
                            bool fzzzzzzzzzzi_ = fzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                            return fzzzzzzzzzzi_;
                        };
                        bool fzzzzzzzzzzc_()
                        {
                            DataType fzzzzzzzzzzj_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzj_);
                            bool fzzzzzzzzzzl_ = fzzzzzzzzzzk_ is CqlDateTime;

                            return fzzzzzzzzzzl_;
                        };
                        if (fzzzzzzzzzza_())
                        {
                            DataType fzzzzzzzzzzm_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzm_);

                            return (fzzzzzzzzzzn_ as CqlDateTime) as object;
                        }
                        else if (fzzzzzzzzzzb_())
                        {
                            DataType fzzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzo_);

                            return (fzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (fzzzzzzzzzzc_())
                        {
                            DataType fzzzzzzzzzzq_ = GlucoseTest?.Effective;
                            object fzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzq_);

                            return (fzzzzzzzzzzr_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime ezzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, ezzzzzzzzzzv_());
                    CqlInterval<CqlDateTime> ezzzzzzzzzzx_ = EncounterDay?.dayPeriod;
                    bool? ezzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzw_, ezzzzzzzzzzx_, default);
                    bool? ezzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzu_, ezzzzzzzzzzy_);

                    return ezzzzzzzzzzz_;
                };
                IEnumerable<Observation> dzzzzzzzzzzq_ = context.Operators.Where<Observation>(dzzzzzzzzzzo_, dzzzzzzzzzzp_);
                bool? dzzzzzzzzzzr_ = context.Operators.Exists<Observation>(dzzzzzzzzzzq_);
                IEnumerable<Observation> dzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? dzzzzzzzzzzu_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> fzzzzzzzzzzs_ = GlucoseTest?.StatusElement;
                    ObservationStatus? fzzzzzzzzzzt_ = fzzzzzzzzzzs_?.Value;
                    Code<ObservationStatus> fzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzt_);
                    string fzzzzzzzzzzv_ = context.Operators.Convert<string>(fzzzzzzzzzzu_);
                    string[] fzzzzzzzzzzw_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? fzzzzzzzzzzx_ = context.Operators.In<string>(fzzzzzzzzzzv_, fzzzzzzzzzzw_ as IEnumerable<string>);
                    ObservationStatus? fzzzzzzzzzzz_ = fzzzzzzzzzzs_?.Value;
                    Code<ObservationStatus> gzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzz_);
                    bool? gzzzzzzzzzzb_ = context.Operators.Equal(gzzzzzzzzzza_, "cancelled");
                    bool? gzzzzzzzzzzc_ = context.Operators.Not(gzzzzzzzzzzb_);
                    bool? gzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzx_, gzzzzzzzzzzc_);
                    DataType gzzzzzzzzzze_ = GlucoseTest?.Value;
                    object gzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzze_);
                    CqlQuantity gzzzzzzzzzzg_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? gzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzf_ as CqlQuantity, gzzzzzzzzzzg_);
                    bool? gzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzd_, gzzzzzzzzzzh_);
                    object gzzzzzzzzzzj_()
                    {
                        bool gzzzzzzzzzzo_()
                        {
                            DataType gzzzzzzzzzzr_ = GlucoseTest?.Effective;
                            object gzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzr_);
                            bool gzzzzzzzzzzt_ = gzzzzzzzzzzs_ is CqlDateTime;

                            return gzzzzzzzzzzt_;
                        };
                        bool gzzzzzzzzzzp_()
                        {
                            DataType gzzzzzzzzzzu_ = GlucoseTest?.Effective;
                            object gzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzu_);
                            bool gzzzzzzzzzzw_ = gzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                            return gzzzzzzzzzzw_;
                        };
                        bool gzzzzzzzzzzq_()
                        {
                            DataType gzzzzzzzzzzx_ = GlucoseTest?.Effective;
                            object gzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzx_);
                            bool gzzzzzzzzzzz_ = gzzzzzzzzzzy_ is CqlDateTime;

                            return gzzzzzzzzzzz_;
                        };
                        if (gzzzzzzzzzzo_())
                        {
                            DataType hzzzzzzzzzza_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzza_);

                            return (hzzzzzzzzzzb_ as CqlDateTime) as object;
                        }
                        else if (gzzzzzzzzzzp_())
                        {
                            DataType hzzzzzzzzzzc_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzc_);

                            return (hzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (gzzzzzzzzzzq_())
                        {
                            DataType hzzzzzzzzzze_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzze_);

                            return (hzzzzzzzzzzf_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime gzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzj_());
                    CqlInterval<CqlDateTime> gzzzzzzzzzzl_ = EncounterDay?.dayPeriod;
                    bool? gzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzk_, gzzzzzzzzzzl_, default);
                    bool? gzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzi_, gzzzzzzzzzzm_);

                    return gzzzzzzzzzzn_;
                };
                IEnumerable<Observation> dzzzzzzzzzzv_ = context.Operators.Where<Observation>(dzzzzzzzzzzt_, dzzzzzzzzzzu_);
                bool? dzzzzzzzzzzw_ = context.Operators.Exists<Observation>(dzzzzzzzzzzv_);
                IEnumerable<Observation> dzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? dzzzzzzzzzzz_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> hzzzzzzzzzzg_ = GlucoseTest?.StatusElement;
                    ObservationStatus? hzzzzzzzzzzh_ = hzzzzzzzzzzg_?.Value;
                    Code<ObservationStatus> hzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzh_);
                    string hzzzzzzzzzzj_ = context.Operators.Convert<string>(hzzzzzzzzzzi_);
                    string[] hzzzzzzzzzzk_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? hzzzzzzzzzzl_ = context.Operators.In<string>(hzzzzzzzzzzj_, hzzzzzzzzzzk_ as IEnumerable<string>);
                    ObservationStatus? hzzzzzzzzzzn_ = hzzzzzzzzzzg_?.Value;
                    Code<ObservationStatus> hzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzn_);
                    bool? hzzzzzzzzzzp_ = context.Operators.Equal(hzzzzzzzzzzo_, "cancelled");
                    bool? hzzzzzzzzzzq_ = context.Operators.Not(hzzzzzzzzzzp_);
                    bool? hzzzzzzzzzzr_ = context.Operators.And(hzzzzzzzzzzl_, hzzzzzzzzzzq_);
                    object hzzzzzzzzzzs_()
                    {
                        bool hzzzzzzzzzzx_()
                        {
                            DataType izzzzzzzzzza_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzza_);
                            bool izzzzzzzzzzc_ = izzzzzzzzzzb_ is CqlDateTime;

                            return izzzzzzzzzzc_;
                        };
                        bool hzzzzzzzzzzy_()
                        {
                            DataType izzzzzzzzzzd_ = GlucoseTest?.Effective;
                            object izzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzd_);
                            bool izzzzzzzzzzf_ = izzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                            return izzzzzzzzzzf_;
                        };
                        bool hzzzzzzzzzzz_()
                        {
                            DataType izzzzzzzzzzg_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzg_);
                            bool izzzzzzzzzzi_ = izzzzzzzzzzh_ is CqlDateTime;

                            return izzzzzzzzzzi_;
                        };
                        if (hzzzzzzzzzzx_())
                        {
                            DataType izzzzzzzzzzj_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzj_);

                            return (izzzzzzzzzzk_ as CqlDateTime) as object;
                        }
                        else if (hzzzzzzzzzzy_())
                        {
                            DataType izzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzl_);

                            return (izzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (hzzzzzzzzzzz_())
                        {
                            DataType izzzzzzzzzzn_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzn_);

                            return (izzzzzzzzzzo_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime hzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.Earliest(context, hzzzzzzzzzzs_());
                    CqlInterval<CqlDateTime> hzzzzzzzzzzu_ = EncounterDay?.dayPeriod;
                    bool? hzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzt_, hzzzzzzzzzzu_, default);
                    bool? hzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzr_, hzzzzzzzzzzv_);

                    return hzzzzzzzzzzw_;
                };
                IEnumerable<Observation> ezzzzzzzzzza_ = context.Operators.Where<Observation>(dzzzzzzzzzzy_, dzzzzzzzzzzz_);
                bool? ezzzzzzzzzzb_ = context.Operators.Exists<Observation>(ezzzzzzzzzza_);
                bool? ezzzzzzzzzzc_ = context.Operators.Not(ezzzzzzzzzzb_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ezzzzzzzzzzd_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, dzzzzzzzzzzl_, dzzzzzzzzzzm_, dzzzzzzzzzzr_, dzzzzzzzzzzw_, ezzzzzzzzzzc_);

                return ezzzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> dzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(dzzzzzzzzzzg_, dzzzzzzzzzzh_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> dzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(dzzzzzzzzzzi_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? dzzzzzzzzzzk_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, dzzzzzzzzzze_, dzzzzzzzzzzf_, dzzzzzzzzzzj_);

            return dzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> dzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(dzzzzzzzzzza_, dzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> dzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(dzzzzzzzzzzc_);

        return dzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> izzzzzzzzzzp_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? izzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter izzzzzzzzzzt_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> izzzzzzzzzzu_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> izzzzzzzzzzv_ = EncounterWithResultDays?.relevantDays;
            bool? izzzzzzzzzzw_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? jzzzzzzzzzzc_ = EncounterDay?.dayNumber;
                bool? jzzzzzzzzzzd_ = context.Operators.Greater(jzzzzzzzzzzc_, 1);

                return jzzzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> izzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(izzzzzzzzzzv_, izzzzzzzzzzw_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? izzzzzzzzzzy_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? jzzzzzzzzzze_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> jzzzzzzzzzzf_ = EncounterDay?.dayPeriod;
                bool? jzzzzzzzzzzg_ = EncounterDay?.hasSevereResult;
                bool? jzzzzzzzzzzh_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> jzzzzzzzzzzi_ = EncounterWithResultDays?.relevantDays;
                int? jzzzzzzzzzzk_ = context.Operators.Subtract(jzzzzzzzzzze_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? jzzzzzzzzzzl_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(jzzzzzzzzzzi_, jzzzzzzzzzzk_);
                bool? jzzzzzzzzzzm_ = jzzzzzzzzzzl_?.hasElevatedResult;
                bool? jzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzh_, jzzzzzzzzzzm_);
                int? jzzzzzzzzzzq_ = context.Operators.Subtract(jzzzzzzzzzze_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? jzzzzzzzzzzr_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(jzzzzzzzzzzi_, jzzzzzzzzzzq_);
                bool? jzzzzzzzzzzs_ = jzzzzzzzzzzr_?.hasElevatedResult;
                bool? jzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzn_, jzzzzzzzzzzs_);
                bool? jzzzzzzzzzzu_ = context.Operators.Or(jzzzzzzzzzzg_, jzzzzzzzzzzt_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? jzzzzzzzzzzv_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, jzzzzzzzzzze_, jzzzzzzzzzzf_, jzzzzzzzzzzu_);

                return jzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> izzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(izzzzzzzzzzx_, izzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> jzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(izzzzzzzzzzz_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? jzzzzzzzzzzb_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, izzzzzzzzzzt_, izzzzzzzzzzu_, jzzzzzzzzzza_);

            return jzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> izzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(izzzzzzzzzzp_, izzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> izzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(izzzzzzzzzzr_);

        return izzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzw_ = this.Initial_Population(context);
        CqlValueSet jzzzzzzzzzzx_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> jzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> jzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, Observation>(jzzzzzzzzzzw_, jzzzzzzzzzzy_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? kzzzzzzzzzza_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? kzzzzzzzzzzh_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> kzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(jzzzzzzzzzzz_, kzzzzzzzzzza_);
        bool? kzzzzzzzzzzc_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType kzzzzzzzzzzi_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object kzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzi_);
            CqlQuantity kzzzzzzzzzzk_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? kzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzj_ as CqlQuantity, kzzzzzzzzzzk_);
            Code<ObservationStatus> kzzzzzzzzzzm_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? kzzzzzzzzzzn_ = kzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzn_);
            string kzzzzzzzzzzp_ = context.Operators.Convert<string>(kzzzzzzzzzzo_);
            string[] kzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzr_ = context.Operators.In<string>(kzzzzzzzzzzp_, kzzzzzzzzzzq_ as IEnumerable<string>);
            bool? kzzzzzzzzzzs_ = context.Operators.And(kzzzzzzzzzzl_, kzzzzzzzzzzr_);
            object kzzzzzzzzzzt_()
            {
                bool lzzzzzzzzzzg_()
                {
                    DataType lzzzzzzzzzzj_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzj_);
                    bool lzzzzzzzzzzl_ = lzzzzzzzzzzk_ is CqlDateTime;

                    return lzzzzzzzzzzl_;
                };
                bool lzzzzzzzzzzh_()
                {
                    DataType lzzzzzzzzzzm_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzm_);
                    bool lzzzzzzzzzzo_ = lzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzzo_;
                };
                bool lzzzzzzzzzzi_()
                {
                    DataType lzzzzzzzzzzp_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzp_);
                    bool lzzzzzzzzzzr_ = lzzzzzzzzzzq_ is CqlDateTime;

                    return lzzzzzzzzzzr_;
                };
                if (lzzzzzzzzzzg_())
                {
                    DataType lzzzzzzzzzzs_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzs_);

                    return (lzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzh_())
                {
                    DataType lzzzzzzzzzzu_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzu_);

                    return (lzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzi_())
                {
                    DataType lzzzzzzzzzzw_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object lzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzw_);

                    return (lzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime kzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.Earliest(context, kzzzzzzzzzzt_());
            CqlInterval<CqlDateTime> kzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime kzzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzzv_);
            CqlQuantity kzzzzzzzzzzx_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime kzzzzzzzzzzy_ = context.Operators.Subtract(kzzzzzzzzzzw_, kzzzzzzzzzzx_);
            CqlDateTime lzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzv_);
            CqlQuantity lzzzzzzzzzzb_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime lzzzzzzzzzzc_ = context.Operators.Add(lzzzzzzzzzza_, lzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzd_ = context.Operators.Interval(kzzzzzzzzzzy_, lzzzzzzzzzzc_, true, true);
            bool? lzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzu_, lzzzzzzzzzzd_, default);
            bool? lzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzs_, lzzzzzzzzzze_);

            return lzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> kzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(kzzzzzzzzzzb_, kzzzzzzzzzzc_);
        Observation kzzzzzzzzzze_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) =>
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> kzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(kzzzzzzzzzzd_, kzzzzzzzzzze_);
        IEnumerable<Observation> kzzzzzzzzzzg_ = context.Operators.Distinct<Observation>(kzzzzzzzzzzf_);

        return kzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzy_ = this.Initial_Population(context);
        IEnumerable<Observation> lzzzzzzzzzzz_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet mzzzzzzzzzza_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> mzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> mzzzzzzzzzzc_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(lzzzzzzzzzzy_, lzzzzzzzzzzz_, mzzzzzzzzzzb_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? mzzzzzzzzzzd_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? mzzzzzzzzzzk_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> mzzzzzzzzzze_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(mzzzzzzzzzzc_, mzzzzzzzzzzd_);
        bool? mzzzzzzzzzzf_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object mzzzzzzzzzzl_()
            {
                bool nzzzzzzzzzzp_()
                {
                    DataType nzzzzzzzzzzs_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object nzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzs_);
                    bool nzzzzzzzzzzu_ = nzzzzzzzzzzt_ is CqlDateTime;

                    return nzzzzzzzzzzu_;
                };
                bool nzzzzzzzzzzq_()
                {
                    DataType nzzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object nzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzv_);
                    bool nzzzzzzzzzzx_ = nzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzx_;
                };
                bool nzzzzzzzzzzr_()
                {
                    DataType nzzzzzzzzzzy_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object nzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzy_);
                    bool ozzzzzzzzzza_ = nzzzzzzzzzzz_ is CqlDateTime;

                    return ozzzzzzzzzza_;
                };
                if (nzzzzzzzzzzp_())
                {
                    DataType ozzzzzzzzzzb_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ozzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzb_);

                    return (ozzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzq_())
                {
                    DataType ozzzzzzzzzzd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ozzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzd_);

                    return (ozzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzr_())
                {
                    DataType ozzzzzzzzzzf_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object ozzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzf_);

                    return (ozzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, mzzzzzzzzzzl_());
            CqlInterval<CqlDateTime> mzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime mzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzn_);
            CqlQuantity mzzzzzzzzzzp_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime mzzzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzzzo_, mzzzzzzzzzzp_);
            CqlDateTime mzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzn_);
            CqlQuantity mzzzzzzzzzzt_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime mzzzzzzzzzzu_ = context.Operators.Add(mzzzzzzzzzzs_, mzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzv_ = context.Operators.Interval(mzzzzzzzzzzq_, mzzzzzzzzzzu_, true, true);
            bool? mzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzm_, mzzzzzzzzzzv_, default);
            object mzzzzzzzzzzx_()
            {
                bool ozzzzzzzzzzh_()
                {
                    DataType ozzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzk_);
                    bool ozzzzzzzzzzm_ = ozzzzzzzzzzl_ is CqlDateTime;

                    return ozzzzzzzzzzm_;
                };
                bool ozzzzzzzzzzi_()
                {
                    DataType ozzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzn_);
                    bool ozzzzzzzzzzp_ = ozzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzp_;
                };
                bool ozzzzzzzzzzj_()
                {
                    DataType ozzzzzzzzzzq_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzq_);
                    bool ozzzzzzzzzzs_ = ozzzzzzzzzzr_ is CqlDateTime;

                    return ozzzzzzzzzzs_;
                };
                if (ozzzzzzzzzzh_())
                {
                    DataType ozzzzzzzzzzt_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzt_);

                    return (ozzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzi_())
                {
                    DataType ozzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzv_);

                    return (ozzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzj_())
                {
                    DataType ozzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object ozzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzx_);

                    return (ozzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, mzzzzzzzzzzx_());
            CqlDateTime nzzzzzzzzzza_ = context.Operators.Start(mzzzzzzzzzzn_);
            CqlDateTime nzzzzzzzzzzc_ = context.Operators.Subtract(nzzzzzzzzzza_, mzzzzzzzzzzp_);
            object nzzzzzzzzzzd_()
            {
                bool ozzzzzzzzzzz_()
                {
                    DataType pzzzzzzzzzzc_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzc_);
                    bool pzzzzzzzzzze_ = pzzzzzzzzzzd_ is CqlDateTime;

                    return pzzzzzzzzzze_;
                };
                bool pzzzzzzzzzza_()
                {
                    DataType pzzzzzzzzzzf_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzf_);
                    bool pzzzzzzzzzzh_ = pzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzh_;
                };
                bool pzzzzzzzzzzb_()
                {
                    DataType pzzzzzzzzzzi_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzi_);
                    bool pzzzzzzzzzzk_ = pzzzzzzzzzzj_ is CqlDateTime;

                    return pzzzzzzzzzzk_;
                };
                if (ozzzzzzzzzzz_())
                {
                    DataType pzzzzzzzzzzl_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzl_);

                    return (pzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzza_())
                {
                    DataType pzzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzn_);

                    return (pzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzb_())
                {
                    DataType pzzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzp_);

                    return (pzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.Earliest(context, nzzzzzzzzzzd_());
            CqlInterval<CqlDateTime> nzzzzzzzzzzf_ = context.Operators.Interval(nzzzzzzzzzzc_, nzzzzzzzzzze_, true, false);
            bool? nzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzy_, nzzzzzzzzzzf_, default);
            bool? nzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzw_, nzzzzzzzzzzg_);
            Id nzzzzzzzzzzi_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string nzzzzzzzzzzj_ = nzzzzzzzzzzi_?.Value;
            Id nzzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string nzzzzzzzzzzl_ = nzzzzzzzzzzk_?.Value;
            bool? nzzzzzzzzzzm_ = context.Operators.Equivalent(nzzzzzzzzzzj_, nzzzzzzzzzzl_);
            bool? nzzzzzzzzzzn_ = context.Operators.Not(nzzzzzzzzzzm_);
            bool? nzzzzzzzzzzo_ = context.Operators.And(nzzzzzzzzzzh_, nzzzzzzzzzzn_);

            return nzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> mzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(mzzzzzzzzzze_, mzzzzzzzzzzf_);
        Observation mzzzzzzzzzzh_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) =>
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> mzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(mzzzzzzzzzzg_, mzzzzzzzzzzh_);
        IEnumerable<Observation> mzzzzzzzzzzj_ = context.Operators.Distinct<Observation>(mzzzzzzzzzzi_);

        return mzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzr_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? pzzzzzzzzzzs_(Observation GlucoseResult1000)
        {
            Id pzzzzzzzzzzu_ = GlucoseResult1000?.IdElement;
            string pzzzzzzzzzzv_ = pzzzzzzzzzzu_?.Value;
            IEnumerable<Observation> pzzzzzzzzzzw_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? pzzzzzzzzzzx_(Observation @this)
            {
                string qzzzzzzzzzzd_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? qzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzd_ is null));

                return qzzzzzzzzzze_;
            };
            IEnumerable<Observation> pzzzzzzzzzzy_ = context.Operators.Where<Observation>(pzzzzzzzzzzw_, pzzzzzzzzzzx_);
            string pzzzzzzzzzzz_(Observation @this)
            {
                string qzzzzzzzzzzf_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return qzzzzzzzzzzf_;
            };
            IEnumerable<string> qzzzzzzzzzza_ = context.Operators.Select<Observation, string>(pzzzzzzzzzzy_, pzzzzzzzzzzz_);
            bool? qzzzzzzzzzzb_ = context.Operators.In<string>(pzzzzzzzzzzv_, qzzzzzzzzzza_);
            bool? qzzzzzzzzzzc_ = context.Operators.Not(qzzzzzzzzzzb_);

            return qzzzzzzzzzzc_;
        };
        IEnumerable<Observation> pzzzzzzzzzzt_ = context.Operators.Where<Observation>(pzzzzzzzzzzr_, pzzzzzzzzzzs_);

        return pzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzg_ = this.Initial_Population(context);
        IEnumerable<Encounter> qzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> qzzzzzzzzzzj_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? qzzzzzzzzzzk_(Observation FirstGlucoseResult)
            {
                DataType qzzzzzzzzzzo_ = FirstGlucoseResult?.Value;
                object qzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzo_);
                CqlQuantity qzzzzzzzzzzq_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? qzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzp_ as CqlQuantity, qzzzzzzzzzzq_);
                object qzzzzzzzzzzs_()
                {
                    bool rzzzzzzzzzzf_()
                    {
                        DataType rzzzzzzzzzzi_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzi_);
                        bool rzzzzzzzzzzk_ = rzzzzzzzzzzj_ is CqlDateTime;

                        return rzzzzzzzzzzk_;
                    };
                    bool rzzzzzzzzzzg_()
                    {
                        DataType rzzzzzzzzzzl_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzl_);
                        bool rzzzzzzzzzzn_ = rzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                        return rzzzzzzzzzzn_;
                    };
                    bool rzzzzzzzzzzh_()
                    {
                        DataType rzzzzzzzzzzo_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzo_);
                        bool rzzzzzzzzzzq_ = rzzzzzzzzzzp_ is CqlDateTime;

                        return rzzzzzzzzzzq_;
                    };
                    if (rzzzzzzzzzzf_())
                    {
                        DataType rzzzzzzzzzzr_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzr_);

                        return (rzzzzzzzzzzs_ as CqlDateTime) as object;
                    }
                    else if (rzzzzzzzzzzg_())
                    {
                        DataType rzzzzzzzzzzt_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzt_);

                        return (rzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (rzzzzzzzzzzh_())
                    {
                        DataType rzzzzzzzzzzv_ = FirstGlucoseResult?.Effective;
                        object rzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzv_);

                        return (rzzzzzzzzzzw_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime qzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.Earliest(context, qzzzzzzzzzzs_());
                CqlInterval<CqlDateTime> qzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime qzzzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzzzu_);
                CqlQuantity qzzzzzzzzzzw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime qzzzzzzzzzzx_ = context.Operators.Subtract(qzzzzzzzzzzv_, qzzzzzzzzzzw_);
                CqlDateTime qzzzzzzzzzzz_ = context.Operators.Start(qzzzzzzzzzzu_);
                CqlQuantity rzzzzzzzzzza_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime rzzzzzzzzzzb_ = context.Operators.Add(qzzzzzzzzzzz_, rzzzzzzzzzza_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzc_ = context.Operators.Interval(qzzzzzzzzzzx_, rzzzzzzzzzzb_, true, true);
                bool? rzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzt_, rzzzzzzzzzzc_, default);
                bool? rzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzr_, rzzzzzzzzzzd_);

                return rzzzzzzzzzze_;
            };
            IEnumerable<Observation> qzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzj_, qzzzzzzzzzzk_);
            Encounter qzzzzzzzzzzm_(Observation FirstGlucoseResult) =>
                InpatientHospitalization;
            IEnumerable<Encounter> qzzzzzzzzzzn_ = context.Operators.Select<Observation, Encounter>(qzzzzzzzzzzl_, qzzzzzzzzzzm_);

            return qzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzg_, qzzzzzzzzzzh_);

        return qzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzx_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return rzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> rzzzzzzzzzzy_ = this.Days_with_Hyperglycemic_Events(context);
        bool? rzzzzzzzzzzz_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> szzzzzzzzzze_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? szzzzzzzzzzf_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? szzzzzzzzzzi_ = EligibleEventDay?.hasHyperglycemicEvent;

                return szzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> szzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(szzzzzzzzzze_, szzzzzzzzzzf_);
            bool? szzzzzzzzzzh_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(szzzzzzzzzzg_);

            return szzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> szzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(rzzzzzzzzzzy_, rzzzzzzzzzzz_);
        Encounter szzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter szzzzzzzzzzj_ = HyperglycemicEventDays?.encounter;

            return szzzzzzzzzzj_;
        };
        IEnumerable<Encounter> szzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(szzzzzzzzzza_, szzzzzzzzzzb_);
        IEnumerable<Encounter> szzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzc_);

        return szzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzk_ = this.Encounter_with_Hyperglycemic_Events(context);

        return szzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? szzzzzzzzzzp_()
        {
            bool szzzzzzzzzzq_()
            {
                string szzzzzzzzzzr_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> szzzzzzzzzzs_ = this.Denominator_Exclusions(context);
                bool? szzzzzzzzzzt_(Encounter @this)
                {
                    string szzzzzzzzzzy_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? szzzzzzzzzzz_ = context.Operators.Not((bool?)(szzzzzzzzzzy_ is null));

                    return szzzzzzzzzzz_;
                };
                IEnumerable<Encounter> szzzzzzzzzzu_ = context.Operators.Where<Encounter>(szzzzzzzzzzs_, szzzzzzzzzzt_);
                string szzzzzzzzzzv_(Encounter @this)
                {
                    string tzzzzzzzzzza_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return tzzzzzzzzzza_;
                };
                IEnumerable<string> szzzzzzzzzzw_ = context.Operators.Select<Encounter, string>(szzzzzzzzzzu_, szzzzzzzzzzv_);
                bool? szzzzzzzzzzx_ = context.Operators.In<string>(szzzzzzzzzzr_, szzzzzzzzzzw_);

                return szzzzzzzzzzx_ ?? false;
            };
            if (szzzzzzzzzzq_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzb_ = this.Days_with_Hyperglycemic_Events(context);
                bool? tzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter tzzzzzzzzzzi_ = EncounterWithEventDays?.encounter;
                    bool? tzzzzzzzzzzj_ = context.Operators.Equal(tzzzzzzzzzzi_, QualifyingEncounter);

                    return tzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(tzzzzzzzzzzb_, tzzzzzzzzzzc_);
                int? tzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> tzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(tzzzzzzzzzzd_, tzzzzzzzzzze_);
                IEnumerable<int?> tzzzzzzzzzzg_ = context.Operators.Distinct<int?>(tzzzzzzzzzzf_);
                int? tzzzzzzzzzzh_ = context.Operators.SingletonFrom<int?>(tzzzzzzzzzzg_);

                return tzzzzzzzzzzh_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzk_ = this.Days_with_Hyperglycemic_Events(context);
                bool? tzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter tzzzzzzzzzzr_ = EncounterWithEventDays?.encounter;
                    bool? tzzzzzzzzzzs_ = context.Operators.Equal(tzzzzzzzzzzr_, QualifyingEncounter);

                    return tzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(tzzzzzzzzzzk_, tzzzzzzzzzzl_);
                int? tzzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> tzzzzzzzzzzt_ = EncounterWithEventDays?.eligibleEventDays;
                    int? tzzzzzzzzzzu_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(tzzzzzzzzzzt_);

                    return tzzzzzzzzzzu_;
                };
                IEnumerable<int?> tzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(tzzzzzzzzzzm_, tzzzzzzzzzzn_);
                IEnumerable<int?> tzzzzzzzzzzp_ = context.Operators.Distinct<int?>(tzzzzzzzzzzo_);
                int? tzzzzzzzzzzq_ = context.Operators.SingletonFrom<int?>(tzzzzzzzzzzp_);

                return tzzzzzzzzzzq_;
            }
        };

        return szzzzzzzzzzp_();
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? tzzzzzzzzzzv_()
        {
            bool tzzzzzzzzzzw_()
            {
                string tzzzzzzzzzzx_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> tzzzzzzzzzzy_ = this.Denominator_Exclusions(context);
                bool? tzzzzzzzzzzz_(Encounter @this)
                {
                    string uzzzzzzzzzze_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? uzzzzzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzzzzzze_ is null));

                    return uzzzzzzzzzzf_;
                };
                IEnumerable<Encounter> uzzzzzzzzzza_ = context.Operators.Where<Encounter>(tzzzzzzzzzzy_, tzzzzzzzzzzz_);
                string uzzzzzzzzzzb_(Encounter @this)
                {
                    string uzzzzzzzzzzg_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return uzzzzzzzzzzg_;
                };
                IEnumerable<string> uzzzzzzzzzzc_ = context.Operators.Select<Encounter, string>(uzzzzzzzzzza_, uzzzzzzzzzzb_);
                bool? uzzzzzzzzzzd_ = context.Operators.In<string>(tzzzzzzzzzzx_, uzzzzzzzzzzc_);

                return uzzzzzzzzzzd_ ?? false;
            };
            if (tzzzzzzzzzzw_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzh_ = this.Days_with_Hyperglycemic_Events(context);
                bool? uzzzzzzzzzzi_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter uzzzzzzzzzzo_ = EncounterWithEventDays?.encounter;
                    bool? uzzzzzzzzzzp_ = context.Operators.Equal(uzzzzzzzzzzo_, QualifyingEncounter);

                    return uzzzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(uzzzzzzzzzzh_, uzzzzzzzzzzi_);
                int? uzzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> uzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(uzzzzzzzzzzj_, uzzzzzzzzzzk_);
                IEnumerable<int?> uzzzzzzzzzzm_ = context.Operators.Distinct<int?>(uzzzzzzzzzzl_);
                int? uzzzzzzzzzzn_ = context.Operators.SingletonFrom<int?>(uzzzzzzzzzzm_);

                return uzzzzzzzzzzn_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzq_ = this.Days_with_Hyperglycemic_Events(context);
                bool? uzzzzzzzzzzr_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter uzzzzzzzzzzx_ = EncounterWithEventDays?.encounter;
                    bool? uzzzzzzzzzzy_ = context.Operators.Equal(uzzzzzzzzzzx_, QualifyingEncounter);

                    return uzzzzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(uzzzzzzzzzzq_, uzzzzzzzzzzr_);
                int? uzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> uzzzzzzzzzzz_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? vzzzzzzzzzza_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? vzzzzzzzzzzd_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return vzzzzzzzzzzd_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(uzzzzzzzzzzz_, vzzzzzzzzzza_);
                    int? vzzzzzzzzzzc_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzb_);

                    return vzzzzzzzzzzc_;
                };
                IEnumerable<int?> uzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(uzzzzzzzzzzs_, uzzzzzzzzzzt_);
                IEnumerable<int?> uzzzzzzzzzzv_ = context.Operators.Distinct<int?>(uzzzzzzzzzzu_);
                int? uzzzzzzzzzzw_ = context.Operators.SingletonFrom<int?>(uzzzzzzzzzzv_);

                return uzzzzzzzzzzw_;
            }
        };

        return tzzzzzzzzzzv_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseResult1000", "EarlierGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
        [typeof(Encounter), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayNumber", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
