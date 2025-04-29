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
[CqlLibrary("ControllingHighBloodPressureFHIR", "0.1.000")]
public partial class ControllingHighBloodPressureFHIR_0_1_000 : ILibrary, ISingleton<ControllingHighBloodPressureFHIR_0_1_000>
{
    private ControllingHighBloodPressureFHIR_0_1_000() {}

    public static ControllingHighBloodPressureFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ControllingHighBloodPressureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Status_1_8_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Chronic Kidney Disease, Stage 5
    [CqlValueSetDefinition(
        definitionName: "Chronic Kidney Disease, Stage 5",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002",
        valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext context) => _Chronic_Kidney_Disease__Stage_5;

    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);
    #endregion

    #region ValueSet: Dialysis Services
    [CqlValueSetDefinition(
        definitionName: "Dialysis Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013",
        valueSetVersion: null)]
    public CqlValueSet Dialysis_Services(CqlContext context) => _Dialysis_Services;

    private static readonly CqlValueSet _Dialysis_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", null);
    #endregion

    #region ValueSet: Emergency Department Evaluation and Management Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Evaluation and Management Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => _Emergency_Department_Evaluation_and_Management_Visit;

    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);
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

    #region ValueSet: ESRD Monthly Outpatient Services
    [CqlValueSetDefinition(
        definitionName: "ESRD Monthly Outpatient Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014",
        valueSetVersion: null)]
    public CqlValueSet ESRD_Monthly_Outpatient_Services(CqlContext context) => _ESRD_Monthly_Outpatient_Services;

    private static readonly CqlValueSet _ESRD_Monthly_Outpatient_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", null);
    #endregion

    #region ValueSet: Essential Hypertension
    [CqlValueSetDefinition(
        definitionName: "Essential Hypertension",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Essential_Hypertension(CqlContext context) => _Essential_Hypertension;

    private static readonly CqlValueSet _Essential_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", null);
    #endregion

    #region ValueSet: Kidney Transplant
    [CqlValueSetDefinition(
        definitionName: "Kidney Transplant",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant(CqlContext context) => _Kidney_Transplant;

    private static readonly CqlValueSet _Kidney_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);
    #endregion

    #region ValueSet: Kidney Transplant Recipient
    [CqlValueSetDefinition(
        definitionName: "Kidney Transplant Recipient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029",
        valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant_Recipient(CqlContext context) => _Kidney_Transplant_Recipient;

    private static readonly CqlValueSet _Kidney_Transplant_Recipient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", null);
    #endregion

    #region ValueSet: Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext context) => _Pregnancy;

    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Diastolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Diastolic blood pressure",
        codeId: "8462-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext context) => _Diastolic_blood_pressure;

    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Systolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Systolic blood pressure",
        codeId: "8480-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext context) => _Systolic_blood_pressure;

    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("8462-4", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("ControllingHighBloodPressureFHIR-0.1.000", "Measurement Period", jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Essential Hypertension Diagnosis")]
    public IEnumerable<Condition> Essential_Hypertension_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition Hypertension)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "months");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, false);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
        Date kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        int? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(18, 85, true, true);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Essential_Hypertension_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pregnancy or Renal Diagnosis")]
    public IEnumerable<Condition> Pregnancy_or_Renal_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Pregnancy(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition PregnancyESRDDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Overlaps(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure ESRDProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ESRDProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter ESRDEncounter)
        {
            Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter E)
        {
            Id nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = E?.IdElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            FhirString nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = reference?.ReferenceElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.getId(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isObservationBP(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation BloodPressure)
        {
            ResourceReference nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Encounter;
            Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.getEncounter(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Coding nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Class;
            CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToCode(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.code;
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BloodPressure?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Diastolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Diastolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isObservationBP(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation BloodPressure)
        {
            ResourceReference ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = BloodPressure?.Encounter;
            Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.getEncounter(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Coding ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Class;
            CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.code;
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = BloodPressure?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation DBPExam)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = DBPExam?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation SBPExam)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SBPExam?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Intersect<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ListSort<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Last<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation SBPReading)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SBPReading?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.latest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameAs(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SBPReading?.Component;
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SBPComponent?.Code;
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Systolic_blood_pressure(context);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation.ComponentComponent SBPComponent)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SBPComponent?.Value;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlQuantity> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlQuantity>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<CqlQuantity>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Observation, CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlQuantity> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ListSort<CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<CqlQuantity>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context)
    {
        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Less(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation DBPReading)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = DBPReading?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameAs(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation DBPReading)
        {
            List<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = DBPReading?.Component;
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent DBPComponent)
            {
                CodeableConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = DBPComponent?.Code;
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diastolic_blood_pressure(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent DBPComponent)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = DBPComponent?.Value;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation, CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlQuantity> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ListSort<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<CqlQuantity>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context)
    {
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Less(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
