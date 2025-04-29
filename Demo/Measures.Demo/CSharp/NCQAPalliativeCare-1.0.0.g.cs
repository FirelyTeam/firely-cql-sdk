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
        CqlValueSet kzzzzzzc_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> kzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? kzzzzzze_(Observation PalliativeAssessment)
        {
            DataType lzzzzzzd_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> lzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzd_);
            CqlDateTime lzzzzzzf_ = context.Operators.Start(lzzzzzze_);
            CqlDate lzzzzzzg_ = context.Operators.DateFrom(lzzzzzzf_);
            CqlInterval<CqlDateTime> lzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzd_);
            CqlDateTime lzzzzzzj_ = context.Operators.End(lzzzzzzi_);
            CqlDate lzzzzzzk_ = context.Operators.DateFrom(lzzzzzzj_);
            CqlInterval<CqlDate> lzzzzzzl_ = context.Operators.Interval(lzzzzzzg_, lzzzzzzk_, true, true);
            CqlDateTime lzzzzzzm_ = context.Operators.Start(Period);
            CqlDate lzzzzzzn_ = context.Operators.DateFrom(lzzzzzzm_);
            CqlDateTime lzzzzzzo_ = context.Operators.End(Period);
            CqlDate lzzzzzzp_ = context.Operators.DateFrom(lzzzzzzo_);
            CqlInterval<CqlDate> lzzzzzzq_ = context.Operators.Interval(lzzzzzzn_, lzzzzzzp_, true, true);
            bool? lzzzzzzr_ = context.Operators.Overlaps(lzzzzzzl_, lzzzzzzq_, default);

            return lzzzzzzr_;
        };
        IEnumerable<Observation> kzzzzzzf_ = context.Operators.Where<Observation>(kzzzzzzd_, kzzzzzze_);
        bool? kzzzzzzg_ = context.Operators.Exists<Observation>(kzzzzzzf_);
        CqlValueSet kzzzzzzh_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> kzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> kzzzzzzj_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, kzzzzzzi_);
        bool? kzzzzzzk_(Encounter PalliativeEncounter)
        {
            Period lzzzzzzs_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzs_ as object);
            CqlDateTime lzzzzzzu_ = context.Operators.Start(lzzzzzzt_);
            CqlDate lzzzzzzv_ = context.Operators.DateFrom(lzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzs_ as object);
            CqlDateTime lzzzzzzy_ = context.Operators.End(lzzzzzzx_);
            CqlDate lzzzzzzz_ = context.Operators.DateFrom(lzzzzzzy_);
            CqlInterval<CqlDate> mzzzzzza_ = context.Operators.Interval(lzzzzzzv_, lzzzzzzz_, true, true);
            CqlDateTime mzzzzzzb_ = context.Operators.Start(Period);
            CqlDate mzzzzzzc_ = context.Operators.DateFrom(mzzzzzzb_);
            CqlDateTime mzzzzzzd_ = context.Operators.End(Period);
            CqlDate mzzzzzze_ = context.Operators.DateFrom(mzzzzzzd_);
            CqlInterval<CqlDate> mzzzzzzf_ = context.Operators.Interval(mzzzzzzc_, mzzzzzze_, true, true);
            bool? mzzzzzzg_ = context.Operators.Overlaps(mzzzzzza_, mzzzzzzf_, default);

            return mzzzzzzg_;
        };
        IEnumerable<Encounter> kzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzj_, kzzzzzzk_);
        bool? kzzzzzzm_ = context.Operators.Exists<Encounter>(kzzzzzzl_);
        bool? kzzzzzzn_ = context.Operators.Or(kzzzzzzg_, kzzzzzzm_);
        CqlValueSet kzzzzzzo_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> kzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> kzzzzzzq_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, kzzzzzzp_);
        bool? kzzzzzzr_(Procedure PalliativeIntervention)
        {
            DataType mzzzzzzh_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzh_);
            CqlDateTime mzzzzzzj_ = context.Operators.Start(mzzzzzzi_);
            CqlDate mzzzzzzk_ = context.Operators.DateFrom(mzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzh_);
            CqlDateTime mzzzzzzn_ = context.Operators.End(mzzzzzzm_);
            CqlDate mzzzzzzo_ = context.Operators.DateFrom(mzzzzzzn_);
            CqlInterval<CqlDate> mzzzzzzp_ = context.Operators.Interval(mzzzzzzk_, mzzzzzzo_, true, true);
            CqlDateTime mzzzzzzq_ = context.Operators.Start(Period);
            CqlDate mzzzzzzr_ = context.Operators.DateFrom(mzzzzzzq_);
            CqlDateTime mzzzzzzs_ = context.Operators.End(Period);
            CqlDate mzzzzzzt_ = context.Operators.DateFrom(mzzzzzzs_);
            CqlInterval<CqlDate> mzzzzzzu_ = context.Operators.Interval(mzzzzzzr_, mzzzzzzt_, true, true);
            bool? mzzzzzzv_ = context.Operators.Overlaps(mzzzzzzp_, mzzzzzzu_, default);

            return mzzzzzzv_;
        };
        IEnumerable<Procedure> kzzzzzzs_ = context.Operators.Where<Procedure>(kzzzzzzq_, kzzzzzzr_);
        bool? kzzzzzzt_ = context.Operators.Exists<Procedure>(kzzzzzzs_);
        bool? kzzzzzzu_ = context.Operators.Or(kzzzzzzn_, kzzzzzzt_);
        CqlCode kzzzzzzv_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> kzzzzzzw_ = context.Operators.ToList<CqlCode>(kzzzzzzv_);
        IEnumerable<Condition> kzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, kzzzzzzw_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> kzzzzzzy_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, kzzzzzzx_);
        bool? kzzzzzzz_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime mzzzzzzx_ = context.Operators.Start(mzzzzzzw_);
            CqlDate mzzzzzzy_ = context.Operators.DateFrom(mzzzzzzx_);
            CqlDateTime nzzzzzza_ = context.Operators.End(mzzzzzzw_);
            CqlDate nzzzzzzb_ = context.Operators.DateFrom(nzzzzzza_);
            CqlInterval<CqlDate> nzzzzzzc_ = context.Operators.Interval(mzzzzzzy_, nzzzzzzb_, true, true);
            CqlDateTime nzzzzzzd_ = context.Operators.Start(Period);
            CqlDate nzzzzzze_ = context.Operators.DateFrom(nzzzzzzd_);
            CqlDateTime nzzzzzzf_ = context.Operators.End(Period);
            CqlDate nzzzzzzg_ = context.Operators.DateFrom(nzzzzzzf_);
            CqlInterval<CqlDate> nzzzzzzh_ = context.Operators.Interval(nzzzzzze_, nzzzzzzg_, true, true);
            bool? nzzzzzzi_ = context.Operators.Overlaps(nzzzzzzc_, nzzzzzzh_, default);

            return nzzzzzzi_;
        };
        IEnumerable<Condition> lzzzzzza_ = context.Operators.Where<Condition>(kzzzzzzy_, kzzzzzzz_);
        bool? lzzzzzzb_ = context.Operators.Exists<Condition>(lzzzzzza_);
        bool? lzzzzzzc_ = context.Operators.Or(kzzzzzzu_, lzzzzzzb_);

        return lzzzzzzc_;
    }


    #endregion Expressions

}
