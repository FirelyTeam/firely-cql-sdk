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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("CMS1264FHIRECATREHQR", "1.0.000")]
public partial class CMS1264FHIRECATREHQR_1_0_000 : ILibrary, ISingleton<CMS1264FHIRECATREHQR_1_0_000>
{
    #region ValueSets (7)

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

    #region Codes (3)

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
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3771323338948774042L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1264FHIRECATREHQR-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (34)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1014495218581176614L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ED Evaluation and Management")]
    public IEnumerable<Encounter> ED_Evaluation_and_Management(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Evaluation_and_Management, ED_Evaluation_and_Management_Compute);

    private const long _cacheIndex_ED_Evaluation_and_Management = -3741547166926209002L;

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
            // CQL 'and' (92:5-93:51): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> j_ = EDEvalManagementVisit?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                bool? m_ = context.Operators.Equal(l_, "finished");
                return i_ & m_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("ED Triage")]
    public IEnumerable<Encounter> ED_Triage(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Triage, ED_Triage_Compute);

    private const long _cacheIndex_ED_Triage = -2370023395528382226L;

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
            // CQL 'and' (122:5-123:54): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> j_ = EDTriage?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                string m_ = context.Operators.Convert<string>(l_);
                string[] n_ = [
                    "finished",
                    "triaged",
                ];
                bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                return i_ & o_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("ED Triage Excluding Those Prior To ED Encounters")]
    public IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters, ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute);

    private const long _cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters = 3996380737021184409L;

    private IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage(context);

        bool? b_(Encounter EDTriageinMP) {
            IEnumerable<Encounter> d_ = this.ED_Evaluation_and_Management(context);

            bool? e_(Encounter EDEvalManagementinMP) {
                Period g_ = EDTriageinMP?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EDEvalManagementinMP?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.OverlapsBefore(h_, j_, (string)default);
                bool? l_;
                // CQL 'or' (128:17-129:73): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    Period n_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                    Period p_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
                    l_ = k_ | r_;
                }
                bool? m_;
                // CQL 'or' (128:17-130:73): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    Period s_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                    Period u_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, (string)default);
                    m_ = l_ | w_;
                }
                // CQL 'or' (128:9-132:9): right operand skipped when left is true
                if (m_ is true)
                {
                    return true;
                }
                else
                {
                    Period x_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    CqlDateTime z_ = context.Operators.End(y_);
                    Period aa_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlQuantity ad_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ae_, ac_, true, false);
                    bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, (string)default);
                    bool? ah_;
                    // CQL 'and' (131:16-131:107): right operand skipped when left is false
                    if (ag_ is false)
                    {
                        ah_ = false;
                    }
                    else
                    {
                        Period ai_ = EDEvalManagementinMP?.Period;
                        CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                        CqlDateTime ak_ = context.Operators.Start(aj_);
                        ah_ = ag_ & (!((bool?)(ak_ is null)));
                    }
                    return m_ | ah_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return !f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7666571774031925247L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);
        IEnumerable<Encounter> b_ = this.ED_Triage_Excluding_Those_Prior_To_ED_Encounters(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 5243972692210139206L;

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
            List<Encounter.LocationComponent> l_ = @this?.Location;
            return !((bool?)(l_ is null));
        }


        List<Encounter.LocationComponent> c_(Encounter @this) {
            List<Encounter.LocationComponent> m_ = @this?.Location;
            return m_;
        }

        IEnumerable<List<Encounter.LocationComponent>> d_ = context.Operators.WhereSelect<Encounter, List<Encounter.LocationComponent>>(a_, b_, c_);
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)d_);

        bool? f_(Encounter.LocationComponent Location) {
            ResourceReference n_ = Location?.Location;
            Location o_ = CQMCommon_4_1_000.Instance.getLocation(context, n_);
            List<CodeableConcept> p_ = o_?.Type;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }


            bool? r_(CqlConcept LocationType) {
                CqlValueSet w_ = this.Emergency_Department_Location(context);
                bool? x_ = context.Operators.ConceptInValueSet(LocationType, w_);
                bool? y_;
                // CQL 'or' (155:17-156:48): right operand skipped when left is true
                if (x_ is true)
                {
                    y_ = true;
                }
                else
                {
                    CqlCode z_ = this.Emergency_room(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    bool? ab_ = context.Operators.Equivalent(LocationType, aa_);
                    y_ = x_ | ab_;
                }
                // CQL 'or' (155:11-158:11): right operand skipped when left is true
                if (y_ is true)
                {
                    return true;
                }
                else
                {
                    CqlCode ac_ = this.Emergency_trauma_unit(context);
                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                    bool? ae_ = context.Operators.Equivalent(LocationType, ad_);
                    return y_ | ae_;
                }
            }

            IEnumerable<CqlConcept> s_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_, r_);
            bool? t_ = context.Operators.Exists<CqlConcept>(s_);
            bool? u_;
            // CQL 'and' (154:13-160:48): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                Period af_ = Location?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                u_ = t_ & (!((bool?)(ah_ is null)));
            }
            // CQL 'and' (154:7-165:9): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Period ai_ = Location?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.End(aj_);
                Period al_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlQuantity ao_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, an_, true, false);
                bool? ar_ = context.Operators.In<CqlDateTime>(ak_, aq_, (string)default);
                bool? as_;
                // CQL 'and' (161:13-161:87): right operand skipped when left is false
                if (ar_ is false)
                {
                    as_ = false;
                }
                else
                {
                    Period aw_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    as_ = ar_ & (!((bool?)(ay_ is null)));
                }
                bool? at_;
                // CQL 'or' (161:13-162:65): right operand skipped when left is true
                if (as_ is true)
                {
                    at_ = true;
                }
                else
                {
                    Period az_ = Location?.Period;
                    CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
                    Period bb_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                    bool? bd_ = context.Operators.OverlapsBefore(ba_, bc_, (string)default);
                    at_ = as_ | bd_;
                }
                bool? au_;
                // CQL 'or' (161:13-163:65): right operand skipped when left is true
                if (at_ is true)
                {
                    au_ = true;
                }
                else
                {
                    Period be_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                    Period bg_ = Location?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                    bool? bi_ = context.Operators.OverlapsBefore(bf_, bh_, (string)default);
                    au_ = at_ | bi_;
                }
                bool? av_;
                // CQL 'or' (161:12-165:9): right operand skipped when left is true
                if (au_ is true)
                {
                    av_ = true;
                }
                else
                {
                    Period bj_ = Location?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    Period bm_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    CqlDateTime bo_ = context.Operators.Start(bn_);
                    bool? bp_ = context.Operators.SameAs(bl_, bo_, (string)default);
                    av_ = au_ | bp_;
                }
                return u_ & av_;
            }
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period bq_ = Location?.Period;
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
            CqlDateTime bs_ = context.Operators.Start(br_);
            return bs_;
        }

        IEnumerable<CqlDateTime> h_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>(e_, f_, g_);
        IEnumerable<CqlDateTime> i_ = context.Operators.Distinct<CqlDateTime>(h_);
        IEnumerable<CqlDateTime> j_ = context.Operators.ListSort<CqlDateTime>(i_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime k_ = context.Operators.Last<CqlDateTime>(j_);
        return k_;
    }


    [CqlExpressionDefinition("ED Triage Before Evaluation Management")]
    public IEnumerable<Encounter> ED_Triage_Before_Evaluation_Management(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Triage_Before_Evaluation_Management, ED_Triage_Before_Evaluation_Management_Compute);

    private const long _cacheIndex_ED_Triage_Before_Evaluation_Management = 4085492043442645098L;

    private IEnumerable<Encounter> ED_Triage_Before_Evaluation_Management_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage(context);

        bool? b_(Encounter EDTriageinMP) {
            IEnumerable<Encounter> d_ = this.Denominator(context);

            bool? e_(Encounter EDEncounter) {
                Period g_ = EDTriageinMP?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.OverlapsBefore(h_, j_, (string)default);
                bool? l_;
                // CQL 'or' (138:19-139:62): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    Period n_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                    Period p_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                    bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
                    l_ = k_ | r_;
                }
                bool? m_;
                // CQL 'or' (138:19-140:62): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    Period s_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                    Period u_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, (string)default);
                    m_ = l_ | w_;
                }
                // CQL 'or' (138:17-142:7): right operand skipped when left is true
                if (m_ is true)
                {
                    return true;
                }
                else
                {
                    Period x_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    CqlDateTime z_ = context.Operators.End(y_);
                    Period aa_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlQuantity ad_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ae_, ac_, true, false);
                    bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, (string)default);
                    bool? ah_;
                    // CQL 'and' (141:14-141:96): right operand skipped when left is false
                    if (ag_ is false)
                    {
                        ah_ = false;
                    }
                    else
                    {
                        Period ai_ = EDEncounter?.Period;
                        CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                        CqlDateTime ak_ = context.Operators.Start(aj_);
                        ah_ = ag_ & (!((bool?)(ak_ is null)));
                    }
                    return m_ | ah_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Triage and Evaluation Management")]
    public IEnumerable<Encounter> ED_Triage_and_Evaluation_Management(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Triage_and_Evaluation_Management, ED_Triage_and_Evaluation_Management_Compute);

    private const long _cacheIndex_ED_Triage_and_Evaluation_Management = -3748220850778708280L;

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
            ResourceReference h_ = Location?.Location;
            Location i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;

            CqlConcept k_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Treatment_Location(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            // CQL 'and' (192:7-193:48): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                Period p_ = Location?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                return n_ & (!((bool?)(r_ is null)));
            }
        }


        CqlDateTime c_(Encounter.LocationComponent Location) {
            Period s_ = Location?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            return u_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>((IEnumerable<Encounter.LocationComponent>)a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.First<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Time to Treatment Room Greater Than 60 Minutes")]
    public IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes, Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute);

    private const long _cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes = 635040179997437826L;

    private IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);

        bool? b_(Encounter EDEvalManagementinMP) {
            CqlDateTime d_ = this.edArrivalTime(context, EDEvalManagementinMP);
            CqlDateTime e_ = this.edTreatmentRoomTimeArrivalTime(context, EDEvalManagementinMP);
            CqlQuantity f_ = context.Operators.Quantity(61m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, (string)default);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Arrival Left Without Being Seen")]
    public IEnumerable<Encounter> ED_Arrival_Left_Without_Being_Seen(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Arrival_Left_Without_Being_Seen, ED_Arrival_Left_Without_Being_Seen_Compute);

    private const long _cacheIndex_ED_Arrival_Left_Without_Being_Seen = -4285098943622379315L;

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


    [CqlFunctionDefinition("TransferDecisionUsingOrder")]
    public CqlDateTime TransferDecisionUsingOrder(CqlContext context, Encounter EDEncounter)
    {
        CqlValueSet a_ = this.Decision_to_Transfer(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest TransferOrder) {
            FhirDateTime i_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            Period k_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, (string)default);
            bool? n_;
            // CQL 'and' (200:13-201:42): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<RequestIntent> o_ = TransferOrder?.IntentElement;
                RequestIntent? p_ = o_?.Value;
                Code<RequestIntent> q_ = context.Operators.Convert<Code<RequestIntent>>(p_);
                bool? r_ = context.Operators.Equal(q_, "order");
                n_ = m_ & r_;
            }
            // CQL 'and' (200:7-202:61): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestStatus> s_ = TransferOrder?.StatusElement;
                RequestStatus? t_ = s_?.Value;
                Code<RequestStatus> u_ = context.Operators.Convert<Code<RequestStatus>>(t_);
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "active",
                    "completed",
                ];
                bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                return n_ & x_;
            }
        }


        CqlDateTime d_(ServiceRequest TransferOrder) {
            FhirDateTime y_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
            return z_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.WhereSelect<ServiceRequest, CqlDateTime>(b_, c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlFunctionDefinition("edDepartureTime")]
    public CqlDateTime edDepartureTime(CqlContext context, Encounter EDEncounter)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage_and_Evaluation_Management(context);

        bool? b_(Encounter @this) {
            List<Encounter.LocationComponent> l_ = @this?.Location;
            return !((bool?)(l_ is null));
        }


        List<Encounter.LocationComponent> c_(Encounter @this) {
            List<Encounter.LocationComponent> m_ = @this?.Location;
            return m_;
        }

        IEnumerable<List<Encounter.LocationComponent>> d_ = context.Operators.WhereSelect<Encounter, List<Encounter.LocationComponent>>(a_, b_, c_);
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)d_);

        bool? f_(Encounter.LocationComponent Location) {
            ResourceReference n_ = Location?.Location;
            Location o_ = CQMCommon_4_1_000.Instance.getLocation(context, n_);
            List<CodeableConcept> p_ = o_?.Type;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }


            bool? r_(CqlConcept LocationType) {
                CqlValueSet w_ = this.Emergency_Department_Location(context);
                bool? x_ = context.Operators.ConceptInValueSet(LocationType, w_);
                bool? y_;
                // CQL 'or' (173:17-174:48): right operand skipped when left is true
                if (x_ is true)
                {
                    y_ = true;
                }
                else
                {
                    CqlCode z_ = this.Emergency_room(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    bool? ab_ = context.Operators.Equivalent(LocationType, aa_);
                    y_ = x_ | ab_;
                }
                // CQL 'or' (173:11-176:11): right operand skipped when left is true
                if (y_ is true)
                {
                    return true;
                }
                else
                {
                    CqlCode ac_ = this.Emergency_trauma_unit(context);
                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                    bool? ae_ = context.Operators.Equivalent(LocationType, ad_);
                    return y_ | ae_;
                }
            }

            IEnumerable<CqlConcept> s_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_, r_);
            bool? t_ = context.Operators.Exists<CqlConcept>(s_);
            bool? u_;
            // CQL 'and' (172:13-179:42): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                Period af_ = Location?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                CqlDateTime ah_ = context.Operators.End(ag_);
                u_ = t_ & (!((bool?)(ah_ is null)));
            }
            // CQL 'and' (172:7-184:9): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Period ai_ = Location?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.End(aj_);
                Period al_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlQuantity ao_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, an_, true, false);
                bool? ar_ = context.Operators.In<CqlDateTime>(ak_, aq_, (string)default);
                bool? as_;
                // CQL 'and' (180:13-180:87): right operand skipped when left is false
                if (ar_ is false)
                {
                    as_ = false;
                }
                else
                {
                    Period aw_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    as_ = ar_ & (!((bool?)(ay_ is null)));
                }
                bool? at_;
                // CQL 'or' (180:13-181:65): right operand skipped when left is true
                if (as_ is true)
                {
                    at_ = true;
                }
                else
                {
                    Period az_ = Location?.Period;
                    CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
                    Period bb_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                    bool? bd_ = context.Operators.OverlapsBefore(ba_, bc_, (string)default);
                    at_ = as_ | bd_;
                }
                bool? au_;
                // CQL 'or' (180:13-182:65): right operand skipped when left is true
                if (at_ is true)
                {
                    au_ = true;
                }
                else
                {
                    Period be_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                    Period bg_ = Location?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                    bool? bi_ = context.Operators.OverlapsBefore(bf_, bh_, (string)default);
                    au_ = at_ | bi_;
                }
                bool? av_;
                // CQL 'or' (180:12-184:9): right operand skipped when left is true
                if (au_ is true)
                {
                    av_ = true;
                }
                else
                {
                    Period bj_ = Location?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    Period bm_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    CqlDateTime bo_ = context.Operators.Start(bn_);
                    bool? bp_ = context.Operators.SameAs(bl_, bo_, (string)default);
                    av_ = au_ | bp_;
                }
                return u_ & av_;
            }
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period bq_ = Location?.Period;
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
            CqlDateTime bs_ = context.Operators.End(br_);
            return bs_;
        }

        IEnumerable<CqlDateTime> h_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>(e_, f_, g_);
        IEnumerable<CqlDateTime> i_ = context.Operators.Distinct<CqlDateTime>(h_);
        IEnumerable<CqlDateTime> j_ = context.Operators.ListSort<CqlDateTime>(i_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime k_ = context.Operators.Last<CqlDateTime>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Boarded_Time_Greater_Than_240_Minutes, Boarded_Time_Greater_Than_240_Minutes_Compute);

    private const long _cacheIndex_Boarded_Time_Greater_Than_240_Minutes = 4802016707100171808L;

    private IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            CqlDateTime d_ = this.TransferDecisionUsingOrder(context, EDEncounter);
            CqlDateTime e_ = this.edDepartureTime(context, EDEncounter);
            CqlQuantity f_ = context.Operators.Quantity(241m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, (string)default);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Observation Status")]
    public IEnumerable<Encounter> ED_Observation_Status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Observation_Status, ED_Observation_Status_Compute);

    private const long _cacheIndex_ED_Observation_Status = -3174661449234294770L;

    private IEnumerable<Encounter> ED_Observation_Status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Observation_Services(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter EDObsEncounter) {
            IEnumerable<Encounter> e_ = this.Denominator(context);

            bool? f_(Encounter EDStay) {
                Period h_ = EDStay?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                Period j_ = EDObsEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, (string)default);
                // CQL 'and' (117:17-118:46): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> m_ = EDObsEncounter?.StatusElement;
                    Encounter.EncounterStatus? n_ = m_?.Value;
                    Code<Encounter.EncounterStatus> o_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(n_);
                    bool? p_ = context.Operators.Equal(o_, "finished");
                    return l_ & p_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay, Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay_Compute);

    private const long _cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay = -4226279180473333178L;

    private IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Boarded_Time_Greater_Than_240_Minutes(context);

        bool? b_(Encounter Boarding) {
            IEnumerable<Encounter> d_ = this.ED_Observation_Status(context);

            bool? e_(Encounter EDObs) {
                Period g_ = Boarding?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EDObs?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return !f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes, ED_Length_of_Stay_Greater_Than_480_Minutes_Compute);

    private const long _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes = -8869778249275384935L;

    private IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            CqlDateTime d_ = this.edArrivalTime(context, EDEncounter);
            CqlDateTime e_ = this.edDepartureTime(context, EDEncounter);
            CqlQuantity f_ = context.Operators.Quantity(481m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, (string)default);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay, ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay_Compute);

    private const long _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay = 2595766680658610855L;

    private IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Length_of_Stay_Greater_Than_480_Minutes(context);

        bool? b_(Encounter EDStay) {
            IEnumerable<Encounter> d_ = this.ED_Observation_Status(context);

            bool? e_(Encounter EDObs) {
                Period g_ = EDStay?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EDObs?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return !f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -6480006813910541237L;

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
        context.GetOrCompute(_cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years, ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years_Compute);

    private const long _cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years = -4066828078593406830L;

    private IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Pediatric With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis, Pediatric_With_No_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis = 6925969516884632854L;

    private IEnumerable<Encounter> Pediatric_With_No_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);

        bool? b_(Encounter PediatricEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, PediatricEDEncounters, d_);
            return !e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter or Triage of Patients 18 Years and Older")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older, ED_Encounter_or_Triage_of_Patients_18_Years_and_Older_Compute);

    private const long _cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older = 2761135118601636291L;

    private IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Adult With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Adult_With_No_Mental_Health_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Adult_With_No_Mental_Health_Diagnosis, Adult_With_No_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Adult_With_No_Mental_Health_Diagnosis = -1981226566269198758L;

    private IEnumerable<Encounter> Adult_With_No_Mental_Health_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);

        bool? b_(Encounter AdultEDEncounters) {
            CqlValueSet d_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? e_ = CQMCommon_4_1_000.Instance.hasPrincipalDiagnosisOf(context, AdultEDEncounters, d_);
            return !e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pediatric With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Pediatric_With_Mental_Health_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pediatric_With_Mental_Health_Diagnosis, Pediatric_With_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Pediatric_With_Mental_Health_Diagnosis = 5036533695592859252L;

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
        context.GetOrCompute(_cacheIndex_Adult_With_Mental_Health_Diagnosis, Adult_With_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Adult_With_Mental_Health_Diagnosis = 437003468821603595L;

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
        context.GetOrCompute(_cacheIndex_Stratification_1, Stratification_1_Compute);

    private const long _cacheIndex_Stratification_1 = 5651699758766434310L;

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = 1157011799875292337L;

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 37973682128726921L;

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 4")]
    public IEnumerable<Encounter> Stratification_4(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_4, Stratification_4_Compute);

    private const long _cacheIndex_Stratification_4 = 4938437133017742234L;

    private IEnumerable<Encounter> Stratification_4_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5452485751526775804L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -2152427511355141904L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1270621774348447459L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1991679763806615112L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


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
