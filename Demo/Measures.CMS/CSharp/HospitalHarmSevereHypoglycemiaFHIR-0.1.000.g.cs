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

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose Lab Test Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext _) => _Glucose_Lab_Test_Mass_Per_Volume;
    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlValueSetDefinition("Hypoglycemics Severe Hypoglycemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext _) => _Hypoglycemics_Severe_Hypoglycemia;
    private static readonly CqlValueSet _Hypoglycemics_Severe_Hypoglycemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
        object kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", kzzzzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            Patient kzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
            Date kzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzx_);
            Period kzzzzzzzzzzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzb_);
            int? lzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzc_, "year");
            bool? lzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzzzzzzzd_, 18);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzj_);
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzl_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzn_, "finished");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<MedicationAdministration>(lzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzv_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> lzzzzzzzzzzzzzzzzzzzzzzzx_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? lzzzzzzzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> lzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(lzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? mzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> mzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(mzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzd_, "not-done");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzf_);

            return mzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<MedicationAdministration> lzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<MedicationAdministration>(lzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hypoglycemic_Medication_Administration(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzl_(MedicationAdministration HypoglycemicMedication)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzp_ = HypoglycemicMedication?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzt_, default);

                return mzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationAdministration>(mzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationAdministration HypoglycemicMedication) =>
                InpatientHospitalization;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationAdministration, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzn_);

            return mzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Hypoglycemic_Medication_Administration(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Glucose Test with Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> mzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> nzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? nzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? nzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return nzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> nzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
        {
            object nzzzzzzzzzzzzzzzzzzzzzzzk_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return ozzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool ozzzzzzzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.Earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzk_());
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzm_, default);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzp_);
            string nzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(40m, "mg/dL");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Less(nzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzza_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzc_);
            object ozzzzzzzzzzzzzzzzzzzzzzze_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzzzzze_());
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzg_);
            object ozzzzzzzzzzzzzzzzzzzzzzzi_()
            {
                bool qzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                if (qzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzr_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzi_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzk_, default);
            object ozzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                bool qzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                if (qzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzm_());
            bool? ozzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzp_);

            return ozzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> nzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzze_);
        Observation nzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) =>
            tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzh_);

        return nzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Denominator(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> rzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? rzzzzzzzzzzzzzzzzzzzzzzzq_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? rzzzzzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return rzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(rzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
        {
            object rzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzy_());
            object szzzzzzzzzzzzzzzzzzzzzzza_()
            {
                bool uzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (uzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzza_());
            object szzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool uzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                if (uzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzc_());
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzf_, false, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzg_, default);
            object szzzzzzzzzzzzzzzzzzzzzzzi_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzi_());
            bool? szzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzk_);
            object szzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                bool wzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzs_);
                    bool wzzzzzzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return wzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                if (wzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (wzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzm_());
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzp_);
            object szzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzp_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzr_);

                    return (xzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzr_());
            bool? szzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? szzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzu_);
            Id szzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
            string szzzzzzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Id szzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
            string szzzzzzzzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            bool? tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzze_);
            string tzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] tzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(80m, "mg/dL");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Greater(tzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzn_);

            return tzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> rzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(rzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzs_);
        Observation rzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) =>
            tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzv_);

        return rzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzu_(Observation LowGlucoseTest)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzw_ = LowGlucoseTest?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                string yzzzzzzzzzzzzzzzzzzzzzzzf_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? yzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzf_ is null));

                return yzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzz_);
            string yzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                string yzzzzzzzzzzzzzzzzzzzzzzzh_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return yzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<string> yzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation, string>(yzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(yzzzzzzzzzzzzzzzzzzzzzzzd_);

            return yzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzu_);

        return xzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Denominator(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Encounter, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? yzzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? yzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD, _valueTuple.Item1, _valueTuple.Item2);

            return yzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> yzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(yzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
        {
            object yzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzn_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.Earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzt_());
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return yzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> yzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(yzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzn_);
        Encounter yzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) =>
            tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzzzzzzzzzzt_;
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
