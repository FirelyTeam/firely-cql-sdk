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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS177FHIRChildMDDSuicideAssmt", "1.0.000")]
public partial class CMS177FHIRChildMDDSuicideAssmt_1_0_000 : ILibrary, ISingleton<CMS177FHIRChildMDDSuicideAssmt_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Group Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", valueSetVersion: null)]
    public CqlValueSet Group_Psychotherapy(CqlContext _) => _Group_Psychotherapy;
    private static readonly CqlValueSet _Group_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187", null);

    [CqlValueSetDefinition("Major Depressive Disorder Active", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", valueSetVersion: null)]
    public CqlValueSet Major_Depressive_Disorder_Active(CqlContext _) => _Major_Depressive_Disorder_Active;
    private static readonly CqlValueSet _Major_Depressive_Disorder_Active = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit for Family Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_for_Family_Psychotherapy(CqlContext _) => _Psych_Visit_for_Family_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_for_Family_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Psychoanalysis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", valueSetVersion: null)]
    public CqlValueSet Psychoanalysis(CqlContext _) => _Psychoanalysis;
    private static readonly CqlValueSet _Psychoanalysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Suicide risk assessment (procedure)", codeId: "225337009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Suicide_risk_assessment__procedure_(CqlContext _) => _Suicide_risk_assessment__procedure_;
    private static readonly CqlCode _Suicide_risk_assessment__procedure_ = new CqlCode("225337009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Suicide_risk_assessment__procedure_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(8755168546983360421L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS177FHIRChildMDDSuicideAssmt-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(5323727449356102700L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-2001458593093813737L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-7256827302783747340L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-2246690249441990185L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(8732306134938989179L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    [CqlExpressionDefinition("Encounter With Condition Major Depressive Disorder")]
    public IEnumerable<Encounter> Encounter_With_Condition_Major_Depressive_Disorder(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(8107967900919985246L, () => {
            CqlValueSet a_ = this.Office_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Outpatient_Consultation(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Psych_Visit_Diagnostic_Evaluation(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Psych_Visit_for_Family_Psychotherapy(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Psych_Visit_Psychotherapy(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet n_ = this.Psychoanalysis(context);
            IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
            IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
            CqlValueSet r_ = this.Group_Psychotherapy(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet t_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
            IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);

            bool? x_(Encounter ValidEncounter) {
                Code<Encounter.EncounterStatus> z_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? aa_ = z_?.Value;
                Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aa_);
                bool? ac_ = context.Operators.Equal(ab_, "finished");
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                Period ae_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                bool? ag_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, af_, "day");
                bool? ah_ = context.Operators.And(ac_, ag_);
                CqlValueSet ai_ = this.Major_Depressive_Disorder_Active(context);
                IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? ak_(Condition MDDConditionProb) {
                    List<ResourceReference> at_ = ValidEncounter?.ReasonReference;
                    bool? au_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)at_, MDDConditionProb);
                    return au_;
                }

                IEnumerable<Condition> al_ = context.Operators.Where<Condition>(aj_, ak_);
                IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? ao_(Condition MDDEncDx) {
                    List<ResourceReference> av_ = ValidEncounter?.ReasonReference;
                    bool? aw_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)av_, MDDEncDx);
                    return aw_;
                }

                IEnumerable<Condition> ap_ = context.Operators.Where<Condition>(an_, ao_);
                IEnumerable<object> aq_ = context.Operators.Union<object>(al_ as IEnumerable<object>, ap_ as IEnumerable<object>);
                bool? ar_ = context.Operators.Exists<object>(aq_);
                bool? as_ = context.Operators.And(ah_, ar_);
                return as_;
            }

            IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
            return y_;
        });


    [CqlExpressionDefinition("Encounter With Reason Major Depressive Disorder")]
    public IEnumerable<Encounter> Encounter_With_Reason_Major_Depressive_Disorder(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(720527832511942766L, () => {
            CqlValueSet a_ = this.Office_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Outpatient_Consultation(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Psych_Visit_Diagnostic_Evaluation(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Psych_Visit_for_Family_Psychotherapy(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Psych_Visit_Psychotherapy(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet n_ = this.Psychoanalysis(context);
            IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
            IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
            CqlValueSet r_ = this.Group_Psychotherapy(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet t_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
            IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);

            bool? x_(Encounter ValidEncounter) {
                Code<Encounter.EncounterStatus> z_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? aa_ = z_?.Value;
                Code<Encounter.EncounterStatus> ab_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aa_);
                bool? ac_ = context.Operators.Equal(ab_, "finished");
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                Period ae_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                bool? ag_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, af_, "day");
                bool? ah_ = context.Operators.And(ac_, ag_);
                List<CodeableConcept> ai_ = ValidEncounter?.ReasonCode;

                CqlConcept aj_(CodeableConcept @this) {
                    CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ao_;
                }

                IEnumerable<CqlConcept> ak_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ai_, aj_);
                CqlValueSet al_ = this.Major_Depressive_Disorder_Active(context);
                bool? am_ = context.Operators.ConceptsInValueSet(ak_, al_);
                bool? an_ = context.Operators.And(ah_, am_);
                return an_;
            }

            IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
            return y_;
        });


    [CqlExpressionDefinition("Major Depressive Disorder Encounter")]
    public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(3689749010899809839L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_Condition_Major_Depressive_Disorder(context);
            IEnumerable<Encounter> b_ = this.Encounter_With_Reason_Major_Depressive_Disorder(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7797060179689319226L, () => {
            IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);

            bool? b_(Encounter MDDEncounter) {
                Patient d_ = this.Patient(context);
                Date e_ = d_?.BirthDateElement;
                string f_ = e_?.Value;
                CqlDate g_ = context.Operators.ConvertStringToDate(f_);
                CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                CqlDateTime i_ = context.Operators.Start(h_);
                CqlDate j_ = context.Operators.DateFrom(i_);
                int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
                bool? l_ = context.Operators.GreaterOrEqual(k_, 6);
                Date n_ = d_?.BirthDateElement;
                string o_ = n_?.Value;
                CqlDate p_ = context.Operators.ConvertStringToDate(o_);
                CqlDateTime r_ = context.Operators.Start(h_);
                CqlDate s_ = context.Operators.DateFrom(r_);
                int? t_ = context.Operators.CalculateAgeAt(p_, s_, "year");
                bool? u_ = context.Operators.LessOrEqual(t_, 16);
                bool? v_ = context.Operators.And(l_, u_);
                return v_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(572249356221058848L, () => {
            IEnumerable<Encounter> a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Encounter With Procedure For Suicide Risk Assessment")]
    public IEnumerable<Encounter> Encounter_With_Procedure_For_Suicide_Risk_Assessment(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4638551457840909626L, () => {
            IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);

            IEnumerable<Encounter> b_(Encounter MDDEncounter) {
                CqlCode d_ = this.Suicide_risk_assessment__procedure_(context);
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? g_(Procedure SuicideRiskAssessmentProcedure) {
                    Code<EventStatus> k_ = SuicideRiskAssessmentProcedure?.StatusElement;
                    EventStatus? l_ = k_?.Value;
                    string m_ = context.Operators.Convert<string>(l_);
                    bool? n_ = context.Operators.Equal(m_, "completed");
                    Period o_ = MDDEncounter?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);

                    object q_() {

                        bool u_() {
                            DataType y_ = SuicideRiskAssessmentProcedure?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            bool aa_ = z_ is CqlDateTime;
                            return aa_;
                        }


                        bool v_() {
                            DataType ab_ = SuicideRiskAssessmentProcedure?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                            return ad_;
                        }


                        bool w_() {
                            DataType ae_ = SuicideRiskAssessmentProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlQuantity;
                            return ag_;
                        }


                        bool x_() {
                            DataType ah_ = SuicideRiskAssessmentProcedure?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                            return aj_;
                        }

                        if (u_())
                        {
                            DataType ak_ = SuicideRiskAssessmentProcedure?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            return (al_ as CqlDateTime) as object;
                        }
                        else if (v_())
                        {
                            DataType am_ = SuicideRiskAssessmentProcedure?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            return (an_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (w_())
                        {
                            DataType ao_ = SuicideRiskAssessmentProcedure?.Performed;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            return (ap_ as CqlQuantity) as object;
                        }
                        else if (x_())
                        {
                            DataType aq_ = SuicideRiskAssessmentProcedure?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            return (ar_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, default);
                    bool? t_ = context.Operators.And(n_, s_);
                    return t_;
                }

                IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
                Encounter i_(Procedure SuicideRiskAssessmentProcedure) => MDDEncounter;
                IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
                return j_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter With Observation For Suicide Risk Assessment")]
    public IEnumerable<Encounter> Encounter_With_Observation_For_Suicide_Risk_Assessment(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-6020880057812522378L, () => {
            IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);

            IEnumerable<Encounter> b_(Encounter MDDEncounter) {
                CqlCode d_ = this.Suicide_risk_assessment__procedure_(context);
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(d_);
                IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
                IEnumerable<object> j_ = context.Operators.Union<object>(f_ as IEnumerable<object>, i_ as IEnumerable<object>);

                bool? k_(object ObservationSuicideRiskAssmt) {
                    Period o_ = MDDEncounter?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    object q_ = context.Operators.LateBoundProperty<object>(ObservationSuicideRiskAssmt, "effective");
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, default);
                    object u_ = context.Operators.LateBoundProperty<object>(ObservationSuicideRiskAssmt, "status");
                    string v_ = context.Operators.LateBoundProperty<string>(u_, "value");
                    string[] w_ = [
                        "final",
                        "corrected",
                        "amended",
                    ];
                    bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                    bool? y_ = context.Operators.And(t_, x_);
                    return y_;
                }

                IEnumerable<object> l_ = context.Operators.Where<object>(j_, k_);
                Encounter m_(object ObservationSuicideRiskAssmt) => MDDEncounter;
                IEnumerable<Encounter> n_ = context.Operators.Select<object, Encounter>(l_, m_);
                return n_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(3556269054093713636L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_Procedure_For_Suicide_Risk_Assessment(context);
            IEnumerable<Encounter> b_ = this.Encounter_With_Observation_For_Suicide_Risk_Assessment(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS177FHIRChildMDDSuicideAssmt_1_0_000() {}

    public static CMS177FHIRChildMDDSuicideAssmt_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS177FHIRChildMDDSuicideAssmt";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

}
