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
        object qzzzzzzzzzzzzs_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzv_ = this.Frailty_Device(context);
        IEnumerable<Observation> qzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzzzzzzzzzx_(Observation FrailtyDeviceApplied)
        {
            DataType rzzzzzzzzzzzzu_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzx_ = context.Operators.Overlaps(rzzzzzzzzzzzzv_, rzzzzzzzzzzzzw_, default);

            return rzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzw_, qzzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzy_);
        CqlValueSet rzzzzzzzzzzzza_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> rzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzc_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, rzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzd_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzza_ = context.Operators.Overlaps(rzzzzzzzzzzzzy_, rzzzzzzzzzzzzz_, default);

            return szzzzzzzzzzzza_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzze_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzc_, rzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzg_ = context.Operators.Or(qzzzzzzzzzzzzz_, rzzzzzzzzzzzzf_);
        CqlValueSet rzzzzzzzzzzzzh_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, rzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzk_(Encounter FrailtyEncounter)
        {
            Period szzzzzzzzzzzzb_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzzzzb_ as object);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzze_ = context.Operators.Overlaps(szzzzzzzzzzzzc_, szzzzzzzzzzzzd_, default);

            return szzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzj_, rzzzzzzzzzzzzk_);
        bool? rzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzzn_ = context.Operators.Or(rzzzzzzzzzzzzg_, rzzzzzzzzzzzzm_);
        CqlValueSet rzzzzzzzzzzzzo_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> rzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzzzq_(Observation FrailtySymptom)
        {
            DataType szzzzzzzzzzzzf_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzi_ = context.Operators.Overlaps(szzzzzzzzzzzzg_, szzzzzzzzzzzzh_, default);

            return szzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzp_, rzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzr_);
        bool? rzzzzzzzzzzzzt_ = context.Operators.Or(rzzzzzzzzzzzzn_, rzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzj_ = this.Outpatient(context);
        IEnumerable<Encounter> szzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet szzzzzzzzzzzzl_ = this.Observation(context);
        IEnumerable<Encounter> szzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzk_, szzzzzzzzzzzzm_);
        CqlValueSet szzzzzzzzzzzzo_ = this.ED(context);
        IEnumerable<Encounter> szzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet szzzzzzzzzzzzq_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> szzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzp_, szzzzzzzzzzzzr_);
        IEnumerable<Encounter> szzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzn_, szzzzzzzzzzzzs_);
        CqlValueSet szzzzzzzzzzzzu_ = this.Online_Assessments(context);
        IEnumerable<Encounter> szzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet szzzzzzzzzzzzw_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> szzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzv_, szzzzzzzzzzzzx_);
        IEnumerable<Encounter> szzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzt_, szzzzzzzzzzzzy_);
        IEnumerable<Encounter> tzzzzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, szzzzzzzzzzzzz_);
        bool? tzzzzzzzzzzzzb_(Encounter OutpatientEncounter)
        {
            CqlValueSet tzzzzzzzzzzzzg_ = this.Advanced_Illness(context);
            IEnumerable<Condition> tzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? tzzzzzzzzzzzzi_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, tzzzzzzzzzzzzh_);
            Period tzzzzzzzzzzzzj_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzj_ as object);
            CqlDateTime tzzzzzzzzzzzzl_ = context.Operators.Start(tzzzzzzzzzzzzk_);
            CqlDate tzzzzzzzzzzzzm_ = context.Operators.DateFrom(tzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzo_ = context.Operators.Start(tzzzzzzzzzzzzn_);
            CqlDate tzzzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzzzo_);
            CqlQuantity tzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "year");
            CqlDate tzzzzzzzzzzzzr_ = context.Operators.Subtract(tzzzzzzzzzzzzp_, tzzzzzzzzzzzzq_);
            CqlDateTime tzzzzzzzzzzzzt_ = context.Operators.End(tzzzzzzzzzzzzn_);
            CqlDate tzzzzzzzzzzzzu_ = context.Operators.DateFrom(tzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzv_ = context.Operators.Interval(tzzzzzzzzzzzzr_, tzzzzzzzzzzzzu_, true, true);
            bool? tzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzm_, tzzzzzzzzzzzzv_, default);
            bool? tzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzi_, tzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzza_, tzzzzzzzzzzzzb_);
        CqlDate tzzzzzzzzzzzzd_(Encounter EncounterWithDiagnosis)
        {
            Period tzzzzzzzzzzzzy_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzy_ as object);
            CqlDateTime uzzzzzzzzzzzza_ = context.Operators.End(tzzzzzzzzzzzzz_);
            CqlDate uzzzzzzzzzzzzb_ = context.Operators.DateFrom(uzzzzzzzzzzzza_);

            return uzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzze_ = context.Operators.Select<Encounter, CqlDate>(tzzzzzzzzzzzzc_, tzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> uzzzzzzzzzzzzc_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? uzzzzzzzzzzzzd_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, uzzzzzzzzzzzzc_);
        IEnumerable<Claim> uzzzzzzzzzzzze_ = uzzzzzzzzzzzzd_?.NonacuteInpatientDischarge;
        CqlValueSet uzzzzzzzzzzzzf_ = this.Advanced_Illness(context);
        IValueSetFacade uzzzzzzzzzzzzg_ = context.Operators.CreateValueSetFacade(uzzzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzzzh_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, uzzzzzzzzzzzze_, uzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzi_ = uzzzzzzzzzzzzh_?.ServicePeriod;
        bool? uzzzzzzzzzzzzj_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
        {
            CqlDateTime uzzzzzzzzzzzzo_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate uzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzq_);
            CqlDate uzzzzzzzzzzzzs_ = context.Operators.DateFrom(uzzzzzzzzzzzzr_);
            CqlQuantity uzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "year");
            CqlDate uzzzzzzzzzzzzu_ = context.Operators.Subtract(uzzzzzzzzzzzzs_, uzzzzzzzzzzzzt_);
            CqlDateTime uzzzzzzzzzzzzw_ = context.Operators.End(uzzzzzzzzzzzzq_);
            CqlDate uzzzzzzzzzzzzx_ = context.Operators.DateFrom(uzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzy_ = context.Operators.Interval(uzzzzzzzzzzzzu_, uzzzzzzzzzzzzx_, true, true);
            bool? uzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzy_, default);

            return uzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzk_ = context.Operators.Where<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzi_, uzzzzzzzzzzzzj_);
        CqlDate uzzzzzzzzzzzzl_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime vzzzzzzzzzzzza_ = context.Operators.End(InpatientDischarge);
            CqlDate vzzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzzza_);

            return vzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(uzzzzzzzzzzzzk_, uzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzm_);

        return uzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<CqlDate> vzzzzzzzzzzzzc_()
        {
            bool vzzzzzzzzzzzzd_()
            {
                IEnumerable<CqlDate> vzzzzzzzzzzzze_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> vzzzzzzzzzzzzf_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> vzzzzzzzzzzzzg_ = context.Operators.Union<CqlDate>(vzzzzzzzzzzzze_, vzzzzzzzzzzzzf_);
                bool? vzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzg_ is null));

                return vzzzzzzzzzzzzh_ ?? false;
            };
            if (vzzzzzzzzzzzzd_())
            {
                IEnumerable<CqlDate> vzzzzzzzzzzzzi_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> vzzzzzzzzzzzzj_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> vzzzzzzzzzzzzk_ = context.Operators.Union<CqlDate>(vzzzzzzzzzzzzi_, vzzzzzzzzzzzzj_);

                return vzzzzzzzzzzzzk_;
            }
            else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> vzzzzzzzzzzzzl_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

                return vzzzzzzzzzzzzl_;
            }
            else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> vzzzzzzzzzzzzm_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

                return vzzzzzzzzzzzzm_;
            }
            else
            {
                return null as IEnumerable<CqlDate>;
            }
        };

        return vzzzzzzzzzzzzc_();
    }


    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<CqlDate> vzzzzzzzzzzzzn_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> vzzzzzzzzzzzzp_ = context.Operators.CrossJoin<CqlDate, CqlDate>(vzzzzzzzzzzzzn_, vzzzzzzzzzzzzn_);
        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? vzzzzzzzzzzzzq_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? vzzzzzzzzzzzzy_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

            return vzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> vzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(vzzzzzzzzzzzzp_, vzzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
        {
            CqlQuantity vzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "day");
            CqlDate wzzzzzzzzzzzza_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, vzzzzzzzzzzzzz_);
            bool? wzzzzzzzzzzzzb_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, wzzzzzzzzzzzza_, default);

            return wzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> vzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(vzzzzzzzzzzzzr_, vzzzzzzzzzzzzs_);
        CqlDate vzzzzzzzzzzzzu_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) =>
            tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> vzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzv_);
        bool? vzzzzzzzzzzzzx_ = context.Operators.Exists<CqlDate>(vzzzzzzzzzzzzw_);

        return vzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzc_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzze_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, wzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            CqlValueSet wzzzzzzzzzzzzi_ = this.Advanced_Illness(context);
            IEnumerable<Condition> wzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? wzzzzzzzzzzzzk_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, wzzzzzzzzzzzzj_);
            Period wzzzzzzzzzzzzl_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzl_ as object);
            CqlDateTime wzzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzzm_);
            CqlDate wzzzzzzzzzzzzo_ = context.Operators.DateFrom(wzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzq_ = context.Operators.Start(wzzzzzzzzzzzzp_);
            CqlDate wzzzzzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzzzzzq_);
            CqlQuantity wzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
            CqlDate wzzzzzzzzzzzzt_ = context.Operators.Subtract(wzzzzzzzzzzzzr_, wzzzzzzzzzzzzs_);
            CqlDateTime wzzzzzzzzzzzzv_ = context.Operators.End(wzzzzzzzzzzzzp_);
            CqlDate wzzzzzzzzzzzzw_ = context.Operators.DateFrom(wzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzx_ = context.Operators.Interval(wzzzzzzzzzzzzt_, wzzzzzzzzzzzzw_, true, true);
            bool? wzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzo_, wzzzzzzzzzzzzx_, default);
            bool? wzzzzzzzzzzzzz_ = context.Operators.And(wzzzzzzzzzzzzk_, wzzzzzzzzzzzzy_);

            return wzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzze_, wzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzg_);

        return wzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> xzzzzzzzzzzzza_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? xzzzzzzzzzzzzb_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, xzzzzzzzzzzzza_);
        IEnumerable<Claim> xzzzzzzzzzzzzc_ = xzzzzzzzzzzzzb_?.AcuteInpatientDischarge;
        CqlValueSet xzzzzzzzzzzzzd_ = this.Advanced_Illness(context);
        IValueSetFacade xzzzzzzzzzzzze_ = context.Operators.CreateValueSetFacade(xzzzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzzzzzf_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, xzzzzzzzzzzzzc_, xzzzzzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzg_ = xzzzzzzzzzzzzf_?.ServicePeriod;
        bool? xzzzzzzzzzzzzh_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime xzzzzzzzzzzzzk_ = context.Operators.End(InpatientDischarge);
            CqlDate xzzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzn_ = context.Operators.Start(xzzzzzzzzzzzzm_);
            CqlDate xzzzzzzzzzzzzo_ = context.Operators.DateFrom(xzzzzzzzzzzzzn_);
            CqlQuantity xzzzzzzzzzzzzp_ = context.Operators.Quantity(1m, "year");
            CqlDate xzzzzzzzzzzzzq_ = context.Operators.Subtract(xzzzzzzzzzzzzo_, xzzzzzzzzzzzzp_);
            CqlDateTime xzzzzzzzzzzzzs_ = context.Operators.End(xzzzzzzzzzzzzm_);
            CqlDate xzzzzzzzzzzzzt_ = context.Operators.DateFrom(xzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzu_ = context.Operators.Interval(xzzzzzzzzzzzzq_, xzzzzzzzzzzzzt_, true, true);
            bool? xzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzl_, xzzzzzzzzzzzzu_, default);

            return xzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzi_ = context.Operators.Where<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzg_, xzzzzzzzzzzzzh_);
        bool? xzzzzzzzzzzzzj_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzw_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> xzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, xzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> xzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, xzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> yzzzzzzzzzzzza_ = context.Operators.Union<MedicationDispense>(xzzzzzzzzzzzzx_, xzzzzzzzzzzzzz_);
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzb_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, yzzzzzzzzzzzza_);
        bool? yzzzzzzzzzzzzc_(MedicationDispense DementiaMedDispensed)
        {
            FhirDateTime yzzzzzzzzzzzzf_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, yzzzzzzzzzzzzf_ as object);
            CqlDateTime yzzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzzg_);
            CqlDate yzzzzzzzzzzzzi_ = context.Operators.DateFrom(yzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzzzj_);
            CqlDate yzzzzzzzzzzzzl_ = context.Operators.DateFrom(yzzzzzzzzzzzzk_);
            CqlQuantity yzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "year");
            CqlDate yzzzzzzzzzzzzn_ = context.Operators.Subtract(yzzzzzzzzzzzzl_, yzzzzzzzzzzzzm_);
            CqlDateTime yzzzzzzzzzzzzp_ = context.Operators.End(yzzzzzzzzzzzzj_);
            CqlDate yzzzzzzzzzzzzq_ = context.Operators.DateFrom(yzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzr_ = context.Operators.Interval(yzzzzzzzzzzzzn_, yzzzzzzzzzzzzq_, true, true);
            bool? yzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzi_, yzzzzzzzzzzzzr_, default);

            return yzzzzzzzzzzzzs_;
        };
        IEnumerable<MedicationDispense> yzzzzzzzzzzzzd_ = context.Operators.Where<MedicationDispense>(yzzzzzzzzzzzzb_, yzzzzzzzzzzzzc_);
        bool? yzzzzzzzzzzzze_ = context.Operators.Exists<MedicationDispense>(yzzzzzzzzzzzzd_);

        return yzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient yzzzzzzzzzzzzt_ = this.Patient(context);
        Date yzzzzzzzzzzzzu_ = yzzzzzzzzzzzzt_?.BirthDateElement;
        string yzzzzzzzzzzzzv_ = yzzzzzzzzzzzzu_?.Value;
        CqlDate yzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzy_ = context.Operators.End(yzzzzzzzzzzzzx_);
        CqlDate yzzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzzy_);
        int? zzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzzw_, yzzzzzzzzzzzzz_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzb_ = context.Operators.Interval(66, 80, true, true);
        bool? zzzzzzzzzzzzzc_ = context.Operators.In<int?>(zzzzzzzzzzzzza_, zzzzzzzzzzzzzb_, default);
        bool? zzzzzzzzzzzzzd_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? zzzzzzzzzzzzze_ = context.Operators.And(zzzzzzzzzzzzzc_, zzzzzzzzzzzzzd_);
        bool? zzzzzzzzzzzzzf_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? zzzzzzzzzzzzzg_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? zzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzf_, zzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzi_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? zzzzzzzzzzzzzj_ = context.Operators.Or(zzzzzzzzzzzzzh_, zzzzzzzzzzzzzi_);
        bool? zzzzzzzzzzzzzk_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? zzzzzzzzzzzzzl_ = context.Operators.Or(zzzzzzzzzzzzzj_, zzzzzzzzzzzzzk_);
        bool? zzzzzzzzzzzzzm_ = context.Operators.And(zzzzzzzzzzzzze_, zzzzzzzzzzzzzl_);
        Date zzzzzzzzzzzzzo_ = yzzzzzzzzzzzzt_?.BirthDateElement;
        string zzzzzzzzzzzzzp_ = zzzzzzzzzzzzzo_?.Value;
        CqlDate zzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzp_);
        CqlDateTime zzzzzzzzzzzzzs_ = context.Operators.End(yzzzzzzzzzzzzx_);
        CqlDate zzzzzzzzzzzzzt_ = context.Operators.DateFrom(zzzzzzzzzzzzzs_);
        int? zzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzq_, zzzzzzzzzzzzzt_, "year");
        bool? zzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzu_, 81);
        bool? zzzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzzv_, zzzzzzzzzzzzzd_);
        bool? zzzzzzzzzzzzzy_ = context.Operators.Or(zzzzzzzzzzzzzm_, zzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient zzzzzzzzzzzzzz_ = this.Patient(context);
        Date azzzzzzzzzzzzza_ = zzzzzzzzzzzzzz_?.BirthDateElement;
        string azzzzzzzzzzzzzb_ = azzzzzzzzzzzzza_?.Value;
        CqlDate azzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzze_ = context.Operators.End(azzzzzzzzzzzzzd_);
        CqlDate azzzzzzzzzzzzzf_ = context.Operators.DateFrom(azzzzzzzzzzzzze_);
        int? azzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzc_, azzzzzzzzzzzzzf_, "year");
        bool? azzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzg_, 66);
        bool? azzzzzzzzzzzzzi_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? azzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzh_, azzzzzzzzzzzzzi_);
        bool? azzzzzzzzzzzzzk_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? azzzzzzzzzzzzzl_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? azzzzzzzzzzzzzm_ = context.Operators.Or(azzzzzzzzzzzzzk_, azzzzzzzzzzzzzl_);
        bool? azzzzzzzzzzzzzn_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? azzzzzzzzzzzzzo_ = context.Operators.Or(azzzzzzzzzzzzzm_, azzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzp_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? azzzzzzzzzzzzzq_ = context.Operators.Or(azzzzzzzzzzzzzo_, azzzzzzzzzzzzzp_);
        bool? azzzzzzzzzzzzzr_ = context.Operators.And(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzr_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
