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
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime fzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzo_ = context.Operators.Interval(fzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzn_, true, true);
        object fzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HIVSTITestingFHIR-0.2.000", "Measurement Period", fzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzq_);

        return fzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzs_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzu_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzv_);
        CqlValueSet fzzzzzzzzzzzzzzzx_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzz_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzb_);
        CqlValueSet gzzzzzzzzzzzzzzzd_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzf_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzh_);
        CqlValueSet gzzzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzn_);
        CqlValueSet gzzzzzzzzzzzzzzzp_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzr_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzt_);
        CqlValueSet gzzzzzzzzzzzzzzzv_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period hzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzc_);
            bool? hzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzd_, "day");

            return hzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzf_ = this.HIV(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzh_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime hzzzzzzzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzn_ = context.Operators.End(hzzzzzzzzzzzzzzzm_);
            bool? hzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzn_, "day");

            return hzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzh_);
        bool? hzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzi_);

        return hzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date hzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string hzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzq_?.Value;
        CqlDate hzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzt_);
        CqlDate hzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzu_);
        int? hzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzv_, "year");
        bool? hzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzw_, 13);
        bool? hzzzzzzzzzzzzzzzy_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzy_);
        bool? izzzzzzzzzzzzzzza_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzza_);

        return izzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? izzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return izzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzh_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? izzzzzzzzzzzzzzzj_(Observation ChlamydiaTest)
        {
            DataType izzzzzzzzzzzzzzzm_ = ChlamydiaTest?.Value;
            object izzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzn_ is null));
            Code<ObservationStatus> izzzzzzzzzzzzzzzp_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzq_ = izzzzzzzzzzzzzzzp_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzq_);
            string izzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzr_);
            string[] izzzzzzzzzzzzzzzt_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzu_ = context.Operators.In<string>(izzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzu_);
            object izzzzzzzzzzzzzzzw_()
            {
                bool jzzzzzzzzzzzzzzzb_()
                {
                    DataType jzzzzzzzzzzzzzzze_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzze_);
                    bool jzzzzzzzzzzzzzzzg_ = jzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzg_;
                };
                bool jzzzzzzzzzzzzzzzc_()
                {
                    DataType jzzzzzzzzzzzzzzzh_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzh_);
                    bool jzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzj_;
                };
                bool jzzzzzzzzzzzzzzzd_()
                {
                    DataType jzzzzzzzzzzzzzzzk_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzk_);
                    bool jzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzm_;
                };
                if (jzzzzzzzzzzzzzzzb_())
                {
                    DataType jzzzzzzzzzzzzzzzn_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzn_);

                    return (jzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzc_())
                {
                    DataType jzzzzzzzzzzzzzzzp_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzp_);

                    return (jzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzd_())
                {
                    DataType jzzzzzzzzzzzzzzzr_ = ChlamydiaTest?.Effective;
                    object jzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzr_);

                    return (jzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, izzzzzzzzzzzzzzzw_());
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzy_, "day");
            bool? jzzzzzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzz_);

            return jzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzt_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? jzzzzzzzzzzzzzzzv_(Observation GonorrheaTest)
        {
            DataType jzzzzzzzzzzzzzzzy_ = GonorrheaTest?.Value;
            object jzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzy_);
            bool? kzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzz_ is null));
            Code<ObservationStatus> kzzzzzzzzzzzzzzzb_ = GonorrheaTest?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzb_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzc_);
            string kzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzd_);
            string[] kzzzzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(kzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzg_);
            object kzzzzzzzzzzzzzzzi_()
            {
                bool kzzzzzzzzzzzzzzzn_()
                {
                    DataType kzzzzzzzzzzzzzzzq_ = GonorrheaTest?.Effective;
                    object kzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzq_);
                    bool kzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzs_;
                };
                bool kzzzzzzzzzzzzzzzo_()
                {
                    DataType kzzzzzzzzzzzzzzzt_ = GonorrheaTest?.Effective;
                    object kzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzt_);
                    bool kzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzzzzzzzv_;
                };
                bool kzzzzzzzzzzzzzzzp_()
                {
                    DataType kzzzzzzzzzzzzzzzw_ = GonorrheaTest?.Effective;
                    object kzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzw_);
                    bool kzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzy_;
                };
                if (kzzzzzzzzzzzzzzzn_())
                {
                    DataType kzzzzzzzzzzzzzzzz_ = GonorrheaTest?.Effective;
                    object lzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzz_);

                    return (lzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzzzzzzzo_())
                {
                    DataType lzzzzzzzzzzzzzzzb_ = GonorrheaTest?.Effective;
                    object lzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzb_);

                    return (lzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzzzzzzzp_())
                {
                    DataType lzzzzzzzzzzzzzzzd_ = GonorrheaTest?.Effective;
                    object lzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzd_);

                    return (lzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime kzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.latest(context, kzzzzzzzzzzzzzzzi_());
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzk_, "day");
            bool? kzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzl_);

            return kzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzf_ = this.Syphilis_Tests(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? lzzzzzzzzzzzzzzzh_(Observation SyphilisTest)
        {
            DataType lzzzzzzzzzzzzzzzk_ = SyphilisTest?.Value;
            object lzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzk_);
            bool? lzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzl_ is null));
            Code<ObservationStatus> lzzzzzzzzzzzzzzzn_ = SyphilisTest?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> lzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzo_);
            string lzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzp_);
            string[] lzzzzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzs_);
            object lzzzzzzzzzzzzzzzu_()
            {
                bool lzzzzzzzzzzzzzzzz_()
                {
                    DataType mzzzzzzzzzzzzzzzc_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzc_);
                    bool mzzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzze_;
                };
                bool mzzzzzzzzzzzzzzza_()
                {
                    DataType mzzzzzzzzzzzzzzzf_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzf_);
                    bool mzzzzzzzzzzzzzzzh_ = mzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzh_;
                };
                bool mzzzzzzzzzzzzzzzb_()
                {
                    DataType mzzzzzzzzzzzzzzzi_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzi_);
                    bool mzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzk_;
                };
                if (lzzzzzzzzzzzzzzzz_())
                {
                    DataType mzzzzzzzzzzzzzzzl_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzl_);

                    return (mzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else if (mzzzzzzzzzzzzzzza_())
                {
                    DataType mzzzzzzzzzzzzzzzn_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzn_);

                    return (mzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (mzzzzzzzzzzzzzzzb_())
                {
                    DataType mzzzzzzzzzzzzzzzp_ = SyphilisTest?.Effective;
                    object mzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzp_);

                    return (mzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime lzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, lzzzzzzzzzzzzzzzu_());
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzw_, "day");
            bool? lzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzh_);
        bool? lzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzzi_);

        return lzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzr_ = this.Has_Chlamydia_Testing(context);
        bool? mzzzzzzzzzzzzzzzs_ = this.Has_Gonorrhea_Testing(context);
        bool? mzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzzzzzu_ = this.Has_Syphilis_Testing(context);
        bool? mzzzzzzzzzzzzzzzv_ = context.Operators.And(mzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
