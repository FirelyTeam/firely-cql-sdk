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
        object szzzzk_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)szzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient szzzzm_ = context.Operators.SingletonFrom<Patient>(szzzzl_);

        return szzzzm_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzn_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> szzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzn_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> szzzzr_ = context.Operators.Union<MedicationRequest>(szzzzo_, szzzzq_);
        bool? szzzzs_(MedicationRequest DementiaMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> szzzzu_ = DementiaMed?.StatusElement;
            string szzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzu_);
            bool? szzzzw_ = context.Operators.Equal(szzzzv_, "active");
            Code<MedicationRequest.MedicationRequestIntent> szzzzx_ = DementiaMed?.IntentElement;
            string szzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzx_);
            bool? szzzzz_ = context.Operators.Equal(szzzzy_, "order");
            bool? tzzzza_ = context.Operators.And(szzzzw_, szzzzz_);
            CqlInterval<CqlDateTime> tzzzzb_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
            CqlInterval<CqlDateTime> tzzzzc_ = this.Measurement_Period(context);
            CqlDateTime tzzzzd_ = context.Operators.Start(tzzzzc_);
            CqlQuantity tzzzze_ = context.Operators.Quantity(1m, "year");
            CqlDateTime tzzzzf_ = context.Operators.Subtract(tzzzzd_, tzzzze_);
            CqlDateTime tzzzzh_ = context.Operators.End(tzzzzc_);
            CqlInterval<CqlDateTime> tzzzzi_ = context.Operators.Interval(tzzzzf_, tzzzzh_, true, true);
            bool? tzzzzj_ = context.Operators.Overlaps(tzzzzb_, tzzzzi_, default);
            bool? tzzzzk_ = context.Operators.And(tzzzza_, tzzzzj_);

            return tzzzzk_;
        };
        IEnumerable<MedicationRequest> szzzzt_ = context.Operators.Where<MedicationRequest>(szzzzr_, szzzzs_);

        return szzzzt_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet tzzzzl_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> tzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet tzzzzn_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> tzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> tzzzzp_ = context.Operators.Union<Encounter>(tzzzzm_, tzzzzo_);
        bool? tzzzzq_(Encounter LongTermFacilityEncounter)
        {
            Code<Encounter.EncounterStatus> tzzzzv_ = LongTermFacilityEncounter?.StatusElement;
            string tzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzv_);
            bool? tzzzzx_ = context.Operators.Equal(tzzzzw_, "finished");
            Period tzzzzy_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzy_ as object);
            CqlInterval<CqlDateTime> uzzzza_ = this.Measurement_Period(context);
            bool? uzzzzb_ = context.Operators.Overlaps(tzzzzz_, uzzzza_, default);
            bool? uzzzzc_ = context.Operators.And(tzzzzx_, uzzzzb_);

            return uzzzzc_;
        };
        IEnumerable<Encounter> tzzzzr_ = context.Operators.Where<Encounter>(tzzzzp_, tzzzzq_);
        CqlInterval<CqlDateTime> tzzzzs_(Encounter LongTermFacilityEncounter)
        {
            Period uzzzzd_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzd_ as object);
            CqlInterval<CqlDateTime> uzzzzf_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> uzzzzg_ = context.Operators.Intersect<CqlDateTime>(uzzzze_, uzzzzf_);

            return uzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzt_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(tzzzzr_, tzzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzt_);

        return tzzzzu_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet uzzzzh_ = this.Outpatient(context);
        IEnumerable<Encounter> uzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet uzzzzj_ = this.Observation(context);
        IEnumerable<Encounter> uzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzzl_ = context.Operators.Union<Encounter>(uzzzzi_, uzzzzk_);
        CqlValueSet uzzzzm_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> uzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet uzzzzo_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> uzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzzq_ = context.Operators.Union<Encounter>(uzzzzn_, uzzzzp_);
        IEnumerable<Encounter> uzzzzr_ = context.Operators.Union<Encounter>(uzzzzl_, uzzzzq_);
        bool? uzzzzs_(Encounter Outpatient)
        {
            Code<Encounter.EncounterStatus> uzzzzw_ = Outpatient?.StatusElement;
            string uzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzw_);
            bool? uzzzzy_ = context.Operators.Equal(uzzzzx_, "finished");

            return uzzzzy_;
        };
        IEnumerable<Encounter> uzzzzt_ = context.Operators.Where<Encounter>(uzzzzr_, uzzzzs_);
        IEnumerable<Encounter> uzzzzu_(Encounter OutpatientEncounter)
        {
            CqlValueSet uzzzzz_ = this.Advanced_Illness(context);
            IEnumerable<Condition> vzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? vzzzzb_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> vzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? vzzzzg_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, vzzzzf_);
                Period vzzzzh_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzh_ as object);
                CqlDateTime vzzzzj_ = context.Operators.Start(vzzzzi_);
                CqlInterval<CqlDateTime> vzzzzk_ = this.Measurement_Period(context);
                CqlDateTime vzzzzl_ = context.Operators.End(vzzzzk_);
                CqlQuantity vzzzzm_ = context.Operators.Quantity(2m, "years");
                CqlDateTime vzzzzn_ = context.Operators.Subtract(vzzzzl_, vzzzzm_);
                CqlDateTime vzzzzp_ = context.Operators.End(vzzzzk_);
                CqlInterval<CqlDateTime> vzzzzq_ = context.Operators.Interval(vzzzzn_, vzzzzp_, true, true);
                bool? vzzzzr_ = context.Operators.In<CqlDateTime>(vzzzzj_, vzzzzq_, default);
                CqlDateTime vzzzzt_ = context.Operators.End(vzzzzk_);
                bool? vzzzzu_ = context.Operators.Not((bool?)(vzzzzt_ is null));
                bool? vzzzzv_ = context.Operators.And(vzzzzr_, vzzzzu_);
                bool? vzzzzw_ = context.Operators.And(vzzzzg_, vzzzzv_);

                return vzzzzw_;
            };
            IEnumerable<Condition> vzzzzc_ = context.Operators.Where<Condition>(vzzzza_, vzzzzb_);
            Encounter vzzzzd_(Condition AdvancedIllnessDiagnosis) =>
                OutpatientEncounter;
            IEnumerable<Encounter> vzzzze_ = context.Operators.Select<Condition, Encounter>(vzzzzc_, vzzzzd_);

            return vzzzze_;
        };
        IEnumerable<Encounter> uzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzt_, uzzzzu_);

        return uzzzzv_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzx_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> vzzzzz_ = context.Operators.CrossJoin<Encounter, Encounter>(vzzzzx_, vzzzzx_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? wzzzza_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? wzzzzh_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> wzzzzb_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(vzzzzz_, wzzzza_);
        bool? wzzzzc_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period wzzzzi_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> wzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzi_);
            CqlDateTime wzzzzk_ = context.Operators.End(wzzzzj_);
            Period wzzzzl_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> wzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, wzzzzl_);
            CqlDateTime wzzzzn_ = context.Operators.End(wzzzzm_);
            CqlQuantity wzzzzo_ = context.Operators.Quantity(1m, "day");
            CqlDateTime wzzzzp_ = context.Operators.Add(wzzzzn_, wzzzzo_);
            bool? wzzzzq_ = context.Operators.SameOrAfter(wzzzzk_, wzzzzp_, "day");

            return wzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> wzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(wzzzzb_, wzzzzc_);
        Encounter wzzzze_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> wzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(wzzzzd_, wzzzze_);
        IEnumerable<Encounter> wzzzzg_ = context.Operators.Distinct<Encounter>(wzzzzf_);

        return wzzzzg_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzr_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzs_ = context.Operators.Collapse(wzzzzr_, default);

        return wzzzzs_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzt_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> wzzzzv_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(wzzzzt_, wzzzzt_);
        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? wzzzzw_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? xzzzzd_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> wzzzzx_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(wzzzzv_, wzzzzw_);
        bool? wzzzzy_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime xzzzze_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime xzzzzf_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity xzzzzg_ = context.Operators.Quantity(1m, "day");
            CqlDateTime xzzzzh_ = context.Operators.Subtract(xzzzzf_, xzzzzg_);
            CqlDateTime xzzzzk_ = context.Operators.Add(xzzzzf_, xzzzzg_);
            CqlInterval<CqlDateTime> xzzzzl_ = context.Operators.Interval(xzzzzh_, xzzzzk_, true, true);
            bool? xzzzzm_ = context.Operators.In<CqlDateTime>(xzzzze_, xzzzzl_, default);
            bool? xzzzzo_ = context.Operators.Not((bool?)(xzzzzf_ is null));
            bool? xzzzzp_ = context.Operators.And(xzzzzm_, xzzzzo_);

            return xzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> wzzzzz_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(wzzzzx_, wzzzzy_);
        CqlInterval<CqlDateTime> xzzzza_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime xzzzzq_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime xzzzzr_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> xzzzzs_ = context.Operators.Interval(xzzzzq_, xzzzzr_, true, true);

            return xzzzzs_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(wzzzzz_, xzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzb_);

        return xzzzzc_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzt_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzu_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzv_ = context.Operators.Union<CqlInterval<CqlDateTime>>(xzzzzt_, xzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> xzzzzw_ = context.Operators.Collapse(xzzzzv_, default);
        int? xzzzzx_(CqlInterval<CqlDateTime> LTCPeriods)
        {
            CqlDateTime yzzzzb_ = context.Operators.Start(LTCPeriods);
            CqlDateTime yzzzzc_ = context.Operators.End(LTCPeriods);
            int? yzzzzd_ = context.Operators.DurationBetween(yzzzzb_, yzzzzc_, "day");

            return yzzzzd_;
        };
        IEnumerable<int?> xzzzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(xzzzzw_, xzzzzx_);
        IEnumerable<int?> xzzzzz_ = context.Operators.Distinct<int?>(xzzzzy_);
        int? yzzzza_ = context.Operators.Max<int?>(xzzzzz_);

        return yzzzza_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet yzzzze_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> yzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? yzzzzg_(Encounter AcuteInpatient)
        {
            Code<Encounter.EncounterStatus> yzzzzk_ = AcuteInpatient?.StatusElement;
            string yzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzk_);
            bool? yzzzzm_ = context.Operators.Equal(yzzzzl_, "finished");

            return yzzzzm_;
        };
        IEnumerable<Encounter> yzzzzh_ = context.Operators.Where<Encounter>(yzzzzf_, yzzzzg_);
        IEnumerable<Encounter> yzzzzi_(Encounter InpatientEncounter)
        {
            CqlValueSet yzzzzn_ = this.Advanced_Illness(context);
            IEnumerable<Condition> yzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? yzzzzp_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> yzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? yzzzzu_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, yzzzzt_);
                Period yzzzzv_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzv_ as object);
                CqlDateTime yzzzzx_ = context.Operators.Start(yzzzzw_);
                CqlInterval<CqlDateTime> yzzzzy_ = this.Measurement_Period(context);
                CqlDateTime yzzzzz_ = context.Operators.End(yzzzzy_);
                CqlQuantity zzzzza_ = context.Operators.Quantity(2m, "years");
                CqlDateTime zzzzzb_ = context.Operators.Subtract(yzzzzz_, zzzzza_);
                CqlDateTime zzzzzd_ = context.Operators.End(yzzzzy_);
                CqlInterval<CqlDateTime> zzzzze_ = context.Operators.Interval(zzzzzb_, zzzzzd_, true, true);
                bool? zzzzzf_ = context.Operators.In<CqlDateTime>(yzzzzx_, zzzzze_, default);
                CqlDateTime zzzzzh_ = context.Operators.End(yzzzzy_);
                bool? zzzzzi_ = context.Operators.Not((bool?)(zzzzzh_ is null));
                bool? zzzzzj_ = context.Operators.And(zzzzzf_, zzzzzi_);
                bool? zzzzzk_ = context.Operators.And(yzzzzu_, zzzzzj_);

                return zzzzzk_;
            };
            IEnumerable<Condition> yzzzzq_ = context.Operators.Where<Condition>(yzzzzo_, yzzzzp_);
            Encounter yzzzzr_(Condition AdvancedIllnessDiagnosis) =>
                InpatientEncounter;
            IEnumerable<Encounter> yzzzzs_ = context.Operators.Select<Condition, Encounter>(yzzzzq_, yzzzzr_);

            return yzzzzs_;
        };
        IEnumerable<Encounter> yzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzh_, yzzzzi_);

        return yzzzzj_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet zzzzzl_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> zzzzzm_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, zzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> zzzzzo_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, zzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> zzzzzp_ = context.Operators.Union<DeviceRequest>(zzzzzm_, zzzzzo_);
        bool? zzzzzq_(DeviceRequest FrailtyDeviceOrder)
        {
            Code<RequestStatus> azzzzzr_ = FrailtyDeviceOrder?.StatusElement;
            string azzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzr_);
            string[] azzzzzt_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? azzzzzu_ = context.Operators.In<string>(azzzzzs_, azzzzzt_ as IEnumerable<string>);
            Code<RequestIntent> azzzzzv_ = FrailtyDeviceOrder?.IntentElement;
            string azzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzv_);
            bool? azzzzzx_ = context.Operators.Equal(azzzzzw_, "order");
            bool? azzzzzy_ = context.Operators.And(azzzzzu_, azzzzzx_);
            CqlInterval<CqlDateTime> azzzzzz_ = this.Measurement_Period(context);
            FhirDateTime bzzzzza_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> bzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzza_ as object);
            bool? bzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzz_, bzzzzzb_, default);
            bool? bzzzzzd_ = context.Operators.And(azzzzzy_, bzzzzzc_);

            return bzzzzzd_;
        };
        IEnumerable<DeviceRequest> zzzzzr_ = context.Operators.Where<DeviceRequest>(zzzzzp_, zzzzzq_);
        bool? zzzzzs_ = context.Operators.Exists<DeviceRequest>(zzzzzr_);
        IEnumerable<Observation> zzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzv_(Observation FrailtyDeviceApplied)
        {
            Code<ObservationStatus> bzzzzze_ = FrailtyDeviceApplied?.StatusElement;
            string bzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzze_);
            string[] bzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzh_ = context.Operators.In<string>(bzzzzzf_, bzzzzzg_ as IEnumerable<string>);
            DataType bzzzzzi_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> bzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzi_);
            CqlInterval<CqlDateTime> bzzzzzk_ = this.Measurement_Period(context);
            bool? bzzzzzl_ = context.Operators.Overlaps(bzzzzzj_, bzzzzzk_, default);
            bool? bzzzzzm_ = context.Operators.And(bzzzzzh_, bzzzzzl_);

            return bzzzzzm_;
        };
        IEnumerable<Observation> zzzzzw_ = context.Operators.Where<Observation>(zzzzzu_, zzzzzv_);
        bool? zzzzzx_ = context.Operators.Exists<Observation>(zzzzzw_);
        bool? zzzzzy_ = context.Operators.Or(zzzzzs_, zzzzzx_);
        CqlValueSet zzzzzz_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> azzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? azzzzzb_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bzzzzzo_ = this.Measurement_Period(context);
            bool? bzzzzzp_ = context.Operators.Overlaps(bzzzzzn_, bzzzzzo_, default);

            return bzzzzzp_;
        };
        IEnumerable<Condition> azzzzzc_ = context.Operators.Where<Condition>(azzzzza_, azzzzzb_);
        bool? azzzzzd_ = context.Operators.Exists<Condition>(azzzzzc_);
        bool? azzzzze_ = context.Operators.Or(zzzzzy_, azzzzzd_);
        CqlValueSet azzzzzf_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> azzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? azzzzzh_(Encounter FrailtyEncounter)
        {
            Code<Encounter.EncounterStatus> bzzzzzq_ = FrailtyEncounter?.StatusElement;
            string bzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzq_);
            bool? bzzzzzs_ = context.Operators.Equal(bzzzzzr_, "finished");
            Period bzzzzzt_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzzt_ as object);
            CqlInterval<CqlDateTime> bzzzzzv_ = this.Measurement_Period(context);
            bool? bzzzzzw_ = context.Operators.Overlaps(bzzzzzu_, bzzzzzv_, default);
            bool? bzzzzzx_ = context.Operators.And(bzzzzzs_, bzzzzzw_);

            return bzzzzzx_;
        };
        IEnumerable<Encounter> azzzzzi_ = context.Operators.Where<Encounter>(azzzzzg_, azzzzzh_);
        bool? azzzzzj_ = context.Operators.Exists<Encounter>(azzzzzi_);
        bool? azzzzzk_ = context.Operators.Or(azzzzze_, azzzzzj_);
        CqlValueSet azzzzzl_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> azzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzn_(Observation FrailtySymptom)
        {
            Code<ObservationStatus> bzzzzzy_ = FrailtySymptom?.StatusElement;
            string bzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzy_);
            string[] czzzzza_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzb_ = context.Operators.In<string>(bzzzzzz_, czzzzza_ as IEnumerable<string>);
            DataType czzzzzc_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> czzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzc_);
            CqlInterval<CqlDateTime> czzzzze_ = this.Measurement_Period(context);
            bool? czzzzzf_ = context.Operators.Overlaps(czzzzzd_, czzzzze_, default);
            bool? czzzzzg_ = context.Operators.And(czzzzzb_, czzzzzf_);

            return czzzzzg_;
        };
        IEnumerable<Observation> azzzzzo_ = context.Operators.Where<Observation>(azzzzzm_, azzzzzn_);
        bool? azzzzzp_ = context.Operators.Exists<Observation>(azzzzzo_);
        bool? azzzzzq_ = context.Operators.Or(azzzzzk_, azzzzzp_);

        return azzzzzq_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient czzzzzh_ = this.Patient(context);
        Date czzzzzi_ = czzzzzh_?.BirthDateElement;
        string czzzzzj_ = czzzzzi_?.Value;
        CqlDate czzzzzk_ = context.Operators.ConvertStringToDate(czzzzzj_);
        CqlInterval<CqlDateTime> czzzzzl_ = this.Measurement_Period(context);
        CqlDateTime czzzzzm_ = context.Operators.Start(czzzzzl_);
        CqlDate czzzzzn_ = context.Operators.DateFrom(czzzzzm_);
        int? czzzzzo_ = context.Operators.CalculateAgeAt(czzzzzk_, czzzzzn_, "year");
        CqlInterval<int?> czzzzzp_ = context.Operators.Interval(65, 79, true, true);
        bool? czzzzzq_ = context.Operators.In<int?>(czzzzzo_, czzzzzp_, default);
        bool? czzzzzr_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? czzzzzs_ = context.Operators.And(czzzzzq_, czzzzzr_);
        IEnumerable<Encounter> czzzzzt_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? czzzzzu_ = context.Operators.Exists<Encounter>(czzzzzt_);
        IEnumerable<Encounter> czzzzzv_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? czzzzzw_ = context.Operators.Exists<Encounter>(czzzzzv_);
        bool? czzzzzx_ = context.Operators.Or(czzzzzu_, czzzzzw_);
        IEnumerable<MedicationRequest> czzzzzy_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? czzzzzz_ = context.Operators.Exists<MedicationRequest>(czzzzzy_);
        bool? dzzzzza_ = context.Operators.Or(czzzzzx_, czzzzzz_);
        bool? dzzzzzb_ = context.Operators.And(czzzzzs_, dzzzzza_);
        Date dzzzzzd_ = czzzzzh_?.BirthDateElement;
        string dzzzzze_ = dzzzzzd_?.Value;
        CqlDate dzzzzzf_ = context.Operators.ConvertStringToDate(dzzzzze_);
        CqlDateTime dzzzzzh_ = context.Operators.Start(czzzzzl_);
        CqlDate dzzzzzi_ = context.Operators.DateFrom(dzzzzzh_);
        int? dzzzzzj_ = context.Operators.CalculateAgeAt(dzzzzzf_, dzzzzzi_, "year");
        bool? dzzzzzk_ = context.Operators.GreaterOrEqual(dzzzzzj_, 80);
        bool? dzzzzzm_ = context.Operators.And(dzzzzzk_, czzzzzr_);
        bool? dzzzzzn_ = context.Operators.Or(dzzzzzb_, dzzzzzm_);

        return dzzzzzn_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient dzzzzzo_ = this.Patient(context);
        Date dzzzzzp_ = dzzzzzo_?.BirthDateElement;
        string dzzzzzq_ = dzzzzzp_?.Value;
        CqlDate dzzzzzr_ = context.Operators.ConvertStringToDate(dzzzzzq_);
        CqlInterval<CqlDateTime> dzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzt_ = context.Operators.Start(dzzzzzs_);
        CqlDate dzzzzzu_ = context.Operators.DateFrom(dzzzzzt_);
        int? dzzzzzv_ = context.Operators.CalculateAgeAt(dzzzzzr_, dzzzzzu_, "year");
        bool? dzzzzzw_ = context.Operators.GreaterOrEqual(dzzzzzv_, 65);
        bool? dzzzzzx_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? dzzzzzy_ = context.Operators.And(dzzzzzw_, dzzzzzx_);
        IEnumerable<Encounter> dzzzzzz_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? ezzzzza_ = context.Operators.Exists<Encounter>(dzzzzzz_);
        IEnumerable<Encounter> ezzzzzb_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? ezzzzzc_ = context.Operators.Exists<Encounter>(ezzzzzb_);
        bool? ezzzzzd_ = context.Operators.Or(ezzzzza_, ezzzzzc_);
        IEnumerable<MedicationRequest> ezzzzze_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? ezzzzzf_ = context.Operators.Exists<MedicationRequest>(ezzzzze_);
        bool? ezzzzzg_ = context.Operators.Or(ezzzzzd_, ezzzzzf_);
        bool? ezzzzzh_ = context.Operators.And(dzzzzzy_, ezzzzzg_);

        return ezzzzzh_;
    }


    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
    {
        int? ezzzzzi_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? ezzzzzj_ = context.Operators.Greater(ezzzzzi_, 90);

        return ezzzzzj_;
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
