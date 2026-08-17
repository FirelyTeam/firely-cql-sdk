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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS177FHIRChildMDDSuicideAssmt", "1.0.000")]
public partial class CMS177FHIRChildMDDSuicideAssmt_1_0_000 : ILibrary, ISingleton<CMS177FHIRChildMDDSuicideAssmt_1_0_000>
{
    #region ValueSets (9)

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

    #region Codes (1)

    [CqlCodeDefinition("Suicide risk assessment (procedure)", codeId: "225337009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Suicide_risk_assessment__procedure_(CqlContext _) => _Suicide_risk_assessment__procedure_;
    private static readonly CqlCode _Suicide_risk_assessment__procedure_ = new CqlCode("225337009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Suicide_risk_assessment__procedure_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8755168546983360421L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS177FHIRChildMDDSuicideAssmt-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5323727449356102700L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -2001458593093813737L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7256827302783747340L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -2246690249441990185L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 8732306134938989179L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Condition Major Depressive Disorder")]
    public IEnumerable<Encounter> Encounter_With_Condition_Major_Depressive_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Condition_Major_Depressive_Disorder, Encounter_With_Condition_Major_Depressive_Disorder_Compute);

    private const long _cacheIndex_Encounter_With_Condition_Major_Depressive_Disorder = 8107967900919985246L;

