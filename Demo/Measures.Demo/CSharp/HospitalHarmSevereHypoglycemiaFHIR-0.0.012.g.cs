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

    #region ValueSet: Glucose lab test
    [CqlValueSetDefinition(
        definitionName: "Glucose lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134",
        valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext context) => _Glucose_lab_test;

    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);
    #endregion

    #region ValueSet: Hypoglycemics
    [CqlValueSetDefinition(
        definitionName: "Hypoglycemics",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3",
        valueSetVersion: null)]
    public CqlValueSet Hypoglycemics(CqlContext context) => _Hypoglycemics;

    private static readonly CqlValueSet _Hypoglycemics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);
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

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] nzzzzzzzzzzzzzzzk_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return nzzzzzzzzzzzzzzzk_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime nzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime nzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzn_ = context.Operators.Interval(nzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzm_, true, false);
        object nzzzzzzzzzzzzzzzo_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", nzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient nzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> nzzzzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> nzzzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzu_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? nzzzzzzzzzzzzzzzw_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzzy_ = EncounterInpatient?.StatusElement;
            string nzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzza_ = context.Operators.Equal(nzzzzzzzzzzzzzzzz_, "finished");
            Period ozzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzzzzzzzzb_);
            CqlDateTime ozzzzzzzzzzzzzzzd_ = context.Operators.End(ozzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzze_, default);
            bool? ozzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzf_);

            return ozzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzw_);

        return nzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzh_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            Patient ozzzzzzzzzzzzzzzk_ = this.Patient(context);
            Date ozzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzk_?.BirthDateElement;
            string ozzzzzzzzzzzzzzzm_ = ozzzzzzzzzzzzzzzl_?.Value;
            CqlDateTime ozzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDateTime(ozzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime ozzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzo_);
            int? ozzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzp_, "year");
            bool? ozzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzq_, 18);

            return ozzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzi_);

        return ozzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzs_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationAdministration>(ozzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzv_);
        bool? ozzzzzzzzzzzzzzzx_(MedicationAdministration HypoMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ozzzzzzzzzzzzzzzz_ = HypoMedication?.StatusElement;
            string pzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzzzzzb_ = context.Operators.Equal(pzzzzzzzzzzzzzzza_, "completed");
            string pzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzzzzze_ = context.Operators.Equal(pzzzzzzzzzzzzzzzd_, "not-done");
            bool? pzzzzzzzzzzzzzzzf_ = context.Operators.Not(pzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<MedicationAdministration> ozzzzzzzzzzzzzzzy_ = context.Operators.Where<MedicationAdministration>(ozzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzi_(Encounter QualifyingEncounter)
        {
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzk_ = this.Hypoglycemic_Medication_Administration(context);
            bool? pzzzzzzzzzzzzzzzl_(MedicationAdministration HypoglycemicMedication)
            {
                DataType pzzzzzzzzzzzzzzzp_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzzp_);
                CqlDateTime pzzzzzzzzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? pzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzs_, default);

                return pzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<MedicationAdministration> pzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationAdministration>(pzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzl_);
            Encounter pzzzzzzzzzzzzzzzn_(MedicationAdministration HypoglycemicMedication) =>
                QualifyingEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationAdministration, Encounter>(pzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzi_);

        return pzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);

        return pzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzw_ = this.Denominator(context);
        bool? pzzzzzzzzzzzzzzzx_(Encounter QualifyingEncounter)
        {
            CqlValueSet pzzzzzzzzzzzzzzzz_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> qzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> qzzzzzzzzzzzzzzzb_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzn_ = this.Hypoglycemic_Medication_Administration(context);
                bool? qzzzzzzzzzzzzzzzo_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType qzzzzzzzzzzzzzzzs_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzs_);
                    CqlDateTime qzzzzzzzzzzzzzzzu_ = context.Operators.Start(qzzzzzzzzzzzzzzzt_);
                    DataType qzzzzzzzzzzzzzzzv_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzv_);
                    CqlDateTime qzzzzzzzzzzzzzzzx_ = context.Operators.Start(qzzzzzzzzzzzzzzzw_);
                    CqlQuantity qzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime qzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzy_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzv_);
                    CqlDateTime rzzzzzzzzzzzzzzzc_ = context.Operators.Start(rzzzzzzzzzzzzzzzb_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzd_ = context.Operators.Interval(qzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzc_, true, true);
                    bool? rzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzd_, default);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzv_);
                    CqlDateTime rzzzzzzzzzzzzzzzh_ = context.Operators.Start(rzzzzzzzzzzzzzzzg_);
                    bool? rzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzh_ is null));
                    bool? rzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzi_);
                    Code<ObservationStatus> rzzzzzzzzzzzzzzzk_ = BloodGlucoseLab?.StatusElement;
                    string rzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzk_);
                    bool? rzzzzzzzzzzzzzzzm_ = context.Operators.Equal(rzzzzzzzzzzzzzzzl_, "final");
                    bool? rzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzm_);
                    string rzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzk_);
                    bool? rzzzzzzzzzzzzzzzq_ = context.Operators.Equal(rzzzzzzzzzzzzzzzp_, "cancelled");
                    bool? rzzzzzzzzzzzzzzzr_ = context.Operators.Not(rzzzzzzzzzzzzzzzq_);
                    bool? rzzzzzzzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzr_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzzs_);
                    CqlDateTime rzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? rzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzw_, default);
                    bool? rzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzx_);

                    return rzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationAdministration>(qzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzo_);
                Observation qzzzzzzzzzzzzzzzq_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> qzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationAdministration, Observation>(qzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzq_);

                return qzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Observation, Observation>(qzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            IEnumerable<Observation> qzzzzzzzzzzzzzzzf_(Observation BloodGlucoseLab)
            {
                IEnumerable<MedicationAdministration> rzzzzzzzzzzzzzzzz_ = this.Hypoglycemic_Medication_Administration(context);
                bool? szzzzzzzzzzzzzzza_(MedicationAdministration HypoglycemicMeds)
                {
                    DataType szzzzzzzzzzzzzzze_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzze_);
                    CqlDateTime szzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzf_);
                    DataType szzzzzzzzzzzzzzzh_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzzh_);
                    CqlDateTime szzzzzzzzzzzzzzzj_ = context.Operators.Start(szzzzzzzzzzzzzzzi_);
                    CqlQuantity szzzzzzzzzzzzzzzk_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime szzzzzzzzzzzzzzzl_ = context.Operators.Subtract(szzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzzh_);
                    CqlDateTime szzzzzzzzzzzzzzzo_ = context.Operators.Start(szzzzzzzzzzzzzzzn_);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzp_ = context.Operators.Interval(szzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzo_, true, true);
                    bool? szzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzp_, default);
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzzh_);
                    CqlDateTime szzzzzzzzzzzzzzzt_ = context.Operators.Start(szzzzzzzzzzzzzzzs_);
                    bool? szzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzt_ is null));
                    bool? szzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzu_);
                    Code<ObservationStatus> szzzzzzzzzzzzzzzw_ = BloodGlucoseLab?.StatusElement;
                    string szzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzw_);
                    bool? szzzzzzzzzzzzzzzy_ = context.Operators.Equal(szzzzzzzzzzzzzzzx_, "final");
                    bool? szzzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzy_);
                    string tzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzw_);
                    bool? tzzzzzzzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzzzzzzzb_, "cancelled");
                    bool? tzzzzzzzzzzzzzzzd_ = context.Operators.Not(tzzzzzzzzzzzzzzzc_);
                    bool? tzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzd_);
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzze_);
                    CqlDateTime tzzzzzzzzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzzzzzzzzg_);
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? tzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzi_, default);
                    bool? tzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzj_);

                    return tzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<MedicationAdministration> szzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationAdministration>(rzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzza_);
                Observation szzzzzzzzzzzzzzzc_(MedicationAdministration HypoglycemicMeds) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> szzzzzzzzzzzzzzzd_ = context.Operators.Select<MedicationAdministration, Observation>(szzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzc_);

                return szzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Observation, Observation>(qzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzf_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzh_(Observation BloodGlucoseLab)
            {
                CqlValueSet tzzzzzzzzzzzzzzzl_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> tzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? tzzzzzzzzzzzzzzzn_(Observation FollowupBloodGlucoseLab)
                {
                    DataType tzzzzzzzzzzzzzzzr_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzr_);
                    CqlDateTime tzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzs_);
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? tzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzu_, default);
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzr_);
                    CqlDateTime tzzzzzzzzzzzzzzzy_ = context.Operators.Start(tzzzzzzzzzzzzzzzx_);
                    DataType tzzzzzzzzzzzzzzzz_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzz_);
                    CqlDateTime uzzzzzzzzzzzzzzzb_ = context.Operators.Start(uzzzzzzzzzzzzzzza_);
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzz_);
                    CqlDateTime uzzzzzzzzzzzzzzze_ = context.Operators.Start(uzzzzzzzzzzzzzzzd_);
                    CqlQuantity uzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime uzzzzzzzzzzzzzzzg_ = context.Operators.Add(uzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzh_ = context.Operators.Interval(uzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzg_, false, true);
                    bool? uzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzh_, default);
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzzz_);
                    CqlDateTime uzzzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzzzk_);
                    bool? uzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzl_ is null));
                    bool? uzzzzzzzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzm_);
                    bool? uzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzn_);
                    Code<ObservationStatus> uzzzzzzzzzzzzzzzp_ = FollowupBloodGlucoseLab?.StatusElement;
                    string uzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzp_);
                    bool? uzzzzzzzzzzzzzzzr_ = context.Operators.Equal(uzzzzzzzzzzzzzzzq_, "final");
                    bool? uzzzzzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzr_);
                    string uzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzzzp_);
                    bool? uzzzzzzzzzzzzzzzv_ = context.Operators.Equal(uzzzzzzzzzzzzzzzu_, "cancelled");
                    bool? uzzzzzzzzzzzzzzzw_ = context.Operators.Not(uzzzzzzzzzzzzzzzv_);
                    bool? uzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzw_);
                    DataType uzzzzzzzzzzzzzzzy_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity uzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzzzzzzzzzzzzzy_ as Quantity);
                    CqlQuantity vzzzzzzzzzzzzzzza_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? vzzzzzzzzzzzzzzzb_ = context.Operators.Greater(uzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzza_);
                    bool? vzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzb_);

                    return vzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Observation> tzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzn_);
                Observation tzzzzzzzzzzzzzzzp_(Observation FollowupBloodGlucoseLab) =>
                    BloodGlucoseLab;
                IEnumerable<Observation> tzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, Observation>(tzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzp_);

                return tzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzj_ = context.Operators.Except<Observation>(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzi_);
            bool? qzzzzzzzzzzzzzzzk_(Observation BloodGlucoseLab)
            {
                DataType vzzzzzzzzzzzzzzzd_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? vzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzg_, default);
                DataType vzzzzzzzzzzzzzzzi_ = BloodGlucoseLab?.Value;
                CqlQuantity vzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzi_ as Quantity);
                CqlQuantity vzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(40m, "mg/dL");
                bool? vzzzzzzzzzzzzzzzl_ = context.Operators.Less(vzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzk_);
                bool? vzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzl_);

                return vzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzn_ = this.Severe_Hypoglycemic_Harm_Event(context);

        return vzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
