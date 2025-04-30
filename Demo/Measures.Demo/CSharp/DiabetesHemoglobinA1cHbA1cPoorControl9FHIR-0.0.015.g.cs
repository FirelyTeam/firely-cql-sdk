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
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object qzzzzzzzzzzc_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzd_);

        return qzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> qzzzzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzj_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? qzzzzzzzzzzl_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> qzzzzzzzzzzn_ = TelehealthEncounter?.StatusElement;
            string qzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzn_);
            bool? qzzzzzzzzzzp_ = context.Operators.Equal(qzzzzzzzzzzo_, "finished");
            CqlInterval<CqlDateTime> qzzzzzzzzzzq_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzr_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzr_ as object);
            bool? qzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzq_, qzzzzzzzzzzs_, default);
            bool? qzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzp_, qzzzzzzzzzzt_);

            return qzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzm_ = context.Operators.Where<Encounter>(qzzzzzzzzzzk_, qzzzzzzzzzzl_);

        return qzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient qzzzzzzzzzzv_ = this.Patient(context);
        Date qzzzzzzzzzzw_ = qzzzzzzzzzzv_?.BirthDateElement;
        string qzzzzzzzzzzx_ = qzzzzzzzzzzw_?.Value;
        CqlDate qzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzza_ = context.Operators.Start(qzzzzzzzzzzz_);
        CqlDate rzzzzzzzzzzb_ = context.Operators.DateFrom(rzzzzzzzzzza_);
        int? rzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzy_, rzzzzzzzzzzb_, "year");
        CqlInterval<int?> rzzzzzzzzzzd_ = context.Operators.Interval(18, 75, true, false);
        bool? rzzzzzzzzzze_ = context.Operators.In<int?>(rzzzzzzzzzzc_, rzzzzzzzzzzd_, default);
        IEnumerable<Encounter> rzzzzzzzzzzf_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> rzzzzzzzzzzg_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzh_ = context.Operators.Union<Encounter>(rzzzzzzzzzzf_, rzzzzzzzzzzg_);
        bool? rzzzzzzzzzzi_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzh_);
        bool? rzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzze_, rzzzzzzzzzzi_);
        CqlValueSet rzzzzzzzzzzk_ = this.Diabetes(context);
        IEnumerable<Condition> rzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? rzzzzzzzzzzm_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> rzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzs_ = context.Operators.Overlaps(rzzzzzzzzzzq_, rzzzzzzzzzzr_, default);

            return rzzzzzzzzzzs_;
        };
        IEnumerable<Condition> rzzzzzzzzzzn_ = context.Operators.Where<Condition>(rzzzzzzzzzzl_, rzzzzzzzzzzm_);
        bool? rzzzzzzzzzzo_ = context.Operators.Exists<Condition>(rzzzzzzzzzzn_);
        bool? rzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzj_, rzzzzzzzzzzo_);

        return rzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzt_ = this.Initial_Population(context);

        return rzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzu_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> rzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzw_(Observation RecentHbA1c)
        {
            Code<ObservationStatus> szzzzzzzzzzb_ = RecentHbA1c?.StatusElement;
            string szzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzb_);
            string[] szzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzze_ = context.Operators.In<string>(szzzzzzzzzzc_, szzzzzzzzzzd_ as IEnumerable<string>);
            DataType szzzzzzzzzzf_ = RecentHbA1c?.Effective;
            CqlDateTime szzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzf_);
            CqlInterval<CqlDateTime> szzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzg_, szzzzzzzzzzh_, default);
            bool? szzzzzzzzzzj_ = context.Operators.And(szzzzzzzzzze_, szzzzzzzzzzi_);

            return szzzzzzzzzzj_;
        };
        IEnumerable<Observation> rzzzzzzzzzzx_ = context.Operators.Where<Observation>(rzzzzzzzzzzv_, rzzzzzzzzzzw_);
        object rzzzzzzzzzzy_(Observation @this)
        {
            DataType szzzzzzzzzzk_ = @this?.Effective;
            CqlInterval<CqlDateTime> szzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzk_);
            CqlDateTime szzzzzzzzzzm_ = context.Operators.Start(szzzzzzzzzzl_);

            return szzzzzzzzzzm_;
        };
        IEnumerable<Observation> rzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzx_, rzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
        Observation szzzzzzzzzza_ = context.Operators.Last<Observation>(rzzzzzzzzzzz_);

        return szzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
    {
        Observation szzzzzzzzzzn_ = this.Most_Recent_HbA1c(context);
        bool? szzzzzzzzzzo_ = context.Operators.Not((bool?)(szzzzzzzzzzn_ is null));
        DataType szzzzzzzzzzq_ = szzzzzzzzzzn_?.Value;
        bool? szzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzo_, (bool?)(szzzzzzzzzzq_ is null));

        return szzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
    {
        Observation szzzzzzzzzzs_ = this.Most_Recent_HbA1c(context);
        DataType szzzzzzzzzzt_ = szzzzzzzzzzs_?.Value;
        CqlQuantity szzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzzzzzzzzzt_ as Quantity);
        CqlQuantity szzzzzzzzzzv_ = context.Operators.Quantity(9m, "%");
        bool? szzzzzzzzzzw_ = context.Operators.Greater(szzzzzzzzzzu_, szzzzzzzzzzv_);

        return szzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzx_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> szzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzz_(Observation NoHbA1c)
        {
            Code<ObservationStatus> tzzzzzzzzzzd_ = NoHbA1c?.StatusElement;
            string tzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzd_);
            string[] tzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzg_ = context.Operators.In<string>(tzzzzzzzzzze_, tzzzzzzzzzzf_ as IEnumerable<string>);
            DataType tzzzzzzzzzzh_ = NoHbA1c?.Effective;
            CqlDateTime tzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzi_, tzzzzzzzzzzj_, default);
            bool? tzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzg_, tzzzzzzzzzzk_);

            return tzzzzzzzzzzl_;
        };
        IEnumerable<Observation> tzzzzzzzzzza_ = context.Operators.Where<Observation>(szzzzzzzzzzy_, szzzzzzzzzzz_);
        bool? tzzzzzzzzzzb_ = context.Operators.Exists<Observation>(tzzzzzzzzzza_);
        bool? tzzzzzzzzzzc_ = context.Operators.Not(tzzzzzzzzzzb_);

        return tzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? tzzzzzzzzzzm_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
        bool? tzzzzzzzzzzn_ = this.Has_Most_Recent_Elevated_HbA1c(context);
        bool? tzzzzzzzzzzo_ = context.Operators.Or(tzzzzzzzzzzm_, tzzzzzzzzzzn_);
        bool? tzzzzzzzzzzp_ = this.Has_No_Record_Of_HbA1c(context);
        bool? tzzzzzzzzzzq_ = context.Operators.Or(tzzzzzzzzzzo_, tzzzzzzzzzzp_);

        return tzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? tzzzzzzzzzzr_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? tzzzzzzzzzzs_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? tzzzzzzzzzzt_ = context.Operators.Or(tzzzzzzzzzzr_, tzzzzzzzzzzs_);
        Patient tzzzzzzzzzzu_ = this.Patient(context);
        Date tzzzzzzzzzzv_ = tzzzzzzzzzzu_?.BirthDateElement;
        string tzzzzzzzzzzw_ = tzzzzzzzzzzv_?.Value;
        CqlDate tzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzz_ = context.Operators.Start(tzzzzzzzzzzy_);
        CqlDate uzzzzzzzzzza_ = context.Operators.DateFrom(tzzzzzzzzzzz_);
        int? uzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzx_, uzzzzzzzzzza_, "year");
        bool? uzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzb_, 65);
        bool? uzzzzzzzzzzd_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? uzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzc_, uzzzzzzzzzzd_);
        bool? uzzzzzzzzzzf_ = context.Operators.Or(tzzzzzzzzzzt_, uzzzzzzzzzze_);
        bool? uzzzzzzzzzzg_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? uzzzzzzzzzzh_ = context.Operators.Or(uzzzzzzzzzzf_, uzzzzzzzzzzg_);

        return uzzzzzzzzzzh_;
    }


    #endregion Expressions

}
