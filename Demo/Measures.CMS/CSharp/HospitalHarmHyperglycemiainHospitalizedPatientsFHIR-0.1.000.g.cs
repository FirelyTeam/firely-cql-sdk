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
[CqlLibrary("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR", "0.1.000")]
public partial class HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000>
{
    private HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000() {}

    public static HospitalHarmHyperglycemiainHospitalizedPatientsFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmHyperglycemiainHospitalizedPatientsFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance];

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

    [CqlValueSetDefinition("Glucose Lab Test Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext _) => _Glucose_Lab_Test_Mass_Per_Volume;
    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

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
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "year");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, 18);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "finished");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Diabetes(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Before(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition Diabetes) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        Encounter izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Hospitalization?.encounter;

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<MedicationAdministration>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "not-done");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation GlucoseTest)
            {
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                    }
                    else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                    {
                        DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = GlucoseTest?.Effective;
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                        return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.Earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_());
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Hospitalization?.hospitalizationPeriod;
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "cancelled");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = GlucoseTest?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(200m, "mg/dL");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation GlucoseTest) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Hospitalization?.encounter;

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Denominator(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Hospital Days Max 10")]
    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(Period);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(Period);
        CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(10m, "days");
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDateTime[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
            nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
            nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_,
        ];
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Min<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(Period);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(Period);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DurationBetween(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
        CqlInterval<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(1, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        CqlInterval<int?>[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
        ];
        IEnumerable<CqlInterval<int?>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Expand(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<CqlInterval<int?>>, default);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(CqlInterval<int?> DayExpand)
        {
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(DayExpand);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CqlInterval<int?>, int?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<int?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(int? DayNumber)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(Period);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(24m, "hours");
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToQuantity(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Multiply(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(Period);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(24m, "hours");
                    int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToQuantity(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Multiply(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(Period);
                    int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DurationBetween(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "hour");
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Less(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, 24);

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(Period);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(24m, "hours");
                    int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToQuantity(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Multiply(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                }
                else
                {
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(Period);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Multiply(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                }
            };
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Hospital_Days_Max_10(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hospital_Days_Max_10(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Days_In_Period(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterDay?.dayPeriod;
                CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.StatusElement;
                    ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                    Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                    ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                    Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "cancelled");
                    bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = GlucoseTest?.Value;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                    {
                        bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                        };
                        bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = GlucoseTest?.Effective;
                            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                        };
                        bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                        {
                            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = GlucoseTest?.Effective;
                            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                        };
                        if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                        {
                            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = GlucoseTest?.Effective;
                            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                            return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                        }
                        else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                        {
                            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = GlucoseTest?.Effective;
                            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                            return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                        {
                            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = GlucoseTest?.Effective;
                            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                            return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.Earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
                    CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterDay?.dayPeriod;
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = GlucoseTest?.StatusElement;
                    ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                    Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                    ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                    Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "cancelled");
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.Value;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                        };
                        bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                        };
                        bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                        };
                        if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                            return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                        }
                        else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                            return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                        {
                            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.Effective;
                            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                            return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
                    CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterDay?.dayPeriod;
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = GlucoseTest?.StatusElement;
                    ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                    Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                    ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                    Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "cancelled");
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                    {
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                        };
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                        };
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                        };
                        if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                            return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                        }
                        else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                            return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                        {
                            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = GlucoseTest?.Effective;
                            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                            return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.Earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_());
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterDay?.dayPeriod;
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterWithResultDays?.relevantDays;
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterDay?.dayNumber;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Greater(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, 1);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterDay?.dayPeriod;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterDay?.hasSevereResult;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterWithResultDays?.relevantDays;
                int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.hasElevatedResult;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.hasElevatedResult;
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Encounter, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.Earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_());
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) =>
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.Earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_());
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
            {
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_());
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.Earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, false);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Id zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            Id zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) =>
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation GlucoseResult1000)
        {
            Id czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = GlucoseResult1000?.IdElement;
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<string> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Observation, string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation FirstGlucoseResult)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FirstGlucoseResult?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FirstGlucoseResult?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FirstGlucoseResult?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FirstGlucoseResult?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FirstGlucoseResult?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                        return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FirstGlucoseResult?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                        return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FirstGlucoseResult?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.Earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_());
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation FirstGlucoseResult) =>
                InpatientHospitalization;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Observation, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Days_with_Hyperglycemic_Events(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EligibleEventDay?.hasHyperglycemicEvent;

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HyperglycemicEventDays?.encounter;

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Hyperglycemic_Events(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
        {
            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Denominator_Exclusions(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter @this)
                {
                    string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter @this)
                {
                    string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<string> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Days_with_Hyperglycemic_Events(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterWithEventDays?.encounter;
                    bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, QualifyingEncounter);

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                IEnumerable<int?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Days_with_Hyperglycemic_Events(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterWithEventDays?.encounter;
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, QualifyingEncounter);

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterWithEventDays?.eligibleEventDays;
                    int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<int?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<int?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            }
        };

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_();
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
        {
            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Denominator_Exclusions(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter @this)
                {
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter @this)
                {
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<string> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
            };
            if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Days_with_Hyperglycemic_Events(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterWithEventDays?.encounter;
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, QualifyingEncounter);

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                IEnumerable<int?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<int?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Days_with_Hyperglycemic_Events(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterWithEventDays?.encounter;
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, QualifyingEncounter);

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                IEnumerable<int?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                IEnumerable<int?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<int?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<int?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            }
        };

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
        ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL = new(
        [typeof(Encounter), typeof(Observation), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseResult1000", "EarlierGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
        [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
        ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
        [typeof(Encounter), typeof(Observation)],
        ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
        ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
        ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
        ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
        ["encounter", "hospitalizationPeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR = new(
        [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>)],
        ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayNumber", "dayPeriod"]);

    #endregion CqlTupleMetadata Properties

}
