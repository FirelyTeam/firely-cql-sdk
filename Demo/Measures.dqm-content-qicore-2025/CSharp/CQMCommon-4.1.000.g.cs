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
[CqlLibrary("CQMCommon", "4.1.000")]
public partial class CQMCommon_4_1_000 : ILibrary, ISingleton<CQMCommon_4_1_000>
{
    private CQMCommon_4_1_000() {}

    public static CQMCommon_4_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CQMCommon";
    public string Version => "4.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheToken, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            if (cqlContext.CacheToken is null)
            {
                // No caching
                CacheToken = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheToken, cqlContext.CacheToken))
            {
                return CachedValue;
            }
            else
            {
                var value = factory();
                CachedValue = value;
                CacheToken = cqlContext.CacheToken;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Outpatient Surgery Service", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", valueSetVersion: null)]
    public CqlValueSet Outpatient_Surgery_Service(CqlContext _) => _Outpatient_Surgery_Service;
    private static readonly CqlValueSet _Outpatient_Surgery_Service = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Billing", codeId: "billing", codeSystem: "http://terminology.hl7.org/CodeSystem/diagnosis-role")]
    public CqlCode Billing(CqlContext _) => _Billing;
    private static readonly CqlCode _Billing = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role");

    [CqlCodeDefinition("Admitting Diagnosis", codeId: "admitting", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Admitting_Diagnosis(CqlContext _) => _Admitting_Diagnosis;
    private static readonly CqlCode _Admitting_Diagnosis = new CqlCode("admitting", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Clinical Diagnosis", codeId: "clinical", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Clinical_Diagnosis(CqlContext _) => _Clinical_Diagnosis;
    private static readonly CqlCode _Clinical_Diagnosis = new CqlCode("clinical", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Differential Diagnosis", codeId: "differential", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Differential_Diagnosis(CqlContext _) => _Differential_Diagnosis;
    private static readonly CqlCode _Differential_Diagnosis = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Discharge Diagnosis", codeId: "discharge", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Discharge_Diagnosis(CqlContext _) => _Discharge_Diagnosis;
    private static readonly CqlCode _Discharge_Diagnosis = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Laboratory Diagnosis", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Laboratory_Diagnosis(CqlContext _) => _Laboratory_Diagnosis;
    private static readonly CqlCode _Laboratory_Diagnosis = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Nursing Diagnosis", codeId: "nursing", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Nursing_Diagnosis(CqlContext _) => _Nursing_Diagnosis;
    private static readonly CqlCode _Nursing_Diagnosis = new CqlCode("nursing", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Prenatal Diagnosis", codeId: "prenatal", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Prenatal_Diagnosis(CqlContext _) => _Prenatal_Diagnosis;
    private static readonly CqlCode _Prenatal_Diagnosis = new CqlCode("prenatal", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Principal Diagnosis", codeId: "principal", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Principal_Diagnosis(CqlContext _) => _Principal_Diagnosis;
    private static readonly CqlCode _Principal_Diagnosis = new CqlCode("principal", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Radiology Diagnosis", codeId: "radiology", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Radiology_Diagnosis(CqlContext _) => _Radiology_Diagnosis;
    private static readonly CqlCode _Radiology_Diagnosis = new CqlCode("radiology", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Remote Diagnosis", codeId: "remote", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Remote_Diagnosis(CqlContext _) => _Remote_Diagnosis;
    private static readonly CqlCode _Remote_Diagnosis = new CqlCode("remote", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Retrospective Diagnosis", codeId: "retrospective", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Retrospective_Diagnosis(CqlContext _) => _Retrospective_Diagnosis;
    private static readonly CqlCode _Retrospective_Diagnosis = new CqlCode("retrospective", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Self Diagnosis", codeId: "self", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Self_Diagnosis(CqlContext _) => _Self_Diagnosis;
    private static readonly CqlCode _Self_Diagnosis = new CqlCode("self", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Primary procedure", codeId: "primary", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-procedure-type")]
    public CqlCode Primary_procedure(CqlContext _) => _Primary_procedure;
    private static readonly CqlCode _Primary_procedure = new CqlCode("primary", "http://terminology.hl7.org/CodeSystem/ex-procedure-type");

    [CqlCodeDefinition("POA-Y", codeId: "Y", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_Y(CqlContext _) => _POA_Y;
    private static readonly CqlCode _POA_Y = new CqlCode("Y", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    [CqlCodeDefinition("POA-N", codeId: "N", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_N(CqlContext _) => _POA_N;
    private static readonly CqlCode _POA_N = new CqlCode("N", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    [CqlCodeDefinition("POA-W", codeId: "W", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_W(CqlContext _) => _POA_W;
    private static readonly CqlCode _POA_W = new CqlCode("W", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    [CqlCodeDefinition("POA-1", codeId: "1", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_1(CqlContext _) => _POA_1;
    private static readonly CqlCode _POA_1 = new CqlCode("1", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    [CqlCodeDefinition("POA-U", codeId: "U", codeSystem: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding")]
    public CqlCode POA_U(CqlContext _) => _POA_U;
    private static readonly CqlCode _POA_U = new CqlCode("U", "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("DiagnosisRole", codeSystemId: "http://terminology.hl7.org/CodeSystem/diagnosis-role", codeSystemVersion: null)]
    public CqlCodeSystem DiagnosisRole(CqlContext _) => _DiagnosisRole;
    private static readonly CqlCodeSystem _DiagnosisRole =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/diagnosis-role", null, [
          _Billing]);

    [CqlCodeSystemDefinition("Diagnosis Type", codeSystemId: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype", codeSystemVersion: null)]
    public CqlCodeSystem Diagnosis_Type(CqlContext _) => _Diagnosis_Type;
    private static readonly CqlCodeSystem _Diagnosis_Type =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/ex-diagnosistype", null, [
          _Admitting_Diagnosis,
          _Clinical_Diagnosis,
          _Differential_Diagnosis,
          _Discharge_Diagnosis,
          _Laboratory_Diagnosis,
          _Nursing_Diagnosis,
          _Prenatal_Diagnosis,
          _Principal_Diagnosis,
          _Radiology_Diagnosis,
          _Remote_Diagnosis,
          _Retrospective_Diagnosis,
          _Self_Diagnosis]);

    [CqlCodeSystemDefinition("Procedure Type", codeSystemId: "http://terminology.hl7.org/CodeSystem/ex-procedure-type", codeSystemVersion: null)]
    public CqlCodeSystem Procedure_Type(CqlContext _) => _Procedure_Type;
    private static readonly CqlCodeSystem _Procedure_Type =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/ex-procedure-type", null, [
          _Primary_procedure]);

    [CqlCodeSystemDefinition("Present On Admission Indicators", codeSystemId: "https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding", codeSystemVersion: null)]
    public CqlCodeSystem Present_On_Admission_Indicators(CqlContext _) => _Present_On_Admission_Indicators;
    private static readonly CqlCodeSystem _Present_On_Admission_Indicators =
      new CqlCodeSystem("https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding", null, [
          _POA_Y,
          _POA_N,
          _POA_W,
          _POA_1,
          _POA_U]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CQMCommon-4.1.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Inpatient_Encounter_Cached = new();

    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context) =>
        _Inpatient_Encounter_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Encounter_Inpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? c_(Encounter EncounterInpatient)
                {
                    Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
                    Encounter.EncounterStatus? f_ = e_?.Value;
                    Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
                    bool? h_ = context.Operators.Equal(g_, "finished");
                    Period i_ = EncounterInpatient?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlDateTime k_ = context.Operators.End(j_);
                    CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                    bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
                    bool? n_ = context.Operators.And(h_, m_);
                    return n_;
                };
                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                return d_;
            });


    [CqlFunctionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDate b_ = context.Operators.DateFrom(a_);
        CqlDateTime c_ = context.Operators.End(period);
        CqlDate d_ = context.Operators.DateFrom(c_);
        CqlInterval<CqlDate> e_ = context.Operators.Interval(b_, d_, true, true);
        return e_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlFunctionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlFunctionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? i_ = h_?.Value;
            Code<Encounter.EncounterStatus> j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "finished");
            Period l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            Period o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(x_, ab_);
            bool? ad_ = context.Operators.And(k_, ac_);
            return ad_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        object e_(Encounter @this)
        {
            Period ae_ = @this?.Period;
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.End(af_);
            return ag_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter g_ = context.Operators.Last<Encounter>(f_);
        return g_;
    }


    [CqlFunctionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter edVisit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? i_ = h_?.Value;
            Code<Encounter.EncounterStatus> j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "finished");
            Period l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            Period o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, default);
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(x_, ab_);
            bool? ad_ = context.Operators.And(k_, ac_);
            return ad_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        object e_(Encounter @this)
        {
            Period ae_ = @this?.Period;
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.End(af_);
            return ag_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter g_ = context.Operators.Last<Encounter>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        CqlInterval<CqlDateTime> c_(Encounter X)
        {
            CqlInterval<CqlDateTime> g_()
            {
                if (X is null)
                {
                    Period h_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                    return i_;
                }
                else
                {
                    Period j_ = X?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    Period m_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, false);
                    return p_;
                }
            };
            return g_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);
        CqlInterval<CqlDateTime> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.edVisit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        CqlInterval<CqlDateTime> c_(Encounter X)
        {
            CqlInterval<CqlDateTime> g_()
            {
                if (X is null)
                {
                    Period h_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                    return i_;
                }
                else
                {
                    Period j_ = X?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    Period m_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, true);
                    return p_;
                }
            };
            return g_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);
        CqlInterval<CqlDateTime> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> g_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                    return (IEnumerable<Encounter.LocationComponent>)h_;
                }
                else
                {
                    List<Encounter.LocationComponent> i_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> j_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] k_ = [
                        (IEnumerable<Encounter.LocationComponent>)i_,
                        (IEnumerable<Encounter.LocationComponent>)j_,
                    ];
                    IEnumerable<Encounter.LocationComponent> l_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)k_);
                    return l_;
                }
            };
            return g_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> e_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent> hospitalizationLocations(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.edVisit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> g_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                    return (IEnumerable<Encounter.LocationComponent>)h_;
                }
                else
                {
                    List<Encounter.LocationComponent> i_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> j_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] k_ = [
                        (IEnumerable<Encounter.LocationComponent>)i_,
                        (IEnumerable<Encounter.LocationComponent>)j_,
                    ];
                    IEnumerable<Encounter.LocationComponent> l_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)k_);
                    return l_;
                }
            };
            return g_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> e_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.hospitalization(context, TheEncounter);
        int? b_ = this.lengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime hospitalAdmissionTime(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.hospitalization(context, TheEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, a_);
        CqlDateTime c_ = context.Operators.End(b_);
        return c_;
    }


    [CqlFunctionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime hospitalDischargeTime(CqlContext context, Encounter TheEncounter)
    {
        Period a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, a_);
        CqlDateTime c_ = context.Operators.End(b_);
        return c_;
    }


    [CqlFunctionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
        object b_(Encounter.LocationComponent @this)
        {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime hospitalArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
        object b_(Encounter.LocationComponent @this)
        {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime Hospital_Departure_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
        object b_(Encounter.LocationComponent @this)
        {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.End(f_);
        return g_;
    }


    [CqlFunctionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime hospitalDepartureTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
        object b_(Encounter.LocationComponent @this)
        {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.End(f_);
        return g_;
    }


    [CqlFunctionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime Emergency_Department_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
        bool? b_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference h_ = HospitalLocation?.Location;
            Location i_ = this.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
        Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? b_(Location L)
        {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        };
        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);
        bool? b_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference h_ = HospitalLocation?.Location;
            Location i_ = this.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
        Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter LastSurgeryOP)
            {
                Period aq_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.End(ar_);
                CqlValueSet at_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> au_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? av_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> dq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? dr_ = dq_?.Value;
                    Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                    bool? dt_ = context.Operators.Equal(ds_, "finished");
                    Period du_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                    CqlDateTime dw_ = context.Operators.End(dv_);
                    CqlValueSet dx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fs_ = fr_?.Value;
                        Code<Encounter.EncounterStatus> ft_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fs_);
                        bool? fu_ = context.Operators.Equal(ft_, "finished");
                        Period fv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                        CqlDateTime fx_ = context.Operators.End(fw_);
                        Period fy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime ga_ = context.Operators.Start(fz_);
                        CqlQuantity gb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gc_ = context.Operators.Subtract(ga_, gb_);
                        CqlInterval<CqlDateTime> ge_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime gf_ = context.Operators.Start(ge_);
                        CqlInterval<CqlDateTime> gg_ = context.Operators.Interval(gc_, gf_, true, true);
                        bool? gh_ = context.Operators.In<CqlDateTime>(fx_, gg_, default);
                        CqlInterval<CqlDateTime> gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime gk_ = context.Operators.Start(gj_);
                        bool? gl_ = context.Operators.Not((bool?)(gk_ is null));
                        bool? gm_ = context.Operators.And(gh_, gl_);
                        bool? gn_ = context.Operators.And(fu_, gm_);
                        return gn_;
                    };
                    IEnumerable<Encounter> ea_ = context.Operators.Where<Encounter>(dy_, dz_);
                    object eb_(Encounter @this)
                    {
                        Period go_ = @this?.Period;
                        CqlInterval<CqlDateTime> gp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, go_);
                        CqlDateTime gq_ = context.Operators.End(gp_);
                        return gq_;
                    };
                    IEnumerable<Encounter> ec_ = context.Operators.SortBy<Encounter>(ea_, eb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ed_ = context.Operators.Last<Encounter>(ec_);
                    Period ee_ = ed_?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.Start(ef_);
                    Period eh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ei_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime ej_ = context.Operators.Start(ei_);
                    CqlQuantity ek_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime el_ = context.Operators.Subtract(eg_ ?? ej_, ek_);
                    IEnumerable<Encounter> en_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? eo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gs_ = gr_?.Value;
                        Code<Encounter.EncounterStatus> gt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gs_);
                        bool? gu_ = context.Operators.Equal(gt_, "finished");
                        Period gv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gv_);
                        CqlDateTime gx_ = context.Operators.End(gw_);
                        Period gy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime ha_ = context.Operators.Start(gz_);
                        CqlQuantity hb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hc_ = context.Operators.Subtract(ha_, hb_);
                        CqlInterval<CqlDateTime> he_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime hf_ = context.Operators.Start(he_);
                        CqlInterval<CqlDateTime> hg_ = context.Operators.Interval(hc_, hf_, true, true);
                        bool? hh_ = context.Operators.In<CqlDateTime>(gx_, hg_, default);
                        CqlInterval<CqlDateTime> hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime hk_ = context.Operators.Start(hj_);
                        bool? hl_ = context.Operators.Not((bool?)(hk_ is null));
                        bool? hm_ = context.Operators.And(hh_, hl_);
                        bool? hn_ = context.Operators.And(gu_, hm_);
                        return hn_;
                    };
                    IEnumerable<Encounter> ep_ = context.Operators.Where<Encounter>(en_, eo_);
                    object eq_(Encounter @this)
                    {
                        Period ho_ = @this?.Period;
                        CqlInterval<CqlDateTime> hp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ho_);
                        CqlDateTime hq_ = context.Operators.End(hp_);
                        return hq_;
                    };
                    IEnumerable<Encounter> er_ = context.Operators.SortBy<Encounter>(ep_, eq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter es_ = context.Operators.Last<Encounter>(er_);
                    Period et_ = es_?.Period;
                    CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                    CqlDateTime ev_ = context.Operators.Start(eu_);
                    CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime ey_ = context.Operators.Start(ex_);
                    CqlInterval<CqlDateTime> ez_ = context.Operators.Interval(el_, ev_ ?? ey_, true, true);
                    bool? fa_ = context.Operators.In<CqlDateTime>(dw_, ez_, default);
                    IEnumerable<Encounter> fc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hs_ = hr_?.Value;
                        Code<Encounter.EncounterStatus> ht_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hs_);
                        bool? hu_ = context.Operators.Equal(ht_, "finished");
                        Period hv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hv_);
                        CqlDateTime hx_ = context.Operators.End(hw_);
                        Period hy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ia_ = context.Operators.Start(hz_);
                        CqlQuantity ib_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ic_ = context.Operators.Subtract(ia_, ib_);
                        CqlInterval<CqlDateTime> ie_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime if_ = context.Operators.Start(ie_);
                        CqlInterval<CqlDateTime> ig_ = context.Operators.Interval(ic_, if_, true, true);
                        bool? ih_ = context.Operators.In<CqlDateTime>(hx_, ig_, default);
                        CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ik_ = context.Operators.Start(ij_);
                        bool? il_ = context.Operators.Not((bool?)(ik_ is null));
                        bool? im_ = context.Operators.And(ih_, il_);
                        bool? in_ = context.Operators.And(hu_, im_);
                        return in_;
                    };
                    IEnumerable<Encounter> fe_ = context.Operators.Where<Encounter>(fc_, fd_);
                    object ff_(Encounter @this)
                    {
                        Period io_ = @this?.Period;
                        CqlInterval<CqlDateTime> ip_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, io_);
                        CqlDateTime iq_ = context.Operators.End(ip_);
                        return iq_;
                    };
                    IEnumerable<Encounter> fg_ = context.Operators.SortBy<Encounter>(fe_, ff_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fh_ = context.Operators.Last<Encounter>(fg_);
                    Period fi_ = fh_?.Period;
                    CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                    CqlDateTime fk_ = context.Operators.Start(fj_);
                    CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime fn_ = context.Operators.Start(fm_);
                    bool? fo_ = context.Operators.Not((bool?)((fk_ ?? fn_) is null));
                    bool? fp_ = context.Operators.And(fa_, fo_);
                    bool? fq_ = context.Operators.And(dt_, fp_);
                    return fq_;
                };
                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(au_, av_);
                object ax_(Encounter @this)
                {
                    Period ir_ = @this?.Period;
                    CqlInterval<CqlDateTime> is_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ir_);
                    CqlDateTime it_ = context.Operators.End(is_);
                    return it_;
                };
                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlValueSet bd_ = this.Observation_Services(context);
                IEnumerable<Encounter> be_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> iu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? iv_ = iu_?.Value;
                    Code<Encounter.EncounterStatus> iw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iv_);
                    bool? ix_ = context.Operators.Equal(iw_, "finished");
                    Period iy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> iz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iy_);
                    CqlDateTime ja_ = context.Operators.End(iz_);
                    Period jb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime jd_ = context.Operators.Start(jc_);
                    CqlQuantity je_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jf_ = context.Operators.Subtract(jd_, je_);
                    CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime ji_ = context.Operators.Start(jh_);
                    CqlInterval<CqlDateTime> jj_ = context.Operators.Interval(jf_, ji_, true, true);
                    bool? jk_ = context.Operators.In<CqlDateTime>(ja_, jj_, default);
                    CqlInterval<CqlDateTime> jm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime jn_ = context.Operators.Start(jm_);
                    bool? jo_ = context.Operators.Not((bool?)(jn_ is null));
                    bool? jp_ = context.Operators.And(jk_, jo_);
                    bool? jq_ = context.Operators.And(ix_, jp_);
                    return jq_;
                };
                IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(be_, bf_);
                object bh_(Encounter @this)
                {
                    Period jr_ = @this?.Period;
                    CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                    CqlDateTime jt_ = context.Operators.End(js_);
                    return jt_;
                };
                IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bj_ = context.Operators.Last<Encounter>(bi_);
                Period bk_ = bj_?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                Period bn_ = Visit?.Period;
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlQuantity bq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime br_ = context.Operators.Subtract(bc_ ?? bm_ ?? bp_, bq_);
                IEnumerable<Encounter> bt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bu_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> ju_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? jv_ = ju_?.Value;
                    Code<Encounter.EncounterStatus> jw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jv_);
                    bool? jx_ = context.Operators.Equal(jw_, "finished");
                    Period jy_ = LastED?.Period;
                    CqlInterval<CqlDateTime> jz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jy_);
                    CqlDateTime ka_ = context.Operators.End(jz_);
                    CqlValueSet kb_ = this.Observation_Services(context);
                    IEnumerable<Encounter> kc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lw_ = lv_?.Value;
                        Code<Encounter.EncounterStatus> lx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lw_);
                        bool? ly_ = context.Operators.Equal(lx_, "finished");
                        Period lz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                        CqlDateTime mb_ = context.Operators.End(ma_);
                        Period mc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> md_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime me_ = context.Operators.Start(md_);
                        CqlQuantity mf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mg_ = context.Operators.Subtract(me_, mf_);
                        CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime mj_ = context.Operators.Start(mi_);
                        CqlInterval<CqlDateTime> mk_ = context.Operators.Interval(mg_, mj_, true, true);
                        bool? ml_ = context.Operators.In<CqlDateTime>(mb_, mk_, default);
                        CqlInterval<CqlDateTime> mn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime mo_ = context.Operators.Start(mn_);
                        bool? mp_ = context.Operators.Not((bool?)(mo_ is null));
                        bool? mq_ = context.Operators.And(ml_, mp_);
                        bool? mr_ = context.Operators.And(ly_, mq_);
                        return mr_;
                    };
                    IEnumerable<Encounter> ke_ = context.Operators.Where<Encounter>(kc_, kd_);
                    object kf_(Encounter @this)
                    {
                        Period ms_ = @this?.Period;
                        CqlInterval<CqlDateTime> mt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ms_);
                        CqlDateTime mu_ = context.Operators.End(mt_);
                        return mu_;
                    };
                    IEnumerable<Encounter> kg_ = context.Operators.SortBy<Encounter>(ke_, kf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kh_ = context.Operators.Last<Encounter>(kg_);
                    Period ki_ = kh_?.Period;
                    CqlInterval<CqlDateTime> kj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ki_);
                    CqlDateTime kk_ = context.Operators.Start(kj_);
                    Period kl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> km_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime kn_ = context.Operators.Start(km_);
                    CqlQuantity ko_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kp_ = context.Operators.Subtract(kk_ ?? kn_, ko_);
                    IEnumerable<Encounter> kr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ks_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mw_ = mv_?.Value;
                        Code<Encounter.EncounterStatus> mx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mw_);
                        bool? my_ = context.Operators.Equal(mx_, "finished");
                        Period mz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> na_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mz_);
                        CqlDateTime nb_ = context.Operators.End(na_);
                        Period nc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime ne_ = context.Operators.Start(nd_);
                        CqlQuantity nf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ng_ = context.Operators.Subtract(ne_, nf_);
                        CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime nj_ = context.Operators.Start(ni_);
                        CqlInterval<CqlDateTime> nk_ = context.Operators.Interval(ng_, nj_, true, true);
                        bool? nl_ = context.Operators.In<CqlDateTime>(nb_, nk_, default);
                        CqlInterval<CqlDateTime> nn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime no_ = context.Operators.Start(nn_);
                        bool? np_ = context.Operators.Not((bool?)(no_ is null));
                        bool? nq_ = context.Operators.And(nl_, np_);
                        bool? nr_ = context.Operators.And(my_, nq_);
                        return nr_;
                    };
                    IEnumerable<Encounter> kt_ = context.Operators.Where<Encounter>(kr_, ks_);
                    object ku_(Encounter @this)
                    {
                        Period ns_ = @this?.Period;
                        CqlInterval<CqlDateTime> nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                        CqlDateTime nu_ = context.Operators.End(nt_);
                        return nu_;
                    };
                    IEnumerable<Encounter> kv_ = context.Operators.SortBy<Encounter>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kw_ = context.Operators.Last<Encounter>(kv_);
                    Period kx_ = kw_?.Period;
                    CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                    CqlDateTime kz_ = context.Operators.Start(ky_);
                    CqlInterval<CqlDateTime> lb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime lc_ = context.Operators.Start(lb_);
                    CqlInterval<CqlDateTime> ld_ = context.Operators.Interval(kp_, kz_ ?? lc_, true, true);
                    bool? le_ = context.Operators.In<CqlDateTime>(ka_, ld_, default);
                    IEnumerable<Encounter> lg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nw_ = nv_?.Value;
                        Code<Encounter.EncounterStatus> nx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nw_);
                        bool? ny_ = context.Operators.Equal(nx_, "finished");
                        Period nz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> oa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nz_);
                        CqlDateTime ob_ = context.Operators.End(oa_);
                        Period oc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> od_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oe_ = context.Operators.Start(od_);
                        CqlQuantity of_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime og_ = context.Operators.Subtract(oe_, of_);
                        CqlInterval<CqlDateTime> oi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oj_ = context.Operators.Start(oi_);
                        CqlInterval<CqlDateTime> ok_ = context.Operators.Interval(og_, oj_, true, true);
                        bool? ol_ = context.Operators.In<CqlDateTime>(ob_, ok_, default);
                        CqlInterval<CqlDateTime> on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oo_ = context.Operators.Start(on_);
                        bool? op_ = context.Operators.Not((bool?)(oo_ is null));
                        bool? oq_ = context.Operators.And(ol_, op_);
                        bool? or_ = context.Operators.And(ny_, oq_);
                        return or_;
                    };
                    IEnumerable<Encounter> li_ = context.Operators.Where<Encounter>(lg_, lh_);
                    object lj_(Encounter @this)
                    {
                        Period os_ = @this?.Period;
                        CqlInterval<CqlDateTime> ot_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, os_);
                        CqlDateTime ou_ = context.Operators.End(ot_);
                        return ou_;
                    };
                    IEnumerable<Encounter> lk_ = context.Operators.SortBy<Encounter>(li_, lj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ll_ = context.Operators.Last<Encounter>(lk_);
                    Period lm_ = ll_?.Period;
                    CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lm_);
                    CqlDateTime lo_ = context.Operators.Start(ln_);
                    CqlInterval<CqlDateTime> lq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime lr_ = context.Operators.Start(lq_);
                    bool? ls_ = context.Operators.Not((bool?)((lo_ ?? lr_) is null));
                    bool? lt_ = context.Operators.And(le_, ls_);
                    bool? lu_ = context.Operators.And(jx_, lt_);
                    return lu_;
                };
                IEnumerable<Encounter> bv_ = context.Operators.Where<Encounter>(bt_, bu_);
                object bw_(Encounter @this)
                {
                    Period ov_ = @this?.Period;
                    CqlInterval<CqlDateTime> ow_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ov_);
                    CqlDateTime ox_ = context.Operators.End(ow_);
                    return ox_;
                };
                IEnumerable<Encounter> bx_ = context.Operators.SortBy<Encounter>(bv_, bw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter by_ = context.Operators.Last<Encounter>(bx_);
                Period bz_ = by_?.Period;
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                CqlDateTime cb_ = context.Operators.Start(ca_);
                IEnumerable<Encounter> cd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ce_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> oy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? oz_ = oy_?.Value;
                    Code<Encounter.EncounterStatus> pa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oz_);
                    bool? pb_ = context.Operators.Equal(pa_, "finished");
                    Period pc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pc_);
                    CqlDateTime pe_ = context.Operators.End(pd_);
                    Period pf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime ph_ = context.Operators.Start(pg_);
                    CqlQuantity pi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pj_ = context.Operators.Subtract(ph_, pi_);
                    CqlInterval<CqlDateTime> pl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime pm_ = context.Operators.Start(pl_);
                    CqlInterval<CqlDateTime> pn_ = context.Operators.Interval(pj_, pm_, true, true);
                    bool? po_ = context.Operators.In<CqlDateTime>(pe_, pn_, default);
                    CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime pr_ = context.Operators.Start(pq_);
                    bool? ps_ = context.Operators.Not((bool?)(pr_ is null));
                    bool? pt_ = context.Operators.And(po_, ps_);
                    bool? pu_ = context.Operators.And(pb_, pt_);
                    return pu_;
                };
                IEnumerable<Encounter> cf_ = context.Operators.Where<Encounter>(cd_, ce_);
                object cg_(Encounter @this)
                {
                    Period pv_ = @this?.Period;
                    CqlInterval<CqlDateTime> pw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pv_);
                    CqlDateTime px_ = context.Operators.End(pw_);
                    return px_;
                };
                IEnumerable<Encounter> ch_ = context.Operators.SortBy<Encounter>(cf_, cg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ci_ = context.Operators.Last<Encounter>(ch_);
                Period cj_ = ci_?.Period;
                CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(br_, cb_ ?? cl_ ?? co_, true, true);
                bool? cq_ = context.Operators.In<CqlDateTime>(as_, cp_, default);
                IEnumerable<Encounter> cs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ct_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> py_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? pz_ = py_?.Value;
                    Code<Encounter.EncounterStatus> qa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pz_);
                    bool? qb_ = context.Operators.Equal(qa_, "finished");
                    Period qc_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qc_);
                    CqlDateTime qe_ = context.Operators.End(qd_);
                    CqlValueSet qf_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? sa_ = rz_?.Value;
                        Code<Encounter.EncounterStatus> sb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sa_);
                        bool? sc_ = context.Operators.Equal(sb_, "finished");
                        Period sd_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> se_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sd_);
                        CqlDateTime sf_ = context.Operators.End(se_);
                        Period sg_ = Visit?.Period;
                        CqlInterval<CqlDateTime> sh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime si_ = context.Operators.Start(sh_);
                        CqlQuantity sj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime sk_ = context.Operators.Subtract(si_, sj_);
                        CqlInterval<CqlDateTime> sm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime sn_ = context.Operators.Start(sm_);
                        CqlInterval<CqlDateTime> so_ = context.Operators.Interval(sk_, sn_, true, true);
                        bool? sp_ = context.Operators.In<CqlDateTime>(sf_, so_, default);
                        CqlInterval<CqlDateTime> sr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime ss_ = context.Operators.Start(sr_);
                        bool? st_ = context.Operators.Not((bool?)(ss_ is null));
                        bool? su_ = context.Operators.And(sp_, st_);
                        bool? sv_ = context.Operators.And(sc_, su_);
                        return sv_;
                    };
                    IEnumerable<Encounter> qi_ = context.Operators.Where<Encounter>(qg_, qh_);
                    object qj_(Encounter @this)
                    {
                        Period sw_ = @this?.Period;
                        CqlInterval<CqlDateTime> sx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sw_);
                        CqlDateTime sy_ = context.Operators.End(sx_);
                        return sy_;
                    };
                    IEnumerable<Encounter> qk_ = context.Operators.SortBy<Encounter>(qi_, qj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ql_ = context.Operators.Last<Encounter>(qk_);
                    Period qm_ = ql_?.Period;
                    CqlInterval<CqlDateTime> qn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qm_);
                    CqlDateTime qo_ = context.Operators.Start(qn_);
                    Period qp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime qr_ = context.Operators.Start(qq_);
                    CqlQuantity qs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qt_ = context.Operators.Subtract(qo_ ?? qr_, qs_);
                    IEnumerable<Encounter> qv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> sz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ta_ = sz_?.Value;
                        Code<Encounter.EncounterStatus> tb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ta_);
                        bool? tc_ = context.Operators.Equal(tb_, "finished");
                        Period td_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> te_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, td_);
                        CqlDateTime tf_ = context.Operators.End(te_);
                        Period tg_ = Visit?.Period;
                        CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ti_ = context.Operators.Start(th_);
                        CqlQuantity tj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tk_ = context.Operators.Subtract(ti_, tj_);
                        CqlInterval<CqlDateTime> tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime tn_ = context.Operators.Start(tm_);
                        CqlInterval<CqlDateTime> to_ = context.Operators.Interval(tk_, tn_, true, true);
                        bool? tp_ = context.Operators.In<CqlDateTime>(tf_, to_, default);
                        CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ts_ = context.Operators.Start(tr_);
                        bool? tt_ = context.Operators.Not((bool?)(ts_ is null));
                        bool? tu_ = context.Operators.And(tp_, tt_);
                        bool? tv_ = context.Operators.And(tc_, tu_);
                        return tv_;
                    };
                    IEnumerable<Encounter> qx_ = context.Operators.Where<Encounter>(qv_, qw_);
                    object qy_(Encounter @this)
                    {
                        Period tw_ = @this?.Period;
                        CqlInterval<CqlDateTime> tx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tw_);
                        CqlDateTime ty_ = context.Operators.End(tx_);
                        return ty_;
                    };
                    IEnumerable<Encounter> qz_ = context.Operators.SortBy<Encounter>(qx_, qy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ra_ = context.Operators.Last<Encounter>(qz_);
                    Period rb_ = ra_?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlInterval<CqlDateTime> rf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime rg_ = context.Operators.Start(rf_);
                    CqlInterval<CqlDateTime> rh_ = context.Operators.Interval(qt_, rd_ ?? rg_, true, true);
                    bool? ri_ = context.Operators.In<CqlDateTime>(qe_, rh_, default);
                    IEnumerable<Encounter> rk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ua_ = tz_?.Value;
                        Code<Encounter.EncounterStatus> ub_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ua_);
                        bool? uc_ = context.Operators.Equal(ub_, "finished");
                        Period ud_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ue_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ud_);
                        CqlDateTime uf_ = context.Operators.End(ue_);
                        Period ug_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime ui_ = context.Operators.Start(uh_);
                        CqlQuantity uj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uk_ = context.Operators.Subtract(ui_, uj_);
                        CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime un_ = context.Operators.Start(um_);
                        CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(uk_, un_, true, true);
                        bool? up_ = context.Operators.In<CqlDateTime>(uf_, uo_, default);
                        CqlInterval<CqlDateTime> ur_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime us_ = context.Operators.Start(ur_);
                        bool? ut_ = context.Operators.Not((bool?)(us_ is null));
                        bool? uu_ = context.Operators.And(up_, ut_);
                        bool? uv_ = context.Operators.And(uc_, uu_);
                        return uv_;
                    };
                    IEnumerable<Encounter> rm_ = context.Operators.Where<Encounter>(rk_, rl_);
                    object rn_(Encounter @this)
                    {
                        Period uw_ = @this?.Period;
                        CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                        CqlDateTime uy_ = context.Operators.End(ux_);
                        return uy_;
                    };
                    IEnumerable<Encounter> ro_ = context.Operators.SortBy<Encounter>(rm_, rn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rp_ = context.Operators.Last<Encounter>(ro_);
                    Period rq_ = rp_?.Period;
                    CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rq_);
                    CqlDateTime rs_ = context.Operators.Start(rr_);
                    CqlInterval<CqlDateTime> ru_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime rv_ = context.Operators.Start(ru_);
                    bool? rw_ = context.Operators.Not((bool?)((rs_ ?? rv_) is null));
                    bool? rx_ = context.Operators.And(ri_, rw_);
                    bool? ry_ = context.Operators.And(qb_, rx_);
                    return ry_;
                };
                IEnumerable<Encounter> cu_ = context.Operators.Where<Encounter>(cs_, ct_);
                object cv_(Encounter @this)
                {
                    Period uz_ = @this?.Period;
                    CqlInterval<CqlDateTime> va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                    CqlDateTime vb_ = context.Operators.End(va_);
                    return vb_;
                };
                IEnumerable<Encounter> cw_ = context.Operators.SortBy<Encounter>(cu_, cv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cx_ = context.Operators.Last<Encounter>(cw_);
                Period cy_ = cx_?.Period;
                CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                IEnumerable<Encounter> dc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vd_ = vc_?.Value;
                    Code<Encounter.EncounterStatus> ve_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vd_);
                    bool? vf_ = context.Operators.Equal(ve_, "finished");
                    Period vg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vg_);
                    CqlDateTime vi_ = context.Operators.End(vh_);
                    Period vj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vl_ = context.Operators.Start(vk_);
                    CqlQuantity vm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vn_ = context.Operators.Subtract(vl_, vm_);
                    CqlInterval<CqlDateTime> vp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vq_ = context.Operators.Start(vp_);
                    CqlInterval<CqlDateTime> vr_ = context.Operators.Interval(vn_, vq_, true, true);
                    bool? vs_ = context.Operators.In<CqlDateTime>(vi_, vr_, default);
                    CqlInterval<CqlDateTime> vu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vv_ = context.Operators.Start(vu_);
                    bool? vw_ = context.Operators.Not((bool?)(vv_ is null));
                    bool? vx_ = context.Operators.And(vs_, vw_);
                    bool? vy_ = context.Operators.And(vf_, vx_);
                    return vy_;
                };
                IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(dc_, dd_);
                object df_(Encounter @this)
                {
                    Period vz_ = @this?.Period;
                    CqlInterval<CqlDateTime> wa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vz_);
                    CqlDateTime wb_ = context.Operators.End(wa_);
                    return wb_;
                };
                IEnumerable<Encounter> dg_ = context.Operators.SortBy<Encounter>(de_, df_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dh_ = context.Operators.Last<Encounter>(dg_);
                Period di_ = dh_?.Period;
                CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                CqlDateTime dk_ = context.Operators.Start(dj_);
                CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime dn_ = context.Operators.Start(dm_);
                bool? do_ = context.Operators.Not((bool?)((da_ ?? dk_ ?? dn_) is null));
                bool? dp_ = context.Operators.And(cq_, do_);
                return dp_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period wc_ = @this?.Period;
                CqlInterval<CqlDateTime> wd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wc_);
                CqlDateTime we_ = context.Operators.End(wd_);
                return we_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? r_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> wf_ = LastED?.StatusElement;
                Encounter.EncounterStatus? wg_ = wf_?.Value;
                Code<Encounter.EncounterStatus> wh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wg_);
                bool? wi_ = context.Operators.Equal(wh_, "finished");
                Period wj_ = LastED?.Period;
                CqlInterval<CqlDateTime> wk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wj_);
                CqlDateTime wl_ = context.Operators.End(wk_);
                CqlValueSet wm_ = this.Observation_Services(context);
                IEnumerable<Encounter> wn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> yg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yh_ = yg_?.Value;
                    Code<Encounter.EncounterStatus> yi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yh_);
                    bool? yj_ = context.Operators.Equal(yi_, "finished");
                    Period yk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yk_);
                    CqlDateTime ym_ = context.Operators.End(yl_);
                    Period yn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yp_ = context.Operators.Start(yo_);
                    CqlQuantity yq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yr_ = context.Operators.Subtract(yp_, yq_);
                    CqlInterval<CqlDateTime> yt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yu_ = context.Operators.Start(yt_);
                    CqlInterval<CqlDateTime> yv_ = context.Operators.Interval(yr_, yu_, true, true);
                    bool? yw_ = context.Operators.In<CqlDateTime>(ym_, yv_, default);
                    CqlInterval<CqlDateTime> yy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yz_ = context.Operators.Start(yy_);
                    bool? za_ = context.Operators.Not((bool?)(yz_ is null));
                    bool? zb_ = context.Operators.And(yw_, za_);
                    bool? zc_ = context.Operators.And(yj_, zb_);
                    return zc_;
                };
                IEnumerable<Encounter> wp_ = context.Operators.Where<Encounter>(wn_, wo_);
                object wq_(Encounter @this)
                {
                    Period zd_ = @this?.Period;
                    CqlInterval<CqlDateTime> ze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zd_);
                    CqlDateTime zf_ = context.Operators.End(ze_);
                    return zf_;
                };
                IEnumerable<Encounter> wr_ = context.Operators.SortBy<Encounter>(wp_, wq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ws_ = context.Operators.Last<Encounter>(wr_);
                Period wt_ = ws_?.Period;
                CqlInterval<CqlDateTime> wu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wt_);
                CqlDateTime wv_ = context.Operators.Start(wu_);
                Period ww_ = Visit?.Period;
                CqlInterval<CqlDateTime> wx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime wy_ = context.Operators.Start(wx_);
                CqlQuantity wz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xa_ = context.Operators.Subtract(wv_ ?? wy_, wz_);
                IEnumerable<Encounter> xc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zh_ = zg_?.Value;
                    Code<Encounter.EncounterStatus> zi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zh_);
                    bool? zj_ = context.Operators.Equal(zi_, "finished");
                    Period zk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zk_);
                    CqlDateTime zm_ = context.Operators.End(zl_);
                    Period zn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zp_ = context.Operators.Start(zo_);
                    CqlQuantity zq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zr_ = context.Operators.Subtract(zp_, zq_);
                    CqlInterval<CqlDateTime> zt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zu_ = context.Operators.Start(zt_);
                    CqlInterval<CqlDateTime> zv_ = context.Operators.Interval(zr_, zu_, true, true);
                    bool? zw_ = context.Operators.In<CqlDateTime>(zm_, zv_, default);
                    CqlInterval<CqlDateTime> zy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zz_ = context.Operators.Start(zy_);
                    bool? aza_ = context.Operators.Not((bool?)(zz_ is null));
                    bool? azb_ = context.Operators.And(zw_, aza_);
                    bool? azc_ = context.Operators.And(zj_, azb_);
                    return azc_;
                };
                IEnumerable<Encounter> xe_ = context.Operators.Where<Encounter>(xc_, xd_);
                object xf_(Encounter @this)
                {
                    Period azd_ = @this?.Period;
                    CqlInterval<CqlDateTime> aze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azd_);
                    CqlDateTime azf_ = context.Operators.End(aze_);
                    return azf_;
                };
                IEnumerable<Encounter> xg_ = context.Operators.SortBy<Encounter>(xe_, xf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xh_ = context.Operators.Last<Encounter>(xg_);
                Period xi_ = xh_?.Period;
                CqlInterval<CqlDateTime> xj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xi_);
                CqlDateTime xk_ = context.Operators.Start(xj_);
                CqlInterval<CqlDateTime> xm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime xn_ = context.Operators.Start(xm_);
                CqlInterval<CqlDateTime> xo_ = context.Operators.Interval(xa_, xk_ ?? xn_, true, true);
                bool? xp_ = context.Operators.In<CqlDateTime>(wl_, xo_, default);
                IEnumerable<Encounter> xr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xs_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azh_ = azg_?.Value;
                    Code<Encounter.EncounterStatus> azi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azh_);
                    bool? azj_ = context.Operators.Equal(azi_, "finished");
                    Period azk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azk_);
                    CqlDateTime azm_ = context.Operators.End(azl_);
                    Period azn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azp_ = context.Operators.Start(azo_);
                    CqlQuantity azq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azr_ = context.Operators.Subtract(azp_, azq_);
                    CqlInterval<CqlDateTime> azt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azu_ = context.Operators.Start(azt_);
                    CqlInterval<CqlDateTime> azv_ = context.Operators.Interval(azr_, azu_, true, true);
                    bool? azw_ = context.Operators.In<CqlDateTime>(azm_, azv_, default);
                    CqlInterval<CqlDateTime> azy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azz_ = context.Operators.Start(azy_);
                    bool? bza_ = context.Operators.Not((bool?)(azz_ is null));
                    bool? bzb_ = context.Operators.And(azw_, bza_);
                    bool? bzc_ = context.Operators.And(azj_, bzb_);
                    return bzc_;
                };
                IEnumerable<Encounter> xt_ = context.Operators.Where<Encounter>(xr_, xs_);
                object xu_(Encounter @this)
                {
                    Period bzd_ = @this?.Period;
                    CqlInterval<CqlDateTime> bze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzd_);
                    CqlDateTime bzf_ = context.Operators.End(bze_);
                    return bzf_;
                };
                IEnumerable<Encounter> xv_ = context.Operators.SortBy<Encounter>(xt_, xu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xw_ = context.Operators.Last<Encounter>(xv_);
                Period xx_ = xw_?.Period;
                CqlInterval<CqlDateTime> xy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xx_);
                CqlDateTime xz_ = context.Operators.Start(xy_);
                CqlInterval<CqlDateTime> yb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime yc_ = context.Operators.Start(yb_);
                bool? yd_ = context.Operators.Not((bool?)((xz_ ?? yc_) is null));
                bool? ye_ = context.Operators.And(xp_, yd_);
                bool? yf_ = context.Operators.And(wi_, ye_);
                return yf_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period bzg_ = @this?.Period;
                CqlInterval<CqlDateTime> bzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzg_);
                CqlDateTime bzi_ = context.Operators.End(bzh_);
                return bzi_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlValueSet z_ = this.Observation_Services(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ab_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> bzj_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? bzk_ = bzj_?.Value;
                Code<Encounter.EncounterStatus> bzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzk_);
                bool? bzm_ = context.Operators.Equal(bzl_, "finished");
                Period bzn_ = LastObs?.Period;
                CqlInterval<CqlDateTime> bzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzn_);
                CqlDateTime bzp_ = context.Operators.End(bzo_);
                Period bzq_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime bzs_ = context.Operators.Start(bzr_);
                CqlQuantity bzt_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzu_ = context.Operators.Subtract(bzs_, bzt_);
                CqlInterval<CqlDateTime> bzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime bzx_ = context.Operators.Start(bzw_);
                CqlInterval<CqlDateTime> bzy_ = context.Operators.Interval(bzu_, bzx_, true, true);
                bool? bzz_ = context.Operators.In<CqlDateTime>(bzp_, bzy_, default);
                CqlInterval<CqlDateTime> czb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime czc_ = context.Operators.Start(czb_);
                bool? czd_ = context.Operators.Not((bool?)(czc_ is null));
                bool? cze_ = context.Operators.And(bzz_, czd_);
                bool? czf_ = context.Operators.And(bzm_, cze_);
                return czf_;
            };
            IEnumerable<Encounter> ac_ = context.Operators.Where<Encounter>(aa_, ab_);
            object ad_(Encounter @this)
            {
                Period czg_ = @this?.Period;
                CqlInterval<CqlDateTime> czh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czg_);
                CqlDateTime czi_ = context.Operators.End(czh_);
                return czi_;
            };
            IEnumerable<Encounter> ae_ = context.Operators.SortBy<Encounter>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter af_ = context.Operators.Last<Encounter>(ae_);
            Period ag_ = af_?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            Period aj_ = Visit?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(o_ ?? y_ ?? ai_ ?? al_, ao_, true, true);
            return ap_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter LastSurgeryOP)
            {
                Period aq_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.End(ar_);
                CqlValueSet at_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> au_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? av_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> dq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? dr_ = dq_?.Value;
                    Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                    bool? dt_ = context.Operators.Equal(ds_, "finished");
                    Period du_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                    CqlDateTime dw_ = context.Operators.End(dv_);
                    CqlValueSet dx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? dz_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> fr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fs_ = fr_?.Value;
                        Code<Encounter.EncounterStatus> ft_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fs_);
                        bool? fu_ = context.Operators.Equal(ft_, "finished");
                        Period fv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                        CqlDateTime fx_ = context.Operators.End(fw_);
                        Period fy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime ga_ = context.Operators.Start(fz_);
                        CqlQuantity gb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gc_ = context.Operators.Subtract(ga_, gb_);
                        CqlInterval<CqlDateTime> ge_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime gf_ = context.Operators.Start(ge_);
                        CqlInterval<CqlDateTime> gg_ = context.Operators.Interval(gc_, gf_, true, true);
                        bool? gh_ = context.Operators.In<CqlDateTime>(fx_, gg_, default);
                        CqlInterval<CqlDateTime> gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                        CqlDateTime gk_ = context.Operators.Start(gj_);
                        bool? gl_ = context.Operators.Not((bool?)(gk_ is null));
                        bool? gm_ = context.Operators.And(gh_, gl_);
                        bool? gn_ = context.Operators.And(fu_, gm_);
                        return gn_;
                    };
                    IEnumerable<Encounter> ea_ = context.Operators.Where<Encounter>(dy_, dz_);
                    object eb_(Encounter @this)
                    {
                        Period go_ = @this?.Period;
                        CqlInterval<CqlDateTime> gp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, go_);
                        CqlDateTime gq_ = context.Operators.End(gp_);
                        return gq_;
                    };
                    IEnumerable<Encounter> ec_ = context.Operators.SortBy<Encounter>(ea_, eb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ed_ = context.Operators.Last<Encounter>(ec_);
                    Period ee_ = ed_?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.Start(ef_);
                    Period eh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ei_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime ej_ = context.Operators.Start(ei_);
                    CqlQuantity ek_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime el_ = context.Operators.Subtract(eg_ ?? ej_, ek_);
                    IEnumerable<Encounter> en_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? eo_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> gr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gs_ = gr_?.Value;
                        Code<Encounter.EncounterStatus> gt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gs_);
                        bool? gu_ = context.Operators.Equal(gt_, "finished");
                        Period gv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gv_);
                        CqlDateTime gx_ = context.Operators.End(gw_);
                        Period gy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime ha_ = context.Operators.Start(gz_);
                        CqlQuantity hb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hc_ = context.Operators.Subtract(ha_, hb_);
                        CqlInterval<CqlDateTime> he_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime hf_ = context.Operators.Start(he_);
                        CqlInterval<CqlDateTime> hg_ = context.Operators.Interval(hc_, hf_, true, true);
                        bool? hh_ = context.Operators.In<CqlDateTime>(gx_, hg_, default);
                        CqlInterval<CqlDateTime> hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                        CqlDateTime hk_ = context.Operators.Start(hj_);
                        bool? hl_ = context.Operators.Not((bool?)(hk_ is null));
                        bool? hm_ = context.Operators.And(hh_, hl_);
                        bool? hn_ = context.Operators.And(gu_, hm_);
                        return hn_;
                    };
                    IEnumerable<Encounter> ep_ = context.Operators.Where<Encounter>(en_, eo_);
                    object eq_(Encounter @this)
                    {
                        Period ho_ = @this?.Period;
                        CqlInterval<CqlDateTime> hp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ho_);
                        CqlDateTime hq_ = context.Operators.End(hp_);
                        return hq_;
                    };
                    IEnumerable<Encounter> er_ = context.Operators.SortBy<Encounter>(ep_, eq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter es_ = context.Operators.Last<Encounter>(er_);
                    Period et_ = es_?.Period;
                    CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                    CqlDateTime ev_ = context.Operators.Start(eu_);
                    CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime ey_ = context.Operators.Start(ex_);
                    CqlInterval<CqlDateTime> ez_ = context.Operators.Interval(el_, ev_ ?? ey_, true, true);
                    bool? fa_ = context.Operators.In<CqlDateTime>(dw_, ez_, default);
                    IEnumerable<Encounter> fc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? fd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> hr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? hs_ = hr_?.Value;
                        Code<Encounter.EncounterStatus> ht_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hs_);
                        bool? hu_ = context.Operators.Equal(ht_, "finished");
                        Period hv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> hw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hv_);
                        CqlDateTime hx_ = context.Operators.End(hw_);
                        Period hy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ia_ = context.Operators.Start(hz_);
                        CqlQuantity ib_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ic_ = context.Operators.Subtract(ia_, ib_);
                        CqlInterval<CqlDateTime> ie_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime if_ = context.Operators.Start(ie_);
                        CqlInterval<CqlDateTime> ig_ = context.Operators.Interval(ic_, if_, true, true);
                        bool? ih_ = context.Operators.In<CqlDateTime>(hx_, ig_, default);
                        CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ik_ = context.Operators.Start(ij_);
                        bool? il_ = context.Operators.Not((bool?)(ik_ is null));
                        bool? im_ = context.Operators.And(ih_, il_);
                        bool? in_ = context.Operators.And(hu_, im_);
                        return in_;
                    };
                    IEnumerable<Encounter> fe_ = context.Operators.Where<Encounter>(fc_, fd_);
                    object ff_(Encounter @this)
                    {
                        Period io_ = @this?.Period;
                        CqlInterval<CqlDateTime> ip_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, io_);
                        CqlDateTime iq_ = context.Operators.End(ip_);
                        return iq_;
                    };
                    IEnumerable<Encounter> fg_ = context.Operators.SortBy<Encounter>(fe_, ff_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter fh_ = context.Operators.Last<Encounter>(fg_);
                    Period fi_ = fh_?.Period;
                    CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                    CqlDateTime fk_ = context.Operators.Start(fj_);
                    CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime fn_ = context.Operators.Start(fm_);
                    bool? fo_ = context.Operators.Not((bool?)((fk_ ?? fn_) is null));
                    bool? fp_ = context.Operators.And(fa_, fo_);
                    bool? fq_ = context.Operators.And(dt_, fp_);
                    return fq_;
                };
                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(au_, av_);
                object ax_(Encounter @this)
                {
                    Period ir_ = @this?.Period;
                    CqlInterval<CqlDateTime> is_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ir_);
                    CqlDateTime it_ = context.Operators.End(is_);
                    return it_;
                };
                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlValueSet bd_ = this.Observation_Services(context);
                IEnumerable<Encounter> be_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bf_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> iu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? iv_ = iu_?.Value;
                    Code<Encounter.EncounterStatus> iw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iv_);
                    bool? ix_ = context.Operators.Equal(iw_, "finished");
                    Period iy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> iz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iy_);
                    CqlDateTime ja_ = context.Operators.End(iz_);
                    Period jb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> jc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime jd_ = context.Operators.Start(jc_);
                    CqlQuantity je_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime jf_ = context.Operators.Subtract(jd_, je_);
                    CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime ji_ = context.Operators.Start(jh_);
                    CqlInterval<CqlDateTime> jj_ = context.Operators.Interval(jf_, ji_, true, true);
                    bool? jk_ = context.Operators.In<CqlDateTime>(ja_, jj_, default);
                    CqlInterval<CqlDateTime> jm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jb_);
                    CqlDateTime jn_ = context.Operators.Start(jm_);
                    bool? jo_ = context.Operators.Not((bool?)(jn_ is null));
                    bool? jp_ = context.Operators.And(jk_, jo_);
                    bool? jq_ = context.Operators.And(ix_, jp_);
                    return jq_;
                };
                IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(be_, bf_);
                object bh_(Encounter @this)
                {
                    Period jr_ = @this?.Period;
                    CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                    CqlDateTime jt_ = context.Operators.End(js_);
                    return jt_;
                };
                IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bj_ = context.Operators.Last<Encounter>(bi_);
                Period bk_ = bj_?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                Period bn_ = Visit?.Period;
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlQuantity bq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime br_ = context.Operators.Subtract(bc_ ?? bm_ ?? bp_, bq_);
                IEnumerable<Encounter> bt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bu_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> ju_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? jv_ = ju_?.Value;
                    Code<Encounter.EncounterStatus> jw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jv_);
                    bool? jx_ = context.Operators.Equal(jw_, "finished");
                    Period jy_ = LastED?.Period;
                    CqlInterval<CqlDateTime> jz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jy_);
                    CqlDateTime ka_ = context.Operators.End(jz_);
                    CqlValueSet kb_ = this.Observation_Services(context);
                    IEnumerable<Encounter> kc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? kd_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> lv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lw_ = lv_?.Value;
                        Code<Encounter.EncounterStatus> lx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lw_);
                        bool? ly_ = context.Operators.Equal(lx_, "finished");
                        Period lz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                        CqlDateTime mb_ = context.Operators.End(ma_);
                        Period mc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> md_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime me_ = context.Operators.Start(md_);
                        CqlQuantity mf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mg_ = context.Operators.Subtract(me_, mf_);
                        CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime mj_ = context.Operators.Start(mi_);
                        CqlInterval<CqlDateTime> mk_ = context.Operators.Interval(mg_, mj_, true, true);
                        bool? ml_ = context.Operators.In<CqlDateTime>(mb_, mk_, default);
                        CqlInterval<CqlDateTime> mn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                        CqlDateTime mo_ = context.Operators.Start(mn_);
                        bool? mp_ = context.Operators.Not((bool?)(mo_ is null));
                        bool? mq_ = context.Operators.And(ml_, mp_);
                        bool? mr_ = context.Operators.And(ly_, mq_);
                        return mr_;
                    };
                    IEnumerable<Encounter> ke_ = context.Operators.Where<Encounter>(kc_, kd_);
                    object kf_(Encounter @this)
                    {
                        Period ms_ = @this?.Period;
                        CqlInterval<CqlDateTime> mt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ms_);
                        CqlDateTime mu_ = context.Operators.End(mt_);
                        return mu_;
                    };
                    IEnumerable<Encounter> kg_ = context.Operators.SortBy<Encounter>(ke_, kf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kh_ = context.Operators.Last<Encounter>(kg_);
                    Period ki_ = kh_?.Period;
                    CqlInterval<CqlDateTime> kj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ki_);
                    CqlDateTime kk_ = context.Operators.Start(kj_);
                    Period kl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> km_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime kn_ = context.Operators.Start(km_);
                    CqlQuantity ko_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kp_ = context.Operators.Subtract(kk_ ?? kn_, ko_);
                    IEnumerable<Encounter> kr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? ks_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> mv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? mw_ = mv_?.Value;
                        Code<Encounter.EncounterStatus> mx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mw_);
                        bool? my_ = context.Operators.Equal(mx_, "finished");
                        Period mz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> na_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mz_);
                        CqlDateTime nb_ = context.Operators.End(na_);
                        Period nc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> nd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime ne_ = context.Operators.Start(nd_);
                        CqlQuantity nf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ng_ = context.Operators.Subtract(ne_, nf_);
                        CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime nj_ = context.Operators.Start(ni_);
                        CqlInterval<CqlDateTime> nk_ = context.Operators.Interval(ng_, nj_, true, true);
                        bool? nl_ = context.Operators.In<CqlDateTime>(nb_, nk_, default);
                        CqlInterval<CqlDateTime> nn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nc_);
                        CqlDateTime no_ = context.Operators.Start(nn_);
                        bool? np_ = context.Operators.Not((bool?)(no_ is null));
                        bool? nq_ = context.Operators.And(nl_, np_);
                        bool? nr_ = context.Operators.And(my_, nq_);
                        return nr_;
                    };
                    IEnumerable<Encounter> kt_ = context.Operators.Where<Encounter>(kr_, ks_);
                    object ku_(Encounter @this)
                    {
                        Period ns_ = @this?.Period;
                        CqlInterval<CqlDateTime> nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                        CqlDateTime nu_ = context.Operators.End(nt_);
                        return nu_;
                    };
                    IEnumerable<Encounter> kv_ = context.Operators.SortBy<Encounter>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter kw_ = context.Operators.Last<Encounter>(kv_);
                    Period kx_ = kw_?.Period;
                    CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                    CqlDateTime kz_ = context.Operators.Start(ky_);
                    CqlInterval<CqlDateTime> lb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime lc_ = context.Operators.Start(lb_);
                    CqlInterval<CqlDateTime> ld_ = context.Operators.Interval(kp_, kz_ ?? lc_, true, true);
                    bool? le_ = context.Operators.In<CqlDateTime>(ka_, ld_, default);
                    IEnumerable<Encounter> lg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? lh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> nv_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nw_ = nv_?.Value;
                        Code<Encounter.EncounterStatus> nx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nw_);
                        bool? ny_ = context.Operators.Equal(nx_, "finished");
                        Period nz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> oa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nz_);
                        CqlDateTime ob_ = context.Operators.End(oa_);
                        Period oc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> od_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oe_ = context.Operators.Start(od_);
                        CqlQuantity of_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime og_ = context.Operators.Subtract(oe_, of_);
                        CqlInterval<CqlDateTime> oi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oj_ = context.Operators.Start(oi_);
                        CqlInterval<CqlDateTime> ok_ = context.Operators.Interval(og_, oj_, true, true);
                        bool? ol_ = context.Operators.In<CqlDateTime>(ob_, ok_, default);
                        CqlInterval<CqlDateTime> on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                        CqlDateTime oo_ = context.Operators.Start(on_);
                        bool? op_ = context.Operators.Not((bool?)(oo_ is null));
                        bool? oq_ = context.Operators.And(ol_, op_);
                        bool? or_ = context.Operators.And(ny_, oq_);
                        return or_;
                    };
                    IEnumerable<Encounter> li_ = context.Operators.Where<Encounter>(lg_, lh_);
                    object lj_(Encounter @this)
                    {
                        Period os_ = @this?.Period;
                        CqlInterval<CqlDateTime> ot_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, os_);
                        CqlDateTime ou_ = context.Operators.End(ot_);
                        return ou_;
                    };
                    IEnumerable<Encounter> lk_ = context.Operators.SortBy<Encounter>(li_, lj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ll_ = context.Operators.Last<Encounter>(lk_);
                    Period lm_ = ll_?.Period;
                    CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lm_);
                    CqlDateTime lo_ = context.Operators.Start(ln_);
                    CqlInterval<CqlDateTime> lq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                    CqlDateTime lr_ = context.Operators.Start(lq_);
                    bool? ls_ = context.Operators.Not((bool?)((lo_ ?? lr_) is null));
                    bool? lt_ = context.Operators.And(le_, ls_);
                    bool? lu_ = context.Operators.And(jx_, lt_);
                    return lu_;
                };
                IEnumerable<Encounter> bv_ = context.Operators.Where<Encounter>(bt_, bu_);
                object bw_(Encounter @this)
                {
                    Period ov_ = @this?.Period;
                    CqlInterval<CqlDateTime> ow_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ov_);
                    CqlDateTime ox_ = context.Operators.End(ow_);
                    return ox_;
                };
                IEnumerable<Encounter> bx_ = context.Operators.SortBy<Encounter>(bv_, bw_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter by_ = context.Operators.Last<Encounter>(bx_);
                Period bz_ = by_?.Period;
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                CqlDateTime cb_ = context.Operators.Start(ca_);
                IEnumerable<Encounter> cd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ce_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> oy_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? oz_ = oy_?.Value;
                    Code<Encounter.EncounterStatus> pa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oz_);
                    bool? pb_ = context.Operators.Equal(pa_, "finished");
                    Period pc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> pd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pc_);
                    CqlDateTime pe_ = context.Operators.End(pd_);
                    Period pf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> pg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime ph_ = context.Operators.Start(pg_);
                    CqlQuantity pi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime pj_ = context.Operators.Subtract(ph_, pi_);
                    CqlInterval<CqlDateTime> pl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime pm_ = context.Operators.Start(pl_);
                    CqlInterval<CqlDateTime> pn_ = context.Operators.Interval(pj_, pm_, true, true);
                    bool? po_ = context.Operators.In<CqlDateTime>(pe_, pn_, default);
                    CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                    CqlDateTime pr_ = context.Operators.Start(pq_);
                    bool? ps_ = context.Operators.Not((bool?)(pr_ is null));
                    bool? pt_ = context.Operators.And(po_, ps_);
                    bool? pu_ = context.Operators.And(pb_, pt_);
                    return pu_;
                };
                IEnumerable<Encounter> cf_ = context.Operators.Where<Encounter>(cd_, ce_);
                object cg_(Encounter @this)
                {
                    Period pv_ = @this?.Period;
                    CqlInterval<CqlDateTime> pw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pv_);
                    CqlDateTime px_ = context.Operators.End(pw_);
                    return px_;
                };
                IEnumerable<Encounter> ch_ = context.Operators.SortBy<Encounter>(cf_, cg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ci_ = context.Operators.Last<Encounter>(ch_);
                Period cj_ = ci_?.Period;
                CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                CqlDateTime cl_ = context.Operators.Start(ck_);
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(br_, cb_ ?? cl_ ?? co_, true, true);
                bool? cq_ = context.Operators.In<CqlDateTime>(as_, cp_, default);
                IEnumerable<Encounter> cs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ct_(Encounter LastED)
                {
                    Code<Encounter.EncounterStatus> py_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? pz_ = py_?.Value;
                    Code<Encounter.EncounterStatus> qa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pz_);
                    bool? qb_ = context.Operators.Equal(qa_, "finished");
                    Period qc_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qc_);
                    CqlDateTime qe_ = context.Operators.End(qd_);
                    CqlValueSet qf_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qh_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> rz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? sa_ = rz_?.Value;
                        Code<Encounter.EncounterStatus> sb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sa_);
                        bool? sc_ = context.Operators.Equal(sb_, "finished");
                        Period sd_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> se_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sd_);
                        CqlDateTime sf_ = context.Operators.End(se_);
                        Period sg_ = Visit?.Period;
                        CqlInterval<CqlDateTime> sh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime si_ = context.Operators.Start(sh_);
                        CqlQuantity sj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime sk_ = context.Operators.Subtract(si_, sj_);
                        CqlInterval<CqlDateTime> sm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime sn_ = context.Operators.Start(sm_);
                        CqlInterval<CqlDateTime> so_ = context.Operators.Interval(sk_, sn_, true, true);
                        bool? sp_ = context.Operators.In<CqlDateTime>(sf_, so_, default);
                        CqlInterval<CqlDateTime> sr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime ss_ = context.Operators.Start(sr_);
                        bool? st_ = context.Operators.Not((bool?)(ss_ is null));
                        bool? su_ = context.Operators.And(sp_, st_);
                        bool? sv_ = context.Operators.And(sc_, su_);
                        return sv_;
                    };
                    IEnumerable<Encounter> qi_ = context.Operators.Where<Encounter>(qg_, qh_);
                    object qj_(Encounter @this)
                    {
                        Period sw_ = @this?.Period;
                        CqlInterval<CqlDateTime> sx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sw_);
                        CqlDateTime sy_ = context.Operators.End(sx_);
                        return sy_;
                    };
                    IEnumerable<Encounter> qk_ = context.Operators.SortBy<Encounter>(qi_, qj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ql_ = context.Operators.Last<Encounter>(qk_);
                    Period qm_ = ql_?.Period;
                    CqlInterval<CqlDateTime> qn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qm_);
                    CqlDateTime qo_ = context.Operators.Start(qn_);
                    Period qp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime qr_ = context.Operators.Start(qq_);
                    CqlQuantity qs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qt_ = context.Operators.Subtract(qo_ ?? qr_, qs_);
                    IEnumerable<Encounter> qv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? qw_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> sz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ta_ = sz_?.Value;
                        Code<Encounter.EncounterStatus> tb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ta_);
                        bool? tc_ = context.Operators.Equal(tb_, "finished");
                        Period td_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> te_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, td_);
                        CqlDateTime tf_ = context.Operators.End(te_);
                        Period tg_ = Visit?.Period;
                        CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ti_ = context.Operators.Start(th_);
                        CqlQuantity tj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime tk_ = context.Operators.Subtract(ti_, tj_);
                        CqlInterval<CqlDateTime> tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime tn_ = context.Operators.Start(tm_);
                        CqlInterval<CqlDateTime> to_ = context.Operators.Interval(tk_, tn_, true, true);
                        bool? tp_ = context.Operators.In<CqlDateTime>(tf_, to_, default);
                        CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ts_ = context.Operators.Start(tr_);
                        bool? tt_ = context.Operators.Not((bool?)(ts_ is null));
                        bool? tu_ = context.Operators.And(tp_, tt_);
                        bool? tv_ = context.Operators.And(tc_, tu_);
                        return tv_;
                    };
                    IEnumerable<Encounter> qx_ = context.Operators.Where<Encounter>(qv_, qw_);
                    object qy_(Encounter @this)
                    {
                        Period tw_ = @this?.Period;
                        CqlInterval<CqlDateTime> tx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tw_);
                        CqlDateTime ty_ = context.Operators.End(tx_);
                        return ty_;
                    };
                    IEnumerable<Encounter> qz_ = context.Operators.SortBy<Encounter>(qx_, qy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ra_ = context.Operators.Last<Encounter>(qz_);
                    Period rb_ = ra_?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlInterval<CqlDateTime> rf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime rg_ = context.Operators.Start(rf_);
                    CqlInterval<CqlDateTime> rh_ = context.Operators.Interval(qt_, rd_ ?? rg_, true, true);
                    bool? ri_ = context.Operators.In<CqlDateTime>(qe_, rh_, default);
                    IEnumerable<Encounter> rk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                    bool? rl_(Encounter LastObs)
                    {
                        Code<Encounter.EncounterStatus> tz_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ua_ = tz_?.Value;
                        Code<Encounter.EncounterStatus> ub_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ua_);
                        bool? uc_ = context.Operators.Equal(ub_, "finished");
                        Period ud_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ue_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ud_);
                        CqlDateTime uf_ = context.Operators.End(ue_);
                        Period ug_ = Visit?.Period;
                        CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime ui_ = context.Operators.Start(uh_);
                        CqlQuantity uj_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime uk_ = context.Operators.Subtract(ui_, uj_);
                        CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime un_ = context.Operators.Start(um_);
                        CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(uk_, un_, true, true);
                        bool? up_ = context.Operators.In<CqlDateTime>(uf_, uo_, default);
                        CqlInterval<CqlDateTime> ur_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                        CqlDateTime us_ = context.Operators.Start(ur_);
                        bool? ut_ = context.Operators.Not((bool?)(us_ is null));
                        bool? uu_ = context.Operators.And(up_, ut_);
                        bool? uv_ = context.Operators.And(uc_, uu_);
                        return uv_;
                    };
                    IEnumerable<Encounter> rm_ = context.Operators.Where<Encounter>(rk_, rl_);
                    object rn_(Encounter @this)
                    {
                        Period uw_ = @this?.Period;
                        CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                        CqlDateTime uy_ = context.Operators.End(ux_);
                        return uy_;
                    };
                    IEnumerable<Encounter> ro_ = context.Operators.SortBy<Encounter>(rm_, rn_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rp_ = context.Operators.Last<Encounter>(ro_);
                    Period rq_ = rp_?.Period;
                    CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rq_);
                    CqlDateTime rs_ = context.Operators.Start(rr_);
                    CqlInterval<CqlDateTime> ru_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                    CqlDateTime rv_ = context.Operators.Start(ru_);
                    bool? rw_ = context.Operators.Not((bool?)((rs_ ?? rv_) is null));
                    bool? rx_ = context.Operators.And(ri_, rw_);
                    bool? ry_ = context.Operators.And(qb_, rx_);
                    return ry_;
                };
                IEnumerable<Encounter> cu_ = context.Operators.Where<Encounter>(cs_, ct_);
                object cv_(Encounter @this)
                {
                    Period uz_ = @this?.Period;
                    CqlInterval<CqlDateTime> va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                    CqlDateTime vb_ = context.Operators.End(va_);
                    return vb_;
                };
                IEnumerable<Encounter> cw_ = context.Operators.SortBy<Encounter>(cu_, cv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cx_ = context.Operators.Last<Encounter>(cw_);
                Period cy_ = cx_?.Period;
                CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                IEnumerable<Encounter> dc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? dd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> vc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? vd_ = vc_?.Value;
                    Code<Encounter.EncounterStatus> ve_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vd_);
                    bool? vf_ = context.Operators.Equal(ve_, "finished");
                    Period vg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vg_);
                    CqlDateTime vi_ = context.Operators.End(vh_);
                    Period vj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> vk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vl_ = context.Operators.Start(vk_);
                    CqlQuantity vm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vn_ = context.Operators.Subtract(vl_, vm_);
                    CqlInterval<CqlDateTime> vp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vq_ = context.Operators.Start(vp_);
                    CqlInterval<CqlDateTime> vr_ = context.Operators.Interval(vn_, vq_, true, true);
                    bool? vs_ = context.Operators.In<CqlDateTime>(vi_, vr_, default);
                    CqlInterval<CqlDateTime> vu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vj_);
                    CqlDateTime vv_ = context.Operators.Start(vu_);
                    bool? vw_ = context.Operators.Not((bool?)(vv_ is null));
                    bool? vx_ = context.Operators.And(vs_, vw_);
                    bool? vy_ = context.Operators.And(vf_, vx_);
                    return vy_;
                };
                IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(dc_, dd_);
                object df_(Encounter @this)
                {
                    Period vz_ = @this?.Period;
                    CqlInterval<CqlDateTime> wa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vz_);
                    CqlDateTime wb_ = context.Operators.End(wa_);
                    return wb_;
                };
                IEnumerable<Encounter> dg_ = context.Operators.SortBy<Encounter>(de_, df_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter dh_ = context.Operators.Last<Encounter>(dg_);
                Period di_ = dh_?.Period;
                CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                CqlDateTime dk_ = context.Operators.Start(dj_);
                CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime dn_ = context.Operators.Start(dm_);
                bool? do_ = context.Operators.Not((bool?)((da_ ?? dk_ ?? dn_) is null));
                bool? dp_ = context.Operators.And(cq_, do_);
                return dp_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period wc_ = @this?.Period;
                CqlInterval<CqlDateTime> wd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wc_);
                CqlDateTime we_ = context.Operators.End(wd_);
                return we_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? r_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> wf_ = LastED?.StatusElement;
                Encounter.EncounterStatus? wg_ = wf_?.Value;
                Code<Encounter.EncounterStatus> wh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wg_);
                bool? wi_ = context.Operators.Equal(wh_, "finished");
                Period wj_ = LastED?.Period;
                CqlInterval<CqlDateTime> wk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wj_);
                CqlDateTime wl_ = context.Operators.End(wk_);
                CqlValueSet wm_ = this.Observation_Services(context);
                IEnumerable<Encounter> wn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? wo_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> yg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? yh_ = yg_?.Value;
                    Code<Encounter.EncounterStatus> yi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yh_);
                    bool? yj_ = context.Operators.Equal(yi_, "finished");
                    Period yk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> yl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yk_);
                    CqlDateTime ym_ = context.Operators.End(yl_);
                    Period yn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yp_ = context.Operators.Start(yo_);
                    CqlQuantity yq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime yr_ = context.Operators.Subtract(yp_, yq_);
                    CqlInterval<CqlDateTime> yt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yu_ = context.Operators.Start(yt_);
                    CqlInterval<CqlDateTime> yv_ = context.Operators.Interval(yr_, yu_, true, true);
                    bool? yw_ = context.Operators.In<CqlDateTime>(ym_, yv_, default);
                    CqlInterval<CqlDateTime> yy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yn_);
                    CqlDateTime yz_ = context.Operators.Start(yy_);
                    bool? za_ = context.Operators.Not((bool?)(yz_ is null));
                    bool? zb_ = context.Operators.And(yw_, za_);
                    bool? zc_ = context.Operators.And(yj_, zb_);
                    return zc_;
                };
                IEnumerable<Encounter> wp_ = context.Operators.Where<Encounter>(wn_, wo_);
                object wq_(Encounter @this)
                {
                    Period zd_ = @this?.Period;
                    CqlInterval<CqlDateTime> ze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zd_);
                    CqlDateTime zf_ = context.Operators.End(ze_);
                    return zf_;
                };
                IEnumerable<Encounter> wr_ = context.Operators.SortBy<Encounter>(wp_, wq_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ws_ = context.Operators.Last<Encounter>(wr_);
                Period wt_ = ws_?.Period;
                CqlInterval<CqlDateTime> wu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wt_);
                CqlDateTime wv_ = context.Operators.Start(wu_);
                Period ww_ = Visit?.Period;
                CqlInterval<CqlDateTime> wx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime wy_ = context.Operators.Start(wx_);
                CqlQuantity wz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime xa_ = context.Operators.Subtract(wv_ ?? wy_, wz_);
                IEnumerable<Encounter> xc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xd_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> zg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? zh_ = zg_?.Value;
                    Code<Encounter.EncounterStatus> zi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zh_);
                    bool? zj_ = context.Operators.Equal(zi_, "finished");
                    Period zk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> zl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zk_);
                    CqlDateTime zm_ = context.Operators.End(zl_);
                    Period zn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> zo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zp_ = context.Operators.Start(zo_);
                    CqlQuantity zq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime zr_ = context.Operators.Subtract(zp_, zq_);
                    CqlInterval<CqlDateTime> zt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zu_ = context.Operators.Start(zt_);
                    CqlInterval<CqlDateTime> zv_ = context.Operators.Interval(zr_, zu_, true, true);
                    bool? zw_ = context.Operators.In<CqlDateTime>(zm_, zv_, default);
                    CqlInterval<CqlDateTime> zy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zn_);
                    CqlDateTime zz_ = context.Operators.Start(zy_);
                    bool? aza_ = context.Operators.Not((bool?)(zz_ is null));
                    bool? azb_ = context.Operators.And(zw_, aza_);
                    bool? azc_ = context.Operators.And(zj_, azb_);
                    return azc_;
                };
                IEnumerable<Encounter> xe_ = context.Operators.Where<Encounter>(xc_, xd_);
                object xf_(Encounter @this)
                {
                    Period azd_ = @this?.Period;
                    CqlInterval<CqlDateTime> aze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azd_);
                    CqlDateTime azf_ = context.Operators.End(aze_);
                    return azf_;
                };
                IEnumerable<Encounter> xg_ = context.Operators.SortBy<Encounter>(xe_, xf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xh_ = context.Operators.Last<Encounter>(xg_);
                Period xi_ = xh_?.Period;
                CqlInterval<CqlDateTime> xj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xi_);
                CqlDateTime xk_ = context.Operators.Start(xj_);
                CqlInterval<CqlDateTime> xm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime xn_ = context.Operators.Start(xm_);
                CqlInterval<CqlDateTime> xo_ = context.Operators.Interval(xa_, xk_ ?? xn_, true, true);
                bool? xp_ = context.Operators.In<CqlDateTime>(wl_, xo_, default);
                IEnumerable<Encounter> xr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? xs_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> azg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? azh_ = azg_?.Value;
                    Code<Encounter.EncounterStatus> azi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azh_);
                    bool? azj_ = context.Operators.Equal(azi_, "finished");
                    Period azk_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> azl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azk_);
                    CqlDateTime azm_ = context.Operators.End(azl_);
                    Period azn_ = Visit?.Period;
                    CqlInterval<CqlDateTime> azo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azp_ = context.Operators.Start(azo_);
                    CqlQuantity azq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime azr_ = context.Operators.Subtract(azp_, azq_);
                    CqlInterval<CqlDateTime> azt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azu_ = context.Operators.Start(azt_);
                    CqlInterval<CqlDateTime> azv_ = context.Operators.Interval(azr_, azu_, true, true);
                    bool? azw_ = context.Operators.In<CqlDateTime>(azm_, azv_, default);
                    CqlInterval<CqlDateTime> azy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azn_);
                    CqlDateTime azz_ = context.Operators.Start(azy_);
                    bool? bza_ = context.Operators.Not((bool?)(azz_ is null));
                    bool? bzb_ = context.Operators.And(azw_, bza_);
                    bool? bzc_ = context.Operators.And(azj_, bzb_);
                    return bzc_;
                };
                IEnumerable<Encounter> xt_ = context.Operators.Where<Encounter>(xr_, xs_);
                object xu_(Encounter @this)
                {
                    Period bzd_ = @this?.Period;
                    CqlInterval<CqlDateTime> bze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzd_);
                    CqlDateTime bzf_ = context.Operators.End(bze_);
                    return bzf_;
                };
                IEnumerable<Encounter> xv_ = context.Operators.SortBy<Encounter>(xt_, xu_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter xw_ = context.Operators.Last<Encounter>(xv_);
                Period xx_ = xw_?.Period;
                CqlInterval<CqlDateTime> xy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xx_);
                CqlDateTime xz_ = context.Operators.Start(xy_);
                CqlInterval<CqlDateTime> yb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ww_);
                CqlDateTime yc_ = context.Operators.Start(yb_);
                bool? yd_ = context.Operators.Not((bool?)((xz_ ?? yc_) is null));
                bool? ye_ = context.Operators.And(xp_, yd_);
                bool? yf_ = context.Operators.And(wi_, ye_);
                return yf_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period bzg_ = @this?.Period;
                CqlInterval<CqlDateTime> bzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzg_);
                CqlDateTime bzi_ = context.Operators.End(bzh_);
                return bzi_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlValueSet z_ = this.Observation_Services(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? ab_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> bzj_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? bzk_ = bzj_?.Value;
                Code<Encounter.EncounterStatus> bzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzk_);
                bool? bzm_ = context.Operators.Equal(bzl_, "finished");
                Period bzn_ = LastObs?.Period;
                CqlInterval<CqlDateTime> bzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzn_);
                CqlDateTime bzp_ = context.Operators.End(bzo_);
                Period bzq_ = Visit?.Period;
                CqlInterval<CqlDateTime> bzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime bzs_ = context.Operators.Start(bzr_);
                CqlQuantity bzt_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bzu_ = context.Operators.Subtract(bzs_, bzt_);
                CqlInterval<CqlDateTime> bzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime bzx_ = context.Operators.Start(bzw_);
                CqlInterval<CqlDateTime> bzy_ = context.Operators.Interval(bzu_, bzx_, true, true);
                bool? bzz_ = context.Operators.In<CqlDateTime>(bzp_, bzy_, default);
                CqlInterval<CqlDateTime> czb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzq_);
                CqlDateTime czc_ = context.Operators.Start(czb_);
                bool? czd_ = context.Operators.Not((bool?)(czc_ is null));
                bool? cze_ = context.Operators.And(bzz_, czd_);
                bool? czf_ = context.Operators.And(bzm_, cze_);
                return czf_;
            };
            IEnumerable<Encounter> ac_ = context.Operators.Where<Encounter>(aa_, ab_);
            object ad_(Encounter @this)
            {
                Period czg_ = @this?.Period;
                CqlInterval<CqlDateTime> czh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czg_);
                CqlDateTime czi_ = context.Operators.End(czh_);
                return czi_;
            };
            IEnumerable<Encounter> ae_ = context.Operators.SortBy<Encounter>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter af_ = context.Operators.Last<Encounter>(ae_);
            Period ag_ = af_?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            Period aj_ = Visit?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime ao_ = context.Operators.End(an_);
            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(o_ ?? y_ ?? ai_ ?? al_, ao_, true, true);
            return ap_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> ag_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ah_ = ag_?.Value;
                Code<Encounter.EncounterStatus> ai_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ah_);
                bool? aj_ = context.Operators.Equal(ai_, "finished");
                Period ak_ = LastED?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                CqlValueSet an_ = this.Observation_Services(context);
                IEnumerable<Encounter> ao_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ap_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ch_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ci_ = ch_?.Value;
                    Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                    bool? ck_ = context.Operators.Equal(cj_, "finished");
                    Period cl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                    CqlDateTime cn_ = context.Operators.End(cm_);
                    Period co_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime cq_ = context.Operators.Start(cp_);
                    CqlQuantity cr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cs_ = context.Operators.Subtract(cq_, cr_);
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime cv_ = context.Operators.Start(cu_);
                    CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cs_, cv_, true, true);
                    bool? cx_ = context.Operators.In<CqlDateTime>(cn_, cw_, default);
                    CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    bool? db_ = context.Operators.Not((bool?)(da_ is null));
                    bool? dc_ = context.Operators.And(cx_, db_);
                    bool? dd_ = context.Operators.And(ck_, dc_);
                    return dd_;
                };
                IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);
                object ar_(Encounter @this)
                {
                    Period de_ = @this?.Period;
                    CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.End(df_);
                    return dg_;
                };
                IEnumerable<Encounter> as_ = context.Operators.SortBy<Encounter>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter at_ = context.Operators.Last<Encounter>(as_);
                Period au_ = at_?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                Period ax_ = Visit?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bb_ = context.Operators.Subtract(aw_ ?? az_, ba_);
                IEnumerable<Encounter> bd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? be_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? di_ = dh_?.Value;
                    Code<Encounter.EncounterStatus> dj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(di_);
                    bool? dk_ = context.Operators.Equal(dj_, "finished");
                    Period dl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                    CqlDateTime dn_ = context.Operators.End(dm_);
                    Period do_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    CqlQuantity dr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ds_ = context.Operators.Subtract(dq_, dr_);
                    CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dv_ = context.Operators.Start(du_);
                    CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(ds_, dv_, true, true);
                    bool? dx_ = context.Operators.In<CqlDateTime>(dn_, dw_, default);
                    CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime ea_ = context.Operators.Start(dz_);
                    bool? eb_ = context.Operators.Not((bool?)(ea_ is null));
                    bool? ec_ = context.Operators.And(dx_, eb_);
                    bool? ed_ = context.Operators.And(dk_, ec_);
                    return ed_;
                };
                IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);
                object bg_(Encounter @this)
                {
                    Period ee_ = @this?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.End(ef_);
                    return eg_;
                };
                IEnumerable<Encounter> bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bi_ = context.Operators.Last<Encounter>(bh_);
                Period bj_ = bi_?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bb_, bl_ ?? bo_, true, true);
                bool? bq_ = context.Operators.In<CqlDateTime>(am_, bp_, default);
                IEnumerable<Encounter> bs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> eh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ei_ = eh_?.Value;
                    Code<Encounter.EncounterStatus> ej_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ei_);
                    bool? ek_ = context.Operators.Equal(ej_, "finished");
                    Period el_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                    CqlDateTime en_ = context.Operators.End(em_);
                    Period eo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime eq_ = context.Operators.Start(ep_);
                    CqlQuantity er_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime es_ = context.Operators.Subtract(eq_, er_);
                    CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime ev_ = context.Operators.Start(eu_);
                    CqlInterval<CqlDateTime> ew_ = context.Operators.Interval(es_, ev_, true, true);
                    bool? ex_ = context.Operators.In<CqlDateTime>(en_, ew_, default);
                    CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime fa_ = context.Operators.Start(ez_);
                    bool? fb_ = context.Operators.Not((bool?)(fa_ is null));
                    bool? fc_ = context.Operators.And(ex_, fb_);
                    bool? fd_ = context.Operators.And(ek_, fc_);
                    return fd_;
                };
                IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
                object bv_(Encounter @this)
                {
                    Period fe_ = @this?.Period;
                    CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                    CqlDateTime fg_ = context.Operators.End(ff_);
                    return fg_;
                };
                IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bx_ = context.Operators.Last<Encounter>(bw_);
                Period by_ = bx_?.Period;
                CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                CqlDateTime ca_ = context.Operators.Start(bz_);
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                bool? ce_ = context.Operators.Not((bool?)((ca_ ?? cd_) is null));
                bool? cf_ = context.Operators.And(bq_, ce_);
                bool? cg_ = context.Operators.And(aj_, cf_);
                return cg_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period fh_ = @this?.Period;
                CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fh_);
                CqlDateTime fj_ = context.Operators.End(fi_);
                return fj_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? r_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> fk_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? fl_ = fk_?.Value;
                Code<Encounter.EncounterStatus> fm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fl_);
                bool? fn_ = context.Operators.Equal(fm_, "finished");
                Period fo_ = LastObs?.Period;
                CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                CqlDateTime fq_ = context.Operators.End(fp_);
                Period fr_ = Visit?.Period;
                CqlInterval<CqlDateTime> fs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime ft_ = context.Operators.Start(fs_);
                CqlQuantity fu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fv_ = context.Operators.Subtract(ft_, fu_);
                CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime fy_ = context.Operators.Start(fx_);
                CqlInterval<CqlDateTime> fz_ = context.Operators.Interval(fv_, fy_, true, true);
                bool? ga_ = context.Operators.In<CqlDateTime>(fq_, fz_, default);
                CqlInterval<CqlDateTime> gc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime gd_ = context.Operators.Start(gc_);
                bool? ge_ = context.Operators.Not((bool?)(gd_ is null));
                bool? gf_ = context.Operators.And(ga_, ge_);
                bool? gg_ = context.Operators.And(fn_, gf_);
                return gg_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period gh_ = @this?.Period;
                CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gh_);
                CqlDateTime gj_ = context.Operators.End(gi_);
                return gj_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ae_, true, true);
            return af_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter LastED)
            {
                Code<Encounter.EncounterStatus> ag_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ah_ = ag_?.Value;
                Code<Encounter.EncounterStatus> ai_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ah_);
                bool? aj_ = context.Operators.Equal(ai_, "finished");
                Period ak_ = LastED?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.End(al_);
                CqlValueSet an_ = this.Observation_Services(context);
                IEnumerable<Encounter> ao_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? ap_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> ch_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ci_ = ch_?.Value;
                    Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                    bool? ck_ = context.Operators.Equal(cj_, "finished");
                    Period cl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                    CqlDateTime cn_ = context.Operators.End(cm_);
                    Period co_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime cq_ = context.Operators.Start(cp_);
                    CqlQuantity cr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cs_ = context.Operators.Subtract(cq_, cr_);
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime cv_ = context.Operators.Start(cu_);
                    CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cs_, cv_, true, true);
                    bool? cx_ = context.Operators.In<CqlDateTime>(cn_, cw_, default);
                    CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    bool? db_ = context.Operators.Not((bool?)(da_ is null));
                    bool? dc_ = context.Operators.And(cx_, db_);
                    bool? dd_ = context.Operators.And(ck_, dc_);
                    return dd_;
                };
                IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);
                object ar_(Encounter @this)
                {
                    Period de_ = @this?.Period;
                    CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.End(df_);
                    return dg_;
                };
                IEnumerable<Encounter> as_ = context.Operators.SortBy<Encounter>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter at_ = context.Operators.Last<Encounter>(as_);
                Period au_ = at_?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                Period ax_ = Visit?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bb_ = context.Operators.Subtract(aw_ ?? az_, ba_);
                IEnumerable<Encounter> bd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? be_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> dh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? di_ = dh_?.Value;
                    Code<Encounter.EncounterStatus> dj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(di_);
                    bool? dk_ = context.Operators.Equal(dj_, "finished");
                    Period dl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                    CqlDateTime dn_ = context.Operators.End(dm_);
                    Period do_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    CqlQuantity dr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ds_ = context.Operators.Subtract(dq_, dr_);
                    CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dv_ = context.Operators.Start(du_);
                    CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(ds_, dv_, true, true);
                    bool? dx_ = context.Operators.In<CqlDateTime>(dn_, dw_, default);
                    CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime ea_ = context.Operators.Start(dz_);
                    bool? eb_ = context.Operators.Not((bool?)(ea_ is null));
                    bool? ec_ = context.Operators.And(dx_, eb_);
                    bool? ed_ = context.Operators.And(dk_, ec_);
                    return ed_;
                };
                IEnumerable<Encounter> bf_ = context.Operators.Where<Encounter>(bd_, be_);
                object bg_(Encounter @this)
                {
                    Period ee_ = @this?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.End(ef_);
                    return eg_;
                };
                IEnumerable<Encounter> bh_ = context.Operators.SortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bi_ = context.Operators.Last<Encounter>(bh_);
                Period bj_ = bi_?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bb_, bl_ ?? bo_, true, true);
                bool? bq_ = context.Operators.In<CqlDateTime>(am_, bp_, default);
                IEnumerable<Encounter> bs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, an_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                bool? bt_(Encounter LastObs)
                {
                    Code<Encounter.EncounterStatus> eh_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ei_ = eh_?.Value;
                    Code<Encounter.EncounterStatus> ej_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ei_);
                    bool? ek_ = context.Operators.Equal(ej_, "finished");
                    Period el_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                    CqlDateTime en_ = context.Operators.End(em_);
                    Period eo_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime eq_ = context.Operators.Start(ep_);
                    CqlQuantity er_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime es_ = context.Operators.Subtract(eq_, er_);
                    CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime ev_ = context.Operators.Start(eu_);
                    CqlInterval<CqlDateTime> ew_ = context.Operators.Interval(es_, ev_, true, true);
                    bool? ex_ = context.Operators.In<CqlDateTime>(en_, ew_, default);
                    CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                    CqlDateTime fa_ = context.Operators.Start(ez_);
                    bool? fb_ = context.Operators.Not((bool?)(fa_ is null));
                    bool? fc_ = context.Operators.And(ex_, fb_);
                    bool? fd_ = context.Operators.And(ek_, fc_);
                    return fd_;
                };
                IEnumerable<Encounter> bu_ = context.Operators.Where<Encounter>(bs_, bt_);
                object bv_(Encounter @this)
                {
                    Period fe_ = @this?.Period;
                    CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                    CqlDateTime fg_ = context.Operators.End(ff_);
                    return fg_;
                };
                IEnumerable<Encounter> bw_ = context.Operators.SortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bx_ = context.Operators.Last<Encounter>(bw_);
                Period by_ = bx_?.Period;
                CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                CqlDateTime ca_ = context.Operators.Start(bz_);
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                bool? ce_ = context.Operators.Not((bool?)((ca_ ?? cd_) is null));
                bool? cf_ = context.Operators.And(bq_, ce_);
                bool? cg_ = context.Operators.And(aj_, cf_);
                return cg_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period fh_ = @this?.Period;
                CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fh_);
                CqlDateTime fj_ = context.Operators.End(fi_);
                return fj_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? r_(Encounter LastObs)
            {
                Code<Encounter.EncounterStatus> fk_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? fl_ = fk_?.Value;
                Code<Encounter.EncounterStatus> fm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fl_);
                bool? fn_ = context.Operators.Equal(fm_, "finished");
                Period fo_ = LastObs?.Period;
                CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                CqlDateTime fq_ = context.Operators.End(fp_);
                Period fr_ = Visit?.Period;
                CqlInterval<CqlDateTime> fs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime ft_ = context.Operators.Start(fs_);
                CqlQuantity fu_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fv_ = context.Operators.Subtract(ft_, fu_);
                CqlInterval<CqlDateTime> fx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime fy_ = context.Operators.Start(fx_);
                CqlInterval<CqlDateTime> fz_ = context.Operators.Interval(fv_, fy_, true, true);
                bool? ga_ = context.Operators.In<CqlDateTime>(fq_, fz_, default);
                CqlInterval<CqlDateTime> gc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                CqlDateTime gd_ = context.Operators.Start(gc_);
                bool? ge_ = context.Operators.Not((bool?)(gd_ is null));
                bool? gf_ = context.Operators.And(ga_, ge_);
                bool? gg_ = context.Operators.And(fn_, gf_);
                return gg_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period gh_ = @this?.Period;
                CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gh_);
                CqlDateTime gj_ = context.Operators.End(gi_);
                return gj_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ae_, true, true);
            return af_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? b_ = this.lengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> a_ = Encounter?.Location;
        bool? b_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference g_ = HospitalLocation?.Location;
            Location h_ = this.GetLocation(context, g_);
            List<CodeableConcept> i_ = h_?.Type;
            CqlConcept j_(CodeableConcept @this)
            {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        object d_(Encounter.LocationComponent @this)
        {
            Period u_ = @this?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            return w_;
        };
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> a_ = Encounter?.Location;
        bool? b_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference g_ = HospitalLocation?.Location;
            Location h_ = this.GetLocation(context, g_);
            List<CodeableConcept> i_ = h_?.Type;
            CqlConcept j_(CodeableConcept @this)
            {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        object d_(Encounter.LocationComponent @this)
        {
            Period u_ = @this?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            return w_;
        };
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<object> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        object b_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> g_ = context.Operators.Union<object>(e_ as IEnumerable<object>, f_ as IEnumerable<object>);
            bool? h_(object C)
            {
                ResourceReference k_ = D?.Condition;
                object l_ = context.Operators.LateBoundProperty<object>(C, "id");
                string m_ = context.Operators.LateBoundProperty<string>(l_, "value");
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, k_, m_);
                return n_;
            };
            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            object j_ = context.Operators.SingletonFrom<object>(i_);
            return j_;
        };
        IEnumerable<object> c_ = context.Operators.Select<Encounter.DiagnosisComponent, object>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        IEnumerable<object> d_ = context.Operators.Distinct<object>(c_);
        return d_;
    }


    [CqlFunctionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<object> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;
        object b_(ResourceReference D)
        {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> g_ = context.Operators.Union<object>(e_ as IEnumerable<object>, f_ as IEnumerable<object>);
            bool? h_(object C)
            {
                object k_ = context.Operators.LateBoundProperty<object>(C, "id");
                string l_ = context.Operators.LateBoundProperty<string>(k_, "value");
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, D, l_);
                return m_;
            };
            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            object j_ = context.Operators.SingletonFrom<object>(i_);
            return j_;
        };
        IEnumerable<object> c_ = context.Operators.Select<ResourceReference, object>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<object> d_ = context.Operators.Distinct<object>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public object GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        bool? d_(object C)
        {
            object g_ = context.Operators.LateBoundProperty<object>(C, "id");
            string h_ = context.Operators.LateBoundProperty<string>(g_, "value");
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        };
        IEnumerable<object> e_ = context.Operators.Where<object>(c_, d_);
        object f_ = context.Operators.SingletonFrom<object>(e_);
        return f_;
    }


    [CqlFunctionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public object getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        bool? d_(object C)
        {
            object g_ = context.Operators.LateBoundProperty<object>(C, "id");
            string h_ = context.Operators.LateBoundProperty<string>(g_, "value");
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        };
        IEnumerable<object> e_ = context.Operators.Where<object>(c_, d_);
        object f_ = context.Operators.SingletonFrom<object>(e_);
        return f_;
    }


    [CqlFunctionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public object PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent D)
        {
            PositiveInt h_ = D?.RankElement;
            int? i_ = h_?.Value;
            bool? j_ = context.Operators.Equal(i_, 1);
            CodeableConcept k_ = D?.Use;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlCode m_ = this.Billing(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_ = context.Operators.And(j_, o_);
            return p_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        object d_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> s_ = context.Operators.Union<object>(q_ as IEnumerable<object>, r_ as IEnumerable<object>);
            bool? t_(object C)
            {
                ResourceReference w_ = PD?.Condition;
                object x_ = context.Operators.LateBoundProperty<object>(C, "id");
                string y_ = context.Operators.LateBoundProperty<string>(x_, "value");
                bool? z_ = QICoreCommon_4_0_000.Instance.references(context, w_, y_);
                return z_;
            };
            IEnumerable<object> u_ = context.Operators.Where<object>(s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            return v_;
        };
        IEnumerable<object> e_ = context.Operators.Select<Encounter.DiagnosisComponent, object>(c_, d_);
        IEnumerable<object> f_ = context.Operators.Distinct<object>(e_);
        object g_ = context.Operators.SingletonFrom<object>(f_);
        return g_;
    }


    [CqlFunctionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the claim diagnosis element that is specified as the principal diagnosis for the encounter")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public Claim.DiagnosisComponent principalDiagnosis(CqlContext context, Encounter encounter)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = this.claimDiagnosis(context, encounter);
        bool? b_(Claim.DiagnosisComponent CD)
        {
            List<CodeableConcept> e_ = CD?.Type;
            CqlConcept f_(CodeableConcept @this)
            {
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            };
            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlCode h_ = this.Principal_Diagnosis(context);
            bool? i_ = QICoreCommon_4_0_000.Instance.includesCode(context, g_, h_);
            return i_;
        };
        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>(a_, b_);
        Claim.DiagnosisComponent d_ = context.Operators.SingletonFrom<Claim.DiagnosisComponent>(c_);
        return d_;
    }


    [CqlFunctionDefinition("claimDiagnosis")]
    [CqlTag("description", "Returns the claim diagnosis elements for the given encounter")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public IEnumerable<Claim.DiagnosisComponent> claimDiagnosis(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? g_(Claim C)
            {
                Code<FinancialResourceStatusCodes> p_ = C?.StatusElement;
                FinancialResourceStatusCodes? q_ = p_?.Value;
                Code<FinancialResourceStatusCodes> r_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(q_);
                bool? s_ = context.Operators.Equal(r_, "active");
                Code<ClaimUseCode> t_ = C?.UseElement;
                ClaimUseCode? u_ = t_?.Value;
                Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                bool? w_ = context.Operators.Equal(v_, "claim");
                bool? x_ = context.Operators.And(s_, w_);
                List<Claim.ItemComponent> y_ = C?.Item;
                bool? z_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);
                    return ae_;
                };
                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            };
            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);
            bool? i_(Claim @this)
            {
                List<Claim.DiagnosisComponent> af_ = @this?.Diagnosis;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                return ag_;
            };
            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);
            List<Claim.DiagnosisComponent> k_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ah_ = @this?.Diagnosis;
                return ah_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> l_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(j_, k_);
            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)l_);
            bool? n_(Claim.DiagnosisComponent D)
            {
                PositiveInt ai_ = D?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? al_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> ba_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bb_ = ba_?.Value;
                    Code<FinancialResourceStatusCodes> bc_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bb_);
                    bool? bd_ = context.Operators.Equal(bc_, "active");
                    Code<ClaimUseCode> be_ = C?.UseElement;
                    ClaimUseCode? bf_ = be_?.Value;
                    Code<ClaimUseCode> bg_ = context.Operators.Convert<Code<ClaimUseCode>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "claim");
                    bool? bi_ = context.Operators.And(bd_, bh_);
                    List<Claim.ItemComponent> bj_ = C?.Item;
                    bool? bk_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bo_ = I?.Encounter;
                        bool? bp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bo_, E);
                        return bp_;
                    };
                    IEnumerable<Claim.ItemComponent> bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bj_, bk_);
                    bool? bm_ = context.Operators.Exists<Claim.ItemComponent>(bl_);
                    bool? bn_ = context.Operators.And(bi_, bm_);
                    return bn_;
                };
                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);
                bool? an_(Claim @this)
                {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));
                    return br_;
                };
                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);
                List<Claim.ItemComponent> ap_(Claim @this)
                {
                    List<Claim.ItemComponent> bs_ = @this?.Item;
                    return bs_;
                };
                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);
                bool? as_(Claim.ItemComponent I)
                {
                    List<ResourceReference> bt_ = I?.Encounter;
                    bool? bu_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bt_, E);
                    return bu_;
                };
                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);
                bool? au_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> bv_ = @this?.DiagnosisSequenceElement;
                    int? bw_(PositiveInt @this)
                    {
                        int? bz_ = @this?.Value;
                        return bz_;
                    };
                    IEnumerable<int?> bx_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bv_, bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                };
                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);
                IEnumerable<int?> aw_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ca_ = @this?.DiagnosisSequenceElement;
                    int? cb_(PositiveInt @this)
                    {
                        int? cd_ = @this?.Value;
                        return cd_;
                    };
                    IEnumerable<int?> cc_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ca_, cb_);
                    return cc_;
                };
                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);
                return az_;
            };
            IEnumerable<Claim.DiagnosisComponent> o_ = context.Operators.Where<Claim.DiagnosisComponent>(m_, n_);
            return o_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Claim.DiagnosisComponent>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hasPrincipalDiagnosisOf")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter and has a code in the given valueSet.")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public bool? hasPrincipalDiagnosisOf(CqlContext context, Encounter encounter, CqlValueSet valueSet)
    {
        Claim.DiagnosisComponent a_ = this.principalDiagnosis(context, encounter);
        Claim.DiagnosisComponent[] b_ = [
            a_,
        ];
        bool? c_(Claim.DiagnosisComponent PD)
        {
            DataType g_ = PD?.Diagnosis;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool? i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, valueSet);
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            object l_ = this.getCondition(context, k_ as ResourceReference);
            object m_ = context.Operators.LateBoundProperty<object>(l_, "code");
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_ as CodeableConcept);
            bool? o_ = context.Operators.ConceptInValueSet(n_, valueSet);
            bool? p_ = context.Operators.Or(i_, o_);
            return p_;
        };
        IEnumerable<bool?> d_ = context.Operators.Select<Claim.DiagnosisComponent, bool?>((IEnumerable<Claim.DiagnosisComponent>)b_, c_);
        IEnumerable<bool?> e_ = context.Operators.Distinct<bool?>(d_);
        bool? f_ = context.Operators.SingletonFrom<bool?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("isDiagnosisPresentOnAdmission")]
    [CqlTag("description", "Returns true if the given diagnosis is present on admission, based on the given poaValueSet")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public bool? isDiagnosisPresentOnAdmission(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet, CqlValueSet poaValueSet)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = this.claimDiagnosis(context, encounter);
        bool? b_(Claim.DiagnosisComponent CD)
        {
            CodeableConcept e_ = CD?.OnAdmission;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            bool? g_ = context.Operators.ConceptInValueSet(f_, poaValueSet);
            DataType h_ = CD?.Diagnosis;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            bool? j_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, diagnosisValueSet);
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            object m_ = this.getCondition(context, l_ as ResourceReference);
            object n_ = context.Operators.LateBoundProperty<object>(m_, "code");
            CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_ as CodeableConcept);
            bool? p_ = context.Operators.ConceptInValueSet(o_, diagnosisValueSet);
            bool? q_ = context.Operators.Or(j_, p_);
            bool? r_ = context.Operators.And(g_, q_);
            return r_;
        };
        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>(a_, b_);
        bool? d_ = context.Operators.Exists<Claim.DiagnosisComponent>(c_);
        return d_;
    }


    [CqlFunctionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));
        bool? b_(Location L)
        {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        };
        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept a_()
        {
            bool b_()
            {
                DataType c_ = request?.Medication;
                object d_ = FHIRHelpers_4_4_000.Instance.ToValue(context, c_);
                bool e_ = d_ is CqlConcept;
                return e_;
            };
            if (b_())
            {
                DataType f_ = request?.Medication;
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                return g_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> h_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? i_(Medication M)
                {
                    DataType n_ = request?.Medication;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    bool? p_ = QICoreCommon_4_0_000.Instance.references(context, o_ as ResourceReference, M);
                    return p_;
                };
                IEnumerable<Medication> j_ = context.Operators.Where<Medication>(h_, i_);
                Medication k_ = context.Operators.SingletonFrom<Medication>(j_);
                CodeableConcept l_ = k_?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                return m_;
            }
        };
        return a_();
    }


    [CqlFunctionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        CqlConcept a_()
        {
            bool b_()
            {
                DataType c_ = request?.Medication;
                object d_ = FHIRHelpers_4_4_000.Instance.ToValue(context, c_);
                bool e_ = d_ is CqlConcept;
                return e_;
            };
            if (b_())
            {
                DataType f_ = request?.Medication;
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                return g_ as CqlConcept;
            }
            else
            {
                IEnumerable<Medication> h_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? i_(Medication M)
                {
                    DataType n_ = request?.Medication;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    bool? p_ = QICoreCommon_4_0_000.Instance.references(context, o_ as ResourceReference, M);
                    return p_;
                };
                IEnumerable<Medication> j_ = context.Operators.Where<Medication>(h_, i_);
                Medication k_ = context.Operators.SingletonFrom<Medication>(j_);
                CodeableConcept l_ = k_?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                return m_;
            }
        };
        return a_();
    }


    [CqlFunctionDefinition("principalProcedure")]
    [CqlTag("description", "Returns the claim procedure elements for the given encounter")]
    public Claim.ProcedureComponent principalProcedure(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        Claim.ProcedureComponent b_(Encounter E)
        {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? g_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);
                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            };
            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);
            bool? i_(Claim @this)
            {
                List<Claim.ProcedureComponent> ag_ = @this?.Procedure;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            };
            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);
            List<Claim.ProcedureComponent> k_(Claim @this)
            {
                List<Claim.ProcedureComponent> ai_ = @this?.Procedure;
                return ai_;
            };
            IEnumerable<List<Claim.ProcedureComponent>> l_ = context.Operators.Select<Claim, List<Claim.ProcedureComponent>>(j_, k_);
            IEnumerable<Claim.ProcedureComponent> m_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)l_);
            bool? n_(Claim.ProcedureComponent P)
            {
                PositiveInt aj_ = P?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bh_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bi_ = bh_?.Value;
                    Code<FinancialResourceStatusCodes> bj_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bi_);
                    bool? bk_ = context.Operators.Equal(bj_, "active");
                    Code<ClaimUseCode> bl_ = C?.UseElement;
                    ClaimUseCode? bm_ = bl_?.Value;
                    Code<ClaimUseCode> bn_ = context.Operators.Convert<Code<ClaimUseCode>>(bm_);
                    bool? bo_ = context.Operators.Equal(bn_, "claim");
                    bool? bp_ = context.Operators.And(bk_, bo_);
                    List<Claim.ItemComponent> bq_ = C?.Item;
                    bool? br_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bv_ = I?.Encounter;
                        bool? bw_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bv_, E);
                        return bw_;
                    };
                    IEnumerable<Claim.ItemComponent> bs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bq_, br_);
                    bool? bt_ = context.Operators.Exists<Claim.ItemComponent>(bs_);
                    bool? bu_ = context.Operators.And(bp_, bt_);
                    return bu_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> bx_ = @this?.Item;
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> bz_ = @this?.Item;
                    return bz_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ca_ = I?.Encounter;
                    bool? cb_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ca_, E);
                    return cb_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cc_ = @this?.ProcedureSequenceElement;
                    int? cd_(PositiveInt @this)
                    {
                        int? cg_ = @this?.Value;
                        return cg_;
                    };
                    IEnumerable<int?> ce_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cc_, cd_);
                    bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                    return cf_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ch_ = @this?.ProcedureSequenceElement;
                    int? ci_(PositiveInt @this)
                    {
                        int? ck_ = @this?.Value;
                        return ck_;
                    };
                    IEnumerable<int?> cj_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ch_, ci_);
                    return cj_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                List<CodeableConcept> bb_ = P?.Type;
                CqlConcept bc_(CodeableConcept @this)
                {
                    CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return cl_;
                };
                IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
                CqlCode be_ = this.Primary_procedure(context);
                bool? bf_ = QICoreCommon_4_0_000.Instance.includesCode(context, bd_, be_);
                bool? bg_ = context.Operators.And(ba_, bf_);
                return bg_;
            };
            IEnumerable<Claim.ProcedureComponent> o_ = context.Operators.Where<Claim.ProcedureComponent>(m_, n_);
            Claim.ProcedureComponent p_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(o_);
            return p_;
        };
        IEnumerable<Claim.ProcedureComponent> c_ = context.Operators.Select<Encounter, Claim.ProcedureComponent>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<Claim.ProcedureComponent> d_ = context.Operators.Distinct<Claim.ProcedureComponent>(c_);
        Claim.ProcedureComponent e_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(d_);
        return e_;
    }


    #endregion Functions and Expressions

}
