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
[CqlLibrary("PalliativeCareFHIR", "0.6.000")]
public partial class PalliativeCareFHIR_0_6_000 : ILibrary, ISingleton<PalliativeCareFHIR_0_6_000>
{
    private PalliativeCareFHIR_0_6_000() {}

    public static PalliativeCareFHIR_0_6_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PalliativeCareFHIR";
    public string Version => "0.6.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object dzzzza_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)dzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient dzzzzc_ = context.Operators.SingletonFrom<Patient>(dzzzzb_);

        return dzzzzc_;
    }


    [CqlExpressionDefinition("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode dzzzzd_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> dzzzze_ = context.Operators.ToList<CqlCode>(dzzzzd_);
        IEnumerable<Observation> dzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzze_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzzg_(Observation PalliativeAssessment)
        {
            Code<ObservationStatus> dzzzzv_ = PalliativeAssessment?.StatusElement;
            string dzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzv_);
            string[] dzzzzx_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzy_ = context.Operators.In<string>(dzzzzw_, dzzzzx_ as IEnumerable<string>);
            List<CodeableConcept> dzzzzz_ = PalliativeAssessment?.Category;
            bool? ezzzza_(CodeableConcept PalliativeAssessmentCategory)
            {
                CqlCode ezzzzj_ = this.survey(context);
                CqlConcept ezzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                CqlCode[] ezzzzl_ = ezzzzk_?.codes;
                bool? ezzzzm_ = context.Operators.In<CqlCode>(ezzzzj_, (IEnumerable<CqlCode>)ezzzzl_);

                return ezzzzm_;
            };
            IEnumerable<CodeableConcept> ezzzzb_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)dzzzzz_, ezzzza_);
            bool? ezzzzc_ = context.Operators.Exists<CodeableConcept>(ezzzzb_);
            bool? ezzzzd_ = context.Operators.And(dzzzzy_, ezzzzc_);
            DataType ezzzze_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> ezzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzze_);
            CqlInterval<CqlDateTime> ezzzzg_ = this.Measurement_Period(context);
            bool? ezzzzh_ = context.Operators.Overlaps(ezzzzf_, ezzzzg_, default);
            bool? ezzzzi_ = context.Operators.And(ezzzzd_, ezzzzh_);

            return ezzzzi_;
        };
        IEnumerable<Observation> dzzzzh_ = context.Operators.Where<Observation>(dzzzzf_, dzzzzg_);
        bool? dzzzzi_ = context.Operators.Exists<Observation>(dzzzzh_);
        CqlValueSet dzzzzj_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> dzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? dzzzzl_(Encounter PalliativeEncounter)
        {
            Code<Encounter.EncounterStatus> ezzzzn_ = PalliativeEncounter?.StatusElement;
            string ezzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzn_);
            bool? ezzzzp_ = context.Operators.Equal(ezzzzo_, "finished");
            Period ezzzzq_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzq_ as object);
            CqlInterval<CqlDateTime> ezzzzs_ = this.Measurement_Period(context);
            bool? ezzzzt_ = context.Operators.Overlaps(ezzzzr_, ezzzzs_, default);
            bool? ezzzzu_ = context.Operators.And(ezzzzp_, ezzzzt_);

            return ezzzzu_;
        };
        IEnumerable<Encounter> dzzzzm_ = context.Operators.Where<Encounter>(dzzzzk_, dzzzzl_);
        bool? dzzzzn_ = context.Operators.Exists<Encounter>(dzzzzm_);
        bool? dzzzzo_ = context.Operators.Or(dzzzzi_, dzzzzn_);
        CqlValueSet dzzzzp_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> dzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzr_(Procedure PalliativeIntervention)
        {
            Code<EventStatus> ezzzzv_ = PalliativeIntervention?.StatusElement;
            string ezzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzv_);
            string[] ezzzzx_ = [
                "completed",
                "in-progress",
            ];
            bool? ezzzzy_ = context.Operators.In<string>(ezzzzw_, ezzzzx_ as IEnumerable<string>);
            DataType ezzzzz_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> fzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzz_);
            CqlInterval<CqlDateTime> fzzzzb_ = this.Measurement_Period(context);
            bool? fzzzzc_ = context.Operators.Overlaps(fzzzza_, fzzzzb_, default);
            bool? fzzzzd_ = context.Operators.And(ezzzzy_, fzzzzc_);

            return fzzzzd_;
        };
        IEnumerable<Procedure> dzzzzs_ = context.Operators.Where<Procedure>(dzzzzq_, dzzzzr_);
        bool? dzzzzt_ = context.Operators.Exists<Procedure>(dzzzzs_);
        bool? dzzzzu_ = context.Operators.Or(dzzzzo_, dzzzzt_);

        return dzzzzu_;
    }


    #endregion Expressions

}
