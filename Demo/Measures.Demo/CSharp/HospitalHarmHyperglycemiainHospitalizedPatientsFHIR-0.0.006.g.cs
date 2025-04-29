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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.0.006")]
public partial class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006 : ILibrary, ISingleton<HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006>
{
    private HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006() {}

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_0_006 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR";
    public string Version => "0.0.006";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

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

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

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
        object lzzzzzzzzzzzzzq_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient lzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> lzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return lzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return lzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzx_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        return lzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzz_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? mzzzzzzzzzzzzza_(Encounter InpatientEncounter)
        {
            Patient mzzzzzzzzzzzzzc_ = this.Patient(context);
            Date mzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzc_?.BirthDateElement;
            string mzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzd_?.Value;
            CqlDateTime mzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDateTime(mzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime mzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzg_);
            int? mzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzh_, "year");
            bool? mzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzi_, 18);

            return mzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzz_, mzzzzzzzzzzzzza_);

        return mzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? mzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? mzzzzzzzzzzzzzp_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, mzzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> mzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(mzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> mzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(mzzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> mzzzzzzzzzzzzzq_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> mzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet mzzzzzzzzzzzzzw_ = this.Diabetes(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? mzzzzzzzzzzzzzy_(Condition DiabetesDiagnosis)
            {
                CodeableConcept nzzzzzzzzzzzzzc_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept nzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, nzzzzzzzzzzzzzc_);
                CqlCode nzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept nzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzze_);
                bool? nzzzzzzzzzzzzzg_ = context.Operators.Equivalent(nzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime nzzzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzj_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime nzzzzzzzzzzzzzk_ = context.Operators.End(nzzzzzzzzzzzzzj_);
                bool? nzzzzzzzzzzzzzl_ = context.Operators.Before(nzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzk_, default);
                bool? nzzzzzzzzzzzzzm_ = context.Operators.And(nzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzl_);

                return nzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? nzzzzzzzzzzzzza_(Condition DiabetesDiagnosis) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> nzzzzzzzzzzzzzb_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(mzzzzzzzzzzzzzz_, nzzzzzzzzzzzzza_);

            return nzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> mzzzzzzzzzzzzzs_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(mzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzr_);
        Encounter mzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter nzzzzzzzzzzzzzn_ = EncounterWithHospitalization?.encounter;

            return nzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(mzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzv_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> nzzzzzzzzzzzzzo_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet nzzzzzzzzzzzzzp_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> nzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, nzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> nzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, nzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> nzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationAdministration>(nzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> nzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(nzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? nzzzzzzzzzzzzzv_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? ozzzzzzzzzzzzzc_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> nzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(nzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzx_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ozzzzzzzzzzzzzd_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string ozzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzf_ = context.Operators.Equal(ozzzzzzzzzzzzze_, "completed");
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzg_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType ozzzzzzzzzzzzzh_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzg_, ozzzzzzzzzzzzzi_, default);
            bool? ozzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzf_, ozzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> nzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(nzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzx_);
        Encounter nzzzzzzzzzzzzzz_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Encounter ozzzzzzzzzzzzzl_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

            return ozzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(nzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ozzzzzzzzzzzzzm_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ozzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet ozzzzzzzzzzzzzs_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> ozzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            bool? ozzzzzzzzzzzzzu_(Observation BloodGlucoseLab)
            {
                DataType ozzzzzzzzzzzzzy_ = BloodGlucoseLab?.Effective;
                CqlDateTime ozzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ozzzzzzzzzzzzzy_ as FhirDateTime);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzza_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? pzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzz_, pzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzc_ = BloodGlucoseLab?.StatusElement;
                string pzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzc_);
                bool? pzzzzzzzzzzzzze_ = context.Operators.Equal(pzzzzzzzzzzzzzd_, "final");
                bool? pzzzzzzzzzzzzzf_ = context.Operators.And(pzzzzzzzzzzzzzb_, pzzzzzzzzzzzzze_);
                DataType pzzzzzzzzzzzzzg_ = BloodGlucoseLab?.Value;
                CqlQuantity pzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzzzzzzzzzzzzg_ as Quantity);
                CqlQuantity pzzzzzzzzzzzzzi_ = context.Operators.Quantity(200m, "mg/dL");
                bool? pzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzj_);

                return pzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzt_, ozzzzzzzzzzzzzu_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? ozzzzzzzzzzzzzw_(Observation BloodGlucoseLab) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ozzzzzzzzzzzzzx_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ozzzzzzzzzzzzzv_, ozzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ozzzzzzzzzzzzzo_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ozzzzzzzzzzzzzm_, ozzzzzzzzzzzzzn_);
        Encounter ozzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter pzzzzzzzzzzzzzl_ = EncounterWithHospitalization?.encounter;

            return pzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(ozzzzzzzzzzzzzo_, ozzzzzzzzzzzzzp_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzq_);

        return ozzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzm_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzn_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzp_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return pzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime pzzzzzzzzzzzzzs_ = context.Operators.Start(Period);
        CqlDateTime pzzzzzzzzzzzzzt_ = context.Operators.End(Period);
        CqlQuantity pzzzzzzzzzzzzzv_ = context.Operators.Quantity(10m, "days");
        CqlDateTime pzzzzzzzzzzzzzw_ = context.Operators.Add(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzv_);
        CqlDateTime[] pzzzzzzzzzzzzzx_ = [
            pzzzzzzzzzzzzzt_,
            pzzzzzzzzzzzzzw_,
        ];
        CqlDateTime pzzzzzzzzzzzzzy_ = context.Operators.Min<CqlDateTime>(pzzzzzzzzzzzzzx_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzz_ = context.Operators.Interval(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzy_, true, true);

        return pzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime qzzzzzzzzzzzzza_ = context.Operators.Start(Period);
        CqlDateTime qzzzzzzzzzzzzzb_ = context.Operators.End(Period);
        int? qzzzzzzzzzzzzzc_ = context.Operators.DurationBetween(qzzzzzzzzzzzzza_, qzzzzzzzzzzzzzb_, "day");
        CqlInterval<int?> qzzzzzzzzzzzzzd_ = context.Operators.Interval(1, qzzzzzzzzzzzzzc_, true, true);
        CqlInterval<int?>[] qzzzzzzzzzzzzze_ = [
            qzzzzzzzzzzzzzd_,
        ];
        IEnumerable<CqlInterval<int?>> qzzzzzzzzzzzzzf_ = context.Operators.Expand(qzzzzzzzzzzzzze_ as IEnumerable<CqlInterval<int?>>, default);
        int? qzzzzzzzzzzzzzg_(CqlInterval<int?> DayExpand)
        {
            int? qzzzzzzzzzzzzzj_ = context.Operators.End(DayExpand);

            return qzzzzzzzzzzzzzj_;
        };
        IEnumerable<int?> qzzzzzzzzzzzzzh_ = context.Operators.Select<CqlInterval<int?>, int?>(qzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzg_);
        IEnumerable<int?> qzzzzzzzzzzzzzi_ = context.Operators.Distinct<int?>(qzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> qzzzzzzzzzzzzzk_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? qzzzzzzzzzzzzzl_(int? DayIndex)
        {
            CqlDateTime qzzzzzzzzzzzzzo_ = context.Operators.Start(Period);
            CqlQuantity qzzzzzzzzzzzzzp_ = context.Operators.Quantity(24m, "hours");
            int? qzzzzzzzzzzzzzq_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity qzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToQuantity(qzzzzzzzzzzzzzq_);
            CqlQuantity qzzzzzzzzzzzzzs_ = context.Operators.Multiply(qzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzr_);
            CqlDateTime qzzzzzzzzzzzzzt_ = context.Operators.Add(qzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzs_);
            CqlDateTime qzzzzzzzzzzzzzu_()
            {
                bool qzzzzzzzzzzzzzx_()
                {
                    CqlDateTime qzzzzzzzzzzzzzy_ = context.Operators.Start(Period);
                    CqlQuantity qzzzzzzzzzzzzzz_ = context.Operators.Quantity(24m, "hours");
                    int? rzzzzzzzzzzzzza_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity rzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToQuantity(rzzzzzzzzzzzzza_);
                    CqlQuantity rzzzzzzzzzzzzzc_ = context.Operators.Multiply(qzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzb_);
                    CqlDateTime rzzzzzzzzzzzzzd_ = context.Operators.Add(qzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzc_);
                    CqlDateTime rzzzzzzzzzzzzze_ = context.Operators.End(Period);
                    int? rzzzzzzzzzzzzzf_ = context.Operators.DurationBetween(rzzzzzzzzzzzzzd_, rzzzzzzzzzzzzze_, "hour");
                    bool? rzzzzzzzzzzzzzg_ = context.Operators.Less(rzzzzzzzzzzzzzf_, 24);

                    return rzzzzzzzzzzzzzg_ ?? false;
                };
                if (qzzzzzzzzzzzzzx_())
                {
                    CqlDateTime rzzzzzzzzzzzzzh_ = context.Operators.Start(Period);
                    CqlQuantity rzzzzzzzzzzzzzi_ = context.Operators.Quantity(24m, "hours");
                    int? rzzzzzzzzzzzzzj_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity rzzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToQuantity(rzzzzzzzzzzzzzj_);
                    CqlQuantity rzzzzzzzzzzzzzl_ = context.Operators.Multiply(rzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzk_);
                    CqlDateTime rzzzzzzzzzzzzzm_ = context.Operators.Add(rzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzl_);

                    return rzzzzzzzzzzzzzm_;
                }
                else
                {
                    CqlDateTime rzzzzzzzzzzzzzn_ = context.Operators.Start(Period);
                    CqlQuantity rzzzzzzzzzzzzzo_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity rzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity rzzzzzzzzzzzzzq_ = context.Operators.Multiply(rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzp_);
                    CqlDateTime rzzzzzzzzzzzzzr_ = context.Operators.Add(rzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzq_);

                    return rzzzzzzzzzzzzzr_;
                }
            };
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzv_ = context.Operators.Interval(qzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzu_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? qzzzzzzzzzzzzzw_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, qzzzzzzzzzzzzzv_);

            return qzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> qzzzzzzzzzzzzzm_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(qzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> qzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(qzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzs_ = this.Initial_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? rzzzzzzzzzzzzzt_(Encounter PertinentEncounter)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzy_ = this.Crop_Interval_to_10_Days(context, rzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzza_ = this.Crop_Interval_to_10_Days(context, rzzzzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> szzzzzzzzzzzzzb_ = this.Days_In_Period(context, szzzzzzzzzzzzza_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? szzzzzzzzzzzzzc_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, rzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzy_, szzzzzzzzzzzzzb_);

            return szzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> rzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(rzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> rzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(rzzzzzzzzzzzzzu_);

        return rzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> szzzzzzzzzzzzzd_ = this.Pertinent_Encounters_With_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? szzzzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
        {
            Encounter szzzzzzzzzzzzzh_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzi_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> szzzzzzzzzzzzzj_ = PertinentEncounterDays?.relevantDays;
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? szzzzzzzzzzzzzk_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? szzzzzzzzzzzzzo_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzp_ = EncounterDay?.dayPeriod;
                CqlValueSet szzzzzzzzzzzzzq_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> szzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? szzzzzzzzzzzzzs_(Observation BloodGlucoseLab1)
                {
                    Code<ObservationStatus> tzzzzzzzzzzzzzh_ = BloodGlucoseLab1?.StatusElement;
                    string tzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzzh_);
                    bool? tzzzzzzzzzzzzzj_ = context.Operators.Equal(tzzzzzzzzzzzzzi_, "final");
                    DataType tzzzzzzzzzzzzzk_ = BloodGlucoseLab1?.Value;
                    CqlQuantity tzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzzzzzzzzzzzzzk_ as Quantity);
                    CqlQuantity tzzzzzzzzzzzzzm_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? tzzzzzzzzzzzzzn_ = context.Operators.Greater(tzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzm_);
                    bool? tzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzn_);
                    DataType tzzzzzzzzzzzzzp_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime tzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, tzzzzzzzzzzzzzp_ as FhirDateTime);
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzzr_ = EncounterDay?.dayPeriod;
                    bool? tzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzr_, default);
                    bool? tzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzs_);

                    return tzzzzzzzzzzzzzt_;
                };
                IEnumerable<Observation> szzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzr_, szzzzzzzzzzzzzs_);
                bool? szzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzt_);
                IEnumerable<Observation> szzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? szzzzzzzzzzzzzx_(Observation BloodGlucoseLab2)
                {
                    Code<ObservationStatus> tzzzzzzzzzzzzzu_ = BloodGlucoseLab2?.StatusElement;
                    string tzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzzu_);
                    bool? tzzzzzzzzzzzzzw_ = context.Operators.Equal(tzzzzzzzzzzzzzv_, "final");
                    DataType tzzzzzzzzzzzzzx_ = BloodGlucoseLab2?.Value;
                    CqlQuantity tzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzzzzzzzzzzzzzx_ as Quantity);
                    CqlQuantity tzzzzzzzzzzzzzz_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? uzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzz_);
                    bool? uzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzw_, uzzzzzzzzzzzzza_);
                    DataType uzzzzzzzzzzzzzc_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime uzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzzzzzzzzc_ as FhirDateTime);
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzze_ = EncounterDay?.dayPeriod;
                    bool? uzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzd_, uzzzzzzzzzzzzze_, default);
                    bool? uzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzf_);

                    return uzzzzzzzzzzzzzg_;
                };
                IEnumerable<Observation> szzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzw_, szzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(szzzzzzzzzzzzzy_);
                IEnumerable<Observation> tzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? tzzzzzzzzzzzzzc_(Observation BloodGlucoseLab3)
                {
                    Code<ObservationStatus> uzzzzzzzzzzzzzh_ = BloodGlucoseLab3?.StatusElement;
                    string uzzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzzh_);
                    bool? uzzzzzzzzzzzzzj_ = context.Operators.Equal(uzzzzzzzzzzzzzi_, "final");
                    DataType uzzzzzzzzzzzzzk_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime uzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, uzzzzzzzzzzzzzk_ as FhirDateTime);
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzm_ = EncounterDay?.dayPeriod;
                    bool? uzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzm_, default);
                    bool? uzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzn_);

                    return uzzzzzzzzzzzzzo_;
                };
                IEnumerable<Observation> tzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzc_);
                bool? tzzzzzzzzzzzzze_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzf_ = context.Operators.Not(tzzzzzzzzzzzzze_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? tzzzzzzzzzzzzzg_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, szzzzzzzzzzzzzo_, szzzzzzzzzzzzzp_, szzzzzzzzzzzzzu_, szzzzzzzzzzzzzz_, tzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> szzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(szzzzzzzzzzzzzj_, szzzzzzzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> szzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(szzzzzzzzzzzzzl_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? szzzzzzzzzzzzzn_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, szzzzzzzzzzzzzh_, szzzzzzzzzzzzzi_, szzzzzzzzzzzzzm_);

            return szzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> szzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(szzzzzzzzzzzzzd_, szzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> szzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(szzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> uzzzzzzzzzzzzzp_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? uzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter uzzzzzzzzzzzzzt_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzu_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> uzzzzzzzzzzzzzv_ = EncounterWithResultDays?.relevantDays;
            bool? uzzzzzzzzzzzzzw_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? vzzzzzzzzzzzzzc_ = EncounterDay?.dayIndex;
                bool? vzzzzzzzzzzzzzd_ = context.Operators.Greater(vzzzzzzzzzzzzzc_, 1);

                return vzzzzzzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> uzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(uzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? uzzzzzzzzzzzzzy_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? vzzzzzzzzzzzzze_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzf_ = EncounterDay?.dayPeriod;
                bool? vzzzzzzzzzzzzzg_ = EncounterDay?.hasSevereResult;
                bool? vzzzzzzzzzzzzzh_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> vzzzzzzzzzzzzzi_ = EncounterWithResultDays?.relevantDays;
                int? vzzzzzzzzzzzzzk_ = context.Operators.Subtract(vzzzzzzzzzzzzze_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? vzzzzzzzzzzzzzl_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(vzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzk_);
                bool? vzzzzzzzzzzzzzm_ = vzzzzzzzzzzzzzl_?.hasElevatedResult;
                bool? vzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzm_);
                int? vzzzzzzzzzzzzzq_ = context.Operators.Subtract(vzzzzzzzzzzzzze_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? vzzzzzzzzzzzzzr_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(vzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzq_);
                bool? vzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzr_?.hasElevatedResult;
                bool? vzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzs_);
                bool? vzzzzzzzzzzzzzu_ = context.Operators.Or(vzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzt_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? vzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, vzzzzzzzzzzzzze_, vzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzu_);

                return vzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> uzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(uzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(uzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? vzzzzzzzzzzzzzb_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, uzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzu_, vzzzzzzzzzzzzza_);

            return vzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(uzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(uzzzzzzzzzzzzzr_);

        return uzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzw_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? vzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> wzzzzzzzzzzzzzc_ = EncounterWithEventDays?.eligibleEventDays;
            bool? wzzzzzzzzzzzzzd_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? wzzzzzzzzzzzzzg_ = EligibleEventDay?.hasHyperglycemicEvent;

                return wzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> wzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(wzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzd_);
            bool? wzzzzzzzzzzzzzf_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(wzzzzzzzzzzzzze_);

            return wzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzx_);
        Encounter vzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter wzzzzzzzzzzzzzh_ = EncounterWithEventDays?.encounter;

            return wzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(vzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzi_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? wzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter wzzzzzzzzzzzzzp_ = EncounterWithEventDays?.encounter;
            bool? wzzzzzzzzzzzzzq_ = context.Operators.Equal(wzzzzzzzzzzzzzp_, QualifyingEncounter);

            return wzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(wzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzj_);
        int? wzzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> wzzzzzzzzzzzzzr_ = EncounterWithEventDays?.eligibleEventDays;
            int? wzzzzzzzzzzzzzs_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(wzzzzzzzzzzzzzr_);

            return wzzzzzzzzzzzzzs_;
        };
        IEnumerable<int?> wzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(wzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzl_);
        IEnumerable<int?> wzzzzzzzzzzzzzn_ = context.Operators.Distinct<int?>(wzzzzzzzzzzzzzm_);
        int? wzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<int?>(wzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzt_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? wzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter xzzzzzzzzzzzzza_ = EncounterWithEventDays?.encounter;
            bool? xzzzzzzzzzzzzzb_ = context.Operators.Equal(xzzzzzzzzzzzzza_, QualifyingEncounter);

            return xzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(wzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzu_);
        int? wzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> xzzzzzzzzzzzzzc_ = EncounterWithEventDays?.eligibleEventDays;
            bool? xzzzzzzzzzzzzzd_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? xzzzzzzzzzzzzzg_ = EligibleEventDay?.hasHyperglycemicEvent;

                return xzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> xzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(xzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzd_);
            int? xzzzzzzzzzzzzzf_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(xzzzzzzzzzzzzze_);

            return xzzzzzzzzzzzzzf_;
        };
        IEnumerable<int?> wzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(wzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzw_);
        IEnumerable<int?> wzzzzzzzzzzzzzy_ = context.Operators.Distinct<int?>(wzzzzzzzzzzzzzx_);
        int? wzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<int?>(wzzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["EncounterWithHospitalization", "HypoglycemicMedication"]);

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoResult"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    #endregion CqlTupleMetadata Properties

}
