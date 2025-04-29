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
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object nzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", nzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzzzzzzzv_);

        return nzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            Patient ozzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
            Date ozzzzzzzzzzzzzzzzzzzzc_ = ozzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string ozzzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDate ozzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzd_);
            Period ozzzzzzzzzzzzzzzzzzzzf_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzg_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzh_);
            int? ozzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzi_, "year");
            bool? ozzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzj_, 18);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzp_);
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? ozzzzzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<Encounter.EncounterStatus> ozzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ozzzzzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzt_, "finished");
            bool? ozzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzu_);

            return ozzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzz_);

        return ozzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzw_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationAdministration>(ozzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzzzzb_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzzzzzzzzzzzzd_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? pzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(pzzzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzf_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? pzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(pzzzzzzzzzzzzzzzzzzzzi_);
            bool? pzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzj_, "not-done");
            bool? pzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not(pzzzzzzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzl_);

            return pzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationAdministration>(pzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzb_);

        return pzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzo_(Encounter InpatientHospitalization)
        {
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzq_ = this.Hypoglycemic_Medication_Administration(context);
            bool? pzzzzzzzzzzzzzzzzzzzzr_(MedicationAdministration HypoglycemicMedication)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzv_ = HypoglycemicMedication?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                bool? qzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzz_, default);

                return qzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<MedicationAdministration>(pzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzr_);
            Encounter pzzzzzzzzzzzzzzzzzzzzt_(MedicationAdministration HypoglycemicMedication) =>
                InpatientHospitalization;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<MedicationAdministration, Encounter>(pzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Hypoglycemic_Medication_Administration(context);

        return qzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Glucose Test with Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzd_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzze_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzf_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> qzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(qzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? qzzzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? qzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return qzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> qzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(qzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
        {
            object qzzzzzzzzzzzzzzzzzzzzq_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzza_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzza_);
                    bool szzzzzzzzzzzzzzzzzzzzc_ = szzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzc_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzd_);
                    bool szzzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzf_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzg_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzg_);
                    bool szzzzzzzzzzzzzzzzzzzzi_ = szzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzi_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzj_);

                    return (szzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzl_);

                    return (szzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzn_);

                    return (szzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.Earliest(context, qzzzzzzzzzzzzzzzzzzzzq_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
            bool? qzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzs_, default);
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzu_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzv_);
            string qzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzw_);
            string[] qzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzz_);
            DataType rzzzzzzzzzzzzzzzzzzzzb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
            object rzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(40m, "mg/dL");
            bool? rzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Less(rzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzze_);
            DataType rzzzzzzzzzzzzzzzzzzzzg_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzi_);
            object rzzzzzzzzzzzzzzzzzzzzk_()
            {
                bool szzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzs_);
                    bool szzzzzzzzzzzzzzzzzzzzu_ = szzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzu_;
                };
                bool szzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzv_);
                    bool szzzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzx_;
                };
                bool szzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzy_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzy_);
                    bool tzzzzzzzzzzzzzzzzzzzza_ = szzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzza_;
                };
                if (szzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzb_);

                    return (tzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzd_);

                    return (tzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzf_);

                    return (tzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzk_());
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzm_);
            object rzzzzzzzzzzzzzzzzzzzzo_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzk_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzk_);
                    bool tzzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzn_);
                    bool tzzzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzq_);
                    bool tzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzt_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzt_);

                    return (tzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzv_);

                    return (tzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzx_);

                    return (tzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzo_());
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? rzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzq_, default);
            object rzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzc_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzc_);
                    bool uzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzze_;
                };
                bool uzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzf_);
                    bool uzzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzi_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzi_);
                    bool uzzzzzzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzk_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzl_);

                    return (uzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzn_);

                    return (uzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzp_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzp_);

                    return (uzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzs_());
            bool? rzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzu_);
            bool? rzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> qzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(qzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzk_);
        Observation qzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) =>
            tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(qzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Observation>(qzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzr_ = this.Denominator(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzs_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzt_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> uzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(uzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? uzzzzzzzzzzzzzzzzzzzzw_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? vzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return vzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> uzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(uzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
        {
            object vzzzzzzzzzzzzzzzzzzzze_()
            {
                bool wzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzy_);
                    bool xzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzza_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzb_);
                    bool xzzzzzzzzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzze_);
                    bool xzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (wzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzh_);

                    return (xzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzj_);

                    return (xzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzl_);

                    return (xzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzze_());
            object vzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzq_);
                    bool xzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzt_);
                    bool xzzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzw_);
                    bool xzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzy_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzz_);

                    return (yzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzb_);

                    return (yzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzd_);

                    return (yzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzzg_());
            object vzzzzzzzzzzzzzzzzzzzzi_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzi_);
                    bool yzzzzzzzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzl_);
                    bool yzzzzzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzo_);
                    bool yzzzzzzzzzzzzzzzzzzzzq_ = yzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzq_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzr_);

                    return (yzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzt_);

                    return (yzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzv_);

                    return (yzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzzi_());
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzl_, false, true);
            bool? vzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzm_, default);
            object vzzzzzzzzzzzzzzzzzzzzo_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzza_);
                    bool zzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzc_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzd_);
                    bool zzzzzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzg_);
                    bool zzzzzzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzi_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzj_);

                    return (zzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzl_);

                    return (zzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzn_);

                    return (zzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzzo_());
            bool? vzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? vzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzq_);
            object vzzzzzzzzzzzzzzzzzzzzs_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzs_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzs_);
                    bool zzzzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzv_);
                    bool zzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzy_);
                    bool azzzzzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzza_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzb_);

                    return (azzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzd_);

                    return (azzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzf_);

                    return (azzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzzs_());
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzu_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzv_);
            object vzzzzzzzzzzzzzzzzzzzzx_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzk_);
                    bool azzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzn_);
                    bool azzzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzq_);
                    bool azzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzt_);

                    return (azzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzv_);

                    return (azzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzx_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzx_);

                    return (azzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, vzzzzzzzzzzzzzzzzzzzzx_());
            bool? wzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzu_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzza_);
            Id wzzzzzzzzzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
            string wzzzzzzzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Id wzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
            string wzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzze_?.Value;
            bool? wzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzg_);
            bool? wzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzh_);
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? wzzzzzzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzk_);
            string wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzl_);
            string[] wzzzzzzzzzzzzzzzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzo_);
            DataType wzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
            object wzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(80m, "mg/dL");
            bool? wzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Greater(wzzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzt_);

            return wzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> uzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(uzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzy_);
        Observation vzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) =>
            tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(uzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<Observation>(vzzzzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzz_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        bool? bzzzzzzzzzzzzzzzzzzzzza_(Observation LowGlucoseTest)
        {
            Id bzzzzzzzzzzzzzzzzzzzzzc_ = LowGlucoseTest?.IdElement;
            string bzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzze_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                string bzzzzzzzzzzzzzzzzzzzzzl_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? bzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzl_ is null));

                return bzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzf_);
            string bzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                string bzzzzzzzzzzzzzzzzzzzzzn_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return bzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<string> bzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, string>(bzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzi_);
            bool? bzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzo_ = this.Denominator(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzp_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> bzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CrossJoin<Encounter, Observation>(bzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? bzzzzzzzzzzzzzzzzzzzzzr_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? bzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> bzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(bzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
        {
            object bzzzzzzzzzzzzzzzzzzzzzz_()
            {
                bool czzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzg_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzg_);
                    bool czzzzzzzzzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool czzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzj_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzj_);
                    bool czzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return czzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool czzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzm_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzm_);
                    bool czzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzo_;
                };
                if (czzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzp_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzp_);

                    return (czzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzr_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzr_);

                    return (czzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (czzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzt_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzt_);

                    return (czzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.Earliest(context, bzzzzzzzzzzzzzzzzzzzzzz_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
            bool? czzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzb_, default);

            return czzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> bzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(bzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzt_);
        Encounter bzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) =>
            tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(bzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event(context);

        return czzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzzzzzz_;
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
