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
[CqlLibrary("ColonCancerScreeningFHIR", "0.1.000")]
public partial class ColonCancerScreeningFHIR_0_1_000 : ILibrary, ISingleton<ColonCancerScreeningFHIR_0_1_000>
{
    private ColonCancerScreeningFHIR_0_1_000() {}

    public static ColonCancerScreeningFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ColonCancerScreeningFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Colonoscopy
    [CqlValueSetDefinition(
        definitionName: "Colonoscopy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020",
        valueSetVersion: null)]
    public CqlValueSet Colonoscopy(CqlContext context) => _Colonoscopy;

    private static readonly CqlValueSet _Colonoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);
    #endregion

    #region ValueSet: CT Colonography
    [CqlValueSetDefinition(
        definitionName: "CT Colonography",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038",
        valueSetVersion: null)]
    public CqlValueSet CT_Colonography(CqlContext context) => _CT_Colonography;

    private static readonly CqlValueSet _CT_Colonography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);
    #endregion

    #region ValueSet: Fecal Occult Blood Test (FOBT)
    [CqlValueSetDefinition(
        definitionName: "Fecal Occult Blood Test (FOBT)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011",
        valueSetVersion: null)]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext context) => _Fecal_Occult_Blood_Test__FOBT_;

    private static readonly CqlValueSet _Fecal_Occult_Blood_Test__FOBT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);
    #endregion

    #region ValueSet: sDNA FIT Test
    [CqlValueSetDefinition(
        definitionName: "sDNA FIT Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039",
        valueSetVersion: null)]
    public CqlValueSet sDNA_FIT_Test(CqlContext context) => _sDNA_FIT_Test;

    private static readonly CqlValueSet _sDNA_FIT_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);
    #endregion

    #region ValueSet: Flexible Sigmoidoscopy
    [CqlValueSetDefinition(
        definitionName: "Flexible Sigmoidoscopy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Flexible_Sigmoidoscopy(CqlContext context) => _Flexible_Sigmoidoscopy;

    private static readonly CqlValueSet _Flexible_Sigmoidoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);
    #endregion

    #region ValueSet: Malignant Neoplasm of Colon
    [CqlValueSetDefinition(
        definitionName: "Malignant Neoplasm of Colon",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext context) => _Malignant_Neoplasm_of_Colon;

    private static readonly CqlValueSet _Malignant_Neoplasm_of_Colon = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);
    #endregion

    #region ValueSet: Total Colectomy
    [CqlValueSetDefinition(
        definitionName: "Total Colectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019",
        valueSetVersion: null)]
    public CqlValueSet Total_Colectomy(CqlContext context) => _Total_Colectomy;

    private static readonly CqlValueSet _Total_Colectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzk_ = context.Operators.Interval(rzzzzzzzzzi_, rzzzzzzzzzj_, true, true);
        object rzzzzzzzzzl_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", rzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzm_);

        return rzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzs_ = this.Patient(context);
        Date rzzzzzzzzzt_ = rzzzzzzzzzs_?.BirthDateElement;
        string rzzzzzzzzzu_ = rzzzzzzzzzt_?.Value;
        CqlDate rzzzzzzzzzv_ = context.Operators.ConvertStringToDate(rzzzzzzzzzu_);
        CqlInterval<CqlDateTime> rzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzx_ = context.Operators.End(rzzzzzzzzzw_);
        CqlDate rzzzzzzzzzy_ = context.Operators.DateFrom(rzzzzzzzzzx_);
        int? rzzzzzzzzzz_ = context.Operators.CalculateAgeAt(rzzzzzzzzzv_, rzzzzzzzzzy_, "year");
        CqlInterval<int?> szzzzzzzzza_ = context.Operators.Interval(46, 75, true, true);
        bool? szzzzzzzzzb_ = context.Operators.In<int?>(rzzzzzzzzzz_, szzzzzzzzza_, default);
        IEnumerable<Encounter> szzzzzzzzzc_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? szzzzzzzzzd_ = context.Operators.Exists<Encounter>(szzzzzzzzzc_);
        bool? szzzzzzzzze_ = context.Operators.And(szzzzzzzzzb_, szzzzzzzzzd_);

        return szzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzf_ = this.Initial_Population(context);

        return szzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet szzzzzzzzzg_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> szzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzi_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ColorectalCancer);
            CqlDateTime szzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzk_);
            CqlInterval<CqlDateTime> szzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzn_ = context.Operators.End(szzzzzzzzzm_);
            bool? szzzzzzzzzo_ = context.Operators.SameOrBefore(szzzzzzzzzl_, szzzzzzzzzn_, "day");

            return szzzzzzzzzo_;
        };
        IEnumerable<Condition> szzzzzzzzzj_ = context.Operators.Where<Condition>(szzzzzzzzzh_, szzzzzzzzzi_);

        return szzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet szzzzzzzzzp_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> szzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzq_);
        bool? szzzzzzzzzs_(Procedure Colectomy)
        {
            DataType szzzzzzzzzu_ = Colectomy?.Performed;
            object szzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzu_);
            CqlInterval<CqlDateTime> szzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzv_);
            CqlDateTime szzzzzzzzzx_ = context.Operators.End(szzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzz_ = context.Operators.End(szzzzzzzzzy_);
            bool? tzzzzzzzzza_ = context.Operators.SameOrBefore(szzzzzzzzzx_, szzzzzzzzzz_, "day");

            return tzzzzzzzzza_;
        };
        IEnumerable<Procedure> szzzzzzzzzt_ = context.Operators.Where<Procedure>(szzzzzzzzzr_, szzzzzzzzzs_);

        return szzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? tzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> tzzzzzzzzzc_ = this.Malignant_Neoplasm(context);
        bool? tzzzzzzzzzd_ = context.Operators.Exists<Condition>(tzzzzzzzzzc_);
        bool? tzzzzzzzzze_ = context.Operators.Or(tzzzzzzzzzb_, tzzzzzzzzzd_);
        IEnumerable<Procedure> tzzzzzzzzzf_ = this.Total_Colectomy_Performed(context);
        bool? tzzzzzzzzzg_ = context.Operators.Exists<Procedure>(tzzzzzzzzzf_);
        bool? tzzzzzzzzzh_ = context.Operators.Or(tzzzzzzzzze_, tzzzzzzzzzg_);
        bool? tzzzzzzzzzi_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? tzzzzzzzzzj_ = context.Operators.Or(tzzzzzzzzzh_, tzzzzzzzzzi_);
        bool? tzzzzzzzzzk_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? tzzzzzzzzzl_ = context.Operators.Or(tzzzzzzzzzj_, tzzzzzzzzzk_);
        bool? tzzzzzzzzzm_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? tzzzzzzzzzn_ = context.Operators.Or(tzzzzzzzzzl_, tzzzzzzzzzm_);

        return tzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzo_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> tzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> tzzzzzzzzzq_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, tzzzzzzzzzp_);
        bool? tzzzzzzzzzr_(Observation FecalOccultResult)
        {
            DataType tzzzzzzzzzt_ = FecalOccultResult?.Value;
            object tzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzt_);
            bool? tzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzu_ is null));
            object tzzzzzzzzzw_()
            {
                bool uzzzzzzzzzb_()
                {
                    DataType uzzzzzzzzze_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzze_);
                    bool uzzzzzzzzzg_ = uzzzzzzzzzf_ is CqlDateTime;

                    return uzzzzzzzzzg_;
                };
                bool uzzzzzzzzzc_()
                {
                    DataType uzzzzzzzzzh_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzh_);
                    bool uzzzzzzzzzj_ = uzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return uzzzzzzzzzj_;
                };
                bool uzzzzzzzzzd_()
                {
                    DataType uzzzzzzzzzk_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzk_);
                    bool uzzzzzzzzzm_ = uzzzzzzzzzl_ is CqlDateTime;

                    return uzzzzzzzzzm_;
                };
                if (uzzzzzzzzzb_())
                {
                    DataType uzzzzzzzzzn_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzn_);

                    return (uzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (uzzzzzzzzzc_())
                {
                    DataType uzzzzzzzzzp_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzp_);

                    return (uzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (uzzzzzzzzzd_())
                {
                    DataType uzzzzzzzzzr_ = FecalOccultResult?.Effective;
                    object uzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzr_);

                    return (uzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime tzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, tzzzzzzzzzw_());
            CqlInterval<CqlDateTime> tzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzx_, tzzzzzzzzzy_, "day");
            bool? uzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzv_, tzzzzzzzzzz_);

            return uzzzzzzzzza_;
        };
        IEnumerable<Observation> tzzzzzzzzzs_ = context.Operators.Where<Observation>(tzzzzzzzzzq_, tzzzzzzzzzr_);

        return tzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stool DNA with FIT Test Performed")]
    public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzt_ = this.sDNA_FIT_Test(context);
        IEnumerable<Observation> uzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzzzzzzzzv_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, uzzzzzzzzzu_);
        bool? uzzzzzzzzzw_(Observation sDNATest)
        {
            DataType uzzzzzzzzzy_ = sDNATest?.Value;
            object uzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzy_);
            bool? vzzzzzzzzza_ = context.Operators.Not((bool?)(uzzzzzzzzzz_ is null));
            object vzzzzzzzzzb_()
            {
                bool vzzzzzzzzzm_()
                {
                    DataType vzzzzzzzzzp_ = sDNATest?.Effective;
                    object vzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzp_);
                    bool vzzzzzzzzzr_ = vzzzzzzzzzq_ is CqlDateTime;

                    return vzzzzzzzzzr_;
                };
                bool vzzzzzzzzzn_()
                {
                    DataType vzzzzzzzzzs_ = sDNATest?.Effective;
                    object vzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzs_);
                    bool vzzzzzzzzzu_ = vzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return vzzzzzzzzzu_;
                };
                bool vzzzzzzzzzo_()
                {
                    DataType vzzzzzzzzzv_ = sDNATest?.Effective;
                    object vzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzv_);
                    bool vzzzzzzzzzx_ = vzzzzzzzzzw_ is CqlDateTime;

                    return vzzzzzzzzzx_;
                };
                if (vzzzzzzzzzm_())
                {
                    DataType vzzzzzzzzzy_ = sDNATest?.Effective;
                    object vzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzy_);

                    return (vzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzn_())
                {
                    DataType wzzzzzzzzza_ = sDNATest?.Effective;
                    object wzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzza_);

                    return (wzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzo_())
                {
                    DataType wzzzzzzzzzc_ = sDNATest?.Effective;
                    object wzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzc_);

                    return (wzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, vzzzzzzzzzb_());
            CqlInterval<CqlDateTime> vzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzze_ = context.Operators.Start(vzzzzzzzzzd_);
            CqlQuantity vzzzzzzzzzf_ = context.Operators.Quantity(2m, "years");
            CqlDateTime vzzzzzzzzzg_ = context.Operators.Subtract(vzzzzzzzzze_, vzzzzzzzzzf_);
            CqlDateTime vzzzzzzzzzi_ = context.Operators.End(vzzzzzzzzzd_);
            CqlInterval<CqlDateTime> vzzzzzzzzzj_ = context.Operators.Interval(vzzzzzzzzzg_, vzzzzzzzzzi_, true, true);
            bool? vzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzc_, vzzzzzzzzzj_, "day");
            bool? vzzzzzzzzzl_ = context.Operators.And(vzzzzzzzzza_, vzzzzzzzzzk_);

            return vzzzzzzzzzl_;
        };
        IEnumerable<Observation> uzzzzzzzzzx_ = context.Operators.Where<Observation>(uzzzzzzzzzv_, uzzzzzzzzzw_);

        return uzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet wzzzzzzzzze_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> wzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzf_);
        bool? wzzzzzzzzzh_(Procedure FlexibleSigmoidoscopy)
        {
            DataType wzzzzzzzzzj_ = FlexibleSigmoidoscopy?.Performed;
            object wzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzk_);
            CqlDateTime wzzzzzzzzzm_ = context.Operators.End(wzzzzzzzzzl_);
            CqlInterval<CqlDateTime> wzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzo_ = context.Operators.Start(wzzzzzzzzzn_);
            CqlQuantity wzzzzzzzzzp_ = context.Operators.Quantity(4m, "years");
            CqlDateTime wzzzzzzzzzq_ = context.Operators.Subtract(wzzzzzzzzzo_, wzzzzzzzzzp_);
            CqlDateTime wzzzzzzzzzs_ = context.Operators.End(wzzzzzzzzzn_);
            CqlInterval<CqlDateTime> wzzzzzzzzzt_ = context.Operators.Interval(wzzzzzzzzzq_, wzzzzzzzzzs_, true, true);
            bool? wzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzm_, wzzzzzzzzzt_, "day");

            return wzzzzzzzzzu_;
        };
        IEnumerable<Procedure> wzzzzzzzzzi_ = context.Operators.Where<Procedure>(wzzzzzzzzzg_, wzzzzzzzzzh_);

        return wzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzv_ = this.CT_Colonography(context);
        IEnumerable<Observation> wzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzx_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, wzzzzzzzzzw_);
        bool? wzzzzzzzzzy_(Observation Colonography)
        {
            DataType xzzzzzzzzza_ = Colonography?.Effective;
            object xzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzza_);
            CqlInterval<CqlDateTime> xzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzb_);
            CqlDateTime xzzzzzzzzzd_ = context.Operators.End(xzzzzzzzzzc_);
            CqlInterval<CqlDateTime> xzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzze_);
            CqlQuantity xzzzzzzzzzg_ = context.Operators.Quantity(4m, "years");
            CqlDateTime xzzzzzzzzzh_ = context.Operators.Subtract(xzzzzzzzzzf_, xzzzzzzzzzg_);
            CqlDateTime xzzzzzzzzzj_ = context.Operators.End(xzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzk_ = context.Operators.Interval(xzzzzzzzzzh_, xzzzzzzzzzj_, true, true);
            bool? xzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzd_, xzzzzzzzzzk_, "day");

            return xzzzzzzzzzl_;
        };
        IEnumerable<Observation> wzzzzzzzzzz_ = context.Operators.Where<Observation>(wzzzzzzzzzx_, wzzzzzzzzzy_);

        return wzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzm_ = this.Colonoscopy(context);
        IEnumerable<Procedure> xzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzo_ = Status_1_8_000.Instance.isProcedurePerformed(context, xzzzzzzzzzn_);
        bool? xzzzzzzzzzp_(Procedure Colonoscopy)
        {
            DataType xzzzzzzzzzr_ = Colonoscopy?.Performed;
            object xzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzr_);
            CqlInterval<CqlDateTime> xzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzu_ = context.Operators.End(xzzzzzzzzzt_);
            CqlInterval<CqlDateTime> xzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzv_);
            CqlQuantity xzzzzzzzzzx_ = context.Operators.Quantity(9m, "years");
            CqlDateTime xzzzzzzzzzy_ = context.Operators.Subtract(xzzzzzzzzzw_, xzzzzzzzzzx_);
            CqlDateTime yzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzb_ = context.Operators.Interval(xzzzzzzzzzy_, yzzzzzzzzza_, true, true);
            bool? yzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzu_, yzzzzzzzzzb_, "day");

            return yzzzzzzzzzc_;
        };
        IEnumerable<Procedure> xzzzzzzzzzq_ = context.Operators.Where<Procedure>(xzzzzzzzzzo_, xzzzzzzzzzp_);

        return xzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> yzzzzzzzzzd_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? yzzzzzzzzze_ = context.Operators.Exists<Observation>(yzzzzzzzzzd_);
        IEnumerable<Observation> yzzzzzzzzzf_ = this.Stool_DNA_with_FIT_Test_Performed(context);
        bool? yzzzzzzzzzg_ = context.Operators.Exists<Observation>(yzzzzzzzzzf_);
        bool? yzzzzzzzzzh_ = context.Operators.Or(yzzzzzzzzze_, yzzzzzzzzzg_);
        IEnumerable<Procedure> yzzzzzzzzzi_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? yzzzzzzzzzj_ = context.Operators.Exists<Procedure>(yzzzzzzzzzi_);
        bool? yzzzzzzzzzk_ = context.Operators.Or(yzzzzzzzzzh_, yzzzzzzzzzj_);
        IEnumerable<Observation> yzzzzzzzzzl_ = this.CT_Colonography_Performed(context);
        bool? yzzzzzzzzzm_ = context.Operators.Exists<Observation>(yzzzzzzzzzl_);
        bool? yzzzzzzzzzn_ = context.Operators.Or(yzzzzzzzzzk_, yzzzzzzzzzm_);
        IEnumerable<Procedure> yzzzzzzzzzo_ = this.Colonoscopy_Performed(context);
        bool? yzzzzzzzzzp_ = context.Operators.Exists<Procedure>(yzzzzzzzzzo_);
        bool? yzzzzzzzzzq_ = context.Operators.Or(yzzzzzzzzzn_, yzzzzzzzzzp_);

        return yzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient yzzzzzzzzzr_ = this.Patient(context);
        Date yzzzzzzzzzs_ = yzzzzzzzzzr_?.BirthDateElement;
        string yzzzzzzzzzt_ = yzzzzzzzzzs_?.Value;
        CqlDate yzzzzzzzzzu_ = context.Operators.ConvertStringToDate(yzzzzzzzzzt_);
        CqlInterval<CqlDateTime> yzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzw_ = context.Operators.End(yzzzzzzzzzv_);
        CqlDate yzzzzzzzzzx_ = context.Operators.DateFrom(yzzzzzzzzzw_);
        int? yzzzzzzzzzy_ = context.Operators.CalculateAgeAt(yzzzzzzzzzu_, yzzzzzzzzzx_, "year");
        CqlInterval<int?> yzzzzzzzzzz_ = context.Operators.Interval(46, 49, true, true);
        bool? zzzzzzzzzza_ = context.Operators.In<int?>(yzzzzzzzzzy_, yzzzzzzzzzz_, default);

        return zzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient zzzzzzzzzzb_ = this.Patient(context);
        Date zzzzzzzzzzc_ = zzzzzzzzzzb_?.BirthDateElement;
        string zzzzzzzzzzd_ = zzzzzzzzzzc_?.Value;
        CqlDate zzzzzzzzzze_ = context.Operators.ConvertStringToDate(zzzzzzzzzzd_);
        CqlInterval<CqlDateTime> zzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzg_ = context.Operators.End(zzzzzzzzzzf_);
        CqlDate zzzzzzzzzzh_ = context.Operators.DateFrom(zzzzzzzzzzg_);
        int? zzzzzzzzzzi_ = context.Operators.CalculateAgeAt(zzzzzzzzzze_, zzzzzzzzzzh_, "year");
        CqlInterval<int?> zzzzzzzzzzj_ = context.Operators.Interval(50, 75, true, true);
        bool? zzzzzzzzzzk_ = context.Operators.In<int?>(zzzzzzzzzzi_, zzzzzzzzzzj_, default);

        return zzzzzzzzzzk_;
    }


    #endregion Expressions

}
