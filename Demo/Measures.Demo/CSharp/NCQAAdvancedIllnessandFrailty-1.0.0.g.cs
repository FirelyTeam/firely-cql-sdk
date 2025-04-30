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
        object bzzzzzzzzzzj_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzk_);

        return bzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzm_ = this.Frailty_Device(context);
        IEnumerable<Observation> bzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzo_(Observation FrailtyDeviceApplied)
        {
            DataType czzzzzzzzzzl_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> czzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzzl_);
            CqlInterval<CqlDateTime> czzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzo_ = context.Operators.Overlaps(czzzzzzzzzzm_, czzzzzzzzzzn_, default);

            return czzzzzzzzzzo_;
        };
        IEnumerable<Observation> bzzzzzzzzzzp_ = context.Operators.Where<Observation>(bzzzzzzzzzzn_, bzzzzzzzzzzo_);
        bool? bzzzzzzzzzzq_ = context.Operators.Exists<Observation>(bzzzzzzzzzzp_);
        CqlValueSet bzzzzzzzzzzr_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> bzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> bzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, bzzzzzzzzzzs_);
        bool? bzzzzzzzzzzu_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> czzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzr_ = context.Operators.Overlaps(czzzzzzzzzzp_, czzzzzzzzzzq_, default);

            return czzzzzzzzzzr_;
        };
        IEnumerable<Condition> bzzzzzzzzzzv_ = context.Operators.Where<Condition>(bzzzzzzzzzzt_, bzzzzzzzzzzu_);
        bool? bzzzzzzzzzzw_ = context.Operators.Exists<Condition>(bzzzzzzzzzzv_);
        bool? bzzzzzzzzzzx_ = context.Operators.Or(bzzzzzzzzzzq_, bzzzzzzzzzzw_);
        CqlValueSet bzzzzzzzzzzy_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> czzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, bzzzzzzzzzzz_);
        bool? czzzzzzzzzzb_(Encounter FrailtyEncounter)
        {
            Period czzzzzzzzzzs_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzzs_ as object);
            CqlInterval<CqlDateTime> czzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzv_ = context.Operators.Overlaps(czzzzzzzzzzt_, czzzzzzzzzzu_, default);

            return czzzzzzzzzzv_;
        };
        IEnumerable<Encounter> czzzzzzzzzzc_ = context.Operators.Where<Encounter>(czzzzzzzzzza_, czzzzzzzzzzb_);
        bool? czzzzzzzzzzd_ = context.Operators.Exists<Encounter>(czzzzzzzzzzc_);
        bool? czzzzzzzzzze_ = context.Operators.Or(bzzzzzzzzzzx_, czzzzzzzzzzd_);
        CqlValueSet czzzzzzzzzzf_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> czzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzzzzzzzzh_(Observation FrailtySymptom)
        {
            DataType czzzzzzzzzzw_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> czzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzz_ = context.Operators.Overlaps(czzzzzzzzzzx_, czzzzzzzzzzy_, default);

            return czzzzzzzzzzz_;
        };
        IEnumerable<Observation> czzzzzzzzzzi_ = context.Operators.Where<Observation>(czzzzzzzzzzg_, czzzzzzzzzzh_);
        bool? czzzzzzzzzzj_ = context.Operators.Exists<Observation>(czzzzzzzzzzi_);
        bool? czzzzzzzzzzk_ = context.Operators.Or(czzzzzzzzzze_, czzzzzzzzzzj_);

        return czzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzza_ = this.Outpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzc_ = this.Observation(context);
        IEnumerable<Encounter> dzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> dzzzzzzzzzze_ = context.Operators.Union<Encounter>(dzzzzzzzzzzb_, dzzzzzzzzzzd_);
        CqlValueSet dzzzzzzzzzzf_ = this.ED(context);
        IEnumerable<Encounter> dzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzj_ = context.Operators.Union<Encounter>(dzzzzzzzzzzg_, dzzzzzzzzzzi_);
        IEnumerable<Encounter> dzzzzzzzzzzk_ = context.Operators.Union<Encounter>(dzzzzzzzzzze_, dzzzzzzzzzzj_);
        CqlValueSet dzzzzzzzzzzl_ = this.Online_Assessments(context);
        IEnumerable<Encounter> dzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet dzzzzzzzzzzn_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzp_ = context.Operators.Union<Encounter>(dzzzzzzzzzzm_, dzzzzzzzzzzo_);
        IEnumerable<Encounter> dzzzzzzzzzzq_ = context.Operators.Union<Encounter>(dzzzzzzzzzzk_, dzzzzzzzzzzp_);
        IEnumerable<Encounter> dzzzzzzzzzzr_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, dzzzzzzzzzzq_);
        bool? dzzzzzzzzzzs_(Encounter OutpatientEncounter)
        {
            CqlValueSet dzzzzzzzzzzx_ = this.Advanced_Illness(context);
            IEnumerable<Condition> dzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? dzzzzzzzzzzz_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, dzzzzzzzzzzy_);
            Period ezzzzzzzzzza_ = OutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzza_ as object);
            CqlDateTime ezzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzb_);
            CqlDate ezzzzzzzzzzd_ = context.Operators.DateFrom(ezzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzze_);
            CqlDate ezzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzf_);
            CqlQuantity ezzzzzzzzzzh_ = context.Operators.Quantity(1m, "year");
            CqlDate ezzzzzzzzzzi_ = context.Operators.Subtract(ezzzzzzzzzzg_, ezzzzzzzzzzh_);
            CqlDateTime ezzzzzzzzzzk_ = context.Operators.End(ezzzzzzzzzze_);
            CqlDate ezzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzk_);
            CqlInterval<CqlDate> ezzzzzzzzzzm_ = context.Operators.Interval(ezzzzzzzzzzi_, ezzzzzzzzzzl_, true, true);
            bool? ezzzzzzzzzzn_ = context.Operators.In<CqlDate>(ezzzzzzzzzzd_, ezzzzzzzzzzm_, default);
            bool? ezzzzzzzzzzo_ = context.Operators.And(dzzzzzzzzzzz_, ezzzzzzzzzzn_);

            return ezzzzzzzzzzo_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzt_ = context.Operators.Where<Encounter>(dzzzzzzzzzzr_, dzzzzzzzzzzs_);
        CqlDate dzzzzzzzzzzu_(Encounter EncounterWithDiagnosis)
        {
            Period ezzzzzzzzzzp_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzzp_ as object);
            CqlDateTime ezzzzzzzzzzr_ = context.Operators.End(ezzzzzzzzzzq_);
            CqlDate ezzzzzzzzzzs_ = context.Operators.DateFrom(ezzzzzzzzzzr_);

            return ezzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzv_ = context.Operators.Select<Encounter, CqlDate>(dzzzzzzzzzzt_, dzzzzzzzzzzu_);
        IEnumerable<CqlDate> dzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzv_);

        return dzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> ezzzzzzzzzzt_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? ezzzzzzzzzzu_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, ezzzzzzzzzzt_);
        IEnumerable<Claim> ezzzzzzzzzzv_ = ezzzzzzzzzzu_?.NonacuteInpatientDischarge;
        CqlValueSet ezzzzzzzzzzw_ = this.Advanced_Illness(context);
        IValueSetFacade ezzzzzzzzzzx_ = context.Operators.CreateValueSetFacade(ezzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzzy_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, ezzzzzzzzzzv_, ezzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzz_ = ezzzzzzzzzzy_?.ServicePeriod;
        bool? fzzzzzzzzzza_(CqlInterval<CqlDateTime> DischargeWithDiagnosis)
        {
            CqlDateTime fzzzzzzzzzzf_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate fzzzzzzzzzzg_ = context.Operators.DateFrom(fzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzi_ = context.Operators.Start(fzzzzzzzzzzh_);
            CqlDate fzzzzzzzzzzj_ = context.Operators.DateFrom(fzzzzzzzzzzi_);
            CqlQuantity fzzzzzzzzzzk_ = context.Operators.Quantity(1m, "year");
            CqlDate fzzzzzzzzzzl_ = context.Operators.Subtract(fzzzzzzzzzzj_, fzzzzzzzzzzk_);
            CqlDateTime fzzzzzzzzzzn_ = context.Operators.End(fzzzzzzzzzzh_);
            CqlDate fzzzzzzzzzzo_ = context.Operators.DateFrom(fzzzzzzzzzzn_);
            CqlInterval<CqlDate> fzzzzzzzzzzp_ = context.Operators.Interval(fzzzzzzzzzzl_, fzzzzzzzzzzo_, true, true);
            bool? fzzzzzzzzzzq_ = context.Operators.In<CqlDate>(fzzzzzzzzzzg_, fzzzzzzzzzzp_, default);

            return fzzzzzzzzzzq_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzb_ = context.Operators.Where<CqlInterval<CqlDateTime>>(ezzzzzzzzzzz_, fzzzzzzzzzza_);
        CqlDate fzzzzzzzzzzc_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime fzzzzzzzzzzr_ = context.Operators.End(InpatientDischarge);
            CqlDate fzzzzzzzzzzs_ = context.Operators.DateFrom(fzzzzzzzzzzr_);

            return fzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(fzzzzzzzzzzb_, fzzzzzzzzzzc_);
        IEnumerable<CqlDate> fzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzd_);

        return fzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzzzt_()
        {
            bool fzzzzzzzzzzu_()
            {
                IEnumerable<CqlDate> fzzzzzzzzzzv_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzzzw_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> fzzzzzzzzzzx_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzv_, fzzzzzzzzzzw_);
                bool? fzzzzzzzzzzy_ = context.Operators.Not((bool?)(fzzzzzzzzzzx_ is null));

                return fzzzzzzzzzzy_ ?? false;
            };
            if (fzzzzzzzzzzu_())
            {
                IEnumerable<CqlDate> fzzzzzzzzzzz_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<CqlDate> gzzzzzzzzzza_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                IEnumerable<CqlDate> gzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzz_, gzzzzzzzzzza_);

                return gzzzzzzzzzzb_;
            }
            else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> gzzzzzzzzzzc_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);

                return gzzzzzzzzzzc_;
            }
            else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
            {
                IEnumerable<CqlDate> gzzzzzzzzzzd_ = this.Outpatient_Encounters_with_Advanced_Illness(context);

                return gzzzzzzzzzzd_;
            }
            else
            {
                return null as IEnumerable<CqlDate>;
            }
        };

        return fzzzzzzzzzzt_();
    }


    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<CqlDate> gzzzzzzzzzze_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> gzzzzzzzzzzg_ = context.Operators.CrossJoin<CqlDate, CqlDate>(gzzzzzzzzzze_, gzzzzzzzzzze_);
        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? gzzzzzzzzzzh_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? gzzzzzzzzzzp_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);

            return gzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> gzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(gzzzzzzzzzzg_, gzzzzzzzzzzh_);
        bool? gzzzzzzzzzzj_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv)
        {
            CqlQuantity gzzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
            CqlDate gzzzzzzzzzzr_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, gzzzzzzzzzzq_);
            bool? gzzzzzzzzzzs_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, gzzzzzzzzzzr_, default);

            return gzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> gzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(gzzzzzzzzzzi_, gzzzzzzzzzzj_);
        CqlDate gzzzzzzzzzzl_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) =>
            tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> gzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(gzzzzzzzzzzk_, gzzzzzzzzzzl_);
        IEnumerable<CqlDate> gzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzm_);
        bool? gzzzzzzzzzzo_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzn_);

        return gzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzt_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> gzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzv_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, gzzzzzzzzzzu_);
        bool? gzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            CqlValueSet gzzzzzzzzzzz_ = this.Advanced_Illness(context);
            IEnumerable<Condition> hzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? hzzzzzzzzzzb_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, hzzzzzzzzzza_);
            Period hzzzzzzzzzzc_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, hzzzzzzzzzzc_ as object);
            CqlDateTime hzzzzzzzzzze_ = context.Operators.Start(hzzzzzzzzzzd_);
            CqlDate hzzzzzzzzzzf_ = context.Operators.DateFrom(hzzzzzzzzzze_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzg_);
            CqlDate hzzzzzzzzzzi_ = context.Operators.DateFrom(hzzzzzzzzzzh_);
            CqlQuantity hzzzzzzzzzzj_ = context.Operators.Quantity(1m, "year");
            CqlDate hzzzzzzzzzzk_ = context.Operators.Subtract(hzzzzzzzzzzi_, hzzzzzzzzzzj_);
            CqlDateTime hzzzzzzzzzzm_ = context.Operators.End(hzzzzzzzzzzg_);
            CqlDate hzzzzzzzzzzn_ = context.Operators.DateFrom(hzzzzzzzzzzm_);
            CqlInterval<CqlDate> hzzzzzzzzzzo_ = context.Operators.Interval(hzzzzzzzzzzk_, hzzzzzzzzzzn_, true, true);
            bool? hzzzzzzzzzzp_ = context.Operators.In<CqlDate>(hzzzzzzzzzzf_, hzzzzzzzzzzo_, default);
            bool? hzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzb_, hzzzzzzzzzzp_);

            return hzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzx_ = context.Operators.Where<Encounter>(gzzzzzzzzzzv_, gzzzzzzzzzzw_);
        bool? gzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzx_);

        return gzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context)
    {
        IEnumerable<Claim> hzzzzzzzzzzr_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? hzzzzzzzzzzs_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, hzzzzzzzzzzr_);
        IEnumerable<Claim> hzzzzzzzzzzt_ = hzzzzzzzzzzs_?.AcuteInpatientDischarge;
        CqlValueSet hzzzzzzzzzzu_ = this.Advanced_Illness(context);
        IValueSetFacade hzzzzzzzzzzv_ = context.Operators.CreateValueSetFacade(hzzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzzw_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, hzzzzzzzzzzt_, hzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzx_ = hzzzzzzzzzzw_?.ServicePeriod;
        bool? hzzzzzzzzzzy_(CqlInterval<CqlDateTime> InpatientDischarge)
        {
            CqlDateTime izzzzzzzzzzb_ = context.Operators.End(InpatientDischarge);
            CqlDate izzzzzzzzzzc_ = context.Operators.DateFrom(izzzzzzzzzzb_);
            CqlInterval<CqlDateTime> izzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzze_ = context.Operators.Start(izzzzzzzzzzd_);
            CqlDate izzzzzzzzzzf_ = context.Operators.DateFrom(izzzzzzzzzze_);
            CqlQuantity izzzzzzzzzzg_ = context.Operators.Quantity(1m, "year");
            CqlDate izzzzzzzzzzh_ = context.Operators.Subtract(izzzzzzzzzzf_, izzzzzzzzzzg_);
            CqlDateTime izzzzzzzzzzj_ = context.Operators.End(izzzzzzzzzzd_);
            CqlDate izzzzzzzzzzk_ = context.Operators.DateFrom(izzzzzzzzzzj_);
            CqlInterval<CqlDate> izzzzzzzzzzl_ = context.Operators.Interval(izzzzzzzzzzh_, izzzzzzzzzzk_, true, true);
            bool? izzzzzzzzzzm_ = context.Operators.In<CqlDate>(izzzzzzzzzzc_, izzzzzzzzzzl_, default);

            return izzzzzzzzzzm_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzz_ = context.Operators.Where<CqlInterval<CqlDateTime>>(hzzzzzzzzzzx_, hzzzzzzzzzzy_);
        bool? izzzzzzzzzza_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(hzzzzzzzzzzz_);

        return izzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzn_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> izzzzzzzzzzo_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, izzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> izzzzzzzzzzq_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, izzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> izzzzzzzzzzr_ = context.Operators.Union<MedicationDispense>(izzzzzzzzzzo_, izzzzzzzzzzq_);
        IEnumerable<MedicationDispense> izzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, izzzzzzzzzzr_);
        bool? izzzzzzzzzzt_(MedicationDispense DementiaMedDispensed)
        {
            FhirDateTime izzzzzzzzzzw_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> izzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzw_ as object);
            CqlDateTime izzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzx_);
            CqlDate izzzzzzzzzzz_ = context.Operators.DateFrom(izzzzzzzzzzy_);
            CqlInterval<CqlDateTime> jzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzb_ = context.Operators.Start(jzzzzzzzzzza_);
            CqlDate jzzzzzzzzzzc_ = context.Operators.DateFrom(jzzzzzzzzzzb_);
            CqlQuantity jzzzzzzzzzzd_ = context.Operators.Quantity(1m, "year");
            CqlDate jzzzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzzzc_, jzzzzzzzzzzd_);
            CqlDateTime jzzzzzzzzzzg_ = context.Operators.End(jzzzzzzzzzza_);
            CqlDate jzzzzzzzzzzh_ = context.Operators.DateFrom(jzzzzzzzzzzg_);
            CqlInterval<CqlDate> jzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzze_, jzzzzzzzzzzh_, true, true);
            bool? jzzzzzzzzzzj_ = context.Operators.In<CqlDate>(izzzzzzzzzzz_, jzzzzzzzzzzi_, default);

            return jzzzzzzzzzzj_;
        };
        IEnumerable<MedicationDispense> izzzzzzzzzzu_ = context.Operators.Where<MedicationDispense>(izzzzzzzzzzs_, izzzzzzzzzzt_);
        bool? izzzzzzzzzzv_ = context.Operators.Exists<MedicationDispense>(izzzzzzzzzzu_);

        return izzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient jzzzzzzzzzzk_ = this.Patient(context);
        Date jzzzzzzzzzzl_ = jzzzzzzzzzzk_?.BirthDateElement;
        string jzzzzzzzzzzm_ = jzzzzzzzzzzl_?.Value;
        CqlDate jzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzp_ = context.Operators.End(jzzzzzzzzzzo_);
        CqlDate jzzzzzzzzzzq_ = context.Operators.DateFrom(jzzzzzzzzzzp_);
        int? jzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzn_, jzzzzzzzzzzq_, "year");
        CqlInterval<int?> jzzzzzzzzzzs_ = context.Operators.Interval(66, 80, true, true);
        bool? jzzzzzzzzzzt_ = context.Operators.In<int?>(jzzzzzzzzzzr_, jzzzzzzzzzzs_, default);
        bool? jzzzzzzzzzzu_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? jzzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzzt_, jzzzzzzzzzzu_);
        bool? jzzzzzzzzzzw_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? jzzzzzzzzzzx_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? jzzzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzzzw_, jzzzzzzzzzzx_);
        bool? jzzzzzzzzzzz_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? kzzzzzzzzzza_ = context.Operators.Or(jzzzzzzzzzzy_, jzzzzzzzzzzz_);
        bool? kzzzzzzzzzzb_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? kzzzzzzzzzzc_ = context.Operators.Or(kzzzzzzzzzza_, kzzzzzzzzzzb_);
        bool? kzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzv_, kzzzzzzzzzzc_);
        Date kzzzzzzzzzzf_ = jzzzzzzzzzzk_?.BirthDateElement;
        string kzzzzzzzzzzg_ = kzzzzzzzzzzf_?.Value;
        CqlDate kzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzg_);
        CqlDateTime kzzzzzzzzzzj_ = context.Operators.End(jzzzzzzzzzzo_);
        CqlDate kzzzzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzzzzj_);
        int? kzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzh_, kzzzzzzzzzzk_, "year");
        bool? kzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzl_, 81);
        bool? kzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzm_, jzzzzzzzzzzu_);
        bool? kzzzzzzzzzzp_ = context.Operators.Or(kzzzzzzzzzzd_, kzzzzzzzzzzo_);

        return kzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient kzzzzzzzzzzq_ = this.Patient(context);
        Date kzzzzzzzzzzr_ = kzzzzzzzzzzq_?.BirthDateElement;
        string kzzzzzzzzzzs_ = kzzzzzzzzzzr_?.Value;
        CqlDate kzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzv_ = context.Operators.End(kzzzzzzzzzzu_);
        CqlDate kzzzzzzzzzzw_ = context.Operators.DateFrom(kzzzzzzzzzzv_);
        int? kzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzt_, kzzzzzzzzzzw_, "year");
        bool? kzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(kzzzzzzzzzzx_, 66);
        bool? kzzzzzzzzzzz_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? lzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzy_, kzzzzzzzzzzz_);
        bool? lzzzzzzzzzzb_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? lzzzzzzzzzzc_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
        bool? lzzzzzzzzzzd_ = context.Operators.Or(lzzzzzzzzzzb_, lzzzzzzzzzzc_);
        bool? lzzzzzzzzzze_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
        bool? lzzzzzzzzzzf_ = context.Operators.Or(lzzzzzzzzzzd_, lzzzzzzzzzze_);
        bool? lzzzzzzzzzzg_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? lzzzzzzzzzzh_ = context.Operators.Or(lzzzzzzzzzzf_, lzzzzzzzzzzg_);
        bool? lzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzza_, lzzzzzzzzzzh_);

        return lzzzzzzzzzzi_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
        [typeof(CqlDate), typeof(CqlDate)],
        ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
