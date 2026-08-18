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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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

            CqlBoolean i_() {
                Period j_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(l_, m_, "day");
                return n_;
            }

            return h_
                /* CQL 'and' (46:5-47:75) */ && i_();
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

            CqlBoolean l_() {
                Period m_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                Period p_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, (string)default);

                CqlBoolean w_() {
                    Period x_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    CqlDateTime z_ = context.Operators.Start(y_);
                    return !((bool?)(z_ is null));
                }

                return v_
                    /* CQL 'and' (80:13-80:88) */ && w_();
            }

            return k_
                /* CQL 'and' (79:7-80:88) */ && l_();
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period aa_ = @this?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.End(ab_);
            return ac_;
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

            CqlBoolean l_() {
                Period m_ = EDVisit?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                Period p_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, (string)default);

                CqlBoolean w_() {
                    Period x_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    CqlDateTime z_ = context.Operators.Start(y_);
                    return !((bool?)(z_ is null));
                }

                return v_
                    /* CQL 'and' (91:13-91:88) */ && w_();
            }

            return k_
                /* CQL 'and' (90:7-91:88) */ && l_();
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period aa_ = @this?.Period;
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
            CqlDateTime ac_ = context.Operators.End(ab_);
            return ac_;
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
                    Code<Encounter.EncounterStatus> ci_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? cj_ = ci_?.Value;
                    Code<Encounter.EncounterStatus> ck_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cj_);
                    CqlBoolean cl_ = context.Operators.Equal(ck_, "finished");

                    CqlBoolean cm_() {
                        Period cn_ = LastED?.Period;
                        CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                        CqlDateTime cp_ = context.Operators.End(co_);
                        CqlValueSet cq_ = this.Observation_Services(context);
                        IEnumerable<Encounter> cr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, cq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? cs_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dq_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dr_ = dq_?.Value;
                            Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                            CqlBoolean dt_ = context.Operators.Equal(ds_, "finished");

                            CqlBoolean du_() {
                                Period dv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.End(dw_);
                                Period dy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                                CqlDateTime ea_ = context.Operators.Start(dz_);
                                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                                CqlBoolean ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                                CqlBoolean ef_() {
                                    Period eg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                                    CqlDateTime ei_ = context.Operators.Start(eh_);
                                    return !((bool?)(ei_ is null));
                                }

                                return ee_
                                    /* CQL 'and' (241:15-241:83) */ && ef_();
                            }

                            return dt_
                                /* CQL 'and' (240:6-241:83) */ && du_();
                        }

                        IEnumerable<Encounter> ct_ = context.Operators.Where<Encounter>(cr_, cs_);

                        object cu_(Encounter @this) {
                            Period ej_ = @this?.Period;
                            CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                            CqlDateTime el_ = context.Operators.End(ek_);
                            return el_;
                        }

                        IEnumerable<Encounter> cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cw_ = context.Operators.Last<Encounter>(cv_);
                        Period cx_ = cw_?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.Start(cy_);
                        Period da_ = Visit?.Period;
                        CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                        CqlDateTime dc_ = context.Operators.Start(db_);
                        CqlQuantity dd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime de_ = context.Operators.Subtract(cz_ ?? dc_, dd_);

                        bool? df_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> em_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? en_ = em_?.Value;
                            Code<Encounter.EncounterStatus> eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(en_);
                            CqlBoolean ep_ = context.Operators.Equal(eo_, "finished");

                            CqlBoolean eq_() {
                                Period er_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                                CqlDateTime et_ = context.Operators.End(es_);
                                Period eu_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                                CqlDateTime ew_ = context.Operators.Start(ev_);
                                CqlQuantity ex_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ey_ = context.Operators.Subtract(ew_, ex_);
                                CqlInterval<CqlDateTime> ez_ = context.Operators.Interval(ey_, ew_, true, true);
                                CqlBoolean fa_ = context.Operators.In<CqlDateTime>(et_, ez_, (string)default);

                                CqlBoolean fb_() {
                                    Period fc_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fc_);
                                    CqlDateTime fe_ = context.Operators.Start(fd_);
                                    return !((bool?)(fe_ is null));
                                }

                                return fa_
                                    /* CQL 'and' (241:15-241:83) */ && fb_();
                            }

                            return ep_
                                /* CQL 'and' (240:6-241:83) */ && eq_();
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.Where<Encounter>(cr_, df_);

                        object dh_(Encounter @this) {
                            Period ff_ = @this?.Period;
                            CqlInterval<CqlDateTime> fg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ff_);
                            CqlDateTime fh_ = context.Operators.End(fg_);
                            return fh_;
                        }

                        IEnumerable<Encounter> di_ = context.Operators.SortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dj_ = context.Operators.Last<Encounter>(di_);
                        Period dk_ = dj_?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        CqlInterval<CqlDateTime> dn_ = context.Operators.Interval(de_, dm_ ?? dc_, true, true);
                        CqlBoolean do_ = context.Operators.In<CqlDateTime>(cp_, dn_, (string)default);

                        CqlBoolean dp_() {
                            CqlValueSet fi_ = this.Observation_Services(context);
                            IEnumerable<Encounter> fj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? fk_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fv_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fw_ = fv_?.Value;
                                Code<Encounter.EncounterStatus> fx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fw_);
                                CqlBoolean fy_ = context.Operators.Equal(fx_, "finished");

                                CqlBoolean fz_() {
                                    Period ga_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> gb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ga_);
                                    CqlDateTime gc_ = context.Operators.End(gb_);
                                    Period gd_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ge_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gd_);
                                    CqlDateTime gf_ = context.Operators.Start(ge_);
                                    CqlQuantity gg_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime gh_ = context.Operators.Subtract(gf_, gg_);
                                    CqlInterval<CqlDateTime> gi_ = context.Operators.Interval(gh_, gf_, true, true);
                                    CqlBoolean gj_ = context.Operators.In<CqlDateTime>(gc_, gi_, (string)default);

                                    CqlBoolean gk_() {
                                        Period gl_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> gm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gl_);
                                        CqlDateTime gn_ = context.Operators.Start(gm_);
                                        return !((bool?)(gn_ is null));
                                    }

                                    return gj_
                                        /* CQL 'and' (241:15-241:83) */ && gk_();
                                }

                                return fy_
                                    /* CQL 'and' (240:6-241:83) */ && fz_();
                            }

                            IEnumerable<Encounter> fl_ = context.Operators.Where<Encounter>(fj_, fk_);

                            object fm_(Encounter @this) {
                                Period go_ = @this?.Period;
                                CqlInterval<CqlDateTime> gp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, go_);
                                CqlDateTime gq_ = context.Operators.End(gp_);
                                return gq_;
                            }

                            IEnumerable<Encounter> fn_ = context.Operators.SortBy<Encounter>(fl_, fm_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fo_ = context.Operators.Last<Encounter>(fn_);
                            Period fp_ = fo_?.Period;
                            CqlInterval<CqlDateTime> fq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fp_);
                            CqlDateTime fr_ = context.Operators.Start(fq_);
                            Period fs_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fs_);
                            CqlDateTime fu_ = context.Operators.Start(ft_);
                            return !((bool?)((fr_ ?? fu_) is null));
                        }

                        return do_
                            /* CQL 'and' (247:15-247:71) */ && dp_();
                    }

                    return cl_
                        /* CQL 'and' (246:6-247:71) */ && cm_();
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gr_ = @this?.Period;
                    CqlInterval<CqlDateTime> gs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gr_);
                    CqlDateTime gt_ = context.Operators.End(gs_);
                    return gt_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gv_ = gu_?.Value;
                    Code<Encounter.EncounterStatus> gw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gv_);
                    CqlBoolean gx_ = context.Operators.Equal(gw_, "finished");

                    CqlBoolean gy_() {
                        Period gz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ha_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gz_);
                        CqlDateTime hb_ = context.Operators.End(ha_);
                        Period hc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hc_);
                        CqlDateTime he_ = context.Operators.Start(hd_);
                        CqlQuantity hf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hg_ = context.Operators.Subtract(he_, hf_);
                        CqlInterval<CqlDateTime> hh_ = context.Operators.Interval(hg_, he_, true, true);
                        CqlBoolean hi_ = context.Operators.In<CqlDateTime>(hb_, hh_, (string)default);

                        CqlBoolean hj_() {
                            Period hk_ = Visit?.Period;
                            CqlInterval<CqlDateTime> hl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hk_);
                            CqlDateTime hm_ = context.Operators.Start(hl_);
                            return !((bool?)(hm_ is null));
                        }

                        return hi_
                            /* CQL 'and' (241:15-241:83) */ && hj_();
                    }

                    return gx_
                        /* CQL 'and' (240:6-241:83) */ && gy_();
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hn_ = @this?.Period;
                    CqlInterval<CqlDateTime> ho_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hn_);
                    CqlDateTime hp_ = context.Operators.End(ho_);
                    return hp_;
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
                    Code<Encounter.EncounterStatus> hq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hr_ = hq_?.Value;
                    Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
                    CqlBoolean ht_ = context.Operators.Equal(hs_, "finished");

                    CqlBoolean hu_() {
                        Period hv_ = LastED?.Period;
                        CqlInterval<CqlDateTime> hw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hv_);
                        CqlDateTime hx_ = context.Operators.End(hw_);
                        CqlValueSet hy_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? ia_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> iy_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? iz_ = iy_?.Value;
                            Code<Encounter.EncounterStatus> ja_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iz_);
                            CqlBoolean jb_ = context.Operators.Equal(ja_, "finished");

                            CqlBoolean jc_() {
                                Period jd_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> je_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jd_);
                                CqlDateTime jf_ = context.Operators.End(je_);
                                Period jg_ = Visit?.Period;
                                CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                                CqlDateTime ji_ = context.Operators.Start(jh_);
                                CqlQuantity jj_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jk_ = context.Operators.Subtract(ji_, jj_);
                                CqlInterval<CqlDateTime> jl_ = context.Operators.Interval(jk_, ji_, true, true);
                                CqlBoolean jm_ = context.Operators.In<CqlDateTime>(jf_, jl_, (string)default);

                                CqlBoolean jn_() {
                                    Period jo_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> jp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jo_);
                                    CqlDateTime jq_ = context.Operators.Start(jp_);
                                    return !((bool?)(jq_ is null));
                                }

                                return jm_
                                    /* CQL 'and' (241:15-241:83) */ && jn_();
                            }

                            return jb_
                                /* CQL 'and' (240:6-241:83) */ && jc_();
                        }

                        IEnumerable<Encounter> ib_ = context.Operators.Where<Encounter>(hz_, ia_);

                        object ic_(Encounter @this) {
                            Period jr_ = @this?.Period;
                            CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                            CqlDateTime jt_ = context.Operators.End(js_);
                            return jt_;
                        }

                        IEnumerable<Encounter> id_ = context.Operators.SortBy<Encounter>(ib_, ic_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ie_ = context.Operators.Last<Encounter>(id_);
                        Period if_ = ie_?.Period;
                        CqlInterval<CqlDateTime> ig_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, if_);
                        CqlDateTime ih_ = context.Operators.Start(ig_);
                        Period ii_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                        CqlDateTime ik_ = context.Operators.Start(ij_);
                        CqlQuantity il_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime im_ = context.Operators.Subtract(ih_ ?? ik_, il_);

                        bool? in_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ju_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? jv_ = ju_?.Value;
                            Code<Encounter.EncounterStatus> jw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jv_);
                            CqlBoolean jx_ = context.Operators.Equal(jw_, "finished");

                            CqlBoolean jy_() {
                                Period jz_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jz_);
                                CqlDateTime kb_ = context.Operators.End(ka_);
                                Period kc_ = Visit?.Period;
                                CqlInterval<CqlDateTime> kd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kc_);
                                CqlDateTime ke_ = context.Operators.Start(kd_);
                                CqlQuantity kf_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime kg_ = context.Operators.Subtract(ke_, kf_);
                                CqlInterval<CqlDateTime> kh_ = context.Operators.Interval(kg_, ke_, true, true);
                                CqlBoolean ki_ = context.Operators.In<CqlDateTime>(kb_, kh_, (string)default);

                                CqlBoolean kj_() {
                                    Period kk_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                                    CqlDateTime km_ = context.Operators.Start(kl_);
                                    return !((bool?)(km_ is null));
                                }

                                return ki_
                                    /* CQL 'and' (241:15-241:83) */ && kj_();
                            }

                            return jx_
                                /* CQL 'and' (240:6-241:83) */ && jy_();
                        }

                        IEnumerable<Encounter> io_ = context.Operators.Where<Encounter>(hz_, in_);

                        object ip_(Encounter @this) {
                            Period kn_ = @this?.Period;
                            CqlInterval<CqlDateTime> ko_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kn_);
                            CqlDateTime kp_ = context.Operators.End(ko_);
                            return kp_;
                        }

                        IEnumerable<Encounter> iq_ = context.Operators.SortBy<Encounter>(io_, ip_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ir_ = context.Operators.Last<Encounter>(iq_);
                        Period is_ = ir_?.Period;
                        CqlInterval<CqlDateTime> it_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, is_);
                        CqlDateTime iu_ = context.Operators.Start(it_);
                        CqlInterval<CqlDateTime> iv_ = context.Operators.Interval(im_, iu_ ?? ik_, true, true);
                        CqlBoolean iw_ = context.Operators.In<CqlDateTime>(hx_, iv_, (string)default);

                        CqlBoolean ix_() {
                            CqlValueSet kq_ = this.Observation_Services(context);
                            IEnumerable<Encounter> kr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? ks_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> ld_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? le_ = ld_?.Value;
                                Code<Encounter.EncounterStatus> lf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(le_);
                                CqlBoolean lg_ = context.Operators.Equal(lf_, "finished");

                                CqlBoolean lh_() {
                                    Period li_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> lj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, li_);
                                    CqlDateTime lk_ = context.Operators.End(lj_);
                                    Period ll_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> lm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ll_);
                                    CqlDateTime ln_ = context.Operators.Start(lm_);
                                    CqlQuantity lo_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime lp_ = context.Operators.Subtract(ln_, lo_);
                                    CqlInterval<CqlDateTime> lq_ = context.Operators.Interval(lp_, ln_, true, true);
                                    CqlBoolean lr_ = context.Operators.In<CqlDateTime>(lk_, lq_, (string)default);

                                    CqlBoolean ls_() {
                                        Period lt_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> lu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lt_);
                                        CqlDateTime lv_ = context.Operators.Start(lu_);
                                        return !((bool?)(lv_ is null));
                                    }

                                    return lr_
                                        /* CQL 'and' (241:15-241:83) */ && ls_();
                                }

                                return lg_
                                    /* CQL 'and' (240:6-241:83) */ && lh_();
                            }

                            IEnumerable<Encounter> kt_ = context.Operators.Where<Encounter>(kr_, ks_);

                            object ku_(Encounter @this) {
                                Period lw_ = @this?.Period;
                                CqlInterval<CqlDateTime> lx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lw_);
                                CqlDateTime ly_ = context.Operators.End(lx_);
                                return ly_;
                            }

                            IEnumerable<Encounter> kv_ = context.Operators.SortBy<Encounter>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter kw_ = context.Operators.Last<Encounter>(kv_);
                            Period kx_ = kw_?.Period;
                            CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                            CqlDateTime kz_ = context.Operators.Start(ky_);
                            Period la_ = Visit?.Period;
                            CqlInterval<CqlDateTime> lb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, la_);
                            CqlDateTime lc_ = context.Operators.Start(lb_);
                            return !((bool?)((kz_ ?? lc_) is null));
                        }

                        return iw_
                            /* CQL 'and' (247:15-247:71) */ && ix_();
                    }

                    return ht_
                        /* CQL 'and' (246:6-247:71) */ && hu_();
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                    CqlDateTime mb_ = context.Operators.End(ma_);
                    return mb_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> mc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? md_ = mc_?.Value;
                    Code<Encounter.EncounterStatus> me_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(md_);
                    CqlBoolean mf_ = context.Operators.Equal(me_, "finished");

                    CqlBoolean mg_() {
                        Period mh_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mh_);
                        CqlDateTime mj_ = context.Operators.End(mi_);
                        Period mk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                        CqlDateTime mm_ = context.Operators.Start(ml_);
                        CqlQuantity mn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mo_ = context.Operators.Subtract(mm_, mn_);
                        CqlInterval<CqlDateTime> mp_ = context.Operators.Interval(mo_, mm_, true, true);
                        CqlBoolean mq_ = context.Operators.In<CqlDateTime>(mj_, mp_, (string)default);

                        CqlBoolean mr_() {
                            Period ms_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ms_);
                            CqlDateTime mu_ = context.Operators.Start(mt_);
                            return !((bool?)(mu_ is null));
                        }

                        return mq_
                            /* CQL 'and' (241:15-241:83) */ && mr_();
                    }

                    return mf_
                        /* CQL 'and' (240:6-241:83) */ && mg_();
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period mv_ = @this?.Period;
                    CqlInterval<CqlDateTime> mw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mv_);
                    CqlDateTime mx_ = context.Operators.End(mw_);
                    return mx_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                CqlBoolean cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                CqlBoolean ch_() {
                    CqlValueSet my_ = this.Emergency_Department_Visit(context);
                    IEnumerable<Encounter> mz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, my_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? na_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> nv_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? nw_ = nv_?.Value;
                        Code<Encounter.EncounterStatus> nx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nw_);
                        CqlBoolean ny_ = context.Operators.Equal(nx_, "finished");

                        CqlBoolean nz_() {
                            Period oa_ = LastED?.Period;
                            CqlInterval<CqlDateTime> ob_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oa_);
                            CqlDateTime oc_ = context.Operators.End(ob_);
                            CqlValueSet od_ = this.Observation_Services(context);
                            IEnumerable<Encounter> oe_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, od_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? of_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pd_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? pe_ = pd_?.Value;
                                Code<Encounter.EncounterStatus> pf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pe_);
                                CqlBoolean pg_ = context.Operators.Equal(pf_, "finished");

                                CqlBoolean ph_() {
                                    Period pi_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> pj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pi_);
                                    CqlDateTime pk_ = context.Operators.End(pj_);
                                    Period pl_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> pm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pl_);
                                    CqlDateTime pn_ = context.Operators.Start(pm_);
                                    CqlQuantity po_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime pp_ = context.Operators.Subtract(pn_, po_);
                                    CqlInterval<CqlDateTime> pq_ = context.Operators.Interval(pp_, pn_, true, true);
                                    CqlBoolean pr_ = context.Operators.In<CqlDateTime>(pk_, pq_, (string)default);

                                    CqlBoolean ps_() {
                                        Period pt_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                                        CqlDateTime pv_ = context.Operators.Start(pu_);
                                        return !((bool?)(pv_ is null));
                                    }

                                    return pr_
                                        /* CQL 'and' (241:15-241:83) */ && ps_();
                                }

                                return pg_
                                    /* CQL 'and' (240:6-241:83) */ && ph_();
                            }

                            IEnumerable<Encounter> og_ = context.Operators.Where<Encounter>(oe_, of_);

                            object oh_(Encounter @this) {
                                Period pw_ = @this?.Period;
                                CqlInterval<CqlDateTime> px_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pw_);
                                CqlDateTime py_ = context.Operators.End(px_);
                                return py_;
                            }

                            IEnumerable<Encounter> oi_ = context.Operators.SortBy<Encounter>(og_, oh_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter oj_ = context.Operators.Last<Encounter>(oi_);
                            Period ok_ = oj_?.Period;
                            CqlInterval<CqlDateTime> ol_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ok_);
                            CqlDateTime om_ = context.Operators.Start(ol_);
                            Period on_ = Visit?.Period;
                            CqlInterval<CqlDateTime> oo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, on_);
                            CqlDateTime op_ = context.Operators.Start(oo_);
                            CqlQuantity oq_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime or_ = context.Operators.Subtract(om_ ?? op_, oq_);

                            bool? os_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pz_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? qa_ = pz_?.Value;
                                Code<Encounter.EncounterStatus> qb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qa_);
                                CqlBoolean qc_ = context.Operators.Equal(qb_, "finished");

                                CqlBoolean qd_() {
                                    Period qe_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                                    CqlDateTime qg_ = context.Operators.End(qf_);
                                    Period qh_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> qi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qh_);
                                    CqlDateTime qj_ = context.Operators.Start(qi_);
                                    CqlQuantity qk_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime ql_ = context.Operators.Subtract(qj_, qk_);
                                    CqlInterval<CqlDateTime> qm_ = context.Operators.Interval(ql_, qj_, true, true);
                                    CqlBoolean qn_ = context.Operators.In<CqlDateTime>(qg_, qm_, (string)default);

                                    CqlBoolean qo_() {
                                        Period qp_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> qq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                                        CqlDateTime qr_ = context.Operators.Start(qq_);
                                        return !((bool?)(qr_ is null));
                                    }

                                    return qn_
                                        /* CQL 'and' (241:15-241:83) */ && qo_();
                                }

                                return qc_
                                    /* CQL 'and' (240:6-241:83) */ && qd_();
                            }

                            IEnumerable<Encounter> ot_ = context.Operators.Where<Encounter>(oe_, os_);

                            object ou_(Encounter @this) {
                                Period qs_ = @this?.Period;
                                CqlInterval<CqlDateTime> qt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qs_);
                                CqlDateTime qu_ = context.Operators.End(qt_);
                                return qu_;
                            }

                            IEnumerable<Encounter> ov_ = context.Operators.SortBy<Encounter>(ot_, ou_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter ow_ = context.Operators.Last<Encounter>(ov_);
                            Period ox_ = ow_?.Period;
                            CqlInterval<CqlDateTime> oy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ox_);
                            CqlDateTime oz_ = context.Operators.Start(oy_);
                            CqlInterval<CqlDateTime> pa_ = context.Operators.Interval(or_, oz_ ?? op_, true, true);
                            CqlBoolean pb_ = context.Operators.In<CqlDateTime>(oc_, pa_, (string)default);

                            CqlBoolean pc_() {
                                CqlValueSet qv_ = this.Observation_Services(context);
                                IEnumerable<Encounter> qw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                                bool? qx_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> ri_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? rj_ = ri_?.Value;
                                    Code<Encounter.EncounterStatus> rk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rj_);
                                    CqlBoolean rl_ = context.Operators.Equal(rk_, "finished");

                                    CqlBoolean rm_() {
                                        Period rn_ = LastObs?.Period;
                                        CqlInterval<CqlDateTime> ro_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rn_);
                                        CqlDateTime rp_ = context.Operators.End(ro_);
                                        Period rq_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rq_);
                                        CqlDateTime rs_ = context.Operators.Start(rr_);
                                        CqlQuantity rt_ = context.Operators.Quantity(1m, "hour");
                                        CqlDateTime ru_ = context.Operators.Subtract(rs_, rt_);
                                        CqlInterval<CqlDateTime> rv_ = context.Operators.Interval(ru_, rs_, true, true);
                                        CqlBoolean rw_ = context.Operators.In<CqlDateTime>(rp_, rv_, (string)default);

                                        CqlBoolean rx_() {
                                            Period ry_ = Visit?.Period;
                                            CqlInterval<CqlDateTime> rz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ry_);
                                            CqlDateTime sa_ = context.Operators.Start(rz_);
                                            return !((bool?)(sa_ is null));
                                        }

                                        return rw_
                                            /* CQL 'and' (241:15-241:83) */ && rx_();
                                    }

                                    return rl_
                                        /* CQL 'and' (240:6-241:83) */ && rm_();
                                }

                                IEnumerable<Encounter> qy_ = context.Operators.Where<Encounter>(qw_, qx_);

                                object qz_(Encounter @this) {
                                    Period sb_ = @this?.Period;
                                    CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sb_);
                                    CqlDateTime sd_ = context.Operators.End(sc_);
                                    return sd_;
                                }

                                IEnumerable<Encounter> ra_ = context.Operators.SortBy<Encounter>(qy_, qz_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter rb_ = context.Operators.Last<Encounter>(ra_);
                                Period rc_ = rb_?.Period;
                                CqlInterval<CqlDateTime> rd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rc_);
                                CqlDateTime re_ = context.Operators.Start(rd_);
                                Period rf_ = Visit?.Period;
                                CqlInterval<CqlDateTime> rg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rf_);
                                CqlDateTime rh_ = context.Operators.Start(rg_);
                                return !((bool?)((re_ ?? rh_) is null));
                            }

                            return pb_
                                /* CQL 'and' (247:15-247:71) */ && pc_();
                        }

                        return ny_
                            /* CQL 'and' (246:6-247:71) */ && nz_();
                    }

                    IEnumerable<Encounter> nb_ = context.Operators.Where<Encounter>(mz_, na_);

                    object nc_(Encounter @this) {
                        Period se_ = @this?.Period;
                        CqlInterval<CqlDateTime> sf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, se_);
                        CqlDateTime sg_ = context.Operators.End(sf_);
                        return sg_;
                    }

                    IEnumerable<Encounter> nd_ = context.Operators.SortBy<Encounter>(nb_, nc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ne_ = context.Operators.Last<Encounter>(nd_);
                    Period nf_ = ne_?.Period;
                    CqlInterval<CqlDateTime> ng_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nf_);
                    CqlDateTime nh_ = context.Operators.Start(ng_);
                    CqlValueSet ni_ = this.Observation_Services(context);
                    IEnumerable<Encounter> nj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ni_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? nk_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> sh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? si_ = sh_?.Value;
                        Code<Encounter.EncounterStatus> sj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(si_);
                        CqlBoolean sk_ = context.Operators.Equal(sj_, "finished");

                        CqlBoolean sl_() {
                            Period sm_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> sn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sm_);
                            CqlDateTime so_ = context.Operators.End(sn_);
                            Period sp_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sp_);
                            CqlDateTime sr_ = context.Operators.Start(sq_);
                            CqlQuantity ss_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime st_ = context.Operators.Subtract(sr_, ss_);
                            CqlInterval<CqlDateTime> su_ = context.Operators.Interval(st_, sr_, true, true);
                            CqlBoolean sv_ = context.Operators.In<CqlDateTime>(so_, su_, (string)default);

                            CqlBoolean sw_() {
                                Period sx_ = Visit?.Period;
                                CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sx_);
                                CqlDateTime sz_ = context.Operators.Start(sy_);
                                return !((bool?)(sz_ is null));
                            }

                            return sv_
                                /* CQL 'and' (241:15-241:83) */ && sw_();
                        }

                        return sk_
                            /* CQL 'and' (240:6-241:83) */ && sl_();
                    }

                    IEnumerable<Encounter> nl_ = context.Operators.Where<Encounter>(nj_, nk_);

                    object nm_(Encounter @this) {
                        Period ta_ = @this?.Period;
                        CqlInterval<CqlDateTime> tb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ta_);
                        CqlDateTime tc_ = context.Operators.End(tb_);
                        return tc_;
                    }

                    IEnumerable<Encounter> nn_ = context.Operators.SortBy<Encounter>(nl_, nm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter no_ = context.Operators.Last<Encounter>(nn_);
                    Period np_ = no_?.Period;
                    CqlInterval<CqlDateTime> nq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, np_);
                    CqlDateTime nr_ = context.Operators.Start(nq_);
                    Period ns_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                    CqlDateTime nu_ = context.Operators.Start(nt_);
                    return !((bool?)((nh_ ?? nr_ ?? nu_) is null));
                }

                return cg_
                    /* CQL 'and' (252:6-252:81) */ && ch_();
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period td_ = @this?.Period;
                CqlInterval<CqlDateTime> te_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, td_);
                CqlDateTime tf_ = context.Operators.End(te_);
                return tf_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> tg_ = LastED?.StatusElement;
                Encounter.EncounterStatus? th_ = tg_?.Value;
                Code<Encounter.EncounterStatus> ti_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(th_);
                CqlBoolean tj_ = context.Operators.Equal(ti_, "finished");

                CqlBoolean tk_() {
                    Period tl_ = LastED?.Period;
                    CqlInterval<CqlDateTime> tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tl_);
                    CqlDateTime tn_ = context.Operators.End(tm_);
                    CqlValueSet to_ = this.Observation_Services(context);
                    IEnumerable<Encounter> tp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, to_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? tq_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> uo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? up_ = uo_?.Value;
                        Code<Encounter.EncounterStatus> uq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(up_);
                        CqlBoolean ur_ = context.Operators.Equal(uq_, "finished");

                        CqlBoolean us_() {
                            Period ut_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                            CqlDateTime uv_ = context.Operators.End(uu_);
                            Period uw_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                            CqlDateTime uy_ = context.Operators.Start(ux_);
                            CqlQuantity uz_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime va_ = context.Operators.Subtract(uy_, uz_);
                            CqlInterval<CqlDateTime> vb_ = context.Operators.Interval(va_, uy_, true, true);
                            CqlBoolean vc_ = context.Operators.In<CqlDateTime>(uv_, vb_, (string)default);

                            CqlBoolean vd_() {
                                Period ve_ = Visit?.Period;
                                CqlInterval<CqlDateTime> vf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ve_);
                                CqlDateTime vg_ = context.Operators.Start(vf_);
                                return !((bool?)(vg_ is null));
                            }

                            return vc_
                                /* CQL 'and' (241:15-241:83) */ && vd_();
                        }

                        return ur_
                            /* CQL 'and' (240:6-241:83) */ && us_();
                    }

                    IEnumerable<Encounter> tr_ = context.Operators.Where<Encounter>(tp_, tq_);

                    object ts_(Encounter @this) {
                        Period vh_ = @this?.Period;
                        CqlInterval<CqlDateTime> vi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vh_);
                        CqlDateTime vj_ = context.Operators.End(vi_);
                        return vj_;
                    }

                    IEnumerable<Encounter> tt_ = context.Operators.SortBy<Encounter>(tr_, ts_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tu_ = context.Operators.Last<Encounter>(tt_);
                    Period tv_ = tu_?.Period;
                    CqlInterval<CqlDateTime> tw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tv_);
                    CqlDateTime tx_ = context.Operators.Start(tw_);
                    Period ty_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                    CqlDateTime ua_ = context.Operators.Start(tz_);
                    CqlQuantity ub_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uc_ = context.Operators.Subtract(tx_ ?? ua_, ub_);

                    bool? ud_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> vk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? vl_ = vk_?.Value;
                        Code<Encounter.EncounterStatus> vm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vl_);
                        CqlBoolean vn_ = context.Operators.Equal(vm_, "finished");

                        CqlBoolean vo_() {
                            Period vp_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> vq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vp_);
                            CqlDateTime vr_ = context.Operators.End(vq_);
                            Period vs_ = Visit?.Period;
                            CqlInterval<CqlDateTime> vt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vs_);
                            CqlDateTime vu_ = context.Operators.Start(vt_);
                            CqlQuantity vv_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime vw_ = context.Operators.Subtract(vu_, vv_);
                            CqlInterval<CqlDateTime> vx_ = context.Operators.Interval(vw_, vu_, true, true);
                            CqlBoolean vy_ = context.Operators.In<CqlDateTime>(vr_, vx_, (string)default);

                            CqlBoolean vz_() {
                                Period wa_ = Visit?.Period;
                                CqlInterval<CqlDateTime> wb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wa_);
                                CqlDateTime wc_ = context.Operators.Start(wb_);
                                return !((bool?)(wc_ is null));
                            }

                            return vy_
                                /* CQL 'and' (241:15-241:83) */ && vz_();
                        }

                        return vn_
                            /* CQL 'and' (240:6-241:83) */ && vo_();
                    }

                    IEnumerable<Encounter> ue_ = context.Operators.Where<Encounter>(tp_, ud_);

                    object uf_(Encounter @this) {
                        Period wd_ = @this?.Period;
                        CqlInterval<CqlDateTime> we_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wd_);
                        CqlDateTime wf_ = context.Operators.End(we_);
                        return wf_;
                    }

                    IEnumerable<Encounter> ug_ = context.Operators.SortBy<Encounter>(ue_, uf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter uh_ = context.Operators.Last<Encounter>(ug_);
                    Period ui_ = uh_?.Period;
                    CqlInterval<CqlDateTime> uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime uk_ = context.Operators.Start(uj_);
                    CqlInterval<CqlDateTime> ul_ = context.Operators.Interval(uc_, uk_ ?? ua_, true, true);
                    CqlBoolean um_ = context.Operators.In<CqlDateTime>(tn_, ul_, (string)default);

                    CqlBoolean un_() {
                        CqlValueSet wg_ = this.Observation_Services(context);
                        IEnumerable<Encounter> wh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? wi_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> wt_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? wu_ = wt_?.Value;
                            Code<Encounter.EncounterStatus> wv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wu_);
                            CqlBoolean ww_ = context.Operators.Equal(wv_, "finished");

                            CqlBoolean wx_() {
                                Period wy_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> wz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wy_);
                                CqlDateTime xa_ = context.Operators.End(wz_);
                                Period xb_ = Visit?.Period;
                                CqlInterval<CqlDateTime> xc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xb_);
                                CqlDateTime xd_ = context.Operators.Start(xc_);
                                CqlQuantity xe_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime xf_ = context.Operators.Subtract(xd_, xe_);
                                CqlInterval<CqlDateTime> xg_ = context.Operators.Interval(xf_, xd_, true, true);
                                CqlBoolean xh_ = context.Operators.In<CqlDateTime>(xa_, xg_, (string)default);

                                CqlBoolean xi_() {
                                    Period xj_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> xk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xj_);
                                    CqlDateTime xl_ = context.Operators.Start(xk_);
                                    return !((bool?)(xl_ is null));
                                }

                                return xh_
                                    /* CQL 'and' (241:15-241:83) */ && xi_();
                            }

                            return ww_
                                /* CQL 'and' (240:6-241:83) */ && wx_();
                        }

                        IEnumerable<Encounter> wj_ = context.Operators.Where<Encounter>(wh_, wi_);

                        object wk_(Encounter @this) {
                            Period xm_ = @this?.Period;
                            CqlInterval<CqlDateTime> xn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xm_);
                            CqlDateTime xo_ = context.Operators.End(xn_);
                            return xo_;
                        }

                        IEnumerable<Encounter> wl_ = context.Operators.SortBy<Encounter>(wj_, wk_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter wm_ = context.Operators.Last<Encounter>(wl_);
                        Period wn_ = wm_?.Period;
                        CqlInterval<CqlDateTime> wo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wn_);
                        CqlDateTime wp_ = context.Operators.Start(wo_);
                        Period wq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> wr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wq_);
                        CqlDateTime ws_ = context.Operators.Start(wr_);
                        return !((bool?)((wp_ ?? ws_) is null));
                    }

                    return um_
                        /* CQL 'and' (247:15-247:71) */ && un_();
                }

                return tj_
                    /* CQL 'and' (246:6-247:71) */ && tk_();
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period xp_ = @this?.Period;
                CqlInterval<CqlDateTime> xq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xp_);
                CqlDateTime xr_ = context.Operators.End(xq_);
                return xr_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> xs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? xt_ = xs_?.Value;
                Code<Encounter.EncounterStatus> xu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xt_);
                CqlBoolean xv_ = context.Operators.Equal(xu_, "finished");

                CqlBoolean xw_() {
                    Period xx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xx_);
                    CqlDateTime xz_ = context.Operators.End(xy_);
                    Period ya_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ya_);
                    CqlDateTime yc_ = context.Operators.Start(yb_);
                    CqlQuantity yd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ye_ = context.Operators.Subtract(yc_, yd_);
                    CqlInterval<CqlDateTime> yf_ = context.Operators.Interval(ye_, yc_, true, true);
                    CqlBoolean yg_ = context.Operators.In<CqlDateTime>(xz_, yf_, (string)default);

                    CqlBoolean yh_() {
                        Period yi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yi_);
                        CqlDateTime yk_ = context.Operators.Start(yj_);
                        return !((bool?)(yk_ is null));
                    }

                    return yg_
                        /* CQL 'and' (241:15-241:83) */ && yh_();
                }

                return xv_
                    /* CQL 'and' (240:6-241:83) */ && xw_();
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period yl_ = @this?.Period;
                CqlInterval<CqlDateTime> ym_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yl_);
                CqlDateTime yn_ = context.Operators.End(ym_);
                return yn_;
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
                    Code<Encounter.EncounterStatus> ci_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? cj_ = ci_?.Value;
                    Code<Encounter.EncounterStatus> ck_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cj_);
                    CqlBoolean cl_ = context.Operators.Equal(ck_, "finished");

                    CqlBoolean cm_() {
                        Period cn_ = LastED?.Period;
                        CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                        CqlDateTime cp_ = context.Operators.End(co_);
                        CqlValueSet cq_ = this.Observation_Services(context);
                        IEnumerable<Encounter> cr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, cq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? cs_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dq_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dr_ = dq_?.Value;
                            Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                            CqlBoolean dt_ = context.Operators.Equal(ds_, "finished");

                            CqlBoolean du_() {
                                Period dv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.End(dw_);
                                Period dy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                                CqlDateTime ea_ = context.Operators.Start(dz_);
                                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                                CqlBoolean ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                                CqlBoolean ef_() {
                                    Period eg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                                    CqlDateTime ei_ = context.Operators.Start(eh_);
                                    return !((bool?)(ei_ is null));
                                }

                                return ee_
                                    /* CQL 'and' (264:15-264:83) */ && ef_();
                            }

                            return dt_
                                /* CQL 'and' (263:6-264:83) */ && du_();
                        }

                        IEnumerable<Encounter> ct_ = context.Operators.Where<Encounter>(cr_, cs_);

                        object cu_(Encounter @this) {
                            Period ej_ = @this?.Period;
                            CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                            CqlDateTime el_ = context.Operators.End(ek_);
                            return el_;
                        }

                        IEnumerable<Encounter> cv_ = context.Operators.SortBy<Encounter>(ct_, cu_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cw_ = context.Operators.Last<Encounter>(cv_);
                        Period cx_ = cw_?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.Start(cy_);
                        Period da_ = Visit?.Period;
                        CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                        CqlDateTime dc_ = context.Operators.Start(db_);
                        CqlQuantity dd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime de_ = context.Operators.Subtract(cz_ ?? dc_, dd_);

                        bool? df_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> em_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? en_ = em_?.Value;
                            Code<Encounter.EncounterStatus> eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(en_);
                            CqlBoolean ep_ = context.Operators.Equal(eo_, "finished");

                            CqlBoolean eq_() {
                                Period er_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                                CqlDateTime et_ = context.Operators.End(es_);
                                Period eu_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                                CqlDateTime ew_ = context.Operators.Start(ev_);
                                CqlQuantity ex_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ey_ = context.Operators.Subtract(ew_, ex_);
                                CqlInterval<CqlDateTime> ez_ = context.Operators.Interval(ey_, ew_, true, true);
                                CqlBoolean fa_ = context.Operators.In<CqlDateTime>(et_, ez_, (string)default);

                                CqlBoolean fb_() {
                                    Period fc_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fc_);
                                    CqlDateTime fe_ = context.Operators.Start(fd_);
                                    return !((bool?)(fe_ is null));
                                }

                                return fa_
                                    /* CQL 'and' (264:15-264:83) */ && fb_();
                            }

                            return ep_
                                /* CQL 'and' (263:6-264:83) */ && eq_();
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.Where<Encounter>(cr_, df_);

                        object dh_(Encounter @this) {
                            Period ff_ = @this?.Period;
                            CqlInterval<CqlDateTime> fg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ff_);
                            CqlDateTime fh_ = context.Operators.End(fg_);
                            return fh_;
                        }

                        IEnumerable<Encounter> di_ = context.Operators.SortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dj_ = context.Operators.Last<Encounter>(di_);
                        Period dk_ = dj_?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        CqlInterval<CqlDateTime> dn_ = context.Operators.Interval(de_, dm_ ?? dc_, true, true);
                        CqlBoolean do_ = context.Operators.In<CqlDateTime>(cp_, dn_, (string)default);

                        CqlBoolean dp_() {
                            CqlValueSet fi_ = this.Observation_Services(context);
                            IEnumerable<Encounter> fj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? fk_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fv_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fw_ = fv_?.Value;
                                Code<Encounter.EncounterStatus> fx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fw_);
                                CqlBoolean fy_ = context.Operators.Equal(fx_, "finished");

                                CqlBoolean fz_() {
                                    Period ga_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> gb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ga_);
                                    CqlDateTime gc_ = context.Operators.End(gb_);
                                    Period gd_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ge_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gd_);
                                    CqlDateTime gf_ = context.Operators.Start(ge_);
                                    CqlQuantity gg_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime gh_ = context.Operators.Subtract(gf_, gg_);
                                    CqlInterval<CqlDateTime> gi_ = context.Operators.Interval(gh_, gf_, true, true);
                                    CqlBoolean gj_ = context.Operators.In<CqlDateTime>(gc_, gi_, (string)default);

                                    CqlBoolean gk_() {
                                        Period gl_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> gm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gl_);
                                        CqlDateTime gn_ = context.Operators.Start(gm_);
                                        return !((bool?)(gn_ is null));
                                    }

                                    return gj_
                                        /* CQL 'and' (264:15-264:83) */ && gk_();
                                }

                                return fy_
                                    /* CQL 'and' (263:6-264:83) */ && fz_();
                            }

                            IEnumerable<Encounter> fl_ = context.Operators.Where<Encounter>(fj_, fk_);

                            object fm_(Encounter @this) {
                                Period go_ = @this?.Period;
                                CqlInterval<CqlDateTime> gp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, go_);
                                CqlDateTime gq_ = context.Operators.End(gp_);
                                return gq_;
                            }

                            IEnumerable<Encounter> fn_ = context.Operators.SortBy<Encounter>(fl_, fm_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fo_ = context.Operators.Last<Encounter>(fn_);
                            Period fp_ = fo_?.Period;
                            CqlInterval<CqlDateTime> fq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fp_);
                            CqlDateTime fr_ = context.Operators.Start(fq_);
                            Period fs_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fs_);
                            CqlDateTime fu_ = context.Operators.Start(ft_);
                            return !((bool?)((fr_ ?? fu_) is null));
                        }

                        return do_
                            /* CQL 'and' (270:15-270:71) */ && dp_();
                    }

                    return cl_
                        /* CQL 'and' (269:6-270:71) */ && cm_();
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gr_ = @this?.Period;
                    CqlInterval<CqlDateTime> gs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gr_);
                    CqlDateTime gt_ = context.Operators.End(gs_);
                    return gt_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gv_ = gu_?.Value;
                    Code<Encounter.EncounterStatus> gw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gv_);
                    CqlBoolean gx_ = context.Operators.Equal(gw_, "finished");

                    CqlBoolean gy_() {
                        Period gz_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ha_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gz_);
                        CqlDateTime hb_ = context.Operators.End(ha_);
                        Period hc_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hc_);
                        CqlDateTime he_ = context.Operators.Start(hd_);
                        CqlQuantity hf_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime hg_ = context.Operators.Subtract(he_, hf_);
                        CqlInterval<CqlDateTime> hh_ = context.Operators.Interval(hg_, he_, true, true);
                        CqlBoolean hi_ = context.Operators.In<CqlDateTime>(hb_, hh_, (string)default);

                        CqlBoolean hj_() {
                            Period hk_ = Visit?.Period;
                            CqlInterval<CqlDateTime> hl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hk_);
                            CqlDateTime hm_ = context.Operators.Start(hl_);
                            return !((bool?)(hm_ is null));
                        }

                        return hi_
                            /* CQL 'and' (264:15-264:83) */ && hj_();
                    }

                    return gx_
                        /* CQL 'and' (263:6-264:83) */ && gy_();
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hn_ = @this?.Period;
                    CqlInterval<CqlDateTime> ho_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hn_);
                    CqlDateTime hp_ = context.Operators.End(ho_);
                    return hp_;
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
                    Code<Encounter.EncounterStatus> hq_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hr_ = hq_?.Value;
                    Code<Encounter.EncounterStatus> hs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hr_);
                    CqlBoolean ht_ = context.Operators.Equal(hs_, "finished");

                    CqlBoolean hu_() {
                        Period hv_ = LastED?.Period;
                        CqlInterval<CqlDateTime> hw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hv_);
                        CqlDateTime hx_ = context.Operators.End(hw_);
                        CqlValueSet hy_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? ia_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> iy_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? iz_ = iy_?.Value;
                            Code<Encounter.EncounterStatus> ja_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(iz_);
                            CqlBoolean jb_ = context.Operators.Equal(ja_, "finished");

                            CqlBoolean jc_() {
                                Period jd_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> je_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jd_);
                                CqlDateTime jf_ = context.Operators.End(je_);
                                Period jg_ = Visit?.Period;
                                CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                                CqlDateTime ji_ = context.Operators.Start(jh_);
                                CqlQuantity jj_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jk_ = context.Operators.Subtract(ji_, jj_);
                                CqlInterval<CqlDateTime> jl_ = context.Operators.Interval(jk_, ji_, true, true);
                                CqlBoolean jm_ = context.Operators.In<CqlDateTime>(jf_, jl_, (string)default);

                                CqlBoolean jn_() {
                                    Period jo_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> jp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jo_);
                                    CqlDateTime jq_ = context.Operators.Start(jp_);
                                    return !((bool?)(jq_ is null));
                                }

                                return jm_
                                    /* CQL 'and' (264:15-264:83) */ && jn_();
                            }

                            return jb_
                                /* CQL 'and' (263:6-264:83) */ && jc_();
                        }

                        IEnumerable<Encounter> ib_ = context.Operators.Where<Encounter>(hz_, ia_);

                        object ic_(Encounter @this) {
                            Period jr_ = @this?.Period;
                            CqlInterval<CqlDateTime> js_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jr_);
                            CqlDateTime jt_ = context.Operators.End(js_);
                            return jt_;
                        }

                        IEnumerable<Encounter> id_ = context.Operators.SortBy<Encounter>(ib_, ic_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ie_ = context.Operators.Last<Encounter>(id_);
                        Period if_ = ie_?.Period;
                        CqlInterval<CqlDateTime> ig_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, if_);
                        CqlDateTime ih_ = context.Operators.Start(ig_);
                        Period ii_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ij_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ii_);
                        CqlDateTime ik_ = context.Operators.Start(ij_);
                        CqlQuantity il_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime im_ = context.Operators.Subtract(ih_ ?? ik_, il_);

                        bool? in_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ju_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? jv_ = ju_?.Value;
                            Code<Encounter.EncounterStatus> jw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jv_);
                            CqlBoolean jx_ = context.Operators.Equal(jw_, "finished");

                            CqlBoolean jy_() {
                                Period jz_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jz_);
                                CqlDateTime kb_ = context.Operators.End(ka_);
                                Period kc_ = Visit?.Period;
                                CqlInterval<CqlDateTime> kd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kc_);
                                CqlDateTime ke_ = context.Operators.Start(kd_);
                                CqlQuantity kf_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime kg_ = context.Operators.Subtract(ke_, kf_);
                                CqlInterval<CqlDateTime> kh_ = context.Operators.Interval(kg_, ke_, true, true);
                                CqlBoolean ki_ = context.Operators.In<CqlDateTime>(kb_, kh_, (string)default);

                                CqlBoolean kj_() {
                                    Period kk_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                                    CqlDateTime km_ = context.Operators.Start(kl_);
                                    return !((bool?)(km_ is null));
                                }

                                return ki_
                                    /* CQL 'and' (264:15-264:83) */ && kj_();
                            }

                            return jx_
                                /* CQL 'and' (263:6-264:83) */ && jy_();
                        }

                        IEnumerable<Encounter> io_ = context.Operators.Where<Encounter>(hz_, in_);

                        object ip_(Encounter @this) {
                            Period kn_ = @this?.Period;
                            CqlInterval<CqlDateTime> ko_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kn_);
                            CqlDateTime kp_ = context.Operators.End(ko_);
                            return kp_;
                        }

                        IEnumerable<Encounter> iq_ = context.Operators.SortBy<Encounter>(io_, ip_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ir_ = context.Operators.Last<Encounter>(iq_);
                        Period is_ = ir_?.Period;
                        CqlInterval<CqlDateTime> it_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, is_);
                        CqlDateTime iu_ = context.Operators.Start(it_);
                        CqlInterval<CqlDateTime> iv_ = context.Operators.Interval(im_, iu_ ?? ik_, true, true);
                        CqlBoolean iw_ = context.Operators.In<CqlDateTime>(hx_, iv_, (string)default);

                        CqlBoolean ix_() {
                            CqlValueSet kq_ = this.Observation_Services(context);
                            IEnumerable<Encounter> kr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? ks_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> ld_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? le_ = ld_?.Value;
                                Code<Encounter.EncounterStatus> lf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(le_);
                                CqlBoolean lg_ = context.Operators.Equal(lf_, "finished");

                                CqlBoolean lh_() {
                                    Period li_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> lj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, li_);
                                    CqlDateTime lk_ = context.Operators.End(lj_);
                                    Period ll_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> lm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ll_);
                                    CqlDateTime ln_ = context.Operators.Start(lm_);
                                    CqlQuantity lo_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime lp_ = context.Operators.Subtract(ln_, lo_);
                                    CqlInterval<CqlDateTime> lq_ = context.Operators.Interval(lp_, ln_, true, true);
                                    CqlBoolean lr_ = context.Operators.In<CqlDateTime>(lk_, lq_, (string)default);

                                    CqlBoolean ls_() {
                                        Period lt_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> lu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lt_);
                                        CqlDateTime lv_ = context.Operators.Start(lu_);
                                        return !((bool?)(lv_ is null));
                                    }

                                    return lr_
                                        /* CQL 'and' (264:15-264:83) */ && ls_();
                                }

                                return lg_
                                    /* CQL 'and' (263:6-264:83) */ && lh_();
                            }

                            IEnumerable<Encounter> kt_ = context.Operators.Where<Encounter>(kr_, ks_);

                            object ku_(Encounter @this) {
                                Period lw_ = @this?.Period;
                                CqlInterval<CqlDateTime> lx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lw_);
                                CqlDateTime ly_ = context.Operators.End(lx_);
                                return ly_;
                            }

                            IEnumerable<Encounter> kv_ = context.Operators.SortBy<Encounter>(kt_, ku_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter kw_ = context.Operators.Last<Encounter>(kv_);
                            Period kx_ = kw_?.Period;
                            CqlInterval<CqlDateTime> ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                            CqlDateTime kz_ = context.Operators.Start(ky_);
                            Period la_ = Visit?.Period;
                            CqlInterval<CqlDateTime> lb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, la_);
                            CqlDateTime lc_ = context.Operators.Start(lb_);
                            return !((bool?)((kz_ ?? lc_) is null));
                        }

                        return iw_
                            /* CQL 'and' (270:15-270:71) */ && ix_();
                    }

                    return ht_
                        /* CQL 'and' (269:6-270:71) */ && hu_();
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                    CqlDateTime mb_ = context.Operators.End(ma_);
                    return mb_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> mc_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? md_ = mc_?.Value;
                    Code<Encounter.EncounterStatus> me_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(md_);
                    CqlBoolean mf_ = context.Operators.Equal(me_, "finished");

                    CqlBoolean mg_() {
                        Period mh_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mh_);
                        CqlDateTime mj_ = context.Operators.End(mi_);
                        Period mk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                        CqlDateTime mm_ = context.Operators.Start(ml_);
                        CqlQuantity mn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime mo_ = context.Operators.Subtract(mm_, mn_);
                        CqlInterval<CqlDateTime> mp_ = context.Operators.Interval(mo_, mm_, true, true);
                        CqlBoolean mq_ = context.Operators.In<CqlDateTime>(mj_, mp_, (string)default);

                        CqlBoolean mr_() {
                            Period ms_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ms_);
                            CqlDateTime mu_ = context.Operators.Start(mt_);
                            return !((bool?)(mu_ is null));
                        }

                        return mq_
                            /* CQL 'and' (264:15-264:83) */ && mr_();
                    }

                    return mf_
                        /* CQL 'and' (263:6-264:83) */ && mg_();
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period mv_ = @this?.Period;
                    CqlInterval<CqlDateTime> mw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mv_);
                    CqlDateTime mx_ = context.Operators.End(mw_);
                    return mx_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                CqlBoolean cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                CqlBoolean ch_() {
                    CqlValueSet my_ = this.Emergency_Department_Visit(context);
                    IEnumerable<Encounter> mz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, my_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? na_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> nv_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? nw_ = nv_?.Value;
                        Code<Encounter.EncounterStatus> nx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nw_);
                        CqlBoolean ny_ = context.Operators.Equal(nx_, "finished");

                        CqlBoolean nz_() {
                            Period oa_ = LastED?.Period;
                            CqlInterval<CqlDateTime> ob_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oa_);
                            CqlDateTime oc_ = context.Operators.End(ob_);
                            CqlValueSet od_ = this.Observation_Services(context);
                            IEnumerable<Encounter> oe_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, od_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? of_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pd_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? pe_ = pd_?.Value;
                                Code<Encounter.EncounterStatus> pf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pe_);
                                CqlBoolean pg_ = context.Operators.Equal(pf_, "finished");

                                CqlBoolean ph_() {
                                    Period pi_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> pj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pi_);
                                    CqlDateTime pk_ = context.Operators.End(pj_);
                                    Period pl_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> pm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pl_);
                                    CqlDateTime pn_ = context.Operators.Start(pm_);
                                    CqlQuantity po_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime pp_ = context.Operators.Subtract(pn_, po_);
                                    CqlInterval<CqlDateTime> pq_ = context.Operators.Interval(pp_, pn_, true, true);
                                    CqlBoolean pr_ = context.Operators.In<CqlDateTime>(pk_, pq_, (string)default);

                                    CqlBoolean ps_() {
                                        Period pt_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                                        CqlDateTime pv_ = context.Operators.Start(pu_);
                                        return !((bool?)(pv_ is null));
                                    }

                                    return pr_
                                        /* CQL 'and' (264:15-264:83) */ && ps_();
                                }

                                return pg_
                                    /* CQL 'and' (263:6-264:83) */ && ph_();
                            }

                            IEnumerable<Encounter> og_ = context.Operators.Where<Encounter>(oe_, of_);

                            object oh_(Encounter @this) {
                                Period pw_ = @this?.Period;
                                CqlInterval<CqlDateTime> px_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pw_);
                                CqlDateTime py_ = context.Operators.End(px_);
                                return py_;
                            }

                            IEnumerable<Encounter> oi_ = context.Operators.SortBy<Encounter>(og_, oh_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter oj_ = context.Operators.Last<Encounter>(oi_);
                            Period ok_ = oj_?.Period;
                            CqlInterval<CqlDateTime> ol_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ok_);
                            CqlDateTime om_ = context.Operators.Start(ol_);
                            Period on_ = Visit?.Period;
                            CqlInterval<CqlDateTime> oo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, on_);
                            CqlDateTime op_ = context.Operators.Start(oo_);
                            CqlQuantity oq_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime or_ = context.Operators.Subtract(om_ ?? op_, oq_);

                            bool? os_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pz_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? qa_ = pz_?.Value;
                                Code<Encounter.EncounterStatus> qb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qa_);
                                CqlBoolean qc_ = context.Operators.Equal(qb_, "finished");

                                CqlBoolean qd_() {
                                    Period qe_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                                    CqlDateTime qg_ = context.Operators.End(qf_);
                                    Period qh_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> qi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qh_);
                                    CqlDateTime qj_ = context.Operators.Start(qi_);
                                    CqlQuantity qk_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime ql_ = context.Operators.Subtract(qj_, qk_);
                                    CqlInterval<CqlDateTime> qm_ = context.Operators.Interval(ql_, qj_, true, true);
                                    CqlBoolean qn_ = context.Operators.In<CqlDateTime>(qg_, qm_, (string)default);

                                    CqlBoolean qo_() {
                                        Period qp_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> qq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qp_);
                                        CqlDateTime qr_ = context.Operators.Start(qq_);
                                        return !((bool?)(qr_ is null));
                                    }

                                    return qn_
                                        /* CQL 'and' (264:15-264:83) */ && qo_();
                                }

                                return qc_
                                    /* CQL 'and' (263:6-264:83) */ && qd_();
                            }

                            IEnumerable<Encounter> ot_ = context.Operators.Where<Encounter>(oe_, os_);

                            object ou_(Encounter @this) {
                                Period qs_ = @this?.Period;
                                CqlInterval<CqlDateTime> qt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qs_);
                                CqlDateTime qu_ = context.Operators.End(qt_);
                                return qu_;
                            }

                            IEnumerable<Encounter> ov_ = context.Operators.SortBy<Encounter>(ot_, ou_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter ow_ = context.Operators.Last<Encounter>(ov_);
                            Period ox_ = ow_?.Period;
                            CqlInterval<CqlDateTime> oy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ox_);
                            CqlDateTime oz_ = context.Operators.Start(oy_);
                            CqlInterval<CqlDateTime> pa_ = context.Operators.Interval(or_, oz_ ?? op_, true, true);
                            CqlBoolean pb_ = context.Operators.In<CqlDateTime>(oc_, pa_, (string)default);

                            CqlBoolean pc_() {
                                CqlValueSet qv_ = this.Observation_Services(context);
                                IEnumerable<Encounter> qw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                                bool? qx_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> ri_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? rj_ = ri_?.Value;
                                    Code<Encounter.EncounterStatus> rk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rj_);
                                    CqlBoolean rl_ = context.Operators.Equal(rk_, "finished");

                                    CqlBoolean rm_() {
                                        Period rn_ = LastObs?.Period;
                                        CqlInterval<CqlDateTime> ro_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rn_);
                                        CqlDateTime rp_ = context.Operators.End(ro_);
                                        Period rq_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> rr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rq_);
                                        CqlDateTime rs_ = context.Operators.Start(rr_);
                                        CqlQuantity rt_ = context.Operators.Quantity(1m, "hour");
                                        CqlDateTime ru_ = context.Operators.Subtract(rs_, rt_);
                                        CqlInterval<CqlDateTime> rv_ = context.Operators.Interval(ru_, rs_, true, true);
                                        CqlBoolean rw_ = context.Operators.In<CqlDateTime>(rp_, rv_, (string)default);

                                        CqlBoolean rx_() {
                                            Period ry_ = Visit?.Period;
                                            CqlInterval<CqlDateTime> rz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ry_);
                                            CqlDateTime sa_ = context.Operators.Start(rz_);
                                            return !((bool?)(sa_ is null));
                                        }

                                        return rw_
                                            /* CQL 'and' (264:15-264:83) */ && rx_();
                                    }

                                    return rl_
                                        /* CQL 'and' (263:6-264:83) */ && rm_();
                                }

                                IEnumerable<Encounter> qy_ = context.Operators.Where<Encounter>(qw_, qx_);

                                object qz_(Encounter @this) {
                                    Period sb_ = @this?.Period;
                                    CqlInterval<CqlDateTime> sc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sb_);
                                    CqlDateTime sd_ = context.Operators.End(sc_);
                                    return sd_;
                                }

                                IEnumerable<Encounter> ra_ = context.Operators.SortBy<Encounter>(qy_, qz_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter rb_ = context.Operators.Last<Encounter>(ra_);
                                Period rc_ = rb_?.Period;
                                CqlInterval<CqlDateTime> rd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rc_);
                                CqlDateTime re_ = context.Operators.Start(rd_);
                                Period rf_ = Visit?.Period;
                                CqlInterval<CqlDateTime> rg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rf_);
                                CqlDateTime rh_ = context.Operators.Start(rg_);
                                return !((bool?)((re_ ?? rh_) is null));
                            }

                            return pb_
                                /* CQL 'and' (270:15-270:71) */ && pc_();
                        }

                        return ny_
                            /* CQL 'and' (269:6-270:71) */ && nz_();
                    }

                    IEnumerable<Encounter> nb_ = context.Operators.Where<Encounter>(mz_, na_);

                    object nc_(Encounter @this) {
                        Period se_ = @this?.Period;
                        CqlInterval<CqlDateTime> sf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, se_);
                        CqlDateTime sg_ = context.Operators.End(sf_);
                        return sg_;
                    }

                    IEnumerable<Encounter> nd_ = context.Operators.SortBy<Encounter>(nb_, nc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter ne_ = context.Operators.Last<Encounter>(nd_);
                    Period nf_ = ne_?.Period;
                    CqlInterval<CqlDateTime> ng_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nf_);
                    CqlDateTime nh_ = context.Operators.Start(ng_);
                    CqlValueSet ni_ = this.Observation_Services(context);
                    IEnumerable<Encounter> nj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ni_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? nk_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> sh_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? si_ = sh_?.Value;
                        Code<Encounter.EncounterStatus> sj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(si_);
                        CqlBoolean sk_ = context.Operators.Equal(sj_, "finished");

                        CqlBoolean sl_() {
                            Period sm_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> sn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sm_);
                            CqlDateTime so_ = context.Operators.End(sn_);
                            Period sp_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sp_);
                            CqlDateTime sr_ = context.Operators.Start(sq_);
                            CqlQuantity ss_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime st_ = context.Operators.Subtract(sr_, ss_);
                            CqlInterval<CqlDateTime> su_ = context.Operators.Interval(st_, sr_, true, true);
                            CqlBoolean sv_ = context.Operators.In<CqlDateTime>(so_, su_, (string)default);

                            CqlBoolean sw_() {
                                Period sx_ = Visit?.Period;
                                CqlInterval<CqlDateTime> sy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sx_);
                                CqlDateTime sz_ = context.Operators.Start(sy_);
                                return !((bool?)(sz_ is null));
                            }

                            return sv_
                                /* CQL 'and' (264:15-264:83) */ && sw_();
                        }

                        return sk_
                            /* CQL 'and' (263:6-264:83) */ && sl_();
                    }

                    IEnumerable<Encounter> nl_ = context.Operators.Where<Encounter>(nj_, nk_);

                    object nm_(Encounter @this) {
                        Period ta_ = @this?.Period;
                        CqlInterval<CqlDateTime> tb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ta_);
                        CqlDateTime tc_ = context.Operators.End(tb_);
                        return tc_;
                    }

                    IEnumerable<Encounter> nn_ = context.Operators.SortBy<Encounter>(nl_, nm_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter no_ = context.Operators.Last<Encounter>(nn_);
                    Period np_ = no_?.Period;
                    CqlInterval<CqlDateTime> nq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, np_);
                    CqlDateTime nr_ = context.Operators.Start(nq_);
                    Period ns_ = Visit?.Period;
                    CqlInterval<CqlDateTime> nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                    CqlDateTime nu_ = context.Operators.Start(nt_);
                    return !((bool?)((nh_ ?? nr_ ?? nu_) is null));
                }

                return cg_
                    /* CQL 'and' (275:6-275:81) */ && ch_();
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period td_ = @this?.Period;
                CqlInterval<CqlDateTime> te_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, td_);
                CqlDateTime tf_ = context.Operators.End(te_);
                return tf_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> tg_ = LastED?.StatusElement;
                Encounter.EncounterStatus? th_ = tg_?.Value;
                Code<Encounter.EncounterStatus> ti_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(th_);
                CqlBoolean tj_ = context.Operators.Equal(ti_, "finished");

                CqlBoolean tk_() {
                    Period tl_ = LastED?.Period;
                    CqlInterval<CqlDateTime> tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tl_);
                    CqlDateTime tn_ = context.Operators.End(tm_);
                    CqlValueSet to_ = this.Observation_Services(context);
                    IEnumerable<Encounter> tp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, to_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? tq_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> uo_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? up_ = uo_?.Value;
                        Code<Encounter.EncounterStatus> uq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(up_);
                        CqlBoolean ur_ = context.Operators.Equal(uq_, "finished");

                        CqlBoolean us_() {
                            Period ut_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                            CqlDateTime uv_ = context.Operators.End(uu_);
                            Period uw_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                            CqlDateTime uy_ = context.Operators.Start(ux_);
                            CqlQuantity uz_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime va_ = context.Operators.Subtract(uy_, uz_);
                            CqlInterval<CqlDateTime> vb_ = context.Operators.Interval(va_, uy_, true, true);
                            CqlBoolean vc_ = context.Operators.In<CqlDateTime>(uv_, vb_, (string)default);

                            CqlBoolean vd_() {
                                Period ve_ = Visit?.Period;
                                CqlInterval<CqlDateTime> vf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ve_);
                                CqlDateTime vg_ = context.Operators.Start(vf_);
                                return !((bool?)(vg_ is null));
                            }

                            return vc_
                                /* CQL 'and' (264:15-264:83) */ && vd_();
                        }

                        return ur_
                            /* CQL 'and' (263:6-264:83) */ && us_();
                    }

                    IEnumerable<Encounter> tr_ = context.Operators.Where<Encounter>(tp_, tq_);

                    object ts_(Encounter @this) {
                        Period vh_ = @this?.Period;
                        CqlInterval<CqlDateTime> vi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vh_);
                        CqlDateTime vj_ = context.Operators.End(vi_);
                        return vj_;
                    }

                    IEnumerable<Encounter> tt_ = context.Operators.SortBy<Encounter>(tr_, ts_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tu_ = context.Operators.Last<Encounter>(tt_);
                    Period tv_ = tu_?.Period;
                    CqlInterval<CqlDateTime> tw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tv_);
                    CqlDateTime tx_ = context.Operators.Start(tw_);
                    Period ty_ = Visit?.Period;
                    CqlInterval<CqlDateTime> tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                    CqlDateTime ua_ = context.Operators.Start(tz_);
                    CqlQuantity ub_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime uc_ = context.Operators.Subtract(tx_ ?? ua_, ub_);

                    bool? ud_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> vk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? vl_ = vk_?.Value;
                        Code<Encounter.EncounterStatus> vm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vl_);
                        CqlBoolean vn_ = context.Operators.Equal(vm_, "finished");

                        CqlBoolean vo_() {
                            Period vp_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> vq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vp_);
                            CqlDateTime vr_ = context.Operators.End(vq_);
                            Period vs_ = Visit?.Period;
                            CqlInterval<CqlDateTime> vt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vs_);
                            CqlDateTime vu_ = context.Operators.Start(vt_);
                            CqlQuantity vv_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime vw_ = context.Operators.Subtract(vu_, vv_);
                            CqlInterval<CqlDateTime> vx_ = context.Operators.Interval(vw_, vu_, true, true);
                            CqlBoolean vy_ = context.Operators.In<CqlDateTime>(vr_, vx_, (string)default);

                            CqlBoolean vz_() {
                                Period wa_ = Visit?.Period;
                                CqlInterval<CqlDateTime> wb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wa_);
                                CqlDateTime wc_ = context.Operators.Start(wb_);
                                return !((bool?)(wc_ is null));
                            }

                            return vy_
                                /* CQL 'and' (264:15-264:83) */ && vz_();
                        }

                        return vn_
                            /* CQL 'and' (263:6-264:83) */ && vo_();
                    }

                    IEnumerable<Encounter> ue_ = context.Operators.Where<Encounter>(tp_, ud_);

                    object uf_(Encounter @this) {
                        Period wd_ = @this?.Period;
                        CqlInterval<CqlDateTime> we_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wd_);
                        CqlDateTime wf_ = context.Operators.End(we_);
                        return wf_;
                    }

                    IEnumerable<Encounter> ug_ = context.Operators.SortBy<Encounter>(ue_, uf_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter uh_ = context.Operators.Last<Encounter>(ug_);
                    Period ui_ = uh_?.Period;
                    CqlInterval<CqlDateTime> uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime uk_ = context.Operators.Start(uj_);
                    CqlInterval<CqlDateTime> ul_ = context.Operators.Interval(uc_, uk_ ?? ua_, true, true);
                    CqlBoolean um_ = context.Operators.In<CqlDateTime>(tn_, ul_, (string)default);

                    CqlBoolean un_() {
                        CqlValueSet wg_ = this.Observation_Services(context);
                        IEnumerable<Encounter> wh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? wi_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> wt_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? wu_ = wt_?.Value;
                            Code<Encounter.EncounterStatus> wv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wu_);
                            CqlBoolean ww_ = context.Operators.Equal(wv_, "finished");

                            CqlBoolean wx_() {
                                Period wy_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> wz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wy_);
                                CqlDateTime xa_ = context.Operators.End(wz_);
                                Period xb_ = Visit?.Period;
                                CqlInterval<CqlDateTime> xc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xb_);
                                CqlDateTime xd_ = context.Operators.Start(xc_);
                                CqlQuantity xe_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime xf_ = context.Operators.Subtract(xd_, xe_);
                                CqlInterval<CqlDateTime> xg_ = context.Operators.Interval(xf_, xd_, true, true);
                                CqlBoolean xh_ = context.Operators.In<CqlDateTime>(xa_, xg_, (string)default);

                                CqlBoolean xi_() {
                                    Period xj_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> xk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xj_);
                                    CqlDateTime xl_ = context.Operators.Start(xk_);
                                    return !((bool?)(xl_ is null));
                                }

                                return xh_
                                    /* CQL 'and' (264:15-264:83) */ && xi_();
                            }

                            return ww_
                                /* CQL 'and' (263:6-264:83) */ && wx_();
                        }

                        IEnumerable<Encounter> wj_ = context.Operators.Where<Encounter>(wh_, wi_);

                        object wk_(Encounter @this) {
                            Period xm_ = @this?.Period;
                            CqlInterval<CqlDateTime> xn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xm_);
                            CqlDateTime xo_ = context.Operators.End(xn_);
                            return xo_;
                        }

                        IEnumerable<Encounter> wl_ = context.Operators.SortBy<Encounter>(wj_, wk_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter wm_ = context.Operators.Last<Encounter>(wl_);
                        Period wn_ = wm_?.Period;
                        CqlInterval<CqlDateTime> wo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wn_);
                        CqlDateTime wp_ = context.Operators.Start(wo_);
                        Period wq_ = Visit?.Period;
                        CqlInterval<CqlDateTime> wr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wq_);
                        CqlDateTime ws_ = context.Operators.Start(wr_);
                        return !((bool?)((wp_ ?? ws_) is null));
                    }

                    return um_
                        /* CQL 'and' (270:15-270:71) */ && un_();
                }

                return tj_
                    /* CQL 'and' (269:6-270:71) */ && tk_();
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period xp_ = @this?.Period;
                CqlInterval<CqlDateTime> xq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xp_);
                CqlDateTime xr_ = context.Operators.End(xq_);
                return xr_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> xs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? xt_ = xs_?.Value;
                Code<Encounter.EncounterStatus> xu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xt_);
                CqlBoolean xv_ = context.Operators.Equal(xu_, "finished");

                CqlBoolean xw_() {
                    Period xx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xx_);
                    CqlDateTime xz_ = context.Operators.End(xy_);
                    Period ya_ = Visit?.Period;
                    CqlInterval<CqlDateTime> yb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ya_);
                    CqlDateTime yc_ = context.Operators.Start(yb_);
                    CqlQuantity yd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ye_ = context.Operators.Subtract(yc_, yd_);
                    CqlInterval<CqlDateTime> yf_ = context.Operators.Interval(ye_, yc_, true, true);
                    CqlBoolean yg_ = context.Operators.In<CqlDateTime>(xz_, yf_, (string)default);

                    CqlBoolean yh_() {
                        Period yi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> yj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yi_);
                        CqlDateTime yk_ = context.Operators.Start(yj_);
                        return !((bool?)(yk_ is null));
                    }

                    return yg_
                        /* CQL 'and' (264:15-264:83) */ && yh_();
                }

                return xv_
                    /* CQL 'and' (263:6-264:83) */ && xw_();
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period yl_ = @this?.Period;
                CqlInterval<CqlDateTime> ym_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yl_);
                CqlDateTime yn_ = context.Operators.End(ym_);
                return yn_;
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

                CqlBoolean ah_() {
                    Period ai_ = LastED?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    CqlDateTime ak_ = context.Operators.End(aj_);
                    CqlValueSet al_ = this.Observation_Services(context);
                    IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? an_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> bl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bm_ = bl_?.Value;
                        Code<Encounter.EncounterStatus> bn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bm_);
                        CqlBoolean bo_ = context.Operators.Equal(bn_, "finished");

                        CqlBoolean bp_() {
                            Period bq_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                            CqlDateTime bs_ = context.Operators.End(br_);
                            Period bt_ = Visit?.Period;
                            CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                            CqlDateTime bv_ = context.Operators.Start(bu_);
                            CqlQuantity bw_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
                            CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bx_, bv_, true, true);
                            CqlBoolean bz_ = context.Operators.In<CqlDateTime>(bs_, by_, (string)default);

                            CqlBoolean ca_() {
                                Period cb_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                                CqlDateTime cd_ = context.Operators.Start(cc_);
                                return !((bool?)(cd_ is null));
                            }

                            return bz_
                                /* CQL 'and' (288:17-288:85) */ && ca_();
                        }

                        return bo_
                            /* CQL 'and' (287:7-288:85) */ && bp_();
                    }

                    IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(am_, an_);

                    object ap_(Encounter @this) {
                        Period ce_ = @this?.Period;
                        CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                        CqlDateTime cg_ = context.Operators.End(cf_);
                        return cg_;
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
                        Code<Encounter.EncounterStatus> ch_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ci_ = ch_?.Value;
                        Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                        CqlBoolean ck_ = context.Operators.Equal(cj_, "finished");

                        CqlBoolean cl_() {
                            Period cm_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                            CqlDateTime co_ = context.Operators.End(cn_);
                            Period cp_ = Visit?.Period;
                            CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                            CqlDateTime cr_ = context.Operators.Start(cq_);
                            CqlQuantity cs_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime ct_ = context.Operators.Subtract(cr_, cs_);
                            CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(ct_, cr_, true, true);
                            CqlBoolean cv_ = context.Operators.In<CqlDateTime>(co_, cu_, (string)default);

                            CqlBoolean cw_() {
                                Period cx_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                                CqlDateTime cz_ = context.Operators.Start(cy_);
                                return !((bool?)(cz_ is null));
                            }

                            return cv_
                                /* CQL 'and' (288:17-288:85) */ && cw_();
                        }

                        return ck_
                            /* CQL 'and' (287:7-288:85) */ && cl_();
                    }

                    IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(am_, ba_);

                    object bc_(Encounter @this) {
                        Period da_ = @this?.Period;
                        CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                        CqlDateTime dc_ = context.Operators.End(db_);
                        return dc_;
                    }

                    IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter be_ = context.Operators.Last<Encounter>(bd_);
                    Period bf_ = be_?.Period;
                    CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                    CqlDateTime bh_ = context.Operators.Start(bg_);
                    CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(az_, bh_ ?? ax_, true, true);
                    CqlBoolean bj_ = context.Operators.In<CqlDateTime>(ak_, bi_, (string)default);

                    CqlBoolean bk_() {
                        CqlValueSet dd_ = this.Observation_Services(context);
                        IEnumerable<Encounter> de_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? df_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dq_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dr_ = dq_?.Value;
                            Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                            CqlBoolean dt_ = context.Operators.Equal(ds_, "finished");

                            CqlBoolean du_() {
                                Period dv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.End(dw_);
                                Period dy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                                CqlDateTime ea_ = context.Operators.Start(dz_);
                                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                                CqlBoolean ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                                CqlBoolean ef_() {
                                    Period eg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                                    CqlDateTime ei_ = context.Operators.Start(eh_);
                                    return !((bool?)(ei_ is null));
                                }

                                return ee_
                                    /* CQL 'and' (288:17-288:85) */ && ef_();
                            }

                            return dt_
                                /* CQL 'and' (287:7-288:85) */ && du_();
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.Where<Encounter>(de_, df_);

                        object dh_(Encounter @this) {
                            Period ej_ = @this?.Period;
                            CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                            CqlDateTime el_ = context.Operators.End(ek_);
                            return el_;
                        }

                        IEnumerable<Encounter> di_ = context.Operators.SortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dj_ = context.Operators.Last<Encounter>(di_);
                        Period dk_ = dj_?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        Period dn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                        CqlDateTime dp_ = context.Operators.Start(do_);
                        return !((bool?)((dm_ ?? dp_) is null));
                    }

                    return bj_
                        /* CQL 'and' (294:17-294:73) */ && bk_();
                }

                return ag_
                    /* CQL 'and' (293:7-294:73) */ && ah_();
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> ep_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eq_ = ep_?.Value;
                Code<Encounter.EncounterStatus> er_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eq_);
                CqlBoolean es_ = context.Operators.Equal(er_, "finished");

                CqlBoolean et_() {
                    Period eu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                    CqlDateTime ew_ = context.Operators.End(ev_);
                    Period ex_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                    CqlDateTime ez_ = context.Operators.Start(ey_);
                    CqlQuantity fa_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fb_ = context.Operators.Subtract(ez_, fa_);
                    CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(fb_, ez_, true, true);
                    CqlBoolean fd_ = context.Operators.In<CqlDateTime>(ew_, fc_, (string)default);

                    CqlBoolean fe_() {
                        Period ff_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ff_);
                        CqlDateTime fh_ = context.Operators.Start(fg_);
                        return !((bool?)(fh_ is null));
                    }

                    return fd_
                        /* CQL 'and' (288:17-288:85) */ && fe_();
                }

                return es_
                    /* CQL 'and' (287:7-288:85) */ && et_();
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fi_ = @this?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.End(fj_);
                return fk_;
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

                CqlBoolean ah_() {
                    Period ai_ = LastED?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    CqlDateTime ak_ = context.Operators.End(aj_);
                    CqlValueSet al_ = this.Observation_Services(context);
                    IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? an_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> bl_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bm_ = bl_?.Value;
                        Code<Encounter.EncounterStatus> bn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bm_);
                        CqlBoolean bo_ = context.Operators.Equal(bn_, "finished");

                        CqlBoolean bp_() {
                            Period bq_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                            CqlDateTime bs_ = context.Operators.End(br_);
                            Period bt_ = Visit?.Period;
                            CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                            CqlDateTime bv_ = context.Operators.Start(bu_);
                            CqlQuantity bw_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
                            CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bx_, bv_, true, true);
                            CqlBoolean bz_ = context.Operators.In<CqlDateTime>(bs_, by_, (string)default);

                            CqlBoolean ca_() {
                                Period cb_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                                CqlDateTime cd_ = context.Operators.Start(cc_);
                                return !((bool?)(cd_ is null));
                            }

                            return bz_
                                /* CQL 'and' (306:17-306:85) */ && ca_();
                        }

                        return bo_
                            /* CQL 'and' (305:7-306:85) */ && bp_();
                    }

                    IEnumerable<Encounter> ao_ = context.Operators.Where<Encounter>(am_, an_);

                    object ap_(Encounter @this) {
                        Period ce_ = @this?.Period;
                        CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                        CqlDateTime cg_ = context.Operators.End(cf_);
                        return cg_;
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
                        Code<Encounter.EncounterStatus> ch_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ci_ = ch_?.Value;
                        Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                        CqlBoolean ck_ = context.Operators.Equal(cj_, "finished");

                        CqlBoolean cl_() {
                            Period cm_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                            CqlDateTime co_ = context.Operators.End(cn_);
                            Period cp_ = Visit?.Period;
                            CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                            CqlDateTime cr_ = context.Operators.Start(cq_);
                            CqlQuantity cs_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime ct_ = context.Operators.Subtract(cr_, cs_);
                            CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(ct_, cr_, true, true);
                            CqlBoolean cv_ = context.Operators.In<CqlDateTime>(co_, cu_, (string)default);

                            CqlBoolean cw_() {
                                Period cx_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                                CqlDateTime cz_ = context.Operators.Start(cy_);
                                return !((bool?)(cz_ is null));
                            }

                            return cv_
                                /* CQL 'and' (306:17-306:85) */ && cw_();
                        }

                        return ck_
                            /* CQL 'and' (305:7-306:85) */ && cl_();
                    }

                    IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(am_, ba_);

                    object bc_(Encounter @this) {
                        Period da_ = @this?.Period;
                        CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, da_);
                        CqlDateTime dc_ = context.Operators.End(db_);
                        return dc_;
                    }

                    IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter be_ = context.Operators.Last<Encounter>(bd_);
                    Period bf_ = be_?.Period;
                    CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                    CqlDateTime bh_ = context.Operators.Start(bg_);
                    CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(az_, bh_ ?? ax_, true, true);
                    CqlBoolean bj_ = context.Operators.In<CqlDateTime>(ak_, bi_, (string)default);

                    CqlBoolean bk_() {
                        CqlValueSet dd_ = this.Observation_Services(context);
                        IEnumerable<Encounter> de_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? df_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dq_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dr_ = dq_?.Value;
                            Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                            CqlBoolean dt_ = context.Operators.Equal(ds_, "finished");

                            CqlBoolean du_() {
                                Period dv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.End(dw_);
                                Period dy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                                CqlDateTime ea_ = context.Operators.Start(dz_);
                                CqlQuantity eb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime ec_ = context.Operators.Subtract(ea_, eb_);
                                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(ec_, ea_, true, true);
                                CqlBoolean ee_ = context.Operators.In<CqlDateTime>(dx_, ed_, (string)default);

                                CqlBoolean ef_() {
                                    Period eg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                                    CqlDateTime ei_ = context.Operators.Start(eh_);
                                    return !((bool?)(ei_ is null));
                                }

                                return ee_
                                    /* CQL 'and' (306:17-306:85) */ && ef_();
                            }

                            return dt_
                                /* CQL 'and' (305:7-306:85) */ && du_();
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.Where<Encounter>(de_, df_);

                        object dh_(Encounter @this) {
                            Period ej_ = @this?.Period;
                            CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                            CqlDateTime el_ = context.Operators.End(ek_);
                            return el_;
                        }

                        IEnumerable<Encounter> di_ = context.Operators.SortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dj_ = context.Operators.Last<Encounter>(di_);
                        Period dk_ = dj_?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        Period dn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                        CqlDateTime dp_ = context.Operators.Start(do_);
                        return !((bool?)((dm_ ?? dp_) is null));
                    }

                    return bj_
                        /* CQL 'and' (312:17-312:73) */ && bk_();
                }

                return ag_
                    /* CQL 'and' (311:7-312:73) */ && ah_();
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> ep_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eq_ = ep_?.Value;
                Code<Encounter.EncounterStatus> er_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eq_);
                CqlBoolean es_ = context.Operators.Equal(er_, "finished");

                CqlBoolean et_() {
                    Period eu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                    CqlDateTime ew_ = context.Operators.End(ev_);
                    Period ex_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                    CqlDateTime ez_ = context.Operators.Start(ey_);
                    CqlQuantity fa_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime fb_ = context.Operators.Subtract(ez_, fa_);
                    CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(fb_, ez_, true, true);
                    CqlBoolean fd_ = context.Operators.In<CqlDateTime>(ew_, fc_, (string)default);

                    CqlBoolean fe_() {
                        Period ff_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ff_);
                        CqlDateTime fh_ = context.Operators.Start(fg_);
                        return !((bool?)(fh_ is null));
                    }

                    return fd_
                        /* CQL 'and' (306:17-306:85) */ && fe_();
                }

                return es_
                    /* CQL 'and' (305:7-306:85) */ && et_();
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fi_ = @this?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.End(fj_);
                return fk_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);

            CqlBoolean n_() {
                Period p_ = Encounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                Period r_ = HospitalLocation?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlBoolean t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, (string)default);
                return t_;
            }

            return m_
                /* CQL 'and' (336:6-337:57) */ && n_();
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);

            CqlBoolean n_() {
                Period p_ = Encounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                Period r_ = HospitalLocation?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlBoolean t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, (string)default);
                return t_;
            }

            return m_
                /* CQL 'and' (346:6-347:57) */ && n_();
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

            CqlBoolean j_() {
                CodeableConcept k_ = D?.Use;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlCode m_ = this.Billing(context);
                CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                CqlBoolean o_ = context.Operators.Equivalent(l_, n_);
                return o_;
            }

            return i_
                /* CQL 'and' (386:25-386:62) */ && j_();
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

                CqlBoolean r_() {
                    Code<ClaimUseCode> t_ = C?.UseElement;
                    ClaimUseCode? u_ = t_?.Value;
                    Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                    CqlBoolean w_ = context.Operators.Equal(v_, "claim");
                    return w_;
                }


                CqlBoolean s_() {
                    List<Claim.ItemComponent> x_ = C?.Item;

                    bool? y_(Claim.ItemComponent I) {
                        List<ResourceReference> aa_ = I?.Encounter;
                        CqlBoolean ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aa_, E);
                        return ab_;
                    }

                    CqlBoolean z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                    return z_;
                }

                return q_
                    /* CQL 'and' (406:31-406:69) */ && r_()
                    /* CQL 'and' (406:25-406:123) */ && s_();
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                return !((bool?)(ac_ is null));
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

                    CqlBoolean ay_() {
                        Code<ClaimUseCode> ba_ = C?.UseElement;
                        ClaimUseCode? bb_ = ba_?.Value;
                        Code<ClaimUseCode> bc_ = context.Operators.Convert<Code<ClaimUseCode>>(bb_);
                        CqlBoolean bd_ = context.Operators.Equal(bc_, "claim");
                        return bd_;
                    }


                    CqlBoolean az_() {
                        List<Claim.ItemComponent> be_ = C?.Item;

                        bool? bf_(Claim.ItemComponent I) {
                            List<ResourceReference> bh_ = I?.Encounter;
                            CqlBoolean bi_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bh_, E);
                            return bi_;
                        }

                        CqlBoolean bg_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)be_, bf_);
                        return bg_;
                    }

                    return ax_
                        /* CQL 'and' (406:31-406:69) */ && ay_()
                        /* CQL 'and' (406:25-406:123) */ && az_();
                }

                IEnumerable<Claim> ai_ = context.Operators.Where<Claim>(ag_, ah_);

                bool? aj_(Claim @this) {
                    List<Claim.ItemComponent> bj_ = @this?.Item;
                    return !((bool?)(bj_ is null));
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
                    return !((bool?)(bp_ is null));
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

            CqlBoolean i_() {
                DataType j_ = PD?.Diagnosis;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                Condition l_ = this.getCondition(context, k_ as ResourceReference);
                CodeableConcept m_ = l_?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlBoolean o_ = context.Operators.ConceptInValueSet(n_, valueSet);
                return o_;
            }

            return h_
                /* CQL 'or' (417:13-418:54) */ || i_();
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

            CqlBoolean g_() {
                DataType h_ = CD?.Diagnosis;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlBoolean j_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, diagnosisValueSet);

                CqlBoolean k_() {
                    DataType l_ = CD?.Diagnosis;
                    object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                    Condition n_ = this.getCondition(context, m_ as ResourceReference);
                    CodeableConcept o_ = n_?.Code;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                    CqlBoolean q_ = context.Operators.ConceptInValueSet(p_, diagnosisValueSet);
                    return q_;
                }

                return j_
                    /* CQL 'or' (428:14-431:10) */ || k_();
            }

            return f_
                /* CQL 'and' (427:8-431:10) */ && g_();
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

                CqlBoolean s_() {
                    Code<ClaimUseCode> u_ = C?.UseElement;
                    ClaimUseCode? v_ = u_?.Value;
                    Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                    CqlBoolean x_ = context.Operators.Equal(w_, "claim");
                    return x_;
                }


                CqlBoolean t_() {
                    List<Claim.ItemComponent> y_ = C?.Item;

                    bool? z_(Claim.ItemComponent I) {
                        List<ResourceReference> ab_ = I?.Encounter;
                        CqlBoolean ac_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ab_, E);
                        return ac_;
                    }

                    CqlBoolean aa_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                    return aa_;
                }

                return r_
                    /* CQL 'and' (476:32-476:70) */ && s_()
                    /* CQL 'and' (476:26-476:124) */ && t_();
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.ProcedureComponent> ad_ = @this?.Procedure;
                return !((bool?)(ad_ is null));
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
                    Code<FinancialResourceStatusCodes> aw_ = C?.StatusElement;
                    FinancialResourceStatusCodes? ax_ = aw_?.Value;
                    Code<FinancialResourceStatusCodes> ay_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(ax_);
                    CqlBoolean az_ = context.Operators.Equal(ay_, "active");

                    CqlBoolean ba_() {
                        Code<ClaimUseCode> bc_ = C?.UseElement;
                        ClaimUseCode? bd_ = bc_?.Value;
                        Code<ClaimUseCode> be_ = context.Operators.Convert<Code<ClaimUseCode>>(bd_);
                        CqlBoolean bf_ = context.Operators.Equal(be_, "claim");
                        return bf_;
                    }


                    CqlBoolean bb_() {
                        List<Claim.ItemComponent> bg_ = C?.Item;

                        bool? bh_(Claim.ItemComponent I) {
                            List<ResourceReference> bj_ = I?.Encounter;
                            CqlBoolean bk_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bj_, E);
                            return bk_;
                        }

                        CqlBoolean bi_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bg_, bh_);
                        return bi_;
                    }

                    return az_
                        /* CQL 'and' (476:32-476:70) */ && ba_()
                        /* CQL 'and' (476:26-476:124) */ && bb_();
                }

                IEnumerable<Claim> aj_ = context.Operators.Where<Claim>(ah_, ai_);

                bool? ak_(Claim @this) {
                    List<Claim.ItemComponent> bl_ = @this?.Item;
                    return !((bool?)(bl_ is null));
                }


                List<Claim.ItemComponent> al_(Claim @this) {
                    List<Claim.ItemComponent> bm_ = @this?.Item;
                    return bm_;
                }

                IEnumerable<List<Claim.ItemComponent>> am_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(aj_, ak_, al_);
                IEnumerable<Claim.ItemComponent> an_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)am_);

                bool? ao_(Claim.ItemComponent I) {
                    List<ResourceReference> bn_ = I?.Encounter;
                    CqlBoolean bo_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bn_, E);
                    return bo_;
                }

                IEnumerable<Claim.ItemComponent> ap_ = context.Operators.Where<Claim.ItemComponent>(an_, ao_);

                bool? aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> bp_ = @this?.ProcedureSequenceElement;

                    int? bq_(PositiveInt @this) {
                        int? bs_ = @this?.Value;
                        return bs_;
                    }

                    IEnumerable<int?> br_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bp_, bq_);
                    return !((bool?)(br_ is null));
                }


                IEnumerable<int?> ar_(Claim.ItemComponent @this) {
                    List<PositiveInt> bt_ = @this?.ProcedureSequenceElement;

                    int? bu_(PositiveInt @this) {
                        int? bw_ = @this?.Value;
                        return bw_;
                    }

                    IEnumerable<int?> bv_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bt_, bu_);
                    return bv_;
                }

                IEnumerable<IEnumerable<int?>> as_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ap_, aq_, ar_);
                IEnumerable<int?> at_ = context.Operators.Flatten<int?>(as_);
                CqlBoolean au_ = context.Operators.In<int?>(ag_, at_);

                CqlBoolean av_() {
                    List<CodeableConcept> bx_ = P?.Type;

                    CqlConcept by_(CodeableConcept @this) {
                        CqlConcept cc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return cc_;
                    }

                    IEnumerable<CqlConcept> bz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bx_, by_);
                    CqlCode ca_ = this.Primary_procedure(context);
                    CqlBoolean cb_ = QICoreCommon_4_0_000.Instance.includesCode(context, bz_, ca_);
                    return cb_;
                }

                return au_
                    /* CQL 'and' (478:59-478:150) */ && av_();
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
