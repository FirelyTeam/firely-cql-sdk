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
        CqlDateTime nzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime nzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzm_ = context.Operators.Interval(nzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzl_, true, true);
        object nzzzzzzzzzzzzzzn_ = context.ResolveParameter("HIVSTITestingFHIR-0.2.000", "Measurement Period", nzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)nzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> nzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient nzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(nzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzs_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzt_);
        CqlValueSet nzzzzzzzzzzzzzzv_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzx_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzz_);
        CqlValueSet ozzzzzzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzze_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzf_);
        CqlValueSet ozzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzj_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzl_);
        CqlValueSet ozzzzzzzzzzzzzzn_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzp_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzr_);
        CqlValueSet ozzzzzzzzzzzzzzt_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzzzw_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzb_, "day");

            return pzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzw_);
        bool? ozzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzd_ = this.HIV(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzf_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime pzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzl_ = context.Operators.End(pzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(pzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzl_, "day");

            return pzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzn_?.BirthDateElement;
        string pzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzo_?.Value;
        CqlDate pzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzzzzzr_);
        CqlDate pzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzs_);
        int? pzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzt_, "year");
        bool? pzzzzzzzzzzzzzzv_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzu_, 13);
        bool? pzzzzzzzzzzzzzzw_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzy_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzz_ = context.Operators.And(pzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzf_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? qzzzzzzzzzzzzzzh_(Observation ChlamydiaTest)
        {
            DataType qzzzzzzzzzzzzzzk_ = ChlamydiaTest?.Value;
            object qzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzl_ is null));
            Code<ObservationStatus> qzzzzzzzzzzzzzzn_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzo_);
            string qzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzp_);
            string[] qzzzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzs_ = context.Operators.In<string>(qzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzs_);
            object qzzzzzzzzzzzzzzu_()
            {
                bool qzzzzzzzzzzzzzzz_()
                {
                    DataType rzzzzzzzzzzzzzzc_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzc_);
                    bool rzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return rzzzzzzzzzzzzzze_;
                };
                bool rzzzzzzzzzzzzzza_()
                {
                    DataType rzzzzzzzzzzzzzzf_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzf_);
                    bool rzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return rzzzzzzzzzzzzzzh_;
                };
                bool rzzzzzzzzzzzzzzb_()
                {
                    DataType rzzzzzzzzzzzzzzi_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzi_);
                    bool rzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return rzzzzzzzzzzzzzzk_;
                };
                if (qzzzzzzzzzzzzzzz_())
                {
                    DataType rzzzzzzzzzzzzzzl_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzl_);

                    return (rzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (rzzzzzzzzzzzzzza_())
                {
                    DataType rzzzzzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzn_);

                    return (rzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (rzzzzzzzzzzzzzzb_())
                {
                    DataType rzzzzzzzzzzzzzzp_ = ChlamydiaTest?.Effective;
                    object rzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzp_);

                    return (rzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime qzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, qzzzzzzzzzzzzzzu_());
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? qzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzw_, "day");
            bool? qzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzx_);

            return qzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzr_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? rzzzzzzzzzzzzzzt_(Observation GonorrheaTest)
        {
            DataType rzzzzzzzzzzzzzzw_ = GonorrheaTest?.Value;
            object rzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzw_);
            bool? rzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzx_ is null));
            Code<ObservationStatus> rzzzzzzzzzzzzzzz_ = GonorrheaTest?.StatusElement;
            ObservationStatus? szzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzz_?.Value;
            Code<ObservationStatus> szzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzza_);
            string szzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzb_);
            string[] szzzzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? szzzzzzzzzzzzzze_ = context.Operators.In<string>(szzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzd_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzze_);
            object szzzzzzzzzzzzzzg_()
            {
                bool szzzzzzzzzzzzzzl_()
                {
                    DataType szzzzzzzzzzzzzzo_ = GonorrheaTest?.Effective;
                    object szzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzo_);
                    bool szzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzp_ is CqlDateTime;

                    return szzzzzzzzzzzzzzq_;
                };
                bool szzzzzzzzzzzzzzm_()
                {
                    DataType szzzzzzzzzzzzzzr_ = GonorrheaTest?.Effective;
                    object szzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzr_);
                    bool szzzzzzzzzzzzzzt_ = szzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return szzzzzzzzzzzzzzt_;
                };
                bool szzzzzzzzzzzzzzn_()
                {
                    DataType szzzzzzzzzzzzzzu_ = GonorrheaTest?.Effective;
                    object szzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzu_);
                    bool szzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzv_ is CqlDateTime;

                    return szzzzzzzzzzzzzzw_;
                };
                if (szzzzzzzzzzzzzzl_())
                {
                    DataType szzzzzzzzzzzzzzx_ = GonorrheaTest?.Effective;
                    object szzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzx_);

                    return (szzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (szzzzzzzzzzzzzzm_())
                {
                    DataType szzzzzzzzzzzzzzz_ = GonorrheaTest?.Effective;
                    object tzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzz_);

                    return (tzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (szzzzzzzzzzzzzzn_())
                {
                    DataType tzzzzzzzzzzzzzzb_ = GonorrheaTest?.Effective;
                    object tzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzb_);

                    return (tzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.latest(context, szzzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_, "day");
            bool? szzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzj_);

            return szzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzt_);
        bool? rzzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzzu_);

        return rzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzd_ = this.Syphilis_Tests(context);
        IEnumerable<Observation> tzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? tzzzzzzzzzzzzzzf_(Observation SyphilisTest)
        {
            DataType tzzzzzzzzzzzzzzi_ = SyphilisTest?.Value;
            object tzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzi_);
            bool? tzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzj_ is null));
            Code<ObservationStatus> tzzzzzzzzzzzzzzl_ = SyphilisTest?.StatusElement;
            ObservationStatus? tzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzl_?.Value;
            Code<ObservationStatus> tzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzm_);
            string tzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzn_);
            string[] tzzzzzzzzzzzzzzp_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzzzzzq_ = context.Operators.In<string>(tzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzq_);
            object tzzzzzzzzzzzzzzs_()
            {
                bool tzzzzzzzzzzzzzzx_()
                {
                    DataType uzzzzzzzzzzzzzza_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzza_);
                    bool uzzzzzzzzzzzzzzc_ = uzzzzzzzzzzzzzzb_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzc_;
                };
                bool tzzzzzzzzzzzzzzy_()
                {
                    DataType uzzzzzzzzzzzzzzd_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzd_);
                    bool uzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzzzzzzf_;
                };
                bool tzzzzzzzzzzzzzzz_()
                {
                    DataType uzzzzzzzzzzzzzzg_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzg_);
                    bool uzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzh_ is CqlDateTime;

                    return uzzzzzzzzzzzzzzi_;
                };
                if (tzzzzzzzzzzzzzzx_())
                {
                    DataType uzzzzzzzzzzzzzzj_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzj_);

                    return (uzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else if (tzzzzzzzzzzzzzzy_())
                {
                    DataType uzzzzzzzzzzzzzzl_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzl_);

                    return (uzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (tzzzzzzzzzzzzzzz_())
                {
                    DataType uzzzzzzzzzzzzzzn_ = SyphilisTest?.Effective;
                    object uzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzn_);

                    return (uzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.latest(context, tzzzzzzzzzzzzzzs_());
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzu_, "day");
            bool? tzzzzzzzzzzzzzzw_ = context.Operators.And(tzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzv_);

            return tzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzf_);
        bool? tzzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzp_ = this.Has_Chlamydia_Testing(context);
        bool? uzzzzzzzzzzzzzzq_ = this.Has_Gonorrhea_Testing(context);
        bool? uzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzzzzs_ = this.Has_Syphilis_Testing(context);
        bool? uzzzzzzzzzzzzzzt_ = context.Operators.And(uzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzs_);

        return uzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
