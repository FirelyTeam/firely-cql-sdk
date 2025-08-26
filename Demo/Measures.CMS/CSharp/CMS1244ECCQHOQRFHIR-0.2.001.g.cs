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
[CqlLibrary("CMS1244ECCQHOQRFHIR", "0.2.001")]
public partial class CMS1244ECCQHOQRFHIR_0_2_001 : ILibrary, ISingleton<CMS1244ECCQHOQRFHIR_0_2_001>
{
    private CMS1244ECCQHOQRFHIR_0_2_001() {}

    public static CMS1244ECCQHOQRFHIR_0_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1244ECCQHOQRFHIR";
    public string Version => "0.2.001";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    [CqlValueSetDefinition("Emergency Department Observation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.22", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Observation(CqlContext _) => _Emergency_Department_Observation;
    private static readonly CqlValueSet _Emergency_Department_Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.22", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", valueSetVersion: null)]
    public CqlValueSet Triage(CqlContext _) => _Triage;
    private static readonly CqlValueSet _Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Patient bed assigned (finding)", codeId: "5751000175101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_bed_assigned__finding_(CqlContext _) => _Patient_bed_assigned__finding_;
    private static readonly CqlCode _Patient_bed_assigned__finding_ = new CqlCode("5751000175101", "http://snomed.info/sct");

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
          _Patient_bed_assigned__finding_,
          _Patient_left_without_being_seen__finding_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS1244ECCQHOQRFHIR-0.2.001", "Measurement Period", c_);

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
            Code<Encounter.EncounterStatus> j_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            bool? m_ = context.Operators.Equal(l_, "finished");
            bool? n_ = context.Operators.And(i_, m_);

            return n_;
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


