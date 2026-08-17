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
            // CQL 'and' (46:5-47:75): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                Period i_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
                return h_ & m_;
            }
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
            // CQL 'and' (79:7-80:88): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
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
                bool? v_;
                // CQL 'and' (80:13-80:88): right operand skipped when left is false
                if (u_ is false)
                {
                    v_ = false;
                }
                else
                {
                    v_ = u_ & (!((bool?)(q_ is null)));
                }
                return k_ & v_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period w_ = @this?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.End(x_);
            return y_;
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
            // CQL 'and' (90:7-91:88): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
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
                bool? v_;
                // CQL 'and' (91:13-91:88): right operand skipped when left is false
                if (u_ is false)
                {
                    v_ = false;
                }
                else
                {
                    v_ = u_ & (!((bool?)(q_ is null)));
                }
                return k_ & v_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period w_ = @this?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.End(x_);
            return y_;
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
            CqlValueSet e_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastSurgeryOP) {
                Period an_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.End(ao_);
                CqlValueSet aq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? as_(Encounter LastED) {
                    Code<Encounter.EncounterStatus> ch_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ci_ = ch_?.Value;
                    Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                    bool? ck_ = context.Operators.Equal(cj_, "finished");
                    // CQL 'and' (246:6-247:71): right operand skipped when left is false
                    if (ck_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period cl_ = LastED?.Period;
                        CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                        CqlDateTime cn_ = context.Operators.End(cm_);
                        CqlValueSet co_ = this.Observation_Services(context);
                        IEnumerable<Encounter> cp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? cq_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> do_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dp_ = do_?.Value;
                            Code<Encounter.EncounterStatus> dq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dp_);
                            bool? dr_ = context.Operators.Equal(dq_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (dr_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period ds_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ds_);
                                CqlDateTime du_ = context.Operators.End(dt_);
                                Period dv_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.Start(dw_);
                                CqlQuantity dy_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dz_ = context.Operators.Subtract(dx_, dy_);
                                CqlInterval<CqlDateTime> ea_ = context.Operators.Interval(dz_, dx_, true, true);
                                bool? eb_ = context.Operators.In<CqlDateTime>(du_, ea_, (string)default);
                                bool? ec_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (eb_ is false)
                                {
                                    ec_ = false;
                                }
                                else
                                {
                                    ec_ = eb_ & (!((bool?)(dx_ is null)));
                                }
                                return dr_ & ec_;
                            }
                        }

                        IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                        object cs_(Encounter @this) {
                            Period ed_ = @this?.Period;
                            CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                            CqlDateTime ef_ = context.Operators.End(ee_);
                            return ef_;
                        }

                        IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                        Period cv_ = cu_?.Period;
                        CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                        CqlDateTime cx_ = context.Operators.Start(cw_);
                        Period cy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                        CqlDateTime da_ = context.Operators.Start(cz_);
                        CqlQuantity db_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dc_ = context.Operators.Subtract(cx_ ?? da_, db_);

                        bool? dd_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? eh_ = eg_?.Value;
                            Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
                            bool? ej_ = context.Operators.Equal(ei_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (ej_ is false)
                            {
                                return false;
                            }
                            else
                            {
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
                                bool? eu_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (et_ is false)
                                {
                                    eu_ = false;
                                }
                                else
                                {
                                    eu_ = et_ & (!((bool?)(ep_ is null)));
                                }
                                return ej_ & eu_;
                            }
                        }

                        IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(cp_, dd_);

                        object df_(Encounter @this) {
                            Period ev_ = @this?.Period;
                            CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                            CqlDateTime ex_ = context.Operators.End(ew_);
                            return ex_;
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.SortBy<Encounter>(de_, df_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dh_ = context.Operators.Last<Encounter>(dg_);
                        Period di_ = dh_?.Period;
                        CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                        CqlDateTime dk_ = context.Operators.Start(dj_);
                        CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dc_, dk_ ?? da_, true, true);
                        bool? dm_ = context.Operators.In<CqlDateTime>(cn_, dl_, (string)default);
                        bool? dn_;
                        // CQL 'and' (247:15-247:71): right operand skipped when left is false
                        if (dm_ is false)
                        {
                            dn_ = false;
                        }
                        else
                        {

                            bool? ey_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fg_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fh_ = fg_?.Value;
                                Code<Encounter.EncounterStatus> fi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fh_);
                                bool? fj_ = context.Operators.Equal(fi_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (fj_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period fk_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> fl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fk_);
                                    CqlDateTime fm_ = context.Operators.End(fl_);
                                    Period fn_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                                    CqlDateTime fp_ = context.Operators.Start(fo_);
                                    CqlQuantity fq_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime fr_ = context.Operators.Subtract(fp_, fq_);
                                    CqlInterval<CqlDateTime> fs_ = context.Operators.Interval(fr_, fp_, true, true);
                                    bool? ft_ = context.Operators.In<CqlDateTime>(fm_, fs_, (string)default);
                                    bool? fu_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (ft_ is false)
                                    {
                                        fu_ = false;
                                    }
                                    else
                                    {
                                        fu_ = ft_ & (!((bool?)(fp_ is null)));
                                    }
                                    return fj_ & fu_;
                                }
                            }

                            IEnumerable<Encounter> ez_ = context.Operators.Where<Encounter>(cp_, ey_);

                            object fa_(Encounter @this) {
                                Period fv_ = @this?.Period;
                                CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                                CqlDateTime fx_ = context.Operators.End(fw_);
                                return fx_;
                            }

                            IEnumerable<Encounter> fb_ = context.Operators.SortBy<Encounter>(ez_, fa_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fc_ = context.Operators.Last<Encounter>(fb_);
                            Period fd_ = fc_?.Period;
                            CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                            CqlDateTime ff_ = context.Operators.Start(fe_);
                            dn_ = dm_ & (!((bool?)((ff_ ?? da_) is null)));
                        }
                        return ck_ & dn_;
                    }
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period fy_ = @this?.Period;
                    CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                    CqlDateTime ga_ = context.Operators.End(fz_);
                    return ga_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gc_ = gb_?.Value;
                    Code<Encounter.EncounterStatus> gd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gc_);
                    bool? ge_ = context.Operators.Equal(gd_, "finished");
                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                    if (ge_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gf_);
                        CqlDateTime gh_ = context.Operators.End(gg_);
                        Period gi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gi_);
                        CqlDateTime gk_ = context.Operators.Start(gj_);
                        CqlQuantity gl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gm_ = context.Operators.Subtract(gk_, gl_);
                        CqlInterval<CqlDateTime> gn_ = context.Operators.Interval(gm_, gk_, true, true);
                        bool? go_ = context.Operators.In<CqlDateTime>(gh_, gn_, (string)default);
                        bool? gp_;
                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                        if (go_ is false)
                        {
                            gp_ = false;
                        }
                        else
                        {
                            gp_ = go_ & (!((bool?)(gk_ is null)));
                        }
                        return ge_ & gp_;
                    }
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period gq_ = @this?.Period;
                    CqlInterval<CqlDateTime> gr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                    CqlDateTime gs_ = context.Operators.End(gr_);
                    return gs_;
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
                    Code<Encounter.EncounterStatus> gt_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? gu_ = gt_?.Value;
                    Code<Encounter.EncounterStatus> gv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gu_);
                    bool? gw_ = context.Operators.Equal(gv_, "finished");
                    // CQL 'and' (246:6-247:71): right operand skipped when left is false
                    if (gw_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gx_ = LastED?.Period;
                        CqlInterval<CqlDateTime> gy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gx_);
                        CqlDateTime gz_ = context.Operators.End(gy_);
                        CqlValueSet ha_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ha_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? hc_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ia_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? ib_ = ia_?.Value;
                            Code<Encounter.EncounterStatus> ic_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ib_);
                            bool? id_ = context.Operators.Equal(ic_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (id_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period ie_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> if_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ie_);
                                CqlDateTime ig_ = context.Operators.End(if_);
                                Period ih_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ii_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                                CqlDateTime ij_ = context.Operators.Start(ii_);
                                CqlQuantity ik_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime il_ = context.Operators.Subtract(ij_, ik_);
                                CqlInterval<CqlDateTime> im_ = context.Operators.Interval(il_, ij_, true, true);
                                bool? in_ = context.Operators.In<CqlDateTime>(ig_, im_, (string)default);
                                bool? io_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (in_ is false)
                                {
                                    io_ = false;
                                }
                                else
                                {
                                    io_ = in_ & (!((bool?)(ij_ is null)));
                                }
                                return id_ & io_;
                            }
                        }

                        IEnumerable<Encounter> hd_ = context.Operators.Where<Encounter>(hb_, hc_);

                        object he_(Encounter @this) {
                            Period ip_ = @this?.Period;
                            CqlInterval<CqlDateTime> iq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ip_);
                            CqlDateTime ir_ = context.Operators.End(iq_);
                            return ir_;
                        }

                        IEnumerable<Encounter> hf_ = context.Operators.SortBy<Encounter>(hd_, he_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter hg_ = context.Operators.Last<Encounter>(hf_);
                        Period hh_ = hg_?.Period;
                        CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hh_);
                        CqlDateTime hj_ = context.Operators.Start(hi_);
                        Period hk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hk_);
                        CqlDateTime hm_ = context.Operators.Start(hl_);
                        CqlQuantity hn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ho_ = context.Operators.Subtract(hj_ ?? hm_, hn_);

                        bool? hp_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> is_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? it_ = is_?.Value;
                            Code<Encounter.EncounterStatus> iu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(it_);
                            bool? iv_ = context.Operators.Equal(iu_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (iv_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period iw_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ix_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iw_);
                                CqlDateTime iy_ = context.Operators.End(ix_);
                                Period iz_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ja_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iz_);
                                CqlDateTime jb_ = context.Operators.Start(ja_);
                                CqlQuantity jc_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jd_ = context.Operators.Subtract(jb_, jc_);
                                CqlInterval<CqlDateTime> je_ = context.Operators.Interval(jd_, jb_, true, true);
                                bool? jf_ = context.Operators.In<CqlDateTime>(iy_, je_, (string)default);
                                bool? jg_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (jf_ is false)
                                {
                                    jg_ = false;
                                }
                                else
                                {
                                    jg_ = jf_ & (!((bool?)(jb_ is null)));
                                }
                                return iv_ & jg_;
                            }
                        }

                        IEnumerable<Encounter> hq_ = context.Operators.Where<Encounter>(hb_, hp_);

                        object hr_(Encounter @this) {
                            Period jh_ = @this?.Period;
                            CqlInterval<CqlDateTime> ji_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jh_);
                            CqlDateTime jj_ = context.Operators.End(ji_);
                            return jj_;
                        }

                        IEnumerable<Encounter> hs_ = context.Operators.SortBy<Encounter>(hq_, hr_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ht_ = context.Operators.Last<Encounter>(hs_);
                        Period hu_ = ht_?.Period;
                        CqlInterval<CqlDateTime> hv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hu_);
                        CqlDateTime hw_ = context.Operators.Start(hv_);
                        CqlInterval<CqlDateTime> hx_ = context.Operators.Interval(ho_, hw_ ?? hm_, true, true);
                        bool? hy_ = context.Operators.In<CqlDateTime>(gz_, hx_, (string)default);
                        bool? hz_;
                        // CQL 'and' (247:15-247:71): right operand skipped when left is false
                        if (hy_ is false)
                        {
                            hz_ = false;
                        }
                        else
                        {

                            bool? jk_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> js_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? jt_ = js_?.Value;
                                Code<Encounter.EncounterStatus> ju_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jt_);
                                bool? jv_ = context.Operators.Equal(ju_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (jv_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period jw_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> jx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jw_);
                                    CqlDateTime jy_ = context.Operators.End(jx_);
                                    Period jz_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jz_);
                                    CqlDateTime kb_ = context.Operators.Start(ka_);
                                    CqlQuantity kc_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime kd_ = context.Operators.Subtract(kb_, kc_);
                                    CqlInterval<CqlDateTime> ke_ = context.Operators.Interval(kd_, kb_, true, true);
                                    bool? kf_ = context.Operators.In<CqlDateTime>(jy_, ke_, (string)default);
                                    bool? kg_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (kf_ is false)
                                    {
                                        kg_ = false;
                                    }
                                    else
                                    {
                                        kg_ = kf_ & (!((bool?)(kb_ is null)));
                                    }
                                    return jv_ & kg_;
                                }
                            }

                            IEnumerable<Encounter> jl_ = context.Operators.Where<Encounter>(hb_, jk_);

                            object jm_(Encounter @this) {
                                Period kh_ = @this?.Period;
                                CqlInterval<CqlDateTime> ki_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kh_);
                                CqlDateTime kj_ = context.Operators.End(ki_);
                                return kj_;
                            }

                            IEnumerable<Encounter> jn_ = context.Operators.SortBy<Encounter>(jl_, jm_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter jo_ = context.Operators.Last<Encounter>(jn_);
                            Period jp_ = jo_?.Period;
                            CqlInterval<CqlDateTime> jq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jp_);
                            CqlDateTime jr_ = context.Operators.Start(jq_);
                            hz_ = hy_ & (!((bool?)((jr_ ?? hm_) is null)));
                        }
                        return gw_ & hz_;
                    }
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period kk_ = @this?.Period;
                    CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                    CqlDateTime km_ = context.Operators.End(kl_);
                    return km_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> kn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ko_ = kn_?.Value;
                    Code<Encounter.EncounterStatus> kp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ko_);
                    bool? kq_ = context.Operators.Equal(kp_, "finished");
                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                    if (kq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period kr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ks_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kr_);
                        CqlDateTime kt_ = context.Operators.End(ks_);
                        Period ku_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ku_);
                        CqlDateTime kw_ = context.Operators.Start(kv_);
                        CqlQuantity kx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ky_ = context.Operators.Subtract(kw_, kx_);
                        CqlInterval<CqlDateTime> kz_ = context.Operators.Interval(ky_, kw_, true, true);
                        bool? la_ = context.Operators.In<CqlDateTime>(kt_, kz_, (string)default);
                        bool? lb_;
                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                        if (la_ is false)
                        {
                            lb_ = false;
                        }
                        else
                        {
                            lb_ = la_ & (!((bool?)(kw_ is null)));
                        }
                        return kq_ & lb_;
                    }
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period lc_ = @this?.Period;
                    CqlInterval<CqlDateTime> ld_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lc_);
                    CqlDateTime le_ = context.Operators.End(ld_);
                    return le_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                bool? cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);
                // CQL 'and' (252:6-252:81): right operand skipped when left is false
                if (cg_ is false)
                {
                    return false;
                }
                else
                {

                    bool? lf_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> lv_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? lw_ = lv_?.Value;
                        Code<Encounter.EncounterStatus> lx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lw_);
                        bool? ly_ = context.Operators.Equal(lx_, "finished");
                        // CQL 'and' (246:6-247:71): right operand skipped when left is false
                        if (ly_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period lz_ = LastED?.Period;
                            CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                            CqlDateTime mb_ = context.Operators.End(ma_);
                            CqlValueSet mc_ = this.Observation_Services(context);
                            IEnumerable<Encounter> md_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? me_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> nc_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? nd_ = nc_?.Value;
                                Code<Encounter.EncounterStatus> ne_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nd_);
                                bool? nf_ = context.Operators.Equal(ne_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (nf_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ng_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ng_);
                                    CqlDateTime ni_ = context.Operators.End(nh_);
                                    Period nj_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> nk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nj_);
                                    CqlDateTime nl_ = context.Operators.Start(nk_);
                                    CqlQuantity nm_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime nn_ = context.Operators.Subtract(nl_, nm_);
                                    CqlInterval<CqlDateTime> no_ = context.Operators.Interval(nn_, nl_, true, true);
                                    bool? np_ = context.Operators.In<CqlDateTime>(ni_, no_, (string)default);
                                    bool? nq_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (np_ is false)
                                    {
                                        nq_ = false;
                                    }
                                    else
                                    {
                                        nq_ = np_ & (!((bool?)(nl_ is null)));
                                    }
                                    return nf_ & nq_;
                                }
                            }

                            IEnumerable<Encounter> mf_ = context.Operators.Where<Encounter>(md_, me_);

                            object mg_(Encounter @this) {
                                Period nr_ = @this?.Period;
                                CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nr_);
                                CqlDateTime nt_ = context.Operators.End(ns_);
                                return nt_;
                            }

                            IEnumerable<Encounter> mh_ = context.Operators.SortBy<Encounter>(mf_, mg_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter mi_ = context.Operators.Last<Encounter>(mh_);
                            Period mj_ = mi_?.Period;
                            CqlInterval<CqlDateTime> mk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mj_);
                            CqlDateTime ml_ = context.Operators.Start(mk_);
                            Period mm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mm_);
                            CqlDateTime mo_ = context.Operators.Start(mn_);
                            CqlQuantity mp_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime mq_ = context.Operators.Subtract(ml_ ?? mo_, mp_);

                            bool? mr_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> nu_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? nv_ = nu_?.Value;
                                Code<Encounter.EncounterStatus> nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
                                bool? nx_ = context.Operators.Equal(nw_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (nx_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ny_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ny_);
                                    CqlDateTime oa_ = context.Operators.End(nz_);
                                    Period ob_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ob_);
                                    CqlDateTime od_ = context.Operators.Start(oc_);
                                    CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime of_ = context.Operators.Subtract(od_, oe_);
                                    CqlInterval<CqlDateTime> og_ = context.Operators.Interval(of_, od_, true, true);
                                    bool? oh_ = context.Operators.In<CqlDateTime>(oa_, og_, (string)default);
                                    bool? oi_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (oh_ is false)
                                    {
                                        oi_ = false;
                                    }
                                    else
                                    {
                                        oi_ = oh_ & (!((bool?)(od_ is null)));
                                    }
                                    return nx_ & oi_;
                                }
                            }

                            IEnumerable<Encounter> ms_ = context.Operators.Where<Encounter>(md_, mr_);

                            object mt_(Encounter @this) {
                                Period oj_ = @this?.Period;
                                CqlInterval<CqlDateTime> ok_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oj_);
                                CqlDateTime ol_ = context.Operators.End(ok_);
                                return ol_;
                            }

                            IEnumerable<Encounter> mu_ = context.Operators.SortBy<Encounter>(ms_, mt_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter mv_ = context.Operators.Last<Encounter>(mu_);
                            Period mw_ = mv_?.Period;
                            CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mw_);
                            CqlDateTime my_ = context.Operators.Start(mx_);
                            CqlInterval<CqlDateTime> mz_ = context.Operators.Interval(mq_, my_ ?? mo_, true, true);
                            bool? na_ = context.Operators.In<CqlDateTime>(mb_, mz_, (string)default);
                            bool? nb_;
                            // CQL 'and' (247:15-247:71): right operand skipped when left is false
                            if (na_ is false)
                            {
                                nb_ = false;
                            }
                            else
                            {

                                bool? om_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> ou_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? ov_ = ou_?.Value;
                                    Code<Encounter.EncounterStatus> ow_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ov_);
                                    bool? ox_ = context.Operators.Equal(ow_, "finished");
                                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                    if (ox_ is false)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        Period oy_ = LastObs?.Period;
                                        CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oy_);
                                        CqlDateTime pa_ = context.Operators.End(oz_);
                                        Period pb_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> pc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pb_);
                                        CqlDateTime pd_ = context.Operators.Start(pc_);
                                        CqlQuantity pe_ = context.Operators.Quantity(1m, "hour");
                                        CqlDateTime pf_ = context.Operators.Subtract(pd_, pe_);
                                        CqlInterval<CqlDateTime> pg_ = context.Operators.Interval(pf_, pd_, true, true);
                                        bool? ph_ = context.Operators.In<CqlDateTime>(pa_, pg_, (string)default);
                                        bool? pi_;
                                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                        if (ph_ is false)
                                        {
                                            pi_ = false;
                                        }
                                        else
                                        {
                                            pi_ = ph_ & (!((bool?)(pd_ is null)));
                                        }
                                        return ox_ & pi_;
                                    }
                                }

                                IEnumerable<Encounter> on_ = context.Operators.Where<Encounter>(md_, om_);

                                object oo_(Encounter @this) {
                                    Period pj_ = @this?.Period;
                                    CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                                    CqlDateTime pl_ = context.Operators.End(pk_);
                                    return pl_;
                                }

                                IEnumerable<Encounter> op_ = context.Operators.SortBy<Encounter>(on_, oo_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter oq_ = context.Operators.Last<Encounter>(op_);
                                Period or_ = oq_?.Period;
                                CqlInterval<CqlDateTime> os_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, or_);
                                CqlDateTime ot_ = context.Operators.Start(os_);
                                nb_ = na_ & (!((bool?)((ot_ ?? mo_) is null)));
                            }
                            return ly_ & nb_;
                        }
                    }

                    IEnumerable<Encounter> lg_ = context.Operators.Where<Encounter>(ar_, lf_);

                    object lh_(Encounter @this) {
                        Period pm_ = @this?.Period;
                        CqlInterval<CqlDateTime> pn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pm_);
                        CqlDateTime po_ = context.Operators.End(pn_);
                        return po_;
                    }

                    IEnumerable<Encounter> li_ = context.Operators.SortBy<Encounter>(lg_, lh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lj_ = context.Operators.Last<Encounter>(li_);
                    Period lk_ = lj_?.Period;
                    CqlInterval<CqlDateTime> ll_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lk_);
                    CqlDateTime lm_ = context.Operators.Start(ll_);

                    bool? ln_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pp_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pq_ = pp_?.Value;
                        Code<Encounter.EncounterStatus> pr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pq_);
                        bool? ps_ = context.Operators.Equal(pr_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (ps_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period pt_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                            CqlDateTime pv_ = context.Operators.End(pu_);
                            Period pw_ = Visit?.Period;
                            CqlInterval<CqlDateTime> px_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pw_);
                            CqlDateTime py_ = context.Operators.Start(px_);
                            CqlQuantity pz_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime qa_ = context.Operators.Subtract(py_, pz_);
                            CqlInterval<CqlDateTime> qb_ = context.Operators.Interval(qa_, py_, true, true);
                            bool? qc_ = context.Operators.In<CqlDateTime>(pv_, qb_, (string)default);
                            bool? qd_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (qc_ is false)
                            {
                                qd_ = false;
                            }
                            else
                            {
                                qd_ = qc_ & (!((bool?)(py_ is null)));
                            }
                            return ps_ & qd_;
                        }
                    }

                    IEnumerable<Encounter> lo_ = context.Operators.Where<Encounter>(bb_, ln_);

                    object lp_(Encounter @this) {
                        Period qe_ = @this?.Period;
                        CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                        CqlDateTime qg_ = context.Operators.End(qf_);
                        return qg_;
                    }

                    IEnumerable<Encounter> lq_ = context.Operators.SortBy<Encounter>(lo_, lp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lr_ = context.Operators.Last<Encounter>(lq_);
                    Period ls_ = lr_?.Period;
                    CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ls_);
                    CqlDateTime lu_ = context.Operators.Start(lt_);
                    return cg_ & (!((bool?)((lm_ ?? lu_ ?? bm_) is null)));
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period qh_ = @this?.Period;
                CqlInterval<CqlDateTime> qi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qh_);
                CqlDateTime qj_ = context.Operators.End(qi_);
                return qj_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> qk_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ql_ = qk_?.Value;
                Code<Encounter.EncounterStatus> qm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ql_);
                bool? qn_ = context.Operators.Equal(qm_, "finished");
                // CQL 'and' (246:6-247:71): right operand skipped when left is false
                if (qn_ is false)
                {
                    return false;
                }
                else
                {
                    Period qo_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                    CqlDateTime qq_ = context.Operators.End(qp_);
                    CqlValueSet qr_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? qt_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> rr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rs_ = rr_?.Value;
                        Code<Encounter.EncounterStatus> rt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rs_);
                        bool? ru_ = context.Operators.Equal(rt_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (ru_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period rv_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> rw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rv_);
                            CqlDateTime rx_ = context.Operators.End(rw_);
                            Period ry_ = Visit?.Period;
                            CqlInterval<CqlDateTime> rz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ry_);
                            CqlDateTime sa_ = context.Operators.Start(rz_);
                            CqlQuantity sb_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime sc_ = context.Operators.Subtract(sa_, sb_);
                            CqlInterval<CqlDateTime> sd_ = context.Operators.Interval(sc_, sa_, true, true);
                            bool? se_ = context.Operators.In<CqlDateTime>(rx_, sd_, (string)default);
                            bool? sf_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (se_ is false)
                            {
                                sf_ = false;
                            }
                            else
                            {
                                sf_ = se_ & (!((bool?)(sa_ is null)));
                            }
                            return ru_ & sf_;
                        }
                    }

                    IEnumerable<Encounter> qu_ = context.Operators.Where<Encounter>(qs_, qt_);

                    object qv_(Encounter @this) {
                        Period sg_ = @this?.Period;
                        CqlInterval<CqlDateTime> sh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime si_ = context.Operators.End(sh_);
                        return si_;
                    }

                    IEnumerable<Encounter> qw_ = context.Operators.SortBy<Encounter>(qu_, qv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qx_ = context.Operators.Last<Encounter>(qw_);
                    Period qy_ = qx_?.Period;
                    CqlInterval<CqlDateTime> qz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qy_);
                    CqlDateTime ra_ = context.Operators.Start(qz_);
                    Period rb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlQuantity re_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rf_ = context.Operators.Subtract(ra_ ?? rd_, re_);

                    bool? rg_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> sj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? sk_ = sj_?.Value;
                        Code<Encounter.EncounterStatus> sl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sk_);
                        bool? sm_ = context.Operators.Equal(sl_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (sm_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period sn_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> so_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sn_);
                            CqlDateTime sp_ = context.Operators.End(so_);
                            Period sq_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sq_);
                            CqlDateTime ss_ = context.Operators.Start(sr_);
                            CqlQuantity st_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime su_ = context.Operators.Subtract(ss_, st_);
                            CqlInterval<CqlDateTime> sv_ = context.Operators.Interval(su_, ss_, true, true);
                            bool? sw_ = context.Operators.In<CqlDateTime>(sp_, sv_, (string)default);
                            bool? sx_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (sw_ is false)
                            {
                                sx_ = false;
                            }
                            else
                            {
                                sx_ = sw_ & (!((bool?)(ss_ is null)));
                            }
                            return sm_ & sx_;
                        }
                    }

                    IEnumerable<Encounter> rh_ = context.Operators.Where<Encounter>(qs_, rg_);

                    object ri_(Encounter @this) {
                        Period sy_ = @this?.Period;
                        CqlInterval<CqlDateTime> sz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sy_);
                        CqlDateTime ta_ = context.Operators.End(sz_);
                        return ta_;
                    }

                    IEnumerable<Encounter> rj_ = context.Operators.SortBy<Encounter>(rh_, ri_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rk_ = context.Operators.Last<Encounter>(rj_);
                    Period rl_ = rk_?.Period;
                    CqlInterval<CqlDateTime> rm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rl_);
                    CqlDateTime rn_ = context.Operators.Start(rm_);
                    CqlInterval<CqlDateTime> ro_ = context.Operators.Interval(rf_, rn_ ?? rd_, true, true);
                    bool? rp_ = context.Operators.In<CqlDateTime>(qq_, ro_, (string)default);
                    bool? rq_;
                    // CQL 'and' (247:15-247:71): right operand skipped when left is false
                    if (rp_ is false)
                    {
                        rq_ = false;
                    }
                    else
                    {

                        bool? tb_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> tj_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? tk_ = tj_?.Value;
                            Code<Encounter.EncounterStatus> tl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tk_);
                            bool? tm_ = context.Operators.Equal(tl_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (tm_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period tn_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> to_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tn_);
                                CqlDateTime tp_ = context.Operators.End(to_);
                                Period tq_ = Visit?.Period;
                                CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tq_);
                                CqlDateTime ts_ = context.Operators.Start(tr_);
                                CqlQuantity tt_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime tu_ = context.Operators.Subtract(ts_, tt_);
                                CqlInterval<CqlDateTime> tv_ = context.Operators.Interval(tu_, ts_, true, true);
                                bool? tw_ = context.Operators.In<CqlDateTime>(tp_, tv_, (string)default);
                                bool? tx_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (tw_ is false)
                                {
                                    tx_ = false;
                                }
                                else
                                {
                                    tx_ = tw_ & (!((bool?)(ts_ is null)));
                                }
                                return tm_ & tx_;
                            }
                        }

                        IEnumerable<Encounter> tc_ = context.Operators.Where<Encounter>(qs_, tb_);

                        object td_(Encounter @this) {
                            Period ty_ = @this?.Period;
                            CqlInterval<CqlDateTime> tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                            CqlDateTime ua_ = context.Operators.End(tz_);
                            return ua_;
                        }

                        IEnumerable<Encounter> te_ = context.Operators.SortBy<Encounter>(tc_, td_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter tf_ = context.Operators.Last<Encounter>(te_);
                        Period tg_ = tf_?.Period;
                        CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ti_ = context.Operators.Start(th_);
                        rq_ = rp_ & (!((bool?)((ti_ ?? rd_) is null)));
                    }
                    return qn_ & rq_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period ub_ = @this?.Period;
                CqlInterval<CqlDateTime> uc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ub_);
                CqlDateTime ud_ = context.Operators.End(uc_);
                return ud_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> ue_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uf_ = ue_?.Value;
                Code<Encounter.EncounterStatus> ug_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uf_);
                bool? uh_ = context.Operators.Equal(ug_, "finished");
                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                if (uh_ is false)
                {
                    return false;
                }
                else
                {
                    Period ui_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime uk_ = context.Operators.End(uj_);
                    Period ul_ = Visit?.Period;
                    CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ul_);
                    CqlDateTime un_ = context.Operators.Start(um_);
                    CqlQuantity uo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime up_ = context.Operators.Subtract(un_, uo_);
                    CqlInterval<CqlDateTime> uq_ = context.Operators.Interval(up_, un_, true, true);
                    bool? ur_ = context.Operators.In<CqlDateTime>(uk_, uq_, (string)default);
                    bool? us_;
                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                    if (ur_ is false)
                    {
                        us_ = false;
                    }
                    else
                    {
                        us_ = ur_ & (!((bool?)(un_ is null)));
                    }
                    return uh_ & us_;
                }
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period ut_ = @this?.Period;
                CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                CqlDateTime uv_ = context.Operators.End(uu_);
                return uv_;
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
                    Code<Encounter.EncounterStatus> ch_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ci_ = ch_?.Value;
                    Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                    bool? ck_ = context.Operators.Equal(cj_, "finished");
                    // CQL 'and' (269:6-270:71): right operand skipped when left is false
                    if (ck_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period cl_ = LastED?.Period;
                        CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                        CqlDateTime cn_ = context.Operators.End(cm_);
                        CqlValueSet co_ = this.Observation_Services(context);
                        IEnumerable<Encounter> cp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, co_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? cq_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> do_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dp_ = do_?.Value;
                            Code<Encounter.EncounterStatus> dq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dp_);
                            bool? dr_ = context.Operators.Equal(dq_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (dr_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period ds_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ds_);
                                CqlDateTime du_ = context.Operators.End(dt_);
                                Period dv_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                                CqlDateTime dx_ = context.Operators.Start(dw_);
                                CqlQuantity dy_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dz_ = context.Operators.Subtract(dx_, dy_);
                                CqlInterval<CqlDateTime> ea_ = context.Operators.Interval(dz_, dx_, true, true);
                                bool? eb_ = context.Operators.In<CqlDateTime>(du_, ea_, (string)default);
                                bool? ec_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (eb_ is false)
                                {
                                    ec_ = false;
                                }
                                else
                                {
                                    ec_ = eb_ & (!((bool?)(dx_ is null)));
                                }
                                return dr_ & ec_;
                            }
                        }

                        IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                        object cs_(Encounter @this) {
                            Period ed_ = @this?.Period;
                            CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                            CqlDateTime ef_ = context.Operators.End(ee_);
                            return ef_;
                        }

                        IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                        Period cv_ = cu_?.Period;
                        CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                        CqlDateTime cx_ = context.Operators.Start(cw_);
                        Period cy_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                        CqlDateTime da_ = context.Operators.Start(cz_);
                        CqlQuantity db_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dc_ = context.Operators.Subtract(cx_ ?? da_, db_);

                        bool? dd_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> eg_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? eh_ = eg_?.Value;
                            Code<Encounter.EncounterStatus> ei_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eh_);
                            bool? ej_ = context.Operators.Equal(ei_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (ej_ is false)
                            {
                                return false;
                            }
                            else
                            {
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
                                bool? eu_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (et_ is false)
                                {
                                    eu_ = false;
                                }
                                else
                                {
                                    eu_ = et_ & (!((bool?)(ep_ is null)));
                                }
                                return ej_ & eu_;
                            }
                        }

                        IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(cp_, dd_);

                        object df_(Encounter @this) {
                            Period ev_ = @this?.Period;
                            CqlInterval<CqlDateTime> ew_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ev_);
                            CqlDateTime ex_ = context.Operators.End(ew_);
                            return ex_;
                        }

                        IEnumerable<Encounter> dg_ = context.Operators.SortBy<Encounter>(de_, df_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dh_ = context.Operators.Last<Encounter>(dg_);
                        Period di_ = dh_?.Period;
                        CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                        CqlDateTime dk_ = context.Operators.Start(dj_);
                        CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dc_, dk_ ?? da_, true, true);
                        bool? dm_ = context.Operators.In<CqlDateTime>(cn_, dl_, (string)default);
                        bool? dn_;
                        // CQL 'and' (270:15-270:71): right operand skipped when left is false
                        if (dm_ is false)
                        {
                            dn_ = false;
                        }
                        else
                        {

                            bool? ey_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fg_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fh_ = fg_?.Value;
                                Code<Encounter.EncounterStatus> fi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fh_);
                                bool? fj_ = context.Operators.Equal(fi_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (fj_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period fk_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> fl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fk_);
                                    CqlDateTime fm_ = context.Operators.End(fl_);
                                    Period fn_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                                    CqlDateTime fp_ = context.Operators.Start(fo_);
                                    CqlQuantity fq_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime fr_ = context.Operators.Subtract(fp_, fq_);
                                    CqlInterval<CqlDateTime> fs_ = context.Operators.Interval(fr_, fp_, true, true);
                                    bool? ft_ = context.Operators.In<CqlDateTime>(fm_, fs_, (string)default);
                                    bool? fu_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (ft_ is false)
                                    {
                                        fu_ = false;
                                    }
                                    else
                                    {
                                        fu_ = ft_ & (!((bool?)(fp_ is null)));
                                    }
                                    return fj_ & fu_;
                                }
                            }

                            IEnumerable<Encounter> ez_ = context.Operators.Where<Encounter>(cp_, ey_);

                            object fa_(Encounter @this) {
                                Period fv_ = @this?.Period;
                                CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                                CqlDateTime fx_ = context.Operators.End(fw_);
                                return fx_;
                            }

                            IEnumerable<Encounter> fb_ = context.Operators.SortBy<Encounter>(ez_, fa_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fc_ = context.Operators.Last<Encounter>(fb_);
                            Period fd_ = fc_?.Period;
                            CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                            CqlDateTime ff_ = context.Operators.Start(fe_);
                            dn_ = dm_ & (!((bool?)((ff_ ?? da_) is null)));
                        }
                        return ck_ & dn_;
                    }
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period fy_ = @this?.Period;
                    CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                    CqlDateTime ga_ = context.Operators.End(fz_);
                    return ga_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gc_ = gb_?.Value;
                    Code<Encounter.EncounterStatus> gd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gc_);
                    bool? ge_ = context.Operators.Equal(gd_, "finished");
                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                    if (ge_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gf_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gf_);
                        CqlDateTime gh_ = context.Operators.End(gg_);
                        Period gi_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gi_);
                        CqlDateTime gk_ = context.Operators.Start(gj_);
                        CqlQuantity gl_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gm_ = context.Operators.Subtract(gk_, gl_);
                        CqlInterval<CqlDateTime> gn_ = context.Operators.Interval(gm_, gk_, true, true);
                        bool? go_ = context.Operators.In<CqlDateTime>(gh_, gn_, (string)default);
                        bool? gp_;
                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                        if (go_ is false)
                        {
                            gp_ = false;
                        }
                        else
                        {
                            gp_ = go_ & (!((bool?)(gk_ is null)));
                        }
                        return ge_ & gp_;
                    }
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period gq_ = @this?.Period;
                    CqlInterval<CqlDateTime> gr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                    CqlDateTime gs_ = context.Operators.End(gr_);
                    return gs_;
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
                    Code<Encounter.EncounterStatus> gt_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? gu_ = gt_?.Value;
                    Code<Encounter.EncounterStatus> gv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gu_);
                    bool? gw_ = context.Operators.Equal(gv_, "finished");
                    // CQL 'and' (269:6-270:71): right operand skipped when left is false
                    if (gw_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gx_ = LastED?.Period;
                        CqlInterval<CqlDateTime> gy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gx_);
                        CqlDateTime gz_ = context.Operators.End(gy_);
                        CqlValueSet ha_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ha_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? hc_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ia_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? ib_ = ia_?.Value;
                            Code<Encounter.EncounterStatus> ic_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ib_);
                            bool? id_ = context.Operators.Equal(ic_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (id_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period ie_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> if_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ie_);
                                CqlDateTime ig_ = context.Operators.End(if_);
                                Period ih_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ii_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ih_);
                                CqlDateTime ij_ = context.Operators.Start(ii_);
                                CqlQuantity ik_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime il_ = context.Operators.Subtract(ij_, ik_);
                                CqlInterval<CqlDateTime> im_ = context.Operators.Interval(il_, ij_, true, true);
                                bool? in_ = context.Operators.In<CqlDateTime>(ig_, im_, (string)default);
                                bool? io_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (in_ is false)
                                {
                                    io_ = false;
                                }
                                else
                                {
                                    io_ = in_ & (!((bool?)(ij_ is null)));
                                }
                                return id_ & io_;
                            }
                        }

                        IEnumerable<Encounter> hd_ = context.Operators.Where<Encounter>(hb_, hc_);

                        object he_(Encounter @this) {
                            Period ip_ = @this?.Period;
                            CqlInterval<CqlDateTime> iq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ip_);
                            CqlDateTime ir_ = context.Operators.End(iq_);
                            return ir_;
                        }

                        IEnumerable<Encounter> hf_ = context.Operators.SortBy<Encounter>(hd_, he_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter hg_ = context.Operators.Last<Encounter>(hf_);
                        Period hh_ = hg_?.Period;
                        CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hh_);
                        CqlDateTime hj_ = context.Operators.Start(hi_);
                        Period hk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> hl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hk_);
                        CqlDateTime hm_ = context.Operators.Start(hl_);
                        CqlQuantity hn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ho_ = context.Operators.Subtract(hj_ ?? hm_, hn_);

                        bool? hp_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> is_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? it_ = is_?.Value;
                            Code<Encounter.EncounterStatus> iu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(it_);
                            bool? iv_ = context.Operators.Equal(iu_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (iv_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period iw_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ix_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iw_);
                                CqlDateTime iy_ = context.Operators.End(ix_);
                                Period iz_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ja_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iz_);
                                CqlDateTime jb_ = context.Operators.Start(ja_);
                                CqlQuantity jc_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jd_ = context.Operators.Subtract(jb_, jc_);
                                CqlInterval<CqlDateTime> je_ = context.Operators.Interval(jd_, jb_, true, true);
                                bool? jf_ = context.Operators.In<CqlDateTime>(iy_, je_, (string)default);
                                bool? jg_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (jf_ is false)
                                {
                                    jg_ = false;
                                }
                                else
                                {
                                    jg_ = jf_ & (!((bool?)(jb_ is null)));
                                }
                                return iv_ & jg_;
                            }
                        }

                        IEnumerable<Encounter> hq_ = context.Operators.Where<Encounter>(hb_, hp_);

                        object hr_(Encounter @this) {
                            Period jh_ = @this?.Period;
                            CqlInterval<CqlDateTime> ji_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jh_);
                            CqlDateTime jj_ = context.Operators.End(ji_);
                            return jj_;
                        }

                        IEnumerable<Encounter> hs_ = context.Operators.SortBy<Encounter>(hq_, hr_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ht_ = context.Operators.Last<Encounter>(hs_);
                        Period hu_ = ht_?.Period;
                        CqlInterval<CqlDateTime> hv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hu_);
                        CqlDateTime hw_ = context.Operators.Start(hv_);
                        CqlInterval<CqlDateTime> hx_ = context.Operators.Interval(ho_, hw_ ?? hm_, true, true);
                        bool? hy_ = context.Operators.In<CqlDateTime>(gz_, hx_, (string)default);
                        bool? hz_;
                        // CQL 'and' (270:15-270:71): right operand skipped when left is false
                        if (hy_ is false)
                        {
                            hz_ = false;
                        }
                        else
                        {

                            bool? jk_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> js_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? jt_ = js_?.Value;
                                Code<Encounter.EncounterStatus> ju_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jt_);
                                bool? jv_ = context.Operators.Equal(ju_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (jv_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period jw_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> jx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jw_);
                                    CqlDateTime jy_ = context.Operators.End(jx_);
                                    Period jz_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ka_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jz_);
                                    CqlDateTime kb_ = context.Operators.Start(ka_);
                                    CqlQuantity kc_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime kd_ = context.Operators.Subtract(kb_, kc_);
                                    CqlInterval<CqlDateTime> ke_ = context.Operators.Interval(kd_, kb_, true, true);
                                    bool? kf_ = context.Operators.In<CqlDateTime>(jy_, ke_, (string)default);
                                    bool? kg_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (kf_ is false)
                                    {
                                        kg_ = false;
                                    }
                                    else
                                    {
                                        kg_ = kf_ & (!((bool?)(kb_ is null)));
                                    }
                                    return jv_ & kg_;
                                }
                            }

                            IEnumerable<Encounter> jl_ = context.Operators.Where<Encounter>(hb_, jk_);

                            object jm_(Encounter @this) {
                                Period kh_ = @this?.Period;
                                CqlInterval<CqlDateTime> ki_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kh_);
                                CqlDateTime kj_ = context.Operators.End(ki_);
                                return kj_;
                            }

                            IEnumerable<Encounter> jn_ = context.Operators.SortBy<Encounter>(jl_, jm_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter jo_ = context.Operators.Last<Encounter>(jn_);
                            Period jp_ = jo_?.Period;
                            CqlInterval<CqlDateTime> jq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jp_);
                            CqlDateTime jr_ = context.Operators.Start(jq_);
                            hz_ = hy_ & (!((bool?)((jr_ ?? hm_) is null)));
                        }
                        return gw_ & hz_;
                    }
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period kk_ = @this?.Period;
                    CqlInterval<CqlDateTime> kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                    CqlDateTime km_ = context.Operators.End(kl_);
                    return km_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> kn_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ko_ = kn_?.Value;
                    Code<Encounter.EncounterStatus> kp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ko_);
                    bool? kq_ = context.Operators.Equal(kp_, "finished");
                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                    if (kq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period kr_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> ks_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kr_);
                        CqlDateTime kt_ = context.Operators.End(ks_);
                        Period ku_ = Visit?.Period;
                        CqlInterval<CqlDateTime> kv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ku_);
                        CqlDateTime kw_ = context.Operators.Start(kv_);
                        CqlQuantity kx_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ky_ = context.Operators.Subtract(kw_, kx_);
                        CqlInterval<CqlDateTime> kz_ = context.Operators.Interval(ky_, kw_, true, true);
                        bool? la_ = context.Operators.In<CqlDateTime>(kt_, kz_, (string)default);
                        bool? lb_;
                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                        if (la_ is false)
                        {
                            lb_ = false;
                        }
                        else
                        {
                            lb_ = la_ & (!((bool?)(kw_ is null)));
                        }
                        return kq_ & lb_;
                    }
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period lc_ = @this?.Period;
                    CqlInterval<CqlDateTime> ld_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lc_);
                    CqlDateTime le_ = context.Operators.End(ld_);
                    return le_;
                }

                IEnumerable<Encounter> ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter cb_ = context.Operators.Last<Encounter>(ca_);
                Period cc_ = cb_?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime> cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                bool? cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);
                // CQL 'and' (275:6-275:81): right operand skipped when left is false
                if (cg_ is false)
                {
                    return false;
                }
                else
                {

                    bool? lf_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> lv_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? lw_ = lv_?.Value;
                        Code<Encounter.EncounterStatus> lx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lw_);
                        bool? ly_ = context.Operators.Equal(lx_, "finished");
                        // CQL 'and' (269:6-270:71): right operand skipped when left is false
                        if (ly_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period lz_ = LastED?.Period;
                            CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                            CqlDateTime mb_ = context.Operators.End(ma_);
                            CqlValueSet mc_ = this.Observation_Services(context);
                            IEnumerable<Encounter> md_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? me_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> nc_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? nd_ = nc_?.Value;
                                Code<Encounter.EncounterStatus> ne_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nd_);
                                bool? nf_ = context.Operators.Equal(ne_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (nf_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ng_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> nh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ng_);
                                    CqlDateTime ni_ = context.Operators.End(nh_);
                                    Period nj_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> nk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nj_);
                                    CqlDateTime nl_ = context.Operators.Start(nk_);
                                    CqlQuantity nm_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime nn_ = context.Operators.Subtract(nl_, nm_);
                                    CqlInterval<CqlDateTime> no_ = context.Operators.Interval(nn_, nl_, true, true);
                                    bool? np_ = context.Operators.In<CqlDateTime>(ni_, no_, (string)default);
                                    bool? nq_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (np_ is false)
                                    {
                                        nq_ = false;
                                    }
                                    else
                                    {
                                        nq_ = np_ & (!((bool?)(nl_ is null)));
                                    }
                                    return nf_ & nq_;
                                }
                            }

                            IEnumerable<Encounter> mf_ = context.Operators.Where<Encounter>(md_, me_);

                            object mg_(Encounter @this) {
                                Period nr_ = @this?.Period;
                                CqlInterval<CqlDateTime> ns_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nr_);
                                CqlDateTime nt_ = context.Operators.End(ns_);
                                return nt_;
                            }

                            IEnumerable<Encounter> mh_ = context.Operators.SortBy<Encounter>(mf_, mg_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter mi_ = context.Operators.Last<Encounter>(mh_);
                            Period mj_ = mi_?.Period;
                            CqlInterval<CqlDateTime> mk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mj_);
                            CqlDateTime ml_ = context.Operators.Start(mk_);
                            Period mm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mm_);
                            CqlDateTime mo_ = context.Operators.Start(mn_);
                            CqlQuantity mp_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime mq_ = context.Operators.Subtract(ml_ ?? mo_, mp_);

                            bool? mr_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> nu_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? nv_ = nu_?.Value;
                                Code<Encounter.EncounterStatus> nw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nv_);
                                bool? nx_ = context.Operators.Equal(nw_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (nx_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ny_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ny_);
                                    CqlDateTime oa_ = context.Operators.End(nz_);
                                    Period ob_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ob_);
                                    CqlDateTime od_ = context.Operators.Start(oc_);
                                    CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime of_ = context.Operators.Subtract(od_, oe_);
                                    CqlInterval<CqlDateTime> og_ = context.Operators.Interval(of_, od_, true, true);
                                    bool? oh_ = context.Operators.In<CqlDateTime>(oa_, og_, (string)default);
                                    bool? oi_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (oh_ is false)
                                    {
                                        oi_ = false;
                                    }
                                    else
                                    {
                                        oi_ = oh_ & (!((bool?)(od_ is null)));
                                    }
                                    return nx_ & oi_;
                                }
                            }

                            IEnumerable<Encounter> ms_ = context.Operators.Where<Encounter>(md_, mr_);

                            object mt_(Encounter @this) {
                                Period oj_ = @this?.Period;
                                CqlInterval<CqlDateTime> ok_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oj_);
                                CqlDateTime ol_ = context.Operators.End(ok_);
                                return ol_;
                            }

                            IEnumerable<Encounter> mu_ = context.Operators.SortBy<Encounter>(ms_, mt_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter mv_ = context.Operators.Last<Encounter>(mu_);
                            Period mw_ = mv_?.Period;
                            CqlInterval<CqlDateTime> mx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mw_);
                            CqlDateTime my_ = context.Operators.Start(mx_);
                            CqlInterval<CqlDateTime> mz_ = context.Operators.Interval(mq_, my_ ?? mo_, true, true);
                            bool? na_ = context.Operators.In<CqlDateTime>(mb_, mz_, (string)default);
                            bool? nb_;
                            // CQL 'and' (270:15-270:71): right operand skipped when left is false
                            if (na_ is false)
                            {
                                nb_ = false;
                            }
                            else
                            {

                                bool? om_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> ou_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? ov_ = ou_?.Value;
                                    Code<Encounter.EncounterStatus> ow_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ov_);
                                    bool? ox_ = context.Operators.Equal(ow_, "finished");
                                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                    if (ox_ is false)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        Period oy_ = LastObs?.Period;
                                        CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oy_);
                                        CqlDateTime pa_ = context.Operators.End(oz_);
                                        Period pb_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> pc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pb_);
                                        CqlDateTime pd_ = context.Operators.Start(pc_);
                                        CqlQuantity pe_ = context.Operators.Quantity(1m, "hour");
                                        CqlDateTime pf_ = context.Operators.Subtract(pd_, pe_);
                                        CqlInterval<CqlDateTime> pg_ = context.Operators.Interval(pf_, pd_, true, true);
                                        bool? ph_ = context.Operators.In<CqlDateTime>(pa_, pg_, (string)default);
                                        bool? pi_;
                                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                        if (ph_ is false)
                                        {
                                            pi_ = false;
                                        }
                                        else
                                        {
                                            pi_ = ph_ & (!((bool?)(pd_ is null)));
                                        }
                                        return ox_ & pi_;
                                    }
                                }

                                IEnumerable<Encounter> on_ = context.Operators.Where<Encounter>(md_, om_);

                                object oo_(Encounter @this) {
                                    Period pj_ = @this?.Period;
                                    CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                                    CqlDateTime pl_ = context.Operators.End(pk_);
                                    return pl_;
                                }

                                IEnumerable<Encounter> op_ = context.Operators.SortBy<Encounter>(on_, oo_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter oq_ = context.Operators.Last<Encounter>(op_);
                                Period or_ = oq_?.Period;
                                CqlInterval<CqlDateTime> os_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, or_);
                                CqlDateTime ot_ = context.Operators.Start(os_);
                                nb_ = na_ & (!((bool?)((ot_ ?? mo_) is null)));
                            }
                            return ly_ & nb_;
                        }
                    }

                    IEnumerable<Encounter> lg_ = context.Operators.Where<Encounter>(ar_, lf_);

                    object lh_(Encounter @this) {
                        Period pm_ = @this?.Period;
                        CqlInterval<CqlDateTime> pn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pm_);
                        CqlDateTime po_ = context.Operators.End(pn_);
                        return po_;
                    }

                    IEnumerable<Encounter> li_ = context.Operators.SortBy<Encounter>(lg_, lh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lj_ = context.Operators.Last<Encounter>(li_);
                    Period lk_ = lj_?.Period;
                    CqlInterval<CqlDateTime> ll_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lk_);
                    CqlDateTime lm_ = context.Operators.Start(ll_);

                    bool? ln_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> pp_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pq_ = pp_?.Value;
                        Code<Encounter.EncounterStatus> pr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pq_);
                        bool? ps_ = context.Operators.Equal(pr_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (ps_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period pt_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                            CqlDateTime pv_ = context.Operators.End(pu_);
                            Period pw_ = Visit?.Period;
                            CqlInterval<CqlDateTime> px_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pw_);
                            CqlDateTime py_ = context.Operators.Start(px_);
                            CqlQuantity pz_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime qa_ = context.Operators.Subtract(py_, pz_);
                            CqlInterval<CqlDateTime> qb_ = context.Operators.Interval(qa_, py_, true, true);
                            bool? qc_ = context.Operators.In<CqlDateTime>(pv_, qb_, (string)default);
                            bool? qd_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (qc_ is false)
                            {
                                qd_ = false;
                            }
                            else
                            {
                                qd_ = qc_ & (!((bool?)(py_ is null)));
                            }
                            return ps_ & qd_;
                        }
                    }

                    IEnumerable<Encounter> lo_ = context.Operators.Where<Encounter>(bb_, ln_);

                    object lp_(Encounter @this) {
                        Period qe_ = @this?.Period;
                        CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                        CqlDateTime qg_ = context.Operators.End(qf_);
                        return qg_;
                    }

                    IEnumerable<Encounter> lq_ = context.Operators.SortBy<Encounter>(lo_, lp_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter lr_ = context.Operators.Last<Encounter>(lq_);
                    Period ls_ = lr_?.Period;
                    CqlInterval<CqlDateTime> lt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ls_);
                    CqlDateTime lu_ = context.Operators.Start(lt_);
                    return cg_ & (!((bool?)((lm_ ?? lu_ ?? bm_) is null)));
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period qh_ = @this?.Period;
                CqlInterval<CqlDateTime> qi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qh_);
                CqlDateTime qj_ = context.Operators.End(qi_);
                return qj_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> qk_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ql_ = qk_?.Value;
                Code<Encounter.EncounterStatus> qm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ql_);
                bool? qn_ = context.Operators.Equal(qm_, "finished");
                // CQL 'and' (269:6-270:71): right operand skipped when left is false
                if (qn_ is false)
                {
                    return false;
                }
                else
                {
                    Period qo_ = LastED?.Period;
                    CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                    CqlDateTime qq_ = context.Operators.End(qp_);
                    CqlValueSet qr_ = this.Observation_Services(context);
                    IEnumerable<Encounter> qs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? qt_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> rr_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rs_ = rr_?.Value;
                        Code<Encounter.EncounterStatus> rt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rs_);
                        bool? ru_ = context.Operators.Equal(rt_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (ru_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period rv_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> rw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rv_);
                            CqlDateTime rx_ = context.Operators.End(rw_);
                            Period ry_ = Visit?.Period;
                            CqlInterval<CqlDateTime> rz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ry_);
                            CqlDateTime sa_ = context.Operators.Start(rz_);
                            CqlQuantity sb_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime sc_ = context.Operators.Subtract(sa_, sb_);
                            CqlInterval<CqlDateTime> sd_ = context.Operators.Interval(sc_, sa_, true, true);
                            bool? se_ = context.Operators.In<CqlDateTime>(rx_, sd_, (string)default);
                            bool? sf_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (se_ is false)
                            {
                                sf_ = false;
                            }
                            else
                            {
                                sf_ = se_ & (!((bool?)(sa_ is null)));
                            }
                            return ru_ & sf_;
                        }
                    }

                    IEnumerable<Encounter> qu_ = context.Operators.Where<Encounter>(qs_, qt_);

                    object qv_(Encounter @this) {
                        Period sg_ = @this?.Period;
                        CqlInterval<CqlDateTime> sh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sg_);
                        CqlDateTime si_ = context.Operators.End(sh_);
                        return si_;
                    }

                    IEnumerable<Encounter> qw_ = context.Operators.SortBy<Encounter>(qu_, qv_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter qx_ = context.Operators.Last<Encounter>(qw_);
                    Period qy_ = qx_?.Period;
                    CqlInterval<CqlDateTime> qz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qy_);
                    CqlDateTime ra_ = context.Operators.Start(qz_);
                    Period rb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> rc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rb_);
                    CqlDateTime rd_ = context.Operators.Start(rc_);
                    CqlQuantity re_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rf_ = context.Operators.Subtract(ra_ ?? rd_, re_);

                    bool? rg_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> sj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? sk_ = sj_?.Value;
                        Code<Encounter.EncounterStatus> sl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sk_);
                        bool? sm_ = context.Operators.Equal(sl_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (sm_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period sn_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> so_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sn_);
                            CqlDateTime sp_ = context.Operators.End(so_);
                            Period sq_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sq_);
                            CqlDateTime ss_ = context.Operators.Start(sr_);
                            CqlQuantity st_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime su_ = context.Operators.Subtract(ss_, st_);
                            CqlInterval<CqlDateTime> sv_ = context.Operators.Interval(su_, ss_, true, true);
                            bool? sw_ = context.Operators.In<CqlDateTime>(sp_, sv_, (string)default);
                            bool? sx_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (sw_ is false)
                            {
                                sx_ = false;
                            }
                            else
                            {
                                sx_ = sw_ & (!((bool?)(ss_ is null)));
                            }
                            return sm_ & sx_;
                        }
                    }

                    IEnumerable<Encounter> rh_ = context.Operators.Where<Encounter>(qs_, rg_);

                    object ri_(Encounter @this) {
                        Period sy_ = @this?.Period;
                        CqlInterval<CqlDateTime> sz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sy_);
                        CqlDateTime ta_ = context.Operators.End(sz_);
                        return ta_;
                    }

                    IEnumerable<Encounter> rj_ = context.Operators.SortBy<Encounter>(rh_, ri_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter rk_ = context.Operators.Last<Encounter>(rj_);
                    Period rl_ = rk_?.Period;
                    CqlInterval<CqlDateTime> rm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rl_);
                    CqlDateTime rn_ = context.Operators.Start(rm_);
                    CqlInterval<CqlDateTime> ro_ = context.Operators.Interval(rf_, rn_ ?? rd_, true, true);
                    bool? rp_ = context.Operators.In<CqlDateTime>(qq_, ro_, (string)default);
                    bool? rq_;
                    // CQL 'and' (270:15-270:71): right operand skipped when left is false
                    if (rp_ is false)
                    {
                        rq_ = false;
                    }
                    else
                    {

                        bool? tb_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> tj_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? tk_ = tj_?.Value;
                            Code<Encounter.EncounterStatus> tl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tk_);
                            bool? tm_ = context.Operators.Equal(tl_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (tm_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period tn_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> to_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tn_);
                                CqlDateTime tp_ = context.Operators.End(to_);
                                Period tq_ = Visit?.Period;
                                CqlInterval<CqlDateTime> tr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tq_);
                                CqlDateTime ts_ = context.Operators.Start(tr_);
                                CqlQuantity tt_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime tu_ = context.Operators.Subtract(ts_, tt_);
                                CqlInterval<CqlDateTime> tv_ = context.Operators.Interval(tu_, ts_, true, true);
                                bool? tw_ = context.Operators.In<CqlDateTime>(tp_, tv_, (string)default);
                                bool? tx_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (tw_ is false)
                                {
                                    tx_ = false;
                                }
                                else
                                {
                                    tx_ = tw_ & (!((bool?)(ts_ is null)));
                                }
                                return tm_ & tx_;
                            }
                        }

                        IEnumerable<Encounter> tc_ = context.Operators.Where<Encounter>(qs_, tb_);

                        object td_(Encounter @this) {
                            Period ty_ = @this?.Period;
                            CqlInterval<CqlDateTime> tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                            CqlDateTime ua_ = context.Operators.End(tz_);
                            return ua_;
                        }

                        IEnumerable<Encounter> te_ = context.Operators.SortBy<Encounter>(tc_, td_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter tf_ = context.Operators.Last<Encounter>(te_);
                        Period tg_ = tf_?.Period;
                        CqlInterval<CqlDateTime> th_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tg_);
                        CqlDateTime ti_ = context.Operators.Start(th_);
                        rq_ = rp_ & (!((bool?)((ti_ ?? rd_) is null)));
                    }
                    return qn_ & rq_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period ub_ = @this?.Period;
                CqlInterval<CqlDateTime> uc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ub_);
                CqlDateTime ud_ = context.Operators.End(uc_);
                return ud_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> ue_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? uf_ = ue_?.Value;
                Code<Encounter.EncounterStatus> ug_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uf_);
                bool? uh_ = context.Operators.Equal(ug_, "finished");
                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                if (uh_ is false)
                {
                    return false;
                }
                else
                {
                    Period ui_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime uk_ = context.Operators.End(uj_);
                    Period ul_ = Visit?.Period;
                    CqlInterval<CqlDateTime> um_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ul_);
                    CqlDateTime un_ = context.Operators.Start(um_);
                    CqlQuantity uo_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime up_ = context.Operators.Subtract(un_, uo_);
                    CqlInterval<CqlDateTime> uq_ = context.Operators.Interval(up_, un_, true, true);
                    bool? ur_ = context.Operators.In<CqlDateTime>(uk_, uq_, (string)default);
                    bool? us_;
                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                    if (ur_ is false)
                    {
                        us_ = false;
                    }
                    else
                    {
                        us_ = ur_ & (!((bool?)(un_ is null)));
                    }
                    return uh_ & us_;
                }
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period ut_ = @this?.Period;
                CqlInterval<CqlDateTime> uu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ut_);
                CqlDateTime uv_ = context.Operators.End(uu_);
                return uv_;
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
                bool? ag_ = context.Operators.Equal(af_, "finished");
                // CQL 'and' (293:7-294:73): right operand skipped when left is false
                if (ag_ is false)
                {
                    return false;
                }
                else
                {
                    Period ah_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.End(ai_);
                    CqlValueSet ak_ = this.Observation_Services(context);
                    IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? am_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> bk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bl_ = bk_?.Value;
                        Code<Encounter.EncounterStatus> bm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bl_);
                        bool? bn_ = context.Operators.Equal(bm_, "finished");
                        // CQL 'and' (287:7-288:85): right operand skipped when left is false
                        if (bn_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period bo_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                            CqlDateTime bq_ = context.Operators.End(bp_);
                            Period br_ = Visit?.Period;
                            CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                            CqlDateTime bt_ = context.Operators.Start(bs_);
                            CqlQuantity bu_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime bv_ = context.Operators.Subtract(bt_, bu_);
                            CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bv_, bt_, true, true);
                            bool? bx_ = context.Operators.In<CqlDateTime>(bq_, bw_, (string)default);
                            bool? by_;
                            // CQL 'and' (288:17-288:85): right operand skipped when left is false
                            if (bx_ is false)
                            {
                                by_ = false;
                            }
                            else
                            {
                                by_ = bx_ & (!((bool?)(bt_ is null)));
                            }
                            return bn_ & by_;
                        }
                    }

                    IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                    object ao_(Encounter @this) {
                        Period bz_ = @this?.Period;
                        CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                        CqlDateTime cb_ = context.Operators.End(ca_);
                        return cb_;
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
                        Code<Encounter.EncounterStatus> cc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? cd_ = cc_?.Value;
                        Code<Encounter.EncounterStatus> ce_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cd_);
                        bool? cf_ = context.Operators.Equal(ce_, "finished");
                        // CQL 'and' (287:7-288:85): right operand skipped when left is false
                        if (cf_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period cg_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                            CqlDateTime ci_ = context.Operators.End(ch_);
                            Period cj_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                            CqlDateTime cl_ = context.Operators.Start(ck_);
                            CqlQuantity cm_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime cn_ = context.Operators.Subtract(cl_, cm_);
                            CqlInterval<CqlDateTime> co_ = context.Operators.Interval(cn_, cl_, true, true);
                            bool? cp_ = context.Operators.In<CqlDateTime>(ci_, co_, (string)default);
                            bool? cq_;
                            // CQL 'and' (288:17-288:85): right operand skipped when left is false
                            if (cp_ is false)
                            {
                                cq_ = false;
                            }
                            else
                            {
                                cq_ = cp_ & (!((bool?)(cl_ is null)));
                            }
                            return cf_ & cq_;
                        }
                    }

                    IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                    object bb_(Encounter @this) {
                        Period cr_ = @this?.Period;
                        CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                        CqlDateTime ct_ = context.Operators.End(cs_);
                        return ct_;
                    }

                    IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bd_ = context.Operators.Last<Encounter>(bc_);
                    Period be_ = bd_?.Period;
                    CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                    CqlDateTime bg_ = context.Operators.Start(bf_);
                    CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                    bool? bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);
                    bool? bj_;
                    // CQL 'and' (294:17-294:73): right operand skipped when left is false
                    if (bi_ is false)
                    {
                        bj_ = false;
                    }
                    else
                    {

                        bool? cu_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dc_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dd_ = dc_?.Value;
                            Code<Encounter.EncounterStatus> de_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dd_);
                            bool? df_ = context.Operators.Equal(de_, "finished");
                            // CQL 'and' (287:7-288:85): right operand skipped when left is false
                            if (df_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period dg_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                                CqlDateTime di_ = context.Operators.End(dh_);
                                Period dj_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                                CqlDateTime dl_ = context.Operators.Start(dk_);
                                CqlQuantity dm_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dn_ = context.Operators.Subtract(dl_, dm_);
                                CqlInterval<CqlDateTime> do_ = context.Operators.Interval(dn_, dl_, true, true);
                                bool? dp_ = context.Operators.In<CqlDateTime>(di_, do_, (string)default);
                                bool? dq_;
                                // CQL 'and' (288:17-288:85): right operand skipped when left is false
                                if (dp_ is false)
                                {
                                    dq_ = false;
                                }
                                else
                                {
                                    dq_ = dp_ & (!((bool?)(dl_ is null)));
                                }
                                return df_ & dq_;
                            }
                        }

                        IEnumerable<Encounter> cv_ = context.Operators.Where<Encounter>(al_, cu_);

                        object cw_(Encounter @this) {
                            Period dr_ = @this?.Period;
                            CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                            CqlDateTime dt_ = context.Operators.End(ds_);
                            return dt_;
                        }

                        IEnumerable<Encounter> cx_ = context.Operators.SortBy<Encounter>(cv_, cw_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cy_ = context.Operators.Last<Encounter>(cx_);
                        Period cz_ = cy_?.Period;
                        CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cz_);
                        CqlDateTime db_ = context.Operators.Start(da_);
                        bj_ = bi_ & (!((bool?)((db_ ?? aw_) is null)));
                    }
                    return ag_ & bj_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period du_ = @this?.Period;
                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                CqlDateTime dw_ = context.Operators.End(dv_);
                return dw_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> dx_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? dy_ = dx_?.Value;
                Code<Encounter.EncounterStatus> dz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dy_);
                bool? ea_ = context.Operators.Equal(dz_, "finished");
                // CQL 'and' (287:7-288:85): right operand skipped when left is false
                if (ea_ is false)
                {
                    return false;
                }
                else
                {
                    Period eb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.End(ec_);
                    Period ee_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.Start(ef_);
                    CqlQuantity eh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ei_ = context.Operators.Subtract(eg_, eh_);
                    CqlInterval<CqlDateTime> ej_ = context.Operators.Interval(ei_, eg_, true, true);
                    bool? ek_ = context.Operators.In<CqlDateTime>(ed_, ej_, (string)default);
                    bool? el_;
                    // CQL 'and' (288:17-288:85): right operand skipped when left is false
                    if (ek_ is false)
                    {
                        el_ = false;
                    }
                    else
                    {
                        el_ = ek_ & (!((bool?)(eg_ is null)));
                    }
                    return ea_ & el_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
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
                bool? ag_ = context.Operators.Equal(af_, "finished");
                // CQL 'and' (311:7-312:73): right operand skipped when left is false
                if (ag_ is false)
                {
                    return false;
                }
                else
                {
                    Period ah_ = LastED?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.End(ai_);
                    CqlValueSet ak_ = this.Observation_Services(context);
                    IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? am_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> bk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bl_ = bk_?.Value;
                        Code<Encounter.EncounterStatus> bm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bl_);
                        bool? bn_ = context.Operators.Equal(bm_, "finished");
                        // CQL 'and' (305:7-306:85): right operand skipped when left is false
                        if (bn_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period bo_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                            CqlDateTime bq_ = context.Operators.End(bp_);
                            Period br_ = Visit?.Period;
                            CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                            CqlDateTime bt_ = context.Operators.Start(bs_);
                            CqlQuantity bu_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime bv_ = context.Operators.Subtract(bt_, bu_);
                            CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bv_, bt_, true, true);
                            bool? bx_ = context.Operators.In<CqlDateTime>(bq_, bw_, (string)default);
                            bool? by_;
                            // CQL 'and' (306:17-306:85): right operand skipped when left is false
                            if (bx_ is false)
                            {
                                by_ = false;
                            }
                            else
                            {
                                by_ = bx_ & (!((bool?)(bt_ is null)));
                            }
                            return bn_ & by_;
                        }
                    }

                    IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                    object ao_(Encounter @this) {
                        Period bz_ = @this?.Period;
                        CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                        CqlDateTime cb_ = context.Operators.End(ca_);
                        return cb_;
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
                        Code<Encounter.EncounterStatus> cc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? cd_ = cc_?.Value;
                        Code<Encounter.EncounterStatus> ce_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cd_);
                        bool? cf_ = context.Operators.Equal(ce_, "finished");
                        // CQL 'and' (305:7-306:85): right operand skipped when left is false
                        if (cf_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period cg_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                            CqlDateTime ci_ = context.Operators.End(ch_);
                            Period cj_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                            CqlDateTime cl_ = context.Operators.Start(ck_);
                            CqlQuantity cm_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime cn_ = context.Operators.Subtract(cl_, cm_);
                            CqlInterval<CqlDateTime> co_ = context.Operators.Interval(cn_, cl_, true, true);
                            bool? cp_ = context.Operators.In<CqlDateTime>(ci_, co_, (string)default);
                            bool? cq_;
                            // CQL 'and' (306:17-306:85): right operand skipped when left is false
                            if (cp_ is false)
                            {
                                cq_ = false;
                            }
                            else
                            {
                                cq_ = cp_ & (!((bool?)(cl_ is null)));
                            }
                            return cf_ & cq_;
                        }
                    }

                    IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                    object bb_(Encounter @this) {
                        Period cr_ = @this?.Period;
                        CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                        CqlDateTime ct_ = context.Operators.End(cs_);
                        return ct_;
                    }

                    IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter bd_ = context.Operators.Last<Encounter>(bc_);
                    Period be_ = bd_?.Period;
                    CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                    CqlDateTime bg_ = context.Operators.Start(bf_);
                    CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                    bool? bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);
                    bool? bj_;
                    // CQL 'and' (312:17-312:73): right operand skipped when left is false
                    if (bi_ is false)
                    {
                        bj_ = false;
                    }
                    else
                    {

                        bool? cu_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dc_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dd_ = dc_?.Value;
                            Code<Encounter.EncounterStatus> de_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dd_);
                            bool? df_ = context.Operators.Equal(de_, "finished");
                            // CQL 'and' (305:7-306:85): right operand skipped when left is false
                            if (df_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period dg_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                                CqlDateTime di_ = context.Operators.End(dh_);
                                Period dj_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                                CqlDateTime dl_ = context.Operators.Start(dk_);
                                CqlQuantity dm_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dn_ = context.Operators.Subtract(dl_, dm_);
                                CqlInterval<CqlDateTime> do_ = context.Operators.Interval(dn_, dl_, true, true);
                                bool? dp_ = context.Operators.In<CqlDateTime>(di_, do_, (string)default);
                                bool? dq_;
                                // CQL 'and' (306:17-306:85): right operand skipped when left is false
                                if (dp_ is false)
                                {
                                    dq_ = false;
                                }
                                else
                                {
                                    dq_ = dp_ & (!((bool?)(dl_ is null)));
                                }
                                return df_ & dq_;
                            }
                        }

                        IEnumerable<Encounter> cv_ = context.Operators.Where<Encounter>(al_, cu_);

                        object cw_(Encounter @this) {
                            Period dr_ = @this?.Period;
                            CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                            CqlDateTime dt_ = context.Operators.End(ds_);
                            return dt_;
                        }

                        IEnumerable<Encounter> cx_ = context.Operators.SortBy<Encounter>(cv_, cw_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter cy_ = context.Operators.Last<Encounter>(cx_);
                        Period cz_ = cy_?.Period;
                        CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cz_);
                        CqlDateTime db_ = context.Operators.Start(da_);
                        bj_ = bi_ & (!((bool?)((db_ ?? aw_) is null)));
                    }
                    return ag_ & bj_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period du_ = @this?.Period;
                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                CqlDateTime dw_ = context.Operators.End(dv_);
                return dw_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> dx_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? dy_ = dx_?.Value;
                Code<Encounter.EncounterStatus> dz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dy_);
                bool? ea_ = context.Operators.Equal(dz_, "finished");
                // CQL 'and' (305:7-306:85): right operand skipped when left is false
                if (ea_ is false)
                {
                    return false;
                }
                else
                {
                    Period eb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.End(ec_);
                    Period ee_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.Start(ef_);
                    CqlQuantity eh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ei_ = context.Operators.Subtract(eg_, eh_);
                    CqlInterval<CqlDateTime> ej_ = context.Operators.Interval(ei_, eg_, true, true);
                    bool? ek_ = context.Operators.In<CqlDateTime>(ed_, ej_, (string)default);
                    bool? el_;
                    // CQL 'and' (306:17-306:85): right operand skipped when left is false
                    if (ek_ is false)
                    {
                        el_ = false;
                    }
                    else
                    {
                        el_ = ek_ & (!((bool?)(eg_ is null)));
                    }
                    return ea_ & el_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
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
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            // CQL 'and' (336:6-337:57): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Period o_ = Encounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                Period q_ = HospitalLocation?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                return m_ & s_;
            }
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        object d_(Encounter.LocationComponent @this) {
            Period t_ = @this?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            return v_;
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
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            // CQL 'and' (346:6-347:57): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Period o_ = Encounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                Period q_ = HospitalLocation?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(p_, r_, (string)default);
                return m_ & s_;
            }
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        object d_(Encounter.LocationComponent @this) {
            Period t_ = @this?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            return v_;
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
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, j_, l_);
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
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, D, k_);
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
            PositiveInt g_ = D?.RankElement;
            int? h_ = g_?.Value;
            bool? i_ = context.Operators.Equal(h_, 1);
            // CQL 'and' (386:25-386:62): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                CodeableConcept j_ = D?.Use;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = this.Billing(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                return i_ & n_;
            }
        }


        Condition c_(Encounter.DiagnosisComponent PD) {
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> q_ = context.Operators.Union<Condition>(o_ as IEnumerable<Condition>, p_ as IEnumerable<Condition>);

            bool? r_(Condition C) {
                ResourceReference u_ = PD?.Condition;
                Id v_ = C?.IdElement;
                string w_ = v_?.Value;
                bool? x_ = QICoreCommon_4_0_000.Instance.references(context, u_, w_);
                return x_;
            }

            IEnumerable<Condition> s_ = context.Operators.Where<Condition>(q_, r_);
            Condition t_ = context.Operators.SingletonFrom<Condition>(s_);
            return t_;
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
            IEnumerable<Claim> e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim C) {
                Code<FinancialResourceStatusCodes> n_ = C?.StatusElement;
                FinancialResourceStatusCodes? o_ = n_?.Value;
                Code<FinancialResourceStatusCodes> p_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(o_);
                bool? q_ = context.Operators.Equal(p_, "active");
                bool? r_;
                // CQL 'and' (406:31-406:69): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Code<ClaimUseCode> s_ = C?.UseElement;
                    ClaimUseCode? t_ = s_?.Value;
                    Code<ClaimUseCode> u_ = context.Operators.Convert<Code<ClaimUseCode>>(t_);
                    bool? v_ = context.Operators.Equal(u_, "claim");
                    r_ = q_ & v_;
                }
                // CQL 'and' (406:25-406:123): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> w_ = C?.Item;

                    bool? x_(Claim.ItemComponent I) {
                        List<ResourceReference> z_ = I?.Encounter;
                        bool? aa_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)z_, E);
                        return aa_;
                    }

                    bool? y_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)w_, x_);
                    return r_ & y_;
                }
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.DiagnosisComponent> ab_ = @this?.Diagnosis;
                return !((bool?)(ab_ is null));
            }


            List<Claim.DiagnosisComponent> i_(Claim @this) {
                List<Claim.DiagnosisComponent> ac_ = @this?.Diagnosis;
                return ac_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent> k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)j_);

            bool? l_(Claim.DiagnosisComponent D) {
                PositiveInt ad_ = D?.SequenceElement;
                int? ae_ = ad_?.Value;
                IEnumerable<Claim> af_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ag_(Claim C) {
                    Code<FinancialResourceStatusCodes> at_ = C?.StatusElement;
                    FinancialResourceStatusCodes? au_ = at_?.Value;
                    Code<FinancialResourceStatusCodes> av_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(au_);
                    bool? aw_ = context.Operators.Equal(av_, "active");
                    bool? ax_;
                    // CQL 'and' (406:31-406:69): right operand skipped when left is false
                    if (aw_ is false)
                    {
                        ax_ = false;
                    }
                    else
                    {
                        Code<ClaimUseCode> ay_ = C?.UseElement;
                        ClaimUseCode? az_ = ay_?.Value;
                        Code<ClaimUseCode> ba_ = context.Operators.Convert<Code<ClaimUseCode>>(az_);
                        bool? bb_ = context.Operators.Equal(ba_, "claim");
                        ax_ = aw_ & bb_;
                    }
                    // CQL 'and' (406:25-406:123): right operand skipped when left is false
                    if (ax_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<Claim.ItemComponent> bc_ = C?.Item;

                        bool? bd_(Claim.ItemComponent I) {
                            List<ResourceReference> bf_ = I?.Encounter;
                            bool? bg_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bf_, E);
                            return bg_;
                        }

                        bool? be_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bc_, bd_);
                        return ax_ & be_;
                    }
                }

                IEnumerable<Claim> ah_ = context.Operators.Where<Claim>(af_, ag_);

                bool? ai_(Claim @this) {
                    List<Claim.ItemComponent> bh_ = @this?.Item;
                    return !((bool?)(bh_ is null));
                }


                List<Claim.ItemComponent> aj_(Claim @this) {
                    List<Claim.ItemComponent> bi_ = @this?.Item;
                    return bi_;
                }

                IEnumerable<List<Claim.ItemComponent>> ak_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ah_, ai_, aj_);
                IEnumerable<Claim.ItemComponent> al_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ak_);

                bool? am_(Claim.ItemComponent I) {
                    List<ResourceReference> bj_ = I?.Encounter;
                    bool? bk_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bj_, E);
                    return bk_;
                }

                IEnumerable<Claim.ItemComponent> an_ = context.Operators.Where<Claim.ItemComponent>(al_, am_);

                bool? ao_(Claim.ItemComponent @this) {
                    List<PositiveInt> bl_ = @this?.DiagnosisSequenceElement;

                    int? bm_(PositiveInt @this) {
                        int? bo_ = @this?.Value;
                        return bo_;
                    }

                    IEnumerable<int?> bn_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bl_, bm_);
                    return !((bool?)(bn_ is null));
                }


                IEnumerable<int?> ap_(Claim.ItemComponent @this) {
                    List<PositiveInt> bp_ = @this?.DiagnosisSequenceElement;

                    int? bq_(PositiveInt @this) {
                        int? bs_ = @this?.Value;
                        return bs_;
                    }

                    IEnumerable<int?> br_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bp_, bq_);
                    return br_;
                }

                IEnumerable<IEnumerable<int?>> aq_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(an_, ao_, ap_);
                IEnumerable<int?> ar_ = context.Operators.Flatten<int?>(aq_);
                bool? as_ = context.Operators.In<int?>(ae_, ar_);
                return as_;
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
            bool? h_ = context.Operators.ConceptInValueSet(g_ as CqlConcept, valueSet);
            // CQL 'or' (417:13-418:54): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                Condition i_ = this.getCondition(context, g_ as ResourceReference);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                bool? l_ = context.Operators.ConceptInValueSet(k_, valueSet);
                return h_ | l_;
            }
        }

        IEnumerable<bool?> d_ = context.Operators.SelectDistinct<Claim.DiagnosisComponent, bool?>((IEnumerable<Claim.DiagnosisComponent>)b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
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
            bool? f_ = context.Operators.ConceptInValueSet(e_, poaValueSet);
            // CQL 'and' (427:8-431:10): right operand skipped when left is false
            if (f_ is false)
            {
                return false;
            }
            else
            {
                DataType g_ = CD?.Diagnosis;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                bool? i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept, diagnosisValueSet);
                bool? j_;
                // CQL 'or' (428:14-431:10): right operand skipped when left is true
                if (i_ is true)
                {
                    j_ = true;
                }
                else
                {
                    Condition k_ = this.getCondition(context, h_ as ResourceReference);
                    CodeableConcept l_ = k_?.Code;
                    CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                    bool? n_ = context.Operators.ConceptInValueSet(m_, diagnosisValueSet);
                    j_ = i_ | n_;
                }
                return f_ & j_;
            }
        }

        bool? c_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(a_, b_);
        return c_;
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
            return b_ as CqlConcept;
        }
        else
        {
            IEnumerable<Medication> d_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? e_(Medication M) {
                DataType j_ = request?.Medication;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, k_ as ResourceReference, M);
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
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, k_ as ResourceReference, M);
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
                bool? r_ = context.Operators.Equal(q_, "active");
                bool? s_;
                // CQL 'and' (476:32-476:70): right operand skipped when left is false
                if (r_ is false)
                {
                    s_ = false;
                }
                else
                {
                    Code<ClaimUseCode> t_ = C?.UseElement;
                    ClaimUseCode? u_ = t_?.Value;
                    Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                    bool? w_ = context.Operators.Equal(v_, "claim");
                    s_ = r_ & w_;
                }
                // CQL 'and' (476:26-476:124): right operand skipped when left is false
                if (s_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> x_ = C?.Item;

                    bool? y_(Claim.ItemComponent I) {
                        List<ResourceReference> aa_ = I?.Encounter;
                        bool? ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aa_, E);
                        return ab_;
                    }

                    bool? z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                    return s_ & z_;
                }
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim @this) {
                List<Claim.ProcedureComponent> ac_ = @this?.Procedure;
                return !((bool?)(ac_ is null));
            }


            List<Claim.ProcedureComponent> i_(Claim @this) {
                List<Claim.ProcedureComponent> ad_ = @this?.Procedure;
                return ad_;
            }

            IEnumerable<List<Claim.ProcedureComponent>> j_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(g_, h_, i_);
            IEnumerable<Claim.ProcedureComponent> k_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)j_);

            bool? l_(Claim.ProcedureComponent P) {
                PositiveInt ae_ = P?.SequenceElement;
                int? af_ = ae_?.Value;
                IEnumerable<Claim> ag_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ah_(Claim C) {
                    Code<FinancialResourceStatusCodes> au_ = C?.StatusElement;
                    FinancialResourceStatusCodes? av_ = au_?.Value;
                    Code<FinancialResourceStatusCodes> aw_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(av_);
                    bool? ax_ = context.Operators.Equal(aw_, "active");
                    bool? ay_;
                    // CQL 'and' (476:32-476:70): right operand skipped when left is false
                    if (ax_ is false)
                    {
                        ay_ = false;
                    }
                    else
                    {
                        Code<ClaimUseCode> az_ = C?.UseElement;
                        ClaimUseCode? ba_ = az_?.Value;
                        Code<ClaimUseCode> bb_ = context.Operators.Convert<Code<ClaimUseCode>>(ba_);
                        bool? bc_ = context.Operators.Equal(bb_, "claim");
                        ay_ = ax_ & bc_;
                    }
                    // CQL 'and' (476:26-476:124): right operand skipped when left is false
                    if (ay_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<Claim.ItemComponent> bd_ = C?.Item;

                        bool? be_(Claim.ItemComponent I) {
                            List<ResourceReference> bg_ = I?.Encounter;
                            bool? bh_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bg_, E);
                            return bh_;
                        }

                        bool? bf_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bd_, be_);
                        return ay_ & bf_;
                    }
                }

                IEnumerable<Claim> ai_ = context.Operators.Where<Claim>(ag_, ah_);

                bool? aj_(Claim @this) {
                    List<Claim.ItemComponent> bi_ = @this?.Item;
                    return !((bool?)(bi_ is null));
                }


                List<Claim.ItemComponent> ak_(Claim @this) {
                    List<Claim.ItemComponent> bj_ = @this?.Item;
                    return bj_;
                }

                IEnumerable<List<Claim.ItemComponent>> al_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ai_, aj_, ak_);
                IEnumerable<Claim.ItemComponent> am_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)al_);

                bool? an_(Claim.ItemComponent I) {
                    List<ResourceReference> bk_ = I?.Encounter;
                    bool? bl_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bk_, E);
                    return bl_;
                }

                IEnumerable<Claim.ItemComponent> ao_ = context.Operators.Where<Claim.ItemComponent>(am_, an_);

                bool? ap_(Claim.ItemComponent @this) {
                    List<PositiveInt> bm_ = @this?.ProcedureSequenceElement;

                    int? bn_(PositiveInt @this) {
                        int? bp_ = @this?.Value;
                        return bp_;
                    }

                    IEnumerable<int?> bo_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bm_, bn_);
                    return !((bool?)(bo_ is null));
                }


                IEnumerable<int?> aq_(Claim.ItemComponent @this) {
                    List<PositiveInt> bq_ = @this?.ProcedureSequenceElement;

                    int? br_(PositiveInt @this) {
                        int? bt_ = @this?.Value;
                        return bt_;
                    }

                    IEnumerable<int?> bs_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bq_, br_);
                    return bs_;
                }

                IEnumerable<IEnumerable<int?>> ar_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ao_, ap_, aq_);
                IEnumerable<int?> as_ = context.Operators.Flatten<int?>(ar_);
                bool? at_ = context.Operators.In<int?>(af_, as_);
                // CQL 'and' (478:59-478:150): right operand skipped when left is false
                if (at_ is false)
                {
                    return false;
                }
                else
                {
                    List<CodeableConcept> bu_ = P?.Type;

                    CqlConcept bv_(CodeableConcept @this) {
                        CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return bz_;
                    }

                    IEnumerable<CqlConcept> bw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bu_, bv_);
                    CqlCode bx_ = this.Primary_procedure(context);
                    bool? by_ = QICoreCommon_4_0_000.Instance.includesCode(context, bw_, bx_);
                    return at_ & by_;
                }
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
