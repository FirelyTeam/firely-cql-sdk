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
        CqlDateTime jzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzk_ = context.Operators.Interval(jzzzzzzzzzzzi_, jzzzzzzzzzzzj_, true, true);
        object jzzzzzzzzzzzl_ = context.ResolveParameter("ControllingHighBloodPressureFHIR-0.1.000", "Measurement Period", jzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzm_);

        return jzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Essential Hypertension Diagnosis")]
    public IEnumerable<Condition> Essential_Hypertension_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzo_ = this.Essential_Hypertension(context);
        IEnumerable<Condition> jzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzq_(Condition Hypertension)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Hypertension);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzu_ = context.Operators.Start(jzzzzzzzzzzzt_);
            CqlDateTime jzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzt_);
            CqlQuantity jzzzzzzzzzzzx_ = context.Operators.Quantity(6m, "months");
            CqlDateTime jzzzzzzzzzzzy_ = context.Operators.Add(jzzzzzzzzzzzw_, jzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzz_ = context.Operators.Interval(jzzzzzzzzzzzu_, jzzzzzzzzzzzy_, true, false);
            bool? kzzzzzzzzzzza_ = context.Operators.Overlaps(jzzzzzzzzzzzs_, jzzzzzzzzzzzz_, default);

            return kzzzzzzzzzzza_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzr_ = context.Operators.Where<Condition>(jzzzzzzzzzzzp_, jzzzzzzzzzzzq_);

        return jzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient kzzzzzzzzzzzb_ = this.Patient(context);
        Date kzzzzzzzzzzzc_ = kzzzzzzzzzzzb_?.BirthDateElement;
        string kzzzzzzzzzzzd_ = kzzzzzzzzzzzc_?.Value;
        CqlDate kzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzf_);
        CqlDate kzzzzzzzzzzzh_ = context.Operators.DateFrom(kzzzzzzzzzzzg_);
        int? kzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzze_, kzzzzzzzzzzzh_, "year");
        CqlInterval<int?> kzzzzzzzzzzzj_ = context.Operators.Interval(18, 85, true, true);
        bool? kzzzzzzzzzzzk_ = context.Operators.In<int?>(kzzzzzzzzzzzi_, kzzzzzzzzzzzj_, default);
        IEnumerable<Condition> kzzzzzzzzzzzl_ = this.Essential_Hypertension_Diagnosis(context);
        bool? kzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzl_);
        bool? kzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzk_, kzzzzzzzzzzzm_);
        IEnumerable<Encounter> kzzzzzzzzzzzo_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? kzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzq_ = context.Operators.And(kzzzzzzzzzzzn_, kzzzzzzzzzzzp_);

        return kzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzr_ = this.Initial_Population(context);

        return kzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Pregnancy or Renal Diagnosis")]
    public IEnumerable<Condition> Pregnancy_or_Renal_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzs_ = this.Pregnancy(context);
        IEnumerable<Condition> kzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzzzzzzzzzu_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> kzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> kzzzzzzzzzzzw_ = context.Operators.Union<Condition>(kzzzzzzzzzzzt_, kzzzzzzzzzzzv_);
        CqlValueSet kzzzzzzzzzzzx_ = this.Kidney_Transplant_Recipient(context);
        IEnumerable<Condition> kzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzzzzzzzzzz_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> lzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzb_ = context.Operators.Union<Condition>(kzzzzzzzzzzzy_, lzzzzzzzzzzza_);
        IEnumerable<Condition> lzzzzzzzzzzzc_ = context.Operators.Union<Condition>(kzzzzzzzzzzzw_, lzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzd_(Condition PregnancyESRDDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PregnancyESRDDiagnosis);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzh_ = context.Operators.Overlaps(lzzzzzzzzzzzf_, lzzzzzzzzzzzg_, default);

            return lzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> lzzzzzzzzzzze_ = context.Operators.Where<Condition>(lzzzzzzzzzzzc_, lzzzzzzzzzzzd_);

        return lzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Procedures")]
    public IEnumerable<Procedure> End_Stage_Renal_Disease_Procedures(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzi_ = this.Kidney_Transplant(context);
        IEnumerable<Procedure> lzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet lzzzzzzzzzzzk_ = this.Dialysis_Services(context);
        IEnumerable<Procedure> lzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzm_ = context.Operators.Union<Procedure>(lzzzzzzzzzzzj_, lzzzzzzzzzzzl_);
        IEnumerable<Procedure> lzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzo_(Procedure ESRDProcedure)
        {
            DataType lzzzzzzzzzzzq_ = ESRDProcedure?.Performed;
            object lzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzr_);
            CqlDateTime lzzzzzzzzzzzt_ = context.Operators.End(lzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzv_ = context.Operators.End(lzzzzzzzzzzzu_);
            bool? lzzzzzzzzzzzw_ = context.Operators.SameOrBefore(lzzzzzzzzzzzt_, lzzzzzzzzzzzv_, default);

            return lzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzn_, lzzzzzzzzzzzo_);

        return lzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("End Stage Renal Disease Encounter")]
    public IEnumerable<Encounter> End_Stage_Renal_Disease_Encounter(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzx_ = this.ESRD_Monthly_Outpatient_Services(context);
        IEnumerable<Encounter> lzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzz_ = Status_1_8_000.Instance.isEncounterPerformed(context, lzzzzzzzzzzzy_);
        bool? mzzzzzzzzzzza_(Encounter ESRDEncounter)
        {
            Period mzzzzzzzzzzzc_ = ESRDEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzd_ as object);
            CqlDateTime mzzzzzzzzzzzf_ = context.Operators.Start(mzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzh_ = context.Operators.End(mzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzi_ = context.Operators.SameOrBefore(mzzzzzzzzzzzf_, mzzzzzzzzzzzh_, default);

            return mzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzz_, mzzzzzzzzzzza_);

        return mzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzzzzzzzzzj_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> mzzzzzzzzzzzk_ = this.Pregnancy_or_Renal_Diagnosis(context);
        bool? mzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzk_);
        bool? mzzzzzzzzzzzm_ = context.Operators.Or(mzzzzzzzzzzzj_, mzzzzzzzzzzzl_);
        IEnumerable<Procedure> mzzzzzzzzzzzn_ = this.End_Stage_Renal_Disease_Procedures(context);
        bool? mzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzn_);
        bool? mzzzzzzzzzzzp_ = context.Operators.Or(mzzzzzzzzzzzm_, mzzzzzzzzzzzo_);
        IEnumerable<Encounter> mzzzzzzzzzzzq_ = this.End_Stage_Renal_Disease_Encounter(context);
        bool? mzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzq_);
        bool? mzzzzzzzzzzzs_ = context.Operators.Or(mzzzzzzzzzzzp_, mzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzt_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(context);
        bool? mzzzzzzzzzzzu_ = context.Operators.Or(mzzzzzzzzzzzs_, mzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzv_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? mzzzzzzzzzzzw_ = context.Operators.Or(mzzzzzzzzzzzu_, mzzzzzzzzzzzv_);
        bool? mzzzzzzzzzzzx_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? mzzzzzzzzzzzy_ = context.Operators.Or(mzzzzzzzzzzzw_, mzzzzzzzzzzzx_);

        return mzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("getEncounter")]
    public Encounter getEncounter(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzzzzzzzzzza_(Encounter E)
        {
            Id nzzzzzzzzzzzd_ = E?.IdElement;
            string nzzzzzzzzzzze_ = nzzzzzzzzzzzd_?.Value;
            FhirString nzzzzzzzzzzzf_ = reference?.ReferenceElement;
            string nzzzzzzzzzzzg_ = nzzzzzzzzzzzf_?.Value;
            string nzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.getId(context, nzzzzzzzzzzzg_);
            bool? nzzzzzzzzzzzi_ = context.Operators.Equal(nzzzzzzzzzzze_, nzzzzzzzzzzzh_);

            return nzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzz_, nzzzzzzzzzzza_);
        Encounter nzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Encounter>(nzzzzzzzzzzzb_);

        return nzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> nzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> nzzzzzzzzzzzk_ = Status_1_8_000.Instance.isObservationBP(context, nzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzl_(Observation BloodPressure)
        {
            ResourceReference nzzzzzzzzzzzn_ = BloodPressure?.Encounter;
            Encounter nzzzzzzzzzzzo_ = this.getEncounter(context, nzzzzzzzzzzzn_);
            Coding nzzzzzzzzzzzp_ = nzzzzzzzzzzzo_?.Class;
            CqlCode nzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToCode(context, nzzzzzzzzzzzp_);
            string nzzzzzzzzzzzr_ = nzzzzzzzzzzzq_?.code;
            string[] nzzzzzzzzzzzs_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? nzzzzzzzzzzzt_ = context.Operators.In<string>(nzzzzzzzzzzzr_, nzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzu_ = context.Operators.Not(nzzzzzzzzzzzt_);
            DataType nzzzzzzzzzzzv_ = BloodPressure?.Effective;
            object nzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzv_);
            CqlDateTime nzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, nzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzx_, nzzzzzzzzzzzy_, "day");
            bool? ozzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzu_, nzzzzzzzzzzzz_);

            return ozzzzzzzzzzza_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzm_ = context.Operators.Where<Observation>(nzzzzzzzzzzzk_, nzzzzzzzzzzzl_);

        return nzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Diastolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Diastolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> ozzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        IEnumerable<Observation> ozzzzzzzzzzzc_ = Status_1_8_000.Instance.isObservationBP(context, ozzzzzzzzzzzb_);
        bool? ozzzzzzzzzzzd_(Observation BloodPressure)
        {
            ResourceReference ozzzzzzzzzzzf_ = BloodPressure?.Encounter;
            Encounter ozzzzzzzzzzzg_ = this.getEncounter(context, ozzzzzzzzzzzf_);
            Coding ozzzzzzzzzzzh_ = ozzzzzzzzzzzg_?.Class;
            CqlCode ozzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToCode(context, ozzzzzzzzzzzh_);
            string ozzzzzzzzzzzj_ = ozzzzzzzzzzzi_?.code;
            string[] ozzzzzzzzzzzk_ = [
                "EMER",
                "IMP",
                "ACUTE",
                "NONAC",
                "PRENC",
                "SS",
            ];
            bool? ozzzzzzzzzzzl_ = context.Operators.In<string>(ozzzzzzzzzzzj_, ozzzzzzzzzzzk_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzm_ = context.Operators.Not(ozzzzzzzzzzzl_);
            DataType ozzzzzzzzzzzn_ = BloodPressure?.Effective;
            object ozzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzn_);
            CqlDateTime ozzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzp_, ozzzzzzzzzzzq_, "day");
            bool? ozzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzm_, ozzzzzzzzzzzr_);

            return ozzzzzzzzzzzs_;
        };
        IEnumerable<Observation> ozzzzzzzzzzze_ = context.Operators.Where<Observation>(ozzzzzzzzzzzc_, ozzzzzzzzzzzd_);

        return ozzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Blood Pressure Days")]
    public IEnumerable<CqlDate> Blood_Pressure_Days(CqlContext context)
    {
        IEnumerable<Observation> ozzzzzzzzzzzt_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        CqlDate ozzzzzzzzzzzu_(Observation DBPExam)
        {
            DataType pzzzzzzzzzzzc_ = DBPExam?.Effective;
            object pzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzc_);
            CqlDateTime pzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzd_);
            CqlDate pzzzzzzzzzzzf_ = context.Operators.DateFrom(pzzzzzzzzzzze_);

            return pzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzv_ = context.Operators.Select<Observation, CqlDate>(ozzzzzzzzzzzt_, ozzzzzzzzzzzu_);
        IEnumerable<CqlDate> ozzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzv_);
        IEnumerable<Observation> ozzzzzzzzzzzx_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        CqlDate ozzzzzzzzzzzy_(Observation SBPExam)
        {
            DataType pzzzzzzzzzzzg_ = SBPExam?.Effective;
            object pzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzg_);
            CqlDateTime pzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzh_);
            CqlDate pzzzzzzzzzzzj_ = context.Operators.DateFrom(pzzzzzzzzzzzi_);

            return pzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzz_ = context.Operators.Select<Observation, CqlDate>(ozzzzzzzzzzzx_, ozzzzzzzzzzzy_);
        IEnumerable<CqlDate> pzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzz_);
        IEnumerable<CqlDate> pzzzzzzzzzzzb_ = context.Operators.Intersect<CqlDate>(ozzzzzzzzzzzw_, pzzzzzzzzzzza_);

        return pzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Most Recent Blood Pressure Day")]
    public CqlDate Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<CqlDate> pzzzzzzzzzzzk_ = this.Blood_Pressure_Days(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzl_ = context.Operators.ListSort<CqlDate>(pzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDate pzzzzzzzzzzzm_ = context.Operators.Last<CqlDate>(pzzzzzzzzzzzl_);

        return pzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Lowest Systolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzn_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? pzzzzzzzzzzzo_(Observation SBPReading)
        {
            DataType pzzzzzzzzzzzv_ = SBPReading?.Effective;
            object pzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzv_);
            CqlDateTime pzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzw_);
            CqlDate pzzzzzzzzzzzy_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime pzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzza_ = context.Operators.SameAs(pzzzzzzzzzzzx_, pzzzzzzzzzzzz_, "day");

            return qzzzzzzzzzzza_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzp_ = context.Operators.Where<Observation>(pzzzzzzzzzzzn_, pzzzzzzzzzzzo_);
        CqlQuantity pzzzzzzzzzzzq_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> qzzzzzzzzzzzb_ = SBPReading?.Component;
            bool? qzzzzzzzzzzzc_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept qzzzzzzzzzzzi_ = SBPComponent?.Code;
                CqlConcept qzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzi_);
                CqlCode qzzzzzzzzzzzk_ = this.Systolic_blood_pressure(context);
                CqlConcept qzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzk_);
                bool? qzzzzzzzzzzzm_ = context.Operators.Equivalent(qzzzzzzzzzzzj_, qzzzzzzzzzzzl_);

                return qzzzzzzzzzzzm_;
            };
            IEnumerable<Observation.ComponentComponent> qzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)qzzzzzzzzzzzb_, qzzzzzzzzzzzc_);
            CqlQuantity qzzzzzzzzzzze_(Observation.ComponentComponent SBPComponent)
            {
                DataType qzzzzzzzzzzzn_ = SBPComponent?.Value;
                object qzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzn_);

                return qzzzzzzzzzzzo_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> qzzzzzzzzzzzf_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(qzzzzzzzzzzzd_, qzzzzzzzzzzze_);
            IEnumerable<CqlQuantity> qzzzzzzzzzzzg_ = context.Operators.Distinct<CqlQuantity>(qzzzzzzzzzzzf_);
            CqlQuantity qzzzzzzzzzzzh_ = context.Operators.SingletonFrom<CqlQuantity>(qzzzzzzzzzzzg_);

            return qzzzzzzzzzzzh_;
        };
        IEnumerable<CqlQuantity> pzzzzzzzzzzzr_ = context.Operators.Select<Observation, CqlQuantity>(pzzzzzzzzzzzp_, pzzzzzzzzzzzq_);
        IEnumerable<CqlQuantity> pzzzzzzzzzzzs_ = context.Operators.Distinct<CqlQuantity>(pzzzzzzzzzzzr_);
        IEnumerable<CqlQuantity> pzzzzzzzzzzzt_ = context.Operators.ListSort<CqlQuantity>(pzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity pzzzzzzzzzzzu_ = context.Operators.First<CqlQuantity>(pzzzzzzzzzzzt_);

        return pzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Systolic Blood Pressure Less Than 140")]
    public bool? Has_Systolic_Blood_Pressure_Less_Than_140(CqlContext context)
    {
        CqlQuantity qzzzzzzzzzzzp_ = this.Lowest_Systolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity qzzzzzzzzzzzq_ = context.Operators.Quantity(140m, "mm[Hg]");
        bool? qzzzzzzzzzzzr_ = context.Operators.Less(qzzzzzzzzzzzp_, qzzzzzzzzzzzq_);

        return qzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Lowest Diastolic Reading on Most Recent Blood Pressure Day")]
    public CqlQuantity Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzs_ = this.Qualifying_Diastolic_Blood_Pressure_Reading(context);
        bool? qzzzzzzzzzzzt_(Observation DBPReading)
        {
            DataType rzzzzzzzzzzza_ = DBPReading?.Effective;
            object rzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzza_);
            CqlDateTime rzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, rzzzzzzzzzzzb_);
            CqlDate rzzzzzzzzzzzd_ = this.Most_Recent_Blood_Pressure_Day(context);
            CqlDateTime rzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzf_ = context.Operators.SameAs(rzzzzzzzzzzzc_, rzzzzzzzzzzze_, "day");

            return rzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzu_ = context.Operators.Where<Observation>(qzzzzzzzzzzzs_, qzzzzzzzzzzzt_);
        CqlQuantity qzzzzzzzzzzzv_(Observation DBPReading)
        {
            List<Observation.ComponentComponent> rzzzzzzzzzzzg_ = DBPReading?.Component;
            bool? rzzzzzzzzzzzh_(Observation.ComponentComponent DBPComponent)
            {
                CodeableConcept rzzzzzzzzzzzn_ = DBPComponent?.Code;
                CqlConcept rzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzn_);
                CqlCode rzzzzzzzzzzzp_ = this.Diastolic_blood_pressure(context);
                CqlConcept rzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzr_ = context.Operators.Equivalent(rzzzzzzzzzzzo_, rzzzzzzzzzzzq_);

                return rzzzzzzzzzzzr_;
            };
            IEnumerable<Observation.ComponentComponent> rzzzzzzzzzzzi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)rzzzzzzzzzzzg_, rzzzzzzzzzzzh_);
            CqlQuantity rzzzzzzzzzzzj_(Observation.ComponentComponent DBPComponent)
            {
                DataType rzzzzzzzzzzzs_ = DBPComponent?.Value;
                object rzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzs_);

                return rzzzzzzzzzzzt_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> rzzzzzzzzzzzk_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(rzzzzzzzzzzzi_, rzzzzzzzzzzzj_);
            IEnumerable<CqlQuantity> rzzzzzzzzzzzl_ = context.Operators.Distinct<CqlQuantity>(rzzzzzzzzzzzk_);
            CqlQuantity rzzzzzzzzzzzm_ = context.Operators.SingletonFrom<CqlQuantity>(rzzzzzzzzzzzl_);

            return rzzzzzzzzzzzm_;
        };
        IEnumerable<CqlQuantity> qzzzzzzzzzzzw_ = context.Operators.Select<Observation, CqlQuantity>(qzzzzzzzzzzzu_, qzzzzzzzzzzzv_);
        IEnumerable<CqlQuantity> qzzzzzzzzzzzx_ = context.Operators.Distinct<CqlQuantity>(qzzzzzzzzzzzw_);
        IEnumerable<CqlQuantity> qzzzzzzzzzzzy_ = context.Operators.ListSort<CqlQuantity>(qzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity qzzzzzzzzzzzz_ = context.Operators.First<CqlQuantity>(qzzzzzzzzzzzy_);

        return qzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Diastolic Blood Pressure Less Than 90")]
    public bool? Has_Diastolic_Blood_Pressure_Less_Than_90(CqlContext context)
    {
        CqlQuantity rzzzzzzzzzzzu_ = this.Lowest_Diastolic_Reading_on_Most_Recent_Blood_Pressure_Day(context);
        CqlQuantity rzzzzzzzzzzzv_ = context.Operators.Quantity(90m, "mm[Hg]");
        bool? rzzzzzzzzzzzw_ = context.Operators.Less(rzzzzzzzzzzzu_, rzzzzzzzzzzzv_);

        return rzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? rzzzzzzzzzzzx_ = this.Has_Systolic_Blood_Pressure_Less_Than_140(context);
        bool? rzzzzzzzzzzzy_ = this.Has_Diastolic_Blood_Pressure_Less_Than_90(context);
        bool? rzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzx_, rzzzzzzzzzzzy_);

        return rzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzd_;
    }


    #endregion Expressions

}
