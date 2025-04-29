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
[CqlLibrary("HIVViralSuppressionFHIR", "0.1.000")]
public partial class HIVViralSuppressionFHIR_0_1_000 : ILibrary, ISingleton<HIVViralSuppressionFHIR_0_1_000>
{
    private HIVViralSuppressionFHIR_0_1_000() {}

    public static HIVViralSuppressionFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVViralSuppressionFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Face-to-Face Interaction
    [CqlValueSetDefinition(
        definitionName: "Face-to-Face Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext context) => _Face_to_Face_Interaction;

    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: HIV Viral Load
    [CqlValueSetDefinition(
        definitionName: "HIV Viral Load",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002",
        valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load(CqlContext context) => _HIV_Viral_Load;

    private static readonly CqlValueSet _HIV_Viral_Load = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services Other
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) => _Preventive_Care_Services_Other;

    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Telehealth Services
    [CqlValueSetDefinition(
        definitionName: "Telehealth Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031",
        valueSetVersion: null)]
    public CqlValueSet Telehealth_Services(CqlContext context) => _Telehealth_Services;

    private static readonly CqlValueSet _Telehealth_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Below threshold level (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Below threshold level (qualifier value)",
        codeId: "260988000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Below_threshold_level__qualifier_value_(CqlContext context) => _Below_threshold_level__qualifier_value_;

    private static readonly CqlCode _Below_threshold_level__qualifier_value_ = new CqlCode("260988000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Not detected (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Not detected (qualifier value)",
        codeId: "260415000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Not_detected__qualifier_value_(CqlContext context) => _Not_detected__qualifier_value_;

    private static readonly CqlCode _Not_detected__qualifier_value_ = new CqlCode("260415000", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] ezzzzzzi_ = [
            new CqlCode("260988000", "http://snomed.info/sct", default, default),
            new CqlCode("260415000", "http://snomed.info/sct", default, default),
        ];

        return ezzzzzzi_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] ezzzzzzj_ = []
;

        return ezzzzzzj_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzm_ = context.Operators.Interval(ezzzzzzk_, ezzzzzzl_, true, true);
        object ezzzzzzn_ = context.ResolveParameter("HIVViralSuppressionFHIR-0.1.000", "Measurement Period", ezzzzzzm_);

        return (CqlInterval<CqlDateTime>)ezzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzp_ = context.Operators.SingletonFrom<Patient>(ezzzzzzo_);

        return ezzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzq_ = this.HIV(context);
        IEnumerable<Condition> ezzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzs_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> ezzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime ezzzzzzw_ = context.Operators.Start(ezzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzy_ = context.Operators.Start(ezzzzzzx_);
            CqlQuantity ezzzzzzz_ = context.Operators.Quantity(90m, "days");
            CqlDateTime fzzzzzza_ = context.Operators.Add(ezzzzzzy_, ezzzzzzz_);
            bool? fzzzzzzb_ = context.Operators.Before(ezzzzzzw_, fzzzzzza_, "day");

            return fzzzzzzb_;
        };
        IEnumerable<Condition> ezzzzzzt_ = context.Operators.Where<Condition>(ezzzzzzr_, ezzzzzzs_);
        bool? ezzzzzzu_ = context.Operators.Exists<Condition>(ezzzzzzt_);

        return ezzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzc_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzze_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> fzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzg_ = context.Operators.Union<Encounter>(fzzzzzzd_, fzzzzzzf_);
        CqlValueSet fzzzzzzh_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzj_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> fzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzl_ = context.Operators.Union<Encounter>(fzzzzzzi_, fzzzzzzk_);
        IEnumerable<Encounter> fzzzzzzm_ = context.Operators.Union<Encounter>(fzzzzzzg_, fzzzzzzl_);
        CqlValueSet fzzzzzzn_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzp_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzr_ = context.Operators.Union<Encounter>(fzzzzzzo_, fzzzzzzq_);
        IEnumerable<Encounter> fzzzzzzs_ = context.Operators.Union<Encounter>(fzzzzzzm_, fzzzzzzr_);
        CqlValueSet fzzzzzzt_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzv_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzx_ = context.Operators.Union<Encounter>(fzzzzzzu_, fzzzzzzw_);
        IEnumerable<Encounter> fzzzzzzy_ = context.Operators.Union<Encounter>(fzzzzzzs_, fzzzzzzx_);
        CqlValueSet fzzzzzzz_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> gzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzd_ = context.Operators.Union<Encounter>(gzzzzzza_, gzzzzzzc_);
        IEnumerable<Encounter> gzzzzzze_ = context.Operators.Union<Encounter>(fzzzzzzy_, gzzzzzzd_);
        CqlValueSet gzzzzzzf_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> gzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzh_ = context.Operators.Union<Encounter>(gzzzzzze_, gzzzzzzg_);
        bool? gzzzzzzi_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzm_ = context.Operators.Start(gzzzzzzl_);
            CqlDateTime gzzzzzzo_ = context.Operators.Start(gzzzzzzl_);
            CqlQuantity gzzzzzzp_ = context.Operators.Quantity(240m, "days");
            CqlDateTime gzzzzzzq_ = context.Operators.Add(gzzzzzzo_, gzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzr_ = context.Operators.Interval(gzzzzzzm_, gzzzzzzq_, true, true);
            Period gzzzzzzs_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzs_);
            bool? gzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzr_, gzzzzzzt_, "day");

            return gzzzzzzu_;
        };
        IEnumerable<Encounter> gzzzzzzj_ = context.Operators.Where<Encounter>(gzzzzzzh_, gzzzzzzi_);
        bool? gzzzzzzk_ = context.Operators.Exists<Encounter>(gzzzzzzj_);

        return gzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? gzzzzzzv_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(context);
        bool? gzzzzzzw_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? gzzzzzzx_ = context.Operators.And(gzzzzzzv_, gzzzzzzw_);

        return gzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzy_ = this.Initial_Population(context);

        return gzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Viral Load Test During Measurement Period")]
    public Observation Most_Recent_Viral_Load_Test_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzd_ = this.HIV_Viral_Load(context);
        IEnumerable<Observation> hzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzf_(Observation ViralLoad)
        {
            object hzzzzzzk_()
            {
                bool hzzzzzzo_()
                {
                    DataType hzzzzzzr_ = ViralLoad?.Effective;
                    object hzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzr_);
                    bool hzzzzzzt_ = hzzzzzzs_ is CqlDateTime;

                    return hzzzzzzt_;
                };
                bool hzzzzzzp_()
                {
                    DataType hzzzzzzu_ = ViralLoad?.Effective;
                    object hzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzu_);
                    bool hzzzzzzw_ = hzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzw_;
                };
                bool hzzzzzzq_()
                {
                    DataType hzzzzzzx_ = ViralLoad?.Effective;
                    object hzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzx_);
                    bool hzzzzzzz_ = hzzzzzzy_ is CqlDateTime;

                    return hzzzzzzz_;
                };
                if (hzzzzzzo_())
                {
                    DataType izzzzzza_ = ViralLoad?.Effective;
                    object izzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzza_);

                    return (izzzzzzb_ as CqlDateTime) as object;
                }
                else if (hzzzzzzp_())
                {
                    DataType izzzzzzc_ = ViralLoad?.Effective;
                    object izzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzc_);

