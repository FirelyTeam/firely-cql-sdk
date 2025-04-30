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
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Encounter_for_palliative_care);

    #endregion CodeSystems

    #region Expressions

    [CqlExpressionDefinition("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet zzzzzzzzzzzzzza_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> zzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzzzzzc_(Observation PalliativeAssessment)
        {
            DataType azzzzzzzzzzzzzzb_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzb_);
            CqlDateTime azzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzc_);
            CqlDate azzzzzzzzzzzzzze_ = context.Operators.DateFrom(azzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzb_);
            CqlDateTime azzzzzzzzzzzzzzh_ = context.Operators.End(azzzzzzzzzzzzzzg_);
            CqlDate azzzzzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzj_ = context.Operators.Interval(azzzzzzzzzzzzzze_, azzzzzzzzzzzzzzi_, true, true);
            CqlDateTime azzzzzzzzzzzzzzk_ = context.Operators.Start(Period);
            CqlDate azzzzzzzzzzzzzzl_ = context.Operators.DateFrom(azzzzzzzzzzzzzzk_);
            CqlDateTime azzzzzzzzzzzzzzm_ = context.Operators.End(Period);
            CqlDate azzzzzzzzzzzzzzn_ = context.Operators.DateFrom(azzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzo_ = context.Operators.Interval(azzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzn_, true, true);
            bool? azzzzzzzzzzzzzzp_ = context.Operators.Overlaps(azzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzo_, default);

            return azzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzze_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzd_);
        CqlValueSet zzzzzzzzzzzzzzf_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzh_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, zzzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzzi_(Encounter PalliativeEncounter)
        {
            Period azzzzzzzzzzzzzzq_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzq_ as object);
            CqlDateTime azzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzr_);
            CqlDate azzzzzzzzzzzzzzt_ = context.Operators.DateFrom(azzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzq_ as object);
            CqlDateTime azzzzzzzzzzzzzzw_ = context.Operators.End(azzzzzzzzzzzzzzv_);
            CqlDate azzzzzzzzzzzzzzx_ = context.Operators.DateFrom(azzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzy_ = context.Operators.Interval(azzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzx_, true, true);
            CqlDateTime azzzzzzzzzzzzzzz_ = context.Operators.Start(Period);
            CqlDate bzzzzzzzzzzzzzza_ = context.Operators.DateFrom(azzzzzzzzzzzzzzz_);
            CqlDateTime bzzzzzzzzzzzzzzb_ = context.Operators.End(Period);
            CqlDate bzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzc_, true, true);
            bool? bzzzzzzzzzzzzzze_ = context.Operators.Overlaps(azzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzd_, default);

            return bzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzi_);
        bool? zzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzl_ = context.Operators.Or(zzzzzzzzzzzzzze_, zzzzzzzzzzzzzzk_);
        CqlValueSet zzzzzzzzzzzzzzm_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzo_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, zzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzp_(Procedure PalliativeIntervention)
        {
            DataType bzzzzzzzzzzzzzzf_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzf_);
            CqlDateTime bzzzzzzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzzzzzzg_);
            CqlDate bzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzzzzzzzf_);
            CqlDateTime bzzzzzzzzzzzzzzl_ = context.Operators.End(bzzzzzzzzzzzzzzk_);
            CqlDate bzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzn_ = context.Operators.Interval(bzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzm_, true, true);
            CqlDateTime bzzzzzzzzzzzzzzo_ = context.Operators.Start(Period);
            CqlDate bzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzo_);
            CqlDateTime bzzzzzzzzzzzzzzq_ = context.Operators.End(Period);
            CqlDate bzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzs_ = context.Operators.Interval(bzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzr_, true, true);
            bool? bzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(bzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzs_, default);

            return bzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzr_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzq_);
        bool? zzzzzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzr_);
        CqlCode zzzzzzzzzzzzzzt_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzt_);
        IEnumerable<Condition> zzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzu_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzw_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, zzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzx_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
            CqlDateTime bzzzzzzzzzzzzzzv_ = context.Operators.Start(bzzzzzzzzzzzzzzu_);
            CqlDate bzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzv_);
            CqlDateTime bzzzzzzzzzzzzzzy_ = context.Operators.End(bzzzzzzzzzzzzzzu_);
            CqlDate bzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzza_ = context.Operators.Interval(bzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzz_, true, true);
            CqlDateTime czzzzzzzzzzzzzzb_ = context.Operators.Start(Period);
            CqlDate czzzzzzzzzzzzzzc_ = context.Operators.DateFrom(czzzzzzzzzzzzzzb_);
            CqlDateTime czzzzzzzzzzzzzzd_ = context.Operators.End(Period);
            CqlDate czzzzzzzzzzzzzze_ = context.Operators.DateFrom(czzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzzzzc_, czzzzzzzzzzzzzze_, true, true);
            bool? czzzzzzzzzzzzzzg_ = context.Operators.Overlaps(czzzzzzzzzzzzzza_, czzzzzzzzzzzzzzf_, default);

            return czzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzza_ = context.Operators.Or(zzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzz_);

        return azzzzzzzzzzzzzza_;
    }


    #endregion Expressions

}
