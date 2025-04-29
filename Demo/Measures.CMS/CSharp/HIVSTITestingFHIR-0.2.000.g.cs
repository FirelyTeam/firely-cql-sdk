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

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Chlamydia Screening
    [CqlValueSetDefinition(
        definitionName: "Chlamydia Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052",
        valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext context) => _Chlamydia_Screening;

    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);
    #endregion

    #region ValueSet: Face-to-Face Interaction
    [CqlValueSetDefinition(
        definitionName: "Face-to-Face Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext context) => _Face_to_Face_Interaction;

    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);
    #endregion

    #region ValueSet: Gonorrhea Screening
    [CqlValueSetDefinition(
        definitionName: "Gonorrhea Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1",
        valueSetVersion: null)]
    public CqlValueSet Gonorrhea_Screening(CqlContext context) => _Gonorrhea_Screening;

    private static readonly CqlValueSet _Gonorrhea_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
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

    #region ValueSet: Syphilis Tests
    [CqlValueSetDefinition(
        definitionName: "Syphilis Tests",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1166.117",
        valueSetVersion: null)]
    public CqlValueSet Syphilis_Tests(CqlContext context) => _Syphilis_Tests;

    private static readonly CqlValueSet _Syphilis_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1166.117", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Preventive Care Services Other
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) => _Preventive_Care_Services_Other;

    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);
    #endregion

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzo_ = []
;

        return azzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzr_ = context.Operators.Interval(azzzzzzzzzzzp_, azzzzzzzzzzzq_, true, true);
        object azzzzzzzzzzzs_ = context.ResolveParameter("HIVSTITestingFHIR-0.2.000", "Measurement Period", azzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzt_);

        return azzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzx_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> azzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzz_ = context.Operators.Union<Encounter>(azzzzzzzzzzzw_, azzzzzzzzzzzy_);
        CqlValueSet bzzzzzzzzzzza_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzc_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> bzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzze_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzb_, bzzzzzzzzzzzd_);
        IEnumerable<Encounter> bzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(azzzzzzzzzzzz_, bzzzzzzzzzzze_);
        CqlValueSet bzzzzzzzzzzzg_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> bzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzi_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzh_, bzzzzzzzzzzzj_);
        IEnumerable<Encounter> bzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzf_, bzzzzzzzzzzzk_);
        CqlValueSet bzzzzzzzzzzzm_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzo_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> bzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzn_, bzzzzzzzzzzzp_);
        IEnumerable<Encounter> bzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzl_, bzzzzzzzzzzzq_);
        CqlValueSet bzzzzzzzzzzzs_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> bzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzu_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzt_, bzzzzzzzzzzzv_);
        IEnumerable<Encounter> bzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzr_, bzzzzzzzzzzzw_);
        CqlValueSet bzzzzzzzzzzzy_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> bzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzza_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzx_, bzzzzzzzzzzzz_);
        bool? czzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzze_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzf_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzf_);
            bool? czzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzze_, czzzzzzzzzzzg_, "day");

            return czzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzc_ = context.Operators.Where<Encounter>(czzzzzzzzzzza_, czzzzzzzzzzzb_);
        bool? czzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzc_);

        return czzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzi_ = this.HIV(context);
        IEnumerable<Condition> czzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzk_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime czzzzzzzzzzzo_ = context.Operators.Start(czzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzq_ = context.Operators.End(czzzzzzzzzzzp_);
            bool? czzzzzzzzzzzr_ = context.Operators.SameOrBefore(czzzzzzzzzzzo_, czzzzzzzzzzzq_, "day");

            return czzzzzzzzzzzr_;
        };
        IEnumerable<Condition> czzzzzzzzzzzl_ = context.Operators.Where<Condition>(czzzzzzzzzzzj_, czzzzzzzzzzzk_);
        bool? czzzzzzzzzzzm_ = context.Operators.Exists<Condition>(czzzzzzzzzzzl_);

        return czzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzs_ = this.Patient(context);
        Date czzzzzzzzzzzt_ = czzzzzzzzzzzs_?.BirthDateElement;
        string czzzzzzzzzzzu_ = czzzzzzzzzzzt_?.Value;
        CqlDate czzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzx_ = context.Operators.Start(czzzzzzzzzzzw_);
        CqlDate czzzzzzzzzzzy_ = context.Operators.DateFrom(czzzzzzzzzzzx_);
        int? czzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzv_, czzzzzzzzzzzy_, "year");
        bool? dzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzz_, 13);
        bool? dzzzzzzzzzzzb_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? dzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzza_, dzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzd_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? dzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzc_, dzzzzzzzzzzzd_);

        return dzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzf_ = this.Initial_Population(context);

        return dzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzk_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> dzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? dzzzzzzzzzzzm_(Observation ChlamydiaTest)
        {
            DataType dzzzzzzzzzzzp_ = ChlamydiaTest?.Value;
            object dzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzp_);
            bool? dzzzzzzzzzzzr_ = context.Operators.Not((bool?)(dzzzzzzzzzzzq_ is null));
            Code<ObservationStatus> dzzzzzzzzzzzs_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? dzzzzzzzzzzzt_ = dzzzzzzzzzzzs_?.Value;
            Code<ObservationStatus> dzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzt_);
            string dzzzzzzzzzzzv_ = context.Operators.Convert<string>(dzzzzzzzzzzzu_);
            string[] dzzzzzzzzzzzw_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzx_ = context.Operators.In<string>(dzzzzzzzzzzzv_, dzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzy_ = context.Operators.And(dzzzzzzzzzzzr_, dzzzzzzzzzzzx_);
            object dzzzzzzzzzzzz_()
            {
                bool ezzzzzzzzzzze_()
                {
                    DataType ezzzzzzzzzzzh_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzh_);
                    bool ezzzzzzzzzzzj_ = ezzzzzzzzzzzi_ is CqlDateTime;

                    return ezzzzzzzzzzzj_;
                };
                bool ezzzzzzzzzzzf_()
                {
                    DataType ezzzzzzzzzzzk_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzk_);
                    bool ezzzzzzzzzzzm_ = ezzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzm_;
                };
                bool ezzzzzzzzzzzg_()
                {
                    DataType ezzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzn_);
                    bool ezzzzzzzzzzzp_ = ezzzzzzzzzzzo_ is CqlDateTime;

                    return ezzzzzzzzzzzp_;
                };
                if (ezzzzzzzzzzze_())
                {
                    DataType ezzzzzzzzzzzq_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzq_);

                    return (ezzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzf_())
                {
                    DataType ezzzzzzzzzzzs_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzs_);

                    return (ezzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzg_())
                {
                    DataType ezzzzzzzzzzzu_ = ChlamydiaTest?.Effective;
                    object ezzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzu_);

                    return (ezzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.latest(context, dzzzzzzzzzzzz_());
            CqlInterval<CqlDateTime> ezzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzza_, ezzzzzzzzzzzb_, "day");
            bool? ezzzzzzzzzzzd_ = context.Operators.And(dzzzzzzzzzzzy_, ezzzzzzzzzzzc_);

            return ezzzzzzzzzzzd_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzn_ = context.Operators.Where<Observation>(dzzzzzzzzzzzl_, dzzzzzzzzzzzm_);
        bool? dzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzn_);

        return dzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzw_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation> ezzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzzzzzy_(Observation GonorrheaTest)
        {
            DataType fzzzzzzzzzzzb_ = GonorrheaTest?.Value;
            object fzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzd_ = context.Operators.Not((bool?)(fzzzzzzzzzzzc_ is null));
            Code<ObservationStatus> fzzzzzzzzzzze_ = GonorrheaTest?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzf_ = fzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzf_);
            string fzzzzzzzzzzzh_ = context.Operators.Convert<string>(fzzzzzzzzzzzg_);
            string[] fzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzzzzh_, fzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzd_, fzzzzzzzzzzzj_);
            object fzzzzzzzzzzzl_()
            {
                bool fzzzzzzzzzzzq_()
                {
                    DataType fzzzzzzzzzzzt_ = GonorrheaTest?.Effective;
                    object fzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzt_);
                    bool fzzzzzzzzzzzv_ = fzzzzzzzzzzzu_ is CqlDateTime;

                    return fzzzzzzzzzzzv_;
                };
                bool fzzzzzzzzzzzr_()
                {
                    DataType fzzzzzzzzzzzw_ = GonorrheaTest?.Effective;
                    object fzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzw_);
                    bool fzzzzzzzzzzzy_ = fzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return fzzzzzzzzzzzy_;
                };
                bool fzzzzzzzzzzzs_()
                {
                    DataType fzzzzzzzzzzzz_ = GonorrheaTest?.Effective;
                    object gzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzz_);
                    bool gzzzzzzzzzzzb_ = gzzzzzzzzzzza_ is CqlDateTime;

                    return gzzzzzzzzzzzb_;
                };
                if (fzzzzzzzzzzzq_())
                {
                    DataType gzzzzzzzzzzzc_ = GonorrheaTest?.Effective;
                    object gzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzc_);

                    return (gzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (fzzzzzzzzzzzr_())
                {
                    DataType gzzzzzzzzzzze_ = GonorrheaTest?.Effective;
                    object gzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzze_);

                    return (gzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fzzzzzzzzzzzs_())
                {
                    DataType gzzzzzzzzzzzg_ = GonorrheaTest?.Effective;
                    object gzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzg_);

                    return (gzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime fzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.latest(context, fzzzzzzzzzzzl_());
            CqlInterval<CqlDateTime> fzzzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzm_, fzzzzzzzzzzzn_, "day");
            bool? fzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzk_, fzzzzzzzzzzzo_);

            return fzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzz_ = context.Operators.Where<Observation>(ezzzzzzzzzzzx_, ezzzzzzzzzzzy_);
        bool? fzzzzzzzzzzza_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzz_);

        return fzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzi_ = this.Syphilis_Tests(context);
        IEnumerable<Observation> gzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? gzzzzzzzzzzzk_(Observation SyphilisTest)
        {
            DataType gzzzzzzzzzzzn_ = SyphilisTest?.Value;
            object gzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzn_);
            bool? gzzzzzzzzzzzp_ = context.Operators.Not((bool?)(gzzzzzzzzzzzo_ is null));
            Code<ObservationStatus> gzzzzzzzzzzzq_ = SyphilisTest?.StatusElement;
            ObservationStatus? gzzzzzzzzzzzr_ = gzzzzzzzzzzzq_?.Value;
            Code<ObservationStatus> gzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzr_);
            string gzzzzzzzzzzzt_ = context.Operators.Convert<string>(gzzzzzzzzzzzs_);
            string[] gzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? gzzzzzzzzzzzv_ = context.Operators.In<string>(gzzzzzzzzzzzt_, gzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? gzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzp_, gzzzzzzzzzzzv_);
            object gzzzzzzzzzzzx_()
            {
                bool hzzzzzzzzzzzc_()
                {
                    DataType hzzzzzzzzzzzf_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzf_);
                    bool hzzzzzzzzzzzh_ = hzzzzzzzzzzzg_ is CqlDateTime;

                    return hzzzzzzzzzzzh_;
                };
                bool hzzzzzzzzzzzd_()
                {
                    DataType hzzzzzzzzzzzi_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzi_);
                    bool hzzzzzzzzzzzk_ = hzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzk_;
                };
                bool hzzzzzzzzzzze_()
                {
                    DataType hzzzzzzzzzzzl_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzl_);
                    bool hzzzzzzzzzzzn_ = hzzzzzzzzzzzm_ is CqlDateTime;

                    return hzzzzzzzzzzzn_;
                };
                if (hzzzzzzzzzzzc_())
                {
                    DataType hzzzzzzzzzzzo_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzo_);

                    return (hzzzzzzzzzzzp_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzd_())
                {
                    DataType hzzzzzzzzzzzq_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzq_);

                    return (hzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzze_())
                {
                    DataType hzzzzzzzzzzzs_ = SyphilisTest?.Effective;
                    object hzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);

                    return (hzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.latest(context, gzzzzzzzzzzzx_());
            CqlInterval<CqlDateTime> gzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzy_, gzzzzzzzzzzzz_, "day");
            bool? hzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzw_, hzzzzzzzzzzza_);

            return hzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzl_ = context.Operators.Where<Observation>(gzzzzzzzzzzzj_, gzzzzzzzzzzzk_);
        bool? gzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzl_);

        return gzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? hzzzzzzzzzzzu_ = this.Has_Chlamydia_Testing(context);
        bool? hzzzzzzzzzzzv_ = this.Has_Gonorrhea_Testing(context);
        bool? hzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzu_, hzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzx_ = this.Has_Syphilis_Testing(context);
        bool? hzzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzzw_, hzzzzzzzzzzzx_);

        return hzzzzzzzzzzzy_;
    }


    #endregion Expressions

}
