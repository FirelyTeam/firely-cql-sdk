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
[CqlLibrary("NCQAPalliativeCare", "1.0.0")]
public partial class NCQAPalliativeCare_1_0_0 : ILibrary, ISingleton<NCQAPalliativeCare_1_0_0>
{
    private NCQAPalliativeCare_1_0_0() {}

    public static NCQAPalliativeCare_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAPalliativeCare";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Palliative Care Assessment", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Assessment(CqlContext _) => _Palliative_Care_Assessment;
    private static readonly CqlValueSet _Palliative_Care_Assessment = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD-10")]
    public CqlCodeSystem ICD_10(CqlContext _) => _ICD_10;
    private static readonly CqlCodeSystem _ICD_10 = new CqlCodeSystem();

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet rzzzzzzzzzzzzzq_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzzzzs_(Observation PalliativeAssessment)
        {
            DataType szzzzzzzzzzzzzr_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzzzzzr_);
            CqlDateTime szzzzzzzzzzzzzt_ = context.Operators.Start(szzzzzzzzzzzzzs_);
            CqlDate szzzzzzzzzzzzzu_ = context.Operators.DateFrom(szzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzzzzzr_);
            CqlDateTime szzzzzzzzzzzzzx_ = context.Operators.End(szzzzzzzzzzzzzw_);
            CqlDate szzzzzzzzzzzzzy_ = context.Operators.DateFrom(szzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzz_ = context.Operators.Interval(szzzzzzzzzzzzzu_, szzzzzzzzzzzzzy_, true, true);
            CqlDateTime tzzzzzzzzzzzzza_ = context.Operators.Start(Period);
            CqlDate tzzzzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzzzzza_);
            CqlDateTime tzzzzzzzzzzzzzc_ = context.Operators.End(Period);
            CqlDate tzzzzzzzzzzzzzd_ = context.Operators.DateFrom(tzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzze_ = context.Operators.Interval(tzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzd_, true, true);
            bool? tzzzzzzzzzzzzzf_ = context.Operators.Overlaps(szzzzzzzzzzzzzz_, tzzzzzzzzzzzzze_, default);

            return tzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzt_);
        CqlValueSet rzzzzzzzzzzzzzv_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzx_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, rzzzzzzzzzzzzzw_);
        bool? rzzzzzzzzzzzzzy_(Encounter PalliativeEncounter)
        {
            Period tzzzzzzzzzzzzzg_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzg_ as object);
            CqlDateTime tzzzzzzzzzzzzzi_ = context.Operators.Start(tzzzzzzzzzzzzzh_);
            CqlDate tzzzzzzzzzzzzzj_ = context.Operators.DateFrom(tzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzg_ as object);
            CqlDateTime tzzzzzzzzzzzzzm_ = context.Operators.End(tzzzzzzzzzzzzzl_);
            CqlDate tzzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzo_ = context.Operators.Interval(tzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzn_, true, true);
            CqlDateTime tzzzzzzzzzzzzzp_ = context.Operators.Start(Period);
            CqlDate tzzzzzzzzzzzzzq_ = context.Operators.DateFrom(tzzzzzzzzzzzzzp_);
            CqlDateTime tzzzzzzzzzzzzzr_ = context.Operators.End(Period);
            CqlDate tzzzzzzzzzzzzzs_ = context.Operators.DateFrom(tzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzs_, true, true);
            bool? tzzzzzzzzzzzzzu_ = context.Operators.Overlaps(tzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzt_, default);

            return tzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzy_);
        bool? szzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzb_ = context.Operators.Or(rzzzzzzzzzzzzzu_, szzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzc_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzze_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, szzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzf_(Procedure PalliativeIntervention)
        {
            DataType tzzzzzzzzzzzzzv_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzw_);
            CqlDate tzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzv_);
            CqlDateTime uzzzzzzzzzzzzzb_ = context.Operators.End(uzzzzzzzzzzzzza_);
            CqlDate uzzzzzzzzzzzzzc_ = context.Operators.DateFrom(uzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzd_ = context.Operators.Interval(tzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzc_, true, true);
            CqlDateTime uzzzzzzzzzzzzze_ = context.Operators.Start(Period);
            CqlDate uzzzzzzzzzzzzzf_ = context.Operators.DateFrom(uzzzzzzzzzzzzze_);
            CqlDateTime uzzzzzzzzzzzzzg_ = context.Operators.End(Period);
            CqlDate uzzzzzzzzzzzzzh_ = context.Operators.DateFrom(uzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzi_ = context.Operators.Interval(uzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzh_, true, true);
            bool? uzzzzzzzzzzzzzj_ = context.Operators.Overlaps(uzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzi_, default);

            return uzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzze_, szzzzzzzzzzzzzf_);
        bool? szzzzzzzzzzzzzh_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzi_ = context.Operators.Or(szzzzzzzzzzzzzb_, szzzzzzzzzzzzzh_);
        CqlCode szzzzzzzzzzzzzj_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzj_);
        IEnumerable<Condition> szzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, szzzzzzzzzzzzzk_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, szzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzn_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime uzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzk_);
            CqlDate uzzzzzzzzzzzzzm_ = context.Operators.DateFrom(uzzzzzzzzzzzzzl_);
            CqlDateTime uzzzzzzzzzzzzzo_ = context.Operators.End(uzzzzzzzzzzzzzk_);
            CqlDate uzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzq_ = context.Operators.Interval(uzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzp_, true, true);
            CqlDateTime uzzzzzzzzzzzzzr_ = context.Operators.Start(Period);
            CqlDate uzzzzzzzzzzzzzs_ = context.Operators.DateFrom(uzzzzzzzzzzzzzr_);
            CqlDateTime uzzzzzzzzzzzzzt_ = context.Operators.End(Period);
            CqlDate uzzzzzzzzzzzzzu_ = context.Operators.DateFrom(uzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzv_ = context.Operators.Interval(uzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzu_, true, true);
            bool? uzzzzzzzzzzzzzw_ = context.Operators.Overlaps(uzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzv_, default);

            return uzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzm_, szzzzzzzzzzzzzn_);
        bool? szzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzq_ = context.Operators.Or(szzzzzzzzzzzzzi_, szzzzzzzzzzzzzp_);

        return szzzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
