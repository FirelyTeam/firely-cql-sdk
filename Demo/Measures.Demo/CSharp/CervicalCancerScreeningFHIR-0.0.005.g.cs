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
        CqlDateTime qzzzzzzzzzzzzr_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime qzzzzzzzzzzzzs_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzt_ = context.Operators.Interval(qzzzzzzzzzzzzr_, qzzzzzzzzzzzzs_, true, false);
        object qzzzzzzzzzzzzu_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", qzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> qzzzzzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzzzzzzd_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzc_, rzzzzzzzzzzzze_);
        CqlValueSet rzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzzzzzzi_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzh_, rzzzzzzzzzzzzj_);
        IEnumerable<Encounter> rzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzf_, rzzzzzzzzzzzzk_);
        CqlValueSet rzzzzzzzzzzzzm_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzzzzzzo_ = this.Online_Assessments(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzn_, rzzzzzzzzzzzzp_);
        IEnumerable<Encounter> rzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzl_, rzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzs_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> rzzzzzzzzzzzzu_ = ValidEncounter?.StatusElement;
            string rzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzu_);
            bool? rzzzzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzzzzv_, "finished");
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            Period rzzzzzzzzzzzzy_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzzzzzy_);
            bool? szzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzx_, rzzzzzzzzzzzzz_, default);
            bool? szzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzw_, szzzzzzzzzzzza_);

            return szzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzr_, rzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient szzzzzzzzzzzzc_ = this.Patient(context);
        Date szzzzzzzzzzzzd_ = szzzzzzzzzzzzc_?.BirthDateElement;
        string szzzzzzzzzzzze_ = szzzzzzzzzzzzd_?.Value;
        CqlDate szzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzh_ = context.Operators.Start(szzzzzzzzzzzzg_);
        CqlDate szzzzzzzzzzzzi_ = context.Operators.DateFrom(szzzzzzzzzzzzh_);
        int? szzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzf_, szzzzzzzzzzzzi_, "year");
        CqlInterval<int?> szzzzzzzzzzzzk_ = context.Operators.Interval(23, 64, true, false);
        bool? szzzzzzzzzzzzl_ = context.Operators.In<int?>(szzzzzzzzzzzzj_, szzzzzzzzzzzzk_, default);
        Code<AdministrativeGender> szzzzzzzzzzzzn_ = szzzzzzzzzzzzc_?.GenderElement;
        string szzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzn_);
        bool? szzzzzzzzzzzzp_ = context.Operators.Equal(szzzzzzzzzzzzo_, "female");
        bool? szzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzl_, szzzzzzzzzzzzp_);
        IEnumerable<Encounter> szzzzzzzzzzzzr_ = this.Qualifying_Encounters(context);
        bool? szzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzq_, szzzzzzzzzzzzs_);

        return szzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzu_ = this.Initial_Population(context);

        return szzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzv_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> szzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzzzx_(Procedure NoCervixProcedure)
        {
            Code<EventStatus> tzzzzzzzzzzzze_ = NoCervixProcedure?.StatusElement;
            string tzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzze_);
            bool? tzzzzzzzzzzzzg_ = context.Operators.Equal(tzzzzzzzzzzzzf_, "completed");
            DataType tzzzzzzzzzzzzh_ = NoCervixProcedure?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzh_);
            CqlDateTime tzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzl_ = context.Operators.End(tzzzzzzzzzzzzk_);
            bool? tzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzj_, tzzzzzzzzzzzzl_, default);
            bool? tzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzg_, tzzzzzzzzzzzzm_);

            return tzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzw_, szzzzzzzzzzzzx_);
        CqlValueSet szzzzzzzzzzzzz_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> tzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tzzzzzzzzzzzzb_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime tzzzzzzzzzzzzp_ = context.Operators.Start(tzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzr_ = context.Operators.End(tzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzp_, tzzzzzzzzzzzzr_, default);

            return tzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(tzzzzzzzzzzzza_, tzzzzzzzzzzzzb_);
        IEnumerable<object> tzzzzzzzzzzzzd_ = context.Operators.Union<object>(szzzzzzzzzzzzy_ as IEnumerable<object>, tzzzzzzzzzzzzc_ as IEnumerable<object>);

        return tzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? tzzzzzzzzzzzzt_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<object> tzzzzzzzzzzzzu_ = this.Absence_of_Cervix(context);
        bool? tzzzzzzzzzzzzv_ = context.Operators.Exists<object>(tzzzzzzzzzzzzu_);
        bool? tzzzzzzzzzzzzw_ = context.Operators.Or(tzzzzzzzzzzzzt_, tzzzzzzzzzzzzv_);
        bool? tzzzzzzzzzzzzx_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? tzzzzzzzzzzzzy_ = context.Operators.Or(tzzzzzzzzzzzzw_, tzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzz_ = this.Pap_Test(context);
        IEnumerable<Observation> uzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzzzzzzzb_(Observation CervicalCytology)
        {
            Code<ObservationStatus> uzzzzzzzzzzzzd_ = CervicalCytology?.StatusElement;
            string uzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzzd_);
            string[] uzzzzzzzzzzzzf_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzg_ = context.Operators.In<string>(uzzzzzzzzzzzze_, uzzzzzzzzzzzzf_ as IEnumerable<string>);
            List<CodeableConcept> uzzzzzzzzzzzzh_ = CervicalCytology?.Category;
            bool? uzzzzzzzzzzzzi_(CodeableConcept CervicalCytologyCategory)
            {
                CqlCode vzzzzzzzzzzzze_ = this.laboratory(context);
                CqlConcept vzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                CqlCode[] vzzzzzzzzzzzzg_ = vzzzzzzzzzzzzf_?.codes;
                bool? vzzzzzzzzzzzzh_ = context.Operators.In<CqlCode>(vzzzzzzzzzzzze_, (IEnumerable<CqlCode>)vzzzzzzzzzzzzg_);

                return vzzzzzzzzzzzzh_;
            };
            IEnumerable<CodeableConcept> uzzzzzzzzzzzzj_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzh_, uzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzk_ = context.Operators.Exists<CodeableConcept>(uzzzzzzzzzzzzj_);
            bool? uzzzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzzzg_, uzzzzzzzzzzzzk_);
            DataType uzzzzzzzzzzzzm_ = CervicalCytology?.Effective;
            CqlDateTime uzzzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, uzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzp_ = context.Operators.End(uzzzzzzzzzzzzo_);
            CqlQuantity uzzzzzzzzzzzzq_ = context.Operators.Quantity(3m, "years");
            CqlDateTime uzzzzzzzzzzzzr_ = context.Operators.Subtract(uzzzzzzzzzzzzp_, uzzzzzzzzzzzzq_);
            CqlDateTime uzzzzzzzzzzzzt_ = context.Operators.End(uzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzu_ = context.Operators.Interval(uzzzzzzzzzzzzr_, uzzzzzzzzzzzzt_, true, true);
            bool? uzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzn_, uzzzzzzzzzzzzu_, default);
            CqlDateTime uzzzzzzzzzzzzx_ = context.Operators.End(uzzzzzzzzzzzzo_);
            bool? uzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzx_ is null));
            bool? uzzzzzzzzzzzzz_ = context.Operators.And(uzzzzzzzzzzzzv_, uzzzzzzzzzzzzy_);
            bool? vzzzzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzzzzl_, uzzzzzzzzzzzzz_);
            DataType vzzzzzzzzzzzzb_ = CervicalCytology?.Value;
            bool? vzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzb_ is null));
            bool? vzzzzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzzzza_, vzzzzzzzzzzzzc_);

            return vzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(uzzzzzzzzzzzza_, uzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzi_ = this.HPV_Test(context);
        IEnumerable<Observation> vzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzzk_(Observation HPVTest)
        {
            Code<ObservationStatus> vzzzzzzzzzzzzm_ = HPVTest?.StatusElement;
            string vzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzm_);
            string[] vzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzzp_ = context.Operators.In<string>(vzzzzzzzzzzzzn_, vzzzzzzzzzzzzo_ as IEnumerable<string>);
            List<CodeableConcept> vzzzzzzzzzzzzq_ = HPVTest?.Category;
            bool? vzzzzzzzzzzzzr_(CodeableConcept HPVTestCategory)
            {
                CqlCode wzzzzzzzzzzzzy_ = this.laboratory(context);
                CqlConcept wzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                CqlCode[] xzzzzzzzzzzzza_ = wzzzzzzzzzzzzz_?.codes;
                bool? xzzzzzzzzzzzzb_ = context.Operators.In<CqlCode>(wzzzzzzzzzzzzy_, (IEnumerable<CqlCode>)xzzzzzzzzzzzza_);

                return xzzzzzzzzzzzzb_;
            };
            IEnumerable<CodeableConcept> vzzzzzzzzzzzzs_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzq_, vzzzzzzzzzzzzr_);
            bool? vzzzzzzzzzzzzt_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzzzzzzs_);
            bool? vzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzp_, vzzzzzzzzzzzzt_);
            Patient vzzzzzzzzzzzzv_ = this.Patient(context);
            Date vzzzzzzzzzzzzw_ = vzzzzzzzzzzzzv_?.BirthDateElement;
            string vzzzzzzzzzzzzx_ = vzzzzzzzzzzzzw_?.Value;
            CqlDate vzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzx_);
            DataType vzzzzzzzzzzzzz_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzz_);
            CqlDateTime wzzzzzzzzzzzzb_ = context.Operators.Start(wzzzzzzzzzzzza_);
            CqlDate wzzzzzzzzzzzzc_ = context.Operators.DateFrom(wzzzzzzzzzzzzb_);
            int? wzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzy_, wzzzzzzzzzzzzc_, "year");
            bool? wzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzd_, 30);
            bool? wzzzzzzzzzzzzf_ = context.Operators.And(vzzzzzzzzzzzzu_, wzzzzzzzzzzzze_);
            CqlDateTime wzzzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzj_ = context.Operators.End(wzzzzzzzzzzzzi_);
            CqlQuantity wzzzzzzzzzzzzk_ = context.Operators.Quantity(5m, "years");
            CqlDateTime wzzzzzzzzzzzzl_ = context.Operators.Subtract(wzzzzzzzzzzzzj_, wzzzzzzzzzzzzk_);
            CqlDateTime wzzzzzzzzzzzzn_ = context.Operators.End(wzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzo_ = context.Operators.Interval(wzzzzzzzzzzzzl_, wzzzzzzzzzzzzn_, true, true);
            bool? wzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzh_, wzzzzzzzzzzzzo_, default);
            CqlDateTime wzzzzzzzzzzzzr_ = context.Operators.End(wzzzzzzzzzzzzi_);
            bool? wzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzr_ is null));
            bool? wzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzp_, wzzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzf_, wzzzzzzzzzzzzt_);
            DataType wzzzzzzzzzzzzv_ = HPVTest?.Value;
            bool? wzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzv_ is null));
            bool? wzzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzzu_, wzzzzzzzzzzzzw_);

            return wzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzj_, vzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> xzzzzzzzzzzzzc_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? xzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(xzzzzzzzzzzzzc_);
        IEnumerable<Observation> xzzzzzzzzzzzze_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? xzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(xzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzg_ = context.Operators.Or(xzzzzzzzzzzzzd_, xzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> xzzzzzzzzzzzzh_ = observation?.StatusElement;
        string xzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzh_);
        string[] xzzzzzzzzzzzzj_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? xzzzzzzzzzzzzk_ = context.Operators.In<string>(xzzzzzzzzzzzzi_, xzzzzzzzzzzzzj_ as IEnumerable<string>);

        return xzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> xzzzzzzzzzzzzl_ = observation?.Category;
        bool? xzzzzzzzzzzzzm_(CodeableConcept category)
        {
            CqlCode xzzzzzzzzzzzzp_ = this.laboratory(context);
            CqlConcept xzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            CqlCode[] xzzzzzzzzzzzzr_ = xzzzzzzzzzzzzq_?.codes;
            bool? xzzzzzzzzzzzzs_ = context.Operators.In<CqlCode>(xzzzzzzzzzzzzp_, (IEnumerable<CqlCode>)xzzzzzzzzzzzzr_);

            return xzzzzzzzzzzzzs_;
        };
        IEnumerable<CodeableConcept> xzzzzzzzzzzzzn_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzzzl_, xzzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzzo_ = context.Operators.Exists<CodeableConcept>(xzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime xzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

        return xzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzu_ = this.Pap_Test(context);
        IEnumerable<Observation> xzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzzzzzw_(Observation CervicalCytology)
        {
            bool? xzzzzzzzzzzzzy_ = this.isComplete(context, CervicalCytology);
            bool? xzzzzzzzzzzzzz_ = this.isLaboratoryTest(context, CervicalCytology);
            bool? yzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzy_, xzzzzzzzzzzzzz_);
            DataType yzzzzzzzzzzzzb_ = CervicalCytology?.Effective;
            CqlDateTime yzzzzzzzzzzzzc_ = this.latest(context, yzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzzzd_);
            CqlQuantity yzzzzzzzzzzzzf_ = context.Operators.Quantity(3m, "years");
            CqlDateTime yzzzzzzzzzzzzg_ = context.Operators.Subtract(yzzzzzzzzzzzze_, yzzzzzzzzzzzzf_);
            CqlDateTime yzzzzzzzzzzzzi_ = context.Operators.End(yzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzj_ = context.Operators.Interval(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzi_, true, true);
            bool? yzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzc_, yzzzzzzzzzzzzj_, default);
            CqlDateTime yzzzzzzzzzzzzm_ = context.Operators.End(yzzzzzzzzzzzzd_);
            bool? yzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzm_ is null));
            bool? yzzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzzk_, yzzzzzzzzzzzzn_);
            bool? yzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzza_, yzzzzzzzzzzzzo_);
            DataType yzzzzzzzzzzzzq_ = CervicalCytology?.Value;
            bool? yzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzq_ is null));
            bool? yzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzp_, yzzzzzzzzzzzzr_);

            return yzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzv_, xzzzzzzzzzzzzw_);

        return xzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

        return yzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzu_ = this.HPV_Test(context);
        IEnumerable<Observation> yzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzzzzzzzw_(Observation HPVTest)
        {
            bool? yzzzzzzzzzzzzy_ = this.isComplete(context, HPVTest);
            bool? yzzzzzzzzzzzzz_ = this.isLaboratoryTest(context, HPVTest);
            bool? zzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzy_, yzzzzzzzzzzzzz_);
            Patient zzzzzzzzzzzzzb_ = this.Patient(context);
            Date zzzzzzzzzzzzzc_ = zzzzzzzzzzzzzb_?.BirthDateElement;
            string zzzzzzzzzzzzzd_ = zzzzzzzzzzzzzc_?.Value;
            CqlDate zzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzd_);
            DataType zzzzzzzzzzzzzf_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzg_ = this.toInterval(context, zzzzzzzzzzzzzf_);
            CqlDateTime zzzzzzzzzzzzzh_ = context.Operators.Start(zzzzzzzzzzzzzg_);
            CqlDate zzzzzzzzzzzzzi_ = context.Operators.DateFrom(zzzzzzzzzzzzzh_);
            int? zzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzze_, zzzzzzzzzzzzzi_, "year");
            bool? zzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzj_, 30);
            bool? zzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzza_, zzzzzzzzzzzzzk_);
            CqlDateTime zzzzzzzzzzzzzn_ = this.latest(context, zzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzp_ = context.Operators.End(zzzzzzzzzzzzzo_);
            CqlQuantity zzzzzzzzzzzzzq_ = context.Operators.Quantity(5m, "years");
            CqlDateTime zzzzzzzzzzzzzr_ = context.Operators.Subtract(zzzzzzzzzzzzzp_, zzzzzzzzzzzzzq_);
            CqlDateTime zzzzzzzzzzzzzt_ = context.Operators.End(zzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzu_ = context.Operators.Interval(zzzzzzzzzzzzzr_, zzzzzzzzzzzzzt_, true, true);
            bool? zzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzn_, zzzzzzzzzzzzzu_, default);
            CqlDateTime zzzzzzzzzzzzzx_ = context.Operators.End(zzzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzx_ is null));
            bool? zzzzzzzzzzzzzz_ = context.Operators.And(zzzzzzzzzzzzzv_, zzzzzzzzzzzzzy_);
            bool? azzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzz_);
            DataType azzzzzzzzzzzzzb_ = HPVTest?.Value;
            bool? azzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzb_ is null));
            bool? azzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzza_, azzzzzzzzzzzzzc_);

            return azzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzv_, yzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
