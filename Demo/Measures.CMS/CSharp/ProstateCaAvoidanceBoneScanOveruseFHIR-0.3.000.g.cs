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
[CqlLibrary("ProstateCaAvoidanceBoneScanOveruseFHIR", "0.3.000")]
public partial class ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000 : ILibrary, ISingleton<ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000>
{
    private ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000() {}

    public static ProstateCaAvoidanceBoneScanOveruseFHIR_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ProstateCaAvoidanceBoneScanOveruseFHIR";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bone Scan", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", valueSetVersion: null)]
    public CqlValueSet Bone_Scan(CqlContext _) => _Bone_Scan;
    private static readonly CqlValueSet _Bone_Scan = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", null);

    [CqlValueSetDefinition("Pain Warranting Further Investigation for Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", valueSetVersion: null)]
    public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer(CqlContext _) => _Pain_Warranting_Further_Investigation_for_Prostate_Cancer;
    private static readonly CqlValueSet _Pain_Warranting_Further_Investigation_for_Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    [CqlValueSetDefinition("Prostate Cancer Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer_Treatment(CqlContext _) => _Prostate_Cancer_Treatment;
    private static readonly CqlValueSet _Prostate_Cancer_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", null);

    [CqlValueSetDefinition("Prostate Specific Antigen Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", valueSetVersion: null)]
    public CqlValueSet Prostate_Specific_Antigen_Test(CqlContext _) => _Prostate_Specific_Antigen_Test;
    private static readonly CqlValueSet _Prostate_Specific_Antigen_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", null);

    [CqlValueSetDefinition("Salvage Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", valueSetVersion: null)]
    public CqlValueSet Salvage_Therapy(CqlContext _) => _Salvage_Therapy;
    private static readonly CqlValueSet _Salvage_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Gleason score in Specimen Qualitative", codeId: "35266-6", codeSystem: "http://loinc.org")]
    public CqlCode Gleason_score_in_Specimen_Qualitative(CqlContext _) => _Gleason_score_in_Specimen_Qualitative;
    private static readonly CqlCode _Gleason_score_in_Specimen_Qualitative = new CqlCode("35266-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)", codeId: "433351000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(CqlContext _) => _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_;
    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_ = new CqlCode("433351000124101", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)", codeId: "433361000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(CqlContext _) => _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_;
    private static readonly CqlCode _Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_ = new CqlCode("433361000124104", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Procedure reason record (record artifact)", codeId: "433611000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Procedure_reason_record__record_artifact_(CqlContext _) => _Procedure_reason_record__record_artifact_;
    private static readonly CqlCode _Procedure_reason_record__record_artifact_ = new CqlCode("433611000124109", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)", codeId: "369833007", codeSystem: "http://snomed.info/sct")]
    public CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(CqlContext _) => _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_;
    private static readonly CqlCode _T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_ = new CqlCode("369833007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)", codeId: "369834001", codeSystem: "http://snomed.info/sct")]
    public CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(CqlContext _) => _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_;
    private static readonly CqlCode _T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_ = new CqlCode("369834001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("UCUM")]
    public CqlCodeSystem UCUM(CqlContext _) => _UCUM;
    private static readonly CqlCodeSystem _UCUM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzv_, true, true);
        object zzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.3.000", "Measurement Period", zzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzy_);

        return zzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzze_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzg_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzj_, "day");
            bool? azzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancer);
            bool? azzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancer);
            bool? azzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzm_);
            bool? azzzzzzzzzzzzzzzzzzo_ = context.Operators.And(azzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzn_);

            return azzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzp_ = this.Prostate_Cancer_Diagnosis(context);
        bool? azzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("First Prostate Cancer Treatment during day of Measurement Period")]
    public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzr_ = this.Prostate_Cancer_Treatment(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? azzzzzzzzzzzzzzzzzzt_(Procedure ProstateCancerTreatment)
        {
            DataType azzzzzzzzzzzzzzzzzzy_ = ProstateCancerTreatment?.Performed;
            object azzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzz_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(bzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzc_, "day");
            Code<EventStatus> bzzzzzzzzzzzzzzzzzze_ = ProstateCancerTreatment?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzze_?.Value;
            string bzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzg_, "completed");
            bool? bzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzt_);
        object azzzzzzzzzzzzzzzzzzv_(Procedure @this)
        {
            DataType bzzzzzzzzzzzzzzzzzzj_ = @this?.Performed;
            object bzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzl_);

            return bzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Procedure>(azzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure azzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Procedure>(azzzzzzzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
    public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzn_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzq_(Observation ProstateCancerStaging)
        {
            Procedure bzzzzzzzzzzzzzzzzzzz_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] czzzzzzzzzzzzzzzzzza_ = [
                bzzzzzzzzzzzzzzzzzzz_,
            ];
            bool? czzzzzzzzzzzzzzzzzzb_(Procedure FirstProstateCancerTreatment)
            {
                DataType czzzzzzzzzzzzzzzzzzf_ = ProstateCancerStaging?.Effective;
                object czzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzh_);
                DataType czzzzzzzzzzzzzzzzzzj_ = FirstProstateCancerTreatment?.Performed;
                object czzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzk_);
                CqlDateTime czzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzl_);
                bool? czzzzzzzzzzzzzzzzzzn_ = context.Operators.Before(czzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzo_ = ProstateCancerStaging?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzo_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzp_);
                string czzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzq_);
                string[] czzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzu_ = context.Operators.And(czzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzt_);

                return czzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzb_);
            Observation czzzzzzzzzzzzzzzzzzd_(Procedure FirstProstateCancerTreatment) =>
                ProstateCancerStaging;
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Procedure, Observation>(czzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzd_);

            return czzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzq_);
        object bzzzzzzzzzzzzzzzzzzs_(Observation @this)
        {
            DataType czzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
            object czzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzw_);
            CqlDateTime czzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzx_);

            return czzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzzzzzzzzzzzzu_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzt_);
        Observation[] bzzzzzzzzzzzzzzzzzzv_ = [
            bzzzzzzzzzzzzzzzzzzu_,
        ];
        bool? bzzzzzzzzzzzzzzzzzzw_(Observation LastProstateCancerStaging)
        {
            DataType czzzzzzzzzzzzzzzzzzz_ = LastProstateCancerStaging?.Value;
            object dzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzz_);
            CqlCode dzzzzzzzzzzzzzzzzzzb_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_(context);
            CqlConcept dzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzb_);
            bool? dzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzza_ as CqlConcept, dzzzzzzzzzzzzzzzzzzc_);
            object dzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzz_);
            CqlCode dzzzzzzzzzzzzzzzzzzg_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_(context);
            CqlConcept dzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzg_);
            bool? dzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzf_ as CqlConcept, dzzzzzzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzi_);
            object dzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzz_);
            CqlCode dzzzzzzzzzzzzzzzzzzm_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_(context);
            CqlConcept dzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzl_ as CqlConcept, dzzzzzzzzzzzzzzzzzzn_);
            bool? dzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzo_);
            object dzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzz_);
            CqlCode dzzzzzzzzzzzzzzzzzzs_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_(context);
            CqlConcept dzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzs_);
            bool? dzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzzr_ as CqlConcept, dzzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>((IEnumerable<Observation>)bzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzw_);
        Observation bzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Observation>(bzzzzzzzzzzzzzzzzzzx_);

        return bzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Most Recent PSA Test Result is Low")]
    public bool? Most_Recent_PSA_Test_Result_is_Low(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzw_ = this.Prostate_Specific_Antigen_Test(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzy_(Observation PSATest)
        {
            Observation ezzzzzzzzzzzzzzzzzzi_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
            Observation[] ezzzzzzzzzzzzzzzzzzj_ = [
                ezzzzzzzzzzzzzzzzzzi_,
            ];
            bool? ezzzzzzzzzzzzzzzzzzk_(Observation MostRecentProstateCancerStaging)
            {
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzo_()
                {
                    bool fzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzb_ = PSATest?.Effective;
                        object fzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzb_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzd_);

                        return fzzzzzzzzzzzzzzzzzze_ is null;
                    };
                    if (fzzzzzzzzzzzzzzzzzza_())
                    {
                        return default;
                    }
                    else
                    {
                        DataType fzzzzzzzzzzzzzzzzzzf_ = PSATest?.Effective;
                        object fzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzh_);
                        object fzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzk_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzm_, true, true);

                        return fzzzzzzzzzzzzzzzzzzn_;
                    }
                };
                DataType ezzzzzzzzzzzzzzzzzzp_ = MostRecentProstateCancerStaging?.Effective;
                object ezzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzq_);
                bool? ezzzzzzzzzzzzzzzzzzs_ = context.Operators.Before(ezzzzzzzzzzzzzzzzzzo_(), ezzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzt_ = PSATest?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzt_?.Value;
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzu_);
                string ezzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzv_);
                string[] ezzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzy_);

                return ezzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>((IEnumerable<Observation>)ezzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzk_);
            Observation ezzzzzzzzzzzzzzzzzzm_(Observation MostRecentProstateCancerStaging) =>
                PSATest;
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Observation, Observation>(ezzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Observation, Observation>(dzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzy_);
        object ezzzzzzzzzzzzzzzzzza_(Observation @this)
        {
            DataType fzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
            object fzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzq_);

            return fzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzzzb_);
        Observation[] ezzzzzzzzzzzzzzzzzzd_ = [
            ezzzzzzzzzzzzzzzzzzc_,
        ];
        bool? ezzzzzzzzzzzzzzzzzze_(Observation LastPSATest)
        {
            DataType fzzzzzzzzzzzzzzzzzzs_ = LastPSATest?.Value;
            object fzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(10m, "ng/mL");
            bool? fzzzzzzzzzzzzzzzzzzv_ = context.Operators.Less(fzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzu_);

            return fzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<bool?> ezzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)ezzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzze_);
        IEnumerable<bool?> ezzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<bool?>(ezzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<bool?>(ezzzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Most Recent Gleason Score is Low")]
    public bool? Most_Recent_Gleason_Score_is_Low(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzzw_ = this.Gleason_score_in_Specimen_Qualitative(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzz_(Observation GleasonScore)
        {
            Procedure gzzzzzzzzzzzzzzzzzzj_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
            Procedure[] gzzzzzzzzzzzzzzzzzzk_ = [
                gzzzzzzzzzzzzzzzzzzj_,
            ];
            bool? gzzzzzzzzzzzzzzzzzzl_(Procedure FirstProstateCancerTreatment)
            {
                DataType gzzzzzzzzzzzzzzzzzzp_ = GleasonScore?.Effective;
                object gzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzr_);
                DataType gzzzzzzzzzzzzzzzzzzt_ = FirstProstateCancerTreatment?.Performed;
                object gzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzv_);
                bool? gzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(gzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzy_ = GleasonScore?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzy_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzz_);
                string hzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzza_);
                string[] hzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzd_);

                return hzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)gzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzl_);
            Observation gzzzzzzzzzzzzzzzzzzn_(Procedure FirstProstateCancerTreatment) =>
                GleasonScore;
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, Observation>(gzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Observation, Observation>(fzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzz_);
        object gzzzzzzzzzzzzzzzzzzb_(Observation @this)
        {
            DataType hzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
            object hzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzh_);

            return hzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation gzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzc_);
        Observation[] gzzzzzzzzzzzzzzzzzze_ = [
            gzzzzzzzzzzzzzzzzzzd_,
        ];
        bool? gzzzzzzzzzzzzzzzzzzf_(Observation LastGleasonScore)
        {
            DataType hzzzzzzzzzzzzzzzzzzj_ = LastGleasonScore?.Value;
            object hzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzj_);
            bool? hzzzzzzzzzzzzzzzzzzl_ = context.Operators.LessOrEqual(hzzzzzzzzzzzzzzzzzzk_ as int?, 6);

            return hzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<bool?> gzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)gzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<bool?> gzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<bool?>(gzzzzzzzzzzzzzzzzzzg_);
        bool? gzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<bool?>(gzzzzzzzzzzzzzzzzzzh_);

        return gzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzm_ = this.Initial_Population(context);
        Procedure hzzzzzzzzzzzzzzzzzzn_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzn_ is null));
        bool? hzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzo_);
        Observation hzzzzzzzzzzzzzzzzzzq_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a(context);
        bool? hzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzq_ is null));
        bool? hzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzr_);
        bool? hzzzzzzzzzzzzzzzzzzt_ = this.Most_Recent_PSA_Test_Result_is_Low(context);
        bool? hzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzt_);
        bool? hzzzzzzzzzzzzzzzzzzv_ = this.Most_Recent_Gleason_Score_is_Low(context);
        bool? hzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzv_);

        return hzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Bone Scan Study Performed")]
    public IEnumerable<Observation> Bone_Scan_Study_Performed(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzx_ = this.Bone_Scan(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzz_(Observation BoneScan)
        {
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzd_ = this.Prostate_Cancer_Diagnosis(context);
            bool? izzzzzzzzzzzzzzzzzze_(Condition ActiveProstateCancer)
            {
                DataType izzzzzzzzzzzzzzzzzzi_ = BoneScan?.Effective;
                object izzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzj_);
                CqlDateTime izzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime izzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzm_);
                bool? izzzzzzzzzzzzzzzzzzo_ = context.Operators.After(izzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzn_, default);

                return izzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzze_);
            Observation izzzzzzzzzzzzzzzzzzg_(Condition ActiveProstateCancer) =>
                BoneScan;
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Condition, Observation>(izzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzg_);

            return izzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzz_);
        bool? izzzzzzzzzzzzzzzzzzb_(Observation BoneScan)
        {
            DataType izzzzzzzzzzzzzzzzzzp_ = BoneScan?.Effective;
            object izzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzq_);
            CqlDateTime izzzzzzzzzzzzzzzzzzs_ = context.Operators.End(izzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzt_, "day");

            return izzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzb_);

        return izzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzv_ = this.Bone_Scan_Study_Performed(context);
        bool? izzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzzzzzv_);
        bool? izzzzzzzzzzzzzzzzzzx_ = context.Operators.Not(izzzzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Diagnosis of Pain related to Prostate Cancer")]
    public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzy_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzza_(Condition ProstateCancerPain)
        {
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzd_ = this.Prostate_Cancer_Diagnosis(context);
            bool? jzzzzzzzzzzzzzzzzzze_(Condition ActiveProstateCancer)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancerPain);
                CqlDateTime jzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime jzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzk_);
                bool? jzzzzzzzzzzzzzzzzzzm_ = context.Operators.After(jzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzl_, default);
                bool? jzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isProblemListItem(context, ProstateCancerPain);
                bool? jzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.isHealthConcern(context, ProstateCancerPain);
                bool? jzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzo_);
                bool? jzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzp_);

                return jzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzze_);
            Condition jzzzzzzzzzzzzzzzzzzg_(Condition ActiveProstateCancer) =>
                ProstateCancerPain;
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Condition, Condition>(jzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzg_);

            return jzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Condition, Condition>(izzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
    public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzr_ = this.Salvage_Therapy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzt_(Procedure SalvageTherapy)
        {
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzw_ = this.Prostate_Cancer_Diagnosis(context);
            bool? jzzzzzzzzzzzzzzzzzzx_(Condition ActiveProstateCancer)
            {
                DataType kzzzzzzzzzzzzzzzzzzb_ = SalvageTherapy?.Performed;
                object kzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime kzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveProstateCancer);
                CqlDateTime kzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzf_);
                bool? kzzzzzzzzzzzzzzzzzzh_ = context.Operators.After(kzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzg_, default);
                Code<EventStatus> kzzzzzzzzzzzzzzzzzzi_ = SalvageTherapy?.StatusElement;
                EventStatus? kzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzi_?.Value;
                string kzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzj_);
                bool? kzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzk_, "completed");
                bool? kzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzl_);

                return kzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzx_);
            Procedure jzzzzzzzzzzzzzzzzzzz_(Condition ActiveProstateCancer) =>
                SalvageTherapy;
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Condition, Procedure>(jzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzz_);

            return kzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Procedure, Procedure>(jzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(jzzzzzzzzzzzzzzzzzzu_);

        return jzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Bone Scan Study Performed with Documented Reason")]
    public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason(CqlContext context)
    {
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzn_ = this.Bone_Scan_Study_Performed(context);
        bool? kzzzzzzzzzzzzzzzzzzo_(Observation BoneScanAfterDiagnosis)
        {
            DataType kzzzzzzzzzzzzzzzzzzr_ = BoneScanAfterDiagnosis?.Value;
            object kzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzr_);
            CqlCode kzzzzzzzzzzzzzzzzzzt_ = this.Procedure_reason_record__record_artifact_(context);
            CqlConcept kzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzs_ as CqlConcept, kzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(kzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzw_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer(context);
        bool? kzzzzzzzzzzzzzzzzzzx_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzx_);
        bool? kzzzzzzzzzzzzzzzzzzz_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason(context);
        bool? lzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzz_);

        return lzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
