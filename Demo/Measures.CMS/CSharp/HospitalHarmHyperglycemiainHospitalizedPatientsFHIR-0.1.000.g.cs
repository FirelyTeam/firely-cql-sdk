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

    #region ValueSet: Glucose Lab Test Mass Per Volume
    [CqlValueSetDefinition(
        definitionName: "Glucose Lab Test Mass Per Volume",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34",
        valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext context) => _Glucose_Lab_Test_Mass_Per_Volume;

    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);
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
        CqlCode[] yzzzzzzzzzzzzzzzzzzzp_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return yzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzr_, true, true);
        object yzzzzzzzzzzzzzzzzzzzt_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", yzzzzzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzu_);

        return yzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            Patient zzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
            Date zzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
            string zzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlDate zzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzc_);
            Period zzzzzzzzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzf_);
            CqlDate zzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzg_);
            int? zzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzh_, "year");
            bool? zzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzi_, 18);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzn_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzo_);
            Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? zzzzzzzzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzs_, "finished");
            bool? zzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? zzzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? azzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, zzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> zzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(zzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> zzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(zzzzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzzh_ = this.Diabetes(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? azzzzzzzzzzzzzzzzzzzzj_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzp_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzp_);
                bool? azzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(azzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzq_, default);

                return azzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? azzzzzzzzzzzzzzzzzzzzl_(Condition Diabetes) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(azzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(azzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzc_);
        Encounter azzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter azzzzzzzzzzzzzzzzzzzzs_ = Hospitalization?.encounter;

            return azzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(azzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(azzzzzzzzzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzu_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> azzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationAdministration>(azzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> azzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(azzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? bzzzzzzzzzzzzzzzzzzzza_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? bzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> bzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(azzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzi_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bzzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bzzzzzzzzzzzzzzzzzzzzj_);
            bool? bzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzk_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? bzzzzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bzzzzzzzzzzzzzzzzzzzzn_);
            bool? bzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzo_, "not-done");
            bool? bzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzp_);
            bool? bzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzs_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType bzzzzzzzzzzzzzzzzzzzzt_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzv_, default);
            bool? bzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> bzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(bzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzc_);
        Encounter bzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter bzzzzzzzzzzzzzzzzzzzzy_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return bzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(bzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> bzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzf_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? czzzzzzzzzzzzzzzzzzzzh_(Observation GlucoseTest)
            {
                object czzzzzzzzzzzzzzzzzzzzl_()
                {
                    bool dzzzzzzzzzzzzzzzzzzzzh_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzk_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzk_);
                        bool dzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzi_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzn_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzn_);
                        bool dzzzzzzzzzzzzzzzzzzzzp_ = dzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                        return dzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzj_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzq_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzq_);
                        bool dzzzzzzzzzzzzzzzzzzzzs_ = dzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    if (dzzzzzzzzzzzzzzzzzzzzh_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzt_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzt_);

                        return (dzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzi_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzv_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzv_);

                        return (dzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzj_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzx_ = GlucoseTest?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzx_);

                        return (dzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime czzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, czzzzzzzzzzzzzzzzzzzzl_());
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzn_ = Hospitalization?.hospitalizationPeriod;
                bool? czzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzzzzp_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzq_);
                string czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzr_);
                string[] czzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzu_);
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzx_ = czzzzzzzzzzzzzzzzzzzzp_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzx_);
                bool? czzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzy_, "cancelled");
                bool? dzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(czzzzzzzzzzzzzzzzzzzzz_);
                bool? dzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzza_);
                DataType dzzzzzzzzzzzzzzzzzzzzc_ = GlucoseTest?.Value;
                object dzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(200m, "mg/dL");
                bool? dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzze_);
                bool? dzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzf_);

                return dzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? czzzzzzzzzzzzzzzzzzzzj_(Observation GlucoseTest) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(czzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzj_);

            return czzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> czzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(bzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzza_);
        Encounter czzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter dzzzzzzzzzzzzzzzzzzzzz_ = Hospitalization?.encounter;

            return dzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(czzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzd_);

        return ezzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzg_ = this.Denominator(context);

        return ezzzzzzzzzzzzzzzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(Period);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(Period);
        CqlQuantity ezzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(10m, "days");
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzk_);
        CqlDateTime[] ezzzzzzzzzzzzzzzzzzzzm_ = [
            ezzzzzzzzzzzzzzzzzzzzi_,
            ezzzzzzzzzzzzzzzzzzzzl_,
        ];
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Min<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzn_, true, true);

        return ezzzzzzzzzzzzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(Period);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(Period);
        int? ezzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DurationBetween(ezzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzq_, "day");
        CqlInterval<int?> ezzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(1, ezzzzzzzzzzzzzzzzzzzzr_, true, true);
        CqlInterval<int?>[] ezzzzzzzzzzzzzzzzzzzzt_ = [
            ezzzzzzzzzzzzzzzzzzzzs_,
        ];
        IEnumerable<CqlInterval<int?>> ezzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Expand(ezzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<CqlInterval<int?>>, default);
        int? ezzzzzzzzzzzzzzzzzzzzv_(CqlInterval<int?> DayExpand)
        {
            int? ezzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(DayExpand);

            return ezzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<int?> ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlInterval<int?>, int?>(ezzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<int?> ezzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<int?>(ezzzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> ezzzzzzzzzzzzzzzzzzzzz_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? fzzzzzzzzzzzzzzzzzzzza_(int? DayNumber)
        {
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(Period);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(24m, "hours");
            int? fzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToQuantity(fzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Multiply(fzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzj_()
            {
                bool fzzzzzzzzzzzzzzzzzzzzm_()
                {
                    CqlDateTime fzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(Period);
                    CqlQuantity fzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(24m, "hours");
                    int? fzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity fzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToQuantity(fzzzzzzzzzzzzzzzzzzzzp_);
                    CqlQuantity fzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Multiply(fzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzq_);
                    CqlDateTime fzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzr_);
                    CqlDateTime fzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(Period);
                    int? fzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DurationBetween(fzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzt_, "hour");
                    bool? fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Less(fzzzzzzzzzzzzzzzzzzzzu_, 24);

                    return fzzzzzzzzzzzzzzzzzzzzv_ ?? false;
                };
                if (fzzzzzzzzzzzzzzzzzzzzm_())
                {
                    CqlDateTime fzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(Period);
                    CqlQuantity fzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(24m, "hours");
                    int? fzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity fzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToQuantity(fzzzzzzzzzzzzzzzzzzzzy_);
                    CqlQuantity gzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Multiply(fzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzz_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzza_);

                    return gzzzzzzzzzzzzzzzzzzzzb_;
                }
                else
                {
                    CqlDateTime gzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(Period);
                    CqlQuantity gzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity gzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity gzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Multiply(gzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzze_);
                    CqlDateTime gzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzf_);

                    return gzzzzzzzzzzzzzzzzzzzzg_;
                }
            };
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzj_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? fzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, fzzzzzzzzzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(ezzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(fzzzzzzzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? gzzzzzzzzzzzzzzzzzzzzi_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzn_ = this.Hospital_Days_Max_10(context, gzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzp_ = this.Hospital_Days_Max_10(context, gzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> gzzzzzzzzzzzzzzzzzzzzq_ = this.Days_In_Period(context, gzzzzzzzzzzzzzzzzzzzzp_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? gzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, gzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzq_);

            return gzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> gzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> gzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> gzzzzzzzzzzzzzzzzzzzzs_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? gzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter gzzzzzzzzzzzzzzzzzzzzw_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzx_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> gzzzzzzzzzzzzzzzzzzzzy_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? gzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? hzzzzzzzzzzzzzzzzzzzzd_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzze_ = EncounterDay?.dayPeriod;
                CqlValueSet hzzzzzzzzzzzzzzzzzzzzf_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? hzzzzzzzzzzzzzzzzzzzzh_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzw_ = GlucoseTest?.StatusElement;
                    ObservationStatus? hzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzw_?.Value;
                    Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzx_);
                    string hzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzy_);
                    string[] izzzzzzzzzzzzzzzzzzzza_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? izzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                    ObservationStatus? izzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzw_?.Value;
                    Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzd_);
                    bool? izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzze_, "cancelled");
                    bool? izzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not(izzzzzzzzzzzzzzzzzzzzf_);
                    bool? izzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzg_);
                    DataType izzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.Value;
                    object izzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzi_);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? izzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzk_);
                    bool? izzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzl_);
                    object izzzzzzzzzzzzzzzzzzzzn_()
                    {
                        bool izzzzzzzzzzzzzzzzzzzzs_()
                        {
                            DataType izzzzzzzzzzzzzzzzzzzzv_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzv_);
                            bool izzzzzzzzzzzzzzzzzzzzx_ = izzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                            return izzzzzzzzzzzzzzzzzzzzx_;
                        };
                        bool izzzzzzzzzzzzzzzzzzzzt_()
                        {
                            DataType izzzzzzzzzzzzzzzzzzzzy_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzy_);
                            bool jzzzzzzzzzzzzzzzzzzzza_ = izzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                            return jzzzzzzzzzzzzzzzzzzzza_;
                        };
                        bool izzzzzzzzzzzzzzzzzzzzu_()
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzzb_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzb_);
                            bool jzzzzzzzzzzzzzzzzzzzzd_ = jzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                            return jzzzzzzzzzzzzzzzzzzzzd_;
                        };
                        if (izzzzzzzzzzzzzzzzzzzzs_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzze_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzze_);

                            return (jzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                        }
                        else if (izzzzzzzzzzzzzzzzzzzzt_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzzg_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzg_);

                            return (jzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (izzzzzzzzzzzzzzzzzzzzu_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzi_);

                            return (jzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime izzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.Earliest(context, izzzzzzzzzzzzzzzzzzzzn_());
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzp_ = EncounterDay?.dayPeriod;
                    bool? izzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzp_, default);
                    bool? izzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzq_);

                    return izzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzh_);
                bool? hzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzi_);
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? hzzzzzzzzzzzzzzzzzzzzm_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzk_ = GlucoseTest?.StatusElement;
                    ObservationStatus? jzzzzzzzzzzzzzzzzzzzzl_ = jzzzzzzzzzzzzzzzzzzzzk_?.Value;
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzl_);
                    string jzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzm_);
                    string[] jzzzzzzzzzzzzzzzzzzzzo_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? jzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                    ObservationStatus? jzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzk_?.Value;
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzr_);
                    bool? jzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzs_, "cancelled");
                    bool? jzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzzt_);
                    bool? jzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzu_);
                    DataType jzzzzzzzzzzzzzzzzzzzzw_ = GlucoseTest?.Value;
                    object jzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzw_);
                    CqlQuantity jzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? jzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, jzzzzzzzzzzzzzzzzzzzzy_);
                    bool? kzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzz_);
                    object kzzzzzzzzzzzzzzzzzzzzb_()
                    {
                        bool kzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzj_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzj_);
                            bool kzzzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                            return kzzzzzzzzzzzzzzzzzzzzl_;
                        };
                        bool kzzzzzzzzzzzzzzzzzzzzh_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzm_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzm_);
                            bool kzzzzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                            return kzzzzzzzzzzzzzzzzzzzzo_;
                        };
                        bool kzzzzzzzzzzzzzzzzzzzzi_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzp_);
                            bool kzzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                            return kzzzzzzzzzzzzzzzzzzzzr_;
                        };
                        if (kzzzzzzzzzzzzzzzzzzzzg_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzs_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzs_);

                            return (kzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                        }
                        else if (kzzzzzzzzzzzzzzzzzzzzh_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzu_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzu_);

                            return (kzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (kzzzzzzzzzzzzzzzzzzzzi_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzzw_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzw_);

                            return (kzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime kzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.Earliest(context, kzzzzzzzzzzzzzzzzzzzzb_());
                    CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzd_ = EncounterDay?.dayPeriod;
                    bool? kzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzd_, default);
                    bool? kzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzze_);

                    return kzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzm_);
                bool? hzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzn_);
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? hzzzzzzzzzzzzzzzzzzzzr_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzy_ = GlucoseTest?.StatusElement;
                    ObservationStatus? kzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzy_?.Value;
                    Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzz_);
                    string lzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzza_);
                    string[] lzzzzzzzzzzzzzzzzzzzzc_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? lzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                    ObservationStatus? lzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzy_?.Value;
                    Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzf_);
                    bool? lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzg_, "cancelled");
                    bool? lzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not(lzzzzzzzzzzzzzzzzzzzzh_);
                    bool? lzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzi_);
                    object lzzzzzzzzzzzzzzzzzzzzk_()
                    {
                        bool lzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            DataType lzzzzzzzzzzzzzzzzzzzzs_ = GlucoseTest?.Effective;
                            object lzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzs_);
                            bool lzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                            return lzzzzzzzzzzzzzzzzzzzzu_;
                        };
                        bool lzzzzzzzzzzzzzzzzzzzzq_()
                        {
                            DataType lzzzzzzzzzzzzzzzzzzzzv_ = GlucoseTest?.Effective;
                            object lzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzv_);
                            bool lzzzzzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                            return lzzzzzzzzzzzzzzzzzzzzx_;
                        };
                        bool lzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            DataType lzzzzzzzzzzzzzzzzzzzzy_ = GlucoseTest?.Effective;
                            object lzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzy_);
                            bool mzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                            return mzzzzzzzzzzzzzzzzzzzza_;
                        };
                        if (lzzzzzzzzzzzzzzzzzzzzp_())
                        {
                            DataType mzzzzzzzzzzzzzzzzzzzzb_ = GlucoseTest?.Effective;
                            object mzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzb_);

                            return (mzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                        }
                        else if (lzzzzzzzzzzzzzzzzzzzzq_())
                        {
                            DataType mzzzzzzzzzzzzzzzzzzzzd_ = GlucoseTest?.Effective;
                            object mzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzd_);

                            return (mzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (lzzzzzzzzzzzzzzzzzzzzr_())
                        {
                            DataType mzzzzzzzzzzzzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object mzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzf_);

                            return (mzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime lzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.Earliest(context, lzzzzzzzzzzzzzzzzzzzzk_());
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzm_ = EncounterDay?.dayPeriod;
                    bool? lzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzm_, default);
                    bool? lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzn_);

                    return lzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzr_);
                bool? hzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzs_);
                bool? hzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzt_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? hzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, hzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzu_);

                return hzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> hzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(gzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(hzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? hzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, gzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzb_);

            return hzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> gzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> gzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(gzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> mzzzzzzzzzzzzzzzzzzzzh_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? mzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter mzzzzzzzzzzzzzzzzzzzzl_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzm_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> mzzzzzzzzzzzzzzzzzzzzn_ = EncounterWithResultDays?.relevantDays;
            bool? mzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? mzzzzzzzzzzzzzzzzzzzzu_ = EncounterDay?.dayNumber;
                bool? mzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Greater(mzzzzzzzzzzzzzzzzzzzzu_, 1);

                return mzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> mzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(mzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? mzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? mzzzzzzzzzzzzzzzzzzzzw_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzx_ = EncounterDay?.dayPeriod;
                bool? mzzzzzzzzzzzzzzzzzzzzy_ = EncounterDay?.hasSevereResult;
                bool? mzzzzzzzzzzzzzzzzzzzzz_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> nzzzzzzzzzzzzzzzzzzzza_ = EncounterWithResultDays?.relevantDays;
                int? nzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzw_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? nzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzc_);
                bool? nzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzd_?.hasElevatedResult;
                bool? nzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzze_);
                int? nzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzw_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? nzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzi_);
                bool? nzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzj_?.hasElevatedResult;
                bool? nzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzk_);
                bool? nzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzl_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? nzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, mzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzm_);

                return nzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> mzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(mzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? mzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, mzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> mzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(mzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> mzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(mzzzzzzzzzzzzzzzzzzzzj_);

        return mzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzp_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> nzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, Observation>(nzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? nzzzzzzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? nzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> nzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzs_);
        bool? nzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType ozzzzzzzzzzzzzzzzzzzza_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object ozzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? ozzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzb_ as CqlQuantity, ozzzzzzzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzze_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzf_ = ozzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzf_);
            string ozzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzg_);
            string[] ozzzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzj_);
            object ozzzzzzzzzzzzzzzzzzzzl_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzb_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzb_);
                    bool pzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzze_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzze_);
                    bool pzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzg_;
                };
                bool pzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzh_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzh_);
                    bool pzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzj_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzk_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzk_);

                    return (pzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzm_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzm_);

                    return (pzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzo_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzo_);

                    return (pzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzzl_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzv_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> nzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(nzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzu_);
        Observation nzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) =>
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(nzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Observation>(nzzzzzzzzzzzzzzzzzzzzx_);

        return nzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzr_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzs_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> pzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(pzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? pzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? qzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return qzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> pzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(pzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzv_);
        bool? pzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object qzzzzzzzzzzzzzzzzzzzzd_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzk_);
                    bool rzzzzzzzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzn_);
                    bool rzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool rzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzq_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzq_);
                    bool rzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzt_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzt_);

                    return (rzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzv_);

                    return (rzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzx_);

                    return (rzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.Earliest(context, qzzzzzzzzzzzzzzzzzzzzd_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzn_, default);
            object qzzzzzzzzzzzzzzzzzzzzp_()
            {
                bool rzzzzzzzzzzzzzzzzzzzzz_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzc_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzc_);
                    bool szzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzze_;
                };
                bool szzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzf_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzf_);
                    bool szzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzh_;
                };
                bool szzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzi_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzi_);
                    bool szzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzk_;
                };
                if (rzzzzzzzzzzzzzzzzzzzzz_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzl_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzl_);

                    return (szzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzn_);

                    return (szzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzp_);

                    return (szzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.Earliest(context, qzzzzzzzzzzzzzzzzzzzzp_());
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzh_);
            object qzzzzzzzzzzzzzzzzzzzzv_()
            {
                bool szzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzu_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzu_);
                    bool szzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzw_;
                };
                bool szzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzx_);
                    bool szzzzzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzz_;
                };
                bool szzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType tzzzzzzzzzzzzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzza_);
                    bool tzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return tzzzzzzzzzzzzzzzzzzzzc_;
                };
                if (szzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzd_);

                    return (tzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzf_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzf_);

                    return (tzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType tzzzzzzzzzzzzzzzzzzzzh_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzh_);

                    return (tzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, qzzzzzzzzzzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzw_, true, false);
            bool? qzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? qzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzy_);
            Id rzzzzzzzzzzzzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzza_?.Value;
            Id rzzzzzzzzzzzzzzzzzzzzc_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzzzc_?.Value;
            bool? rzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(rzzzzzzzzzzzzzzzzzzzze_);
            bool? rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzf_);

            return rzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(pzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzx_);
        Observation pzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) =>
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(pzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<Observation>(qzzzzzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzj_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? tzzzzzzzzzzzzzzzzzzzzk_(Observation GlucoseResult1000)
        {
            Id tzzzzzzzzzzzzzzzzzzzzm_ = GlucoseResult1000?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzm_?.Value;
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzo_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? tzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                string tzzzzzzzzzzzzzzzzzzzzv_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? tzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzv_ is null));

                return tzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzp_);
            string tzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                string tzzzzzzzzzzzzzzzzzzzzx_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return tzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<string> tzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation, string>(tzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzr_);
            bool? tzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzt_);

            return tzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? uzzzzzzzzzzzzzzzzzzzzc_(Observation FirstGlucoseResult)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzg_ = FirstGlucoseResult?.Value;
                object uzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? uzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzi_);
                object uzzzzzzzzzzzzzzzzzzzzk_()
                {
                    bool uzzzzzzzzzzzzzzzzzzzzx_()
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzza_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzza_);
                        bool vzzzzzzzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return vzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzy_()
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzd_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzd_);
                        bool vzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                        return vzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzz_()
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzg_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzg_);
                        bool vzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                        return vzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    if (uzzzzzzzzzzzzzzzzzzzzx_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzj_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzj_);

                        return (vzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzy_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzl_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzl_);

                        return (vzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzz_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzn_ = FirstGlucoseResult?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzn_);

                        return (vzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.Earliest(context, uzzzzzzzzzzzzzzzzzzzzk_());
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzu_, default);
                bool? uzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzv_);

                return uzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzc_);
            Encounter uzzzzzzzzzzzzzzzzzzzze_(Observation FirstGlucoseResult) =>
                InpatientHospitalization;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, Encounter>(uzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzz_);

        return uzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return vzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzzq_ = this.Days_with_Hyperglycemic_Events(context);
        bool? vzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzzzzzzzzzw_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? vzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? wzzzzzzzzzzzzzzzzzzzza_ = EligibleEventDay?.hasHyperglycemicEvent;

                return wzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzzzzzzzzzzzy_);

            return vzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzr_);
        Encounter vzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter wzzzzzzzzzzzzzzzzzzzzb_ = HyperglycemicEventDays?.encounter;

            return wzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(vzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<Encounter>(vzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Hyperglycemic_Events(context);

        return wzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? wzzzzzzzzzzzzzzzzzzzzh_()
        {
            bool wzzzzzzzzzzzzzzzzzzzzi_()
            {
                string wzzzzzzzzzzzzzzzzzzzzj_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzk_ = this.Denominator_Exclusions(context);
                bool? wzzzzzzzzzzzzzzzzzzzzl_(Encounter @this)
                {
                    string wzzzzzzzzzzzzzzzzzzzzq_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? wzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzq_ is null));

                    return wzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzl_);
                string wzzzzzzzzzzzzzzzzzzzzn_(Encounter @this)
                {
                    string wzzzzzzzzzzzzzzzzzzzzs_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return wzzzzzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<string> wzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, string>(wzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzn_);
                bool? wzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzo_);

                return wzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            if (wzzzzzzzzzzzzzzzzzzzzi_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzzt_ = this.Days_with_Hyperglycemic_Events(context);
                bool? wzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter xzzzzzzzzzzzzzzzzzzzza_ = EncounterWithEventDays?.encounter;
                    bool? xzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzza_, QualifyingEncounter);

                    return xzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(wzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzu_);
                int? wzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(wzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzw_);
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<int?>(wzzzzzzzzzzzzzzzzzzzzx_);
                int? wzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<int?>(wzzzzzzzzzzzzzzzzzzzzy_);

                return wzzzzzzzzzzzzzzzzzzzzz_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> xzzzzzzzzzzzzzzzzzzzzc_ = this.Days_with_Hyperglycemic_Events(context);
                bool? xzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter xzzzzzzzzzzzzzzzzzzzzj_ = EncounterWithEventDays?.encounter;
                    bool? xzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzj_, QualifyingEncounter);

                    return xzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> xzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(xzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzd_);
                int? xzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> xzzzzzzzzzzzzzzzzzzzzl_ = EncounterWithEventDays?.eligibleEventDays;
                    int? xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(xzzzzzzzzzzzzzzzzzzzzl_);

                    return xzzzzzzzzzzzzzzzzzzzzm_;
                };
                IEnumerable<int?> xzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(xzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzf_);
                IEnumerable<int?> xzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<int?>(xzzzzzzzzzzzzzzzzzzzzg_);
                int? xzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<int?>(xzzzzzzzzzzzzzzzzzzzzh_);

                return xzzzzzzzzzzzzzzzzzzzzi_;
            }
        };

        return wzzzzzzzzzzzzzzzzzzzzh_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? xzzzzzzzzzzzzzzzzzzzzn_()
        {
            bool xzzzzzzzzzzzzzzzzzzzzo_()
            {
                string xzzzzzzzzzzzzzzzzzzzzp_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzq_ = this.Denominator_Exclusions(context);
                bool? xzzzzzzzzzzzzzzzzzzzzr_(Encounter @this)
                {
                    string xzzzzzzzzzzzzzzzzzzzzw_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? xzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzw_ is null));

                    return xzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzr_);
                string xzzzzzzzzzzzzzzzzzzzzt_(Encounter @this)
                {
                    string xzzzzzzzzzzzzzzzzzzzzy_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return xzzzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<string> xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, string>(xzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzt_);
                bool? xzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzu_);

                return xzzzzzzzzzzzzzzzzzzzzv_ ?? false;
            };
            if (xzzzzzzzzzzzzzzzzzzzzo_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> xzzzzzzzzzzzzzzzzzzzzz_ = this.Days_with_Hyperglycemic_Events(context);
                bool? yzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter yzzzzzzzzzzzzzzzzzzzzg_ = EncounterWithEventDays?.encounter;
                    bool? yzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzg_, QualifyingEncounter);

                    return yzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> yzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(xzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzza_);
                int? yzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(yzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzc_);
                IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<int?>(yzzzzzzzzzzzzzzzzzzzzd_);
                int? yzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<int?>(yzzzzzzzzzzzzzzzzzzzze_);

                return yzzzzzzzzzzzzzzzzzzzzf_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> yzzzzzzzzzzzzzzzzzzzzi_ = this.Days_with_Hyperglycemic_Events(context);
                bool? yzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter yzzzzzzzzzzzzzzzzzzzzp_ = EncounterWithEventDays?.encounter;
                    bool? yzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzp_, QualifyingEncounter);

                    return yzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> yzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(yzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzj_);
                int? yzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> yzzzzzzzzzzzzzzzzzzzzr_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? yzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? yzzzzzzzzzzzzzzzzzzzzv_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return yzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> yzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(yzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzs_);
                    int? yzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(yzzzzzzzzzzzzzzzzzzzzt_);

                    return yzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(yzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzl_);
                IEnumerable<int?> yzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<int?>(yzzzzzzzzzzzzzzzzzzzzm_);
                int? yzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<int?>(yzzzzzzzzzzzzzzzzzzzzn_);

                return yzzzzzzzzzzzzzzzzzzzzo_;
            }
        };

        return xzzzzzzzzzzzzzzzzzzzzn_();
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
