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
[CqlLibrary("PalliativeCare", "1.11.000")]
public partial class PalliativeCare_1_11_000 : ILibrary, ISingleton<PalliativeCare_1_11_000>
{
    private PalliativeCare_1_11_000() {}

    public static PalliativeCare_1_11_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PalliativeCare";
    public string Version => "1.11.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzx_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> yzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, yzzzzzzzzzzzzzzzzz_);
        bool? zzzzzzzzzzzzzzzzzb_(Observation PalliativeAssessment)
        {
            DataType zzzzzzzzzzzzzzzzzy_ = PalliativeAssessment?.Effective;
            object zzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzb_, "day");

            return azzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzb_);
        bool? zzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzzzzzzc_);
        CqlValueSet zzzzzzzzzzzzzzzzze_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzzzg_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzze_, "day");

            return azzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzh_);
        bool? zzzzzzzzzzzzzzzzzj_ = context.Operators.Or(zzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzi_);
        CqlValueSet zzzzzzzzzzzzzzzzzk_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzzzzzzzl_);
        bool? zzzzzzzzzzzzzzzzzn_(Encounter PalliativeEncounter)
        {
            Period azzzzzzzzzzzzzzzzzg_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzh_ as object);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzj_, "day");

            return azzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzq_ = context.Operators.Or(zzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzp_);
        CqlValueSet zzzzzzzzzzzzzzzzzr_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isInterventionPerformed(context, zzzzzzzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzzzzzzu_(Procedure PalliativeIntervention)
        {
            DataType azzzzzzzzzzzzzzzzzl_ = PalliativeIntervention?.Performed;
            object azzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzo_, "day");

            return azzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzx_ = context.Operators.Or(zzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
