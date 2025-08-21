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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS1264ECCQREHQRFHIR", "0.3.001")]
public partial class CMS1264ECCQREHQRFHIR_0_3_001 : ILibrary, ISingleton<CMS1264ECCQREHQRFHIR_0_3_001>
{
    private CMS1264ECCQREHQRFHIR_0_3_001() {}

    public static CMS1264ECCQREHQRFHIR_0_3_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1264ECCQREHQRFHIR";
    public string Version => "0.3.001";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Mental Health Diagnosis without Substance Use Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", valueSetVersion: null)]
    public CqlValueSet Mental_Health_Diagnosis_without_Substance_Use_Disorders(CqlContext _) => _Mental_Health_Diagnosis_without_Substance_Use_Disorders;
    private static readonly CqlValueSet _Mental_Health_Diagnosis_without_Substance_Use_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285", null);

    [CqlValueSetDefinition("Decision to Transfer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.286", valueSetVersion: null)]
    public CqlValueSet Decision_to_Transfer(CqlContext _) => _Decision_to_Transfer;
    private static readonly CqlValueSet _Decision_to_Transfer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.286", null);

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

    [CqlValueSetDefinition("Emergency Department Observation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.22", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Observation(CqlContext _) => _Emergency_Department_Observation;
    private static readonly CqlValueSet _Emergency_Department_Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.22", null);

    [CqlValueSetDefinition("Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", valueSetVersion: null)]
    public CqlValueSet Triage(CqlContext _) => _Triage;
    private static readonly CqlValueSet _Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Patient left without being seen (finding)", codeId: "21541000119102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_left_without_being_seen__finding_(CqlContext _) => _Patient_left_without_being_seen__finding_;
    private static readonly CqlCode _Patient_left_without_being_seen__finding_ = new CqlCode("21541000119102", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, []);

    [CqlCodeSystemDefinition("HSLOC", codeSystemId: "http://terminology.hl7.org/CodeSystem/hsloc", codeSystemVersion: null)]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/hsloc", null, []);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Patient_left_without_being_seen__finding_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS1264ECCQREHQRFHIR-0.3.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("ED Encounter")]
    public IEnumerable<Encounter> ED_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EDEncounter)
        {
            Period e_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("ED Triage")]
    public IEnumerable<Encounter> ED_Triage(CqlContext context)
    {
        CqlValueSet a_ = this.Triage(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EDTriage)
        {
            Period e_ = EDTriage?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter(context);
        IEnumerable<Encounter> b_ = this.ED_Triage(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlFunctionDefinition("EDArrivalTime")]
    public CqlDateTime EDArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
        bool? b_(Encounter.LocationComponent Location)
        {
            ResourceReference i_ = Location?.Location;
            Location j_ = CQMCommon_2_2_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return u_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Emergency_Department_Location(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            Period p_ = Location?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            bool? s_ = context.Operators.Not((bool?)(r_ is null));
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        CqlDateTime d_(Encounter.LocationComponent Location)
        {
            Period v_ = Location?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);

            return x_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlFunctionDefinition("EDTreatmentRoomTimeArrivalTime")]
    public CqlDateTime EDTreatmentRoomTimeArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
        bool? b_(Encounter.LocationComponent Location)
        {
            ResourceReference i_ = Location?.Location;
            Location j_ = CQMCommon_2_2_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return u_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Emergency_Department_Treatment_Location(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            Period p_ = Location?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            bool? s_ = context.Operators.Not((bool?)(r_ is null));
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        CqlDateTime d_(Encounter.LocationComponent Location)
        {
            Period v_ = Location?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);

            return x_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Time to Treatment Room Greater Than 60 Minutes")]
    public IEnumerable<Encounter> Time_to_Treatment_Room_Greater_Than_60_Minutes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter EDEncounter)
        {
            CqlDateTime d_ = this.EDArrivalTime(context, EDEncounter);
            CqlDateTime e_ = this.EDTreatmentRoomTimeArrivalTime(context, EDEncounter);
            CqlQuantity f_ = context.Operators.Quantity(61m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, default);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Arrival Left Without Being Seen")]
    public IEnumerable<Encounter> ED_Arrival_Left_Without_Being_Seen(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Triage(context);
        bool? b_(Encounter EDTriage)
        {
            Encounter.HospitalizationComponent d_ = EDTriage?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlCode g_ = this.Patient_left_without_being_seen__finding_(context);
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
            bool? i_ = context.Operators.Equivalent(f_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("TransferDecisionUsingOrder")]
    public CqlDateTime TransferDecisionUsingOrder(CqlContext context)
    {
        CqlValueSet a_ = this.Decision_to_Transfer(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_(ServiceRequest TransferOrder)
        {
            CqlValueSet j_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? l_(Encounter EDVisit)
            {
                FhirDateTime p_ = TransferOrder?.AuthoredOnElement;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                Period r_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);
                Code<RequestIntent> u_ = TransferOrder?.IntentElement;
                RequestIntent? v_ = u_?.Value;
                Code<RequestIntent> w_ = context.Operators.Convert<Code<RequestIntent>>(v_);
                bool? x_ = context.Operators.Equal(w_, "order");
                bool? y_ = context.Operators.And(t_, x_);
                Code<RequestStatus> z_ = TransferOrder?.StatusElement;
                RequestStatus? aa_ = z_?.Value;
                Code<RequestStatus> ab_ = context.Operators.Convert<Code<RequestStatus>>(aa_);
                bool? ac_ = context.Operators.Equal(ab_, "completed");
                bool? ad_ = context.Operators.And(y_, ac_);
                Code<Encounter.EncounterStatus> ae_ = EDVisit?.StatusElement;
                Encounter.EncounterStatus? af_ = ae_?.Value;
                Code<Encounter.EncounterStatus> ag_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "finished");
                bool? ai_ = context.Operators.And(ad_, ah_);

                return ai_;
            };
            IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
            ServiceRequest n_(Encounter EDVisit) =>
                TransferOrder;
            IEnumerable<ServiceRequest> o_ = context.Operators.Select<Encounter, ServiceRequest>(m_, n_);

            return o_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);
        CqlDateTime e_(ServiceRequest TransferOrder)
        {
            FhirDateTime aj_ = TransferOrder?.AuthoredOnElement;
            CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);

            return ak_;
        };
        IEnumerable<CqlDateTime> f_ = context.Operators.Select<ServiceRequest, CqlDateTime>(d_, e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.Distinct<CqlDateTime>(f_);
        IEnumerable<CqlDateTime> h_ = context.Operators.ListSort<CqlDateTime>(g_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime i_ = context.Operators.Last<CqlDateTime>(h_);

        return i_;
    }


    [CqlFunctionDefinition("EDDepartureTime")]
    public CqlDateTime EDDepartureTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
        bool? b_(Encounter.LocationComponent Location)
        {
            ResourceReference i_ = Location?.Location;
            Location j_ = CQMCommon_2_2_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return u_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Emergency_Department_Location(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            Period p_ = Location?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.End(q_);
            bool? s_ = context.Operators.Not((bool?)(r_ is null));
            bool? t_ = context.Operators.And(o_, s_);

            return t_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        CqlDateTime d_(Encounter.LocationComponent Location)
        {
            Period v_ = Location?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.End(w_);

            return x_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter EDEncounter)
        {
            CqlDateTime d_ = this.TransferDecisionUsingOrder(context);
            CqlDateTime e_ = this.EDDepartureTime(context, EDEncounter);
            CqlQuantity f_ = context.Operators.Quantity(241m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, default);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Observation Encounter Status")]
    public IEnumerable<Encounter> ED_Observation_Encounter_Status(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Observation(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_(Encounter EDObsEncounter)
        {
            IEnumerable<Encounter> e_ = this.Denominator(context);
            bool? f_(Encounter EDEncounter)
            {
                Period j_ = EDObsEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, default);
                Code<Encounter.EncounterStatus> p_ = EDEncounter?.StatusElement;
                Encounter.EncounterStatus? q_ = p_?.Value;
                Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                bool? s_ = context.Operators.Equal(r_, "finished");
                bool? t_ = context.Operators.And(o_, s_);
                Code<Encounter.EncounterStatus> u_ = EDObsEncounter?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                bool? x_ = context.Operators.Equal(w_, "finished");
                bool? y_ = context.Operators.And(t_, x_);

                return y_;
            };
            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            Encounter h_(Encounter EDEncounter) =>
                EDObsEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("ED Observation Order Status")]
    public IEnumerable<ServiceRequest> ED_Observation_Order_Status(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Observation(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> c_(ServiceRequest EDObsOrder)
        {
            IEnumerable<Encounter> e_ = this.Denominator(context);
            bool? f_(Encounter EDEncounter)
            {
                FhirDateTime j_ = EDObsOrder?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, default);
                Code<Encounter.EncounterStatus> o_ = EDEncounter?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                bool? r_ = context.Operators.Equal(q_, "finished");
                bool? s_ = context.Operators.And(n_, r_);
                Code<RequestStatus> t_ = EDObsOrder?.StatusElement;
                RequestStatus? u_ = t_?.Value;
                Code<RequestStatus> v_ = context.Operators.Convert<Code<RequestStatus>>(u_);
                bool? w_ = context.Operators.Equal(v_, "active");
                bool? x_ = context.Operators.And(s_, w_);

                return x_;
            };
            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            ServiceRequest h_(Encounter EDEncounter) =>
                EDObsOrder;
            IEnumerable<ServiceRequest> i_ = context.Operators.Select<Encounter, ServiceRequest>(g_, h_);

            return i_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("ED Observation Status")]
    public IEnumerable<object> ED_Observation_Status(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Observation_Encounter_Status(context);
        IEnumerable<ServiceRequest> b_ = this.ED_Observation_Order_Status(context);
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        IEnumerable<object> d_(object EDObservation)
        {
            IEnumerable<Encounter> f_ = this.Denominator(context);
            bool? g_(Encounter EDStay)
            {
                Period k_ = EDStay?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                object m_ = context.Operators.LateBoundProperty<object>(EDObservation, "period");
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_ as Period);
                bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, default);
                object p_ = context.Operators.LateBoundProperty<object>(EDObservation, "authoredOn");
                CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);
                bool? u_ = context.Operators.Or(o_, t_);

                return u_;
            };
            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            object i_(Encounter EDStay) =>
                EDObservation;
            IEnumerable<object> j_ = context.Operators.Select<Encounter, object>(h_, i_);

            return j_;
        };
        IEnumerable<object> e_ = context.Operators.SelectMany<object, object>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes_and_No_Observation_Stay(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Boarded_Time_Greater_Than_240_Minutes(context);
        bool? b_(Encounter Boarding)
        {
            IEnumerable<object> d_ = this.ED_Observation_Status(context);
            bool? e_(object EDO)
            {
                object i_ = context.Operators.LateBoundProperty<object>(EDO, "period");
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_ as Period);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = Boarding?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, default);
                object o_ = context.Operators.LateBoundProperty<object>(EDO, "authoredOn");
                CqlDateTime p_ = context.Operators.LateBoundProperty<CqlDateTime>(o_, "value");
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
                bool? t_ = context.Operators.Or(n_, s_);

                return t_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter EDEncounter)
        {
            CqlDateTime d_ = this.EDArrivalTime(context, EDEncounter);
            CqlDateTime e_ = this.EDDepartureTime(context, EDEncounter);
            CqlQuantity f_ = context.Operators.Quantity(481m, "minutes");
            CqlDateTime g_ = context.Operators.Subtract(e_, f_);
            bool? h_ = context.Operators.SameOrBefore(d_, g_, default);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Length of Stay Greater Than 480 Minutes and No Observation Stay")]
    public IEnumerable<Encounter> ED_Length_of_Stay_Greater_Than_480_Minutes_and_No_Observation_Stay(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Length_of_Stay_Greater_Than_480_Minutes(context);
        bool? b_(Encounter EDStay)
        {
            IEnumerable<object> d_ = this.ED_Observation_Status(context);
            bool? e_(object EDO)
            {
                object i_ = context.Operators.LateBoundProperty<object>(EDO, "period");
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_ as Period);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = EDStay?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, default);
                object o_ = context.Operators.LateBoundProperty<object>(EDO, "authoredOn");
                CqlDateTime p_ = context.Operators.LateBoundProperty<CqlDateTime>(o_, "value");
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
                bool? t_ = context.Operators.Or(n_, s_);

                return t_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
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
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter EDEncounter)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Stratification 1: Pediatric With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Stratification_1__Pediatric_With_No_Mental_Health_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);
        bool? b_(Encounter EDEncounter)
        {
            Condition d_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, EDEncounter);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            bool? i_ = context.Operators.Not(h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Encounter or Triage of Patients 18 Years and Older")]
    public IEnumerable<Encounter> ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        bool? b_(Encounter EDEncounter)
        {
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
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Stratification 2: Adult With No Mental Health Diagnosis")]
    public IEnumerable<Encounter> Stratification_2__Adult_With_No_Mental_Health_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);
        bool? b_(Encounter EDEncounter)
        {
            Condition d_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, EDEncounter);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            bool? i_ = context.Operators.Not(h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Stratification 3: Pediatric With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Stratification_3__Pediatric_With_Mental_Health_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_Less_Than_18_Years(context);
        bool? b_(Encounter EDEncounter)
        {
            Condition d_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, EDEncounter);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Stratification 4: Adult With Mental Health Diagnosis")]
    public IEnumerable<Encounter> Stratification_4__Adult_With_Mental_Health_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_or_Triage_of_Patients_18_Years_and_Older(context);
        bool? b_(Encounter EDEncounter)
        {
            Condition d_ = CQMCommon_2_2_000.Instance.principalDiagnosis(context, EDEncounter);
            CodeableConcept e_ = d_?.Code;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Mental_Health_Diagnosis_without_Substance_Use_Disorders(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

}
