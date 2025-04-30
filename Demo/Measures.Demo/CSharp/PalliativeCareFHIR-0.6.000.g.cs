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
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _survey]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object hzzzn_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzp_ = context.Operators.SingletonFrom<Patient>(hzzzo_);

        return hzzzp_;
    }


    [CqlExpressionDefinition("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode hzzzq_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> hzzzr_ = context.Operators.ToList<CqlCode>(hzzzq_);
        IEnumerable<Observation> hzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzr_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzt_(Observation PalliativeAssessment)
        {
            Code<ObservationStatus> izzzi_ = PalliativeAssessment?.StatusElement;
            string izzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzi_);
            string[] izzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzl_ = context.Operators.In<string>(izzzj_, izzzk_ as IEnumerable<string>);
            List<CodeableConcept> izzzm_ = PalliativeAssessment?.Category;
            bool? izzzn_(CodeableConcept PalliativeAssessmentCategory)
            {
                CqlCode izzzw_ = this.survey(context);
                CqlConcept izzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                CqlCode[] izzzy_ = izzzx_?.codes;
                bool? izzzz_ = context.Operators.In<CqlCode>(izzzw_, (IEnumerable<CqlCode>)izzzy_);

                return izzzz_;
            };
            IEnumerable<CodeableConcept> izzzo_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)izzzm_, izzzn_);
            bool? izzzp_ = context.Operators.Exists<CodeableConcept>(izzzo_);
            bool? izzzq_ = context.Operators.And(izzzl_, izzzp_);
            DataType izzzr_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> izzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzr_);
            CqlInterval<CqlDateTime> izzzt_ = this.Measurement_Period(context);
            bool? izzzu_ = context.Operators.Overlaps(izzzs_, izzzt_, default);
            bool? izzzv_ = context.Operators.And(izzzq_, izzzu_);

            return izzzv_;
        };
        IEnumerable<Observation> hzzzu_ = context.Operators.Where<Observation>(hzzzs_, hzzzt_);
        bool? hzzzv_ = context.Operators.Exists<Observation>(hzzzu_);
        CqlValueSet hzzzw_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> hzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? hzzzy_(Encounter PalliativeEncounter)
        {
            Code<Encounter.EncounterStatus> jzzza_ = PalliativeEncounter?.StatusElement;
            string jzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzza_);
            bool? jzzzc_ = context.Operators.Equal(jzzzb_, "finished");
            Period jzzzd_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> jzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzd_ as object);
            CqlInterval<CqlDateTime> jzzzf_ = this.Measurement_Period(context);
            bool? jzzzg_ = context.Operators.Overlaps(jzzze_, jzzzf_, default);
            bool? jzzzh_ = context.Operators.And(jzzzc_, jzzzg_);

            return jzzzh_;
        };
        IEnumerable<Encounter> hzzzz_ = context.Operators.Where<Encounter>(hzzzx_, hzzzy_);
        bool? izzza_ = context.Operators.Exists<Encounter>(hzzzz_);
        bool? izzzb_ = context.Operators.Or(hzzzv_, izzza_);
        CqlValueSet izzzc_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> izzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzze_(Procedure PalliativeIntervention)
        {
            Code<EventStatus> jzzzi_ = PalliativeIntervention?.StatusElement;
            string jzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzi_);
            string[] jzzzk_ = [
                "completed",
                "in-progress",
            ];
            bool? jzzzl_ = context.Operators.In<string>(jzzzj_, jzzzk_ as IEnumerable<string>);
            DataType jzzzm_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> jzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzm_);
            CqlInterval<CqlDateTime> jzzzo_ = this.Measurement_Period(context);
            bool? jzzzp_ = context.Operators.Overlaps(jzzzn_, jzzzo_, default);
            bool? jzzzq_ = context.Operators.And(jzzzl_, jzzzp_);

            return jzzzq_;
        };
        IEnumerable<Procedure> izzzf_ = context.Operators.Where<Procedure>(izzzd_, izzze_);
        bool? izzzg_ = context.Operators.Exists<Procedure>(izzzf_);
        bool? izzzh_ = context.Operators.Or(izzzb_, izzzg_);

        return izzzh_;
    }


    #endregion Expressions

}
