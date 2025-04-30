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
[CqlLibrary("FallsScreeningForFutureFallRiskFHIR", "0.2.001")]
public partial class FallsScreeningForFutureFallRiskFHIR_0_2_001 : ILibrary, ISingleton<FallsScreeningForFutureFallRiskFHIR_0_2_001>
{
    private FallsScreeningForFutureFallRiskFHIR_0_2_001() {}

    public static FallsScreeningForFutureFallRiskFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FallsScreeningForFutureFallRiskFHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Audiology Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", valueSetVersion: null)]
    public CqlValueSet Audiology_Visit(CqlContext _) => _Audiology_Visit;
    private static readonly CqlValueSet _Audiology_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1066", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Discharge Services Nursing Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", valueSetVersion: null)]
    public CqlValueSet Discharge_Services_Nursing_Facility(CqlContext _) => _Discharge_Services_Nursing_Facility;
    private static readonly CqlValueSet _Discharge_Services_Nursing_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013", null);

    [CqlValueSetDefinition("Falls Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", valueSetVersion: null)]
    public CqlValueSet Falls_Screening(CqlContext _) => _Falls_Screening;
    private static readonly CqlValueSet _Falls_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1028", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Occupational Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext _) => _Occupational_Therapy_Evaluation;
    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Physical Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext _) => _Physical_Therapy_Evaluation;
    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime nzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime nzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> nzzzzzzzzzzp_ = context.Operators.Interval(nzzzzzzzzzzn_, nzzzzzzzzzzo_, true, true);
        object nzzzzzzzzzzq_ = context.ResolveParameter("FallsScreeningForFutureFallRiskFHIR-0.2.001", "Measurement Period", nzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzr_);

        return nzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzx_ = this.Office_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzz_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzb_ = context.Operators.Union<Encounter>(nzzzzzzzzzzy_, ozzzzzzzzzza_);
        CqlValueSet ozzzzzzzzzzc_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzze_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzg_ = context.Operators.Union<Encounter>(ozzzzzzzzzzd_, ozzzzzzzzzzf_);
        IEnumerable<Encounter> ozzzzzzzzzzh_ = context.Operators.Union<Encounter>(ozzzzzzzzzzb_, ozzzzzzzzzzg_);
        CqlValueSet ozzzzzzzzzzi_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzk_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzm_ = context.Operators.Union<Encounter>(ozzzzzzzzzzj_, ozzzzzzzzzzl_);
        IEnumerable<Encounter> ozzzzzzzzzzn_ = context.Operators.Union<Encounter>(ozzzzzzzzzzh_, ozzzzzzzzzzm_);
        CqlValueSet ozzzzzzzzzzo_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> ozzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzq_ = this.Discharge_Services_Nursing_Facility(context);
        IEnumerable<Encounter> ozzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzs_ = context.Operators.Union<Encounter>(ozzzzzzzzzzp_, ozzzzzzzzzzr_);
        IEnumerable<Encounter> ozzzzzzzzzzt_ = context.Operators.Union<Encounter>(ozzzzzzzzzzn_, ozzzzzzzzzzs_);
        CqlValueSet ozzzzzzzzzzu_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzw_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> ozzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzy_ = context.Operators.Union<Encounter>(ozzzzzzzzzzv_, ozzzzzzzzzzx_);
        IEnumerable<Encounter> ozzzzzzzzzzz_ = context.Operators.Union<Encounter>(ozzzzzzzzzzt_, ozzzzzzzzzzy_);
        CqlValueSet pzzzzzzzzzza_ = this.Audiology_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzze_ = context.Operators.Union<Encounter>(pzzzzzzzzzzb_, pzzzzzzzzzzd_);
        IEnumerable<Encounter> pzzzzzzzzzzf_ = context.Operators.Union<Encounter>(ozzzzzzzzzzz_, pzzzzzzzzzze_);
        CqlValueSet pzzzzzzzzzzg_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzi_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> pzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzzzzzh_, pzzzzzzzzzzj_);
        IEnumerable<Encounter> pzzzzzzzzzzl_ = context.Operators.Union<Encounter>(pzzzzzzzzzzf_, pzzzzzzzzzzk_);
        CqlValueSet pzzzzzzzzzzm_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> pzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzo_ = context.Operators.Union<Encounter>(pzzzzzzzzzzl_, pzzzzzzzzzzn_);
        IEnumerable<Encounter> pzzzzzzzzzzp_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzzzzo_);
        bool? pzzzzzzzzzzq_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzt_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzu_ as object);
            bool? pzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzs_, pzzzzzzzzzzv_, "day");

            return pzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzr_ = context.Operators.Where<Encounter>(pzzzzzzzzzzp_, pzzzzzzzzzzq_);

        return pzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzzx_ = this.Patient(context);
        Date pzzzzzzzzzzy_ = pzzzzzzzzzzx_?.BirthDateElement;
        string pzzzzzzzzzzz_ = pzzzzzzzzzzy_?.Value;
        CqlDate qzzzzzzzzzza_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzc_ = context.Operators.Start(qzzzzzzzzzzb_);
        CqlDate qzzzzzzzzzzd_ = context.Operators.DateFrom(qzzzzzzzzzzc_);
        int? qzzzzzzzzzze_ = context.Operators.CalculateAgeAt(qzzzzzzzzzza_, qzzzzzzzzzzd_, "year");
        bool? qzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(qzzzzzzzzzze_, 65);
        IEnumerable<Encounter> qzzzzzzzzzzg_ = this.Qualifying_Encounter(context);
        bool? qzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzg_);
        bool? qzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzf_, qzzzzzzzzzzh_);

        return qzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzj_ = this.Initial_Population(context);

        return qzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? qzzzzzzzzzzk_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return qzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzl_ = this.Falls_Screening(context);
        IEnumerable<Observation> qzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzm_);
        bool? qzzzzzzzzzzo_(Observation FallsScreening)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzr_ = this.Measurement_Period(context);
            DataType qzzzzzzzzzzs_ = FallsScreening?.Effective;
            object qzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzt_);
            bool? qzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzr_, qzzzzzzzzzzu_, "day");

            return qzzzzzzzzzzv_;
        };
        IEnumerable<Observation> qzzzzzzzzzzp_ = context.Operators.Where<Observation>(qzzzzzzzzzzn_, qzzzzzzzzzzo_);
        bool? qzzzzzzzzzzq_ = context.Operators.Exists<Observation>(qzzzzzzzzzzp_);

        return qzzzzzzzzzzq_;
    }


    #endregion Expressions

}
