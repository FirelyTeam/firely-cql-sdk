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

    #region Code: survey
    [CqlCodeDefinition(
        definitionName: "survey",
        codeId: "survey",
        codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext context) => _survey;

    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] bzzj_ = [
            new CqlCode("71007-9", "http://loinc.org", default, default),
        ];

        return bzzj_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] bzzk_ = [
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return bzzk_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object bzzl_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)bzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient bzzn_ = context.Operators.SingletonFrom<Patient>(bzzm_);

        return bzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode bzzo_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> bzzp_ = context.Operators.ToList<CqlCode>(bzzo_);
        IEnumerable<Observation> bzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzp_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzr_(Observation PalliativeAssessment)
        {
            Code<ObservationStatus> czzg_ = PalliativeAssessment?.StatusElement;
            string czzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzg_);
            string[] czzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? czzj_ = context.Operators.In<string>(czzh_, czzi_ as IEnumerable<string>);
            List<CodeableConcept> czzk_ = PalliativeAssessment?.Category;
            bool? czzl_(CodeableConcept PalliativeAssessmentCategory)
            {
                CqlCode czzu_ = this.survey(context);
                CqlConcept czzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                CqlCode[] czzw_ = czzv_?.codes;
                bool? czzx_ = context.Operators.In<CqlCode>(czzu_, (IEnumerable<CqlCode>)czzw_);

                return czzx_;
            };
            IEnumerable<CodeableConcept> czzm_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)czzk_, czzl_);
            bool? czzn_ = context.Operators.Exists<CodeableConcept>(czzm_);
            bool? czzo_ = context.Operators.And(czzj_, czzn_);
            DataType czzp_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> czzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzp_);
            CqlInterval<CqlDateTime> czzr_ = this.Measurement_Period(context);
            bool? czzs_ = context.Operators.Overlaps(czzq_, czzr_, default);
            bool? czzt_ = context.Operators.And(czzo_, czzs_);

            return czzt_;
        };
        IEnumerable<Observation> bzzs_ = context.Operators.Where<Observation>(bzzq_, bzzr_);
        bool? bzzt_ = context.Operators.Exists<Observation>(bzzs_);
        CqlValueSet bzzu_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> bzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzu_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? bzzw_(Encounter PalliativeEncounter)
        {
            Code<Encounter.EncounterStatus> czzy_ = PalliativeEncounter?.StatusElement;
            string czzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzy_);
            bool? dzza_ = context.Operators.Equal(czzz_, "finished");
            Period dzzb_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> dzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzb_ as object);
            CqlInterval<CqlDateTime> dzzd_ = this.Measurement_Period(context);
            bool? dzze_ = context.Operators.Overlaps(dzzc_, dzzd_, default);
            bool? dzzf_ = context.Operators.And(dzza_, dzze_);

            return dzzf_;
        };
        IEnumerable<Encounter> bzzx_ = context.Operators.Where<Encounter>(bzzv_, bzzw_);
        bool? bzzy_ = context.Operators.Exists<Encounter>(bzzx_);
        bool? bzzz_ = context.Operators.Or(bzzt_, bzzy_);
        CqlValueSet czza_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> czzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? czzc_(Procedure PalliativeIntervention)
        {
            Code<EventStatus> dzzg_ = PalliativeIntervention?.StatusElement;
            string dzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzg_);
            string[] dzzi_ = [
                "completed",
                "in-progress",
            ];
            bool? dzzj_ = context.Operators.In<string>(dzzh_, dzzi_ as IEnumerable<string>);
            DataType dzzk_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> dzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzk_);
            CqlInterval<CqlDateTime> dzzm_ = this.Measurement_Period(context);
            bool? dzzn_ = context.Operators.Overlaps(dzzl_, dzzm_, default);
            bool? dzzo_ = context.Operators.And(dzzj_, dzzn_);

            return dzzo_;
        };
        IEnumerable<Procedure> czzd_ = context.Operators.Where<Procedure>(czzb_, czzc_);
        bool? czze_ = context.Operators.Exists<Procedure>(czzd_);
        bool? czzf_ = context.Operators.Or(bzzz_, czze_);

        return czzf_;
    }


    #endregion Expressions

}
