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

    #region ValueSet: Acute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Acute Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083",
        valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext context) => _Acute_Inpatient;

    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);
    #endregion

    #region ValueSet: Advanced Illness
    [CqlValueSetDefinition(
        definitionName: "Advanced Illness",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082",
        valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext context) => _Advanced_Illness;

    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);
    #endregion

    #region ValueSet: Care Services in Long-Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long-Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Dementia Medications
    [CqlValueSetDefinition(
        definitionName: "Dementia Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510",
        valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext context) => _Dementia_Medications;

    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);
    #endregion

    #region ValueSet: Frailty Device
    [CqlValueSetDefinition(
        definitionName: "Frailty Device",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext context) => _Frailty_Device;

    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);
    #endregion

    #region ValueSet: Frailty Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Frailty Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext context) => _Frailty_Diagnosis;

    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);
    #endregion

    #region ValueSet: Frailty Encounter
    [CqlValueSetDefinition(
        definitionName: "Frailty Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext context) => _Frailty_Encounter;

    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);
    #endregion

    #region ValueSet: Frailty Symptom
    [CqlValueSetDefinition(
        definitionName: "Frailty Symptom",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext context) => _Frailty_Symptom;

    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);
    #endregion

    #region ValueSet: Nonacute Inpatient
    [CqlValueSetDefinition(
        definitionName: "Nonacute Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084",
        valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext context) => _Nonacute_Inpatient;

    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Observation
    [CqlValueSetDefinition(
        definitionName: "Observation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086",
        valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext context) => _Observation;

    private static readonly CqlValueSet _Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);
    #endregion

    #region ValueSet: Outpatient
    [CqlValueSetDefinition(
        definitionName: "Outpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087",
        valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext context) => _Outpatient;

    private static readonly CqlValueSet _Outpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object hzzzr_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzt_ = context.Operators.SingletonFrom<Patient>(hzzzs_);

        return hzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzu_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> hzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzu_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> hzzzy_ = context.Operators.Union<MedicationRequest>(hzzzv_, hzzzx_);
        bool? hzzzz_(MedicationRequest DementiaMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> izzzb_ = DementiaMed?.StatusElement;
            string izzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzb_);
            bool? izzzd_ = context.Operators.Equal(izzzc_, "active");
            Code<MedicationRequest.MedicationRequestIntent> izzze_ = DementiaMed?.IntentElement;
            string izzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzze_);
            bool? izzzg_ = context.Operators.Equal(izzzf_, "order");
            bool? izzzh_ = context.Operators.And(izzzd_, izzzg_);
            CqlInterval<CqlDateTime> izzzi_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
            CqlInterval<CqlDateTime> izzzj_ = this.Measurement_Period(context);
            CqlDateTime izzzk_ = context.Operators.Start(izzzj_);
            CqlQuantity izzzl_ = context.Operators.Quantity(1m, "year");
            CqlDateTime izzzm_ = context.Operators.Subtract(izzzk_, izzzl_);
            CqlDateTime izzzo_ = context.Operators.End(izzzj_);
            CqlInterval<CqlDateTime> izzzp_ = context.Operators.Interval(izzzm_, izzzo_, true, true);
            bool? izzzq_ = context.Operators.Overlaps(izzzi_, izzzp_, default);
            bool? izzzr_ = context.Operators.And(izzzh_, izzzq_);

            return izzzr_;
        };
        IEnumerable<MedicationRequest> izzza_ = context.Operators.Where<MedicationRequest>(hzzzy_, hzzzz_);

        return izzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet izzzs_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> izzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet izzzu_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> izzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> izzzw_ = context.Operators.Union<Encounter>(izzzt_, izzzv_);
        bool? izzzx_(Encounter LongTermFacilityEncounter)
        {
            Code<Encounter.EncounterStatus> jzzzc_ = LongTermFacilityEncounter?.StatusElement;
            string jzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzc_);
            bool? jzzze_ = context.Operators.Equal(jzzzd_, "finished");
            Period jzzzf_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzf_ as object);
            CqlInterval<CqlDateTime> jzzzh_ = this.Measurement_Period(context);
            bool? jzzzi_ = context.Operators.Overlaps(jzzzg_, jzzzh_, default);
            bool? jzzzj_ = context.Operators.And(jzzze_, jzzzi_);

            return jzzzj_;
        };
        IEnumerable<Encounter> izzzy_ = context.Operators.Where<Encounter>(izzzw_, izzzx_);
        CqlInterval<CqlDateTime> izzzz_(Encounter LongTermFacilityEncounter)
        {
            Period jzzzk_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzk_ as object);
            CqlInterval<CqlDateTime> jzzzm_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> jzzzn_ = context.Operators.Intersect<CqlDateTime>(jzzzl_, jzzzm_);

            return jzzzn_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> jzzza_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(izzzy_, izzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> jzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzza_);

        return jzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet jzzzo_ = this.Outpatient(context);
        IEnumerable<Encounter> jzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzzzq_ = this.Observation(context);
        IEnumerable<Encounter> jzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzzs_ = context.Operators.Union<Encounter>(jzzzp_, jzzzr_);
        CqlValueSet jzzzt_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> jzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet jzzzv_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> jzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzzx_ = context.Operators.Union<Encounter>(jzzzu_, jzzzw_);
        IEnumerable<Encounter> jzzzy_ = context.Operators.Union<Encounter>(jzzzs_, jzzzx_);
        bool? jzzzz_(Encounter Outpatient)
        {
            Code<Encounter.EncounterStatus> kzzzd_ = Outpatient?.StatusElement;
            string kzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzd_);
            bool? kzzzf_ = context.Operators.Equal(kzzze_, "finished");

            return kzzzf_;
        };
        IEnumerable<Encounter> kzzza_ = context.Operators.Where<Encounter>(jzzzy_, jzzzz_);
        IEnumerable<Encounter> kzzzb_(Encounter OutpatientEncounter)
        {
            CqlValueSet kzzzg_ = this.Advanced_Illness(context);
            IEnumerable<Condition> kzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? kzzzi_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> kzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? kzzzn_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, kzzzm_);
                Period kzzzo_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzo_ as object);
                CqlDateTime kzzzq_ = context.Operators.Start(kzzzp_);
                CqlInterval<CqlDateTime> kzzzr_ = this.Measurement_Period(context);
                CqlDateTime kzzzs_ = context.Operators.End(kzzzr_);
                CqlQuantity kzzzt_ = context.Operators.Quantity(2m, "years");
                CqlDateTime kzzzu_ = context.Operators.Subtract(kzzzs_, kzzzt_);
                CqlDateTime kzzzw_ = context.Operators.End(kzzzr_);
                CqlInterval<CqlDateTime> kzzzx_ = context.Operators.Interval(kzzzu_, kzzzw_, true, true);
                bool? kzzzy_ = context.Operators.In<CqlDateTime>(kzzzq_, kzzzx_, default);
                CqlDateTime lzzza_ = context.Operators.End(kzzzr_);
                bool? lzzzb_ = context.Operators.Not((bool?)(lzzza_ is null));
                bool? lzzzc_ = context.Operators.And(kzzzy_, lzzzb_);
                bool? lzzzd_ = context.Operators.And(kzzzn_, lzzzc_);

                return lzzzd_;
            };
            IEnumerable<Condition> kzzzj_ = context.Operators.Where<Condition>(kzzzh_, kzzzi_);
            Encounter kzzzk_(Condition AdvancedIllnessDiagnosis) =>
                OutpatientEncounter;
            IEnumerable<Encounter> kzzzl_ = context.Operators.Select<Condition, Encounter>(kzzzj_, kzzzk_);

            return kzzzl_;
        };
        IEnumerable<Encounter> kzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(kzzza_, kzzzb_);

        return kzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> lzzze_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> lzzzg_ = context.Operators.CrossJoin<Encounter, Encounter>(lzzze_, lzzze_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? lzzzh_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? lzzzo_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> lzzzi_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(lzzzg_, lzzzh_);
        bool? lzzzj_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period lzzzp_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> lzzzq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzp_);
            CqlDateTime lzzzr_ = context.Operators.End(lzzzq_);
            Period lzzzs_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> lzzzt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzs_);
            CqlDateTime lzzzu_ = context.Operators.End(lzzzt_);
            CqlQuantity lzzzv_ = context.Operators.Quantity(1m, "day");
            CqlDateTime lzzzw_ = context.Operators.Add(lzzzu_, lzzzv_);
            bool? lzzzx_ = context.Operators.SameOrAfter(lzzzr_, lzzzw_, "day");

            return lzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> lzzzk_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(lzzzi_, lzzzj_);
        Encounter lzzzl_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> lzzzm_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(lzzzk_, lzzzl_);
        IEnumerable<Encounter> lzzzn_ = context.Operators.Distinct<Encounter>(lzzzm_);

        return lzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> lzzzy_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzz_ = context.Operators.Collapse(lzzzy_, default);

        return lzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> mzzza_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> mzzzc_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(mzzza_, mzzza_);
        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? mzzzd_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? mzzzk_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> mzzze_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(mzzzc_, mzzzd_);
        bool? mzzzf_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime mzzzl_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime mzzzm_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity mzzzn_ = context.Operators.Quantity(1m, "day");
            CqlDateTime mzzzo_ = context.Operators.Subtract(mzzzm_, mzzzn_);
            CqlDateTime mzzzr_ = context.Operators.Add(mzzzm_, mzzzn_);
            CqlInterval<CqlDateTime> mzzzs_ = context.Operators.Interval(mzzzo_, mzzzr_, true, true);
            bool? mzzzt_ = context.Operators.In<CqlDateTime>(mzzzl_, mzzzs_, default);
            bool? mzzzv_ = context.Operators.Not((bool?)(mzzzm_ is null));
            bool? mzzzw_ = context.Operators.And(mzzzt_, mzzzv_);

            return mzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> mzzzg_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(mzzze_, mzzzf_);
        CqlInterval<CqlDateTime> mzzzh_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime mzzzx_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime mzzzy_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> mzzzz_ = context.Operators.Interval(mzzzx_, mzzzy_, true, true);

            return mzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzi_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(mzzzg_, mzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzi_);

        return mzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> nzzza_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzb_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzc_ = context.Operators.Union<CqlInterval<CqlDateTime>>(nzzza_, nzzzb_);
        IEnumerable<CqlInterval<CqlDateTime>> nzzzd_ = context.Operators.Collapse(nzzzc_, default);
        int? nzzze_(CqlInterval<CqlDateTime> LTCPeriods)
        {
            CqlDateTime nzzzi_ = context.Operators.Start(LTCPeriods);
            CqlDateTime nzzzj_ = context.Operators.End(LTCPeriods);
            int? nzzzk_ = context.Operators.DurationBetween(nzzzi_, nzzzj_, "day");

            return nzzzk_;
        };
        IEnumerable<int?> nzzzf_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(nzzzd_, nzzze_);
        IEnumerable<int?> nzzzg_ = context.Operators.Distinct<int?>(nzzzf_);
        int? nzzzh_ = context.Operators.Max<int?>(nzzzg_);

        return nzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet nzzzl_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> nzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? nzzzn_(Encounter AcuteInpatient)
        {
            Code<Encounter.EncounterStatus> nzzzr_ = AcuteInpatient?.StatusElement;
            string nzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzr_);
            bool? nzzzt_ = context.Operators.Equal(nzzzs_, "finished");

            return nzzzt_;
        };
        IEnumerable<Encounter> nzzzo_ = context.Operators.Where<Encounter>(nzzzm_, nzzzn_);
        IEnumerable<Encounter> nzzzp_(Encounter InpatientEncounter)
        {
            CqlValueSet nzzzu_ = this.Advanced_Illness(context);
            IEnumerable<Condition> nzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? nzzzw_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> ozzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? ozzzb_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, ozzza_);
                Period ozzzc_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzc_ as object);
                CqlDateTime ozzze_ = context.Operators.Start(ozzzd_);
                CqlInterval<CqlDateTime> ozzzf_ = this.Measurement_Period(context);
                CqlDateTime ozzzg_ = context.Operators.End(ozzzf_);
                CqlQuantity ozzzh_ = context.Operators.Quantity(2m, "years");
                CqlDateTime ozzzi_ = context.Operators.Subtract(ozzzg_, ozzzh_);
                CqlDateTime ozzzk_ = context.Operators.End(ozzzf_);
                CqlInterval<CqlDateTime> ozzzl_ = context.Operators.Interval(ozzzi_, ozzzk_, true, true);
                bool? ozzzm_ = context.Operators.In<CqlDateTime>(ozzze_, ozzzl_, default);
                CqlDateTime ozzzo_ = context.Operators.End(ozzzf_);
                bool? ozzzp_ = context.Operators.Not((bool?)(ozzzo_ is null));
                bool? ozzzq_ = context.Operators.And(ozzzm_, ozzzp_);
                bool? ozzzr_ = context.Operators.And(ozzzb_, ozzzq_);

                return ozzzr_;
            };
            IEnumerable<Condition> nzzzx_ = context.Operators.Where<Condition>(nzzzv_, nzzzw_);
            Encounter nzzzy_(Condition AdvancedIllnessDiagnosis) =>
                InpatientEncounter;
            IEnumerable<Encounter> nzzzz_ = context.Operators.Select<Condition, Encounter>(nzzzx_, nzzzy_);

            return nzzzz_;
        };
        IEnumerable<Encounter> nzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzo_, nzzzp_);

        return nzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet ozzzs_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> ozzzt_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzs_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> ozzzv_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzs_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> ozzzw_ = context.Operators.Union<DeviceRequest>(ozzzt_, ozzzv_);
        bool? ozzzx_(DeviceRequest FrailtyDeviceOrder)
        {
            Code<RequestStatus> pzzzy_ = FrailtyDeviceOrder?.StatusElement;
            string pzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzy_);
            string[] qzzza_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? qzzzb_ = context.Operators.In<string>(pzzzz_, qzzza_ as IEnumerable<string>);
            Code<RequestIntent> qzzzc_ = FrailtyDeviceOrder?.IntentElement;
            string qzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzc_);
            bool? qzzze_ = context.Operators.Equal(qzzzd_, "order");
            bool? qzzzf_ = context.Operators.And(qzzzb_, qzzze_);
            CqlInterval<CqlDateTime> qzzzg_ = this.Measurement_Period(context);
            FhirDateTime qzzzh_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> qzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzh_ as object);
            bool? qzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzg_, qzzzi_, default);
            bool? qzzzk_ = context.Operators.And(qzzzf_, qzzzj_);

            return qzzzk_;
        };
        IEnumerable<DeviceRequest> ozzzy_ = context.Operators.Where<DeviceRequest>(ozzzw_, ozzzx_);
        bool? ozzzz_ = context.Operators.Exists<DeviceRequest>(ozzzy_);
        IEnumerable<Observation> pzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzc_(Observation FrailtyDeviceApplied)
        {
            Code<ObservationStatus> qzzzl_ = FrailtyDeviceApplied?.StatusElement;
            string qzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzl_);
            string[] qzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzo_ = context.Operators.In<string>(qzzzm_, qzzzn_ as IEnumerable<string>);
            DataType qzzzp_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> qzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzp_);
            CqlInterval<CqlDateTime> qzzzr_ = this.Measurement_Period(context);
            bool? qzzzs_ = context.Operators.Overlaps(qzzzq_, qzzzr_, default);
            bool? qzzzt_ = context.Operators.And(qzzzo_, qzzzs_);

            return qzzzt_;
        };
        IEnumerable<Observation> pzzzd_ = context.Operators.Where<Observation>(pzzzb_, pzzzc_);
        bool? pzzze_ = context.Operators.Exists<Observation>(pzzzd_);
        bool? pzzzf_ = context.Operators.Or(ozzzz_, pzzze_);
        CqlValueSet pzzzg_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> pzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzzzi_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> qzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> qzzzv_ = this.Measurement_Period(context);
            bool? qzzzw_ = context.Operators.Overlaps(qzzzu_, qzzzv_, default);

            return qzzzw_;
        };
        IEnumerable<Condition> pzzzj_ = context.Operators.Where<Condition>(pzzzh_, pzzzi_);
        bool? pzzzk_ = context.Operators.Exists<Condition>(pzzzj_);
        bool? pzzzl_ = context.Operators.Or(pzzzf_, pzzzk_);
        CqlValueSet pzzzm_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> pzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? pzzzo_(Encounter FrailtyEncounter)
        {
            Code<Encounter.EncounterStatus> qzzzx_ = FrailtyEncounter?.StatusElement;
            string qzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzx_);
            bool? qzzzz_ = context.Operators.Equal(qzzzy_, "finished");
            Period rzzza_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzza_ as object);
            CqlInterval<CqlDateTime> rzzzc_ = this.Measurement_Period(context);
            bool? rzzzd_ = context.Operators.Overlaps(rzzzb_, rzzzc_, default);
            bool? rzzze_ = context.Operators.And(qzzzz_, rzzzd_);

            return rzzze_;
        };
        IEnumerable<Encounter> pzzzp_ = context.Operators.Where<Encounter>(pzzzn_, pzzzo_);
        bool? pzzzq_ = context.Operators.Exists<Encounter>(pzzzp_);
        bool? pzzzr_ = context.Operators.Or(pzzzl_, pzzzq_);
        CqlValueSet pzzzs_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> pzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzu_(Observation FrailtySymptom)
        {
            Code<ObservationStatus> rzzzf_ = FrailtySymptom?.StatusElement;
            string rzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzf_);
            string[] rzzzh_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzi_ = context.Operators.In<string>(rzzzg_, rzzzh_ as IEnumerable<string>);
            DataType rzzzj_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> rzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzj_);
            CqlInterval<CqlDateTime> rzzzl_ = this.Measurement_Period(context);
            bool? rzzzm_ = context.Operators.Overlaps(rzzzk_, rzzzl_, default);
            bool? rzzzn_ = context.Operators.And(rzzzi_, rzzzm_);

            return rzzzn_;
        };
        IEnumerable<Observation> pzzzv_ = context.Operators.Where<Observation>(pzzzt_, pzzzu_);
        bool? pzzzw_ = context.Operators.Exists<Observation>(pzzzv_);
        bool? pzzzx_ = context.Operators.Or(pzzzr_, pzzzw_);

        return pzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient rzzzo_ = this.Patient(context);
        Date rzzzp_ = rzzzo_?.BirthDateElement;
        string rzzzq_ = rzzzp_?.Value;
        CqlDate rzzzr_ = context.Operators.ConvertStringToDate(rzzzq_);
        CqlInterval<CqlDateTime> rzzzs_ = this.Measurement_Period(context);
        CqlDateTime rzzzt_ = context.Operators.Start(rzzzs_);
        CqlDate rzzzu_ = context.Operators.DateFrom(rzzzt_);
        int? rzzzv_ = context.Operators.CalculateAgeAt(rzzzr_, rzzzu_, "year");
        CqlInterval<int?> rzzzw_ = context.Operators.Interval(65, 79, true, true);
        bool? rzzzx_ = context.Operators.In<int?>(rzzzv_, rzzzw_, default);
        bool? rzzzy_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? rzzzz_ = context.Operators.And(rzzzx_, rzzzy_);
        IEnumerable<Encounter> szzza_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? szzzb_ = context.Operators.Exists<Encounter>(szzza_);
        IEnumerable<Encounter> szzzc_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? szzzd_ = context.Operators.Exists<Encounter>(szzzc_);
        bool? szzze_ = context.Operators.Or(szzzb_, szzzd_);
        IEnumerable<MedicationRequest> szzzf_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? szzzg_ = context.Operators.Exists<MedicationRequest>(szzzf_);
        bool? szzzh_ = context.Operators.Or(szzze_, szzzg_);
        bool? szzzi_ = context.Operators.And(rzzzz_, szzzh_);
        Date szzzk_ = rzzzo_?.BirthDateElement;
        string szzzl_ = szzzk_?.Value;
        CqlDate szzzm_ = context.Operators.ConvertStringToDate(szzzl_);
        CqlDateTime szzzo_ = context.Operators.Start(rzzzs_);
        CqlDate szzzp_ = context.Operators.DateFrom(szzzo_);
        int? szzzq_ = context.Operators.CalculateAgeAt(szzzm_, szzzp_, "year");
        bool? szzzr_ = context.Operators.GreaterOrEqual(szzzq_, 80);
        bool? szzzt_ = context.Operators.And(szzzr_, rzzzy_);
        bool? szzzu_ = context.Operators.Or(szzzi_, szzzt_);

        return szzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient szzzv_ = this.Patient(context);
        Date szzzw_ = szzzv_?.BirthDateElement;
        string szzzx_ = szzzw_?.Value;
        CqlDate szzzy_ = context.Operators.ConvertStringToDate(szzzx_);
        CqlInterval<CqlDateTime> szzzz_ = this.Measurement_Period(context);
        CqlDateTime tzzza_ = context.Operators.Start(szzzz_);
        CqlDate tzzzb_ = context.Operators.DateFrom(tzzza_);
        int? tzzzc_ = context.Operators.CalculateAgeAt(szzzy_, tzzzb_, "year");
        bool? tzzzd_ = context.Operators.GreaterOrEqual(tzzzc_, 65);
        bool? tzzze_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? tzzzf_ = context.Operators.And(tzzzd_, tzzze_);
        IEnumerable<Encounter> tzzzg_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? tzzzh_ = context.Operators.Exists<Encounter>(tzzzg_);
        IEnumerable<Encounter> tzzzi_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? tzzzj_ = context.Operators.Exists<Encounter>(tzzzi_);
        bool? tzzzk_ = context.Operators.Or(tzzzh_, tzzzj_);
        IEnumerable<MedicationRequest> tzzzl_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? tzzzm_ = context.Operators.Exists<MedicationRequest>(tzzzl_);
        bool? tzzzn_ = context.Operators.Or(tzzzk_, tzzzm_);
        bool? tzzzo_ = context.Operators.And(tzzzf_, tzzzn_);

        return tzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
    {
        int? tzzzp_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? tzzzq_ = context.Operators.Greater(tzzzp_, 90);

        return tzzzq_;
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
