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
        CqlDateTime fzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzn_, true, true);
        object fzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.2.000", "Measurement Period", fzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzq_);

        return fzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? fzzzzzzzzzzzzzzzzzzy_(Encounter EncounterInpatient)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            Period gzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzb_);
            bool? gzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzc_, "day");
            Patient gzzzzzzzzzzzzzzzzzze_ = this.Patient(context);
            Date gzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzze_?.BirthDateElement;
            string gzzzzzzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDate gzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzj_);
            CqlDate gzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzk_);
            int? gzzzzzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzl_, "year");
            bool? gzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzm_, 65);
            bool? gzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzt_);
            int? gzzzzzzzzzzzzzzzzzzv_ = context.Operators.DurationBetween(gzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzu_, "hour");
            bool? gzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzv_, 24);
            bool? gzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? gzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gzzzzzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzza_, "finished");
            bool? hzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzb_);

            return hzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzy_);

        return fzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);
        CqlValueSet hzzzzzzzzzzzzzzzzzzf_ = this.Hospital_Dietitian_Referral(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> hzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Procedure>(hzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? hzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? hzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> hzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(hzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
        {
            CodeableConcept hzzzzzzzzzzzzzzzzzzq_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
            CqlConcept hzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzs_ = this.Hospital_Dietitian_Referral(context);
            bool? hzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzr_ as CqlConcept, hzzzzzzzzzzzzzzzzzzs_);
            Code<EventStatus> hzzzzzzzzzzzzzzzzzzu_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
            EventStatus? hzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzu_?.Value;
            string hzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzv_);
            string[] hzzzzzzzzzzzzzzzzzzx_ = [
                "active",
                "completed",
                "in-progress",
            ];
            bool? hzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzy_);
            DataType izzzzzzzzzzzzzzzzzza_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
            object izzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
            bool? izzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzd_, default);
            bool? izzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzze_);

            return izzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> hzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(hzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzk_);
        Encounter hzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) =>
            tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(hzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(hzzzzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        CqlValueSet izzzzzzzzzzzzzzzzzzh_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> izzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, Observation>(izzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? izzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? izzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> izzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(izzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept izzzzzzzzzzzzzzzzzzs_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept izzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzs_);
            CqlValueSet izzzzzzzzzzzzzzzzzzu_ = this.Malnutrition_Risk_Screening(context);
            bool? izzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzt_ as CqlConcept, izzzzzzzzzzzzzzzzzzu_);
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzw_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzzzx_ = izzzzzzzzzzzzzzzzzzw_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzx_);
            string izzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzy_);
            string[] jzzzzzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(izzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType jzzzzzzzzzzzzzzzzzze_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object jzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzg_, default);
            bool? jzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzh_);
            DataType jzzzzzzzzzzzzzzzzzzj_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object jzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzl_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? jzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzk_ as CqlConcept, jzzzzzzzzzzzzzzzzzzl_);
            object jzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzp_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? jzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzo_ as CqlConcept, jzzzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzq_);
            bool? jzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> izzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(izzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzm_);
        Encounter izzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(izzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);
        bool? jzzzzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? kzzzzzzzzzzzzzzzzzza_ = context.Operators.Contains<Encounter>(jzzzzzzzzzzzzzzzzzzz_, QualifyingEncounter);
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? kzzzzzzzzzzzzzzzzzzc_ = context.Operators.Contains<Encounter>(kzzzzzzzzzzzzzzzzzzb_, QualifyingEncounter);
            bool? kzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzu_);
        Encounter jzzzzzzzzzzzzzzzzzzw_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);
        CqlValueSet kzzzzzzzzzzzzzzzzzzf_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> kzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Observation>(kzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? kzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? kzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> kzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(kzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept kzzzzzzzzzzzzzzzzzzq_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept kzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzs_ = this.Malnutrition_Risk_Screening(context);
            bool? kzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzr_ as CqlConcept, kzzzzzzzzzzzzzzzzzzs_);
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzu_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzv_);
            string kzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzw_);
            string[] kzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType lzzzzzzzzzzzzzzzzzzc_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object lzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzze_, default);
            bool? lzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(lzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzf_);
            DataType lzzzzzzzzzzzzzzzzzzh_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object lzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzj_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? lzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzi_ as CqlConcept, lzzzzzzzzzzzzzzzzzzj_);
            bool? lzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> kzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(kzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzk_);
        Encounter kzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(kzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(kzzzzzzzzzzzzzzzzzzn_);

        return kzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);
        bool? lzzzzzzzzzzzzzzzzzzn_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? lzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<Encounter>(lzzzzzzzzzzzzzzzzzzs_, QualifyingEncounter);
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? lzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(lzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzw_);

            return lzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzn_);
        Encounter lzzzzzzzzzzzzzzzzzzp_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        CqlValueSet lzzzzzzzzzzzzzzzzzzz_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> mzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, Observation>(lzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? mzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? mzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> mzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(mzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept mzzzzzzzzzzzzzzzzzzk_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept mzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzm_ = this.Malnutrition_Risk_Screening(context);
            bool? mzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzl_ as CqlConcept, mzzzzzzzzzzzzzzzzzzm_);
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzo_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzp_);
            string mzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzq_);
            string[] mzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType mzzzzzzzzzzzzzzzzzzw_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object mzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzx_);
            bool? mzzzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzy_, default);
            bool? nzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzz_);
            DataType nzzzzzzzzzzzzzzzzzzb_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object nzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzd_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? nzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzc_ as CqlConcept, nzzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzze_);

            return nzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> mzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(mzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzze_);
        Encounter mzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(mzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);
        bool? nzzzzzzzzzzzzzzzzzzh_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? nzzzzzzzzzzzzzzzzzzn_ = context.Operators.Contains<Encounter>(nzzzzzzzzzzzzzzzzzzm_, QualifyingEncounter);
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? nzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(nzzzzzzzzzzzzzzzzzzo_, QualifyingEncounter);
            bool? nzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzh_);
        Encounter nzzzzzzzzzzzzzzzzzzj_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment and Identified Status")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        CqlValueSet nzzzzzzzzzzzzzzzzzzs_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> nzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Encounter, Observation>(nzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? nzzzzzzzzzzzzzzzzzzv_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? ozzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> nzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(nzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept ozzzzzzzzzzzzzzzzzzd_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept ozzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzd_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzf_ = this.Nutrition_Assessment(context);
            bool? ozzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzze_ as CqlConcept, ozzzzzzzzzzzzzzzzzzf_);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzh_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzi_);
            string ozzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzj_);
            string[] ozzzzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType ozzzzzzzzzzzzzzzzzzp_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object ozzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzq_);
            bool? ozzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzr_, default);
            bool? ozzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzs_);
            DataType ozzzzzzzzzzzzzzzzzzu_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object ozzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzu_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzw_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? ozzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzv_ as CqlConcept, ozzzzzzzzzzzzzzzzzzw_);
            object ozzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzu_);
            CqlValueSet pzzzzzzzzzzzzzzzzzza_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? pzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzz_ as CqlConcept, pzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzb_);
            object pzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzu_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzf_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? pzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzze_ as CqlConcept, pzzzzzzzzzzzzzzzzzzf_);
            bool? pzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzg_);
            bool? pzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzh_);

            return pzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> nzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(nzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzx_);
        Encounter nzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(nzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);
        CqlValueSet pzzzzzzzzzzzzzzzzzzk_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> pzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Observation>(pzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? pzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? pzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(pzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept pzzzzzzzzzzzzzzzzzzv_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept pzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzx_ = this.Nutrition_Assessment(context);
            bool? pzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzw_ as CqlConcept, pzzzzzzzzzzzzzzzzzzx_);
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzz_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzza_ = pzzzzzzzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzza_);
            string qzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzb_);
            string[] qzzzzzzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType qzzzzzzzzzzzzzzzzzzh_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object qzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzi_);
            bool? qzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzj_, default);
            bool? qzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzk_);
            DataType qzzzzzzzzzzzzzzzzzzm_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object qzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzo_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? qzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzn_ as CqlConcept, qzzzzzzzzzzzzzzzzzzo_);
            object qzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzs_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? qzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzr_ as CqlConcept, qzzzzzzzzzzzzzzzzzzs_);
            bool? qzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzu_);

            return qzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> pzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(pzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzp_);
        Encounter pzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(pzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);
        CqlValueSet qzzzzzzzzzzzzzzzzzzx_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> qzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, Observation>(qzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? rzzzzzzzzzzzzzzzzzza_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? rzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return rzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> rzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(qzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept rzzzzzzzzzzzzzzzzzzi_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept rzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzi_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzk_ = this.Nutrition_Assessment(context);
            bool? rzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzj_ as CqlConcept, rzzzzzzzzzzzzzzzzzzk_);
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzm_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzn_);
            string rzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzo_);
            string[] rzzzzzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType rzzzzzzzzzzzzzzzzzzu_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object rzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzv_);
            bool? rzzzzzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzw_, default);
            bool? rzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzx_);
            DataType rzzzzzzzzzzzzzzzzzzz_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object szzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet szzzzzzzzzzzzzzzzzzb_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? szzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzza_ as CqlConcept, szzzzzzzzzzzzzzzzzzb_);
            bool? szzzzzzzzzzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzc_);

            return szzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> rzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(rzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzc_);
        Encounter rzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(rzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzf_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> szzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, Condition>(szzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? szzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? szzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> szzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(szzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
        {
            CodeableConcept szzzzzzzzzzzzzzzzzzq_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
            CqlConcept szzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzq_);
            CqlValueSet szzzzzzzzzzzzzzzzzzs_ = this.Malnutrition_Diagnosis(context);
            bool? szzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzr_ as CqlConcept, szzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
            bool? szzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzv_, default);
            bool? szzzzzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzw_);

            return szzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> szzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(szzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzk_);
        Encounter szzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) =>
            tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(szzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzz_ = this.Nutrition_Care_Plan(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> tzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, Procedure>(szzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> tzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(tzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
        {
            CodeableConcept tzzzzzzzzzzzzzzzzzzk_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
            CqlConcept tzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzk_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzm_ = this.Nutrition_Care_Plan(context);
            bool? tzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzl_ as CqlConcept, tzzzzzzzzzzzzzzzzzzm_);
            Code<EventStatus> tzzzzzzzzzzzzzzzzzzo_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
            EventStatus? tzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzo_?.Value;
            string tzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzp_);
            string[] tzzzzzzzzzzzzzzzzzzr_ = [
                "completed",
                "in-progress",
            ];
            bool? tzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzs_);
            DataType tzzzzzzzzzzzzzzzzzzu_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
            object tzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
            bool? tzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzx_, default);
            bool? tzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzy_);

            return tzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> tzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(tzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzze_);
        Encounter tzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) =>
            tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(tzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzzzzh_);

        return tzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    [CqlExpressionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? uzzzzzzzzzzzzzzzzzza_()
        {
            bool uzzzzzzzzzzzzzzzzzzb_()
            {
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? uzzzzzzzzzzzzzzzzzze_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzd_, NutritionAssessment);

                return uzzzzzzzzzzzzzzzzzze_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzc_()
            {
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? uzzzzzzzzzzzzzzzzzzg_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzf_, NutritionAssessment);

                return uzzzzzzzzzzzzzzzzzzg_ ?? false;
            };
            if (uzzzzzzzzzzzzzzzzzzb_())
            {
                return 0;
            }
            else if (uzzzzzzzzzzzzzzzzzzc_())
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

        return uzzzzzzzzzzzzzzzzzza_();
    }


    [CqlExpressionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagonsis)
    {
        int? uzzzzzzzzzzzzzzzzzzh_()
        {
            bool uzzzzzzzzzzzzzzzzzzi_()
            {
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? uzzzzzzzzzzzzzzzzzzl_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzk_, MalnutritionDiagonsis);

                return uzzzzzzzzzzzzzzzzzzl_ ?? false;
            };
            bool uzzzzzzzzzzzzzzzzzzj_()
            {
                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? uzzzzzzzzzzzzzzzzzzn_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzm_, MalnutritionDiagonsis);

                return uzzzzzzzzzzzzzzzzzzn_ ?? false;
            };
            if (uzzzzzzzzzzzzzzzzzzi_())
            {
                return 0;
            }
            else if (uzzzzzzzzzzzzzzzzzzj_())
            {
                int? uzzzzzzzzzzzzzzzzzzo_()
                {
                    bool uzzzzzzzzzzzzzzzzzzp_()
                    {
                        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Malnutrition_Diagnosis(context);
                        bool? uzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzq_, MalnutritionDiagonsis);

                        return uzzzzzzzzzzzzzzzzzzr_ ?? false;
                    };
                    if (uzzzzzzzzzzzzzzzzzzp_())
                    {
                        int? uzzzzzzzzzzzzzzzzzzs_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzt_()
                            {
                                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? uzzzzzzzzzzzzzzzzzzw_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzv_, MalnutritionDiagonsis);

                                return uzzzzzzzzzzzzzzzzzzw_ ?? false;
                            };
                            bool uzzzzzzzzzzzzzzzzzzu_()
                            {
                                IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? uzzzzzzzzzzzzzzzzzzy_ = context.Operators.Contains<Encounter>(uzzzzzzzzzzzzzzzzzzx_, MalnutritionDiagonsis);

                                return uzzzzzzzzzzzzzzzzzzy_ ?? false;
                            };
                            if (uzzzzzzzzzzzzzzzzzzt_())
                            {
                                return 0;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzu_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return uzzzzzzzzzzzzzzzzzzs_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return uzzzzzzzzzzzzzzzzzzo_();
            }
            else
            {
                return 0;
            }
        };

        return uzzzzzzzzzzzzzzzzzzh_();
    }


    [CqlExpressionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        int? uzzzzzzzzzzzzzzzzzzz_()
        {
            bool vzzzzzzzzzzzzzzzzzza_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzd_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzc_, NutritionCarePlan);

                return vzzzzzzzzzzzzzzzzzzd_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzb_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzze_, NutritionCarePlan);

                return vzzzzzzzzzzzzzzzzzzf_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzza_())
            {
                return 0;
            }
            else if (vzzzzzzzzzzzzzzzzzzb_())
            {
                int? vzzzzzzzzzzzzzzzzzzg_()
                {
                    bool vzzzzzzzzzzzzzzzzzzh_()
                    {
                        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Nutrition_Care_Plan(context);
                        bool? vzzzzzzzzzzzzzzzzzzj_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzi_, NutritionCarePlan);

                        return vzzzzzzzzzzzzzzzzzzj_ ?? false;
                    };
                    if (vzzzzzzzzzzzzzzzzzzh_())
                    {
                        int? vzzzzzzzzzzzzzzzzzzk_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzl_()
                            {
                                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? vzzzzzzzzzzzzzzzzzzo_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzn_, NutritionCarePlan);

                                return vzzzzzzzzzzzzzzzzzzo_ ?? false;
                            };
                            bool vzzzzzzzzzzzzzzzzzzm_()
                            {
                                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? vzzzzzzzzzzzzzzzzzzq_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzp_, NutritionCarePlan);

                                return vzzzzzzzzzzzzzzzzzzq_ ?? false;
                            };
                            if (vzzzzzzzzzzzzzzzzzzl_())
                            {
                                return 0;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzm_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return vzzzzzzzzzzzzzzzzzzk_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return vzzzzzzzzzzzzzzzzzzg_();
            }
            else
            {
                return 0;
            }
        };

        return uzzzzzzzzzzzzzzzzzzz_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Components Score")]
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? vzzzzzzzzzzzzzzzzzzr_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? vzzzzzzzzzzzzzzzzzzs_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? vzzzzzzzzzzzzzzzzzzt_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? vzzzzzzzzzzzzzzzzzzu_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] vzzzzzzzzzzzzzzzzzzv_ = [
            vzzzzzzzzzzzzzzzzzzr_,
            vzzzzzzzzzzzzzzzzzzs_,
            vzzzzzzzzzzzzzzzzzzt_,
            vzzzzzzzzzzzzzzzzzzu_,
        ];
        int? vzzzzzzzzzzzzzzzzzzw_ = context.Operators.Sum(vzzzzzzzzzzzzzzzzzzv_ as IEnumerable<int?>);

        return vzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Total Malnutrition Composite Score Eligible Occurrences")]
    public int? Total_Malnutrition_Composite_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? vzzzzzzzzzzzzzzzzzzx_()
        {
            bool vzzzzzzzzzzzzzzzzzzy_()
            {
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzza_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzb_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzza_, QualifyingEncounter);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? wzzzzzzzzzzzzzzzzzzd_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzc_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzd_);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzg_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzf_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzg_);
                bool? wzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzh_);

                return wzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzz_()
            {
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzk_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzj_, QualifyingEncounter);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? wzzzzzzzzzzzzzzzzzzm_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzl_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzm_);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzo_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzp_);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                bool? wzzzzzzzzzzzzzzzzzzs_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzr_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzs_);
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
                bool? wzzzzzzzzzzzzzzzzzzv_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzu_, QualifyingEncounter);
                bool? wzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzw_);

                return wzzzzzzzzzzzzzzzzzzx_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzzy_())
            {
                return 1;
            }
            else if (vzzzzzzzzzzzzzzzzzzz_())
            {
                return 2;
            }
            else
            {
                return 4;
            }
        };

        return vzzzzzzzzzzzzzzzzzzx_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Composite Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Composite_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? wzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(100);
        int? wzzzzzzzzzzzzzzzzzzz_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? xzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertIntegerToDecimal(wzzzzzzzzzzzzzzzzzzz_);
        int? xzzzzzzzzzzzzzzzzzzb_ = this.Total_Malnutrition_Composite_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? xzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(xzzzzzzzzzzzzzzzzzzb_);
        decimal? xzzzzzzzzzzzzzzzzzzd_ = context.Operators.Divide(xzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzc_);
        decimal? xzzzzzzzzzzzzzzzzzze_ = context.Operators.Multiply(wzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzzzzzzzze_;
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
