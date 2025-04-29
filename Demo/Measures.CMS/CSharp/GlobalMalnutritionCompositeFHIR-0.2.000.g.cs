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

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: Hospital Dietitian Referral
    [CqlValueSetDefinition(
        definitionName: "Hospital Dietitian Referral",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91",
        valueSetVersion: null)]
    public CqlValueSet Hospital_Dietitian_Referral(CqlContext context) => _Hospital_Dietitian_Referral;

    private static readonly CqlValueSet _Hospital_Dietitian_Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91", null);
    #endregion

    #region ValueSet: Malnutrition Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Malnutrition Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55",
        valueSetVersion: null)]
    public CqlValueSet Malnutrition_Diagnosis(CqlContext context) => _Malnutrition_Diagnosis;

    private static readonly CqlValueSet _Malnutrition_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55", null);
    #endregion

    #region ValueSet: Malnutrition Risk Screening
    [CqlValueSetDefinition(
        definitionName: "Malnutrition Risk Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92",
        valueSetVersion: null)]
    public CqlValueSet Malnutrition_Risk_Screening(CqlContext context) => _Malnutrition_Risk_Screening;

    private static readonly CqlValueSet _Malnutrition_Risk_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92", null);
    #endregion

    #region ValueSet: Malnutrition Screening Finding of At Risk Result
    [CqlValueSetDefinition(
        definitionName: "Malnutrition Screening Finding of At Risk Result",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89",
        valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_At_Risk_Result(CqlContext context) => _Malnutrition_Screening_Finding_of_At_Risk_Result;

    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89", null);
    #endregion

    #region ValueSet: Malnutrition Screening Finding of Not At Risk Result
    [CqlValueSetDefinition(
        definitionName: "Malnutrition Screening Finding of Not At Risk Result",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34",
        valueSetVersion: null)]
    public CqlValueSet Malnutrition_Screening_Finding_of_Not_At_Risk_Result(CqlContext context) => _Malnutrition_Screening_Finding_of_Not_At_Risk_Result;

    private static readonly CqlValueSet _Malnutrition_Screening_Finding_of_Not_At_Risk_Result = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34", null);
    #endregion

    #region ValueSet: Nutrition Assessment
    [CqlValueSetDefinition(
        definitionName: "Nutrition Assessment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment(CqlContext context) => _Nutrition_Assessment;

    private static readonly CqlValueSet _Nutrition_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21", null);
    #endregion

    #region ValueSet: Nutrition Assessment Status Finding of Moderately Malnourished
    [CqlValueSetDefinition(
        definitionName: "Nutrition Assessment Status Finding of Moderately Malnourished",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(CqlContext context) => _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished;

    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47", null);
    #endregion

    #region ValueSet: Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished
    [CqlValueSetDefinition(
        definitionName: "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(CqlContext context) => _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished;

    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96", null);
    #endregion

    #region ValueSet: Nutrition Assessment Status Finding of Severely Malnourished
    [CqlValueSetDefinition(
        definitionName: "Nutrition Assessment Status Finding of Severely Malnourished",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(CqlContext context) => _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished;

    private static readonly CqlValueSet _Nutrition_Assessment_Status_Finding_of_Severely_Malnourished = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43", null);
    #endregion

    #region ValueSet: Nutrition Care Plan
    [CqlValueSetDefinition(
        definitionName: "Nutrition Care Plan",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Care_Plan(CqlContext context) => _Nutrition_Care_Plan;

    private static readonly CqlValueSet _Nutrition_Care_Plan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Payer Type
    [CqlValueSetDefinition(
        definitionName: "Payer Type",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext context) => _Payer_Type;

    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
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
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = []
;

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = []
;

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.2.000", "Measurement Period", czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterInpatient)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Patient(context);
            Date dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.BirthDateElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            int? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, 65);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DurationBetween(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "hour");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, 24);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "finished");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hospital_Dietitian_Referral(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Procedure>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
        {
            CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hospital_Dietitian_Referral(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Code<EventStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
            EventStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
                "in-progress",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) =>
            tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Initial_Population(context);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CrossJoin<Encounter, Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Malnutrition_Risk_Screening(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlConcept, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        Encounter fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, QualifyingEncounter);
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Contains<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, QualifyingEncounter);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        Encounter hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Malnutrition_Risk_Screening(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Contains<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, QualifyingEncounter);
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        Encounter izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.CrossJoin<Encounter, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Malnutrition_Risk_Screening(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlConcept, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Initial_Population(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Contains<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, QualifyingEncounter);
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, QualifyingEncounter);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Nutrition Assessment and Identified Status")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Nutrition_Assessment(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlConcept, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Nutrition_Assessment(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlConcept, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlConcept, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Nutrition Assessment Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population(context);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<Encounter, Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Nutrition_Assessment(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlConcept, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
        {
            CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Malnutrition_Diagnosis(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) =>
            tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Nutrition_Care_Plan(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.CrossJoin<Encounter, Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI, _valueTuple.Item1, _valueTuple.Item2);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
        {
            CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Nutrition_Care_Plan(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "completed",
                "in-progress",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) =>
            tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
        {
            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Contains<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, NutritionAssessment);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
            {
                IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Contains<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, NutritionAssessment);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
            {
                return 0;
            }
            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
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

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagonsis)
    {
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
        {
            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
            {
                IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Contains<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, MalnutritionDiagonsis);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? false;
            };
            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Contains<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, MalnutritionDiagonsis);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
            };
            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
            {
                return 0;
            }
            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
            {
                int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Malnutrition_Diagnosis(context);
                        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Contains<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, MalnutritionDiagonsis);

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ ?? false;
                    };
                    if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, MalnutritionDiagonsis);

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, MalnutritionDiagonsis);

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ ?? false;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                return 0;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_();
            }
            else
            {
                return 0;
            }
        };

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
        {
            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, NutritionCarePlan);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, NutritionCarePlan);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
            {
                return 0;
            }
            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
            {
                int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                    {
                        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Nutrition_Care_Plan(context);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, NutritionCarePlan);

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ ?? false;
                    };
                    if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                    {
                        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, NutritionCarePlan);

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ ?? false;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Contains<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, NutritionCarePlan);

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? false;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                return 0;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_();
            }
            else
            {
                return 0;
            }
        };

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
            szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_,
            szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_,
            szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_,
            szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_,
        ];
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Sum(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<int?>);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? Total_Malnutrition_Composite_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
        {
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, QualifyingEncounter);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, QualifyingEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, QualifyingEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, QualifyingEncounter);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, QualifyingEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, QualifyingEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, QualifyingEncounter);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Contains<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, QualifyingEncounter);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
            };
            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                return 1;
            }
            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                return 2;
            }
            else
            {
                return 4;
            }
        };

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? Measure_Observation_Total_Malnutrition_Composite_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(100);
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Total_Malnutrition_Composite_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        decimal? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Divide(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        decimal? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Multiply(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
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
