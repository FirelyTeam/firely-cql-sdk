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

    [CqlValueSetDefinition("Chronic Kidney Disease, Stage 5", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext _) => _Chronic_Kidney_Disease__Stage_5;
    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);

    [CqlValueSetDefinition("Dialysis Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", valueSetVersion: null)]
    public CqlValueSet Dialysis_Services(CqlContext _) => _Dialysis_Services;
    private static readonly CqlValueSet _Dialysis_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("ESRD Monthly Outpatient Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", valueSetVersion: null)]
    public CqlValueSet ESRD_Monthly_Outpatient_Services(CqlContext _) => _ESRD_Monthly_Outpatient_Services;
    private static readonly CqlValueSet _ESRD_Monthly_Outpatient_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014", null);

    [CqlValueSetDefinition("Essential Hypertension", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", valueSetVersion: null)]
    public CqlValueSet Essential_Hypertension(CqlContext _) => _Essential_Hypertension;
    private static readonly CqlValueSet _Essential_Hypertension = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011", null);

    [CqlValueSetDefinition("Kidney Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant(CqlContext _) => _Kidney_Transplant;
    private static readonly CqlValueSet _Kidney_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012", null);

    [CqlValueSetDefinition("Kidney Transplant Recipient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", valueSetVersion: null)]
    public CqlValueSet Kidney_Transplant_Recipient(CqlContext _) => _Kidney_Transplant_Recipient;
    private static readonly CqlValueSet _Kidney_Transplant_Recipient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Diastolic blood pressure", codeId: "8462-4", codeSystem: "http://loinc.org")]
    public CqlCode Diastolic_blood_pressure(CqlContext _) => _Diastolic_blood_pressure;
    private static readonly CqlCode _Diastolic_blood_pressure = new CqlCode("8462-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);

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
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.ResolveParameter("ControllingHighBloodPressureFHIR-0.1.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Essential Hypertension Diagnosis")]
    public IEnumerable<Condition> Essential_Hypertension_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition Hypertension)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(6m, "months");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, false);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        int? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
        CqlInterval<int?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(18, 85, true, true);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Essential_Hypertension_Diagnosis(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Pregnancy or Renal Diagnosis")]
    public IEnumerable<Condition> Pregnancy_or_Renal_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Pregnancy(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition PregnancyESRDDiagnosis)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure ESRDProcedure)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ESRDProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter ESRDEncounter)
        {
            Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("getEncounter")]
    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter E)
        {
            Id pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = E?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            FhirString pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = reference?.ReferenceElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.getId(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isObservationBP(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation BloodPressure)
        {
            ResourceReference qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.Encounter;
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.getEncounter(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Class;
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToCode(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.code;
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = BloodPressure?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.latest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Diastolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Diastolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isObservationBP(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BloodPressure)
        {
            ResourceReference qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = BloodPressure?.Encounter;
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.getEncounter(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Class;
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToCode(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.code;
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BloodPressure?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context)
    {
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation DBPExam)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = DBPExam?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation SBPExam)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SBPExam?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Observation, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Intersect<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ListSort<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation SBPReading)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SBPReading?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.latest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SBPReading?.Component;
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SBPComponent?.Code;
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Systolic_blood_pressure(context);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent SBPComponent)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SBPComponent?.Value;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Observation, CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlQuantity> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ListSort<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<CqlQuantity>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context)
    {
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Less(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation DBPReading)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = DBPReading?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.latest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation DBPReading)
        {
            List<Observation.ComponentComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = DBPReading?.Component;
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation.ComponentComponent DBPComponent)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = DBPComponent?.Code;
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Diastolic_blood_pressure(context);
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation.ComponentComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation.ComponentComponent DBPComponent)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = DBPComponent?.Value;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation, CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlQuantity> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ListSort<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<CqlQuantity>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context)
    {
        CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Less(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
