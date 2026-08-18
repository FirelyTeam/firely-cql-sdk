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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
            CqlBoolean h_ = context.Operators.Equal(g_, "finished");
            Period i_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            CqlBoolean n_ = m_;
            return h_
                /* CQL 'and' (46:5-47:75) */ && n_;
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
            CqlBoolean k_ = context.Operators.Equal(j_, "finished");
            Period l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            Period o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            CqlBoolean v_ = (CqlBoolean)(q_ is not null);
            CqlBoolean w_ = u_
                /* CQL 'and' (80:13-80:88) */ && v_;
            return k_
                /* CQL 'and' (79:7-80:88) */ && w_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period x_ = @this?.Period;
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
            CqlDateTime z_ = context.Operators.End(y_);
            return z_;
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
            CqlBoolean k_ = context.Operators.Equal(j_, "finished");
            Period l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            Period o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(s_, q_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            CqlBoolean v_ = (CqlBoolean)(q_ is not null);
            CqlBoolean w_ = u_
                /* CQL 'and' (91:13-91:88) */ && v_;
            return k_
                /* CQL 'and' (90:7-91:88) */ && w_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period x_ = @this?.Period;
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
            CqlDateTime z_ = context.Operators.End(y_);
            return z_;
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
                Period f_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                return g_;
            }
            else
            {
                Period h_ = X?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> n_ = context.Operators.Interval(j_, m_, true, false);
                return n_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
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
                Period f_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                return g_;
            }
            else
            {
                Period h_ = X?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> n_ = context.Operators.Interval(j_, m_, true, true);
                return n_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
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
                List<Encounter.LocationComponent> f_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)f_;
            }
            else
            {
                List<Encounter.LocationComponent> g_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] i_ = [
                    (IEnumerable<Encounter.LocationComponent>)g_,
                    (IEnumerable<Encounter.LocationComponent>)h_,
                ];
                IEnumerable<Encounter.LocationComponent> j_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)i_);
                return j_;
            }
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);
        return e_;
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
                List<Encounter.LocationComponent> f_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent>)f_;
            }
            else
            {
                List<Encounter.LocationComponent> g_ = EDEncounter?.Location;
                List<Encounter.LocationComponent> h_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent>[] i_ = [
                    (IEnumerable<Encounter.LocationComponent>)g_,
                    (IEnumerable<Encounter.LocationComponent>)h_,
                ];
                IEnumerable<Encounter.LocationComponent> j_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent>>)i_);
                return j_;
            }
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);
        return e_;
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
            CqlBoolean n_ = context.Operators.ConceptsInValueSet(l_, m_);
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
            CqlBoolean e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
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
            CqlBoolean n_ = context.Operators.ConceptsInValueSet(l_, m_);
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
            CqlValueSet e_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastSurgeryOP) {
                Period an_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.End(ao_);
                CqlValueSet aq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? as_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> cy_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? cz_ = cy_?.Value;
                    Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cz_);
                    CqlBoolean db_ = context.Operators.Equal(da_, "finished");
                    Period dc_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    CqlValueSet df_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, df_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? dh_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> eo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ep_ = eo_?.Value;
                        Code<Encounter.EncounterStatus> eq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ep_);
                        CqlBoolean er_ = context.Operators.Equal(eq_, "finished");
                        Period es_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                        CqlDateTime eu_ = context.Operators.End(et_);
                        Period ev_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                        CqlDateTime ex_ = context.Operators.Start(ew_);
                        CqlQuantity ey_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ez_ = context.Operators.Subtract(ex_, ey_);
                        CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ez_, ex_, true, true);
                        CqlBoolean fb_ = context.Operators.In<CqlDateTime>(eu_, fa_, (string)default);
                        CqlBoolean fc_ = (CqlBoolean)(ex_ is not null);
                        CqlBoolean fd_ = fb_
                            /* CQL 'and' (241:15-241:83) */ && fc_;
                        return er_
                            /* CQL 'and' (240:6-241:83) */ && fd_;
                    }

                    IEnumerable<Encounter> di_ = context.Operators.Where<Encounter>(dg_, dh_);

                    object dj_(Encounter @this) {
                        Period fe_ = @this?.Period;
                        CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                        CqlDateTime fg_ = context.Operators.End(ff_);
                        return fg_;
                    }

                    IEnumerable<Encounter> dk_ = context.Operators.SortBy<Encounter>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dl_ = context.Operators.Last<Encounter>(dk_);
                    Period dm_ = dl_?.Period;
                    CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime do_ = context.Operators.Start(dn_);
                    Period dp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
                    CqlDateTime dr_ = context.Operators.Start(dq_);
                    CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dt_ = context.Operators.Subtract(do_ ?? dr_, ds_);

                    bool? du_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> fh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fi_ = fh_?.Value;
                        Code<Encounter.EncounterStatus> fj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fi_);
                        CqlBoolean fk_ = context.Operators.Equal(fj_, "finished");
                        Period fl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fl_);
                        CqlDateTime fn_ = context.Operators.End(fm_);
                        Period fo_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                        CqlDateTime fq_ = context.Operators.Start(fp_);
                        CqlQuantity fr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fs_ = context.Operators.Subtract(fq_, fr_);
                        CqlInterval<CqlDateTime> ft_ = context.Operators.Interval(fs_, fq_, true, true);
                        CqlBoolean fu_ = context.Operators.In<CqlDateTime>(fn_, ft_, (string)default);
                        CqlBoolean fv_ = (CqlBoolean)(fq_ is not null);
                        CqlBoolean fw_ = fu_
                            /* CQL 'and' (241:15-241:83) */ && fv_;
                        return fk_
                            /* CQL 'and' (240:6-241:83) */ && fw_;
                    }

                    IEnumerable<Encounter> dv_ = context.Operators.Where<Encounter>(dg_, du_);

                    object dw_(Encounter @this) {
                        Period fx_ = @this?.Period;
                        CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                        CqlDateTime fz_ = context.Operators.End(fy_);
                        return fz_;
                    }

                    IEnumerable<Encounter> dx_ = context.Operators.SortBy<Encounter>(dv_, dw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dy_ = context.Operators.Last<Encounter>(dx_);
                    Period dz_ = dy_?.Period;
                    CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                    CqlDateTime eb_ = context.Operators.Start(ea_);
                    CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dt_, eb_ ?? dr_, true, true);
                    CqlBoolean ed_ = context.Operators.In<CqlDateTime>(de_, ec_, (string)default);

                    bool? ee_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> ga_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gb_ = ga_?.Value;
                        Code<Encounter.EncounterStatus> gc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gb_);
                        CqlBoolean gd_ = context.Operators.Equal(gc_, "finished");
                        Period ge_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ge_);
                        CqlDateTime gg_ = context.Operators.End(gf_);
                        Period gh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gh_);
                        CqlDateTime gj_ = context.Operators.Start(gi_);
                        CqlQuantity gk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gl_ = context.Operators.Subtract(gj_, gk_);
                        CqlInterval<CqlDateTime> gm_ = context.Operators.Interval(gl_, gj_, true, true);
                        CqlBoolean gn_ = context.Operators.In<CqlDateTime>(gg_, gm_, (string)default);
                        CqlBoolean go_ = (CqlBoolean)(gj_ is not null);
                        CqlBoolean gp_ = gn_
                            /* CQL 'and' (241:15-241:83) */ && go_;
                        return gd_
                            /* CQL 'and' (240:6-241:83) */ && gp_;
                    }

                    IEnumerable<Encounter> ef_ = context.Operators.Where<Encounter>(dg_, ee_);

                    object eg_(Encounter @this) {
                        Period gq_ = @this?.Period;
                        CqlInterval<CqlDateTime> gr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                        CqlDateTime gs_ = context.Operators.End(gr_);
                        return gs_;
                    }

                    IEnumerable<Encounter> eh_ = context.Operators.SortBy<Encounter>(ef_, eg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ei_ = context.Operators.Last<Encounter>(eh_);
                    Period ej_ = ei_?.Period;
                    CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                    CqlDateTime el_ = context.Operators.Start(ek_);
                    CqlBoolean em_ = (CqlBoolean)((el_ ?? dr_) is not null);
                    CqlBoolean en_ = ed_
                        /* CQL 'and' (247:15-247:71) */ && em_;
                    return db_
                        /* CQL 'and' (246:6-247:71) */ && en_;
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gt_ = @this?.Period;
                    CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gt_);
                    CqlDateTime gv_ = context.Operators.End(gu_);
                    return gv_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gx_ = gw_?.Value;
                    Code<Encounter.EncounterStatus> gy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gx_);
                    CqlBoolean gz_ = context.Operators.Equal(gy_, "finished");
                    Period ha_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ha_);
                    CqlDateTime hc_ = context.Operators.End(hb_);
                    Period hd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> he_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hd_);
                    CqlDateTime hf_ = context.Operators.Start(he_);
                    CqlQuantity hg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hh_ = context.Operators.Subtract(hf_, hg_);
                    CqlInterval<CqlDateTime> hi_ = context.Operators.Interval(hh_, hf_, true, true);
                    CqlBoolean hj_ = context.Operators.In<CqlDateTime>(hc_, hi_, (string)default);
                    CqlBoolean hk_ = (CqlBoolean)(hf_ is not null);
                    CqlBoolean hl_ = hj_
                        /* CQL 'and' (241:15-241:83) */ && hk_;
                    return gz_
                        /* CQL 'and' (240:6-241:83) */ && hl_;
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hm_ = @this?.Period;
                    CqlInterval<CqlDateTime> hn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hm_);
                    CqlDateTime ho_ = context.Operators.End(hn_);
                    return ho_;
                }

                IEnumerable<Encounter> bf_ = context.Operators.SortBy<Encounter>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bg_ = context.Operators.Last<Encounter>(bf_);
                Period bh_ = bg_?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                Period bk_ = Visit?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bo_ = context.Operators.Subtract(az_ ?? bj_ ?? bm_, bn_);

                bool? bp_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> hp_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hq_ = hp_?.Value;
                    Code<Encounter.EncounterStatus> hr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hq_);
                    CqlBoolean hs_ = context.Operators.Equal(hr_, "finished");
                    Period ht_ = LastED?.Period;
                    CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ht_);
                    CqlDateTime hv_ = context.Operators.End(hu_);
                    CqlValueSet hw_ = this.Observation_Services(context);
                    IEnumerable<Encounter> hx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? hy_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jg_ = jf_?.Value;
                        Code<Encounter.EncounterStatus> jh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jg_);
                        CqlBoolean ji_ = context.Operators.Equal(jh_, "finished");
                        Period jj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jj_);
                        CqlDateTime jl_ = context.Operators.End(jk_);
                        Period jm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jm_);
                        CqlDateTime jo_ = context.Operators.Start(jn_);
                        CqlQuantity jp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jq_ = context.Operators.Subtract(jo_, jp_);
                        CqlInterval<CqlDateTime> jr_ = context.Operators.Interval(jq_, jo_, true, true);
                        CqlBoolean js_ = context.Operators.In<CqlDateTime>(jl_, jr_, (string)default);
                        CqlBoolean jt_ = (CqlBoolean)(jo_ is not null);
                        CqlBoolean ju_ = js_
                            /* CQL 'and' (241:15-241:83) */ && jt_;
                        return ji_
                            /* CQL 'and' (240:6-241:83) */ && ju_;
                    }

                    IEnumerable<Encounter> hz_ = context.Operators.Where<Encounter>(hx_, hy_);

                    object ia_(Encounter @this) {
                        Period jv_ = @this?.Period;
                        CqlInterval<CqlDateTime> jw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jv_);
                        CqlDateTime jx_ = context.Operators.End(jw_);
                        return jx_;
                    }

                    IEnumerable<Encounter> ib_ = context.Operators.SortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ic_ = context.Operators.Last<Encounter>(ib_);
                    Period id_ = ic_?.Period;
                    CqlInterval<CqlDateTime> ie_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, id_);
                    CqlDateTime if_ = context.Operators.Start(ie_);
                    Period ig_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ih_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ig_);
                    CqlDateTime ii_ = context.Operators.Start(ih_);
                    CqlQuantity ij_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ik_ = context.Operators.Subtract(if_ ?? ii_, ij_);

                    bool? il_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jy_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jz_ = jy_?.Value;
                        Code<Encounter.EncounterStatus> ka_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jz_);
                        CqlBoolean kb_ = context.Operators.Equal(ka_, "finished");
                        Period kc_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kc_);
                        CqlDateTime ke_ = context.Operators.End(kd_);
                        Period kf_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kf_);
                        CqlDateTime kh_ = context.Operators.Start(kg_);
                        CqlQuantity ki_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kj_ = context.Operators.Subtract(kh_, ki_);
                        CqlInterval<CqlDateTime> kk_ = context.Operators.Interval(kj_, kh_, true, true);
                        CqlBoolean kl_ = context.Operators.In<CqlDateTime>(ke_, kk_, (string)default);
                        CqlBoolean km_ = (CqlBoolean)(kh_ is not null);
                        CqlBoolean kn_ = kl_
                            /* CQL 'and' (241:15-241:83) */ && km_;
                        return kb_
                            /* CQL 'and' (240:6-241:83) */ && kn_;
                    }

                    IEnumerable<Encounter> im_ = context.Operators.Where<Encounter>(hx_, il_);

                    object in_(Encounter @this) {
                        Period ko_ = @this?.Period;
                        CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                        CqlDateTime kq_ = context.Operators.End(kp_);
                        return kq_;
                    }

                    IEnumerable<Encounter> io_ = context.Operators.SortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ip_ = context.Operators.Last<Encounter>(io_);
                    Period iq_ = ip_?.Period;
                    CqlInterval<CqlDateTime> ir_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iq_);
                    CqlDateTime is_ = context.Operators.Start(ir_);
                    CqlInterval<CqlDateTime> it_ = context.Operators.Interval(ik_, is_ ?? ii_, true, true);
                    CqlBoolean iu_ = context.Operators.In<CqlDateTime>(hv_, it_, (string)default);

                    bool? iv_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> kr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ks_ = kr_?.Value;
                        Code<Encounter.EncounterStatus> kt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ks_);
                        CqlBoolean ku_ = context.Operators.Equal(kt_, "finished");
                        Period kv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kv_);
                        CqlDateTime kx_ = context.Operators.End(kw_);
                        Period ky_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                        CqlDateTime la_ = context.Operators.Start(kz_);
                        CqlQuantity lb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lc_ = context.Operators.Subtract(la_, lb_);
                        CqlInterval<CqlDateTime> ld_ = context.Operators.Interval(lc_, la_, true, true);
                        CqlBoolean le_ = context.Operators.In<CqlDateTime>(kx_, ld_, (string)default);
                        CqlBoolean lf_ = (CqlBoolean)(la_ is not null);
                        CqlBoolean lg_ = le_
                            /* CQL 'and' (241:15-241:83) */ && lf_;
                        return ku_
                            /* CQL 'and' (240:6-241:83) */ && lg_;
                    }

                    IEnumerable<Encounter> iw_ = context.Operators.Where<Encounter>(hx_, iv_);

                    object ix_(Encounter @this) {
                        Period lh_ = @this?.Period;
                        CqlInterval<CqlDateTime> li_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lh_);
                        CqlDateTime lj_ = context.Operators.End(li_);
                        return lj_;
                    }

                    IEnumerable<Encounter> iy_ = context.Operators.SortBy<Encounter>(iw_, ix_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter iz_ = context.Operators.Last<Encounter>(iy_);
                    Period ja_ = iz_?.Period;
                    CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ja_);
                    CqlDateTime jc_ = context.Operators.Start(jb_);
                    CqlBoolean jd_ = (CqlBoolean)((jc_ ?? ii_) is not null);
                    CqlBoolean je_ = iu_
                        /* CQL 'and' (247:15-247:71) */ && jd_;
                    return hs_
                        /* CQL 'and' (246:6-247:71) */ && je_;
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ll_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lk_);
                    CqlDateTime lm_ = context.Operators.End(ll_);
                    return lm_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ln_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lo_ = ln_?.Value;
                    Code<Encounter.EncounterStatus> lp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lo_);
                    CqlBoolean lq_ = context.Operators.Equal(lp_, "finished");
                    Period lr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ls_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lr_);
                    CqlDateTime lt_ = context.Operators.End(ls_);
                    Period lu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lu_);
                    CqlDateTime lw_ = context.Operators.Start(lv_);
                    CqlQuantity lx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ly_ = context.Operators.Subtract(lw_, lx_);
                    CqlInterval<CqlDateTime> lz_ = context.Operators.Interval(ly_, lw_, true, true);
                    CqlBoolean ma_ = context.Operators.In<CqlDateTime>(lt_, lz_, (string)default);
                    CqlBoolean mb_ = (CqlBoolean)(lw_ is not null);
                    CqlBoolean mc_ = ma_
                        /* CQL 'and' (241:15-241:83) */ && mb_;
                    return lq_
                        /* CQL 'and' (240:6-241:83) */ && mc_;
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period md_ = @this?.Period;
                    CqlInterval<CqlDateTime> me_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, md_);
                    CqlDateTime mf_ = context.Operators.End(me_);
                    return mf_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                CqlBoolean cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                bool? ch_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> mg_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mh_ = mg_?.Value;
                    Code<Encounter.EncounterStatus> mi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mh_);
                    CqlBoolean mj_ = context.Operators.Equal(mi_, "finished");
                    Period mk_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                    CqlDateTime mm_ = context.Operators.End(ml_);
                    CqlValueSet mn_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mp_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> nw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nx_ = nw_?.Value;
                        Code<Encounter.EncounterStatus> ny_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nx_);
                        CqlBoolean nz_ = context.Operators.Equal(ny_, "finished");
                        Period oa_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ob_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oa_);
                        CqlDateTime oc_ = context.Operators.End(ob_);
                        Period od_ = Visit?.Period;
                        CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, od_);
                        CqlDateTime of_ = context.Operators.Start(oe_);
                        CqlQuantity og_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime oh_ = context.Operators.Subtract(of_, og_);
                        CqlInterval<CqlDateTime> oi_ = context.Operators.Interval(oh_, of_, true, true);
                        CqlBoolean oj_ = context.Operators.In<CqlDateTime>(oc_, oi_, (string)default);
                        CqlBoolean ok_ = (CqlBoolean)(of_ is not null);
                        CqlBoolean ol_ = oj_
                            /* CQL 'and' (241:15-241:83) */ && ok_;
                        return nz_
                            /* CQL 'and' (240:6-241:83) */ && ol_;
                    }

                    IEnumerable<Encounter> mq_ = context.Operators.Where<Encounter>(mo_, mp_);

                    object mr_(Encounter @this) {
                        Period om_ = @this?.Period;
                        CqlInterval<CqlDateTime> on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, om_);
                        CqlDateTime oo_ = context.Operators.End(on_);
                        return oo_;
                    }

                    IEnumerable<Encounter> ms_ = context.Operators.SortBy<Encounter>(mq_, mr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mt_ = context.Operators.Last<Encounter>(ms_);
                    Period mu_ = mt_?.Period;
                    CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mu_);
                    CqlDateTime mw_ = context.Operators.Start(mv_);
                    Period mx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> my_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mx_);
                    CqlDateTime mz_ = context.Operators.Start(my_);
                    CqlQuantity na_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nb_ = context.Operators.Subtract(mw_ ?? mz_, na_);

                    bool? nc_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> op_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? oq_ = op_?.Value;
                        Code<Encounter.EncounterStatus> or_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oq_);
                        CqlBoolean os_ = context.Operators.Equal(or_, "finished");
                        Period ot_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ou_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ot_);
                        CqlDateTime ov_ = context.Operators.End(ou_);
                        Period ow_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ox_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ow_);
                        CqlDateTime oy_ = context.Operators.Start(ox_);
                        CqlQuantity oz_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pa_ = context.Operators.Subtract(oy_, oz_);
                        CqlInterval<CqlDateTime> pb_ = context.Operators.Interval(pa_, oy_, true, true);
                        CqlBoolean pc_ = context.Operators.In<CqlDateTime>(ov_, pb_, (string)default);
                        CqlBoolean pd_ = (CqlBoolean)(oy_ is not null);
                        CqlBoolean pe_ = pc_
                            /* CQL 'and' (241:15-241:83) */ && pd_;
                        return os_
                            /* CQL 'and' (240:6-241:83) */ && pe_;
                    }

                    IEnumerable<Encounter> nd_ = context.Operators.Where<Encounter>(mo_, nc_);

                    object ne_(Encounter @this) {
                        Period pf_ = @this?.Period;
                        CqlInterval<CqlDateTime> pg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                        CqlDateTime ph_ = context.Operators.End(pg_);
                        return ph_;
                    }

                    IEnumerable<Encounter> nf_ = context.Operators.SortBy<Encounter>(nd_, ne_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ng_ = context.Operators.Last<Encounter>(nf_);
                    Period nh_ = ng_?.Period;
                    CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nh_);
                    CqlDateTime nj_ = context.Operators.Start(ni_);
                    CqlInterval<CqlDateTime> nk_ = context.Operators.Interval(nb_, nj_ ?? mz_, true, true);
                    CqlBoolean nl_ = context.Operators.In<CqlDateTime>(mm_, nk_, (string)default);

                    bool? nm_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pj_ = pi_?.Value;
                        Code<Encounter.EncounterStatus> pk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pj_);
                        CqlBoolean pl_ = context.Operators.Equal(pk_, "finished");
                        Period pm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pm_);
                        CqlDateTime po_ = context.Operators.End(pn_);
                        Period pp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pp_);
                        CqlDateTime pr_ = context.Operators.Start(pq_);
                        CqlQuantity ps_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pt_ = context.Operators.Subtract(pr_, ps_);
                        CqlInterval<CqlDateTime> pu_ = context.Operators.Interval(pt_, pr_, true, true);
                        CqlBoolean pv_ = context.Operators.In<CqlDateTime>(po_, pu_, (string)default);
                        CqlBoolean pw_ = (CqlBoolean)(pr_ is not null);
                        CqlBoolean px_ = pv_
                            /* CQL 'and' (241:15-241:83) */ && pw_;
                        return pl_
                            /* CQL 'and' (240:6-241:83) */ && px_;
                    }

                    IEnumerable<Encounter> nn_ = context.Operators.Where<Encounter>(mo_, nm_);

                    object no_(Encounter @this) {
                        Period py_ = @this?.Period;
                        CqlInterval<CqlDateTime> pz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, py_);
                        CqlDateTime qa_ = context.Operators.End(pz_);
                        return qa_;
                    }

                    IEnumerable<Encounter> np_ = context.Operators.SortBy<Encounter>(nn_, no_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nq_ = context.Operators.Last<Encounter>(np_);
                    Period nr_ = nq_?.Period;
                    CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nr_);
                    CqlDateTime nt_ = context.Operators.Start(ns_);
                    CqlBoolean nu_ = (CqlBoolean)((nt_ ?? mz_) is not null);
                    CqlBoolean nv_ = nl_
                        /* CQL 'and' (247:15-247:71) */ && nu_;
                    return mj_
                        /* CQL 'and' (246:6-247:71) */ && nv_;
                }

                IEnumerable<Encounter> ci_ = context.Operators.Where<Encounter>(ar_, ch_);

                object cj_(Encounter @this) {
                    Period qb_ = @this?.Period;
                    CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                    CqlDateTime qd_ = context.Operators.End(qc_);
                    return qd_;
                }

                IEnumerable<Encounter> ck_ = context.Operators.SortBy<Encounter>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cl_ = context.Operators.Last<Encounter>(ck_);
                Period cm_ = cl_?.Period;
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime co_ = context.Operators.Start(cn_);

                bool? cp_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> qe_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qf_ = qe_?.Value;
                    Code<Encounter.EncounterStatus> qg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qf_);
                    CqlBoolean qh_ = context.Operators.Equal(qg_, "finished");
                    Period qi_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qi_);
                    CqlDateTime qk_ = context.Operators.End(qj_);
                    Period ql_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ql_);
                    CqlDateTime qn_ = context.Operators.Start(qm_);
                    CqlQuantity qo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qp_ = context.Operators.Subtract(qn_, qo_);
                    CqlInterval<CqlDateTime> qq_ = context.Operators.Interval(qp_, qn_, true, true);
                    CqlBoolean qr_ = context.Operators.In<CqlDateTime>(qk_, qq_, (string)default);
                    CqlBoolean qs_ = (CqlBoolean)(qn_ is not null);
                    CqlBoolean qt_ = qr_
                        /* CQL 'and' (241:15-241:83) */ && qs_;
                    return qh_
                        /* CQL 'and' (240:6-241:83) */ && qt_;
                }

                IEnumerable<Encounter> cq_ = context.Operators.Where<Encounter>(bb_, cp_);

                object cr_(Encounter @this) {
                    Period qu_ = @this?.Period;
                    CqlInterval<CqlDateTime> qv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qu_);
                    CqlDateTime qw_ = context.Operators.End(qv_);
                    return qw_;
                }

                IEnumerable<Encounter> cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ct_ = context.Operators.Last<Encounter>(cs_);
                Period cu_ = ct_?.Period;
                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                CqlDateTime cw_ = context.Operators.Start(cv_);
                CqlBoolean cx_ = (CqlBoolean)((co_ ?? cw_ ?? bm_) is not null);
                return cg_
                    /* CQL 'and' (252:6-252:81) */ && cx_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period qx_ = @this?.Period;
                CqlInterval<CqlDateTime> qy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qx_);
                CqlDateTime qz_ = context.Operators.End(qy_);
                return qz_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ra_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rb_ = ra_?.Value;
                Code<Encounter.EncounterStatus> rc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rb_);
                CqlBoolean rd_ = context.Operators.Equal(rc_, "finished");
                Period re_ = LastED?.Period;
                CqlInterval<CqlDateTime> rf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, re_);
                CqlDateTime rg_ = context.Operators.End(rf_);
                CqlValueSet rh_ = this.Observation_Services(context);
                IEnumerable<Encounter> ri_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? rj_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> sq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? sr_ = sq_?.Value;
                    Code<Encounter.EncounterStatus> ss_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sr_);
                    CqlBoolean st_ = context.Operators.Equal(ss_, "finished");
                    Period su_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> sv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, su_);
                    CqlDateTime sw_ = context.Operators.End(sv_);
                    Period sx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sx_);
                    CqlDateTime sz_ = context.Operators.Start(sy_);
                    CqlQuantity ta_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tb_ = context.Operators.Subtract(sz_, ta_);
                    CqlInterval<CqlDateTime> tc_ = context.Operators.Interval(tb_, sz_, true, true);
                    CqlBoolean td_ = context.Operators.In<CqlDateTime>(sw_, tc_, (string)default);
                    CqlBoolean te_ = (CqlBoolean)(sz_ is not null);
                    CqlBoolean tf_ = td_
                        /* CQL 'and' (241:15-241:83) */ && te_;
                    return st_
                        /* CQL 'and' (240:6-241:83) */ && tf_;
                }

                IEnumerable<Encounter> rk_ = context.Operators.Where<Encounter>(ri_, rj_);

                object rl_(Encounter @this) {
                    Period tg_ = @this?.Period;
                    CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                    CqlDateTime ti_ = context.Operators.End(th_);
                    return ti_;
                }

                IEnumerable<Encounter> rm_ = context.Operators.SortBy<Encounter>(rk_, rl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter rn_ = context.Operators.Last<Encounter>(rm_);
                Period ro_ = rn_?.Period;
                CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ro_);
                CqlDateTime rq_ = context.Operators.Start(rp_);
                Period rr_ = Visit?.Period;
                CqlInterval<CqlDateTime> rs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rr_);
                CqlDateTime rt_ = context.Operators.Start(rs_);
                CqlQuantity ru_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime rv_ = context.Operators.Subtract(rq_ ?? rt_, ru_);

                bool? rw_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> tj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tk_ = tj_?.Value;
                    Code<Encounter.EncounterStatus> tl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tk_);
                    CqlBoolean tm_ = context.Operators.Equal(tl_, "finished");
                    Period tn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> to_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tn_);
                    CqlDateTime tp_ = context.Operators.End(to_);
                    Period tq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tq_);
                    CqlDateTime ts_ = context.Operators.Start(tr_);
                    CqlQuantity tt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tu_ = context.Operators.Subtract(ts_, tt_);
                    CqlInterval<CqlDateTime> tv_ = context.Operators.Interval(tu_, ts_, true, true);
                    CqlBoolean tw_ = context.Operators.In<CqlDateTime>(tp_, tv_, (string)default);
                    CqlBoolean tx_ = (CqlBoolean)(ts_ is not null);
                    CqlBoolean ty_ = tw_
                        /* CQL 'and' (241:15-241:83) */ && tx_;
                    return tm_
                        /* CQL 'and' (240:6-241:83) */ && ty_;
                }

                IEnumerable<Encounter> rx_ = context.Operators.Where<Encounter>(ri_, rw_);

                object ry_(Encounter @this) {
                    Period tz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ua_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tz_);
                    CqlDateTime ub_ = context.Operators.End(ua_);
                    return ub_;
                }

                IEnumerable<Encounter> rz_ = context.Operators.SortBy<Encounter>(rx_, ry_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sa_ = context.Operators.Last<Encounter>(rz_);
                Period sb_ = sa_?.Period;
                CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sb_);
                CqlDateTime sd_ = context.Operators.Start(sc_);
                CqlInterval<CqlDateTime> se_ = context.Operators.Interval(rv_, sd_ ?? rt_, true, true);
                CqlBoolean sf_ = context.Operators.In<CqlDateTime>(rg_, se_, (string)default);

                bool? sg_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ud_ = uc_?.Value;
                    Code<Encounter.EncounterStatus> ue_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ud_);
                    CqlBoolean uf_ = context.Operators.Equal(ue_, "finished");
                    Period ug_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                    CqlDateTime ui_ = context.Operators.End(uh_);
                    Period uj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uj_);
                    CqlDateTime ul_ = context.Operators.Start(uk_);
                    CqlQuantity um_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime un_ = context.Operators.Subtract(ul_, um_);
                    CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(un_, ul_, true, true);
                    CqlBoolean up_ = context.Operators.In<CqlDateTime>(ui_, uo_, (string)default);
                    CqlBoolean uq_ = (CqlBoolean)(ul_ is not null);
                    CqlBoolean ur_ = up_
                        /* CQL 'and' (241:15-241:83) */ && uq_;
                    return uf_
                        /* CQL 'and' (240:6-241:83) */ && ur_;
                }

                IEnumerable<Encounter> sh_ = context.Operators.Where<Encounter>(ri_, sg_);

                object si_(Encounter @this) {
                    Period us_ = @this?.Period;
                    CqlInterval<CqlDateTime> ut_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, us_);
                    CqlDateTime uu_ = context.Operators.End(ut_);
                    return uu_;
                }

                IEnumerable<Encounter> sj_ = context.Operators.SortBy<Encounter>(sh_, si_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sk_ = context.Operators.Last<Encounter>(sj_);
                Period sl_ = sk_?.Period;
                CqlInterval<CqlDateTime> sm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sl_);
                CqlDateTime sn_ = context.Operators.Start(sm_);
                CqlBoolean so_ = (CqlBoolean)((sn_ ?? rt_) is not null);
                CqlBoolean sp_ = sf_
                    /* CQL 'and' (247:15-247:71) */ && so_;
                return rd_
                    /* CQL 'and' (246:6-247:71) */ && sp_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period uv_ = @this?.Period;
                CqlInterval<CqlDateTime> uw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uv_);
                CqlDateTime ux_ = context.Operators.End(uw_);
                return ux_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> uy_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uz_ = uy_?.Value;
                Code<Encounter.EncounterStatus> va_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uz_);
                CqlBoolean vb_ = context.Operators.Equal(va_, "finished");
                Period vc_ = LastObs?.Period;
                CqlInterval<CqlDateTime> vd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vc_);
                CqlDateTime ve_ = context.Operators.End(vd_);
                Period vf_ = Visit?.Period;
                CqlInterval<CqlDateTime> vg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vf_);
                CqlDateTime vh_ = context.Operators.Start(vg_);
                CqlQuantity vi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime vj_ = context.Operators.Subtract(vh_, vi_);
                CqlInterval<CqlDateTime> vk_ = context.Operators.Interval(vj_, vh_, true, true);
                CqlBoolean vl_ = context.Operators.In<CqlDateTime>(ve_, vk_, (string)default);
                CqlBoolean vm_ = (CqlBoolean)(vh_ is not null);
                CqlBoolean vn_ = vl_
                    /* CQL 'and' (241:15-241:83) */ && vm_;
                return vb_
                    /* CQL 'and' (240:6-241:83) */ && vn_;
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period vo_ = @this?.Period;
                CqlInterval<CqlDateTime> vp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vo_);
                CqlDateTime vq_ = context.Operators.End(vp_);
                return vq_;
            }

            IEnumerable<Encounter> ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ae_ = context.Operators.Last<Encounter>(ad_);
            Period af_ = ae_?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            Period ai_ = Visit?.Period;
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDateTime al_ = context.Operators.End(aj_);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, al_, true, true);
            return am_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet e_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastSurgeryOP) {
                Period an_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.End(ao_);
                CqlValueSet aq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? as_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> cy_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? cz_ = cy_?.Value;
                    Code<Encounter.EncounterStatus> da_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cz_);
                    CqlBoolean db_ = context.Operators.Equal(da_, "finished");
                    Period dc_ = LastED?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    CqlValueSet df_ = this.Observation_Services(context);
                    IEnumerable<Encounter> dg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, df_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? dh_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> eo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ep_ = eo_?.Value;
                        Code<Encounter.EncounterStatus> eq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ep_);
                        CqlBoolean er_ = context.Operators.Equal(eq_, "finished");
                        Period es_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                        CqlDateTime eu_ = context.Operators.End(et_);
                        Period ev_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                        CqlDateTime ex_ = context.Operators.Start(ew_);
                        CqlQuantity ey_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ez_ = context.Operators.Subtract(ex_, ey_);
                        CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ez_, ex_, true, true);
                        CqlBoolean fb_ = context.Operators.In<CqlDateTime>(eu_, fa_, (string)default);
                        CqlBoolean fc_ = (CqlBoolean)(ex_ is not null);
                        CqlBoolean fd_ = fb_
                            /* CQL 'and' (264:15-264:83) */ && fc_;
                        return er_
                            /* CQL 'and' (263:6-264:83) */ && fd_;
                    }

                    IEnumerable<Encounter> di_ = context.Operators.Where<Encounter>(dg_, dh_);

                    object dj_(Encounter @this) {
                        Period fe_ = @this?.Period;
                        CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                        CqlDateTime fg_ = context.Operators.End(ff_);
                        return fg_;
                    }

                    IEnumerable<Encounter> dk_ = context.Operators.SortBy<Encounter>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dl_ = context.Operators.Last<Encounter>(dk_);
                    Period dm_ = dl_?.Period;
                    CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime do_ = context.Operators.Start(dn_);
                    Period dp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
                    CqlDateTime dr_ = context.Operators.Start(dq_);
                    CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dt_ = context.Operators.Subtract(do_ ?? dr_, ds_);

                    bool? du_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> fh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fi_ = fh_?.Value;
                        Code<Encounter.EncounterStatus> fj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fi_);
                        CqlBoolean fk_ = context.Operators.Equal(fj_, "finished");
                        Period fl_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fl_);
                        CqlDateTime fn_ = context.Operators.End(fm_);
                        Period fo_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                        CqlDateTime fq_ = context.Operators.Start(fp_);
                        CqlQuantity fr_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fs_ = context.Operators.Subtract(fq_, fr_);
                        CqlInterval<CqlDateTime> ft_ = context.Operators.Interval(fs_, fq_, true, true);
                        CqlBoolean fu_ = context.Operators.In<CqlDateTime>(fn_, ft_, (string)default);
                        CqlBoolean fv_ = (CqlBoolean)(fq_ is not null);
                        CqlBoolean fw_ = fu_
                            /* CQL 'and' (264:15-264:83) */ && fv_;
                        return fk_
                            /* CQL 'and' (263:6-264:83) */ && fw_;
                    }

                    IEnumerable<Encounter> dv_ = context.Operators.Where<Encounter>(dg_, du_);

                    object dw_(Encounter @this) {
                        Period fx_ = @this?.Period;
                        CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                        CqlDateTime fz_ = context.Operators.End(fy_);
                        return fz_;
                    }

                    IEnumerable<Encounter> dx_ = context.Operators.SortBy<Encounter>(dv_, dw_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dy_ = context.Operators.Last<Encounter>(dx_);
                    Period dz_ = dy_?.Period;
                    CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                    CqlDateTime eb_ = context.Operators.Start(ea_);
                    CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dt_, eb_ ?? dr_, true, true);
                    CqlBoolean ed_ = context.Operators.In<CqlDateTime>(de_, ec_, (string)default);

                    bool? ee_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> ga_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gb_ = ga_?.Value;
                        Code<Encounter.EncounterStatus> gc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gb_);
                        CqlBoolean gd_ = context.Operators.Equal(gc_, "finished");
                        Period ge_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ge_);
                        CqlDateTime gg_ = context.Operators.End(gf_);
                        Period gh_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gh_);
                        CqlDateTime gj_ = context.Operators.Start(gi_);
                        CqlQuantity gk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gl_ = context.Operators.Subtract(gj_, gk_);
                        CqlInterval<CqlDateTime> gm_ = context.Operators.Interval(gl_, gj_, true, true);
                        CqlBoolean gn_ = context.Operators.In<CqlDateTime>(gg_, gm_, (string)default);
                        CqlBoolean go_ = (CqlBoolean)(gj_ is not null);
                        CqlBoolean gp_ = gn_
                            /* CQL 'and' (264:15-264:83) */ && go_;
                        return gd_
                            /* CQL 'and' (263:6-264:83) */ && gp_;
                    }

                    IEnumerable<Encounter> ef_ = context.Operators.Where<Encounter>(dg_, ee_);

                    object eg_(Encounter @this) {
                        Period gq_ = @this?.Period;
                        CqlInterval<CqlDateTime> gr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                        CqlDateTime gs_ = context.Operators.End(gr_);
                        return gs_;
                    }

                    IEnumerable<Encounter> eh_ = context.Operators.SortBy<Encounter>(ef_, eg_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ei_ = context.Operators.Last<Encounter>(eh_);
                    Period ej_ = ei_?.Period;
                    CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                    CqlDateTime el_ = context.Operators.Start(ek_);
                    CqlBoolean em_ = (CqlBoolean)((el_ ?? dr_) is not null);
                    CqlBoolean en_ = ed_
                        /* CQL 'and' (270:15-270:71) */ && em_;
                    return db_
                        /* CQL 'and' (269:6-270:71) */ && en_;
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gt_ = @this?.Period;
                    CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gt_);
                    CqlDateTime gv_ = context.Operators.End(gu_);
                    return gv_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gw_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gx_ = gw_?.Value;
                    Code<Encounter.EncounterStatus> gy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gx_);
                    CqlBoolean gz_ = context.Operators.Equal(gy_, "finished");
                    Period ha_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> hb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ha_);
                    CqlDateTime hc_ = context.Operators.End(hb_);
                    Period hd_ = Visit?.Period;
                    CqlInterval<CqlDateTime> he_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hd_);
                    CqlDateTime hf_ = context.Operators.Start(he_);
                    CqlQuantity hg_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hh_ = context.Operators.Subtract(hf_, hg_);
                    CqlInterval<CqlDateTime> hi_ = context.Operators.Interval(hh_, hf_, true, true);
                    CqlBoolean hj_ = context.Operators.In<CqlDateTime>(hc_, hi_, (string)default);
                    CqlBoolean hk_ = (CqlBoolean)(hf_ is not null);
                    CqlBoolean hl_ = hj_
                        /* CQL 'and' (264:15-264:83) */ && hk_;
                    return gz_
                        /* CQL 'and' (263:6-264:83) */ && hl_;
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hm_ = @this?.Period;
                    CqlInterval<CqlDateTime> hn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hm_);
                    CqlDateTime ho_ = context.Operators.End(hn_);
                    return ho_;
                }

                IEnumerable<Encounter> bf_ = context.Operators.SortBy<Encounter>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bg_ = context.Operators.Last<Encounter>(bf_);
                Period bh_ = bg_?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                Period bk_ = Visit?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bo_ = context.Operators.Subtract(az_ ?? bj_ ?? bm_, bn_);

                bool? bp_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> hp_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hq_ = hp_?.Value;
                    Code<Encounter.EncounterStatus> hr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hq_);
                    CqlBoolean hs_ = context.Operators.Equal(hr_, "finished");
                    Period ht_ = LastED?.Period;
                    CqlInterval<CqlDateTime> hu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ht_);
                    CqlDateTime hv_ = context.Operators.End(hu_);
                    CqlValueSet hw_ = this.Observation_Services(context);
                    IEnumerable<Encounter> hx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? hy_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jg_ = jf_?.Value;
                        Code<Encounter.EncounterStatus> jh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jg_);
                        CqlBoolean ji_ = context.Operators.Equal(jh_, "finished");
                        Period jj_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> jk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jj_);
                        CqlDateTime jl_ = context.Operators.End(jk_);
                        Period jm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> jn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jm_);
                        CqlDateTime jo_ = context.Operators.Start(jn_);
                        CqlQuantity jp_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jq_ = context.Operators.Subtract(jo_, jp_);
                        CqlInterval<CqlDateTime> jr_ = context.Operators.Interval(jq_, jo_, true, true);
                        CqlBoolean js_ = context.Operators.In<CqlDateTime>(jl_, jr_, (string)default);
                        CqlBoolean jt_ = (CqlBoolean)(jo_ is not null);
                        CqlBoolean ju_ = js_
                            /* CQL 'and' (264:15-264:83) */ && jt_;
                        return ji_
                            /* CQL 'and' (263:6-264:83) */ && ju_;
                    }

                    IEnumerable<Encounter> hz_ = context.Operators.Where<Encounter>(hx_, hy_);

                    object ia_(Encounter @this) {
                        Period jv_ = @this?.Period;
                        CqlInterval<CqlDateTime> jw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jv_);
                        CqlDateTime jx_ = context.Operators.End(jw_);
                        return jx_;
                    }

                    IEnumerable<Encounter> ib_ = context.Operators.SortBy<Encounter>(hz_, ia_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ic_ = context.Operators.Last<Encounter>(ib_);
                    Period id_ = ic_?.Period;
                    CqlInterval<CqlDateTime> ie_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, id_);
                    CqlDateTime if_ = context.Operators.Start(ie_);
                    Period ig_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ih_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ig_);
                    CqlDateTime ii_ = context.Operators.Start(ih_);
                    CqlQuantity ij_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ik_ = context.Operators.Subtract(if_ ?? ii_, ij_);

                    bool? il_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> jy_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jz_ = jy_?.Value;
                        Code<Encounter.EncounterStatus> ka_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jz_);
                        CqlBoolean kb_ = context.Operators.Equal(ka_, "finished");
                        Period kc_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kc_);
                        CqlDateTime ke_ = context.Operators.End(kd_);
                        Period kf_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kf_);
                        CqlDateTime kh_ = context.Operators.Start(kg_);
                        CqlQuantity ki_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime kj_ = context.Operators.Subtract(kh_, ki_);
                        CqlInterval<CqlDateTime> kk_ = context.Operators.Interval(kj_, kh_, true, true);
                        CqlBoolean kl_ = context.Operators.In<CqlDateTime>(ke_, kk_, (string)default);
                        CqlBoolean km_ = (CqlBoolean)(kh_ is not null);
                        CqlBoolean kn_ = kl_
                            /* CQL 'and' (264:15-264:83) */ && km_;
                        return kb_
                            /* CQL 'and' (263:6-264:83) */ && kn_;
                    }

                    IEnumerable<Encounter> im_ = context.Operators.Where<Encounter>(hx_, il_);

                    object in_(Encounter @this) {
                        Period ko_ = @this?.Period;
                        CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                        CqlDateTime kq_ = context.Operators.End(kp_);
                        return kq_;
                    }

                    IEnumerable<Encounter> io_ = context.Operators.SortBy<Encounter>(im_, in_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ip_ = context.Operators.Last<Encounter>(io_);
                    Period iq_ = ip_?.Period;
                    CqlInterval<CqlDateTime> ir_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iq_);
                    CqlDateTime is_ = context.Operators.Start(ir_);
                    CqlInterval<CqlDateTime> it_ = context.Operators.Interval(ik_, is_ ?? ii_, true, true);
                    CqlBoolean iu_ = context.Operators.In<CqlDateTime>(hv_, it_, (string)default);

                    bool? iv_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> kr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ks_ = kr_?.Value;
                        Code<Encounter.EncounterStatus> kt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ks_);
                        CqlBoolean ku_ = context.Operators.Equal(kt_, "finished");
                        Period kv_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> kw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kv_);
                        CqlDateTime kx_ = context.Operators.End(kw_);
                        Period ky_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                        CqlDateTime la_ = context.Operators.Start(kz_);
                        CqlQuantity lb_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime lc_ = context.Operators.Subtract(la_, lb_);
                        CqlInterval<CqlDateTime> ld_ = context.Operators.Interval(lc_, la_, true, true);
                        CqlBoolean le_ = context.Operators.In<CqlDateTime>(kx_, ld_, (string)default);
                        CqlBoolean lf_ = (CqlBoolean)(la_ is not null);
                        CqlBoolean lg_ = le_
                            /* CQL 'and' (264:15-264:83) */ && lf_;
                        return ku_
                            /* CQL 'and' (263:6-264:83) */ && lg_;
                    }

                    IEnumerable<Encounter> iw_ = context.Operators.Where<Encounter>(hx_, iv_);

                    object ix_(Encounter @this) {
                        Period lh_ = @this?.Period;
                        CqlInterval<CqlDateTime> li_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lh_);
                        CqlDateTime lj_ = context.Operators.End(li_);
                        return lj_;
                    }

                    IEnumerable<Encounter> iy_ = context.Operators.SortBy<Encounter>(iw_, ix_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter iz_ = context.Operators.Last<Encounter>(iy_);
                    Period ja_ = iz_?.Period;
                    CqlInterval<CqlDateTime> jb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ja_);
                    CqlDateTime jc_ = context.Operators.Start(jb_);
                    CqlBoolean jd_ = (CqlBoolean)((jc_ ?? ii_) is not null);
                    CqlBoolean je_ = iu_
                        /* CQL 'and' (270:15-270:71) */ && jd_;
                    return hs_
                        /* CQL 'and' (269:6-270:71) */ && je_;
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ll_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lk_);
                    CqlDateTime lm_ = context.Operators.End(ll_);
                    return lm_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ln_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lo_ = ln_?.Value;
                    Code<Encounter.EncounterStatus> lp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lo_);
                    CqlBoolean lq_ = context.Operators.Equal(lp_, "finished");
                    Period lr_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ls_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lr_);
                    CqlDateTime lt_ = context.Operators.End(ls_);
                    Period lu_ = Visit?.Period;
                    CqlInterval<CqlDateTime> lv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lu_);
                    CqlDateTime lw_ = context.Operators.Start(lv_);
                    CqlQuantity lx_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ly_ = context.Operators.Subtract(lw_, lx_);
                    CqlInterval<CqlDateTime> lz_ = context.Operators.Interval(ly_, lw_, true, true);
                    CqlBoolean ma_ = context.Operators.In<CqlDateTime>(lt_, lz_, (string)default);
                    CqlBoolean mb_ = (CqlBoolean)(lw_ is not null);
                    CqlBoolean mc_ = ma_
                        /* CQL 'and' (264:15-264:83) */ && mb_;
                    return lq_
                        /* CQL 'and' (263:6-264:83) */ && mc_;
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period md_ = @this?.Period;
                    CqlInterval<CqlDateTime> me_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, md_);
                    CqlDateTime mf_ = context.Operators.End(me_);
                    return mf_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                CqlBoolean cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                bool? ch_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> mg_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? mh_ = mg_?.Value;
                    Code<Encounter.EncounterStatus> mi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(mh_);
                    CqlBoolean mj_ = context.Operators.Equal(mi_, "finished");
                    Period mk_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                    CqlDateTime mm_ = context.Operators.End(ml_);
                    CqlValueSet mn_ = this.Observation_Services(context);
                    IEnumerable<Encounter> mo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mp_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> nw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? nx_ = nw_?.Value;
                        Code<Encounter.EncounterStatus> ny_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nx_);
                        CqlBoolean nz_ = context.Operators.Equal(ny_, "finished");
                        Period oa_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ob_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oa_);
                        CqlDateTime oc_ = context.Operators.End(ob_);
                        Period od_ = Visit?.Period;
                        CqlInterval<CqlDateTime> oe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, od_);
                        CqlDateTime of_ = context.Operators.Start(oe_);
                        CqlQuantity og_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime oh_ = context.Operators.Subtract(of_, og_);
                        CqlInterval<CqlDateTime> oi_ = context.Operators.Interval(oh_, of_, true, true);
                        CqlBoolean oj_ = context.Operators.In<CqlDateTime>(oc_, oi_, (string)default);
                        CqlBoolean ok_ = (CqlBoolean)(of_ is not null);
                        CqlBoolean ol_ = oj_
                            /* CQL 'and' (264:15-264:83) */ && ok_;
                        return nz_
                            /* CQL 'and' (263:6-264:83) */ && ol_;
                    }

                    IEnumerable<Encounter> mq_ = context.Operators.Where<Encounter>(mo_, mp_);

                    object mr_(Encounter @this) {
                        Period om_ = @this?.Period;
                        CqlInterval<CqlDateTime> on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, om_);
                        CqlDateTime oo_ = context.Operators.End(on_);
                        return oo_;
                    }

                    IEnumerable<Encounter> ms_ = context.Operators.SortBy<Encounter>(mq_, mr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mt_ = context.Operators.Last<Encounter>(ms_);
                    Period mu_ = mt_?.Period;
                    CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mu_);
                    CqlDateTime mw_ = context.Operators.Start(mv_);
                    Period mx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> my_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mx_);
                    CqlDateTime mz_ = context.Operators.Start(my_);
                    CqlQuantity na_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime nb_ = context.Operators.Subtract(mw_ ?? mz_, na_);

                    bool? nc_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> op_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? oq_ = op_?.Value;
                        Code<Encounter.EncounterStatus> or_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oq_);
                        CqlBoolean os_ = context.Operators.Equal(or_, "finished");
                        Period ot_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ou_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ot_);
                        CqlDateTime ov_ = context.Operators.End(ou_);
                        Period ow_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ox_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ow_);
                        CqlDateTime oy_ = context.Operators.Start(ox_);
                        CqlQuantity oz_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pa_ = context.Operators.Subtract(oy_, oz_);
                        CqlInterval<CqlDateTime> pb_ = context.Operators.Interval(pa_, oy_, true, true);
                        CqlBoolean pc_ = context.Operators.In<CqlDateTime>(ov_, pb_, (string)default);
                        CqlBoolean pd_ = (CqlBoolean)(oy_ is not null);
                        CqlBoolean pe_ = pc_
                            /* CQL 'and' (264:15-264:83) */ && pd_;
                        return os_
                            /* CQL 'and' (263:6-264:83) */ && pe_;
                    }

                    IEnumerable<Encounter> nd_ = context.Operators.Where<Encounter>(mo_, nc_);

                    object ne_(Encounter @this) {
                        Period pf_ = @this?.Period;
                        CqlInterval<CqlDateTime> pg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pf_);
                        CqlDateTime ph_ = context.Operators.End(pg_);
                        return ph_;
                    }

                    IEnumerable<Encounter> nf_ = context.Operators.SortBy<Encounter>(nd_, ne_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ng_ = context.Operators.Last<Encounter>(nf_);
                    Period nh_ = ng_?.Period;
                    CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nh_);
                    CqlDateTime nj_ = context.Operators.Start(ni_);
                    CqlInterval<CqlDateTime> nk_ = context.Operators.Interval(nb_, nj_ ?? mz_, true, true);
                    CqlBoolean nl_ = context.Operators.In<CqlDateTime>(mm_, nk_, (string)default);

                    bool? nm_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pj_ = pi_?.Value;
                        Code<Encounter.EncounterStatus> pk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pj_);
                        CqlBoolean pl_ = context.Operators.Equal(pk_, "finished");
                        Period pm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> pn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pm_);
                        CqlDateTime po_ = context.Operators.End(pn_);
                        Period pp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> pq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pp_);
                        CqlDateTime pr_ = context.Operators.Start(pq_);
                        CqlQuantity ps_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime pt_ = context.Operators.Subtract(pr_, ps_);
                        CqlInterval<CqlDateTime> pu_ = context.Operators.Interval(pt_, pr_, true, true);
                        CqlBoolean pv_ = context.Operators.In<CqlDateTime>(po_, pu_, (string)default);
                        CqlBoolean pw_ = (CqlBoolean)(pr_ is not null);
                        CqlBoolean px_ = pv_
                            /* CQL 'and' (264:15-264:83) */ && pw_;
                        return pl_
                            /* CQL 'and' (263:6-264:83) */ && px_;
                    }

                    IEnumerable<Encounter> nn_ = context.Operators.Where<Encounter>(mo_, nm_);

                    object no_(Encounter @this) {
                        Period py_ = @this?.Period;
                        CqlInterval<CqlDateTime> pz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, py_);
                        CqlDateTime qa_ = context.Operators.End(pz_);
                        return qa_;
                    }

                    IEnumerable<Encounter> np_ = context.Operators.SortBy<Encounter>(nn_, no_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nq_ = context.Operators.Last<Encounter>(np_);
                    Period nr_ = nq_?.Period;
                    CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nr_);
                    CqlDateTime nt_ = context.Operators.Start(ns_);
                    CqlBoolean nu_ = (CqlBoolean)((nt_ ?? mz_) is not null);
                    CqlBoolean nv_ = nl_
                        /* CQL 'and' (270:15-270:71) */ && nu_;
                    return mj_
                        /* CQL 'and' (269:6-270:71) */ && nv_;
                }

                IEnumerable<Encounter> ci_ = context.Operators.Where<Encounter>(ar_, ch_);

                object cj_(Encounter @this) {
                    Period qb_ = @this?.Period;
                    CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                    CqlDateTime qd_ = context.Operators.End(qc_);
                    return qd_;
                }

                IEnumerable<Encounter> ck_ = context.Operators.SortBy<Encounter>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cl_ = context.Operators.Last<Encounter>(ck_);
                Period cm_ = cl_?.Period;
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime co_ = context.Operators.Start(cn_);

                bool? cp_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> qe_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qf_ = qe_?.Value;
                    Code<Encounter.EncounterStatus> qg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qf_);
                    CqlBoolean qh_ = context.Operators.Equal(qg_, "finished");
                    Period qi_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> qj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qi_);
                    CqlDateTime qk_ = context.Operators.End(qj_);
                    Period ql_ = Visit?.Period;
                    CqlInterval<CqlDateTime> qm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ql_);
                    CqlDateTime qn_ = context.Operators.Start(qm_);
                    CqlQuantity qo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime qp_ = context.Operators.Subtract(qn_, qo_);
                    CqlInterval<CqlDateTime> qq_ = context.Operators.Interval(qp_, qn_, true, true);
                    CqlBoolean qr_ = context.Operators.In<CqlDateTime>(qk_, qq_, (string)default);
                    CqlBoolean qs_ = (CqlBoolean)(qn_ is not null);
                    CqlBoolean qt_ = qr_
                        /* CQL 'and' (264:15-264:83) */ && qs_;
                    return qh_
                        /* CQL 'and' (263:6-264:83) */ && qt_;
                }

                IEnumerable<Encounter> cq_ = context.Operators.Where<Encounter>(bb_, cp_);

                object cr_(Encounter @this) {
                    Period qu_ = @this?.Period;
                    CqlInterval<CqlDateTime> qv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qu_);
                    CqlDateTime qw_ = context.Operators.End(qv_);
                    return qw_;
                }

                IEnumerable<Encounter> cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ct_ = context.Operators.Last<Encounter>(cs_);
                Period cu_ = ct_?.Period;
                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                CqlDateTime cw_ = context.Operators.Start(cv_);
                CqlBoolean cx_ = (CqlBoolean)((co_ ?? cw_ ?? bm_) is not null);
                return cg_
                    /* CQL 'and' (275:6-275:81) */ && cx_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period qx_ = @this?.Period;
                CqlInterval<CqlDateTime> qy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qx_);
                CqlDateTime qz_ = context.Operators.End(qy_);
                return qz_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ra_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rb_ = ra_?.Value;
                Code<Encounter.EncounterStatus> rc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rb_);
                CqlBoolean rd_ = context.Operators.Equal(rc_, "finished");
                Period re_ = LastED?.Period;
                CqlInterval<CqlDateTime> rf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, re_);
                CqlDateTime rg_ = context.Operators.End(rf_);
                CqlValueSet rh_ = this.Observation_Services(context);
                IEnumerable<Encounter> ri_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? rj_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> sq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? sr_ = sq_?.Value;
                    Code<Encounter.EncounterStatus> ss_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sr_);
                    CqlBoolean st_ = context.Operators.Equal(ss_, "finished");
                    Period su_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> sv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, su_);
                    CqlDateTime sw_ = context.Operators.End(sv_);
                    Period sx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sx_);
                    CqlDateTime sz_ = context.Operators.Start(sy_);
                    CqlQuantity ta_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tb_ = context.Operators.Subtract(sz_, ta_);
                    CqlInterval<CqlDateTime> tc_ = context.Operators.Interval(tb_, sz_, true, true);
                    CqlBoolean td_ = context.Operators.In<CqlDateTime>(sw_, tc_, (string)default);
                    CqlBoolean te_ = (CqlBoolean)(sz_ is not null);
                    CqlBoolean tf_ = td_
                        /* CQL 'and' (264:15-264:83) */ && te_;
                    return st_
                        /* CQL 'and' (263:6-264:83) */ && tf_;
                }

                IEnumerable<Encounter> rk_ = context.Operators.Where<Encounter>(ri_, rj_);

                object rl_(Encounter @this) {
                    Period tg_ = @this?.Period;
                    CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                    CqlDateTime ti_ = context.Operators.End(th_);
                    return ti_;
                }

                IEnumerable<Encounter> rm_ = context.Operators.SortBy<Encounter>(rk_, rl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter rn_ = context.Operators.Last<Encounter>(rm_);
                Period ro_ = rn_?.Period;
                CqlInterval<CqlDateTime> rp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ro_);
                CqlDateTime rq_ = context.Operators.Start(rp_);
                Period rr_ = Visit?.Period;
                CqlInterval<CqlDateTime> rs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rr_);
                CqlDateTime rt_ = context.Operators.Start(rs_);
                CqlQuantity ru_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime rv_ = context.Operators.Subtract(rq_ ?? rt_, ru_);

                bool? rw_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> tj_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? tk_ = tj_?.Value;
                    Code<Encounter.EncounterStatus> tl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tk_);
                    CqlBoolean tm_ = context.Operators.Equal(tl_, "finished");
                    Period tn_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> to_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tn_);
                    CqlDateTime tp_ = context.Operators.End(to_);
                    Period tq_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tq_);
                    CqlDateTime ts_ = context.Operators.Start(tr_);
                    CqlQuantity tt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tu_ = context.Operators.Subtract(ts_, tt_);
                    CqlInterval<CqlDateTime> tv_ = context.Operators.Interval(tu_, ts_, true, true);
                    CqlBoolean tw_ = context.Operators.In<CqlDateTime>(tp_, tv_, (string)default);
                    CqlBoolean tx_ = (CqlBoolean)(ts_ is not null);
                    CqlBoolean ty_ = tw_
                        /* CQL 'and' (264:15-264:83) */ && tx_;
                    return tm_
                        /* CQL 'and' (263:6-264:83) */ && ty_;
                }

                IEnumerable<Encounter> rx_ = context.Operators.Where<Encounter>(ri_, rw_);

                object ry_(Encounter @this) {
                    Period tz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ua_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tz_);
                    CqlDateTime ub_ = context.Operators.End(ua_);
                    return ub_;
                }

                IEnumerable<Encounter> rz_ = context.Operators.SortBy<Encounter>(rx_, ry_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sa_ = context.Operators.Last<Encounter>(rz_);
                Period sb_ = sa_?.Period;
                CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sb_);
                CqlDateTime sd_ = context.Operators.Start(sc_);
                CqlInterval<CqlDateTime> se_ = context.Operators.Interval(rv_, sd_ ?? rt_, true, true);
                CqlBoolean sf_ = context.Operators.In<CqlDateTime>(rg_, se_, (string)default);

                bool? sg_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> uc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ud_ = uc_?.Value;
                    Code<Encounter.EncounterStatus> ue_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ud_);
                    CqlBoolean uf_ = context.Operators.Equal(ue_, "finished");
                    Period ug_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ug_);
                    CqlDateTime ui_ = context.Operators.End(uh_);
                    Period uj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> uk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uj_);
                    CqlDateTime ul_ = context.Operators.Start(uk_);
                    CqlQuantity um_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime un_ = context.Operators.Subtract(ul_, um_);
                    CqlInterval<CqlDateTime> uo_ = context.Operators.Interval(un_, ul_, true, true);
                    CqlBoolean up_ = context.Operators.In<CqlDateTime>(ui_, uo_, (string)default);
                    CqlBoolean uq_ = (CqlBoolean)(ul_ is not null);
                    CqlBoolean ur_ = up_
                        /* CQL 'and' (264:15-264:83) */ && uq_;
                    return uf_
                        /* CQL 'and' (263:6-264:83) */ && ur_;
                }

                IEnumerable<Encounter> sh_ = context.Operators.Where<Encounter>(ri_, sg_);

                object si_(Encounter @this) {
                    Period us_ = @this?.Period;
                    CqlInterval<CqlDateTime> ut_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, us_);
                    CqlDateTime uu_ = context.Operators.End(ut_);
                    return uu_;
                }

                IEnumerable<Encounter> sj_ = context.Operators.SortBy<Encounter>(sh_, si_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter sk_ = context.Operators.Last<Encounter>(sj_);
                Period sl_ = sk_?.Period;
                CqlInterval<CqlDateTime> sm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sl_);
                CqlDateTime sn_ = context.Operators.Start(sm_);
                CqlBoolean so_ = (CqlBoolean)((sn_ ?? rt_) is not null);
                CqlBoolean sp_ = sf_
                    /* CQL 'and' (270:15-270:71) */ && so_;
                return rd_
                    /* CQL 'and' (269:6-270:71) */ && sp_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period uv_ = @this?.Period;
                CqlInterval<CqlDateTime> uw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uv_);
                CqlDateTime ux_ = context.Operators.End(uw_);
                return ux_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> uy_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uz_ = uy_?.Value;
                Code<Encounter.EncounterStatus> va_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uz_);
                CqlBoolean vb_ = context.Operators.Equal(va_, "finished");
                Period vc_ = LastObs?.Period;
                CqlInterval<CqlDateTime> vd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vc_);
                CqlDateTime ve_ = context.Operators.End(vd_);
                Period vf_ = Visit?.Period;
                CqlInterval<CqlDateTime> vg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vf_);
                CqlDateTime vh_ = context.Operators.Start(vg_);
                CqlQuantity vi_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime vj_ = context.Operators.Subtract(vh_, vi_);
                CqlInterval<CqlDateTime> vk_ = context.Operators.Interval(vj_, vh_, true, true);
                CqlBoolean vl_ = context.Operators.In<CqlDateTime>(ve_, vk_, (string)default);
                CqlBoolean vm_ = (CqlBoolean)(vh_ is not null);
                CqlBoolean vn_ = vl_
                    /* CQL 'and' (264:15-264:83) */ && vm_;
                return vb_
                    /* CQL 'and' (263:6-264:83) */ && vn_;
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period vo_ = @this?.Period;
                CqlInterval<CqlDateTime> vp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vo_);
                CqlDateTime vq_ = context.Operators.End(vp_);
                return vq_;
            }

            IEnumerable<Encounter> ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter ae_ = context.Operators.Last<Encounter>(ad_);
            Period af_ = ae_?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            Period ai_ = Visit?.Period;
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDateTime al_ = context.Operators.End(aj_);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, al_, true, true);
            return am_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
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
            CqlValueSet e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ad_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ae_ = ad_?.Value;
                Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                CqlBoolean ag_ = context.Operators.Equal(af_, "finished");
                Period ah_ = LastED?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.End(ai_);
                CqlValueSet ak_ = this.Observation_Services(context);
                IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? am_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> bt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bu_ = bt_?.Value;
                    Code<Encounter.EncounterStatus> bv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bu_);
                    CqlBoolean bw_ = context.Operators.Equal(bv_, "finished");
                    Period bx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.End(by_);
                    Period ca_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                    CqlDateTime cc_ = context.Operators.Start(cb_);
                    CqlQuantity cd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ce_ = context.Operators.Subtract(cc_, cd_);
                    CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(ce_, cc_, true, true);
                    CqlBoolean cg_ = context.Operators.In<CqlDateTime>(bz_, cf_, (string)default);
                    CqlBoolean ch_ = (CqlBoolean)(cc_ is not null);
                    CqlBoolean ci_ = cg_
                        /* CQL 'and' (288:17-288:85) */ && ch_;
                    return bw_
                        /* CQL 'and' (287:7-288:85) */ && ci_;
                }

                IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                object ao_(Encounter @this) {
                    Period cj_ = @this?.Period;
                    CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                    CqlDateTime cl_ = context.Operators.End(ck_);
                    return cl_;
                }

                IEnumerable<Encounter> ap_ = context.Operators.SortBy<Encounter>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aq_ = context.Operators.Last<Encounter>(ap_);
                Period ar_ = aq_?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                Period au_ = Visit?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlQuantity ax_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ay_ = context.Operators.Subtract(at_ ?? aw_, ax_);

                bool? az_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> cm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cn_ = cm_?.Value;
                    Code<Encounter.EncounterStatus> co_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cn_);
                    CqlBoolean cp_ = context.Operators.Equal(co_, "finished");
                    Period cq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                    CqlDateTime cs_ = context.Operators.End(cr_);
                    Period ct_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                    CqlDateTime cv_ = context.Operators.Start(cu_);
                    CqlQuantity cw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cx_ = context.Operators.Subtract(cv_, cw_);
                    CqlInterval<CqlDateTime> cy_ = context.Operators.Interval(cx_, cv_, true, true);
                    CqlBoolean cz_ = context.Operators.In<CqlDateTime>(cs_, cy_, (string)default);
                    CqlBoolean da_ = (CqlBoolean)(cv_ is not null);
                    CqlBoolean db_ = cz_
                        /* CQL 'and' (288:17-288:85) */ && da_;
                    return cp_
                        /* CQL 'and' (287:7-288:85) */ && db_;
                }

                IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                object bb_(Encounter @this) {
                    Period dc_ = @this?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    return de_;
                }

                IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bd_ = context.Operators.Last<Encounter>(bc_);
                Period be_ = bd_?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                CqlBoolean bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);

                bool? bj_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> df_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dg_ = df_?.Value;
                    Code<Encounter.EncounterStatus> dh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dg_);
                    CqlBoolean di_ = context.Operators.Equal(dh_, "finished");
                    Period dj_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                    CqlDateTime dl_ = context.Operators.End(dk_);
                    Period dm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime do_ = context.Operators.Start(dn_);
                    CqlQuantity dp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dq_ = context.Operators.Subtract(do_, dp_);
                    CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(dq_, do_, true, true);
                    CqlBoolean ds_ = context.Operators.In<CqlDateTime>(dl_, dr_, (string)default);
                    CqlBoolean dt_ = (CqlBoolean)(do_ is not null);
                    CqlBoolean du_ = ds_
                        /* CQL 'and' (288:17-288:85) */ && dt_;
                    return di_
                        /* CQL 'and' (287:7-288:85) */ && du_;
                }

                IEnumerable<Encounter> bk_ = context.Operators.Where<Encounter>(al_, bj_);

                object bl_(Encounter @this) {
                    Period dv_ = @this?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.End(dw_);
                    return dx_;
                }

                IEnumerable<Encounter> bm_ = context.Operators.SortBy<Encounter>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bn_ = context.Operators.Last<Encounter>(bm_);
                Period bo_ = bn_?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlBoolean br_ = (CqlBoolean)((bq_ ?? aw_) is not null);
                CqlBoolean bs_ = bi_
                    /* CQL 'and' (294:17-294:73) */ && br_;
                return ag_
                    /* CQL 'and' (293:7-294:73) */ && bs_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period dy_ = @this?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.End(dz_);
                return ea_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> eb_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? ec_ = eb_?.Value;
                Code<Encounter.EncounterStatus> ed_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ec_);
                CqlBoolean ee_ = context.Operators.Equal(ed_, "finished");
                Period ef_ = LastObs?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                CqlDateTime eh_ = context.Operators.End(eg_);
                Period ei_ = Visit?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                CqlQuantity el_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime em_ = context.Operators.Subtract(ek_, el_);
                CqlInterval<CqlDateTime> en_ = context.Operators.Interval(em_, ek_, true, true);
                CqlBoolean eo_ = context.Operators.In<CqlDateTime>(eh_, en_, (string)default);
                CqlBoolean ep_ = (CqlBoolean)(ek_ is not null);
                CqlBoolean eq_ = eo_
                    /* CQL 'and' (288:17-288:85) */ && ep_;
                return ee_
                    /* CQL 'and' (287:7-288:85) */ && eq_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period er_ = @this?.Period;
                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                CqlDateTime et_ = context.Operators.End(es_);
                return et_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            Period y_ = Visit?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDateTime ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime> hospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastED) {
                Code<Encounter.EncounterStatus> ad_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ae_ = ad_?.Value;
                Code<Encounter.EncounterStatus> af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                CqlBoolean ag_ = context.Operators.Equal(af_, "finished");
                Period ah_ = LastED?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.End(ai_);
                CqlValueSet ak_ = this.Observation_Services(context);
                IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? am_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> bt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bu_ = bt_?.Value;
                    Code<Encounter.EncounterStatus> bv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bu_);
                    CqlBoolean bw_ = context.Operators.Equal(bv_, "finished");
                    Period bx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.End(by_);
                    Period ca_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                    CqlDateTime cc_ = context.Operators.Start(cb_);
                    CqlQuantity cd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ce_ = context.Operators.Subtract(cc_, cd_);
                    CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(ce_, cc_, true, true);
                    CqlBoolean cg_ = context.Operators.In<CqlDateTime>(bz_, cf_, (string)default);
                    CqlBoolean ch_ = (CqlBoolean)(cc_ is not null);
                    CqlBoolean ci_ = cg_
                        /* CQL 'and' (306:17-306:85) */ && ch_;
                    return bw_
                        /* CQL 'and' (305:7-306:85) */ && ci_;
                }

                IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                object ao_(Encounter @this) {
                    Period cj_ = @this?.Period;
                    CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                    CqlDateTime cl_ = context.Operators.End(ck_);
                    return cl_;
                }

                IEnumerable<Encounter> ap_ = context.Operators.SortBy<Encounter>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aq_ = context.Operators.Last<Encounter>(ap_);
                Period ar_ = aq_?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                Period au_ = Visit?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlQuantity ax_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ay_ = context.Operators.Subtract(at_ ?? aw_, ax_);

                bool? az_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> cm_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cn_ = cm_?.Value;
                    Code<Encounter.EncounterStatus> co_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cn_);
                    CqlBoolean cp_ = context.Operators.Equal(co_, "finished");
                    Period cq_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cq_);
                    CqlDateTime cs_ = context.Operators.End(cr_);
                    Period ct_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                    CqlDateTime cv_ = context.Operators.Start(cu_);
                    CqlQuantity cw_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cx_ = context.Operators.Subtract(cv_, cw_);
                    CqlInterval<CqlDateTime> cy_ = context.Operators.Interval(cx_, cv_, true, true);
                    CqlBoolean cz_ = context.Operators.In<CqlDateTime>(cs_, cy_, (string)default);
                    CqlBoolean da_ = (CqlBoolean)(cv_ is not null);
                    CqlBoolean db_ = cz_
                        /* CQL 'and' (306:17-306:85) */ && da_;
                    return cp_
                        /* CQL 'and' (305:7-306:85) */ && db_;
                }

                IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                object bb_(Encounter @this) {
                    Period dc_ = @this?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    return de_;
                }

                IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bd_ = context.Operators.Last<Encounter>(bc_);
                Period be_ = bd_?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                CqlBoolean bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);

                bool? bj_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> df_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dg_ = df_?.Value;
                    Code<Encounter.EncounterStatus> dh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dg_);
                    CqlBoolean di_ = context.Operators.Equal(dh_, "finished");
                    Period dj_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                    CqlDateTime dl_ = context.Operators.End(dk_);
                    Period dm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime do_ = context.Operators.Start(dn_);
                    CqlQuantity dp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dq_ = context.Operators.Subtract(do_, dp_);
                    CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(dq_, do_, true, true);
                    CqlBoolean ds_ = context.Operators.In<CqlDateTime>(dl_, dr_, (string)default);
                    CqlBoolean dt_ = (CqlBoolean)(do_ is not null);
                    CqlBoolean du_ = ds_
                        /* CQL 'and' (306:17-306:85) */ && dt_;
                    return di_
                        /* CQL 'and' (305:7-306:85) */ && du_;
                }

                IEnumerable<Encounter> bk_ = context.Operators.Where<Encounter>(al_, bj_);

                object bl_(Encounter @this) {
                    Period dv_ = @this?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.End(dw_);
                    return dx_;
                }

                IEnumerable<Encounter> bm_ = context.Operators.SortBy<Encounter>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bn_ = context.Operators.Last<Encounter>(bm_);
                Period bo_ = bn_?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlBoolean br_ = (CqlBoolean)((bq_ ?? aw_) is not null);
                CqlBoolean bs_ = bi_
                    /* CQL 'and' (312:17-312:73) */ && br_;
                return ag_
                    /* CQL 'and' (311:7-312:73) */ && bs_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period dy_ = @this?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.End(dz_);
                return ea_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> eb_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? ec_ = eb_?.Value;
                Code<Encounter.EncounterStatus> ed_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ec_);
                CqlBoolean ee_ = context.Operators.Equal(ed_, "finished");
                Period ef_ = LastObs?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                CqlDateTime eh_ = context.Operators.End(eg_);
                Period ei_ = Visit?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                CqlQuantity el_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime em_ = context.Operators.Subtract(ek_, el_);
                CqlInterval<CqlDateTime> en_ = context.Operators.Interval(em_, ek_, true, true);
                CqlBoolean eo_ = context.Operators.In<CqlDateTime>(eh_, en_, (string)default);
                CqlBoolean ep_ = (CqlBoolean)(ek_ is not null);
                CqlBoolean eq_ = eo_
                    /* CQL 'and' (306:17-306:85) */ && ep_;
                return ee_
                    /* CQL 'and' (305:7-306:85) */ && eq_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period er_ = @this?.Period;
                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                CqlDateTime et_ = context.Operators.End(es_);
                return et_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            Period y_ = Visit?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDateTime ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
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
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlBoolean r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            CqlBoolean s_ = r_;
            return m_
                /* CQL 'and' (336:6-337:57) */ && s_;
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
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period n_ = Encounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlBoolean r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            CqlBoolean s_ = r_;
            return m_
                /* CQL 'and' (346:6-347:57) */ && s_;
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
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, e_ as IEnumerable<Condition>);

            bool? g_(Condition C) {
                ResourceReference j_ = D?.Condition;
                Id k_ = C?.IdElement;
                string l_ = k_?.Value;
                CqlBoolean m_ = QICoreCommon_4_0_000.Instance.references(context, j_, l_);
                return m_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Condition i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition> c_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition> encounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        Condition b_(ResourceReference D) {
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, e_ as IEnumerable<Condition>);

            bool? g_(Condition C) {
                Id j_ = C?.IdElement;
                string k_ = j_?.Value;
                CqlBoolean l_ = QICoreCommon_4_0_000.Instance.references(context, D, k_);
                return l_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Condition i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition> c_ = context.Operators.SelectDistinct<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        return c_;
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
            CqlBoolean i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
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
            CqlBoolean i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
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
            PositiveInt g_ = D?.RankElement;
            int? h_ = g_?.Value;
            CqlBoolean i_ = context.Operators.Equal(h_, 1);
            CodeableConcept j_ = D?.Use;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode l_ = this.Billing(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            CqlBoolean n_ = context.Operators.Equivalent(k_, m_);
            CqlBoolean o_ = n_;
            return i_
                /* CQL 'and' (386:25-386:62) */ && o_;
        }


        Condition c_(Encounter.DiagnosisComponent PD) {
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> r_ = context.Operators.Union<Condition>(p_ as IEnumerable<Condition>, q_ as IEnumerable<Condition>);

            bool? s_(Condition C) {
                ResourceReference v_ = PD?.Condition;
                Id w_ = C?.IdElement;
                string x_ = w_?.Value;
                CqlBoolean y_ = QICoreCommon_4_0_000.Instance.references(context, v_, x_);
                return y_;
            }

            IEnumerable<Condition> t_ = context.Operators.Where<Condition>(r_, s_);
            Condition u_ = context.Operators.SingletonFrom<Condition>(t_);
            return u_;
        }

        IEnumerable<Condition> d_ = context.Operators.WhereSelect<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_, c_);
        IEnumerable<Condition> e_ = context.Operators.Distinct<Condition>(d_);
        Condition f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
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
            CqlBoolean i_ = QICoreCommon_4_0_000.Instance.includesCode(context, g_, h_);
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
            IEnumerable<Claim> e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim C) {
                Code<FinancialResourceStatusCodes> n_ = C?.StatusElement;
                FinancialResourceStatusCodes? o_ = n_?.Value;
                Code<FinancialResourceStatusCodes> p_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(o_);
                CqlBoolean q_ = context.Operators.Equal(p_, "active");
                Code<ClaimUseCode> r_ = C?.UseElement;
                ClaimUseCode? s_ = r_?.Value;
                Code<ClaimUseCode> t_ = context.Operators.Convert<Code<ClaimUseCode>>(s_);
                CqlBoolean u_ = context.Operators.Equal(t_, "claim");
                CqlBoolean v_ = u_;
                List<Claim.ItemComponent> w_ = C?.Item;

                bool? x_(Claim.ItemComponent I) {
                    List<ResourceReference> aa_ = I?.Encounter;
                    CqlBoolean ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aa_, E);
                    return ab_;
                }

                CqlBoolean y_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)w_, x_);
                CqlBoolean z_ = y_;
                return q_
                    /* CQL 'and' (406:31-406:69) */ && v_
                    /* CQL 'and' (406:25-406:123) */ && z_;
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                return ac_ is not null;
            }


            List<Claim.DiagnosisComponent> i_(Claim @this) {
                List<Claim.DiagnosisComponent> ad_ = @this?.Diagnosis;
                return ad_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent> k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)j_);

            bool? l_(Claim.DiagnosisComponent D) {
                PositiveInt ae_ = D?.SequenceElement;
                int? af_ = ae_?.Value;
                IEnumerable<Claim> ag_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ah_(Claim C) {
                    Code<FinancialResourceStatusCodes> au_ = C?.StatusElement;
                    FinancialResourceStatusCodes? av_ = au_?.Value;
                    Code<FinancialResourceStatusCodes> aw_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(av_);
                    CqlBoolean ax_ = context.Operators.Equal(aw_, "active");
                    Code<ClaimUseCode> ay_ = C?.UseElement;
                    ClaimUseCode? az_ = ay_?.Value;
                    Code<ClaimUseCode> ba_ = context.Operators.Convert<Code<ClaimUseCode>>(az_);
                    CqlBoolean bb_ = context.Operators.Equal(ba_, "claim");
                    CqlBoolean bc_ = bb_;
                    List<Claim.ItemComponent> bd_ = C?.Item;

                    bool? be_(Claim.ItemComponent I) {
                        List<ResourceReference> bh_ = I?.Encounter;
                        CqlBoolean bi_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bh_, E);
                        return bi_;
                    }

                    CqlBoolean bf_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bd_, be_);
                    CqlBoolean bg_ = bf_;
                    return ax_
                        /* CQL 'and' (406:31-406:69) */ && bc_
                        /* CQL 'and' (406:25-406:123) */ && bg_;
                }

                IEnumerable<Claim> ai_ = context.Operators.Where<Claim>(ag_, ah_);

                bool? aj_(Claim @this) {
                    List<Claim.ItemComponent> bj_ = @this?.Item;
                    return bj_ is not null;
                }


                List<Claim.ItemComponent> ak_(Claim @this) {
                    List<Claim.ItemComponent> bk_ = @this?.Item;
                    return bk_;
                }

                IEnumerable<List<Claim.ItemComponent>> al_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ai_, aj_, ak_);
                IEnumerable<Claim.ItemComponent> am_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)al_);

                bool? an_(Claim.ItemComponent I) {
                    List<ResourceReference> bl_ = I?.Encounter;
                    CqlBoolean bm_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bl_, E);
                    return bm_;
                }

                IEnumerable<Claim.ItemComponent> ao_ = context.Operators.Where<Claim.ItemComponent>(am_, an_);

                bool? ap_(Claim.ItemComponent @this) {
                    List<PositiveInt> bn_ = @this?.DiagnosisSequenceElement;

                    int? bo_(PositiveInt @this) {
                        int? bq_ = @this?.Value;
                        return bq_;
                    }

                    IEnumerable<int?> bp_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bn_, bo_);
                    return bp_ is not null;
                }


                IEnumerable<int?> aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> br_ = @this?.DiagnosisSequenceElement;

                    int? bs_(PositiveInt @this) {
                        int? bu_ = @this?.Value;
                        return bu_;
                    }

                    IEnumerable<int?> bt_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)br_, bs_);
                    return bt_;
                }

                IEnumerable<IEnumerable<int?>> ar_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ao_, ap_, aq_);
                IEnumerable<int?> as_ = context.Operators.Flatten<int?>(ar_);
                CqlBoolean at_ = context.Operators.In<int?>(af_, as_);
                return at_;
            }

            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Where<Claim.DiagnosisComponent>(k_, l_);
            return m_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<Claim.DiagnosisComponent> d_ = context.Operators.SingletonFrom<IEnumerable<Claim.DiagnosisComponent>>(c_);
        return d_;
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
            DataType f_ = PD?.Diagnosis;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlBoolean h_ = context.Operators.ConceptInValueSet(g_ as CqlConcept, valueSet);
            Condition i_ = this.getCondition(context, g_ as ResourceReference);
            CodeableConcept j_ = i_?.Code;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlBoolean l_ = context.Operators.ConceptInValueSet(k_, valueSet);
            CqlBoolean m_ = l_;
            return h_
                /* CQL 'or' (417:13-418:54) */ || m_;
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Claim.DiagnosisComponent, bool?>((IEnumerable<Claim.DiagnosisComponent>)b_, c_);
        CqlBoolean e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isDiagnosisPresentOnAdmission")]
    [CqlTag("description", "Returns true if the given diagnosis is present on admission, based on the given poaValueSet")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public bool? isDiagnosisPresentOnAdmission(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet, CqlValueSet poaValueSet)
    {
        IEnumerable<Claim.DiagnosisComponent> a_ = this.claimDiagnosis(context, encounter);

        bool? b_(Claim.DiagnosisComponent CD) {
            CodeableConcept d_ = CD?.OnAdmission;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlBoolean f_ = context.Operators.ConceptInValueSet(e_, poaValueSet);
            DataType g_ = CD?.Diagnosis;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlBoolean i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, diagnosisValueSet);
            Condition j_ = this.getCondition(context, h_ as ResourceReference);
            CodeableConcept k_ = j_?.Code;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlBoolean m_ = context.Operators.ConceptInValueSet(l_, diagnosisValueSet);
            CqlBoolean n_ = m_;
            CqlBoolean o_ = i_
                /* CQL 'or' (428:14-431:10) */ || n_;
            return f_
                /* CQL 'and' (427:8-431:10) */ && o_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location getLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

        bool? b_(Location L) {
            CqlBoolean e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
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
            return b_ as CqlConcept;
        }
        else
        {
            IEnumerable<Medication> d_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? e_(Medication M) {
                DataType j_ = request?.Medication;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlBoolean l_ = QICoreCommon_4_0_000.Instance.references(context, k_ as ResourceReference, M);
                return l_;
            }

            IEnumerable<Medication> f_ = context.Operators.Where<Medication>(d_, e_);
            Medication g_ = context.Operators.SingletonFrom<Medication>(f_);
            CodeableConcept h_ = g_?.Code;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            return i_;
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
            return b_ as CqlConcept;
        }
        else
        {
            IEnumerable<Medication> d_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? e_(Medication M) {
                DataType j_ = request?.Medication;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlBoolean l_ = QICoreCommon_4_0_000.Instance.references(context, k_ as ResourceReference, M);
                return l_;
            }

            IEnumerable<Medication> f_ = context.Operators.Where<Medication>(d_, e_);
            Medication g_ = context.Operators.SingletonFrom<Medication>(f_);
            CodeableConcept h_ = g_?.Code;
            CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
            return i_;
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
            IEnumerable<Claim> e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim C) {
                Code<FinancialResourceStatusCodes> o_ = C?.StatusElement;
                FinancialResourceStatusCodes? p_ = o_?.Value;
                Code<FinancialResourceStatusCodes> q_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(p_);
                CqlBoolean r_ = context.Operators.Equal(q_, "active");
                Code<ClaimUseCode> s_ = C?.UseElement;
                ClaimUseCode? t_ = s_?.Value;
                Code<ClaimUseCode> u_ = context.Operators.Convert<Code<ClaimUseCode>>(t_);
                CqlBoolean v_ = context.Operators.Equal(u_, "claim");
                CqlBoolean w_ = v_;
                List<Claim.ItemComponent> x_ = C?.Item;

                bool? y_(Claim.ItemComponent I) {
                    List<ResourceReference> ab_ = I?.Encounter;
                    CqlBoolean ac_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ab_, E);
                    return ac_;
                }

                CqlBoolean z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                CqlBoolean aa_ = z_;
                return r_
                    /* CQL 'and' (476:32-476:70) */ && w_
                    /* CQL 'and' (476:26-476:124) */ && aa_;
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.ProcedureComponent> ad_ = @this?.Procedure;
                return ad_ is not null;
            }


            List<Claim.ProcedureComponent> i_(Claim @this) {
                List<Claim.ProcedureComponent> ae_ = @this?.Procedure;
                return ae_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(g_, h_, i_);
            IEnumerable<Claim.ProcedureComponent> k_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)j_);

            bool? l_(Claim.ProcedureComponent P) {
                PositiveInt af_ = P?.SequenceElement;
                int? ag_ = af_?.Value;
                IEnumerable<Claim> ah_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ai_(Claim C) {
                    Code<FinancialResourceStatusCodes> bb_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bc_ = bb_?.Value;
                    Code<FinancialResourceStatusCodes> bd_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bc_);
                    CqlBoolean be_ = context.Operators.Equal(bd_, "active");
                    Code<ClaimUseCode> bf_ = C?.UseElement;
                    ClaimUseCode? bg_ = bf_?.Value;
                    Code<ClaimUseCode> bh_ = context.Operators.Convert<Code<ClaimUseCode>>(bg_);
                    CqlBoolean bi_ = context.Operators.Equal(bh_, "claim");
                    CqlBoolean bj_ = bi_;
                    List<Claim.ItemComponent> bk_ = C?.Item;

                    bool? bl_(Claim.ItemComponent I) {
                        List<ResourceReference> bo_ = I?.Encounter;
                        CqlBoolean bp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bo_, E);
                        return bp_;
                    }

                    CqlBoolean bm_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bk_, bl_);
                    CqlBoolean bn_ = bm_;
                    return be_
                        /* CQL 'and' (476:32-476:70) */ && bj_
                        /* CQL 'and' (476:26-476:124) */ && bn_;
                }

                IEnumerable<Claim> aj_ = context.Operators.Where<Claim>(ah_, ai_);

                bool? ak_(Claim @this) {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    return bq_ is not null;
                }


                List<Claim.ItemComponent> al_(Claim @this) {
                    List<Claim.ItemComponent> br_ = @this?.Item;
                    return br_;
                }

                IEnumerable<List<Claim.ItemComponent>> am_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(aj_, ak_, al_);
                IEnumerable<Claim.ItemComponent> an_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)am_);

                bool? ao_(Claim.ItemComponent I) {
                    List<ResourceReference> bs_ = I?.Encounter;
                    CqlBoolean bt_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bs_, E);
                    return bt_;
                }

                IEnumerable<Claim.ItemComponent> ap_ = context.Operators.Where<Claim.ItemComponent>(an_, ao_);

                bool? aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> bu_ = @this?.ProcedureSequenceElement;

                    int? bv_(PositiveInt @this) {
                        int? bx_ = @this?.Value;
                        return bx_;
                    }

                    IEnumerable<int?> bw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bu_, bv_);
                    return bw_ is not null;
                }


                IEnumerable<int?> ar_(Claim.ItemComponent @this) {
                    List<PositiveInt> by_ = @this?.ProcedureSequenceElement;

                    int? bz_(PositiveInt @this) {
                        int? cb_ = @this?.Value;
                        return cb_;
                    }

                    IEnumerable<int?> ca_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)by_, bz_);
                    return ca_;
                }

                IEnumerable<IEnumerable<int?>> as_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ap_, aq_, ar_);
                IEnumerable<int?> at_ = context.Operators.Flatten<int?>(as_);
                CqlBoolean au_ = context.Operators.In<int?>(ag_, at_);
                List<CodeableConcept> av_ = P?.Type;

                CqlConcept aw_(CodeableConcept @this) {
                    CqlConcept cc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return cc_;
                }

                IEnumerable<CqlConcept> ax_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)av_, aw_);
                CqlCode ay_ = this.Primary_procedure(context);
                CqlBoolean az_ = QICoreCommon_4_0_000.Instance.includesCode(context, ax_, ay_);
                CqlBoolean ba_ = az_;
                return au_
                    /* CQL 'and' (478:59-478:150) */ && ba_;
            }

            IEnumerable<Claim.ProcedureComponent> m_ = context.Operators.Where<Claim.ProcedureComponent>(k_, l_);
            Claim.ProcedureComponent n_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(m_);
            return n_;
        }

        IEnumerable<Claim.ProcedureComponent> c_ = context.Operators.SelectDistinct<Encounter, Claim.ProcedureComponent>((IEnumerable<Encounter>)a_, b_);
        Claim.ProcedureComponent d_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(c_);
        return d_;
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
