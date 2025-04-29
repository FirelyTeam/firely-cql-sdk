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
        object rzzza_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzc_ = context.Operators.SingletonFrom<Patient>(rzzzb_);

        return rzzzc_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzd_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> rzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> rzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzd_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> rzzzh_ = context.Operators.Union<MedicationRequest>(rzzze_, rzzzg_);
        bool? rzzzi_(MedicationRequest DementiaMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> rzzzk_ = DementiaMed?.StatusElement;
            string rzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzk_);
            bool? rzzzm_ = context.Operators.Equal(rzzzl_, "active");
            Code<MedicationRequest.MedicationRequestIntent> rzzzn_ = DementiaMed?.IntentElement;
            string rzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzn_);
            bool? rzzzp_ = context.Operators.Equal(rzzzo_, "order");
            bool? rzzzq_ = context.Operators.And(rzzzm_, rzzzp_);
            CqlInterval<CqlDateTime> rzzzr_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
            CqlInterval<CqlDateTime> rzzzs_ = this.Measurement_Period(context);
            CqlDateTime rzzzt_ = context.Operators.Start(rzzzs_);
            CqlQuantity rzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDateTime rzzzv_ = context.Operators.Subtract(rzzzt_, rzzzu_);
            CqlDateTime rzzzx_ = context.Operators.End(rzzzs_);
            CqlInterval<CqlDateTime> rzzzy_ = context.Operators.Interval(rzzzv_, rzzzx_, true, true);
            bool? rzzzz_ = context.Operators.Overlaps(rzzzr_, rzzzy_, default);
            bool? szzza_ = context.Operators.And(rzzzq_, rzzzz_);

            return szzza_;
        };
        IEnumerable<MedicationRequest> rzzzj_ = context.Operators.Where<MedicationRequest>(rzzzh_, rzzzi_);

        return rzzzj_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzb_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> szzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet szzzd_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> szzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> szzzf_ = context.Operators.Union<Encounter>(szzzc_, szzze_);
        bool? szzzg_(Encounter LongTermFacilityEncounter)
        {
            Code<Encounter.EncounterStatus> szzzl_ = LongTermFacilityEncounter?.StatusElement;
            string szzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzl_);
            bool? szzzn_ = context.Operators.Equal(szzzm_, "finished");
            Period szzzo_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> szzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzo_ as object);
            CqlInterval<CqlDateTime> szzzq_ = this.Measurement_Period(context);
            bool? szzzr_ = context.Operators.Overlaps(szzzp_, szzzq_, default);
            bool? szzzs_ = context.Operators.And(szzzn_, szzzr_);

            return szzzs_;
        };
        IEnumerable<Encounter> szzzh_ = context.Operators.Where<Encounter>(szzzf_, szzzg_);
        CqlInterval<CqlDateTime> szzzi_(Encounter LongTermFacilityEncounter)
        {
            Period szzzt_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> szzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzt_ as object);
            CqlInterval<CqlDateTime> szzzv_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> szzzw_ = context.Operators.Intersect<CqlDateTime>(szzzu_, szzzv_);

            return szzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzzj_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(szzzh_, szzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> szzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzzj_);

        return szzzk_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet szzzx_ = this.Outpatient(context);
        IEnumerable<Encounter> szzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet szzzz_ = this.Observation(context);
        IEnumerable<Encounter> tzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> tzzzb_ = context.Operators.Union<Encounter>(szzzy_, tzzza_);
        CqlValueSet tzzzc_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> tzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet tzzze_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> tzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> tzzzg_ = context.Operators.Union<Encounter>(tzzzd_, tzzzf_);
        IEnumerable<Encounter> tzzzh_ = context.Operators.Union<Encounter>(tzzzb_, tzzzg_);
        bool? tzzzi_(Encounter Outpatient)
        {
            Code<Encounter.EncounterStatus> tzzzm_ = Outpatient?.StatusElement;
            string tzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzm_);
            bool? tzzzo_ = context.Operators.Equal(tzzzn_, "finished");

            return tzzzo_;
        };
        IEnumerable<Encounter> tzzzj_ = context.Operators.Where<Encounter>(tzzzh_, tzzzi_);
        IEnumerable<Encounter> tzzzk_(Encounter OutpatientEncounter)
        {
            CqlValueSet tzzzp_ = this.Advanced_Illness(context);
            IEnumerable<Condition> tzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? tzzzr_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> tzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? tzzzw_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, tzzzv_);
                Period tzzzx_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzx_ as object);
                CqlDateTime tzzzz_ = context.Operators.Start(tzzzy_);
                CqlInterval<CqlDateTime> uzzza_ = this.Measurement_Period(context);
                CqlDateTime uzzzb_ = context.Operators.End(uzzza_);
                CqlQuantity uzzzc_ = context.Operators.Quantity(2m, "years");
                CqlDateTime uzzzd_ = context.Operators.Subtract(uzzzb_, uzzzc_);
                CqlDateTime uzzzf_ = context.Operators.End(uzzza_);
                CqlInterval<CqlDateTime> uzzzg_ = context.Operators.Interval(uzzzd_, uzzzf_, true, true);
                bool? uzzzh_ = context.Operators.In<CqlDateTime>(tzzzz_, uzzzg_, default);
                CqlDateTime uzzzj_ = context.Operators.End(uzzza_);
                bool? uzzzk_ = context.Operators.Not((bool?)(uzzzj_ is null));
                bool? uzzzl_ = context.Operators.And(uzzzh_, uzzzk_);
                bool? uzzzm_ = context.Operators.And(tzzzw_, uzzzl_);

                return uzzzm_;
            };
            IEnumerable<Condition> tzzzs_ = context.Operators.Where<Condition>(tzzzq_, tzzzr_);
            Encounter tzzzt_(Condition AdvancedIllnessDiagnosis) =>
                OutpatientEncounter;
            IEnumerable<Encounter> tzzzu_ = context.Operators.Select<Condition, Encounter>(tzzzs_, tzzzt_);

            return tzzzu_;
        };
        IEnumerable<Encounter> tzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzj_, tzzzk_);

        return tzzzl_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context)
    {
        IEnumerable<Encounter> uzzzn_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> uzzzp_ = context.Operators.CrossJoin<Encounter, Encounter>(uzzzn_, uzzzn_);
        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? uzzzq_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? uzzzx_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);

            return uzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> uzzzr_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(uzzzp_, uzzzq_);
        bool? uzzzs_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
        {
            Period uzzzy_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> uzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, uzzzy_);
            CqlDateTime vzzza_ = context.Operators.End(uzzzz_);
            Period vzzzb_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> vzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, vzzzb_);
            CqlDateTime vzzzd_ = context.Operators.End(vzzzc_);
            CqlQuantity vzzze_ = context.Operators.Quantity(1m, "day");
            CqlDateTime vzzzf_ = context.Operators.Add(vzzzd_, vzzze_);
            bool? vzzzg_ = context.Operators.SameOrAfter(vzzza_, vzzzf_, "day");

            return vzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> uzzzt_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(uzzzr_, uzzzs_);
        Encounter uzzzu_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
            tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> uzzzv_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(uzzzt_, uzzzu_);
        IEnumerable<Encounter> uzzzw_ = context.Operators.Distinct<Encounter>(uzzzv_);

        return uzzzw_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> vzzzh_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> vzzzi_ = context.Operators.Collapse(vzzzh_, default);

        return vzzzi_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> vzzzj_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> vzzzl_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(vzzzj_, vzzzj_);
        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? vzzzm_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? vzzzt_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);

            return vzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> vzzzn_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(vzzzl_, vzzzm_);
        bool? vzzzo_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime vzzzu_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime vzzzv_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity vzzzw_ = context.Operators.Quantity(1m, "day");
            CqlDateTime vzzzx_ = context.Operators.Subtract(vzzzv_, vzzzw_);
            CqlDateTime wzzza_ = context.Operators.Add(vzzzv_, vzzzw_);
            CqlInterval<CqlDateTime> wzzzb_ = context.Operators.Interval(vzzzx_, wzzza_, true, true);
            bool? wzzzc_ = context.Operators.In<CqlDateTime>(vzzzu_, wzzzb_, default);
            bool? wzzze_ = context.Operators.Not((bool?)(vzzzv_ is null));
            bool? wzzzf_ = context.Operators.And(wzzzc_, wzzze_);

            return wzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> vzzzp_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(vzzzn_, vzzzo_);
        CqlInterval<CqlDateTime> vzzzq_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
        {
            CqlDateTime wzzzg_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime wzzzh_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> wzzzi_ = context.Operators.Interval(wzzzg_, wzzzh_, true, true);

            return wzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> vzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(vzzzp_, vzzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> vzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzr_);

        return vzzzs_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzj_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzk_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzl_ = context.Operators.Union<CqlInterval<CqlDateTime>>(wzzzj_, wzzzk_);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzm_ = context.Operators.Collapse(wzzzl_, default);
        int? wzzzn_(CqlInterval<CqlDateTime> LTCPeriods)
        {
            CqlDateTime wzzzr_ = context.Operators.Start(LTCPeriods);
            CqlDateTime wzzzs_ = context.Operators.End(LTCPeriods);
            int? wzzzt_ = context.Operators.DurationBetween(wzzzr_, wzzzs_, "day");

            return wzzzt_;
        };
        IEnumerable<int?> wzzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(wzzzm_, wzzzn_);
        IEnumerable<int?> wzzzp_ = context.Operators.Distinct<int?>(wzzzo_);
        int? wzzzq_ = context.Operators.Max<int?>(wzzzp_);

        return wzzzq_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context)
    {
        CqlValueSet wzzzu_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> wzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? wzzzw_(Encounter AcuteInpatient)
        {
            Code<Encounter.EncounterStatus> xzzza_ = AcuteInpatient?.StatusElement;
            string xzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzza_);
            bool? xzzzc_ = context.Operators.Equal(xzzzb_, "finished");

            return xzzzc_;
        };
        IEnumerable<Encounter> wzzzx_ = context.Operators.Where<Encounter>(wzzzv_, wzzzw_);
        IEnumerable<Encounter> wzzzy_(Encounter InpatientEncounter)
        {
            CqlValueSet xzzzd_ = this.Advanced_Illness(context);
            IEnumerable<Condition> xzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? xzzzf_(Condition AdvancedIllnessDiagnosis)
            {
                IEnumerable<Condition> xzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? xzzzk_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, xzzzj_);
                Period xzzzl_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzl_ as object);
                CqlDateTime xzzzn_ = context.Operators.Start(xzzzm_);
                CqlInterval<CqlDateTime> xzzzo_ = this.Measurement_Period(context);
                CqlDateTime xzzzp_ = context.Operators.End(xzzzo_);
                CqlQuantity xzzzq_ = context.Operators.Quantity(2m, "years");
                CqlDateTime xzzzr_ = context.Operators.Subtract(xzzzp_, xzzzq_);
                CqlDateTime xzzzt_ = context.Operators.End(xzzzo_);
                CqlInterval<CqlDateTime> xzzzu_ = context.Operators.Interval(xzzzr_, xzzzt_, true, true);
                bool? xzzzv_ = context.Operators.In<CqlDateTime>(xzzzn_, xzzzu_, default);
                CqlDateTime xzzzx_ = context.Operators.End(xzzzo_);
                bool? xzzzy_ = context.Operators.Not((bool?)(xzzzx_ is null));
                bool? xzzzz_ = context.Operators.And(xzzzv_, xzzzy_);
                bool? yzzza_ = context.Operators.And(xzzzk_, xzzzz_);

                return yzzza_;
            };
            IEnumerable<Condition> xzzzg_ = context.Operators.Where<Condition>(xzzze_, xzzzf_);
            Encounter xzzzh_(Condition AdvancedIllnessDiagnosis) =>
                InpatientEncounter;
            IEnumerable<Encounter> xzzzi_ = context.Operators.Select<Condition, Encounter>(xzzzg_, xzzzh_);

            return xzzzi_;
        };
        IEnumerable<Encounter> wzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzx_, wzzzy_);

        return wzzzz_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet yzzzb_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> yzzzc_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, yzzzb_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> yzzze_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, yzzzb_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> yzzzf_ = context.Operators.Union<DeviceRequest>(yzzzc_, yzzze_);
        bool? yzzzg_(DeviceRequest FrailtyDeviceOrder)
        {
            Code<RequestStatus> zzzzh_ = FrailtyDeviceOrder?.StatusElement;
            string zzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzh_);
            string[] zzzzj_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? zzzzk_ = context.Operators.In<string>(zzzzi_, zzzzj_ as IEnumerable<string>);
            Code<RequestIntent> zzzzl_ = FrailtyDeviceOrder?.IntentElement;
            string zzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzl_);
            bool? zzzzn_ = context.Operators.Equal(zzzzm_, "order");
            bool? zzzzo_ = context.Operators.And(zzzzk_, zzzzn_);
            CqlInterval<CqlDateTime> zzzzp_ = this.Measurement_Period(context);
            FhirDateTime zzzzq_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> zzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzq_ as object);
            bool? zzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzp_, zzzzr_, default);
            bool? zzzzt_ = context.Operators.And(zzzzo_, zzzzs_);

            return zzzzt_;
        };
        IEnumerable<DeviceRequest> yzzzh_ = context.Operators.Where<DeviceRequest>(yzzzf_, yzzzg_);
        bool? yzzzi_ = context.Operators.Exists<DeviceRequest>(yzzzh_);
        IEnumerable<Observation> yzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzl_(Observation FrailtyDeviceApplied)
        {
            Code<ObservationStatus> zzzzu_ = FrailtyDeviceApplied?.StatusElement;
            string zzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzu_);
            string[] zzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? zzzzx_ = context.Operators.In<string>(zzzzv_, zzzzw_ as IEnumerable<string>);
            DataType zzzzy_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> zzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzy_);
            CqlInterval<CqlDateTime> azzzza_ = this.Measurement_Period(context);
            bool? azzzzb_ = context.Operators.Overlaps(zzzzz_, azzzza_, default);
            bool? azzzzc_ = context.Operators.And(zzzzx_, azzzzb_);

            return azzzzc_;
        };
        IEnumerable<Observation> yzzzm_ = context.Operators.Where<Observation>(yzzzk_, yzzzl_);
        bool? yzzzn_ = context.Operators.Exists<Observation>(yzzzm_);
        bool? yzzzo_ = context.Operators.Or(yzzzi_, yzzzn_);
        CqlValueSet yzzzp_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> yzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? yzzzr_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> azzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> azzzze_ = this.Measurement_Period(context);
            bool? azzzzf_ = context.Operators.Overlaps(azzzzd_, azzzze_, default);

            return azzzzf_;
        };
        IEnumerable<Condition> yzzzs_ = context.Operators.Where<Condition>(yzzzq_, yzzzr_);
        bool? yzzzt_ = context.Operators.Exists<Condition>(yzzzs_);
        bool? yzzzu_ = context.Operators.Or(yzzzo_, yzzzt_);
        CqlValueSet yzzzv_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> yzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? yzzzx_(Encounter FrailtyEncounter)
        {
            Code<Encounter.EncounterStatus> azzzzg_ = FrailtyEncounter?.StatusElement;
            string azzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzg_);
            bool? azzzzi_ = context.Operators.Equal(azzzzh_, "finished");
            Period azzzzj_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzj_ as object);
            CqlInterval<CqlDateTime> azzzzl_ = this.Measurement_Period(context);
            bool? azzzzm_ = context.Operators.Overlaps(azzzzk_, azzzzl_, default);
            bool? azzzzn_ = context.Operators.And(azzzzi_, azzzzm_);

            return azzzzn_;
        };
        IEnumerable<Encounter> yzzzy_ = context.Operators.Where<Encounter>(yzzzw_, yzzzx_);
        bool? yzzzz_ = context.Operators.Exists<Encounter>(yzzzy_);
        bool? zzzza_ = context.Operators.Or(yzzzu_, yzzzz_);
        CqlValueSet zzzzb_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> zzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzd_(Observation FrailtySymptom)
        {
            Code<ObservationStatus> azzzzo_ = FrailtySymptom?.StatusElement;
            string azzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzo_);
            string[] azzzzq_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzr_ = context.Operators.In<string>(azzzzp_, azzzzq_ as IEnumerable<string>);
            DataType azzzzs_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> azzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzs_);
            CqlInterval<CqlDateTime> azzzzu_ = this.Measurement_Period(context);
            bool? azzzzv_ = context.Operators.Overlaps(azzzzt_, azzzzu_, default);
            bool? azzzzw_ = context.Operators.And(azzzzr_, azzzzv_);

            return azzzzw_;
        };
        IEnumerable<Observation> zzzze_ = context.Operators.Where<Observation>(zzzzc_, zzzzd_);
        bool? zzzzf_ = context.Operators.Exists<Observation>(zzzze_);
        bool? zzzzg_ = context.Operators.Or(zzzza_, zzzzf_);

        return zzzzg_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context)
    {
        Patient azzzzx_ = this.Patient(context);
        Date azzzzy_ = azzzzx_?.BirthDateElement;
        string azzzzz_ = azzzzy_?.Value;
        CqlDate bzzzza_ = context.Operators.ConvertStringToDate(azzzzz_);
        CqlInterval<CqlDateTime> bzzzzb_ = this.Measurement_Period(context);
        CqlDateTime bzzzzc_ = context.Operators.Start(bzzzzb_);
        CqlDate bzzzzd_ = context.Operators.DateFrom(bzzzzc_);
        int? bzzzze_ = context.Operators.CalculateAgeAt(bzzzza_, bzzzzd_, "year");
        CqlInterval<int?> bzzzzf_ = context.Operators.Interval(65, 79, true, true);
        bool? bzzzzg_ = context.Operators.In<int?>(bzzzze_, bzzzzf_, default);
        bool? bzzzzh_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? bzzzzi_ = context.Operators.And(bzzzzg_, bzzzzh_);
        IEnumerable<Encounter> bzzzzj_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? bzzzzk_ = context.Operators.Exists<Encounter>(bzzzzj_);
        IEnumerable<Encounter> bzzzzl_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? bzzzzm_ = context.Operators.Exists<Encounter>(bzzzzl_);
        bool? bzzzzn_ = context.Operators.Or(bzzzzk_, bzzzzm_);
        IEnumerable<MedicationRequest> bzzzzo_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? bzzzzp_ = context.Operators.Exists<MedicationRequest>(bzzzzo_);
        bool? bzzzzq_ = context.Operators.Or(bzzzzn_, bzzzzp_);
        bool? bzzzzr_ = context.Operators.And(bzzzzi_, bzzzzq_);
        Date bzzzzt_ = azzzzx_?.BirthDateElement;
        string bzzzzu_ = bzzzzt_?.Value;
        CqlDate bzzzzv_ = context.Operators.ConvertStringToDate(bzzzzu_);
        CqlDateTime bzzzzx_ = context.Operators.Start(bzzzzb_);
        CqlDate bzzzzy_ = context.Operators.DateFrom(bzzzzx_);
        int? bzzzzz_ = context.Operators.CalculateAgeAt(bzzzzv_, bzzzzy_, "year");
        bool? czzzza_ = context.Operators.GreaterOrEqual(bzzzzz_, 80);
        bool? czzzzc_ = context.Operators.And(czzzza_, bzzzzh_);
        bool? czzzzd_ = context.Operators.Or(bzzzzr_, czzzzc_);

        return czzzzd_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context)
    {
        Patient czzzze_ = this.Patient(context);
        Date czzzzf_ = czzzze_?.BirthDateElement;
        string czzzzg_ = czzzzf_?.Value;
        CqlDate czzzzh_ = context.Operators.ConvertStringToDate(czzzzg_);
        CqlInterval<CqlDateTime> czzzzi_ = this.Measurement_Period(context);
        CqlDateTime czzzzj_ = context.Operators.Start(czzzzi_);
        CqlDate czzzzk_ = context.Operators.DateFrom(czzzzj_);
        int? czzzzl_ = context.Operators.CalculateAgeAt(czzzzh_, czzzzk_, "year");
        bool? czzzzm_ = context.Operators.GreaterOrEqual(czzzzl_, 65);
        bool? czzzzn_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? czzzzo_ = context.Operators.And(czzzzm_, czzzzn_);
        IEnumerable<Encounter> czzzzp_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? czzzzq_ = context.Operators.Exists<Encounter>(czzzzp_);
        IEnumerable<Encounter> czzzzr_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? czzzzs_ = context.Operators.Exists<Encounter>(czzzzr_);
        bool? czzzzt_ = context.Operators.Or(czzzzq_, czzzzs_);
        IEnumerable<MedicationRequest> czzzzu_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? czzzzv_ = context.Operators.Exists<MedicationRequest>(czzzzu_);
        bool? czzzzw_ = context.Operators.Or(czzzzt_, czzzzv_);
        bool? czzzzx_ = context.Operators.And(czzzzo_, czzzzw_);

        return czzzzx_;
    }


    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context)
    {
        int? czzzzy_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? czzzzz_ = context.Operators.Greater(czzzzy_, 90);

        return czzzzz_;
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