    [CqlFunctionDefinition("AdmitDecisionUsingEncounterOrder")]
    public CqlDateTime AdmitDecisionUsingEncounterOrder(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<ServiceRequest> a_ = this.EDtoIPOrder(context);
        bool? b_(ServiceRequest AdmitOrder)
        {
            FhirDateTime i_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            Encounter k_ = this.LastEDEncounter(context, InpatientEncounter);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(j_, m_, default);
            Code<RequestIntent> o_ = AdmitOrder?.IntentElement;
            RequestIntent? p_ = o_?.Value;
            Code<RequestIntent> q_ = context.Operators.Convert<Code<RequestIntent>>(p_);
            bool? r_ = context.Operators.Equivalent(q_, "order");
            bool? s_ = context.Operators.And(n_, r_);
            Code<RequestStatus> t_ = AdmitOrder?.StatusElement;
            RequestStatus? u_ = t_?.Value;
            Code<RequestStatus> v_ = context.Operators.Convert<Code<RequestStatus>>(u_);
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "active",
                "completed",
            ];
            bool? y_ = context.Operators.In<string>(w_, x_ as IEnumerable<string>);
            bool? z_ = context.Operators.And(s_, y_);

            return z_;
        };
        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);
        CqlDateTime d_(ServiceRequest AdmitOrder)
        {
            FhirDateTime aa_ = AdmitOrder?.AuthoredOnElement;
            CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);

            return ab_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<ServiceRequest, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("EDtoIPOrder")]
    public IEnumerable<ServiceRequest> EDtoIPOrder(CqlContext context)
    {
        CqlValueSet a_ = this.Decision_to_Admit_to_Hospital_Inpatient(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        return b_;
    }


    [CqlFunctionDefinition("LastEDEncounter")]
    public Encounter LastEDEncounter(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter(context);
        bool? b_(Encounter EDVisit)
        {
            Period g_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            CqlDateTime i_ = context.Operators.Start(h_);
            Period j_ = InpatientEncounter?.Period;
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
            bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, ai_, default);
            bool? ak_ = context.Operators.And(af_, aj_);
            Code<Encounter.EncounterStatus> al_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? am_ = al_?.Value;
            Code<Encounter.EncounterStatus> an_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(am_);
            bool? ao_ = context.Operators.Equal(an_, "finished");
            bool? ap_ = context.Operators.And(ak_, ao_);

            return ap_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        object d_(Encounter @this)
        {
            Period aq_ = @this?.Period;
            CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
            CqlDateTime as_ = context.Operators.End(ar_);

            return as_;
        };
        IEnumerable<Encounter> e_ = context.Operators.SortBy<Encounter>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter f_ = context.Operators.Last<Encounter>(e_);

        return f_;
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


    [CqlExpressionDefinition("Decision to Admit Encounter Order")]
    public IEnumerable<Encounter> Decision_to_Admit_Encounter_Order(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Encounter> b_(Encounter EDEncounter)
        {
            IEnumerable<Encounter> d_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
            bool? e_(Encounter EncounterInpatient)
            {
                CqlDateTime i_ = this.AdmitDecisionUsingEncounterOrder(context, EncounterInpatient);
                CqlDateTime j_ = this.EDDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter EncounterInpatient) =>
                EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("AdmitDecisionUsingAssessment")]
    public CqlDateTime AdmitDecisionUsingAssessment(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<Observation> a_ = this.AssessmentInED(context);
        bool? b_(Observation EDEvaluation)
        {
            DataType i_ = EDEvaluation?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.toInterval(context, j_);
            CqlDateTime l_ = context.Operators.Start(k_);
            Encounter m_ = this.LastEDEncounter(context, InpatientEncounter);
            Period n_ = m_?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            bool? p_ = context.Operators.In<CqlDateTime>(l_, o_, default);
            DataType q_ = EDEvaluation?.Value;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlValueSet s_ = this.Admit_Inpatient(context);
            bool? t_ = context.Operators.ConceptInValueSet(r_ as CqlConcept, s_);
            bool? u_ = context.Operators.And(p_, t_);
            Code<ObservationStatus> v_ = EDEvaluation?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            Code<ObservationStatus> x_ = context.Operators.Convert<Code<ObservationStatus>>(w_);
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
            bool? ab_ = context.Operators.And(u_, aa_);

            return ab_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        CqlDateTime d_(Observation EDEvaluation)
        {
            DataType ac_ = EDEvaluation?.Effective;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_1_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);

            return af_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("AssessmentInED")]
    public IEnumerable<Observation> AssessmentInED(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));

        return b_;
    }


    [CqlExpressionDefinition("Decision to Admit Using Assessment")]
    public IEnumerable<Encounter> Decision_to_Admit_Using_Assessment(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Encounter> b_(Encounter EDEncounter)
        {
            IEnumerable<Encounter> d_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
            bool? e_(Encounter EncounterInpatient)
            {
                CqlDateTime i_ = this.AdmitDecisionUsingAssessment(context, EncounterInpatient);
                CqlDateTime j_ = this.EDDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter EncounterInpatient) =>
                EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("AdmitInpatientOrBedAssignmentOrder")]
    public CqlDateTime AdmitInpatientOrBedAssignmentOrder(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<ServiceRequest> a_ = this.InpatientOrBedAssignmentEncounterOrder(context);
        bool? b_(ServiceRequest AdmitInpatientOrder)
        {
            FhirDateTime i_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            Encounter k_ = this.LastEDEncounter(context, InpatientEncounter);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.In<CqlDateTime>(j_, m_, default);

            return n_;
        };
        IEnumerable<ServiceRequest> c_ = context.Operators.Where<ServiceRequest>(a_, b_);
        CqlDateTime d_(ServiceRequest AdmitInpatientOrder)
        {
            FhirDateTime o_ = AdmitInpatientOrder?.AuthoredOnElement;
            CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);

            return p_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<ServiceRequest, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("InpatientOrBedAssignmentEncounterOrder")]
    public IEnumerable<ServiceRequest> InpatientOrBedAssignmentEncounterOrder(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        CqlCode c_ = this.Patient_bed_assigned__finding_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> f_ = context.Operators.Union<ServiceRequest>(b_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Time of Admit Order Or Bed Assignment to Departure Greater Than 241 Minutes")]
    public IEnumerable<Encounter> Time_of_Admit_Order_Or_Bed_Assignment_to_Departure_Greater_Than_241_Minutes(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Encounter> b_(Encounter EDEncounter)
        {
            IEnumerable<Encounter> d_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
            bool? e_(Encounter InpatientEncounter)
            {
                CqlDateTime i_ = this.AdmitInpatientOrBedAssignmentOrder(context, InpatientEncounter);
                CqlDateTime j_ = this.EDDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter InpatientEncounter) =>
                EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("HoldingInEDAfterAdmission")]
    public CqlDateTime HoldingInEDAfterAdmission(CqlContext context, Encounter InpatientEncounter)
    {
        IEnumerable<Encounter> a_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? b_(Encounter AdmittedInpatient)
        {
            Period i_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            Encounter l_ = this.LastEDEncounter(context, InpatientEncounter);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            bool? o_ = context.Operators.In<CqlDateTime>(k_, n_, default);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        CqlDateTime d_(Encounter AdmittedInpatient)
        {
            Period p_ = AdmittedInpatient?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);

            return r_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Admitted to Inpatient 241 Minutes or More Before Departure")]
    public IEnumerable<Encounter> Admitted_to_Inpatient_241_Minutes_or_More_Before_Departure(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Encounter> b_(Encounter EDEncounter)
        {
            IEnumerable<Encounter> d_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
            bool? e_(Encounter Inpatient)
            {
                CqlDateTime i_ = this.HoldingInEDAfterAdmission(context, Inpatient);
                CqlDateTime j_ = this.EDDepartureTime(context, EDEncounter);
                CqlQuantity k_ = context.Operators.Quantity(241m, "minutes");
                CqlDateTime l_ = context.Operators.Subtract(j_, k_);
                bool? m_ = context.Operators.SameOrBefore(i_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter Inpatient) =>
                EDEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Boarded Time Greater Than 240 Minutes")]
    public IEnumerable<Encounter> Boarded_Time_Greater_Than_240_Minutes(CqlContext context)
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
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            bool? l_ = context.Operators.Less(k_, 18);

            return l_;
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
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
            bool? l_ = context.Operators.GreaterOrEqual(k_, 18);

            return l_;
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
