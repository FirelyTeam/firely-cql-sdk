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
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.4.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 : ILibrary, ISingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000>
{
    private IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000() {}

    public static IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Active Tuberculosis for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", valueSetVersion: null)]
    public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext _) => _Active_Tuberculosis_for_Urology_Care;
    private static readonly CqlValueSet _Active_Tuberculosis_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", null);

    [CqlValueSetDefinition("BCG Bacillus Calmette Guerin for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", valueSetVersion: null)]
    public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext _) => _BCG_Bacillus_Calmette_Guerin_for_Urology_Care;
    private static readonly CqlValueSet _BCG_Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", null);

    [CqlValueSetDefinition("Bladder Cancer for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", valueSetVersion: null)]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext _) => _Bladder_Cancer_for_Urology_Care;
    private static readonly CqlValueSet _Bladder_Cancer_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", null);

    [CqlValueSetDefinition("Chemotherapy Agents for Advanced Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext _) => _Chemotherapy_Agents_for_Advanced_Cancer;
    private static readonly CqlValueSet _Chemotherapy_Agents_for_Advanced_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", null);

    [CqlValueSetDefinition("Cystectomy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", valueSetVersion: null)]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext _) => _Cystectomy_for_Urology_Care;
    private static readonly CqlValueSet _Cystectomy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Immunocompromised Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", valueSetVersion: null)]
    public CqlValueSet Immunocompromised_Conditions(CqlContext _) => _Immunocompromised_Conditions;
    private static readonly CqlValueSet _Immunocompromised_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", null);

    [CqlValueSetDefinition("Immunosuppressive Drugs for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", valueSetVersion: null)]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext _) => _Immunosuppressive_Drugs_for_Urology_Care;
    private static readonly CqlValueSet _Immunosuppressive_Drugs_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", null);

    [CqlValueSetDefinition("Mixed histology urothelial cell carcinoma for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", valueSetVersion: null)]
    public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext _) => _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care;
    private static readonly CqlValueSet _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Unavailability of Bacillus Calmette Guerin for urology care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", valueSetVersion: null)]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext _) => _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care;
    private static readonly CqlValueSet _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American Joint Committee on Cancer cT1 (qualifier value)", codeId: "1228889001", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("American Joint Committee on Cancer cTa (qualifier value)", codeId: "1228883000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("American Joint Committee on Cancer cTis (qualifier value)", codeId: "1228884006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Carcinoma in situ of bladder", codeId: "D09.0", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext _) => _Carcinoma_in_situ_of_bladder;
    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlCodeDefinition("Combined radiotherapy (procedure)", codeId: "169331000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext _) => _Combined_radiotherapy__procedure_;
    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime lzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzq_ = context.Operators.Interval(lzzzzzzo_, lzzzzzzp_, true, true);
        object lzzzzzzr_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", lzzzzzzq_);

        return (CqlInterval<CqlDateTime>)lzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzt_ = context.Operators.SingletonFrom<Patient>(lzzzzzzs_);

        return lzzzzzzt_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? lzzzzzzu_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept lzzzzzzv_ = Condition?.VerificationStatus;
        CqlConcept lzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzv_);
        CqlCode lzzzzzzx_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept lzzzzzzy_ = context.Operators.ConvertCodeToConcept(lzzzzzzx_);
        bool? lzzzzzzz_ = context.Operators.Equivalent(lzzzzzzw_, lzzzzzzy_);
        bool? mzzzzzza_ = context.Operators.And(lzzzzzzu_, lzzzzzzz_);

        return mzzzzzza_;
    }


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzb_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> mzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzd_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> mzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime mzzzzzzg_ = context.Operators.Start(mzzzzzzf_);
            CqlInterval<CqlDateTime> mzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzi_ = context.Operators.End(mzzzzzzh_);
            bool? mzzzzzzj_ = context.Operators.Before(mzzzzzzg_, mzzzzzzi_, default);
            bool? mzzzzzzk_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? mzzzzzzl_ = context.Operators.And(mzzzzzzj_, mzzzzzzk_);

            return mzzzzzzl_;
        };
        IEnumerable<Condition> mzzzzzze_ = context.Operators.Where<Condition>(mzzzzzzc_, mzzzzzzd_);

        return mzzzzzze_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode mzzzzzzm_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> mzzzzzzn_ = context.Operators.ToList<CqlCode>(mzzzzzzm_);
        IEnumerable<Procedure> mzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, mzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzp_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> mzzzzzzw_ = this.Bladder_Cancer_Diagnosis(context);
            bool? mzzzzzzx_(Condition BladderCancer)
            {
                DataType nzzzzzzb_ = BladderCancerStaging?.Performed;
                object nzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzb_);
                CqlInterval<CqlDateTime> nzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzc_);
                CqlDateTime nzzzzzze_ = context.Operators.Start(nzzzzzzd_);
                CqlInterval<CqlDateTime> nzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime nzzzzzzg_ = context.Operators.Start(nzzzzzzf_);
                bool? nzzzzzzh_ = context.Operators.SameOrBefore(nzzzzzze_, nzzzzzzg_, "day");

                return nzzzzzzh_;
            };
            IEnumerable<Condition> mzzzzzzy_ = context.Operators.Where<Condition>(mzzzzzzw_, mzzzzzzx_);
            Procedure mzzzzzzz_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> nzzzzzza_ = context.Operators.Select<Condition, Procedure>(mzzzzzzy_, mzzzzzzz_);

            return nzzzzzza_;
        };
        IEnumerable<Procedure> mzzzzzzq_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzo_, mzzzzzzp_);
        bool? mzzzzzzr_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> nzzzzzzi_ = BladderCancerStaging?.StatusElement;
            EventStatus? nzzzzzzj_ = nzzzzzzi_?.Value;
            string nzzzzzzk_ = context.Operators.Convert<string>(nzzzzzzj_);
            bool? nzzzzzzl_ = context.Operators.Equal(nzzzzzzk_, "completed");

            return nzzzzzzl_;
        };
        IEnumerable<Procedure> mzzzzzzs_ = context.Operators.Where<Procedure>(mzzzzzzq_, mzzzzzzr_);
        object mzzzzzzt_(Procedure @this)
        {
            DataType nzzzzzzm_ = @this?.Performed;
            object nzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzn_);
            CqlDateTime nzzzzzzp_ = context.Operators.Start(nzzzzzzo_);

            return nzzzzzzp_;
        };
        IEnumerable<Procedure> mzzzzzzu_ = context.Operators.SortBy<Procedure>(mzzzzzzs_, mzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure mzzzzzzv_ = context.Operators.First<Procedure>(mzzzzzzu_);

        return mzzzzzzv_;
    }


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> nzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzr_ = context.Operators.Start(nzzzzzzq_);
        int? nzzzzzzs_ = context.Operators.DateTimeComponentFrom(nzzzzzzr_, "year");
        int? nzzzzzzt_ = context.Operators.Subtract(nzzzzzzs_, 1);
        decimal? nzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime nzzzzzzv_ = context.Operators.DateTime(nzzzzzzt_, 7, 1, 0, 0, 0, 0, nzzzzzzu_);

        return nzzzzzzv_;
    }


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> nzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzx_ = context.Operators.Start(nzzzzzzw_);
        int? nzzzzzzy_ = context.Operators.DateTimeComponentFrom(nzzzzzzx_, "year");
        decimal? nzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime ozzzzzza_ = context.Operators.DateTime(nzzzzzzy_, 6, 30, 23, 59, 59, 0, nzzzzzzz_);

        return ozzzzzza_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure ozzzzzzb_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] ozzzzzzc_ = [
            ozzzzzzb_,
        ];
        bool? ozzzzzzd_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime ozzzzzzg_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime ozzzzzzh_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> ozzzzzzi_ = context.Operators.Interval(ozzzzzzg_, ozzzzzzh_, true, true);
            DataType ozzzzzzj_ = FirstBladderCancerStaging?.Performed;
            object ozzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzk_);
            bool? ozzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzi_, ozzzzzzl_, "day");

            return ozzzzzzm_;
        };
        IEnumerable<Procedure> ozzzzzze_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ozzzzzzc_, ozzzzzzd_);
        Procedure ozzzzzzf_ = context.Operators.SingletonFrom<Procedure>(ozzzzzze_);

        return ozzzzzzf_;
    }


    [CqlExpressionDefinition("getStagingProcedure")]
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> ozzzzzzn_ = StagingObservation?.PartOf;
        Procedure ozzzzzzo_(ResourceReference StagingReference)
        {
            Procedure ozzzzzzr_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] ozzzzzzs_ = [
                ozzzzzzr_,
            ];
            bool? ozzzzzzt_(Procedure FirstBladderCancerStagingMP)
            {
                Id ozzzzzzw_ = FirstBladderCancerStagingMP?.IdElement;
                string ozzzzzzx_ = ozzzzzzw_?.Value;
                FhirString ozzzzzzy_ = StagingReference?.ReferenceElement;
                string ozzzzzzz_ = ozzzzzzy_?.Value;
                string pzzzzzza_ = QICoreCommon_2_1_000.Instance.getId(context, ozzzzzzz_);
                bool? pzzzzzzb_ = context.Operators.Equal(ozzzzzzx_, pzzzzzza_);

                return pzzzzzzb_;
            };
            IEnumerable<Procedure> ozzzzzzu_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ozzzzzzs_, ozzzzzzt_);
            Procedure ozzzzzzv_ = context.Operators.SingletonFrom<Procedure>(ozzzzzzu_);

            return ozzzzzzv_;
        };
        IEnumerable<Procedure> ozzzzzzp_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)ozzzzzzn_, ozzzzzzo_);
        IEnumerable<Procedure> ozzzzzzq_ = context.Operators.Distinct<Procedure>(ozzzzzzp_);

        return ozzzzzzq_;
    }


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzd_(Observation StagingObservation)
        {
            IEnumerable<Procedure> pzzzzzzg_ = this.getStagingProcedure(context, StagingObservation);
            bool? pzzzzzzh_ = context.Operators.Not((bool?)(pzzzzzzg_ is null));
            DataType pzzzzzzi_ = StagingObservation?.Value;
            object pzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzi_);
            CqlCode pzzzzzzk_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept pzzzzzzl_ = context.Operators.ConvertCodeToConcept(pzzzzzzk_);
            bool? pzzzzzzm_ = context.Operators.Equivalent(pzzzzzzj_ as CqlConcept, pzzzzzzl_);
            object pzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzi_);
            CqlCode pzzzzzzp_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept pzzzzzzq_ = context.Operators.ConvertCodeToConcept(pzzzzzzp_);
            bool? pzzzzzzr_ = context.Operators.Equivalent(pzzzzzzo_ as CqlConcept, pzzzzzzq_);
            bool? pzzzzzzs_ = context.Operators.Or(pzzzzzzm_, pzzzzzzr_);
            object pzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzi_);
            CqlCode pzzzzzzv_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept pzzzzzzw_ = context.Operators.ConvertCodeToConcept(pzzzzzzv_);
            bool? pzzzzzzx_ = context.Operators.Equivalent(pzzzzzzu_ as CqlConcept, pzzzzzzw_);
            bool? pzzzzzzy_ = context.Operators.Or(pzzzzzzs_, pzzzzzzx_);
            object qzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzi_);
            CqlCode qzzzzzzb_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept qzzzzzzc_ = context.Operators.ConvertCodeToConcept(qzzzzzzb_);
            bool? qzzzzzzd_ = context.Operators.Equivalent(qzzzzzza_ as CqlConcept, qzzzzzzc_);
            bool? qzzzzzze_ = context.Operators.Or(pzzzzzzy_, qzzzzzzd_);
            bool? qzzzzzzf_ = context.Operators.And(pzzzzzzh_, qzzzzzze_);
            Code<ObservationStatus> qzzzzzzg_ = StagingObservation?.StatusElement;
            ObservationStatus? qzzzzzzh_ = qzzzzzzg_?.Value;
            Code<ObservationStatus> qzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzh_);
            string qzzzzzzj_ = context.Operators.Convert<string>(qzzzzzzi_);
            string[] qzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzl_ = context.Operators.In<string>(qzzzzzzj_, qzzzzzzk_ as IEnumerable<string>);
            bool? qzzzzzzm_ = context.Operators.And(qzzzzzzf_, qzzzzzzl_);

            return qzzzzzzm_;
        };
        IEnumerable<Observation> pzzzzzze_ = context.Operators.Where<Observation>(pzzzzzzc_, pzzzzzzd_);
        bool? pzzzzzzf_ = context.Operators.Exists<Observation>(pzzzzzze_);

        return pzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet qzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzp_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> qzzzzzzs_ = this.Measurement_Period(context);
            Period qzzzzzzt_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzt_);
            bool? qzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzs_, qzzzzzzu_, default);
            Coding qzzzzzzw_ = ValidEncounter?.Class;
            CqlCode qzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToCode(context, qzzzzzzw_);
            CqlCode qzzzzzzy_ = this.@virtual(context);
            bool? qzzzzzzz_ = context.Operators.Equivalent(qzzzzzzx_, qzzzzzzy_);
            bool? rzzzzzza_ = context.Operators.Not(qzzzzzzz_);
            bool? rzzzzzzb_ = context.Operators.And(qzzzzzzv_, rzzzzzza_);
            Code<Encounter.EncounterStatus> rzzzzzzc_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzzzzzd_ = rzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> rzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzd_);
            bool? rzzzzzzf_ = context.Operators.Equal(rzzzzzze_, "finished");
            bool? rzzzzzzg_ = context.Operators.And(rzzzzzzb_, rzzzzzzf_);

            return rzzzzzzg_;
        };
        IEnumerable<Encounter> qzzzzzzq_ = context.Operators.Where<Encounter>(qzzzzzzo_, qzzzzzzp_);
        bool? qzzzzzzr_ = context.Operators.Exists<Encounter>(qzzzzzzq_);

        return qzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? rzzzzzzh_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? rzzzzzzi_ = this.Has_Qualifying_Encounter(context);
        bool? rzzzzzzj_ = context.Operators.And(rzzzzzzh_, rzzzzzzi_);

        return rzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzk_ = this.Initial_Population(context);

        return rzzzzzzk_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet rzzzzzzl_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> rzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzn_(Condition ActiveTuberculosis)
        {
            Procedure rzzzzzzr_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] rzzzzzzs_ = [
                rzzzzzzr_,
            ];
            bool? rzzzzzzt_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> rzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType rzzzzzzy_ = FirstBladderCancerStaging?.Performed;
                object rzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzy_);
                CqlInterval<CqlDateTime> szzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzz_);
                bool? szzzzzzb_ = context.Operators.OverlapsAfter(rzzzzzzx_, szzzzzza_, "day");

                return szzzzzzb_;
            };
            IEnumerable<Procedure> rzzzzzzu_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)rzzzzzzs_, rzzzzzzt_);
            Condition rzzzzzzv_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> rzzzzzzw_ = context.Operators.Select<Procedure, Condition>(rzzzzzzu_, rzzzzzzv_);

            return rzzzzzzw_;
        };
        IEnumerable<Condition> rzzzzzzo_ = context.Operators.SelectMany<Condition, Condition>(rzzzzzzm_, rzzzzzzn_);
        bool? rzzzzzzp_(Condition ActiveTuberculosis)
        {
            bool? szzzzzzc_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return szzzzzzc_;
        };
        IEnumerable<Condition> rzzzzzzq_ = context.Operators.Where<Condition>(rzzzzzzo_, rzzzzzzp_);

        return rzzzzzzq_;
    }


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet szzzzzzd_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> szzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzh_ = context.Operators.Union<MedicationRequest>(szzzzzze_, szzzzzzg_);
        IEnumerable<MedicationRequest> szzzzzzi_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure szzzzzzm_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] szzzzzzn_ = [
                szzzzzzm_,
            ];
            bool? szzzzzzo_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> szzzzzzs_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? szzzzzzt_(Dosage @this)
                {
                    Timing uzzzzzzd_ = @this?.Timing;
                    bool? uzzzzzze_ = context.Operators.Not((bool?)(uzzzzzzd_ is null));

                    return uzzzzzze_;
                };
                IEnumerable<Dosage> szzzzzzu_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzs_, szzzzzzt_);
                Timing szzzzzzv_(Dosage @this)
                {
                    Timing uzzzzzzf_ = @this?.Timing;

                    return uzzzzzzf_;
                };
                IEnumerable<Timing> szzzzzzw_ = context.Operators.Select<Dosage, Timing>(szzzzzzu_, szzzzzzv_);
                CqlDateTime szzzzzzx_(Timing dosageTiming)
                {
                    List<FhirDateTime> uzzzzzzg_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> uzzzzzzh_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(uzzzzzzg_, "value");
                    IEnumerable<CqlDateTime> uzzzzzzi_ = context.Operators.ListSort<CqlDateTime>(uzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime uzzzzzzj_ = context.Operators.First<CqlDateTime>(uzzzzzzi_);

                    return uzzzzzzj_;
                };
                IEnumerable<CqlDateTime> szzzzzzy_ = context.Operators.Select<Timing, CqlDateTime>(szzzzzzw_, szzzzzzx_);
                IEnumerable<CqlDateTime> szzzzzzz_ = context.Operators.Distinct<CqlDateTime>(szzzzzzy_);
                IEnumerable<CqlDateTime> tzzzzzza_ = context.Operators.ListSort<CqlDateTime>(szzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime tzzzzzzb_ = context.Operators.First<CqlDateTime>(tzzzzzza_);
                CqlInterval<CqlDateTime> tzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzb_ as object);
                bool? tzzzzzze_(Dosage @this)
                {
                    Timing uzzzzzzk_ = @this?.Timing;
                    bool? uzzzzzzl_ = context.Operators.Not((bool?)(uzzzzzzk_ is null));

                    return uzzzzzzl_;
                };
                IEnumerable<Dosage> tzzzzzzf_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzs_, tzzzzzze_);
                Timing tzzzzzzg_(Dosage @this)
                {
                    Timing uzzzzzzm_ = @this?.Timing;

                    return uzzzzzzm_;
                };
                IEnumerable<Timing> tzzzzzzh_ = context.Operators.Select<Dosage, Timing>(tzzzzzzf_, tzzzzzzg_);
                bool? tzzzzzzi_(Timing @this)
                {
                    Timing.RepeatComponent uzzzzzzn_ = @this?.Repeat;
                    bool? uzzzzzzo_ = context.Operators.Not((bool?)(uzzzzzzn_ is null));

                    return uzzzzzzo_;
                };
                IEnumerable<Timing> tzzzzzzj_ = context.Operators.Where<Timing>(tzzzzzzh_, tzzzzzzi_);
                Timing.RepeatComponent tzzzzzzk_(Timing @this)
                {
                    Timing.RepeatComponent uzzzzzzp_ = @this?.Repeat;

                    return uzzzzzzp_;
                };
                IEnumerable<Timing.RepeatComponent> tzzzzzzl_ = context.Operators.Select<Timing, Timing.RepeatComponent>(tzzzzzzj_, tzzzzzzk_);
                bool? tzzzzzzm_(Timing.RepeatComponent @this)
                {
                    DataType uzzzzzzq_ = @this?.Bounds;
                    object uzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzq_);
                    bool? uzzzzzzs_ = context.Operators.Not((bool?)(uzzzzzzr_ is null));

                    return uzzzzzzs_;
                };
                IEnumerable<Timing.RepeatComponent> tzzzzzzn_ = context.Operators.Where<Timing.RepeatComponent>(tzzzzzzl_, tzzzzzzm_);
                object tzzzzzzo_(Timing.RepeatComponent @this)
                {
                    DataType uzzzzzzt_ = @this?.Bounds;
                    object uzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzt_);

                    return uzzzzzzu_;
                };
                IEnumerable<object> tzzzzzzp_ = context.Operators.Select<Timing.RepeatComponent, object>(tzzzzzzn_, tzzzzzzo_);
                CqlInterval<CqlDateTime> tzzzzzzq_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> uzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return uzzzzzzv_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzr_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(tzzzzzzp_, tzzzzzzq_);
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzr_);
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzt_ = context.Operators.Collapse(tzzzzzzs_, default);
                object tzzzzzzu_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime uzzzzzzw_ = context.Operators.Start(@this);

                    return uzzzzzzw_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzv_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(tzzzzzzt_, tzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> tzzzzzzw_ = context.Operators.First<CqlInterval<CqlDateTime>>(tzzzzzzv_);
                CqlDateTime tzzzzzzx_ = context.Operators.Start(tzzzzzzc_ ?? tzzzzzzw_);
                DataType tzzzzzzy_ = FirstBladderCancerStaging?.Performed;
                object tzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzy_);
                CqlInterval<CqlDateTime> uzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzz_);
                CqlDateTime uzzzzzzb_ = context.Operators.Start(uzzzzzza_);
                bool? uzzzzzzc_ = context.Operators.SameOrBefore(tzzzzzzx_, uzzzzzzb_, "day");

                return uzzzzzzc_;
            };
            IEnumerable<Procedure> szzzzzzp_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)szzzzzzn_, szzzzzzo_);
            MedicationRequest szzzzzzq_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> szzzzzzr_ = context.Operators.Select<Procedure, MedicationRequest>(szzzzzzp_, szzzzzzq_);

            return szzzzzzr_;
        };
        IEnumerable<MedicationRequest> szzzzzzj_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(szzzzzzh_, szzzzzzi_);
        bool? szzzzzzk_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzx_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? uzzzzzzy_ = uzzzzzzx_?.Value;
            string uzzzzzzz_ = context.Operators.Convert<string>(uzzzzzzy_);
            string[] vzzzzzza_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzb_ = context.Operators.In<string>(uzzzzzzz_, vzzzzzza_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzc_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzd_ = vzzzzzzc_?.Value;
            string vzzzzzze_ = context.Operators.Convert<string>(vzzzzzzd_);
            bool? vzzzzzzf_ = context.Operators.Equal(vzzzzzze_, "order");
            bool? vzzzzzzg_ = context.Operators.And(vzzzzzzb_, vzzzzzzf_);

            return vzzzzzzg_;
        };
        IEnumerable<MedicationRequest> szzzzzzl_ = context.Operators.Where<MedicationRequest>(szzzzzzj_, szzzzzzk_);

        return szzzzzzl_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet vzzzzzzh_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> vzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzj_(Procedure Cystectomy)
        {
            Procedure vzzzzzzn_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] vzzzzzzo_ = [
                vzzzzzzn_,
            ];
            bool? vzzzzzzp_(Procedure FirstBladderCancerStaging)
            {
                DataType vzzzzzzt_ = Cystectomy?.Performed;
                object vzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzu_);
                CqlDateTime vzzzzzzw_ = context.Operators.End(vzzzzzzv_);
                DataType vzzzzzzx_ = FirstBladderCancerStaging?.Performed;
                object vzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzx_);
                CqlInterval<CqlDateTime> vzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzy_);
                CqlDateTime wzzzzzza_ = context.Operators.Start(vzzzzzzz_);
                CqlQuantity wzzzzzzb_ = context.Operators.Quantity(6m, "months");
                CqlDateTime wzzzzzzc_ = context.Operators.Subtract(wzzzzzza_, wzzzzzzb_);
                object wzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzx_);
                CqlInterval<CqlDateTime> wzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzze_);
                CqlDateTime wzzzzzzg_ = context.Operators.Start(wzzzzzzf_);
                CqlInterval<CqlDateTime> wzzzzzzh_ = context.Operators.Interval(wzzzzzzc_, wzzzzzzg_, true, false);
                bool? wzzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzzw_, wzzzzzzh_, default);
                object wzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzx_);
                CqlInterval<CqlDateTime> wzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzk_);
                CqlDateTime wzzzzzzm_ = context.Operators.Start(wzzzzzzl_);
                bool? wzzzzzzn_ = context.Operators.Not((bool?)(wzzzzzzm_ is null));
                bool? wzzzzzzo_ = context.Operators.And(wzzzzzzi_, wzzzzzzn_);

                return wzzzzzzo_;
            };
            IEnumerable<Procedure> vzzzzzzq_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)vzzzzzzo_, vzzzzzzp_);
            Procedure vzzzzzzr_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> vzzzzzzs_ = context.Operators.Select<Procedure, Procedure>(vzzzzzzq_, vzzzzzzr_);

            return vzzzzzzs_;
        };
        IEnumerable<Procedure> vzzzzzzk_ = context.Operators.SelectMany<Procedure, Procedure>(vzzzzzzi_, vzzzzzzj_);
        bool? vzzzzzzl_(Procedure Cystectomy)
        {
            Code<EventStatus> wzzzzzzp_ = Cystectomy?.StatusElement;
            EventStatus? wzzzzzzq_ = wzzzzzzp_?.Value;
            string wzzzzzzr_ = context.Operators.Convert<string>(wzzzzzzq_);
            bool? wzzzzzzs_ = context.Operators.Equal(wzzzzzzr_, "completed");

            return wzzzzzzs_;
        };
        IEnumerable<Procedure> vzzzzzzm_ = context.Operators.Where<Procedure>(vzzzzzzk_, vzzzzzzl_);

        return vzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet wzzzzzzt_ = this.HIV(context);
        IEnumerable<Condition> wzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzv_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> wzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzx_ = context.Operators.Union<Condition>(wzzzzzzu_, wzzzzzzw_);
        CqlValueSet wzzzzzzy_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> wzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzza_ = context.Operators.Union<Condition>(wzzzzzzx_, wzzzzzzz_);
        IEnumerable<Condition> xzzzzzzb_(Condition ExclusionDiagnosis)
        {
            Procedure xzzzzzzg_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] xzzzzzzh_ = [
                xzzzzzzg_,
            ];
            bool? xzzzzzzi_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> xzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime xzzzzzzn_ = context.Operators.Start(xzzzzzzm_);
                DataType xzzzzzzo_ = FirstBladderCancerStaging?.Performed;
                object xzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzo_);
                CqlInterval<CqlDateTime> xzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzp_);
                CqlDateTime xzzzzzzr_ = context.Operators.Start(xzzzzzzq_);
                bool? xzzzzzzs_ = context.Operators.SameOrBefore(xzzzzzzn_, xzzzzzzr_, "day");

                return xzzzzzzs_;
            };
            IEnumerable<Procedure> xzzzzzzj_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)xzzzzzzh_, xzzzzzzi_);
            Condition xzzzzzzk_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> xzzzzzzl_ = context.Operators.Select<Procedure, Condition>(xzzzzzzj_, xzzzzzzk_);

            return xzzzzzzl_;
        };
        IEnumerable<Condition> xzzzzzzc_ = context.Operators.SelectMany<Condition, Condition>(xzzzzzza_, xzzzzzzb_);
        bool? xzzzzzzd_(Condition ExclusionDiagnosis)
        {
            bool? xzzzzzzt_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return xzzzzzzt_;
        };
        IEnumerable<Condition> xzzzzzze_ = context.Operators.Where<Condition>(xzzzzzzc_, xzzzzzzd_);
        bool? xzzzzzzf_ = context.Operators.Exists<Condition>(xzzzzzze_);

        return xzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet xzzzzzzu_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> xzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzy_ = context.Operators.Union<MedicationRequest>(xzzzzzzv_, xzzzzzzx_);
        IEnumerable<MedicationRequest> xzzzzzzz_(MedicationRequest ExclusionMed)
        {
            Procedure yzzzzzzm_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] yzzzzzzn_ = [
                yzzzzzzm_,
            ];
            bool? yzzzzzzo_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> yzzzzzzs_ = ExclusionMed?.DosageInstruction;
                bool? yzzzzzzt_(Dosage @this)
                {
                    Timing azzzzzzzf_ = @this?.Timing;
                    bool? azzzzzzzg_ = context.Operators.Not((bool?)(azzzzzzzf_ is null));

                    return azzzzzzzg_;
                };
                IEnumerable<Dosage> yzzzzzzu_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)yzzzzzzs_, yzzzzzzt_);
                Timing yzzzzzzv_(Dosage @this)
                {
                    Timing azzzzzzzh_ = @this?.Timing;

                    return azzzzzzzh_;
                };
                IEnumerable<Timing> yzzzzzzw_ = context.Operators.Select<Dosage, Timing>(yzzzzzzu_, yzzzzzzv_);
                bool? yzzzzzzx_(Timing @this)
                {
                    Timing.RepeatComponent azzzzzzzi_ = @this?.Repeat;
                    bool? azzzzzzzj_ = context.Operators.Not((bool?)(azzzzzzzi_ is null));

                    return azzzzzzzj_;
                };
                IEnumerable<Timing> yzzzzzzy_ = context.Operators.Where<Timing>(yzzzzzzw_, yzzzzzzx_);
                Timing.RepeatComponent yzzzzzzz_(Timing @this)
                {
                    Timing.RepeatComponent azzzzzzzk_ = @this?.Repeat;

                    return azzzzzzzk_;
                };
                IEnumerable<Timing.RepeatComponent> zzzzzzza_ = context.Operators.Select<Timing, Timing.RepeatComponent>(yzzzzzzy_, yzzzzzzz_);
                bool? zzzzzzzb_(Timing.RepeatComponent @this)
                {
                    DataType azzzzzzzl_ = @this?.Bounds;
                    object azzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzl_);
                    bool? azzzzzzzn_ = context.Operators.Not((bool?)(azzzzzzzm_ is null));

                    return azzzzzzzn_;
                };
                IEnumerable<Timing.RepeatComponent> zzzzzzzc_ = context.Operators.Where<Timing.RepeatComponent>(zzzzzzza_, zzzzzzzb_);
                object zzzzzzzd_(Timing.RepeatComponent @this)
                {
                    DataType azzzzzzzo_ = @this?.Bounds;
                    object azzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzo_);

                    return azzzzzzzp_;
                };
                IEnumerable<object> zzzzzzze_ = context.Operators.Select<Timing.RepeatComponent, object>(zzzzzzzc_, zzzzzzzd_);
                CqlInterval<CqlDateTime> zzzzzzzf_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> azzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return azzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzg_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(zzzzzzze_, zzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzzzzzg_);
                IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzi_ = context.Operators.Collapse(zzzzzzzh_, default);
                object zzzzzzzj_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime azzzzzzzr_ = context.Operators.Start(@this);

                    return azzzzzzzr_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzk_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(zzzzzzzi_, zzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> zzzzzzzl_ = context.Operators.First<CqlInterval<CqlDateTime>>(zzzzzzzk_);
                CqlDateTime zzzzzzzm_ = context.Operators.Start(zzzzzzzl_);
                DataType zzzzzzzn_ = FirstBladderCancerStaging?.Performed;
                object zzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzn_);
                CqlInterval<CqlDateTime> zzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzo_);
                CqlDateTime zzzzzzzq_ = context.Operators.Start(zzzzzzzp_);
                CqlQuantity zzzzzzzr_ = context.Operators.Quantity(6m, "months");
                CqlDateTime zzzzzzzs_ = context.Operators.Subtract(zzzzzzzq_, zzzzzzzr_);
                object zzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzn_);
                CqlInterval<CqlDateTime> zzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzu_);
                CqlDateTime zzzzzzzw_ = context.Operators.Start(zzzzzzzv_);
                CqlInterval<CqlDateTime> zzzzzzzx_ = context.Operators.Interval(zzzzzzzs_, zzzzzzzw_, true, false);
                bool? zzzzzzzy_ = context.Operators.In<CqlDateTime>(zzzzzzzm_, zzzzzzzx_, default);
                object azzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzn_);
                CqlInterval<CqlDateTime> azzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzza_);
                CqlDateTime azzzzzzzc_ = context.Operators.Start(azzzzzzzb_);
                bool? azzzzzzzd_ = context.Operators.Not((bool?)(azzzzzzzc_ is null));
                bool? azzzzzzze_ = context.Operators.And(zzzzzzzy_, azzzzzzzd_);

                return azzzzzzze_;
            };
            IEnumerable<Procedure> yzzzzzzp_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)yzzzzzzn_, yzzzzzzo_);
            MedicationRequest yzzzzzzq_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> yzzzzzzr_ = context.Operators.Select<Procedure, MedicationRequest>(yzzzzzzp_, yzzzzzzq_);

            return yzzzzzzr_;
        };
        IEnumerable<MedicationRequest> yzzzzzza_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(xzzzzzzy_, xzzzzzzz_);
        bool? yzzzzzzb_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> azzzzzzzs_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? azzzzzzzt_ = azzzzzzzs_?.Value;
            string azzzzzzzu_ = context.Operators.Convert<string>(azzzzzzzt_);
            string[] azzzzzzzv_ = [
                "active",
                "completed",
            ];
            bool? azzzzzzzw_ = context.Operators.In<string>(azzzzzzzu_, azzzzzzzv_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> azzzzzzzx_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? azzzzzzzy_ = azzzzzzzx_?.Value;
            string azzzzzzzz_ = context.Operators.Convert<string>(azzzzzzzy_);
            bool? bzzzzzzza_ = context.Operators.Equal(azzzzzzzz_, "order");
            bool? bzzzzzzzb_ = context.Operators.And(azzzzzzzw_, bzzzzzzza_);

            return bzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> yzzzzzzc_ = context.Operators.Where<MedicationRequest>(yzzzzzza_, yzzzzzzb_);
        CqlCode yzzzzzzd_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> yzzzzzze_ = context.Operators.ToList<CqlCode>(yzzzzzzd_);
        IEnumerable<Procedure> yzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, yzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzg_(Procedure ExclusionProcedure)
        {
            Procedure bzzzzzzzc_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] bzzzzzzzd_ = [
                bzzzzzzzc_,
            ];
            bool? bzzzzzzze_(Procedure FirstBladderCancerStaging)
            {
                DataType bzzzzzzzi_ = ExclusionProcedure?.Performed;
                object bzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzi_);
                CqlInterval<CqlDateTime> bzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzj_);
                CqlDateTime bzzzzzzzl_ = context.Operators.Start(bzzzzzzzk_);
                DataType bzzzzzzzm_ = FirstBladderCancerStaging?.Performed;
                object bzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzn_);
                CqlDateTime bzzzzzzzp_ = context.Operators.Start(bzzzzzzzo_);
                CqlQuantity bzzzzzzzq_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bzzzzzzzr_ = context.Operators.Subtract(bzzzzzzzp_, bzzzzzzzq_);
                object bzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzt_);
                CqlDateTime bzzzzzzzv_ = context.Operators.Start(bzzzzzzzu_);
                CqlInterval<CqlDateTime> bzzzzzzzw_ = context.Operators.Interval(bzzzzzzzr_, bzzzzzzzv_, true, false);
                bool? bzzzzzzzx_ = context.Operators.In<CqlDateTime>(bzzzzzzzl_, bzzzzzzzw_, default);
                object bzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzz_);
                CqlDateTime czzzzzzzb_ = context.Operators.Start(czzzzzzza_);
                bool? czzzzzzzc_ = context.Operators.Not((bool?)(czzzzzzzb_ is null));
                bool? czzzzzzzd_ = context.Operators.And(bzzzzzzzx_, czzzzzzzc_);

                return czzzzzzzd_;
            };
            IEnumerable<Procedure> bzzzzzzzf_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)bzzzzzzzd_, bzzzzzzze_);
            Procedure bzzzzzzzg_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> bzzzzzzzh_ = context.Operators.Select<Procedure, Procedure>(bzzzzzzzf_, bzzzzzzzg_);

            return bzzzzzzzh_;
        };
        IEnumerable<Procedure> yzzzzzzh_ = context.Operators.SelectMany<Procedure, Procedure>(yzzzzzzf_, yzzzzzzg_);
        bool? yzzzzzzi_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> czzzzzzze_ = ExclusionProcedure?.StatusElement;
            EventStatus? czzzzzzzf_ = czzzzzzze_?.Value;
            string czzzzzzzg_ = context.Operators.Convert<string>(czzzzzzzf_);
            bool? czzzzzzzh_ = context.Operators.Equal(czzzzzzzg_, "completed");

            return czzzzzzzh_;
        };
        IEnumerable<Procedure> yzzzzzzj_ = context.Operators.Where<Procedure>(yzzzzzzh_, yzzzzzzi_);
        IEnumerable<object> yzzzzzzk_ = context.Operators.Union<object>(yzzzzzzc_ as IEnumerable<object>, yzzzzzzj_ as IEnumerable<object>);
        bool? yzzzzzzl_ = context.Operators.Exists<object>(yzzzzzzk_);

        return yzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> czzzzzzzi_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? czzzzzzzj_ = context.Operators.Exists<Condition>(czzzzzzzi_);
        IEnumerable<MedicationRequest> czzzzzzzk_ = this.Immunosuppressive_Drugs(context);
        bool? czzzzzzzl_ = context.Operators.Exists<MedicationRequest>(czzzzzzzk_);
        bool? czzzzzzzm_ = context.Operators.Or(czzzzzzzj_, czzzzzzzl_);
        IEnumerable<Procedure> czzzzzzzn_ = this.Cystectomy_Done(context);
        bool? czzzzzzzo_ = context.Operators.Exists<Procedure>(czzzzzzzn_);
        bool? czzzzzzzp_ = context.Operators.Or(czzzzzzzm_, czzzzzzzo_);
        bool? czzzzzzzq_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? czzzzzzzr_ = context.Operators.Or(czzzzzzzp_, czzzzzzzq_);
        bool? czzzzzzzs_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? czzzzzzzt_ = context.Operators.Or(czzzzzzzr_, czzzzzzzs_);

        return czzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet czzzzzzzu_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> czzzzzzzv_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> czzzzzzzx_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> czzzzzzzy_ = context.Operators.Union<MedicationAdministration>(czzzzzzzv_, czzzzzzzx_);
        IEnumerable<MedicationAdministration> czzzzzzzz_(MedicationAdministration BCG)
        {
            Procedure dzzzzzzzg_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] dzzzzzzzh_ = [
                dzzzzzzzg_,
            ];
            bool? dzzzzzzzi_(Procedure FirstBladderCancerStaging)
            {
                DataType dzzzzzzzm_ = BCG?.Effective;
                object dzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzm_);
                CqlInterval<CqlDateTime> dzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzn_);
                CqlDateTime dzzzzzzzp_ = context.Operators.Start(dzzzzzzzo_);
                DataType dzzzzzzzq_ = FirstBladderCancerStaging?.Performed;
                object dzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzr_);
                CqlDateTime dzzzzzzzt_ = context.Operators.Start(dzzzzzzzs_);
                object dzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzv_);
                CqlDateTime dzzzzzzzx_ = context.Operators.Start(dzzzzzzzw_);
                CqlQuantity dzzzzzzzy_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dzzzzzzzz_ = context.Operators.Add(dzzzzzzzx_, dzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzza_ = context.Operators.Interval(dzzzzzzzt_, dzzzzzzzz_, false, true);
                bool? ezzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzp_, ezzzzzzza_, default);
                object ezzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzq_);
                CqlInterval<CqlDateTime> ezzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzd_);
                CqlDateTime ezzzzzzzf_ = context.Operators.Start(ezzzzzzze_);
                bool? ezzzzzzzg_ = context.Operators.Not((bool?)(ezzzzzzzf_ is null));
                bool? ezzzzzzzh_ = context.Operators.And(ezzzzzzzb_, ezzzzzzzg_);
                object ezzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzm_);
                CqlInterval<CqlDateTime> ezzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzj_);
                CqlDateTime ezzzzzzzl_ = context.Operators.Start(ezzzzzzzk_);
                CqlInterval<CqlDateTime> ezzzzzzzm_ = this.Measurement_Period(context);
                bool? ezzzzzzzn_ = context.Operators.In<CqlDateTime>(ezzzzzzzl_, ezzzzzzzm_, default);
                bool? ezzzzzzzo_ = context.Operators.And(ezzzzzzzh_, ezzzzzzzn_);

                return ezzzzzzzo_;
            };
            IEnumerable<Procedure> dzzzzzzzj_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)dzzzzzzzh_, dzzzzzzzi_);
            MedicationAdministration dzzzzzzzk_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> dzzzzzzzl_ = context.Operators.Select<Procedure, MedicationAdministration>(dzzzzzzzj_, dzzzzzzzk_);

            return dzzzzzzzl_;
        };
        IEnumerable<MedicationAdministration> dzzzzzzza_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(czzzzzzzy_, czzzzzzzz_);
        bool? dzzzzzzzb_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ezzzzzzzp_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ezzzzzzzq_ = ezzzzzzzp_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ezzzzzzzr_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(ezzzzzzzq_);
            string ezzzzzzzs_ = context.Operators.Convert<string>(ezzzzzzzr_);
            string[] ezzzzzzzt_ = [
                "in-progress",
                "completed",
            ];
            bool? ezzzzzzzu_ = context.Operators.In<string>(ezzzzzzzs_, ezzzzzzzt_ as IEnumerable<string>);

            return ezzzzzzzu_;
        };
        IEnumerable<MedicationAdministration> dzzzzzzzc_ = context.Operators.Where<MedicationAdministration>(dzzzzzzza_, dzzzzzzzb_);
        object dzzzzzzzd_(MedicationAdministration @this)
        {
            DataType ezzzzzzzv_ = @this?.Effective;
            object ezzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzw_);
            CqlDateTime ezzzzzzzy_ = context.Operators.Start(ezzzzzzzx_);

            return ezzzzzzzy_;
        };
        IEnumerable<MedicationAdministration> dzzzzzzze_ = context.Operators.SortBy<MedicationAdministration>(dzzzzzzzc_, dzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration dzzzzzzzf_ = context.Operators.First<MedicationAdministration>(dzzzzzzze_);

        return dzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration ezzzzzzzz_ = this.First_BCG_Administered(context);
        bool? fzzzzzzza_ = context.Operators.Not((bool?)(ezzzzzzzz_ is null));

        return fzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return fzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> fzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return fzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? fzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return fzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return fzzzzzzze_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet fzzzzzzzf_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> fzzzzzzzg_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> fzzzzzzzi_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, fzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> fzzzzzzzj_ = context.Operators.Union<MedicationAdministration>(fzzzzzzzg_, fzzzzzzzi_);
        IEnumerable<MedicationAdministration> fzzzzzzzk_(MedicationAdministration BCGNotGiven)
        {
            Procedure fzzzzzzzo_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fzzzzzzzp_ = [
                fzzzzzzzo_,
            ];
            bool? fzzzzzzzq_(Procedure FirstBladderCancerStaging)
            {
                bool? fzzzzzzzu_(Extension @this)
                {
                    string gzzzzzzzs_ = @this?.Url;
                    FhirString gzzzzzzzt_ = context.Operators.Convert<FhirString>(gzzzzzzzs_);
                    string gzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzt_);
                    bool? gzzzzzzzv_ = context.Operators.Equal(gzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return gzzzzzzzv_;
                };
                IEnumerable<Extension> fzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), fzzzzzzzu_);
                DataType fzzzzzzzw_(Extension @this)
                {
                    DataType gzzzzzzzw_ = @this?.Value;

                    return gzzzzzzzw_;
                };
                IEnumerable<DataType> fzzzzzzzx_ = context.Operators.Select<Extension, DataType>(fzzzzzzzv_, fzzzzzzzw_);
                DataType fzzzzzzzy_ = context.Operators.SingletonFrom<DataType>(fzzzzzzzx_);
                CqlDateTime fzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzy_);
                DataType gzzzzzzza_ = FirstBladderCancerStaging?.Performed;
                object gzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzb_);
                CqlDateTime gzzzzzzzd_ = context.Operators.Start(gzzzzzzzc_);
                object gzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzf_);
                CqlDateTime gzzzzzzzh_ = context.Operators.Start(gzzzzzzzg_);
                CqlQuantity gzzzzzzzi_ = context.Operators.Quantity(6m, "months");
                CqlDateTime gzzzzzzzj_ = context.Operators.Add(gzzzzzzzh_, gzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzk_ = context.Operators.Interval(gzzzzzzzd_, gzzzzzzzj_, false, true);
                bool? gzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzz_, gzzzzzzzk_, default);
                object gzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzn_);
                CqlDateTime gzzzzzzzp_ = context.Operators.Start(gzzzzzzzo_);
                bool? gzzzzzzzq_ = context.Operators.Not((bool?)(gzzzzzzzp_ is null));
                bool? gzzzzzzzr_ = context.Operators.And(gzzzzzzzl_, gzzzzzzzq_);

                return gzzzzzzzr_;
            };
            IEnumerable<Procedure> fzzzzzzzr_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fzzzzzzzp_, fzzzzzzzq_);
            MedicationAdministration fzzzzzzzs_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> fzzzzzzzt_ = context.Operators.Select<Procedure, MedicationAdministration>(fzzzzzzzr_, fzzzzzzzs_);

            return fzzzzzzzt_;
        };
        IEnumerable<MedicationAdministration> fzzzzzzzl_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(fzzzzzzzj_, fzzzzzzzk_);
        bool? fzzzzzzzm_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> gzzzzzzzx_ = BCGNotGiven?.StatusReason;
            CqlConcept gzzzzzzzy_(CodeableConcept @this)
            {
                CqlConcept hzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzzzc_;
            };
            IEnumerable<CqlConcept> gzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzx_, gzzzzzzzy_);
            CqlValueSet hzzzzzzza_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? hzzzzzzzb_ = context.Operators.ConceptsInValueSet(gzzzzzzzz_, hzzzzzzza_);

            return hzzzzzzzb_;
        };
        IEnumerable<MedicationAdministration> fzzzzzzzn_ = context.Operators.Where<MedicationAdministration>(fzzzzzzzl_, fzzzzzzzm_);

        return fzzzzzzzn_;
    }


    #endregion Expressions

}
