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
        object ozzzzzzzzzzzzzzf_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzg_);

        return ozzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzzzzzo_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzp_);
        CqlValueSet ozzzzzzzzzzzzzzr_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzzzzzt_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzv_);
        CqlValueSet ozzzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzzzzzz_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzb_);
        CqlValueSet pzzzzzzzzzzzzzzd_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzzzzf_ = this.Online_Assessments(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzj_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzm_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzm_ as object);
            bool? pzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzn_, default);
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzp_ = ValidEncounter?.StatusElement;
            string pzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzp_);
            bool? pzzzzzzzzzzzzzzr_ = context.Operators.Equal(pzzzzzzzzzzzzzzq_, "finished");
            bool? pzzzzzzzzzzzzzzs_ = context.Operators.And(pzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzr_);

            return pzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzt_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzt_?.BirthDateElement;
        string pzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzu_?.Value;
        CqlDate pzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzx_);
        CqlDate pzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzy_);
        int? qzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzz_, "month");
        bool? qzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzza_, 6);
        Date qzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzt_?.BirthDateElement;
        string qzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzd_?.Value;
        CqlDate qzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzze_);
        CqlDateTime qzzzzzzzzzzzzzzh_ = context.Operators.Start(pzzzzzzzzzzzzzzx_);
        CqlDate qzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzh_);
        int? qzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzi_, "year");
        bool? qzzzzzzzzzzzzzzk_ = context.Operators.Less(qzzzzzzzzzzzzzzj_, 20);
        bool? qzzzzzzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        bool? qzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzq_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);

        return qzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date qzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzr_?.BirthDateElement;
        string qzzzzzzzzzzzzzzt_ = qzzzzzzzzzzzzzzs_?.Value;
        CqlDate qzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzv_);
        CqlDate qzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzw_);
        int? qzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzx_, "month");
        bool? qzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzy_, 6);
        Date rzzzzzzzzzzzzzzb_ = qzzzzzzzzzzzzzzr_?.BirthDateElement;
        string rzzzzzzzzzzzzzzc_ = rzzzzzzzzzzzzzzb_?.Value;
        CqlDate rzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzc_);
        CqlDateTime rzzzzzzzzzzzzzzf_ = context.Operators.Start(qzzzzzzzzzzzzzzv_);
        CqlDate rzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzf_);
        int? rzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzg_, "year");
        bool? rzzzzzzzzzzzzzzi_ = context.Operators.LessOrEqual(rzzzzzzzzzzzzzzh_, 4);
        bool? rzzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzk_?.BirthDateElement;
        string rzzzzzzzzzzzzzzm_ = rzzzzzzzzzzzzzzl_?.Value;
        CqlDate rzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzo_);
        CqlDate rzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzp_);
        int? rzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzq_, "year");
        CqlInterval<int?> rzzzzzzzzzzzzzzs_ = context.Operators.Interval(5, 11, true, true);
        bool? rzzzzzzzzzzzzzzt_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzs_, default);

        return rzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzu_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzu_?.BirthDateElement;
        string rzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzv_?.Value;
        CqlDate rzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzz_ = context.Operators.Start(rzzzzzzzzzzzzzzy_);
        CqlDate szzzzzzzzzzzzzza_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzz_);
        int? szzzzzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzza_, "year");
        CqlInterval<int?> szzzzzzzzzzzzzzc_ = context.Operators.Interval(12, 20, true, false);
        bool? szzzzzzzzzzzzzzd_ = context.Operators.In<int?>(szzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzc_, default);

        return szzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzze_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzzzzzg_(Procedure FluorideApplication)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            DataType szzzzzzzzzzzzzzk_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzk_);
            bool? szzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzl_, default);
            Code<EventStatus> szzzzzzzzzzzzzzn_ = FluorideApplication?.StatusElement;
            string szzzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzp_ = context.Operators.Equal(szzzzzzzzzzzzzzo_, "completed");
            bool? szzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzp_);

            return szzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzi_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzh_);

        return szzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
