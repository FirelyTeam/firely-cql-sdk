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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object pzzzzc_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)pzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient pzzzze_ = context.Operators.SingletonFrom<Patient>(pzzzzd_);

        return pzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> pzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return pzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> pzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return pzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> pzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return pzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return pzzzzi_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet pzzzzj_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? pzzzzl_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> pzzzzn_ = TelehealthEncounter?.StatusElement;
            string pzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzn_);
            bool? pzzzzp_ = context.Operators.Equal(pzzzzo_, "finished");
            CqlInterval<CqlDateTime> pzzzzq_ = this.Measurement_Period(context);
            Period pzzzzr_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzr_ as object);
            bool? pzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzq_, pzzzzs_, default);
            bool? pzzzzu_ = context.Operators.And(pzzzzp_, pzzzzt_);

            return pzzzzu_;
        };
        IEnumerable<Encounter> pzzzzm_ = context.Operators.Where<Encounter>(pzzzzk_, pzzzzl_);

        return pzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzv_ = this.Patient(context);
        Date pzzzzw_ = pzzzzv_?.BirthDateElement;
        string pzzzzx_ = pzzzzw_?.Value;
        CqlDate pzzzzy_ = context.Operators.ConvertStringToDate(pzzzzx_);
        CqlInterval<CqlDateTime> pzzzzz_ = this.Measurement_Period(context);
        CqlDateTime qzzzza_ = context.Operators.Start(pzzzzz_);
        CqlDate qzzzzb_ = context.Operators.DateFrom(qzzzza_);
        int? qzzzzc_ = context.Operators.CalculateAgeAt(pzzzzy_, qzzzzb_, "year");
        CqlInterval<int?> qzzzzd_ = context.Operators.Interval(18, 75, true, false);
        bool? qzzzze_ = context.Operators.In<int?>(qzzzzc_, qzzzzd_, default);
        IEnumerable<Encounter> qzzzzf_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> qzzzzg_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> qzzzzh_ = context.Operators.Union<Encounter>(qzzzzf_, qzzzzg_);
        bool? qzzzzi_ = context.Operators.Exists<Encounter>(qzzzzh_);
        bool? qzzzzj_ = context.Operators.And(qzzzze_, qzzzzi_);
        CqlValueSet qzzzzk_ = this.Diabetes(context);
        IEnumerable<Condition> qzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? qzzzzm_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> qzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> qzzzzr_ = this.Measurement_Period(context);
            bool? qzzzzs_ = context.Operators.Overlaps(qzzzzq_, qzzzzr_, default);

            return qzzzzs_;
        };
        IEnumerable<Condition> qzzzzn_ = context.Operators.Where<Condition>(qzzzzl_, qzzzzm_);
        bool? qzzzzo_ = context.Operators.Exists<Condition>(qzzzzn_);
        bool? qzzzzp_ = context.Operators.And(qzzzzj_, qzzzzo_);

        return qzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzt_ = this.Initial_Population(context);

        return qzzzzt_;
    }


    [CqlExpressionDefinition("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context)
    {
        CqlValueSet qzzzzu_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> qzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzw_(Observation RecentHbA1c)
        {
            Code<ObservationStatus> rzzzzb_ = RecentHbA1c?.StatusElement;
            string rzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzb_);
            string[] rzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzze_ = context.Operators.In<string>(rzzzzc_, rzzzzd_ as IEnumerable<string>);
            DataType rzzzzf_ = RecentHbA1c?.Effective;
            CqlDateTime rzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, rzzzzf_);
            CqlInterval<CqlDateTime> rzzzzh_ = this.Measurement_Period(context);
            bool? rzzzzi_ = context.Operators.In<CqlDateTime>(rzzzzg_, rzzzzh_, default);
            bool? rzzzzj_ = context.Operators.And(rzzzze_, rzzzzi_);

            return rzzzzj_;
        };
        IEnumerable<Observation> qzzzzx_ = context.Operators.Where<Observation>(qzzzzv_, qzzzzw_);
        object qzzzzy_(Observation @this)
        {
            DataType rzzzzk_ = @this?.Effective;
            CqlInterval<CqlDateTime> rzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzk_);
            CqlDateTime rzzzzm_ = context.Operators.Start(rzzzzl_);

            return rzzzzm_;
        };
        IEnumerable<Observation> qzzzzz_ = context.Operators.SortBy<Observation>(qzzzzx_, qzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
        Observation rzzzza_ = context.Operators.Last<Observation>(qzzzzz_);

        return rzzzza_;
    }


    [CqlExpressionDefinition("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
    {
        Observation rzzzzn_ = this.Most_Recent_HbA1c(context);
        bool? rzzzzo_ = context.Operators.Not((bool?)(rzzzzn_ is null));
        DataType rzzzzq_ = rzzzzn_?.Value;
        bool? rzzzzr_ = context.Operators.And(rzzzzo_, (bool?)(rzzzzq_ is null));

        return rzzzzr_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
    {
        Observation rzzzzs_ = this.Most_Recent_HbA1c(context);
        DataType rzzzzt_ = rzzzzs_?.Value;
        CqlQuantity rzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzzzt_ as Quantity);
        CqlQuantity rzzzzv_ = context.Operators.Quantity(9m, "%");
        bool? rzzzzw_ = context.Operators.Greater(rzzzzu_, rzzzzv_);

        return rzzzzw_;
    }


    [CqlExpressionDefinition("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context)
    {
        CqlValueSet rzzzzx_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> rzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzz_(Observation NoHbA1c)
        {
            Code<ObservationStatus> szzzzd_ = NoHbA1c?.StatusElement;
            string szzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzd_);
            string[] szzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzg_ = context.Operators.In<string>(szzzze_, szzzzf_ as IEnumerable<string>);
            DataType szzzzh_ = NoHbA1c?.Effective;
            CqlDateTime szzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzh_);
            CqlInterval<CqlDateTime> szzzzj_ = this.Measurement_Period(context);
            bool? szzzzk_ = context.Operators.In<CqlDateTime>(szzzzi_, szzzzj_, default);
            bool? szzzzl_ = context.Operators.And(szzzzg_, szzzzk_);

            return szzzzl_;
        };
        IEnumerable<Observation> szzzza_ = context.Operators.Where<Observation>(rzzzzy_, rzzzzz_);
        bool? szzzzb_ = context.Operators.Exists<Observation>(szzzza_);
        bool? szzzzc_ = context.Operators.Not(szzzzb_);

        return szzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? szzzzm_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
        bool? szzzzn_ = this.Has_Most_Recent_Elevated_HbA1c(context);
        bool? szzzzo_ = context.Operators.Or(szzzzm_, szzzzn_);
        bool? szzzzp_ = this.Has_No_Record_Of_HbA1c(context);
        bool? szzzzq_ = context.Operators.Or(szzzzo_, szzzzp_);

        return szzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? szzzzr_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? szzzzs_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? szzzzt_ = context.Operators.Or(szzzzr_, szzzzs_);
        Patient szzzzu_ = this.Patient(context);
        Date szzzzv_ = szzzzu_?.BirthDateElement;
        string szzzzw_ = szzzzv_?.Value;
        CqlDate szzzzx_ = context.Operators.ConvertStringToDate(szzzzw_);
        CqlInterval<CqlDateTime> szzzzy_ = this.Measurement_Period(context);
        CqlDateTime szzzzz_ = context.Operators.Start(szzzzy_);
        CqlDate tzzzza_ = context.Operators.DateFrom(szzzzz_);
        int? tzzzzb_ = context.Operators.CalculateAgeAt(szzzzx_, tzzzza_, "year");
        bool? tzzzzc_ = context.Operators.GreaterOrEqual(tzzzzb_, 65);
        bool? tzzzzd_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? tzzzze_ = context.Operators.And(tzzzzc_, tzzzzd_);
        bool? tzzzzf_ = context.Operators.Or(szzzzt_, tzzzze_);
        bool? tzzzzg_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? tzzzzh_ = context.Operators.Or(tzzzzf_, tzzzzg_);

        return tzzzzh_;
    }


    #endregion Expressions

}
