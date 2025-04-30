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
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object lzzzzzzzzzzj_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient lzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzk_);

        return lzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> lzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return lzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return lzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzzs_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzu_ = context.Operators.Union<Encounter>(lzzzzzzzzzzr_, lzzzzzzzzzzt_);
        CqlValueSet lzzzzzzzzzzv_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> lzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzzx_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> lzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzz_ = context.Operators.Union<Encounter>(lzzzzzzzzzzw_, lzzzzzzzzzzy_);
        IEnumerable<Encounter> mzzzzzzzzzza_ = context.Operators.Union<Encounter>(lzzzzzzzzzzu_, lzzzzzzzzzzz_);
        CqlValueSet mzzzzzzzzzzb_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet mzzzzzzzzzzd_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> mzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzf_ = context.Operators.Union<Encounter>(mzzzzzzzzzzc_, mzzzzzzzzzze_);
        IEnumerable<Encounter> mzzzzzzzzzzg_ = context.Operators.Union<Encounter>(mzzzzzzzzzza_, mzzzzzzzzzzf_);
        CqlValueSet mzzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> mzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet mzzzzzzzzzzj_ = this.Online_Assessments(context);
        IEnumerable<Encounter> mzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzl_ = context.Operators.Union<Encounter>(mzzzzzzzzzzi_, mzzzzzzzzzzk_);
        IEnumerable<Encounter> mzzzzzzzzzzm_ = context.Operators.Union<Encounter>(mzzzzzzzzzzg_, mzzzzzzzzzzl_);
        bool? mzzzzzzzzzzn_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period mzzzzzzzzzzq_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzq_ as object);
            bool? mzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzp_, mzzzzzzzzzzr_, default);
            Code<Encounter.EncounterStatus> mzzzzzzzzzzt_ = ValidEncounter?.StatusElement;
            string mzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzt_);
            bool? mzzzzzzzzzzv_ = context.Operators.Equal(mzzzzzzzzzzu_, "finished");
            bool? mzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzs_, mzzzzzzzzzzv_);

            return mzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzo_ = context.Operators.Where<Encounter>(mzzzzzzzzzzm_, mzzzzzzzzzzn_);

        return mzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzzzzzzx_ = this.Patient(context);
        Date mzzzzzzzzzzy_ = mzzzzzzzzzzx_?.BirthDateElement;
        string mzzzzzzzzzzz_ = mzzzzzzzzzzy_?.Value;
        CqlDate nzzzzzzzzzza_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzc_ = context.Operators.Start(nzzzzzzzzzzb_);
        CqlDate nzzzzzzzzzzd_ = context.Operators.DateFrom(nzzzzzzzzzzc_);
        int? nzzzzzzzzzze_ = context.Operators.CalculateAgeAt(nzzzzzzzzzza_, nzzzzzzzzzzd_, "month");
        bool? nzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(nzzzzzzzzzze_, 6);
        Date nzzzzzzzzzzh_ = mzzzzzzzzzzx_?.BirthDateElement;
        string nzzzzzzzzzzi_ = nzzzzzzzzzzh_?.Value;
        CqlDate nzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzi_);
        CqlDateTime nzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzb_);
        CqlDate nzzzzzzzzzzm_ = context.Operators.DateFrom(nzzzzzzzzzzl_);
        int? nzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzj_, nzzzzzzzzzzm_, "year");
        bool? nzzzzzzzzzzo_ = context.Operators.Less(nzzzzzzzzzzn_, 20);
        bool? nzzzzzzzzzzp_ = context.Operators.And(nzzzzzzzzzzf_, nzzzzzzzzzzo_);
        IEnumerable<Encounter> nzzzzzzzzzzq_ = this.Qualifying_Encounters(context);
        bool? nzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzq_);
        bool? nzzzzzzzzzzs_ = context.Operators.And(nzzzzzzzzzzp_, nzzzzzzzzzzr_);

        return nzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzt_ = this.Initial_Population(context);

        return nzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzzzzzzzu_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);

        return nzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient nzzzzzzzzzzv_ = this.Patient(context);
        Date nzzzzzzzzzzw_ = nzzzzzzzzzzv_?.BirthDateElement;
        string nzzzzzzzzzzx_ = nzzzzzzzzzzw_?.Value;
        CqlDate nzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzzz_);
        CqlDate ozzzzzzzzzzb_ = context.Operators.DateFrom(ozzzzzzzzzza_);
        int? ozzzzzzzzzzc_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzy_, ozzzzzzzzzzb_, "month");
        bool? ozzzzzzzzzzd_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzc_, 6);
        Date ozzzzzzzzzzf_ = nzzzzzzzzzzv_?.BirthDateElement;
        string ozzzzzzzzzzg_ = ozzzzzzzzzzf_?.Value;
        CqlDate ozzzzzzzzzzh_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzg_);
        CqlDateTime ozzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzz_);
        CqlDate ozzzzzzzzzzk_ = context.Operators.DateFrom(ozzzzzzzzzzj_);
        int? ozzzzzzzzzzl_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzh_, ozzzzzzzzzzk_, "year");
        bool? ozzzzzzzzzzm_ = context.Operators.LessOrEqual(ozzzzzzzzzzl_, 4);
        bool? ozzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzd_, ozzzzzzzzzzm_);

        return ozzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient ozzzzzzzzzzo_ = this.Patient(context);
        Date ozzzzzzzzzzp_ = ozzzzzzzzzzo_?.BirthDateElement;
        string ozzzzzzzzzzq_ = ozzzzzzzzzzp_?.Value;
        CqlDate ozzzzzzzzzzr_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzq_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzs_);
        CqlDate ozzzzzzzzzzu_ = context.Operators.DateFrom(ozzzzzzzzzzt_);
        int? ozzzzzzzzzzv_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzr_, ozzzzzzzzzzu_, "year");
        CqlInterval<int?> ozzzzzzzzzzw_ = context.Operators.Interval(5, 11, true, true);
        bool? ozzzzzzzzzzx_ = context.Operators.In<int?>(ozzzzzzzzzzv_, ozzzzzzzzzzw_, default);

        return ozzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient ozzzzzzzzzzy_ = this.Patient(context);
        Date ozzzzzzzzzzz_ = ozzzzzzzzzzy_?.BirthDateElement;
        string pzzzzzzzzzza_ = ozzzzzzzzzzz_?.Value;
        CqlDate pzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(pzzzzzzzzzza_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzd_ = context.Operators.Start(pzzzzzzzzzzc_);
        CqlDate pzzzzzzzzzze_ = context.Operators.DateFrom(pzzzzzzzzzzd_);
        int? pzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzb_, pzzzzzzzzzze_, "year");
        CqlInterval<int?> pzzzzzzzzzzg_ = context.Operators.Interval(12, 20, true, false);
        bool? pzzzzzzzzzzh_ = context.Operators.In<int?>(pzzzzzzzzzzf_, pzzzzzzzzzzg_, default);

        return pzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzi_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> pzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? pzzzzzzzzzzk_(Procedure FluorideApplication)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzn_ = this.Measurement_Period(context);
            DataType pzzzzzzzzzzo_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> pzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzo_);
            bool? pzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzn_, pzzzzzzzzzzp_, default);
            Code<EventStatus> pzzzzzzzzzzr_ = FluorideApplication?.StatusElement;
            string pzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzr_);
            bool? pzzzzzzzzzzt_ = context.Operators.Equal(pzzzzzzzzzzs_, "completed");
            bool? pzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzq_, pzzzzzzzzzzt_);

            return pzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzl_ = context.Operators.Where<Procedure>(pzzzzzzzzzzj_, pzzzzzzzzzzk_);
        bool? pzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzl_);

        return pzzzzzzzzzzm_;
    }


    #endregion Expressions

}
