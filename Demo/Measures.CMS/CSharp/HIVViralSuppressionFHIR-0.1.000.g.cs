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

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("HIV Viral Load", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load(CqlContext _) => _HIV_Viral_Load;
    private static readonly CqlValueSet _HIV_Viral_Load = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telehealth Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", valueSetVersion: null)]
    public CqlValueSet Telehealth_Services(CqlContext _) => _Telehealth_Services;
    private static readonly CqlValueSet _Telehealth_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Below threshold level (qualifier value)", codeId: "260988000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Below_threshold_level__qualifier_value_(CqlContext _) => _Below_threshold_level__qualifier_value_;
    private static readonly CqlCode _Below_threshold_level__qualifier_value_ = new CqlCode("260988000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Not detected (qualifier value)", codeId: "260415000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Not_detected__qualifier_value_(CqlContext _) => _Not_detected__qualifier_value_;
    private static readonly CqlCode _Not_detected__qualifier_value_ = new CqlCode("260415000", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzl_ = context.Operators.Interval(ezzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzk_, true, true);
        object ezzzzzzzzzzzzzzm_ = context.ResolveParameter("HIVViralSuppressionFHIR-0.1.000", "Measurement Period", ezzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzp_ = this.HIV(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzr_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime ezzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzzzzzw_);
            CqlQuantity ezzzzzzzzzzzzzzy_ = context.Operators.Quantity(90m, "days");
            CqlDateTime ezzzzzzzzzzzzzzz_ = context.Operators.Add(ezzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzy_);
            bool? fzzzzzzzzzzzzzza_ = context.Operators.Before(ezzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzz_, "day");

            return fzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzd_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzze_);
        CqlValueSet fzzzzzzzzzzzzzzg_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzi_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzk_);
        CqlValueSet fzzzzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzq_);
        CqlValueSet fzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzw_);
        CqlValueSet fzzzzzzzzzzzzzzy_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzc_);
        CqlValueSet gzzzzzzzzzzzzzze_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzh_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzk_);
            CqlDateTime gzzzzzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzzzzzk_);
            CqlQuantity gzzzzzzzzzzzzzzo_ = context.Operators.Quantity(240m, "days");
            CqlDateTime gzzzzzzzzzzzzzzp_ = context.Operators.Add(gzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzq_ = context.Operators.Interval(gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzp_, true, true);
            Period gzzzzzzzzzzzzzzr_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzr_);
            bool? gzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzs_, "day");

            return gzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzh_);
        bool? gzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzu_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzv_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzx_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Most Recent Viral Load Test During Measurement Period")]
    public Observation Most_Recent_Viral_Load_Test_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzc_ = this.HIV_Viral_Load(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzze_(Observation ViralLoad)
        {
            object hzzzzzzzzzzzzzzj_()
            {
                bool hzzzzzzzzzzzzzzn_()
                {
                    DataType hzzzzzzzzzzzzzzq_ = ViralLoad?.Effective;
                    object hzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzq_);
                    bool hzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzs_;
                };
                bool hzzzzzzzzzzzzzzo_()
                {
                    DataType hzzzzzzzzzzzzzzt_ = ViralLoad?.Effective;
                    object hzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzt_);
                    bool hzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzv_;
                };
                bool hzzzzzzzzzzzzzzp_()
                {
                    DataType hzzzzzzzzzzzzzzw_ = ViralLoad?.Effective;
                    object hzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzw_);
                    bool hzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzy_;
                };
                if (hzzzzzzzzzzzzzzn_())
                {
                    DataType hzzzzzzzzzzzzzzz_ = ViralLoad?.Effective;
                    object izzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzz_);

                    return (izzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzo_())
                {
                    DataType izzzzzzzzzzzzzzb_ = ViralLoad?.Effective;
                    object izzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzb_);

                    return (izzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzp_())
                {
                    DataType izzzzzzzzzzzzzzd_ = ViralLoad?.Effective;
                    object izzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzd_);

                    return (izzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzzzzzzzzzj_());
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzl_, "day");

            return hzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzze_);
        object hzzzzzzzzzzzzzzg_(Observation @this)
        {
            DataType izzzzzzzzzzzzzzf_ = @this?.Effective;
            object izzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzg_);
            CqlDateTime izzzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzzh_);

            return izzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        Observation izzzzzzzzzzzzzzj_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period(context);
        DataType izzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzj_?.Value;
        object izzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzk_);
        CqlQuantity izzzzzzzzzzzzzzm_ = context.Operators.Quantity(200m, "{copies}/mL");
        bool? izzzzzzzzzzzzzzn_ = context.Operators.Less(izzzzzzzzzzzzzzl_ as CqlQuantity, izzzzzzzzzzzzzzm_);
        DataType izzzzzzzzzzzzzzp_ = izzzzzzzzzzzzzzj_?.Value;
        object izzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzp_);
        CqlCode izzzzzzzzzzzzzzr_ = this.Below_threshold_level__qualifier_value_(context);
        CqlConcept izzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzr_);
        bool? izzzzzzzzzzzzzzt_ = context.Operators.Equivalent(izzzzzzzzzzzzzzq_ as CqlConcept, izzzzzzzzzzzzzzs_);
        bool? izzzzzzzzzzzzzzu_ = context.Operators.Or(izzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzt_);
        DataType izzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzj_?.Value;
        object izzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzw_);
        CqlCode izzzzzzzzzzzzzzy_ = this.Not_detected__qualifier_value_(context);
        CqlConcept izzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzza_ = context.Operators.Equivalent(izzzzzzzzzzzzzzx_ as CqlConcept, izzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzb_ = context.Operators.Or(izzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
