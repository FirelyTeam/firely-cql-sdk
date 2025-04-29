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
[CqlLibrary("HIVSTITestingFHIR", "0.2.000")]
public partial class HIVSTITestingFHIR_0_2_000 : ILibrary, ISingleton<HIVSTITestingFHIR_0_2_000>
{
    private HIVSTITestingFHIR_0_2_000() {}

    public static HIVSTITestingFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVSTITestingFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Chlamydia Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext _) => _Chlamydia_Screening;
    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("Gonorrhea Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1", valueSetVersion: null)]
    public CqlValueSet Gonorrhea_Screening(CqlContext _) => _Gonorrhea_Screening;
    private static readonly CqlValueSet _Gonorrhea_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

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

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Syphilis Tests", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1166.117", valueSetVersion: null)]
    public CqlValueSet Syphilis_Tests(CqlContext _) => _Syphilis_Tests;
    private static readonly CqlValueSet _Syphilis_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1166.117", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzn_ = context.Operators.Interval(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzm_, true, true);
        object zzzzzzzzzzzzzo_ = context.ResolveParameter("HIVSTITestingFHIR-0.2.000", "Measurement Period", zzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzp_);

        return zzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzt_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzs_, zzzzzzzzzzzzzu_);
        CqlValueSet zzzzzzzzzzzzzw_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzy_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzx_, zzzzzzzzzzzzzz_);
        IEnumerable<Encounter> azzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzv_, azzzzzzzzzzzzza_);
        CqlValueSet azzzzzzzzzzzzzc_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzze_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzd_, azzzzzzzzzzzzzf_);
        IEnumerable<Encounter> azzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzb_, azzzzzzzzzzzzzg_);
        CqlValueSet azzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzk_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzl_);
        IEnumerable<Encounter> azzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzh_, azzzzzzzzzzzzzm_);
        CqlValueSet azzzzzzzzzzzzzo_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzq_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzp_, azzzzzzzzzzzzzr_);
        IEnumerable<Encounter> azzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzn_, azzzzzzzzzzzzzs_);
        CqlValueSet azzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzt_, azzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzx_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzb_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzb_);
            bool? bzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzza_, bzzzzzzzzzzzzzc_, "day");

            return bzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzw_, azzzzzzzzzzzzzx_);
        bool? azzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzze_ = this.HIV(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzg_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime bzzzzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzm_ = context.Operators.End(bzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzm_, "day");

            return bzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzg_);
        bool? bzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzh_);

        return bzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzo_ = this.Patient(context);
        Date bzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzo_?.BirthDateElement;
        string bzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzp_?.Value;
        CqlDate bzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzt_ = context.Operators.Start(bzzzzzzzzzzzzzs_);
        CqlDate bzzzzzzzzzzzzzu_ = context.Operators.DateFrom(bzzzzzzzzzzzzzt_);
        int? bzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzu_, "year");
        bool? bzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzv_, 13);
        bool? bzzzzzzzzzzzzzx_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzz_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? czzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? czzzzzzzzzzzzzb_ = this.Initial_Population(context);

        return czzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzg_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> czzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? czzzzzzzzzzzzzi_(Observation ChlamydiaTest)
        {
            DataType czzzzzzzzzzzzzl_ = ChlamydiaTest?.Value;
            object czzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzm_ is null));
            Code<ObservationStatus> czzzzzzzzzzzzzo_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzp_ = czzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzp_);
            string czzzzzzzzzzzzzr_ = context.Operators.Convert<string>(czzzzzzzzzzzzzq_);
            string[] czzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzzzzzzzzzzzzt_ = context.Operators.In<string>(czzzzzzzzzzzzzr_, czzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzzzzn_, czzzzzzzzzzzzzt_);
            object czzzzzzzzzzzzzv_()
            {
                bool dzzzzzzzzzzzzza_()
                {
                    DataType dzzzzzzzzzzzzzd_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzd_);
                    bool dzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzze_ is CqlDateTime;

                    return dzzzzzzzzzzzzzf_;
                };
                bool dzzzzzzzzzzzzzb_()
                {
                    DataType dzzzzzzzzzzzzzg_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzg_);
                    bool dzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzi_;
                };
                bool dzzzzzzzzzzzzzc_()
                {
                    DataType dzzzzzzzzzzzzzj_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzj_);
                    bool dzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzk_ is CqlDateTime;

                    return dzzzzzzzzzzzzzl_;
                };
                if (dzzzzzzzzzzzzza_())
                {
                    DataType dzzzzzzzzzzzzzm_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzm_);

                    return (dzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzb_())
                {
                    DataType dzzzzzzzzzzzzzo_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzo_);

                    return (dzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzc_())
                {
                    DataType dzzzzzzzzzzzzzq_ = ChlamydiaTest?.Effective;
                    object dzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzq_);

                    return (dzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.latest(context, czzzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzw_, czzzzzzzzzzzzzx_, "day");
            bool? czzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzu_, czzzzzzzzzzzzzy_);

            return czzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzh_, czzzzzzzzzzzzzi_);
        bool? czzzzzzzzzzzzzk_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzj_);

        return czzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzs_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzzzu_(Observation GonorrheaTest)
        {
            DataType dzzzzzzzzzzzzzx_ = GonorrheaTest?.Value;
            object dzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzy_ is null));
            Code<ObservationStatus> ezzzzzzzzzzzzza_ = GonorrheaTest?.StatusElement;
            ObservationStatus? ezzzzzzzzzzzzzb_ = ezzzzzzzzzzzzza_?.Value;
            Code<ObservationStatus> ezzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzb_);
            string ezzzzzzzzzzzzzd_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzc_);
            string[] ezzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ezzzzzzzzzzzzzf_ = context.Operators.In<string>(ezzzzzzzzzzzzzd_, ezzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzf_);
            object ezzzzzzzzzzzzzh_()
            {
                bool ezzzzzzzzzzzzzm_()
                {
                    DataType ezzzzzzzzzzzzzp_ = GonorrheaTest?.Effective;
                    object ezzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzp_);
                    bool ezzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzq_ is CqlDateTime;

                    return ezzzzzzzzzzzzzr_;
                };
                bool ezzzzzzzzzzzzzn_()
                {
                    DataType ezzzzzzzzzzzzzs_ = GonorrheaTest?.Effective;
                    object ezzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzs_);
                    bool ezzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzu_;
                };
                bool ezzzzzzzzzzzzzo_()
                {
                    DataType ezzzzzzzzzzzzzv_ = GonorrheaTest?.Effective;
                    object ezzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzv_);
                    bool ezzzzzzzzzzzzzx_ = ezzzzzzzzzzzzzw_ is CqlDateTime;

                    return ezzzzzzzzzzzzzx_;
                };
                if (ezzzzzzzzzzzzzm_())
                {
                    DataType ezzzzzzzzzzzzzy_ = GonorrheaTest?.Effective;
                    object ezzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzy_);

                    return (ezzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzn_())
                {
                    DataType fzzzzzzzzzzzzza_ = GonorrheaTest?.Effective;
                    object fzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzza_);

                    return (fzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzo_())
                {
                    DataType fzzzzzzzzzzzzzc_ = GonorrheaTest?.Effective;
                    object fzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzc_);

                    return (fzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.latest(context, ezzzzzzzzzzzzzh_());
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzi_, ezzzzzzzzzzzzzj_, "day");
            bool? ezzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzg_, ezzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzze_ = this.Syphilis_Tests(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? fzzzzzzzzzzzzzg_(Observation SyphilisTest)
        {
            DataType fzzzzzzzzzzzzzj_ = SyphilisTest?.Value;
            object fzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzj_);
            bool? fzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzk_ is null));
            Code<ObservationStatus> fzzzzzzzzzzzzzm_ = SyphilisTest?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzm_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzn_);
            string fzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzo_);
            string[] fzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzzr_ = context.Operators.In<string>(fzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzr_);
            object fzzzzzzzzzzzzzt_()
            {
                bool fzzzzzzzzzzzzzy_()
                {
                    DataType gzzzzzzzzzzzzzb_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzb_);
                    bool gzzzzzzzzzzzzzd_ = gzzzzzzzzzzzzzc_ is CqlDateTime;

                    return gzzzzzzzzzzzzzd_;
                };
                bool fzzzzzzzzzzzzzz_()
                {
                    DataType gzzzzzzzzzzzzze_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzze_);
                    bool gzzzzzzzzzzzzzg_ = gzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzg_;
                };
                bool gzzzzzzzzzzzzza_()
                {
                    DataType gzzzzzzzzzzzzzh_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzh_);
                    bool gzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzi_ is CqlDateTime;

                    return gzzzzzzzzzzzzzj_;
                };
                if (fzzzzzzzzzzzzzy_())
                {
                    DataType gzzzzzzzzzzzzzk_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzk_);

                    return (gzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzzzz_())
                {
                    DataType gzzzzzzzzzzzzzm_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzm_);

                    return (gzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzza_())
                {
                    DataType gzzzzzzzzzzzzzo_ = SyphilisTest?.Effective;
                    object gzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzo_);

                    return (gzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime fzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, fzzzzzzzzzzzzzt_());
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzv_, "day");
            bool? fzzzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzw_);

            return fzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzq_ = this.Has_Chlamydia_Testing(context);
        bool? gzzzzzzzzzzzzzr_ = this.Has_Gonorrhea_Testing(context);
        bool? gzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzr_);
        bool? gzzzzzzzzzzzzzt_ = this.Has_Syphilis_Testing(context);
        bool? gzzzzzzzzzzzzzu_ = context.Operators.And(gzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzt_);

        return gzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
