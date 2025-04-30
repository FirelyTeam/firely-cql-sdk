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
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            Patient pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "year");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, 18);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "finished");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<MedicationAdministration>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "not-done");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationAdministration>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InpatientHospitalization)
        {
            IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Hypoglycemic_Medication_Administration(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(MedicationAdministration HypoglycemicMedication)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HypoglycemicMedication?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationAdministration>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(MedicationAdministration HypoglycemicMedication) =>
                InpatientHospitalization;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationAdministration, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Hypoglycemic_Medication_Administration(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Glucose Test with Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_FSGEiXEbHOWUcRPJgTjPZFYcO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho)
        {
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_());
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_btymmdgachdragrhofgxbxgho?.QualifyingEncounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(40m, "mg/dL");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Less(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_btymmdgachdragrhofgxbxgho?.HypoglycemicMedication?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
            {
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_());
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_());
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_btymmdgachdragrhofgxbxgho) =>
            tuple_btymmdgachdragrhofgxbxgho?.GlucoseTest;
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Denominator(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_BfZBOfPTWgQBddbhgdIFdbKHU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd)
        {
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, false, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_clljqcgdejtdiiewkzyjpwapd?.QualifyingEncounter);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.Earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_());
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_clljqcgdejtdiiewkzyjpwapd?.FollowupGlucoseTest?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(80m, "mg/dL");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Greater(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_clljqcgdejtdiiewkzyjpwapd) =>
            tuple_clljqcgdejtdiiewkzyjpwapd?.LowGlucoseTest;
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Glucose_Test_with_Result_Less_Than_40(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation LowGlucoseTest)
        {
            Id czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = LowGlucoseTest?.IdElement;
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<string> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Denominator(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<Encounter, Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GNOWceaaAJjTLNBBKCiSMeeVD, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr)
        {
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_hfnempjqliopfnrmypnydhffr?.HypoglycemicEvent?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.Earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_());
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)? tuple_hfnempjqliopfnrmypnydhffr) =>
            tuple_hfnempjqliopfnrmypnydhffr?.QualifyingEncounter;
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HypoglycemicEvent)?, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
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
