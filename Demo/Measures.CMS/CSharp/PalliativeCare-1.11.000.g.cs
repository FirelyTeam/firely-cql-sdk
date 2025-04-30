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
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object qzzzzzzzzzzzs_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzt_);

        return qzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzv_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzv_);
        IEnumerable<Observation> qzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzzzx_);
        bool? qzzzzzzzzzzzz_(Observation PalliativeAssessment)
        {
            DataType rzzzzzzzzzzzw_ = PalliativeAssessment?.Effective;
            object rzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzza_ = context.Operators.Overlaps(rzzzzzzzzzzzy_, rzzzzzzzzzzzz_, "day");

            return szzzzzzzzzzza_;
        };
        IEnumerable<Observation> rzzzzzzzzzzza_ = context.Operators.Where<Observation>(qzzzzzzzzzzzy_, qzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(rzzzzzzzzzzza_);
        CqlValueSet rzzzzzzzzzzzc_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> rzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzze_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> szzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzd_ = context.Operators.Overlaps(szzzzzzzzzzzb_, szzzzzzzzzzzc_, "day");

            return szzzzzzzzzzzd_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzf_ = context.Operators.Where<Condition>(rzzzzzzzzzzzd_, rzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzh_ = context.Operators.Or(rzzzzzzzzzzzb_, rzzzzzzzzzzzg_);
        CqlValueSet rzzzzzzzzzzzi_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzk_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzj_);
        bool? rzzzzzzzzzzzl_(Encounter PalliativeEncounter)
        {
            Period szzzzzzzzzzze_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzze_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzf_ as object);
            CqlInterval<CqlDateTime> szzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzi_ = context.Operators.Overlaps(szzzzzzzzzzzg_, szzzzzzzzzzzh_, "day");

            return szzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzk_, rzzzzzzzzzzzl_);
        bool? rzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzo_ = context.Operators.Or(rzzzzzzzzzzzh_, rzzzzzzzzzzzn_);
        CqlValueSet rzzzzzzzzzzzp_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> rzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzr_ = Status_1_8_000.Instance.isInterventionPerformed(context, rzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzs_(Procedure PalliativeIntervention)
        {
            DataType szzzzzzzzzzzj_ = PalliativeIntervention?.Performed;
            object szzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzn_ = context.Operators.Overlaps(szzzzzzzzzzzl_, szzzzzzzzzzzm_, "day");

            return szzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzr_, rzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(rzzzzzzzzzzzt_);
        bool? rzzzzzzzzzzzv_ = context.Operators.Or(rzzzzzzzzzzzo_, rzzzzzzzzzzzu_);

        return rzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
