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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public partial class CervicalCancerScreeningFHIR_0_0_005 : ILibrary, ISingleton<CervicalCancerScreeningFHIR_0_0_005>
{
    private CervicalCancerScreeningFHIR_0_0_005() {}

    public static CervicalCancerScreeningFHIR_0_0_005 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CervicalCancerScreeningFHIR";
    public string Version => "0.0.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, HospiceFHIR4_2_3_000.Instance, PalliativeCareFHIR_0_6_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Congenital or Acquired Absence of Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext _) => _Congenital_or_Acquired_Absence_of_Cervix;
    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("HPV Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext _) => _HPV_Test;
    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlValueSetDefinition("Hysterectomy with No Residual Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext _) => _Hysterectomy_with_No_Residual_Cervix;
    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzx_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime qzzzzzzzy_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> qzzzzzzzz_ = context.Operators.Interval(qzzzzzzzx_, qzzzzzzzy_, true, false);
        object rzzzzzzza_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", qzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)rzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzb_);

        return rzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> rzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> rzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return rzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> rzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return rzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return rzzzzzzzg_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet rzzzzzzzh_ = this.Office_Visit(context);
        IEnumerable<Encounter> rzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzj_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzl_ = context.Operators.Union<Encounter>(rzzzzzzzi_, rzzzzzzzk_);
        CqlValueSet rzzzzzzzm_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzo_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> rzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzq_ = context.Operators.Union<Encounter>(rzzzzzzzn_, rzzzzzzzp_);
        IEnumerable<Encounter> rzzzzzzzr_ = context.Operators.Union<Encounter>(rzzzzzzzl_, rzzzzzzzq_);
        CqlValueSet rzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzu_ = this.Online_Assessments(context);
        IEnumerable<Encounter> rzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzw_ = context.Operators.Union<Encounter>(rzzzzzzzt_, rzzzzzzzv_);
        IEnumerable<Encounter> rzzzzzzzx_ = context.Operators.Union<Encounter>(rzzzzzzzr_, rzzzzzzzw_);
        bool? rzzzzzzzy_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> szzzzzzza_ = ValidEncounter?.StatusElement;
            string szzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzza_);
            bool? szzzzzzzc_ = context.Operators.Equal(szzzzzzzb_, "finished");
            CqlInterval<CqlDateTime> szzzzzzzd_ = this.Measurement_Period(context);
            Period szzzzzzze_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, szzzzzzze_);
            bool? szzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzd_, szzzzzzzf_, default);
            bool? szzzzzzzh_ = context.Operators.And(szzzzzzzc_, szzzzzzzg_);

            return szzzzzzzh_;
        };
        IEnumerable<Encounter> rzzzzzzzz_ = context.Operators.Where<Encounter>(rzzzzzzzx_, rzzzzzzzy_);

        return rzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient szzzzzzzi_ = this.Patient(context);
        Date szzzzzzzj_ = szzzzzzzi_?.BirthDateElement;
        string szzzzzzzk_ = szzzzzzzj_?.Value;
        CqlDate szzzzzzzl_ = context.Operators.ConvertStringToDate(szzzzzzzk_);
        CqlInterval<CqlDateTime> szzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzn_ = context.Operators.Start(szzzzzzzm_);
        CqlDate szzzzzzzo_ = context.Operators.DateFrom(szzzzzzzn_);
        int? szzzzzzzp_ = context.Operators.CalculateAgeAt(szzzzzzzl_, szzzzzzzo_, "year");
        CqlInterval<int?> szzzzzzzq_ = context.Operators.Interval(23, 64, true, false);
        bool? szzzzzzzr_ = context.Operators.In<int?>(szzzzzzzp_, szzzzzzzq_, default);
        Code<AdministrativeGender> szzzzzzzt_ = szzzzzzzi_?.GenderElement;
        string szzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzt_);
        bool? szzzzzzzv_ = context.Operators.Equal(szzzzzzzu_, "female");
        bool? szzzzzzzw_ = context.Operators.And(szzzzzzzr_, szzzzzzzv_);
        IEnumerable<Encounter> szzzzzzzx_ = this.Qualifying_Encounters(context);
        bool? szzzzzzzy_ = context.Operators.Exists<Encounter>(szzzzzzzx_);
        bool? szzzzzzzz_ = context.Operators.And(szzzzzzzw_, szzzzzzzy_);

        return szzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? tzzzzzzza_ = this.Initial_Population(context);

        return tzzzzzzza_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet tzzzzzzzb_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> tzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzzd_(Procedure NoCervixProcedure)
        {
            Code<EventStatus> tzzzzzzzk_ = NoCervixProcedure?.StatusElement;
            string tzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzk_);
            bool? tzzzzzzzm_ = context.Operators.Equal(tzzzzzzzl_, "completed");
            DataType tzzzzzzzn_ = NoCervixProcedure?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzn_);
            CqlDateTime tzzzzzzzp_ = context.Operators.End(tzzzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzr_ = context.Operators.End(tzzzzzzzq_);
            bool? tzzzzzzzs_ = context.Operators.SameOrBefore(tzzzzzzzp_, tzzzzzzzr_, default);
            bool? tzzzzzzzt_ = context.Operators.And(tzzzzzzzm_, tzzzzzzzs_);

            return tzzzzzzzt_;
        };
        IEnumerable<Procedure> tzzzzzzze_ = context.Operators.Where<Procedure>(tzzzzzzzc_, tzzzzzzzd_);
        CqlValueSet tzzzzzzzf_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> tzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tzzzzzzzh_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime tzzzzzzzv_ = context.Operators.Start(tzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzx_ = context.Operators.End(tzzzzzzzw_);
            bool? tzzzzzzzy_ = context.Operators.SameOrBefore(tzzzzzzzv_, tzzzzzzzx_, default);

            return tzzzzzzzy_;
        };
        IEnumerable<Condition> tzzzzzzzi_ = context.Operators.Where<Condition>(tzzzzzzzg_, tzzzzzzzh_);
        IEnumerable<object> tzzzzzzzj_ = context.Operators.Union<object>(tzzzzzzze_ as IEnumerable<object>, tzzzzzzzi_ as IEnumerable<object>);

        return tzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? tzzzzzzzz_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<object> uzzzzzzza_ = this.Absence_of_Cervix(context);
        bool? uzzzzzzzb_ = context.Operators.Exists<object>(uzzzzzzza_);
        bool? uzzzzzzzc_ = context.Operators.Or(tzzzzzzzz_, uzzzzzzzb_);
        bool? uzzzzzzzd_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? uzzzzzzze_ = context.Operators.Or(uzzzzzzzc_, uzzzzzzzd_);

        return uzzzzzzze_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet uzzzzzzzf_ = this.Pap_Test(context);
        IEnumerable<Observation> uzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzzh_(Observation CervicalCytology)
        {
            Code<ObservationStatus> uzzzzzzzj_ = CervicalCytology?.StatusElement;
            string uzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzj_);
            string[] uzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzm_ = context.Operators.In<string>(uzzzzzzzk_, uzzzzzzzl_ as IEnumerable<string>);
            List<CodeableConcept> uzzzzzzzn_ = CervicalCytology?.Category;
            bool? uzzzzzzzo_(CodeableConcept CervicalCytologyCategory)
            {
                CqlCode vzzzzzzzk_ = this.laboratory(context);
                CqlConcept vzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                CqlCode[] vzzzzzzzm_ = vzzzzzzzl_?.codes;
                bool? vzzzzzzzn_ = context.Operators.In<CqlCode>(vzzzzzzzk_, (IEnumerable<CqlCode>)vzzzzzzzm_);

                return vzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> uzzzzzzzp_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzzzzn_, uzzzzzzzo_);
            bool? uzzzzzzzq_ = context.Operators.Exists<CodeableConcept>(uzzzzzzzp_);
            bool? uzzzzzzzr_ = context.Operators.And(uzzzzzzzm_, uzzzzzzzq_);
            DataType uzzzzzzzs_ = CervicalCytology?.Effective;
            CqlDateTime uzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzzs_);
            CqlInterval<CqlDateTime> uzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzv_ = context.Operators.End(uzzzzzzzu_);
            CqlQuantity uzzzzzzzw_ = context.Operators.Quantity(3m, "years");
            CqlDateTime uzzzzzzzx_ = context.Operators.Subtract(uzzzzzzzv_, uzzzzzzzw_);
            CqlDateTime uzzzzzzzz_ = context.Operators.End(uzzzzzzzu_);
            CqlInterval<CqlDateTime> vzzzzzzza_ = context.Operators.Interval(uzzzzzzzx_, uzzzzzzzz_, true, true);
            bool? vzzzzzzzb_ = context.Operators.In<CqlDateTime>(uzzzzzzzt_, vzzzzzzza_, default);
            CqlDateTime vzzzzzzzd_ = context.Operators.End(uzzzzzzzu_);
            bool? vzzzzzzze_ = context.Operators.Not((bool?)(vzzzzzzzd_ is null));
            bool? vzzzzzzzf_ = context.Operators.And(vzzzzzzzb_, vzzzzzzze_);
            bool? vzzzzzzzg_ = context.Operators.And(uzzzzzzzr_, vzzzzzzzf_);
            DataType vzzzzzzzh_ = CervicalCytology?.Value;
            bool? vzzzzzzzi_ = context.Operators.Not((bool?)(vzzzzzzzh_ is null));
            bool? vzzzzzzzj_ = context.Operators.And(vzzzzzzzg_, vzzzzzzzi_);

            return vzzzzzzzj_;
        };
        IEnumerable<Observation> uzzzzzzzi_ = context.Operators.Where<Observation>(uzzzzzzzg_, uzzzzzzzh_);

        return uzzzzzzzi_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet vzzzzzzzo_ = this.HPV_Test(context);
        IEnumerable<Observation> vzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzq_(Observation HPVTest)
        {
            Code<ObservationStatus> vzzzzzzzs_ = HPVTest?.StatusElement;
            string vzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzs_);
            string[] vzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzv_ = context.Operators.In<string>(vzzzzzzzt_, vzzzzzzzu_ as IEnumerable<string>);
            List<CodeableConcept> vzzzzzzzw_ = HPVTest?.Category;
            bool? vzzzzzzzx_(CodeableConcept HPVTestCategory)
            {
                CqlCode xzzzzzzze_ = this.laboratory(context);
                CqlConcept xzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                CqlCode[] xzzzzzzzg_ = xzzzzzzzf_?.codes;
                bool? xzzzzzzzh_ = context.Operators.In<CqlCode>(xzzzzzzze_, (IEnumerable<CqlCode>)xzzzzzzzg_);

                return xzzzzzzzh_;
            };
            IEnumerable<CodeableConcept> vzzzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzw_, vzzzzzzzx_);
            bool? vzzzzzzzz_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzy_);
            bool? wzzzzzzza_ = context.Operators.And(vzzzzzzzv_, vzzzzzzzz_);
            Patient wzzzzzzzb_ = this.Patient(context);
            Date wzzzzzzzc_ = wzzzzzzzb_?.BirthDateElement;
            string wzzzzzzzd_ = wzzzzzzzc_?.Value;
            CqlDate wzzzzzzze_ = context.Operators.ConvertStringToDate(wzzzzzzzd_);
            DataType wzzzzzzzf_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> wzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzzf_);
            CqlDateTime wzzzzzzzh_ = context.Operators.Start(wzzzzzzzg_);
            CqlDate wzzzzzzzi_ = context.Operators.DateFrom(wzzzzzzzh_);
            int? wzzzzzzzj_ = context.Operators.CalculateAgeAt(wzzzzzzze_, wzzzzzzzi_, "year");
            bool? wzzzzzzzk_ = context.Operators.GreaterOrEqual(wzzzzzzzj_, 30);
            bool? wzzzzzzzl_ = context.Operators.And(wzzzzzzza_, wzzzzzzzk_);
            CqlDateTime wzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, wzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzp_ = context.Operators.End(wzzzzzzzo_);
            CqlQuantity wzzzzzzzq_ = context.Operators.Quantity(5m, "years");
            CqlDateTime wzzzzzzzr_ = context.Operators.Subtract(wzzzzzzzp_, wzzzzzzzq_);
            CqlDateTime wzzzzzzzt_ = context.Operators.End(wzzzzzzzo_);
            CqlInterval<CqlDateTime> wzzzzzzzu_ = context.Operators.Interval(wzzzzzzzr_, wzzzzzzzt_, true, true);
            bool? wzzzzzzzv_ = context.Operators.In<CqlDateTime>(wzzzzzzzn_, wzzzzzzzu_, default);
            CqlDateTime wzzzzzzzx_ = context.Operators.End(wzzzzzzzo_);
            bool? wzzzzzzzy_ = context.Operators.Not((bool?)(wzzzzzzzx_ is null));
            bool? wzzzzzzzz_ = context.Operators.And(wzzzzzzzv_, wzzzzzzzy_);
            bool? xzzzzzzza_ = context.Operators.And(wzzzzzzzl_, wzzzzzzzz_);
            DataType xzzzzzzzb_ = HPVTest?.Value;
            bool? xzzzzzzzc_ = context.Operators.Not((bool?)(xzzzzzzzb_ is null));
            bool? xzzzzzzzd_ = context.Operators.And(xzzzzzzza_, xzzzzzzzc_);

            return xzzzzzzzd_;
        };
        IEnumerable<Observation> vzzzzzzzr_ = context.Operators.Where<Observation>(vzzzzzzzp_, vzzzzzzzq_);

        return vzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzi_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? xzzzzzzzj_ = context.Operators.Exists<Observation>(xzzzzzzzi_);
        IEnumerable<Observation> xzzzzzzzk_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? xzzzzzzzl_ = context.Operators.Exists<Observation>(xzzzzzzzk_);
        bool? xzzzzzzzm_ = context.Operators.Or(xzzzzzzzj_, xzzzzzzzl_);

        return xzzzzzzzm_;
    }


    [CqlExpressionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> xzzzzzzzn_ = observation?.StatusElement;
        string xzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzn_);
        string[] xzzzzzzzp_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? xzzzzzzzq_ = context.Operators.In<string>(xzzzzzzzo_, xzzzzzzzp_ as IEnumerable<string>);

        return xzzzzzzzq_;
    }


    [CqlExpressionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> xzzzzzzzr_ = observation?.Category;
        bool? xzzzzzzzs_(CodeableConcept category)
        {
            CqlCode xzzzzzzzv_ = this.laboratory(context);
            CqlConcept xzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            CqlCode[] xzzzzzzzx_ = xzzzzzzzw_?.codes;
            bool? xzzzzzzzy_ = context.Operators.In<CqlCode>(xzzzzzzzv_, (IEnumerable<CqlCode>)xzzzzzzzx_);

            return xzzzzzzzy_;
        };
        IEnumerable<CodeableConcept> xzzzzzzzt_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzzzzr_, xzzzzzzzs_);
        bool? xzzzzzzzu_ = context.Operators.Exists<CodeableConcept>(xzzzzzzzt_);

        return xzzzzzzzu_;
    }


    [CqlExpressionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime xzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

        return xzzzzzzzz_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
    {
        CqlValueSet yzzzzzzza_ = this.Pap_Test(context);
        IEnumerable<Observation> yzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzzc_(Observation CervicalCytology)
        {
            bool? yzzzzzzze_ = this.isComplete(context, CervicalCytology);
            bool? yzzzzzzzf_ = this.isLaboratoryTest(context, CervicalCytology);
            bool? yzzzzzzzg_ = context.Operators.And(yzzzzzzze_, yzzzzzzzf_);
            DataType yzzzzzzzh_ = CervicalCytology?.Effective;
            CqlDateTime yzzzzzzzi_ = this.latest(context, yzzzzzzzh_);
            CqlInterval<CqlDateTime> yzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzk_ = context.Operators.End(yzzzzzzzj_);
            CqlQuantity yzzzzzzzl_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzzzm_ = context.Operators.Subtract(yzzzzzzzk_, yzzzzzzzl_);
            CqlDateTime yzzzzzzzo_ = context.Operators.End(yzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzp_ = context.Operators.Interval(yzzzzzzzm_, yzzzzzzzo_, true, true);
            bool? yzzzzzzzq_ = context.Operators.In<CqlDateTime>(yzzzzzzzi_, yzzzzzzzp_, default);
            CqlDateTime yzzzzzzzs_ = context.Operators.End(yzzzzzzzj_);
            bool? yzzzzzzzt_ = context.Operators.Not((bool?)(yzzzzzzzs_ is null));
            bool? yzzzzzzzu_ = context.Operators.And(yzzzzzzzq_, yzzzzzzzt_);
            bool? yzzzzzzzv_ = context.Operators.And(yzzzzzzzg_, yzzzzzzzu_);
            DataType yzzzzzzzw_ = CervicalCytology?.Value;
            bool? yzzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzzw_ is null));
            bool? yzzzzzzzy_ = context.Operators.And(yzzzzzzzv_, yzzzzzzzx_);

            return yzzzzzzzy_;
        };
        IEnumerable<Observation> yzzzzzzzd_ = context.Operators.Where<Observation>(yzzzzzzzb_, yzzzzzzzc_);

        return yzzzzzzzd_;
    }


    [CqlExpressionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

        return yzzzzzzzz_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
    {
        CqlValueSet zzzzzzzza_ = this.HPV_Test(context);
        IEnumerable<Observation> zzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzc_(Observation HPVTest)
        {
            bool? zzzzzzzze_ = this.isComplete(context, HPVTest);
            bool? zzzzzzzzf_ = this.isLaboratoryTest(context, HPVTest);
            bool? zzzzzzzzg_ = context.Operators.And(zzzzzzzze_, zzzzzzzzf_);
            Patient zzzzzzzzh_ = this.Patient(context);
            Date zzzzzzzzi_ = zzzzzzzzh_?.BirthDateElement;
            string zzzzzzzzj_ = zzzzzzzzi_?.Value;
            CqlDate zzzzzzzzk_ = context.Operators.ConvertStringToDate(zzzzzzzzj_);
            DataType zzzzzzzzl_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzzm_ = this.toInterval(context, zzzzzzzzl_);
            CqlDateTime zzzzzzzzn_ = context.Operators.Start(zzzzzzzzm_);
            CqlDate zzzzzzzzo_ = context.Operators.DateFrom(zzzzzzzzn_);
            int? zzzzzzzzp_ = context.Operators.CalculateAgeAt(zzzzzzzzk_, zzzzzzzzo_, "year");
            bool? zzzzzzzzq_ = context.Operators.GreaterOrEqual(zzzzzzzzp_, 30);
            bool? zzzzzzzzr_ = context.Operators.And(zzzzzzzzg_, zzzzzzzzq_);
            CqlDateTime zzzzzzzzt_ = this.latest(context, zzzzzzzzl_);
            CqlInterval<CqlDateTime> zzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzv_ = context.Operators.End(zzzzzzzzu_);
            CqlQuantity zzzzzzzzw_ = context.Operators.Quantity(5m, "years");
            CqlDateTime zzzzzzzzx_ = context.Operators.Subtract(zzzzzzzzv_, zzzzzzzzw_);
            CqlDateTime zzzzzzzzz_ = context.Operators.End(zzzzzzzzu_);
            CqlInterval<CqlDateTime> azzzzzzzza_ = context.Operators.Interval(zzzzzzzzx_, zzzzzzzzz_, true, true);
            bool? azzzzzzzzb_ = context.Operators.In<CqlDateTime>(zzzzzzzzt_, azzzzzzzza_, default);
            CqlDateTime azzzzzzzzd_ = context.Operators.End(zzzzzzzzu_);
            bool? azzzzzzzze_ = context.Operators.Not((bool?)(azzzzzzzzd_ is null));
            bool? azzzzzzzzf_ = context.Operators.And(azzzzzzzzb_, azzzzzzzze_);
            bool? azzzzzzzzg_ = context.Operators.And(zzzzzzzzr_, azzzzzzzzf_);
            DataType azzzzzzzzh_ = HPVTest?.Value;
            bool? azzzzzzzzi_ = context.Operators.Not((bool?)(azzzzzzzzh_ is null));
            bool? azzzzzzzzj_ = context.Operators.And(azzzzzzzzg_, azzzzzzzzi_);

            return azzzzzzzzj_;
        };
        IEnumerable<Observation> zzzzzzzzd_ = context.Operators.Where<Observation>(zzzzzzzzb_, zzzzzzzzc_);

        return zzzzzzzzd_;
    }


    #endregion Expressions

}
