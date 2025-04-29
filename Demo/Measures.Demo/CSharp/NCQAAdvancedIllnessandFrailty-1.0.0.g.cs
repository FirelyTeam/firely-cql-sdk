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
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public partial class NCQAAdvancedIllnessandFrailty_1_0_0 : ILibrary, ISingleton<NCQAAdvancedIllnessandFrailty_1_0_0>
{
    private NCQAAdvancedIllnessandFrailty_1_0_0() {}

    public static NCQAAdvancedIllnessandFrailty_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAAdvancedIllnessandFrailty";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAEncounter_1_0_0.Instance, NCQAClaims_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Acute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Acute Inpatient",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810",
        valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext context) => _Acute_Inpatient;

    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);
    #endregion

    #region ValueSet: Advanced Illness
    [CqlValueSetDefinition(
        definitionName: "Advanced Illness",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465",
        valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext context) => _Advanced_Illness;

    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);
    #endregion

    #region ValueSet: Dementia Medications
    [CqlValueSetDefinition(
        definitionName: "Dementia Medications",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729",
        valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext context) => _Dementia_Medications;

    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);
    #endregion

    #region ValueSet: ED
    [CqlValueSetDefinition(
        definitionName: "ED",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086",
        valueSetVersion: null)]
    public CqlValueSet ED(CqlContext context) => _ED;

    private static readonly CqlValueSet _ED = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);
    #endregion

    #region ValueSet: Frailty Device
    [CqlValueSetDefinition(
        definitionName: "Frailty Device",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext context) => _Frailty_Device;

    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);
    #endregion

    #region ValueSet: Frailty Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Frailty Diagnosis",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext context) => _Frailty_Diagnosis;

    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);
    #endregion

    #region ValueSet: Frailty Encounter
    [CqlValueSetDefinition(
        definitionName: "Frailty Encounter",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext context) => _Frailty_Encounter;

    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);
    #endregion

    #region ValueSet: Frailty Symptom
    [CqlValueSetDefinition(
        definitionName: "Frailty Symptom",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext context) => _Frailty_Symptom;

    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);
    #endregion

    #region ValueSet: Nonacute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Nonacute Inpatient",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189",
        valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext context) => _Nonacute_Inpatient;

    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);
    #endregion

    #region ValueSet: Observation
    [CqlValueSetDefinition(
        definitionName: "Observation",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191",
        valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext context) => _Observation;

    private static readonly CqlValueSet _Observation = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);
    #endregion

    #region ValueSet: Online Assessments
    [CqlValueSetDefinition(
        definitionName: "Online Assessments",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446",
        valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext context) => _Online_Assessments;

    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);
    #endregion

    #region ValueSet: Outpatient
    [CqlValueSetDefinition(
        definitionName: "Outpatient",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202",
        valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext context) => _Outpatient;

    private static readonly CqlValueSet _Outpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object azzzzzzzzzq_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzr_);

        return azzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet azzzzzzzzzt_ = this.Frailty_Device(context);
        IEnumerable<Observation> azzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzzzzzv_(Observation FrailtyDeviceApplied)
        {
            DataType bzzzzzzzzzs_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> bzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzzs_);
            CqlInterval<CqlDateTime> bzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzv_ = context.Operators.Overlaps(bzzzzzzzzzt_, bzzzzzzzzzu_, default);

            return bzzzzzzzzzv_;
        };
        IEnumerable<Observation> azzzzzzzzzw_ = context.Operators.Where<Observation>(azzzzzzzzzu_, azzzzzzzzzv_);
        bool? azzzzzzzzzx_ = context.Operators.Exists<Observation>(azzzzzzzzzw_);
        CqlValueSet azzzzzzzzzy_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> azzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> bzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, azzzzzzzzzz_);
        bool? bzzzzzzzzzb_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzy_ = context.Operators.Overlaps(bzzzzzzzzzw_, bzzzzzzzzzx_, default);

            return bzzzzzzzzzy_;
        };
        IEnumerable<Condition> bzzzzzzzzzc_ = context.Operators.Where<Condition>(bzzzzzzzzza_, bzzzzzzzzzb_);
        bool? bzzzzzzzzzd_ = context.Operators.Exists<Condition>(bzzzzzzzzzc_);
        bool? bzzzzzzzzze_ = context.Operators.Or(azzzzzzzzzx_, bzzzzzzzzzd_);
        CqlValueSet bzzzzzzzzzf_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> bzzzzzzzzzh_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, bzzzzzzzzzg_);
        bool? bzzzzzzzzzi_(Encounter FrailtyEncounter)
        {
            Period bzzzzzzzzzz_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzzz_ as object);
            CqlInterval<CqlDateTime> czzzzzzzzzb_ = this.Measurement_Period(context);
            bool? czzzzzzzzzc_ = context.Operators.Overlaps(czzzzzzzzza_, czzzzzzzzzb_, default);

            return czzzzzzzzzc_;
        };
        IEnumerable<Encounter> bzzzzzzzzzj_ = context.Operators.Where<Encounter>(bzzzzzzzzzh_, bzzzzzzzzzi_);
        bool? bzzzzzzzzzk_ = context.Operators.Exists<Encounter>(bzzzzzzzzzj_);
        bool? bzzzzzzzzzl_ = context.Operators.Or(bzzzzzzzzze_, bzzzzzzzzzk_);
        CqlValueSet bzzzzzzzzzm_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> bzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzo_(Observation FrailtySymptom)
        {
            DataType czzzzzzzzzd_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> czzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzf_ = this.Measurement_Period(context);
            bool? czzzzzzzzzg_ = context.Operators.Overlaps(czzzzzzzzze_, czzzzzzzzzf_, default);

            return czzzzzzzzzg_;
        };
        IEnumerable<Observation> bzzzzzzzzzp_ = context.Operators.Where<Observation>(bzzzzzzzzzn_, bzzzzzzzzzo_);
        bool? bzzzzzzzzzq_ = context.Operators.Exists<Observation>(bzzzzzzzzzp_);
        bool? bzzzzzzzzzr_ = context.Operators.Or(bzzzzzzzzzl_, bzzzzzzzzzq_);

        return bzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet czzzzzzzzzh_ = this.Outpatient(context);
        IEnumerable<Encounter> czzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzj_ = this.Observation(context);
        IEnumerable<Encounter> czzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzl_ = context.Operators.Union<Encounter>(czzzzzzzzzi_, czzzzzzzzzk_);
        CqlValueSet czzzzzzzzzm_ = this.ED(context);
        IEnumerable<Encounter> czzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzo_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> czzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzq_ = context.Operators.Union<Encounter>(czzzzzzzzzn_, czzzzzzzzzp_);
        IEnumerable<Encounter> czzzzzzzzzr_ = context.Operators.Union<Encounter>(czzzzzzzzzl_, czzzzzzzzzq_);
        CqlValueSet czzzzzzzzzs_ = this.Online_Assessments(context);
        IEnumerable<Encounter> czzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet czzzzzzzzzu_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> czzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzw_ = context.Operators.Union<Encounter>(czzzzzzzzzt_, czzzzzzzzzv_);
        IEnumerable<Encounter> czzzzzzzzzx_ = context.Operators.Union<Encounter>(czzzzzzzzzr_, czzzzzzzzzw_);
        IEnumerable<Encounter> czzzzzzzzzy_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, czzzzzzzzzx_);
        bool? czzzzzzzzzz_(Encounter OutpatientEncounter)
        {
            CqlValueSet dzzzzzzzzze_ = this.Advanced_Illness(context);
            IEnumerable<Condition> dzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? dzzzzzzzzzg_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, dzzzzzzzzzf_);
            Period dzzzzzzzzzh_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzh_ as object);
            CqlDateTime dzzzzzzzzzj_ = context.Operators.Start(dzzzzzzzzzi_);
            CqlDate dzzzzzzzzzk_ = context.Operators.DateFrom(dzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzm_ = context.Operators.Start(dzzzzzzzzzl_);
            CqlDate dzzzzzzzzzn_ = context.Operators.DateFrom(dzzzzzzzzzm_);
            CqlQuantity dzzzzzzzzzo_ = context.Operators.Quantity(1m, "year");
            CqlDate dzzzzzzzzzp_ = context.Operators.Subtract(dzzzzzzzzzn_, dzzzzzzzzzo_);
            CqlDateTime dzzzzzzzzzr_ = context.Operators.End(dzzzzzzzzzl_);
            CqlDate dzzzzzzzzzs_ = context.Operators.DateFrom(dzzzzzzzzzr_);
            CqlInterval<CqlDate> dzzzzzzzzzt_ = context.Operators.Interval(dzzzzzzzzzp_, dzzzzzzzzzs_, true, true);
            bool? dzzzzzzzzzu_ = context.Operators.In<CqlDate>(dzzzzzzzzzk_, dzzzzzzzzzt_, default);
            bool? dzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzg_, dzzzzzzzzzu_);

            return dzzzzzzzzzv_;
        };
        IEnumerable<Encounter> dzzzzzzzzza_ = context.Operators.Where<Encounter>(czzzzzzzzzy_, czzzzzzzzzz_);
        CqlDate dzzzzzzzzzb_(Encounter EncounterWithDiagnosis)
        {
            Period dzzzzzzzzzw_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzw_ as object);
            CqlDateTime dzzzzzzzzzy_ = context.Operators.End(dzzzzzzzzzx_);
            CqlDate dzzzzzzzzzz_ = context.Operators.DateFrom(dzzzzzzzzzy_);

            return dzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzc_ = context.Operators.Select<Encounter, CqlDate>(dzzzzzzzzza_, dzzzzzzzzzb_);
        IEnumerable<CqlDate> dzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzc_);

        return dzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> ezzzzzzzzza_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? ezzzzzzzzzb_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, ezzzzzzzzza_);
        IEnumerable<Claim> ezzzzzzzzzc_ = ezzzzzzzzzb_?.NonacuteInpatientDischarge;
        CqlValueSet ezzzzzzzzzd_ = this.Advanced_Illness(context);
        IValueSetFacade ezzzzzzzzze_ = context.Operators.CreateValueSetFacade(ezzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzf_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, ezzzzzzzzzc_, ezzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzg_ = ezzzzzzzzzf_?.ServicePeriod;
        bool? ezzzzzzzzzh_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
        {
            CqlDateTime ezzzzzzzzzm_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate ezzzzzzzzzn_ = context.Operators.DateFrom(ezzzzzzzzzm_);
            CqlInterval<CqlDateTime> ezzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzo_);
            CqlDate ezzzzzzzzzq_ = context.Operators.DateFrom(ezzzzzzzzzp_);
            CqlQuantity ezzzzzzzzzr_ = context.Operators.Quantity(1m, "year");
            CqlDate ezzzzzzzzzs_ = context.Operators.Subtract(ezzzzzzzzzq_, ezzzzzzzzzr_);
            CqlDateTime ezzzzzzzzzu_ = context.Operators.End(ezzzzzzzzzo_);
            CqlDate ezzzzzzzzzv_ = context.Operators.DateFrom(ezzzzzzzzzu_);
            CqlInterval<CqlDate> ezzzzzzzzzw_ = context.Operators.Interval(ezzzzzzzzzs_, ezzzzzzzzzv_, true, true);
            bool? ezzzzzzzzzx_ = context.Operators.In<CqlDate>(ezzzzzzzzzn_, ezzzzzzzzzw_, default);

            return ezzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzi_ = context.Operators.Where<CqlInterval<CqlDateTime>>(ezzzzzzzzzg_, ezzzzzzzzzh_);
        CqlDate ezzzzzzzzzj_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime ezzzzzzzzzy_ = context.Operators.End(InpatientDischarge);
            CqlDate ezzzzzzzzzz_ = context.Operators.DateFrom(ezzzzzzzzzy_);

            return ezzzzzzzzzz_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzk_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(ezzzzzzzzzi_, ezzzzzzzzzj_);
        IEnumerable<CqlDate> ezzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzk_);

        return ezzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzza_()
        {
            bool fzzzzzzzzzb_()
            {
                IEnumerable<CqlDate> fzzzzzzzzzc_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzzd_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzze_ = context.Operators.Union<CqlDate>(fzzzzzzzzzc_, fzzzzzzzzzd_);
                bool? fzzzzzzzzzf_ = context.Operators.Not((bool?)(fzzzzzzzzze_ is null));

                return fzzzzzzzzzf_ ?? false;
            };
            if (fzzzzzzzzzb_())
            {
                IEnumerable<CqlDate> fzzzzzzzzzg_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzzh_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzzi_ = context.Operators.Union<CqlDate>(fzzzzzzzzzg_, fzzzzzzzzzh_);

                return fzzzzzzzzzi_;
            }
            else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> fzzzzzzzzzj_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

                return fzzzzzzzzzj_;
            }
            else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> fzzzzzzzzzk_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

                return fzzzzzzzzzk_;
            }
            else
            {
                return null as IEnumerable<CqlDate>;
            }
        };

        return fzzzzzzzzza_();
    }


    [CqlExpressionDefinition(
        definitionName: "Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzzl_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> fzzzzzzzzzn_ = context.Operators.CrossJoin<CqlDate, CqlDate>(fzzzzzzzzzl_, fzzzzzzzzzl_);
        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? fzzzzzzzzzo_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? fzzzzzzzzzw_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

            return fzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> fzzzzzzzzzp_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(fzzzzzzzzzn_, fzzzzzzzzzo_);
        bool? fzzzzzzzzzq_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
        {
            CqlQuantity fzzzzzzzzzx_ = context.Operators.Quantity(1m, "day");
            CqlDate fzzzzzzzzzy_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, fzzzzzzzzzx_);
            bool? fzzzzzzzzzz_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, fzzzzzzzzzy_, default);

            return fzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> fzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(fzzzzzzzzzp_, fzzzzzzzzzq_);
        CqlDate fzzzzzzzzzs_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) =>
            tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> fzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(fzzzzzzzzzr_, fzzzzzzzzzs_);
        IEnumerable<CqlDate> fzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzt_);
        bool? fzzzzzzzzzv_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzu_);

        return fzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet gzzzzzzzzza_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> gzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> gzzzzzzzzzc_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, gzzzzzzzzzb_);
        bool? gzzzzzzzzzd_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzzg_ = this.Advanced_Illness(context);
            IEnumerable<Condition> gzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? gzzzzzzzzzi_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, gzzzzzzzzzh_);
            Period gzzzzzzzzzj_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzj_ as object);
            CqlDateTime gzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzk_);
            CqlDate gzzzzzzzzzm_ = context.Operators.DateFrom(gzzzzzzzzzl_);
            CqlInterval<CqlDateTime> gzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzn_);
            CqlDate gzzzzzzzzzp_ = context.Operators.DateFrom(gzzzzzzzzzo_);
            CqlQuantity gzzzzzzzzzq_ = context.Operators.Quantity(1m, "year");
            CqlDate gzzzzzzzzzr_ = context.Operators.Subtract(gzzzzzzzzzp_, gzzzzzzzzzq_);
            CqlDateTime gzzzzzzzzzt_ = context.Operators.End(gzzzzzzzzzn_);
            CqlDate gzzzzzzzzzu_ = context.Operators.DateFrom(gzzzzzzzzzt_);
            CqlInterval<CqlDate> gzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzr_, gzzzzzzzzzu_, true, true);
            bool? gzzzzzzzzzw_ = context.Operators.In<CqlDate>(gzzzzzzzzzm_, gzzzzzzzzzv_, default);
            bool? gzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzi_, gzzzzzzzzzw_);

            return gzzzzzzzzzx_;
        };
        IEnumerable<Encounter> gzzzzzzzzze_ = context.Operators.Where<Encounter>(gzzzzzzzzzc_, gzzzzzzzzzd_);
        bool? gzzzzzzzzzf_ = context.Operators.Exists<Encounter>(gzzzzzzzzze_);

        return gzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> gzzzzzzzzzy_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? gzzzzzzzzzz_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, gzzzzzzzzzy_);
        IEnumerable<Claim> hzzzzzzzzza_ = gzzzzzzzzzz_?.AcuteInpatientDischarge;
        CqlValueSet hzzzzzzzzzb_ = this.Advanced_Illness(context);
        IValueSetFacade hzzzzzzzzzc_ = context.Operators.CreateValueSetFacade(hzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzd_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, hzzzzzzzzza_, hzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzze_ = hzzzzzzzzzd_?.ServicePeriod;
        bool? hzzzzzzzzzf_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime hzzzzzzzzzi_ = context.Operators.End(InpatientDischarge);
            CqlDate hzzzzzzzzzj_ = context.Operators.DateFrom(hzzzzzzzzzi_);
            CqlInterval<CqlDateTime> hzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzk_);
            CqlDate hzzzzzzzzzm_ = context.Operators.DateFrom(hzzzzzzzzzl_);
            CqlQuantity hzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
            CqlDate hzzzzzzzzzo_ = context.Operators.Subtract(hzzzzzzzzzm_, hzzzzzzzzzn_);
            CqlDateTime hzzzzzzzzzq_ = context.Operators.End(hzzzzzzzzzk_);
            CqlDate hzzzzzzzzzr_ = context.Operators.DateFrom(hzzzzzzzzzq_);
            CqlInterval<CqlDate> hzzzzzzzzzs_ = context.Operators.Interval(hzzzzzzzzzo_, hzzzzzzzzzr_, true, true);
            bool? hzzzzzzzzzt_ = context.Operators.In<CqlDate>(hzzzzzzzzzj_, hzzzzzzzzzs_, default);

            return hzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzg_ = context.Operators.Where<CqlInterval<CqlDateTime>>(hzzzzzzzzze_, hzzzzzzzzzf_);
        bool? hzzzzzzzzzh_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(hzzzzzzzzzg_);

        return hzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzu_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> hzzzzzzzzzv_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, hzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> hzzzzzzzzzx_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, hzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> hzzzzzzzzzy_ = context.Operators.Union<MedicationDispense>(hzzzzzzzzzv_, hzzzzzzzzzx_);
        IEnumerable<MedicationDispense> hzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, hzzzzzzzzzy_);
        bool? izzzzzzzzza_(MedicationDispense DementiaMedDispensed)
        {
            FhirDateTime izzzzzzzzzd_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> izzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzd_ as object);
            CqlDateTime izzzzzzzzzf_ = context.Operators.Start(izzzzzzzzze_);
            CqlDate izzzzzzzzzg_ = context.Operators.DateFrom(izzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzh_);
            CqlDate izzzzzzzzzj_ = context.Operators.DateFrom(izzzzzzzzzi_);
            CqlQuantity izzzzzzzzzk_ = context.Operators.Quantity(1m, "year");
            CqlDate izzzzzzzzzl_ = context.Operators.Subtract(izzzzzzzzzj_, izzzzzzzzzk_);
            CqlDateTime izzzzzzzzzn_ = context.Operators.End(izzzzzzzzzh_);
            CqlDate izzzzzzzzzo_ = context.Operators.DateFrom(izzzzzzzzzn_);
            CqlInterval<CqlDate> izzzzzzzzzp_ = context.Operators.Interval(izzzzzzzzzl_, izzzzzzzzzo_, true, true);
            bool? izzzzzzzzzq_ = context.Operators.In<CqlDate>(izzzzzzzzzg_, izzzzzzzzzp_, default);

            return izzzzzzzzzq_;
        };
        IEnumerable<MedicationDispense> izzzzzzzzzb_ = context.Operators.Where<MedicationDispense>(hzzzzzzzzzz_, izzzzzzzzza_);
        bool? izzzzzzzzzc_ = context.Operators.Exists<MedicationDispense>(izzzzzzzzzb_);

        return izzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient izzzzzzzzzr_ = this.Patient(context);
        Date izzzzzzzzzs_ = izzzzzzzzzr_?.BirthDateElement;
        string izzzzzzzzzt_ = izzzzzzzzzs_?.Value;
        CqlDate izzzzzzzzzu_ = context.Operators.ConvertStringToDate(izzzzzzzzzt_);
        CqlInterval<CqlDateTime> izzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzw_ = context.Operators.End(izzzzzzzzzv_);
        CqlDate izzzzzzzzzx_ = context.Operators.DateFrom(izzzzzzzzzw_);
        int? izzzzzzzzzy_ = context.Operators.CalculateAgeAt(izzzzzzzzzu_, izzzzzzzzzx_, "year");
        CqlInterval<int?> izzzzzzzzzz_ = context.Operators.Interval(66, 80, true, true);
        bool? jzzzzzzzzza_ = context.Operators.In<int?>(izzzzzzzzzy_, izzzzzzzzzz_, default);
        bool? jzzzzzzzzzb_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? jzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzza_, jzzzzzzzzzb_);
        bool? jzzzzzzzzzd_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? jzzzzzzzzze_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? jzzzzzzzzzf_ = context.Operators.Or(jzzzzzzzzzd_, jzzzzzzzzze_);
        bool? jzzzzzzzzzg_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? jzzzzzzzzzh_ = context.Operators.Or(jzzzzzzzzzf_, jzzzzzzzzzg_);
        bool? jzzzzzzzzzi_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? jzzzzzzzzzj_ = context.Operators.Or(jzzzzzzzzzh_, jzzzzzzzzzi_);
        bool? jzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzc_, jzzzzzzzzzj_);
        Date jzzzzzzzzzm_ = izzzzzzzzzr_?.BirthDateElement;
        string jzzzzzzzzzn_ = jzzzzzzzzzm_?.Value;
        CqlDate jzzzzzzzzzo_ = context.Operators.ConvertStringToDate(jzzzzzzzzzn_);
        CqlDateTime jzzzzzzzzzq_ = context.Operators.End(izzzzzzzzzv_);
        CqlDate jzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzq_);
        int? jzzzzzzzzzs_ = context.Operators.CalculateAgeAt(jzzzzzzzzzo_, jzzzzzzzzzr_, "year");
        bool? jzzzzzzzzzt_ = context.Operators.GreaterOrEqual(jzzzzzzzzzs_, 81);
        bool? jzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzt_, jzzzzzzzzzb_);
        bool? jzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzk_, jzzzzzzzzzv_);

        return jzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient jzzzzzzzzzx_ = this.Patient(context);
        Date jzzzzzzzzzy_ = jzzzzzzzzzx_?.BirthDateElement;
        string jzzzzzzzzzz_ = jzzzzzzzzzy_?.Value;
        CqlDate kzzzzzzzzza_ = context.Operators.ConvertStringToDate(jzzzzzzzzzz_);
        CqlInterval<CqlDateTime> kzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzc_ = context.Operators.End(kzzzzzzzzzb_);
        CqlDate kzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzc_);
        int? kzzzzzzzzze_ = context.Operators.CalculateAgeAt(kzzzzzzzzza_, kzzzzzzzzzd_, "year");
        bool? kzzzzzzzzzf_ = context.Operators.GreaterOrEqual(kzzzzzzzzze_, 66);
        bool? kzzzzzzzzzg_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? kzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzf_, kzzzzzzzzzg_);
        bool? kzzzzzzzzzi_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? kzzzzzzzzzj_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? kzzzzzzzzzk_ = context.Operators.Or(kzzzzzzzzzi_, kzzzzzzzzzj_);
        bool? kzzzzzzzzzl_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? kzzzzzzzzzm_ = context.Operators.Or(kzzzzzzzzzk_, kzzzzzzzzzl_);
        bool? kzzzzzzzzzn_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? kzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzm_, kzzzzzzzzzn_);
        bool? kzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzh_, kzzzzzzzzzo_);

        return kzzzzzzzzzp_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
