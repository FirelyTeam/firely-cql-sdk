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

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);

    [CqlValueSetDefinition("ED", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", valueSetVersion: null)]
    public CqlValueSet ED(CqlContext _) => _ED;
    private static readonly CqlValueSet _ED = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);

    [CqlValueSetDefinition("Nonacute Inpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext _) => _Nonacute_Inpatient;
    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);

    [CqlValueSetDefinition("Observation", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext _) => _Observation;
    private static readonly CqlValueSet _Observation = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);

    [CqlValueSetDefinition("Outpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlValueSet _Outpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object mzzzzzzzzzzza_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzb_);

        return mzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzd_ = this.Frailty_Device(context);
        IEnumerable<Observation> mzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzzzzzzzf_(Observation FrailtyDeviceApplied)
        {
            DataType nzzzzzzzzzzzc_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzf_ = context.Operators.Overlaps(nzzzzzzzzzzzd_, nzzzzzzzzzzze_, default);

            return nzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzg_ = context.Operators.Where<Observation>(mzzzzzzzzzzze_, mzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzg_);
        CqlValueSet mzzzzzzzzzzzi_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> mzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> mzzzzzzzzzzzk_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, mzzzzzzzzzzzj_);
        bool? mzzzzzzzzzzzl_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzi_ = context.Operators.Overlaps(nzzzzzzzzzzzg_, nzzzzzzzzzzzh_, default);

            return nzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzm_ = context.Operators.Where<Condition>(mzzzzzzzzzzzk_, mzzzzzzzzzzzl_);
        bool? mzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzo_ = context.Operators.Or(mzzzzzzzzzzzh_, mzzzzzzzzzzzn_);
        CqlValueSet mzzzzzzzzzzzp_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzr_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, mzzzzzzzzzzzq_);
        bool? mzzzzzzzzzzzs_(Encounter FrailtyEncounter)
        {
            Period nzzzzzzzzzzzj_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzzzj_ as object);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzm_ = context.Operators.Overlaps(nzzzzzzzzzzzk_, nzzzzzzzzzzzl_, default);

            return nzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzr_, mzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzv_ = context.Operators.Or(mzzzzzzzzzzzo_, mzzzzzzzzzzzu_);
        CqlValueSet mzzzzzzzzzzzw_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> mzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? mzzzzzzzzzzzy_(Observation FrailtySymptom)
        {
            DataType nzzzzzzzzzzzn_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzq_ = context.Operators.Overlaps(nzzzzzzzzzzzo_, nzzzzzzzzzzzp_, default);

            return nzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzz_ = context.Operators.Where<Observation>(mzzzzzzzzzzzx_, mzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzza_ = context.Operators.Exists<Observation>(mzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzb_ = context.Operators.Or(mzzzzzzzzzzzv_, nzzzzzzzzzzza_);

        return nzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzr_ = this.Outpatient(context);
        IEnumerable<Encounter> nzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet nzzzzzzzzzzzt_ = this.Observation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzs_, nzzzzzzzzzzzu_);
        CqlValueSet nzzzzzzzzzzzw_ = this.ED(context);
        IEnumerable<Encounter> nzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet nzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzza_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzx_, nzzzzzzzzzzzz_);
        IEnumerable<Encounter> ozzzzzzzzzzzb_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzv_, ozzzzzzzzzzza_);
        CqlValueSet ozzzzzzzzzzzc_ = this.Online_Assessments(context);
        IEnumerable<Encounter> ozzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzze_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> ozzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzg_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzd_, ozzzzzzzzzzzf_);
        IEnumerable<Encounter> ozzzzzzzzzzzh_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzb_, ozzzzzzzzzzzg_);
        IEnumerable<Encounter> ozzzzzzzzzzzi_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, ozzzzzzzzzzzh_);
        bool? ozzzzzzzzzzzj_(Encounter OutpatientEncounter)
        {
            CqlValueSet ozzzzzzzzzzzo_ = this.Advanced_Illness(context);
            IEnumerable<Condition> ozzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? ozzzzzzzzzzzq_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, ozzzzzzzzzzzp_);
            Period ozzzzzzzzzzzr_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ozzzzzzzzzzzr_ as object);
            CqlDateTime ozzzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzzs_);
            CqlDate ozzzzzzzzzzzu_ = context.Operators.DateFrom(ozzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzv_);
            CqlDate ozzzzzzzzzzzx_ = context.Operators.DateFrom(ozzzzzzzzzzzw_);
            CqlQuantity ozzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
            CqlDate ozzzzzzzzzzzz_ = context.Operators.Subtract(ozzzzzzzzzzzx_, ozzzzzzzzzzzy_);
            CqlDateTime pzzzzzzzzzzzb_ = context.Operators.End(ozzzzzzzzzzzv_);
            CqlDate pzzzzzzzzzzzc_ = context.Operators.DateFrom(pzzzzzzzzzzzb_);
            CqlInterval<CqlDate> pzzzzzzzzzzzd_ = context.Operators.Interval(ozzzzzzzzzzzz_, pzzzzzzzzzzzc_, true, true);
            bool? pzzzzzzzzzzze_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzu_, pzzzzzzzzzzzd_, default);
            bool? pzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzq_, pzzzzzzzzzzze_);

            return pzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzk_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzi_, ozzzzzzzzzzzj_);
        CqlDate ozzzzzzzzzzzl_(Encounter EncounterWithDiagnosis)
        {
            Period pzzzzzzzzzzzg_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, pzzzzzzzzzzzg_ as object);
            CqlDateTime pzzzzzzzzzzzi_ = context.Operators.End(pzzzzzzzzzzzh_);
            CqlDate pzzzzzzzzzzzj_ = context.Operators.DateFrom(pzzzzzzzzzzzi_);

            return pzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzm_ = context.Operators.Select<Encounter, CqlDate>(ozzzzzzzzzzzk_, ozzzzzzzzzzzl_);
        IEnumerable<CqlDate> ozzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzm_);

        return ozzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> pzzzzzzzzzzzk_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? pzzzzzzzzzzzl_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, pzzzzzzzzzzzk_);
        IEnumerable<Claim> pzzzzzzzzzzzm_ = pzzzzzzzzzzzl_?.NonacuteInpatientDischarge;
        CqlValueSet pzzzzzzzzzzzn_ = this.Advanced_Illness(context);
        IValueSetFacade pzzzzzzzzzzzo_ = context.Operators.CreateValueSetFacade(pzzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzzzzzp_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, pzzzzzzzzzzzm_, pzzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzq_ = pzzzzzzzzzzzp_?.ServicePeriod;
        bool? pzzzzzzzzzzzr_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
        {
            CqlDateTime pzzzzzzzzzzzw_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate pzzzzzzzzzzzx_ = context.Operators.DateFrom(pzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzz_ = context.Operators.Start(pzzzzzzzzzzzy_);
            CqlDate qzzzzzzzzzzza_ = context.Operators.DateFrom(pzzzzzzzzzzzz_);
            CqlQuantity qzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "year");
            CqlDate qzzzzzzzzzzzc_ = context.Operators.Subtract(qzzzzzzzzzzza_, qzzzzzzzzzzzb_);
            CqlDateTime qzzzzzzzzzzze_ = context.Operators.End(pzzzzzzzzzzzy_);
            CqlDate qzzzzzzzzzzzf_ = context.Operators.DateFrom(qzzzzzzzzzzze_);
            CqlInterval<CqlDate> qzzzzzzzzzzzg_ = context.Operators.Interval(qzzzzzzzzzzzc_, qzzzzzzzzzzzf_, true, true);
            bool? qzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzx_, qzzzzzzzzzzzg_, default);

            return qzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzs_ = context.Operators.Where<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzq_, pzzzzzzzzzzzr_);
        CqlDate pzzzzzzzzzzzt_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime qzzzzzzzzzzzi_ = context.Operators.End(InpatientDischarge);
            CqlDate qzzzzzzzzzzzj_ = context.Operators.DateFrom(qzzzzzzzzzzzi_);

            return qzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(pzzzzzzzzzzzs_, pzzzzzzzzzzzt_);
        IEnumerable<CqlDate> pzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzu_);

        return pzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzzzzzzzzk_()
        {
            bool qzzzzzzzzzzzl_()
            {
                IEnumerable<CqlDate> qzzzzzzzzzzzm_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> qzzzzzzzzzzzn_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> qzzzzzzzzzzzo_ = context.Operators.Union<CqlDate>(qzzzzzzzzzzzm_, qzzzzzzzzzzzn_);
                bool? qzzzzzzzzzzzp_ = context.Operators.Not((bool?)(qzzzzzzzzzzzo_ is null));

                return qzzzzzzzzzzzp_ ?? false;
            };
            if (qzzzzzzzzzzzl_())
            {
                IEnumerable<CqlDate> qzzzzzzzzzzzq_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> qzzzzzzzzzzzr_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> qzzzzzzzzzzzs_ = context.Operators.Union<CqlDate>(qzzzzzzzzzzzq_, qzzzzzzzzzzzr_);

                return qzzzzzzzzzzzs_;
            }
            else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> qzzzzzzzzzzzt_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

                return qzzzzzzzzzzzt_;
            }
            else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> qzzzzzzzzzzzu_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

                return qzzzzzzzzzzzu_;
            }
            else
            {
                return null as IEnumerable<CqlDate>;
            }
        };

        return qzzzzzzzzzzzk_();
    }


    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzzzzzzzzv_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> qzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate>(qzzzzzzzzzzzv_, qzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? qzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? rzzzzzzzzzzzg_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

            return rzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> qzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(qzzzzzzzzzzzx_, qzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzza_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
        {
            CqlQuantity rzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "day");
            CqlDate rzzzzzzzzzzzi_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, rzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzj_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, rzzzzzzzzzzzi_, default);

            return rzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> rzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(qzzzzzzzzzzzz_, rzzzzzzzzzzza_);
        CqlDate rzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) =>
            tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> rzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(rzzzzzzzzzzzb_, rzzzzzzzzzzzc_);
        IEnumerable<CqlDate> rzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzf_ = context.Operators.Exists<CqlDate>(rzzzzzzzzzzze_);

        return rzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzk_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> rzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, rzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet rzzzzzzzzzzzq_ = this.Advanced_Illness(context);
            IEnumerable<Condition> rzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? rzzzzzzzzzzzs_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, rzzzzzzzzzzzr_);
            Period rzzzzzzzzzzzt_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzzzzt_ as object);
            CqlDateTime rzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzu_);
            CqlDate rzzzzzzzzzzzw_ = context.Operators.DateFrom(rzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzx_);
            CqlDate rzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzy_);
            CqlQuantity szzzzzzzzzzza_ = context.Operators.Quantity(1m, "year");
            CqlDate szzzzzzzzzzzb_ = context.Operators.Subtract(rzzzzzzzzzzzz_, szzzzzzzzzzza_);
            CqlDateTime szzzzzzzzzzzd_ = context.Operators.End(rzzzzzzzzzzzx_);
            CqlDate szzzzzzzzzzze_ = context.Operators.DateFrom(szzzzzzzzzzzd_);
            CqlInterval<CqlDate> szzzzzzzzzzzf_ = context.Operators.Interval(szzzzzzzzzzzb_, szzzzzzzzzzze_, true, true);
            bool? szzzzzzzzzzzg_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzw_, szzzzzzzzzzzf_, default);
            bool? szzzzzzzzzzzh_ = context.Operators.And(rzzzzzzzzzzzs_, szzzzzzzzzzzg_);

            return szzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzm_, rzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzo_);

        return rzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> szzzzzzzzzzzi_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? szzzzzzzzzzzj_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, szzzzzzzzzzzi_);
        IEnumerable<Claim> szzzzzzzzzzzk_ = szzzzzzzzzzzj_?.AcuteInpatientDischarge;
        CqlValueSet szzzzzzzzzzzl_ = this.Advanced_Illness(context);
        IValueSetFacade szzzzzzzzzzzm_ = context.Operators.CreateValueSetFacade(szzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzn_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, szzzzzzzzzzzk_, szzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzo_ = szzzzzzzzzzzn_?.ServicePeriod;
        bool? szzzzzzzzzzzp_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime szzzzzzzzzzzs_ = context.Operators.End(InpatientDischarge);
            CqlDate szzzzzzzzzzzt_ = context.Operators.DateFrom(szzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzv_ = context.Operators.Start(szzzzzzzzzzzu_);
            CqlDate szzzzzzzzzzzw_ = context.Operators.DateFrom(szzzzzzzzzzzv_);
            CqlQuantity szzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
            CqlDate szzzzzzzzzzzy_ = context.Operators.Subtract(szzzzzzzzzzzw_, szzzzzzzzzzzx_);
            CqlDateTime tzzzzzzzzzzza_ = context.Operators.End(szzzzzzzzzzzu_);
            CqlDate tzzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzzza_);
            CqlInterval<CqlDate> tzzzzzzzzzzzc_ = context.Operators.Interval(szzzzzzzzzzzy_, tzzzzzzzzzzzb_, true, true);
            bool? tzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(szzzzzzzzzzzt_, tzzzzzzzzzzzc_, default);

            return tzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzq_ = context.Operators.Where<CqlInterval<CqlDateTime>>(szzzzzzzzzzzo_, szzzzzzzzzzzp_);
        bool? szzzzzzzzzzzr_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(szzzzzzzzzzzq_);

        return szzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzze_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> tzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, tzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> tzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, tzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> tzzzzzzzzzzzi_ = context.Operators.Union<MedicationDispense>(tzzzzzzzzzzzf_, tzzzzzzzzzzzh_);
        IEnumerable<MedicationDispense> tzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, tzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzk_(MedicationDispense DementiaMedDispensed)
        {
            FhirDateTime tzzzzzzzzzzzn_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzn_ as object);
            CqlDateTime tzzzzzzzzzzzp_ = context.Operators.Start(tzzzzzzzzzzzo_);
            CqlDate tzzzzzzzzzzzq_ = context.Operators.DateFrom(tzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzs_ = context.Operators.Start(tzzzzzzzzzzzr_);
            CqlDate tzzzzzzzzzzzt_ = context.Operators.DateFrom(tzzzzzzzzzzzs_);
            CqlQuantity tzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDate tzzzzzzzzzzzv_ = context.Operators.Subtract(tzzzzzzzzzzzt_, tzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzx_ = context.Operators.End(tzzzzzzzzzzzr_);
            CqlDate tzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzx_);
            CqlInterval<CqlDate> tzzzzzzzzzzzz_ = context.Operators.Interval(tzzzzzzzzzzzv_, tzzzzzzzzzzzy_, true, true);
            bool? uzzzzzzzzzzza_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzq_, tzzzzzzzzzzzz_, default);

            return uzzzzzzzzzzza_;
        };
        IEnumerable<MedicationDispense> tzzzzzzzzzzzl_ = context.Operators.Where<MedicationDispense>(tzzzzzzzzzzzj_, tzzzzzzzzzzzk_);
        bool? tzzzzzzzzzzzm_ = context.Operators.Exists<MedicationDispense>(tzzzzzzzzzzzl_);

        return tzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient uzzzzzzzzzzzb_ = this.Patient(context);
        Date uzzzzzzzzzzzc_ = uzzzzzzzzzzzb_?.BirthDateElement;
        string uzzzzzzzzzzzd_ = uzzzzzzzzzzzc_?.Value;
        CqlDate uzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzg_ = context.Operators.End(uzzzzzzzzzzzf_);
        CqlDate uzzzzzzzzzzzh_ = context.Operators.DateFrom(uzzzzzzzzzzzg_);
        int? uzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzze_, uzzzzzzzzzzzh_, "year");
        CqlInterval<int?> uzzzzzzzzzzzj_ = context.Operators.Interval(66, 80, true, true);
        bool? uzzzzzzzzzzzk_ = context.Operators.In<int?>(uzzzzzzzzzzzi_, uzzzzzzzzzzzj_, default);
        bool? uzzzzzzzzzzzl_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? uzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzk_, uzzzzzzzzzzzl_);
        bool? uzzzzzzzzzzzn_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? uzzzzzzzzzzzo_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? uzzzzzzzzzzzp_ = context.Operators.Or(uzzzzzzzzzzzn_, uzzzzzzzzzzzo_);
        bool? uzzzzzzzzzzzq_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? uzzzzzzzzzzzr_ = context.Operators.Or(uzzzzzzzzzzzp_, uzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzs_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? uzzzzzzzzzzzt_ = context.Operators.Or(uzzzzzzzzzzzr_, uzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzm_, uzzzzzzzzzzzt_);
        Date uzzzzzzzzzzzw_ = uzzzzzzzzzzzb_?.BirthDateElement;
        string uzzzzzzzzzzzx_ = uzzzzzzzzzzzw_?.Value;
        CqlDate uzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzx_);
        CqlDateTime vzzzzzzzzzzza_ = context.Operators.End(uzzzzzzzzzzzf_);
        CqlDate vzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzza_);
        int? vzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzy_, vzzzzzzzzzzzb_, "year");
        bool? vzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzc_, 81);
        bool? vzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzd_, uzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzg_ = context.Operators.Or(uzzzzzzzzzzzu_, vzzzzzzzzzzzf_);

        return vzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient vzzzzzzzzzzzh_ = this.Patient(context);
        Date vzzzzzzzzzzzi_ = vzzzzzzzzzzzh_?.BirthDateElement;
        string vzzzzzzzzzzzj_ = vzzzzzzzzzzzi_?.Value;
        CqlDate vzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzm_ = context.Operators.End(vzzzzzzzzzzzl_);
        CqlDate vzzzzzzzzzzzn_ = context.Operators.DateFrom(vzzzzzzzzzzzm_);
        int? vzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzk_, vzzzzzzzzzzzn_, "year");
        bool? vzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzo_, 66);
        bool? vzzzzzzzzzzzq_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? vzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzp_, vzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzs_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? vzzzzzzzzzzzt_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? vzzzzzzzzzzzu_ = context.Operators.Or(vzzzzzzzzzzzs_, vzzzzzzzzzzzt_);
        bool? vzzzzzzzzzzzv_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? vzzzzzzzzzzzw_ = context.Operators.Or(vzzzzzzzzzzzu_, vzzzzzzzzzzzv_);
        bool? vzzzzzzzzzzzx_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? vzzzzzzzzzzzy_ = context.Operators.Or(vzzzzzzzzzzzw_, vzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzr_, vzzzzzzzzzzzy_);

        return vzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
