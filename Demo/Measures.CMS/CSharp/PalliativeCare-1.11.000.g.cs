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

    #region ValueSet: Palliative Care Encounter
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext context) => _Palliative_Care_Encounter;

    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);
    #endregion

    #region ValueSet: Palliative Care Intervention
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext context) => _Palliative_Care_Intervention;

    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);
    #endregion

    #region ValueSet: Palliative Care Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Palliative Care Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167",
        valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext context) => _Palliative_Care_Diagnosis;

    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)
    [CqlCodeDefinition(
        definitionName: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)",
        codeId: "71007-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext context) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;

    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] gzzzzzzzzzq_ = [
            new CqlCode("71007-9", "http://loinc.org", default, default),
        ];

        return gzzzzzzzzzq_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object gzzzzzzzzzr_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient gzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzs_);

        return gzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode gzzzzzzzzzu_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> gzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzu_);
        IEnumerable<Observation> gzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzw_);
        bool? gzzzzzzzzzy_(Observation PalliativeAssessment)
        {
            DataType hzzzzzzzzzv_ = PalliativeAssessment?.Effective;
            object hzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzw_);
            CqlInterval<CqlDateTime> hzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzz_ = context.Operators.Overlaps(hzzzzzzzzzx_, hzzzzzzzzzy_, "day");

            return hzzzzzzzzzz_;
        };
        IEnumerable<Observation> gzzzzzzzzzz_ = context.Operators.Where<Observation>(gzzzzzzzzzx_, gzzzzzzzzzy_);
        bool? hzzzzzzzzza_ = context.Operators.Exists<Observation>(gzzzzzzzzzz_);
        CqlValueSet hzzzzzzzzzb_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> hzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzd_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> izzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> izzzzzzzzzb_ = this.Measurement_Period(context);
            bool? izzzzzzzzzc_ = context.Operators.Overlaps(izzzzzzzzza_, izzzzzzzzzb_, "day");

            return izzzzzzzzzc_;
        };
        IEnumerable<Condition> hzzzzzzzzze_ = context.Operators.Where<Condition>(hzzzzzzzzzc_, hzzzzzzzzzd_);
        bool? hzzzzzzzzzf_ = context.Operators.Exists<Condition>(hzzzzzzzzze_);
        bool? hzzzzzzzzzg_ = context.Operators.Or(hzzzzzzzzza_, hzzzzzzzzzf_);
        CqlValueSet hzzzzzzzzzh_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzj_ = Status_1_8_000.Instance.isEncounterPerformed(context, hzzzzzzzzzi_);
        bool? hzzzzzzzzzk_(Encounter PalliativeEncounter)
        {
            Period izzzzzzzzzd_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzd_);
            CqlInterval<CqlDateTime> izzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzze_ as object);
            CqlInterval<CqlDateTime> izzzzzzzzzg_ = this.Measurement_Period(context);
            bool? izzzzzzzzzh_ = context.Operators.Overlaps(izzzzzzzzzf_, izzzzzzzzzg_, "day");

            return izzzzzzzzzh_;
        };
        IEnumerable<Encounter> hzzzzzzzzzl_ = context.Operators.Where<Encounter>(hzzzzzzzzzj_, hzzzzzzzzzk_);
        bool? hzzzzzzzzzm_ = context.Operators.Exists<Encounter>(hzzzzzzzzzl_);
        bool? hzzzzzzzzzn_ = context.Operators.Or(hzzzzzzzzzg_, hzzzzzzzzzm_);
        CqlValueSet hzzzzzzzzzo_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> hzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzq_ = Status_1_8_000.Instance.isInterventionPerformed(context, hzzzzzzzzzp_);
        bool? hzzzzzzzzzr_(Procedure PalliativeIntervention)
        {
            DataType izzzzzzzzzi_ = PalliativeIntervention?.Performed;
            object izzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzi_);
            CqlInterval<CqlDateTime> izzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzj_);
            CqlInterval<CqlDateTime> izzzzzzzzzl_ = this.Measurement_Period(context);
            bool? izzzzzzzzzm_ = context.Operators.Overlaps(izzzzzzzzzk_, izzzzzzzzzl_, "day");

            return izzzzzzzzzm_;
        };
        IEnumerable<Procedure> hzzzzzzzzzs_ = context.Operators.Where<Procedure>(hzzzzzzzzzq_, hzzzzzzzzzr_);
        bool? hzzzzzzzzzt_ = context.Operators.Exists<Procedure>(hzzzzzzzzzs_);
        bool? hzzzzzzzzzu_ = context.Operators.Or(hzzzzzzzzzn_, hzzzzzzzzzt_);

        return hzzzzzzzzzu_;
    }


    #endregion Expressions

}
