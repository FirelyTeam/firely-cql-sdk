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
        object hzzzl_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzn_ = context.Operators.SingletonFrom<Patient>(hzzzm_);

        return hzzzn_;
    }


    [CqlExpressionDefinition("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode hzzzo_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> hzzzp_ = context.Operators.ToList<CqlCode>(hzzzo_);
        IEnumerable<Observation> hzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzp_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzr_(Observation PalliativeAssessment)
        {
            Code<ObservationStatus> izzzg_ = PalliativeAssessment?.StatusElement;
            string izzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzg_);
            string[] izzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzj_ = context.Operators.In<string>(izzzh_, izzzi_ as IEnumerable<string>);
            List<CodeableConcept> izzzk_ = PalliativeAssessment?.Category;
            bool? izzzl_(CodeableConcept PalliativeAssessmentCategory)
            {
                CqlCode izzzu_ = this.survey(context);
                CqlConcept izzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                CqlCode[] izzzw_ = izzzv_?.codes;
                bool? izzzx_ = context.Operators.In<CqlCode>(izzzu_, (IEnumerable<CqlCode>)izzzw_);

                return izzzx_;
            };
            IEnumerable<CodeableConcept> izzzm_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)izzzk_, izzzl_);
            bool? izzzn_ = context.Operators.Exists<CodeableConcept>(izzzm_);
            bool? izzzo_ = context.Operators.And(izzzj_, izzzn_);
            DataType izzzp_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> izzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzp_);
            CqlInterval<CqlDateTime> izzzr_ = this.Measurement_Period(context);
            bool? izzzs_ = context.Operators.Overlaps(izzzq_, izzzr_, default);
            bool? izzzt_ = context.Operators.And(izzzo_, izzzs_);

            return izzzt_;
        };
        IEnumerable<Observation> hzzzs_ = context.Operators.Where<Observation>(hzzzq_, hzzzr_);
        bool? hzzzt_ = context.Operators.Exists<Observation>(hzzzs_);
        CqlValueSet hzzzu_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> hzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? hzzzw_(Encounter PalliativeEncounter)
        {
            Code<Encounter.EncounterStatus> izzzy_ = PalliativeEncounter?.StatusElement;
            string izzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzy_);
            bool? jzzza_ = context.Operators.Equal(izzzz_, "finished");
            Period jzzzb_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzb_ as object);
            CqlInterval<CqlDateTime> jzzzd_ = this.Measurement_Period(context);
            bool? jzzze_ = context.Operators.Overlaps(jzzzc_, jzzzd_, default);
            bool? jzzzf_ = context.Operators.And(jzzza_, jzzze_);

            return jzzzf_;
        };
        IEnumerable<Encounter> hzzzx_ = context.Operators.Where<Encounter>(hzzzv_, hzzzw_);
        bool? hzzzy_ = context.Operators.Exists<Encounter>(hzzzx_);
        bool? hzzzz_ = context.Operators.Or(hzzzt_, hzzzy_);
        CqlValueSet izzza_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> izzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? izzzc_(Procedure PalliativeIntervention)
        {
            Code<EventStatus> jzzzg_ = PalliativeIntervention?.StatusElement;
            string jzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzg_);
            string[] jzzzi_ = [
                "completed",
                "in-progress",
            ];
            bool? jzzzj_ = context.Operators.In<string>(jzzzh_, jzzzi_ as IEnumerable<string>);
            DataType jzzzk_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> jzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzk_);
            CqlInterval<CqlDateTime> jzzzm_ = this.Measurement_Period(context);
            bool? jzzzn_ = context.Operators.Overlaps(jzzzl_, jzzzm_, default);
            bool? jzzzo_ = context.Operators.And(jzzzj_, jzzzn_);

            return jzzzo_;
        };
        IEnumerable<Procedure> izzzd_ = context.Operators.Where<Procedure>(izzzb_, izzzc_);
        bool? izzze_ = context.Operators.Exists<Procedure>(izzzd_);
        bool? izzzf_ = context.Operators.Or(hzzzz_, izzze_);

        return izzzf_;
    }


    #endregion Expressions

}
