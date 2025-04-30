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
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ozzzzzzzzzzzzzzzt_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.0.006", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzza_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        return pzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzc_ = this.Inpatient_Encounter_During_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            Patient pzzzzzzzzzzzzzzzf_ = this.Patient(context);
            Date pzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzf_?.BirthDateElement;
            string pzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzg_?.Value;
            CqlDateTime pzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDateTime(pzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime pzzzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzzzj_);
            int? pzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzk_, "year");
            bool? pzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzzl_, 18);

            return pzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Qualifying_Encounters_With_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounters(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? pzzzzzzzzzzzzzzzo_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? pzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingEncounter, pzzzzzzzzzzzzzzzr_);

            return pzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> pzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(pzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> pzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(pzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> pzzzzzzzzzzzzzzzt_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> pzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet pzzzzzzzzzzzzzzzz_ = this.Diabetes(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? qzzzzzzzzzzzzzzzb_(Condition DiabetesDiagnosis)
            {
                CodeableConcept qzzzzzzzzzzzzzzzf_ = DiabetesDiagnosis?.VerificationStatus;
                CqlConcept qzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, qzzzzzzzzzzzzzzzf_);
                CqlCode qzzzzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.confirmed(context);
                CqlConcept qzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzh_);
                bool? qzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabetesDiagnosis);
                CqlDateTime qzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzm_ = EncounterWithHospitalization?.hospitalizationPeriod;
                CqlDateTime qzzzzzzzzzzzzzzzn_ = context.Operators.End(qzzzzzzzzzzzzzzzm_);
                bool? qzzzzzzzzzzzzzzzo_ = context.Operators.Before(qzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzn_, default);
                bool? qzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzo_);

                return qzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Condition> qzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? qzzzzzzzzzzzzzzzd_(Condition DiabetesDiagnosis) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> qzzzzzzzzzzzzzzze_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(qzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> pzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(pzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzu_);
        Encounter pzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter qzzzzzzzzzzzzzzzq_ = EncounterWithHospitalization?.encounter;

            return qzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(pzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Hypoglycemic Medication")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> qzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        CqlValueSet qzzzzzzzzzzzzzzzs_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> qzzzzzzzzzzzzzzzw_ = context.Operators.Union<MedicationAdministration>(qzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzv_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> qzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(qzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? qzzzzzzzzzzzzzzzy_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? rzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_CLXCRdeeSPOVHRdOZOXQZeIEB, _valueTuple.Item1, _valueTuple.Item2);

            return rzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> qzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(qzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzza_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> rzzzzzzzzzzzzzzzg_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.StatusElement;
            string rzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzzg_);
            bool? rzzzzzzzzzzzzzzzi_ = context.Operators.Equal(rzzzzzzzzzzzzzzzh_, "completed");
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzj_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.hospitalizationPeriod;
            DataType rzzzzzzzzzzzzzzzk_ = tuple_clxcrdeespovhrdozoxqzeieb?.HypoglycemicMedication?.Effective;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzzzzzzzzzzk_);
            bool? rzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzl_, default);
            bool? rzzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzm_);

            return rzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?> rzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?>(qzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzza_);
        Encounter rzzzzzzzzzzzzzzzc_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)? tuple_clxcrdeespovhrdozoxqzeieb)
        {
            Encounter rzzzzzzzzzzzzzzzo_ = tuple_clxcrdeespovhrdozoxqzeieb?.EncounterWithHospitalization?.encounter;

            return rzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization, MedicationAdministration HypoglycemicMedication)?, Encounter>(rzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzd_);

        return rzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounters With Elevated Blood Glucose Lab")]
    public IEnumerable<Encounter> Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> rzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounters_With_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> rzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            CqlValueSet rzzzzzzzzzzzzzzzv_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
            bool? rzzzzzzzzzzzzzzzx_(Observation BloodGlucoseLab)
            {
                DataType szzzzzzzzzzzzzzzb_ = BloodGlucoseLab?.Effective;
                CqlDateTime szzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, szzzzzzzzzzzzzzzb_ as FhirDateTime);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzd_ = EncounterWithHospitalization?.hospitalizationPeriod;
                bool? szzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzf_ = BloodGlucoseLab?.StatusElement;
                string szzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzzf_);
                bool? szzzzzzzzzzzzzzzh_ = context.Operators.Equal(szzzzzzzzzzzzzzzg_, "final");
                bool? szzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzh_);
                DataType szzzzzzzzzzzzzzzj_ = BloodGlucoseLab?.Value;
                CqlQuantity szzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzzzzzzzzzzzzzzj_ as Quantity);
                CqlQuantity szzzzzzzzzzzzzzzl_ = context.Operators.Quantity(200m, "mg/dL");
                bool? szzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzl_);
                bool? szzzzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzm_);

                return szzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? rzzzzzzzzzzzzzzzz_(Observation BloodGlucoseLab) =>
                EncounterWithHospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> szzzzzzzzzzzzzzza_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(rzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzz_);

            return szzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> rzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(rzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzq_);
        Encounter rzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? EncounterWithHospitalization)
        {
            Encounter szzzzzzzzzzzzzzzo_ = EncounterWithHospitalization?.encounter;

            return szzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(rzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzp_ = this.Qualifying_Encounters_With_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzq_ = this.Qualifying_Encounters_With_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzs_ = this.Qualifying_Encounters_With_Elevated_Blood_Glucose_Lab(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzs_);

        return szzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzu_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Crop Interval to 10 Days")]
    public CqlInterval<CqlDateTime> Crop_Interval_to_10_Days(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime szzzzzzzzzzzzzzzv_ = context.Operators.Start(Period);
        CqlDateTime szzzzzzzzzzzzzzzw_ = context.Operators.End(Period);
        CqlQuantity szzzzzzzzzzzzzzzy_ = context.Operators.Quantity(10m, "days");
        CqlDateTime szzzzzzzzzzzzzzzz_ = context.Operators.Add(szzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzy_);
        CqlDateTime[] tzzzzzzzzzzzzzzza_ = [
            szzzzzzzzzzzzzzzw_,
            szzzzzzzzzzzzzzzz_,
        ];
        CqlDateTime tzzzzzzzzzzzzzzzb_ = context.Operators.Min<CqlDateTime>(tzzzzzzzzzzzzzzza_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzc_ = context.Operators.Interval(szzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzb_, true, true);

        return tzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime tzzzzzzzzzzzzzzzd_ = context.Operators.Start(Period);
        CqlDateTime tzzzzzzzzzzzzzzze_ = context.Operators.End(Period);
        int? tzzzzzzzzzzzzzzzf_ = context.Operators.DurationBetween(tzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzze_, "day");
        CqlInterval<int?> tzzzzzzzzzzzzzzzg_ = context.Operators.Interval(1, tzzzzzzzzzzzzzzzf_, true, true);
        CqlInterval<int?>[] tzzzzzzzzzzzzzzzh_ = [
            tzzzzzzzzzzzzzzzg_,
        ];
        IEnumerable<CqlInterval<int?>> tzzzzzzzzzzzzzzzi_ = context.Operators.Expand(tzzzzzzzzzzzzzzzh_ as IEnumerable<CqlInterval<int?>>, default);
        int? tzzzzzzzzzzzzzzzj_(CqlInterval<int?> DayExpand)
        {
            int? tzzzzzzzzzzzzzzzm_ = context.Operators.End(DayExpand);

            return tzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<int?> tzzzzzzzzzzzzzzzk_ = context.Operators.Select<CqlInterval<int?>, int?>(tzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzj_);
        IEnumerable<int?> tzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<int?>(tzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> tzzzzzzzzzzzzzzzn_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? tzzzzzzzzzzzzzzzo_(int? DayIndex)
        {
            CqlDateTime tzzzzzzzzzzzzzzzr_ = context.Operators.Start(Period);
            CqlQuantity tzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(24m, "hours");
            int? tzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity tzzzzzzzzzzzzzzzu_ = context.Operators.ConvertIntegerToQuantity(tzzzzzzzzzzzzzzzt_);
            CqlQuantity tzzzzzzzzzzzzzzzv_ = context.Operators.Multiply(tzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzw_ = context.Operators.Add(tzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzzzx_()
            {
                bool uzzzzzzzzzzzzzzza_()
                {
                    CqlDateTime uzzzzzzzzzzzzzzzb_ = context.Operators.Start(Period);
                    CqlQuantity uzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(24m, "hours");
                    int? uzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity uzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToQuantity(uzzzzzzzzzzzzzzzd_);
                    CqlQuantity uzzzzzzzzzzzzzzzf_ = context.Operators.Multiply(uzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzze_);
                    CqlDateTime uzzzzzzzzzzzzzzzg_ = context.Operators.Add(uzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzf_);
                    CqlDateTime uzzzzzzzzzzzzzzzh_ = context.Operators.End(Period);
                    int? uzzzzzzzzzzzzzzzi_ = context.Operators.DurationBetween(uzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzh_, "hour");
                    bool? uzzzzzzzzzzzzzzzj_ = context.Operators.Less(uzzzzzzzzzzzzzzzi_, 24);

                    return uzzzzzzzzzzzzzzzj_ ?? false;
                };
                if (uzzzzzzzzzzzzzzza_())
                {
                    CqlDateTime uzzzzzzzzzzzzzzzk_ = context.Operators.Start(Period);
                    CqlQuantity uzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                    int? uzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity uzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToQuantity(uzzzzzzzzzzzzzzzm_);
                    CqlQuantity uzzzzzzzzzzzzzzzo_ = context.Operators.Multiply(uzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzn_);
                    CqlDateTime uzzzzzzzzzzzzzzzp_ = context.Operators.Add(uzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzo_);

                    return uzzzzzzzzzzzzzzzp_;
                }
                else
                {
                    CqlDateTime uzzzzzzzzzzzzzzzq_ = context.Operators.Start(Period);
                    CqlQuantity uzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity uzzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity uzzzzzzzzzzzzzzzt_ = context.Operators.Multiply(uzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzs_);
                    CqlDateTime uzzzzzzzzzzzzzzzu_ = context.Operators.Add(uzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzt_);

                    return uzzzzzzzzzzzzzzzu_;
                }
            };
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzy_ = context.Operators.Interval(tzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzx_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? tzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, tzzzzzzzzzzzzzzzy_);

            return tzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> tzzzzzzzzzzzzzzzp_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(tzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> tzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(tzzzzzzzzzzzzzzzp_);

        return tzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Pertinent_Encounters_With_Days(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? uzzzzzzzzzzzzzzzw_(Encounter PertinentEncounter)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, PertinentEncounter);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzb_ = this.Crop_Interval_to_10_Days(context, uzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzd_ = this.Crop_Interval_to_10_Days(context, uzzzzzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> vzzzzzzzzzzzzzzze_ = this.Days_In_Period(context, vzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? vzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, PertinentEncounter, uzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> uzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(uzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> uzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(uzzzzzzzzzzzzzzzx_);

        return uzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Glucose Result Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> Pertinent_Encounters_With_Glucose_Result_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> vzzzzzzzzzzzzzzzg_ = this.Pertinent_Encounters_With_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? vzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? PertinentEncounterDays)
        {
            Encounter vzzzzzzzzzzzzzzzk_ = PertinentEncounterDays?.encounter;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzl_ = PertinentEncounterDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> vzzzzzzzzzzzzzzzm_ = PertinentEncounterDays?.relevantDays;
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? vzzzzzzzzzzzzzzzn_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? vzzzzzzzzzzzzzzzr_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzs_ = EncounterDay?.dayPeriod;
                CqlValueSet vzzzzzzzzzzzzzzzt_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> vzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? vzzzzzzzzzzzzzzzv_(Observation BloodGlucoseLab1)
                {
                    Code<ObservationStatus> wzzzzzzzzzzzzzzzk_ = BloodGlucoseLab1?.StatusElement;
                    string wzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzk_);
                    bool? wzzzzzzzzzzzzzzzm_ = context.Operators.Equal(wzzzzzzzzzzzzzzzl_, "final");
                    DataType wzzzzzzzzzzzzzzzn_ = BloodGlucoseLab1?.Value;
                    CqlQuantity wzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzzzzzzzzzzzzzzn_ as Quantity);
                    CqlQuantity wzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? wzzzzzzzzzzzzzzzq_ = context.Operators.Greater(wzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzp_);
                    bool? wzzzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzq_);
                    DataType wzzzzzzzzzzzzzzzs_ = BloodGlucoseLab1?.Effective;
                    CqlDateTime wzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, wzzzzzzzzzzzzzzzs_ as FhirDateTime);
                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzu_ = EncounterDay?.dayPeriod;
                    bool? wzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzu_, default);
                    bool? wzzzzzzzzzzzzzzzw_ = context.Operators.And(wzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzv_);

                    return wzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Observation> vzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzw_);
                IEnumerable<Observation> vzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? wzzzzzzzzzzzzzzza_(Observation BloodGlucoseLab2)
                {
                    Code<ObservationStatus> wzzzzzzzzzzzzzzzx_ = BloodGlucoseLab2?.StatusElement;
                    string wzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzzzx_);
                    bool? wzzzzzzzzzzzzzzzz_ = context.Operators.Equal(wzzzzzzzzzzzzzzzy_, "final");
                    DataType xzzzzzzzzzzzzzzza_ = BloodGlucoseLab2?.Value;
                    CqlQuantity xzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzzzzzzzzzzzzza_ as Quantity);
                    CqlQuantity xzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? xzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzc_);
                    bool? xzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzd_);
                    DataType xzzzzzzzzzzzzzzzf_ = BloodGlucoseLab2?.Effective;
                    CqlDateTime xzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzzzzzzzzzzzzzf_ as FhirDateTime);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzh_ = EncounterDay?.dayPeriod;
                    bool? xzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzh_, default);
                    bool? xzzzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzi_);

                    return xzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Observation> wzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzza_);
                bool? wzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzb_);
                IEnumerable<Observation> wzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? wzzzzzzzzzzzzzzzf_(Observation BloodGlucoseLab3)
                {
                    Code<ObservationStatus> xzzzzzzzzzzzzzzzk_ = BloodGlucoseLab3?.StatusElement;
                    string xzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzzzk_);
                    bool? xzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzl_, "final");
                    DataType xzzzzzzzzzzzzzzzn_ = BloodGlucoseLab3?.Effective;
                    CqlDateTime xzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, xzzzzzzzzzzzzzzzn_ as FhirDateTime);
                    CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzp_ = EncounterDay?.dayPeriod;
                    bool? xzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzp_, default);
                    bool? xzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzq_);

                    return xzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Observation> wzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzf_);
                bool? wzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(wzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzi_ = context.Operators.Not(wzzzzzzzzzzzzzzzh_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? wzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_DRKKGhBGYfEMJaNePAIEJiGe, vzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzi_);

                return wzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> vzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(vzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzn_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> vzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(vzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? vzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_BEJFJZgXEOCibEHSLPSMaRGGM, vzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> vzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(vzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> vzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?>(vzzzzzzzzzzzzzzzi_);

        return vzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Pertinent Encounters With Hyperglycemic Event Days")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Pertinent_Encounters_With_Hyperglycemic_Event_Days(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?> xzzzzzzzzzzzzzzzs_ = this.Pertinent_Encounters_With_Glucose_Result_Days(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? xzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter xzzzzzzzzzzzzzzzw_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzx_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> xzzzzzzzzzzzzzzzy_ = EncounterWithResultDays?.relevantDays;
            bool? xzzzzzzzzzzzzzzzz_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? yzzzzzzzzzzzzzzzf_ = EncounterDay?.dayIndex;
                bool? yzzzzzzzzzzzzzzzg_ = context.Operators.Greater(yzzzzzzzzzzzzzzzf_, 1);

                return yzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> yzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(xzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? yzzzzzzzzzzzzzzzb_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? EncounterDay)
            {
                int? yzzzzzzzzzzzzzzzh_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzi_ = EncounterDay?.dayPeriod;
                bool? yzzzzzzzzzzzzzzzj_ = EncounterDay?.hasSevereResult;
                bool? yzzzzzzzzzzzzzzzk_ = EncounterDay?.hasNoResult;
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> yzzzzzzzzzzzzzzzl_ = EncounterWithResultDays?.relevantDays;
                int? yzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzh_, 2);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? yzzzzzzzzzzzzzzzo_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzo_?.hasElevatedResult;
                bool? yzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzp_);
                int? yzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzh_, 3);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)? yzzzzzzzzzzzzzzzu_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?>(yzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzt_);
                bool? yzzzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzzzu_?.hasElevatedResult;
                bool? yzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzv_);
                bool? yzzzzzzzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzw_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? yzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, yzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzx_);

                return yzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> yzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(yzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> yzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(yzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? yzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, xzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzd_);

            return yzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> xzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoResult)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(xzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> xzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(xzzzzzzzzzzzzzzzu_);

        return xzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> yzzzzzzzzzzzzzzzz_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? zzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> zzzzzzzzzzzzzzzzf_ = EncounterWithEventDays?.eligibleEventDays;
            bool? zzzzzzzzzzzzzzzzg_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? zzzzzzzzzzzzzzzzj_ = EligibleEventDay?.hasHyperglycemicEvent;

                return zzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> zzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(zzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzzi_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(zzzzzzzzzzzzzzzzh_);

            return zzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> zzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(yzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzza_);
        Encounter zzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter zzzzzzzzzzzzzzzzk_ = EncounterWithEventDays?.encounter;

            return zzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(zzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(zzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> zzzzzzzzzzzzzzzzl_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? zzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter zzzzzzzzzzzzzzzzs_ = EncounterWithEventDays?.encounter;
            bool? zzzzzzzzzzzzzzzzt_ = context.Operators.Equal(zzzzzzzzzzzzzzzzs_, QualifyingEncounter);

            return zzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> zzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(zzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzm_);
        int? zzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> zzzzzzzzzzzzzzzzu_ = EncounterWithEventDays?.eligibleEventDays;
            int? zzzzzzzzzzzzzzzzv_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(zzzzzzzzzzzzzzzzu_);

            return zzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<int?> zzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(zzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzo_);
        IEnumerable<int?> zzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<int?>(zzzzzzzzzzzzzzzzp_);
        int? zzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<int?>(zzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> zzzzzzzzzzzzzzzzw_ = this.Pertinent_Encounters_With_Hyperglycemic_Event_Days(context);
        bool? zzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            Encounter azzzzzzzzzzzzzzzzd_ = EncounterWithEventDays?.encounter;
            bool? azzzzzzzzzzzzzzzze_ = context.Operators.Equal(azzzzzzzzzzzzzzzzd_, QualifyingEncounter);

            return azzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> zzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(zzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzx_);
        int? zzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> azzzzzzzzzzzzzzzzf_ = EncounterWithEventDays?.eligibleEventDays;
            bool? azzzzzzzzzzzzzzzzg_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? azzzzzzzzzzzzzzzzj_ = EligibleEventDay?.hasHyperglycemicEvent;

                return azzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> azzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(azzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzg_);
            int? azzzzzzzzzzzzzzzzi_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(azzzzzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<int?> azzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(zzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzz_);
        IEnumerable<int?> azzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<int?>(azzzzzzzzzzzzzzzza_);
        int? azzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<int?>(azzzzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzzzc_;
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
