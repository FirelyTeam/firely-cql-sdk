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
[CqlLibrary("CMS1157FHIRHIVRetention", "1.0.000")]
public partial class CMS1157FHIRHIVRetention_1_0_000 : ILibrary, ISingleton<CMS1157FHIRHIVRetention_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("HIV Viral Load Tests", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.377", valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load_Tests(CqlContext _) => _HIV_Viral_Load_Tests;
    private static readonly CqlValueSet _HIV_Viral_Load_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.377", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(7120571719777767895L, () => {
            CqlDateTime a_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlDateTime b_ = context.Operators.DateTime((int?)2027, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
            object d_ = context.ResolveParameter("CMS1157FHIRHIVRetention-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-7203151912317783707L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2942012201348195836L, () => {
            CqlValueSet a_ = this.HIV(context);
            IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

            bool? f_(object HIVDx) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDx);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity((decimal?)240m, "days");
                CqlDateTime n_ = context.Operators.Add(l_, m_);
                bool? o_ = context.Operators.SameOrBefore(j_, n_, "day");
                bool? p_ = this.isVerified(context, HIVDx);
                bool? q_ = context.Operators.And(o_, p_);
                return q_;
            }

            IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
            bool? h_ = context.Operators.Exists<object>(g_);
            return h_;
        });


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-6849852775086982183L, () => {
            CqlValueSet a_ = this.Office_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Outpatient_Consultation(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Annual_Wellness_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Face_to_Face_Interaction(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Home_Healthcare_Services(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
            IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
            CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
            IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
            CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet z_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
            IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
            CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
            IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);

            bool? ag_(Encounter QualifyingEncounter) {
                CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlDateTime am_ = context.Operators.Start(aj_);
                CqlQuantity an_ = context.Operators.Quantity((decimal?)240m, "days");
                CqlDateTime ao_ = context.Operators.Add(am_, an_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, (bool?)true, (bool?)true);
                Period aq_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");
                return as_;
            }

            IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
            bool? ai_ = context.Operators.Exists<Encounter>(ah_);
            return ai_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-4234890751006689890L, () => {
            bool? a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
            bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
            bool? c_ = context.Operators.And(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7534093440581347258L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2018350640424713448L, () => {
            CqlValueSet a_ = this.Office_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet c_ = this.Outpatient_Consultation(context);
            IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
            CqlValueSet f_ = this.Annual_Wellness_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet h_ = this.Face_to_Face_Interaction(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
            CqlValueSet l_ = this.Home_Healthcare_Services(context);
            IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
            IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
            CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
            IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
            CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
            IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            CqlValueSet z_ = this.Telephone_Visits(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
            IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
            CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
            IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);

            IEnumerable<Encounter> ag_(Encounter ValidEncounter) {
                CqlValueSet ai_ = this.HIV(context);
                IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> al_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> am_ = context.Operators.Union<object>(aj_ as IEnumerable<object>, al_ as IEnumerable<object>);

                bool? an_(object HIVDiagnosis) {
                    CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
                    Period as_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                    bool? au_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ar_, at_, "day");
                    Code<Encounter.EncounterStatus> av_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? aw_ = av_?.Value;
                    Code<Encounter.EncounterStatus> ax_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aw_);
                    bool? ay_ = context.Operators.Equal(ax_, "finished");
                    bool? az_ = context.Operators.And(au_, ay_);
                    CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                    CqlDateTime bb_ = context.Operators.Start(ba_);
                    CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                    CqlDateTime be_ = context.Operators.Start(bd_);
                    bool? bf_ = context.Operators.SameOrBefore(bb_, be_, "day");
                    bool? bg_ = context.Operators.And(az_, bf_);
                    bool? bh_ = this.isVerified(context, HIVDiagnosis);
                    bool? bi_ = context.Operators.And(bg_, bh_);
                    return bi_;
                }

                IEnumerable<object> ao_ = context.Operators.Where<object>(am_, an_);
                Encounter ap_(object HIVDiagnosis) => ValidEncounter;
                IEnumerable<Encounter> aq_ = context.Operators.Select<object, Encounter>(ao_, ap_);
                return aq_;
            }

            IEnumerable<Encounter> ah_ = context.Operators.SelectMany<Encounter, Encounter>(af_, ag_);
            return ah_;
        });


    [CqlExpressionDefinition("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3355794708213189831L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);

            IEnumerable<Encounter> b_(Encounter EncounterWithHIV) {
                CqlValueSet e_ = this.HIV_Viral_Load_Tests(context);
                IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? g_(Observation ViralLoadTest) {
                    Code<ObservationStatus> k_ = ViralLoadTest?.StatusElement;
                    ObservationStatus? l_ = k_?.Value;
                    string m_ = context.Operators.Convert<string>(l_);
                    string[] n_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    DataType q_ = ViralLoadTest?.Effective;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, s_, "day");
                    bool? u_ = context.Operators.And(o_, t_);
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    Period z_ = EncounterWithHIV?.Period;
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity((decimal?)90m, "days");
                    CqlDateTime ad_ = context.Operators.Add(ab_, ac_);
                    bool? ae_ = context.Operators.SameOrAfter(y_, ad_, "day");
                    CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.End(ak_);
                    CqlDateTime an_ = context.Operators.Add(al_, ac_);
                    bool? ao_ = context.Operators.SameOrAfter(ah_, an_, "day");
                    bool? ap_ = context.Operators.Or(ae_, ao_);
                    bool? aq_ = context.Operators.And(u_, ap_);
                    return aq_;
                }

                IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
                Encounter i_(Observation ViralLoadTest) => EncounterWithHIV;
                IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);
                return j_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        });


    [CqlExpressionDefinition("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-8472684227837062782L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);

            IEnumerable<Encounter> b_(Encounter EncounterWithHIV) {
                IEnumerable<Encounter> e_ = this.Encounter_During_Measurement_Period_With_HIV(context);

                bool? f_(Encounter AnotherEncounterWithHIV) {
                    bool? j_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                    bool? k_ = context.Operators.Not(j_);
                    Period l_ = AnotherEncounterWithHIV?.Period;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    Period o_ = EncounterWithHIV?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    CqlDateTime q_ = context.Operators.End(p_);
                    CqlQuantity r_ = context.Operators.Quantity((decimal?)90m, "days");
                    CqlDateTime s_ = context.Operators.Add(q_, r_);
                    bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");
                    bool? u_ = context.Operators.And(k_, t_);
                    return u_;
                }

                IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
                Encounter h_(Encounter AnotherEncounterWithHIV) => EncounterWithHIV;
                IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);
                return i_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            bool? d_ = context.Operators.Exists<Encounter>(c_);
            return d_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-432429125784477938L, () => {
            bool? a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
            bool? b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
            bool? c_ = context.Operators.Or(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-5894552619446013439L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-2091850607751688233L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-2769690994678393655L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(6418511549947391990L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1157FHIRHIVRetention_1_0_000() {}

    public static CMS1157FHIRHIVRetention_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1157FHIRHIVRetention";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
