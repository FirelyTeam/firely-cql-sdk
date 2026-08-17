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
[CqlLibrary("CMS1244FHIRECATHOQR", "1.0.000")]
public partial class CMS1244FHIRECATHOQR_1_0_000 : ILibrary, ISingleton<CMS1244FHIRECATHOQR_1_0_000>
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
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 1514351667965499189L;

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
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5007770230675133735L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ED Evaluation and Management")]
    public IEnumerable<Encounter> ED_Evaluation_and_Management(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Evaluation_and_Management, ED_Evaluation_and_Management_Compute);

    private const long _cacheIndex_ED_Evaluation_and_Management = -8498519959231902913L;

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
            // CQL 'and' (113:5-114:51): right operand skipped when left is false
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

    private const long _cacheIndex_ED_Triage = -2369979132436776259L;

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
            // CQL 'and' (143:7-144:56): right operand skipped when left is false
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

    private const long _cacheIndex_ED_Triage_Excluding_Those_Prior_To_ED_Encounters = -3557059114495163485L;

    private IEnumerable<Encounter> ED_Triage_Excluding_Those_Prior_To_ED_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage(context);

        bool? b_(Encounter EDTriageinMP) {
            IEnumerable<Encounter> d_ = this.ED_Evaluation_and_Management(context);

            bool? e_(Encounter EDEvalManagementInMP) {
                Period g_ = EDTriageinMP?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EDEvalManagementInMP?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.OverlapsBefore(h_, j_, (string)default);
                bool? l_;
                // CQL 'or' (150:17-151:73): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, h_, (string)default);
                    l_ = k_ | n_;
                }
                bool? m_;
                // CQL 'or' (150:17-152:73): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                    m_ = l_ | o_;
                }
                // CQL 'or' (150:9-154:9): right operand skipped when left is true
                if (m_ is true)
                {
                    return true;
                }
                else
                {
                    CqlDateTime p_ = context.Operators.End(h_);
                    CqlDateTime q_ = context.Operators.Start(j_);
                    CqlQuantity r_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                    CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, false);
                    bool? u_ = context.Operators.In<CqlDateTime>(p_, t_, (string)default);
                    bool? v_;
                    // CQL 'and' (153:16-153:107): right operand skipped when left is false
                    if (u_ is false)
                    {
                        v_ = false;
                    }
                    else
                    {
                        v_ = u_ & (!((bool?)(q_ is null)));
                    }
                    return m_ | v_;
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

    private const long _cacheIndex_Initial_Population = 8043475470187039484L;

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

    private const long _cacheIndex_Denominator = 7769120724938359430L;

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
                // CQL 'or' (222:17-223:48): right operand skipped when left is true
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
                // CQL 'or' (222:11-225:11): right operand skipped when left is true
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
            // CQL 'and' (221:13-227:48): right operand skipped when left is false
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
            // CQL 'and' (221:7-232:9): right operand skipped when left is false
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
                // CQL 'and' (228:13-228:87): right operand skipped when left is false
                if (ar_ is false)
                {
                    as_ = false;
                }
                else
                {
                    as_ = ar_ & (!((bool?)(an_ is null)));
                }
                bool? at_;
                // CQL 'or' (228:13-229:65): right operand skipped when left is true
                if (as_ is true)
                {
                    at_ = true;
                }
                else
                {
                    bool? aw_ = context.Operators.OverlapsBefore(aj_, am_, (string)default);
                    at_ = as_ | aw_;
                }
                bool? au_;
                // CQL 'or' (228:13-230:65): right operand skipped when left is true
                if (at_ is true)
                {
                    au_ = true;
                }
                else
                {
                    bool? ax_ = context.Operators.OverlapsBefore(am_, aj_, (string)default);
                    au_ = at_ | ax_;
                }
                bool? av_;
                // CQL 'or' (228:12-232:9): right operand skipped when left is true
                if (au_ is true)
                {
                    av_ = true;
                }
                else
                {
                    CqlDateTime ay_ = context.Operators.Start(aj_);
                    bool? az_ = context.Operators.SameAs(ay_, an_, (string)default);
                    av_ = au_ | az_;
                }
                return u_ & av_;
            }
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period ba_ = Location?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.Start(bb_);
            return bc_;
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

    private const long _cacheIndex_ED_Triage_Before_Evaluation_Management = -2895778111572727986L;

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
                // CQL 'or' (160:19-161:62): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, h_, (string)default);
                    l_ = k_ | n_;
                }
                bool? m_;
                // CQL 'or' (160:19-162:62): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                    m_ = l_ | o_;
                }
                // CQL 'or' (160:17-164:7): right operand skipped when left is true
                if (m_ is true)
                {
                    return true;
                }
                else
                {
                    CqlDateTime p_ = context.Operators.End(h_);
                    CqlDateTime q_ = context.Operators.Start(j_);
                    CqlQuantity r_ = context.Operators.Quantity(120m, "minutes");
                    CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                    CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, false);
                    bool? u_ = context.Operators.In<CqlDateTime>(p_, t_, (string)default);
                    bool? v_;
                    // CQL 'and' (163:14-163:96): right operand skipped when left is false
                    if (u_ is false)
                    {
                        v_ = false;
                    }
                    else
                    {
                        v_ = u_ & (!((bool?)(q_ is null)));
                    }
                    return m_ | v_;
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

    private const long _cacheIndex_ED_Triage_and_Evaluation_Management = -7784186630710248603L;

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
            // CQL 'and' (259:7-260:48): right operand skipped when left is false
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

    private const long _cacheIndex_Time_to_Treatment_Room_Greater_Than_60_Minutes = 8589694032106636874L;

    private IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Evaluation_and_Management(context);

        bool? b_(Encounter EDEvalManagementInMP) {
            CqlDateTime d_ = this.edArrivalTime(context, EDEvalManagementInMP);
            CqlDateTime e_ = this.edTreatmentRoomTimeArrivalTime(context, EDEvalManagementInMP);
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

    private const long _cacheIndex_ED_Arrival_Left_Without_Being_Seen = -1788122869814405320L;

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
            FhirDateTime h_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            Encounter j_ = this.lastEDEncounter(context, EncounterInpatient);
            Period k_ = j_?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            bool? m_ = context.Operators.In<CqlDateTime>(i_, l_, (string)default);
            // CQL 'and' (200:7-201:39): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> n_ = AdmitOrder?.IntentElement;
                RequestIntent? o_ = n_?.Value;
                Code<RequestIntent> p_ = context.Operators.Convert<Code<RequestIntent>>(o_);
                bool? q_ = context.Operators.Equivalent(p_, "order");
                return m_ & q_;
            }
        }


        CqlDateTime c_(ServiceRequest AdmitOrder) {
            FhirDateTime r_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
            return s_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<ServiceRequest, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("ED To Inpatient Order")]
    public IEnumerable<ServiceRequest> ED_To_Inpatient_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_To_Inpatient_Order, ED_To_Inpatient_Order_Compute);

    private const long _cacheIndex_ED_To_Inpatient_Order = -8235323389346960348L;

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
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, true);
            bool? p_ = context.Operators.In<CqlDateTime>(i_, o_, (string)default);
            bool? q_;
            // CQL 'and' (275:13-275:108): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                q_ = p_ & (!((bool?)(l_ is null)));
            }
            bool? r_;
            // CQL 'and' (275:13-276:88): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                bool? t_ = context.Operators.Before(i_, l_, (string)default);
                r_ = q_ & t_;
            }
            bool? s_;
            // CQL 'and' (275:13-277:74): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, h_, "day");
                s_ = r_ & v_;
            }
            // CQL 'and' (275:7-278:52): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> w_ = EDEvalManagementInMP?.StatusElement;
                Encounter.EncounterStatus? x_ = w_?.Value;
                Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
                bool? z_ = context.Operators.Equal(y_, "finished");
                return s_ & z_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        object d_(Encounter @this) {
            Period aa_ = @this?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.End(ab_);
            return ac_;
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
                // CQL 'or' (240:17-241:48): right operand skipped when left is true
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
                // CQL 'or' (240:11-243:11): right operand skipped when left is true
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
            // CQL 'and' (239:13-246:42): right operand skipped when left is false
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
            // CQL 'and' (239:7-251:9): right operand skipped when left is false
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
                // CQL 'and' (247:13-247:87): right operand skipped when left is false
                if (ar_ is false)
                {
                    as_ = false;
                }
                else
                {
                    as_ = ar_ & (!((bool?)(an_ is null)));
                }
                bool? at_;
                // CQL 'or' (247:13-248:65): right operand skipped when left is true
                if (as_ is true)
                {
                    at_ = true;
                }
                else
                {
                    bool? aw_ = context.Operators.OverlapsBefore(aj_, am_, (string)default);
                    at_ = as_ | aw_;
                }
                bool? au_;
                // CQL 'or' (247:13-249:65): right operand skipped when left is true
                if (at_ is true)
                {
                    au_ = true;
                }
                else
                {
                    bool? ax_ = context.Operators.OverlapsBefore(am_, aj_, (string)default);
                    au_ = at_ | ax_;
                }
                bool? av_;
                // CQL 'or' (247:12-251:9): right operand skipped when left is true
                if (au_ is true)
                {
                    av_ = true;
                }
                else
                {
                    CqlDateTime ay_ = context.Operators.Start(aj_);
                    bool? az_ = context.Operators.SameAs(ay_, an_, (string)default);
                    av_ = au_ | az_;
                }
                return u_ & av_;
            }
        }


        CqlDateTime g_(Encounter.LocationComponent Location) {
            Period ba_ = Location?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.End(bb_);
            return bc_;
        }

        IEnumerable<CqlDateTime> h_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>(e_, f_, g_);
        IEnumerable<CqlDateTime> i_ = context.Operators.Distinct<CqlDateTime>(h_);
        IEnumerable<CqlDateTime> j_ = context.Operators.ListSort<CqlDateTime>(i_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime k_ = context.Operators.Last<CqlDateTime>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Decision to Admit Encounter Order")]
    public IEnumerable<Encounter> Decision_to_Admit_Encounter_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Decision_to_Admit_Encounter_Order, Decision_to_Admit_Encounter_Order_Compute);

    private const long _cacheIndex_Decision_to_Admit_Encounter_Order = 749891334126782508L;

    private IEnumerable<Encounter> Decision_to_Admit_Encounter_Order_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter EncounterInpatient) {
                CqlDateTime g_ = this.admitDecisionUsingEncounterOrder(context, EncounterInpatient);
                CqlDateTime h_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity i_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime j_ = context.Operators.Subtract(h_, i_);
                bool? k_ = context.Operators.SameOrBefore(g_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("admitDecisionUsingAssessment")]
    public CqlDateTime admitDecisionUsingAssessment(CqlContext context, Encounter EncounterInpatient)
    {
        IEnumerable<Observation> a_ = this.Assessment_In_ED(context);

        bool? b_(Observation EDEvaluation) {
            DataType h_ = EDEvaluation?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            Encounter l_ = this.lastEDEncounter(context, EncounterInpatient);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            bool? o_ = context.Operators.In<CqlDateTime>(k_, n_, (string)default);
            // CQL 'and' (187:7-188:70): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> p_ = EDEvaluation?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return o_ & t_;
            }
        }


        CqlDateTime c_(Observation EDEvaluation) {
            DataType u_ = EDEvaluation?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            return x_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Observation, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Assessment In ED")]
    public IEnumerable<Observation> Assessment_In_ED(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Assessment_In_ED, Assessment_In_ED_Compute);

    private const long _cacheIndex_Assessment_In_ED = -2770964050305353667L;

    private IEnumerable<Observation> Assessment_In_ED_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation ObsInED) {
            DataType g_ = ObsInED?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlValueSet i_ = this.Admit_Inpatient(context);
            bool? j_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        IEnumerable<Observation> f_ = context.Operators.Union<Observation>(b_ as IEnumerable<Observation>, e_ as IEnumerable<Observation>);
        return f_;
    }


    [CqlExpressionDefinition("Decision to Admit Using Assessment")]
    public IEnumerable<Encounter> Decision_to_Admit_Using_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Decision_to_Admit_Using_Assessment, Decision_to_Admit_Using_Assessment_Compute);

    private const long _cacheIndex_Decision_to_Admit_Using_Assessment = 5843420632977074130L;

    private IEnumerable<Encounter> Decision_to_Admit_Using_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter EncounterInpatient) {
                CqlDateTime g_ = this.admitDecisionUsingAssessment(context, EncounterInpatient);
                CqlDateTime h_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity i_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime j_ = context.Operators.Subtract(h_, i_);
                bool? k_ = context.Operators.SameOrBefore(g_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("admitInpatientOrBedAssignmentEncounterOrder")]
    public CqlDateTime admitInpatientOrBedAssignmentEncounterOrder(CqlContext context, Encounter Encounter)
    {
        IEnumerable<ServiceRequest> a_ = this.Inpatient_Or_Bed_Assignment_Encounter_Order(context);

        bool? b_(ServiceRequest AdmitInpatientOrder) {
            FhirDateTime h_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            Encounter j_ = this.lastEDEncounter(context, Encounter);
            Period k_ = j_?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            bool? m_ = context.Operators.In<CqlDateTime>(i_, l_, (string)default);
            return m_;
        }


        CqlDateTime c_(ServiceRequest AdmitInpatientOrder) {
            FhirDateTime n_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
            return o_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<ServiceRequest, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Inpatient Or Bed Assignment Encounter Order")]
    public IEnumerable<ServiceRequest> Inpatient_Or_Bed_Assignment_Encounter_Order(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Or_Bed_Assignment_Encounter_Order, Inpatient_Or_Bed_Assignment_Encounter_Order_Compute);

    private const long _cacheIndex_Inpatient_Or_Bed_Assignment_Encounter_Order = -1053802276613658725L;

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
        context.GetOrCompute(_cacheIndex_Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes, Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes_Compute);

    private const long _cacheIndex_Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes = 5181621130666177995L;

    private IEnumerable<Encounter> Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter InpatientEncounter) {
                CqlDateTime g_ = this.admitInpatientOrBedAssignmentEncounterOrder(context, InpatientEncounter);
                CqlDateTime h_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity i_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime j_ = context.Operators.Subtract(h_, i_);
                bool? k_ = context.Operators.SameOrBefore(g_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("holdingInEDAfterAdmission")]
    public CqlDateTime holdingInEDAfterAdmission(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter AdmittedInpatient) {
            Period h_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            Encounter k_ = this.lastEDEncounter(context, InpatientEncounter);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(j_, m_, (string)default);
            return n_;
        }


        CqlDateTime c_(Encounter AdmittedInpatient) {
            Period o_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            return q_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Encounter, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Admitted to Inpatient 241 Minutes or More Before Departure")]
    public IEnumerable<Encounter> Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure, Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure_Compute);

    private const long _cacheIndex_Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure = 4586384400018440955L;

    private IEnumerable<Encounter> Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter EDEncounter) {
            IEnumerable<Encounter> d_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

            bool? e_(Encounter Inpatient) {
                CqlDateTime g_ = this.holdingInEDAfterAdmission(context, Inpatient);
                CqlDateTime h_ = this.edDepartureTime(context, EDEncounter);
                CqlQuantity i_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime j_ = context.Operators.Subtract(h_, i_);
                bool? k_ = context.Operators.SameOrBefore(g_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Boarded_Time_Greater_Than_240_Minutes, Boarded_Time_Greater_Than_240_Minutes_Compute);

    private const long _cacheIndex_Boarded_Time_Greater_Than_240_Minutes = 6909252192339620427L;

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
        context.GetOrCompute(_cacheIndex_ED_Observation_Status, ED_Observation_Status_Compute);

    private const long _cacheIndex_ED_Observation_Status = 7518040729675102322L;

    private IEnumerable<Encounter> ED_Observation_Status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Observation_Services(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter EDObsEncounter) {
            IEnumerable<Encounter> e_ = this.Denominator(context);

            bool? f_(Encounter EDEncounter) {
                Period h_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                Period j_ = EDObsEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, (string)default);
                // CQL 'and' (138:17-139:46): right operand skipped when left is false
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

    private const long _cacheIndex_Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay = 5943507332585823609L;

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

    private const long _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes = 997941685269438763L;

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

    private const long _cacheIndex_ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay = -8859002859181274170L;

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

    private const long _cacheIndex_Numerator = 4971354970454751926L;

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

    private const long _cacheIndex_ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years = 5925777047380369906L;

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
        context.GetOrCompute(_cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis, Pediatric_With_No_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Pediatric_With_No_Mental_Health_Diagnosis = -208256387275009242L;

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

    private const long _cacheIndex_ED_Encounter_or_Triage_of_Patients_18_Years_and_Older = -5331314089026339565L;

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
        context.GetOrCompute(_cacheIndex_Adult_With_No_Mental_Health_Diagnosis, Adult_With_No_Mental_Health_Diagnosis_Compute);

    private const long _cacheIndex_Adult_With_No_Mental_Health_Diagnosis = -9198098665733055182L;

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

    private const long _cacheIndex_Pediatric_With_Mental_Health_Diagnosis = 892056070909937912L;

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

    private const long _cacheIndex_Adult_With_Mental_Health_Diagnosis = -558307240570505674L;

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

    private const long _cacheIndex_Stratification_1 = 5942352318045369146L;

    private IEnumerable<Encounter> Stratification_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public IEnumerable<Encounter> Stratification_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_2, Stratification_2_Compute);

    private const long _cacheIndex_Stratification_2 = -7992318308575810951L;

    private IEnumerable<Encounter> Stratification_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_No_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public IEnumerable<Encounter> Stratification_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_3, Stratification_3_Compute);

    private const long _cacheIndex_Stratification_3 = 6500512355801734679L;

    private IEnumerable<Encounter> Stratification_3_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Pediatric_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Stratification 4")]
    public IEnumerable<Encounter> Stratification_4(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Stratification_4, Stratification_4_Compute);

    private const long _cacheIndex_Stratification_4 = 4102676335102210626L;

    private IEnumerable<Encounter> Stratification_4_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Adult_With_Mental_Health_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -2764988004099448273L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 3188438233448661594L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1014595823694878083L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 7666189415205594029L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

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
