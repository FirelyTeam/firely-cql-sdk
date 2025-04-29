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
        object czzzn_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)czzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzp_ = context.Operators.SingletonFrom<Patient>(czzzo_);

        return czzzp_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode czzzq_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> czzzr_ = context.Operators.ToList<CqlCode>(czzzq_);
        IEnumerable<Observation> czzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzs_);
        bool? czzzu_(Observation PalliativeAssessment)
        {
            DataType dzzzr_ = PalliativeAssessment?.Effective;
            object dzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzr_);
            CqlInterval<CqlDateTime> dzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzs_);
            CqlInterval<CqlDateTime> dzzzu_ = this.Measurement_Period(context);
            bool? dzzzv_ = context.Operators.Overlaps(dzzzt_, dzzzu_, "day");

            return dzzzv_;
        };
        IEnumerable<Observation> czzzv_ = context.Operators.Where<Observation>(czzzt_, czzzu_);
        bool? czzzw_ = context.Operators.Exists<Observation>(czzzv_);
        CqlValueSet czzzx_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> czzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzz_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> dzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> dzzzx_ = this.Measurement_Period(context);
            bool? dzzzy_ = context.Operators.Overlaps(dzzzw_, dzzzx_, "day");

            return dzzzy_;
        };
        IEnumerable<Condition> dzzza_ = context.Operators.Where<Condition>(czzzy_, czzzz_);
        bool? dzzzb_ = context.Operators.Exists<Condition>(dzzza_);
        bool? dzzzc_ = context.Operators.Or(czzzw_, dzzzb_);
        CqlValueSet dzzzd_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> dzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzf_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzze_);
        bool? dzzzg_(Encounter PalliativeEncounter)
        {
            Period dzzzz_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ezzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzz_);
            CqlInterval<CqlDateTime> ezzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzza_ as object);
            CqlInterval<CqlDateTime> ezzzc_ = this.Measurement_Period(context);
            bool? ezzzd_ = context.Operators.Overlaps(ezzzb_, ezzzc_, "day");

            return ezzzd_;
        };
        IEnumerable<Encounter> dzzzh_ = context.Operators.Where<Encounter>(dzzzf_, dzzzg_);
        bool? dzzzi_ = context.Operators.Exists<Encounter>(dzzzh_);
        bool? dzzzj_ = context.Operators.Or(dzzzc_, dzzzi_);
        CqlValueSet dzzzk_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> dzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzm_ = Status_1_8_000.Instance.isInterventionPerformed(context, dzzzl_);
        bool? dzzzn_(Procedure PalliativeIntervention)
        {
            DataType ezzze_ = PalliativeIntervention?.Performed;
            object ezzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzze_);
            CqlInterval<CqlDateTime> ezzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzf_);
            CqlInterval<CqlDateTime> ezzzh_ = this.Measurement_Period(context);
            bool? ezzzi_ = context.Operators.Overlaps(ezzzg_, ezzzh_, "day");

            return ezzzi_;
        };
        IEnumerable<Procedure> dzzzo_ = context.Operators.Where<Procedure>(dzzzm_, dzzzn_);
        bool? dzzzp_ = context.Operators.Exists<Procedure>(dzzzo_);
        bool? dzzzq_ = context.Operators.Or(dzzzj_, dzzzp_);

        return dzzzq_;
    }


    #endregion Expressions

}
