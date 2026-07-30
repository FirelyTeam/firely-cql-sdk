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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("CQMCommon", "4.1.000")]
public partial class CQMCommon_4_1_000 : ILibrary, ISingleton<CQMCommon_4_1_000>
{
    #region ValueSets (6)

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

    #region Codes (19)

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

    #region CodeSystems (4)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8782724425627446250L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("CQMCommon-4.1.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (45)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1022634852813303399L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter, Inpatient_Encounter_Compute);

    private const long _cacheIndex_Inpatient_Encounter = -6472726403027980764L;

    private IEnumerable<Encounter> Inpatient_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter EncounterInpatient) {
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
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


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

        bool? c_(Encounter EDVisit) {
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
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            bool? v_ = context.Operators.Not((bool?)(q_ is null));
            bool? w_ = context.Operators.And(u_, v_);
            bool? x_ = context.Operators.And(k_, w_);
            return x_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period y_ = @this?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            return aa_;
        }

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

        bool? c_(Encounter EDVisit) {
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
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            bool? v_ = context.Operators.Not((bool?)(q_ is null));
            bool? w_ = context.Operators.And(u_, v_);
            bool? x_ = context.Operators.And(k_, w_);
            return x_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period y_ = @this?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.End(z_);
            return aa_;
        }

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

        CqlInterval<CqlDateTime> c_(Encounter X) {
            if (X is null)
            {
                Period g_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                return h_;
            }
            else
            {
                Period i_ = X?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, false);
                return o_;
            }
        }

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

        CqlInterval<CqlDateTime> c_(Encounter X) {
            if (X is null)
            {
                Period g_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                return h_;
            }
            else
            {
                Period i_ = X?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, true);
                return o_;
            }
        }

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

        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter) {
            if (EDEncounter is null)
            {
                List<Encounter.LocationComponent> g_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)g_;
            }
            else
            {
                List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] j_ = [
                    (IEnumerable<Encounter.LocationComponent>)h_,
                    (IEnumerable<Encounter.LocationComponent>)i_,
                ];
                IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)j_);
                return k_;
            }
        }

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

        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter) {
            if (EDEncounter is null)
            {
                List<Encounter.LocationComponent> g_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)g_;
            }
            else
            {
                List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] j_ = [
                    (IEnumerable<Encounter.LocationComponent>)h_,
                    (IEnumerable<Encounter.LocationComponent>)i_,
                ];
                IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)j_);
                return k_;
            }
        }

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

        object b_(Encounter.LocationComponent @this) {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        }

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

        object b_(Encounter.LocationComponent @this) {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        }

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

        object b_(Encounter.LocationComponent @this) {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        }

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

        object b_(Encounter.LocationComponent @this) {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            return j_;
        }

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

        bool? b_(Encounter.LocationComponent HospitalLocation) {
            ResourceReference h_ = HospitalLocation?.Location;
            Location i_ = this.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;

            CqlConcept k_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

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

        bool? b_(Location L) {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        }

        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime emergencyDepartmentArrivalTime(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.hospitalizationLocations(context, TheEncounter);

        bool? b_(Encounter.LocationComponent HospitalLocation) {
            ResourceReference h_ = HospitalLocation?.Location;
            Location i_ = this.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;

            CqlConcept k_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

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

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet f_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastSurgeryOP) {
                Period ao_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.End(ap_);
                CqlValueSet ar_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> as_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? at_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> da_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? db_ = da_?.Value;
                    Code<Encounter.EncounterStatus> dc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(db_);
                    bool? dd_ = context.Operators.Equal(dc_, "finished");
                    Period de_ = LastED?.Period;
                    CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.End(df_);
                    CqlValueSet dh_ = this.Observation_Services(context);
                    IEnumerable<Encounter> di_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? dj_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> er_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? es_ = er_?.Value;
                        Code<Encounter.EncounterStatus> et_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(es_);
                        bool? eu_ = context.Operators.Equal(et_, "finished");
                        Period ev_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                        CqlDateTime ex_ = context.Operators.End(ew_);
                        Period ey_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ey_);
                        CqlDateTime fa_ = context.Operators.Start(ez_);
                        CqlQuantity fb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fc_ = context.Operators.Subtract(fa_, fb_);
                        CqlInterval<CqlDateTime> fd_ = context.Operators.Interval(fc_, fa_, true, true);
                        bool? fe_ = context.Operators.In<CqlDateTime>(ex_, fd_, (string)default);
                        bool? ff_ = context.Operators.Not((bool?)(fa_ is null));
                        bool? fg_ = context.Operators.And(fe_, ff_);
                        bool? fh_ = context.Operators.And(eu_, fg_);
                        return fh_;
                    }

                    IEnumerable<Encounter> dk_ = context.Operators.Where<Encounter>(di_, dj_);

                    object dl_(Encounter @this) {
                        Period fi_ = @this?.Period;
                        CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                        CqlDateTime fk_ = context.Operators.End(fj_);
                        return fk_;
                    }

                    IEnumerable<Encounter> dm_ = context.Operators.SortBy<Encounter>(dk_, dl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dn_ = context.Operators.Last<Encounter>(dm_);
                    Period do_ = dn_?.Period;
                    CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    Period dr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                    CqlDateTime dt_ = context.Operators.Start(ds_);
                    CqlQuantity du_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dv_ = context.Operators.Subtract(dq_ ?? dt_, du_);

                    bool? dw_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> fl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fm_ = fl_?.Value;
                        Code<Encounter.EncounterStatus> fn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fm_);
                        bool? fo_ = context.Operators.Equal(fn_, "finished");
                        Period fp_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fp_);
                        CqlDateTime fr_ = context.Operators.End(fq_);
                        Period fs_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fs_);
                        CqlDateTime fu_ = context.Operators.Start(ft_);
                        CqlQuantity fv_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fw_ = context.Operators.Subtract(fu_, fv_);
                        CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(fw_, fu_, true, true);
                        bool? fy_ = context.Operators.In<CqlDateTime>(fr_, fx_, (string)default);
                        bool? fz_ = context.Operators.Not((bool?)(fu_ is null));
                        bool? ga_ = context.Operators.And(fy_, fz_);
                        bool? gb_ = context.Operators.And(fo_, ga_);
                        return gb_;
                    }

                    IEnumerable<Encounter> dx_ = context.Operators.Where<Encounter>(di_, dw_);

                    object dy_(Encounter @this) {
                        Period gc_ = @this?.Period;
                        CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gc_);
                        CqlDateTime ge_ = context.Operators.End(gd_);
                        return ge_;
                    }

                    IEnumerable<Encounter> dz_ = context.Operators.SortBy<Encounter>(dx_, dy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ea_ = context.Operators.Last<Encounter>(dz_);
                    Period eb_ = ea_?.Period;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.Start(ec_);
                    CqlInterval<CqlDateTime> ee_ = context.Operators.Interval(dv_, ed_ ?? dt_, true, true);
                    bool? ef_ = context.Operators.In<CqlDateTime>(dg_, ee_, (string)default);

                    bool? eg_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> gf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gg_ = gf_?.Value;
                        Code<Encounter.EncounterStatus> gh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gg_);
                        bool? gi_ = context.Operators.Equal(gh_, "finished");
                        Period gj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gj_);
                        CqlDateTime gl_ = context.Operators.End(gk_);
                        Period gm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gm_);
                        CqlDateTime go_ = context.Operators.Start(gn_);
                        CqlQuantity gp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gq_ = context.Operators.Subtract(go_, gp_);
                        CqlInterval<CqlDateTime> gr_ = context.Operators.Interval(gq_, go_, true, true);
                        bool? gs_ = context.Operators.In<CqlDateTime>(gl_, gr_, (string)default);
                        bool? gt_ = context.Operators.Not((bool?)(go_ is null));
                        bool? gu_ = context.Operators.And(gs_, gt_);
                        bool? gv_ = context.Operators.And(gi_, gu_);
                        return gv_;
                    }

                    IEnumerable<Encounter> eh_ = context.Operators.Where<Encounter>(di_, eg_);

                    object ei_(Encounter @this) {
                        Period gw_ = @this?.Period;
                        CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gw_);
                        CqlDateTime gy_ = context.Operators.End(gx_);
                        return gy_;
                    }

                    IEnumerable<Encounter> ej_ = context.Operators.SortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ek_ = context.Operators.Last<Encounter>(ej_);
                    Period el_ = ek_?.Period;
                    CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                    CqlDateTime en_ = context.Operators.Start(em_);
                    bool? eo_ = context.Operators.Not((bool?)((en_ ?? dt_) is null));
                    bool? ep_ = context.Operators.And(ef_, eo_);
                    bool? eq_ = context.Operators.And(dd_, ep_);
                    return eq_;
                }

                IEnumerable<Encounter> au_ = context.Operators.Where<Encounter>(as_, at_);

                object av_(Encounter @this) {
                    Period gz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ha_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gz_);
                    CqlDateTime hb_ = context.Operators.End(ha_);
                    return hb_;
                }

                IEnumerable<Encounter> aw_ = context.Operators.SortBy<Encounter>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ax_ = context.Operators.Last<Encounter>(aw_);
                Period ay_ = ax_?.Period;
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlValueSet bb_ = this.Observation_Services(context);
                IEnumerable<Encounter> bc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bd_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> hc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hd_ = hc_?.Value;
                    Code<Encounter.EncounterStatus> he_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hd_);
                    bool? hf_ = context.Operators.Equal(he_, "finished");
                    Period hg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hg_);
                    CqlDateTime hi_ = context.Operators.End(hh_);
                    Period hj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hj_);
                    CqlDateTime hl_ = context.Operators.Start(hk_);
                    CqlQuantity hm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hn_ = context.Operators.Subtract(hl_, hm_);
                    CqlInterval<CqlDateTime> ho_ = context.Operators.Interval(hn_, hl_, true, true);
                    bool? hp_ = context.Operators.In<CqlDateTime>(hi_, ho_, (string)default);
                    bool? hq_ = context.Operators.Not((bool?)(hl_ is null));
                    bool? hr_ = context.Operators.And(hp_, hq_);
                    bool? hs_ = context.Operators.And(hf_, hr_);
                    return hs_;
                }

                IEnumerable<Encounter> be_ = context.Operators.Where<Encounter>(bc_, bd_);

                object bf_(Encounter @this) {
                    Period ht_ = @this?.Period;
                    CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ht_);
                    CqlDateTime hv_ = context.Operators.End(hu_);
                    return hv_;
                }

                IEnumerable<Encounter> bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bh_ = context.Operators.Last<Encounter>(bg_);
                Period bi_ = bh_?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                Period bl_ = Visit?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlQuantity bo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bp_ = context.Operators.Subtract(ba_ ?? bk_ ?? bn_, bo_);

                bool? bq_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> hw_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hx_ = hw_?.Value;
                    Code<Encounter.EncounterStatus> hy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hx_);
                    bool? hz_ = context.Operators.Equal(hy_, "finished");
                    Period ia_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ib_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ia_);
                    CqlDateTime ic_ = context.Operators.End(ib_);
                    CqlValueSet id_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ie_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, id_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? if_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jo_ = jn_?.Value;
                        Code<Encounter.EncounterStatus> jp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jo_);
                        bool? jq_ = context.Operators.Equal(jp_, "finished");
                        Period jr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                        CqlDateTime jt_ = context.Operators.End(js_);
                        Period ju_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ju_);
                        CqlDateTime jw_ = context.Operators.Start(jv_);
                        CqlQuantity jx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jy_ = context.Operators.Subtract(jw_, jx_);
                        CqlInterval<CqlDateTime> jz_ = context.Operators.Interval(jy_, jw_, true, true);
                        bool? ka_ = context.Operators.In<CqlDateTime>(jt_, jz_, (string)default);
                        bool? kb_ = context.Operators.Not((bool?)(jw_ is null));
                        bool? kc_ = context.Operators.And(ka_, kb_);
                        bool? kd_ = context.Operators.And(jq_, kc_);
                        return kd_;
                    }

                    IEnumerable<Encounter> ig_ = context.Operators.Where<Encounter>(ie_, if_);

                    object ih_(Encounter @this) {
                        Period ke_ = @this?.Period;
                        CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ke_);
                        CqlDateTime kg_ = context.Operators.End(kf_);
                        return kg_;
                    }

                    IEnumerable<Encounter> ii_ = context.Operators.SortBy<Encounter>(ig_, ih_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ij_ = context.Operators.Last<Encounter>(ii_);
                    Period ik_ = ij_?.Period;
                    CqlInterval<CqlDateTime> il_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ik_);
                    CqlDateTime im_ = context.Operators.Start(il_);
                    Period in_ = Visit?.Period;
                    CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                    CqlDateTime ip_ = context.Operators.Start(io_);
                    CqlQuantity iq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ir_ = context.Operators.Subtract(im_ ?? ip_, iq_);

                    bool? is_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> kh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ki_ = kh_?.Value;
                        Code<Encounter.EncounterStatus> kj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ki_);
                        bool? kk_ = context.Operators.Equal(kj_, "finished");
                        Period kl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> km_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                        CqlDateTime kn_ = context.Operators.End(km_);
                        Period ko_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                        CqlDateTime kq_ = context.Operators.Start(kp_);
                        CqlQuantity kr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ks_ = context.Operators.Subtract(kq_, kr_);
                        CqlInterval<CqlDateTime> kt_ = context.Operators.Interval(ks_, kq_, true, true);
                        bool? ku_ = context.Operators.In<CqlDateTime>(kn_, kt_, (string)default);
                        bool? kv_ = context.Operators.Not((bool?)(kq_ is null));
                        bool? kw_ = context.Operators.And(ku_, kv_);
                        bool? kx_ = context.Operators.And(kk_, kw_);
                        return kx_;
                    }

                    IEnumerable<Encounter> it_ = context.Operators.Where<Encounter>(ie_, is_);

                    object iu_(Encounter @this) {
                        Period ky_ = @this?.Period;
                        CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                        CqlDateTime la_ = context.Operators.End(kz_);
                        return la_;
                    }

                    IEnumerable<Encounter> iv_ = context.Operators.SortBy<Encounter>(it_, iu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter iw_ = context.Operators.Last<Encounter>(iv_);
                    Period ix_ = iw_?.Period;
                    CqlInterval<CqlDateTime> iy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ix_);
                    CqlDateTime iz_ = context.Operators.Start(iy_);
                    CqlInterval<CqlDateTime> ja_ = context.Operators.Interval(ir_, iz_ ?? ip_, true, true);
                    bool? jb_ = context.Operators.In<CqlDateTime>(ic_, ja_, (string)default);

                    bool? jc_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> lb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lc_ = lb_?.Value;
                        Code<Encounter.EncounterStatus> ld_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lc_);
                        bool? le_ = context.Operators.Equal(ld_, "finished");
                        Period lf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lf_);
                        CqlDateTime lh_ = context.Operators.End(lg_);
                        Period li_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, li_);
                        CqlDateTime lk_ = context.Operators.Start(lj_);
                        CqlQuantity ll_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lm_ = context.Operators.Subtract(lk_, ll_);
                        CqlInterval<CqlDateTime> ln_ = context.Operators.Interval(lm_, lk_, true, true);
                        bool? lo_ = context.Operators.In<CqlDateTime>(lh_, ln_, (string)default);
                        bool? lp_ = context.Operators.Not((bool?)(lk_ is null));
                        bool? lq_ = context.Operators.And(lo_, lp_);
                        bool? lr_ = context.Operators.And(le_, lq_);
                        return lr_;
                    }

                    IEnumerable<Encounter> jd_ = context.Operators.Where<Encounter>(ie_, jc_);

                    object je_(Encounter @this) {
                        Period ls_ = @this?.Period;
                        CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ls_);
                        CqlDateTime lu_ = context.Operators.End(lt_);
                        return lu_;
                    }

                    IEnumerable<Encounter> jf_ = context.Operators.SortBy<Encounter>(jd_, je_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jg_ = context.Operators.Last<Encounter>(jf_);
                    Period jh_ = jg_?.Period;
                    CqlInterval<CqlDateTime> ji_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jh_);
                    CqlDateTime jj_ = context.Operators.Start(ji_);
                    bool? jk_ = context.Operators.Not((bool?)((jj_ ?? ip_) is null));
                    bool? jl_ = context.Operators.And(jb_, jk_);
                    bool? jm_ = context.Operators.And(hz_, jl_);
                    return jm_;
                }

                IEnumerable<Encounter> br_ = context.Operators.Where<Encounter>(as_, bq_);

                object bs_(Encounter @this) {
                    Period lv_ = @this?.Period;
                    CqlInterval<CqlDateTime> lw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lv_);
                    CqlDateTime lx_ = context.Operators.End(lw_);
                    return lx_;
                }

                IEnumerable<Encounter> bt_ = context.Operators.SortBy<Encounter>(br_, bs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bu_ = context.Operators.Last<Encounter>(bt_);
                Period bv_ = bu_?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);

                bool? by_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ly_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lz_ = ly_?.Value;
                    Code<Encounter.EncounterStatus> ma_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lz_);
                    bool? mb_ = context.Operators.Equal(ma_, "finished");
                    Period mc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> md_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                    CqlDateTime me_ = context.Operators.End(md_);
                    Period mf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mf_);
                    CqlDateTime mh_ = context.Operators.Start(mg_);
                    CqlQuantity mi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mj_ = context.Operators.Subtract(mh_, mi_);
                    CqlInterval<CqlDateTime> mk_ = context.Operators.Interval(mj_, mh_, true, true);
                    bool? ml_ = context.Operators.In<CqlDateTime>(me_, mk_, (string)default);
                    bool? mm_ = context.Operators.Not((bool?)(mh_ is null));
                    bool? mn_ = context.Operators.And(ml_, mm_);
                    bool? mo_ = context.Operators.And(mb_, mn_);
                    return mo_;
                }

                IEnumerable<Encounter> bz_ = context.Operators.Where<Encounter>(bc_, by_);

                object ca_(Encounter @this) {
                    Period mp_ = @this?.Period;
                    CqlInterval<CqlDateTime> mq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mp_);
                    CqlDateTime mr_ = context.Operators.End(mq_);
                    return mr_;
                }

                IEnumerable<Encounter> cb_ = context.Operators.SortBy<Encounter>(bz_, ca_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cc_ = context.Operators.Last<Encounter>(cb_);
                Period cd_ = cc_?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(bp_, bx_ ?? cf_ ?? bn_, true, true);
                bool? ch_ = context.Operators.In<CqlDateTime>(aq_, cg_, (string)default);

                bool? ci_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> ms_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mt_ = ms_?.Value;
                    Code<Encounter.EncounterStatus> mu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mt_);
                    bool? mv_ = context.Operators.Equal(mu_, "finished");
                    Period mw_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mw_);
                    CqlDateTime my_ = context.Operators.End(mx_);
                    CqlValueSet mz_ = this.Observation_Services(context);
                    IEnumerable<Encounter> na_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? nb_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> oj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ok_ = oj_?.Value;
                        Code<Encounter.EncounterStatus> ol_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ok_);
                        bool? om_ = context.Operators.Equal(ol_, "finished");
                        Period on_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> oo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, on_);
                        CqlDateTime op_ = context.Operators.End(oo_);
                        Period oq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> or_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oq_);
                        CqlDateTime os_ = context.Operators.Start(or_);
                        CqlQuantity ot_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ou_ = context.Operators.Subtract(os_, ot_);
                        CqlInterval<CqlDateTime> ov_ = context.Operators.Interval(ou_, os_, true, true);
                        bool? ow_ = context.Operators.In<CqlDateTime>(op_, ov_, (string)default);
                        bool? ox_ = context.Operators.Not((bool?)(os_ is null));
                        bool? oy_ = context.Operators.And(ow_, ox_);
                        bool? oz_ = context.Operators.And(om_, oy_);
                        return oz_;
                    }

                    IEnumerable<Encounter> nc_ = context.Operators.Where<Encounter>(na_, nb_);

                    object nd_(Encounter @this) {
                        Period pa_ = @this?.Period;
                        CqlInterval<CqlDateTime> pb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pa_);
                        CqlDateTime pc_ = context.Operators.End(pb_);
                        return pc_;
                    }

                    IEnumerable<Encounter> ne_ = context.Operators.SortBy<Encounter>(nc_, nd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nf_ = context.Operators.Last<Encounter>(ne_);
                    Period ng_ = nf_?.Period;
                    CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ng_);
                    CqlDateTime ni_ = context.Operators.Start(nh_);
                    Period nj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nj_);
                    CqlDateTime nl_ = context.Operators.Start(nk_);
                    CqlQuantity nm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nn_ = context.Operators.Subtract(ni_ ?? nl_, nm_);

                    bool? no_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pd_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pe_ = pd_?.Value;
                        Code<Encounter.EncounterStatus> pf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pe_);
                        bool? pg_ = context.Operators.Equal(pf_, "finished");
                        Period ph_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ph_);
                        CqlDateTime pj_ = context.Operators.End(pi_);
                        Period pk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pk_);
                        CqlDateTime pm_ = context.Operators.Start(pl_);
                        CqlQuantity pn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime po_ = context.Operators.Subtract(pm_, pn_);
                        CqlInterval<CqlDateTime> pp_ = context.Operators.Interval(po_, pm_, true, true);
                        bool? pq_ = context.Operators.In<CqlDateTime>(pj_, pp_, (string)default);
                        bool? pr_ = context.Operators.Not((bool?)(pm_ is null));
                        bool? ps_ = context.Operators.And(pq_, pr_);
                        bool? pt_ = context.Operators.And(pg_, ps_);
                        return pt_;
                    }

                    IEnumerable<Encounter> np_ = context.Operators.Where<Encounter>(na_, no_);

                    object nq_(Encounter @this) {
                        Period pu_ = @this?.Period;
                        CqlInterval<CqlDateTime> pv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pu_);
                        CqlDateTime pw_ = context.Operators.End(pv_);
                        return pw_;
                    }

                    IEnumerable<Encounter> nr_ = context.Operators.SortBy<Encounter>(np_, nq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ns_ = context.Operators.Last<Encounter>(nr_);
                    Period nt_ = ns_?.Period;
                    CqlInterval<CqlDateTime> nu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nt_);
                    CqlDateTime nv_ = context.Operators.Start(nu_);
                    CqlInterval<CqlDateTime> nw_ = context.Operators.Interval(nn_, nv_ ?? nl_, true, true);
                    bool? nx_ = context.Operators.In<CqlDateTime>(my_, nw_, (string)default);

                    bool? ny_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> px_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? py_ = px_?.Value;
                        Code<Encounter.EncounterStatus> pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
                        bool? qa_ = context.Operators.Equal(pz_, "finished");
                        Period qb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                        CqlDateTime qd_ = context.Operators.End(qc_);
                        Period qe_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                        CqlDateTime qg_ = context.Operators.Start(qf_);
                        CqlQuantity qh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qi_ = context.Operators.Subtract(qg_, qh_);
                        CqlInterval<CqlDateTime> qj_ = context.Operators.Interval(qi_, qg_, true, true);
                        bool? qk_ = context.Operators.In<CqlDateTime>(qd_, qj_, (string)default);
                        bool? ql_ = context.Operators.Not((bool?)(qg_ is null));
                        bool? qm_ = context.Operators.And(qk_, ql_);
                        bool? qn_ = context.Operators.And(qa_, qm_);
                        return qn_;
                    }

                    IEnumerable<Encounter> nz_ = context.Operators.Where<Encounter>(na_, ny_);

                    object oa_(Encounter @this) {
                        Period qo_ = @this?.Period;
                        CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                        CqlDateTime qq_ = context.Operators.End(qp_);
                        return qq_;
                    }

                    IEnumerable<Encounter> ob_ = context.Operators.SortBy<Encounter>(nz_, oa_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter oc_ = context.Operators.Last<Encounter>(ob_);
                    Period od_ = oc_?.Period;
                    CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, od_);
                    CqlDateTime of_ = context.Operators.Start(oe_);
                    bool? og_ = context.Operators.Not((bool?)((of_ ?? nl_) is null));
                    bool? oh_ = context.Operators.And(nx_, og_);
                    bool? oi_ = context.Operators.And(mv_, oh_);
                    return oi_;
                }

                IEnumerable<Encounter> cj_ = context.Operators.Where<Encounter>(as_, ci_);

                object ck_(Encounter @this) {
                    Period qr_ = @this?.Period;
                    CqlInterval<CqlDateTime> qs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qr_);
                    CqlDateTime qt_ = context.Operators.End(qs_);
                    return qt_;
                }

                IEnumerable<Encounter> cl_ = context.Operators.SortBy<Encounter>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cm_ = context.Operators.Last<Encounter>(cl_);
                Period cn_ = cm_?.Period;
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                CqlDateTime cp_ = context.Operators.Start(co_);

                bool? cq_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> qu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qv_ = qu_?.Value;
                    Code<Encounter.EncounterStatus> qw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qv_);
                    bool? qx_ = context.Operators.Equal(qw_, "finished");
                    Period qy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qy_);
                    CqlDateTime ra_ = context.Operators.End(qz_);
                    Period rb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlQuantity re_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rf_ = context.Operators.Subtract(rd_, re_);
                    CqlInterval<CqlDateTime> rg_ = context.Operators.Interval(rf_, rd_, true, true);
                    bool? rh_ = context.Operators.In<CqlDateTime>(ra_, rg_, (string)default);
                    bool? ri_ = context.Operators.Not((bool?)(rd_ is null));
                    bool? rj_ = context.Operators.And(rh_, ri_);
                    bool? rk_ = context.Operators.And(qx_, rj_);
                    return rk_;
                }

                IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(bc_, cq_);

                object cs_(Encounter @this) {
                    Period rl_ = @this?.Period;
                    CqlInterval<CqlDateTime> rm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rl_);
                    CqlDateTime rn_ = context.Operators.End(rm_);
                    return rn_;
                }

                IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                Period cv_ = cu_?.Period;
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                bool? cy_ = context.Operators.Not((bool?)((cp_ ?? cx_ ?? bn_) is null));
                bool? cz_ = context.Operators.And(ch_, cy_);
                return cz_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period ro_ = @this?.Period;
                CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ro_);
                CqlDateTime rq_ = context.Operators.End(rp_);
                return rq_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastED) {
                Code<Encounter.EncounterStatus> rr_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rs_ = rr_?.Value;
                Code<Encounter.EncounterStatus> rt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rs_);
                bool? ru_ = context.Operators.Equal(rt_, "finished");
                Period rv_ = LastED?.Period;
                CqlInterval<CqlDateTime> rw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rv_);
                CqlDateTime rx_ = context.Operators.End(rw_);
                CqlValueSet ry_ = this.Observation_Services(context);
                IEnumerable<Encounter> rz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ry_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? sa_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ti_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tj_ = ti_?.Value;
                    Code<Encounter.EncounterStatus> tk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tj_);
                    bool? tl_ = context.Operators.Equal(tk_, "finished");
                    Period tm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tm_);
                    CqlDateTime to_ = context.Operators.End(tn_);
                    Period tp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tp_);
                    CqlDateTime tr_ = context.Operators.Start(tq_);
                    CqlQuantity ts_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tt_ = context.Operators.Subtract(tr_, ts_);
                    CqlInterval<CqlDateTime> tu_ = context.Operators.Interval(tt_, tr_, true, true);
                    bool? tv_ = context.Operators.In<CqlDateTime>(to_, tu_, (string)default);
                    bool? tw_ = context.Operators.Not((bool?)(tr_ is null));
                    bool? tx_ = context.Operators.And(tv_, tw_);
                    bool? ty_ = context.Operators.And(tl_, tx_);
                    return ty_;
                }

                IEnumerable<Encounter> sb_ = context.Operators.Where<Encounter>(rz_, sa_);

                object sc_(Encounter @this) {
                    Period tz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ua_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tz_);
                    CqlDateTime ub_ = context.Operators.End(ua_);
                    return ub_;
                }

                IEnumerable<Encounter> sd_ = context.Operators.SortBy<Encounter>(sb_, sc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter se_ = context.Operators.Last<Encounter>(sd_);
                Period sf_ = se_?.Period;
                CqlInterval<CqlDateTime> sg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sf_);
                CqlDateTime sh_ = context.Operators.Start(sg_);
                Period si_ = Visit?.Period;
                CqlInterval<CqlDateTime> sj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, si_);
                CqlDateTime sk_ = context.Operators.Start(sj_);
                CqlQuantity sl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime sm_ = context.Operators.Subtract(sh_ ?? sk_, sl_);

                bool? sn_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ud_ = uc_?.Value;
                    Code<Encounter.EncounterStatus> ue_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ud_);
                    bool? uf_ = context.Operators.Equal(ue_, "finished");
                    Period ug_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                    CqlDateTime ui_ = context.Operators.End(uh_);
                    Period uj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uj_);
                    CqlDateTime ul_ = context.Operators.Start(uk_);
                    CqlQuantity um_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime un_ = context.Operators.Subtract(ul_, um_);
                    CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(un_, ul_, true, true);
                    bool? up_ = context.Operators.In<CqlDateTime>(ui_, uo_, (string)default);
                    bool? uq_ = context.Operators.Not((bool?)(ul_ is null));
                    bool? ur_ = context.Operators.And(up_, uq_);
                    bool? us_ = context.Operators.And(uf_, ur_);
                    return us_;
                }

                IEnumerable<Encounter> so_ = context.Operators.Where<Encounter>(rz_, sn_);

                object sp_(Encounter @this) {
                    Period ut_ = @this?.Period;
                    CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                    CqlDateTime uv_ = context.Operators.End(uu_);
                    return uv_;
                }

                IEnumerable<Encounter> sq_ = context.Operators.SortBy<Encounter>(so_, sp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sr_ = context.Operators.Last<Encounter>(sq_);
                Period ss_ = sr_?.Period;
                CqlInterval<CqlDateTime> st_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ss_);
                CqlDateTime su_ = context.Operators.Start(st_);
                CqlInterval<CqlDateTime> sv_ = context.Operators.Interval(sm_, su_ ?? sk_, true, true);
                bool? sw_ = context.Operators.In<CqlDateTime>(rx_, sv_, (string)default);

                bool? sx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ux_ = uw_?.Value;
                    Code<Encounter.EncounterStatus> uy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ux_);
                    bool? uz_ = context.Operators.Equal(uy_, "finished");
                    Period va_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, va_);
                    CqlDateTime vc_ = context.Operators.End(vb_);
                    Period vd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ve_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vd_);
                    CqlDateTime vf_ = context.Operators.Start(ve_);
                    CqlQuantity vg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vh_ = context.Operators.Subtract(vf_, vg_);
                    CqlInterval<CqlDateTime> vi_ = context.Operators.Interval(vh_, vf_, true, true);
                    bool? vj_ = context.Operators.In<CqlDateTime>(vc_, vi_, (string)default);
                    bool? vk_ = context.Operators.Not((bool?)(vf_ is null));
                    bool? vl_ = context.Operators.And(vj_, vk_);
                    bool? vm_ = context.Operators.And(uz_, vl_);
                    return vm_;
                }

                IEnumerable<Encounter> sy_ = context.Operators.Where<Encounter>(rz_, sx_);

                object sz_(Encounter @this) {
                    Period vn_ = @this?.Period;
                    CqlInterval<CqlDateTime> vo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vn_);
                    CqlDateTime vp_ = context.Operators.End(vo_);
                    return vp_;
                }

                IEnumerable<Encounter> ta_ = context.Operators.SortBy<Encounter>(sy_, sz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tb_ = context.Operators.Last<Encounter>(ta_);
                Period tc_ = tb_?.Period;
                CqlInterval<CqlDateTime> td_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tc_);
                CqlDateTime te_ = context.Operators.Start(td_);
                bool? tf_ = context.Operators.Not((bool?)((te_ ?? sk_) is null));
                bool? tg_ = context.Operators.And(sw_, tf_);
                bool? th_ = context.Operators.And(ru_, tg_);
                return th_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period vq_ = @this?.Period;
                CqlInterval<CqlDateTime> vr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vq_);
                CqlDateTime vs_ = context.Operators.End(vr_);
                return vs_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlValueSet z_ = this.Observation_Services(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ab_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> vt_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? vu_ = vt_?.Value;
                Code<Encounter.EncounterStatus> vv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vu_);
                bool? vw_ = context.Operators.Equal(vv_, "finished");
                Period vx_ = LastObs?.Period;
                CqlInterval<CqlDateTime> vy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vx_);
                CqlDateTime vz_ = context.Operators.End(vy_);
                Period wa_ = Visit?.Period;
                CqlInterval<CqlDateTime> wb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wa_);
                CqlDateTime wc_ = context.Operators.Start(wb_);
                CqlQuantity wd_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime we_ = context.Operators.Subtract(wc_, wd_);
                CqlInterval<CqlDateTime> wf_ = context.Operators.Interval(we_, wc_, true, true);
                bool? wg_ = context.Operators.In<CqlDateTime>(vz_, wf_, (string)default);
                bool? wh_ = context.Operators.Not((bool?)(wc_ is null));
                bool? wi_ = context.Operators.And(wg_, wh_);
                bool? wj_ = context.Operators.And(vw_, wi_);
                return wj_;
            }

            IEnumerable<Encounter> ac_ = context.Operators.Where<Encounter>(aa_, ab_);

            object ad_(Encounter @this) {
                Period wk_ = @this?.Period;
                CqlInterval<CqlDateTime> wl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wk_);
                CqlDateTime wm_ = context.Operators.End(wl_);
                return wm_;
            }

            IEnumerable<Encounter> ae_ = context.Operators.SortBy<Encounter>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter af_ = context.Operators.Last<Encounter>(ae_);
            Period ag_ = af_?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            Period aj_ = Visit?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDateTime am_ = context.Operators.End(ak_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(o_ ?? y_ ?? ai_ ?? al_, am_, true, true);
            return an_;
        }

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

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet f_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastSurgeryOP) {
                Period ao_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.End(ap_);
                CqlValueSet ar_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> as_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? at_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> da_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? db_ = da_?.Value;
                    Code<Encounter.EncounterStatus> dc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(db_);
                    bool? dd_ = context.Operators.Equal(dc_, "finished");
                    Period de_ = LastED?.Period;
                    CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.End(df_);
                    CqlValueSet dh_ = this.Observation_Services(context);
                    IEnumerable<Encounter> di_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? dj_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> er_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? es_ = er_?.Value;
                        Code<Encounter.EncounterStatus> et_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(es_);
                        bool? eu_ = context.Operators.Equal(et_, "finished");
                        Period ev_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                        CqlDateTime ex_ = context.Operators.End(ew_);
                        Period ey_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ey_);
                        CqlDateTime fa_ = context.Operators.Start(ez_);
                        CqlQuantity fb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fc_ = context.Operators.Subtract(fa_, fb_);
                        CqlInterval<CqlDateTime> fd_ = context.Operators.Interval(fc_, fa_, true, true);
                        bool? fe_ = context.Operators.In<CqlDateTime>(ex_, fd_, (string)default);
                        bool? ff_ = context.Operators.Not((bool?)(fa_ is null));
                        bool? fg_ = context.Operators.And(fe_, ff_);
                        bool? fh_ = context.Operators.And(eu_, fg_);
                        return fh_;
                    }

                    IEnumerable<Encounter> dk_ = context.Operators.Where<Encounter>(di_, dj_);

                    object dl_(Encounter @this) {
                        Period fi_ = @this?.Period;
                        CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                        CqlDateTime fk_ = context.Operators.End(fj_);
                        return fk_;
                    }

                    IEnumerable<Encounter> dm_ = context.Operators.SortBy<Encounter>(dk_, dl_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dn_ = context.Operators.Last<Encounter>(dm_);
                    Period do_ = dn_?.Period;
                    CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    Period dr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                    CqlDateTime dt_ = context.Operators.Start(ds_);
                    CqlQuantity du_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dv_ = context.Operators.Subtract(dq_ ?? dt_, du_);

                    bool? dw_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> fl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fm_ = fl_?.Value;
                        Code<Encounter.EncounterStatus> fn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fm_);
                        bool? fo_ = context.Operators.Equal(fn_, "finished");
                        Period fp_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fp_);
                        CqlDateTime fr_ = context.Operators.End(fq_);
                        Period fs_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fs_);
                        CqlDateTime fu_ = context.Operators.Start(ft_);
                        CqlQuantity fv_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fw_ = context.Operators.Subtract(fu_, fv_);
                        CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(fw_, fu_, true, true);
                        bool? fy_ = context.Operators.In<CqlDateTime>(fr_, fx_, (string)default);
                        bool? fz_ = context.Operators.Not((bool?)(fu_ is null));
                        bool? ga_ = context.Operators.And(fy_, fz_);
                        bool? gb_ = context.Operators.And(fo_, ga_);
                        return gb_;
                    }

                    IEnumerable<Encounter> dx_ = context.Operators.Where<Encounter>(di_, dw_);

                    object dy_(Encounter @this) {
                        Period gc_ = @this?.Period;
                        CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gc_);
                        CqlDateTime ge_ = context.Operators.End(gd_);
                        return ge_;
                    }

                    IEnumerable<Encounter> dz_ = context.Operators.SortBy<Encounter>(dx_, dy_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ea_ = context.Operators.Last<Encounter>(dz_);
                    Period eb_ = ea_?.Period;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.Start(ec_);
                    CqlInterval<CqlDateTime> ee_ = context.Operators.Interval(dv_, ed_ ?? dt_, true, true);
                    bool? ef_ = context.Operators.In<CqlDateTime>(dg_, ee_, (string)default);

                    bool? eg_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> gf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gg_ = gf_?.Value;
                        Code<Encounter.EncounterStatus> gh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gg_);
                        bool? gi_ = context.Operators.Equal(gh_, "finished");
                        Period gj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gj_);
                        CqlDateTime gl_ = context.Operators.End(gk_);
                        Period gm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gm_);
                        CqlDateTime go_ = context.Operators.Start(gn_);
                        CqlQuantity gp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gq_ = context.Operators.Subtract(go_, gp_);
                        CqlInterval<CqlDateTime> gr_ = context.Operators.Interval(gq_, go_, true, true);
                        bool? gs_ = context.Operators.In<CqlDateTime>(gl_, gr_, (string)default);
                        bool? gt_ = context.Operators.Not((bool?)(go_ is null));
                        bool? gu_ = context.Operators.And(gs_, gt_);
                        bool? gv_ = context.Operators.And(gi_, gu_);
                        return gv_;
                    }

                    IEnumerable<Encounter> eh_ = context.Operators.Where<Encounter>(di_, eg_);

                    object ei_(Encounter @this) {
                        Period gw_ = @this?.Period;
                        CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gw_);
                        CqlDateTime gy_ = context.Operators.End(gx_);
                        return gy_;
                    }

                    IEnumerable<Encounter> ej_ = context.Operators.SortBy<Encounter>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ek_ = context.Operators.Last<Encounter>(ej_);
                    Period el_ = ek_?.Period;
                    CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                    CqlDateTime en_ = context.Operators.Start(em_);
                    bool? eo_ = context.Operators.Not((bool?)((en_ ?? dt_) is null));
                    bool? ep_ = context.Operators.And(ef_, eo_);
                    bool? eq_ = context.Operators.And(dd_, ep_);
                    return eq_;
                }

                IEnumerable<Encounter> au_ = context.Operators.Where<Encounter>(as_, at_);

                object av_(Encounter @this) {
                    Period gz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ha_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gz_);
                    CqlDateTime hb_ = context.Operators.End(ha_);
                    return hb_;
                }

                IEnumerable<Encounter> aw_ = context.Operators.SortBy<Encounter>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ax_ = context.Operators.Last<Encounter>(aw_);
                Period ay_ = ax_?.Period;
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlValueSet bb_ = this.Observation_Services(context);
                IEnumerable<Encounter> bc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bd_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> hc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hd_ = hc_?.Value;
                    Code<Encounter.EncounterStatus> he_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hd_);
                    bool? hf_ = context.Operators.Equal(he_, "finished");
                    Period hg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hg_);
                    CqlDateTime hi_ = context.Operators.End(hh_);
                    Period hj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> hk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hj_);
                    CqlDateTime hl_ = context.Operators.Start(hk_);
                    CqlQuantity hm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hn_ = context.Operators.Subtract(hl_, hm_);
                    CqlInterval<CqlDateTime> ho_ = context.Operators.Interval(hn_, hl_, true, true);
                    bool? hp_ = context.Operators.In<CqlDateTime>(hi_, ho_, (string)default);
                    bool? hq_ = context.Operators.Not((bool?)(hl_ is null));
                    bool? hr_ = context.Operators.And(hp_, hq_);
                    bool? hs_ = context.Operators.And(hf_, hr_);
                    return hs_;
                }

                IEnumerable<Encounter> be_ = context.Operators.Where<Encounter>(bc_, bd_);

                object bf_(Encounter @this) {
                    Period ht_ = @this?.Period;
                    CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ht_);
                    CqlDateTime hv_ = context.Operators.End(hu_);
                    return hv_;
                }

                IEnumerable<Encounter> bg_ = context.Operators.SortBy<Encounter>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bh_ = context.Operators.Last<Encounter>(bg_);
                Period bi_ = bh_?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                Period bl_ = Visit?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                CqlQuantity bo_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bp_ = context.Operators.Subtract(ba_ ?? bk_ ?? bn_, bo_);

                bool? bq_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> hw_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hx_ = hw_?.Value;
                    Code<Encounter.EncounterStatus> hy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hx_);
                    bool? hz_ = context.Operators.Equal(hy_, "finished");
                    Period ia_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ib_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ia_);
                    CqlDateTime ic_ = context.Operators.End(ib_);
                    CqlValueSet id_ = this.Observation_Services(context);
                    IEnumerable<Encounter> ie_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, id_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? if_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jn_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jo_ = jn_?.Value;
                        Code<Encounter.EncounterStatus> jp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jo_);
                        bool? jq_ = context.Operators.Equal(jp_, "finished");
                        Period jr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                        CqlDateTime jt_ = context.Operators.End(js_);
                        Period ju_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ju_);
                        CqlDateTime jw_ = context.Operators.Start(jv_);
                        CqlQuantity jx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jy_ = context.Operators.Subtract(jw_, jx_);
                        CqlInterval<CqlDateTime> jz_ = context.Operators.Interval(jy_, jw_, true, true);
                        bool? ka_ = context.Operators.In<CqlDateTime>(jt_, jz_, (string)default);
                        bool? kb_ = context.Operators.Not((bool?)(jw_ is null));
                        bool? kc_ = context.Operators.And(ka_, kb_);
                        bool? kd_ = context.Operators.And(jq_, kc_);
                        return kd_;
                    }

                    IEnumerable<Encounter> ig_ = context.Operators.Where<Encounter>(ie_, if_);

                    object ih_(Encounter @this) {
                        Period ke_ = @this?.Period;
                        CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ke_);
                        CqlDateTime kg_ = context.Operators.End(kf_);
                        return kg_;
                    }

                    IEnumerable<Encounter> ii_ = context.Operators.SortBy<Encounter>(ig_, ih_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ij_ = context.Operators.Last<Encounter>(ii_);
                    Period ik_ = ij_?.Period;
                    CqlInterval<CqlDateTime> il_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ik_);
                    CqlDateTime im_ = context.Operators.Start(il_);
                    Period in_ = Visit?.Period;
                    CqlInterval<CqlDateTime> io_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, in_);
                    CqlDateTime ip_ = context.Operators.Start(io_);
                    CqlQuantity iq_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ir_ = context.Operators.Subtract(im_ ?? ip_, iq_);

                    bool? is_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> kh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ki_ = kh_?.Value;
                        Code<Encounter.EncounterStatus> kj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ki_);
                        bool? kk_ = context.Operators.Equal(kj_, "finished");
                        Period kl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> km_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kl_);
                        CqlDateTime kn_ = context.Operators.End(km_);
                        Period ko_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                        CqlDateTime kq_ = context.Operators.Start(kp_);
                        CqlQuantity kr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ks_ = context.Operators.Subtract(kq_, kr_);
                        CqlInterval<CqlDateTime> kt_ = context.Operators.Interval(ks_, kq_, true, true);
                        bool? ku_ = context.Operators.In<CqlDateTime>(kn_, kt_, (string)default);
                        bool? kv_ = context.Operators.Not((bool?)(kq_ is null));
                        bool? kw_ = context.Operators.And(ku_, kv_);
                        bool? kx_ = context.Operators.And(kk_, kw_);
                        return kx_;
                    }

                    IEnumerable<Encounter> it_ = context.Operators.Where<Encounter>(ie_, is_);

                    object iu_(Encounter @this) {
                        Period ky_ = @this?.Period;
                        CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                        CqlDateTime la_ = context.Operators.End(kz_);
                        return la_;
                    }

                    IEnumerable<Encounter> iv_ = context.Operators.SortBy<Encounter>(it_, iu_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter iw_ = context.Operators.Last<Encounter>(iv_);
                    Period ix_ = iw_?.Period;
                    CqlInterval<CqlDateTime> iy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ix_);
                    CqlDateTime iz_ = context.Operators.Start(iy_);
                    CqlInterval<CqlDateTime> ja_ = context.Operators.Interval(ir_, iz_ ?? ip_, true, true);
                    bool? jb_ = context.Operators.In<CqlDateTime>(ic_, ja_, (string)default);

                    bool? jc_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> lb_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lc_ = lb_?.Value;
                        Code<Encounter.EncounterStatus> ld_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lc_);
                        bool? le_ = context.Operators.Equal(ld_, "finished");
                        Period lf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lf_);
                        CqlDateTime lh_ = context.Operators.End(lg_);
                        Period li_ = Visit?.Period;
                        CqlInterval<CqlDateTime> lj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, li_);
                        CqlDateTime lk_ = context.Operators.Start(lj_);
                        CqlQuantity ll_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lm_ = context.Operators.Subtract(lk_, ll_);
                        CqlInterval<CqlDateTime> ln_ = context.Operators.Interval(lm_, lk_, true, true);
                        bool? lo_ = context.Operators.In<CqlDateTime>(lh_, ln_, (string)default);
                        bool? lp_ = context.Operators.Not((bool?)(lk_ is null));
                        bool? lq_ = context.Operators.And(lo_, lp_);
                        bool? lr_ = context.Operators.And(le_, lq_);
                        return lr_;
                    }

                    IEnumerable<Encounter> jd_ = context.Operators.Where<Encounter>(ie_, jc_);

                    object je_(Encounter @this) {
                        Period ls_ = @this?.Period;
                        CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ls_);
                        CqlDateTime lu_ = context.Operators.End(lt_);
                        return lu_;
                    }

                    IEnumerable<Encounter> jf_ = context.Operators.SortBy<Encounter>(jd_, je_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter jg_ = context.Operators.Last<Encounter>(jf_);
                    Period jh_ = jg_?.Period;
                    CqlInterval<CqlDateTime> ji_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jh_);
                    CqlDateTime jj_ = context.Operators.Start(ji_);
                    bool? jk_ = context.Operators.Not((bool?)((jj_ ?? ip_) is null));
                    bool? jl_ = context.Operators.And(jb_, jk_);
                    bool? jm_ = context.Operators.And(hz_, jl_);
                    return jm_;
                }

                IEnumerable<Encounter> br_ = context.Operators.Where<Encounter>(as_, bq_);

                object bs_(Encounter @this) {
                    Period lv_ = @this?.Period;
                    CqlInterval<CqlDateTime> lw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lv_);
                    CqlDateTime lx_ = context.Operators.End(lw_);
                    return lx_;
                }

                IEnumerable<Encounter> bt_ = context.Operators.SortBy<Encounter>(br_, bs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bu_ = context.Operators.Last<Encounter>(bt_);
                Period bv_ = bu_?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);

                bool? by_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ly_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lz_ = ly_?.Value;
                    Code<Encounter.EncounterStatus> ma_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lz_);
                    bool? mb_ = context.Operators.Equal(ma_, "finished");
                    Period mc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> md_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mc_);
                    CqlDateTime me_ = context.Operators.End(md_);
                    Period mf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> mg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mf_);
                    CqlDateTime mh_ = context.Operators.Start(mg_);
                    CqlQuantity mi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime mj_ = context.Operators.Subtract(mh_, mi_);
                    CqlInterval<CqlDateTime> mk_ = context.Operators.Interval(mj_, mh_, true, true);
                    bool? ml_ = context.Operators.In<CqlDateTime>(me_, mk_, (string)default);
                    bool? mm_ = context.Operators.Not((bool?)(mh_ is null));
                    bool? mn_ = context.Operators.And(ml_, mm_);
                    bool? mo_ = context.Operators.And(mb_, mn_);
                    return mo_;
                }

                IEnumerable<Encounter> bz_ = context.Operators.Where<Encounter>(bc_, by_);

                object ca_(Encounter @this) {
                    Period mp_ = @this?.Period;
                    CqlInterval<CqlDateTime> mq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mp_);
                    CqlDateTime mr_ = context.Operators.End(mq_);
                    return mr_;
                }

                IEnumerable<Encounter> cb_ = context.Operators.SortBy<Encounter>(bz_, ca_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cc_ = context.Operators.Last<Encounter>(cb_);
                Period cd_ = cc_?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(bp_, bx_ ?? cf_ ?? bn_, true, true);
                bool? ch_ = context.Operators.In<CqlDateTime>(aq_, cg_, (string)default);

                bool? ci_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> ms_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mt_ = ms_?.Value;
                    Code<Encounter.EncounterStatus> mu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mt_);
                    bool? mv_ = context.Operators.Equal(mu_, "finished");
                    Period mw_ = LastED?.Period;
                    CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mw_);
                    CqlDateTime my_ = context.Operators.End(mx_);
                    CqlValueSet mz_ = this.Observation_Services(context);
                    IEnumerable<Encounter> na_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? nb_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> oj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ok_ = oj_?.Value;
                        Code<Encounter.EncounterStatus> ol_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ok_);
                        bool? om_ = context.Operators.Equal(ol_, "finished");
                        Period on_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> oo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, on_);
                        CqlDateTime op_ = context.Operators.End(oo_);
                        Period oq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> or_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oq_);
                        CqlDateTime os_ = context.Operators.Start(or_);
                        CqlQuantity ot_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ou_ = context.Operators.Subtract(os_, ot_);
                        CqlInterval<CqlDateTime> ov_ = context.Operators.Interval(ou_, os_, true, true);
                        bool? ow_ = context.Operators.In<CqlDateTime>(op_, ov_, (string)default);
                        bool? ox_ = context.Operators.Not((bool?)(os_ is null));
                        bool? oy_ = context.Operators.And(ow_, ox_);
                        bool? oz_ = context.Operators.And(om_, oy_);
                        return oz_;
                    }

                    IEnumerable<Encounter> nc_ = context.Operators.Where<Encounter>(na_, nb_);

                    object nd_(Encounter @this) {
                        Period pa_ = @this?.Period;
                        CqlInterval<CqlDateTime> pb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pa_);
                        CqlDateTime pc_ = context.Operators.End(pb_);
                        return pc_;
                    }

                    IEnumerable<Encounter> ne_ = context.Operators.SortBy<Encounter>(nc_, nd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nf_ = context.Operators.Last<Encounter>(ne_);
                    Period ng_ = nf_?.Period;
                    CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ng_);
                    CqlDateTime ni_ = context.Operators.Start(nh_);
                    Period nj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nj_);
                    CqlDateTime nl_ = context.Operators.Start(nk_);
                    CqlQuantity nm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nn_ = context.Operators.Subtract(ni_ ?? nl_, nm_);

                    bool? no_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pd_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pe_ = pd_?.Value;
                        Code<Encounter.EncounterStatus> pf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pe_);
                        bool? pg_ = context.Operators.Equal(pf_, "finished");
                        Period ph_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ph_);
                        CqlDateTime pj_ = context.Operators.End(pi_);
                        Period pk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pk_);
                        CqlDateTime pm_ = context.Operators.Start(pl_);
                        CqlQuantity pn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime po_ = context.Operators.Subtract(pm_, pn_);
                        CqlInterval<CqlDateTime> pp_ = context.Operators.Interval(po_, pm_, true, true);
                        bool? pq_ = context.Operators.In<CqlDateTime>(pj_, pp_, (string)default);
                        bool? pr_ = context.Operators.Not((bool?)(pm_ is null));
                        bool? ps_ = context.Operators.And(pq_, pr_);
                        bool? pt_ = context.Operators.And(pg_, ps_);
                        return pt_;
                    }

                    IEnumerable<Encounter> np_ = context.Operators.Where<Encounter>(na_, no_);

                    object nq_(Encounter @this) {
                        Period pu_ = @this?.Period;
                        CqlInterval<CqlDateTime> pv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pu_);
                        CqlDateTime pw_ = context.Operators.End(pv_);
                        return pw_;
                    }

                    IEnumerable<Encounter> nr_ = context.Operators.SortBy<Encounter>(np_, nq_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ns_ = context.Operators.Last<Encounter>(nr_);
                    Period nt_ = ns_?.Period;
                    CqlInterval<CqlDateTime> nu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nt_);
                    CqlDateTime nv_ = context.Operators.Start(nu_);
                    CqlInterval<CqlDateTime> nw_ = context.Operators.Interval(nn_, nv_ ?? nl_, true, true);
                    bool? nx_ = context.Operators.In<CqlDateTime>(my_, nw_, (string)default);

                    bool? ny_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> px_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? py_ = px_?.Value;
                        Code<Encounter.EncounterStatus> pz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(py_);
                        bool? qa_ = context.Operators.Equal(pz_, "finished");
                        Period qb_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                        CqlDateTime qd_ = context.Operators.End(qc_);
                        Period qe_ = Visit?.Period;
                        CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                        CqlDateTime qg_ = context.Operators.Start(qf_);
                        CqlQuantity qh_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime qi_ = context.Operators.Subtract(qg_, qh_);
                        CqlInterval<CqlDateTime> qj_ = context.Operators.Interval(qi_, qg_, true, true);
                        bool? qk_ = context.Operators.In<CqlDateTime>(qd_, qj_, (string)default);
                        bool? ql_ = context.Operators.Not((bool?)(qg_ is null));
                        bool? qm_ = context.Operators.And(qk_, ql_);
                        bool? qn_ = context.Operators.And(qa_, qm_);
                        return qn_;
                    }

                    IEnumerable<Encounter> nz_ = context.Operators.Where<Encounter>(na_, ny_);

                    object oa_(Encounter @this) {
                        Period qo_ = @this?.Period;
                        CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                        CqlDateTime qq_ = context.Operators.End(qp_);
                        return qq_;
                    }

                    IEnumerable<Encounter> ob_ = context.Operators.SortBy<Encounter>(nz_, oa_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter oc_ = context.Operators.Last<Encounter>(ob_);
                    Period od_ = oc_?.Period;
                    CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, od_);
                    CqlDateTime of_ = context.Operators.Start(oe_);
                    bool? og_ = context.Operators.Not((bool?)((of_ ?? nl_) is null));
                    bool? oh_ = context.Operators.And(nx_, og_);
                    bool? oi_ = context.Operators.And(mv_, oh_);
                    return oi_;
                }

                IEnumerable<Encounter> cj_ = context.Operators.Where<Encounter>(as_, ci_);

                object ck_(Encounter @this) {
                    Period qr_ = @this?.Period;
                    CqlInterval<CqlDateTime> qs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qr_);
                    CqlDateTime qt_ = context.Operators.End(qs_);
                    return qt_;
                }

                IEnumerable<Encounter> cl_ = context.Operators.SortBy<Encounter>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cm_ = context.Operators.Last<Encounter>(cl_);
                Period cn_ = cm_?.Period;
                CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                CqlDateTime cp_ = context.Operators.Start(co_);

                bool? cq_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> qu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qv_ = qu_?.Value;
                    Code<Encounter.EncounterStatus> qw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qv_);
                    bool? qx_ = context.Operators.Equal(qw_, "finished");
                    Period qy_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qy_);
                    CqlDateTime ra_ = context.Operators.End(qz_);
                    Period rb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlQuantity re_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rf_ = context.Operators.Subtract(rd_, re_);
                    CqlInterval<CqlDateTime> rg_ = context.Operators.Interval(rf_, rd_, true, true);
                    bool? rh_ = context.Operators.In<CqlDateTime>(ra_, rg_, (string)default);
                    bool? ri_ = context.Operators.Not((bool?)(rd_ is null));
                    bool? rj_ = context.Operators.And(rh_, ri_);
                    bool? rk_ = context.Operators.And(qx_, rj_);
                    return rk_;
                }

                IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(bc_, cq_);

                object cs_(Encounter @this) {
                    Period rl_ = @this?.Period;
                    CqlInterval<CqlDateTime> rm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rl_);
                    CqlDateTime rn_ = context.Operators.End(rm_);
                    return rn_;
                }

                IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                Period cv_ = cu_?.Period;
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                bool? cy_ = context.Operators.Not((bool?)((cp_ ?? cx_ ?? bn_) is null));
                bool? cz_ = context.Operators.And(ch_, cy_);
                return cz_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period ro_ = @this?.Period;
                CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ro_);
                CqlDateTime rq_ = context.Operators.End(rp_);
                return rq_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastED) {
                Code<Encounter.EncounterStatus> rr_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rs_ = rr_?.Value;
                Code<Encounter.EncounterStatus> rt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rs_);
                bool? ru_ = context.Operators.Equal(rt_, "finished");
                Period rv_ = LastED?.Period;
                CqlInterval<CqlDateTime> rw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rv_);
                CqlDateTime rx_ = context.Operators.End(rw_);
                CqlValueSet ry_ = this.Observation_Services(context);
                IEnumerable<Encounter> rz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ry_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? sa_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ti_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tj_ = ti_?.Value;
                    Code<Encounter.EncounterStatus> tk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tj_);
                    bool? tl_ = context.Operators.Equal(tk_, "finished");
                    Period tm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> tn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tm_);
                    CqlDateTime to_ = context.Operators.End(tn_);
                    Period tp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tp_);
                    CqlDateTime tr_ = context.Operators.Start(tq_);
                    CqlQuantity ts_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tt_ = context.Operators.Subtract(tr_, ts_);
                    CqlInterval<CqlDateTime> tu_ = context.Operators.Interval(tt_, tr_, true, true);
                    bool? tv_ = context.Operators.In<CqlDateTime>(to_, tu_, (string)default);
                    bool? tw_ = context.Operators.Not((bool?)(tr_ is null));
                    bool? tx_ = context.Operators.And(tv_, tw_);
                    bool? ty_ = context.Operators.And(tl_, tx_);
                    return ty_;
                }

                IEnumerable<Encounter> sb_ = context.Operators.Where<Encounter>(rz_, sa_);

                object sc_(Encounter @this) {
                    Period tz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ua_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tz_);
                    CqlDateTime ub_ = context.Operators.End(ua_);
                    return ub_;
                }

                IEnumerable<Encounter> sd_ = context.Operators.SortBy<Encounter>(sb_, sc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter se_ = context.Operators.Last<Encounter>(sd_);
                Period sf_ = se_?.Period;
                CqlInterval<CqlDateTime> sg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sf_);
                CqlDateTime sh_ = context.Operators.Start(sg_);
                Period si_ = Visit?.Period;
                CqlInterval<CqlDateTime> sj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, si_);
                CqlDateTime sk_ = context.Operators.Start(sj_);
                CqlQuantity sl_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime sm_ = context.Operators.Subtract(sh_ ?? sk_, sl_);

                bool? sn_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ud_ = uc_?.Value;
                    Code<Encounter.EncounterStatus> ue_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ud_);
                    bool? uf_ = context.Operators.Equal(ue_, "finished");
                    Period ug_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                    CqlDateTime ui_ = context.Operators.End(uh_);
                    Period uj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uj_);
                    CqlDateTime ul_ = context.Operators.Start(uk_);
                    CqlQuantity um_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime un_ = context.Operators.Subtract(ul_, um_);
                    CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(un_, ul_, true, true);
                    bool? up_ = context.Operators.In<CqlDateTime>(ui_, uo_, (string)default);
                    bool? uq_ = context.Operators.Not((bool?)(ul_ is null));
                    bool? ur_ = context.Operators.And(up_, uq_);
                    bool? us_ = context.Operators.And(uf_, ur_);
                    return us_;
                }

                IEnumerable<Encounter> so_ = context.Operators.Where<Encounter>(rz_, sn_);

                object sp_(Encounter @this) {
                    Period ut_ = @this?.Period;
                    CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                    CqlDateTime uv_ = context.Operators.End(uu_);
                    return uv_;
                }

                IEnumerable<Encounter> sq_ = context.Operators.SortBy<Encounter>(so_, sp_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sr_ = context.Operators.Last<Encounter>(sq_);
                Period ss_ = sr_?.Period;
                CqlInterval<CqlDateTime> st_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ss_);
                CqlDateTime su_ = context.Operators.Start(st_);
                CqlInterval<CqlDateTime> sv_ = context.Operators.Interval(sm_, su_ ?? sk_, true, true);
                bool? sw_ = context.Operators.In<CqlDateTime>(rx_, sv_, (string)default);

                bool? sx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ux_ = uw_?.Value;
                    Code<Encounter.EncounterStatus> uy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ux_);
                    bool? uz_ = context.Operators.Equal(uy_, "finished");
                    Period va_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> vb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, va_);
                    CqlDateTime vc_ = context.Operators.End(vb_);
                    Period vd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ve_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vd_);
                    CqlDateTime vf_ = context.Operators.Start(ve_);
                    CqlQuantity vg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime vh_ = context.Operators.Subtract(vf_, vg_);
                    CqlInterval<CqlDateTime> vi_ = context.Operators.Interval(vh_, vf_, true, true);
                    bool? vj_ = context.Operators.In<CqlDateTime>(vc_, vi_, (string)default);
                    bool? vk_ = context.Operators.Not((bool?)(vf_ is null));
                    bool? vl_ = context.Operators.And(vj_, vk_);
                    bool? vm_ = context.Operators.And(uz_, vl_);
                    return vm_;
                }

                IEnumerable<Encounter> sy_ = context.Operators.Where<Encounter>(rz_, sx_);

                object sz_(Encounter @this) {
                    Period vn_ = @this?.Period;
                    CqlInterval<CqlDateTime> vo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vn_);
                    CqlDateTime vp_ = context.Operators.End(vo_);
                    return vp_;
                }

                IEnumerable<Encounter> ta_ = context.Operators.SortBy<Encounter>(sy_, sz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter tb_ = context.Operators.Last<Encounter>(ta_);
                Period tc_ = tb_?.Period;
                CqlInterval<CqlDateTime> td_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tc_);
                CqlDateTime te_ = context.Operators.Start(td_);
                bool? tf_ = context.Operators.Not((bool?)((te_ ?? sk_) is null));
                bool? tg_ = context.Operators.And(sw_, tf_);
                bool? th_ = context.Operators.And(ru_, tg_);
                return th_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period vq_ = @this?.Period;
                CqlInterval<CqlDateTime> vr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vq_);
                CqlDateTime vs_ = context.Operators.End(vr_);
                return vs_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlValueSet z_ = this.Observation_Services(context);
            IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? ab_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> vt_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? vu_ = vt_?.Value;
                Code<Encounter.EncounterStatus> vv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vu_);
                bool? vw_ = context.Operators.Equal(vv_, "finished");
                Period vx_ = LastObs?.Period;
                CqlInterval<CqlDateTime> vy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vx_);
                CqlDateTime vz_ = context.Operators.End(vy_);
                Period wa_ = Visit?.Period;
                CqlInterval<CqlDateTime> wb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wa_);
                CqlDateTime wc_ = context.Operators.Start(wb_);
                CqlQuantity wd_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime we_ = context.Operators.Subtract(wc_, wd_);
                CqlInterval<CqlDateTime> wf_ = context.Operators.Interval(we_, wc_, true, true);
                bool? wg_ = context.Operators.In<CqlDateTime>(vz_, wf_, (string)default);
                bool? wh_ = context.Operators.Not((bool?)(wc_ is null));
                bool? wi_ = context.Operators.And(wg_, wh_);
                bool? wj_ = context.Operators.And(vw_, wi_);
                return wj_;
            }

            IEnumerable<Encounter> ac_ = context.Operators.Where<Encounter>(aa_, ab_);

            object ad_(Encounter @this) {
                Period wk_ = @this?.Period;
                CqlInterval<CqlDateTime> wl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wk_);
                CqlDateTime wm_ = context.Operators.End(wl_);
                return wm_;
            }

            IEnumerable<Encounter> ae_ = context.Operators.SortBy<Encounter>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter af_ = context.Operators.Last<Encounter>(ae_);
            Period ag_ = af_?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            Period aj_ = Visit?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDateTime am_ = context.Operators.End(ak_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(o_ ?? y_ ?? ai_ ?? al_, am_, true, true);
            return an_;
        }

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

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ae_ = LastED?.StatusElement;
                Encounter.EncounterStatus? af_ = ae_?.Value;
                Code<Encounter.EncounterStatus> ag_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "finished");
                Period ai_ = LastED?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.End(aj_);
                CqlValueSet al_ = this.Observation_Services(context);
                IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? an_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> bv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bw_ = bv_?.Value;
                    Code<Encounter.EncounterStatus> bx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bw_);
                    bool? by_ = context.Operators.Equal(bx_, "finished");
                    Period bz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                    CqlDateTime cb_ = context.Operators.End(ca_);
                    Period cc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.Start(cd_);
                    CqlQuantity cf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cg_ = context.Operators.Subtract(ce_, cf_);
                    CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(cg_, ce_, true, true);
                    bool? ci_ = context.Operators.In<CqlDateTime>(cb_, ch_, (string)default);
                    bool? cj_ = context.Operators.Not((bool?)(ce_ is null));
                    bool? ck_ = context.Operators.And(ci_, cj_);
                    bool? cl_ = context.Operators.And(by_, ck_);
                    return cl_;
                }

                IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(am_, an_);

                object ap_(Encounter @this) {
                    Period cm_ = @this?.Period;
                    CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                    CqlDateTime co_ = context.Operators.End(cn_);
                    return co_;
                }

                IEnumerable<Encounter> aq_ = context.Operators.SortBy<Encounter>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ar_ = context.Operators.Last<Encounter>(aq_);
                Period as_ = ar_?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                Period av_ = Visit?.Period;
                CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime az_ = context.Operators.Subtract(au_ ?? ax_, ay_);

                bool? ba_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> cp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cq_ = cp_?.Value;
                    Code<Encounter.EncounterStatus> cr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cq_);
                    bool? cs_ = context.Operators.Equal(cr_, "finished");
                    Period ct_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                    CqlDateTime cv_ = context.Operators.End(cu_);
                    Period cw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                    CqlDateTime cy_ = context.Operators.Start(cx_);
                    CqlQuantity cz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime da_ = context.Operators.Subtract(cy_, cz_);
                    CqlInterval<CqlDateTime> db_ = context.Operators.Interval(da_, cy_, true, true);
                    bool? dc_ = context.Operators.In<CqlDateTime>(cv_, db_, (string)default);
                    bool? dd_ = context.Operators.Not((bool?)(cy_ is null));
                    bool? de_ = context.Operators.And(dc_, dd_);
                    bool? df_ = context.Operators.And(cs_, de_);
                    return df_;
                }

                IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(am_, ba_);

                object bc_(Encounter @this) {
                    Period dg_ = @this?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.End(dh_);
                    return di_;
                }

                IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter be_ = context.Operators.Last<Encounter>(bd_);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(az_, bh_ ?? ax_, true, true);
                bool? bj_ = context.Operators.In<CqlDateTime>(ak_, bi_, (string)default);

                bool? bk_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> dj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dk_ = dj_?.Value;
                    Code<Encounter.EncounterStatus> dl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dk_);
                    bool? dm_ = context.Operators.Equal(dl_, "finished");
                    Period dn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                    CqlDateTime dp_ = context.Operators.End(do_);
                    Period dq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dq_);
                    CqlDateTime ds_ = context.Operators.Start(dr_);
                    CqlQuantity dt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime du_ = context.Operators.Subtract(ds_, dt_);
                    CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(du_, ds_, true, true);
                    bool? dw_ = context.Operators.In<CqlDateTime>(dp_, dv_, (string)default);
                    bool? dx_ = context.Operators.Not((bool?)(ds_ is null));
                    bool? dy_ = context.Operators.And(dw_, dx_);
                    bool? dz_ = context.Operators.And(dm_, dy_);
                    return dz_;
                }

                IEnumerable<Encounter> bl_ = context.Operators.Where<Encounter>(am_, bk_);

                object bm_(Encounter @this) {
                    Period ea_ = @this?.Period;
                    CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                    CqlDateTime ec_ = context.Operators.End(eb_);
                    return ec_;
                }

                IEnumerable<Encounter> bn_ = context.Operators.SortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bo_ = context.Operators.Last<Encounter>(bn_);
                Period bp_ = bo_?.Period;
                CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                bool? bs_ = context.Operators.Not((bool?)((br_ ?? ax_) is null));
                bool? bt_ = context.Operators.And(bj_, bs_);
                bool? bu_ = context.Operators.And(ah_, bt_);
                return bu_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period ed_ = @this?.Period;
                CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.End(ee_);
                return ef_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eh_ = eg_?.Value;
                Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
                bool? ej_ = context.Operators.Equal(ei_, "finished");
                Period ek_ = LastObs?.Period;
                CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                CqlDateTime em_ = context.Operators.End(el_);
                Period en_ = Visit?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlQuantity eq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
                CqlInterval<CqlDateTime> es_ = context.Operators.Interval(er_, ep_, true, true);
                bool? et_ = context.Operators.In<CqlDateTime>(em_, es_, (string)default);
                bool? eu_ = context.Operators.Not((bool?)(ep_ is null));
                bool? ev_ = context.Operators.And(et_, eu_);
                bool? ew_ = context.Operators.And(ej_, ev_);
                return ew_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period ex_ = @this?.Period;
                CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                CqlDateTime ez_ = context.Operators.End(ey_);
                return ez_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlDateTime ac_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ac_, true, true);
            return ad_;
        }

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

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ae_ = LastED?.StatusElement;
                Encounter.EncounterStatus? af_ = ae_?.Value;
                Code<Encounter.EncounterStatus> ag_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "finished");
                Period ai_ = LastED?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.End(aj_);
                CqlValueSet al_ = this.Observation_Services(context);
                IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? an_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> bv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bw_ = bv_?.Value;
                    Code<Encounter.EncounterStatus> bx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bw_);
                    bool? by_ = context.Operators.Equal(bx_, "finished");
                    Period bz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                    CqlDateTime cb_ = context.Operators.End(ca_);
                    Period cc_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.Start(cd_);
                    CqlQuantity cf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cg_ = context.Operators.Subtract(ce_, cf_);
                    CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(cg_, ce_, true, true);
                    bool? ci_ = context.Operators.In<CqlDateTime>(cb_, ch_, (string)default);
                    bool? cj_ = context.Operators.Not((bool?)(ce_ is null));
                    bool? ck_ = context.Operators.And(ci_, cj_);
                    bool? cl_ = context.Operators.And(by_, ck_);
                    return cl_;
                }

                IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(am_, an_);

                object ap_(Encounter @this) {
                    Period cm_ = @this?.Period;
                    CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                    CqlDateTime co_ = context.Operators.End(cn_);
                    return co_;
                }

                IEnumerable<Encounter> aq_ = context.Operators.SortBy<Encounter>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ar_ = context.Operators.Last<Encounter>(aq_);
                Period as_ = ar_?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                Period av_ = Visit?.Period;
                CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime az_ = context.Operators.Subtract(au_ ?? ax_, ay_);

                bool? ba_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> cp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cq_ = cp_?.Value;
                    Code<Encounter.EncounterStatus> cr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cq_);
                    bool? cs_ = context.Operators.Equal(cr_, "finished");
                    Period ct_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                    CqlDateTime cv_ = context.Operators.End(cu_);
                    Period cw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                    CqlDateTime cy_ = context.Operators.Start(cx_);
                    CqlQuantity cz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime da_ = context.Operators.Subtract(cy_, cz_);
                    CqlInterval<CqlDateTime> db_ = context.Operators.Interval(da_, cy_, true, true);
                    bool? dc_ = context.Operators.In<CqlDateTime>(cv_, db_, (string)default);
                    bool? dd_ = context.Operators.Not((bool?)(cy_ is null));
                    bool? de_ = context.Operators.And(dc_, dd_);
                    bool? df_ = context.Operators.And(cs_, de_);
                    return df_;
                }

                IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(am_, ba_);

                object bc_(Encounter @this) {
                    Period dg_ = @this?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.End(dh_);
                    return di_;
                }

                IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter be_ = context.Operators.Last<Encounter>(bd_);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(az_, bh_ ?? ax_, true, true);
                bool? bj_ = context.Operators.In<CqlDateTime>(ak_, bi_, (string)default);

                bool? bk_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> dj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dk_ = dj_?.Value;
                    Code<Encounter.EncounterStatus> dl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dk_);
                    bool? dm_ = context.Operators.Equal(dl_, "finished");
                    Period dn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                    CqlDateTime dp_ = context.Operators.End(do_);
                    Period dq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dq_);
                    CqlDateTime ds_ = context.Operators.Start(dr_);
                    CqlQuantity dt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime du_ = context.Operators.Subtract(ds_, dt_);
                    CqlInterval<CqlDateTime> dv_ = context.Operators.Interval(du_, ds_, true, true);
                    bool? dw_ = context.Operators.In<CqlDateTime>(dp_, dv_, (string)default);
                    bool? dx_ = context.Operators.Not((bool?)(ds_ is null));
                    bool? dy_ = context.Operators.And(dw_, dx_);
                    bool? dz_ = context.Operators.And(dm_, dy_);
                    return dz_;
                }

                IEnumerable<Encounter> bl_ = context.Operators.Where<Encounter>(am_, bk_);

                object bm_(Encounter @this) {
                    Period ea_ = @this?.Period;
                    CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                    CqlDateTime ec_ = context.Operators.End(eb_);
                    return ec_;
                }

                IEnumerable<Encounter> bn_ = context.Operators.SortBy<Encounter>(bl_, bm_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bo_ = context.Operators.Last<Encounter>(bn_);
                Period bp_ = bo_?.Period;
                CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                bool? bs_ = context.Operators.Not((bool?)((br_ ?? ax_) is null));
                bool? bt_ = context.Operators.And(bj_, bs_);
                bool? bu_ = context.Operators.And(ah_, bt_);
                return bu_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period ed_ = @this?.Period;
                CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.End(ee_);
                return ef_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eh_ = eg_?.Value;
                Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
                bool? ej_ = context.Operators.Equal(ei_, "finished");
                Period ek_ = LastObs?.Period;
                CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                CqlDateTime em_ = context.Operators.End(el_);
                Period en_ = Visit?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.Start(eo_);
                CqlQuantity eq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime er_ = context.Operators.Subtract(ep_, eq_);
                CqlInterval<CqlDateTime> es_ = context.Operators.Interval(er_, ep_, true, true);
                bool? et_ = context.Operators.In<CqlDateTime>(em_, es_, (string)default);
                bool? eu_ = context.Operators.Not((bool?)(ep_ is null));
                bool? ev_ = context.Operators.And(et_, eu_);
                bool? ew_ = context.Operators.And(ej_, ev_);
                return ew_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period ex_ = @this?.Period;
                CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                CqlDateTime ez_ = context.Operators.End(ey_);
                return ez_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlDateTime ac_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ac_, true, true);
            return ad_;
        }

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

        bool? b_(Encounter.LocationComponent HospitalLocation) {
            ResourceReference g_ = HospitalLocation?.Location;
            Location h_ = this.GetLocation(context, g_);
            List<CodeableConcept> i_ = h_?.Type;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        object d_(Encounter.LocationComponent @this) {
            Period u_ = @this?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            return w_;
        }

        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent firstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> a_ = Encounter?.Location;

        bool? b_(Encounter.LocationComponent HospitalLocation) {
            ResourceReference g_ = HospitalLocation?.Location;
            Location h_ = this.GetLocation(context, g_);
            List<CodeableConcept> i_ = h_?.Type;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        object d_(Encounter.LocationComponent @this) {
            Period u_ = @this?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            return w_;
        }

        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        Condition b_(Encounter.DiagnosisComponent D) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition C) {
                ResourceReference k_ = D?.Condition;
                Id l_ = C?.IdElement;
                string m_ = l_?.Value;
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, k_, m_);
                return n_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            Condition j_ = context.Operators.SingletonFrom<Condition>(i_);
            return j_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        return d_;
    }


    [CqlFunctionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        Condition b_(ResourceReference D) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition C) {
                Id k_ = C?.IdElement;
                string l_ = k_?.Value;
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, D, l_);
                return m_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            Condition j_ = context.Operators.SingletonFrom<Condition>(i_);
            return j_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Union<Condition>(a_ as IEnumerable<Condition>, b_ as IEnumerable<Condition>);

        bool? d_(Condition C) {
            Id g_ = C?.IdElement;
            string h_ = g_?.Value;
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        }

        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        Condition f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
    }


    [CqlFunctionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition getCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Union<Condition>(a_ as IEnumerable<Condition>, b_ as IEnumerable<Condition>);

        bool? d_(Condition C) {
            Id g_ = C?.IdElement;
            string h_ = g_?.Value;
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        }

        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        Condition f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
    }


    [CqlFunctionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        bool? b_(Encounter.DiagnosisComponent D) {
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
        }

        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

        Condition d_(Encounter.DiagnosisComponent PD) {
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> s_ = context.Operators.Union<Condition>(q_ as IEnumerable<Condition>, r_ as IEnumerable<Condition>);

            bool? t_(Condition C) {
                ResourceReference w_ = PD?.Condition;
                Id x_ = C?.IdElement;
                string y_ = x_?.Value;
                bool? z_ = QICoreCommon_4_0_000.Instance.references(context, w_, y_);
                return z_;
            }

            IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
            Condition v_ = context.Operators.SingletonFrom<Condition>(u_);
            return v_;
        }

        IEnumerable<Condition> e_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(c_, d_);
        IEnumerable<Condition> f_ = context.Operators.Distinct<Condition>(e_);
        Condition g_ = context.Operators.SingletonFrom<Condition>(f_);
        return g_;
    }


    [CqlFunctionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the claim diagnosis element that is specified as the principal diagnosis for the encounter")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public Claim.DiagnosisComponent principalDiagnosis(CqlContext context, Encounter encounter)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = this.claimDiagnosis(context, encounter);

        bool? b_(Claim.DiagnosisComponent CD) {
            List<CodeableConcept> e_ = CD?.Type;

            CqlConcept f_(CodeableConcept @this) {
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlCode h_ = this.Principal_Diagnosis(context);
            bool? i_ = QICoreCommon_4_0_000.Instance.includesCode(context, g_, h_);
            return i_;
        }

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

        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E) {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? g_(Claim C) {
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

                bool? z_(Claim.ItemComponent I) {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);
                    return ae_;
                }

                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.DiagnosisComponent> af_ = @this?.Diagnosis;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                return ag_;
            }

            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);

            List<Claim.DiagnosisComponent> k_(Claim @this) {
                List<Claim.DiagnosisComponent> ah_ = @this?.Diagnosis;
                return ah_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> l_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(j_, k_);
            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)l_);

            bool? n_(Claim.DiagnosisComponent D) {
                PositiveInt ai_ = D?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? al_(Claim C) {
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

                    bool? bk_(Claim.ItemComponent I) {
                        List<ResourceReference> bo_ = I?.Encounter;
                        bool? bp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bo_, E);
                        return bp_;
                    }

                    IEnumerable<Claim.ItemComponent> bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bj_, bk_);
                    bool? bm_ = context.Operators.Exists<Claim.ItemComponent>(bl_);
                    bool? bn_ = context.Operators.And(bi_, bm_);
                    return bn_;
                }

                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);

                bool? an_(Claim @this) {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));
                    return br_;
                }

                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);

                List<Claim.ItemComponent> ap_(Claim @this) {
                    List<Claim.ItemComponent> bs_ = @this?.Item;
                    return bs_;
                }

                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);

                bool? as_(Claim.ItemComponent I) {
                    List<ResourceReference> bt_ = I?.Encounter;
                    bool? bu_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bt_, E);
                    return bu_;
                }

                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);

                bool? au_(Claim.ItemComponent @this) {
                    List<PositiveInt> bv_ = @this?.DiagnosisSequenceElement;

                    int? bw_(PositiveInt @this) {
                        int? bz_ = @this?.Value;
                        return bz_;
                    }

                    IEnumerable<int?> bx_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bv_, bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                }

                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);

                IEnumerable<int?> aw_(Claim.ItemComponent @this) {
                    List<PositiveInt> ca_ = @this?.DiagnosisSequenceElement;

                    int? cb_(PositiveInt @this) {
                        int? cd_ = @this?.Value;
                        return cd_;
                    }

                    IEnumerable<int?> cc_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ca_, cb_);
                    return cc_;
                }

                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);
                return az_;
            }

            IEnumerable<Claim.DiagnosisComponent> o_ = context.Operators.Where<Claim.DiagnosisComponent>(m_, n_);
            return o_;
        }

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

        bool? c_(Claim.DiagnosisComponent PD) {
            DataType g_ = PD?.Diagnosis;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool? i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, valueSet);
            Condition j_ = this.getCondition(context, h_ as ResourceReference);
            CodeableConcept k_ = j_?.Code;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            bool? m_ = context.Operators.ConceptInValueSet(l_, valueSet);
            bool? n_ = context.Operators.Or(i_, m_);
            return n_;
        }

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

        bool? b_(Claim.DiagnosisComponent CD) {
            CodeableConcept e_ = CD?.OnAdmission;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            bool? g_ = context.Operators.ConceptInValueSet(f_, poaValueSet);
            DataType h_ = CD?.Diagnosis;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            bool? j_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, diagnosisValueSet);
            Condition k_ = this.getCondition(context, i_ as ResourceReference);
            CodeableConcept l_ = k_?.Code;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            bool? n_ = context.Operators.ConceptInValueSet(m_, diagnosisValueSet);
            bool? o_ = context.Operators.Or(j_, n_);
            bool? p_ = context.Operators.And(g_, o_);
            return p_;
        }

        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>(a_, b_);
        bool? d_ = context.Operators.Exists<Claim.DiagnosisComponent>(c_);
        return d_;
    }


    [CqlFunctionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

        bool? b_(Location L) {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        }

        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        DataType a_ = request?.Medication;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlConcept;
        if (c_)
        {
            DataType d_ = request?.Medication;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            return e_ as CqlConcept;
        }
        else
        {
            IEnumerable<Medication> f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? g_(Medication M) {
                DataType l_ = request?.Medication;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, m_ as ResourceReference, M);
                return n_;
            }

            IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
            Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
            CodeableConcept j_ = i_?.Code;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            return k_;
        }
    }


    [CqlFunctionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept getMedicationCode(CqlContext context, MedicationRequest request)
    {
        DataType a_ = request?.Medication;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlConcept;
        if (c_)
        {
            DataType d_ = request?.Medication;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            return e_ as CqlConcept;
        }
        else
        {
            IEnumerable<Medication> f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? g_(Medication M) {
                DataType l_ = request?.Medication;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, m_ as ResourceReference, M);
                return n_;
            }

            IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
            Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
            CodeableConcept j_ = i_?.Code;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            return k_;
        }
    }


    [CqlFunctionDefinition("principalProcedure")]
    [CqlTag("description", "Returns the claim procedure elements for the given encounter")]
    public Claim.ProcedureComponent principalProcedure(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];

        Claim.ProcedureComponent b_(Encounter E) {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? g_(Claim C) {
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

                bool? aa_(Claim.ItemComponent I) {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);
                    return af_;
                }

                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.ProcedureComponent> ag_ = @this?.Procedure;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }

            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);

            List<Claim.ProcedureComponent> k_(Claim @this) {
                List<Claim.ProcedureComponent> ai_ = @this?.Procedure;
                return ai_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> l_ = context.Operators.Select<Claim, List<Claim.ProcedureComponent>>(j_, k_);
            IEnumerable<Claim.ProcedureComponent> m_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)l_);

            bool? n_(Claim.ProcedureComponent P) {
                PositiveInt aj_ = P?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? am_(Claim C) {
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

                    bool? br_(Claim.ItemComponent I) {
                        List<ResourceReference> bv_ = I?.Encounter;
                        bool? bw_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bv_, E);
                        return bw_;
                    }

                    IEnumerable<Claim.ItemComponent> bs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bq_, br_);
                    bool? bt_ = context.Operators.Exists<Claim.ItemComponent>(bs_);
                    bool? bu_ = context.Operators.And(bp_, bt_);
                    return bu_;
                }

                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);

                bool? ao_(Claim @this) {
                    List<Claim.ItemComponent> bx_ = @this?.Item;
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    return by_;
                }

                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);

                List<Claim.ItemComponent> aq_(Claim @this) {
                    List<Claim.ItemComponent> bz_ = @this?.Item;
                    return bz_;
                }

                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);

                bool? at_(Claim.ItemComponent I) {
                    List<ResourceReference> ca_ = I?.Encounter;
                    bool? cb_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ca_, E);
                    return cb_;
                }

                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);

                bool? av_(Claim.ItemComponent @this) {
                    List<PositiveInt> cc_ = @this?.ProcedureSequenceElement;

                    int? cd_(PositiveInt @this) {
                        int? cg_ = @this?.Value;
                        return cg_;
                    }

                    IEnumerable<int?> ce_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cc_, cd_);
                    bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                    return cf_;
                }

                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);

                IEnumerable<int?> ax_(Claim.ItemComponent @this) {
                    List<PositiveInt> ch_ = @this?.ProcedureSequenceElement;

                    int? ci_(PositiveInt @this) {
                        int? ck_ = @this?.Value;
                        return ck_;
                    }

                    IEnumerable<int?> cj_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ch_, ci_);
                    return cj_;
                }

                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                List<CodeableConcept> bb_ = P?.Type;

                CqlConcept bc_(CodeableConcept @this) {
                    CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return cl_;
                }

                IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
                CqlCode be_ = this.Primary_procedure(context);
                bool? bf_ = QICoreCommon_4_0_000.Instance.includesCode(context, bd_, be_);
                bool? bg_ = context.Operators.And(ba_, bf_);
                return bg_;
            }

            IEnumerable<Claim.ProcedureComponent> o_ = context.Operators.Where<Claim.ProcedureComponent>(m_, n_);
            Claim.ProcedureComponent p_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(o_);
            return p_;
        }

        IEnumerable<Claim.ProcedureComponent> c_ = context.Operators.Select<Encounter, Claim.ProcedureComponent>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<Claim.ProcedureComponent> d_ = context.Operators.Distinct<Claim.ProcedureComponent>(c_);
        Claim.ProcedureComponent e_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(d_);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CQMCommon_4_1_000() {}

    public static CQMCommon_4_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CQMCommon";
    public string Version => "4.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
