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
        object hzzzzzzzzzzzm_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzn_);

        return hzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzp_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzp_);
        IEnumerable<Observation> hzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzr_);
        bool? hzzzzzzzzzzzt_(Observation PalliativeAssessment)
        {
            DataType izzzzzzzzzzzq_ = PalliativeAssessment?.Effective;
            object izzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzu_ = context.Operators.Overlaps(izzzzzzzzzzzs_, izzzzzzzzzzzt_, "day");

            return izzzzzzzzzzzu_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzu_ = context.Operators.Where<Observation>(hzzzzzzzzzzzs_, hzzzzzzzzzzzt_);
        bool? hzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzu_);
        CqlValueSet hzzzzzzzzzzzw_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> hzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzy_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> izzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? izzzzzzzzzzzx_ = context.Operators.Overlaps(izzzzzzzzzzzv_, izzzzzzzzzzzw_, "day");

            return izzzzzzzzzzzx_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzz_ = context.Operators.Where<Condition>(hzzzzzzzzzzzx_, hzzzzzzzzzzzy_);
        bool? izzzzzzzzzzza_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzz_);
        bool? izzzzzzzzzzzb_ = context.Operators.Or(hzzzzzzzzzzzv_, izzzzzzzzzzza_);
        CqlValueSet izzzzzzzzzzzc_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzze_ = Status_1_8_000.Instance.isEncounterPerformed(context, izzzzzzzzzzzd_);
        bool? izzzzzzzzzzzf_(Encounter PalliativeEncounter)
        {
            Period izzzzzzzzzzzy_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzz_ as object);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzb_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzc_ = context.Operators.Overlaps(jzzzzzzzzzzza_, jzzzzzzzzzzzb_, "day");

            return jzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzg_ = context.Operators.Where<Encounter>(izzzzzzzzzzze_, izzzzzzzzzzzf_);
        bool? izzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzg_);
        bool? izzzzzzzzzzzi_ = context.Operators.Or(izzzzzzzzzzzb_, izzzzzzzzzzzh_);
        CqlValueSet izzzzzzzzzzzj_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> izzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzzzzzzzzzl_ = Status_1_8_000.Instance.isInterventionPerformed(context, izzzzzzzzzzzk_);
        bool? izzzzzzzzzzzm_(Procedure PalliativeIntervention)
        {
            DataType jzzzzzzzzzzzd_ = PalliativeIntervention?.Performed;
            object jzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzh_ = context.Operators.Overlaps(jzzzzzzzzzzzf_, jzzzzzzzzzzzg_, "day");

            return jzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzn_ = context.Operators.Where<Procedure>(izzzzzzzzzzzl_, izzzzzzzzzzzm_);
        bool? izzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(izzzzzzzzzzzn_);
        bool? izzzzzzzzzzzp_ = context.Operators.Or(izzzzzzzzzzzi_, izzzzzzzzzzzo_);

        return izzzzzzzzzzzp_;
    }


    #endregion Expressions

}
