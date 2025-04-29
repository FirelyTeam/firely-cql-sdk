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
        CqlDateTime zzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzh_ = context.Operators.Interval(zzzzzzf_, zzzzzzg_, true, true);
        object zzzzzzi_ = context.ResolveParameter("ControllingHighBloodPressureFHIR-0.1.000", "Measurement Period", zzzzzzh_);

        return (CqlInterval<CqlDateTime>)zzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzk_ = context.Operators.SingletonFrom<Patient>(zzzzzzj_);

        return zzzzzzk_;
    }


    [CqlExpressionDefinition("Essential Hypertension Diagnosis")]
    public IEnumerable<Condition> Essential_Hypertension_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzl_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> zzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzn_(Condition Hypertension)
        {
            CqlInterval<CqlDateTime> zzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> zzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzr_ = context.Operators.Start(zzzzzzq_);
            CqlDateTime zzzzzzt_ = context.Operators.Start(zzzzzzq_);
            CqlQuantity zzzzzzu_ = context.Operators.Quantity(6m, "months");
            CqlDateTime zzzzzzv_ = context.Operators.Add(zzzzzzt_, zzzzzzu_);
            CqlInterval<CqlDateTime> zzzzzzw_ = context.Operators.Interval(zzzzzzr_, zzzzzzv_, true, false);
            bool? zzzzzzx_ = context.Operators.Overlaps(zzzzzzp_, zzzzzzw_, default);

            return zzzzzzx_;
        };
        IEnumerable<Condition> zzzzzzo_ = context.Operators.Where<Condition>(zzzzzzm_, zzzzzzn_);

        return zzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient zzzzzzy_ = this.Patient(context);
        Date zzzzzzz_ = zzzzzzy_?.BirthDateElement;
        string azzzzzza_ = zzzzzzz_?.Value;
        CqlDate azzzzzzb_ = context.Operators.ConvertStringToDate(azzzzzza_);
        CqlInterval<CqlDateTime> azzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzd_ = context.Operators.End(azzzzzzc_);
        CqlDate azzzzzze_ = context.Operators.DateFrom(azzzzzzd_);
        int? azzzzzzf_ = context.Operators.CalculateAgeAt(azzzzzzb_, azzzzzze_, "year");
        CqlInterval<int?> azzzzzzg_ = context.Operators.Interval(18, 85, true, true);
        bool? azzzzzzh_ = context.Operators.In<int?>(azzzzzzf_, azzzzzzg_, default);
        IEnumerable<Condition> azzzzzzi_ = this.Essential_Hypertension_Diagnosis(context);
        bool? azzzzzzj_ = context.Operators.Exists<Condition>(azzzzzzi_);
        bool? azzzzzzk_ = context.Operators.And(azzzzzzh_, azzzzzzj_);
        IEnumerable<Encounter> azzzzzzl_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? azzzzzzm_ = context.Operators.Exists<Encounter>(azzzzzzl_);
        bool? azzzzzzn_ = context.Operators.And(azzzzzzk_, azzzzzzm_);

        return azzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzo_ = this.Initial_Population(context);

        return azzzzzzo_;
    }


    [CqlExpressionDefinition("Pregnancy or Renal Diagnosis")]
    public IEnumerable<Condition> Pregnancy_or_Renal_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzp_ = this.Pregnancy(context);
        IEnumerable<Condition> azzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet azzzzzzr_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> azzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> azzzzzzt_ = context.Operators.Union<Condition>(azzzzzzq_, azzzzzzs_);
        CqlValueSet azzzzzzu_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> azzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet azzzzzzw_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> azzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> azzzzzzy_ = context.Operators.Union<Condition>(azzzzzzv_, azzzzzzx_);
        IEnumerable<Condition> azzzzzzz_ = context.Operators.Union<Condition>(azzzzzzt_, azzzzzzy_);
        bool? bzzzzzza_(Condition PregnancyESRDDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> bzzzzzzd_ = this.Measurement_Period(context);
            bool? bzzzzzze_ = context.Operators.Overlaps(bzzzzzzc_, bzzzzzzd_, default);

            return bzzzzzze_;
        };
        IEnumerable<Condition> bzzzzzzb_ = context.Operators.Where<Condition>(azzzzzzz_, bzzzzzza_);

        return bzzzzzzb_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context)
    {
        CqlValueSet bzzzzzzf_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> bzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet bzzzzzzh_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> bzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzj_ = context.Operators.Union<Procedure>(bzzzzzzg_, bzzzzzzi_);
        IEnumerable<Procedure> bzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, bzzzzzzj_);
        bool? bzzzzzzl_(Procedure ESRDProcedure)
        {
            DataType bzzzzzzn_ = ESRDProcedure?.Performed;
            object bzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzn_);
            CqlInterval<CqlDateTime> bzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzo_);
            CqlDateTime bzzzzzzq_ = context.Operators.End(bzzzzzzp_);
            CqlInterval<CqlDateTime> bzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzs_ = context.Operators.End(bzzzzzzr_);
            bool? bzzzzzzt_ = context.Operators.SameOrBefore(bzzzzzzq_, bzzzzzzs_, default);

            return bzzzzzzt_;
        };
        IEnumerable<Procedure> bzzzzzzm_ = context.Operators.Where<Procedure>(bzzzzzzk_, bzzzzzzl_);

        return bzzzzzzm_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context)
    {
        CqlValueSet bzzzzzzu_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> bzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzw_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzv_);
        bool? bzzzzzzx_(Encounter ESRDEncounter)
        {
            Period bzzzzzzz_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzz_);
            CqlInterval<CqlDateTime> czzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzza_ as object);
            CqlDateTime czzzzzzc_ = context.Operators.Start(czzzzzzb_);
            CqlInterval<CqlDateTime> czzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime czzzzzze_ = context.Operators.End(czzzzzzd_);
            bool? czzzzzzf_ = context.Operators.SameOrBefore(czzzzzzc_, czzzzzze_, default);

            return czzzzzzf_;
        };
        IEnumerable<Encounter> bzzzzzzy_ = context.Operators.Where<Encounter>(bzzzzzzw_, bzzzzzzx_);

        return bzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? czzzzzzg_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> czzzzzzh_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? czzzzzzi_ = context.Operators.Exists<Condition>(czzzzzzh_);
        bool? czzzzzzj_ = context.Operators.Or(czzzzzzg_, czzzzzzi_);
        IEnumerable<Procedure> czzzzzzk_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? czzzzzzl_ = context.Operators.Exists<Procedure>(czzzzzzk_);
        bool? czzzzzzm_ = context.Operators.Or(czzzzzzj_, czzzzzzl_);
        IEnumerable<Encounter> czzzzzzn_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? czzzzzzo_ = context.Operators.Exists<Encounter>(czzzzzzn_);
        bool? czzzzzzp_ = context.Operators.Or(czzzzzzm_, czzzzzzo_);
        bool? czzzzzzq_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? czzzzzzr_ = context.Operators.Or(czzzzzzp_, czzzzzzq_);
        bool? czzzzzzs_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? czzzzzzt_ = context.Operators.Or(czzzzzzr_, czzzzzzs_);
        bool? czzzzzzu_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? czzzzzzv_ = context.Operators.Or(czzzzzzt_, czzzzzzu_);

        return czzzzzzv_;
    }


    [CqlExpressionDefinition("getEncounter")]
    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> czzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzzx_(Encounter E)
        {
            Id dzzzzzza_ = E?.IdElement;
            string dzzzzzzb_ = dzzzzzza_?.Value;
            FhirString dzzzzzzc_ = reference?.ReferenceElement;
            string dzzzzzzd_ = dzzzzzzc_?.Value;
            string dzzzzzze_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzd_);
            bool? dzzzzzzf_ = context.Operators.Equal(dzzzzzzb_, dzzzzzze_);

            return dzzzzzzf_;
        };
        IEnumerable<Encounter> czzzzzzy_ = context.Operators.Where<Encounter>(czzzzzzw_, czzzzzzx_);
        Encounter czzzzzzz_ = context.Operators.SingletonFrom<Encounter>(czzzzzzy_);

        return czzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> dzzzzzzh_ = Status_1_8_000.Instance.isObservationBP(context, dzzzzzzg_);
        bool? dzzzzzzi_(Observation BloodPressure)
        {
            ResourceReference dzzzzzzk_ = BloodPressure?.Encounter;
            Encounter dzzzzzzl_ = this.getEncounter(context, dzzzzzzk_);
            Coding dzzzzzzm_ = dzzzzzzl_?.Class;
            CqlCode dzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToCode(context, dzzzzzzm_);
            string dzzzzzzo_ = dzzzzzzn_?.code;
            string[] dzzzzzzp_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? dzzzzzzq_ = context.Operators.In<string>(dzzzzzzo_, dzzzzzzp_ as IEnumerable<string>);
            bool? dzzzzzzr_ = context.Operators.Not(dzzzzzzq_);
            DataType dzzzzzzs_ = BloodPressure?.Effective;
            object dzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzs_);
            CqlDateTime dzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, dzzzzzzt_);
            CqlInterval<CqlDateTime> dzzzzzzv_ = this.Measurement_Period(context);
            bool? dzzzzzzw_ = context.Operators.In<CqlDateTime>(dzzzzzzu_, dzzzzzzv_, "day");
            bool? dzzzzzzx_ = context.Operators.And(dzzzzzzr_, dzzzzzzw_);

            return dzzzzzzx_;
        };
        IEnumerable<Observation> dzzzzzzj_ = context.Operators.Where<Observation>(dzzzzzzh_, dzzzzzzi_);

        return dzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Diastolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Diastolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> dzzzzzzz_ = Status_1_8_000.Instance.isObservationBP(context, dzzzzzzy_);
        bool? ezzzzzza_(Observation BloodPressure)
        {
            ResourceReference ezzzzzzc_ = BloodPressure?.Encounter;
            Encounter ezzzzzzd_ = this.getEncounter(context, ezzzzzzc_);
            Coding ezzzzzze_ = ezzzzzzd_?.Class;
            CqlCode ezzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ezzzzzze_);
            string ezzzzzzg_ = ezzzzzzf_?.code;
            string[] ezzzzzzh_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? ezzzzzzi_ = context.Operators.In<string>(ezzzzzzg_, ezzzzzzh_ as IEnumerable<string>);
            bool? ezzzzzzj_ = context.Operators.Not(ezzzzzzi_);
            DataType ezzzzzzk_ = BloodPressure?.Effective;
            object ezzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzk_);
            CqlDateTime ezzzzzzm_ = QICoreCommon_2_1_000.Instance.latest(context, ezzzzzzl_);
            CqlInterval<CqlDateTime> ezzzzzzn_ = this.Measurement_Period(context);
            bool? ezzzzzzo_ = context.Operators.In<CqlDateTime>(ezzzzzzm_, ezzzzzzn_, "day");
            bool? ezzzzzzp_ = context.Operators.And(ezzzzzzj_, ezzzzzzo_);

            return ezzzzzzp_;
        };
        IEnumerable<Observation> ezzzzzzb_ = context.Operators.Where<Observation>(dzzzzzzz_, ezzzzzza_);

        return ezzzzzzb_;
    }


    [CqlExpressionDefinition("Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzq_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        CqlDate ezzzzzzr_(Observation DBPExam)
        {
            DataType ezzzzzzz_ = DBPExam?.Effective;
            object fzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzz_);
            CqlDateTime fzzzzzzb_ = QICoreCommon_2_1_000.Instance.latest(context, fzzzzzza_);
            CqlDate fzzzzzzc_ = context.Operators.DateFrom(fzzzzzzb_);

            return fzzzzzzc_;
        };
        IEnumerable<CqlDate> ezzzzzzs_ = context.Operators.Select<Observation, CqlDate>(ezzzzzzq_, ezzzzzzr_);
        IEnumerable<CqlDate> ezzzzzzt_ = context.Operators.Distinct<CqlDate>(ezzzzzzs_);
        IEnumerable<Observation> ezzzzzzu_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        CqlDate ezzzzzzv_(Observation SBPExam)
        {
            DataType fzzzzzzd_ = SBPExam?.Effective;
            object fzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzd_);
            CqlDateTime fzzzzzzf_ = QICoreCommon_2_1_000.Instance.latest(context, fzzzzzze_);
            CqlDate fzzzzzzg_ = context.Operators.DateFrom(fzzzzzzf_);

            return fzzzzzzg_;
        };
        IEnumerable<CqlDate> ezzzzzzw_ = context.Operators.Select<Observation, CqlDate>(ezzzzzzu_, ezzzzzzv_);
        IEnumerable<CqlDate> ezzzzzzx_ = context.Operators.Distinct<CqlDate>(ezzzzzzw_);
        IEnumerable<CqlDate> ezzzzzzy_ = context.Operators.Intersect<CqlDate>(ezzzzzzt_, ezzzzzzx_);

        return ezzzzzzy_;
    }


    [CqlExpressionDefinition("Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzh_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> fzzzzzzi_ = context.Operators.ListSort<CqlDate>(fzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate fzzzzzzj_ = context.Operators.Last<CqlDate>(fzzzzzzi_);

        return fzzzzzzj_;
    }


    [CqlExpressionDefinition("Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> fzzzzzzk_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? fzzzzzzl_(Observation SBPReading)
        {
            DataType fzzzzzzs_ = SBPReading?.Effective;
            object fzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzs_);
            CqlDateTime fzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, fzzzzzzt_);
            CqlDate fzzzzzzv_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime fzzzzzzw_ = context.Operators.ConvertDateToDateTime(fzzzzzzv_);
            bool? fzzzzzzx_ = context.Operators.SameAs(fzzzzzzu_, fzzzzzzw_, "day");

            return fzzzzzzx_;
        };
        IEnumerable<Observation> fzzzzzzm_ = context.Operators.Where<Observation>(fzzzzzzk_, fzzzzzzl_);
        CqlQuantity fzzzzzzn_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> fzzzzzzy_ = SBPReading?.Component;
            bool? fzzzzzzz_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept gzzzzzzf_ = SBPComponent?.Code;
                CqlConcept gzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzf_);
                CqlCode gzzzzzzh_ = this.Systolic_blood_pressure(context);
                CqlConcept gzzzzzzi_ = context.Operators.ConvertCodeToConcept(gzzzzzzh_);
                bool? gzzzzzzj_ = context.Operators.Equivalent(gzzzzzzg_, gzzzzzzi_);

                return gzzzzzzj_;
            };
            IEnumerable<Observation.ComponentComponent> gzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)fzzzzzzy_, fzzzzzzz_);
            CqlQuantity gzzzzzzb_(Observation.ComponentComponent SBPComponent)
            {
                DataType gzzzzzzk_ = SBPComponent?.Value;
                object gzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzk_);

                return gzzzzzzl_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> gzzzzzzc_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(gzzzzzza_, gzzzzzzb_);
            IEnumerable<CqlQuantity> gzzzzzzd_ = context.Operators.Distinct<CqlQuantity>(gzzzzzzc_);
            CqlQuantity gzzzzzze_ = context.Operators.SingletonFrom<CqlQuantity>(gzzzzzzd_);

            return gzzzzzze_;
        };
        IEnumerable<CqlQuantity> fzzzzzzo_ = context.Operators.Select<Observation, CqlQuantity>(fzzzzzzm_, fzzzzzzn_);
        IEnumerable<CqlQuantity> fzzzzzzp_ = context.Operators.Distinct<CqlQuantity>(fzzzzzzo_);
        IEnumerable<CqlQuantity> fzzzzzzq_ = context.Operators.ListSort<CqlQuantity>(fzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity fzzzzzzr_ = context.Operators.First<CqlQuantity>(fzzzzzzq_);

        return fzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context)
    {
        CqlQuantity gzzzzzzm_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity gzzzzzzn_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? gzzzzzzo_ = context.Operators.Less(gzzzzzzm_, gzzzzzzn_);

        return gzzzzzzo_;
    }


    [CqlExpressionDefinition("Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzp_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        bool? gzzzzzzq_(Observation DBPReading)
        {
            DataType gzzzzzzx_ = DBPReading?.Effective;
            object gzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzx_);
            CqlDateTime gzzzzzzz_ = QICoreCommon_2_1_000.Instance.latest(context, gzzzzzzy_);
            CqlDate hzzzzzza_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime hzzzzzzb_ = context.Operators.ConvertDateToDateTime(hzzzzzza_);
            bool? hzzzzzzc_ = context.Operators.SameAs(gzzzzzzz_, hzzzzzzb_, "day");

            return hzzzzzzc_;
        };
        IEnumerable<Observation> gzzzzzzr_ = context.Operators.Where<Observation>(gzzzzzzp_, gzzzzzzq_);
        CqlQuantity gzzzzzzs_(Observation DBPReading)
        {
            List<Observation.ComponentComponent> hzzzzzzd_ = DBPReading?.Component;
            bool? hzzzzzze_(Observation.ComponentComponent DBPComponent)
            {
                CodeableConcept hzzzzzzk_ = DBPComponent?.Code;
                CqlConcept hzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzk_);
                CqlCode hzzzzzzm_ = this.Diastolic_blood_pressure(context);
                CqlConcept hzzzzzzn_ = context.Operators.ConvertCodeToConcept(hzzzzzzm_);
                bool? hzzzzzzo_ = context.Operators.Equivalent(hzzzzzzl_, hzzzzzzn_);

                return hzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> hzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzd_, hzzzzzze_);
            CqlQuantity hzzzzzzg_(Observation.ComponentComponent DBPComponent)
            {
                DataType hzzzzzzp_ = DBPComponent?.Value;
                object hzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzp_);

                return hzzzzzzq_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> hzzzzzzh_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(hzzzzzzf_, hzzzzzzg_);
            IEnumerable<CqlQuantity> hzzzzzzi_ = context.Operators.Distinct<CqlQuantity>(hzzzzzzh_);
            CqlQuantity hzzzzzzj_ = context.Operators.SingletonFrom<CqlQuantity>(hzzzzzzi_);

            return hzzzzzzj_;
        };
        IEnumerable<CqlQuantity> gzzzzzzt_ = context.Operators.Select<Observation, CqlQuantity>(gzzzzzzr_, gzzzzzzs_);
        IEnumerable<CqlQuantity> gzzzzzzu_ = context.Operators.Distinct<CqlQuantity>(gzzzzzzt_);
        IEnumerable<CqlQuantity> gzzzzzzv_ = context.Operators.ListSort<CqlQuantity>(gzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity gzzzzzzw_ = context.Operators.First<CqlQuantity>(gzzzzzzv_);

        return gzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context)
    {
        CqlQuantity hzzzzzzr_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity hzzzzzzs_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? hzzzzzzt_ = context.Operators.Less(hzzzzzzr_, hzzzzzzs_);

        return hzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? hzzzzzzu_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? hzzzzzzv_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? hzzzzzzw_ = context.Operators.And(hzzzzzzu_, hzzzzzzv_);

        return hzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzza_;
    }


    #endregion Expressions

}
