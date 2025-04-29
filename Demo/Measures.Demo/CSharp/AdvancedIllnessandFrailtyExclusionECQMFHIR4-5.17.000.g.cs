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
[CqlLibrary("AdvancedIllnessandFrailtyExclusionECQMFHIR4", "5.17.000")]
public partial class AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 : ILibrary, ISingleton<AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000>
{
    private AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000() {}

    public static AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AdvancedIllnessandFrailtyExclusionECQMFHIR4";
    public string Version => "5.17.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlValueSetDefinition("Nonacute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext _) => _Nonacute_Inpatient;
    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Observation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext _) => _Observation;
    private static readonly CqlValueSet _Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlValueSetDefinition("Outpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlValueSet _Outpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object vzzl_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)vzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzn_ = context.Operators.SingletonFrom<Patient>(vzzm_);

        return vzzn_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet vzzo_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> vzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzo_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> vzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzo_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> vzzs_ = context.Operators.Union<MedicationRequest>(vzzp_, vzzr_);
        bool? vzzt_(MedicationRequest DementiaMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> vzzv_ = DementiaMed?.StatusElement;
            string vzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzv_);
            bool? vzzx_ = context.Operators.Equal(vzzw_, "active");
            Code<MedicationRequest.MedicationRequestIntent> vzzy_ = DementiaMed?.IntentElement;
            string vzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzy_);
            bool? wzza_ = context.Operators.Equal(vzzz_, "order");
            bool? wzzb_ = context.Operators.And(vzzx_, wzza_);
            CqlInterval<CqlDateTime> wzzc_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
            CqlInterval<CqlDateTime> wzzd_ = this.Measurement_Period(context);
            CqlDateTime wzze_ = context.Operators.Start(wzzd_);
            CqlQuantity wzzf_ = context.Operators.Quantity(1m, "year");
            CqlDateTime wzzg_ = context.Operators.Subtract(wzze_, wzzf_);
            CqlDateTime wzzi_ = context.Operators.End(wzzd_);
            CqlInterval<CqlDateTime> wzzj_ = context.Operators.Interval(wzzg_, wzzi_, true, true);
            bool? wzzk_ = context.Operators.Overlaps(wzzc_, wzzj_, default);
            bool? wzzl_ = context.Operators.And(wzzb_, wzzk_);

            return wzzl_;
        };
        IEnumerable<MedicationRequest> vzzu_ = context.Operators.Where<MedicationRequest>(vzzs_, vzzt_);

        return vzzu_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzm_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> wzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzo_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> wzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzq_ = context.Operators.Union<Encounter>(wzzn_, wzzp_);
        bool? wzzr_(Encounter LongTermFacilityEncounter)
        {
            Code<Encounter.EncounterStatus> wzzw_ = LongTermFacilityEncounter?.StatusElement;
            string wzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzw_);
            bool? wzzy_ = context.Operators.Equal(wzzx_, "finished");
            Period wzzz_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> xzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzz_ as object);
            CqlInterval<CqlDateTime> xzzb_ = this.Measurement_Period(context);
            bool? xzzc_ = context.Operators.Overlaps(xzza_, xzzb_, default);
            bool? xzzd_ = context.Operators.And(wzzy_, xzzc_);

            return xzzd_;
        };
        IEnumerable<Encounter> wzzs_ = context.Operators.Where<Encounter>(wzzq_, wzzr_);
        CqlInterval<CqlDateTime> wzzt_(Encounter LongTermFacilityEncounter)
        {
            Period xzze_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> xzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzze_ as object);
            CqlInterval<CqlDateTime> xzzg_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> xzzh_ = context.Operators.Intersect<CqlDateTime>(xzzf_, xzzg_);

            return xzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> wzzu_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(wzzs_, wzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> wzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzu_);

        return wzzv_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet xzzi_ = this.Outpatient(context);
        IEnumerable<Encounter> xzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet xzzk_ = this.Observation(context);
        IEnumerable<Encounter> xzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzm_ = context.Operators.Union<Encounter>(xzzj_, xzzl_);
        CqlValueSet xzzn_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> xzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet xzzp_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> xzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzr_ = context.Operators.Union<Encounter>(xzzo_, xzzq_);
        IEnumerable<Encounter> xzzs_ = context.Operators.Union<Encounter>(xzzm_, xzzr_);
        bool? xzzt_(Encounter Outpatient)
        {
            Code<Encounter.EncounterStatus> xzzx_ = Outpatient?.StatusElement;
            string xzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzx_);
            bool? xzzz_ = context.Operators.Equal(xzzy_, "finished");

            return xzzz_;
        };
        IEnumerable<Encounter> xzzu_ = context.Operators.Where<Encounter>(xzzs_, xzzt_);
        IEnumerable<Encounter> xzzv_(Encounter OutpatientEncounter)
        {
            CqlValueSet yzza_ = this.Advanced_Illness(context);
            IEnumerable<Condition> yzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? yzzc_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> yzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? yzzh_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, yzzg_);
                Period yzzi_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> yzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzi_ as object);
                CqlDateTime yzzk_ = context.Operators.Start(yzzj_);
                CqlInterval<CqlDateTime> yzzl_ = this.Measurement_Period(context);
                CqlDateTime yzzm_ = context.Operators.End(yzzl_);
                CqlQuantity yzzn_ = context.Operators.Quantity(2m, "years");
                CqlDateTime yzzo_ = context.Operators.Subtract(yzzm_, yzzn_);
                CqlDateTime yzzq_ = context.Operators.End(yzzl_);
                CqlInterval<CqlDateTime> yzzr_ = context.Operators.Interval(yzzo_, yzzq_, true, true);
                bool? yzzs_ = context.Operators.In<CqlDateTime>(yzzk_, yzzr_, default);
                CqlDateTime yzzu_ = context.Operators.End(yzzl_);
                bool? yzzv_ = context.Operators.Not((bool?)(yzzu_ is null));
                bool? yzzw_ = context.Operators.And(yzzs_, yzzv_);
                bool? yzzx_ = context.Operators.And(yzzh_, yzzw_);

                return yzzx_;
            };
            IEnumerable<Condition> yzzd_ = context.Operators.Where<Condition>(yzzb_, yzzc_);
            Encounter yzze_(Condition AdvancedIllnessDiagnosis) =>
                OutpatientEncounter;
            IEnumerable<Encounter> yzzf_ = context.Operators.Select<Condition, Encounter>(yzzd_, yzze_);

            return yzzf_;
        };
        IEnumerable<Encounter> xzzw_ = context.Operators.SelectMany<Encounter, Encounter>(xzzu_, xzzv_);

        return xzzw_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> yzzy_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> zzza_ = context.Operators.CrossJoin<Encounter, Encounter>(yzzy_, yzzy_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? zzzb_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? zzzi_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return zzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> zzzc_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(zzza_, zzzb_);
        bool? zzzd_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period zzzj_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> zzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzj_);
            CqlDateTime zzzl_ = context.Operators.End(zzzk_);
            Period zzzm_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> zzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, zzzm_);
            CqlDateTime zzzo_ = context.Operators.End(zzzn_);
            CqlQuantity zzzp_ = context.Operators.Quantity(1m, "day");
            CqlDateTime zzzq_ = context.Operators.Add(zzzo_, zzzp_);
            bool? zzzr_ = context.Operators.SameOrAfter(zzzl_, zzzq_, "day");

            return zzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> zzze_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(zzzc_, zzzd_);
        Encounter zzzf_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> zzzg_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(zzze_, zzzf_);
        IEnumerable<Encounter> zzzh_ = context.Operators.Distinct<Encounter>(zzzg_);

        return zzzh_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> zzzs_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> zzzt_ = context.Operators.Collapse(zzzs_, default);

        return zzzt_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> zzzu_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> zzzw_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(zzzu_, zzzu_);
        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? zzzx_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? azzze_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);

            return azzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> zzzy_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(zzzw_, zzzx_);
        bool? zzzz_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime azzzf_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime azzzg_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity azzzh_ = context.Operators.Quantity(1m, "day");
            CqlDateTime azzzi_ = context.Operators.Subtract(azzzg_, azzzh_);
            CqlDateTime azzzl_ = context.Operators.Add(azzzg_, azzzh_);
            CqlInterval<CqlDateTime> azzzm_ = context.Operators.Interval(azzzi_, azzzl_, true, true);
            bool? azzzn_ = context.Operators.In<CqlDateTime>(azzzf_, azzzm_, default);
            bool? azzzp_ = context.Operators.Not((bool?)(azzzg_ is null));
            bool? azzzq_ = context.Operators.And(azzzn_, azzzp_);

            return azzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> azzza_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(zzzy_, zzzz_);
        CqlInterval<CqlDateTime> azzzb_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime azzzr_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime azzzs_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> azzzt_ = context.Operators.Interval(azzzr_, azzzs_, true, true);

            return azzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> azzzc_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(azzza_, azzzb_);
        IEnumerable<CqlInterval<CqlDateTime>> azzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzc_);

        return azzzd_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> azzzu_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> azzzv_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> azzzw_ = context.Operators.Union<CqlInterval<CqlDateTime>>(azzzu_, azzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> azzzx_ = context.Operators.Collapse(azzzw_, default);
        int? azzzy_(CqlInterval<CqlDateTime> LTCPeriods)
        {
            CqlDateTime bzzzc_ = context.Operators.Start(LTCPeriods);
            CqlDateTime bzzzd_ = context.Operators.End(LTCPeriods);
            int? bzzze_ = context.Operators.DurationBetween(bzzzc_, bzzzd_, "day");

            return bzzze_;
        };
        IEnumerable<int?> azzzz_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(azzzx_, azzzy_);
        IEnumerable<int?> bzzza_ = context.Operators.Distinct<int?>(azzzz_);
        int? bzzzb_ = context.Operators.Max<int?>(bzzza_);

        return bzzzb_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet bzzzf_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> bzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? bzzzh_(Encounter AcuteInpatient)
        {
            Code<Encounter.EncounterStatus> bzzzl_ = AcuteInpatient?.StatusElement;
            string bzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzl_);
            bool? bzzzn_ = context.Operators.Equal(bzzzm_, "finished");

            return bzzzn_;
        };
        IEnumerable<Encounter> bzzzi_ = context.Operators.Where<Encounter>(bzzzg_, bzzzh_);
        IEnumerable<Encounter> bzzzj_(Encounter InpatientEncounter)
        {
            CqlValueSet bzzzo_ = this.Advanced_Illness(context);
            IEnumerable<Condition> bzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? bzzzq_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> bzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? bzzzv_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, bzzzu_);
                Period bzzzw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzw_ as object);
                CqlDateTime bzzzy_ = context.Operators.Start(bzzzx_);
                CqlInterval<CqlDateTime> bzzzz_ = this.Measurement_Period(context);
                CqlDateTime czzza_ = context.Operators.End(bzzzz_);
                CqlQuantity czzzb_ = context.Operators.Quantity(2m, "years");
                CqlDateTime czzzc_ = context.Operators.Subtract(czzza_, czzzb_);
                CqlDateTime czzze_ = context.Operators.End(bzzzz_);
                CqlInterval<CqlDateTime> czzzf_ = context.Operators.Interval(czzzc_, czzze_, true, true);
                bool? czzzg_ = context.Operators.In<CqlDateTime>(bzzzy_, czzzf_, default);
                CqlDateTime czzzi_ = context.Operators.End(bzzzz_);
                bool? czzzj_ = context.Operators.Not((bool?)(czzzi_ is null));
                bool? czzzk_ = context.Operators.And(czzzg_, czzzj_);
                bool? czzzl_ = context.Operators.And(bzzzv_, czzzk_);

                return czzzl_;
            };
            IEnumerable<Condition> bzzzr_ = context.Operators.Where<Condition>(bzzzp_, bzzzq_);
            Encounter bzzzs_(Condition AdvancedIllnessDiagnosis) =>
                InpatientEncounter;
            IEnumerable<Encounter> bzzzt_ = context.Operators.Select<Condition, Encounter>(bzzzr_, bzzzs_);

            return bzzzt_;
        };
        IEnumerable<Encounter> bzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzi_, bzzzj_);

        return bzzzk_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet czzzm_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> czzzn_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, czzzm_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> czzzp_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, czzzm_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> czzzq_ = context.Operators.Union<DeviceRequest>(czzzn_, czzzp_);
        bool? czzzr_(DeviceRequest FrailtyDeviceOrder)
        {
            Code<RequestStatus> dzzzs_ = FrailtyDeviceOrder?.StatusElement;
            string dzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzs_);
            string[] dzzzu_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? dzzzv_ = context.Operators.In<string>(dzzzt_, dzzzu_ as IEnumerable<string>);
            Code<RequestIntent> dzzzw_ = FrailtyDeviceOrder?.IntentElement;
            string dzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzw_);
            bool? dzzzy_ = context.Operators.Equal(dzzzx_, "order");
            bool? dzzzz_ = context.Operators.And(dzzzv_, dzzzy_);
            CqlInterval<CqlDateTime> ezzza_ = this.Measurement_Period(context);
            FhirDateTime ezzzb_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> ezzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzb_ as object);
            bool? ezzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzza_, ezzzc_, default);
            bool? ezzze_ = context.Operators.And(dzzzz_, ezzzd_);

            return ezzze_;
        };
        IEnumerable<DeviceRequest> czzzs_ = context.Operators.Where<DeviceRequest>(czzzq_, czzzr_);
        bool? czzzt_ = context.Operators.Exists<DeviceRequest>(czzzs_);
        IEnumerable<Observation> czzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? czzzw_(Observation FrailtyDeviceApplied)
        {
            Code<ObservationStatus> ezzzf_ = FrailtyDeviceApplied?.StatusElement;
            string ezzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzf_);
            string[] ezzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzi_ = context.Operators.In<string>(ezzzg_, ezzzh_ as IEnumerable<string>);
            DataType ezzzj_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> ezzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzj_);
            CqlInterval<CqlDateTime> ezzzl_ = this.Measurement_Period(context);
            bool? ezzzm_ = context.Operators.Overlaps(ezzzk_, ezzzl_, default);
            bool? ezzzn_ = context.Operators.And(ezzzi_, ezzzm_);

            return ezzzn_;
        };
        IEnumerable<Observation> czzzx_ = context.Operators.Where<Observation>(czzzv_, czzzw_);
        bool? czzzy_ = context.Operators.Exists<Observation>(czzzx_);
        bool? czzzz_ = context.Operators.Or(czzzt_, czzzy_);
        CqlValueSet dzzza_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> dzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? dzzzc_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> ezzzp_ = this.Measurement_Period(context);
            bool? ezzzq_ = context.Operators.Overlaps(ezzzo_, ezzzp_, default);

            return ezzzq_;
        };
        IEnumerable<Condition> dzzzd_ = context.Operators.Where<Condition>(dzzzb_, dzzzc_);
        bool? dzzze_ = context.Operators.Exists<Condition>(dzzzd_);
        bool? dzzzf_ = context.Operators.Or(czzzz_, dzzze_);
        CqlValueSet dzzzg_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> dzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? dzzzi_(Encounter FrailtyEncounter)
        {
            Code<Encounter.EncounterStatus> ezzzr_ = FrailtyEncounter?.StatusElement;
            string ezzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzr_);
            bool? ezzzt_ = context.Operators.Equal(ezzzs_, "finished");
            Period ezzzu_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzu_ as object);
            CqlInterval<CqlDateTime> ezzzw_ = this.Measurement_Period(context);
            bool? ezzzx_ = context.Operators.Overlaps(ezzzv_, ezzzw_, default);
            bool? ezzzy_ = context.Operators.And(ezzzt_, ezzzx_);

            return ezzzy_;
        };
        IEnumerable<Encounter> dzzzj_ = context.Operators.Where<Encounter>(dzzzh_, dzzzi_);
        bool? dzzzk_ = context.Operators.Exists<Encounter>(dzzzj_);
        bool? dzzzl_ = context.Operators.Or(dzzzf_, dzzzk_);
        CqlValueSet dzzzm_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> dzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzo_(Observation FrailtySymptom)
        {
            Code<ObservationStatus> ezzzz_ = FrailtySymptom?.StatusElement;
            string fzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzz_);
            string[] fzzzb_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzc_ = context.Operators.In<string>(fzzza_, fzzzb_ as IEnumerable<string>);
            DataType fzzzd_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> fzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzd_);
            CqlInterval<CqlDateTime> fzzzf_ = this.Measurement_Period(context);
            bool? fzzzg_ = context.Operators.Overlaps(fzzze_, fzzzf_, default);
            bool? fzzzh_ = context.Operators.And(fzzzc_, fzzzg_);

            return fzzzh_;
        };
        IEnumerable<Observation> dzzzp_ = context.Operators.Where<Observation>(dzzzn_, dzzzo_);
        bool? dzzzq_ = context.Operators.Exists<Observation>(dzzzp_);
        bool? dzzzr_ = context.Operators.Or(dzzzl_, dzzzq_);

        return dzzzr_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient fzzzi_ = this.Patient(context);
        Date fzzzj_ = fzzzi_?.BirthDateElement;
        string fzzzk_ = fzzzj_?.Value;
        CqlDate fzzzl_ = context.Operators.ConvertStringToDate(fzzzk_);
        CqlInterval<CqlDateTime> fzzzm_ = this.Measurement_Period(context);
        CqlDateTime fzzzn_ = context.Operators.Start(fzzzm_);
        CqlDate fzzzo_ = context.Operators.DateFrom(fzzzn_);
        int? fzzzp_ = context.Operators.CalculateAgeAt(fzzzl_, fzzzo_, "year");
        CqlInterval<int?> fzzzq_ = context.Operators.Interval(65, 79, true, true);
        bool? fzzzr_ = context.Operators.In<int?>(fzzzp_, fzzzq_, default);
        bool? fzzzs_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? fzzzt_ = context.Operators.And(fzzzr_, fzzzs_);
        IEnumerable<Encounter> fzzzu_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? fzzzv_ = context.Operators.Exists<Encounter>(fzzzu_);
        IEnumerable<Encounter> fzzzw_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? fzzzx_ = context.Operators.Exists<Encounter>(fzzzw_);
        bool? fzzzy_ = context.Operators.Or(fzzzv_, fzzzx_);
        IEnumerable<MedicationRequest> fzzzz_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? gzzza_ = context.Operators.Exists<MedicationRequest>(fzzzz_);
        bool? gzzzb_ = context.Operators.Or(fzzzy_, gzzza_);
        bool? gzzzc_ = context.Operators.And(fzzzt_, gzzzb_);
        Date gzzze_ = fzzzi_?.BirthDateElement;
        string gzzzf_ = gzzze_?.Value;
        CqlDate gzzzg_ = context.Operators.ConvertStringToDate(gzzzf_);
        CqlDateTime gzzzi_ = context.Operators.Start(fzzzm_);
        CqlDate gzzzj_ = context.Operators.DateFrom(gzzzi_);
        int? gzzzk_ = context.Operators.CalculateAgeAt(gzzzg_, gzzzj_, "year");
        bool? gzzzl_ = context.Operators.GreaterOrEqual(gzzzk_, 80);
        bool? gzzzn_ = context.Operators.And(gzzzl_, fzzzs_);
        bool? gzzzo_ = context.Operators.Or(gzzzc_, gzzzn_);

        return gzzzo_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient gzzzp_ = this.Patient(context);
        Date gzzzq_ = gzzzp_?.BirthDateElement;
        string gzzzr_ = gzzzq_?.Value;
        CqlDate gzzzs_ = context.Operators.ConvertStringToDate(gzzzr_);
        CqlInterval<CqlDateTime> gzzzt_ = this.Measurement_Period(context);
        CqlDateTime gzzzu_ = context.Operators.Start(gzzzt_);
        CqlDate gzzzv_ = context.Operators.DateFrom(gzzzu_);
        int? gzzzw_ = context.Operators.CalculateAgeAt(gzzzs_, gzzzv_, "year");
        bool? gzzzx_ = context.Operators.GreaterOrEqual(gzzzw_, 65);
        bool? gzzzy_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? gzzzz_ = context.Operators.And(gzzzx_, gzzzy_);
        IEnumerable<Encounter> hzzza_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? hzzzb_ = context.Operators.Exists<Encounter>(hzzza_);
        IEnumerable<Encounter> hzzzc_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? hzzzd_ = context.Operators.Exists<Encounter>(hzzzc_);
        bool? hzzze_ = context.Operators.Or(hzzzb_, hzzzd_);
        IEnumerable<MedicationRequest> hzzzf_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? hzzzg_ = context.Operators.Exists<MedicationRequest>(hzzzf_);
        bool? hzzzh_ = context.Operators.Or(hzzze_, hzzzg_);
        bool? hzzzi_ = context.Operators.And(gzzzz_, hzzzh_);

        return hzzzi_;
    }


    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
    {
        int? hzzzj_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? hzzzk_ = context.Operators.Greater(hzzzj_, 90);

        return hzzzk_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
        ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OutpatientEncounter1", "OutpatientEncounter2"]);

    #endregion CqlTupleMetadata Properties

}
