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
      new CqlCodeSystem("http://loinc.org", null,
          _Birth_date);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object wzzzzzzzzze_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzf_);

        return wzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> wzzzzzzzzzi_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> wzzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return wzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzzzzzn_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> wzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzzzzzp_ = context.Operators.Union<Encounter>(wzzzzzzzzzm_, wzzzzzzzzzo_);
        CqlValueSet wzzzzzzzzzq_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> wzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzzzzzs_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> wzzzzzzzzzu_ = context.Operators.Union<Encounter>(wzzzzzzzzzr_, wzzzzzzzzzt_);
        IEnumerable<Encounter> wzzzzzzzzzv_ = context.Operators.Union<Encounter>(wzzzzzzzzzp_, wzzzzzzzzzu_);
        CqlValueSet wzzzzzzzzzw_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> wzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet wzzzzzzzzzy_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> wzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzzzzzzzza_ = context.Operators.Union<Encounter>(wzzzzzzzzzx_, wzzzzzzzzzz_);
        IEnumerable<Encounter> xzzzzzzzzzb_ = context.Operators.Union<Encounter>(wzzzzzzzzzv_, xzzzzzzzzza_);
        CqlValueSet xzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> xzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet xzzzzzzzzze_ = this.Online_Assessments(context);
        IEnumerable<Encounter> xzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> xzzzzzzzzzg_ = context.Operators.Union<Encounter>(xzzzzzzzzzd_, xzzzzzzzzzf_);
        IEnumerable<Encounter> xzzzzzzzzzh_ = context.Operators.Union<Encounter>(xzzzzzzzzzb_, xzzzzzzzzzg_);
        bool? xzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzk_ = this.Measurement_Period(context);
            Period xzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzl_ as object);
            bool? xzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzk_, xzzzzzzzzzm_, default);
            Code<Encounter.EncounterStatus> xzzzzzzzzzo_ = ValidEncounter?.StatusElement;
            string xzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzo_);
            bool? xzzzzzzzzzq_ = context.Operators.Equal(xzzzzzzzzzp_, "finished");
            bool? xzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzn_, xzzzzzzzzzq_);

            return xzzzzzzzzzr_;
        };
        IEnumerable<Encounter> xzzzzzzzzzj_ = context.Operators.Where<Encounter>(xzzzzzzzzzh_, xzzzzzzzzzi_);

        return xzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient xzzzzzzzzzs_ = this.Patient(context);
        Date xzzzzzzzzzt_ = xzzzzzzzzzs_?.BirthDateElement;
        string xzzzzzzzzzu_ = xzzzzzzzzzt_?.Value;
        CqlDate xzzzzzzzzzv_ = context.Operators.ConvertStringToDate(xzzzzzzzzzu_);
        CqlInterval<CqlDateTime> xzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzx_ = context.Operators.Start(xzzzzzzzzzw_);
        CqlDate xzzzzzzzzzy_ = context.Operators.DateFrom(xzzzzzzzzzx_);
        int? xzzzzzzzzzz_ = context.Operators.CalculateAgeAt(xzzzzzzzzzv_, xzzzzzzzzzy_, "month");
        bool? yzzzzzzzzza_ = context.Operators.GreaterOrEqual(xzzzzzzzzzz_, 6);
        Date yzzzzzzzzzc_ = xzzzzzzzzzs_?.BirthDateElement;
        string yzzzzzzzzzd_ = yzzzzzzzzzc_?.Value;
        CqlDate yzzzzzzzzze_ = context.Operators.ConvertStringToDate(yzzzzzzzzzd_);
        CqlDateTime yzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzw_);
        CqlDate yzzzzzzzzzh_ = context.Operators.DateFrom(yzzzzzzzzzg_);
        int? yzzzzzzzzzi_ = context.Operators.CalculateAgeAt(yzzzzzzzzze_, yzzzzzzzzzh_, "year");
        bool? yzzzzzzzzzj_ = context.Operators.Less(yzzzzzzzzzi_, 20);
        bool? yzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzza_, yzzzzzzzzzj_);
        IEnumerable<Encounter> yzzzzzzzzzl_ = this.Qualifying_Encounters(context);
        bool? yzzzzzzzzzm_ = context.Operators.Exists<Encounter>(yzzzzzzzzzl_);
        bool? yzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzk_, yzzzzzzzzzm_);

        return yzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? yzzzzzzzzzo_ = this.Initial_Population(context);

        return yzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? yzzzzzzzzzp_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);

        return yzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient yzzzzzzzzzq_ = this.Patient(context);
        Date yzzzzzzzzzr_ = yzzzzzzzzzq_?.BirthDateElement;
        string yzzzzzzzzzs_ = yzzzzzzzzzr_?.Value;
        CqlDate yzzzzzzzzzt_ = context.Operators.ConvertStringToDate(yzzzzzzzzzs_);
        CqlInterval<CqlDateTime> yzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzv_ = context.Operators.Start(yzzzzzzzzzu_);
        CqlDate yzzzzzzzzzw_ = context.Operators.DateFrom(yzzzzzzzzzv_);
        int? yzzzzzzzzzx_ = context.Operators.CalculateAgeAt(yzzzzzzzzzt_, yzzzzzzzzzw_, "month");
        bool? yzzzzzzzzzy_ = context.Operators.GreaterOrEqual(yzzzzzzzzzx_, 6);
        Date zzzzzzzzzza_ = yzzzzzzzzzq_?.BirthDateElement;
        string zzzzzzzzzzb_ = zzzzzzzzzza_?.Value;
        CqlDate zzzzzzzzzzc_ = context.Operators.ConvertStringToDate(zzzzzzzzzzb_);
        CqlDateTime zzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzu_);
        CqlDate zzzzzzzzzzf_ = context.Operators.DateFrom(zzzzzzzzzze_);
        int? zzzzzzzzzzg_ = context.Operators.CalculateAgeAt(zzzzzzzzzzc_, zzzzzzzzzzf_, "year");
        bool? zzzzzzzzzzh_ = context.Operators.LessOrEqual(zzzzzzzzzzg_, 4);
        bool? zzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzy_, zzzzzzzzzzh_);

        return zzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient zzzzzzzzzzj_ = this.Patient(context);
        Date zzzzzzzzzzk_ = zzzzzzzzzzj_?.BirthDateElement;
        string zzzzzzzzzzl_ = zzzzzzzzzzk_?.Value;
        CqlDate zzzzzzzzzzm_ = context.Operators.ConvertStringToDate(zzzzzzzzzzl_);
        CqlInterval<CqlDateTime> zzzzzzzzzzn_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzn_);
        CqlDate zzzzzzzzzzp_ = context.Operators.DateFrom(zzzzzzzzzzo_);
        int? zzzzzzzzzzq_ = context.Operators.CalculateAgeAt(zzzzzzzzzzm_, zzzzzzzzzzp_, "year");
        CqlInterval<int?> zzzzzzzzzzr_ = context.Operators.Interval(5, 11, true, true);
        bool? zzzzzzzzzzs_ = context.Operators.In<int?>(zzzzzzzzzzq_, zzzzzzzzzzr_, default);

        return zzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient zzzzzzzzzzt_ = this.Patient(context);
        Date zzzzzzzzzzu_ = zzzzzzzzzzt_?.BirthDateElement;
        string zzzzzzzzzzv_ = zzzzzzzzzzu_?.Value;
        CqlDate zzzzzzzzzzw_ = context.Operators.ConvertStringToDate(zzzzzzzzzzv_);
        CqlInterval<CqlDateTime> zzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzy_ = context.Operators.Start(zzzzzzzzzzx_);
        CqlDate zzzzzzzzzzz_ = context.Operators.DateFrom(zzzzzzzzzzy_);
        int? azzzzzzzzzza_ = context.Operators.CalculateAgeAt(zzzzzzzzzzw_, zzzzzzzzzzz_, "year");
        CqlInterval<int?> azzzzzzzzzzb_ = context.Operators.Interval(12, 20, true, false);
        bool? azzzzzzzzzzc_ = context.Operators.In<int?>(azzzzzzzzzza_, azzzzzzzzzzb_, default);

        return azzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzd_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> azzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? azzzzzzzzzzf_(Procedure FluorideApplication)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzi_ = this.Measurement_Period(context);
            DataType azzzzzzzzzzj_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> azzzzzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzj_);
            bool? azzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzi_, azzzzzzzzzzk_, default);
            Code<EventStatus> azzzzzzzzzzm_ = FluorideApplication?.StatusElement;
            string azzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzm_);
            bool? azzzzzzzzzzo_ = context.Operators.Equal(azzzzzzzzzzn_, "completed");
            bool? azzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzl_, azzzzzzzzzzo_);

            return azzzzzzzzzzp_;
        };
        IEnumerable<Procedure> azzzzzzzzzzg_ = context.Operators.Where<Procedure>(azzzzzzzzzze_, azzzzzzzzzzf_);
        bool? azzzzzzzzzzh_ = context.Operators.Exists<Procedure>(azzzzzzzzzzg_);

        return azzzzzzzzzzh_;
    }


    #endregion Expressions

}
