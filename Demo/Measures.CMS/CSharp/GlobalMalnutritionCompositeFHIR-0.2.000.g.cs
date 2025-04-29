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
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.ResolveParameter("GlobalMalnutritionCompositeFHIR-0.2.000", "Measurement Period", gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterInpatient)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "year");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, 65);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DurationBetween(hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "hour");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, 24);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzze_, "finished");
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Measure Population")]
    public IEnumerable<Encounter> Measure_Population(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Hospital_Dietitian_Referral(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> izzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? izzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? izzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GVQcZJVjNdGAcjPedLaYDjEME, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa)
        {
            CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Code;
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hospital_Dietitian_Referral(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, izzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Code<EventStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.StatusElement;
            EventStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                "active",
                "completed",
                "in-progress",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_blodcpfeecjfnodfofhfzlqfa?.HospitalDietitianReferral?.Performed;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        Encounter izzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)? tuple_blodcpfeecjfnodfofhfzlqfa) =>
            tuple_blodcpfeecjfnodfofhfzlqfa?.QualifyingEncounter;
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure HospitalDietitianReferral)?, Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_Population(context);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<Encounter, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Malnutrition_Risk_Screening(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlConcept, jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlConcept, kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlConcept, kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Initial_Population(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Malnutrition_Risk_Screening(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Contains<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, QualifyingEncounter);
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Contains<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, QualifyingEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening Not At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Malnutrition_Risk_Screening(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Malnutrition_Screening_Finding_of_Not_At_Risk_Result(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlConcept, mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        Encounter lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Contains<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, QualifyingEncounter);
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Malnutrition_Risk_Screening(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CrossJoin<Encounter, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_XadcRffdjUdMDMjcTIdSXKKS, _valueTuple.Item1, _valueTuple.Item2);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb)
        {
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Code;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Malnutrition_Risk_Screening(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_bejjtwegpxjsnajsodybefddb?.MalnutritionRiskScreening?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Malnutrition_Screening_Finding_of_At_Risk_Result(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlConcept, ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)? tuple_bejjtwegpxjsnajsodybefddb) =>
            tuple_bejjtwegpxjsnajsodybefddb?.QualifyingEncounter;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation MalnutritionRiskScreening)?, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_Population(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_, QualifyingEncounter);
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_, QualifyingEncounter);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter QualifyingEncounter) =>
            QualifyingEncounter;
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment and Identified Status")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_and_Identified_Status(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<Encounter, Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Nutrition_Assessment(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlConcept, qzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlConcept, qzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlConcept, qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Initial_Population(context);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CrossJoin<Encounter, Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Nutrition_Assessment(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlConcept, rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Nutrition_Assessment_Status_Finding_of_Moderately_Malnourished(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlConcept, rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Nutrition_Assessment_Status_Finding_of_Severely_Malnourished(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Assessment Not or Mildly Malnourished")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Nutrition_Assessment(context);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<ValueTuple<Encounter, Observation>> szzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Encounter, Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? szzzzzzzzzzzzzzzzzzzzzzzzzzze_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? szzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_GFjZJIRJbJMHZiLMbCVCEiHgh, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne)
        {
            CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Code;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Nutrition_Assessment(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlConcept, szzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.StatusElement;
            ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string szzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_hhhypfjvjujitmizocefugcne?.NutritionAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Nutrition_Assessment_Status_Finding_of_Well_Nourished_or_Not_Malnourished_or_Mildly_Malnourished(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlConcept, tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        Encounter szzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)? tuple_hhhypfjvjujitmizocefugcne) =>
            tuple_hhhypfjvjujitmizocefugcne?.QualifyingEncounter;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation NutritionAssessment)?, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with Malnutrition Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Malnutrition_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Malnutrition_Diagnosis(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<ValueTuple<Encounter, Condition>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Encounter, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_CTGXhDDGNAgcaKfhTDIBGVLYU, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, Condition>, (CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn)
        {
            CodeableConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis?.Code;
            CqlConcept tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Malnutrition_Diagnosis(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlConcept, tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, tuple_gsigyornrkjgexbhejviwntmn?.MalnutritionDiagnosis);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Overlaps(tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)? tuple_gsigyornrkjgexbhejviwntmn) =>
            tuple_gsigyornrkjgexbhejviwntmn?.QualifyingEncounter;
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Condition MalnutritionDiagnosis)?, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Nutrition Care Plan")]
    public IEnumerable<Encounter> Encounter_with_Nutrition_Care_Plan(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Nutrition_Care_Plan(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<ValueTuple<Encounter, Procedure>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CrossJoin<Encounter, Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ValueTuple<Encounter, Procedure> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_TVETjQTNGSKUhAIhIbeKTXMI, _valueTuple.Item1, _valueTuple.Item2);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, Procedure>, (CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm)
        {
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Code;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Nutrition_Care_Plan(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Code<EventStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.StatusElement;
            EventStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                "completed",
                "in-progress",
            ];
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_igutmwhaufjcwzmijcgjeysm?.NutritionCarePlan?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservation(context, tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)? tuple_igutmwhaufjcwzmijcgjeysm) =>
            tuple_igutmwhaufjcwzmijcgjeysm?.QualifyingEncounter;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Procedure NutritionCarePlan)?, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Measure Observation 1")]
    public int? Measure_Observation_1(CqlContext context, Encounter MalnutritionRiskScreening) =>
        ((context.Operators.Contains<Encounter>(this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context), MalnutritionRiskScreening)) ?? false
            ? 1
            : 0);


    [CqlExpressionDefinition("Measure Observation 2")]
    public int? Measure_Observation_2(CqlContext context, Encounter NutritionAssessment)
    {
        int? vzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
        {
            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, NutritionAssessment);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, NutritionAssessment);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
            {
                return 0;
            }
            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
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

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzze_();
    }


    [CqlExpressionDefinition("Measure Observation 3")]
    public int? Measure_Observation_3(CqlContext context, Encounter MalnutritionDiagonsis)
    {
        int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
        {
            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, MalnutritionDiagonsis);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ ?? false;
            };
            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
            {
                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, MalnutritionDiagonsis);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ ?? false;
            };
            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
            {
                return 0;
            }
            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
            {
                int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                    {
                        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Malnutrition_Diagnosis(context);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, MalnutritionDiagonsis);

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ ?? false;
                    };
                    if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                    {
                        int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Contains<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, MalnutritionDiagonsis);

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzza_ ?? false;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, MalnutritionDiagonsis);

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ ?? false;
                            };
                            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                return 0;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_();
            }
            else
            {
                return 0;
            }
        };

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_();
    }


    [CqlExpressionDefinition("Measure Observation 4")]
    public int? Measure_Observation_4(CqlContext context, Encounter NutritionCarePlan)
    {
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
        {
            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
            {
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Malnutrition_Not_At_Risk_Screening_and_without_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, NutritionCarePlan);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ ?? false;
            };
            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
            {
                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk_or_with_Hospital_Dietitian_Referral(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, NutritionCarePlan);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? false;
            };
            if (wzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
            {
                return 0;
            }
            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
            {
                int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Encounter_with_Nutrition_Care_Plan(context);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, NutritionCarePlan);

                        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ ?? false;
                    };
                    if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, NutritionCarePlan);

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ ?? false;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Nutrition_Assessment_Status_Moderately_Or_Severely_Malnourished(context);
                                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Contains<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, NutritionCarePlan);

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ ?? false;
                            };
                            if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                return 0;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        };

                        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_();
                    }
                    else
                    {
                        return 0;
                    }
                };

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzk_();
            }
            else
            {
                return 0;
            }
        };

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Components Score")]
    public int? Measure_Observation_Total_Malnutrition_Components_Score(CqlContext context, Encounter QualifyingEncounter)
    {
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measure_Observation_1(context, QualifyingEncounter);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measure_Observation_2(context, QualifyingEncounter);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measure_Observation_3(context, QualifyingEncounter);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measure_Observation_4(context, QualifyingEncounter);
        int?[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
            wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_,
            wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_,
            wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_,
            wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_,
        ];
        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Sum(wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<int?>);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Total Malnutrition Composite Score Eligible Occurrences")]
    public int? Total_Malnutrition_Composite_Score_Eligible_Occurrences(CqlContext context, Encounter QualifyingEncounter)
    {
        int? xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
        {
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzze_, QualifyingEncounter);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Malnutrition_Risk_Screening_Not_At_Risk(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, QualifyingEncounter);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, QualifyingEncounter);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ ?? false;
            };
            bool xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
            {
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Encounter_with_Malnutrition_Risk_Screening_or_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, QualifyingEncounter);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Malnutrition_Risk_Screening_At_Risk(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, QualifyingEncounter);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_with_Hospital_Dietitian_Referral(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, QualifyingEncounter);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_Nutrition_Assessment_Not_or_Mildly_Malnourished(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, QualifyingEncounter);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Nutrition_Assessment_and_Identified_Status(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Contains<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, QualifyingEncounter);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ ?? false;
            };
            if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
            {
                return 1;
            }
            else if (xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
            {
                return 2;
            }
            else
            {
                return 4;
            }
        };

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_();
    }


    [CqlExpressionDefinition("Measure Observation Total Malnutrition Composite Score as Percentage")]
    public decimal? Measure_Observation_Total_Malnutrition_Composite_Score_as_Percentage(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertIntegerToDecimal(100);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measure_Observation_Total_Malnutrition_Components_Score(context, QualifyingEncounter);
        decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        int? yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Total_Malnutrition_Composite_Score_Eligible_Occurrences(context, QualifyingEncounter);
        decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Divide(yzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        decimal? yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Multiply(yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
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
