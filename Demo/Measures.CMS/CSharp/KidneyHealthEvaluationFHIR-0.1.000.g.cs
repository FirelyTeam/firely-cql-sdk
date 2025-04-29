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
[CqlLibrary("KidneyHealthEvaluationFHIR", "0.1.000")]
public partial class KidneyHealthEvaluationFHIR_0_1_000 : ILibrary, ISingleton<KidneyHealthEvaluationFHIR_0_1_000>
{
    private KidneyHealthEvaluationFHIR_0_1_000() {}

    public static KidneyHealthEvaluationFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "KidneyHealthEvaluationFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Acute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Acute Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083",
        valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext context) => _Acute_Inpatient;

    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);
    #endregion

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Chronic Kidney Disease, Stage 5
    [CqlValueSetDefinition(
        definitionName: "Chronic Kidney Disease, Stage 5",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002",
        valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext context) => _Chronic_Kidney_Disease__Stage_5;

    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);
    #endregion

    #region ValueSet: Diabetes
    [CqlValueSetDefinition(
        definitionName: "Diabetes",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext context) => _Diabetes;

    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: End Stage Renal Disease
    [CqlValueSetDefinition(
        definitionName: "End Stage Renal Disease",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353",
        valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext context) => _End_Stage_Renal_Disease;

    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);
    #endregion

    #region ValueSet: Estimated Glomerular Filtration Rate
    [CqlValueSetDefinition(
        definitionName: "Estimated Glomerular Filtration Rate",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000",
        valueSetVersion: null)]
    public CqlValueSet Estimated_Glomerular_Filtration_Rate(CqlContext context) => _Estimated_Glomerular_Filtration_Rate;

    private static readonly CqlValueSet _Estimated_Glomerular_Filtration_Rate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Hospice Care Ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice Care Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => _Hospice_Care_Ambulatory;

    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Palliative or Hospice Care
    [CqlValueSetDefinition(
        definitionName: "Palliative or Hospice Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579",
        valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => _Palliative_or_Hospice_Care;

    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
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

    #region ValueSet: Urine Albumin Creatinine Ratio
    [CqlValueSetDefinition(
        definitionName: "Urine Albumin Creatinine Ratio",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Urine_Albumin_Creatinine_Ratio(CqlContext context) => _Urine_Albumin_Creatinine_Ratio;

    private static readonly CqlValueSet _Urine_Albumin_Creatinine_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", null);
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

    #region Code: AMB
    [CqlCodeDefinition(
        definitionName: "AMB",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext context) => _AMB;

    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
        ];

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
        object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("KidneyHealthEvaluationFHIR-0.1.000", "Measurement Period", zzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Active Diabetes Overlaps Measurement Period")]
    public bool? Has_Active_Diabetes_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Diabetes(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Diabetes?.ClinicalStatus;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.active(context);
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Outpatient Visit During Measurement Period")]
    public bool? Has_Outpatient_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(18, 85, true, true);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<int?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Active_Diabetes_Overlaps_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Outpatient_Visit_During_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has CKD Stage 5 or ESRD Diagnosis Overlaps Measurement Period")]
    public IEnumerable<Condition> Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition CKDOrESRD)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CKDOrESRD);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            CodeableConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = CKDOrESRD?.ClinicalStatus;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.active(context);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Kidney Panel Performed During Measurement Period")]
    public bool? Has_Kidney_Panel_Performed_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Estimated_Glomerular_Filtration_Rate(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation eGFRTest)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = eGFRTest?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = eGFRTest?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = eGFRTest?.StatusElement;
            ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Urine_Albumin_Creatinine_Ratio(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation uACRTest)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = uACRTest?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = uACRTest?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = uACRTest?.StatusElement;
            ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Kidney_Panel_Performed_During_Measurement_Period(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Expressions

}
