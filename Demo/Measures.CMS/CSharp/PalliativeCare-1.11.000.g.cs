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

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("PalliativeCare-1.11.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Has Palliative Care in the Measurement Period")]
    public bool? Has_Palliative_Care_in_the_Measurement_Period(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation PalliativeAssessment)
        {
            DataType ab_ = PalliativeAssessment?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_1_000.Instance.toInterval(context, ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            bool? af_ = context.Operators.Overlaps(ad_, ae_, "day");

            return af_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        CqlValueSet h_ = this.Palliative_Care_Diagnosis(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? j_(Condition PalliativeDiagnosis)
        {
            CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PalliativeDiagnosis);
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            bool? ai_ = context.Operators.Overlaps(ag_, ah_, "day");

            return ai_;
        };
        IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
        bool? l_ = context.Operators.Exists<Condition>(k_);
        bool? m_ = context.Operators.Or(g_, l_);
        CqlValueSet n_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = Status_1_8_000.Instance.isEncounterPerformed(context, o_);
        bool? q_(Encounter PalliativeEncounter)
        {
            Period aj_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
            bool? an_ = context.Operators.Overlaps(al_, am_, "day");

            return an_;
        };
        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
        bool? s_ = context.Operators.Exists<Encounter>(r_);
        bool? t_ = context.Operators.Or(m_, s_);
        CqlValueSet u_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> v_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> w_ = Status_1_8_000.Instance.isInterventionPerformed(context, v_);
        bool? x_(Procedure PalliativeIntervention)
        {
            DataType ao_ = PalliativeIntervention?.Performed;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ap_);
            CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
            bool? as_ = context.Operators.Overlaps(aq_, ar_, "day");

            return as_;
        };
        IEnumerable<Procedure> y_ = context.Operators.Where<Procedure>(w_, x_);
        bool? z_ = context.Operators.Exists<Procedure>(y_);
        bool? aa_ = context.Operators.Or(t_, z_);

        return aa_;
    }


    #endregion Expressions

}
