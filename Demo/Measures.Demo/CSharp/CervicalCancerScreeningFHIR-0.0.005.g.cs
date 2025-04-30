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
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzg_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ozzzzzzzzzzzh_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzi_ = context.Operators.Interval(ozzzzzzzzzzzg_, ozzzzzzzzzzzh_, true, false);
        object ozzzzzzzzzzzj_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", ozzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzk_);

        return ozzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> ozzzzzzzzzzzn_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> ozzzzzzzzzzzo_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzp_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzzs_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzu_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzr_, ozzzzzzzzzzzt_);
        CqlValueSet ozzzzzzzzzzzv_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ozzzzzzzzzzzx_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzz_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzw_, ozzzzzzzzzzzy_);
        IEnumerable<Encounter> pzzzzzzzzzzza_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzu_, ozzzzzzzzzzzz_);
        CqlValueSet pzzzzzzzzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzzzzzzd_ = this.Online_Assessments(context);
        IEnumerable<Encounter> pzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzc_, pzzzzzzzzzzze_);
        IEnumerable<Encounter> pzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(pzzzzzzzzzzza_, pzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzj_ = ValidEncounter?.StatusElement;
            string pzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzzzzk_, "finished");
            CqlInterval<CqlDateTime> pzzzzzzzzzzzm_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzn_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, pzzzzzzzzzzzn_);
            bool? pzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzm_, pzzzzzzzzzzzo_, default);
            bool? pzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzl_, pzzzzzzzzzzzp_);

            return pzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzg_, pzzzzzzzzzzzh_);

        return pzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient pzzzzzzzzzzzr_ = this.Patient(context);
        Date pzzzzzzzzzzzs_ = pzzzzzzzzzzzr_?.BirthDateElement;
        string pzzzzzzzzzzzt_ = pzzzzzzzzzzzs_?.Value;
        CqlDate pzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzzzv_);
        CqlDate pzzzzzzzzzzzx_ = context.Operators.DateFrom(pzzzzzzzzzzzw_);
        int? pzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzu_, pzzzzzzzzzzzx_, "year");
        CqlInterval<int?> pzzzzzzzzzzzz_ = context.Operators.Interval(23, 64, true, false);
        bool? qzzzzzzzzzzza_ = context.Operators.In<int?>(pzzzzzzzzzzzy_, pzzzzzzzzzzzz_, default);
        Code<AdministrativeGender> qzzzzzzzzzzzc_ = pzzzzzzzzzzzr_?.GenderElement;
        string qzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzzd_, "female");
        bool? qzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzza_, qzzzzzzzzzzze_);
        IEnumerable<Encounter> qzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        bool? qzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzf_, qzzzzzzzzzzzh_);

        return qzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzzj_ = this.Initial_Population(context);

        return qzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzk_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> qzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? qzzzzzzzzzzzm_(Procedure NoCervixProcedure)
        {
            Code<EventStatus> qzzzzzzzzzzzt_ = NoCervixProcedure?.StatusElement;
            string qzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzv_ = context.Operators.Equal(qzzzzzzzzzzzu_, "completed");
            DataType qzzzzzzzzzzzw_ = NoCervixProcedure?.Performed;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzw_);
            CqlDateTime qzzzzzzzzzzzy_ = context.Operators.End(qzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzza_ = context.Operators.End(qzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzb_ = context.Operators.SameOrBefore(qzzzzzzzzzzzy_, rzzzzzzzzzzza_, default);
            bool? rzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzv_, rzzzzzzzzzzzb_);

            return rzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzl_, qzzzzzzzzzzzm_);
        CqlValueSet qzzzzzzzzzzzo_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> qzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? qzzzzzzzzzzzq_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime rzzzzzzzzzzze_ = context.Operators.Start(rzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzh_ = context.Operators.SameOrBefore(rzzzzzzzzzzze_, rzzzzzzzzzzzg_, default);

            return rzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzr_ = context.Operators.Where<Condition>(qzzzzzzzzzzzp_, qzzzzzzzzzzzq_);
        IEnumerable<object> qzzzzzzzzzzzs_ = context.Operators.Union<object>(qzzzzzzzzzzzn_ as IEnumerable<object>, qzzzzzzzzzzzr_ as IEnumerable<object>);

        return qzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? rzzzzzzzzzzzi_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<object> rzzzzzzzzzzzj_ = this.Absence_of_Cervix(context);
        bool? rzzzzzzzzzzzk_ = context.Operators.Exists<object>(rzzzzzzzzzzzj_);
        bool? rzzzzzzzzzzzl_ = context.Operators.Or(rzzzzzzzzzzzi_, rzzzzzzzzzzzk_);
        bool? rzzzzzzzzzzzm_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? rzzzzzzzzzzzn_ = context.Operators.Or(rzzzzzzzzzzzl_, rzzzzzzzzzzzm_);

        return rzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzo_ = this.Pap_Test(context);
        IEnumerable<Observation> rzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzzq_(Observation CervicalCytology)
        {
            Code<ObservationStatus> rzzzzzzzzzzzs_ = CervicalCytology?.StatusElement;
            string rzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzs_);
            string[] rzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzv_ = context.Operators.In<string>(rzzzzzzzzzzzt_, rzzzzzzzzzzzu_ as IEnumerable<string>);
            List<CodeableConcept> rzzzzzzzzzzzw_ = CervicalCytology?.Category;
            bool? rzzzzzzzzzzzx_(CodeableConcept CervicalCytologyCategory)
            {
                CqlCode szzzzzzzzzzzt_ = this.laboratory(context);
                CqlConcept szzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                CqlCode[] szzzzzzzzzzzv_ = szzzzzzzzzzzu_?.codes;
                bool? szzzzzzzzzzzw_ = context.Operators.In<CqlCode>(szzzzzzzzzzzt_, (IEnumerable<CqlCode>)szzzzzzzzzzzv_);

                return szzzzzzzzzzzw_;
            };
            IEnumerable<CodeableConcept> rzzzzzzzzzzzy_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzw_, rzzzzzzzzzzzx_);
            bool? rzzzzzzzzzzzz_ = context.Operators.Exists<CodeableConcept>(rzzzzzzzzzzzy_);
            bool? szzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzv_, rzzzzzzzzzzzz_);
            DataType szzzzzzzzzzzb_ = CervicalCytology?.Effective;
            CqlDateTime szzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, szzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzze_ = context.Operators.End(szzzzzzzzzzzd_);
            CqlQuantity szzzzzzzzzzzf_ = context.Operators.Quantity(3m, "years");
            CqlDateTime szzzzzzzzzzzg_ = context.Operators.Subtract(szzzzzzzzzzze_, szzzzzzzzzzzf_);
            CqlDateTime szzzzzzzzzzzi_ = context.Operators.End(szzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzj_ = context.Operators.Interval(szzzzzzzzzzzg_, szzzzzzzzzzzi_, true, true);
            bool? szzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzc_, szzzzzzzzzzzj_, default);
            CqlDateTime szzzzzzzzzzzm_ = context.Operators.End(szzzzzzzzzzzd_);
            bool? szzzzzzzzzzzn_ = context.Operators.Not((bool?)(szzzzzzzzzzzm_ is null));
            bool? szzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzk_, szzzzzzzzzzzn_);
            bool? szzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzza_, szzzzzzzzzzzo_);
            DataType szzzzzzzzzzzq_ = CervicalCytology?.Value;
            bool? szzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzq_ is null));
            bool? szzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzp_, szzzzzzzzzzzr_);

            return szzzzzzzzzzzs_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzr_ = context.Operators.Where<Observation>(rzzzzzzzzzzzp_, rzzzzzzzzzzzq_);

        return rzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzx_ = this.HPV_Test(context);
        IEnumerable<Observation> szzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? szzzzzzzzzzzz_(Observation HPVTest)
        {
            Code<ObservationStatus> tzzzzzzzzzzzb_ = HPVTest?.StatusElement;
            string tzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzb_);
            string[] tzzzzzzzzzzzd_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? tzzzzzzzzzzze_ = context.Operators.In<string>(tzzzzzzzzzzzc_, tzzzzzzzzzzzd_ as IEnumerable<string>);
            List<CodeableConcept> tzzzzzzzzzzzf_ = HPVTest?.Category;
            bool? tzzzzzzzzzzzg_(CodeableConcept HPVTestCategory)
            {
                CqlCode uzzzzzzzzzzzn_ = this.laboratory(context);
                CqlConcept uzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                CqlCode[] uzzzzzzzzzzzp_ = uzzzzzzzzzzzo_?.codes;
                bool? uzzzzzzzzzzzq_ = context.Operators.In<CqlCode>(uzzzzzzzzzzzn_, (IEnumerable<CqlCode>)uzzzzzzzzzzzp_);

                return uzzzzzzzzzzzq_;
            };
            IEnumerable<CodeableConcept> tzzzzzzzzzzzh_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzf_, tzzzzzzzzzzzg_);
            bool? tzzzzzzzzzzzi_ = context.Operators.Exists<CodeableConcept>(tzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzze_, tzzzzzzzzzzzi_);
            Patient tzzzzzzzzzzzk_ = this.Patient(context);
            Date tzzzzzzzzzzzl_ = tzzzzzzzzzzzk_?.BirthDateElement;
            string tzzzzzzzzzzzm_ = tzzzzzzzzzzzl_?.Value;
            CqlDate tzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzm_);
            DataType tzzzzzzzzzzzo_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzo_);
            CqlDateTime tzzzzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzzzzp_);
            CqlDate tzzzzzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzzzzzq_);
            int? tzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzn_, tzzzzzzzzzzzr_, "year");
            bool? tzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzs_, 30);
            bool? tzzzzzzzzzzzu_ = context.Operators.And(tzzzzzzzzzzzj_, tzzzzzzzzzzzt_);
            CqlDateTime tzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, tzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzy_ = context.Operators.End(tzzzzzzzzzzzx_);
            CqlQuantity tzzzzzzzzzzzz_ = context.Operators.Quantity(5m, "years");
            CqlDateTime uzzzzzzzzzzza_ = context.Operators.Subtract(tzzzzzzzzzzzy_, tzzzzzzzzzzzz_);
            CqlDateTime uzzzzzzzzzzzc_ = context.Operators.End(tzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzd_ = context.Operators.Interval(uzzzzzzzzzzza_, uzzzzzzzzzzzc_, true, true);
            bool? uzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzw_, uzzzzzzzzzzzd_, default);
            CqlDateTime uzzzzzzzzzzzg_ = context.Operators.End(tzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzh_ = context.Operators.Not((bool?)(uzzzzzzzzzzzg_ is null));
            bool? uzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzze_, uzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzu_, uzzzzzzzzzzzi_);
            DataType uzzzzzzzzzzzk_ = HPVTest?.Value;
            bool? uzzzzzzzzzzzl_ = context.Operators.Not((bool?)(uzzzzzzzzzzzk_ is null));
            bool? uzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzj_, uzzzzzzzzzzzl_);

            return uzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> tzzzzzzzzzzza_ = context.Operators.Where<Observation>(szzzzzzzzzzzy_, szzzzzzzzzzzz_);

        return tzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> uzzzzzzzzzzzr_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? uzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzr_);
        IEnumerable<Observation> uzzzzzzzzzzzt_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? uzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzv_ = context.Operators.Or(uzzzzzzzzzzzs_, uzzzzzzzzzzzu_);

        return uzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> uzzzzzzzzzzzw_ = observation?.StatusElement;
        string uzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzzw_);
        string[] uzzzzzzzzzzzy_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? uzzzzzzzzzzzz_ = context.Operators.In<string>(uzzzzzzzzzzzx_, uzzzzzzzzzzzy_ as IEnumerable<string>);

        return uzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> vzzzzzzzzzzza_ = observation?.Category;
        bool? vzzzzzzzzzzzb_(CodeableConcept category)
        {
            CqlCode vzzzzzzzzzzze_ = this.laboratory(context);
            CqlConcept vzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            CqlCode[] vzzzzzzzzzzzg_ = vzzzzzzzzzzzf_?.codes;
            bool? vzzzzzzzzzzzh_ = context.Operators.In<CqlCode>(vzzzzzzzzzzze_, (IEnumerable<CqlCode>)vzzzzzzzzzzzg_);

            return vzzzzzzzzzzzh_;
        };
        IEnumerable<CodeableConcept> vzzzzzzzzzzzc_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzza_, vzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzd_ = context.Operators.Exists<CodeableConcept>(vzzzzzzzzzzzc_);

        return vzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime vzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

        return vzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzj_ = this.Pap_Test(context);
        IEnumerable<Observation> vzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzl_(Observation CervicalCytology)
        {
            bool? vzzzzzzzzzzzn_ = this.isComplete(context, CervicalCytology);
            bool? vzzzzzzzzzzzo_ = this.isLaboratoryTest(context, CervicalCytology);
            bool? vzzzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzzzn_, vzzzzzzzzzzzo_);
            DataType vzzzzzzzzzzzq_ = CervicalCytology?.Effective;
            CqlDateTime vzzzzzzzzzzzr_ = this.latest(context, vzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzt_ = context.Operators.End(vzzzzzzzzzzzs_);
            CqlQuantity vzzzzzzzzzzzu_ = context.Operators.Quantity(3m, "years");
            CqlDateTime vzzzzzzzzzzzv_ = context.Operators.Subtract(vzzzzzzzzzzzt_, vzzzzzzzzzzzu_);
            CqlDateTime vzzzzzzzzzzzx_ = context.Operators.End(vzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzy_ = context.Operators.Interval(vzzzzzzzzzzzv_, vzzzzzzzzzzzx_, true, true);
            bool? vzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzr_, vzzzzzzzzzzzy_, default);
            CqlDateTime wzzzzzzzzzzzb_ = context.Operators.End(vzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzc_ = context.Operators.Not((bool?)(wzzzzzzzzzzzb_ is null));
            bool? wzzzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzzzz_, wzzzzzzzzzzzc_);
            bool? wzzzzzzzzzzze_ = context.Operators.And(vzzzzzzzzzzzp_, wzzzzzzzzzzzd_);
            DataType wzzzzzzzzzzzf_ = CervicalCytology?.Value;
            bool? wzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzf_ is null));
            bool? wzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzze_, wzzzzzzzzzzzg_);

            return wzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzm_ = context.Operators.Where<Observation>(vzzzzzzzzzzzk_, vzzzzzzzzzzzl_);

        return vzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

        return wzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzj_ = this.HPV_Test(context);
        IEnumerable<Observation> wzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzzzzzzzzzl_(Observation HPVTest)
        {
            bool? wzzzzzzzzzzzn_ = this.isComplete(context, HPVTest);
            bool? wzzzzzzzzzzzo_ = this.isLaboratoryTest(context, HPVTest);
            bool? wzzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzzn_, wzzzzzzzzzzzo_);
            Patient wzzzzzzzzzzzq_ = this.Patient(context);
            Date wzzzzzzzzzzzr_ = wzzzzzzzzzzzq_?.BirthDateElement;
            string wzzzzzzzzzzzs_ = wzzzzzzzzzzzr_?.Value;
            CqlDate wzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzs_);
            DataType wzzzzzzzzzzzu_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzv_ = this.toInterval(context, wzzzzzzzzzzzu_);
            CqlDateTime wzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzv_);
            CqlDate wzzzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzzzw_);
            int? wzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzt_, wzzzzzzzzzzzx_, "year");
            bool? wzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzy_, 30);
            bool? xzzzzzzzzzzza_ = context.Operators.And(wzzzzzzzzzzzp_, wzzzzzzzzzzzz_);
            CqlDateTime xzzzzzzzzzzzc_ = this.latest(context, wzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzze_ = context.Operators.End(xzzzzzzzzzzzd_);
            CqlQuantity xzzzzzzzzzzzf_ = context.Operators.Quantity(5m, "years");
            CqlDateTime xzzzzzzzzzzzg_ = context.Operators.Subtract(xzzzzzzzzzzze_, xzzzzzzzzzzzf_);
            CqlDateTime xzzzzzzzzzzzi_ = context.Operators.End(xzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzj_ = context.Operators.Interval(xzzzzzzzzzzzg_, xzzzzzzzzzzzi_, true, true);
            bool? xzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzc_, xzzzzzzzzzzzj_, default);
            CqlDateTime xzzzzzzzzzzzm_ = context.Operators.End(xzzzzzzzzzzzd_);
            bool? xzzzzzzzzzzzn_ = context.Operators.Not((bool?)(xzzzzzzzzzzzm_ is null));
            bool? xzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzk_, xzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzp_ = context.Operators.And(xzzzzzzzzzzza_, xzzzzzzzzzzzo_);
            DataType xzzzzzzzzzzzq_ = HPVTest?.Value;
            bool? xzzzzzzzzzzzr_ = context.Operators.Not((bool?)(xzzzzzzzzzzzq_ is null));
            bool? xzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzp_, xzzzzzzzzzzzr_);

            return xzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzm_ = context.Operators.Where<Observation>(wzzzzzzzzzzzk_, wzzzzzzzzzzzl_);

        return wzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
