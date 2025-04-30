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
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null,
          _survey);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ezzzzzk_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ezzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ezzzzzm_ = context.Operators.SingletonFrom<Patient>(ezzzzzl_);

        return ezzzzzm_;
    }


    [CqlExpressionDefinition("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode ezzzzzn_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> ezzzzzo_ = context.Operators.ToList<CqlCode>(ezzzzzn_);
        IEnumerable<Observation> ezzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzo_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzq_(Observation PalliativeAssessment)
        {
            Code<ObservationStatus> fzzzzzf_ = PalliativeAssessment?.StatusElement;
            string fzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzf_);
            string[] fzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzi_ = context.Operators.In<string>(fzzzzzg_, fzzzzzh_ as IEnumerable<string>);
            List<CodeableConcept> fzzzzzj_ = PalliativeAssessment?.Category;
            bool? fzzzzzk_(CodeableConcept PalliativeAssessmentCategory)
            {
                CqlCode fzzzzzt_ = this.survey(context);
                CqlConcept fzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                CqlCode[] fzzzzzv_ = fzzzzzu_?.codes;
                bool? fzzzzzw_ = context.Operators.In<CqlCode>(fzzzzzt_, (IEnumerable<CqlCode>)fzzzzzv_);

                return fzzzzzw_;
            };
            IEnumerable<CodeableConcept> fzzzzzl_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)fzzzzzj_, fzzzzzk_);
            bool? fzzzzzm_ = context.Operators.Exists<CodeableConcept>(fzzzzzl_);
            bool? fzzzzzn_ = context.Operators.And(fzzzzzi_, fzzzzzm_);
            DataType fzzzzzo_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> fzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzq_ = this.Measurement_Period(context);
            bool? fzzzzzr_ = context.Operators.Overlaps(fzzzzzp_, fzzzzzq_, default);
            bool? fzzzzzs_ = context.Operators.And(fzzzzzn_, fzzzzzr_);

            return fzzzzzs_;
        };
        IEnumerable<Observation> ezzzzzr_ = context.Operators.Where<Observation>(ezzzzzp_, ezzzzzq_);
        bool? ezzzzzs_ = context.Operators.Exists<Observation>(ezzzzzr_);
        CqlValueSet ezzzzzt_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> ezzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? ezzzzzv_(Encounter PalliativeEncounter)
        {
            Code<Encounter.EncounterStatus> fzzzzzx_ = PalliativeEncounter?.StatusElement;
            string fzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzx_);
            bool? fzzzzzz_ = context.Operators.Equal(fzzzzzy_, "finished");
            Period gzzzzza_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzza_ as object);
            CqlInterval<CqlDateTime> gzzzzzc_ = this.Measurement_Period(context);
            bool? gzzzzzd_ = context.Operators.Overlaps(gzzzzzb_, gzzzzzc_, default);
            bool? gzzzzze_ = context.Operators.And(fzzzzzz_, gzzzzzd_);

            return gzzzzze_;
        };
        IEnumerable<Encounter> ezzzzzw_ = context.Operators.Where<Encounter>(ezzzzzu_, ezzzzzv_);
        bool? ezzzzzx_ = context.Operators.Exists<Encounter>(ezzzzzw_);
        bool? ezzzzzy_ = context.Operators.Or(ezzzzzs_, ezzzzzx_);
        CqlValueSet ezzzzzz_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> fzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzzzzb_(Procedure PalliativeIntervention)
        {
            Code<EventStatus> gzzzzzf_ = PalliativeIntervention?.StatusElement;
            string gzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzf_);
            string[] gzzzzzh_ = [
                "completed",
                "in-progress",
            ];
            bool? gzzzzzi_ = context.Operators.In<string>(gzzzzzg_, gzzzzzh_ as IEnumerable<string>);
            DataType gzzzzzj_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> gzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzj_);
            CqlInterval<CqlDateTime> gzzzzzl_ = this.Measurement_Period(context);
            bool? gzzzzzm_ = context.Operators.Overlaps(gzzzzzk_, gzzzzzl_, default);
            bool? gzzzzzn_ = context.Operators.And(gzzzzzi_, gzzzzzm_);

            return gzzzzzn_;
        };
        IEnumerable<Procedure> fzzzzzc_ = context.Operators.Where<Procedure>(fzzzzza_, fzzzzzb_);
        bool? fzzzzzd_ = context.Operators.Exists<Procedure>(fzzzzzc_);
        bool? fzzzzze_ = context.Operators.Or(ezzzzzy_, fzzzzzd_);

        return fzzzzze_;
    }


    #endregion Expressions

}
