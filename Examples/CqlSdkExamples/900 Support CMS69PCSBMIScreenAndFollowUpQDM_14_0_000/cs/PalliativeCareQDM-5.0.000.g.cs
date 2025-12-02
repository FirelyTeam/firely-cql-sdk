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
using TestConsoleAppFhir.resources.output._69;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("PalliativeCareQDM", "5.0.000")]
public partial class PalliativeCareQDM_5_0_000 : ILibrary, ISingleton<PalliativeCareQDM_5_0_000>
{
    private PalliativeCareQDM_5_0_000() {}

    public static PalliativeCareQDM_5_0_000 Instance { get; } = new();

    #region ILibrary Implementation

public string Name => "PalliativeCareQDM";
public string Version => "5.0.000";
    public ILibrary[] Dependencies => [CQMCommonQDM_9_0_000.Instance];

#endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "urn:oid:2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("urn:oid:2.16.840.1.113883.3.464.1003.1167", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "urn:oid:2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("urn:oid:2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "urn:oid:2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("urn:oid:2.16.840.1.113883.3.464.1003.198.12.1135", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "urn:oid:2.16.840.1.113883.6.1")]
public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "urn:oid:2.16.840.1.113883.6.1");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "urn:oid:2.16.840.1.113883.6.1", codeSystemVersion: null)]
public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
private static readonly CqlCodeSystem _LOINC =
  new CqlCodeSystem("urn:oid:2.16.840.1.113883.6.1", null, [
      _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("PalliativeCareQDM-5.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<PositiveAssessmentPerformed> c_ = context.Operators.Retrieve<PositiveAssessmentPerformed>(new RetrieveParameters(default, default, b_, "PositiveAssessmentPerformed"));
        bool? d_(PositiveAssessmentPerformed PalliativeAssessment)
        {
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(PalliativeAssessment, "relevantDatetime");
            CqlInterval<CqlDateTime> z_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(PalliativeAssessment, "relevantPeriod");
            CqlInterval<CqlDateTime> aa_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, y_, z_);
            CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
            bool? ac_ = context.Operators.Overlaps(aa_, ab_, "day");

            return ac_;
        };
        IEnumerable<PositiveAssessmentPerformed> e_ = context.Operators.Where<PositiveAssessmentPerformed>(c_, d_);
        bool? f_ = context.Operators.Exists<PositiveAssessmentPerformed>(e_);
        CqlValueSet g_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Diagnosis> h_ = context.Operators.Retrieve<Diagnosis>(new RetrieveParameters(default, g_, default, default));
        bool? i_(Diagnosis PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> ad_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(PalliativeDiagnosis, "prevalencePeriod");
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            bool? af_ = context.Operators.Overlaps(ad_, ae_, "day");

            return af_;
        };
        IEnumerable<Diagnosis> j_ = context.Operators.Where<Diagnosis>(h_, i_);
        bool? k_ = context.Operators.Exists<Diagnosis>(j_);
        bool? l_ = context.Operators.Or(f_, k_);
        CqlValueSet m_ = this.Palliative_Care_Encounter(context);
        IEnumerable<PositiveEncounterPerformed> n_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, m_, default, "PositiveEncounterPerformed"));
        bool? o_(PositiveEncounterPerformed PalliativeEncounter)
        {
            CqlInterval<CqlDateTime> ag_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(PalliativeEncounter, "relevantPeriod");
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.Overlaps(ag_, ah_, "day");

            return ai_;
        };
        IEnumerable<PositiveEncounterPerformed> p_ = context.Operators.Where<PositiveEncounterPerformed>(n_, o_);
        bool? q_ = context.Operators.Exists<PositiveEncounterPerformed>(p_);
        bool? r_ = context.Operators.Or(l_, q_);
        CqlValueSet s_ = this.Palliative_Care_Intervention(context);
        IEnumerable<PositiveInterventionPerformed> t_ = context.Operators.Retrieve<PositiveInterventionPerformed>(new RetrieveParameters(default, s_, default, "PositiveInterventionPerformed"));
        bool? u_(PositiveInterventionPerformed PalliativeIntervention)
        {
            CqlDateTime aj_ = context.Operators.LateBoundProperty<CqlDateTime>(PalliativeIntervention, "relevantDatetime");
            CqlInterval<CqlDateTime> ak_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(PalliativeIntervention, "relevantPeriod");
            CqlInterval<CqlDateTime> al_ = CQMCommonQDM_9_0_000.Instance.NormalizeInterval(context, aj_, ak_);
            CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
            bool? an_ = context.Operators.Overlaps(al_, am_, "day");

            return an_;
        };
        IEnumerable<PositiveInterventionPerformed> v_ = context.Operators.Where<PositiveInterventionPerformed>(t_, u_);
        bool? w_ = context.Operators.Exists<PositiveInterventionPerformed>(v_);
        bool? x_ = context.Operators.Or(r_, w_);

        return x_;
    }


    [CqlExpressionDefinition("Patient")]
    public PatientDetails Patient(CqlContext context)
    {
        IEnumerable<PatientDetails> a_ = context.Operators.Retrieve<PatientDetails>(new RetrieveParameters(default, default, default, "Patient"));
        PatientDetails b_ = context.Operators.SingletonFrom<PatientDetails>(a_);

        return b_;
    }


    #endregion Functions and Expressions

}
