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
[CqlLibrary("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR", "0.0.008")]
public partial class PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008 : ILibrary, ISingleton<PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008>
{
    private PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008() {}

    public static PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR_0_0_008 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR";
    public string Version => "0.0.008";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, HospiceFHIR4_2_3_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Preventive Care - Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care___Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care___Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care___Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care- Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ozzzzzzzzzzzzzzt_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzza_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzzzzc_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzd_);
        CqlValueSet pzzzzzzzzzzzzzzf_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzj_);
        CqlValueSet pzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzzzzn_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzp_);
        CqlValueSet pzzzzzzzzzzzzzzr_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzzzzt_ = this.Online_Assessments(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzv_);
        bool? pzzzzzzzzzzzzzzx_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzza_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzza_ as object);
            bool? qzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzb_, default);
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzd_ = ValidEncounter?.StatusElement;
            string qzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzzd_);
            bool? qzzzzzzzzzzzzzzf_ = context.Operators.Equal(qzzzzzzzzzzzzzze_, "finished");
            bool? qzzzzzzzzzzzzzzg_ = context.Operators.And(qzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzf_);

            return qzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date qzzzzzzzzzzzzzzi_ = qzzzzzzzzzzzzzzh_?.BirthDateElement;
        string qzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzi_?.Value;
        CqlDate qzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzzzzzm_ = context.Operators.Start(qzzzzzzzzzzzzzzl_);
        CqlDate qzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzm_);
        int? qzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzn_, "month");
        bool? qzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzo_, 6);
        Date qzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzh_?.BirthDateElement;
        string qzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzr_?.Value;
        CqlDate qzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzs_);
        CqlDateTime qzzzzzzzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzzzzzzzl_);
        CqlDate qzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzv_);
        int? qzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzw_, "year");
        bool? qzzzzzzzzzzzzzzy_ = context.Operators.Less(qzzzzzzzzzzzzzzx_, 20);
        bool? qzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzza_ = this.Qualifying_Encounters(context);
        bool? rzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return rzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzze_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);

        return rzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzf_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzf_?.BirthDateElement;
        string rzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzg_?.Value;
        CqlDate rzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzk_ = context.Operators.Start(rzzzzzzzzzzzzzzj_);
        CqlDate rzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzk_);
        int? rzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzl_, "month");
        bool? rzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzm_, 6);
        Date rzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzf_?.BirthDateElement;
        string rzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzp_?.Value;
        CqlDate rzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzq_);
        CqlDateTime rzzzzzzzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzzzzzzzj_);
        CqlDate rzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzt_);
        int? rzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzu_, "year");
        bool? rzzzzzzzzzzzzzzw_ = context.Operators.LessOrEqual(rzzzzzzzzzzzzzzv_, 4);
        bool? rzzzzzzzzzzzzzzx_ = context.Operators.And(rzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzy_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzy_?.BirthDateElement;
        string szzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzz_?.Value;
        CqlDate szzzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzc_);
        CqlDate szzzzzzzzzzzzzze_ = context.Operators.DateFrom(szzzzzzzzzzzzzzd_);
        int? szzzzzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzb_, szzzzzzzzzzzzzze_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzg_ = context.Operators.Interval(5, 11, true, true);
        bool? szzzzzzzzzzzzzzh_ = context.Operators.In<int?>(szzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzg_, default);

        return szzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzi_ = this.Patient(context);
        Date szzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzi_?.BirthDateElement;
        string szzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzj_?.Value;
        CqlDate szzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzn_ = context.Operators.Start(szzzzzzzzzzzzzzm_);
        CqlDate szzzzzzzzzzzzzzo_ = context.Operators.DateFrom(szzzzzzzzzzzzzzn_);
        int? szzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzo_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzq_ = context.Operators.Interval(12, 20, true, false);
        bool? szzzzzzzzzzzzzzr_ = context.Operators.In<int?>(szzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzq_, default);

        return szzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzs_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzzzzzu_(Procedure FluorideApplication)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            DataType szzzzzzzzzzzzzzy_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzz_, default);
            Code<EventStatus> tzzzzzzzzzzzzzzb_ = FluorideApplication?.StatusElement;
            string tzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzzzb_);
            bool? tzzzzzzzzzzzzzzd_ = context.Operators.Equal(tzzzzzzzzzzzzzzc_, "completed");
            bool? tzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzd_);

            return tzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
