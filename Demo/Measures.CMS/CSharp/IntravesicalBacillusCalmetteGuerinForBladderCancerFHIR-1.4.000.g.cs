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
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", lzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Condition?.VerificationStatus;
        CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Bladder_Cancer_Diagnosis(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition BladderCancer)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BladderCancerStaging?.Performed;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Procedure mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Condition, Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = BladderCancerStaging?.StatusElement;
            EventStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "completed");

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure @this)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "year");
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, 1);
        decimal? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 7, 1, 0, 0, 0, 0, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        int? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "year");
        decimal? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, 6, 30, 23, 59, 59, 0, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
            nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_,
        ];
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FirstBladderCancerStaging?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        Procedure nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("getStagingProcedure")]
    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = StagingObservation?.PartOf;
        Procedure ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ResourceReference StagingReference)
        {
            Procedure ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure FirstBladderCancerStagingMP)
            {
                Id ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FirstBladderCancerStagingMP?.IdElement;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                FhirString ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = StagingReference?.ReferenceElement;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.getId(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Procedure ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<Procedure>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation StagingObservation)
        {
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.getStagingProcedure(context, StagingObservation);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = StagingObservation?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlConcept, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlConcept, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = StagingObservation?.StatusElement;
            ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            Coding qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ValidEncounter?.Class;
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToCode(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.@virtual(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            Code<Encounter.EncounterStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "finished");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Qualifying_Encounter(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition ActiveTuberculosis)
        {
            Procedure rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_,
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FirstBladderCancerStaging?.Performed;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.OverlapsAfter(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Condition rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Condition, Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition ActiveTuberculosis)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure szzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                szzzzzzzzzzzzzzzzzzzzzzzzzzzza_,
            ];
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Dosage @this)
                {
                    Timing tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Timing;
                    bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Dosage> szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Timing szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Dosage @this)
                {
                    Timing tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Timing;

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<Timing> szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Dosage, Timing>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Timing dosageTiming)
                {
                    List<FhirDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "value");
                    IEnumerable<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ListSort<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Timing, CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                IEnumerable<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ListSort<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as object);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Dosage @this)
                {
                    Timing tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Timing;
                    bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

                    return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Dosage> szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Timing szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Dosage @this)
                {
                    Timing uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Timing;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Timing> szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Dosage, Timing>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Timing @this)
                {
                    Timing.RepeatComponent uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Repeat;
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<Timing> szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Timing>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                Timing.RepeatComponent szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Timing @this)
                {
                    Timing.RepeatComponent uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Repeat;

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Timing.RepeatComponent> szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Timing, Timing.RepeatComponent>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Timing.RepeatComponent @this)
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Bounds;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Timing.RepeatComponent> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Timing.RepeatComponent>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Timing.RepeatComponent @this)
                {
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Bounds;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                IEnumerable<object> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Timing.RepeatComponent, object>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Collapse(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(@this);

                    return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FirstBladderCancerStaging?.Performed;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            MedicationRequest szzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Procedure, MedicationRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                "active",
                "completed",
            ];
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "order");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure Cystectomy)
        {
            Procedure vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                vzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure FirstBladderCancerStaging)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Cystectomy?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FirstBladderCancerStaging?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(6m, "months");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, false);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Procedure vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Procedure, Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure Cystectomy)
        {
            Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Cystectomy?.StatusElement;
            EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "completed");

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.HIV(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition ExclusionDiagnosis)
        {
            Procedure wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_,
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FirstBladderCancerStaging?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Condition wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Condition, Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition ExclusionDiagnosis)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationRequest ExclusionMed)
        {
            Procedure yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_,
            ];
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ExclusionMed?.DosageInstruction;
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Dosage @this)
                {
                    Timing zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Timing;
                    bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Dosage> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Timing yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Dosage @this)
                {
                    Timing zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Timing;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Timing> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Dosage, Timing>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Timing @this)
                {
                    Timing.RepeatComponent zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Repeat;
                    bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Timing> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Timing>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Timing.RepeatComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Timing @this)
                {
                    Timing.RepeatComponent zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Repeat;

                    return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Timing.RepeatComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Timing, Timing.RepeatComponent>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Timing.RepeatComponent @this)
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Bounds;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<Timing.RepeatComponent> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Timing.RepeatComponent>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Timing.RepeatComponent @this)
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Bounds;
                    object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Timing.RepeatComponent, object>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Collapse(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(@this);

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FirstBladderCancerStaging?.Performed;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(6m, "months");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, false);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            MedicationRequest yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Procedure, MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "order");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure ExclusionProcedure)
        {
            Procedure azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure FirstBladderCancerStaging)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ExclusionProcedure?.Performed;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FirstBladderCancerStaging?.Performed;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, false);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Procedure azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Procedure, Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ExclusionProcedure?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "completed");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<object>, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<object>);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationRequest> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Immunosuppressive_Drugs(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<MedicationRequest>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Cystectomy_Done(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(MedicationAdministration BCG)
        {
            Procedure czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_,
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure FirstBladderCancerStaging)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = BCG?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FirstBladderCancerStaging?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, false, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            MedicationAdministration czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "in-progress",
                "completed",
            ];
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(MedicationAdministration @this)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<MedicationAdministration> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<MedicationAdministration>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.First_BCG_Administered(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationAdministration>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(MedicationAdministration BCGNotGiven)
        {
            Procedure fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_,
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure FirstBladderCancerStaging)
            {
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<DataType> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, DataType>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<DataType>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FirstBladderCancerStaging?.Performed;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, false, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            MedicationAdministration fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, MedicationAdministration>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<MedicationAdministration> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BCGNotGiven?.StatusReason;
            CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(CodeableConcept @this)
            {
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<MedicationAdministration> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationAdministration>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
