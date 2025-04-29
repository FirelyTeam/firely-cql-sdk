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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.0.015")]
public partial class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015 : ILibrary, ISingleton<DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015>
{
    private DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015() {}

    public static DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DiabetesHemoglobinA1cHbA1cPoorControl9FHIR";
    public string Version => "0.0.015";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, PalliativeCareFHIR_0_6_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, HospiceFHIR4_2_3_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("HbA1c Laboratory Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext _) => _HbA1c_Laboratory_Test;
    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

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
        object ozzzzzzzzzo_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzp_);

        return ozzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzv_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ozzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? ozzzzzzzzzx_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> ozzzzzzzzzz_ = TelehealthEncounter?.StatusElement;
            string pzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzz_);
            bool? pzzzzzzzzzb_ = context.Operators.Equal(pzzzzzzzzza_, "finished");
            CqlInterval<CqlDateTime> pzzzzzzzzzc_ = this.Measurement_Period(context);
            Period pzzzzzzzzzd_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzd_ as object);
            bool? pzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzc_, pzzzzzzzzze_, default);
            bool? pzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzb_, pzzzzzzzzzf_);

            return pzzzzzzzzzg_;
        };
        IEnumerable<Encounter> ozzzzzzzzzy_ = context.Operators.Where<Encounter>(ozzzzzzzzzw_, ozzzzzzzzzx_);

        return ozzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzh_ = this.Patient(context);
        Date pzzzzzzzzzi_ = pzzzzzzzzzh_?.BirthDateElement;
        string pzzzzzzzzzj_ = pzzzzzzzzzi_?.Value;
        CqlDate pzzzzzzzzzk_ = context.Operators.ConvertStringToDate(pzzzzzzzzzj_);
        CqlInterval<CqlDateTime> pzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzl_);
        CqlDate pzzzzzzzzzn_ = context.Operators.DateFrom(pzzzzzzzzzm_);
        int? pzzzzzzzzzo_ = context.Operators.CalculateAgeAt(pzzzzzzzzzk_, pzzzzzzzzzn_, "year");
        CqlInterval<int?> pzzzzzzzzzp_ = context.Operators.Interval(18, 75, true, false);
        bool? pzzzzzzzzzq_ = context.Operators.In<int?>(pzzzzzzzzzo_, pzzzzzzzzzp_, default);
        IEnumerable<Encounter> pzzzzzzzzzr_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> pzzzzzzzzzs_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzt_ = context.Operators.Union<Encounter>(pzzzzzzzzzr_, pzzzzzzzzzs_);
        bool? pzzzzzzzzzu_ = context.Operators.Exists<Encounter>(pzzzzzzzzzt_);
        bool? pzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzq_, pzzzzzzzzzu_);
        CqlValueSet pzzzzzzzzzw_ = this.Diabetes(context);
        IEnumerable<Condition> pzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzzzzzzzzzy_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> qzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? qzzzzzzzzze_ = context.Operators.Overlaps(qzzzzzzzzzc_, qzzzzzzzzzd_, default);

            return qzzzzzzzzze_;
        };
        IEnumerable<Condition> pzzzzzzzzzz_ = context.Operators.Where<Condition>(pzzzzzzzzzx_, pzzzzzzzzzy_);
        bool? qzzzzzzzzza_ = context.Operators.Exists<Condition>(pzzzzzzzzzz_);
        bool? qzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzv_, qzzzzzzzzza_);

        return qzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzf_ = this.Initial_Population(context);

        return qzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzg_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> qzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzi_(Observation RecentHbA1c)
        {
            Code<ObservationStatus> qzzzzzzzzzn_ = RecentHbA1c?.StatusElement;
            string qzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzn_);
            string[] qzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzq_ = context.Operators.In<string>(qzzzzzzzzzo_, qzzzzzzzzzp_ as IEnumerable<string>);
            DataType qzzzzzzzzzr_ = RecentHbA1c?.Effective;
            CqlDateTime qzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, qzzzzzzzzzr_);
            CqlInterval<CqlDateTime> qzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzs_, qzzzzzzzzzt_, default);
            bool? qzzzzzzzzzv_ = context.Operators.And(qzzzzzzzzzq_, qzzzzzzzzzu_);

            return qzzzzzzzzzv_;
        };
        IEnumerable<Observation> qzzzzzzzzzj_ = context.Operators.Where<Observation>(qzzzzzzzzzh_, qzzzzzzzzzi_);
        object qzzzzzzzzzk_(Observation @this)
        {
            DataType qzzzzzzzzzw_ = @this?.Effective;
            CqlInterval<CqlDateTime> qzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzw_);
            CqlDateTime qzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzx_);

            return qzzzzzzzzzy_;
        };
        IEnumerable<Observation> qzzzzzzzzzl_ = context.Operators.SortBy<Observation>(qzzzzzzzzzj_, qzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation qzzzzzzzzzm_ = context.Operators.Last<Observation>(qzzzzzzzzzl_);

        return qzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
    {
        Observation qzzzzzzzzzz_ = this.Most_Recent_HbA1c(context);
        bool? rzzzzzzzzza_ = context.Operators.Not((bool?)(qzzzzzzzzzz_ is null));
        DataType rzzzzzzzzzc_ = qzzzzzzzzzz_?.Value;
        bool? rzzzzzzzzzd_ = context.Operators.And(rzzzzzzzzza_, (bool?)(rzzzzzzzzzc_ is null));

        return rzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
    {
        Observation rzzzzzzzzze_ = this.Most_Recent_HbA1c(context);
        DataType rzzzzzzzzzf_ = rzzzzzzzzze_?.Value;
        CqlQuantity rzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzzzzzzzzf_ as Quantity);
        CqlQuantity rzzzzzzzzzh_ = context.Operators.Quantity(9m, "%");
        bool? rzzzzzzzzzi_ = context.Operators.Greater(rzzzzzzzzzg_, rzzzzzzzzzh_);

        return rzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzj_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> rzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzl_(Observation NoHbA1c)
        {
            Code<ObservationStatus> rzzzzzzzzzp_ = NoHbA1c?.StatusElement;
            string rzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzp_);
            string[] rzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzs_ = context.Operators.In<string>(rzzzzzzzzzq_, rzzzzzzzzzr_ as IEnumerable<string>);
            DataType rzzzzzzzzzt_ = NoHbA1c?.Effective;
            CqlDateTime rzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzzzzzzt_);
            CqlInterval<CqlDateTime> rzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzu_, rzzzzzzzzzv_, default);
            bool? rzzzzzzzzzx_ = context.Operators.And(rzzzzzzzzzs_, rzzzzzzzzzw_);

            return rzzzzzzzzzx_;
        };
        IEnumerable<Observation> rzzzzzzzzzm_ = context.Operators.Where<Observation>(rzzzzzzzzzk_, rzzzzzzzzzl_);
        bool? rzzzzzzzzzn_ = context.Operators.Exists<Observation>(rzzzzzzzzzm_);
        bool? rzzzzzzzzzo_ = context.Operators.Not(rzzzzzzzzzn_);

        return rzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? rzzzzzzzzzy_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
        bool? rzzzzzzzzzz_ = this.Has_Most_Recent_Elevated_HbA1c(context);
        bool? szzzzzzzzza_ = context.Operators.Or(rzzzzzzzzzy_, rzzzzzzzzzz_);
        bool? szzzzzzzzzb_ = this.Has_No_Record_Of_HbA1c(context);
        bool? szzzzzzzzzc_ = context.Operators.Or(szzzzzzzzza_, szzzzzzzzzb_);

        return szzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? szzzzzzzzzd_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? szzzzzzzzze_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? szzzzzzzzzf_ = context.Operators.Or(szzzzzzzzzd_, szzzzzzzzze_);
        Patient szzzzzzzzzg_ = this.Patient(context);
        Date szzzzzzzzzh_ = szzzzzzzzzg_?.BirthDateElement;
        string szzzzzzzzzi_ = szzzzzzzzzh_?.Value;
        CqlDate szzzzzzzzzj_ = context.Operators.ConvertStringToDate(szzzzzzzzzi_);
        CqlInterval<CqlDateTime> szzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzk_);
        CqlDate szzzzzzzzzm_ = context.Operators.DateFrom(szzzzzzzzzl_);
        int? szzzzzzzzzn_ = context.Operators.CalculateAgeAt(szzzzzzzzzj_, szzzzzzzzzm_, "year");
        bool? szzzzzzzzzo_ = context.Operators.GreaterOrEqual(szzzzzzzzzn_, 65);
        bool? szzzzzzzzzp_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? szzzzzzzzzq_ = context.Operators.And(szzzzzzzzzo_, szzzzzzzzzp_);
        bool? szzzzzzzzzr_ = context.Operators.Or(szzzzzzzzzf_, szzzzzzzzzq_);
        bool? szzzzzzzzzs_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? szzzzzzzzzt_ = context.Operators.Or(szzzzzzzzzr_, szzzzzzzzzs_);

        return szzzzzzzzzt_;
    }


    #endregion Expressions

}
