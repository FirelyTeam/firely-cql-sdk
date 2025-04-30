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
[CqlLibrary("GlobalMalnutritionCompositeFHIR", "0.2.000")]
public partial class GlobalMalnutritionCompositeFHIR_0_2_000 : ILibrary, ISingleton<GlobalMalnutritionCompositeFHIR_0_2_000>
{
    private GlobalMalnutritionCompositeFHIR_0_2_000() {}

    public static GlobalMalnutritionCompositeFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "GlobalMalnutritionCompositeFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hospital Dietitian Referral", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", valueSetVersion: null)]
    public CqlValueSet Hospital_Dietitian_Referral(CqlContext _) => _Hospital_Dietitian_Referral;
    private static readonly CqlValueSet _Hospital_Dietitian_Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);

    [CqlValueSetDefinition("Malnutrition Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Diagnosis(CqlContext _) => _Malnutrition_Diagnosis;
    private static readonly CqlValueSet _Malnutrition_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", null);

    [CqlValueSetDefinition("Malnutrition Risk Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Risk_Screening(CqlContext _) => _Malnutrition_Risk_Screening;
    private static readonly CqlValueSet _Malnutrition_Risk_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", null);

    [CqlValueSetDefinition("Malnutrition Screening Finding of Not At Risk Result", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_Not_At_Risk_Result(CqlContext _) => _Malnutrition_Screening_Finding_of_Not_At_Risk_Result;
    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_Not_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", null);

    [CqlValueSetDefinition("Nutrition Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment(CqlContext _) => _Nutrition_Assessment;
    private static readonly CqlValueSet _Nutrition_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Moderately Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", null);

    [CqlValueSetDefinition("Nutrition Assessment Status Finding of Severely Malnourished", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(CqlContext _) => _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished;
    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", null);

    [CqlValueSetDefinition("Nutrition Care Plan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", valueSetVersion: null)]
    public CqlValueSet Nutrition_Care_Plan(CqlContext _) => _Nutrition_Care_Plan;
    private static readonly CqlValueSet _Nutrition_Care_Plan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

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

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.2.000", "Measurement Period", izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter EncounterInpatient)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
            Date jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "year");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 65);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DurationBetween(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "hour");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 24);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "finished");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hospital_Dietitian_Referral(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
        {
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Hospital_Dietitian_Referral(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Code<EventStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
            EventStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
                "in-progress",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) =>
            tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Malnutrition_Risk_Screening(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Contains<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, QualifyingEncounter);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Contains<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, QualifyingEncounter);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Malnutrition_Risk_Screening(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlConcept, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Contains<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, QualifyingEncounter);
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Encounter, Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Malnutrition_Risk_Screening(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlConcept, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, QualifyingEncounter);
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, QualifyingEncounter);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment and Identified Status")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<Encounter, Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Nutrition_Assessment(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlConcept, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlConcept, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlConcept, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlConcept, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Initial_Population(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CrossJoin<Encounter, Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Nutrition_Assessment(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlConcept, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        Encounter szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Nutrition_Assessment(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlConcept, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlConcept, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU, _valueTuple.Item1, _valueTuple.Item2);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
        {
            CodeableConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
            CqlConcept vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Malnutrition_Diagnosis(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) =>
            tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Nutrition_Care_Plan(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Encounter, Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
        {
            CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
            CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Nutrition_Care_Plan(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
            EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                "completed",
                "in-progress",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) =>
            tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    [CqlExpressionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
        {
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, NutritionAssessment);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, NutritionAssessment);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                return 0;
            }
            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                return ((context.Operators.Contains<Encounter>(this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context), NutritionAssessment)) ?? false
                    ? 1
                    : 0);
            }
            else
            {
                return 0;
            }
        };

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_();
    }


    [CqlExpressionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagonsis)
    {
        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
        {
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, MalnutritionDiagonsis);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, MalnutritionDiagonsis);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
            {
                return 0;
            }
            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
            {
                int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Malnutrition_Diagnosis(context);
                        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, MalnutritionDiagonsis);

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
                    };
                    if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, MalnutritionDiagonsis);

                                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ ?? false;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, MalnutritionDiagonsis);

                                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ ?? false;
                            };
                            if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                return 0;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_();
            }
            else
            {
                return 0;
            }
        };

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_();
    }


    [CqlExpressionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
        {
            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, NutritionCarePlan);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Contains<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, NutritionCarePlan);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                return 0;
            }
            else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                    {
                        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Nutrition_Care_Plan(context);
                        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Contains<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, NutritionCarePlan);

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
                    };
                    if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                    {
                        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Contains<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, NutritionCarePlan);

                                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
                            };
                            bool yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Contains<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, NutritionCarePlan);

                                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
                            };
                            if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                return 0;
                            }
                            else if (yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_();
            }
            else
            {
                return 0;
            }
        };

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Components Score")]
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_,
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_,
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_,
            yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_,
        ];
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Sum(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<int?>);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Total Malnutrition Composite Score Eligible Occurrences")]
    public int? Total_Malnutrition_Composite_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
        {
            bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, QualifyingEncounter);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            bool zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, QualifyingEncounter);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Contains<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, QualifyingEncounter);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ ?? false;
            };
            if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
            {
                return 1;
            }
            else if (zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
            {
                return 2;
            }
            else
            {
                return 4;
            }
        };

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Composite Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Composite_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(100);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Total_Malnutrition_Composite_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Divide(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        decimal? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Multiply(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU = new(
        [typeof(Encounter), typeof(Condition)],
        ["QualifyingEncounter", "MalnutritionDiagnosis"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "NutritionAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME = new(
        [typeof(Encounter), typeof(Procedure)],
        ["QualifyingEncounter", "HospitalDietitianReferral"]);

    private static CqlTupleMetadata CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI = new(
        [typeof(Encounter), typeof(Procedure)],
        ["QualifyingEncounter", "NutritionCarePlan"]);

    private static CqlTupleMetadata CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS = new(
        [typeof(Encounter), typeof(Observation)],
        ["QualifyingEncounter", "MalnutritionRiskScreening"]);

    #endregion CqlTupleMetadata Properties

}
