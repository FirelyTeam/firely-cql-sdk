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

    #region ValueSet: Congenital or Acquired Absence of Cervix
    [CqlValueSetDefinition(
        definitionName: "Congenital or Acquired Absence of Cervix",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext context) => _Congenital_or_Acquired_Absence_of_Cervix;

    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: HPV Test
    [CqlValueSetDefinition(
        definitionName: "HPV Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059",
        valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext context) => _HPV_Test;

    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);
    #endregion

    #region ValueSet: Hysterectomy with No Residual Cervix
    [CqlValueSetDefinition(
        definitionName: "Hysterectomy with No Residual Cervix",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext context) => _Hysterectomy_with_No_Residual_Cervix;

    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);
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

    #region ValueSet: Pap Test
    [CqlValueSetDefinition(
        definitionName: "Pap Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext context) => _Pap_Test;

    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);
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

    #region Code: laboratory
    [CqlCodeDefinition(
        definitionName: "laboratory",
        codeId: "laboratory",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext context) => _laboratory;

    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] dzzp_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return dzzp_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzq_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime dzzr_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> dzzs_ = context.Operators.Interval(dzzq_, dzzr_, true, false);
        object dzzt_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", dzzs_);

        return (CqlInterval<CqlDateTime>)dzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient dzzv_ = context.Operators.SingletonFrom<Patient>(dzzu_);

        return dzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> dzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return dzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> dzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return dzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> dzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return dzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return dzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet ezza_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ezzc_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ezzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ezze_ = context.Operators.Union<Encounter>(ezzb_, ezzd_);
        CqlValueSet ezzf_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ezzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ezzh_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> ezzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ezzj_ = context.Operators.Union<Encounter>(ezzg_, ezzi_);
        IEnumerable<Encounter> ezzk_ = context.Operators.Union<Encounter>(ezze_, ezzj_);
        CqlValueSet ezzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ezzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet ezzn_ = this.Online_Assessments(context);
        IEnumerable<Encounter> ezzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> ezzp_ = context.Operators.Union<Encounter>(ezzm_, ezzo_);
        IEnumerable<Encounter> ezzq_ = context.Operators.Union<Encounter>(ezzk_, ezzp_);
        bool? ezzr_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> ezzt_ = ValidEncounter?.StatusElement;
            string ezzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzt_);
            bool? ezzv_ = context.Operators.Equal(ezzu_, "finished");
            CqlInterval<CqlDateTime> ezzw_ = this.Measurement_Period(context);
            Period ezzx_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> ezzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzx_);
            bool? ezzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzw_, ezzy_, default);
            bool? fzza_ = context.Operators.And(ezzv_, ezzz_);

            return fzza_;
        };
        IEnumerable<Encounter> ezzs_ = context.Operators.Where<Encounter>(ezzq_, ezzr_);

        return ezzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient fzzb_ = this.Patient(context);
        Date fzzc_ = fzzb_?.BirthDateElement;
        string fzzd_ = fzzc_?.Value;
        CqlDate fzze_ = context.Operators.ConvertStringToDate(fzzd_);
        CqlInterval<CqlDateTime> fzzf_ = this.Measurement_Period(context);
        CqlDateTime fzzg_ = context.Operators.Start(fzzf_);
        CqlDate fzzh_ = context.Operators.DateFrom(fzzg_);
        int? fzzi_ = context.Operators.CalculateAgeAt(fzze_, fzzh_, "year");
        CqlInterval<int?> fzzj_ = context.Operators.Interval(23, 64, true, false);
        bool? fzzk_ = context.Operators.In<int?>(fzzi_, fzzj_, default);
        Code<AdministrativeGender> fzzm_ = fzzb_?.GenderElement;
        string fzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzm_);
        bool? fzzo_ = context.Operators.Equal(fzzn_, "female");
        bool? fzzp_ = context.Operators.And(fzzk_, fzzo_);
        IEnumerable<Encounter> fzzq_ = this.Qualifying_Encounters(context);
        bool? fzzr_ = context.Operators.Exists<Encounter>(fzzq_);
        bool? fzzs_ = context.Operators.And(fzzp_, fzzr_);

        return fzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzt_ = this.Initial_Population(context);

        return fzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet fzzu_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> fzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzw_(Procedure NoCervixProcedure)
        {
            Code<EventStatus> gzzd_ = NoCervixProcedure?.StatusElement;
            string gzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzd_);
            bool? gzzf_ = context.Operators.Equal(gzze_, "completed");
            DataType gzzg_ = NoCervixProcedure?.Performed;
            CqlInterval<CqlDateTime> gzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzg_);
            CqlDateTime gzzi_ = context.Operators.End(gzzh_);
            CqlInterval<CqlDateTime> gzzj_ = this.Measurement_Period(context);
            CqlDateTime gzzk_ = context.Operators.End(gzzj_);
            bool? gzzl_ = context.Operators.SameOrBefore(gzzi_, gzzk_, default);
            bool? gzzm_ = context.Operators.And(gzzf_, gzzl_);

            return gzzm_;
        };
        IEnumerable<Procedure> fzzx_ = context.Operators.Where<Procedure>(fzzv_, fzzw_);
        CqlValueSet fzzy_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> fzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? gzza_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> gzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
            CqlDateTime gzzo_ = context.Operators.Start(gzzn_);
            CqlInterval<CqlDateTime> gzzp_ = this.Measurement_Period(context);
            CqlDateTime gzzq_ = context.Operators.End(gzzp_);
            bool? gzzr_ = context.Operators.SameOrBefore(gzzo_, gzzq_, default);

            return gzzr_;
        };
        IEnumerable<Condition> gzzb_ = context.Operators.Where<Condition>(fzzz_, gzza_);
        IEnumerable<object> gzzc_ = context.Operators.Union<object>(fzzx_ as IEnumerable<object>, gzzb_ as IEnumerable<object>);

        return gzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? gzzs_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<object> gzzt_ = this.Absence_of_Cervix(context);
        bool? gzzu_ = context.Operators.Exists<object>(gzzt_);
        bool? gzzv_ = context.Operators.Or(gzzs_, gzzu_);
        bool? gzzw_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? gzzx_ = context.Operators.Or(gzzv_, gzzw_);

        return gzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet gzzy_ = this.Pap_Test(context);
        IEnumerable<Observation> gzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzza_(Observation CervicalCytology)
        {
            Code<ObservationStatus> hzzc_ = CervicalCytology?.StatusElement;
            string hzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzc_);
            string[] hzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzf_ = context.Operators.In<string>(hzzd_, hzze_ as IEnumerable<string>);
            List<CodeableConcept> hzzg_ = CervicalCytology?.Category;
            bool? hzzh_(CodeableConcept CervicalCytologyCategory)
            {
                CqlCode izzd_ = this.laboratory(context);
                CqlConcept izze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                CqlCode[] izzf_ = izze_?.codes;
                bool? izzg_ = context.Operators.In<CqlCode>(izzd_, (IEnumerable<CqlCode>)izzf_);

                return izzg_;
            };
            IEnumerable<CodeableConcept> hzzi_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)hzzg_, hzzh_);
            bool? hzzj_ = context.Operators.Exists<CodeableConcept>(hzzi_);
            bool? hzzk_ = context.Operators.And(hzzf_, hzzj_);
            DataType hzzl_ = CervicalCytology?.Effective;
            CqlDateTime hzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, hzzl_);
            CqlInterval<CqlDateTime> hzzn_ = this.Measurement_Period(context);
            CqlDateTime hzzo_ = context.Operators.End(hzzn_);
            CqlQuantity hzzp_ = context.Operators.Quantity(3m, "years");
            CqlDateTime hzzq_ = context.Operators.Subtract(hzzo_, hzzp_);
            CqlDateTime hzzs_ = context.Operators.End(hzzn_);
            CqlInterval<CqlDateTime> hzzt_ = context.Operators.Interval(hzzq_, hzzs_, true, true);
            bool? hzzu_ = context.Operators.In<CqlDateTime>(hzzm_, hzzt_, default);
            CqlDateTime hzzw_ = context.Operators.End(hzzn_);
            bool? hzzx_ = context.Operators.Not((bool?)(hzzw_ is null));
            bool? hzzy_ = context.Operators.And(hzzu_, hzzx_);
            bool? hzzz_ = context.Operators.And(hzzk_, hzzy_);
            DataType izza_ = CervicalCytology?.Value;
            bool? izzb_ = context.Operators.Not((bool?)(izza_ is null));
            bool? izzc_ = context.Operators.And(hzzz_, izzb_);

            return izzc_;
        };
        IEnumerable<Observation> hzzb_ = context.Operators.Where<Observation>(gzzz_, hzza_);

        return hzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet izzh_ = this.HPV_Test(context);
        IEnumerable<Observation> izzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzh_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzj_(Observation HPVTest)
        {
            Code<ObservationStatus> izzl_ = HPVTest?.StatusElement;
            string izzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzl_);
            string[] izzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzo_ = context.Operators.In<string>(izzm_, izzn_ as IEnumerable<string>);
            List<CodeableConcept> izzp_ = HPVTest?.Category;
            bool? izzq_(CodeableConcept HPVTestCategory)
            {
                CqlCode jzzx_ = this.laboratory(context);
                CqlConcept jzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                CqlCode[] jzzz_ = jzzy_?.codes;
                bool? kzza_ = context.Operators.In<CqlCode>(jzzx_, (IEnumerable<CqlCode>)jzzz_);

                return kzza_;
            };
            IEnumerable<CodeableConcept> izzr_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)izzp_, izzq_);
            bool? izzs_ = context.Operators.Exists<CodeableConcept>(izzr_);
            bool? izzt_ = context.Operators.And(izzo_, izzs_);
            Patient izzu_ = this.Patient(context);
            Date izzv_ = izzu_?.BirthDateElement;
            string izzw_ = izzv_?.Value;
            CqlDate izzx_ = context.Operators.ConvertStringToDate(izzw_);
            DataType izzy_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> izzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzy_);
            CqlDateTime jzza_ = context.Operators.Start(izzz_);
            CqlDate jzzb_ = context.Operators.DateFrom(jzza_);
            int? jzzc_ = context.Operators.CalculateAgeAt(izzx_, jzzb_, "year");
            bool? jzzd_ = context.Operators.GreaterOrEqual(jzzc_, 30);
            bool? jzze_ = context.Operators.And(izzt_, jzzd_);
            CqlDateTime jzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, izzy_);
            CqlInterval<CqlDateTime> jzzh_ = this.Measurement_Period(context);
            CqlDateTime jzzi_ = context.Operators.End(jzzh_);
            CqlQuantity jzzj_ = context.Operators.Quantity(5m, "years");
            CqlDateTime jzzk_ = context.Operators.Subtract(jzzi_, jzzj_);
            CqlDateTime jzzm_ = context.Operators.End(jzzh_);
            CqlInterval<CqlDateTime> jzzn_ = context.Operators.Interval(jzzk_, jzzm_, true, true);
            bool? jzzo_ = context.Operators.In<CqlDateTime>(jzzg_, jzzn_, default);
            CqlDateTime jzzq_ = context.Operators.End(jzzh_);
            bool? jzzr_ = context.Operators.Not((bool?)(jzzq_ is null));
            bool? jzzs_ = context.Operators.And(jzzo_, jzzr_);
            bool? jzzt_ = context.Operators.And(jzze_, jzzs_);
            DataType jzzu_ = HPVTest?.Value;
            bool? jzzv_ = context.Operators.Not((bool?)(jzzu_ is null));
            bool? jzzw_ = context.Operators.And(jzzt_, jzzv_);

            return jzzw_;
        };
        IEnumerable<Observation> izzk_ = context.Operators.Where<Observation>(izzi_, izzj_);

        return izzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> kzzb_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? kzzc_ = context.Operators.Exists<Observation>(kzzb_);
        IEnumerable<Observation> kzzd_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? kzze_ = context.Operators.Exists<Observation>(kzzd_);
        bool? kzzf_ = context.Operators.Or(kzzc_, kzze_);

        return kzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> kzzg_ = observation?.StatusElement;
        string kzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzg_);
        string[] kzzi_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? kzzj_ = context.Operators.In<string>(kzzh_, kzzi_ as IEnumerable<string>);

        return kzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> kzzk_ = observation?.Category;
        bool? kzzl_(CodeableConcept category)
        {
            CqlCode kzzo_ = this.laboratory(context);
            CqlConcept kzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            CqlCode[] kzzq_ = kzzp_?.codes;
            bool? kzzr_ = context.Operators.In<CqlCode>(kzzo_, (IEnumerable<CqlCode>)kzzq_);

            return kzzr_;
        };
        IEnumerable<CodeableConcept> kzzm_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)kzzk_, kzzl_);
        bool? kzzn_ = context.Operators.Exists<CodeableConcept>(kzzm_);

        return kzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime kzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);

        return kzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context)
    {
        CqlValueSet kzzt_ = this.Pap_Test(context);
        IEnumerable<Observation> kzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzv_(Observation CervicalCytology)
        {
            bool? kzzx_ = this.isComplete(context, CervicalCytology);
            bool? kzzy_ = this.isLaboratoryTest(context, CervicalCytology);
            bool? kzzz_ = context.Operators.And(kzzx_, kzzy_);
            DataType lzza_ = CervicalCytology?.Effective;
            CqlDateTime lzzb_ = this.latest(context, lzza_);
            CqlInterval<CqlDateTime> lzzc_ = this.Measurement_Period(context);
            CqlDateTime lzzd_ = context.Operators.End(lzzc_);
            CqlQuantity lzze_ = context.Operators.Quantity(3m, "years");
            CqlDateTime lzzf_ = context.Operators.Subtract(lzzd_, lzze_);
            CqlDateTime lzzh_ = context.Operators.End(lzzc_);
            CqlInterval<CqlDateTime> lzzi_ = context.Operators.Interval(lzzf_, lzzh_, true, true);
            bool? lzzj_ = context.Operators.In<CqlDateTime>(lzzb_, lzzi_, default);
            CqlDateTime lzzl_ = context.Operators.End(lzzc_);
            bool? lzzm_ = context.Operators.Not((bool?)(lzzl_ is null));
            bool? lzzn_ = context.Operators.And(lzzj_, lzzm_);
            bool? lzzo_ = context.Operators.And(kzzz_, lzzn_);
            DataType lzzp_ = CervicalCytology?.Value;
            bool? lzzq_ = context.Operators.Not((bool?)(lzzp_ is null));
            bool? lzzr_ = context.Operators.And(lzzo_, lzzq_);

            return lzzr_;
        };
        IEnumerable<Observation> kzzw_ = context.Operators.Where<Observation>(kzzu_, kzzv_);

        return kzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> lzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);

        return lzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context)
    {
        CqlValueSet lzzt_ = this.HPV_Test(context);
        IEnumerable<Observation> lzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzv_(Observation HPVTest)
        {
            bool? lzzx_ = this.isComplete(context, HPVTest);
            bool? lzzy_ = this.isLaboratoryTest(context, HPVTest);
            bool? lzzz_ = context.Operators.And(lzzx_, lzzy_);
            Patient mzza_ = this.Patient(context);
            Date mzzb_ = mzza_?.BirthDateElement;
            string mzzc_ = mzzb_?.Value;
            CqlDate mzzd_ = context.Operators.ConvertStringToDate(mzzc_);
            DataType mzze_ = HPVTest?.Effective;
            CqlInterval<CqlDateTime> mzzf_ = this.toInterval(context, mzze_);
            CqlDateTime mzzg_ = context.Operators.Start(mzzf_);
            CqlDate mzzh_ = context.Operators.DateFrom(mzzg_);
            int? mzzi_ = context.Operators.CalculateAgeAt(mzzd_, mzzh_, "year");
            bool? mzzj_ = context.Operators.GreaterOrEqual(mzzi_, 30);
            bool? mzzk_ = context.Operators.And(lzzz_, mzzj_);
            CqlDateTime mzzm_ = this.latest(context, mzze_);
            CqlInterval<CqlDateTime> mzzn_ = this.Measurement_Period(context);
            CqlDateTime mzzo_ = context.Operators.End(mzzn_);
            CqlQuantity mzzp_ = context.Operators.Quantity(5m, "years");
            CqlDateTime mzzq_ = context.Operators.Subtract(mzzo_, mzzp_);
            CqlDateTime mzzs_ = context.Operators.End(mzzn_);
            CqlInterval<CqlDateTime> mzzt_ = context.Operators.Interval(mzzq_, mzzs_, true, true);
            bool? mzzu_ = context.Operators.In<CqlDateTime>(mzzm_, mzzt_, default);
            CqlDateTime mzzw_ = context.Operators.End(mzzn_);
            bool? mzzx_ = context.Operators.Not((bool?)(mzzw_ is null));
            bool? mzzy_ = context.Operators.And(mzzu_, mzzx_);
            bool? mzzz_ = context.Operators.And(mzzk_, mzzy_);
            DataType nzza_ = HPVTest?.Value;
            bool? nzzb_ = context.Operators.Not((bool?)(nzza_ is null));
            bool? nzzc_ = context.Operators.And(mzzz_, nzzb_);

            return nzzc_;
        };
        IEnumerable<Observation> lzzw_ = context.Operators.Where<Observation>(lzzu_, lzzv_);

        return lzzw_;
    }


    #endregion Expressions

}