                    return (izzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzq_())
                {
                    DataType izzzzzze_ = ViralLoad?.Effective;
                    object izzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzze_);

                    return (izzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzl_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzk_());
            CqlInterval<CqlDateTime> hzzzzzzm_ = this.Measurement_Period(context);
            bool? hzzzzzzn_ = context.Operators.In<CqlDateTime>(hzzzzzzl_, hzzzzzzm_, "day");

            return hzzzzzzn_;
        };
        IEnumerable<Observation> hzzzzzzg_ = context.Operators.Where<Observation>(hzzzzzze_, hzzzzzzf_);
        object hzzzzzzh_(Observation @this)
        {
            DataType izzzzzzg_ = @this?.Effective;
            object izzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzg_);
            CqlInterval<CqlDateTime> izzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzh_);
            CqlDateTime izzzzzzj_ = context.Operators.Start(izzzzzzi_);

            return izzzzzzj_;
        };
        IEnumerable<Observation> hzzzzzzi_ = context.Operators.SortBy<Observation>(hzzzzzzg_, hzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzj_ = context.Operators.Last<Observation>(hzzzzzzi_);

        return hzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        Observation izzzzzzk_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period(context);
        DataType izzzzzzl_ = izzzzzzk_?.Value;
        object izzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzl_);
        CqlQuantity izzzzzzn_ = context.Operators.Quantity(200m, "{copies}/mL");
        bool? izzzzzzo_ = context.Operators.Less(izzzzzzm_ as CqlQuantity, izzzzzzn_);
        DataType izzzzzzq_ = izzzzzzk_?.Value;
        object izzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzq_);
        CqlCode izzzzzzs_ = this.Below_threshold_level__qualifier_value_(context);
        CqlConcept izzzzzzt_ = context.Operators.ConvertCodeToConcept(izzzzzzs_);
        bool? izzzzzzu_ = context.Operators.Equivalent(izzzzzzr_ as CqlConcept, izzzzzzt_);
        bool? izzzzzzv_ = context.Operators.Or(izzzzzzo_, izzzzzzu_);
        DataType izzzzzzx_ = izzzzzzk_?.Value;
        object izzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzx_);
        CqlCode izzzzzzz_ = this.Not_detected__qualifier_value_(context);
        CqlConcept jzzzzzza_ = context.Operators.ConvertCodeToConcept(izzzzzzz_);
        bool? jzzzzzzb_ = context.Operators.Equivalent(izzzzzzy_ as CqlConcept, jzzzzzza_);
        bool? jzzzzzzc_ = context.Operators.Or(izzzzzzv_, jzzzzzzb_);

        return jzzzzzzc_;
    }


    #endregion Expressions

}
