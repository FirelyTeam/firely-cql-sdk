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
        CqlDateTime dzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzf_ = context.Operators.Interval(dzzzzzzzzzd_, dzzzzzzzzze_, true, true);
        object dzzzzzzzzzg_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", dzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzh_);

        return dzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzj_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            Patient dzzzzzzzzzn_ = this.Patient(context);
            Date dzzzzzzzzzo_ = dzzzzzzzzzn_?.BirthDateElement;
            string dzzzzzzzzzp_ = dzzzzzzzzzo_?.Value;
            CqlDate dzzzzzzzzzq_ = context.Operators.ConvertStringToDate(dzzzzzzzzzp_);
            Period dzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzs_);
            CqlDate dzzzzzzzzzu_ = context.Operators.DateFrom(dzzzzzzzzzt_);
            int? dzzzzzzzzzv_ = context.Operators.CalculateAgeAt(dzzzzzzzzzq_, dzzzzzzzzzu_, "year");
            bool? dzzzzzzzzzw_ = context.Operators.GreaterOrEqual(dzzzzzzzzzv_, 18);
            CqlInterval<CqlDateTime> dzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzy_);
            CqlInterval<CqlDateTime> ezzzzzzzzza_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzz_, ezzzzzzzzza_, "day");
            bool? ezzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzw_, ezzzzzzzzzb_);
            Code<Encounter.EncounterStatus> ezzzzzzzzzd_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? ezzzzzzzzze_ = ezzzzzzzzzd_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzze_);
            bool? ezzzzzzzzzg_ = context.Operators.Equal(ezzzzzzzzzf_, "finished");
            bool? ezzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzc_, ezzzzzzzzzg_);

            return ezzzzzzzzzh_;
        };
        IEnumerable<Encounter> dzzzzzzzzzm_ = context.Operators.Where<Encounter>(dzzzzzzzzzk_, dzzzzzzzzzl_);

        return dzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzi_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? ezzzzzzzzzj_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? ezzzzzzzzzn_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, ezzzzzzzzzm_);

            return ezzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ezzzzzzzzzi_, ezzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ezzzzzzzzzk_);

        return ezzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzo_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet ezzzzzzzzzu_ = this.Diabetes(context);
            IEnumerable<Condition> ezzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ezzzzzzzzzw_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> fzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime fzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzza_);
                CqlInterval<CqlDateTime> fzzzzzzzzzc_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime fzzzzzzzzzd_ = context.Operators.End(fzzzzzzzzzc_);
                bool? fzzzzzzzzze_ = context.Operators.Before(fzzzzzzzzzb_, fzzzzzzzzzd_, default);

                return fzzzzzzzzze_;
            };
            IEnumerable<Condition> ezzzzzzzzzx_ = context.Operators.Where<Condition>(ezzzzzzzzzv_, ezzzzzzzzzw_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? ezzzzzzzzzy_(Condition Diabetes) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzz_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ezzzzzzzzzx_, ezzzzzzzzzy_);

            return ezzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzq_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ezzzzzzzzzo_, ezzzzzzzzzp_);
        Encounter ezzzzzzzzzr_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter fzzzzzzzzzf_ = Hospitalization?.encounter;

            return fzzzzzzzzzf_;
        };
        IEnumerable<Encounter> ezzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(ezzzzzzzzzq_, ezzzzzzzzzr_);
        IEnumerable<Encounter> ezzzzzzzzzt_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzs_);

        return ezzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> fzzzzzzzzzg_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet fzzzzzzzzzh_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> fzzzzzzzzzi_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> fzzzzzzzzzk_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> fzzzzzzzzzl_ = context.Operators.Union<MedicationAdministration>(fzzzzzzzzzi_, fzzzzzzzzzk_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> fzzzzzzzzzm_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(fzzzzzzzzzg_, fzzzzzzzzzl_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? fzzzzzzzzzn_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? fzzzzzzzzzu_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return fzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> fzzzzzzzzzo_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(fzzzzzzzzzm_, fzzzzzzzzzn_);
        bool? fzzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> fzzzzzzzzzv_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? fzzzzzzzzzw_ = fzzzzzzzzzv_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> fzzzzzzzzzx_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(fzzzzzzzzzw_);
            bool? fzzzzzzzzzy_ = context.Operators.Equal(fzzzzzzzzzx_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? gzzzzzzzzza_ = fzzzzzzzzzv_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> gzzzzzzzzzb_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(gzzzzzzzzza_);
            bool? gzzzzzzzzzc_ = context.Operators.Equal(gzzzzzzzzzb_, "not-done");
            bool? gzzzzzzzzzd_ = context.Operators.Not(gzzzzzzzzzc_);
            bool? gzzzzzzzzze_ = context.Operators.And(fzzzzzzzzzy_, gzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzf_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType gzzzzzzzzzg_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object gzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzh_);
            bool? gzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzf_, gzzzzzzzzzi_, default);
            bool? gzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzze_, gzzzzzzzzzj_);

            return gzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> fzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(fzzzzzzzzzo_, fzzzzzzzzzp_);
        Encounter fzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter gzzzzzzzzzl_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return gzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(fzzzzzzzzzq_, fzzzzzzzzzr_);
        IEnumerable<Encounter> fzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzs_);

        return fzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> gzzzzzzzzzm_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> gzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet gzzzzzzzzzs_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> gzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? gzzzzzzzzzu_(Observation GlucoseTest)
            {
                object gzzzzzzzzzy_()
                {
                    bool hzzzzzzzzzu_()
                    {
                        DataType hzzzzzzzzzx_ = GlucoseTest?.Effective;
                        object hzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzx_);
                        bool hzzzzzzzzzz_ = hzzzzzzzzzy_ is CqlDateTime;

                        return hzzzzzzzzzz_;
                    };
                    bool hzzzzzzzzzv_()
                    {
                        DataType izzzzzzzzza_ = GlucoseTest?.Effective;
                        object izzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzza_);
                        bool izzzzzzzzzc_ = izzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                        return izzzzzzzzzc_;
                    };
                    bool hzzzzzzzzzw_()
                    {
                        DataType izzzzzzzzzd_ = GlucoseTest?.Effective;
                        object izzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzd_);
                        bool izzzzzzzzzf_ = izzzzzzzzze_ is CqlDateTime;

                        return izzzzzzzzzf_;
                    };
                    if (hzzzzzzzzzu_())
                    {
                        DataType izzzzzzzzzg_ = GlucoseTest?.Effective;
                        object izzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzg_);

                        return (izzzzzzzzzh_ as CqlDateTime) as object;
                    }
                    else if (hzzzzzzzzzv_())
                    {
                        DataType izzzzzzzzzi_ = GlucoseTest?.Effective;
                        object izzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzi_);

                        return (izzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (hzzzzzzzzzw_())
                    {
                        DataType izzzzzzzzzk_ = GlucoseTest?.Effective;
                        object izzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzk_);

                        return (izzzzzzzzzl_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime gzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzy_());
                CqlInterval<CqlDateTime> hzzzzzzzzza_ = Hospitalization?.hospitalizationPeriod;
                bool? hzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzz_, hzzzzzzzzza_, default);
                Code<ObservationStatus> hzzzzzzzzzc_ = GlucoseTest?.StatusElement;
                ObservationStatus? hzzzzzzzzzd_ = hzzzzzzzzzc_?.Value;
                Code<ObservationStatus> hzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzd_);
                string hzzzzzzzzzf_ = context.Operators.Convert<string>(hzzzzzzzzze_);
                string[] hzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzh_ = context.Operators.In<string>(hzzzzzzzzzf_, hzzzzzzzzzg_ as IEnumerable<string>);
                bool? hzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzb_, hzzzzzzzzzh_);
                ObservationStatus? hzzzzzzzzzk_ = hzzzzzzzzzc_?.Value;
                Code<ObservationStatus> hzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzk_);
                bool? hzzzzzzzzzm_ = context.Operators.Equal(hzzzzzzzzzl_, "cancelled");
                bool? hzzzzzzzzzn_ = context.Operators.Not(hzzzzzzzzzm_);
                bool? hzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzi_, hzzzzzzzzzn_);
                DataType hzzzzzzzzzp_ = GlucoseTest?.Value;
                object hzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzp_);
                CqlQuantity hzzzzzzzzzr_ = context.Operators.Quantity(200m, "mg/dL");
                bool? hzzzzzzzzzs_ = context.Operators.GreaterOrEqual(hzzzzzzzzzq_ as CqlQuantity, hzzzzzzzzzr_);
                bool? hzzzzzzzzzt_ = context.Operators.And(hzzzzzzzzzo_, hzzzzzzzzzs_);

                return hzzzzzzzzzt_;
            };
            IEnumerable<Observation> gzzzzzzzzzv_ = context.Operators.Where<Observation>(gzzzzzzzzzt_, gzzzzzzzzzu_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? gzzzzzzzzzw_(Observation GlucoseTest) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> gzzzzzzzzzx_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(gzzzzzzzzzv_, gzzzzzzzzzw_);

            return gzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> gzzzzzzzzzo_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(gzzzzzzzzzm_, gzzzzzzzzzn_);
        Encounter gzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter izzzzzzzzzm_ = Hospitalization?.encounter;

            return izzzzzzzzzm_;
        };
        IEnumerable<Encounter> gzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(gzzzzzzzzzo_, gzzzzzzzzzp_);
        IEnumerable<Encounter> gzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(gzzzzzzzzzq_);

        return gzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzn_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> izzzzzzzzzo_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> izzzzzzzzzp_ = context.Operators.Union<Encounter>(izzzzzzzzzn_, izzzzzzzzzo_);
        IEnumerable<Encounter> izzzzzzzzzq_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> izzzzzzzzzr_ = context.Operators.Union<Encounter>(izzzzzzzzzp_, izzzzzzzzzq_);

        return izzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzs_ = this.Initial_Population(context);

        return izzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzt_ = this.Denominator(context);

        return izzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Hospital Days Max 10")]
    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime izzzzzzzzzu_ = context.Operators.Start(Period);
        CqlDateTime izzzzzzzzzv_ = context.Operators.End(Period);
        CqlQuantity izzzzzzzzzx_ = context.Operators.Quantity(10m, "days");
        CqlDateTime izzzzzzzzzy_ = context.Operators.Add(izzzzzzzzzu_, izzzzzzzzzx_);
        CqlDateTime[] izzzzzzzzzz_ = [
            izzzzzzzzzv_,
            izzzzzzzzzy_,
        ];
        CqlDateTime jzzzzzzzzza_ = context.Operators.Min<CqlDateTime>(izzzzzzzzzz_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> jzzzzzzzzzb_ = context.Operators.Interval(izzzzzzzzzu_, jzzzzzzzzza_, true, true);

        return jzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime jzzzzzzzzzc_ = context.Operators.Start(Period);
        CqlDateTime jzzzzzzzzzd_ = context.Operators.End(Period);
        int? jzzzzzzzzze_ = context.Operators.DurationBetween(jzzzzzzzzzc_, jzzzzzzzzzd_, "day");
        CqlInterval<int?> jzzzzzzzzzf_ = context.Operators.Interval(1, jzzzzzzzzze_, true, true);
        CqlInterval<int?>[] jzzzzzzzzzg_ = [
            jzzzzzzzzzf_,
        ];
        IEnumerable<CqlInterval<int?>> jzzzzzzzzzh_ = context.Operators.Expand(jzzzzzzzzzg_ as IEnumerable<CqlInterval<int?>>, default);
        int? jzzzzzzzzzi_(CqlInterval<int?> DayExpand)
        {
            int? jzzzzzzzzzl_ = context.Operators.End(DayExpand);

            return jzzzzzzzzzl_;
        };
        IEnumerable<int?> jzzzzzzzzzj_ = context.Operators.Select<CqlInterval<int?>, int?>(jzzzzzzzzzh_, jzzzzzzzzzi_);
        IEnumerable<int?> jzzzzzzzzzk_ = context.Operators.Distinct<int?>(jzzzzzzzzzj_);

        return jzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> jzzzzzzzzzm_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? jzzzzzzzzzn_(int? DayNumber)
        {
            CqlDateTime jzzzzzzzzzq_ = context.Operators.Start(Period);
            CqlQuantity jzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
            int? jzzzzzzzzzs_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity jzzzzzzzzzt_ = context.Operators.ConvertIntegerToQuantity(jzzzzzzzzzs_);
            CqlQuantity jzzzzzzzzzu_ = context.Operators.Multiply(jzzzzzzzzzr_, jzzzzzzzzzt_);
            CqlDateTime jzzzzzzzzzv_ = context.Operators.Add(jzzzzzzzzzq_, jzzzzzzzzzu_);
            CqlDateTime jzzzzzzzzzw_()
            {
                bool jzzzzzzzzzz_()
                {
                    CqlDateTime kzzzzzzzzza_ = context.Operators.Start(Period);
                    CqlQuantity kzzzzzzzzzb_ = context.Operators.Quantity(24m, "hours");
                    int? kzzzzzzzzzc_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity kzzzzzzzzzd_ = context.Operators.ConvertIntegerToQuantity(kzzzzzzzzzc_);
                    CqlQuantity kzzzzzzzzze_ = context.Operators.Multiply(kzzzzzzzzzb_, kzzzzzzzzzd_);
                    CqlDateTime kzzzzzzzzzf_ = context.Operators.Add(kzzzzzzzzza_, kzzzzzzzzze_);
                    CqlDateTime kzzzzzzzzzg_ = context.Operators.End(Period);
                    int? kzzzzzzzzzh_ = context.Operators.DurationBetween(kzzzzzzzzzf_, kzzzzzzzzzg_, "hour");
                    bool? kzzzzzzzzzi_ = context.Operators.Less(kzzzzzzzzzh_, 24);

                    return kzzzzzzzzzi_ ?? false;
                };
                if (jzzzzzzzzzz_())
                {
                    CqlDateTime kzzzzzzzzzj_ = context.Operators.Start(Period);
                    CqlQuantity kzzzzzzzzzk_ = context.Operators.Quantity(24m, "hours");
                    int? kzzzzzzzzzl_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity kzzzzzzzzzm_ = context.Operators.ConvertIntegerToQuantity(kzzzzzzzzzl_);
                    CqlQuantity kzzzzzzzzzn_ = context.Operators.Multiply(kzzzzzzzzzk_, kzzzzzzzzzm_);
                    CqlDateTime kzzzzzzzzzo_ = context.Operators.Add(kzzzzzzzzzj_, kzzzzzzzzzn_);

                    return kzzzzzzzzzo_;
                }
                else
                {
                    CqlDateTime kzzzzzzzzzp_ = context.Operators.Start(Period);
                    CqlQuantity kzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity kzzzzzzzzzr_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity kzzzzzzzzzs_ = context.Operators.Multiply(kzzzzzzzzzq_, kzzzzzzzzzr_);
                    CqlDateTime kzzzzzzzzzt_ = context.Operators.Add(kzzzzzzzzzp_, kzzzzzzzzzs_);

                    return kzzzzzzzzzt_;
                }
            };
            CqlInterval<CqlDateTime> jzzzzzzzzzx_ = context.Operators.Interval(jzzzzzzzzzv_, jzzzzzzzzzw_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? jzzzzzzzzzy_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, jzzzzzzzzzx_);

            return jzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> jzzzzzzzzzo_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(jzzzzzzzzzm_, jzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> jzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(jzzzzzzzzzo_);

        return jzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzu_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? kzzzzzzzzzv_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> lzzzzzzzzza_ = this.Hospital_Days_Max_10(context, kzzzzzzzzzy_);
            CqlInterval<CqlDateTime> lzzzzzzzzzc_ = this.Hospital_Days_Max_10(context, kzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> lzzzzzzzzzd_ = this.Days_In_Period(context, lzzzzzzzzzc_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? lzzzzzzzzze_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, kzzzzzzzzzy_, lzzzzzzzzza_, lzzzzzzzzzd_);

            return lzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> kzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(kzzzzzzzzzu_, kzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> kzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(kzzzzzzzzzw_);

        return kzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> lzzzzzzzzzf_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? lzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter lzzzzzzzzzj_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> lzzzzzzzzzk_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> lzzzzzzzzzl_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? lzzzzzzzzzm_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? lzzzzzzzzzq_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> lzzzzzzzzzr_ = EncounterDay?.dayPeriod;
                CqlValueSet lzzzzzzzzzs_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> lzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? lzzzzzzzzzu_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> mzzzzzzzzzj_ = GlucoseTest?.StatusElement;
                    ObservationStatus? mzzzzzzzzzk_ = mzzzzzzzzzj_?.Value;
                    Code<ObservationStatus> mzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzk_);
                    string mzzzzzzzzzm_ = context.Operators.Convert<string>(mzzzzzzzzzl_);
                    string[] mzzzzzzzzzn_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? mzzzzzzzzzo_ = context.Operators.In<string>(mzzzzzzzzzm_, mzzzzzzzzzn_ as IEnumerable<string>);
                    ObservationStatus? mzzzzzzzzzq_ = mzzzzzzzzzj_?.Value;
                    Code<ObservationStatus> mzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzq_);
                    bool? mzzzzzzzzzs_ = context.Operators.Equal(mzzzzzzzzzr_, "cancelled");
                    bool? mzzzzzzzzzt_ = context.Operators.Not(mzzzzzzzzzs_);
                    bool? mzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzo_, mzzzzzzzzzt_);
                    DataType mzzzzzzzzzv_ = GlucoseTest?.Value;
                    object mzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzv_);
                    CqlQuantity mzzzzzzzzzx_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? mzzzzzzzzzy_ = context.Operators.Greater(mzzzzzzzzzw_ as CqlQuantity, mzzzzzzzzzx_);
                    bool? mzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzu_, mzzzzzzzzzy_);
                    object nzzzzzzzzza_()
                    {
                        bool nzzzzzzzzzf_()
                        {
                            DataType nzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzi_);
                            bool nzzzzzzzzzk_ = nzzzzzzzzzj_ is CqlDateTime;

                            return nzzzzzzzzzk_;
                        };
                        bool nzzzzzzzzzg_()
                        {
                            DataType nzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzl_);
                            bool nzzzzzzzzzn_ = nzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                            return nzzzzzzzzzn_;
                        };
                        bool nzzzzzzzzzh_()
                        {
                            DataType nzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzo_);
                            bool nzzzzzzzzzq_ = nzzzzzzzzzp_ is CqlDateTime;

                            return nzzzzzzzzzq_;
                        };
                        if (nzzzzzzzzzf_())
                        {
                            DataType nzzzzzzzzzr_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzr_);

                            return (nzzzzzzzzzs_ as CqlDateTime) as object;
                        }
                        else if (nzzzzzzzzzg_())
                        {
                            DataType nzzzzzzzzzt_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzt_);

                            return (nzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (nzzzzzzzzzh_())
                        {
                            DataType nzzzzzzzzzv_ = GlucoseTest?.Effective;
                            object nzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzv_);

                            return (nzzzzzzzzzw_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime nzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.Earliest(context, nzzzzzzzzza_());
                    CqlInterval<CqlDateTime> nzzzzzzzzzc_ = EncounterDay?.dayPeriod;
                    bool? nzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzb_, nzzzzzzzzzc_, default);
                    bool? nzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzz_, nzzzzzzzzzd_);

                    return nzzzzzzzzze_;
                };
                IEnumerable<Observation> lzzzzzzzzzv_ = context.Operators.Where<Observation>(lzzzzzzzzzt_, lzzzzzzzzzu_);
                bool? lzzzzzzzzzw_ = context.Operators.Exists<Observation>(lzzzzzzzzzv_);
                IEnumerable<Observation> lzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? lzzzzzzzzzz_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> nzzzzzzzzzx_ = GlucoseTest?.StatusElement;
                    ObservationStatus? nzzzzzzzzzy_ = nzzzzzzzzzx_?.Value;
                    Code<ObservationStatus> nzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzy_);
                    string ozzzzzzzzza_ = context.Operators.Convert<string>(nzzzzzzzzzz_);
                    string[] ozzzzzzzzzb_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ozzzzzzzzzc_ = context.Operators.In<string>(ozzzzzzzzza_, ozzzzzzzzzb_ as IEnumerable<string>);
                    ObservationStatus? ozzzzzzzzze_ = nzzzzzzzzzx_?.Value;
                    Code<ObservationStatus> ozzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzze_);
                    bool? ozzzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzzf_, "cancelled");
                    bool? ozzzzzzzzzh_ = context.Operators.Not(ozzzzzzzzzg_);
                    bool? ozzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzc_, ozzzzzzzzzh_);
                    DataType ozzzzzzzzzj_ = GlucoseTest?.Value;
                    object ozzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzj_);
                    CqlQuantity ozzzzzzzzzl_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? ozzzzzzzzzm_ = context.Operators.GreaterOrEqual(ozzzzzzzzzk_ as CqlQuantity, ozzzzzzzzzl_);
                    bool? ozzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzi_, ozzzzzzzzzm_);
                    object ozzzzzzzzzo_()
                    {
                        bool ozzzzzzzzzt_()
                        {
                            DataType ozzzzzzzzzw_ = GlucoseTest?.Effective;
                            object ozzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzw_);
                            bool ozzzzzzzzzy_ = ozzzzzzzzzx_ is CqlDateTime;

                            return ozzzzzzzzzy_;
                        };
                        bool ozzzzzzzzzu_()
                        {
                            DataType ozzzzzzzzzz_ = GlucoseTest?.Effective;
                            object pzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzz_);
                            bool pzzzzzzzzzb_ = pzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                            return pzzzzzzzzzb_;
                        };
                        bool ozzzzzzzzzv_()
                        {
                            DataType pzzzzzzzzzc_ = GlucoseTest?.Effective;
                            object pzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzc_);
                            bool pzzzzzzzzze_ = pzzzzzzzzzd_ is CqlDateTime;

                            return pzzzzzzzzze_;
                        };
                        if (ozzzzzzzzzt_())
                        {
                            DataType pzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object pzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzf_);

                            return (pzzzzzzzzzg_ as CqlDateTime) as object;
                        }
                        else if (ozzzzzzzzzu_())
                        {
                            DataType pzzzzzzzzzh_ = GlucoseTest?.Effective;
                            object pzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzh_);

                            return (pzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ozzzzzzzzzv_())
                        {
                            DataType pzzzzzzzzzj_ = GlucoseTest?.Effective;
                            object pzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzj_);

                            return (pzzzzzzzzzk_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime ozzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzo_());
                    CqlInterval<CqlDateTime> ozzzzzzzzzq_ = EncounterDay?.dayPeriod;
                    bool? ozzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzp_, ozzzzzzzzzq_, default);
                    bool? ozzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzn_, ozzzzzzzzzr_);

                    return ozzzzzzzzzs_;
                };
                IEnumerable<Observation> mzzzzzzzzza_ = context.Operators.Where<Observation>(lzzzzzzzzzy_, lzzzzzzzzzz_);
                bool? mzzzzzzzzzb_ = context.Operators.Exists<Observation>(mzzzzzzzzza_);
                IEnumerable<Observation> mzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? mzzzzzzzzze_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> pzzzzzzzzzl_ = GlucoseTest?.StatusElement;
                    ObservationStatus? pzzzzzzzzzm_ = pzzzzzzzzzl_?.Value;
                    Code<ObservationStatus> pzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzm_);
                    string pzzzzzzzzzo_ = context.Operators.Convert<string>(pzzzzzzzzzn_);
                    string[] pzzzzzzzzzp_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? pzzzzzzzzzq_ = context.Operators.In<string>(pzzzzzzzzzo_, pzzzzzzzzzp_ as IEnumerable<string>);
                    ObservationStatus? pzzzzzzzzzs_ = pzzzzzzzzzl_?.Value;
                    Code<ObservationStatus> pzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzs_);
                    bool? pzzzzzzzzzu_ = context.Operators.Equal(pzzzzzzzzzt_, "cancelled");
                    bool? pzzzzzzzzzv_ = context.Operators.Not(pzzzzzzzzzu_);
                    bool? pzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzq_, pzzzzzzzzzv_);
                    object pzzzzzzzzzx_()
                    {
                        bool qzzzzzzzzzc_()
                        {
                            DataType qzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzf_);
                            bool qzzzzzzzzzh_ = qzzzzzzzzzg_ is CqlDateTime;

                            return qzzzzzzzzzh_;
                        };
                        bool qzzzzzzzzzd_()
                        {
                            DataType qzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzi_);
                            bool qzzzzzzzzzk_ = qzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                            return qzzzzzzzzzk_;
                        };
                        bool qzzzzzzzzze_()
                        {
                            DataType qzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzl_);
                            bool qzzzzzzzzzn_ = qzzzzzzzzzm_ is CqlDateTime;

                            return qzzzzzzzzzn_;
                        };
                        if (qzzzzzzzzzc_())
                        {
                            DataType qzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzo_);

                            return (qzzzzzzzzzp_ as CqlDateTime) as object;
                        }
                        else if (qzzzzzzzzzd_())
                        {
                            DataType qzzzzzzzzzq_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzq_);

                            return (qzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (qzzzzzzzzze_())
                        {
                            DataType qzzzzzzzzzs_ = GlucoseTest?.Effective;
                            object qzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzs_);

                            return (qzzzzzzzzzt_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime pzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, pzzzzzzzzzx_());
                    CqlInterval<CqlDateTime> pzzzzzzzzzz_ = EncounterDay?.dayPeriod;
                    bool? qzzzzzzzzza_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzy_, pzzzzzzzzzz_, default);
                    bool? qzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzw_, qzzzzzzzzza_);

                    return qzzzzzzzzzb_;
                };
                IEnumerable<Observation> mzzzzzzzzzf_ = context.Operators.Where<Observation>(mzzzzzzzzzd_, mzzzzzzzzze_);
                bool? mzzzzzzzzzg_ = context.Operators.Exists<Observation>(mzzzzzzzzzf_);
                bool? mzzzzzzzzzh_ = context.Operators.Not(mzzzzzzzzzg_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? mzzzzzzzzzi_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, lzzzzzzzzzq_, lzzzzzzzzzr_, lzzzzzzzzzw_, mzzzzzzzzzb_, mzzzzzzzzzh_);

                return mzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> lzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(lzzzzzzzzzl_, lzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> lzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(lzzzzzzzzzn_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? lzzzzzzzzzp_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, lzzzzzzzzzj_, lzzzzzzzzzk_, lzzzzzzzzzo_);

            return lzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> lzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(lzzzzzzzzzf_, lzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> lzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(lzzzzzzzzzh_);

        return lzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> qzzzzzzzzzu_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? qzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter qzzzzzzzzzy_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> qzzzzzzzzzz_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> rzzzzzzzzza_ = EncounterWithResultDays?.relevantDays;
            bool? rzzzzzzzzzb_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? rzzzzzzzzzh_ = EncounterDay?.dayNumber;
                bool? rzzzzzzzzzi_ = context.Operators.Greater(rzzzzzzzzzh_, 1);

                return rzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> rzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(rzzzzzzzzza_, rzzzzzzzzzb_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? rzzzzzzzzzd_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? rzzzzzzzzzj_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> rzzzzzzzzzk_ = EncounterDay?.dayPeriod;
                bool? rzzzzzzzzzl_ = EncounterDay?.hasSevereResult;
                bool? rzzzzzzzzzm_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> rzzzzzzzzzn_ = EncounterWithResultDays?.relevantDays;
                int? rzzzzzzzzzp_ = context.Operators.Subtract(rzzzzzzzzzj_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? rzzzzzzzzzq_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(rzzzzzzzzzn_, rzzzzzzzzzp_);
                bool? rzzzzzzzzzr_ = rzzzzzzzzzq_?.hasElevatedResult;
                bool? rzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzm_, rzzzzzzzzzr_);
                int? rzzzzzzzzzv_ = context.Operators.Subtract(rzzzzzzzzzj_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? rzzzzzzzzzw_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(rzzzzzzzzzn_, rzzzzzzzzzv_);
                bool? rzzzzzzzzzx_ = rzzzzzzzzzw_?.hasElevatedResult;
                bool? rzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzs_, rzzzzzzzzzx_);
                bool? rzzzzzzzzzz_ = context.Operators.Or(rzzzzzzzzzl_, rzzzzzzzzzy_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? szzzzzzzzza_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, rzzzzzzzzzj_, rzzzzzzzzzk_, rzzzzzzzzzz_);

                return szzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> rzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(rzzzzzzzzzc_, rzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> rzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(rzzzzzzzzze_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? rzzzzzzzzzg_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, qzzzzzzzzzy_, qzzzzzzzzzz_, rzzzzzzzzzf_);

            return rzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> qzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(qzzzzzzzzzu_, qzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> qzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(qzzzzzzzzzw_);

        return qzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzb_ = this.Initial_Population(context);
        CqlValueSet szzzzzzzzzc_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> szzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> szzzzzzzzze_ = context.Operators.CrossJoin<Encounter, Observation>(szzzzzzzzzb_, szzzzzzzzzd_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? szzzzzzzzzf_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? szzzzzzzzzm_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> szzzzzzzzzg_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(szzzzzzzzze_, szzzzzzzzzf_);
        bool? szzzzzzzzzh_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType szzzzzzzzzn_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object szzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzn_);
            CqlQuantity szzzzzzzzzp_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? szzzzzzzzzq_ = context.Operators.GreaterOrEqual(szzzzzzzzzo_ as CqlQuantity, szzzzzzzzzp_);
            Code<ObservationStatus> szzzzzzzzzr_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? szzzzzzzzzs_ = szzzzzzzzzr_?.Value;
            Code<ObservationStatus> szzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzs_);
            string szzzzzzzzzu_ = context.Operators.Convert<string>(szzzzzzzzzt_);
            string[] szzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzw_ = context.Operators.In<string>(szzzzzzzzzu_, szzzzzzzzzv_ as IEnumerable<string>);
            bool? szzzzzzzzzx_ = context.Operators.And(szzzzzzzzzq_, szzzzzzzzzw_);
            object szzzzzzzzzy_()
            {
                bool tzzzzzzzzzl_()
                {
                    DataType tzzzzzzzzzo_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object tzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzo_);
                    bool tzzzzzzzzzq_ = tzzzzzzzzzp_ is CqlDateTime;

                    return tzzzzzzzzzq_;
                };
                bool tzzzzzzzzzm_()
                {
                    DataType tzzzzzzzzzr_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object tzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzr_);
                    bool tzzzzzzzzzt_ = tzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzt_;
                };
                bool tzzzzzzzzzn_()
                {
                    DataType tzzzzzzzzzu_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object tzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzu_);
                    bool tzzzzzzzzzw_ = tzzzzzzzzzv_ is CqlDateTime;

                    return tzzzzzzzzzw_;
                };
                if (tzzzzzzzzzl_())
                {
                    DataType tzzzzzzzzzx_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object tzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzx_);

                    return (tzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzm_())
                {
                    DataType tzzzzzzzzzz_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object uzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzz_);

                    return (uzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzn_())
                {
                    DataType uzzzzzzzzzb_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object uzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzb_);

                    return (uzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzy_());
            CqlInterval<CqlDateTime> tzzzzzzzzza_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime tzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzza_);
            CqlQuantity tzzzzzzzzzc_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime tzzzzzzzzzd_ = context.Operators.Subtract(tzzzzzzzzzb_, tzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzza_);
            CqlQuantity tzzzzzzzzzg_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime tzzzzzzzzzh_ = context.Operators.Add(tzzzzzzzzzf_, tzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzi_ = context.Operators.Interval(tzzzzzzzzzd_, tzzzzzzzzzh_, true, true);
            bool? tzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzzzzz_, tzzzzzzzzzi_, default);
            bool? tzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzx_, tzzzzzzzzzj_);

            return tzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> szzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(szzzzzzzzzg_, szzzzzzzzzh_);
        Observation szzzzzzzzzj_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) =>
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> szzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(szzzzzzzzzi_, szzzzzzzzzj_);
        IEnumerable<Observation> szzzzzzzzzl_ = context.Operators.Distinct<Observation>(szzzzzzzzzk_);

        return szzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzd_ = this.Initial_Population(context);
        IEnumerable<Observation> uzzzzzzzzze_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet uzzzzzzzzzf_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> uzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> uzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(uzzzzzzzzzd_, uzzzzzzzzze_, uzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? uzzzzzzzzzi_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? uzzzzzzzzzp_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return uzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> uzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(uzzzzzzzzzh_, uzzzzzzzzzi_);
        bool? uzzzzzzzzzk_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object uzzzzzzzzzq_()
            {
                bool vzzzzzzzzzu_()
                {
                    DataType vzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object vzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzx_);
                    bool vzzzzzzzzzz_ = vzzzzzzzzzy_ is CqlDateTime;

                    return vzzzzzzzzzz_;
                };
                bool vzzzzzzzzzv_()
                {
                    DataType wzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object wzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzza_);
                    bool wzzzzzzzzzc_ = wzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzc_;
                };
                bool vzzzzzzzzzw_()
                {
                    DataType wzzzzzzzzzd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object wzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzd_);
                    bool wzzzzzzzzzf_ = wzzzzzzzzze_ is CqlDateTime;

                    return wzzzzzzzzzf_;
                };
                if (vzzzzzzzzzu_())
                {
                    DataType wzzzzzzzzzg_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object wzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzg_);

                    return (wzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzv_())
                {
                    DataType wzzzzzzzzzi_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object wzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzi_);

                    return (wzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzw_())
                {
                    DataType wzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object wzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzk_);

                    return (wzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime uzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.Earliest(context, uzzzzzzzzzq_());
            CqlInterval<CqlDateTime> uzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime uzzzzzzzzzt_ = context.Operators.Start(uzzzzzzzzzs_);
            CqlQuantity uzzzzzzzzzu_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime uzzzzzzzzzv_ = context.Operators.Subtract(uzzzzzzzzzt_, uzzzzzzzzzu_);
            CqlDateTime uzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzs_);
            CqlQuantity uzzzzzzzzzy_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime uzzzzzzzzzz_ = context.Operators.Add(uzzzzzzzzzx_, uzzzzzzzzzy_);
            CqlInterval<CqlDateTime> vzzzzzzzzza_ = context.Operators.Interval(uzzzzzzzzzv_, uzzzzzzzzzz_, true, true);
            bool? vzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzr_, vzzzzzzzzza_, default);
            object vzzzzzzzzzc_()
            {
                bool wzzzzzzzzzm_()
                {
                    DataType wzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object wzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzp_);
                    bool wzzzzzzzzzr_ = wzzzzzzzzzq_ is CqlDateTime;

                    return wzzzzzzzzzr_;
                };
                bool wzzzzzzzzzn_()
                {
                    DataType wzzzzzzzzzs_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object wzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzs_);
                    bool wzzzzzzzzzu_ = wzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzu_;
                };
                bool wzzzzzzzzzo_()
                {
                    DataType wzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object wzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzv_);
                    bool wzzzzzzzzzx_ = wzzzzzzzzzw_ is CqlDateTime;

                    return wzzzzzzzzzx_;
                };
                if (wzzzzzzzzzm_())
                {
                    DataType wzzzzzzzzzy_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object wzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzy_);

                    return (wzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzn_())
                {
                    DataType xzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object xzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzza_);

                    return (xzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzo_())
                {
                    DataType xzzzzzzzzzc_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object xzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzc_);

                    return (xzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzc_());
            CqlDateTime vzzzzzzzzzf_ = context.Operators.Start(uzzzzzzzzzs_);
            CqlDateTime vzzzzzzzzzh_ = context.Operators.Subtract(vzzzzzzzzzf_, uzzzzzzzzzu_);
            object vzzzzzzzzzi_()
            {
                bool xzzzzzzzzze_()
                {
                    DataType xzzzzzzzzzh_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzh_);
                    bool xzzzzzzzzzj_ = xzzzzzzzzzi_ is CqlDateTime;

                    return xzzzzzzzzzj_;
                };
                bool xzzzzzzzzzf_()
                {
                    DataType xzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzk_);
                    bool xzzzzzzzzzm_ = xzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzm_;
                };
                bool xzzzzzzzzzg_()
                {
                    DataType xzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzn_);
                    bool xzzzzzzzzzp_ = xzzzzzzzzzo_ is CqlDateTime;

                    return xzzzzzzzzzp_;
                };
                if (xzzzzzzzzze_())
                {
                    DataType xzzzzzzzzzq_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzq_);

                    return (xzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzf_())
                {
                    DataType xzzzzzzzzzs_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzs_);

                    return (xzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzg_())
                {
                    DataType xzzzzzzzzzu_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object xzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzu_);

                    return (xzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzi_());
            CqlInterval<CqlDateTime> vzzzzzzzzzk_ = context.Operators.Interval(vzzzzzzzzzh_, vzzzzzzzzzj_, true, false);
            bool? vzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzd_, vzzzzzzzzzk_, default);
            bool? vzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzb_, vzzzzzzzzzl_);
            Id vzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string vzzzzzzzzzo_ = vzzzzzzzzzn_?.Value;
            Id vzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string vzzzzzzzzzq_ = vzzzzzzzzzp_?.Value;
            bool? vzzzzzzzzzr_ = context.Operators.Equivalent(vzzzzzzzzzo_, vzzzzzzzzzq_);
            bool? vzzzzzzzzzs_ = context.Operators.Not(vzzzzzzzzzr_);
            bool? vzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzm_, vzzzzzzzzzs_);

            return vzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> uzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(uzzzzzzzzzj_, uzzzzzzzzzk_);
        Observation uzzzzzzzzzm_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) =>
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> uzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(uzzzzzzzzzl_, uzzzzzzzzzm_);
        IEnumerable<Observation> uzzzzzzzzzo_ = context.Operators.Distinct<Observation>(uzzzzzzzzzn_);

        return uzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzw_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? xzzzzzzzzzx_(Observation GlucoseResult1000)
        {
            Id xzzzzzzzzzz_ = GlucoseResult1000?.IdElement;
            string yzzzzzzzzza_ = xzzzzzzzzzz_?.Value;
            IEnumerable<Observation> yzzzzzzzzzb_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? yzzzzzzzzzc_(Observation @this)
            {
                string yzzzzzzzzzi_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? yzzzzzzzzzj_ = context.Operators.Not((bool?)(yzzzzzzzzzi_ is null));

                return yzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzd_ = context.Operators.Where<Observation>(yzzzzzzzzzb_, yzzzzzzzzzc_);
            string yzzzzzzzzze_(Observation @this)
            {
                string yzzzzzzzzzk_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return yzzzzzzzzzk_;
            };
            IEnumerable<string> yzzzzzzzzzf_ = context.Operators.Select<Observation, string>(yzzzzzzzzzd_, yzzzzzzzzze_);
            bool? yzzzzzzzzzg_ = context.Operators.In<string>(yzzzzzzzzza_, yzzzzzzzzzf_);
            bool? yzzzzzzzzzh_ = context.Operators.Not(yzzzzzzzzzg_);

            return yzzzzzzzzzh_;
        };
        IEnumerable<Observation> xzzzzzzzzzy_ = context.Operators.Where<Observation>(xzzzzzzzzzw_, xzzzzzzzzzx_);

        return xzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzl_ = this.Initial_Population(context);
        IEnumerable<Encounter> yzzzzzzzzzm_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> yzzzzzzzzzo_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? yzzzzzzzzzp_(Observation FirstGlucoseResult)
            {
                DataType yzzzzzzzzzt_ = FirstGlucoseResult?.Value;
                object yzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzt_);
                CqlQuantity yzzzzzzzzzv_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? yzzzzzzzzzw_ = context.Operators.GreaterOrEqual(yzzzzzzzzzu_ as CqlQuantity, yzzzzzzzzzv_);
                object yzzzzzzzzzx_()
                {
                    bool zzzzzzzzzzk_()
                    {
                        DataType zzzzzzzzzzn_ = FirstGlucoseResult?.Effective;
                        object zzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzn_);
                        bool zzzzzzzzzzp_ = zzzzzzzzzzo_ is CqlDateTime;

                        return zzzzzzzzzzp_;
                    };
                    bool zzzzzzzzzzl_()
                    {
                        DataType zzzzzzzzzzq_ = FirstGlucoseResult?.Effective;
                        object zzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzq_);
                        bool zzzzzzzzzzs_ = zzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                        return zzzzzzzzzzs_;
                    };
                    bool zzzzzzzzzzm_()
                    {
                        DataType zzzzzzzzzzt_ = FirstGlucoseResult?.Effective;
                        object zzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzt_);
                        bool zzzzzzzzzzv_ = zzzzzzzzzzu_ is CqlDateTime;

                        return zzzzzzzzzzv_;
                    };
                    if (zzzzzzzzzzk_())
                    {
                        DataType zzzzzzzzzzw_ = FirstGlucoseResult?.Effective;
                        object zzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzw_);

                        return (zzzzzzzzzzx_ as CqlDateTime) as object;
                    }
                    else if (zzzzzzzzzzl_())
                    {
                        DataType zzzzzzzzzzy_ = FirstGlucoseResult?.Effective;
                        object zzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzy_);

                        return (zzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (zzzzzzzzzzm_())
                    {
                        DataType azzzzzzzzzza_ = FirstGlucoseResult?.Effective;
                        object azzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzza_);

                        return (azzzzzzzzzzb_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime yzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, yzzzzzzzzzx_());
                CqlInterval<CqlDateTime> yzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime zzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzz_);
                CqlQuantity zzzzzzzzzzb_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime zzzzzzzzzzc_ = context.Operators.Subtract(zzzzzzzzzza_, zzzzzzzzzzb_);
                CqlDateTime zzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzz_);
                CqlQuantity zzzzzzzzzzf_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime zzzzzzzzzzg_ = context.Operators.Add(zzzzzzzzzze_, zzzzzzzzzzf_);
                CqlInterval<CqlDateTime> zzzzzzzzzzh_ = context.Operators.Interval(zzzzzzzzzzc_, zzzzzzzzzzg_, true, true);
                bool? zzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzy_, zzzzzzzzzzh_, default);
                bool? zzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzw_, zzzzzzzzzzi_);

                return zzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzzzzo_, yzzzzzzzzzp_);
            Encounter yzzzzzzzzzr_(Observation FirstGlucoseResult) =>
                InpatientHospitalization;
            IEnumerable<Encounter> yzzzzzzzzzs_ = context.Operators.Select<Observation, Encounter>(yzzzzzzzzzq_, yzzzzzzzzzr_);

            return yzzzzzzzzzs_;
        };
        IEnumerable<Encounter> yzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzl_, yzzzzzzzzzm_);

        return yzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzc_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return azzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> azzzzzzzzzzd_ = this.Days_with_Hyperglycemic_Events(context);
        bool? azzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> azzzzzzzzzzj_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? azzzzzzzzzzk_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? azzzzzzzzzzn_ = EligibleEventDay?.hasHyperglycemicEvent;

                return azzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> azzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(azzzzzzzzzzj_, azzzzzzzzzzk_);
            bool? azzzzzzzzzzm_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(azzzzzzzzzzl_);

            return azzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> azzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(azzzzzzzzzzd_, azzzzzzzzzze_);
        Encounter azzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter azzzzzzzzzzo_ = HyperglycemicEventDays?.encounter;

            return azzzzzzzzzzo_;
        };
        IEnumerable<Encounter> azzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(azzzzzzzzzzf_, azzzzzzzzzzg_);
        IEnumerable<Encounter> azzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(azzzzzzzzzzh_);

        return azzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzp_ = this.Encounter_with_Hyperglycemic_Events(context);

        return azzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? azzzzzzzzzzu_()
        {
            bool azzzzzzzzzzv_()
            {
                string azzzzzzzzzzw_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> azzzzzzzzzzx_ = this.Denominator_Exclusions(context);
                bool? azzzzzzzzzzy_(Encounter @this)
                {
                    string bzzzzzzzzzzd_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? bzzzzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzzzzd_ is null));

                    return bzzzzzzzzzze_;
                };
                IEnumerable<Encounter> azzzzzzzzzzz_ = context.Operators.Where<Encounter>(azzzzzzzzzzx_, azzzzzzzzzzy_);
                string bzzzzzzzzzza_(Encounter @this)
                {
                    string bzzzzzzzzzzf_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return bzzzzzzzzzzf_;
                };
                IEnumerable<string> bzzzzzzzzzzb_ = context.Operators.Select<Encounter, string>(azzzzzzzzzzz_, bzzzzzzzzzza_);
                bool? bzzzzzzzzzzc_ = context.Operators.In<string>(azzzzzzzzzzw_, bzzzzzzzzzzb_);

                return bzzzzzzzzzzc_ ?? false;
            };
            if (azzzzzzzzzzv_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> bzzzzzzzzzzg_ = this.Days_with_Hyperglycemic_Events(context);
                bool? bzzzzzzzzzzh_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter bzzzzzzzzzzn_ = EncounterWithEventDays?.encounter;
                    bool? bzzzzzzzzzzo_ = context.Operators.Equal(bzzzzzzzzzzn_, QualifyingEncounter);

                    return bzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> bzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(bzzzzzzzzzzg_, bzzzzzzzzzzh_);
                int? bzzzzzzzzzzj_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> bzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(bzzzzzzzzzzi_, bzzzzzzzzzzj_);
                IEnumerable<int?> bzzzzzzzzzzl_ = context.Operators.Distinct<int?>(bzzzzzzzzzzk_);
                int? bzzzzzzzzzzm_ = context.Operators.SingletonFrom<int?>(bzzzzzzzzzzl_);

                return bzzzzzzzzzzm_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> bzzzzzzzzzzp_ = this.Days_with_Hyperglycemic_Events(context);
                bool? bzzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter bzzzzzzzzzzw_ = EncounterWithEventDays?.encounter;
                    bool? bzzzzzzzzzzx_ = context.Operators.Equal(bzzzzzzzzzzw_, QualifyingEncounter);

                    return bzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> bzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(bzzzzzzzzzzp_, bzzzzzzzzzzq_);
                int? bzzzzzzzzzzs_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> bzzzzzzzzzzy_ = EncounterWithEventDays?.eligibleEventDays;
                    int? bzzzzzzzzzzz_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(bzzzzzzzzzzy_);

                    return bzzzzzzzzzzz_;
                };
                IEnumerable<int?> bzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(bzzzzzzzzzzr_, bzzzzzzzzzzs_);
                IEnumerable<int?> bzzzzzzzzzzu_ = context.Operators.Distinct<int?>(bzzzzzzzzzzt_);
                int? bzzzzzzzzzzv_ = context.Operators.SingletonFrom<int?>(bzzzzzzzzzzu_);

                return bzzzzzzzzzzv_;
            }
        };

        return azzzzzzzzzzu_();
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? czzzzzzzzzza_()
        {
            bool czzzzzzzzzzb_()
            {
                string czzzzzzzzzzc_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> czzzzzzzzzzd_ = this.Denominator_Exclusions(context);
                bool? czzzzzzzzzze_(Encounter @this)
                {
                    string czzzzzzzzzzj_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? czzzzzzzzzzk_ = context.Operators.Not((bool?)(czzzzzzzzzzj_ is null));

                    return czzzzzzzzzzk_;
                };
                IEnumerable<Encounter> czzzzzzzzzzf_ = context.Operators.Where<Encounter>(czzzzzzzzzzd_, czzzzzzzzzze_);
                string czzzzzzzzzzg_(Encounter @this)
                {
                    string czzzzzzzzzzl_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return czzzzzzzzzzl_;
                };
                IEnumerable<string> czzzzzzzzzzh_ = context.Operators.Select<Encounter, string>(czzzzzzzzzzf_, czzzzzzzzzzg_);
                bool? czzzzzzzzzzi_ = context.Operators.In<string>(czzzzzzzzzzc_, czzzzzzzzzzh_);

                return czzzzzzzzzzi_ ?? false;
            };
            if (czzzzzzzzzzb_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> czzzzzzzzzzm_ = this.Days_with_Hyperglycemic_Events(context);
                bool? czzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter czzzzzzzzzzt_ = EncounterWithEventDays?.encounter;
                    bool? czzzzzzzzzzu_ = context.Operators.Equal(czzzzzzzzzzt_, QualifyingEncounter);

                    return czzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> czzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(czzzzzzzzzzm_, czzzzzzzzzzn_);
                int? czzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> czzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(czzzzzzzzzzo_, czzzzzzzzzzp_);
                IEnumerable<int?> czzzzzzzzzzr_ = context.Operators.Distinct<int?>(czzzzzzzzzzq_);
                int? czzzzzzzzzzs_ = context.Operators.SingletonFrom<int?>(czzzzzzzzzzr_);

                return czzzzzzzzzzs_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> czzzzzzzzzzv_ = this.Days_with_Hyperglycemic_Events(context);
                bool? czzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter dzzzzzzzzzzc_ = EncounterWithEventDays?.encounter;
                    bool? dzzzzzzzzzzd_ = context.Operators.Equal(dzzzzzzzzzzc_, QualifyingEncounter);

                    return dzzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> czzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(czzzzzzzzzzv_, czzzzzzzzzzw_);
                int? czzzzzzzzzzy_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> dzzzzzzzzzze_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? dzzzzzzzzzzf_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? dzzzzzzzzzzi_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return dzzzzzzzzzzi_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> dzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(dzzzzzzzzzze_, dzzzzzzzzzzf_);
                    int? dzzzzzzzzzzh_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(dzzzzzzzzzzg_);

                    return dzzzzzzzzzzh_;
                };
                IEnumerable<int?> czzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(czzzzzzzzzzx_, czzzzzzzzzzy_);
                IEnumerable<int?> dzzzzzzzzzza_ = context.Operators.Distinct<int?>(czzzzzzzzzzz_);
                int? dzzzzzzzzzzb_ = context.Operators.SingletonFrom<int?>(dzzzzzzzzzza_);

                return dzzzzzzzzzzb_;
            }
        };

        return czzzzzzzzzza_();
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
