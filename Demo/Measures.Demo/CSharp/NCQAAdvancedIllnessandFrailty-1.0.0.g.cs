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
        object pzzzzzzzzzzzzza_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient pzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzb_);

        return pzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzd_ = this.Frailty_Device(context);
        IEnumerable<Observation> pzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzf_(Observation FrailtyDeviceApplied)
        {
            DataType qzzzzzzzzzzzzzc_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzf_ = context.Operators.Overlaps(qzzzzzzzzzzzzzd_, qzzzzzzzzzzzzze_, default);

            return qzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzze_, pzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzg_);
        CqlValueSet pzzzzzzzzzzzzzi_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzk_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, pzzzzzzzzzzzzzj_);
        bool? pzzzzzzzzzzzzzl_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzi_ = context.Operators.Overlaps(qzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzh_, default);

            return qzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzl_);
        bool? pzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzo_ = context.Operators.Or(pzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzn_);
        CqlValueSet pzzzzzzzzzzzzzp_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzr_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, pzzzzzzzzzzzzzq_);
        bool? pzzzzzzzzzzzzzs_(Encounter FrailtyEncounter)
        {
            Period qzzzzzzzzzzzzzj_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzj_ as object);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzm_ = context.Operators.Overlaps(qzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzl_, default);

            return qzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzs_);
        bool? pzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzt_);
        bool? pzzzzzzzzzzzzzv_ = context.Operators.Or(pzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzu_);
        CqlValueSet pzzzzzzzzzzzzzw_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzy_(Observation FrailtySymptom)
        {
            DataType qzzzzzzzzzzzzzn_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzq_ = context.Operators.Overlaps(qzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzp_, default);

            return qzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzzzzv_, qzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzr_ = this.Outpatient(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzzzzzzzzzzt_ = this.Observation(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzu_);
        CqlValueSet qzzzzzzzzzzzzzw_ = this.ED(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzv_, rzzzzzzzzzzzzza_);
        CqlValueSet rzzzzzzzzzzzzzc_ = this.Online_Assessments(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzzzzzzze_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzi_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, rzzzzzzzzzzzzzh_);
        bool? rzzzzzzzzzzzzzj_(Encounter OutpatientEncounter)
        {
            CqlValueSet rzzzzzzzzzzzzzo_ = this.Advanced_Illness(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? rzzzzzzzzzzzzzq_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, rzzzzzzzzzzzzzp_);
            Period rzzzzzzzzzzzzzr_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzzzzzzr_ as object);
            CqlDateTime rzzzzzzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzzzzzzs_);
            CqlDate rzzzzzzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzv_);
            CqlDate rzzzzzzzzzzzzzx_ = context.Operators.DateFrom(rzzzzzzzzzzzzzw_);
            CqlQuantity rzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
            CqlDate rzzzzzzzzzzzzzz_ = context.Operators.Subtract(rzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzy_);
            CqlDateTime szzzzzzzzzzzzzb_ = context.Operators.End(rzzzzzzzzzzzzzv_);
            CqlDate szzzzzzzzzzzzzc_ = context.Operators.DateFrom(szzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzd_ = context.Operators.Interval(rzzzzzzzzzzzzzz_, szzzzzzzzzzzzzc_, true, true);
            bool? szzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzu_, szzzzzzzzzzzzzd_, default);
            bool? szzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzq_, szzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzj_);
        CqlDate rzzzzzzzzzzzzzl_(Encounter EncounterWithDiagnosis)
        {
            Period szzzzzzzzzzzzzg_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzzzzzg_ as object);
            CqlDateTime szzzzzzzzzzzzzi_ = context.Operators.End(szzzzzzzzzzzzzh_);
            CqlDate szzzzzzzzzzzzzj_ = context.Operators.DateFrom(szzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, CqlDate>(rzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzm_);

        return rzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> szzzzzzzzzzzzzk_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? szzzzzzzzzzzzzl_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, szzzzzzzzzzzzzk_);
        IEnumerable<Claim> szzzzzzzzzzzzzm_ = szzzzzzzzzzzzzl_?.NonacuteInpatientDischarge;
        CqlValueSet szzzzzzzzzzzzzn_ = this.Advanced_Illness(context);
        IValueSetFacade szzzzzzzzzzzzzo_ = context.Operators.CreateValueSetFacade(szzzzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzzzp_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, szzzzzzzzzzzzzm_, szzzzzzzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzq_ = szzzzzzzzzzzzzp_?.ServicePeriod;
        bool? szzzzzzzzzzzzzr_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
        {
            CqlDateTime szzzzzzzzzzzzzw_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate szzzzzzzzzzzzzx_ = context.Operators.DateFrom(szzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzzzy_);
            CqlDate tzzzzzzzzzzzzza_ = context.Operators.DateFrom(szzzzzzzzzzzzzz_);
            CqlQuantity tzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "year");
            CqlDate tzzzzzzzzzzzzzc_ = context.Operators.Subtract(tzzzzzzzzzzzzza_, tzzzzzzzzzzzzzb_);
            CqlDateTime tzzzzzzzzzzzzze_ = context.Operators.End(szzzzzzzzzzzzzy_);
            CqlDate tzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzg_ = context.Operators.Interval(tzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzf_, true, true);
            bool? tzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzx_, tzzzzzzzzzzzzzg_, default);

            return tzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzs_ = context.Operators.Where<CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzq_, szzzzzzzzzzzzzr_);
        CqlDate szzzzzzzzzzzzzt_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime tzzzzzzzzzzzzzi_ = context.Operators.End(InpatientDischarge);
            CqlDate tzzzzzzzzzzzzzj_ = context.Operators.DateFrom(tzzzzzzzzzzzzzi_);

            return tzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(szzzzzzzzzzzzzs_, szzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzk_()
        {
            bool tzzzzzzzzzzzzzl_()
            {
                IEnumerable<CqlDate> tzzzzzzzzzzzzzm_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> tzzzzzzzzzzzzzn_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> tzzzzzzzzzzzzzo_ = context.Operators.Union<CqlDate>(tzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzn_);
                bool? tzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzo_ is null));

                return tzzzzzzzzzzzzzp_ ?? false;
            };
            if (tzzzzzzzzzzzzzl_())
            {
                IEnumerable<CqlDate> tzzzzzzzzzzzzzq_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> tzzzzzzzzzzzzzr_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> tzzzzzzzzzzzzzs_ = context.Operators.Union<CqlDate>(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzr_);

                return tzzzzzzzzzzzzzs_;
            }
            else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> tzzzzzzzzzzzzzt_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

                return tzzzzzzzzzzzzzt_;
            }
            else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> tzzzzzzzzzzzzzu_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

                return tzzzzzzzzzzzzzu_;
            }
            else
            {
                return null as IEnumerable<CqlDate>;
            }
        };

        return tzzzzzzzzzzzzzk_();
    }


    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzv_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> tzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate>(tzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tzzzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? uzzzzzzzzzzzzzg_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

            return uzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> tzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(tzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
        {
            CqlQuantity uzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "day");
            CqlDate uzzzzzzzzzzzzzi_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, uzzzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzzzj_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, uzzzzzzzzzzzzzi_, default);

            return uzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> uzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(tzzzzzzzzzzzzzz_, uzzzzzzzzzzzzza_);
        CqlDate uzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) =>
            tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> uzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(uzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlDate>(uzzzzzzzzzzzzze_);

        return uzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzk_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, uzzzzzzzzzzzzzl_);
        bool? uzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzq_ = this.Advanced_Illness(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? uzzzzzzzzzzzzzs_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, uzzzzzzzzzzzzzr_);
            Period uzzzzzzzzzzzzzt_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, uzzzzzzzzzzzzzt_ as object);
            CqlDateTime uzzzzzzzzzzzzzv_ = context.Operators.Start(uzzzzzzzzzzzzzu_);
            CqlDate uzzzzzzzzzzzzzw_ = context.Operators.DateFrom(uzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzzzzx_);
            CqlDate uzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzy_);
            CqlQuantity vzzzzzzzzzzzzza_ = context.Operators.Quantity(1m, "year");
            CqlDate vzzzzzzzzzzzzzb_ = context.Operators.Subtract(uzzzzzzzzzzzzzz_, vzzzzzzzzzzzzza_);
            CqlDateTime vzzzzzzzzzzzzzd_ = context.Operators.End(uzzzzzzzzzzzzzx_);
            CqlDate vzzzzzzzzzzzzze_ = context.Operators.DateFrom(vzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzf_ = context.Operators.Interval(vzzzzzzzzzzzzzb_, vzzzzzzzzzzzzze_, true, true);
            bool? vzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzf_, default);
            bool? vzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzg_);

            return vzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzn_);
        bool? uzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> vzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? vzzzzzzzzzzzzzj_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, vzzzzzzzzzzzzzi_);
        IEnumerable<Claim> vzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzj_?.AcuteInpatientDischarge;
        CqlValueSet vzzzzzzzzzzzzzl_ = this.Advanced_Illness(context);
        IValueSetFacade vzzzzzzzzzzzzzm_ = context.Operators.CreateValueSetFacade(vzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzzzzzzn_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, vzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzn_?.ServicePeriod;
        bool? vzzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime vzzzzzzzzzzzzzs_ = context.Operators.End(InpatientDischarge);
            CqlDate vzzzzzzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzv_ = context.Operators.Start(vzzzzzzzzzzzzzu_);
            CqlDate vzzzzzzzzzzzzzw_ = context.Operators.DateFrom(vzzzzzzzzzzzzzv_);
            CqlQuantity vzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
            CqlDate vzzzzzzzzzzzzzy_ = context.Operators.Subtract(vzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzza_ = context.Operators.End(vzzzzzzzzzzzzzu_);
            CqlDate wzzzzzzzzzzzzzb_ = context.Operators.DateFrom(wzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzc_ = context.Operators.Interval(vzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzb_, true, true);
            bool? wzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzc_, default);

            return wzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzq_ = context.Operators.Where<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzze_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> wzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, wzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> wzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, wzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> wzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationDispense>(wzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzh_);
        IEnumerable<MedicationDispense> wzzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, wzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzk_(MedicationDispense DementiaMedDispensed)
        {
            FhirDateTime wzzzzzzzzzzzzzn_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzn_ as object);
            CqlDateTime wzzzzzzzzzzzzzp_ = context.Operators.Start(wzzzzzzzzzzzzzo_);
            CqlDate wzzzzzzzzzzzzzq_ = context.Operators.DateFrom(wzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzr_);
            CqlDate wzzzzzzzzzzzzzt_ = context.Operators.DateFrom(wzzzzzzzzzzzzzs_);
            CqlQuantity wzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDate wzzzzzzzzzzzzzv_ = context.Operators.Subtract(wzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzu_);
            CqlDateTime wzzzzzzzzzzzzzx_ = context.Operators.End(wzzzzzzzzzzzzzr_);
            CqlDate wzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzz_ = context.Operators.Interval(wzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzy_, true, true);
            bool? xzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzz_, default);

            return xzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationDispense> wzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationDispense>(wzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzm_ = context.Operators.Exists<MedicationDispense>(wzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient xzzzzzzzzzzzzzb_ = this.Patient(context);
        Date xzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzb_?.BirthDateElement;
        string xzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzc_?.Value;
        CqlDate xzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzzzzzg_ = context.Operators.End(xzzzzzzzzzzzzzf_);
        CqlDate xzzzzzzzzzzzzzh_ = context.Operators.DateFrom(xzzzzzzzzzzzzzg_);
        int? xzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzze_, xzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> xzzzzzzzzzzzzzj_ = context.Operators.Interval(66, 80, true, true);
        bool? xzzzzzzzzzzzzzk_ = context.Operators.In<int?>(xzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzj_, default);
        bool? xzzzzzzzzzzzzzl_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? xzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzn_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? xzzzzzzzzzzzzzo_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? xzzzzzzzzzzzzzp_ = context.Operators.Or(xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzo_);
        bool? xzzzzzzzzzzzzzq_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? xzzzzzzzzzzzzzr_ = context.Operators.Or(xzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzs_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? xzzzzzzzzzzzzzt_ = context.Operators.Or(xzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzs_);
        bool? xzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzt_);
        Date xzzzzzzzzzzzzzw_ = xzzzzzzzzzzzzzb_?.BirthDateElement;
        string xzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzw_?.Value;
        CqlDate xzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzx_);
        CqlDateTime yzzzzzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzzzzzf_);
        CqlDate yzzzzzzzzzzzzzb_ = context.Operators.DateFrom(yzzzzzzzzzzzzza_);
        int? yzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzb_, "year");
        bool? yzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzc_, 81);
        bool? yzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzl_);
        bool? yzzzzzzzzzzzzzg_ = context.Operators.Or(xzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzf_);

        return yzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzh_ = this.Patient(context);
        Date yzzzzzzzzzzzzzi_ = yzzzzzzzzzzzzzh_?.BirthDateElement;
        string yzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzi_?.Value;
        CqlDate yzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzm_ = context.Operators.End(yzzzzzzzzzzzzzl_);
        CqlDate yzzzzzzzzzzzzzn_ = context.Operators.DateFrom(yzzzzzzzzzzzzzm_);
        int? yzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzn_, "year");
        bool? yzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzo_, 66);
        bool? yzzzzzzzzzzzzzq_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? yzzzzzzzzzzzzzr_ = context.Operators.And(yzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzq_);
        bool? yzzzzzzzzzzzzzs_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? yzzzzzzzzzzzzzt_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? yzzzzzzzzzzzzzu_ = context.Operators.Or(yzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzv_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? yzzzzzzzzzzzzzw_ = context.Operators.Or(yzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzv_);
        bool? yzzzzzzzzzzzzzx_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? yzzzzzzzzzzzzzy_ = context.Operators.Or(yzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzx_);
        bool? yzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
