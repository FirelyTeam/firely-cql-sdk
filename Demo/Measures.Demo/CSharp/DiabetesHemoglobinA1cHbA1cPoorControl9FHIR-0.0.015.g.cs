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
        object mzzzzzzzzzzzzl_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> mzzzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> mzzzzzzzzzzzzq_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzr_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? mzzzzzzzzzzzzu_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> mzzzzzzzzzzzzw_ = TelehealthEncounter?.StatusElement;
            string mzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzzy_ = context.Operators.Equal(mzzzzzzzzzzzzx_, "finished");
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzza_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzza_ as object);
            bool? nzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzz_, nzzzzzzzzzzzzb_, default);
            bool? nzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzy_, nzzzzzzzzzzzzc_);

            return nzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzt_, mzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient nzzzzzzzzzzzze_ = this.Patient(context);
        Date nzzzzzzzzzzzzf_ = nzzzzzzzzzzzze_?.BirthDateElement;
        string nzzzzzzzzzzzzg_ = nzzzzzzzzzzzzf_?.Value;
        CqlDate nzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzi_);
        CqlDate nzzzzzzzzzzzzk_ = context.Operators.DateFrom(nzzzzzzzzzzzzj_);
        int? nzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzh_, nzzzzzzzzzzzzk_, "year");
        CqlInterval<int?> nzzzzzzzzzzzzm_ = context.Operators.Interval(18, 75, true, false);
        bool? nzzzzzzzzzzzzn_ = context.Operators.In<int?>(nzzzzzzzzzzzzl_, nzzzzzzzzzzzzm_, default);
        IEnumerable<Encounter> nzzzzzzzzzzzzo_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzp_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzo_, nzzzzzzzzzzzzp_);
        bool? nzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzq_);
        bool? nzzzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzzzn_, nzzzzzzzzzzzzr_);
        CqlValueSet nzzzzzzzzzzzzt_ = this.Diabetes(context);
        IEnumerable<Condition> nzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzzzzv_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzb_ = context.Operators.Overlaps(nzzzzzzzzzzzzz_, ozzzzzzzzzzzza_, default);

            return ozzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzw_);
        bool? nzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzs_, nzzzzzzzzzzzzx_);

        return nzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzc_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzd_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> ozzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzzzzzzzzzf_(Observation RecentHbA1c)
        {
            Code<ObservationStatus> ozzzzzzzzzzzzk_ = RecentHbA1c?.StatusElement;
            string ozzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzzzzzk_);
            string[] ozzzzzzzzzzzzm_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzn_ = context.Operators.In<string>(ozzzzzzzzzzzzl_, ozzzzzzzzzzzzm_ as IEnumerable<string>);
            DataType ozzzzzzzzzzzzo_ = RecentHbA1c?.Effective;
            CqlDateTime ozzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, ozzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzp_, ozzzzzzzzzzzzq_, default);
            bool? ozzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzn_, ozzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzg_ = context.Operators.Where<Observation>(ozzzzzzzzzzzze_, ozzzzzzzzzzzzf_);
        object ozzzzzzzzzzzzh_(Observation @this)
        {
            DataType ozzzzzzzzzzzzt_ = @this?.Effective;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzzzzzt_);
            CqlDateTime ozzzzzzzzzzzzv_ = context.Operators.Start(ozzzzzzzzzzzzu_);

            return ozzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzg_, ozzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ozzzzzzzzzzzzj_ = context.Operators.Last<Observation>(ozzzzzzzzzzzzi_);

        return ozzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
    {
        Observation ozzzzzzzzzzzzw_ = this.Most_Recent_HbA1c(context);
        bool? ozzzzzzzzzzzzx_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzw_ is null));
        DataType ozzzzzzzzzzzzz_ = ozzzzzzzzzzzzw_?.Value;
        bool? pzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzx_, (bool?)(ozzzzzzzzzzzzz_ is null));

        return pzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
    {
        Observation pzzzzzzzzzzzzb_ = this.Most_Recent_HbA1c(context);
        DataType pzzzzzzzzzzzzc_ = pzzzzzzzzzzzzb_?.Value;
        CqlQuantity pzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzzzzzzzzzzzc_ as Quantity);
        CqlQuantity pzzzzzzzzzzzze_ = context.Operators.Quantity(9m, "%");
        bool? pzzzzzzzzzzzzf_ = context.Operators.Greater(pzzzzzzzzzzzzd_, pzzzzzzzzzzzze_);

        return pzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzg_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> pzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzi_(Observation NoHbA1c)
        {
            Code<ObservationStatus> pzzzzzzzzzzzzm_ = NoHbA1c?.StatusElement;
            string pzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzm_);
            string[] pzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzp_ = context.Operators.In<string>(pzzzzzzzzzzzzn_, pzzzzzzzzzzzzo_ as IEnumerable<string>);
            DataType pzzzzzzzzzzzzq_ = NoHbA1c?.Effective;
            CqlDateTime pzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, pzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzr_, pzzzzzzzzzzzzs_, default);
            bool? pzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzp_, pzzzzzzzzzzzzt_);

            return pzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzh_, pzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzk_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzj_);
        bool? pzzzzzzzzzzzzl_ = context.Operators.Not(pzzzzzzzzzzzzk_);

        return pzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? pzzzzzzzzzzzzv_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
        bool? pzzzzzzzzzzzzw_ = this.Has_Most_Recent_Elevated_HbA1c(context);
        bool? pzzzzzzzzzzzzx_ = context.Operators.Or(pzzzzzzzzzzzzv_, pzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzy_ = this.Has_No_Record_Of_HbA1c(context);
        bool? pzzzzzzzzzzzzz_ = context.Operators.Or(pzzzzzzzzzzzzx_, pzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? qzzzzzzzzzzzza_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? qzzzzzzzzzzzzb_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? qzzzzzzzzzzzzc_ = context.Operators.Or(qzzzzzzzzzzzza_, qzzzzzzzzzzzzb_);
        Patient qzzzzzzzzzzzzd_ = this.Patient(context);
        Date qzzzzzzzzzzzze_ = qzzzzzzzzzzzzd_?.BirthDateElement;
        string qzzzzzzzzzzzzf_ = qzzzzzzzzzzzze_?.Value;
        CqlDate qzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzzzi_ = context.Operators.Start(qzzzzzzzzzzzzh_);
        CqlDate qzzzzzzzzzzzzj_ = context.Operators.DateFrom(qzzzzzzzzzzzzi_);
        int? qzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzg_, qzzzzzzzzzzzzj_, "year");
        bool? qzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzk_, 65);
        bool? qzzzzzzzzzzzzm_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? qzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzl_, qzzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzzo_ = context.Operators.Or(qzzzzzzzzzzzzc_, qzzzzzzzzzzzzn_);
        bool? qzzzzzzzzzzzzp_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? qzzzzzzzzzzzzq_ = context.Operators.Or(qzzzzzzzzzzzzo_, qzzzzzzzzzzzzp_);

        return qzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
