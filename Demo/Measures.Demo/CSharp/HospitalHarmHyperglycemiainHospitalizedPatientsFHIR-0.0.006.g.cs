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
        object bzzzzzzzzzzzc_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzzd_);

        return bzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return bzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> bzzzzzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return bzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> bzzzzzzzzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return bzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return bzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzj_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> bzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        return bzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzl_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? bzzzzzzzzzzzm_(Encounter InpatientEncounter)
        {
            Patient bzzzzzzzzzzzo_ = this.Patient(context);
            Date bzzzzzzzzzzzp_ = bzzzzzzzzzzzo_?.BirthDateElement;
            string bzzzzzzzzzzzq_ = bzzzzzzzzzzzp_?.Value;
            CqlDateTime bzzzzzzzzzzzr_ = context.Operators.ConvertStringToDateTime(bzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime bzzzzzzzzzzzt_ = context.Operators.Start(bzzzzzzzzzzzs_);
            int? bzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzr_, bzzzzzzzzzzzt_, "year");
            bool? bzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzu_, 18);

            return bzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzl_, bzzzzzzzzzzzm_);

        return bzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? bzzzzzzzzzzzx_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? czzzzzzzzzzzb_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, czzzzzzzzzzza_);

            return czzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzw_, bzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzy_);

        return bzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzc_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzd_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet czzzzzzzzzzzi_ = this.Diabetes(context);
            IEnumerable<Condition> czzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? czzzzzzzzzzzk_(Condition DiabetesDiagnosis)
            {
                CodeableConcept czzzzzzzzzzzo_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept czzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, czzzzzzzzzzzo_);
                CqlCode czzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept czzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzq_);
                bool? czzzzzzzzzzzs_ = context.Operators.Equivalent(czzzzzzzzzzzp_, czzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime czzzzzzzzzzzu_ = context.Operators.Start(czzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzv_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime czzzzzzzzzzzw_ = context.Operators.End(czzzzzzzzzzzv_);
                bool? czzzzzzzzzzzx_ = context.Operators.Before(czzzzzzzzzzzu_, czzzzzzzzzzzw_, default);
                bool? czzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzs_, czzzzzzzzzzzx_);

                return czzzzzzzzzzzy_;
            };
            IEnumerable<Condition> czzzzzzzzzzzl_ = context.Operators.Where<Condition>(czzzzzzzzzzzj_, czzzzzzzzzzzk_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? czzzzzzzzzzzm_(Condition DiabetesDiagnosis) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzn_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(czzzzzzzzzzzl_, czzzzzzzzzzzm_);

            return czzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzze_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(czzzzzzzzzzzc_, czzzzzzzzzzzd_);
        Encounter czzzzzzzzzzzf_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter czzzzzzzzzzzz_ = EncounterWithHospitalization?.encounter;

            return czzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(czzzzzzzzzzze_, czzzzzzzzzzzf_);
        IEnumerable<Encounter> czzzzzzzzzzzh_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzzg_);

        return czzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzza_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet dzzzzzzzzzzzb_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, dzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> dzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, dzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> dzzzzzzzzzzzf_ = context.Operators.Union<MedicationAdministration>(dzzzzzzzzzzzc_, dzzzzzzzzzzze_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> dzzzzzzzzzzzg_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(dzzzzzzzzzzza_, dzzzzzzzzzzzf_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? dzzzzzzzzzzzh_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? dzzzzzzzzzzzo_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> dzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(dzzzzzzzzzzzg_, dzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> dzzzzzzzzzzzp_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string dzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzzzp_);
            bool? dzzzzzzzzzzzr_ = context.Operators.Equal(dzzzzzzzzzzzq_, "completed");
            CqlInterval<CqlDateTime> dzzzzzzzzzzzs_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType dzzzzzzzzzzzt_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzs_, dzzzzzzzzzzzu_, default);
            bool? dzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzr_, dzzzzzzzzzzzv_);

            return dzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> dzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(dzzzzzzzzzzzi_, dzzzzzzzzzzzj_);
        Encounter dzzzzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Encounter dzzzzzzzzzzzx_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

            return dzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(dzzzzzzzzzzzk_, dzzzzzzzzzzzl_);
        IEnumerable<Encounter> dzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(dzzzzzzzzzzzm_);

        return dzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzy_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> dzzzzzzzzzzzz_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet ezzzzzzzzzzze_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> ezzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            bool? ezzzzzzzzzzzg_(Observation BloodGlucoseLab)
            {
                DataType ezzzzzzzzzzzk_ = BloodGlucoseLab?.Effective;
                CqlDateTime ezzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ezzzzzzzzzzzk_ as FhirDateTime);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzm_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? ezzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzl_, ezzzzzzzzzzzm_, default);
                Code<ObservationStatus> ezzzzzzzzzzzo_ = BloodGlucoseLab?.StatusElement;
                string ezzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzo_);
                bool? ezzzzzzzzzzzq_ = context.Operators.Equal(ezzzzzzzzzzzp_, "final");
                bool? ezzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzn_, ezzzzzzzzzzzq_);
                DataType ezzzzzzzzzzzs_ = BloodGlucoseLab?.Value;
                CqlQuantity ezzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzzzzzzzs_ as Quantity);
                CqlQuantity ezzzzzzzzzzzu_ = context.Operators.Quantity(200m, "mg/dL");
                bool? ezzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzt_, ezzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzr_, ezzzzzzzzzzzv_);

                return ezzzzzzzzzzzw_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzh_ = context.Operators.Where<Observation>(ezzzzzzzzzzzf_, ezzzzzzzzzzzg_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? ezzzzzzzzzzzi_(Observation BloodGlucoseLab) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzzzj_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(ezzzzzzzzzzzh_, ezzzzzzzzzzzi_);

            return ezzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> ezzzzzzzzzzza_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(dzzzzzzzzzzzy_, dzzzzzzzzzzzz_);
        Encounter ezzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter ezzzzzzzzzzzx_ = EncounterWithHospitalization?.encounter;

            return ezzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(ezzzzzzzzzzza_, ezzzzzzzzzzzb_);
        IEnumerable<Encounter> ezzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzzc_);

        return ezzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzy_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> ezzzzzzzzzzzz_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> fzzzzzzzzzzza_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzy_, ezzzzzzzzzzzz_);
        IEnumerable<Encounter> fzzzzzzzzzzzb_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> fzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(fzzzzzzzzzzza_, fzzzzzzzzzzzb_);

        return fzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzd_ = this.Initial_Population(context);

        return fzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime fzzzzzzzzzzze_ = context.Operators.Start(Period);
        CqlDateTime fzzzzzzzzzzzf_ = context.Operators.End(Period);
        CqlQuantity fzzzzzzzzzzzh_ = context.Operators.Quantity(10m, "days");
        CqlDateTime fzzzzzzzzzzzi_ = context.Operators.Add(fzzzzzzzzzzze_, fzzzzzzzzzzzh_);
        CqlDateTime[] fzzzzzzzzzzzj_ = [
            fzzzzzzzzzzzf_,
            fzzzzzzzzzzzi_,
        ];
        CqlDateTime fzzzzzzzzzzzk_ = context.Operators.Min<CqlDateTime>(fzzzzzzzzzzzj_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzl_ = context.Operators.Interval(fzzzzzzzzzzze_, fzzzzzzzzzzzk_, true, true);

        return fzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime fzzzzzzzzzzzm_ = context.Operators.Start(Period);
        CqlDateTime fzzzzzzzzzzzn_ = context.Operators.End(Period);
        int? fzzzzzzzzzzzo_ = context.Operators.DurationBetween(fzzzzzzzzzzzm_, fzzzzzzzzzzzn_, "day");
        CqlInterval<int?> fzzzzzzzzzzzp_ = context.Operators.Interval(1, fzzzzzzzzzzzo_, true, true);
        CqlInterval<int?>[] fzzzzzzzzzzzq_ = [
            fzzzzzzzzzzzp_,
        ];
        IEnumerable<CqlInterval<int?>> fzzzzzzzzzzzr_ = context.Operators.Expand(fzzzzzzzzzzzq_ as IEnumerable<CqlInterval<int?>>, default);
        int? fzzzzzzzzzzzs_(CqlInterval<int?> DayExpand)
        {
            int? fzzzzzzzzzzzv_ = context.Operators.End(DayExpand);

            return fzzzzzzzzzzzv_;
        };
        IEnumerable<int?> fzzzzzzzzzzzt_ = context.Operators.Select<CqlInterval<int?>, int?>(fzzzzzzzzzzzr_, fzzzzzzzzzzzs_);
        IEnumerable<int?> fzzzzzzzzzzzu_ = context.Operators.Distinct<int?>(fzzzzzzzzzzzt_);

        return fzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> fzzzzzzzzzzzw_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? fzzzzzzzzzzzx_(int? DayIndex)
        {
            CqlDateTime gzzzzzzzzzzza_ = context.Operators.Start(Period);
            CqlQuantity gzzzzzzzzzzzb_ = context.Operators.Quantity(24m, "hours");
            int? gzzzzzzzzzzzc_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity gzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToQuantity(gzzzzzzzzzzzc_);
            CqlQuantity gzzzzzzzzzzze_ = context.Operators.Multiply(gzzzzzzzzzzzb_, gzzzzzzzzzzzd_);
            CqlDateTime gzzzzzzzzzzzf_ = context.Operators.Add(gzzzzzzzzzzza_, gzzzzzzzzzzze_);
            CqlDateTime gzzzzzzzzzzzg_()
            {
                bool gzzzzzzzzzzzj_()
                {
                    CqlDateTime gzzzzzzzzzzzk_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                    int? gzzzzzzzzzzzm_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity gzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToQuantity(gzzzzzzzzzzzm_);
                    CqlQuantity gzzzzzzzzzzzo_ = context.Operators.Multiply(gzzzzzzzzzzzl_, gzzzzzzzzzzzn_);
                    CqlDateTime gzzzzzzzzzzzp_ = context.Operators.Add(gzzzzzzzzzzzk_, gzzzzzzzzzzzo_);
                    CqlDateTime gzzzzzzzzzzzq_ = context.Operators.End(Period);
                    int? gzzzzzzzzzzzr_ = context.Operators.DurationBetween(gzzzzzzzzzzzp_, gzzzzzzzzzzzq_, "hour");
                    bool? gzzzzzzzzzzzs_ = context.Operators.Less(gzzzzzzzzzzzr_, 24);

                    return gzzzzzzzzzzzs_ ?? false;
                };
                if (gzzzzzzzzzzzj_())
                {
                    CqlDateTime gzzzzzzzzzzzt_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzu_ = context.Operators.Quantity(24m, "hours");
                    int? gzzzzzzzzzzzv_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity gzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToQuantity(gzzzzzzzzzzzv_);
                    CqlQuantity gzzzzzzzzzzzx_ = context.Operators.Multiply(gzzzzzzzzzzzu_, gzzzzzzzzzzzw_);
                    CqlDateTime gzzzzzzzzzzzy_ = context.Operators.Add(gzzzzzzzzzzzt_, gzzzzzzzzzzzx_);

                    return gzzzzzzzzzzzy_;
                }
                else
                {
                    CqlDateTime gzzzzzzzzzzzz_ = context.Operators.Start(Period);
                    CqlQuantity hzzzzzzzzzzza_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity hzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity hzzzzzzzzzzzc_ = context.Operators.Multiply(hzzzzzzzzzzza_, hzzzzzzzzzzzb_);
                    CqlDateTime hzzzzzzzzzzzd_ = context.Operators.Add(gzzzzzzzzzzzz_, hzzzzzzzzzzzc_);

                    return hzzzzzzzzzzzd_;
                }
            };
            CqlInterval<CqlDateTime> gzzzzzzzzzzzh_ = context.Operators.Interval(gzzzzzzzzzzzf_, gzzzzzzzzzzzg_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? gzzzzzzzzzzzi_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, gzzzzzzzzzzzh_);

            return gzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzy_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(fzzzzzzzzzzzw_, fzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(fzzzzzzzzzzzy_);

        return fzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzze_ = this.Initial_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? hzzzzzzzzzzzf_(Encounter PertinentEncounter)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzk_ = this.Crop_Interval_to_10_Days(context, hzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzm_ = this.Crop_Interval_to_10_Days(context, hzzzzzzzzzzzi_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> hzzzzzzzzzzzn_ = this.Days_In_Period(context, hzzzzzzzzzzzm_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? hzzzzzzzzzzzo_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, hzzzzzzzzzzzi_, hzzzzzzzzzzzk_, hzzzzzzzzzzzn_);

            return hzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> hzzzzzzzzzzzg_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(hzzzzzzzzzzze_, hzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> hzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(hzzzzzzzzzzzg_);

        return hzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> hzzzzzzzzzzzp_ = this.Pertinent_Encounters_With_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? hzzzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
        {
            Encounter hzzzzzzzzzzzt_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzu_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> hzzzzzzzzzzzv_ = PertinentEncounterDays?.relevantDays;
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? hzzzzzzzzzzzw_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? izzzzzzzzzzza_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> izzzzzzzzzzzb_ = EncounterDay?.dayPeriod;
                CqlValueSet izzzzzzzzzzzc_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> izzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? izzzzzzzzzzze_(Observation BloodGlucoseLab1)
                {
                    Code<ObservationStatus> izzzzzzzzzzzt_ = BloodGlucoseLab1?.StatusElement;
                    string izzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzt_);
                    bool? izzzzzzzzzzzv_ = context.Operators.Equal(izzzzzzzzzzzu_, "final");
                    DataType izzzzzzzzzzzw_ = BloodGlucoseLab1?.Value;
                    CqlQuantity izzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzzzzzzzzzw_ as Quantity);
                    CqlQuantity izzzzzzzzzzzy_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? izzzzzzzzzzzz_ = context.Operators.Greater(izzzzzzzzzzzx_, izzzzzzzzzzzy_);
                    bool? jzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzv_, izzzzzzzzzzzz_);
                    DataType jzzzzzzzzzzzb_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime jzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzb_ as FhirDateTime);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzd_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_, default);
                    bool? jzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzza_, jzzzzzzzzzzze_);

                    return jzzzzzzzzzzzf_;
                };
                IEnumerable<Observation> izzzzzzzzzzzf_ = context.Operators.Where<Observation>(izzzzzzzzzzzd_, izzzzzzzzzzze_);
                bool? izzzzzzzzzzzg_ = context.Operators.Exists<Observation>(izzzzzzzzzzzf_);
                IEnumerable<Observation> izzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? izzzzzzzzzzzj_(Observation BloodGlucoseLab2)
                {
                    Code<ObservationStatus> jzzzzzzzzzzzg_ = BloodGlucoseLab2?.StatusElement;
                    string jzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzg_);
                    bool? jzzzzzzzzzzzi_ = context.Operators.Equal(jzzzzzzzzzzzh_, "final");
                    DataType jzzzzzzzzzzzj_ = BloodGlucoseLab2?.Value;
                    CqlQuantity jzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, jzzzzzzzzzzzj_ as Quantity);
                    CqlQuantity jzzzzzzzzzzzl_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? jzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzk_, jzzzzzzzzzzzl_);
                    bool? jzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzi_, jzzzzzzzzzzzm_);
                    DataType jzzzzzzzzzzzo_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime jzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzo_ as FhirDateTime);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzq_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzp_, jzzzzzzzzzzzq_, default);
                    bool? jzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzn_, jzzzzzzzzzzzr_);

                    return jzzzzzzzzzzzs_;
                };
                IEnumerable<Observation> izzzzzzzzzzzk_ = context.Operators.Where<Observation>(izzzzzzzzzzzi_, izzzzzzzzzzzj_);
                bool? izzzzzzzzzzzl_ = context.Operators.Exists<Observation>(izzzzzzzzzzzk_);
                IEnumerable<Observation> izzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? izzzzzzzzzzzo_(Observation BloodGlucoseLab3)
                {
                    Code<ObservationStatus> jzzzzzzzzzzzt_ = BloodGlucoseLab3?.StatusElement;
                    string jzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzt_);
                    bool? jzzzzzzzzzzzv_ = context.Operators.Equal(jzzzzzzzzzzzu_, "final");
                    DataType jzzzzzzzzzzzw_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime jzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, jzzzzzzzzzzzw_ as FhirDateTime);
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzy_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzx_, jzzzzzzzzzzzy_, default);
                    bool? kzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzv_, jzzzzzzzzzzzz_);

                    return kzzzzzzzzzzza_;
                };
                IEnumerable<Observation> izzzzzzzzzzzp_ = context.Operators.Where<Observation>(izzzzzzzzzzzn_, izzzzzzzzzzzo_);
                bool? izzzzzzzzzzzq_ = context.Operators.Exists<Observation>(izzzzzzzzzzzp_);
                bool? izzzzzzzzzzzr_ = context.Operators.Not(izzzzzzzzzzzq_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? izzzzzzzzzzzs_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, izzzzzzzzzzza_, izzzzzzzzzzzb_, izzzzzzzzzzzg_, izzzzzzzzzzzl_, izzzzzzzzzzzr_);

                return izzzzzzzzzzzs_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> hzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(hzzzzzzzzzzzv_, hzzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> hzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(hzzzzzzzzzzzx_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? hzzzzzzzzzzzz_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, hzzzzzzzzzzzt_, hzzzzzzzzzzzu_, hzzzzzzzzzzzy_);

            return hzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> hzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(hzzzzzzzzzzzp_, hzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> hzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(hzzzzzzzzzzzr_);

        return hzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> kzzzzzzzzzzzb_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? kzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter kzzzzzzzzzzzf_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzg_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> kzzzzzzzzzzzh_ = EncounterWithResultDays?.relevantDays;
            bool? kzzzzzzzzzzzi_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? kzzzzzzzzzzzo_ = EncounterDay?.dayIndex;
                bool? kzzzzzzzzzzzp_ = context.Operators.Greater(kzzzzzzzzzzzo_, 1);

                return kzzzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> kzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(kzzzzzzzzzzzh_, kzzzzzzzzzzzi_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? kzzzzzzzzzzzk_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? kzzzzzzzzzzzq_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzr_ = EncounterDay?.dayPeriod;
                bool? kzzzzzzzzzzzs_ = EncounterDay?.hasSevereResult;
                bool? kzzzzzzzzzzzt_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> kzzzzzzzzzzzu_ = EncounterWithResultDays?.relevantDays;
                int? kzzzzzzzzzzzw_ = context.Operators.Subtract(kzzzzzzzzzzzq_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? kzzzzzzzzzzzx_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(kzzzzzzzzzzzu_, kzzzzzzzzzzzw_);
                bool? kzzzzzzzzzzzy_ = kzzzzzzzzzzzx_?.hasElevatedResult;
                bool? kzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzt_, kzzzzzzzzzzzy_);
                int? lzzzzzzzzzzzc_ = context.Operators.Subtract(kzzzzzzzzzzzq_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? lzzzzzzzzzzzd_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(kzzzzzzzzzzzu_, lzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzze_ = lzzzzzzzzzzzd_?.hasElevatedResult;
                bool? lzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzz_, lzzzzzzzzzzze_);
                bool? lzzzzzzzzzzzg_ = context.Operators.Or(kzzzzzzzzzzzs_, lzzzzzzzzzzzf_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? lzzzzzzzzzzzh_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, kzzzzzzzzzzzq_, kzzzzzzzzzzzr_, lzzzzzzzzzzzg_);

                return lzzzzzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> kzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(kzzzzzzzzzzzj_, kzzzzzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> kzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(kzzzzzzzzzzzl_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? kzzzzzzzzzzzn_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, kzzzzzzzzzzzf_, kzzzzzzzzzzzg_, kzzzzzzzzzzzm_);

            return kzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> kzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(kzzzzzzzzzzzb_, kzzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> kzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(kzzzzzzzzzzzd_);

        return kzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzi_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? lzzzzzzzzzzzj_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzo_ = EncounterWithEventDays?.eligibleEventDays;
            bool? lzzzzzzzzzzzp_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? lzzzzzzzzzzzs_ = EligibleEventDay?.hasHyperglycemicEvent;

                return lzzzzzzzzzzzs_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzo_, lzzzzzzzzzzzp_);
            bool? lzzzzzzzzzzzr_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzq_);

            return lzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(lzzzzzzzzzzzi_, lzzzzzzzzzzzj_);
        Encounter lzzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter lzzzzzzzzzzzt_ = EncounterWithEventDays?.encounter;

            return lzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(lzzzzzzzzzzzk_, lzzzzzzzzzzzl_);
        IEnumerable<Encounter> lzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzm_);

        return lzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzu_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? lzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter mzzzzzzzzzzzb_ = EncounterWithEventDays?.encounter;
            bool? mzzzzzzzzzzzc_ = context.Operators.Equal(mzzzzzzzzzzzb_, QualifyingEncounter);

            return mzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> lzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(lzzzzzzzzzzzu_, lzzzzzzzzzzzv_);
        int? lzzzzzzzzzzzx_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzd_ = EncounterWithEventDays?.eligibleEventDays;
            int? mzzzzzzzzzzze_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzd_);

            return mzzzzzzzzzzze_;
        };
        IEnumerable<int?> lzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(lzzzzzzzzzzzw_, lzzzzzzzzzzzx_);
        IEnumerable<int?> lzzzzzzzzzzzz_ = context.Operators.Distinct<int?>(lzzzzzzzzzzzy_);
        int? mzzzzzzzzzzza_ = context.Operators.SingletonFrom<int?>(lzzzzzzzzzzzz_);

        return mzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> mzzzzzzzzzzzf_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? mzzzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter mzzzzzzzzzzzm_ = EncounterWithEventDays?.encounter;
            bool? mzzzzzzzzzzzn_ = context.Operators.Equal(mzzzzzzzzzzzm_, QualifyingEncounter);

            return mzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> mzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(mzzzzzzzzzzzf_, mzzzzzzzzzzzg_);
        int? mzzzzzzzzzzzi_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzo_ = EncounterWithEventDays?.eligibleEventDays;
            bool? mzzzzzzzzzzzp_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? mzzzzzzzzzzzs_ = EligibleEventDay?.hasHyperglycemicEvent;

                return mzzzzzzzzzzzs_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzo_, mzzzzzzzzzzzp_);
            int? mzzzzzzzzzzzr_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzq_);

            return mzzzzzzzzzzzr_;
        };
        IEnumerable<int?> mzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(mzzzzzzzzzzzh_, mzzzzzzzzzzzi_);
        IEnumerable<int?> mzzzzzzzzzzzk_ = context.Operators.Distinct<int?>(mzzzzzzzzzzzj_);
        int? mzzzzzzzzzzzl_ = context.Operators.SingletonFrom<int?>(mzzzzzzzzzzzk_);

        return mzzzzzzzzzzzl_;
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
