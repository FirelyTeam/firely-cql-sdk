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

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Dental Caries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004", valueSetVersion: null)]
    public CqlValueSet Dental_Caries(CqlContext _) => _Dental_Caries;
    private static readonly CqlValueSet _Dental_Caries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzf_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("ChildrenWhoHaveDentalDecayOrCavitiesFHIR-0.0.001", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzi_);

        return dzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzk_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzzzzzzzzzzn_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzr_ as object);
            bool? dzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzs_, "day");

            return dzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzn_);

        return dzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
        Date dzzzzzzzzzzzzzzzzzzzzv_ = dzzzzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
        string dzzzzzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzzzzzv_?.Value;
        CqlDate dzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate ezzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzz_);
        int? ezzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzza_, "year");
        CqlInterval<int?> ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(1, 20, true, true);
        bool? ezzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzc_, default);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounters(context);
        bool? ezzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzze_);
        bool? ezzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzi_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return ezzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzj_ = this.Dental_Caries(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzl_(Condition DentalCaries)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DentalCaries);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzp_, default);

            return ezzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
