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
        CqlDateTime xzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzb_, true, true);
        object xzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("HospitalHarmHyperglycemiainHospitalizedPatientsFHIR-0.1.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzg_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? xzzzzzzzzzzzzzzzzzzi_(Encounter InpatientEncounter)
        {
            Patient xzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
            Date xzzzzzzzzzzzzzzzzzzl_ = xzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
            string xzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlDate xzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzzzzzm_);
            Period xzzzzzzzzzzzzzzzzzzo_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzp_);
            CqlDate xzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzq_);
            int? xzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzr_, "year");
            bool? xzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzs_, 18);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzx_, "day");
            bool? xzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzy_);
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzza_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? yzzzzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzc_, "finished");
            bool? yzzzzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzd_);

            return yzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? yzzzzzzzzzzzzzzzzzzg_(Encounter QualifyingHospitalization)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? yzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, yzzzzzzzzzzzzzzzzzzj_);

            return yzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzr_ = this.Diabetes(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzzzzzzzzzzzt_(Condition Diabetes)
            {
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToPrevalenceInterval(context, Diabetes);
                CqlDateTime yzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzz_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime zzzzzzzzzzzzzzzzzzza_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzzzzzzzb_ = context.Operators.Before(yzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzza_, default);

                return zzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? yzzzzzzzzzzzzzzzzzzv_(Condition Diabetes) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Condition, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzv_);

            return yzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> yzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(yzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzm_);
        Encounter yzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter zzzzzzzzzzzzzzzzzzzc_ = Hospitalization?.encounter;

            return zzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(yzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> zzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet zzzzzzzzzzzzzzzzzzze_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> zzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> zzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> zzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationAdministration>(zzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> zzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(zzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? zzzzzzzzzzzzzzzzzzzk_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple)
        {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? zzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);

            return zzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> zzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(zzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> zzzzzzzzzzzzzzzzzzzs_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? zzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> zzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(zzzzzzzzzzzzzzzzzzzt_);
            bool? zzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzu_, "completed");
            MedicationAdministration.MedicationAdministrationStatusCodes? zzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> zzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(zzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzy_, "not-done");
            bool? azzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzz_);
            bool? azzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzc_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType azzzzzzzzzzzzzzzzzzzd_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object azzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzze_);
            bool? azzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzf_, default);
            bool? azzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzg_);

            return azzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> zzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(zzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzm_);
        Encounter zzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig)
        {
            Encounter azzzzzzzzzzzzzzzzzzzi_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;

            return azzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(zzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(zzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzp_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? azzzzzzzzzzzzzzzzzzzr_(Observation GlucoseTest)
            {
                object azzzzzzzzzzzzzzzzzzzv_()
                {
                    bool bzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzu_ = GlucoseTest?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzu_);
                        bool bzzzzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return bzzzzzzzzzzzzzzzzzzzw_;
                    };
                    bool bzzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzx_ = GlucoseTest?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzx_);
                        bool bzzzzzzzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                        return bzzzzzzzzzzzzzzzzzzzz_;
                    };
                    bool bzzzzzzzzzzzzzzzzzzzt_()
                    {
                        DataType czzzzzzzzzzzzzzzzzzza_ = GlucoseTest?.Effective;
                        object czzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzza_);
                        bool czzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return czzzzzzzzzzzzzzzzzzzc_;
                    };
                    if (bzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType czzzzzzzzzzzzzzzzzzzd_ = GlucoseTest?.Effective;
                        object czzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzd_);

                        return (czzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                    }
                    else if (bzzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType czzzzzzzzzzzzzzzzzzzf_ = GlucoseTest?.Effective;
                        object czzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzf_);

                        return (czzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bzzzzzzzzzzzzzzzzzzzt_())
                    {
                        DataType czzzzzzzzzzzzzzzzzzzh_ = GlucoseTest?.Effective;
                        object czzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzh_);

                        return (czzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime azzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, azzzzzzzzzzzzzzzzzzzv_());
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzx_ = Hospitalization?.hospitalizationPeriod;
                bool? azzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzz_ = GlucoseTest?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzzzzzzz_?.Value;
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzza_);
                string bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzb_);
                string[] bzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzze_);
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzzz_?.Value;
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzzh_);
                bool? bzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzi_, "cancelled");
                bool? bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzj_);
                bool? bzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzk_);
                DataType bzzzzzzzzzzzzzzzzzzzm_ = GlucoseTest?.Value;
                object bzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(200m, "mg/dL");
                bool? bzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzo_);
                bool? bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzp_);

                return bzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? azzzzzzzzzzzzzzzzzzzt_(Observation GlucoseTest) =>
                Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(azzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzt_);

            return azzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> azzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(azzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzk_);
        Encounter azzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization)
        {
            Encounter czzzzzzzzzzzzzzzzzzzj_ = Hospitalization?.encounter;

            return czzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(azzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(azzzzzzzzzzzzzzzzzzzn_);

        return azzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return czzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzq_ = this.Denominator(context);

        return czzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Hospital Days Max 10")]
    public CqlInterval<CqlDateTime> Hospital_Days_Max_10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime czzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(Period);
        CqlDateTime czzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(Period);
        CqlQuantity czzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(10m, "days");
        CqlDateTime czzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzu_);
        CqlDateTime[] czzzzzzzzzzzzzzzzzzzw_ = [
            czzzzzzzzzzzzzzzzzzzs_,
            czzzzzzzzzzzzzzzzzzzv_,
        ];
        CqlDateTime czzzzzzzzzzzzzzzzzzzx_ = context.Operators.Min<CqlDateTime>(czzzzzzzzzzzzzzzzzzzw_ as IEnumerable<CqlDateTime>);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzx_, true, true);

        return czzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Interval To Day Numbers")]
    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime czzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(Period);
        CqlDateTime dzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(Period);
        int? dzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DurationBetween(czzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzza_, "day");
        CqlInterval<int?> dzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(1, dzzzzzzzzzzzzzzzzzzzb_, true, true);
        CqlInterval<int?>[] dzzzzzzzzzzzzzzzzzzzd_ = [
            dzzzzzzzzzzzzzzzzzzzc_,
        ];
        IEnumerable<CqlInterval<int?>> dzzzzzzzzzzzzzzzzzzze_ = context.Operators.Expand(dzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<CqlInterval<int?>>, default);
        int? dzzzzzzzzzzzzzzzzzzzf_(CqlInterval<int?> DayExpand)
        {
            int? dzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(DayExpand);

            return dzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<int?> dzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<int?>, int?>(dzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<int?> dzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<int?>(dzzzzzzzzzzzzzzzzzzzg_);

        return dzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Days In Period")]
    public IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> dzzzzzzzzzzzzzzzzzzzj_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? dzzzzzzzzzzzzzzzzzzzk_(int? DayNumber)
        {
            CqlDateTime dzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(Period);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(24m, "hours");
            int? dzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(DayNumber, 1);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertIntegerToQuantity(dzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Multiply(dzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzt_()
            {
                bool dzzzzzzzzzzzzzzzzzzzw_()
                {
                    CqlDateTime dzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(Period);
                    CqlQuantity dzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(24m, "hours");
                    int? dzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToQuantity(dzzzzzzzzzzzzzzzzzzzz_);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzb_ = context.Operators.Multiply(dzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzza_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzb_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(Period);
                    int? ezzzzzzzzzzzzzzzzzzze_ = context.Operators.DurationBetween(ezzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzd_, "hour");
                    bool? ezzzzzzzzzzzzzzzzzzzf_ = context.Operators.Less(ezzzzzzzzzzzzzzzzzzze_, 24);

                    return ezzzzzzzzzzzzzzzzzzzf_ ?? false;
                };
                if (dzzzzzzzzzzzzzzzzzzzw_())
                {
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(Period);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(24m, "hours");
                    int? ezzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(DayNumber, 1);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToQuantity(ezzzzzzzzzzzzzzzzzzzi_);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzk_ = context.Operators.Multiply(ezzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzj_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzk_);

                    return ezzzzzzzzzzzzzzzzzzzl_;
                }
                else
                {
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(Period);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToQuantity(DayNumber);
                    CqlQuantity ezzzzzzzzzzzzzzzzzzzp_ = context.Operators.Multiply(ezzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzo_);
                    CqlDateTime ezzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzp_);

                    return ezzzzzzzzzzzzzzzzzzzq_;
                }
            };
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzt_(), true, false);
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? dzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_SMNhCfXhAdRgSFYJNGOMBShE, DayNumber, dzzzzzzzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> dzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(dzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> dzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?>(dzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Population(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? ezzzzzzzzzzzzzzzzzzzs_(Encounter EligibleInpatientHospitalization)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzx_ = this.Hospital_Days_Max_10(context, ezzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzz_ = this.Hospital_Days_Max_10(context, ezzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzzza_ = this.Days_In_Period(context, ezzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? fzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_HRTAKZQhNDEfbiSbFGHLQTdcR, EligibleInpatientHospitalization, ezzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzza_);

            return fzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> ezzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(ezzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> ezzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(ezzzzzzzzzzzzzzzzzzzt_);

        return ezzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> fzzzzzzzzzzzzzzzzzzzc_ = this.Days_in_Hospitalization(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? fzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays)
        {
            Encounter fzzzzzzzzzzzzzzzzzzzg_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzh_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> fzzzzzzzzzzzzzzzzzzzi_ = InpatientHospitalDays?.relevantDays;
            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? fzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay)
            {
                int? fzzzzzzzzzzzzzzzzzzzn_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzo_ = EncounterDay?.dayPeriod;
                CqlValueSet fzzzzzzzzzzzzzzzzzzzp_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? fzzzzzzzzzzzzzzzzzzzr_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzg_ = GlucoseTest?.StatusElement;
                    ObservationStatus? gzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzg_?.Value;
                    Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzh_);
                    string gzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzi_);
                    string[] gzzzzzzzzzzzzzzzzzzzk_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? gzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                    ObservationStatus? gzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzg_?.Value;
                    Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzn_);
                    bool? gzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzo_, "cancelled");
                    bool? gzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not(gzzzzzzzzzzzzzzzzzzzp_);
                    bool? gzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzq_);
                    DataType gzzzzzzzzzzzzzzzzzzzs_ = GlucoseTest?.Value;
                    object gzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzs_);
                    CqlQuantity gzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? gzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Greater(gzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzu_);
                    bool? gzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzv_);
                    object gzzzzzzzzzzzzzzzzzzzx_()
                    {
                        bool hzzzzzzzzzzzzzzzzzzzc_()
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzf_);
                            bool hzzzzzzzzzzzzzzzzzzzh_ = hzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                            return hzzzzzzzzzzzzzzzzzzzh_;
                        };
                        bool hzzzzzzzzzzzzzzzzzzzd_()
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzi_);
                            bool hzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                            return hzzzzzzzzzzzzzzzzzzzk_;
                        };
                        bool hzzzzzzzzzzzzzzzzzzze_()
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzl_);
                            bool hzzzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                            return hzzzzzzzzzzzzzzzzzzzn_;
                        };
                        if (hzzzzzzzzzzzzzzzzzzzc_())
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzo_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzo_);

                            return (hzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                        }
                        else if (hzzzzzzzzzzzzzzzzzzzd_())
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzq_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzq_);

                            return (hzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (hzzzzzzzzzzzzzzzzzzze_())
                        {
                            DataType hzzzzzzzzzzzzzzzzzzzs_ = GlucoseTest?.Effective;
                            object hzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzs_);

                            return (hzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime gzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.Earliest(context, gzzzzzzzzzzzzzzzzzzzx_());
                    CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzz_ = EncounterDay?.dayPeriod;
                    bool? hzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzz_, default);
                    bool? hzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzza_);

                    return hzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzr_);
                bool? fzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzzzzzzzs_);
                IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? fzzzzzzzzzzzzzzzzzzzw_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzu_ = GlucoseTest?.StatusElement;
                    ObservationStatus? hzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzu_?.Value;
                    Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzv_);
                    string hzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzw_);
                    string[] hzzzzzzzzzzzzzzzzzzzy_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? hzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                    ObservationStatus? izzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzu_?.Value;
                    Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzb_);
                    bool? izzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzc_, "cancelled");
                    bool? izzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(izzzzzzzzzzzzzzzzzzzd_);
                    bool? izzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzze_);
                    DataType izzzzzzzzzzzzzzzzzzzg_ = GlucoseTest?.Value;
                    object izzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzg_);
                    CqlQuantity izzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? izzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzi_);
                    bool? izzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzj_);
                    object izzzzzzzzzzzzzzzzzzzl_()
                    {
                        bool izzzzzzzzzzzzzzzzzzzq_()
                        {
                            DataType izzzzzzzzzzzzzzzzzzzt_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzt_);
                            bool izzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                            return izzzzzzzzzzzzzzzzzzzv_;
                        };
                        bool izzzzzzzzzzzzzzzzzzzr_()
                        {
                            DataType izzzzzzzzzzzzzzzzzzzw_ = GlucoseTest?.Effective;
                            object izzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzw_);
                            bool izzzzzzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                            return izzzzzzzzzzzzzzzzzzzy_;
                        };
                        bool izzzzzzzzzzzzzzzzzzzs_()
                        {
                            DataType izzzzzzzzzzzzzzzzzzzz_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzz_);
                            bool jzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                            return jzzzzzzzzzzzzzzzzzzzb_;
                        };
                        if (izzzzzzzzzzzzzzzzzzzq_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzc_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzc_);

                            return (jzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                        }
                        else if (izzzzzzzzzzzzzzzzzzzr_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzze_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzze_);

                            return (jzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (izzzzzzzzzzzzzzzzzzzs_())
                        {
                            DataType jzzzzzzzzzzzzzzzzzzzg_ = GlucoseTest?.Effective;
                            object jzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzg_);

                            return (jzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime izzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.Earliest(context, izzzzzzzzzzzzzzzzzzzl_());
                    CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzn_ = EncounterDay?.dayPeriod;
                    bool? izzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzn_, default);
                    bool? izzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzo_);

                    return izzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzw_);
                bool? fzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzzzzzzzx_);
                IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                bool? gzzzzzzzzzzzzzzzzzzzb_(Observation GlucoseTest)
                {
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.StatusElement;
                    ObservationStatus? jzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzi_?.Value;
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzj_);
                    string jzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzk_);
                    string[] jzzzzzzzzzzzzzzzzzzzm_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? jzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                    ObservationStatus? jzzzzzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzzzzzi_?.Value;
                    Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzp_);
                    bool? jzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzq_, "cancelled");
                    bool? jzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzr_);
                    bool? jzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzs_);
                    object jzzzzzzzzzzzzzzzzzzzu_()
                    {
                        bool jzzzzzzzzzzzzzzzzzzzz_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzc_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzc_);
                            bool kzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                            return kzzzzzzzzzzzzzzzzzzze_;
                        };
                        bool kzzzzzzzzzzzzzzzzzzza_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzf_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzf_);
                            bool kzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                            return kzzzzzzzzzzzzzzzzzzzh_;
                        };
                        bool kzzzzzzzzzzzzzzzzzzzb_()
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzi_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzi_);
                            bool kzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                            return kzzzzzzzzzzzzzzzzzzzk_;
                        };
                        if (jzzzzzzzzzzzzzzzzzzzz_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzl_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzl_);

                            return (kzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                        }
                        else if (kzzzzzzzzzzzzzzzzzzza_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzn_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzn_);

                            return (kzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (kzzzzzzzzzzzzzzzzzzzb_())
                        {
                            DataType kzzzzzzzzzzzzzzzzzzzp_ = GlucoseTest?.Effective;
                            object kzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzp_);

                            return (kzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        }
                    };
                    CqlDateTime jzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.Earliest(context, jzzzzzzzzzzzzzzzzzzzu_());
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzw_ = EncounterDay?.dayPeriod;
                    bool? jzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzw_, default);
                    bool? jzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzx_);

                    return jzzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzb_);
                bool? gzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(gzzzzzzzzzzzzzzzzzzzd_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? gzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, fzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> fzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(fzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> fzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(fzzzzzzzzzzzzzzzzzzzk_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? fzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, fzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> fzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(fzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> fzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(fzzzzzzzzzzzzzzzzzzze_);

        return fzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> kzzzzzzzzzzzzzzzzzzzr_ = this.Days_with_Glucose_Results(context);
        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? kzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays)
        {
            Encounter kzzzzzzzzzzzzzzzzzzzv_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzw_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> kzzzzzzzzzzzzzzzzzzzx_ = EncounterWithResultDays?.relevantDays;
            bool? kzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? lzzzzzzzzzzzzzzzzzzze_ = EncounterDay?.dayNumber;
                bool? lzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Greater(lzzzzzzzzzzzzzzzzzzze_, 1);

                return lzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> kzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(kzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? lzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay)
            {
                int? lzzzzzzzzzzzzzzzzzzzg_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzh_ = EncounterDay?.dayPeriod;
                bool? lzzzzzzzzzzzzzzzzzzzi_ = EncounterDay?.hasSevereResult;
                bool? lzzzzzzzzzzzzzzzzzzzj_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> lzzzzzzzzzzzzzzzzzzzk_ = EncounterWithResultDays?.relevantDays;
                int? lzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzg_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? lzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(lzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzm_);
                bool? lzzzzzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzzzzzn_?.hasElevatedResult;
                bool? lzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzo_);
                int? lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzg_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? lzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(lzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzs_);
                bool? lzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzt_?.hasElevatedResult;
                bool? lzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzv_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? lzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, lzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzw_);

                return lzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(kzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> lzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(lzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? lzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, kzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> kzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(kzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> kzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(kzzzzzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzz_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> mzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, Observation>(lzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? mzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? mzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> mzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(mzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh)
        {
            DataType mzzzzzzzzzzzzzzzzzzzk_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object mzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1000m, "mg/dL");
            bool? mzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(mzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzm_);
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzo_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzp_);
            string mzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzq_);
            string[] mzzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzt_);
            object mzzzzzzzzzzzzzzzzzzzv_()
            {
                bool nzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzl_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzl_);
                    bool nzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzn_;
                };
                bool nzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzo_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzo_);
                    bool nzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzzzzzzzzq_;
                };
                bool nzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzr_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzr_);
                    bool nzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzt_;
                };
                if (nzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzu_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzu_);

                    return (nzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzw_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzw_);

                    return (nzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzy_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzy_);

                    return (nzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.Earliest(context, mzzzzzzzzzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime nzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime nzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzze_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzf_, default);
            bool? nzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzg_);

            return nzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> mzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(mzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzze_);
        Observation mzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) =>
            tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(mzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Observation>(mzzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Glucose Tests Earlier Than Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzb_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzc_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> ozzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(ozzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? ozzzzzzzzzzzzzzzzzzzf_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? ozzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_BBNOZJWbNFIIMKUYJNdXQYNTL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ozzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> ozzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(ozzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai)
        {
            object ozzzzzzzzzzzzzzzzzzzn_()
            {
                bool pzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzu_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzu_);
                    bool pzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzw_;
                };
                bool pzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzx_);
                    bool pzzzzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzz_;
                };
                bool pzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzza_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzza_);
                    bool qzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzc_;
                };
                if (pzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzd_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object qzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzd_);

                    return (qzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzf_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzf_);

                    return (qzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzh_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzh_);

                    return (qzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzn_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, tuple_fdcevedgizpocycjyzijywhai?.InpatientHospitalization);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzw_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzx_, default);
            object ozzzzzzzzzzzzzzzzzzzz_()
            {
                bool qzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzm_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzm_);
                    bool qzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzo_;
                };
                bool qzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzp_);
                    bool qzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return qzzzzzzzzzzzzzzzzzzzr_;
                };
                bool qzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzs_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzs_);
                    bool qzzzzzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzu_;
                };
                if (qzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzv_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzv_);

                    return (qzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzx_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzx_);

                    return (qzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzz_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzz_);

                    return (rzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.Earliest(context, ozzzzzzzzzzzzzzzzzzzz_());
            CqlDateTime pzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzr_);
            object pzzzzzzzzzzzzzzzzzzzf_()
            {
                bool rzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzze_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzze_);
                    bool rzzzzzzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzg_;
                };
                bool rzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzh_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzh_);
                    bool rzzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzj_;
                };
                bool rzzzzzzzzzzzzzzzzzzzd_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzk_);
                    bool rzzzzzzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzm_;
                };
                if (rzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzn_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzn_);

                    return (rzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzp_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzp_);

                    return (rzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzzzzzzd_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzr_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzr_);

                    return (rzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.Earliest(context, pzzzzzzzzzzzzzzzzzzzf_());
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzg_, true, false);
            bool? pzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzh_, default);
            bool? pzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzi_);
            Id pzzzzzzzzzzzzzzzzzzzk_ = tuple_fdcevedgizpocycjyzijywhai?.EarlierGlucoseTest?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzl_ = pzzzzzzzzzzzzzzzzzzzk_?.Value;
            Id pzzzzzzzzzzzzzzzzzzzm_ = tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzm_?.Value;
            bool? pzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzn_);
            bool? pzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(pzzzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?> ozzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?>(ozzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzh_);
        Observation ozzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)? tuple_fdcevedgizpocycjyzijywhai) =>
            tuple_fdcevedgizpocycjyzijywhai?.GlucoseResult1000;
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult1000, Observation EarlierGlucoseTest)?, Observation>(ozzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Observation>(ozzzzzzzzzzzzzzzzzzzk_);

        return ozzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Glucose Greater Than or Equal to 1000 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzt_ = this.Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        bool? rzzzzzzzzzzzzzzzzzzzu_(Observation GlucoseResult1000)
        {
            Id rzzzzzzzzzzzzzzzzzzzw_ = GlucoseResult1000?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzw_?.Value;
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzy_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? rzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                string szzzzzzzzzzzzzzzzzzzf_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                bool? szzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzf_ is null));

                return szzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzz_);
            string szzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                string szzzzzzzzzzzzzzzzzzzh_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                return szzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<string> szzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation, string>(szzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzb_);
            bool? szzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzc_);
            bool? szzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(szzzzzzzzzzzzzzzzzzzd_);

            return szzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzu_);

        return rzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Greater Than or Equal to 1000")]
    public IEnumerable<Encounter> Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzj_(Encounter InpatientHospitalization)
        {
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzl_ = this.Initial_Glucose_Greater_Than_or_Equal_to_1000_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
            bool? szzzzzzzzzzzzzzzzzzzm_(Observation FirstGlucoseResult)
            {
                DataType szzzzzzzzzzzzzzzzzzzq_ = FirstGlucoseResult?.Value;
                object szzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1000m, "mg/dL");
                bool? szzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzs_);
                object szzzzzzzzzzzzzzzzzzzu_()
                {
                    bool tzzzzzzzzzzzzzzzzzzzh_()
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzk_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzk_);
                        bool tzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                        return tzzzzzzzzzzzzzzzzzzzm_;
                    };
                    bool tzzzzzzzzzzzzzzzzzzzi_()
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzn_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzn_);
                        bool tzzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                        return tzzzzzzzzzzzzzzzzzzzp_;
                    };
                    bool tzzzzzzzzzzzzzzzzzzzj_()
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzq_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzq_);
                        bool tzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                        return tzzzzzzzzzzzzzzzzzzzs_;
                    };
                    if (tzzzzzzzzzzzzzzzzzzzh_())
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzt_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzt_);

                        return (tzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                    }
                    else if (tzzzzzzzzzzzzzzzzzzzi_())
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzv_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzv_);

                        return (tzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (tzzzzzzzzzzzzzzzzzzzj_())
                    {
                        DataType tzzzzzzzzzzzzzzzzzzzx_ = FirstGlucoseResult?.Effective;
                        object tzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzx_);

                        return (tzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime szzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.Earliest(context, szzzzzzzzzzzzzzzzzzzu_());
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime szzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime szzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzze_, default);
                bool? tzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzm_);
            Encounter szzzzzzzzzzzzzzzzzzzo_(Observation FirstGlucoseResult) =>
                InpatientHospitalization;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(szzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_First_Glucose_Greater_Than_or_Equal_to_1000(context);

        return tzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzzzzzzzzzza_ = this.Days_with_Hyperglycemic_Events(context);
        bool? uzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> uzzzzzzzzzzzzzzzzzzzg_ = HyperglycemicEventDays?.eligibleEventDays;
            bool? uzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
            {
                bool? uzzzzzzzzzzzzzzzzzzzk_ = EligibleEventDay?.hasHyperglycemicEvent;

                return uzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> uzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(uzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(uzzzzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> uzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(uzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzb_);
        Encounter uzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays)
        {
            Encounter uzzzzzzzzzzzzzzzzzzzl_ = HyperglycemicEventDays?.encounter;

            return uzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(uzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzze_);

        return uzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Hyperglycemic_Events(context);

        return uzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? uzzzzzzzzzzzzzzzzzzzr_()
        {
            bool uzzzzzzzzzzzzzzzzzzzs_()
            {
                string uzzzzzzzzzzzzzzzzzzzt_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzu_ = this.Denominator_Exclusions(context);
                bool? uzzzzzzzzzzzzzzzzzzzv_(Encounter @this)
                {
                    string vzzzzzzzzzzzzzzzzzzza_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? vzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzza_ is null));

                    return vzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzv_);
                string uzzzzzzzzzzzzzzzzzzzx_(Encounter @this)
                {
                    string vzzzzzzzzzzzzzzzzzzzc_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return vzzzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<string> uzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, string>(uzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzx_);
                bool? uzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzy_);

                return uzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            if (uzzzzzzzzzzzzzzzzzzzs_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzd_ = this.Days_with_Hyperglycemic_Events(context);
                bool? vzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter vzzzzzzzzzzzzzzzzzzzk_ = EncounterWithEventDays?.encounter;
                    bool? vzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzk_, QualifyingEncounter);

                    return vzzzzzzzzzzzzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzze_);
                int? vzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> vzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(vzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzg_);
                IEnumerable<int?> vzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<int?>(vzzzzzzzzzzzzzzzzzzzh_);
                int? vzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<int?>(vzzzzzzzzzzzzzzzzzzzi_);

                return vzzzzzzzzzzzzzzzzzzzj_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzm_ = this.Days_with_Hyperglycemic_Events(context);
                bool? vzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter vzzzzzzzzzzzzzzzzzzzt_ = EncounterWithEventDays?.encounter;
                    bool? vzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzt_, QualifyingEncounter);

                    return vzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> vzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(vzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzn_);
                int? vzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> vzzzzzzzzzzzzzzzzzzzv_ = EncounterWithEventDays?.eligibleEventDays;
                    int? vzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(vzzzzzzzzzzzzzzzzzzzv_);

                    return vzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<int?> vzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(vzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzp_);
                IEnumerable<int?> vzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<int?>(vzzzzzzzzzzzzzzzzzzzq_);
                int? vzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<int?>(vzzzzzzzzzzzzzzzzzzzr_);

                return vzzzzzzzzzzzzzzzzzzzs_;
            }
        };

        return uzzzzzzzzzzzzzzzzzzzr_();
    }


    [CqlExpressionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        int? vzzzzzzzzzzzzzzzzzzzx_()
        {
            bool vzzzzzzzzzzzzzzzzzzzy_()
            {
                string vzzzzzzzzzzzzzzzzzzzz_ = (QualifyingEncounter is Resource
    ? (QualifyingEncounter as Resource).IdElement
    : default)?.Value;
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzza_ = this.Denominator_Exclusions(context);
                bool? wzzzzzzzzzzzzzzzzzzzb_(Encounter @this)
                {
                    string wzzzzzzzzzzzzzzzzzzzg_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;
                    bool? wzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzg_ is null));

                    return wzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzb_);
                string wzzzzzzzzzzzzzzzzzzzd_(Encounter @this)
                {
                    string wzzzzzzzzzzzzzzzzzzzi_ = (@this is Resource
    ? (@this as Resource).IdElement
    : default)?.Value;

                    return wzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<string> wzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, string>(wzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzze_);

                return wzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzzzy_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzj_ = this.Days_with_Hyperglycemic_Events(context);
                bool? wzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter wzzzzzzzzzzzzzzzzzzzq_ = EncounterWithEventDays?.encounter;
                    bool? wzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzq_, QualifyingEncounter);

                    return wzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(wzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzk_);
                int? wzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) =>
                    0;
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(wzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzm_);
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<int?>(wzzzzzzzzzzzzzzzzzzzn_);
                int? wzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<int?>(wzzzzzzzzzzzzzzzzzzzo_);

                return wzzzzzzzzzzzzzzzzzzzp_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzs_ = this.Days_with_Hyperglycemic_Events(context);
                bool? wzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    Encounter wzzzzzzzzzzzzzzzzzzzz_ = EncounterWithEventDays?.encounter;
                    bool? xzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzz_, QualifyingEncounter);

                    return xzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> wzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(wzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzt_);
                int? wzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays)
                {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> xzzzzzzzzzzzzzzzzzzzb_ = EncounterWithEventDays?.eligibleEventDays;
                    bool? xzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay)
                    {
                        bool? xzzzzzzzzzzzzzzzzzzzf_ = EligibleEventDay?.hasHyperglycemicEvent;

                        return xzzzzzzzzzzzzzzzzzzzf_;
                    };
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> xzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(xzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzc_);
                    int? xzzzzzzzzzzzzzzzzzzze_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(xzzzzzzzzzzzzzzzzzzzd_);

                    return xzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(wzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzv_);
                IEnumerable<int?> wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<int?>(wzzzzzzzzzzzzzzzzzzzw_);
                int? wzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<int?>(wzzzzzzzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzzzzzzzy_;
            }
        };

        return vzzzzzzzzzzzzzzzzzzzx_();
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
