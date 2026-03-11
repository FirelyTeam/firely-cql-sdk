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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("VTE", "8.18.000")]
public partial class VTE_8_18_000 : ILibrary, ISingleton<VTE_8_18_000>
{
    #region ValueSets (3)

    [CqlValueSetDefinition("Obstetrical or Pregnancy Related Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", valueSetVersion: null)]
    public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions(CqlContext _) => _Obstetrical_or_Pregnancy_Related_Conditions;
    private static readonly CqlValueSet _Obstetrical_or_Pregnancy_Related_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);

    [CqlValueSetDefinition("Obstetrics VTE", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", valueSetVersion: null)]
    public CqlValueSet Obstetrics_VTE(CqlContext _) => _Obstetrics_VTE;
    private static readonly CqlValueSet _Obstetrics_VTE = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", null);

    [CqlValueSetDefinition("Venous Thromboembolism", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", valueSetVersion: null)]
    public CqlValueSet Venous_Thromboembolism(CqlContext _) => _Venous_Thromboembolism;
    private static readonly CqlValueSet _Venous_Thromboembolism = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8773371835216757249L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("VTE-8.18.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (7)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -6064100381930538164L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("hasEncDiagnosisOf")]
    public bool? hasEncDiagnosisOf(CqlContext context, Encounter TheEncounter, CqlValueSet DiagnosisValueSet)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        bool? b_(Encounter E) {
            IEnumerable<object> f_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, E);

            bool? g_(object @this) {
                object q_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_ as CodeableConcept);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);

            CqlConcept i_(object @this) {
                object t_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_ as CodeableConcept);
                return u_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<object, CqlConcept>(h_, i_);
            bool? k_ = context.Operators.ConceptsInValueSet(j_, DiagnosisValueSet);
            List<CodeableConcept> l_ = E?.ReasonCode;

            CqlConcept m_(CodeableConcept @this) {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)l_, m_);
            bool? o_ = context.Operators.ConceptsInValueSet(n_, DiagnosisValueSet);
            bool? p_ = context.Operators.Or(k_, o_);
            return p_;
        }

        IEnumerable<bool?> c_ = context.Operators.Select<Encounter, bool?>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<bool?> d_ = context.Operators.Distinct<bool?>(c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Admission Without VTE Or Obstetrical Conditions")]
    public IEnumerable<Encounter> Admission_Without_VTE_Or_Obstetrical_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Admission_Without_VTE_Or_Obstetrical_Conditions, Admission_Without_VTE_Or_Obstetrical_Conditions_Compute);

    private const long _cacheIndex_Admission_Without_VTE_Or_Obstetrical_Conditions = -1660812742436512091L;

    private IEnumerable<Encounter> Admission_Without_VTE_Or_Obstetrical_Conditions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Obstetrical_or_Pregnancy_Related_Conditions(context);
            bool? e_ = this.hasEncDiagnosisOf(context, InpatientEncounter, d_);
            CqlValueSet f_ = this.Venous_Thromboembolism(context);
            bool? g_ = this.hasEncDiagnosisOf(context, InpatientEncounter, f_);
            bool? h_ = context.Operators.Or(e_, g_);
            CqlValueSet i_ = this.Obstetrics_VTE(context);
            bool? j_ = this.hasEncDiagnosisOf(context, InpatientEncounter, i_);
            bool? k_ = context.Operators.Or(h_, j_);
            bool? l_ = context.Operators.Not(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Age Range And Without VTE Diagnosis Or Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions, Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions_Compute);

    private const long _cacheIndex_Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions = -8789342914136935360L;

    private IEnumerable<Encounter> Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Admission_Without_VTE_Or_Obstetrical_Conditions(context);

        bool? b_(Encounter EncounterWithoutConditions) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = EncounterWithoutConditions?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -6262669387061031876L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_Range_And_Without_VTE_Diagnosis_Or_Obstetrical_Conditions(context);
        return a_;
    }


    [CqlFunctionDefinition("fromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> fromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, TheEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDate c_ = context.Operators.DateFrom(b_);
        Period d_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        CqlQuantity h_ = context.Operators.Quantity(1m, "days");
        CqlDate i_ = context.Operators.Add(g_, h_);
        CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);
        return j_;
    }


    [CqlFunctionDefinition("hasPrincipalProcedureOf")]
    public bool? hasPrincipalProcedureOf(CqlContext context, Encounter TheEncounter, CqlValueSet DiagnosisValueSet)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        bool? b_(Encounter E) {
            Claim.ProcedureComponent f_ = CQMCommon_4_1_000.Instance.principalProcedure(context, E);
            DataType g_ = f_?.Procedure;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool? i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, DiagnosisValueSet);
            IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? k_(Procedure P) {
                Claim.ProcedureComponent r_ = CQMCommon_4_1_000.Instance.principalProcedure(context, E);
                DataType s_ = r_?.Procedure;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                Id u_ = P?.IdElement;
                string v_ = u_?.Value;
                bool? w_ = QICoreCommon_4_0_000.Instance.references(context, t_ as ResourceReference, v_);
                return w_;
            }

            IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
            Procedure m_ = context.Operators.SingletonFrom<Procedure>(l_);
            CodeableConcept n_ = m_?.Code;
            CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
            bool? p_ = context.Operators.ConceptInValueSet(o_, DiagnosisValueSet);
            bool? q_ = context.Operators.Or(i_, p_);
            return q_;
        }

        IEnumerable<bool?> c_ = context.Operators.Select<Encounter, bool?>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<bool?> d_ = context.Operators.Distinct<bool?>(c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private VTE_8_18_000() {}

    public static VTE_8_18_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "VTE";
    public string Version => "8.18.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

}
