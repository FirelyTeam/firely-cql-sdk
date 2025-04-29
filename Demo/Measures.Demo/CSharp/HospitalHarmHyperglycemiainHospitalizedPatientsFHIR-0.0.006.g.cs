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
        object azzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzt_);

        return azzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzz_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        return bzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            Patient bzzzzzzzzzzzzzzzzze_ = this.Patient(context);
            Date bzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzze_?.BirthDateElement;
            string bzzzzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDateTime bzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDateTime(bzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime bzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzi_);
            int? bzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzj_, "year");
            bool? bzzzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzk_, 18);

            return bzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? bzzzzzzzzzzzzzzzzzn_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? bzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, bzzzzzzzzzzzzzzzzzq_);

            return bzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet bzzzzzzzzzzzzzzzzzy_ = this.Diabetes(context);
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? czzzzzzzzzzzzzzzzza_(Condition DiabetesDiagnosis)
            {
                CodeableConcept czzzzzzzzzzzzzzzzze_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept czzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, czzzzzzzzzzzzzzzzze_);
                CqlCode czzzzzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept czzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzg_);
                bool? czzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime czzzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzl_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime czzzzzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzzzzl_);
                bool? czzzzzzzzzzzzzzzzzn_ = context.Operators.Before(czzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzm_, default);
                bool? czzzzzzzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzn_);

                return czzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? czzzzzzzzzzzzzzzzzc_(Condition DiabetesDiagnosis) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(czzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzc_);

            return czzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzt_);
        Encounter bzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter czzzzzzzzzzzzzzzzzp_ = EncounterWithHospitalization?.encounter;

            return czzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(bzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzzzzzzzq_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet czzzzzzzzzzzzzzzzzr_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationAdministration>(czzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzu_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> czzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(czzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? czzzzzzzzzzzzzzzzzx_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? dzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> czzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(czzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzzzzzzzf_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string dzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzzzzzzzf_);
            bool? dzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzg_, "completed");
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzi_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType dzzzzzzzzzzzzzzzzzj_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzzzzj_);
            bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzk_, default);
            bool? dzzzzzzzzzzzzzzzzzm_ = context.Operators.And(dzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzl_);

            return dzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> dzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(czzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzz_);
        Encounter dzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Encounter dzzzzzzzzzzzzzzzzzn_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

            return dzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(dzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(dzzzzzzzzzzzzzzzzzc_);

        return dzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet dzzzzzzzzzzzzzzzzzu_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            bool? dzzzzzzzzzzzzzzzzzw_(Observation BloodGlucoseLab)
            {
                DataType ezzzzzzzzzzzzzzzzza_ = BloodGlucoseLab?.Effective;
                CqlDateTime ezzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzzzzzzza_ as FhirDateTime);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzc_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? ezzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzze_ = BloodGlucoseLab?.StatusElement;
                string ezzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzzzze_);
                bool? ezzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzf_, "final");
                bool? ezzzzzzzzzzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzg_);
                DataType ezzzzzzzzzzzzzzzzzi_ = BloodGlucoseLab?.Value;
                CqlQuantity ezzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzi_ as Quantity);
                CqlQuantity ezzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(200m, "mg/dL");
                bool? ezzzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzk_);
                bool? ezzzzzzzzzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzl_);

                return ezzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? dzzzzzzzzzzzzzzzzzy_(Observation BloodGlucoseLab) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(dzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzy_);

            return dzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(dzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzp_);
        Encounter dzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter ezzzzzzzzzzzzzzzzzn_ = EncounterWithHospitalization?.encounter;

            return ezzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(dzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(dzzzzzzzzzzzzzzzzzs_);

        return dzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzu_ = context.Operators.Start(Period);
        CqlDateTime ezzzzzzzzzzzzzzzzzv_ = context.Operators.End(Period);
        CqlQuantity ezzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(10m, "days");
        CqlDateTime ezzzzzzzzzzzzzzzzzy_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzx_);
        CqlDateTime[] ezzzzzzzzzzzzzzzzzz_ = [
            ezzzzzzzzzzzzzzzzzv_,
            ezzzzzzzzzzzzzzzzzy_,
        ];
        CqlDateTime fzzzzzzzzzzzzzzzzza_ = context.Operators.Min<CqlDateTime>(ezzzzzzzzzzzzzzzzzz_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzza_, true, true);

        return fzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime fzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(Period);
        CqlDateTime fzzzzzzzzzzzzzzzzzd_ = context.Operators.End(Period);
        int? fzzzzzzzzzzzzzzzzze_ = context.Operators.DurationBetween(fzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzd_, "day");
        CqlInterval<int?> fzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(1, fzzzzzzzzzzzzzzzzze_, true, true);
        CqlInterval<int?>[] fzzzzzzzzzzzzzzzzzg_ = [
            fzzzzzzzzzzzzzzzzzf_,
        ];
        IEnumerable<CqlInterval<int?>> fzzzzzzzzzzzzzzzzzh_ = context.Operators.Expand(fzzzzzzzzzzzzzzzzzg_ as IEnumerable<CqlInterval<int?>>, default);
        int? fzzzzzzzzzzzzzzzzzi_(CqlInterval<int?> DayExpand)
        {
            int? fzzzzzzzzzzzzzzzzzl_ = context.Operators.End(DayExpand);

            return fzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<int?> fzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CqlInterval<int?>, int?>(fzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzi_);
        IEnumerable<int?> fzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<int?>(fzzzzzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> fzzzzzzzzzzzzzzzzzm_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? fzzzzzzzzzzzzzzzzzn_(int? DayIndex)
        {
            CqlDateTime fzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(Period);
            CqlQuantity fzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
            int? fzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity fzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertIntegerToQuantity(fzzzzzzzzzzzzzzzzzs_);
            CqlQuantity fzzzzzzzzzzzzzzzzzu_ = context.Operators.Multiply(fzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzt_);
            CqlDateTime fzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzu_);
            CqlDateTime fzzzzzzzzzzzzzzzzzw_()
            {
                bool fzzzzzzzzzzzzzzzzzz_()
                {
                    CqlDateTime gzzzzzzzzzzzzzzzzza_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(24m, "hours");
                    int? gzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity gzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToQuantity(gzzzzzzzzzzzzzzzzzc_);
                    CqlQuantity gzzzzzzzzzzzzzzzzze_ = context.Operators.Multiply(gzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzd_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(gzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzze_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzg_ = context.Operators.End(Period);
                    int? gzzzzzzzzzzzzzzzzzh_ = context.Operators.DurationBetween(gzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzg_, "hour");
                    bool? gzzzzzzzzzzzzzzzzzi_ = context.Operators.Less(gzzzzzzzzzzzzzzzzzh_, 24);

                    return gzzzzzzzzzzzzzzzzzi_ ?? false;
                };
                if (fzzzzzzzzzzzzzzzzzz_())
                {
                    CqlDateTime gzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(24m, "hours");
                    int? gzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity gzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertIntegerToQuantity(gzzzzzzzzzzzzzzzzzl_);
                    CqlQuantity gzzzzzzzzzzzzzzzzzn_ = context.Operators.Multiply(gzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzm_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzn_);

                    return gzzzzzzzzzzzzzzzzzo_;
                }
                else
                {
                    CqlDateTime gzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity gzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity gzzzzzzzzzzzzzzzzzs_ = context.Operators.Multiply(gzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzs_);

                    return gzzzzzzzzzzzzzzzzzt_;
                }
            };
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzw_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? fzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, fzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(fzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(fzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzu_ = this.Initial_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? gzzzzzzzzzzzzzzzzzv_(Encounter PertinentEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzza_ = this.Crop_Interval_to_10_Days(context, gzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzc_ = this.Crop_Interval_to_10_Days(context, gzzzzzzzzzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> hzzzzzzzzzzzzzzzzzd_ = this.Days_In_Period(context, hzzzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? hzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, gzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzd_);

            return hzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> gzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> gzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzw_);

        return gzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> hzzzzzzzzzzzzzzzzzf_ = this.Pertinent_Encounters_With_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? hzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
        {
            Encounter hzzzzzzzzzzzzzzzzzj_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzk_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> hzzzzzzzzzzzzzzzzzl_ = PertinentEncounterDays?.relevantDays;
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? hzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? hzzzzzzzzzzzzzzzzzq_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzr_ = EncounterDay?.dayPeriod;
                CqlValueSet hzzzzzzzzzzzzzzzzzs_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? hzzzzzzzzzzzzzzzzzu_(Observation BloodGlucoseLab1)
                {
                    Code<ObservationStatus> izzzzzzzzzzzzzzzzzj_ = BloodGlucoseLab1?.StatusElement;
                    string izzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzzj_);
                    bool? izzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzk_, "final");
                    DataType izzzzzzzzzzzzzzzzzm_ = BloodGlucoseLab1?.Value;
                    CqlQuantity izzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzm_ as Quantity);
                    CqlQuantity izzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? izzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzo_);
                    bool? izzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzp_);
                    DataType izzzzzzzzzzzzzzzzzr_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime izzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, izzzzzzzzzzzzzzzzzr_ as FhirDateTime);
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzt_ = EncounterDay?.dayPeriod;
                    bool? izzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzt_, default);
                    bool? izzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzu_);

                    return izzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzv_);
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? hzzzzzzzzzzzzzzzzzz_(Observation BloodGlucoseLab2)
                {
                    Code<ObservationStatus> izzzzzzzzzzzzzzzzzw_ = BloodGlucoseLab2?.StatusElement;
                    string izzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzzzzzzw_);
                    bool? izzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzx_, "final");
                    DataType izzzzzzzzzzzzzzzzzz_ = BloodGlucoseLab2?.Value;
                    CqlQuantity jzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzzzzzzzzzzzzzzzz_ as Quantity);
                    CqlQuantity jzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? jzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzb_);
                    bool? jzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzc_);
                    DataType jzzzzzzzzzzzzzzzzze_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime jzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzzzze_ as FhirDateTime);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzg_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzg_, default);
                    bool? jzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzh_);

                    return jzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<Observation> izzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzz_);
                bool? izzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzza_);
                IEnumerable<Observation> izzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? izzzzzzzzzzzzzzzzze_(Observation BloodGlucoseLab3)
                {
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzj_ = BloodGlucoseLab3?.StatusElement;
                    string jzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzzzzj_);
                    bool? jzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzk_, "final");
                    DataType jzzzzzzzzzzzzzzzzzm_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime jzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzzzzzzzm_ as FhirDateTime);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzo_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzo_, default);
                    bool? jzzzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzp_);

                    return jzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Observation> izzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzzf_);
                bool? izzzzzzzzzzzzzzzzzh_ = context.Operators.Not(izzzzzzzzzzzzzzzzzg_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? izzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, hzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzh_);

                return izzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> hzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(hzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(hzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? hzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, hzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzo_);

            return hzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> hzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(hzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> hzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(hzzzzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> jzzzzzzzzzzzzzzzzzr_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? jzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter jzzzzzzzzzzzzzzzzzv_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzw_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> jzzzzzzzzzzzzzzzzzx_ = EncounterWithResultDays?.relevantDays;
            bool? jzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? kzzzzzzzzzzzzzzzzze_ = EncounterDay?.dayIndex;
                bool? kzzzzzzzzzzzzzzzzzf_ = context.Operators.Greater(kzzzzzzzzzzzzzzzzze_, 1);

                return kzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> jzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(jzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? kzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? kzzzzzzzzzzzzzzzzzg_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzh_ = EncounterDay?.dayPeriod;
                bool? kzzzzzzzzzzzzzzzzzi_ = EncounterDay?.hasSevereResult;
                bool? kzzzzzzzzzzzzzzzzzj_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> kzzzzzzzzzzzzzzzzzk_ = EncounterWithResultDays?.relevantDays;
                int? kzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzg_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? kzzzzzzzzzzzzzzzzzn_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzm_);
                bool? kzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzn_?.hasElevatedResult;
                bool? kzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzo_);
                int? kzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzg_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? kzzzzzzzzzzzzzzzzzt_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzs_);
                bool? kzzzzzzzzzzzzzzzzzu_ = kzzzzzzzzzzzzzzzzzt_?.hasElevatedResult;
                bool? kzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzu_);
                bool? kzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzv_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? kzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, kzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzw_);

                return kzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> kzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(jzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzza_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> kzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(kzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? kzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, jzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> jzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(jzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> jzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(jzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> kzzzzzzzzzzzzzzzzzy_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? kzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzzzzzzze_ = EncounterWithEventDays?.eligibleEventDays;
            bool? lzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? lzzzzzzzzzzzzzzzzzi_ = EligibleEventDay?.hasHyperglycemicEvent;

                return lzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(kzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzz_);
        Encounter lzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter lzzzzzzzzzzzzzzzzzj_ = EncounterWithEventDays?.encounter;

            return lzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(lzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzc_);

        return lzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzzzzzzzk_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? lzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter lzzzzzzzzzzzzzzzzzr_ = EncounterWithEventDays?.encounter;
            bool? lzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzr_, QualifyingEncounter);

            return lzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(lzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzl_);
        int? lzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzzzzzzzt_ = EncounterWithEventDays?.eligibleEventDays;
            int? lzzzzzzzzzzzzzzzzzu_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzzzzzzzt_);

            return lzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<int?> lzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(lzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzn_);
        IEnumerable<int?> lzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<int?>(lzzzzzzzzzzzzzzzzzo_);
        int? lzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<int?>(lzzzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzzzzzzzv_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? lzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter mzzzzzzzzzzzzzzzzzc_ = EncounterWithEventDays?.encounter;
            bool? mzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzc_, QualifyingEncounter);

            return mzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(lzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzw_);
        int? lzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzzzzzzze_ = EncounterWithEventDays?.eligibleEventDays;
            bool? mzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? mzzzzzzzzzzzzzzzzzi_ = EligibleEventDay?.hasHyperglycemicEvent;

                return mzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzf_);
            int? mzzzzzzzzzzzzzzzzzh_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzzzzzzzg_);

            return mzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<int?> lzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(lzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzy_);
        IEnumerable<int?> mzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<int?>(lzzzzzzzzzzzzzzzzzz_);
        int? mzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<int?>(mzzzzzzzzzzzzzzzzza_);

        return mzzzzzzzzzzzzzzzzzb_;
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
