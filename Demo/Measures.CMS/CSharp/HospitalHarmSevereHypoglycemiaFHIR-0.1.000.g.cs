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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.1.000")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_1_000>
{
    private HospitalHarmSevereHypoglycemiaFHIR_0_1_000() {}

    public static HospitalHarmSevereHypoglycemiaFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmSevereHypoglycemiaFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: birth date
    [CqlValueSetDefinition(
        definitionName: "birth date",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4",
        valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext context) => _birth_date;

    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Glucose Lab Test Mass Per Volume
    [CqlValueSetDefinition(
        definitionName: "Glucose Lab Test Mass Per Volume",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34",
        valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext context) => _Glucose_Lab_Test_Mass_Per_Volume;

    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);
    #endregion

    #region ValueSet: Hypoglycemics Severe Hypoglycemia
    [CqlValueSetDefinition(
        definitionName: "Hypoglycemics Severe Hypoglycemia",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393",
        valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext context) => _Hypoglycemics_Severe_Hypoglycemia;

    private static readonly CqlValueSet _Hypoglycemics_Severe_Hypoglycemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzza_ = context.Operators.Interval(yzzzzzzzzzzzy_, yzzzzzzzzzzzz_, true, true);
        object zzzzzzzzzzzzb_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", zzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzc_);

        return zzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> zzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? zzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            Patient zzzzzzzzzzzzi_ = this.Patient(context);
            Date zzzzzzzzzzzzj_ = zzzzzzzzzzzzi_?.BirthDateElement;
            string zzzzzzzzzzzzk_ = zzzzzzzzzzzzj_?.Value;
            CqlDate zzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzk_);
            Period zzzzzzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzm_);
            CqlDateTime zzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzn_);
            CqlDate zzzzzzzzzzzzp_ = context.Operators.DateFrom(zzzzzzzzzzzzo_);
            int? zzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzl_, zzzzzzzzzzzzp_, "year");
            bool? zzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzq_, 18);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzm_);
            CqlDateTime zzzzzzzzzzzzu_ = context.Operators.End(zzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzu_, zzzzzzzzzzzzv_, "day");
            bool? zzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzr_, zzzzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> zzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? zzzzzzzzzzzzz_ = zzzzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzb_ = context.Operators.Equal(azzzzzzzzzzzza_, "finished");
            bool? azzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzx_, azzzzzzzzzzzzb_);

            return azzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzf_, zzzzzzzzzzzzg_);

        return zzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzd_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> azzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, azzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, azzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzh_ = context.Operators.Union<MedicationAdministration>(azzzzzzzzzzzze_, azzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzi_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> azzzzzzzzzzzzk_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? azzzzzzzzzzzzl_ = azzzzzzzzzzzzk_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> azzzzzzzzzzzzm_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(azzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzn_ = context.Operators.Equal(azzzzzzzzzzzzm_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? azzzzzzzzzzzzp_ = azzzzzzzzzzzzk_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> azzzzzzzzzzzzq_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(azzzzzzzzzzzzp_);
            bool? azzzzzzzzzzzzr_ = context.Operators.Equal(azzzzzzzzzzzzq_, "not-done");
            bool? azzzzzzzzzzzzs_ = context.Operators.Not(azzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzt_ = context.Operators.And(azzzzzzzzzzzzn_, azzzzzzzzzzzzs_);

            return azzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzj_ = context.Operators.Where<MedicationAdministration>(azzzzzzzzzzzzh_, azzzzzzzzzzzzi_);

        return azzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzu_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzv_(Encounter InpatientHospitalization)
        {
            IEnumerable<MedicationAdministration> azzzzzzzzzzzzx_ = this.Hypoglycemic_Medication_Administration(context);
            bool? azzzzzzzzzzzzy_(MedicationAdministration HypoglycemicMedication)
            {
                DataType bzzzzzzzzzzzzc_ = HypoglycemicMedication?.Effective;
                object bzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, bzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzf_ = context.Operators.Start(bzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                bool? bzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzf_, bzzzzzzzzzzzzg_, default);

                return bzzzzzzzzzzzzh_;
            };
            IEnumerable<MedicationAdministration> azzzzzzzzzzzzz_ = context.Operators.Where<MedicationAdministration>(azzzzzzzzzzzzx_, azzzzzzzzzzzzy_);
            Encounter bzzzzzzzzzzzza_(MedicationAdministration HypoglycemicMedication) =>
                InpatientHospitalization;
            IEnumerable<Encounter> bzzzzzzzzzzzzb_ = context.Operators.Select<MedicationAdministration, Encounter>(azzzzzzzzzzzzz_, bzzzzzzzzzzzza_);

            return bzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzu_, azzzzzzzzzzzzv_);

        return azzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzi_ = this.Encounter_with_Hypoglycemic_Medication_Administration(context);

        return bzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Glucose Test with Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzk_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> bzzzzzzzzzzzzl_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet bzzzzzzzzzzzzm_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> bzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> bzzzzzzzzzzzzo_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(bzzzzzzzzzzzzk_, bzzzzzzzzzzzzl_, bzzzzzzzzzzzzn_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? bzzzzzzzzzzzzp_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? bzzzzzzzzzzzzw_ = (CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> bzzzzzzzzzzzzq_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(bzzzzzzzzzzzzo_, bzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
        {
            object bzzzzzzzzzzzzx_()
            {
                bool dzzzzzzzzzzzze_()
                {
                    DataType dzzzzzzzzzzzzh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzh_);
                    bool dzzzzzzzzzzzzj_ = dzzzzzzzzzzzzi_ is CqlDateTime;

                    return dzzzzzzzzzzzzj_;
                };
                bool dzzzzzzzzzzzzf_()
                {
                    DataType dzzzzzzzzzzzzk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzk_);
                    bool dzzzzzzzzzzzzm_ = dzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzm_;
                };
                bool dzzzzzzzzzzzzg_()
                {
                    DataType dzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzn_);
                    bool dzzzzzzzzzzzzp_ = dzzzzzzzzzzzzo_ is CqlDateTime;

                    return dzzzzzzzzzzzzp_;
                };
                if (dzzzzzzzzzzzze_())
                {
                    DataType dzzzzzzzzzzzzq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzq_);

                    return (dzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzf_())
                {
                    DataType dzzzzzzzzzzzzs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzs_);

                    return (dzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzg_())
                {
                    DataType dzzzzzzzzzzzzu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object dzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzu_);

                    return (dzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, bzzzzzzzzzzzzx_());
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
            bool? czzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzy_, bzzzzzzzzzzzzz_, default);
            Code<ObservationStatus> czzzzzzzzzzzzb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzc_ = czzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzc_);
            string czzzzzzzzzzzze_ = context.Operators.Convert<string>(czzzzzzzzzzzzd_);
            string[] czzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzg_ = context.Operators.In<string>(czzzzzzzzzzzze_, czzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzh_ = context.Operators.And(czzzzzzzzzzzza_, czzzzzzzzzzzzg_);
            DataType czzzzzzzzzzzzi_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
            object czzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzi_);
            CqlQuantity czzzzzzzzzzzzk_ = context.Operators.Quantity(40m, "mg/dL");
            bool? czzzzzzzzzzzzl_ = context.Operators.Less(czzzzzzzzzzzzj_ as CqlQuantity, czzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzh_, czzzzzzzzzzzzl_);
            DataType czzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
            object czzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzzo_);
            CqlDateTime czzzzzzzzzzzzq_ = context.Operators.Start(czzzzzzzzzzzzp_);
            object czzzzzzzzzzzzr_()
            {
                bool dzzzzzzzzzzzzw_()
                {
                    DataType dzzzzzzzzzzzzz_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzz_);
                    bool ezzzzzzzzzzzzb_ = ezzzzzzzzzzzza_ is CqlDateTime;

                    return ezzzzzzzzzzzzb_;
                };
                bool dzzzzzzzzzzzzx_()
                {
                    DataType ezzzzzzzzzzzzc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzc_);
                    bool ezzzzzzzzzzzze_ = ezzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzze_;
                };
                bool dzzzzzzzzzzzzy_()
                {
                    DataType ezzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzf_);
                    bool ezzzzzzzzzzzzh_ = ezzzzzzzzzzzzg_ is CqlDateTime;

                    return ezzzzzzzzzzzzh_;
                };
                if (dzzzzzzzzzzzzw_())
                {
                    DataType ezzzzzzzzzzzzi_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzi_);

                    return (ezzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzx_())
                {
                    DataType ezzzzzzzzzzzzk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzk_);

                    return (ezzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzy_())
                {
                    DataType ezzzzzzzzzzzzm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzm_);

                    return (ezzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.Earliest(context, czzzzzzzzzzzzr_());
            CqlQuantity czzzzzzzzzzzzt_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime czzzzzzzzzzzzu_ = context.Operators.Subtract(czzzzzzzzzzzzs_, czzzzzzzzzzzzt_);
            object czzzzzzzzzzzzv_()
            {
                bool ezzzzzzzzzzzzo_()
                {
                    DataType ezzzzzzzzzzzzr_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzr_);
                    bool ezzzzzzzzzzzzt_ = ezzzzzzzzzzzzs_ is CqlDateTime;

                    return ezzzzzzzzzzzzt_;
                };
                bool ezzzzzzzzzzzzp_()
                {
                    DataType ezzzzzzzzzzzzu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzu_);
                    bool ezzzzzzzzzzzzw_ = ezzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzw_;
                };
                bool ezzzzzzzzzzzzq_()
                {
                    DataType ezzzzzzzzzzzzx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ezzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzx_);
                    bool ezzzzzzzzzzzzz_ = ezzzzzzzzzzzzy_ is CqlDateTime;

                    return ezzzzzzzzzzzzz_;
                };
                if (ezzzzzzzzzzzzo_())
                {
                    DataType fzzzzzzzzzzzza_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzza_);

                    return (fzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzp_())
                {
                    DataType fzzzzzzzzzzzzc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzc_);

                    return (fzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzq_())
                {
                    DataType fzzzzzzzzzzzze_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzze_);

                    return (fzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, czzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzx_ = context.Operators.Interval(czzzzzzzzzzzzu_, czzzzzzzzzzzzw_, true, true);
            bool? czzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzq_, czzzzzzzzzzzzx_, default);
            object czzzzzzzzzzzzz_()
            {
                bool fzzzzzzzzzzzzg_()
                {
                    DataType fzzzzzzzzzzzzj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzj_);
                    bool fzzzzzzzzzzzzl_ = fzzzzzzzzzzzzk_ is CqlDateTime;

                    return fzzzzzzzzzzzzl_;
                };
                bool fzzzzzzzzzzzzh_()
                {
                    DataType fzzzzzzzzzzzzm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzm_);
                    bool fzzzzzzzzzzzzo_ = fzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzzzzzzo_;
                };
                bool fzzzzzzzzzzzzi_()
                {
                    DataType fzzzzzzzzzzzzp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzp_);
                    bool fzzzzzzzzzzzzr_ = fzzzzzzzzzzzzq_ is CqlDateTime;

                    return fzzzzzzzzzzzzr_;
                };
                if (fzzzzzzzzzzzzg_())
                {
                    DataType fzzzzzzzzzzzzs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzs_);

                    return (fzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzzh_())
                {
                    DataType fzzzzzzzzzzzzu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzu_);

                    return (fzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzzzzzzi_())
                {
                    DataType fzzzzzzzzzzzzw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object fzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzw_);

                    return (fzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.Earliest(context, czzzzzzzzzzzzz_());
            bool? dzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(dzzzzzzzzzzzza_ is null));
            bool? dzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzy_, dzzzzzzzzzzzzb_);
            bool? dzzzzzzzzzzzzd_ = context.Operators.And(czzzzzzzzzzzzm_, dzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> bzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(bzzzzzzzzzzzzq_, bzzzzzzzzzzzzr_);
        Observation bzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) =>
            tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
        IEnumerable<Observation> bzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(bzzzzzzzzzzzzs_, bzzzzzzzzzzzzt_);
        IEnumerable<Observation> bzzzzzzzzzzzzv_ = context.Operators.Distinct<Observation>(bzzzzzzzzzzzzu_);

        return bzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzy_ = this.Denominator(context);
        IEnumerable<Observation> fzzzzzzzzzzzzz_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        CqlValueSet gzzzzzzzzzzzza_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> gzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> gzzzzzzzzzzzzc_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(fzzzzzzzzzzzzy_, fzzzzzzzzzzzzz_, gzzzzzzzzzzzzb_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? gzzzzzzzzzzzzd_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? gzzzzzzzzzzzzk_ = (CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return gzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> gzzzzzzzzzzzze_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(gzzzzzzzzzzzzc_, gzzzzzzzzzzzzd_);
        bool? gzzzzzzzzzzzzf_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
        {
            object gzzzzzzzzzzzzl_()
            {
                bool izzzzzzzzzzzzc_()
                {
                    DataType izzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzf_);
                    bool izzzzzzzzzzzzh_ = izzzzzzzzzzzzg_ is CqlDateTime;

                    return izzzzzzzzzzzzh_;
                };
                bool izzzzzzzzzzzzd_()
                {
                    DataType izzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzi_);
                    bool izzzzzzzzzzzzk_ = izzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzk_;
                };
                bool izzzzzzzzzzzze_()
                {
                    DataType izzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzl_);
                    bool izzzzzzzzzzzzn_ = izzzzzzzzzzzzm_ is CqlDateTime;

                    return izzzzzzzzzzzzn_;
                };
                if (izzzzzzzzzzzzc_())
                {
                    DataType izzzzzzzzzzzzo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzo_);

                    return (izzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzd_())
                {
                    DataType izzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzq_);

                    return (izzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzze_())
                {
                    DataType izzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object izzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzs_);

                    return (izzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzl_());
            object gzzzzzzzzzzzzn_()
            {
                bool izzzzzzzzzzzzu_()
                {
                    DataType izzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object izzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzx_);
                    bool izzzzzzzzzzzzz_ = izzzzzzzzzzzzy_ is CqlDateTime;

                    return izzzzzzzzzzzzz_;
                };
                bool izzzzzzzzzzzzv_()
                {
                    DataType jzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzza_);
                    bool jzzzzzzzzzzzzc_ = jzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzc_;
                };
                bool izzzzzzzzzzzzw_()
                {
                    DataType jzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzd_);
                    bool jzzzzzzzzzzzzf_ = jzzzzzzzzzzzze_ is CqlDateTime;

                    return jzzzzzzzzzzzzf_;
                };
                if (izzzzzzzzzzzzu_())
                {
                    DataType jzzzzzzzzzzzzg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzg_);

                    return (jzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzv_())
                {
                    DataType jzzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzi_);

                    return (jzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzw_())
                {
                    DataType jzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzk_);

                    return (jzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzn_());
            object gzzzzzzzzzzzzp_()
            {
                bool jzzzzzzzzzzzzm_()
                {
                    DataType jzzzzzzzzzzzzp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzp_);
                    bool jzzzzzzzzzzzzr_ = jzzzzzzzzzzzzq_ is CqlDateTime;

                    return jzzzzzzzzzzzzr_;
                };
                bool jzzzzzzzzzzzzn_()
                {
                    DataType jzzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzs_);
                    bool jzzzzzzzzzzzzu_ = jzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzu_;
                };
                bool jzzzzzzzzzzzzo_()
                {
                    DataType jzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzv_);
                    bool jzzzzzzzzzzzzx_ = jzzzzzzzzzzzzw_ is CqlDateTime;

                    return jzzzzzzzzzzzzx_;
                };
                if (jzzzzzzzzzzzzm_())
                {
                    DataType jzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object jzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzy_);

                    return (jzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzn_())
                {
                    DataType kzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzza_);

                    return (kzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzo_())
                {
                    DataType kzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzc_);

                    return (kzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzp_());
            CqlQuantity gzzzzzzzzzzzzr_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime gzzzzzzzzzzzzs_ = context.Operators.Add(gzzzzzzzzzzzzq_, gzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzt_ = context.Operators.Interval(gzzzzzzzzzzzzo_, gzzzzzzzzzzzzs_, false, true);
            bool? gzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzm_, gzzzzzzzzzzzzt_, default);
            object gzzzzzzzzzzzzv_()
            {
                bool kzzzzzzzzzzzze_()
                {
                    DataType kzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzh_);
                    bool kzzzzzzzzzzzzj_ = kzzzzzzzzzzzzi_ is CqlDateTime;

                    return kzzzzzzzzzzzzj_;
                };
                bool kzzzzzzzzzzzzf_()
                {
                    DataType kzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzk_);
                    bool kzzzzzzzzzzzzm_ = kzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzm_;
                };
                bool kzzzzzzzzzzzzg_()
                {
                    DataType kzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzn_);
                    bool kzzzzzzzzzzzzp_ = kzzzzzzzzzzzzo_ is CqlDateTime;

                    return kzzzzzzzzzzzzp_;
                };
                if (kzzzzzzzzzzzze_())
                {
                    DataType kzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzq_);

                    return (kzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzf_())
                {
                    DataType kzzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzs_);

                    return (kzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzg_())
                {
                    DataType kzzzzzzzzzzzzu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object kzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzu_);

                    return (kzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzv_());
            bool? gzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzw_ is null));
            bool? gzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzu_, gzzzzzzzzzzzzx_);
            object gzzzzzzzzzzzzz_()
            {
                bool kzzzzzzzzzzzzw_()
                {
                    DataType kzzzzzzzzzzzzz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzz_);
                    bool lzzzzzzzzzzzzb_ = lzzzzzzzzzzzza_ is CqlDateTime;

                    return lzzzzzzzzzzzzb_;
                };
                bool kzzzzzzzzzzzzx_()
                {
                    DataType lzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzc_);
                    bool lzzzzzzzzzzzze_ = lzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzzzze_;
                };
                bool kzzzzzzzzzzzzy_()
                {
                    DataType lzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzf_);
                    bool lzzzzzzzzzzzzh_ = lzzzzzzzzzzzzg_ is CqlDateTime;

                    return lzzzzzzzzzzzzh_;
                };
                if (kzzzzzzzzzzzzw_())
                {
                    DataType lzzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzi_);

                    return (lzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzx_())
                {
                    DataType lzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzk_);

                    return (lzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzy_())
                {
                    DataType lzzzzzzzzzzzzm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzm_);

                    return (lzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzz_());
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
            bool? hzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzza_, hzzzzzzzzzzzzb_, default);
            bool? hzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzy_, hzzzzzzzzzzzzc_);
            object hzzzzzzzzzzzze_()
            {
                bool lzzzzzzzzzzzzo_()
                {
                    DataType lzzzzzzzzzzzzr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzr_);
                    bool lzzzzzzzzzzzzt_ = lzzzzzzzzzzzzs_ is CqlDateTime;

                    return lzzzzzzzzzzzzt_;
                };
                bool lzzzzzzzzzzzzp_()
                {
                    DataType lzzzzzzzzzzzzu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzu_);
                    bool lzzzzzzzzzzzzw_ = lzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzzzzw_;
                };
                bool lzzzzzzzzzzzzq_()
                {
                    DataType lzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object lzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzx_);
                    bool lzzzzzzzzzzzzz_ = lzzzzzzzzzzzzy_ is CqlDateTime;

                    return lzzzzzzzzzzzzz_;
                };
                if (lzzzzzzzzzzzzo_())
                {
                    DataType mzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object mzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzza_);

                    return (mzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzzzzp_())
                {
                    DataType mzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object mzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzc_);

                    return (mzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzzzzq_())
                {
                    DataType mzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object mzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzze_);

                    return (mzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.Earliest(context, hzzzzzzzzzzzze_());
            bool? hzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzf_, hzzzzzzzzzzzzb_, default);
            bool? hzzzzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzzzzd_, hzzzzzzzzzzzzh_);
            Id hzzzzzzzzzzzzj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
            string hzzzzzzzzzzzzk_ = hzzzzzzzzzzzzj_?.Value;
            Id hzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
            string hzzzzzzzzzzzzm_ = hzzzzzzzzzzzzl_?.Value;
            bool? hzzzzzzzzzzzzn_ = context.Operators.Equivalent(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzm_);
            bool? hzzzzzzzzzzzzo_ = context.Operators.Not(hzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzi_, hzzzzzzzzzzzzo_);
            Code<ObservationStatus> hzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? hzzzzzzzzzzzzr_ = hzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> hzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzr_);
            string hzzzzzzzzzzzzt_ = context.Operators.Convert<string>(hzzzzzzzzzzzzs_);
            string[] hzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzzv_ = context.Operators.In<string>(hzzzzzzzzzzzzt_, hzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzp_, hzzzzzzzzzzzzv_);
            DataType hzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
            object hzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzx_);
            CqlQuantity hzzzzzzzzzzzzz_ = context.Operators.Quantity(80m, "mg/dL");
            bool? izzzzzzzzzzzza_ = context.Operators.Greater(hzzzzzzzzzzzzy_ as CqlQuantity, hzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzw_, izzzzzzzzzzzza_);

            return izzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> gzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(gzzzzzzzzzzzze_, gzzzzzzzzzzzzf_);
        Observation gzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) =>
            tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
        IEnumerable<Observation> gzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(gzzzzzzzzzzzzg_, gzzzzzzzzzzzzh_);
        IEnumerable<Observation> gzzzzzzzzzzzzj_ = context.Operators.Distinct<Observation>(gzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzg_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        bool? mzzzzzzzzzzzzh_(Observation LowGlucoseTest)
        {
            Id mzzzzzzzzzzzzj_ = LowGlucoseTest?.IdElement;
            string mzzzzzzzzzzzzk_ = mzzzzzzzzzzzzj_?.Value;
            IEnumerable<Observation> mzzzzzzzzzzzzl_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);
            bool? mzzzzzzzzzzzzm_(Observation @this)
            {
                string mzzzzzzzzzzzzs_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? mzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzs_ is null));

                return mzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzl_, mzzzzzzzzzzzzm_);
            string mzzzzzzzzzzzzo_(Observation @this)
            {
                string mzzzzzzzzzzzzu_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return mzzzzzzzzzzzzu_;
            };
            IEnumerable<string> mzzzzzzzzzzzzp_ = context.Operators.Select<Observation, string>(mzzzzzzzzzzzzn_, mzzzzzzzzzzzzo_);
            bool? mzzzzzzzzzzzzq_ = context.Operators.In<string>(mzzzzzzzzzzzzk_, mzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzr_ = context.Operators.Not(mzzzzzzzzzzzzq_);

            return mzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzg_, mzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzv_ = this.Denominator(context);
        IEnumerable<Observation> mzzzzzzzzzzzzw_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> mzzzzzzzzzzzzx_ = context.Operators.CrossJoin<Encounter, Observation>(mzzzzzzzzzzzzv_, mzzzzzzzzzzzzw_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? mzzzzzzzzzzzzy_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? nzzzzzzzzzzzzf_ = (CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> mzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(mzzzzzzzzzzzzx_, mzzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzzza_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
        {
            object nzzzzzzzzzzzzg_()
            {
                bool nzzzzzzzzzzzzk_()
                {
                    DataType nzzzzzzzzzzzzn_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object nzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzn_);
                    bool nzzzzzzzzzzzzp_ = nzzzzzzzzzzzzo_ is CqlDateTime;

                    return nzzzzzzzzzzzzp_;
                };
                bool nzzzzzzzzzzzzl_()
                {
                    DataType nzzzzzzzzzzzzq_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object nzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzq_);
                    bool nzzzzzzzzzzzzs_ = nzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzs_;
                };
                bool nzzzzzzzzzzzzm_()
                {
                    DataType nzzzzzzzzzzzzt_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object nzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzt_);
                    bool nzzzzzzzzzzzzv_ = nzzzzzzzzzzzzu_ is CqlDateTime;

                    return nzzzzzzzzzzzzv_;
                };
                if (nzzzzzzzzzzzzk_())
                {
                    DataType nzzzzzzzzzzzzw_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object nzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzw_);

                    return (nzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzzl_())
                {
                    DataType nzzzzzzzzzzzzy_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object nzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzy_);

                    return (nzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzzzm_())
                {
                    DataType ozzzzzzzzzzzza_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object ozzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzza_);

                    return (ozzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.Earliest(context, nzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
            bool? nzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzh_, nzzzzzzzzzzzzi_, default);

            return nzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> nzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(mzzzzzzzzzzzzz_, nzzzzzzzzzzzza_);
        Encounter nzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) =>
            tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
        IEnumerable<Encounter> nzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(nzzzzzzzzzzzzb_, nzzzzzzzzzzzzc_);
        IEnumerable<Encounter> nzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzc_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event(context);

        return ozzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["QualifyingEncounter", "LowGlucoseTest", "FollowupGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO = new(
        [typeof(Encounter), typeof(MedicationAdministration), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicMedication", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "HypoglycemicEvent"]);

    #endregion CqlTupleMetadata Properties

}
