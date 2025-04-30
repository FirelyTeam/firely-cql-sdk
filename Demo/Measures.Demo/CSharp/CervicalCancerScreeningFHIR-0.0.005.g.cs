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
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _laboratory);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzd_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime qzzzzzzzze_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> qzzzzzzzzf_ = context.Operators.Interval(qzzzzzzzzd_, qzzzzzzzze_, true, false);
        object qzzzzzzzzg_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", qzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzh_);

        return qzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> qzzzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return qzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return qzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return qzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzzzzzp_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzzzzzr_ = context.Operators.Union<Encounter>(qzzzzzzzzo_, qzzzzzzzzq_);
        CqlValueSet qzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> qzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzzzzzu_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> qzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzzzzzw_ = context.Operators.Union<Encounter>(qzzzzzzzzt_, qzzzzzzzzv_);
        IEnumerable<Encounter> qzzzzzzzzx_ = context.Operators.Union<Encounter>(qzzzzzzzzr_, qzzzzzzzzw_);
        CqlValueSet qzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet rzzzzzzzza_ = this.Online_Assessments(context);
        IEnumerable<Encounter> rzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzc_ = context.Operators.Union<Encounter>(qzzzzzzzzz_, rzzzzzzzzb_);
        IEnumerable<Encounter> rzzzzzzzzd_ = context.Operators.Union<Encounter>(qzzzzzzzzx_, rzzzzzzzzc_);
        bool? rzzzzzzzze_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> rzzzzzzzzg_ = ValidEncounter?.StatusElement;
            string rzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzg_);
            bool? rzzzzzzzzi_ = context.Operators.Equal(rzzzzzzzzh_, "finished");
            CqlInterval<CqlDateTime> rzzzzzzzzj_ = this.Measurement_Period(context);
            Period rzzzzzzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, rzzzzzzzzk_);
            bool? rzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzj_, rzzzzzzzzl_, default);
            bool? rzzzzzzzzn_ = context.Operators.And(rzzzzzzzzi_, rzzzzzzzzm_);

            return rzzzzzzzzn_;
        };
        IEnumerable<Encounter> rzzzzzzzzf_ = context.Operators.Where<Encounter>(rzzzzzzzzd_, rzzzzzzzze_);

        return rzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzo_ = this.Patient(context);
        Date rzzzzzzzzp_ = rzzzzzzzzo_?.BirthDateElement;
        string rzzzzzzzzq_ = rzzzzzzzzp_?.Value;
        CqlDate rzzzzzzzzr_ = context.Operators.ConvertStringToDate(rzzzzzzzzq_);
        CqlInterval<CqlDateTime> rzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzs_);
        CqlDate rzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzt_);
        int? rzzzzzzzzv_ = context.Operators.CalculateAgeAt(rzzzzzzzzr_, rzzzzzzzzu_, "year");
        CqlInterval<int?> rzzzzzzzzw_ = context.Operators.Interval(23, 64, true, false);
        bool? rzzzzzzzzx_ = context.Operators.In<int?>(rzzzzzzzzv_, rzzzzzzzzw_, default);
        Code<AdministrativeGender> rzzzzzzzzz_ = rzzzzzzzzo_?.GenderElement;
        string szzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzz_);
        bool? szzzzzzzzb_ = context.Operators.Equal(szzzzzzzza_, "female");
        bool? szzzzzzzzc_ = context.Operators.And(rzzzzzzzzx_, szzzzzzzzb_);
        IEnumerable<Encounter> szzzzzzzzd_ = this.Qualifying_Encounters(context);
        bool? szzzzzzzze_ = context.Operators.Exists<Encounter>(szzzzzzzzd_);
        bool? szzzzzzzzf_ = context.Operators.And(szzzzzzzzc_, szzzzzzzze_);

        return szzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzg_ = this.Initial_Population(context);

        return szzzzzzzzg_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet szzzzzzzzh_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> szzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzj_(Procedure NoCervixProcedure)
        {
            Code<EventStatus> szzzzzzzzq_ = NoCervixProcedure?.StatusElement;
            string szzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzq_);
            bool? szzzzzzzzs_ = context.Operators.Equal(szzzzzzzzr_, "completed");
            DataType szzzzzzzzt_ = NoCervixProcedure?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzt_);
            CqlDateTime szzzzzzzzv_ = context.Operators.End(szzzzzzzzu_);
            CqlInterval<CqlDateTime> szzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzx_ = context.Operators.End(szzzzzzzzw_);
            bool? szzzzzzzzy_ = context.Operators.SameOrBefore(szzzzzzzzv_, szzzzzzzzx_, default);
            bool? szzzzzzzzz_ = context.Operators.And(szzzzzzzzs_, szzzzzzzzy_);

            return szzzzzzzzz_;
        };
        IEnumerable<Procedure> szzzzzzzzk_ = context.Operators.Where<Procedure>(szzzzzzzzi_, szzzzzzzzj_);
        CqlValueSet szzzzzzzzl_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> szzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? szzzzzzzzn_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> tzzzzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime tzzzzzzzzb_ = context.Operators.Start(tzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzd_ = context.Operators.End(tzzzzzzzzc_);
            bool? tzzzzzzzze_ = context.Operators.SameOrBefore(tzzzzzzzzb_, tzzzzzzzzd_, default);

            return tzzzzzzzze_;
        };
        IEnumerable<Condition> szzzzzzzzo_ = context.Operators.Where<Condition>(szzzzzzzzm_, szzzzzzzzn_);
        IEnumerable<object> szzzzzzzzp_ = context.Operators.Union<object>(szzzzzzzzk_ as IEnumerable<object>, szzzzzzzzo_ as IEnumerable<object>);

        return szzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? tzzzzzzzzf_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<object> tzzzzzzzzg_ = this.Absence_of_Cervix(context);
        bool? tzzzzzzzzh_ = context.Operators.Exists<object>(tzzzzzzzzg_);
        bool? tzzzzzzzzi_ = context.Operators.Or(tzzzzzzzzf_, tzzzzzzzzh_);
        bool? tzzzzzzzzj_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? tzzzzzzzzk_ = context.Operators.Or(tzzzzzzzzi_, tzzzzzzzzj_);

        return tzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet tzzzzzzzzl_ = this.Pap_Test(context);
        IEnumerable<Observation> tzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? tzzzzzzzzn_(Observation CervicalCytology)
        {
            Code<ObservationStatus> tzzzzzzzzp_ = CervicalCytology?.StatusElement;
            string tzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzp_);
            string[] tzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzs_ = context.Operators.In<string>(tzzzzzzzzq_, tzzzzzzzzr_ as IEnumerable<string>);
            List<CodeableConcept> tzzzzzzzzt_ = CervicalCytology?.Category;
            bool? tzzzzzzzzu_(CodeableConcept CervicalCytologyCategory)
            {
                CqlCode uzzzzzzzzq_ = this.laboratory(context);
                CqlConcept uzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                CqlCode[] uzzzzzzzzs_ = uzzzzzzzzr_?.codes;
                bool? uzzzzzzzzt_ = context.Operators.In<CqlCode>(uzzzzzzzzq_, (IEnumerable<CqlCode>)uzzzzzzzzs_);

                return uzzzzzzzzt_;
            };
            IEnumerable<CodeableConcept> tzzzzzzzzv_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzt_, tzzzzzzzzu_);
            bool? tzzzzzzzzw_ = context.Operators.Exists<CodeableConcept>(tzzzzzzzzv_);
            bool? tzzzzzzzzx_ = context.Operators.And(tzzzzzzzzs_, tzzzzzzzzw_);
            DataType tzzzzzzzzy_ = CervicalCytology?.Effective;
            CqlDateTime tzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzy_);
            CqlInterval<CqlDateTime> uzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzb_ = context.Operators.End(uzzzzzzzza_);
            CqlQuantity uzzzzzzzzc_ = context.Operators.Quantity(3m, "years");
            CqlDateTime uzzzzzzzzd_ = context.Operators.Subtract(uzzzzzzzzb_, uzzzzzzzzc_);
            CqlDateTime uzzzzzzzzf_ = context.Operators.End(uzzzzzzzza_);
            CqlInterval<CqlDateTime> uzzzzzzzzg_ = context.Operators.Interval(uzzzzzzzzd_, uzzzzzzzzf_, true, true);
            bool? uzzzzzzzzh_ = context.Operators.In<CqlDateTime>(tzzzzzzzzz_, uzzzzzzzzg_, default);
            CqlDateTime uzzzzzzzzj_ = context.Operators.End(uzzzzzzzza_);
            bool? uzzzzzzzzk_ = context.Operators.Not((bool?)(uzzzzzzzzj_ is null));
            bool? uzzzzzzzzl_ = context.Operators.And(uzzzzzzzzh_, uzzzzzzzzk_);
            bool? uzzzzzzzzm_ = context.Operators.And(tzzzzzzzzx_, uzzzzzzzzl_);
            DataType uzzzzzzzzn_ = CervicalCytology?.Value;
            bool? uzzzzzzzzo_ = context.Operators.Not((bool?)(uzzzzzzzzn_ is null));
            bool? uzzzzzzzzp_ = context.Operators.And(uzzzzzzzzm_, uzzzzzzzzo_);

            return uzzzzzzzzp_;
        };
        IEnumerable<Observation> tzzzzzzzzo_ = context.Operators.Where<Observation>(tzzzzzzzzm_, tzzzzzzzzn_);

        return tzzzzzzzzo_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet uzzzzzzzzu_ = this.HPV_Test(context);
        IEnumerable<Observation> uzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzzzw_(Observation HPVTest)
        {
            Code<ObservationStatus> uzzzzzzzzy_ = HPVTest?.StatusElement;
            string uzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzy_);
            string[] vzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzb_ = context.Operators.In<string>(uzzzzzzzzz_, vzzzzzzzza_ as IEnumerable<string>);
            List<CodeableConcept> vzzzzzzzzc_ = HPVTest?.Category;
            bool? vzzzzzzzzd_(CodeableConcept HPVTestCategory)
            {
                CqlCode wzzzzzzzzk_ = this.laboratory(context);
                CqlConcept wzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                CqlCode[] wzzzzzzzzm_ = wzzzzzzzzl_?.codes;
                bool? wzzzzzzzzn_ = context.Operators.In<CqlCode>(wzzzzzzzzk_, (IEnumerable<CqlCode>)wzzzzzzzzm_);

                return wzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> vzzzzzzzze_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzc_, vzzzzzzzzd_);
            bool? vzzzzzzzzf_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzze_);
            bool? vzzzzzzzzg_ = context.Operators.And(vzzzzzzzzb_, vzzzzzzzzf_);
            Patient vzzzzzzzzh_ = this.Patient(context);
            Date vzzzzzzzzi_ = vzzzzzzzzh_?.BirthDateElement;
            string vzzzzzzzzj_ = vzzzzzzzzi_?.Value;
            CqlDate vzzzzzzzzk_ = context.Operators.ConvertStringToDate(vzzzzzzzzj_);
            DataType vzzzzzzzzl_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> vzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzl_);
            CqlDateTime vzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzm_);
            CqlDate vzzzzzzzzo_ = context.Operators.DateFrom(vzzzzzzzzn_);
            int? vzzzzzzzzp_ = context.Operators.CalculateAgeAt(vzzzzzzzzk_, vzzzzzzzzo_, "year");
            bool? vzzzzzzzzq_ = context.Operators.GreaterOrEqual(vzzzzzzzzp_, 30);
            bool? vzzzzzzzzr_ = context.Operators.And(vzzzzzzzzg_, vzzzzzzzzq_);
            CqlDateTime vzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, vzzzzzzzzl_);
            CqlInterval<CqlDateTime> vzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzv_ = context.Operators.End(vzzzzzzzzu_);
            CqlQuantity vzzzzzzzzw_ = context.Operators.Quantity(5m, "years");
            CqlDateTime vzzzzzzzzx_ = context.Operators.Subtract(vzzzzzzzzv_, vzzzzzzzzw_);
            CqlDateTime vzzzzzzzzz_ = context.Operators.End(vzzzzzzzzu_);
            CqlInterval<CqlDateTime> wzzzzzzzza_ = context.Operators.Interval(vzzzzzzzzx_, vzzzzzzzzz_, true, true);
            bool? wzzzzzzzzb_ = context.Operators.In<CqlDateTime>(vzzzzzzzzt_, wzzzzzzzza_, default);
            CqlDateTime wzzzzzzzzd_ = context.Operators.End(vzzzzzzzzu_);
            bool? wzzzzzzzze_ = context.Operators.Not((bool?)(wzzzzzzzzd_ is null));
            bool? wzzzzzzzzf_ = context.Operators.And(wzzzzzzzzb_, wzzzzzzzze_);
            bool? wzzzzzzzzg_ = context.Operators.And(vzzzzzzzzr_, wzzzzzzzzf_);
            DataType wzzzzzzzzh_ = HPVTest?.Value;
            bool? wzzzzzzzzi_ = context.Operators.Not((bool?)(wzzzzzzzzh_ is null));
            bool? wzzzzzzzzj_ = context.Operators.And(wzzzzzzzzg_, wzzzzzzzzi_);

            return wzzzzzzzzj_;
        };
        IEnumerable<Observation> uzzzzzzzzx_ = context.Operators.Where<Observation>(uzzzzzzzzv_, uzzzzzzzzw_);

        return uzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> wzzzzzzzzo_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? wzzzzzzzzp_ = context.Operators.Exists<Observation>(wzzzzzzzzo_);
        IEnumerable<Observation> wzzzzzzzzq_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? wzzzzzzzzr_ = context.Operators.Exists<Observation>(wzzzzzzzzq_);
        bool? wzzzzzzzzs_ = context.Operators.Or(wzzzzzzzzp_, wzzzzzzzzr_);

        return wzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> wzzzzzzzzt_ = observation?.StatusElement;
        string wzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzt_);
        string[] wzzzzzzzzv_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? wzzzzzzzzw_ = context.Operators.In<string>(wzzzzzzzzu_, wzzzzzzzzv_ as IEnumerable<string>);

        return wzzzzzzzzw_;
    }


    [CqlExpressionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> wzzzzzzzzx_ = observation?.Category;
        bool? wzzzzzzzzy_(CodeableConcept category)
        {
            CqlCode xzzzzzzzzb_ = this.laboratory(context);
            CqlConcept xzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            CqlCode[] xzzzzzzzzd_ = xzzzzzzzzc_?.codes;
            bool? xzzzzzzzze_ = context.Operators.In<CqlCode>(xzzzzzzzzb_, (IEnumerable<CqlCode>)xzzzzzzzzd_);

            return xzzzzzzzze_;
        };
        IEnumerable<CodeableConcept> wzzzzzzzzz_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzx_, wzzzzzzzzy_);
        bool? xzzzzzzzza_ = context.Operators.Exists<CodeableConcept>(wzzzzzzzzz_);

        return xzzzzzzzza_;
    }


    [CqlExpressionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime xzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

        return xzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
    {
        CqlValueSet xzzzzzzzzg_ = this.Pap_Test(context);
        IEnumerable<Observation> xzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? xzzzzzzzzi_(Observation CervicalCytology)
        {
            bool? xzzzzzzzzk_ = this.isComplete(context, CervicalCytology);
            bool? xzzzzzzzzl_ = this.isLaboratoryTest(context, CervicalCytology);
            bool? xzzzzzzzzm_ = context.Operators.And(xzzzzzzzzk_, xzzzzzzzzl_);
            DataType xzzzzzzzzn_ = CervicalCytology?.Effective;
            CqlDateTime xzzzzzzzzo_ = this.latest(context, xzzzzzzzzn_);
            CqlInterval<CqlDateTime> xzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzq_ = context.Operators.End(xzzzzzzzzp_);
            CqlQuantity xzzzzzzzzr_ = context.Operators.Quantity(3m, "years");
            CqlDateTime xzzzzzzzzs_ = context.Operators.Subtract(xzzzzzzzzq_, xzzzzzzzzr_);
            CqlDateTime xzzzzzzzzu_ = context.Operators.End(xzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzs_, xzzzzzzzzu_, true, true);
            bool? xzzzzzzzzw_ = context.Operators.In<CqlDateTime>(xzzzzzzzzo_, xzzzzzzzzv_, default);
            CqlDateTime xzzzzzzzzy_ = context.Operators.End(xzzzzzzzzp_);
            bool? xzzzzzzzzz_ = context.Operators.Not((bool?)(xzzzzzzzzy_ is null));
            bool? yzzzzzzzza_ = context.Operators.And(xzzzzzzzzw_, xzzzzzzzzz_);
            bool? yzzzzzzzzb_ = context.Operators.And(xzzzzzzzzm_, yzzzzzzzza_);
            DataType yzzzzzzzzc_ = CervicalCytology?.Value;
            bool? yzzzzzzzzd_ = context.Operators.Not((bool?)(yzzzzzzzzc_ is null));
            bool? yzzzzzzzze_ = context.Operators.And(yzzzzzzzzb_, yzzzzzzzzd_);

            return yzzzzzzzze_;
        };
        IEnumerable<Observation> xzzzzzzzzj_ = context.Operators.Where<Observation>(xzzzzzzzzh_, xzzzzzzzzi_);

        return xzzzzzzzzj_;
    }


    [CqlExpressionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

        return yzzzzzzzzf_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
    {
        CqlValueSet yzzzzzzzzg_ = this.HPV_Test(context);
        IEnumerable<Observation> yzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzzzi_(Observation HPVTest)
        {
            bool? yzzzzzzzzk_ = this.isComplete(context, HPVTest);
            bool? yzzzzzzzzl_ = this.isLaboratoryTest(context, HPVTest);
            bool? yzzzzzzzzm_ = context.Operators.And(yzzzzzzzzk_, yzzzzzzzzl_);
            Patient yzzzzzzzzn_ = this.Patient(context);
            Date yzzzzzzzzo_ = yzzzzzzzzn_?.BirthDateElement;
            string yzzzzzzzzp_ = yzzzzzzzzo_?.Value;
            CqlDate yzzzzzzzzq_ = context.Operators.ConvertStringToDate(yzzzzzzzzp_);
            DataType yzzzzzzzzr_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> yzzzzzzzzs_ = this.toInterval(context, yzzzzzzzzr_);
            CqlDateTime yzzzzzzzzt_ = context.Operators.Start(yzzzzzzzzs_);
            CqlDate yzzzzzzzzu_ = context.Operators.DateFrom(yzzzzzzzzt_);
            int? yzzzzzzzzv_ = context.Operators.CalculateAgeAt(yzzzzzzzzq_, yzzzzzzzzu_, "year");
            bool? yzzzzzzzzw_ = context.Operators.GreaterOrEqual(yzzzzzzzzv_, 30);
            bool? yzzzzzzzzx_ = context.Operators.And(yzzzzzzzzm_, yzzzzzzzzw_);
            CqlDateTime yzzzzzzzzz_ = this.latest(context, yzzzzzzzzr_);
            CqlInterval<CqlDateTime> zzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzb_ = context.Operators.End(zzzzzzzzza_);
            CqlQuantity zzzzzzzzzc_ = context.Operators.Quantity(5m, "years");
            CqlDateTime zzzzzzzzzd_ = context.Operators.Subtract(zzzzzzzzzb_, zzzzzzzzzc_);
            CqlDateTime zzzzzzzzzf_ = context.Operators.End(zzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzd_, zzzzzzzzzf_, true, true);
            bool? zzzzzzzzzh_ = context.Operators.In<CqlDateTime>(yzzzzzzzzz_, zzzzzzzzzg_, default);
            CqlDateTime zzzzzzzzzj_ = context.Operators.End(zzzzzzzzza_);
            bool? zzzzzzzzzk_ = context.Operators.Not((bool?)(zzzzzzzzzj_ is null));
            bool? zzzzzzzzzl_ = context.Operators.And(zzzzzzzzzh_, zzzzzzzzzk_);
            bool? zzzzzzzzzm_ = context.Operators.And(yzzzzzzzzx_, zzzzzzzzzl_);
            DataType zzzzzzzzzn_ = HPVTest?.Value;
            bool? zzzzzzzzzo_ = context.Operators.Not((bool?)(zzzzzzzzzn_ is null));
            bool? zzzzzzzzzp_ = context.Operators.And(zzzzzzzzzm_, zzzzzzzzzo_);

            return zzzzzzzzzp_;
        };
        IEnumerable<Observation> yzzzzzzzzj_ = context.Operators.Where<Observation>(yzzzzzzzzh_, yzzzzzzzzi_);

        return yzzzzzzzzj_;
    }


    #endregion Expressions

}