    private IEnumerable<Encounter> Encounter_With_Condition_Major_Depressive_Disorder_Compute(CqlContext context)
    {
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
            bool? ad_;
            // CQL 'and' (80:11-81:66): right operand skipped when left is false
            if (ac_ is false)
            {
                ad_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                Period af_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
                ad_ = ac_ & ah_;
            }
            // CQL 'and' (80:5-88:7): right operand skipped when left is false
            if (ad_ is false)
            {
                return false;
            }
            else
            {
                CqlValueSet ai_ = this.Major_Depressive_Disorder_Active(context);
                IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? ak_(Condition MDDConditionProb) {
                    List<ResourceReference> ar_ = ValidEncounter?.ReasonReference;
                    bool? as_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ar_, MDDConditionProb);
                    return as_;
                }

                IEnumerable<Condition> al_ = context.Operators.Where<Condition>(aj_, ak_);
                IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? an_(Condition MDDEncDx) {
                    List<ResourceReference> at_ = ValidEncounter?.ReasonReference;
                    bool? au_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)at_, MDDEncDx);
                    return au_;
                }

                IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
                IEnumerable<Condition> ap_ = context.Operators.Union<Condition>(al_ as IEnumerable<Condition>, ao_ as IEnumerable<Condition>);
                bool? aq_ = context.Operators.Exists<Condition>(ap_);
                return ad_ & aq_;
            }
        }

        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Encounter With Reason Major Depressive Disorder")]
    public IEnumerable<Encounter> Encounter_With_Reason_Major_Depressive_Disorder(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Reason_Major_Depressive_Disorder, Encounter_With_Reason_Major_Depressive_Disorder_Compute);

    private const long _cacheIndex_Encounter_With_Reason_Major_Depressive_Disorder = 720527832511942766L;

    private IEnumerable<Encounter> Encounter_With_Reason_Major_Depressive_Disorder_Compute(CqlContext context)
    {
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
            bool? ad_;
            // CQL 'and' (99:11-100:66): right operand skipped when left is false
            if (ac_ is false)
            {
                ad_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                Period af_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
                ad_ = ac_ & ah_;
            }
            // CQL 'and' (99:5-101:77): right operand skipped when left is false
            if (ad_ is false)
            {
                return false;
            }
            else
            {
                List<CodeableConcept> ai_ = ValidEncounter?.ReasonCode;

                CqlConcept aj_(CodeableConcept @this) {
                    CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return an_;
                }

                IEnumerable<CqlConcept> ak_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ai_, aj_);
                CqlValueSet al_ = this.Major_Depressive_Disorder_Active(context);
                bool? am_ = context.Operators.ConceptsInValueSet(ak_, al_);
                return ad_ & am_;
            }
        }

        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Major Depressive Disorder Encounter")]
    public IEnumerable<Encounter> Major_Depressive_Disorder_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Major_Depressive_Disorder_Encounter, Major_Depressive_Disorder_Encounter_Compute);

    private const long _cacheIndex_Major_Depressive_Disorder_Encounter = 3689749010899809839L;

    private IEnumerable<Encounter> Major_Depressive_Disorder_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Condition_Major_Depressive_Disorder(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Reason_Major_Depressive_Disorder(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 7797060179689319226L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
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
            // CQL 'and' (43:5-45:5): right operand skipped when left is false
            if (l_ is false)
            {
                return false;
            }
            else
            {
                bool? m_ = context.Operators.LessOrEqual(k_, 16);
                return l_ & m_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 572249356221058848L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Procedure For Suicide Risk Assessment")]
    public IEnumerable<Encounter> Encounter_With_Procedure_For_Suicide_Risk_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Procedure_For_Suicide_Risk_Assessment, Encounter_With_Procedure_For_Suicide_Risk_Assessment_Compute);

    private const long _cacheIndex_Encounter_With_Procedure_For_Suicide_Risk_Assessment = 4638551457840909626L;

    private IEnumerable<Encounter> Encounter_With_Procedure_For_Suicide_Risk_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);

        bool? b_(Encounter MDDEncounter) {
            CqlCode d_ = this.Suicide_risk_assessment__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure SuicideRiskAssessmentProcedure) {
                Code<EventStatus> i_ = SuicideRiskAssessmentProcedure?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");
                // CQL 'and' (57:17-58:94): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    Period m_ = MDDEncounter?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    object o_;
                    DataType r_ = SuicideRiskAssessmentProcedure?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    if (t_)
                    {
                        DataType u_ = SuicideRiskAssessmentProcedure?.Performed;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        o_ = v_ as CqlDateTime;
                    }
                    else
                    {
                        DataType w_ = SuicideRiskAssessmentProcedure?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlQuantity;
                        if (y_)
                        {
                            DataType z_ = SuicideRiskAssessmentProcedure?.Performed;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            o_ = aa_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ab_ = SuicideRiskAssessmentProcedure?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                            if (ad_)
                            {
                                DataType ae_ = SuicideRiskAssessmentProcedure?.Performed;
                                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                                o_ = af_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ag_ = SuicideRiskAssessmentProcedure?.Performed;
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                                if (ai_)
                                {
                                    DataType aj_ = SuicideRiskAssessmentProcedure?.Performed;
                                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                    o_ = ak_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    o_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                    bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, (string)default);
                    return l_ & q_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Observation For Suicide Risk Assessment")]
    public IEnumerable<Encounter> Encounter_With_Observation_For_Suicide_Risk_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Observation_For_Suicide_Risk_Assessment, Encounter_With_Observation_For_Suicide_Risk_Assessment_Compute);

    private const long _cacheIndex_Encounter_With_Observation_For_Suicide_Risk_Assessment = -6020880057812522378L;

    private IEnumerable<Encounter> Encounter_With_Observation_For_Suicide_Risk_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Major_Depressive_Disorder_Encounter(context);

        bool? b_(Encounter MDDEncounter) {
            CqlCode d_ = this.Suicide_risk_assessment__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
            IEnumerable<Observation> h_ = context.Operators.Union<Observation>(f_ as IEnumerable<Observation>, g_ as IEnumerable<Observation>);

            bool? i_(Observation ObservationSuicideRiskAssmt) {
                Period k_ = MDDEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                DataType m_ = ObservationSuicideRiskAssmt?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, (string)default);
                // CQL 'and' (64:17-65:85): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> q_ = ObservationSuicideRiskAssmt?.StatusElement;
                    ObservationStatus? r_ = q_?.Value;
                    string s_ = context.Operators.Convert<string>(r_);
                    string[] t_ = [
                        "final",
                        "corrected",
                        "amended",
                    ];
                    bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                    return p_ & u_;
                }
            }

            bool? j_ = context.Operators.WhereAny<Observation>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3556269054093713636L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Procedure_For_Suicide_Risk_Assessment(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Observation_For_Suicide_Risk_Assessment(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


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
