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

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Diabetes
    [CqlValueSetDefinition(
        definitionName: "Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext context) => _Diabetes;

    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);
    #endregion

    #region ValueSet: Discharged to Health Care Facility for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Health Care Facility for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);
    #endregion

    #region ValueSet: Discharged to Home for Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Discharged to Home for Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209",
        valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => _Discharged_to_Home_for_Hospice_Care;

    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: HbA1c Laboratory Test
    [CqlValueSetDefinition(
        definitionName: "HbA1c Laboratory Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013",
        valueSetVersion: null)]
    public CqlValueSet HbA1c_Laboratory_Test(CqlContext context) => _HbA1c_Laboratory_Test;

    private static readonly CqlValueSet _HbA1c_Laboratory_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Hospice care ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice care ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15",
        valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext context) => _Hospice_care_ambulatory;

    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
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
        CqlCode[] gzzzzzzzzzzzzg_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return gzzzzzzzzzzzzg_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object gzzzzzzzzzzzzh_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient gzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> gzzzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> gzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> gzzzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzo_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? gzzzzzzzzzzzzq_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> gzzzzzzzzzzzzs_ = TelehealthEncounter?.StatusElement;
            string gzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzs_);
            bool? gzzzzzzzzzzzzu_ = context.Operators.Equal(gzzzzzzzzzzzzt_, "finished");
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            Period gzzzzzzzzzzzzw_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzzzzw_ as object);
            bool? gzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzv_, gzzzzzzzzzzzzx_, default);
            bool? gzzzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzzzu_, gzzzzzzzzzzzzy_);

            return gzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzp_, gzzzzzzzzzzzzq_);

        return gzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzzzzzzzza_ = this.Patient(context);
        Date hzzzzzzzzzzzzb_ = hzzzzzzzzzzzza_?.BirthDateElement;
        string hzzzzzzzzzzzzc_ = hzzzzzzzzzzzzb_?.Value;
        CqlDate hzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzf_ = context.Operators.Start(hzzzzzzzzzzzze_);
        CqlDate hzzzzzzzzzzzzg_ = context.Operators.DateFrom(hzzzzzzzzzzzzf_);
        int? hzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzd_, hzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> hzzzzzzzzzzzzi_ = context.Operators.Interval(18, 75, true, false);
        bool? hzzzzzzzzzzzzj_ = context.Operators.In<int?>(hzzzzzzzzzzzzh_, hzzzzzzzzzzzzi_, default);
        IEnumerable<Encounter> hzzzzzzzzzzzzk_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzl_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzm_);
        bool? hzzzzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzzzzj_, hzzzzzzzzzzzzn_);
        CqlValueSet hzzzzzzzzzzzzp_ = this.Diabetes(context);
        IEnumerable<Condition> hzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzzzzzzzzzzr_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Diabetes);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzx_ = context.Operators.Overlaps(hzzzzzzzzzzzzv_, hzzzzzzzzzzzzw_, default);

            return hzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzq_, hzzzzzzzzzzzzr_);
        bool? hzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzo_, hzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? hzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzz_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> izzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzzzzb_(Observation RecentHbA1c)
        {
            Code<ObservationStatus> izzzzzzzzzzzzg_ = RecentHbA1c?.StatusElement;
            string izzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzzzzzzg_);
            string[] izzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzj_ = context.Operators.In<string>(izzzzzzzzzzzzh_, izzzzzzzzzzzzi_ as IEnumerable<string>);
            DataType izzzzzzzzzzzzk_ = RecentHbA1c?.Effective;
            CqlDateTime izzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, izzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzl_, izzzzzzzzzzzzm_, default);
            bool? izzzzzzzzzzzzo_ = context.Operators.And(izzzzzzzzzzzzj_, izzzzzzzzzzzzn_);

            return izzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzc_ = context.Operators.Where<Observation>(izzzzzzzzzzzza_, izzzzzzzzzzzzb_);
        object izzzzzzzzzzzzd_(Observation @this)
        {
            DataType izzzzzzzzzzzzp_ = @this?.Effective;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzzzzzzp_);
            CqlDateTime izzzzzzzzzzzzr_ = context.Operators.Start(izzzzzzzzzzzzq_);

            return izzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> izzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzc_, izzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Observation izzzzzzzzzzzzf_ = context.Operators.Last<Observation>(izzzzzzzzzzzze_);

        return izzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result(CqlContext context)
    {
        Observation izzzzzzzzzzzzs_ = this.Most_Recent_HbA1c(context);
        bool? izzzzzzzzzzzzt_ = context.Operators.Not((bool?)(izzzzzzzzzzzzs_ is null));
        DataType izzzzzzzzzzzzv_ = izzzzzzzzzzzzs_?.Value;
        bool? izzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzt_, (bool?)(izzzzzzzzzzzzv_ is null));

        return izzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c(CqlContext context)
    {
        Observation izzzzzzzzzzzzx_ = this.Most_Recent_HbA1c(context);
        DataType izzzzzzzzzzzzy_ = izzzzzzzzzzzzx_?.Value;
        CqlQuantity izzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzzzzzzzzzzzy_ as Quantity);
        CqlQuantity jzzzzzzzzzzzza_ = context.Operators.Quantity(9m, "%");
        bool? jzzzzzzzzzzzzb_ = context.Operators.Greater(izzzzzzzzzzzzz_, jzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzc_ = this.HbA1c_Laboratory_Test(context);
        IEnumerable<Observation> jzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? jzzzzzzzzzzzze_(Observation NoHbA1c)
        {
            Code<ObservationStatus> jzzzzzzzzzzzzi_ = NoHbA1c?.StatusElement;
            string jzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzi_);
            string[] jzzzzzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzl_ = context.Operators.In<string>(jzzzzzzzzzzzzj_, jzzzzzzzzzzzzk_ as IEnumerable<string>);
            DataType jzzzzzzzzzzzzm_ = NoHbA1c?.Effective;
            CqlDateTime jzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, jzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzn_, jzzzzzzzzzzzzo_, default);
            bool? jzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzl_, jzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzd_, jzzzzzzzzzzzze_);
        bool? jzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzf_);
        bool? jzzzzzzzzzzzzh_ = context.Operators.Not(jzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzr_ = this.Has_Most_Recent_HbA1c_Without_Result(context);
        bool? jzzzzzzzzzzzzs_ = this.Has_Most_Recent_Elevated_HbA1c(context);
        bool? jzzzzzzzzzzzzt_ = context.Operators.Or(jzzzzzzzzzzzzr_, jzzzzzzzzzzzzs_);
        bool? jzzzzzzzzzzzzu_ = this.Has_No_Record_Of_HbA1c(context);
        bool? jzzzzzzzzzzzzv_ = context.Operators.Or(jzzzzzzzzzzzzt_, jzzzzzzzzzzzzu_);

        return jzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? jzzzzzzzzzzzzw_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? jzzzzzzzzzzzzx_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? jzzzzzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzzzzzw_, jzzzzzzzzzzzzx_);
        Patient jzzzzzzzzzzzzz_ = this.Patient(context);
        Date kzzzzzzzzzzzza_ = jzzzzzzzzzzzzz_?.BirthDateElement;
        string kzzzzzzzzzzzzb_ = kzzzzzzzzzzzza_?.Value;
        CqlDate kzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzze_ = context.Operators.Start(kzzzzzzzzzzzzd_);
        CqlDate kzzzzzzzzzzzzf_ = context.Operators.DateFrom(kzzzzzzzzzzzze_);
        int? kzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzc_, kzzzzzzzzzzzzf_, "year");
        bool? kzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzzzg_, 65);
        bool? kzzzzzzzzzzzzi_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? kzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzh_, kzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzk_ = context.Operators.Or(jzzzzzzzzzzzzy_, kzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzl_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? kzzzzzzzzzzzzm_ = context.Operators.Or(kzzzzzzzzzzzzk_, kzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
