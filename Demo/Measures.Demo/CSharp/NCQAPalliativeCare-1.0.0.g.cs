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

    #region ValueSet: Palliative Care Assessment
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Assessment",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Assessment(CqlContext context) => _Palliative_Care_Assessment;

    private static readonly CqlValueSet _Palliative_Care_Assessment = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);
    #endregion

    #region ValueSet: Palliative Care Encounter
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Encounter",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) => _Palliative_Care_Encounter;

    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);
    #endregion

    #region ValueSet: Palliative Care Intervention
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Intervention",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) => _Palliative_Care_Intervention;

    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Encounter for palliative care
    [CqlCodeDefinition(
        definitionName: "Encounter for palliative care",
        codeId: "Z51.5",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext context) => _Encounter_for_palliative_care;

    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "ICD-10")]
    public CqlCode[] ICD_10(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzq_ = [
            new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return kzzzzzzzzzq_;
    }


    #endregion CodeSystems

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet kzzzzzzzzzr_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> kzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzzzzzt_(Observation PalliativeAssessment)
        {
            DataType lzzzzzzzzzs_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> lzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzt_);
            CqlDate lzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzy_ = context.Operators.End(lzzzzzzzzzx_);
            CqlDate lzzzzzzzzzz_ = context.Operators.DateFrom(lzzzzzzzzzy_);
            CqlInterval<CqlDate> mzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzv_, lzzzzzzzzzz_, true, true);
            CqlDateTime mzzzzzzzzzb_ = context.Operators.Start(Period);
            CqlDate mzzzzzzzzzc_ = context.Operators.DateFrom(mzzzzzzzzzb_);
            CqlDateTime mzzzzzzzzzd_ = context.Operators.End(Period);
            CqlDate mzzzzzzzzze_ = context.Operators.DateFrom(mzzzzzzzzzd_);
            CqlInterval<CqlDate> mzzzzzzzzzf_ = context.Operators.Interval(mzzzzzzzzzc_, mzzzzzzzzze_, true, true);
            bool? mzzzzzzzzzg_ = context.Operators.Overlaps(mzzzzzzzzza_, mzzzzzzzzzf_, default);

            return mzzzzzzzzzg_;
        };
        IEnumerable<Observation> kzzzzzzzzzu_ = context.Operators.Where<Observation>(kzzzzzzzzzs_, kzzzzzzzzzt_);
        bool? kzzzzzzzzzv_ = context.Operators.Exists<Observation>(kzzzzzzzzzu_);
        CqlValueSet kzzzzzzzzzw_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> kzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> kzzzzzzzzzy_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, kzzzzzzzzzx_);
        bool? kzzzzzzzzzz_(Encounter PalliativeEncounter)
        {
            Period mzzzzzzzzzh_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzzzzh_ as object);
            CqlDateTime mzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzi_);
            CqlDate mzzzzzzzzzk_ = context.Operators.DateFrom(mzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzzzzh_ as object);
            CqlDateTime mzzzzzzzzzn_ = context.Operators.End(mzzzzzzzzzm_);
            CqlDate mzzzzzzzzzo_ = context.Operators.DateFrom(mzzzzzzzzzn_);
            CqlInterval<CqlDate> mzzzzzzzzzp_ = context.Operators.Interval(mzzzzzzzzzk_, mzzzzzzzzzo_, true, true);
            CqlDateTime mzzzzzzzzzq_ = context.Operators.Start(Period);
            CqlDate mzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzq_);
            CqlDateTime mzzzzzzzzzs_ = context.Operators.End(Period);
            CqlDate mzzzzzzzzzt_ = context.Operators.DateFrom(mzzzzzzzzzs_);
            CqlInterval<CqlDate> mzzzzzzzzzu_ = context.Operators.Interval(mzzzzzzzzzr_, mzzzzzzzzzt_, true, true);
            bool? mzzzzzzzzzv_ = context.Operators.Overlaps(mzzzzzzzzzp_, mzzzzzzzzzu_, default);

            return mzzzzzzzzzv_;
        };
        IEnumerable<Encounter> lzzzzzzzzza_ = context.Operators.Where<Encounter>(kzzzzzzzzzy_, kzzzzzzzzzz_);
        bool? lzzzzzzzzzb_ = context.Operators.Exists<Encounter>(lzzzzzzzzza_);
        bool? lzzzzzzzzzc_ = context.Operators.Or(kzzzzzzzzzv_, lzzzzzzzzzb_);
        CqlValueSet lzzzzzzzzzd_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> lzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> lzzzzzzzzzf_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, lzzzzzzzzze_);
        bool? lzzzzzzzzzg_(Procedure PalliativeIntervention)
        {
            DataType mzzzzzzzzzw_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzzzzw_);
            CqlDateTime mzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzx_);
            CqlDate mzzzzzzzzzz_ = context.Operators.DateFrom(mzzzzzzzzzy_);
            CqlInterval<CqlDateTime> nzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzzzzw_);
            CqlDateTime nzzzzzzzzzc_ = context.Operators.End(nzzzzzzzzzb_);
            CqlDate nzzzzzzzzzd_ = context.Operators.DateFrom(nzzzzzzzzzc_);
            CqlInterval<CqlDate> nzzzzzzzzze_ = context.Operators.Interval(mzzzzzzzzzz_, nzzzzzzzzzd_, true, true);
            CqlDateTime nzzzzzzzzzf_ = context.Operators.Start(Period);
            CqlDate nzzzzzzzzzg_ = context.Operators.DateFrom(nzzzzzzzzzf_);
            CqlDateTime nzzzzzzzzzh_ = context.Operators.End(Period);
            CqlDate nzzzzzzzzzi_ = context.Operators.DateFrom(nzzzzzzzzzh_);
            CqlInterval<CqlDate> nzzzzzzzzzj_ = context.Operators.Interval(nzzzzzzzzzg_, nzzzzzzzzzi_, true, true);
            bool? nzzzzzzzzzk_ = context.Operators.Overlaps(nzzzzzzzzze_, nzzzzzzzzzj_, default);

            return nzzzzzzzzzk_;
        };
        IEnumerable<Procedure> lzzzzzzzzzh_ = context.Operators.Where<Procedure>(lzzzzzzzzzf_, lzzzzzzzzzg_);
        bool? lzzzzzzzzzi_ = context.Operators.Exists<Procedure>(lzzzzzzzzzh_);
        bool? lzzzzzzzzzj_ = context.Operators.Or(lzzzzzzzzzc_, lzzzzzzzzzi_);
        CqlCode lzzzzzzzzzk_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> lzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzk_);
        IEnumerable<Condition> lzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, lzzzzzzzzzl_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> lzzzzzzzzzn_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, lzzzzzzzzzm_);
        bool? lzzzzzzzzzo_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime nzzzzzzzzzm_ = context.Operators.Start(nzzzzzzzzzl_);
            CqlDate nzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzm_);
            CqlDateTime nzzzzzzzzzp_ = context.Operators.End(nzzzzzzzzzl_);
            CqlDate nzzzzzzzzzq_ = context.Operators.DateFrom(nzzzzzzzzzp_);
            CqlInterval<CqlDate> nzzzzzzzzzr_ = context.Operators.Interval(nzzzzzzzzzn_, nzzzzzzzzzq_, true, true);
            CqlDateTime nzzzzzzzzzs_ = context.Operators.Start(Period);
            CqlDate nzzzzzzzzzt_ = context.Operators.DateFrom(nzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzu_ = context.Operators.End(Period);
            CqlDate nzzzzzzzzzv_ = context.Operators.DateFrom(nzzzzzzzzzu_);
            CqlInterval<CqlDate> nzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzt_, nzzzzzzzzzv_, true, true);
            bool? nzzzzzzzzzx_ = context.Operators.Overlaps(nzzzzzzzzzr_, nzzzzzzzzzw_, default);

            return nzzzzzzzzzx_;
        };
        IEnumerable<Condition> lzzzzzzzzzp_ = context.Operators.Where<Condition>(lzzzzzzzzzn_, lzzzzzzzzzo_);
        bool? lzzzzzzzzzq_ = context.Operators.Exists<Condition>(lzzzzzzzzzp_);
        bool? lzzzzzzzzzr_ = context.Operators.Or(lzzzzzzzzzj_, lzzzzzzzzzq_);

        return lzzzzzzzzzr_;
    }


    #endregion Expressions

}
