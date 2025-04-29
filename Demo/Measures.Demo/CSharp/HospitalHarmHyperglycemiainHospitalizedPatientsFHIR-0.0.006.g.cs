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

    #region ValueSet: birth date
    [CqlValueSetDefinition(
        definitionName: "birth date",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4",
        valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext context) => _birth_date;

    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);
    #endregion

    #region ValueSet: Diabetes
    [CqlValueSetDefinition(
        definitionName: "Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext context) => _Diabetes;

    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);
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

    #region ValueSet: Hypoglycemics Treatment Medications
    [CqlValueSetDefinition(
        definitionName: "Hypoglycemics Treatment Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394",
        valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext context) => _Hypoglycemics_Treatment_Medications;

    private static readonly CqlValueSet _Hypoglycemics_Treatment_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);
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
        CqlCode[] hzzzzzzzzzzzzzw_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return hzzzzzzzzzzzzzw_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object hzzzzzzzzzzzzzx_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzy_);

        return hzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> izzzzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        return izzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzg_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? izzzzzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            Patient izzzzzzzzzzzzzj_ = this.Patient(context);
            Date izzzzzzzzzzzzzk_ = izzzzzzzzzzzzzj_?.BirthDateElement;
            string izzzzzzzzzzzzzl_ = izzzzzzzzzzzzzk_?.Value;
            CqlDateTime izzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDateTime(izzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime izzzzzzzzzzzzzo_ = context.Operators.Start(izzzzzzzzzzzzzn_);
            int? izzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzm_, izzzzzzzzzzzzzo_, "year");
            bool? izzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzp_, 18);

            return izzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzg_, izzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzr_ = this.Qualifying_Encounters(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? izzzzzzzzzzzzzs_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? izzzzzzzzzzzzzw_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, izzzzzzzzzzzzzv_);

            return izzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzr_, izzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzt_);

        return izzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzx_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet jzzzzzzzzzzzzzd_ = this.Diabetes(context);
            IEnumerable<Condition> jzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? jzzzzzzzzzzzzzf_(Condition DiabetesDiagnosis)
            {
                CodeableConcept jzzzzzzzzzzzzzj_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept jzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, jzzzzzzzzzzzzzj_);
                CqlCode jzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept jzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(jzzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzzn_ = context.Operators.Equivalent(jzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime jzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzq_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime jzzzzzzzzzzzzzr_ = context.Operators.End(jzzzzzzzzzzzzzq_);
                bool? jzzzzzzzzzzzzzs_ = context.Operators.Before(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzr_, default);
                bool? jzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzs_);

                return jzzzzzzzzzzzzzt_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzze_, jzzzzzzzzzzzzzf_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? jzzzzzzzzzzzzzh_(Condition DiabetesDiagnosis) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> jzzzzzzzzzzzzzi_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(jzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzz_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzx_, izzzzzzzzzzzzzy_);
        Encounter jzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter jzzzzzzzzzzzzzu_ = EncounterWithHospitalization?.encounter;

            return jzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(izzzzzzzzzzzzzz_, jzzzzzzzzzzzzza_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzc_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> jzzzzzzzzzzzzzv_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet jzzzzzzzzzzzzzw_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> kzzzzzzzzzzzzza_ = context.Operators.Union<MedicationAdministration>(jzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzz_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> kzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(jzzzzzzzzzzzzzv_, kzzzzzzzzzzzzza_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? kzzzzzzzzzzzzzc_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? kzzzzzzzzzzzzzj_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> kzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(kzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzk_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string kzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzk_);
            bool? kzzzzzzzzzzzzzm_ = context.Operators.Equal(kzzzzzzzzzzzzzl_, "completed");
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzn_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType kzzzzzzzzzzzzzo_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzp_, default);
            bool? kzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzq_);

            return kzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> kzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(kzzzzzzzzzzzzzd_, kzzzzzzzzzzzzze_);
        Encounter kzzzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Encounter kzzzzzzzzzzzzzs_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

            return kzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(kzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzh_);

        return kzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzt_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet kzzzzzzzzzzzzzz_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> lzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            bool? lzzzzzzzzzzzzzb_(Observation BloodGlucoseLab)
            {
                DataType lzzzzzzzzzzzzzf_ = BloodGlucoseLab?.Effective;
                CqlDateTime lzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, lzzzzzzzzzzzzzf_ as FhirDateTime);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzh_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? lzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzj_ = BloodGlucoseLab?.StatusElement;
                string lzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzzzzzk_, "final");
                bool? lzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzl_);
                DataType lzzzzzzzzzzzzzn_ = BloodGlucoseLab?.Value;
                CqlQuantity lzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzzzzzzzzzn_ as Quantity);
                CqlQuantity lzzzzzzzzzzzzzp_ = context.Operators.Quantity(200m, "mg/dL");
                bool? lzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzq_);

                return lzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzza_, lzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? lzzzzzzzzzzzzzd_(Observation BloodGlucoseLab) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> lzzzzzzzzzzzzze_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(lzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzd_);

            return lzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzv_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(kzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzu_);
        Encounter kzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter lzzzzzzzzzzzzzs_ = EncounterWithHospitalization?.encounter;

            return lzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(kzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzt_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzu_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzw_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return lzzzzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime lzzzzzzzzzzzzzz_ = context.Operators.Start(Period);
        CqlDateTime mzzzzzzzzzzzzza_ = context.Operators.End(Period);
        CqlQuantity mzzzzzzzzzzzzzc_ = context.Operators.Quantity(10m, "days");
        CqlDateTime mzzzzzzzzzzzzzd_ = context.Operators.Add(lzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzc_);
        CqlDateTime[] mzzzzzzzzzzzzze_ = [
            mzzzzzzzzzzzzza_,
            mzzzzzzzzzzzzzd_,
        ];
        CqlDateTime mzzzzzzzzzzzzzf_ = context.Operators.Min<CqlDateTime>(mzzzzzzzzzzzzze_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzg_ = context.Operators.Interval(lzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzf_, true, true);

        return mzzzzzzzzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime mzzzzzzzzzzzzzh_ = context.Operators.Start(Period);
        CqlDateTime mzzzzzzzzzzzzzi_ = context.Operators.End(Period);
        int? mzzzzzzzzzzzzzj_ = context.Operators.DurationBetween(mzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzi_, "day");
        CqlInterval<int?> mzzzzzzzzzzzzzk_ = context.Operators.Interval(1, mzzzzzzzzzzzzzj_, true, true);
        CqlInterval<int?>[] mzzzzzzzzzzzzzl_ = [
            mzzzzzzzzzzzzzk_,
        ];
        IEnumerable<CqlInterval<int?>> mzzzzzzzzzzzzzm_ = context.Operators.Expand(mzzzzzzzzzzzzzl_ as IEnumerable<CqlInterval<int?>>, default);
        int? mzzzzzzzzzzzzzn_(CqlInterval<int?> DayExpand)
        {
            int? mzzzzzzzzzzzzzq_ = context.Operators.End(DayExpand);

            return mzzzzzzzzzzzzzq_;
        };
        IEnumerable<int?> mzzzzzzzzzzzzzo_ = context.Operators.Select<CqlInterval<int?>, int?>(mzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzn_);
        IEnumerable<int?> mzzzzzzzzzzzzzp_ = context.Operators.Distinct<int?>(mzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> mzzzzzzzzzzzzzr_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? mzzzzzzzzzzzzzs_(int? DayIndex)
        {
            CqlDateTime mzzzzzzzzzzzzzv_ = context.Operators.Start(Period);
            CqlQuantity mzzzzzzzzzzzzzw_ = context.Operators.Quantity(24m, "hours");
            int? mzzzzzzzzzzzzzx_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity mzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToQuantity(mzzzzzzzzzzzzzx_);
            CqlQuantity mzzzzzzzzzzzzzz_ = context.Operators.Multiply(mzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzy_);
            CqlDateTime nzzzzzzzzzzzzza_ = context.Operators.Add(mzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzz_);
            CqlDateTime nzzzzzzzzzzzzzb_()
            {
                bool nzzzzzzzzzzzzze_()
                {
                    CqlDateTime nzzzzzzzzzzzzzf_ = context.Operators.Start(Period);
                    CqlQuantity nzzzzzzzzzzzzzg_ = context.Operators.Quantity(24m, "hours");
                    int? nzzzzzzzzzzzzzh_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity nzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToQuantity(nzzzzzzzzzzzzzh_);
                    CqlQuantity nzzzzzzzzzzzzzj_ = context.Operators.Multiply(nzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzi_);
                    CqlDateTime nzzzzzzzzzzzzzk_ = context.Operators.Add(nzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzj_);
                    CqlDateTime nzzzzzzzzzzzzzl_ = context.Operators.End(Period);
                    int? nzzzzzzzzzzzzzm_ = context.Operators.DurationBetween(nzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzl_, "hour");
                    bool? nzzzzzzzzzzzzzn_ = context.Operators.Less(nzzzzzzzzzzzzzm_, 24);

                    return nzzzzzzzzzzzzzn_ ?? false;
                };
                if (nzzzzzzzzzzzzze_())
                {
                    CqlDateTime nzzzzzzzzzzzzzo_ = context.Operators.Start(Period);
                    CqlQuantity nzzzzzzzzzzzzzp_ = context.Operators.Quantity(24m, "hours");
                    int? nzzzzzzzzzzzzzq_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity nzzzzzzzzzzzzzr_ = context.Operators.ConvertIntegerToQuantity(nzzzzzzzzzzzzzq_);
                    CqlQuantity nzzzzzzzzzzzzzs_ = context.Operators.Multiply(nzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzr_);
                    CqlDateTime nzzzzzzzzzzzzzt_ = context.Operators.Add(nzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzs_);

                    return nzzzzzzzzzzzzzt_;
                }
                else
                {
                    CqlDateTime nzzzzzzzzzzzzzu_ = context.Operators.Start(Period);
                    CqlQuantity nzzzzzzzzzzzzzv_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity nzzzzzzzzzzzzzw_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity nzzzzzzzzzzzzzx_ = context.Operators.Multiply(nzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzw_);
                    CqlDateTime nzzzzzzzzzzzzzy_ = context.Operators.Add(nzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzx_);

                    return nzzzzzzzzzzzzzy_;
                }
            };
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzc_ = context.Operators.Interval(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzb_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? nzzzzzzzzzzzzzd_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, nzzzzzzzzzzzzzc_);

            return nzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> mzzzzzzzzzzzzzt_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(mzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> mzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(mzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzz_ = this.Initial_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? ozzzzzzzzzzzzza_(Encounter PertinentEncounter)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzf_ = this.Crop_Interval_to_10_Days(context, ozzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzh_ = this.Crop_Interval_to_10_Days(context, ozzzzzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> ozzzzzzzzzzzzzi_ = this.Days_In_Period(context, ozzzzzzzzzzzzzh_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? ozzzzzzzzzzzzzj_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, ozzzzzzzzzzzzzd_, ozzzzzzzzzzzzzf_, ozzzzzzzzzzzzzi_);

            return ozzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> ozzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(nzzzzzzzzzzzzzz_, ozzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> ozzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(ozzzzzzzzzzzzzb_);

        return ozzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> ozzzzzzzzzzzzzk_ = this.Pertinent_Encounters_With_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? ozzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
        {
            Encounter ozzzzzzzzzzzzzo_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzp_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> ozzzzzzzzzzzzzq_ = PertinentEncounterDays?.relevantDays;
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? ozzzzzzzzzzzzzr_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? ozzzzzzzzzzzzzv_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzw_ = EncounterDay?.dayPeriod;
                CqlValueSet ozzzzzzzzzzzzzx_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> ozzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? ozzzzzzzzzzzzzz_(Observation BloodGlucoseLab1)
                {
                    Code<ObservationStatus> pzzzzzzzzzzzzzo_ = BloodGlucoseLab1?.StatusElement;
                    string pzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzo_);
                    bool? pzzzzzzzzzzzzzq_ = context.Operators.Equal(pzzzzzzzzzzzzzp_, "final");
                    DataType pzzzzzzzzzzzzzr_ = BloodGlucoseLab1?.Value;
                    CqlQuantity pzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzzzzzzzzzzzzr_ as Quantity);
                    CqlQuantity pzzzzzzzzzzzzzt_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? pzzzzzzzzzzzzzu_ = context.Operators.Greater(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzt_);
                    bool? pzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzu_);
                    DataType pzzzzzzzzzzzzzw_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime pzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, pzzzzzzzzzzzzzw_ as FhirDateTime);
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzzzy_ = EncounterDay?.dayPeriod;
                    bool? pzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzy_, default);
                    bool? qzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzz_);

                    return qzzzzzzzzzzzzza_;
                };
                IEnumerable<Observation> pzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzy_, ozzzzzzzzzzzzzz_);
                bool? pzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzza_);
                IEnumerable<Observation> pzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? pzzzzzzzzzzzzze_(Observation BloodGlucoseLab2)
                {
                    Code<ObservationStatus> qzzzzzzzzzzzzzb_ = BloodGlucoseLab2?.StatusElement;
                    string qzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzb_);
                    bool? qzzzzzzzzzzzzzd_ = context.Operators.Equal(qzzzzzzzzzzzzzc_, "final");
                    DataType qzzzzzzzzzzzzze_ = BloodGlucoseLab2?.Value;
                    CqlQuantity qzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzzzzzzzzzzzze_ as Quantity);
                    CqlQuantity qzzzzzzzzzzzzzg_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? qzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzg_);
                    bool? qzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzh_);
                    DataType qzzzzzzzzzzzzzj_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime qzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzzzzzzzzj_ as FhirDateTime);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzl_ = EncounterDay?.dayPeriod;
                    bool? qzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzl_, default);
                    bool? qzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzm_);

                    return qzzzzzzzzzzzzzn_;
                };
                IEnumerable<Observation> pzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzd_, pzzzzzzzzzzzzze_);
                bool? pzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzf_);
                IEnumerable<Observation> pzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? pzzzzzzzzzzzzzj_(Observation BloodGlucoseLab3)
                {
                    Code<ObservationStatus> qzzzzzzzzzzzzzo_ = BloodGlucoseLab3?.StatusElement;
                    string qzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzo_);
                    bool? qzzzzzzzzzzzzzq_ = context.Operators.Equal(qzzzzzzzzzzzzzp_, "final");
                    DataType qzzzzzzzzzzzzzr_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime qzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, qzzzzzzzzzzzzzr_ as FhirDateTime);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzzzt_ = EncounterDay?.dayPeriod;
                    bool? qzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzt_, default);
                    bool? qzzzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzu_);

                    return qzzzzzzzzzzzzzv_;
                };
                IEnumerable<Observation> pzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzj_);
                bool? pzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzk_);
                bool? pzzzzzzzzzzzzzm_ = context.Operators.Not(pzzzzzzzzzzzzzl_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? pzzzzzzzzzzzzzn_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, ozzzzzzzzzzzzzv_, ozzzzzzzzzzzzzw_, pzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzm_);

                return pzzzzzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> ozzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(ozzzzzzzzzzzzzq_, ozzzzzzzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> ozzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(ozzzzzzzzzzzzzs_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? ozzzzzzzzzzzzzu_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, ozzzzzzzzzzzzzo_, ozzzzzzzzzzzzzp_, ozzzzzzzzzzzzzt_);

            return ozzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> ozzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(ozzzzzzzzzzzzzk_, ozzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> ozzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(ozzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> qzzzzzzzzzzzzzw_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? qzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter rzzzzzzzzzzzzza_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzb_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> rzzzzzzzzzzzzzc_ = EncounterWithResultDays?.relevantDays;
            bool? rzzzzzzzzzzzzzd_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? rzzzzzzzzzzzzzj_ = EncounterDay?.dayIndex;
                bool? rzzzzzzzzzzzzzk_ = context.Operators.Greater(rzzzzzzzzzzzzzj_, 1);

                return rzzzzzzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> rzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(rzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? rzzzzzzzzzzzzzf_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? rzzzzzzzzzzzzzl_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzm_ = EncounterDay?.dayPeriod;
                bool? rzzzzzzzzzzzzzn_ = EncounterDay?.hasSevereResult;
                bool? rzzzzzzzzzzzzzo_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> rzzzzzzzzzzzzzp_ = EncounterWithResultDays?.relevantDays;
                int? rzzzzzzzzzzzzzr_ = context.Operators.Subtract(rzzzzzzzzzzzzzl_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? rzzzzzzzzzzzzzs_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(rzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzr_);
                bool? rzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzs_?.hasElevatedResult;
                bool? rzzzzzzzzzzzzzu_ = context.Operators.And(rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzt_);
                int? rzzzzzzzzzzzzzx_ = context.Operators.Subtract(rzzzzzzzzzzzzzl_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? rzzzzzzzzzzzzzy_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(rzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzy_?.hasElevatedResult;
                bool? szzzzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzz_);
                bool? szzzzzzzzzzzzzb_ = context.Operators.Or(rzzzzzzzzzzzzzn_, szzzzzzzzzzzzza_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? szzzzzzzzzzzzzc_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, rzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzm_, szzzzzzzzzzzzzb_);

                return szzzzzzzzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> rzzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(rzzzzzzzzzzzzze_, rzzzzzzzzzzzzzf_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> rzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(rzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? rzzzzzzzzzzzzzi_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, rzzzzzzzzzzzzza_, rzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzh_);

            return rzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> qzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(qzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> qzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(qzzzzzzzzzzzzzy_);

        return qzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> szzzzzzzzzzzzzd_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? szzzzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> szzzzzzzzzzzzzj_ = EncounterWithEventDays?.eligibleEventDays;
            bool? szzzzzzzzzzzzzk_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? szzzzzzzzzzzzzn_ = EligibleEventDay?.hasHyperglycemicEvent;

                return szzzzzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> szzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(szzzzzzzzzzzzzj_, szzzzzzzzzzzzzk_);
            bool? szzzzzzzzzzzzzm_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(szzzzzzzzzzzzzl_);

            return szzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> szzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(szzzzzzzzzzzzzd_, szzzzzzzzzzzzze_);
        Encounter szzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter szzzzzzzzzzzzzo_ = EncounterWithEventDays?.encounter;

            return szzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(szzzzzzzzzzzzzf_, szzzzzzzzzzzzzg_);
        IEnumerable<Encounter> szzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzh_);

        return szzzzzzzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> szzzzzzzzzzzzzp_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? szzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter szzzzzzzzzzzzzw_ = EncounterWithEventDays?.encounter;
            bool? szzzzzzzzzzzzzx_ = context.Operators.Equal(szzzzzzzzzzzzzw_, QualifyingEncounter);

            return szzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> szzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(szzzzzzzzzzzzzp_, szzzzzzzzzzzzzq_);
        int? szzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> szzzzzzzzzzzzzy_ = EncounterWithEventDays?.eligibleEventDays;
            int? szzzzzzzzzzzzzz_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(szzzzzzzzzzzzzy_);

            return szzzzzzzzzzzzzz_;
        };
        IEnumerable<int?> szzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(szzzzzzzzzzzzzr_, szzzzzzzzzzzzzs_);
        IEnumerable<int?> szzzzzzzzzzzzzu_ = context.Operators.Distinct<int?>(szzzzzzzzzzzzzt_);
        int? szzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<int?>(szzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzzzza_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? tzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter tzzzzzzzzzzzzzh_ = EncounterWithEventDays?.encounter;
            bool? tzzzzzzzzzzzzzi_ = context.Operators.Equal(tzzzzzzzzzzzzzh_, QualifyingEncounter);

            return tzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> tzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(tzzzzzzzzzzzzza_, tzzzzzzzzzzzzzb_);
        int? tzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> tzzzzzzzzzzzzzj_ = EncounterWithEventDays?.eligibleEventDays;
            bool? tzzzzzzzzzzzzzk_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? tzzzzzzzzzzzzzn_ = EligibleEventDay?.hasHyperglycemicEvent;

                return tzzzzzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> tzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(tzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzk_);
            int? tzzzzzzzzzzzzzm_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(tzzzzzzzzzzzzzl_);

            return tzzzzzzzzzzzzzm_;
        };
        IEnumerable<int?> tzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(tzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzd_);
        IEnumerable<int?> tzzzzzzzzzzzzzf_ = context.Operators.Distinct<int?>(tzzzzzzzzzzzzze_);
        int? tzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<int?>(tzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzg_;
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
