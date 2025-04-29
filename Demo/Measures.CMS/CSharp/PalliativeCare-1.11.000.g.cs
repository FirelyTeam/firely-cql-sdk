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
        object xzzzzzj_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)xzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzl_ = context.Operators.SingletonFrom<Patient>(xzzzzzk_);

        return xzzzzzl_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode xzzzzzm_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> xzzzzzn_ = context.Operators.ToList<CqlCode>(xzzzzzm_);
        IEnumerable<Observation> xzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, xzzzzzo_);
        bool? xzzzzzq_(Observation PalliativeAssessment)
        {
            DataType yzzzzzn_ = PalliativeAssessment?.Effective;
            object yzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzo_);
            CqlInterval<CqlDateTime> yzzzzzq_ = this.Measurement_Period(context);
            bool? yzzzzzr_ = context.Operators.Overlaps(yzzzzzp_, yzzzzzq_, "day");

            return yzzzzzr_;
        };
        IEnumerable<Observation> xzzzzzr_ = context.Operators.Where<Observation>(xzzzzzp_, xzzzzzq_);
        bool? xzzzzzs_ = context.Operators.Exists<Observation>(xzzzzzr_);
        CqlValueSet xzzzzzt_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> xzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzv_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> yzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> yzzzzzt_ = this.Measurement_Period(context);
            bool? yzzzzzu_ = context.Operators.Overlaps(yzzzzzs_, yzzzzzt_, "day");

            return yzzzzzu_;
        };
        IEnumerable<Condition> xzzzzzw_ = context.Operators.Where<Condition>(xzzzzzu_, xzzzzzv_);
        bool? xzzzzzx_ = context.Operators.Exists<Condition>(xzzzzzw_);
        bool? xzzzzzy_ = context.Operators.Or(xzzzzzs_, xzzzzzx_);
        CqlValueSet xzzzzzz_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> yzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzb_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzza_);
        bool? yzzzzzc_(Encounter PalliativeEncounter)
        {
            Period yzzzzzv_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzw_ as object);
            CqlInterval<CqlDateTime> yzzzzzy_ = this.Measurement_Period(context);
            bool? yzzzzzz_ = context.Operators.Overlaps(yzzzzzx_, yzzzzzy_, "day");

            return yzzzzzz_;
        };
        IEnumerable<Encounter> yzzzzzd_ = context.Operators.Where<Encounter>(yzzzzzb_, yzzzzzc_);
        bool? yzzzzze_ = context.Operators.Exists<Encounter>(yzzzzzd_);
        bool? yzzzzzf_ = context.Operators.Or(xzzzzzy_, yzzzzze_);
        CqlValueSet yzzzzzg_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> yzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzi_ = Status_1_8_000.Instance.isInterventionPerformed(context, yzzzzzh_);
        bool? yzzzzzj_(Procedure PalliativeIntervention)
        {
            DataType zzzzzza_ = PalliativeIntervention?.Performed;
            object zzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzb_);
            CqlInterval<CqlDateTime> zzzzzzd_ = this.Measurement_Period(context);
            bool? zzzzzze_ = context.Operators.Overlaps(zzzzzzc_, zzzzzzd_, "day");

            return zzzzzze_;
        };
        IEnumerable<Procedure> yzzzzzk_ = context.Operators.Where<Procedure>(yzzzzzi_, yzzzzzj_);
        bool? yzzzzzl_ = context.Operators.Exists<Procedure>(yzzzzzk_);
        bool? yzzzzzm_ = context.Operators.Or(yzzzzzf_, yzzzzzl_);

        return yzzzzzm_;
    }


    #endregion Expressions

}
