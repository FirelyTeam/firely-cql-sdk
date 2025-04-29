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
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.ResolveParameter("HIVSTITestingFHIR-0.2.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.HIV(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, 13);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation ChlamydiaTest)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ChlamydiaTest?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ChlamydiaTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.latest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_());
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation GonorrheaTest)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = GonorrheaTest?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = GonorrheaTest?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
            {
                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = GonorrheaTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = GonorrheaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = GonorrheaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = GonorrheaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = GonorrheaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = GonorrheaTest?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.latest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Syphilis_Tests(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation SyphilisTest)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SyphilisTest?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SyphilisTest?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                    return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                {
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SyphilisTest?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.latest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_());
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Chlamydia_Testing(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Gonorrhea_Testing(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Syphilis_Testing(context);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
