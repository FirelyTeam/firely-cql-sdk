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
[CqlLibrary("ChildrenWhoHaveDentalDecayOrCavitiesFHIR", "0.0.001")]
public partial class ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001 : ILibrary, ISingleton<ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001>
{
    private ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001() {}

    public static ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ChildrenWhoHaveDentalDecayOrCavitiesFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Clinical Oral Evaluation
    [CqlValueSetDefinition(
        definitionName: "Clinical Oral Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext context) => _Clinical_Oral_Evaluation;

    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);
    #endregion

    #region ValueSet: Dental Caries
    [CqlValueSetDefinition(
        definitionName: "Dental Caries",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004",
        valueSetVersion: null)]
    public CqlValueSet Dental_Caries(CqlContext context) => _Dental_Caries;

    private static readonly CqlValueSet _Dental_Caries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004", null);
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

    #endregion ValueSets

    #region Codes

    #region Code: Discharge to healthcare facility for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to healthcare facility for hospice care (procedure)",
        codeId: "428371000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Discharge to home for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to home for hospice care (procedure)",
        codeId: "428361000124107",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_home_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Hospice care [Minimum Data Set]
    [CqlCodeDefinition(
        definitionName: "Hospice care [Minimum Data Set]",
        codeId: "45755-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => _Hospice_care__Minimum_Data_Set_;

    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Yes (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Yes (qualifier value)",
        codeId: "373066001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext context) => _Yes__qualifier_value_;

    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
            new CqlCode("45755-6", "http://loinc.org", default, default),
        ];

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("ChildrenWhoHaveDentalDecayOrCavitiesFHIR-0.0.001", "Measurement Period", izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(1, 20, true, true);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounters(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Dental_Caries(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition DentalCaries)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DentalCaries);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
