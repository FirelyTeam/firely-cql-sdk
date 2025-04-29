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
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("ColonCancerScreeningFHIR-0.1.000", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzzzzzzzzzzt_ = azzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzw_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> azzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(46, 75, true, true);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(azzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Malignant Neoplasm")]
    public IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Malignant_Neoplasm_of_Colon(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition ColorectalCancer)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ColorectalCancer);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Total Colectomy Performed")]
    public IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Total_Colectomy(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isProcedurePerformed(context, bzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure Colectomy)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Colectomy?.Performed;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzzzzzzzzza_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Malignant_Neoplasm(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Total_Colectomy_Performed(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzh_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzj_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzl_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Fecal Occult Blood Test Performed")]
    public IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, czzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation FecalOccultResult)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzs_ = FecalOccultResult?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            object czzzzzzzzzzzzzzzzzzzzzzzzzv_()
            {
                bool dzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool dzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (dzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FecalOccultResult?.Effective;
                    object dzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (dzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.latest(context, czzzzzzzzzzzzzzzzzzzzzzzzzv_());
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Stool DNA with FIT Test Performed")]
    public IEnumerable<Observation> Stool_DNA_with_FIT_Test_Performed(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.sDNA_FIT_Test(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation sDNATest)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzx_ = sDNATest?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            object ezzzzzzzzzzzzzzzzzzzzzzzzza_()
            {
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzo_ = sDNATest?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzr_ = sDNATest?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzu_ = sDNATest?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                if (ezzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzx_ = sDNATest?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzx_);

                    return (ezzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzz_ = sDNATest?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (fzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = sDNATest?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (fzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.latest(context, ezzzzzzzzzzzzzzzzzzzzzzzzza_());
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(2m, "years");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Flexible Sigmoidoscopy Performed")]
    public IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Flexible_Sigmoidoscopy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure FlexibleSigmoidoscopy)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FlexibleSigmoidoscopy?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(4m, "years");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("CT Colonography Performed")]
    public IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.CT_Colonography(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation Colonography)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Colonography?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(4m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Colonoscopy Performed")]
    public IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Colonoscopy(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure Colonoscopy)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Colonoscopy?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(9m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Fecal_Occult_Blood_Test_Performed(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Stool_DNA_with_FIT_Test_Performed(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Flexible_Sigmoidoscopy_Performed(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.CT_Colonography_Performed(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Colonoscopy_Performed(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date hzzzzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? hzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        CqlInterval<int?> hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(46, 49, true, true);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<int?>(hzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? izzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> izzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(50, 75, true, true);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(izzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

        return izzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
