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

            bool? j_() {
                Code<Encounter.EncounterStatus> k_ = EDEvalManagementVisit?.StatusElement;
                Encounter.EncounterStatus? l_ = k_?.Value;
                Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
                bool? n_ = context.Operators.Equal(m_, "finished");
                return (bool?)((CqlBoolean)n_);
            }

            return (bool?)(/* CQL 'and' (92:5-93:51) */ ((CqlBoolean)i_
                && (CqlBoolean)j_()));
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

            bool? j_() {
                Code<Encounter.EncounterStatus> k_ = EDTriage?.StatusElement;
                Encounter.EncounterStatus? l_ = k_?.Value;
                Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
                string n_ = context.Operators.Convert<string>(m_);
                string[] o_ = [
                    "finished",
                    "triaged",
                ];
                bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
                return (bool?)((CqlBoolean)p_);
            }

            return (bool?)(/* CQL 'and' (122:5-123:54) */ ((CqlBoolean)i_
                && (CqlBoolean)j_()));
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

                bool? l_() {
                    Period o_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    Period q_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                    return (bool?)((CqlBoolean)s_);
                }


                bool? m_() {
                    Period t_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    Period v_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                    bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, (string)default);
                    return (bool?)((CqlBoolean)x_);
                }


                bool? n_() {
                    Period y_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.End(z_);
                    Period ab_ = EDEvalManagementinMP?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    CqlQuantity ae_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(af_, ad_, true, false);
                    bool? ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, (string)default);

                    bool? ai_() {
                        Period aj_ = EDEvalManagementinMP?.Period;
                        CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                        CqlDateTime al_ = context.Operators.Start(ak_);
                        return (bool?)((CqlBoolean)(!((bool?)(al_ is null))));
                    }

                    return (bool?)(/* CQL 'and' (131:16-131:107) */ ((CqlBoolean)ah_
                        && (CqlBoolean)ai_()));
                }

                return (bool?)(/* CQL 'or' (128:9-132:9) */ (/* CQL 'or' (128:17-130:73) */ (/* CQL 'or' (128:17-129:73) */ ((CqlBoolean)k_
                    || (CqlBoolean)l_())
                    || (CqlBoolean)m_())
                    || (CqlBoolean)n_()));
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
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return w_;
            }


            bool? r_(CqlConcept LocationType) {
                CqlValueSet x_ = this.Emergency_Department_Location(context);
                bool? y_ = context.Operators.ConceptInValueSet(LocationType, x_);

                bool? z_() {
                    CqlCode ab_ = this.Emergency_room(context);
                    CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                    bool? ad_ = context.Operators.Equivalent(LocationType, ac_);
                    return (bool?)((CqlBoolean)ad_);
                }


                bool? aa_() {
                    CqlCode ae_ = this.Emergency_trauma_unit(context);
                    CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
                    bool? ag_ = context.Operators.Equivalent(LocationType, af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'or' (155:11-158:11) */ (/* CQL 'or' (155:17-156:48) */ ((CqlBoolean)y_
                    || (CqlBoolean)z_())
                    || (CqlBoolean)aa_()));
            }

            IEnumerable<CqlConcept> s_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_, r_);
            bool? t_ = context.Operators.Exists<CqlConcept>(s_);

            bool? u_() {
                Period ah_ = Location?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                return (bool?)((CqlBoolean)(!((bool?)(aj_ is null))));
            }


            bool? v_() {
                Period ak_ = Location?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                Period an_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ar_, ap_, true, false);
                bool? at_ = context.Operators.In<CqlDateTime>(am_, as_, (string)default);

                bool? au_() {
                    Period ay_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                    CqlDateTime ba_ = context.Operators.Start(az_);
                    return (bool?)((CqlBoolean)(!((bool?)(ba_ is null))));
                }


                bool? av_() {
                    Period bb_ = Location?.Period;
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                    Period bd_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                    bool? bf_ = context.Operators.OverlapsBefore(bc_, be_, (string)default);
                    return (bool?)((CqlBoolean)bf_);
                }


                bool? aw_() {
                    Period bg_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                    Period bi_ = Location?.Period;
                    CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                    bool? bk_ = context.Operators.OverlapsBefore(bh_, bj_, (string)default);
                    return (bool?)((CqlBoolean)bk_);
                }


                bool? ax_() {
                    Period bl_ = Location?.Period;
                    CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    Period bo_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                    CqlDateTime bq_ = context.Operators.Start(bp_);
                    bool? br_ = context.Operators.SameAs(bn_, bq_, (string)default);
                    return (bool?)((CqlBoolean)br_);
                }

                return (bool?)(/* CQL 'or' (161:12-165:9) */ (/* CQL 'or' (161:13-163:65) */ (/* CQL 'or' (161:13-162:65) */ (/* CQL 'and' (161:13-161:87) */ ((CqlBoolean)at_
                    && (CqlBoolean)au_())
                    || (CqlBoolean)av_())
                    || (CqlBoolean)aw_())
                    || (CqlBoolean)ax_()));
            }

            return (bool?)(/* CQL 'and' (154:7-165:9) */ (/* CQL 'and' (154:13-160:48) */ ((CqlBoolean)t_
                && (CqlBoolean)u_())
                && (CqlBoolean)v_()));
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period bs_ = Location?.Period;
            CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.Start(bt_);
            return bu_;
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

                bool? l_() {
                    Period o_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                    Period q_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                    bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                    return (bool?)((CqlBoolean)s_);
                }


                bool? m_() {
                    Period t_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    Period v_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                    bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, (string)default);
                    return (bool?)((CqlBoolean)x_);
                }


                bool? n_() {
                    Period y_ = EDTriageinMP?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.End(z_);
                    Period ab_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    CqlQuantity ae_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(af_, ad_, true, false);
                    bool? ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, (string)default);

                    bool? ai_() {
                        Period aj_ = EDEncounter?.Period;
                        CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                        CqlDateTime al_ = context.Operators.Start(ak_);
                        return (bool?)((CqlBoolean)(!((bool?)(al_ is null))));
                    }

                    return (bool?)(/* CQL 'and' (141:14-141:96) */ ((CqlBoolean)ah_
                        && (CqlBoolean)ai_()));
                }

                return (bool?)(/* CQL 'or' (138:17-142:7) */ (/* CQL 'or' (138:19-140:62) */ (/* CQL 'or' (138:19-139:62) */ ((CqlBoolean)k_
                    || (CqlBoolean)l_())
                    || (CqlBoolean)m_())
                    || (CqlBoolean)n_()));
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Treatment_Location(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

            bool? o_() {
                Period q_ = Location?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                return (bool?)((CqlBoolean)(!((bool?)(s_ is null))));
            }

            return (bool?)(/* CQL 'and' (192:7-193:48) */ ((CqlBoolean)n_
                && (CqlBoolean)o_()));
        }


        CqlDateTime c_(Encounter.LocationComponent Location) {
            Period t_ = Location?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            return v_;
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

            bool? n_() {
                Code<RequestIntent> p_ = TransferOrder?.IntentElement;
                RequestIntent? q_ = p_?.Value;
                Code<RequestIntent> r_ = context.Operators.Convert<Code<RequestIntent>>(q_);
                bool? s_ = context.Operators.Equal(r_, "order");
                return (bool?)((CqlBoolean)s_);
            }


            bool? o_() {
                Code<RequestStatus> t_ = TransferOrder?.StatusElement;
                RequestStatus? u_ = t_?.Value;
                Code<RequestStatus> v_ = context.Operators.Convert<Code<RequestStatus>>(u_);
                string w_ = context.Operators.Convert<string>(v_);
                string[] x_ = [
                    "active",
                    "completed",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                return (bool?)((CqlBoolean)y_);
            }

            return (bool?)(/* CQL 'and' (200:7-202:61) */ (/* CQL 'and' (200:13-201:42) */ ((CqlBoolean)m_
                && (CqlBoolean)n_())
                && (CqlBoolean)o_()));
        }


        CqlDateTime d_(ServiceRequest TransferOrder) {
            FhirDateTime z_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
            return aa_;
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
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return w_;
            }


            bool? r_(CqlConcept LocationType) {
                CqlValueSet x_ = this.Emergency_Department_Location(context);
                bool? y_ = context.Operators.ConceptInValueSet(LocationType, x_);

                bool? z_() {
                    CqlCode ab_ = this.Emergency_room(context);
                    CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                    bool? ad_ = context.Operators.Equivalent(LocationType, ac_);
                    return (bool?)((CqlBoolean)ad_);
                }


                bool? aa_() {
                    CqlCode ae_ = this.Emergency_trauma_unit(context);
                    CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
                    bool? ag_ = context.Operators.Equivalent(LocationType, af_);
                    return (bool?)((CqlBoolean)ag_);
                }

                return (bool?)(/* CQL 'or' (173:11-176:11) */ (/* CQL 'or' (173:17-174:48) */ ((CqlBoolean)y_
                    || (CqlBoolean)z_())
                    || (CqlBoolean)aa_()));
            }

            IEnumerable<CqlConcept> s_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_, r_);
            bool? t_ = context.Operators.Exists<CqlConcept>(s_);

            bool? u_() {
                Period ah_ = Location?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.End(ai_);
                return (bool?)((CqlBoolean)(!((bool?)(aj_ is null))));
            }


            bool? v_() {
                Period ak_ = Location?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                Period an_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ar_, ap_, true, false);
                bool? at_ = context.Operators.In<CqlDateTime>(am_, as_, (string)default);

                bool? au_() {
                    Period ay_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                    CqlDateTime ba_ = context.Operators.Start(az_);
                    return (bool?)((CqlBoolean)(!((bool?)(ba_ is null))));
                }


                bool? av_() {
                    Period bb_ = Location?.Period;
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                    Period bd_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                    bool? bf_ = context.Operators.OverlapsBefore(bc_, be_, (string)default);
                    return (bool?)((CqlBoolean)bf_);
                }


                bool? aw_() {
                    Period bg_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                    Period bi_ = Location?.Period;
                    CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                    bool? bk_ = context.Operators.OverlapsBefore(bh_, bj_, (string)default);
                    return (bool?)((CqlBoolean)bk_);
                }


                bool? ax_() {
                    Period bl_ = Location?.Period;
                    CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    Period bo_ = EDEncounter?.Period;
                    CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                    CqlDateTime bq_ = context.Operators.Start(bp_);
                    bool? br_ = context.Operators.SameAs(bn_, bq_, (string)default);
                    return (bool?)((CqlBoolean)br_);
                }

                return (bool?)(/* CQL 'or' (180:12-184:9) */ (/* CQL 'or' (180:13-182:65) */ (/* CQL 'or' (180:13-181:65) */ (/* CQL 'and' (180:13-180:87) */ ((CqlBoolean)at_
                    && (CqlBoolean)au_())
                    || (CqlBoolean)av_())
                    || (CqlBoolean)aw_())
                    || (CqlBoolean)ax_()));
            }

            return (bool?)(/* CQL 'and' (172:7-184:9) */ (/* CQL 'and' (172:13-179:42) */ ((CqlBoolean)t_
                && (CqlBoolean)u_())
                && (CqlBoolean)v_()));
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period bs_ = Location?.Period;
            CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.End(bt_);
            return bu_;
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

                bool? m_() {
                    Code<Encounter.EncounterStatus> n_ = EDObsEncounter?.StatusElement;
                    Encounter.EncounterStatus? o_ = n_?.Value;
                    Code<Encounter.EncounterStatus> p_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(o_);
                    bool? q_ = context.Operators.Equal(p_, "finished");
                    return (bool?)((CqlBoolean)q_);
                }

                return (bool?)(/* CQL 'and' (117:17-118:46) */ ((CqlBoolean)l_
                    && (CqlBoolean)m_()));
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
