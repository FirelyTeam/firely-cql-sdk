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
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD-10")]
    public CqlCodeSystem ICD_10(CqlContext _) => _ICD_10;
    private static readonly CqlCodeSystem _ICD_10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet vzzzzzzzzzzzzzn_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzzzzzzzzp_(Observation PalliativeAssessment)
        {
            DataType wzzzzzzzzzzzzzo_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzo_);
            CqlDateTime wzzzzzzzzzzzzzq_ = context.Operators.Start(wzzzzzzzzzzzzzp_);
            CqlDate wzzzzzzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzzo_);
            CqlDateTime wzzzzzzzzzzzzzu_ = context.Operators.End(wzzzzzzzzzzzzzt_);
            CqlDate wzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzv_, true, true);
            CqlDateTime wzzzzzzzzzzzzzx_ = context.Operators.Start(Period);
            CqlDate wzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzzz_ = context.Operators.End(Period);
            CqlDate xzzzzzzzzzzzzza_ = context.Operators.DateFrom(wzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzb_ = context.Operators.Interval(wzzzzzzzzzzzzzy_, xzzzzzzzzzzzzza_, true, true);
            bool? xzzzzzzzzzzzzzc_ = context.Operators.Overlaps(wzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzb_, default);

            return xzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzq_);
        CqlValueSet vzzzzzzzzzzzzzs_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzu_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, vzzzzzzzzzzzzzt_);
        bool? vzzzzzzzzzzzzzv_(Encounter PalliativeEncounter)
        {
            Period xzzzzzzzzzzzzzd_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzd_ as object);
            CqlDateTime xzzzzzzzzzzzzzf_ = context.Operators.Start(xzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzd_ as object);
            CqlDateTime xzzzzzzzzzzzzzj_ = context.Operators.End(xzzzzzzzzzzzzzi_);
            CqlDate xzzzzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzl_ = context.Operators.Interval(xzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzk_, true, true);
            CqlDateTime xzzzzzzzzzzzzzm_ = context.Operators.Start(Period);
            CqlDate xzzzzzzzzzzzzzn_ = context.Operators.DateFrom(xzzzzzzzzzzzzzm_);
            CqlDateTime xzzzzzzzzzzzzzo_ = context.Operators.End(Period);
            CqlDate xzzzzzzzzzzzzzp_ = context.Operators.DateFrom(xzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzq_ = context.Operators.Interval(xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzp_, true, true);
            bool? xzzzzzzzzzzzzzr_ = context.Operators.Overlaps(xzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzq_, default);

            return xzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzv_);
        bool? vzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzy_ = context.Operators.Or(vzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzx_);
        CqlValueSet vzzzzzzzzzzzzzz_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzb_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, wzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzc_(Procedure PalliativeIntervention)
        {
            DataType xzzzzzzzzzzzzzs_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzu_ = context.Operators.Start(xzzzzzzzzzzzzzt_);
            CqlDate xzzzzzzzzzzzzzv_ = context.Operators.DateFrom(xzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzzzzx_);
            CqlDate xzzzzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzza_ = context.Operators.Interval(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzz_, true, true);
            CqlDateTime yzzzzzzzzzzzzzb_ = context.Operators.Start(Period);
            CqlDate yzzzzzzzzzzzzzc_ = context.Operators.DateFrom(yzzzzzzzzzzzzzb_);
            CqlDateTime yzzzzzzzzzzzzzd_ = context.Operators.End(Period);
            CqlDate yzzzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzf_ = context.Operators.Interval(yzzzzzzzzzzzzzc_, yzzzzzzzzzzzzze_, true, true);
            bool? yzzzzzzzzzzzzzg_ = context.Operators.Overlaps(yzzzzzzzzzzzzza_, yzzzzzzzzzzzzzf_, default);

            return yzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzzf_ = context.Operators.Or(vzzzzzzzzzzzzzy_, wzzzzzzzzzzzzze_);
        CqlCode wzzzzzzzzzzzzzg_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzg_);
        IEnumerable<Condition> wzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzh_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, wzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzk_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime yzzzzzzzzzzzzzi_ = context.Operators.Start(yzzzzzzzzzzzzzh_);
            CqlDate yzzzzzzzzzzzzzj_ = context.Operators.DateFrom(yzzzzzzzzzzzzzi_);
            CqlDateTime yzzzzzzzzzzzzzl_ = context.Operators.End(yzzzzzzzzzzzzzh_);
            CqlDate yzzzzzzzzzzzzzm_ = context.Operators.DateFrom(yzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzn_ = context.Operators.Interval(yzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzm_, true, true);
            CqlDateTime yzzzzzzzzzzzzzo_ = context.Operators.Start(Period);
            CqlDate yzzzzzzzzzzzzzp_ = context.Operators.DateFrom(yzzzzzzzzzzzzzo_);
            CqlDateTime yzzzzzzzzzzzzzq_ = context.Operators.End(Period);
            CqlDate yzzzzzzzzzzzzzr_ = context.Operators.DateFrom(yzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzs_ = context.Operators.Interval(yzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzr_, true, true);
            bool? yzzzzzzzzzzzzzt_ = context.Operators.Overlaps(yzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzs_, default);

            return yzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzn_ = context.Operators.Or(wzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}
