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
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object dzzzzzzzzzc_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzd_);

        return dzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode dzzzzzzzzzf_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> dzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzf_);
        IEnumerable<Observation> dzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzh_);
        bool? dzzzzzzzzzj_(Observation PalliativeAssessment)
        {
            DataType ezzzzzzzzzg_ = PalliativeAssessment?.Effective;
            object ezzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzh_);
            CqlInterval<CqlDateTime> ezzzzzzzzzj_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzk_ = context.Operators.Overlaps(ezzzzzzzzzi_, ezzzzzzzzzj_, "day");

            return ezzzzzzzzzk_;
        };
        IEnumerable<Observation> dzzzzzzzzzk_ = context.Operators.Where<Observation>(dzzzzzzzzzi_, dzzzzzzzzzj_);
        bool? dzzzzzzzzzl_ = context.Operators.Exists<Observation>(dzzzzzzzzzk_);
        CqlValueSet dzzzzzzzzzm_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> dzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzo_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> ezzzzzzzzzm_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzn_ = context.Operators.Overlaps(ezzzzzzzzzl_, ezzzzzzzzzm_, "day");

            return ezzzzzzzzzn_;
        };
        IEnumerable<Condition> dzzzzzzzzzp_ = context.Operators.Where<Condition>(dzzzzzzzzzn_, dzzzzzzzzzo_);
        bool? dzzzzzzzzzq_ = context.Operators.Exists<Condition>(dzzzzzzzzzp_);
        bool? dzzzzzzzzzr_ = context.Operators.Or(dzzzzzzzzzl_, dzzzzzzzzzq_);
        CqlValueSet dzzzzzzzzzs_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzu_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzt_);
        bool? dzzzzzzzzzv_(Encounter PalliativeEncounter)
        {
            Period ezzzzzzzzzo_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzo_);
            CqlInterval<CqlDateTime> ezzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzp_ as object);
            CqlInterval<CqlDateTime> ezzzzzzzzzr_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzs_ = context.Operators.Overlaps(ezzzzzzzzzq_, ezzzzzzzzzr_, "day");

            return ezzzzzzzzzs_;
        };
        IEnumerable<Encounter> dzzzzzzzzzw_ = context.Operators.Where<Encounter>(dzzzzzzzzzu_, dzzzzzzzzzv_);
        bool? dzzzzzzzzzx_ = context.Operators.Exists<Encounter>(dzzzzzzzzzw_);
        bool? dzzzzzzzzzy_ = context.Operators.Or(dzzzzzzzzzr_, dzzzzzzzzzx_);
        CqlValueSet dzzzzzzzzzz_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> ezzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzb_ = Status_1_8_000.Instance.isInterventionPerformed(context, ezzzzzzzzza_);
        bool? ezzzzzzzzzc_(Procedure PalliativeIntervention)
        {
            DataType ezzzzzzzzzt_ = PalliativeIntervention?.Performed;
            object ezzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzt_);
            CqlInterval<CqlDateTime> ezzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzu_);
            CqlInterval<CqlDateTime> ezzzzzzzzzw_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzx_ = context.Operators.Overlaps(ezzzzzzzzzv_, ezzzzzzzzzw_, "day");

            return ezzzzzzzzzx_;
        };
        IEnumerable<Procedure> ezzzzzzzzzd_ = context.Operators.Where<Procedure>(ezzzzzzzzzb_, ezzzzzzzzzc_);
        bool? ezzzzzzzzze_ = context.Operators.Exists<Procedure>(ezzzzzzzzzd_);
        bool? ezzzzzzzzzf_ = context.Operators.Or(dzzzzzzzzzy_, ezzzzzzzzze_);

        return ezzzzzzzzzf_;
    }


    #endregion Expressions

}
