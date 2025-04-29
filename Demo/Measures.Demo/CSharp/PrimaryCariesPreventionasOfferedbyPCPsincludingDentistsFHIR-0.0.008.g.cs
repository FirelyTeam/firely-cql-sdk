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

    #region ValueSet: Clinical Oral Evaluation
    [CqlValueSetDefinition(
        definitionName: "Clinical Oral Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext context) => _Clinical_Oral_Evaluation;

    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);
    #endregion

    #region ValueSet: Fluoride Varnish Application for Children
    [CqlValueSetDefinition(
        definitionName: "Fluoride Varnish Application for Children",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002",
        valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext context) => _Fluoride_Varnish_Application_for_Children;

    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Online Assessments
    [CqlValueSetDefinition(
        definitionName: "Online Assessments",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext context) => _Online_Assessments;

    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Preventive Care - Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care - Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care___Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care___Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care___Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care- Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care- Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] qzzzzf_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return qzzzzf_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object qzzzzg_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyPCPsincludingDentistsFHIR-0.0.008", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)qzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzi_ = context.Operators.SingletonFrom<Patient>(qzzzzh_);

        return qzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> qzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return qzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> qzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return qzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> qzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return qzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return qzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzp_ = this.Preventive_Care___Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzr_ = context.Operators.Union<Encounter>(qzzzzo_, qzzzzq_);
        CqlValueSet qzzzzs_ = this.Preventive_Care__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzu_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzw_ = context.Operators.Union<Encounter>(qzzzzt_, qzzzzv_);
        IEnumerable<Encounter> qzzzzx_ = context.Operators.Union<Encounter>(qzzzzr_, qzzzzw_);
        CqlValueSet qzzzzy_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzza_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> rzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzc_ = context.Operators.Union<Encounter>(qzzzzz_, rzzzzb_);
        IEnumerable<Encounter> rzzzzd_ = context.Operators.Union<Encounter>(qzzzzx_, rzzzzc_);
        CqlValueSet rzzzze_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzg_ = this.Online_Assessments(context);
        IEnumerable<Encounter> rzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzi_ = context.Operators.Union<Encounter>(rzzzzf_, rzzzzh_);
        IEnumerable<Encounter> rzzzzj_ = context.Operators.Union<Encounter>(rzzzzd_, rzzzzi_);
        bool? rzzzzk_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> rzzzzm_ = this.Measurement_Period(context);
            Period rzzzzn_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzn_ as object);
            bool? rzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzm_, rzzzzo_, default);
            Code<Encounter.EncounterStatus> rzzzzq_ = ValidEncounter?.StatusElement;
            string rzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzq_);
            bool? rzzzzs_ = context.Operators.Equal(rzzzzr_, "finished");
            bool? rzzzzt_ = context.Operators.And(rzzzzp_, rzzzzs_);

            return rzzzzt_;
        };
        IEnumerable<Encounter> rzzzzl_ = context.Operators.Where<Encounter>(rzzzzj_, rzzzzk_);

        return rzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzu_ = this.Patient(context);
        Date rzzzzv_ = rzzzzu_?.BirthDateElement;
        string rzzzzw_ = rzzzzv_?.Value;
        CqlDate rzzzzx_ = context.Operators.ConvertStringToDate(rzzzzw_);
        CqlInterval<CqlDateTime> rzzzzy_ = this.Measurement_Period(context);
        CqlDateTime rzzzzz_ = context.Operators.Start(rzzzzy_);
        CqlDate szzzza_ = context.Operators.DateFrom(rzzzzz_);
        int? szzzzb_ = context.Operators.CalculateAgeAt(rzzzzx_, szzzza_, "month");
        bool? szzzzc_ = context.Operators.GreaterOrEqual(szzzzb_, 6);
        Date szzzze_ = rzzzzu_?.BirthDateElement;
        string szzzzf_ = szzzze_?.Value;
        CqlDate szzzzg_ = context.Operators.ConvertStringToDate(szzzzf_);
        CqlDateTime szzzzi_ = context.Operators.Start(rzzzzy_);
        CqlDate szzzzj_ = context.Operators.DateFrom(szzzzi_);
        int? szzzzk_ = context.Operators.CalculateAgeAt(szzzzg_, szzzzj_, "year");
        bool? szzzzl_ = context.Operators.Less(szzzzk_, 20);
        bool? szzzzm_ = context.Operators.And(szzzzc_, szzzzl_);
        IEnumerable<Encounter> szzzzn_ = this.Qualifying_Encounters(context);
        bool? szzzzo_ = context.Operators.Exists<Encounter>(szzzzn_);
        bool? szzzzp_ = context.Operators.And(szzzzm_, szzzzo_);

        return szzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzq_ = this.Initial_Population(context);

        return szzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? szzzzr_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);

        return szzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient szzzzs_ = this.Patient(context);
        Date szzzzt_ = szzzzs_?.BirthDateElement;
        string szzzzu_ = szzzzt_?.Value;
        CqlDate szzzzv_ = context.Operators.ConvertStringToDate(szzzzu_);
        CqlInterval<CqlDateTime> szzzzw_ = this.Measurement_Period(context);
        CqlDateTime szzzzx_ = context.Operators.Start(szzzzw_);
        CqlDate szzzzy_ = context.Operators.DateFrom(szzzzx_);
        int? szzzzz_ = context.Operators.CalculateAgeAt(szzzzv_, szzzzy_, "month");
        bool? tzzzza_ = context.Operators.GreaterOrEqual(szzzzz_, 6);
        Date tzzzzc_ = szzzzs_?.BirthDateElement;
        string tzzzzd_ = tzzzzc_?.Value;
        CqlDate tzzzze_ = context.Operators.ConvertStringToDate(tzzzzd_);
        CqlDateTime tzzzzg_ = context.Operators.Start(szzzzw_);
        CqlDate tzzzzh_ = context.Operators.DateFrom(tzzzzg_);
        int? tzzzzi_ = context.Operators.CalculateAgeAt(tzzzze_, tzzzzh_, "year");
        bool? tzzzzj_ = context.Operators.LessOrEqual(tzzzzi_, 4);
        bool? tzzzzk_ = context.Operators.And(tzzzza_, tzzzzj_);

        return tzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient tzzzzl_ = this.Patient(context);
        Date tzzzzm_ = tzzzzl_?.BirthDateElement;
        string tzzzzn_ = tzzzzm_?.Value;
        CqlDate tzzzzo_ = context.Operators.ConvertStringToDate(tzzzzn_);
        CqlInterval<CqlDateTime> tzzzzp_ = this.Measurement_Period(context);
        CqlDateTime tzzzzq_ = context.Operators.Start(tzzzzp_);
        CqlDate tzzzzr_ = context.Operators.DateFrom(tzzzzq_);
        int? tzzzzs_ = context.Operators.CalculateAgeAt(tzzzzo_, tzzzzr_, "year");
        CqlInterval<int?> tzzzzt_ = context.Operators.Interval(5, 11, true, true);
        bool? tzzzzu_ = context.Operators.In<int?>(tzzzzs_, tzzzzt_, default);

        return tzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient tzzzzv_ = this.Patient(context);
        Date tzzzzw_ = tzzzzv_?.BirthDateElement;
        string tzzzzx_ = tzzzzw_?.Value;
        CqlDate tzzzzy_ = context.Operators.ConvertStringToDate(tzzzzx_);
        CqlInterval<CqlDateTime> tzzzzz_ = this.Measurement_Period(context);
        CqlDateTime uzzzza_ = context.Operators.Start(tzzzzz_);
        CqlDate uzzzzb_ = context.Operators.DateFrom(uzzzza_);
        int? uzzzzc_ = context.Operators.CalculateAgeAt(tzzzzy_, uzzzzb_, "year");
        CqlInterval<int?> uzzzzd_ = context.Operators.Interval(12, 20, true, false);
        bool? uzzzze_ = context.Operators.In<int?>(uzzzzc_, uzzzzd_, default);

        return uzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet uzzzzf_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> uzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? uzzzzh_(Procedure FluorideApplication)
        {
            CqlInterval<CqlDateTime> uzzzzk_ = this.Measurement_Period(context);
            DataType uzzzzl_ = FluorideApplication?.Performed;
            CqlInterval<CqlDateTime> uzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzl_);
            bool? uzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzk_, uzzzzm_, default);
            Code<EventStatus> uzzzzo_ = FluorideApplication?.StatusElement;
            string uzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzo_);
            bool? uzzzzq_ = context.Operators.Equal(uzzzzp_, "completed");
            bool? uzzzzr_ = context.Operators.And(uzzzzn_, uzzzzq_);

            return uzzzzr_;
        };
        IEnumerable<Procedure> uzzzzi_ = context.Operators.Where<Procedure>(uzzzzg_, uzzzzh_);
        bool? uzzzzj_ = context.Operators.Exists<Procedure>(uzzzzi_);

        return uzzzzj_;
    }


    #endregion Expressions

}
