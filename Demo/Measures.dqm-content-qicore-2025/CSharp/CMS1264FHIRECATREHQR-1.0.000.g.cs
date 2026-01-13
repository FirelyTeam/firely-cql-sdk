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
[CqlLibrary("CMS1264FHIRECATREHQR", "1.0.000")]
public partial class CMS1264FHIRECATREHQR_1_0_000 : ILibrary, ISingleton<CMS1264FHIRECATREHQR_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Mental Health Diagnosis without Substance Use Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", valueSetVersion: null)]
    public CqlValueSet Mental_Health_Diagnosis_without_Substance_Use_Disorders(CqlContext _) => _Mental_Health_Diagnosis_without_Substance_Use_Disorders;
    private static readonly CqlValueSet _Mental_Health_Diagnosis_without_Substance_Use_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", null);

    [CqlValueSetDefinition("Decision to Transfer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.286", valueSetVersion: null)]
    public CqlValueSet Decision_to_Transfer(CqlContext _) => _Decision_to_Transfer;
    private static readonly CqlValueSet _Decision_to_Transfer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.286", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Emergency Department Location", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.284", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Location(CqlContext _) => _Emergency_Department_Location;
    private static readonly CqlValueSet _Emergency_Department_Location = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.284", null);

    [CqlValueSetDefinition("Emergency Department Treatment Location", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.278", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Treatment_Location(CqlContext _) => _Emergency_Department_Treatment_Location;
    private static readonly CqlValueSet _Emergency_Department_Treatment_Location = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.278", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", valueSetVersion: null)]
    public CqlValueSet Triage(CqlContext _) => _Triage;
    private static readonly CqlValueSet _Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Patient left without being seen (finding)", codeId: "21541000119102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_left_without_being_seen__finding_(CqlContext _) => _Patient_left_without_being_seen__finding_;
    private static readonly CqlCode _Patient_left_without_being_seen__finding_ = new CqlCode("21541000119102", "http://snomed.info/sct");

    [CqlCodeDefinition("Emergency room", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_room(CqlContext _) => _Emergency_room;
    private static readonly CqlCode _Emergency_room = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("Emergency trauma unit", codeId: "ETU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_trauma_unit(CqlContext _) => _Emergency_trauma_unit;
    private static readonly CqlCode _Emergency_trauma_unit = new CqlCode("ETU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Patient_left_without_being_seen__finding_]);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _Emergency_room,
          _Emergency_trauma_unit]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(3771323338948774042L, () => {
            object a_ = context.ResolveParameter("CMS1264FHIRECATREHQR-1.0.000", "Measurement Period", null);
            return (CqlInterval<CqlDateTime>)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(1014495218581176614L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("ED Evaluation and Management")]
    public IEnumerable<Encounter> ED_Evaluation_and_Management(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3741547166926209002L, () => {
            CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? c_(Encounter EDEvalManagementVisit) {
                Period e_ = EDEvalManagementVisit?.Period;
                CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                CqlDateTime g_ = context.Operators.End(f_);
                CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
                Code<Encounter.EncounterStatus> j_ = EDEvalManagementVisit?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                bool? m_ = context.Operators.Equal(l_, "finished");
                bool? n_ = context.Operators.And(i_, m_);
                return n_;
            }

            IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("ED Triage")]
    public IEnumerable<Encounter> ED_Triage(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-2370023395528382226L, () => {
            CqlValueSet a_ = this.Triage(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? c_(Encounter EDTriage) {
                Period e_ = EDTriage?.Period;
                CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
                CqlDateTime g_ = context.Operators.End(f_);
                CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
                bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
                Code<Encounter.EncounterStatus> j_ = EDTriage?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "finished",
                    "triaged",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                bool? p_ = context.Operators.And(i_, o_);
                return p_;
            }

            IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("ED Triage Excluding Those Prior To ED Encounters")]
    public IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(3996380737021184409L, () => {
            IEnumerable<Encounter> a_ = this.ED_Triage(context);

            bool? b_(Encounter EDTriageinMP) {
                IEnumerable<Encounter> d_ = this.ED_Evaluation_and_Management(context);

                bool? e_(Encounter EDEvalManagementinMP) {
                    Period i_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    Period k_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.OverlapsBefore(j_, l_, default);
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
                    bool? s_ = context.Operators.Or(m_, r_);
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, default);
                    bool? y_ = context.Operators.Or(s_, x_);
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime ae_ = context.Operators.Start(ad_);
                    CqlQuantity af_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ag_, aj_, true, false);
                    bool? al_ = context.Operators.In<CqlDateTime>(ab_, ak_, default);
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime ao_ = context.Operators.Start(an_);
                    bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
                    bool? aq_ = context.Operators.And(al_, ap_);
                    bool? ar_ = context.Operators.Or(y_, aq_);
                    return ar_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                bool? g_ = context.Operators.Exists<Encounter>(f_);
                bool? h_ = context.Operators.Not(g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-7666571774031925247L, () => {
            IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);
            IEnumerable<Encounter> b_ = this.ED_Triage_Excluding_Those_Prior_To_ED_Encounters(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(5243972692210139206L, () => {
            IEnumerable<Encounter> a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlFunctionDefinition("edArrivalTime")]
    public CqlDateTime edArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage_and_Evaluation_Management(context);

        bool? b_(Encounter @this) {
            List<Encounter.LocationComponent> n_ = @this?.Location;
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        List<Encounter.LocationComponent> d_(Encounter @this) {
            List<Encounter.LocationComponent> p_ = @this?.Location;
            return p_;
        }

        IEnumerable<List<Encounter.LocationComponent>> e_ = context.Operators.Select<Encounter, List<Encounter.LocationComponent>>(c_, d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)e_);

        bool? g_(Encounter.LocationComponent Location) {
            ResourceReference q_ = Location?.Location;
            Location r_ = CQMCommon_4_1_000.Instance.getLocation(context, q_);
            List<CodeableConcept> s_ = r_?.Type;

            CqlConcept t_(CodeableConcept @this) {
                CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bq_;
            }

            IEnumerable<CqlConcept> u_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, t_);

            bool? v_(CqlConcept LocationType) {
                CqlValueSet br_ = this.Emergency_Department_Location(context);
                bool? bs_ = context.Operators.ConceptInValueSet(LocationType, br_);
                CqlCode bt_ = this.Emergency_room(context);
                CqlConcept bu_ = context.Operators.ConvertCodeToConcept(bt_);
                bool? bv_ = context.Operators.Equivalent(LocationType, bu_);
                bool? bw_ = context.Operators.Or(bs_, bv_);
                CqlCode bx_ = this.Emergency_trauma_unit(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                bool? bz_ = context.Operators.Equivalent(LocationType, by_);
                bool? ca_ = context.Operators.Or(bw_, bz_);
                return ca_;
            }

            IEnumerable<CqlConcept> w_ = context.Operators.Where<CqlConcept>(u_, v_);
            bool? x_ = context.Operators.Exists<CqlConcept>(w_);
            Period y_ = Location?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(x_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime af_ = context.Operators.End(ae_);
            Period ag_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlQuantity aj_ = context.Operators.Quantity(120m, "minutes");
            CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
            CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ak_, an_, true, false);
            bool? ap_ = context.Operators.In<CqlDateTime>(af_, ao_, default);
            CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            bool? at_ = context.Operators.Not((bool?)(as_ is null));
            bool? au_ = context.Operators.And(ap_, at_);
            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            bool? az_ = context.Operators.OverlapsBefore(aw_, ay_, default);
            bool? ba_ = context.Operators.Or(au_, az_);
            CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            bool? bf_ = context.Operators.OverlapsBefore(bc_, be_, default);
            bool? bg_ = context.Operators.Or(ba_, bf_);
            CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime bj_ = context.Operators.Start(bi_);
            CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime bm_ = context.Operators.Start(bl_);
            bool? bn_ = context.Operators.SameAs(bj_, bm_, default);
            bool? bo_ = context.Operators.Or(bg_, bn_);
            bool? bp_ = context.Operators.And(ac_, bo_);
            return bp_;
        }

        IEnumerable<Encounter.LocationComponent> h_ = context.Operators.Where<Encounter.LocationComponent>(f_, g_);

        CqlDateTime i_(Encounter.LocationComponent Location) {
            Period cb_ = Location?.Period;
            CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
            CqlDateTime cd_ = context.Operators.Start(cc_);
            return cd_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.Last<CqlDateTime>(l_);
        return m_;
    }


    [CqlExpressionDefinition("ED Triage Before Evaluation Management")]
    public IEnumerable<Encounter> ED_Triage_Before_Evaluation_Management(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4085492043442645098L, () => {
            IEnumerable<Encounter> a_ = this.ED_Triage(context);

            IEnumerable<Encounter> b_(Encounter EDTriageinMP) {
                IEnumerable<Encounter> d_ = this.Denominator(context);

                bool? e_(Encounter EDEncounter) {
                    Period i_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    Period k_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.OverlapsBefore(j_, l_, default);
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
                    bool? s_ = context.Operators.Or(m_, r_);
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, default);
                    bool? y_ = context.Operators.Or(s_, x_);
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime ae_ = context.Operators.Start(ad_);
                    CqlQuantity af_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ag_, aj_, true, false);
                    bool? al_ = context.Operators.In<CqlDateTime>(ab_, ak_, default);
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    CqlDateTime ao_ = context.Operators.Start(an_);
                    bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
                    bool? aq_ = context.Operators.And(al_, ap_);
                    bool? ar_ = context.Operators.Or(y_, aq_);
                    return ar_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                Encounter g_(Encounter EDEncounter) => EDTriageinMP;
                IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Triage and Evaluation Management")]
    public IEnumerable<Encounter> ED_Triage_and_Evaluation_Management(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3748220850778708280L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);
            IEnumerable<Encounter> b_ = this.ED_Triage_Before_Evaluation_Management(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlFunctionDefinition("edTreatmentRoomTimeArrivalTime")]
    public CqlDateTime edTreatmentRoomTimeArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent Location) {
            ResourceReference i_ = Location?.Location;
            Location j_ = CQMCommon_4_1_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Emergency_Department_Treatment_Location(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            Period p_ = Location?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            bool? s_ = context.Operators.Not((bool?)(r_ is null));
            bool? t_ = context.Operators.And(o_, s_);
            return t_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        CqlDateTime d_(Encounter.LocationComponent Location) {
            Period v_ = Location?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            return x_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.First<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Time to Treatment Room Greater Than 60 Minutes")]
    public IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(635040179997437826L, () => {
            IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);

            bool? b_(Encounter EDEvalManagementinMP) {
                CqlDateTime d_ = this.edArrivalTime(context, EDEvalManagementinMP);
                CqlDateTime e_ = this.edTreatmentRoomTimeArrivalTime(context, EDEvalManagementinMP);
                CqlQuantity f_ = context.Operators.Quantity(61m, "minutes");
                CqlDateTime g_ = context.Operators.Subtract(e_, f_);
                bool? h_ = context.Operators.SameOrBefore(d_, g_, default);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Arrival Left Without Being Seen")]
    public IEnumerable<Encounter> ED_Arrival_Left_Without_Being_Seen(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-4285098943622379315L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);

            bool? b_(Encounter EDEncounter) {
                Encounter.HospitalizationComponent d_ = EDEncounter?.Hospitalization;
                CodeableConcept e_ = d_?.DischargeDisposition;
                CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
                CqlCode g_ = this.Patient_left_without_being_seen__finding_(context);
                CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
                bool? i_ = context.Operators.Equivalent(f_, h_);
                return i_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlFunctionDefinition("TransferDecisionUsingOrder")]
    public CqlDateTime TransferDecisionUsingOrder(CqlContext context, Encounter EDEncounter)
    {
        CqlValueSet a_ = this.Decision_to_Transfer(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest TransferOrder) {
            FhirDateTime j_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
            Period l_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, default);
            Code<RequestIntent> o_ = TransferOrder?.IntentElement;
            RequestIntent? p_ = o_?.Value;
            Code<RequestIntent> q_ = context.Operators.Convert<Code<RequestIntent>>(p_);
            bool? r_ = context.Operators.Equal(q_, "order");
            bool? s_ = context.Operators.And(n_, r_);
            Code<RequestStatus> t_ = TransferOrder?.StatusElement;
            RequestStatus? u_ = t_?.Value;
            Code<RequestStatus> v_ = context.Operators.Convert<Code<RequestStatus>>(u_);
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "active",
                "completed",
            ];
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            bool? z_ = context.Operators.And(s_, y_);
            return z_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        CqlDateTime e_(ServiceRequest TransferOrder) {
            FhirDateTime aa_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
            return ab_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.Select<ServiceRequest, CqlDateTime>(d_, e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.Distinct<CqlDateTime>(f_);
        IEnumerable<CqlDateTime> h_ = context.Operators.ListSort<CqlDateTime>(g_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime i_ = context.Operators.Last<CqlDateTime>(h_);
        return i_;
    }


    [CqlFunctionDefinition("edDepartureTime")]
    public CqlDateTime edDepartureTime(CqlContext context, Encounter EDEncounter)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage_and_Evaluation_Management(context);

        bool? b_(Encounter @this) {
            List<Encounter.LocationComponent> n_ = @this?.Location;
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        List<Encounter.LocationComponent> d_(Encounter @this) {
            List<Encounter.LocationComponent> p_ = @this?.Location;
            return p_;
        }

        IEnumerable<List<Encounter.LocationComponent>> e_ = context.Operators.Select<Encounter, List<Encounter.LocationComponent>>(c_, d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)e_);

        bool? g_(Encounter.LocationComponent Location) {
            ResourceReference q_ = Location?.Location;
            Location r_ = CQMCommon_4_1_000.Instance.getLocation(context, q_);
            List<CodeableConcept> s_ = r_?.Type;

            CqlConcept t_(CodeableConcept @this) {
                CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bq_;
            }

            IEnumerable<CqlConcept> u_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, t_);

            bool? v_(CqlConcept LocationType) {
                CqlValueSet br_ = this.Emergency_Department_Location(context);
                bool? bs_ = context.Operators.ConceptInValueSet(LocationType, br_);
                CqlCode bt_ = this.Emergency_room(context);
                CqlConcept bu_ = context.Operators.ConvertCodeToConcept(bt_);
                bool? bv_ = context.Operators.Equivalent(LocationType, bu_);
                bool? bw_ = context.Operators.Or(bs_, bv_);
                CqlCode bx_ = this.Emergency_trauma_unit(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                bool? bz_ = context.Operators.Equivalent(LocationType, by_);
                bool? ca_ = context.Operators.Or(bw_, bz_);
                return ca_;
            }

            IEnumerable<CqlConcept> w_ = context.Operators.Where<CqlConcept>(u_, v_);
            bool? x_ = context.Operators.Exists<CqlConcept>(w_);
            Period y_ = Location?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(x_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime af_ = context.Operators.End(ae_);
            Period ag_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlQuantity aj_ = context.Operators.Quantity(120m, "minutes");
            CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
            CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ak_, an_, true, false);
            bool? ap_ = context.Operators.In<CqlDateTime>(af_, ao_, default);
            CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            bool? at_ = context.Operators.Not((bool?)(as_ is null));
            bool? au_ = context.Operators.And(ap_, at_);
            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            bool? az_ = context.Operators.OverlapsBefore(aw_, ay_, default);
            bool? ba_ = context.Operators.Or(au_, az_);
            CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            bool? bf_ = context.Operators.OverlapsBefore(bc_, be_, default);
            bool? bg_ = context.Operators.Or(ba_, bf_);
            CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime bj_ = context.Operators.Start(bi_);
            CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime bm_ = context.Operators.Start(bl_);
            bool? bn_ = context.Operators.SameAs(bj_, bm_, default);
            bool? bo_ = context.Operators.Or(bg_, bn_);
            bool? bp_ = context.Operators.And(ac_, bo_);
            return bp_;
        }

        IEnumerable<Encounter.LocationComponent> h_ = context.Operators.Where<Encounter.LocationComponent>(f_, g_);

        CqlDateTime i_(Encounter.LocationComponent Location) {
            Period cb_ = Location?.Period;
            CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
            CqlDateTime cd_ = context.Operators.End(cc_);
            return cd_;
        }

        IEnumerable<CqlDateTime> j_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(h_, i_);
        IEnumerable<CqlDateTime> k_ = context.Operators.Distinct<CqlDateTime>(j_);
        IEnumerable<CqlDateTime> l_ = context.Operators.ListSort<CqlDateTime>(k_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime m_ = context.Operators.Last<CqlDateTime>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4802016707100171808L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);

            bool? b_(Encounter EDEncounter) {
                CqlDateTime d_ = this.TransferDecisionUsingOrder(context, EDEncounter);
                CqlDateTime e_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity f_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime g_ = context.Operators.Subtract(e_, f_);
                bool? h_ = context.Operators.SameOrBefore(d_, g_, default);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Observation Status")]
    public IEnumerable<Encounter> ED_Observation_Status(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3174661449234294770L, () => {
            CqlValueSet a_ = this.Observation_Services(context);
            IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            IEnumerable<Encounter> c_(Encounter EDObsEncounter) {
                IEnumerable<Encounter> e_ = this.Denominator(context);

                bool? f_(Encounter EDStay) {
                    Period j_ = EDStay?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                    Period l_ = EDObsEncounter?.Period;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                    bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
                    Code<Encounter.EncounterStatus> o_ = EDObsEncounter?.StatusElement;
                    Encounter.EncounterStatus? p_ = o_?.Value;
                    Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                    bool? r_ = context.Operators.Equal(q_, "finished");
                    bool? s_ = context.Operators.And(n_, r_);
                    return s_;
                }

                IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
                Encounter h_(Encounter EDStay) => EDObsEncounter;
                IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);
                return i_;
            }

            IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);
            return d_;
        });


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-4226279180473333178L, () => {
            IEnumerable<Encounter> a_ = this.Boarded_Time_Greater_Than_240_Minutes(context);

            bool? b_(Encounter Boarding) {
                IEnumerable<Encounter> d_ = this.ED_Observation_Status(context);

                bool? e_(Encounter EDObs) {
                    Period i_ = Boarding?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    Period k_ = EDObs?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);
                    return m_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                bool? g_ = context.Operators.Exists<Encounter>(f_);
                bool? h_ = context.Operators.Not(g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-8869778249275384935L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);

            bool? b_(Encounter EDEncounter) {
                CqlDateTime d_ = this.edArrivalTime(context, EDEncounter);
                CqlDateTime e_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity f_ = context.Operators.Quantity(481m, "minutes");
                CqlDateTime g_ = context.Operators.Subtract(e_, f_);
                bool? h_ = context.Operators.SameOrBefore(d_, g_, default);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2595766680658610855L, () => {
            IEnumerable<Encounter> a_ = this.ED_Length_of_Stay_Greater_Than_480_Minutes(context);

            bool? b_(Encounter EDStay) {
                IEnumerable<Encounter> d_ = this.ED_Observation_Status(context);

                bool? e_(Encounter EDObs) {
                    Period i_ = EDStay?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    Period k_ = EDObs?.Period;
                    CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                    bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);
                    return m_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                bool? g_ = context.Operators.Exists<Encounter>(f_);
                bool? h_ = context.Operators.Not(g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-6480006813910541237L, () => {
            IEnumerable<Encounter> a_ = this.Time_to_Treatment_Room_Greater_Than_60_Minutes(context);
            IEnumerable<Encounter> b_ = this.ED_Arrival_Left_Without_Being_Seen(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            IEnumerable<Encounter> d_ = this.Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(context);
            IEnumerable<Encounter> e_ = this.ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(context);
            IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
            IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
            return g_;
        });


    [CqlExpressionDefinition("ED Encounter or Triage of Patients Less Than 18 Years")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-4066828078593406830L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);

            bool? b_(Encounter EDEncounter) {
                Patient d_ = this.Patient(context);
                Date e_ = d_?.BirthDateElement;
                string f_ = e_?.Value;
                CqlDate g_ = context.Operators.ConvertStringToDate(f_);
                Period h_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDate k_ = context.Operators.DateFrom(j_);
                int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
                bool? m_ = context.Operators.Less(l_, 18);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Pediatric With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(6925969516884632854L, () => {
            IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);

            bool? b_(Encounter PediatricEDEncounters) {
                CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
                bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, PediatricEDEncounters, d_);
                bool? f_ = context.Operators.Not(e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("ED Encounter or Triage of Patients 18 Years and Older")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2761135118601636291L, () => {
            IEnumerable<Encounter> a_ = this.Denominator(context);

            bool? b_(Encounter EDEncounter) {
                Patient d_ = this.Patient(context);
                Date e_ = d_?.BirthDateElement;
                string f_ = e_?.Value;
                CqlDate g_ = context.Operators.ConvertStringToDate(f_);
                Period h_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDate k_ = context.Operators.DateFrom(j_);
                int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
                bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Adult With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Adult_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-1981226566269198758L, () => {
            IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);

            bool? b_(Encounter AdultEDEncounters) {
                CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
                bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, AdultEDEncounters, d_);
                bool? f_ = context.Operators.Not(e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Pediatric With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_Mental_Health_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(5036533695592859252L, () => {
            IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);

            bool? b_(Encounter PediatricEDEncounters) {
                CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
                bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, PediatricEDEncounters, d_);
                return e_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Adult With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Adult_With_Mental_Health_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(437003468821603595L, () => {
            IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);

            bool? b_(Encounter AdultEDEncounters) {
                CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
                bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, AdultEDEncounters, d_);
                return e_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(5651699758766434310L, () => {
            IEnumerable<Encounter> a_ = this.Pediatric_With_No_Mental_Health_Diagnosis(context);
            return a_;
        });


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(1157011799875292337L, () => {
            IEnumerable<Encounter> a_ = this.Adult_With_No_Mental_Health_Diagnosis(context);
            return a_;
        });


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(37973682128726921L, () => {
            IEnumerable<Encounter> a_ = this.Pediatric_With_Mental_Health_Diagnosis(context);
            return a_;
        });


    [CqlExpressionDefinition("Stratification 4")]
    public IEnumerable<Encounter> Stratification_4(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4938437133017742234L, () => {
            IEnumerable<Encounter> a_ = this.Adult_With_Mental_Health_Diagnosis(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-5452485751526775804L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-2152427511355141904L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-1270621774348447459L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-1991679763806615112L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1264FHIRECATREHQR_1_0_000() {}

    public static CMS1264FHIRECATREHQR_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1264FHIRECATREHQR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
