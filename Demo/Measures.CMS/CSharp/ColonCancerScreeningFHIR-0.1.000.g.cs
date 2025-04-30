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

    [CqlValueSetDefinition("Colonoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", valueSetVersion: null)]
    public CqlValueSet Colonoscopy(CqlContext _) => _Colonoscopy;
    private static readonly CqlValueSet _Colonoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", null);

    [CqlValueSetDefinition("CT Colonography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", valueSetVersion: null)]
    public CqlValueSet CT_Colonography(CqlContext _) => _CT_Colonography;
    private static readonly CqlValueSet _CT_Colonography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", null);

    [CqlValueSetDefinition("Fecal Occult Blood Test (FOBT)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", valueSetVersion: null)]
    public CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext _) => _Fecal_Occult_Blood_Test__FOBT_;
    private static readonly CqlValueSet _Fecal_Occult_Blood_Test__FOBT_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", null);

    [CqlValueSetDefinition("sDNA FIT Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", valueSetVersion: null)]
    public CqlValueSet sDNA_FIT_Test(CqlContext _) => _sDNA_FIT_Test;
    private static readonly CqlValueSet _sDNA_FIT_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", null);

    [CqlValueSetDefinition("Flexible Sigmoidoscopy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", valueSetVersion: null)]
    public CqlValueSet Flexible_Sigmoidoscopy(CqlContext _) => _Flexible_Sigmoidoscopy;
    private static readonly CqlValueSet _Flexible_Sigmoidoscopy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", null);

    [CqlValueSetDefinition("Malignant Neoplasm of Colon", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext _) => _Malignant_Neoplasm_of_Colon;
    private static readonly CqlValueSet _Malignant_Neoplasm_of_Colon = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", null);

    [CqlValueSetDefinition("Total Colectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", valueSetVersion: null)]
    public CqlValueSet Total_Colectomy(CqlContext _) => _Total_Colectomy;
    private static readonly CqlValueSet _Total_Colectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
        CqlInterval<int?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(46, 75, true, true);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ColorectalCancer);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure Colectomy)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Colectomy?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Malignant_Neoplasm(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Total_Colectomy_Performed(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation FecalOccultResult)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FecalOccultResult?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FecalOccultResult?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FecalOccultResult?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FecalOccultResult?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FecalOccultResult?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FecalOccultResult?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FecalOccultResult?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.latest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Stool DNA with FIT Test Performed")]
    public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.sDNA_FIT_Test(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation sDNATest)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = sDNATest?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
            {
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                {
                    DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = sDNATest?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(2m, "years");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isProcedurePerformed(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure FlexibleSigmoidoscopy)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FlexibleSigmoidoscopy?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(4m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.CT_Colonography(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation Colonography)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Colonography?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(4m, "years");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Colonoscopy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure Colonoscopy)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Colonoscopy?.Performed;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(9m, "years");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Stool_DNA_with_FIT_Test_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.CT_Colonography_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Colonoscopy_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(46, 49, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        int? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(50, 75, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
