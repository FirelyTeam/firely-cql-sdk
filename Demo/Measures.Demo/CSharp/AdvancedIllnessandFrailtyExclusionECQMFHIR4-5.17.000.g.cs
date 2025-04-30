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
        object dzzzzc_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)dzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient dzzzze_ = context.Operators.SingletonFrom<Patient>(dzzzzd_);

        return dzzzze_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet dzzzzf_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> dzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> dzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> dzzzzj_ = context.Operators.Union<MedicationRequest>(dzzzzg_, dzzzzi_);
        bool? dzzzzk_(MedicationRequest DementiaMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> dzzzzm_ = DementiaMed?.StatusElement;
            string dzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzm_);
            bool? dzzzzo_ = context.Operators.Equal(dzzzzn_, "active");
            Code<MedicationRequest.MedicationRequestIntent> dzzzzp_ = DementiaMed?.IntentElement;
            string dzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzp_);
            bool? dzzzzr_ = context.Operators.Equal(dzzzzq_, "order");
            bool? dzzzzs_ = context.Operators.And(dzzzzo_, dzzzzr_);
            CqlInterval<CqlDateTime> dzzzzt_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
            CqlInterval<CqlDateTime> dzzzzu_ = this.Measurement_Period(context);
            CqlDateTime dzzzzv_ = context.Operators.Start(dzzzzu_);
            CqlQuantity dzzzzw_ = context.Operators.Quantity(1m, "year");
            CqlDateTime dzzzzx_ = context.Operators.Subtract(dzzzzv_, dzzzzw_);
            CqlDateTime dzzzzz_ = context.Operators.End(dzzzzu_);
            CqlInterval<CqlDateTime> ezzzza_ = context.Operators.Interval(dzzzzx_, dzzzzz_, true, true);
            bool? ezzzzb_ = context.Operators.Overlaps(dzzzzt_, ezzzza_, default);
            bool? ezzzzc_ = context.Operators.And(dzzzzs_, ezzzzb_);

            return ezzzzc_;
        };
        IEnumerable<MedicationRequest> dzzzzl_ = context.Operators.Where<MedicationRequest>(dzzzzj_, dzzzzk_);

        return dzzzzl_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzd_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> ezzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ezzzzf_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> ezzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ezzzzh_ = context.Operators.Union<Encounter>(ezzzze_, ezzzzg_);
        bool? ezzzzi_(Encounter LongTermFacilityEncounter)
        {
            Code<Encounter.EncounterStatus> ezzzzn_ = LongTermFacilityEncounter?.StatusElement;
            string ezzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzn_);
            bool? ezzzzp_ = context.Operators.Equal(ezzzzo_, "finished");
            Period ezzzzq_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzq_ as object);
            CqlInterval<CqlDateTime> ezzzzs_ = this.Measurement_Period(context);
            bool? ezzzzt_ = context.Operators.Overlaps(ezzzzr_, ezzzzs_, default);
            bool? ezzzzu_ = context.Operators.And(ezzzzp_, ezzzzt_);

            return ezzzzu_;
        };
        IEnumerable<Encounter> ezzzzj_ = context.Operators.Where<Encounter>(ezzzzh_, ezzzzi_);
        CqlInterval<CqlDateTime> ezzzzk_(Encounter LongTermFacilityEncounter)
        {
            Period ezzzzv_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzv_ as object);
            CqlInterval<CqlDateTime> ezzzzx_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> ezzzzy_ = context.Operators.Intersect<CqlDateTime>(ezzzzw_, ezzzzx_);

            return ezzzzy_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzl_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(ezzzzj_, ezzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzm_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzl_);

        return ezzzzm_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet ezzzzz_ = this.Outpatient(context);
        IEnumerable<Encounter> fzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet fzzzzb_ = this.Observation(context);
        IEnumerable<Encounter> fzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> fzzzzd_ = context.Operators.Union<Encounter>(fzzzza_, fzzzzc_);
        CqlValueSet fzzzze_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> fzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet fzzzzg_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> fzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> fzzzzi_ = context.Operators.Union<Encounter>(fzzzzf_, fzzzzh_);
        IEnumerable<Encounter> fzzzzj_ = context.Operators.Union<Encounter>(fzzzzd_, fzzzzi_);
        bool? fzzzzk_(Encounter Outpatient)
        {
            Code<Encounter.EncounterStatus> fzzzzo_ = Outpatient?.StatusElement;
            string fzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzo_);
            bool? fzzzzq_ = context.Operators.Equal(fzzzzp_, "finished");

            return fzzzzq_;
        };
        IEnumerable<Encounter> fzzzzl_ = context.Operators.Where<Encounter>(fzzzzj_, fzzzzk_);
        IEnumerable<Encounter> fzzzzm_(Encounter OutpatientEncounter)
        {
            CqlValueSet fzzzzr_ = this.Advanced_Illness(context);
            IEnumerable<Condition> fzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? fzzzzt_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> fzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? fzzzzy_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, fzzzzx_);
                Period fzzzzz_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzz_ as object);
                CqlDateTime gzzzzb_ = context.Operators.Start(gzzzza_);
                CqlInterval<CqlDateTime> gzzzzc_ = this.Measurement_Period(context);
                CqlDateTime gzzzzd_ = context.Operators.End(gzzzzc_);
                CqlQuantity gzzzze_ = context.Operators.Quantity(2m, "years");
                CqlDateTime gzzzzf_ = context.Operators.Subtract(gzzzzd_, gzzzze_);
                CqlDateTime gzzzzh_ = context.Operators.End(gzzzzc_);
                CqlInterval<CqlDateTime> gzzzzi_ = context.Operators.Interval(gzzzzf_, gzzzzh_, true, true);
                bool? gzzzzj_ = context.Operators.In<CqlDateTime>(gzzzzb_, gzzzzi_, default);
                CqlDateTime gzzzzl_ = context.Operators.End(gzzzzc_);
                bool? gzzzzm_ = context.Operators.Not((bool?)(gzzzzl_ is null));
                bool? gzzzzn_ = context.Operators.And(gzzzzj_, gzzzzm_);
                bool? gzzzzo_ = context.Operators.And(fzzzzy_, gzzzzn_);

                return gzzzzo_;
            };
            IEnumerable<Condition> fzzzzu_ = context.Operators.Where<Condition>(fzzzzs_, fzzzzt_);
            Encounter fzzzzv_(Condition AdvancedIllnessDiagnosis) =>
                OutpatientEncounter;
            IEnumerable<Encounter> fzzzzw_ = context.Operators.Select<Condition, Encounter>(fzzzzu_, fzzzzv_);

            return fzzzzw_;
        };
        IEnumerable<Encounter> fzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzl_, fzzzzm_);

        return fzzzzn_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzp_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> gzzzzr_ = context.Operators.CrossJoin<Encounter, Encounter>(gzzzzp_, gzzzzp_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? gzzzzs_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? gzzzzz_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return gzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> gzzzzt_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(gzzzzr_, gzzzzs_);
        bool? gzzzzu_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period hzzzza_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> hzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzza_);
            CqlDateTime hzzzzc_ = context.Operators.End(hzzzzb_);
            Period hzzzzd_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> hzzzze_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzd_);
            CqlDateTime hzzzzf_ = context.Operators.End(hzzzze_);
            CqlQuantity hzzzzg_ = context.Operators.Quantity(1m, "day");
            CqlDateTime hzzzzh_ = context.Operators.Add(hzzzzf_, hzzzzg_);
            bool? hzzzzi_ = context.Operators.SameOrAfter(hzzzzc_, hzzzzh_, "day");

            return hzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> gzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(gzzzzt_, gzzzzu_);
        Encounter gzzzzw_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> gzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(gzzzzv_, gzzzzw_);
        IEnumerable<Encounter> gzzzzy_ = context.Operators.Distinct<Encounter>(gzzzzx_);

        return gzzzzy_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzj_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzk_ = context.Operators.Collapse(hzzzzj_, default);

        return hzzzzk_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzl_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> hzzzzn_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(hzzzzl_, hzzzzl_);
        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? hzzzzo_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? hzzzzv_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> hzzzzp_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(hzzzzn_, hzzzzo_);
        bool? hzzzzq_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime hzzzzw_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime hzzzzx_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity hzzzzy_ = context.Operators.Quantity(1m, "day");
            CqlDateTime hzzzzz_ = context.Operators.Subtract(hzzzzx_, hzzzzy_);
            CqlDateTime izzzzc_ = context.Operators.Add(hzzzzx_, hzzzzy_);
            CqlInterval<CqlDateTime> izzzzd_ = context.Operators.Interval(hzzzzz_, izzzzc_, true, true);
            bool? izzzze_ = context.Operators.In<CqlDateTime>(hzzzzw_, izzzzd_, default);
            bool? izzzzg_ = context.Operators.Not((bool?)(hzzzzx_ is null));
            bool? izzzzh_ = context.Operators.And(izzzze_, izzzzg_);

            return izzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> hzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(hzzzzp_, hzzzzq_);
        CqlInterval<CqlDateTime> hzzzzs_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime izzzzi_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime izzzzj_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> izzzzk_ = context.Operators.Interval(izzzzi_, izzzzj_, true, true);

            return izzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(hzzzzr_, hzzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzt_);

        return hzzzzu_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> izzzzl_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> izzzzm_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> izzzzn_ = context.Operators.Union<CqlInterval<CqlDateTime>>(izzzzl_, izzzzm_);
        IEnumerable<CqlInterval<CqlDateTime>> izzzzo_ = context.Operators.Collapse(izzzzn_, default);
        int? izzzzp_(CqlInterval<CqlDateTime> LTCPeriods)
        {
            CqlDateTime izzzzt_ = context.Operators.Start(LTCPeriods);
            CqlDateTime izzzzu_ = context.Operators.End(LTCPeriods);
            int? izzzzv_ = context.Operators.DurationBetween(izzzzt_, izzzzu_, "day");

            return izzzzv_;
        };
        IEnumerable<int?> izzzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(izzzzo_, izzzzp_);
        IEnumerable<int?> izzzzr_ = context.Operators.Distinct<int?>(izzzzq_);
        int? izzzzs_ = context.Operators.Max<int?>(izzzzr_);

        return izzzzs_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet izzzzw_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> izzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? izzzzy_(Encounter AcuteInpatient)
        {
            Code<Encounter.EncounterStatus> jzzzzc_ = AcuteInpatient?.StatusElement;
            string jzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzc_);
            bool? jzzzze_ = context.Operators.Equal(jzzzzd_, "finished");

            return jzzzze_;
        };
        IEnumerable<Encounter> izzzzz_ = context.Operators.Where<Encounter>(izzzzx_, izzzzy_);
        IEnumerable<Encounter> jzzzza_(Encounter InpatientEncounter)
        {
            CqlValueSet jzzzzf_ = this.Advanced_Illness(context);
            IEnumerable<Condition> jzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? jzzzzh_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> jzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? jzzzzm_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, jzzzzl_);
                Period jzzzzn_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzn_ as object);
                CqlDateTime jzzzzp_ = context.Operators.Start(jzzzzo_);
                CqlInterval<CqlDateTime> jzzzzq_ = this.Measurement_Period(context);
                CqlDateTime jzzzzr_ = context.Operators.End(jzzzzq_);
                CqlQuantity jzzzzs_ = context.Operators.Quantity(2m, "years");
                CqlDateTime jzzzzt_ = context.Operators.Subtract(jzzzzr_, jzzzzs_);
                CqlDateTime jzzzzv_ = context.Operators.End(jzzzzq_);
                CqlInterval<CqlDateTime> jzzzzw_ = context.Operators.Interval(jzzzzt_, jzzzzv_, true, true);
                bool? jzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzp_, jzzzzw_, default);
                CqlDateTime jzzzzz_ = context.Operators.End(jzzzzq_);
                bool? kzzzza_ = context.Operators.Not((bool?)(jzzzzz_ is null));
                bool? kzzzzb_ = context.Operators.And(jzzzzx_, kzzzza_);
                bool? kzzzzc_ = context.Operators.And(jzzzzm_, kzzzzb_);

                return kzzzzc_;
            };
            IEnumerable<Condition> jzzzzi_ = context.Operators.Where<Condition>(jzzzzg_, jzzzzh_);
            Encounter jzzzzj_(Condition AdvancedIllnessDiagnosis) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzk_ = context.Operators.Select<Condition, Encounter>(jzzzzi_, jzzzzj_);

            return jzzzzk_;
        };
        IEnumerable<Encounter> jzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzz_, jzzzza_);

        return jzzzzb_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet kzzzzd_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> kzzzze_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, kzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> kzzzzg_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, kzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> kzzzzh_ = context.Operators.Union<DeviceRequest>(kzzzze_, kzzzzg_);
        bool? kzzzzi_(DeviceRequest FrailtyDeviceOrder)
        {
            Code<RequestStatus> lzzzzj_ = FrailtyDeviceOrder?.StatusElement;
            string lzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzj_);
            string[] lzzzzl_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? lzzzzm_ = context.Operators.In<string>(lzzzzk_, lzzzzl_ as IEnumerable<string>);
            Code<RequestIntent> lzzzzn_ = FrailtyDeviceOrder?.IntentElement;
            string lzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzn_);
            bool? lzzzzp_ = context.Operators.Equal(lzzzzo_, "order");
            bool? lzzzzq_ = context.Operators.And(lzzzzm_, lzzzzp_);
            CqlInterval<CqlDateTime> lzzzzr_ = this.Measurement_Period(context);
            FhirDateTime lzzzzs_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> lzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzs_ as object);
            bool? lzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzr_, lzzzzt_, default);
            bool? lzzzzv_ = context.Operators.And(lzzzzq_, lzzzzu_);

            return lzzzzv_;
        };
        IEnumerable<DeviceRequest> kzzzzj_ = context.Operators.Where<DeviceRequest>(kzzzzh_, kzzzzi_);
        bool? kzzzzk_ = context.Operators.Exists<DeviceRequest>(kzzzzj_);
        IEnumerable<Observation> kzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzn_(Observation FrailtyDeviceApplied)
        {
            Code<ObservationStatus> lzzzzw_ = FrailtyDeviceApplied?.StatusElement;
            string lzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzw_);
            string[] lzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzz_ = context.Operators.In<string>(lzzzzx_, lzzzzy_ as IEnumerable<string>);
            DataType mzzzza_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> mzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzza_);
            CqlInterval<CqlDateTime> mzzzzc_ = this.Measurement_Period(context);
            bool? mzzzzd_ = context.Operators.Overlaps(mzzzzb_, mzzzzc_, default);
            bool? mzzzze_ = context.Operators.And(lzzzzz_, mzzzzd_);

            return mzzzze_;
        };
        IEnumerable<Observation> kzzzzo_ = context.Operators.Where<Observation>(kzzzzm_, kzzzzn_);
        bool? kzzzzp_ = context.Operators.Exists<Observation>(kzzzzo_);
        bool? kzzzzq_ = context.Operators.Or(kzzzzk_, kzzzzp_);
        CqlValueSet kzzzzr_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> kzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? kzzzzt_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> mzzzzg_ = this.Measurement_Period(context);
            bool? mzzzzh_ = context.Operators.Overlaps(mzzzzf_, mzzzzg_, default);

            return mzzzzh_;
        };
        IEnumerable<Condition> kzzzzu_ = context.Operators.Where<Condition>(kzzzzs_, kzzzzt_);
        bool? kzzzzv_ = context.Operators.Exists<Condition>(kzzzzu_);
        bool? kzzzzw_ = context.Operators.Or(kzzzzq_, kzzzzv_);
        CqlValueSet kzzzzx_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> kzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? kzzzzz_(Encounter FrailtyEncounter)
        {
            Code<Encounter.EncounterStatus> mzzzzi_ = FrailtyEncounter?.StatusElement;
            string mzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzi_);
            bool? mzzzzk_ = context.Operators.Equal(mzzzzj_, "finished");
            Period mzzzzl_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzl_ as object);
            CqlInterval<CqlDateTime> mzzzzn_ = this.Measurement_Period(context);
            bool? mzzzzo_ = context.Operators.Overlaps(mzzzzm_, mzzzzn_, default);
            bool? mzzzzp_ = context.Operators.And(mzzzzk_, mzzzzo_);

            return mzzzzp_;
        };
        IEnumerable<Encounter> lzzzza_ = context.Operators.Where<Encounter>(kzzzzy_, kzzzzz_);
        bool? lzzzzb_ = context.Operators.Exists<Encounter>(lzzzza_);
        bool? lzzzzc_ = context.Operators.Or(kzzzzw_, lzzzzb_);
        CqlValueSet lzzzzd_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> lzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzzzf_(Observation FrailtySymptom)
        {
            Code<ObservationStatus> mzzzzq_ = FrailtySymptom?.StatusElement;
            string mzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzq_);
            string[] mzzzzs_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzt_ = context.Operators.In<string>(mzzzzr_, mzzzzs_ as IEnumerable<string>);
            DataType mzzzzu_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> mzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzu_);
            CqlInterval<CqlDateTime> mzzzzw_ = this.Measurement_Period(context);
            bool? mzzzzx_ = context.Operators.Overlaps(mzzzzv_, mzzzzw_, default);
            bool? mzzzzy_ = context.Operators.And(mzzzzt_, mzzzzx_);

            return mzzzzy_;
        };
        IEnumerable<Observation> lzzzzg_ = context.Operators.Where<Observation>(lzzzze_, lzzzzf_);
        bool? lzzzzh_ = context.Operators.Exists<Observation>(lzzzzg_);
        bool? lzzzzi_ = context.Operators.Or(lzzzzc_, lzzzzh_);

        return lzzzzi_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient mzzzzz_ = this.Patient(context);
        Date nzzzza_ = mzzzzz_?.BirthDateElement;
        string nzzzzb_ = nzzzza_?.Value;
        CqlDate nzzzzc_ = context.Operators.ConvertStringToDate(nzzzzb_);
        CqlInterval<CqlDateTime> nzzzzd_ = this.Measurement_Period(context);
        CqlDateTime nzzzze_ = context.Operators.Start(nzzzzd_);
        CqlDate nzzzzf_ = context.Operators.DateFrom(nzzzze_);
        int? nzzzzg_ = context.Operators.CalculateAgeAt(nzzzzc_, nzzzzf_, "year");
        CqlInterval<int?> nzzzzh_ = context.Operators.Interval(65, 79, true, true);
        bool? nzzzzi_ = context.Operators.In<int?>(nzzzzg_, nzzzzh_, default);
        bool? nzzzzj_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? nzzzzk_ = context.Operators.And(nzzzzi_, nzzzzj_);
        IEnumerable<Encounter> nzzzzl_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? nzzzzm_ = context.Operators.Exists<Encounter>(nzzzzl_);
        IEnumerable<Encounter> nzzzzn_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? nzzzzo_ = context.Operators.Exists<Encounter>(nzzzzn_);
        bool? nzzzzp_ = context.Operators.Or(nzzzzm_, nzzzzo_);
        IEnumerable<MedicationRequest> nzzzzq_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? nzzzzr_ = context.Operators.Exists<MedicationRequest>(nzzzzq_);
        bool? nzzzzs_ = context.Operators.Or(nzzzzp_, nzzzzr_);
        bool? nzzzzt_ = context.Operators.And(nzzzzk_, nzzzzs_);
        Date nzzzzv_ = mzzzzz_?.BirthDateElement;
        string nzzzzw_ = nzzzzv_?.Value;
        CqlDate nzzzzx_ = context.Operators.ConvertStringToDate(nzzzzw_);
        CqlDateTime nzzzzz_ = context.Operators.Start(nzzzzd_);
        CqlDate ozzzza_ = context.Operators.DateFrom(nzzzzz_);
        int? ozzzzb_ = context.Operators.CalculateAgeAt(nzzzzx_, ozzzza_, "year");
        bool? ozzzzc_ = context.Operators.GreaterOrEqual(ozzzzb_, 80);
        bool? ozzzze_ = context.Operators.And(ozzzzc_, nzzzzj_);
        bool? ozzzzf_ = context.Operators.Or(nzzzzt_, ozzzze_);

        return ozzzzf_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient ozzzzg_ = this.Patient(context);
        Date ozzzzh_ = ozzzzg_?.BirthDateElement;
        string ozzzzi_ = ozzzzh_?.Value;
        CqlDate ozzzzj_ = context.Operators.ConvertStringToDate(ozzzzi_);
        CqlInterval<CqlDateTime> ozzzzk_ = this.Measurement_Period(context);
        CqlDateTime ozzzzl_ = context.Operators.Start(ozzzzk_);
        CqlDate ozzzzm_ = context.Operators.DateFrom(ozzzzl_);
        int? ozzzzn_ = context.Operators.CalculateAgeAt(ozzzzj_, ozzzzm_, "year");
        bool? ozzzzo_ = context.Operators.GreaterOrEqual(ozzzzn_, 65);
        bool? ozzzzp_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? ozzzzq_ = context.Operators.And(ozzzzo_, ozzzzp_);
        IEnumerable<Encounter> ozzzzr_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? ozzzzs_ = context.Operators.Exists<Encounter>(ozzzzr_);
        IEnumerable<Encounter> ozzzzt_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? ozzzzu_ = context.Operators.Exists<Encounter>(ozzzzt_);
        bool? ozzzzv_ = context.Operators.Or(ozzzzs_, ozzzzu_);
        IEnumerable<MedicationRequest> ozzzzw_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? ozzzzx_ = context.Operators.Exists<MedicationRequest>(ozzzzw_);
        bool? ozzzzy_ = context.Operators.Or(ozzzzv_, ozzzzx_);
        bool? ozzzzz_ = context.Operators.And(ozzzzq_, ozzzzy_);

        return ozzzzz_;
    }


    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
    {
        int? pzzzza_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? pzzzzb_ = context.Operators.Greater(pzzzza_, 90);

        return pzzzzb_;
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
