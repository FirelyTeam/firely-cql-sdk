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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS1244FHIRECATHOQR", "1.0.000")]
public partial class CMS1244FHIRECATHOQR_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS1244FHIRECATHOQR_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Admit Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.164", valueSetVersion: null)]
    public CqlValueSet Admit_Inpatient(CqlContext _) => _Admit_Inpatient;
    private static readonly CqlValueSet _Admit_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.164", null);

    [CqlValueSetDefinition("Mental Health Diagnosis without Substance Use Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", valueSetVersion: null)]
    public CqlValueSet Mental_Health_Diagnosis_without_Substance_Use_Disorders(CqlContext _) => _Mental_Health_Diagnosis_without_Substance_Use_Disorders;
    private static readonly CqlValueSet _Mental_Health_Diagnosis_without_Substance_Use_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", null);

    [CqlValueSetDefinition("Decision to Admit to Hospital Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.294", valueSetVersion: null)]
    public CqlValueSet Decision_to_Admit_to_Hospital_Inpatient(CqlContext _) => _Decision_to_Admit_to_Hospital_Inpatient;
    private static readonly CqlValueSet _Decision_to_Admit_to_Hospital_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.294", null);

    [CqlValueSetDefinition("Emergency Department Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.163", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation(CqlContext _) => _Emergency_Department_Evaluation;
    private static readonly CqlValueSet _Emergency_Department_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.163", null);

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

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", valueSetVersion: null)]
    public CqlValueSet Triage(CqlContext _) => _Triage;
    private static readonly CqlValueSet _Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", null);

    #endregion ValueSets

    #region Codes (4)

    [CqlCodeDefinition("Patient bed assigned (finding)", codeId: "5751000175101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_bed_assigned__finding_(CqlContext _) => _Patient_bed_assigned__finding_;
    private static readonly CqlCode _Patient_bed_assigned__finding_ = new CqlCode("5751000175101", "http://snomed.info/sct");

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

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Patient_bed_assigned__finding_,
          _Patient_left_without_being_seen__finding_]);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _Emergency_room,
          _Emergency_trauma_unit]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1244FHIRECATHOQR-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (45)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ED Evaluation and Management")]
    public IEnumerable<Encounter> ED_Evaluation_and_Management(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Evaluation_and_Management, ED_Evaluation_and_Management_Compute, context) ?? ED_Evaluation_and_Management_Compute(context);

    private IEnumerable<Encounter> ED_Evaluation_and_Management_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("ED Triage")]
    public IEnumerable<Encounter> ED_Triage(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Triage, ED_Triage_Compute, context) ?? ED_Triage_Compute(context);

    private IEnumerable<Encounter> ED_Triage_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("ED Triage Excluding Those Prior To ED Encounters")]
    public IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters, ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute, context) ?? ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute(context);

    private IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage(context);

        bool? b_(Encounter EDTriageinMP) {
            IEnumerable<Encounter> d_ = this.ED_Evaluation_and_Management(context);

            bool? e_(Encounter EDEvalManagementInMP) {
                Period i_ = EDTriageinMP?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                Period k_ = EDEvalManagementInMP?.Period;
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
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);
        IEnumerable<Encounter> b_ = this.ED_Triage_Excluding_Those_Prior_To_ED_Encounters(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


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
        _cache?.GetOrCompute(_cacheIndex_ED_Triage_Before_Evaluation_Management, ED_Triage_Before_Evaluation_Management_Compute, context) ?? ED_Triage_Before_Evaluation_Management_Compute(context);

    private IEnumerable<Encounter> ED_Triage_Before_Evaluation_Management_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("ED Triage and Evaluation Management")]
    public IEnumerable<Encounter> ED_Triage_and_Evaluation_Management(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Triage_and_Evaluation_Management, ED_Triage_and_Evaluation_Management_Compute, context) ?? ED_Triage_and_Evaluation_Management_Compute(context);

    private IEnumerable<Encounter> ED_Triage_and_Evaluation_Management_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Encounter> b_ = this.ED_Triage_Before_Evaluation_Management(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


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
        _cache?.GetOrCompute(_cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes, Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute, context) ?? Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute(context);

    private IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);

        bool? b_(Encounter EDEvalManagementInMP) {
            CqlDateTime d_ = this.edArrivalTime(context, EDEvalManagementInMP);
            CqlDateTime e_ = this.edTreatmentRoomTimeArrivalTime(context, EDEvalManagementInMP);
            CqlQuantity f_ = context.Operators.Quantity(61m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, default);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Arrival Left Without Being Seen")]
    public IEnumerable<Encounter> ED_Arrival_Left_Without_Being_Seen(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Arrival_Left_Without_Being_Seen, ED_Arrival_Left_Without_Being_Seen_Compute, context) ?? ED_Arrival_Left_Without_Being_Seen_Compute(context);

    private IEnumerable<Encounter> ED_Arrival_Left_Without_Being_Seen_Compute(CqlContext context)
    {
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
    }


    [CqlFunctionDefinition("admitDecisionUsingEncounterOrder")]
    public CqlDateTime admitDecisionUsingEncounterOrder(CqlContext context, Encounter EncounterInpatient)
    {
        IEnumerable<ServiceRequest> a_ = this.ED_To_Inpatient_Order(context);

        bool? b_(ServiceRequest AdmitOrder) {
            FhirDateTime i_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            Encounter k_ = this.lastEDEncounter(context, EncounterInpatient);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(j_, m_, default);
            Code<RequestIntent> o_ = AdmitOrder?.IntentElement;
            RequestIntent? p_ = o_?.Value;
            Code<RequestIntent> q_ = context.Operators.Convert<Code<RequestIntent>>(p_);
            bool? r_ = context.Operators.Equivalent(q_, "order");
            bool? s_ = context.Operators.And(n_, r_);
            return s_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        CqlDateTime d_(ServiceRequest AdmitOrder) {
            FhirDateTime t_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
            return u_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<ServiceRequest, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("ED To Inpatient Order")]
    public IEnumerable<ServiceRequest> ED_To_Inpatient_Order(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_To_Inpatient_Order, ED_To_Inpatient_Order_Compute, context) ?? ED_To_Inpatient_Order_Compute(context);

    private IEnumerable<ServiceRequest> ED_To_Inpatient_Order_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Decision_to_Admit_to_Hospital_Inpatient(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest AdmitIPOrder) {
            Code<RequestStatus> e_ = AdmitIPOrder?.StatusElement;
            RequestStatus? f_ = e_?.Value;
            Code<RequestStatus> g_ = context.Operators.Convert<Code<RequestStatus>>(f_);
            string h_ = context.Operators.Convert<string>(g_);
            string[] i_ = [
                "active",
                "completed",
            ];
            bool? j_ = context.Operators.In<string>(h_, (IEnumerable<string>)i_);
            return j_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("lastEDEncounter")]
    public Encounter lastEDEncounter(CqlContext context, Encounter EncounterInpatient)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);

        bool? b_(Encounter EDEvalManagementInMP) {
            Period g_ = EDEvalManagementInMP?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlDateTime i_ = context.Operators.Start(h_);
            Period j_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlQuantity m_ = context.Operators.Quantity(1m, "day");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = context.Operators.Interval(n_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDateTime>(i_, r_, default);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
            CqlDateTime v_ = context.Operators.Start(u_);
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            bool? x_ = context.Operators.And(s_, w_);
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            bool? ae_ = context.Operators.Before(aa_, ad_, default);
            bool? af_ = context.Operators.And(x_, ae_);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, ai_, "day");
            bool? ak_ = context.Operators.And(af_, aj_);
            Code<Encounter.EncounterStatus> al_ = EDEvalManagementInMP?.StatusElement;
            Encounter.EncounterStatus? am_ = al_?.Value;
            Code<Encounter.EncounterStatus> an_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(am_);
            bool? ao_ = context.Operators.Equal(an_, "finished");
            bool? ap_ = context.Operators.And(ak_, ao_);
            return ap_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        object d_(Encounter @this) {
            Period aq_ = @this?.Period;
            CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
            CqlDateTime as_ = context.Operators.End(ar_);
            return as_;
        }

        IEnumerable<Encounter> e_ = context.Operators.SortBy<Encounter>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter f_ = context.Operators.Last<Encounter>(e_);
        return f_;
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


    [CqlExpressionDefinition("Decision to Admit Encounter Order")]
    public IEnumerable<Encounter> Decision_to_Admit_Encounter_Order(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Decision_to_Admit_Encounter_Order, Decision_to_Admit_Encounter_Order_Compute, context) ?? Decision_to_Admit_Encounter_Order_Compute(context);

    private IEnumerable<Encounter> Decision_to_Admit_Encounter_Order_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        IEnumerable<Encounter> b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter EncounterInpatient) {
                CqlDateTime i_ = this.admitDecisionUsingEncounterOrder(context, EncounterInpatient);
                CqlDateTime j_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter EncounterInpatient) => EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("admitDecisionUsingAssessment")]
    public CqlDateTime admitDecisionUsingAssessment(CqlContext context, Encounter EncounterInpatient)
    {
        IEnumerable<object> a_ = this.Assessment_In_ED(context);

        bool? b_(object EDEvaluation) {
            object i_ = context.Operators.LateBoundProperty<object>(EDEvaluation, "effective");
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            CqlDateTime l_ = context.Operators.Start(k_);
            Encounter m_ = this.lastEDEncounter(context, EncounterInpatient);
            Period n_ = m_?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            bool? p_ = context.Operators.In<CqlDateTime>(l_, o_, default);
            object q_ = context.Operators.LateBoundProperty<object>(EDEvaluation, "status");
            string r_ = context.Operators.LateBoundProperty<string>(q_, "value");
            string[] s_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            bool? u_ = context.Operators.And(p_, t_);
            return u_;
        }

        IEnumerable<object> c_ = context.Operators.Where<object>(a_, b_);

        CqlDateTime d_(object EDEvaluation) {
            object v_ = context.Operators.LateBoundProperty<object>(EDEvaluation, "effective");
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            return y_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<object, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Assessment In ED")]
    public IEnumerable<object> Assessment_In_ED(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Assessment_In_ED, Assessment_In_ED_Compute, context) ?? Assessment_In_ED_Compute(context);

    private IEnumerable<object> Assessment_In_ED_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? e_(Observation ObsInED) {
            DataType h_ = ObsInED?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlValueSet j_ = this.Admit_Inpatient(context);
            bool? k_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, j_);
            return k_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        IEnumerable<object> g_ = context.Operators.Union<object>(b_ as IEnumerable<object>, f_ as IEnumerable<object>);
        return g_;
    }


    [CqlExpressionDefinition("Decision to Admit Using Assessment")]
    public IEnumerable<Encounter> Decision_to_Admit_Using_Assessment(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Decision_to_Admit_Using_Assessment, Decision_to_Admit_Using_Assessment_Compute, context) ?? Decision_to_Admit_Using_Assessment_Compute(context);

    private IEnumerable<Encounter> Decision_to_Admit_Using_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        IEnumerable<Encounter> b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter EncounterInpatient) {
                CqlDateTime i_ = this.admitDecisionUsingAssessment(context, EncounterInpatient);
                CqlDateTime j_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter EncounterInpatient) => EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("admitInpatientOrBedAssignmentEncounterOrder")]
    public CqlDateTime admitInpatientOrBedAssignmentEncounterOrder(CqlContext context, Encounter Encounter)
    {
        IEnumerable<ServiceRequest> a_ = this.Inpatient_Or_Bed_Assignment_Encounter_Order(context);

        bool? b_(ServiceRequest AdmitInpatientOrder) {
            FhirDateTime i_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            Encounter k_ = this.lastEDEncounter(context, Encounter);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(j_, m_, default);
            return n_;
        }

        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);

        CqlDateTime d_(ServiceRequest AdmitInpatientOrder) {
            FhirDateTime o_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
            return p_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<ServiceRequest, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Inpatient Or Bed Assignment Encounter Order")]
    public IEnumerable<ServiceRequest> Inpatient_Or_Bed_Assignment_Encounter_Order(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Inpatient_Or_Bed_Assignment_Encounter_Order, Inpatient_Or_Bed_Assignment_Encounter_Order_Compute, context) ?? Inpatient_Or_Bed_Assignment_Encounter_Order_Compute(context);

    private IEnumerable<ServiceRequest> Inpatient_Or_Bed_Assignment_Encounter_Order_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode c_ = this.Patient_bed_assigned__finding_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(b_, e_);

        bool? g_(ServiceRequest IPRequest) {
            Code<RequestStatus> i_ = IPRequest?.StatusElement;
            RequestStatus? j_ = i_?.Value;
            Code<RequestStatus> k_ = context.Operators.Convert<Code<RequestStatus>>(j_);
            string l_ = context.Operators.Convert<string>(k_);
            string[] m_ = [
                "active",
                "completed",
            ];
            bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
            return n_;
        }

        IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Time of Admit Order Or Bed Assignment to Departure Greater Than 241 Minutes")]
    public IEnumerable<Encounter> Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes, Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes_Compute, context) ?? Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes_Compute(context);

    private IEnumerable<Encounter> Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        IEnumerable<Encounter> b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter InpatientEncounter) {
                CqlDateTime i_ = this.admitInpatientOrBedAssignmentEncounterOrder(context, InpatientEncounter);
                CqlDateTime j_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter InpatientEncounter) => EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("holdingInEDAfterAdmission")]
    public CqlDateTime holdingInEDAfterAdmission(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter AdmittedInpatient) {
            Period i_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            Encounter l_ = this.lastEDEncounter(context, InpatientEncounter);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            bool? o_ = context.Operators.In<CqlDateTime>(k_, n_, default);
            return o_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        CqlDateTime d_(Encounter AdmittedInpatient) {
            Period p_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            return r_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Admitted to Inpatient 241 Minutes or More Before Departure")]
    public IEnumerable<Encounter> Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure, Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure_Compute, context) ?? Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure_Compute(context);

    private IEnumerable<Encounter> Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        IEnumerable<Encounter> b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter Inpatient) {
                CqlDateTime i_ = this.holdingInEDAfterAdmission(context, Inpatient);
                CqlDateTime j_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter Inpatient) => EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Boarded_Time_Greater_Than_240_Minutes, Boarded_Time_Greater_Than_240_Minutes_Compute, context) ?? Boarded_Time_Greater_Than_240_Minutes_Compute(context);

    private IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Decision_to_Admit_Encounter_Order(context);
        IEnumerable<Encounter> b_ = this.Decision_to_Admit_Using_Assessment(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes(context);
        IEnumerable<Encounter> e_ = this.Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("ED Observation Status")]
    public IEnumerable<Encounter> ED_Observation_Status(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Observation_Status, ED_Observation_Status_Compute, context) ?? ED_Observation_Status_Compute(context);

    private IEnumerable<Encounter> ED_Observation_Status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Observation_Services(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        IEnumerable<Encounter> c_(Encounter EDObsEncounter) {
            IEnumerable<Encounter> e_ = this.Denominator(context);

            bool? f_(Encounter EDEncounter) {
                Period j_ = EDEncounter?.Period;
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
            Encounter h_(Encounter EDEncounter) => EDObsEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay, Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay_Compute, context) ?? Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay_Compute(context);

    private IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes, ED_Length_of_Stay_Greater_Than_480_Minutes_Compute, context) ?? ED_Length_of_Stay_Greater_Than_480_Minutes_Compute(context);

    private IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay, ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay_Compute, context) ?? ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay_Compute(context);

    private IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Time_to_Treatment_Room_Greater_Than_60_Minutes(context);
        IEnumerable<Encounter> b_ = this.ED_Arrival_Left_Without_Being_Seen(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(context);
        IEnumerable<Encounter> e_ = this.ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("ED Encounter or Triage of Patients Less Than 18 Years")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years, ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years_Compute, context) ?? ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years_Compute(context);

    private IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            bool? l_ = context.Operators.Less(k_, 18);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pediatric With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis, Pediatric_With_No_Mental_Health_Diagnosis_Compute, context) ?? Pediatric_With_No_Mental_Health_Diagnosis_Compute(context);

    private IEnumerable<Encounter> Pediatric_With_No_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);

        bool? b_(Encounter PediatricEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, PediatricEDEncounters, d_);
            bool? f_ = context.Operators.Not(e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter or Triage of Patients 18 Years and Older")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older, ED_Encounter_or_Triage_of_Patients_18_Years_and_Older_Compute, context) ?? ED_Encounter_or_Triage_of_Patients_18_Years_and_Older_Compute(context);

    private IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            bool? l_ = context.Operators.GreaterOrEqual(k_, 18);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Adult With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Adult_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Adult_With_No_Mental_Health_Diagnosis, Adult_With_No_Mental_Health_Diagnosis_Compute, context) ?? Adult_With_No_Mental_Health_Diagnosis_Compute(context);

    private IEnumerable<Encounter> Adult_With_No_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);

        bool? b_(Encounter AdultEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, AdultEDEncounters, d_);
            bool? f_ = context.Operators.Not(e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pediatric With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_Mental_Health_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Pediatric_With_Mental_Health_Diagnosis, Pediatric_With_Mental_Health_Diagnosis_Compute, context) ?? Pediatric_With_Mental_Health_Diagnosis_Compute(context);

    private IEnumerable<Encounter> Pediatric_With_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);

        bool? b_(Encounter PediatricEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, PediatricEDEncounters, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Adult With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Adult_With_Mental_Health_Diagnosis(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Adult_With_Mental_Health_Diagnosis, Adult_With_Mental_Health_Diagnosis_Compute, context) ?? Adult_With_Mental_Health_Diagnosis_Compute(context);

    private IEnumerable<Encounter> Adult_With_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);

        bool? b_(Encounter AdultEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, AdultEDEncounters, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public IEnumerable<Encounter> Stratification_1(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute, context) ?? Stratification_1_Compute(context);

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute, context) ?? Stratification_2_Compute(context);

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute, context) ?? Stratification_3_Compute(context);

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 4")]
    public IEnumerable<Encounter> Stratification_4(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Stratification_4, Stratification_4_Compute, context) ?? Stratification_4_Compute(context);

    private IEnumerable<Encounter> Stratification_4_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (38)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_ED_Evaluation_and_Management = -1;
    private int _cacheIndex_ED_Triage = -1;
    private int _cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_ED_Triage_Before_Evaluation_Management = -1;
    private int _cacheIndex_ED_Triage_and_Evaluation_Management = -1;
    private int _cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes = -1;
    private int _cacheIndex_ED_Arrival_Left_Without_Being_Seen = -1;
    private int _cacheIndex_ED_To_Inpatient_Order = -1;
    private int _cacheIndex_Decision_to_Admit_Encounter_Order = -1;
    private int _cacheIndex_Assessment_In_ED = -1;
    private int _cacheIndex_Decision_to_Admit_Using_Assessment = -1;
    private int _cacheIndex_Inpatient_Or_Bed_Assignment_Encounter_Order = -1;
    private int _cacheIndex_Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes = -1;
    private int _cacheIndex_Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure = -1;
    private int _cacheIndex_Boarded_Time_Greater_Than_240_Minutes = -1;
    private int _cacheIndex_ED_Observation_Status = -1;
    private int _cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay = -1;
    private int _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes = -1;
    private int _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years = -1;
    private int _cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis = -1;
    private int _cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older = -1;
    private int _cacheIndex_Adult_With_No_Mental_Health_Diagnosis = -1;
    private int _cacheIndex_Pediatric_With_Mental_Health_Diagnosis = -1;
    private int _cacheIndex_Adult_With_Mental_Health_Diagnosis = -1;
    private int _cacheIndex_Stratification_1 = -1;
    private int _cacheIndex_Stratification_2 = -1;
    private int _cacheIndex_Stratification_3 = -1;
    private int _cacheIndex_Stratification_4 = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_ED_Evaluation_and_Management = index++;
        _cacheIndex_ED_Triage = index++;
        _cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_ED_Triage_Before_Evaluation_Management = index++;
        _cacheIndex_ED_Triage_and_Evaluation_Management = index++;
        _cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes = index++;
        _cacheIndex_ED_Arrival_Left_Without_Being_Seen = index++;
        _cacheIndex_ED_To_Inpatient_Order = index++;
        _cacheIndex_Decision_to_Admit_Encounter_Order = index++;
        _cacheIndex_Assessment_In_ED = index++;
        _cacheIndex_Decision_to_Admit_Using_Assessment = index++;
        _cacheIndex_Inpatient_Or_Bed_Assignment_Encounter_Order = index++;
        _cacheIndex_Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes = index++;
        _cacheIndex_Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure = index++;
        _cacheIndex_Boarded_Time_Greater_Than_240_Minutes = index++;
        _cacheIndex_ED_Observation_Status = index++;
        _cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay = index++;
        _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes = index++;
        _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years = index++;
        _cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis = index++;
        _cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older = index++;
        _cacheIndex_Adult_With_No_Mental_Health_Diagnosis = index++;
        _cacheIndex_Pediatric_With_Mental_Health_Diagnosis = index++;
        _cacheIndex_Adult_With_Mental_Health_Diagnosis = index++;
        _cacheIndex_Stratification_1 = index++;
        _cacheIndex_Stratification_2 = index++;
        _cacheIndex_Stratification_3 = index++;
        _cacheIndex_Stratification_4 = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS1244FHIRECATHOQR_1_0_000() {}

    public static CMS1244FHIRECATHOQR_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1244FHIRECATHOQR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}
